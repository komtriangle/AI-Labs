/* file "GeometryExpressionTreeOperatorNodeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryExpressionTreeOperatorNodeJSON : GeometryExpressionTreeNodeJSON
  {
    private bool flagHasOperatorType;
    private string storeOperatorType;
    private bool flagHasLeftChild;
    private GeometryExpressionTreeNodeJSON  storeLeftChild;
    private bool flagHasRightChild;
    private GeometryExpressionTreeNodeJSON  storeRightChild;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraOperatorTypeToJSON()
      {
        JSONStringValue generated_string_OperatorType = new JSONStringValue(storeOperatorType);
        return generated_string_OperatorType;
      }

    private JSONValue  extraLeftChildToJSON()
      {
        JSONValueHandler handler_LeftChild = new JSONValueHandler();
        storeLeftChild.write_as_json(handler_LeftChild);
        return handler_LeftChild.result;
      }

    private JSONValue  extraRightChildToJSON()
      {
        JSONValueHandler handler_RightChild = new JSONValueHandler();
        storeRightChild.write_as_json(handler_RightChild);
        return handler_RightChild.result;
      }


    private void  fromJSONOperatorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OperatorType of GeometryExpressionTreeOperatorNodeJSON is not a string.");
        setOperatorType(json_string.getData());
      }


    private void  fromJSONLeftChild(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryExpressionTreeNodeJSON convert_classy = GeometryExpressionTreeNodeJSON.from_json(json_value, ignore_extras, true);
        setLeftChild(convert_classy);
      }


    private void  fromJSONRightChild(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryExpressionTreeNodeJSON convert_classy = GeometryExpressionTreeNodeJSON.from_json(json_value, ignore_extras, true);
        setRightChild(convert_classy);
      }


    public GeometryExpressionTreeOperatorNodeJSON()
      {
        flagHasOperatorType = false;
        flagHasLeftChild = false;
        flagHasRightChild = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNodeType()
      {
        return "Operator";
      }

    public bool  hasOperatorType()
      {
        return flagHasOperatorType;
      }

    public string  getOperatorType()
      {
        Debug.Assert(flagHasOperatorType);
        return storeOperatorType;
      }

    public bool  hasLeftChild()
      {
        return flagHasLeftChild;
      }

    public GeometryExpressionTreeNodeJSON   getLeftChild()
      {
        Debug.Assert(flagHasLeftChild);
        return storeLeftChild;
      }

    public bool  hasRightChild()
      {
        return flagHasRightChild;
      }

    public GeometryExpressionTreeNodeJSON   getRightChild()
      {
        Debug.Assert(flagHasRightChild);
        return storeRightChild;
      }


    public virtual int extraGeometryExpressionTreeOperatorNodeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryExpressionTreeOperatorNodeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryExpressionTreeOperatorNodeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryExpressionTreeOperatorNodeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeometryExpressionTreeNodeComponentCount()
      {
        int result = 0;
        if (flagHasOperatorType)
            ++result;
        if (flagHasLeftChild)
            ++result;
        if (flagHasRightChild)
            ++result;
        result += extraGeometryExpressionTreeOperatorNodeComponentCount();
        return result;
      }
    public override string extraGeometryExpressionTreeNodeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasOperatorType)
          {
            if (remainder == 0)
                return "OperatorType";
            --remainder;
          }
        if (flagHasLeftChild)
          {
            if (remainder == 0)
                return "LeftChild";
            --remainder;
          }
        if (flagHasRightChild)
          {
            if (remainder == 0)
                return "RightChild";
            --remainder;
          }
        return extraGeometryExpressionTreeOperatorNodeComponentKey(remainder);
      }
    public override JSONValue extraGeometryExpressionTreeNodeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasOperatorType)
          {
            if (remainder == 0)
                return extraOperatorTypeToJSON();
            --remainder;
          }
        if (flagHasLeftChild)
          {
            if (remainder == 0)
                return extraLeftChildToJSON();
            --remainder;
          }
        if (flagHasRightChild)
          {
            if (remainder == 0)
                return extraRightChildToJSON();
            --remainder;
          }
        return extraGeometryExpressionTreeOperatorNodeComponentValue(remainder);
      }
    public override JSONValue extraGeometryExpressionTreeNodeLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'L':
                if ((String.Compare(field_name, 1, "eftChild", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasLeftChild ? extraLeftChildToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "peratorType", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasOperatorType ? extraOperatorTypeToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "ightChild", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasRightChild ? extraRightChildToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeometryExpressionTreeOperatorNodeLookup(field_name);
      }

    public void setOperatorType(string new_value)
      {
        flagHasOperatorType = true;
        storeOperatorType = new_value;
      }
    public void unsetOperatorType()
      {
        flagHasOperatorType = false;
      }
    public void setLeftChild(GeometryExpressionTreeNodeJSON  new_value)
      {
        if (flagHasLeftChild)
          {
          }
        flagHasLeftChild = true;
        storeLeftChild = new_value;
      }
    public void unsetLeftChild()
      {
        if (flagHasLeftChild)
          {
          }
        flagHasLeftChild = false;
      }
    public void setRightChild(GeometryExpressionTreeNodeJSON  new_value)
      {
        if (flagHasRightChild)
          {
          }
        flagHasRightChild = true;
        storeRightChild = new_value;
      }
    public void unsetRightChild()
      {
        if (flagHasRightChild)
          {
          }
        flagHasRightChild = false;
      }

    public virtual void extraGeometryExpressionTreeOperatorNodeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryExpressionTreeOperatorNodeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryExpressionTreeOperatorNodeLookup(key);
        if (old_field == null)
          {
            extraGeometryExpressionTreeOperatorNodeAppendPair(key, new_component);
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
    public override void extraGeometryExpressionTreeNodeAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "eftChild", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONLeftChild(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "peratorType", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONOperatorType(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ightChild", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONRightChild(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryExpressionTreeOperatorNodeAppendPair(key, new_component);
      }
    public override void extraGeometryExpressionTreeNodeSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "eftChild", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONLeftChild(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "peratorType", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONOperatorType(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ightChild", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONRightChild(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryExpressionTreeOperatorNodeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOperatorType);
        if (flagHasOperatorType)
          {
            handler.start_pair("OperatorType");
            handler.string_value(storeOperatorType);
          }
        if (flagHasLeftChild)
          {
            handler.start_pair("LeftChild");
            if (partial_allowed)
                storeLeftChild.write_partial_as_json(handler);
            else
                storeLeftChild.write_as_json(handler);
          }
        if (flagHasRightChild)
          {
            handler.start_pair("RightChild");
            if (partial_allowed)
                storeRightChild.write_partial_as_json(handler);
            else
                storeRightChild.write_as_json(handler);
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
        if (!(hasOperatorType()))
          {
            return "When parsing the object for %what%, the \"OperatorType\" field was missing.";
          }
        return null;
      }

    public static new GeometryExpressionTreeOperatorNodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryExpressionTreeOperatorNodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryExpressionTreeOperatorNode", ignore_extras);
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
    public static new GeometryExpressionTreeOperatorNodeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryExpressionTreeOperatorNodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryExpressionTreeOperatorNodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryExpressionTreeOperatorNode", ignore_extras);
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
    public static new GeometryExpressionTreeOperatorNodeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryExpressionTreeOperatorNodeJSON from_text(string text, bool ignore_extras)
      {
        GeometryExpressionTreeOperatorNodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryExpressionTreeOperatorNode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryExpressionTreeOperatorNodeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeometryExpressionTreeOperatorNodeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryExpressionTreeOperatorNodeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryExpressionTreeOperatorNode", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeometryExpressionTreeNodeJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorOperatorType;
        private GeometryExpressionTreeNodeJSON.HoldingGenerator fieldGeneratorLeftChild;
        private GeometryExpressionTreeNodeJSON.HoldingGenerator fieldGeneratorRightChild;
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
            if (!(getGeometryExpressionTreeNodeJSONKey().Equals("Operator")))
                throw new Exception("The key field has a value other than `Operator'.");
            GeometryExpressionTreeOperatorNodeJSON result = new GeometryExpressionTreeOperatorNodeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryExpressionTreeOperatorNodeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeometryExpressionTreeNodeJSON new_result)
          {
            handle_result((GeometryExpressionTreeOperatorNodeJSON )new_result);
          }
        protected void finish(GeometryExpressionTreeOperatorNodeJSON result)
          {
            if (fieldGeneratorOperatorType.have_value)
              {
                result.setOperatorType(fieldGeneratorOperatorType.value);
                fieldGeneratorOperatorType.have_value = false;
              }
            else if ((!(result.hasOperatorType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OperatorType\" field was missing.");
              }
            if (fieldGeneratorLeftChild.have_value)
              {
                result.setLeftChild(fieldGeneratorLeftChild.value);
                fieldGeneratorLeftChild.have_value = false;
              }
            if (fieldGeneratorRightChild.have_value)
              {
                result.setRightChild(fieldGeneratorRightChild.value);
                fieldGeneratorRightChild.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeometryExpressionTreeOperatorNodeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "eftChild", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorLeftChild;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "peratorType", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOperatorType;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ightChild", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorRightChild;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOperatorType = new JSONHoldingStringGenerator("field \"OperatorType\" of the GeometryExpressionTreeOperatorNode class");
            fieldGeneratorLeftChild = new GeometryExpressionTreeNodeJSON.HoldingGenerator("field \"LeftChild\" of the GeometryExpressionTreeOperatorNode class", ignore_extras);
            fieldGeneratorRightChild = new GeometryExpressionTreeNodeJSON.HoldingGenerator("field \"RightChild\" of the GeometryExpressionTreeOperatorNode class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryExpressionTreeOperatorNode class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOperatorType = new JSONHoldingStringGenerator("field \"OperatorType\" of the GeometryExpressionTreeOperatorNode class");
            fieldGeneratorLeftChild = new GeometryExpressionTreeNodeJSON.HoldingGenerator("field \"LeftChild\" of the GeometryExpressionTreeOperatorNode class", false);
            fieldGeneratorRightChild = new GeometryExpressionTreeNodeJSON.HoldingGenerator("field \"RightChild\" of the GeometryExpressionTreeOperatorNode class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryExpressionTreeOperatorNode class");
          }

        public override void reset()
          {
            fieldGeneratorOperatorType.reset();
            fieldGeneratorLeftChild.reset();
            fieldGeneratorRightChild.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryExpressionTreeOperatorNodeJSON  result)
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
        public GeometryExpressionTreeOperatorNodeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryExpressionTreeOperatorNodeJSON  result)
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
    protected virtual void handle_result(List<GeometryExpressionTreeOperatorNodeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryExpressionTreeOperatorNodeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryExpressionTreeOperatorNodeJSON>();
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
    public List<GeometryExpressionTreeOperatorNodeJSON> value;
  };
  };
