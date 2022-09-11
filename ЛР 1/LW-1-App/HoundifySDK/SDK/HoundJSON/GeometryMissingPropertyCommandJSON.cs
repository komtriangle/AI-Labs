/* file "GeometryMissingPropertyCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryMissingPropertyCommandJSON : GeometryCommandJSON
  {
    private bool flagHasShapeName;
    private string storeShapeName;
    private bool flagHasGivenProperties;
    private List< GeometryShapePropertyJSON  > storeGivenProperties;
    private bool flagHasRequestedProperty;
    private GeometryShapePropertyJSON  storeRequestedProperty;
    private bool flagHasMissingProperty;
    private GeometryShapePropertyJSON  storeMissingProperty;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraShapeNameToJSON()
      {
        JSONStringValue generated_string_ShapeName = new JSONStringValue(storeShapeName);
        return generated_string_ShapeName;
      }

    private JSONValue  extraGivenPropertiesToJSON()
      {
        JSONArrayValue generated_array_1_GivenProperties = new JSONArrayValue();
        for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
          {
            JSONValueHandler handler_GivenProperties = new JSONValueHandler();
            storeGivenProperties[num1].write_as_json(handler_GivenProperties);
            generated_array_1_GivenProperties.appendComponent(handler_GivenProperties.result);
          }
        return generated_array_1_GivenProperties;
      }

    private JSONValue  extraRequestedPropertyToJSON()
      {
        JSONValueHandler handler_RequestedProperty = new JSONValueHandler();
        storeRequestedProperty.write_as_json(handler_RequestedProperty);
        return handler_RequestedProperty.result;
      }

    private JSONValue  extraMissingPropertyToJSON()
      {
        JSONValueHandler handler_MissingProperty = new JSONValueHandler();
        storeMissingProperty.write_as_json(handler_MissingProperty);
        return handler_MissingProperty.result;
      }


    private void  fromJSONShapeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShapeName of GeometryMissingPropertyCommandJSON is not a string.");
        setShapeName(json_string.getData());
      }


    private void  fromJSONGivenProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GivenProperties of GeometryMissingPropertyCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GivenProperties of GeometryMissingPropertyCommandJSON has too few elements.");
        List< GeometryShapePropertyJSON  > vector_GivenProperties1 = new List< GeometryShapePropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GivenProperties1.Add(convert_classy);
          }
        Debug.Assert(vector_GivenProperties1.Count >= 1);
        initGivenProperties();
        for (int num1 = 0; num1 < vector_GivenProperties1.Count; ++num1)
            appendGivenProperties(vector_GivenProperties1[num1]);
        for (int num1 = 0; num1 < vector_GivenProperties1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_value, ignore_extras, true);
        setRequestedProperty(convert_classy);
      }


    private void  fromJSONMissingProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_value, ignore_extras, true);
        setMissingProperty(convert_classy);
      }


    public GeometryMissingPropertyCommandJSON()
      {
        flagHasShapeName = false;
        flagHasGivenProperties = false;
        flagHasRequestedProperty = false;
        flagHasMissingProperty = false;
        storeGivenProperties = new List< GeometryShapePropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getGeometryCommandKind()
      {
        return "GeometryMissingPropertyCommand";
      }

    public bool  hasShapeName()
      {
        return flagHasShapeName;
      }

    public string  getShapeName()
      {
        Debug.Assert(flagHasShapeName);
        return storeShapeName;
      }

    public bool  hasGivenProperties()
      {
        return flagHasGivenProperties;
      }

    public int  countOfGivenProperties()
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties.Count;
      }

    public GeometryShapePropertyJSON   elementOfGivenProperties(int element_num)
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties[element_num];
      }

    public List< GeometryShapePropertyJSON  >  getGivenProperties()
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties;
      }

    public bool  hasRequestedProperty()
      {
        return flagHasRequestedProperty;
      }

    public GeometryShapePropertyJSON   getRequestedProperty()
      {
        Debug.Assert(flagHasRequestedProperty);
        return storeRequestedProperty;
      }

    public bool  hasMissingProperty()
      {
        return flagHasMissingProperty;
      }

    public GeometryShapePropertyJSON   getMissingProperty()
      {
        Debug.Assert(flagHasMissingProperty);
        return storeMissingProperty;
      }


    public virtual int extraGeometryMissingPropertyCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryMissingPropertyCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryMissingPropertyCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryMissingPropertyCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeometryCommandComponentCount()
      {
        int result = 0;
        if (flagHasShapeName)
            ++result;
        if (flagHasGivenProperties)
            ++result;
        if (flagHasRequestedProperty)
            ++result;
        if (flagHasMissingProperty)
            ++result;
        result += extraGeometryMissingPropertyCommandComponentCount();
        return result;
      }
    public override string extraGeometryCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasShapeName)
          {
            if (remainder == 0)
                return "ShapeName";
            --remainder;
          }
        if (flagHasGivenProperties)
          {
            if (remainder == 0)
                return "GivenProperties";
            --remainder;
          }
        if (flagHasRequestedProperty)
          {
            if (remainder == 0)
                return "RequestedProperty";
            --remainder;
          }
        if (flagHasMissingProperty)
          {
            if (remainder == 0)
                return "MissingProperty";
            --remainder;
          }
        return extraGeometryMissingPropertyCommandComponentKey(remainder);
      }
    public override JSONValue extraGeometryCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasShapeName)
          {
            if (remainder == 0)
                return extraShapeNameToJSON();
            --remainder;
          }
        if (flagHasGivenProperties)
          {
            if (remainder == 0)
                return extraGivenPropertiesToJSON();
            --remainder;
          }
        if (flagHasRequestedProperty)
          {
            if (remainder == 0)
                return extraRequestedPropertyToJSON();
            --remainder;
          }
        if (flagHasMissingProperty)
          {
            if (remainder == 0)
                return extraMissingPropertyToJSON();
            --remainder;
          }
        return extraGeometryMissingPropertyCommandComponentValue(remainder);
      }
    public override JSONValue extraGeometryCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'G':
                if ((String.Compare(field_name, 1, "ivenProperties", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasGivenProperties ? extraGivenPropertiesToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "issingProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasMissingProperty ? extraMissingPropertyToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedProperty", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasRequestedProperty ? extraRequestedPropertyToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "hapeName", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasShapeName ? extraShapeNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeometryMissingPropertyCommandLookup(field_name);
      }

    public void setShapeName(string new_value)
      {
        flagHasShapeName = true;
        storeShapeName = new_value;
      }
    public void unsetShapeName()
      {
        flagHasShapeName = false;
      }
    public void initGivenProperties()
      {
        if (flagHasGivenProperties)
          {
            for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
              {
              }
          }
        flagHasGivenProperties = true;
        storeGivenProperties.Clear();
      }
    public void appendGivenProperties(GeometryShapePropertyJSON  to_append)
      {
        if (!flagHasGivenProperties)
          {
            flagHasGivenProperties = true;
            storeGivenProperties.Clear();
          }
        Debug.Assert(flagHasGivenProperties);
        storeGivenProperties.Add(to_append);
      }
    public void unsetGivenProperties()
      {
        if (flagHasGivenProperties)
          {
            for (int num2 = 0; num2 < storeGivenProperties.Count; ++num2)
              {
              }
          }
        flagHasGivenProperties = false;
        storeGivenProperties.Clear();
      }
    public void setRequestedProperty(GeometryShapePropertyJSON  new_value)
      {
        if (flagHasRequestedProperty)
          {
          }
        flagHasRequestedProperty = true;
        storeRequestedProperty = new_value;
      }
    public void unsetRequestedProperty()
      {
        if (flagHasRequestedProperty)
          {
          }
        flagHasRequestedProperty = false;
      }
    public void setMissingProperty(GeometryShapePropertyJSON  new_value)
      {
        if (flagHasMissingProperty)
          {
          }
        flagHasMissingProperty = true;
        storeMissingProperty = new_value;
      }
    public void unsetMissingProperty()
      {
        if (flagHasMissingProperty)
          {
          }
        flagHasMissingProperty = false;
      }

    public virtual void extraGeometryMissingPropertyCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryMissingPropertyCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryMissingPropertyCommandLookup(key);
        if (old_field == null)
          {
            extraGeometryMissingPropertyCommandAppendPair(key, new_component);
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
    public override void extraGeometryCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'G':
                if ((String.Compare(key, 1, "ivenProperties", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONGivenProperties(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "issingProperty", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONMissingProperty(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedProperty", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONRequestedProperty(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "hapeName", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONShapeName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryMissingPropertyCommandAppendPair(key, new_component);
      }
    public override void extraGeometryCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'G':
                if ((String.Compare(key, 1, "ivenProperties", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONGivenProperties(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "issingProperty", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONMissingProperty(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedProperty", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONRequestedProperty(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "hapeName", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONShapeName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryMissingPropertyCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasShapeName);
        if (flagHasShapeName)
          {
            handler.start_pair("ShapeName");
            handler.string_value(storeShapeName);
          }
        if (flagHasGivenProperties)
          {
            handler.start_pair("GivenProperties");
            Debug.Assert(storeGivenProperties.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
              {
                if (partial_allowed)
                    storeGivenProperties[num1].write_partial_as_json(handler);
                else
                    storeGivenProperties[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRequestedProperty)
          {
            handler.start_pair("RequestedProperty");
            if (partial_allowed)
                storeRequestedProperty.write_partial_as_json(handler);
            else
                storeRequestedProperty.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasMissingProperty);
        if (flagHasMissingProperty)
          {
            handler.start_pair("MissingProperty");
            if (partial_allowed)
                storeMissingProperty.write_partial_as_json(handler);
            else
                storeMissingProperty.write_as_json(handler);
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
        if (!(hasShapeName()))
          {
            return "When parsing the object for %what%, the \"ShapeName\" field was missing.";
          }
        if (!(hasMissingProperty()))
          {
            return "When parsing the object for %what%, the \"MissingProperty\" field was missing.";
          }
        return null;
      }

    public static new GeometryMissingPropertyCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryMissingPropertyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryMissingPropertyCommand", ignore_extras);
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
    public static new GeometryMissingPropertyCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryMissingPropertyCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryMissingPropertyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryMissingPropertyCommand", ignore_extras);
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
    public static new GeometryMissingPropertyCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryMissingPropertyCommandJSON from_text(string text, bool ignore_extras)
      {
        GeometryMissingPropertyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryMissingPropertyCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryMissingPropertyCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeometryMissingPropertyCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryMissingPropertyCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryMissingPropertyCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeometryCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorShapeName;
        private GeometryShapePropertyJSON.HoldingArrayGenerator fieldGeneratorGivenProperties;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorRequestedProperty;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorMissingProperty;
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
            if (!(getGeometryCommandJSONKey().Equals("GeometryMissingPropertyCommand")))
                throw new Exception("The key field has a value other than `GeometryMissingPropertyCommand'.");
            GeometryMissingPropertyCommandJSON result = new GeometryMissingPropertyCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryMissingPropertyCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeometryCommandJSON new_result)
          {
            handle_result((GeometryMissingPropertyCommandJSON )new_result);
          }
        protected void finish(GeometryMissingPropertyCommandJSON result)
          {
            if (fieldGeneratorShapeName.have_value)
              {
                result.setShapeName(fieldGeneratorShapeName.value);
                fieldGeneratorShapeName.have_value = false;
              }
            else if ((!(result.hasShapeName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShapeName\" field was missing.");
              }
            if (fieldGeneratorGivenProperties.have_value)
              {
                result.initGivenProperties();
                int count = fieldGeneratorGivenProperties.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGivenProperties(fieldGeneratorGivenProperties.value[num]);
                  }
                fieldGeneratorGivenProperties.value.Clear();
                fieldGeneratorGivenProperties.have_value = false;
              }
            if (fieldGeneratorRequestedProperty.have_value)
              {
                result.setRequestedProperty(fieldGeneratorRequestedProperty.value);
                fieldGeneratorRequestedProperty.have_value = false;
              }
            if (fieldGeneratorMissingProperty.have_value)
              {
                result.setMissingProperty(fieldGeneratorMissingProperty.value);
                fieldGeneratorMissingProperty.have_value = false;
              }
            else if ((!(result.hasMissingProperty())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MissingProperty\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeometryMissingPropertyCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "ivenProperties", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorGivenProperties;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "issingProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorMissingProperty;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedProperty", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorRequestedProperty;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "hapeName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorShapeName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryMissingPropertyCommand class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryMissingPropertyCommand class", ignore_extras);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryMissingPropertyCommand class", ignore_extras);
            fieldGeneratorMissingProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"MissingProperty\" of the GeometryMissingPropertyCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryMissingPropertyCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryMissingPropertyCommand class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryMissingPropertyCommand class", false);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryMissingPropertyCommand class", false);
            fieldGeneratorMissingProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"MissingProperty\" of the GeometryMissingPropertyCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryMissingPropertyCommand class");
          }

        public override void reset()
          {
            fieldGeneratorShapeName.reset();
            fieldGeneratorGivenProperties.reset();
            fieldGeneratorRequestedProperty.reset();
            fieldGeneratorMissingProperty.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryMissingPropertyCommandJSON  result)
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
        public GeometryMissingPropertyCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryMissingPropertyCommandJSON  result)
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
    protected virtual void handle_result(List<GeometryMissingPropertyCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryMissingPropertyCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryMissingPropertyCommandJSON>();
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
    public List<GeometryMissingPropertyCommandJSON> value;
  };
  };
