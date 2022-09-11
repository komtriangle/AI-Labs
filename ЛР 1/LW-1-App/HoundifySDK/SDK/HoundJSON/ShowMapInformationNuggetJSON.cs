/* file "ShowMapInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowMapInformationNuggetJSON : MapInformationNuggetJSON
  {
    private bool flagHasMapLocationSpecs;
    private List< MapLocationWithDescriptionJSON  > storeMapLocationSpecs;
    private bool flagHasRequestedCoordinates;
    private bool storeRequestedCoordinates;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMapLocationSpecsToJSON()
      {
        JSONArrayValue generated_array_1_MapLocationSpecs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeMapLocationSpecs.Count; ++num1)
          {
            JSONValueHandler handler_MapLocationSpecs = new JSONValueHandler();
            storeMapLocationSpecs[num1].write_as_json(handler_MapLocationSpecs);
            generated_array_1_MapLocationSpecs.appendComponent(handler_MapLocationSpecs.result);
          }
        return generated_array_1_MapLocationSpecs;
      }

    private JSONValue  extraRequestedCoordinatesToJSON()
      {
        JSONValue generated_boolean_RequestedCoordinates = (storeRequestedCoordinates ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestedCoordinates;
      }


    private void  fromJSONMapLocationSpecs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MapLocationSpecs of ShowMapInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field MapLocationSpecs of ShowMapInformationNuggetJSON has too few elements.");
        List< MapLocationWithDescriptionJSON  > vector_MapLocationSpecs1 = new List< MapLocationWithDescriptionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MapLocationWithDescriptionJSON convert_classy = MapLocationWithDescriptionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MapLocationSpecs1.Add(convert_classy);
          }
        Debug.Assert(vector_MapLocationSpecs1.Count >= 1);
        initMapLocationSpecs();
        for (int num1 = 0; num1 < vector_MapLocationSpecs1.Count; ++num1)
            appendMapLocationSpecs(vector_MapLocationSpecs1[num1]);
        for (int num1 = 0; num1 < vector_MapLocationSpecs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedCoordinates(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestedCoordinates of ShowMapInformationNuggetJSON is not true for false.");
              }
          }
        setRequestedCoordinates(the_bool);
      }


    public ShowMapInformationNuggetJSON()
      {
        flagHasMapLocationSpecs = false;
        flagHasRequestedCoordinates = false;
        storeMapLocationSpecs = new List< MapLocationWithDescriptionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMapNuggetKind()
      {
        return "ShowMap";
      }

    public bool  hasMapLocationSpecs()
      {
        return flagHasMapLocationSpecs;
      }

    public int  countOfMapLocationSpecs()
      {
        Debug.Assert(flagHasMapLocationSpecs);
        return storeMapLocationSpecs.Count;
      }

    public MapLocationWithDescriptionJSON   elementOfMapLocationSpecs(int element_num)
      {
        Debug.Assert(flagHasMapLocationSpecs);
        return storeMapLocationSpecs[element_num];
      }

    public List< MapLocationWithDescriptionJSON  >  getMapLocationSpecs()
      {
        Debug.Assert(flagHasMapLocationSpecs);
        return storeMapLocationSpecs;
      }

    public bool  hasRequestedCoordinates()
      {
        return flagHasRequestedCoordinates;
      }

    public bool  getRequestedCoordinates()
      {
        Debug.Assert(flagHasRequestedCoordinates);
        return storeRequestedCoordinates;
      }


    public virtual int extraShowMapInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowMapInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowMapInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowMapInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMapInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasMapLocationSpecs)
            ++result;
        if (flagHasRequestedCoordinates)
            ++result;
        result += extraShowMapInformationNuggetComponentCount();
        return result;
      }
    public override string extraMapInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMapLocationSpecs)
          {
            if (remainder == 0)
                return "MapLocationSpecs";
            --remainder;
          }
        if (flagHasRequestedCoordinates)
          {
            if (remainder == 0)
                return "RequestedCoordinates";
            --remainder;
          }
        return extraShowMapInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraMapInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMapLocationSpecs)
          {
            if (remainder == 0)
                return extraMapLocationSpecsToJSON();
            --remainder;
          }
        if (flagHasRequestedCoordinates)
          {
            if (remainder == 0)
                return extraRequestedCoordinatesToJSON();
            --remainder;
          }
        return extraShowMapInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraMapInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "apLocationSpecs", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasMapLocationSpecs ? extraMapLocationSpecsToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedCoordinates", 0, 19, false) == 0) && (field_name.Length == 20))
                    return (flagHasRequestedCoordinates ? extraRequestedCoordinatesToJSON() : null);
                break;
            default:
                break;
          }
        return extraShowMapInformationNuggetLookup(field_name);
      }

    public void initMapLocationSpecs()
      {
        if (flagHasMapLocationSpecs)
          {
            for (int num1 = 0; num1 < storeMapLocationSpecs.Count; ++num1)
              {
              }
          }
        flagHasMapLocationSpecs = true;
        storeMapLocationSpecs.Clear();
      }
    public void appendMapLocationSpecs(MapLocationWithDescriptionJSON  to_append)
      {
        if (!flagHasMapLocationSpecs)
          {
            flagHasMapLocationSpecs = true;
            storeMapLocationSpecs.Clear();
          }
        Debug.Assert(flagHasMapLocationSpecs);
        storeMapLocationSpecs.Add(to_append);
      }
    public void unsetMapLocationSpecs()
      {
        if (flagHasMapLocationSpecs)
          {
            for (int num2 = 0; num2 < storeMapLocationSpecs.Count; ++num2)
              {
              }
          }
        flagHasMapLocationSpecs = false;
        storeMapLocationSpecs.Clear();
      }
    public void setRequestedCoordinates(bool new_value)
      {
        flagHasRequestedCoordinates = true;
        storeRequestedCoordinates = new_value;
      }
    public void unsetRequestedCoordinates()
      {
        flagHasRequestedCoordinates = false;
      }

    public virtual void extraShowMapInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowMapInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowMapInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowMapInformationNuggetAppendPair(key, new_component);
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
    public override void extraMapInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "apLocationSpecs", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONMapLocationSpecs(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedCoordinates", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRequestedCoordinates(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowMapInformationNuggetAppendPair(key, new_component);
      }
    public override void extraMapInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "apLocationSpecs", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONMapLocationSpecs(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedCoordinates", 0, 19, false) == 0) && (key.Length == 20))
                    {
                    fromJSONRequestedCoordinates(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowMapInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMapLocationSpecs);
        if (flagHasMapLocationSpecs)
          {
            handler.start_pair("MapLocationSpecs");
            Debug.Assert(storeMapLocationSpecs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeMapLocationSpecs.Count; ++num1)
              {
                if (partial_allowed)
                    storeMapLocationSpecs[num1].write_partial_as_json(handler);
                else
                    storeMapLocationSpecs[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRequestedCoordinates)
          {
            handler.start_pair("RequestedCoordinates");
            handler.boolean_value(storeRequestedCoordinates);
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
        if (!(hasMapLocationSpecs()))
          {
            return "When parsing the object for %what%, the \"MapLocationSpecs\" field was missing.";
          }
        return null;
      }

    public static new ShowMapInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowMapInformationNugget", ignore_extras);
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
    public static new ShowMapInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowMapInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowMapInformationNugget", ignore_extras);
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
    public static new ShowMapInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowMapInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowMapInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowMapInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowMapInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowMapInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowMapInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MapInformationNuggetJSON.Generator
      {
        private MapLocationWithDescriptionJSON.HoldingArrayGenerator fieldGeneratorMapLocationSpecs;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestedCoordinates;
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
            if (!(getMapInformationNuggetJSONKey().Equals("ShowMap")))
                throw new Exception("The key field has a value other than `ShowMap'.");
            ShowMapInformationNuggetJSON result = new ShowMapInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowMapInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MapInformationNuggetJSON new_result)
          {
            handle_result((ShowMapInformationNuggetJSON )new_result);
          }
        protected void finish(ShowMapInformationNuggetJSON result)
          {
            if (fieldGeneratorMapLocationSpecs.have_value)
              {
                result.initMapLocationSpecs();
                int count = fieldGeneratorMapLocationSpecs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMapLocationSpecs(fieldGeneratorMapLocationSpecs.value[num]);
                  }
                fieldGeneratorMapLocationSpecs.value.Clear();
                fieldGeneratorMapLocationSpecs.have_value = false;
              }
            else if ((!(result.hasMapLocationSpecs())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MapLocationSpecs\" field was missing.");
              }
            if (fieldGeneratorRequestedCoordinates.have_value)
              {
                result.setRequestedCoordinates(fieldGeneratorRequestedCoordinates.value);
                fieldGeneratorRequestedCoordinates.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowMapInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocationSpecs", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorMapLocationSpecs;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedCoordinates", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorRequestedCoordinates;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMapLocationSpecs = new MapLocationWithDescriptionJSON.HoldingArrayGenerator("field \"MapLocationSpecs\" of the ShowMapInformationNugget class", ignore_extras);
            fieldGeneratorRequestedCoordinates = new JSONHoldingBooleanGenerator("field \"RequestedCoordinates\" of the ShowMapInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowMapInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMapLocationSpecs = new MapLocationWithDescriptionJSON.HoldingArrayGenerator("field \"MapLocationSpecs\" of the ShowMapInformationNugget class", false);
            fieldGeneratorRequestedCoordinates = new JSONHoldingBooleanGenerator("field \"RequestedCoordinates\" of the ShowMapInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowMapInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorMapLocationSpecs.reset();
            fieldGeneratorRequestedCoordinates.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowMapInformationNuggetJSON  result)
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
        public ShowMapInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowMapInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowMapInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowMapInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowMapInformationNuggetJSON>();
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
    public List<ShowMapInformationNuggetJSON> value;
  };
  };
