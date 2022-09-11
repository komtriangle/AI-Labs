/* file "GeometryAbstractShapeCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryAbstractShapeCommandJSON : GeometryCommandJSON
  {
    private bool flagHasAbstractShapeName;
    private string storeAbstractShapeName;
    private bool flagHasConcreteShapeTypes;
    private List< string > storeConcreteShapeTypes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAbstractShapeNameToJSON()
      {
        JSONStringValue generated_string_AbstractShapeName = new JSONStringValue(storeAbstractShapeName);
        return generated_string_AbstractShapeName;
      }

    private JSONValue  extraConcreteShapeTypesToJSON()
      {
        JSONArrayValue generated_array_1_ConcreteShapeTypes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeConcreteShapeTypes.Count; ++num1)
          {
            JSONStringValue generated_string_ConcreteShapeTypes = new JSONStringValue(storeConcreteShapeTypes[num1]);
            generated_array_1_ConcreteShapeTypes.appendComponent(generated_string_ConcreteShapeTypes);
          }
        return generated_array_1_ConcreteShapeTypes;
      }


    private void  fromJSONAbstractShapeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AbstractShapeName of GeometryAbstractShapeCommandJSON is not a string.");
        setAbstractShapeName(json_string.getData());
      }


    private void  fromJSONConcreteShapeTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ConcreteShapeTypes of GeometryAbstractShapeCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ConcreteShapeTypes1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ConcreteShapeTypes of GeometryAbstractShapeCommandJSON is not a string.");
            vector_ConcreteShapeTypes1.Add(json_string.getData());
          }
        initConcreteShapeTypes();
        for (int num1 = 0; num1 < vector_ConcreteShapeTypes1.Count; ++num1)
            appendConcreteShapeTypes(vector_ConcreteShapeTypes1[num1]);
        for (int num1 = 0; num1 < vector_ConcreteShapeTypes1.Count; ++num1)
          {
          }
      }


    public GeometryAbstractShapeCommandJSON()
      {
        flagHasAbstractShapeName = false;
        flagHasConcreteShapeTypes = false;
        storeConcreteShapeTypes = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getGeometryCommandKind()
      {
        return "GeometryAbstractShapeCommand";
      }

    public bool  hasAbstractShapeName()
      {
        return flagHasAbstractShapeName;
      }

    public string  getAbstractShapeName()
      {
        Debug.Assert(flagHasAbstractShapeName);
        return storeAbstractShapeName;
      }

    public bool  hasConcreteShapeTypes()
      {
        return flagHasConcreteShapeTypes;
      }

    public int  countOfConcreteShapeTypes()
      {
        Debug.Assert(flagHasConcreteShapeTypes);
        return storeConcreteShapeTypes.Count;
      }

    public string  elementOfConcreteShapeTypes(int element_num)
      {
        Debug.Assert(flagHasConcreteShapeTypes);
        return storeConcreteShapeTypes[element_num];
      }

    public List< string >  getConcreteShapeTypes()
      {
        Debug.Assert(flagHasConcreteShapeTypes);
        return storeConcreteShapeTypes;
      }


    public virtual int extraGeometryAbstractShapeCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryAbstractShapeCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryAbstractShapeCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryAbstractShapeCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeometryCommandComponentCount()
      {
        int result = 0;
        if (flagHasAbstractShapeName)
            ++result;
        if (flagHasConcreteShapeTypes)
            ++result;
        result += extraGeometryAbstractShapeCommandComponentCount();
        return result;
      }
    public override string extraGeometryCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAbstractShapeName)
          {
            if (remainder == 0)
                return "AbstractShapeName";
            --remainder;
          }
        if (flagHasConcreteShapeTypes)
          {
            if (remainder == 0)
                return "ConcreteShapeTypes";
            --remainder;
          }
        return extraGeometryAbstractShapeCommandComponentKey(remainder);
      }
    public override JSONValue extraGeometryCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAbstractShapeName)
          {
            if (remainder == 0)
                return extraAbstractShapeNameToJSON();
            --remainder;
          }
        if (flagHasConcreteShapeTypes)
          {
            if (remainder == 0)
                return extraConcreteShapeTypesToJSON();
            --remainder;
          }
        return extraGeometryAbstractShapeCommandComponentValue(remainder);
      }
    public override JSONValue extraGeometryCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "bstractShapeName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasAbstractShapeName ? extraAbstractShapeNameToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "oncreteShapeTypes", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasConcreteShapeTypes ? extraConcreteShapeTypesToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeometryAbstractShapeCommandLookup(field_name);
      }

    public void setAbstractShapeName(string new_value)
      {
        flagHasAbstractShapeName = true;
        storeAbstractShapeName = new_value;
      }
    public void unsetAbstractShapeName()
      {
        flagHasAbstractShapeName = false;
      }
    public void initConcreteShapeTypes()
      {
        flagHasConcreteShapeTypes = true;
        storeConcreteShapeTypes.Clear();
      }
    public void appendConcreteShapeTypes(string to_append)
      {
        if (!flagHasConcreteShapeTypes)
          {
            flagHasConcreteShapeTypes = true;
            storeConcreteShapeTypes.Clear();
          }
        Debug.Assert(flagHasConcreteShapeTypes);
        storeConcreteShapeTypes.Add(to_append);
      }
    public void unsetConcreteShapeTypes()
      {
        flagHasConcreteShapeTypes = false;
        storeConcreteShapeTypes.Clear();
      }

    public virtual void extraGeometryAbstractShapeCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryAbstractShapeCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryAbstractShapeCommandLookup(key);
        if (old_field == null)
          {
            extraGeometryAbstractShapeCommandAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "bstractShapeName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONAbstractShapeName(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "oncreteShapeTypes", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONConcreteShapeTypes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryAbstractShapeCommandAppendPair(key, new_component);
      }
    public override void extraGeometryCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "bstractShapeName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONAbstractShapeName(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "oncreteShapeTypes", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONConcreteShapeTypes(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryAbstractShapeCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAbstractShapeName);
        if (flagHasAbstractShapeName)
          {
            handler.start_pair("AbstractShapeName");
            handler.string_value(storeAbstractShapeName);
          }
        Debug.Assert(partial_allowed || flagHasConcreteShapeTypes);
        if (flagHasConcreteShapeTypes)
          {
            handler.start_pair("ConcreteShapeTypes");
            handler.start_array();
            for (int num1 = 0; num1 < storeConcreteShapeTypes.Count; ++num1)
              {
                handler.string_value(storeConcreteShapeTypes[num1]);
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
        if (!(hasAbstractShapeName()))
          {
            return "When parsing the object for %what%, the \"AbstractShapeName\" field was missing.";
          }
        if (!(hasConcreteShapeTypes()))
          {
            return "When parsing the object for %what%, the \"ConcreteShapeTypes\" field was missing.";
          }
        return null;
      }

    public static new GeometryAbstractShapeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryAbstractShapeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryAbstractShapeCommand", ignore_extras);
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
    public static new GeometryAbstractShapeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryAbstractShapeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryAbstractShapeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryAbstractShapeCommand", ignore_extras);
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
    public static new GeometryAbstractShapeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryAbstractShapeCommandJSON from_text(string text, bool ignore_extras)
      {
        GeometryAbstractShapeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryAbstractShapeCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryAbstractShapeCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeometryAbstractShapeCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryAbstractShapeCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryAbstractShapeCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeometryCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorAbstractShapeName;
        private JSONHoldingStringArrayGenerator fieldGeneratorConcreteShapeTypes;
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
            if (!(getGeometryCommandJSONKey().Equals("GeometryAbstractShapeCommand")))
                throw new Exception("The key field has a value other than `GeometryAbstractShapeCommand'.");
            GeometryAbstractShapeCommandJSON result = new GeometryAbstractShapeCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryAbstractShapeCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeometryCommandJSON new_result)
          {
            handle_result((GeometryAbstractShapeCommandJSON )new_result);
          }
        protected void finish(GeometryAbstractShapeCommandJSON result)
          {
            if (fieldGeneratorAbstractShapeName.have_value)
              {
                result.setAbstractShapeName(fieldGeneratorAbstractShapeName.value);
                fieldGeneratorAbstractShapeName.have_value = false;
              }
            else if ((!(result.hasAbstractShapeName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AbstractShapeName\" field was missing.");
              }
            if (fieldGeneratorConcreteShapeTypes.have_value)
              {
                result.initConcreteShapeTypes();
                int count = fieldGeneratorConcreteShapeTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendConcreteShapeTypes(fieldGeneratorConcreteShapeTypes.value[num]);
                  }
                fieldGeneratorConcreteShapeTypes.value.Clear();
                fieldGeneratorConcreteShapeTypes.have_value = false;
              }
            else if ((!(result.hasConcreteShapeTypes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConcreteShapeTypes\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeometryAbstractShapeCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "bstractShapeName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorAbstractShapeName;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "oncreteShapeTypes", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorConcreteShapeTypes;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAbstractShapeName = new JSONHoldingStringGenerator("field \"AbstractShapeName\" of the GeometryAbstractShapeCommand class");
            fieldGeneratorConcreteShapeTypes = new JSONHoldingStringArrayGenerator("field \"ConcreteShapeTypes\" of the GeometryAbstractShapeCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryAbstractShapeCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAbstractShapeName = new JSONHoldingStringGenerator("field \"AbstractShapeName\" of the GeometryAbstractShapeCommand class");
            fieldGeneratorConcreteShapeTypes = new JSONHoldingStringArrayGenerator("field \"ConcreteShapeTypes\" of the GeometryAbstractShapeCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryAbstractShapeCommand class");
          }

        public override void reset()
          {
            fieldGeneratorAbstractShapeName.reset();
            fieldGeneratorConcreteShapeTypes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryAbstractShapeCommandJSON  result)
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
        public GeometryAbstractShapeCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryAbstractShapeCommandJSON  result)
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
    protected virtual void handle_result(List<GeometryAbstractShapeCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryAbstractShapeCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryAbstractShapeCommandJSON>();
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
    public List<GeometryAbstractShapeCommandJSON> value;
  };
  };
