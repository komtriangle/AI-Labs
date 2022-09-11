/* file "GeometryShapePropertyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryShapePropertyJSON : JSONBase
  {
    private bool flagHasPropertyName;
    private string storePropertyName;
    private bool flagHasPropertyValue;
    private AmountJSON  storePropertyValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPropertyName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PropertyName of GeometryShapePropertyJSON is not a string.");
        setPropertyName(json_string.getData());
      }


    private void  fromJSONPropertyValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPropertyValue(convert_classy);
      }


    public GeometryShapePropertyJSON()
      {
        flagHasPropertyName = false;
        flagHasPropertyValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPropertyName()
      {
        return flagHasPropertyName;
      }

    public string  getPropertyName()
      {
        Debug.Assert(flagHasPropertyName);
        return storePropertyName;
      }

    public bool  hasPropertyValue()
      {
        return flagHasPropertyValue;
      }

    public AmountJSON   getPropertyValue()
      {
        Debug.Assert(flagHasPropertyValue);
        return storePropertyValue;
      }


    public virtual int extraGeometryShapePropertyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryShapePropertyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPropertyName(string new_value)
      {
        flagHasPropertyName = true;
        storePropertyName = new_value;
      }
    public void unsetPropertyName()
      {
        flagHasPropertyName = false;
      }
    public void setPropertyValue(AmountJSON  new_value)
      {
        if (flagHasPropertyValue)
          {
          }
        flagHasPropertyValue = true;
        storePropertyValue = new_value;
      }
    public void unsetPropertyValue()
      {
        if (flagHasPropertyValue)
          {
          }
        flagHasPropertyValue = false;
      }

    public virtual void extraGeometryShapePropertyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryShapePropertySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryShapePropertyLookup(key);
        if (old_field == null)
          {
            extraGeometryShapePropertyAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPropertyName);
        if (flagHasPropertyName)
          {
            handler.start_pair("PropertyName");
            handler.string_value(storePropertyName);
          }
        if (flagHasPropertyValue)
          {
            handler.start_pair("PropertyValue");
            if (partial_allowed)
                storePropertyValue.write_partial_as_json(handler);
            else
                storePropertyValue.write_as_json(handler);
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
        if (!(hasPropertyName()))
          {
            return "When parsing the object for %what%, the \"PropertyName\" field was missing.";
          }
        return null;
      }

    public static GeometryShapePropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapeProperty", ignore_extras);
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
    public static GeometryShapePropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeometryShapePropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapeProperty", ignore_extras);
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
    public static GeometryShapePropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeometryShapePropertyJSON from_text(string text, bool ignore_extras)
      {
        GeometryShapePropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapeProperty", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryShapePropertyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeometryShapePropertyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryShapePropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapeProperty", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPropertyName;
        private AmountJSON.HoldingGenerator fieldGeneratorPropertyValue;
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
            GeometryShapePropertyJSON result = new GeometryShapePropertyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryShapePropertyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GeometryShapePropertyJSON result)
          {
            if (fieldGeneratorPropertyName.have_value)
              {
                result.setPropertyName(fieldGeneratorPropertyName.value);
                fieldGeneratorPropertyName.have_value = false;
              }
            else if ((!(result.hasPropertyName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PropertyName\" field was missing.");
              }
            if (fieldGeneratorPropertyValue.have_value)
              {
                result.setPropertyValue(fieldGeneratorPropertyValue.value);
                fieldGeneratorPropertyValue.have_value = false;
              }
          }
        protected abstract void handle_result(GeometryShapePropertyJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Property", 0, 8, false) == 0)
              {
                switch (field_name[8])
                  {
                    case 'N':
                        if ((String.Compare(field_name, 9, "ame", 0, 3, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorPropertyName;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 9, "alue", 0, 4, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorPropertyValue;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPropertyName = new JSONHoldingStringGenerator("field \"PropertyName\" of the GeometryShapeProperty class");
            fieldGeneratorPropertyValue = new AmountJSON.HoldingGenerator("field \"PropertyValue\" of the GeometryShapeProperty class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryShapeProperty class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPropertyName = new JSONHoldingStringGenerator("field \"PropertyName\" of the GeometryShapeProperty class");
            fieldGeneratorPropertyValue = new AmountJSON.HoldingGenerator("field \"PropertyValue\" of the GeometryShapeProperty class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryShapeProperty class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPropertyName.reset();
            fieldGeneratorPropertyValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPropertyValue.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPropertyValue.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryShapePropertyJSON  result)
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
        public GeometryShapePropertyJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryShapePropertyJSON  result)
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
    protected virtual void handle_result(List<GeometryShapePropertyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryShapePropertyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryShapePropertyJSON>();
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
    public List<GeometryShapePropertyJSON> value;
  };
  };
