/* file "DisambiguateLocationCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisambiguateLocationCommandJSON : CommandResultJSON
  {
    private bool flagHasAmbiguousLocations;
    private List< AnnotatedMapLocationJSON  > storeAmbiguousLocations;
    private bool flagHasActionOnSelection;
    private DisambiguateLocationActionOnSelectionJSON  storeActionOnSelection;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAmbiguousLocationsToJSON()
      {
        JSONArrayValue generated_array_1_AmbiguousLocations = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAmbiguousLocations.Count; ++num1)
          {
            JSONValueHandler handler_AmbiguousLocations = new JSONValueHandler();
            storeAmbiguousLocations[num1].write_as_json(handler_AmbiguousLocations);
            generated_array_1_AmbiguousLocations.appendComponent(handler_AmbiguousLocations.result);
          }
        return generated_array_1_AmbiguousLocations;
      }

    private JSONValue  extraActionOnSelectionToJSON()
      {
        JSONValueHandler handler_ActionOnSelection = new JSONValueHandler();
        storeActionOnSelection.write_as_json(handler_ActionOnSelection);
        return handler_ActionOnSelection.result;
      }


    private void  fromJSONAmbiguousLocations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmbiguousLocations of DisambiguateLocationCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field AmbiguousLocations of DisambiguateLocationCommandJSON has too few elements.");
        List< AnnotatedMapLocationJSON  > vector_AmbiguousLocations1 = new List< AnnotatedMapLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AnnotatedMapLocationJSON convert_classy = AnnotatedMapLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmbiguousLocations1.Add(convert_classy);
          }
        Debug.Assert(vector_AmbiguousLocations1.Count >= 2);
        initAmbiguousLocations();
        for (int num1 = 0; num1 < vector_AmbiguousLocations1.Count; ++num1)
            appendAmbiguousLocations(vector_AmbiguousLocations1[num1]);
        for (int num1 = 0; num1 < vector_AmbiguousLocations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONActionOnSelection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DisambiguateLocationActionOnSelectionJSON convert_classy = DisambiguateLocationActionOnSelectionJSON.from_json(json_value, ignore_extras, true);
        setActionOnSelection(convert_classy);
      }


    public DisambiguateLocationCommandJSON()
      {
        flagHasAmbiguousLocations = false;
        flagHasActionOnSelection = false;
        storeAmbiguousLocations = new List< AnnotatedMapLocationJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "DisambiguateLocationCommand";
      }

    public bool  hasAmbiguousLocations()
      {
        return flagHasAmbiguousLocations;
      }

    public int  countOfAmbiguousLocations()
      {
        Debug.Assert(flagHasAmbiguousLocations);
        return storeAmbiguousLocations.Count;
      }

    public AnnotatedMapLocationJSON   elementOfAmbiguousLocations(int element_num)
      {
        Debug.Assert(flagHasAmbiguousLocations);
        return storeAmbiguousLocations[element_num];
      }

    public List< AnnotatedMapLocationJSON  >  getAmbiguousLocations()
      {
        Debug.Assert(flagHasAmbiguousLocations);
        return storeAmbiguousLocations;
      }

    public bool  hasActionOnSelection()
      {
        return flagHasActionOnSelection;
      }

    public DisambiguateLocationActionOnSelectionJSON   getActionOnSelection()
      {
        Debug.Assert(flagHasActionOnSelection);
        return storeActionOnSelection;
      }

    public DisambiguateLocationActionOnSelectionJSON.TypeValue  getActionOnSelectionValue()
      {
        return getActionOnSelection().getValue();
      }

    public string  getActionOnSelectionAsString()
      {
        return getActionOnSelection().getValueAsString();
      }


    public virtual int extraDisambiguateLocationCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisambiguateLocationCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisambiguateLocationCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisambiguateLocationCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasAmbiguousLocations)
            ++result;
        if (flagHasActionOnSelection)
            ++result;
        result += extraDisambiguateLocationCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAmbiguousLocations)
          {
            if (remainder == 0)
                return "AmbiguousLocations";
            --remainder;
          }
        if (flagHasActionOnSelection)
          {
            if (remainder == 0)
                return "ActionOnSelection";
            --remainder;
          }
        return extraDisambiguateLocationCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAmbiguousLocations)
          {
            if (remainder == 0)
                return extraAmbiguousLocationsToJSON();
            --remainder;
          }
        if (flagHasActionOnSelection)
          {
            if (remainder == 0)
                return extraActionOnSelectionToJSON();
            --remainder;
          }
        return extraDisambiguateLocationCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "A", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'c':
                    if ((String.Compare(field_name, 2, "tionOnSelection", 0, 15, false) == 0) && (field_name.Length == 17))
                        return (flagHasActionOnSelection ? extraActionOnSelectionToJSON() : null);
                    break;
                case 'm':
                    if ((String.Compare(field_name, 2, "biguousLocations", 0, 16, false) == 0) && (field_name.Length == 18))
                        return (flagHasAmbiguousLocations ? extraAmbiguousLocationsToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraDisambiguateLocationCommandLookup(field_name);
      }

    public void initAmbiguousLocations()
      {
        if (flagHasAmbiguousLocations)
          {
            for (int num1 = 0; num1 < storeAmbiguousLocations.Count; ++num1)
              {
              }
          }
        flagHasAmbiguousLocations = true;
        storeAmbiguousLocations.Clear();
      }
    public void appendAmbiguousLocations(AnnotatedMapLocationJSON  to_append)
      {
        if (!flagHasAmbiguousLocations)
          {
            flagHasAmbiguousLocations = true;
            storeAmbiguousLocations.Clear();
          }
        Debug.Assert(flagHasAmbiguousLocations);
        storeAmbiguousLocations.Add(to_append);
      }
    public void unsetAmbiguousLocations()
      {
        if (flagHasAmbiguousLocations)
          {
            for (int num2 = 0; num2 < storeAmbiguousLocations.Count; ++num2)
              {
              }
          }
        flagHasAmbiguousLocations = false;
        storeAmbiguousLocations.Clear();
      }
    public void setActionOnSelection(DisambiguateLocationActionOnSelectionJSON  new_value)
      {
        if (flagHasActionOnSelection)
          {
          }
        flagHasActionOnSelection = true;
        storeActionOnSelection = new_value;
      }
    public void setActionOnSelection(DisambiguateLocationActionOnSelectionJSON.TypeValue new_value)
      {
        setActionOnSelection(new DisambiguateLocationActionOnSelectionJSON(new_value));
      }
    public void setActionOnSelection(string chars)
      {
        DisambiguateLocationActionOnSelectionJSON.TypeValueKnownValues known = DisambiguateLocationActionOnSelectionJSON.stringToValue(chars);
        DisambiguateLocationActionOnSelectionJSON.TypeValue new_value = new DisambiguateLocationActionOnSelectionJSON.TypeValue();
        if (known == DisambiguateLocationActionOnSelectionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setActionOnSelection(new_value);
      }
    public void unsetActionOnSelection()
      {
        if (flagHasActionOnSelection)
          {
          }
        flagHasActionOnSelection = false;
      }

    public virtual void extraDisambiguateLocationCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisambiguateLocationCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisambiguateLocationCommandLookup(key);
        if (old_field == null)
          {
            extraDisambiguateLocationCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "A", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'c':
                    if ((String.Compare(key, 2, "tionOnSelection", 0, 15, false) == 0) && (key.Length == 17))
                        {
                        fromJSONActionOnSelection(new_component, false);
                        return;
                        }
                    break;
                case 'm':
                    if ((String.Compare(key, 2, "biguousLocations", 0, 16, false) == 0) && (key.Length == 18))
                        {
                        fromJSONAmbiguousLocations(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraDisambiguateLocationCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "A", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'c':
                    if ((String.Compare(key, 2, "tionOnSelection", 0, 15, false) == 0) && (key.Length == 17))
                        {
                        fromJSONActionOnSelection(new_component, false);
                        return;
                        }
                    break;
                case 'm':
                    if ((String.Compare(key, 2, "biguousLocations", 0, 16, false) == 0) && (key.Length == 18))
                        {
                        fromJSONAmbiguousLocations(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraDisambiguateLocationCommandSetField(key, new_component);
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
        if (flagHasAmbiguousLocations)
          {
            handler.start_pair("AmbiguousLocations");
            Debug.Assert(storeAmbiguousLocations.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeAmbiguousLocations.Count; ++num1)
              {
                if (partial_allowed)
                    storeAmbiguousLocations[num1].write_partial_as_json(handler);
                else
                    storeAmbiguousLocations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasActionOnSelection)
          {
            handler.start_pair("ActionOnSelection");
            if (partial_allowed)
                storeActionOnSelection.write_partial_as_json(handler);
            else
                storeActionOnSelection.write_as_json(handler);
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

    public static new DisambiguateLocationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateLocationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateLocationCommand", ignore_extras);
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
    public static new DisambiguateLocationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateLocationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateLocationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateLocationCommand", ignore_extras);
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
    public static new DisambiguateLocationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateLocationCommandJSON from_text(string text, bool ignore_extras)
      {
        DisambiguateLocationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateLocationCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguateLocationCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisambiguateLocationCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguateLocationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateLocationCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private AnnotatedMapLocationJSON.HoldingArrayGenerator fieldGeneratorAmbiguousLocations;
        private DisambiguateLocationActionOnSelectionJSON.HoldingGenerator fieldGeneratorActionOnSelection;
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
            if (!(getCommandResultJSONKey().Equals("DisambiguateLocationCommand")))
                throw new Exception("The key field has a value other than `DisambiguateLocationCommand'.");
            DisambiguateLocationCommandJSON result = new DisambiguateLocationCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisambiguateLocationCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((DisambiguateLocationCommandJSON )new_result);
          }
        protected void finish(DisambiguateLocationCommandJSON result)
          {
            if (fieldGeneratorAmbiguousLocations.have_value)
              {
                result.initAmbiguousLocations();
                int count = fieldGeneratorAmbiguousLocations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmbiguousLocations(fieldGeneratorAmbiguousLocations.value[num]);
                  }
                fieldGeneratorAmbiguousLocations.value.Clear();
                fieldGeneratorAmbiguousLocations.have_value = false;
              }
            if (fieldGeneratorActionOnSelection.have_value)
              {
                result.setActionOnSelection(fieldGeneratorActionOnSelection.value);
                fieldGeneratorActionOnSelection.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisambiguateLocationCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "A", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'c':
                        if ((String.Compare(field_name, 2, "tionOnSelection", 0, 15, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorActionOnSelection;
                        break;
                    case 'm':
                        if ((String.Compare(field_name, 2, "biguousLocations", 0, 16, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorAmbiguousLocations;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAmbiguousLocations = new AnnotatedMapLocationJSON.HoldingArrayGenerator("field \"AmbiguousLocations\" of the DisambiguateLocationCommand class", ignore_extras);
            fieldGeneratorActionOnSelection = new DisambiguateLocationActionOnSelectionJSON.HoldingGenerator("field \"ActionOnSelection\" of the DisambiguateLocationCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisambiguateLocationCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAmbiguousLocations = new AnnotatedMapLocationJSON.HoldingArrayGenerator("field \"AmbiguousLocations\" of the DisambiguateLocationCommand class", false);
            fieldGeneratorActionOnSelection = new DisambiguateLocationActionOnSelectionJSON.HoldingGenerator("field \"ActionOnSelection\" of the DisambiguateLocationCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisambiguateLocationCommand class");
          }

        public override void reset()
          {
            fieldGeneratorAmbiguousLocations.reset();
            fieldGeneratorActionOnSelection.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisambiguateLocationCommandJSON  result)
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
        public DisambiguateLocationCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguateLocationCommandJSON  result)
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
    protected virtual void handle_result(List<DisambiguateLocationCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguateLocationCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguateLocationCommandJSON>();
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
    public List<DisambiguateLocationCommandJSON> value;
  };
  };
