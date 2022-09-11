/* file "DishInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DishInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasDishDetails;
    private DishDetailsJSON  storeDishDetails;
    private bool flagHasIsSpecifiedFromList;
    private bool storeIsSpecifiedFromList;
    private bool flagHasProcessedInstructions;
    private List< RecipeAidInstructionDetailsJSON  > storeProcessedInstructions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDishDetailsToJSON()
      {
        JSONValueHandler handler_DishDetails = new JSONValueHandler();
        storeDishDetails.write_as_json(handler_DishDetails);
        return handler_DishDetails.result;
      }

    private JSONValue  extraIsSpecifiedFromListToJSON()
      {
        JSONValue generated_boolean_IsSpecifiedFromList = (storeIsSpecifiedFromList ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsSpecifiedFromList;
      }

    private JSONValue  extraProcessedInstructionsToJSON()
      {
        JSONArrayValue generated_array_1_ProcessedInstructions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
          {
            JSONValueHandler handler_ProcessedInstructions = new JSONValueHandler();
            storeProcessedInstructions[num1].write_as_json(handler_ProcessedInstructions);
            generated_array_1_ProcessedInstructions.appendComponent(handler_ProcessedInstructions.result);
          }
        return generated_array_1_ProcessedInstructions;
      }


    private void  fromJSONDishDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DishDetailsJSON convert_classy = DishDetailsJSON.from_json(json_value, ignore_extras, true);
        setDishDetails(convert_classy);
      }


    private void  fromJSONIsSpecifiedFromList(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSpecifiedFromList of DishInformationNuggetJSON is not true for false.");
              }
          }
        setIsSpecifiedFromList(the_bool);
      }


    private void  fromJSONProcessedInstructions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProcessedInstructions of DishInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RecipeAidInstructionDetailsJSON  > vector_ProcessedInstructions1 = new List< RecipeAidInstructionDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RecipeAidInstructionDetailsJSON convert_classy = RecipeAidInstructionDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ProcessedInstructions1.Add(convert_classy);
          }
        initProcessedInstructions();
        for (int num1 = 0; num1 < vector_ProcessedInstructions1.Count; ++num1)
            appendProcessedInstructions(vector_ProcessedInstructions1[num1]);
        for (int num1 = 0; num1 < vector_ProcessedInstructions1.Count; ++num1)
          {
          }
      }


    public DishInformationNuggetJSON()
      {
        flagHasDishDetails = false;
        flagHasIsSpecifiedFromList = false;
        flagHasProcessedInstructions = false;
        storeProcessedInstructions = new List< RecipeAidInstructionDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "DishInformationNugget";
      }

    public bool  hasDishDetails()
      {
        return flagHasDishDetails;
      }

    public DishDetailsJSON   getDishDetails()
      {
        Debug.Assert(flagHasDishDetails);
        return storeDishDetails;
      }

    public bool  hasIsSpecifiedFromList()
      {
        return flagHasIsSpecifiedFromList;
      }

    public bool  getIsSpecifiedFromList()
      {
        Debug.Assert(flagHasIsSpecifiedFromList);
        return storeIsSpecifiedFromList;
      }

    public bool  hasProcessedInstructions()
      {
        return flagHasProcessedInstructions;
      }

    public int  countOfProcessedInstructions()
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions.Count;
      }

    public RecipeAidInstructionDetailsJSON   elementOfProcessedInstructions(int element_num)
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions[element_num];
      }

    public List< RecipeAidInstructionDetailsJSON  >  getProcessedInstructions()
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions;
      }


    public virtual int extraDishInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDishInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDishInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDishInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDishDetails)
            ++result;
        if (flagHasIsSpecifiedFromList)
            ++result;
        if (flagHasProcessedInstructions)
            ++result;
        result += extraDishInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDishDetails)
          {
            if (remainder == 0)
                return "DishDetails";
            --remainder;
          }
        if (flagHasIsSpecifiedFromList)
          {
            if (remainder == 0)
                return "IsSpecifiedFromList";
            --remainder;
          }
        if (flagHasProcessedInstructions)
          {
            if (remainder == 0)
                return "ProcessedInstructions";
            --remainder;
          }
        return extraDishInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDishDetails)
          {
            if (remainder == 0)
                return extraDishDetailsToJSON();
            --remainder;
          }
        if (flagHasIsSpecifiedFromList)
          {
            if (remainder == 0)
                return extraIsSpecifiedFromListToJSON();
            --remainder;
          }
        if (flagHasProcessedInstructions)
          {
            if (remainder == 0)
                return extraProcessedInstructionsToJSON();
            --remainder;
          }
        return extraDishInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ishDetails", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDishDetails ? extraDishDetailsToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "sSpecifiedFromList", 0, 18, false) == 0) && (field_name.Length == 19))
                    return (flagHasIsSpecifiedFromList ? extraIsSpecifiedFromListToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rocessedInstructions", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasProcessedInstructions ? extraProcessedInstructionsToJSON() : null);
                break;
            default:
                break;
          }
        return extraDishInformationNuggetLookup(field_name);
      }

    public void setDishDetails(DishDetailsJSON  new_value)
      {
        if (flagHasDishDetails)
          {
          }
        flagHasDishDetails = true;
        storeDishDetails = new_value;
      }
    public void unsetDishDetails()
      {
        if (flagHasDishDetails)
          {
          }
        flagHasDishDetails = false;
      }
    public void setIsSpecifiedFromList(bool new_value)
      {
        flagHasIsSpecifiedFromList = true;
        storeIsSpecifiedFromList = new_value;
      }
    public void unsetIsSpecifiedFromList()
      {
        flagHasIsSpecifiedFromList = false;
      }
    public void initProcessedInstructions()
      {
        if (flagHasProcessedInstructions)
          {
            for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
              {
              }
          }
        flagHasProcessedInstructions = true;
        storeProcessedInstructions.Clear();
      }
    public void appendProcessedInstructions(RecipeAidInstructionDetailsJSON  to_append)
      {
        if (!flagHasProcessedInstructions)
          {
            flagHasProcessedInstructions = true;
            storeProcessedInstructions.Clear();
          }
        Debug.Assert(flagHasProcessedInstructions);
        storeProcessedInstructions.Add(to_append);
      }
    public void unsetProcessedInstructions()
      {
        if (flagHasProcessedInstructions)
          {
            for (int num2 = 0; num2 < storeProcessedInstructions.Count; ++num2)
              {
              }
          }
        flagHasProcessedInstructions = false;
        storeProcessedInstructions.Clear();
      }

    public virtual void extraDishInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDishInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDishInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraDishInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ishDetails", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDishDetails(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sSpecifiedFromList", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONIsSpecifiedFromList(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rocessedInstructions", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONProcessedInstructions(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDishInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ishDetails", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDishDetails(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sSpecifiedFromList", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONIsSpecifiedFromList(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rocessedInstructions", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONProcessedInstructions(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDishInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDishDetails);
        if (flagHasDishDetails)
          {
            handler.start_pair("DishDetails");
            if (partial_allowed)
                storeDishDetails.write_partial_as_json(handler);
            else
                storeDishDetails.write_as_json(handler);
          }
        if (flagHasIsSpecifiedFromList)
          {
            handler.start_pair("IsSpecifiedFromList");
            handler.boolean_value(storeIsSpecifiedFromList);
          }
        if (flagHasProcessedInstructions)
          {
            handler.start_pair("ProcessedInstructions");
            handler.start_array();
            for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
              {
                if (partial_allowed)
                    storeProcessedInstructions[num1].write_partial_as_json(handler);
                else
                    storeProcessedInstructions[num1].write_as_json(handler);
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
        if (!(hasDishDetails()))
          {
            return "When parsing the object for %what%, the \"DishDetails\" field was missing.";
          }
        return null;
      }

    public static new DishInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DishInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishInformationNugget", ignore_extras);
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
    public static new DishInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DishInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DishInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishInformationNugget", ignore_extras);
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
    public static new DishInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DishInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DishInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DishInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DishInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DishInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private DishDetailsJSON.HoldingGenerator fieldGeneratorDishDetails;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSpecifiedFromList;
        private RecipeAidInstructionDetailsJSON.HoldingArrayGenerator fieldGeneratorProcessedInstructions;
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
            if (!(getInformationNuggetJSONKey().Equals("DishInformationNugget")))
                throw new Exception("The key field has a value other than `DishInformationNugget'.");
            DishInformationNuggetJSON result = new DishInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDishInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((DishInformationNuggetJSON )new_result);
          }
        protected void finish(DishInformationNuggetJSON result)
          {
            if (fieldGeneratorDishDetails.have_value)
              {
                result.setDishDetails(fieldGeneratorDishDetails.value);
                fieldGeneratorDishDetails.have_value = false;
              }
            else if ((!(result.hasDishDetails())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DishDetails\" field was missing.");
              }
            if (fieldGeneratorIsSpecifiedFromList.have_value)
              {
                result.setIsSpecifiedFromList(fieldGeneratorIsSpecifiedFromList.value);
                fieldGeneratorIsSpecifiedFromList.have_value = false;
              }
            if (fieldGeneratorProcessedInstructions.have_value)
              {
                result.initProcessedInstructions();
                int count = fieldGeneratorProcessedInstructions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProcessedInstructions(fieldGeneratorProcessedInstructions.value[num]);
                  }
                fieldGeneratorProcessedInstructions.value.Clear();
                fieldGeneratorProcessedInstructions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DishInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ishDetails", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDishDetails;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sSpecifiedFromList", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorIsSpecifiedFromList;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rocessedInstructions", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorProcessedInstructions;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDishDetails = new DishDetailsJSON.HoldingGenerator("field \"DishDetails\" of the DishInformationNugget class", ignore_extras);
            fieldGeneratorIsSpecifiedFromList = new JSONHoldingBooleanGenerator("field \"IsSpecifiedFromList\" of the DishInformationNugget class");
            fieldGeneratorProcessedInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"ProcessedInstructions\" of the DishInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DishInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDishDetails = new DishDetailsJSON.HoldingGenerator("field \"DishDetails\" of the DishInformationNugget class", false);
            fieldGeneratorIsSpecifiedFromList = new JSONHoldingBooleanGenerator("field \"IsSpecifiedFromList\" of the DishInformationNugget class");
            fieldGeneratorProcessedInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"ProcessedInstructions\" of the DishInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DishInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDishDetails.reset();
            fieldGeneratorIsSpecifiedFromList.reset();
            fieldGeneratorProcessedInstructions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DishInformationNuggetJSON  result)
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
        public DishInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DishInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DishInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DishInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DishInformationNuggetJSON>();
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
    public List<DishInformationNuggetJSON> value;
  };
  };
