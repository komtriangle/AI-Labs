/* file "BasicBinaryOperationQuantityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BasicBinaryOperationQuantityJSON : QuantityJSON
  {
    public enum TypeOperation
      {
        Operation_Addition,
        Operation_Subtraction,
        Operation_Multiplication,
        Operation_Division
      };

    public static TypeOperation  stringToOperation(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ddition", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeOperation.Operation_Addition;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ivision", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeOperation.Operation_Division;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ultiplication", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeOperation.Operation_Multiplication;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ubtraction", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeOperation.Operation_Subtraction;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Operation' is not one of the legal values.");
      }

    public static string  stringFromOperation(TypeOperation the_enum)
      {
        switch (the_enum)
          {
            case TypeOperation.Operation_Addition:
                return "Addition";
            case TypeOperation.Operation_Subtraction:
                return "Subtraction";
            case TypeOperation.Operation_Multiplication:
                return "Multiplication";
            case TypeOperation.Operation_Division:
                return "Division";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasOperation;
    private TypeOperation storeOperation;
    private bool flagHasLeft;
    private QuantityJSON  storeLeft;
    private bool flagHasRight;
    private QuantityJSON  storeRight;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraOperationToJSON()
      {
        JSONStringValue generated_string_Operation;
        switch (storeOperation)
          {
            case TypeOperation.Operation_Addition:
                generated_string_Operation = new JSONStringValue("Addition");
                break;
            case TypeOperation.Operation_Subtraction:
                generated_string_Operation = new JSONStringValue("Subtraction");
                break;
            case TypeOperation.Operation_Multiplication:
                generated_string_Operation = new JSONStringValue("Multiplication");
                break;
            case TypeOperation.Operation_Division:
                generated_string_Operation = new JSONStringValue("Division");
                break;
            default:
                Debug.Assert(false);
                generated_string_Operation = null;
                break;
          }
        return generated_string_Operation;
      }

    private JSONValue  extraLeftToJSON()
      {
        JSONValueHandler handler_Left = new JSONValueHandler();
        storeLeft.write_as_json(handler_Left);
        return handler_Left.result;
      }

    private JSONValue  extraRightToJSON()
      {
        JSONValueHandler handler_Right = new JSONValueHandler();
        storeRight.write_as_json(handler_Right);
        return handler_Right.result;
      }


    private void  fromJSONOperation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Operation of BasicBinaryOperationQuantityJSON is not a string.");
        TypeOperation the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ddition", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeOperation.Operation_Addition;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ivision", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeOperation.Operation_Division;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ultiplication", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeOperation.Operation_Multiplication;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ubtraction", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeOperation.Operation_Subtraction;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Operation of BasicBinaryOperationQuantityJSON is not one of the legal strings.");
      enum_is_done:;
        setOperation(the_enum);
      }


    private void  fromJSONLeft(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QuantityJSON convert_classy = QuantityJSON.from_json(json_value, ignore_extras, true);
        setLeft(convert_classy);
      }


    private void  fromJSONRight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QuantityJSON convert_classy = QuantityJSON.from_json(json_value, ignore_extras, true);
        setRight(convert_classy);
      }


    public BasicBinaryOperationQuantityJSON()
      {
        flagHasOperation = false;
        flagHasLeft = false;
        flagHasRight = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getQuantityKind()
      {
        return "BasicBinaryOperation";
      }

    public bool  hasOperation()
      {
        return flagHasOperation;
      }

    public TypeOperation  getOperation()
      {
        Debug.Assert(flagHasOperation);
        return storeOperation;
      }

    public string  getOperationAsString()
      {
        return stringFromOperation(getOperation());
      }

    public bool  hasLeft()
      {
        return flagHasLeft;
      }

    public QuantityJSON   getLeft()
      {
        Debug.Assert(flagHasLeft);
        return storeLeft;
      }

    public bool  hasRight()
      {
        return flagHasRight;
      }

    public QuantityJSON   getRight()
      {
        Debug.Assert(flagHasRight);
        return storeRight;
      }


    public virtual int extraBasicBinaryOperationQuantityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBasicBinaryOperationQuantityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBasicBinaryOperationQuantityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBasicBinaryOperationQuantityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraQuantityComponentCount()
      {
        int result = 0;
        if (flagHasOperation)
            ++result;
        if (flagHasLeft)
            ++result;
        if (flagHasRight)
            ++result;
        result += extraBasicBinaryOperationQuantityComponentCount();
        return result;
      }
    public override string extraQuantityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasOperation)
          {
            if (remainder == 0)
                return "Operation";
            --remainder;
          }
        if (flagHasLeft)
          {
            if (remainder == 0)
                return "Left";
            --remainder;
          }
        if (flagHasRight)
          {
            if (remainder == 0)
                return "Right";
            --remainder;
          }
        return extraBasicBinaryOperationQuantityComponentKey(remainder);
      }
    public override JSONValue extraQuantityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasOperation)
          {
            if (remainder == 0)
                return extraOperationToJSON();
            --remainder;
          }
        if (flagHasLeft)
          {
            if (remainder == 0)
                return extraLeftToJSON();
            --remainder;
          }
        if (flagHasRight)
          {
            if (remainder == 0)
                return extraRightToJSON();
            --remainder;
          }
        return extraBasicBinaryOperationQuantityComponentValue(remainder);
      }
    public override JSONValue extraQuantityLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'L':
                if ((String.Compare(field_name, 1, "eft", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasLeft ? extraLeftToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "peration", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasOperation ? extraOperationToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "ight", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasRight ? extraRightToJSON() : null);
                break;
            default:
                break;
          }
        return extraBasicBinaryOperationQuantityLookup(field_name);
      }

    public void setOperation(TypeOperation new_value)
      {
        flagHasOperation = true;
        storeOperation = new_value;
      }
    public void setOperation(string chars)
      {
        setOperation(stringToOperation(chars));
      }
    public void unsetOperation()
      {
        flagHasOperation = false;
      }
    public void setLeft(QuantityJSON  new_value)
      {
        if (flagHasLeft)
          {
          }
        flagHasLeft = true;
        storeLeft = new_value;
      }
    public void unsetLeft()
      {
        if (flagHasLeft)
          {
          }
        flagHasLeft = false;
      }
    public void setRight(QuantityJSON  new_value)
      {
        if (flagHasRight)
          {
          }
        flagHasRight = true;
        storeRight = new_value;
      }
    public void unsetRight()
      {
        if (flagHasRight)
          {
          }
        flagHasRight = false;
      }

    public virtual void extraBasicBinaryOperationQuantityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBasicBinaryOperationQuantitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBasicBinaryOperationQuantityLookup(key);
        if (old_field == null)
          {
            extraBasicBinaryOperationQuantityAppendPair(key, new_component);
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
    public override void extraQuantityAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "eft", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONLeft(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "peration", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONOperation(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ight", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONRight(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBasicBinaryOperationQuantityAppendPair(key, new_component);
      }
    public override void extraQuantitySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "eft", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONLeft(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "peration", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONOperation(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "ight", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONRight(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBasicBinaryOperationQuantitySetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOperation);
        if (flagHasOperation)
          {
            handler.start_pair("Operation");
            switch (storeOperation)
              {
                case TypeOperation.Operation_Addition:
                    handler.string_value("Addition");
                    break;
                case TypeOperation.Operation_Subtraction:
                    handler.string_value("Subtraction");
                    break;
                case TypeOperation.Operation_Multiplication:
                    handler.string_value("Multiplication");
                    break;
                case TypeOperation.Operation_Division:
                    handler.string_value("Division");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasLeft);
        if (flagHasLeft)
          {
            handler.start_pair("Left");
            if (partial_allowed)
                storeLeft.write_partial_as_json(handler);
            else
                storeLeft.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRight);
        if (flagHasRight)
          {
            handler.start_pair("Right");
            if (partial_allowed)
                storeRight.write_partial_as_json(handler);
            else
                storeRight.write_as_json(handler);
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
        if (!(hasOperation()))
          {
            return "When parsing the object for %what%, the \"Operation\" field was missing.";
          }
        if (!(hasLeft()))
          {
            return "When parsing the object for %what%, the \"Left\" field was missing.";
          }
        if (!(hasRight()))
          {
            return "When parsing the object for %what%, the \"Right\" field was missing.";
          }
        return null;
      }

    public static new BasicBinaryOperationQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BasicBinaryOperationQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BasicBinaryOperationQuantity", ignore_extras);
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
    public static new BasicBinaryOperationQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BasicBinaryOperationQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BasicBinaryOperationQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BasicBinaryOperationQuantity", ignore_extras);
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
    public static new BasicBinaryOperationQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BasicBinaryOperationQuantityJSON from_text(string text, bool ignore_extras)
      {
        BasicBinaryOperationQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BasicBinaryOperationQuantity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BasicBinaryOperationQuantityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BasicBinaryOperationQuantityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BasicBinaryOperationQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BasicBinaryOperationQuantity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : QuantityJSON.Generator
      {
    private abstract class FieldGeneratorOperation : JSONStringGenerator
          {
            protected FieldGeneratorOperation(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOperation()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToOperation(result));
              }
            protected abstract void handle_result(TypeOperation result);
          };
    private class FieldHoldingGeneratorOperation : FieldGeneratorOperation
  {
    protected override void handle_result(TypeOperation result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOperation(String what)
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
    public TypeOperation value;
  };
    private class FieldHoldingArrayGeneratorOperation : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOperation
      {
        private FieldHoldingArrayGeneratorOperation top;

        protected override void handle_result(TypeOperation result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOperation init_top)
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
    protected virtual void handle_result(List<TypeOperation> result)
      {
      }

    public FieldHoldingArrayGeneratorOperation(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOperation>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOperation()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOperation>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOperation> value;
  };
        private FieldHoldingGeneratorOperation fieldGeneratorOperation;
        private QuantityJSON.HoldingGenerator fieldGeneratorLeft;
        private QuantityJSON.HoldingGenerator fieldGeneratorRight;
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
            if (!(getQuantityJSONKey().Equals("BasicBinaryOperation")))
                throw new Exception("The key field has a value other than `BasicBinaryOperation'.");
            BasicBinaryOperationQuantityJSON result = new BasicBinaryOperationQuantityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBasicBinaryOperationQuantityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(QuantityJSON new_result)
          {
            handle_result((BasicBinaryOperationQuantityJSON )new_result);
          }
        protected void finish(BasicBinaryOperationQuantityJSON result)
          {
            if (fieldGeneratorOperation.have_value)
              {
                result.setOperation(fieldGeneratorOperation.value);
                fieldGeneratorOperation.have_value = false;
              }
            else if ((!(result.hasOperation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Operation\" field was missing.");
              }
            if (fieldGeneratorLeft.have_value)
              {
                result.setLeft(fieldGeneratorLeft.value);
                fieldGeneratorLeft.have_value = false;
              }
            else if ((!(result.hasLeft())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Left\" field was missing.");
              }
            if (fieldGeneratorRight.have_value)
              {
                result.setRight(fieldGeneratorRight.value);
                fieldGeneratorRight.have_value = false;
              }
            else if ((!(result.hasRight())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Right\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(BasicBinaryOperationQuantityJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "eft", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorLeft;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "peration", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOperation;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ight", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorRight;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorOperation = new FieldHoldingGeneratorOperation("field \"Operation\" of the BasicBinaryOperationQuantity class");
            fieldGeneratorLeft = new QuantityJSON.HoldingGenerator("field \"Left\" of the BasicBinaryOperationQuantity class", ignore_extras);
            fieldGeneratorRight = new QuantityJSON.HoldingGenerator("field \"Right\" of the BasicBinaryOperationQuantity class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BasicBinaryOperationQuantity class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorOperation = new FieldHoldingGeneratorOperation("field \"Operation\" of the BasicBinaryOperationQuantity class");
            fieldGeneratorLeft = new QuantityJSON.HoldingGenerator("field \"Left\" of the BasicBinaryOperationQuantity class", false);
            fieldGeneratorRight = new QuantityJSON.HoldingGenerator("field \"Right\" of the BasicBinaryOperationQuantity class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BasicBinaryOperationQuantity class");
          }

        public override void reset()
          {
            fieldGeneratorOperation.reset();
            fieldGeneratorLeft.reset();
            fieldGeneratorRight.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BasicBinaryOperationQuantityJSON  result)
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
        public BasicBinaryOperationQuantityJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BasicBinaryOperationQuantityJSON  result)
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
    protected virtual void handle_result(List<BasicBinaryOperationQuantityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BasicBinaryOperationQuantityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BasicBinaryOperationQuantityJSON>();
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
    public List<BasicBinaryOperationQuantityJSON> value;
  };
  };
