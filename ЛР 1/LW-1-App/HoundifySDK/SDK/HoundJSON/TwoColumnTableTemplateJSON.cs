/* file "TwoColumnTableTemplateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TwoColumnTableTemplateJSON : TemplateJSON
  {
    public class TypeRowsJSON : JSONBase
      {
        private bool flagHasLeftText;
        private string storeLeftText;
        private bool flagHasRightText;
        private string storeRightText;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONLeftText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LeftText of TypeRowsJSON is not a string.");
            setLeftText(json_string.getData());
          }


        private void  fromJSONRightText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RightText of TypeRowsJSON is not a string.");
            setRightText(json_string.getData());
          }


        public TypeRowsJSON()
          {
            flagHasLeftText = false;
            flagHasRightText = false;
            storeLeftText = "";
            storeRightText = "";
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasLeftText()
          {
            return flagHasLeftText;
          }

        public string  getLeftText()
          {
            return storeLeftText;
          }

        public bool  hasRightText()
          {
            return flagHasRightText;
          }

        public string  getRightText()
          {
            return storeRightText;
          }


        public virtual int extraTypeRowsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRowsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRowsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRowsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setLeftText(string new_value)
          {
            flagHasLeftText = true;
            storeLeftText = new_value;
          }
        public void unsetLeftText()
          {
            flagHasLeftText = false;
          }
        public void setRightText(string new_value)
          {
            flagHasRightText = true;
            storeRightText = new_value;
          }
        public void unsetRightText()
          {
            flagHasRightText = false;
          }

        public virtual void extraTypeRowsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRowsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRowsLookup(key);
            if (old_field == null)
              {
                extraTypeRowsAppendPair(key, new_component);
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
            if (flagHasLeftText)
              {
                handler.start_pair("LeftText");
                handler.string_value(storeLeftText);
              }
            if (flagHasRightText)
              {
                handler.start_pair("RightText");
                handler.string_value(storeRightText);
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

        public static TypeRowsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRows", ignore_extras);
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
        public static TypeRowsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRowsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRows", ignore_extras);
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
        public static TypeRowsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRowsJSON from_text(string text, bool ignore_extras)
          {
            TypeRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRows", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRowsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRowsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRowsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRows", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLeftText;
            private JSONHoldingStringGenerator fieldGeneratorRightText;
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
                TypeRowsJSON result = new TypeRowsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRowsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRowsJSON result)
              {
                if (fieldGeneratorLeftText.have_value)
                  {
                    result.setLeftText(fieldGeneratorLeftText.value);
                    fieldGeneratorLeftText.have_value = false;
                  }
                if (fieldGeneratorRightText.have_value)
                  {
                    result.setRightText(fieldGeneratorRightText.value);
                    fieldGeneratorRightText.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeRowsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "eftText", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorLeftText;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ightText", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorRightText;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLeftText = new JSONHoldingStringGenerator("field \"LeftText\" of the TypeRows class");
                fieldGeneratorRightText = new JSONHoldingStringGenerator("field \"RightText\" of the TypeRows class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRows class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLeftText = new JSONHoldingStringGenerator("field \"LeftText\" of the TypeRows class");
                fieldGeneratorRightText = new JSONHoldingStringGenerator("field \"RightText\" of the TypeRows class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRows class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLeftText.reset();
                fieldGeneratorRightText.reset();
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
            protected override void handle_result(TypeRowsJSON  result)
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
            public TypeRowsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRowsJSON  result)
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
        protected virtual void handle_result(List<TypeRowsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRowsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRowsJSON>();
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
        public List<TypeRowsJSON> value;
      };
      };
    private bool flagHasRows;
    private List< TypeRowsJSON  > storeRows;
    private bool flagHasActionAndroidIntent;
    private AndroidIntentJSON  storeActionAndroidIntent;
    private bool flagHasActionURIs;
    private List< string > storeActionURIs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRowsToJSON()
      {
        JSONArrayValue generated_array_1_Rows = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRows.Count; ++num1)
          {
            JSONValueHandler handler_Rows = new JSONValueHandler();
            storeRows[num1].write_as_json(handler_Rows);
            generated_array_1_Rows.appendComponent(handler_Rows.result);
          }
        return generated_array_1_Rows;
      }

    private JSONValue  extraActionAndroidIntentToJSON()
      {
        JSONValueHandler handler_ActionAndroidIntent = new JSONValueHandler();
        storeActionAndroidIntent.write_as_json(handler_ActionAndroidIntent);
        return handler_ActionAndroidIntent.result;
      }

    private JSONValue  extraActionURIsToJSON()
      {
        JSONArrayValue generated_array_2_ActionURIs = new JSONArrayValue();
        for (int num2 = 0; num2 < storeActionURIs.Count; ++num2)
          {
            JSONStringValue generated_string_ActionURIs = new JSONStringValue(storeActionURIs[num2]);
            generated_array_2_ActionURIs.appendComponent(generated_string_ActionURIs);
          }
        return generated_array_2_ActionURIs;
      }


    private void  fromJSONRows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rows of TwoColumnTableTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Rows of TwoColumnTableTemplateJSON has too few elements.");
        List< TypeRowsJSON  > vector_Rows1 = new List< TypeRowsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeRowsJSON convert_classy = TypeRowsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Rows1.Add(convert_classy);
          }
        Debug.Assert(vector_Rows1.Count >= 1);
        initRows();
        for (int num1 = 0; num1 < vector_Rows1.Count; ++num1)
            appendRows(vector_Rows1[num1]);
        for (int num1 = 0; num1 < vector_Rows1.Count; ++num1)
          {
          }
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
            throw new Exception("The value for field ActionURIs of TwoColumnTableTemplateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ActionURIs of TwoColumnTableTemplateJSON has too few elements.");
        List< string > vector_ActionURIs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ActionURIs of TwoColumnTableTemplateJSON is not a string.");
            vector_ActionURIs1.Add(json_string.getData());
          }
        Debug.Assert(vector_ActionURIs1.Count >= 1);
        initActionURIs();
        for (int num2 = 0; num2 < vector_ActionURIs1.Count; ++num2)
            appendActionURIs(vector_ActionURIs1[num2]);
        for (int num1 = 0; num1 < vector_ActionURIs1.Count; ++num1)
          {
          }
      }


    public TwoColumnTableTemplateJSON()
      {
        flagHasRows = false;
        flagHasActionAndroidIntent = false;
        flagHasActionURIs = false;
        storeRows = new List< TypeRowsJSON  >();
        storeActionURIs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTemplateName()
      {
        return "TwoColumnTable";
      }

    public bool  hasRows()
      {
        return flagHasRows;
      }

    public int  countOfRows()
      {
        Debug.Assert(flagHasRows);
        return storeRows.Count;
      }

    public TypeRowsJSON   elementOfRows(int element_num)
      {
        Debug.Assert(flagHasRows);
        return storeRows[element_num];
      }

    public List< TypeRowsJSON  >  getRows()
      {
        Debug.Assert(flagHasRows);
        return storeRows;
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


    public virtual int extraTwoColumnTableTemplateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTwoColumnTableTemplateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTwoColumnTableTemplateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTwoColumnTableTemplateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTemplateComponentCount()
      {
        int result = 0;
        if (flagHasRows)
            ++result;
        if (flagHasActionAndroidIntent)
            ++result;
        if (flagHasActionURIs)
            ++result;
        result += extraTwoColumnTableTemplateComponentCount();
        return result;
      }
    public override string extraTemplateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRows)
          {
            if (remainder == 0)
                return "Rows";
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
        return extraTwoColumnTableTemplateComponentKey(remainder);
      }
    public override JSONValue extraTemplateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRows)
          {
            if (remainder == 0)
                return extraRowsToJSON();
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
        return extraTwoColumnTableTemplateComponentValue(remainder);
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
            case 'R':
                if ((String.Compare(field_name, 1, "ows", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasRows ? extraRowsToJSON() : null);
                break;
            default:
                break;
          }
        return extraTwoColumnTableTemplateLookup(field_name);
      }

    public void initRows()
      {
        if (flagHasRows)
          {
            for (int num1 = 0; num1 < storeRows.Count; ++num1)
              {
              }
          }
        flagHasRows = true;
        storeRows.Clear();
      }
    public void appendRows(TypeRowsJSON  to_append)
      {
        if (!flagHasRows)
          {
            flagHasRows = true;
            storeRows.Clear();
          }
        Debug.Assert(flagHasRows);
        storeRows.Add(to_append);
      }
    public void unsetRows()
      {
        if (flagHasRows)
          {
            for (int num2 = 0; num2 < storeRows.Count; ++num2)
              {
              }
          }
        flagHasRows = false;
        storeRows.Clear();
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

    public virtual void extraTwoColumnTableTemplateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTwoColumnTableTemplateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTwoColumnTableTemplateLookup(key);
        if (old_field == null)
          {
            extraTwoColumnTableTemplateAppendPair(key, new_component);
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
            case 'R':
                if ((String.Compare(key, 1, "ows", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONRows(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTwoColumnTableTemplateAppendPair(key, new_component);
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
            case 'R':
                if ((String.Compare(key, 1, "ows", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONRows(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTwoColumnTableTemplateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRows);
        if (flagHasRows)
          {
            handler.start_pair("Rows");
            Debug.Assert(storeRows.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeRows.Count; ++num1)
              {
                if (partial_allowed)
                    storeRows[num1].write_partial_as_json(handler);
                else
                    storeRows[num1].write_as_json(handler);
              }
            handler.finish_array();
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
            for (int num2 = 0; num2 < storeActionURIs.Count; ++num2)
              {
                handler.string_value(storeActionURIs[num2]);
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
        if (!(hasRows()))
          {
            return "When parsing the object for %what%, the \"Rows\" field was missing.";
          }
        return null;
      }

    public static new TwoColumnTableTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TwoColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TwoColumnTableTemplate", ignore_extras);
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
    public static new TwoColumnTableTemplateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TwoColumnTableTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TwoColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TwoColumnTableTemplate", ignore_extras);
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
    public static new TwoColumnTableTemplateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TwoColumnTableTemplateJSON from_text(string text, bool ignore_extras)
      {
        TwoColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TwoColumnTableTemplate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TwoColumnTableTemplateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TwoColumnTableTemplateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TwoColumnTableTemplateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TwoColumnTableTemplate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TemplateJSON.Generator
      {
        private TypeRowsJSON.HoldingArrayGenerator fieldGeneratorRows;
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
            if (!(getTemplateJSONKey().Equals("TwoColumnTable")))
                throw new Exception("The key field has a value other than `TwoColumnTable'.");
            TwoColumnTableTemplateJSON result = new TwoColumnTableTemplateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTwoColumnTableTemplateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TemplateJSON new_result)
          {
            handle_result((TwoColumnTableTemplateJSON )new_result);
          }
        protected void finish(TwoColumnTableTemplateJSON result)
          {
            if (fieldGeneratorRows.have_value)
              {
                result.initRows();
                int count = fieldGeneratorRows.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRows(fieldGeneratorRows.value[num]);
                  }
                fieldGeneratorRows.value.Clear();
                fieldGeneratorRows.have_value = false;
              }
            else if ((!(result.hasRows())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Rows\" field was missing.");
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
        protected abstract void handle_result(TwoColumnTableTemplateJSON new_result);
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
                case 'R':
                    if ((String.Compare(field_name, 1, "ows", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRows;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRows = new TypeRowsJSON.HoldingArrayGenerator("field \"Rows\" of the TwoColumnTableTemplate class", ignore_extras);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the TwoColumnTableTemplate class", ignore_extras);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the TwoColumnTableTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TwoColumnTableTemplate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRows = new TypeRowsJSON.HoldingArrayGenerator("field \"Rows\" of the TwoColumnTableTemplate class", false);
            fieldGeneratorActionAndroidIntent = new AndroidIntentJSON.HoldingGenerator("field \"ActionAndroidIntent\" of the TwoColumnTableTemplate class", false);
            fieldGeneratorActionURIs = new JSONHoldingStringArrayGenerator("field \"ActionURIs\" of the TwoColumnTableTemplate class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TwoColumnTableTemplate class");
          }

        public override void reset()
          {
            fieldGeneratorRows.reset();
            fieldGeneratorActionAndroidIntent.reset();
            fieldGeneratorActionURIs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TwoColumnTableTemplateJSON  result)
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
        public TwoColumnTableTemplateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TwoColumnTableTemplateJSON  result)
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
    protected virtual void handle_result(List<TwoColumnTableTemplateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TwoColumnTableTemplateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TwoColumnTableTemplateJSON>();
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
    public List<TwoColumnTableTemplateJSON> value;
  };
  };
