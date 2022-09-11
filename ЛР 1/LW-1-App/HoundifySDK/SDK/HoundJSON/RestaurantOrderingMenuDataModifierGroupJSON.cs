/* file "RestaurantOrderingMenuDataModifierGroupJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataModifierGroupJSON : RestaurantOrderingMenuDataEntityJSON
  {
    private bool flagHasModifierOptionItemIDs;
    private List< string > storeModifierOptionItemIDs;
    private bool flagHasSelectionRules;
    private RestaurantOrderingMenuDataSelectionRulesJSON  storeSelectionRules;
    private bool flagHasDefaultSelectedModifierOptionItemIDs;
    private List< string > storeDefaultSelectedModifierOptionItemIDs;
    private bool flagHasAvailability;
    private RestaurantOrderingMenuDataAvailabilityJSON  storeAvailability;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraModifierOptionItemIDsToJSON()
      {
        JSONArrayValue generated_array_1_ModifierOptionItemIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeModifierOptionItemIDs.Count; ++num1)
          {
            JSONStringValue generated_string_ModifierOptionItemIDs = new JSONStringValue(storeModifierOptionItemIDs[num1]);
            generated_array_1_ModifierOptionItemIDs.appendComponent(generated_string_ModifierOptionItemIDs);
          }
        return generated_array_1_ModifierOptionItemIDs;
      }

    private JSONValue  extraSelectionRulesToJSON()
      {
        JSONValueHandler handler_SelectionRules = new JSONValueHandler();
        storeSelectionRules.write_as_json(handler_SelectionRules);
        return handler_SelectionRules.result;
      }

    private JSONValue  extraDefaultSelectedModifierOptionItemIDsToJSON()
      {
        JSONArrayValue generated_array_2_DefaultSelectedModifierOptionItemIDs = new JSONArrayValue();
        for (int num2 = 0; num2 < storeDefaultSelectedModifierOptionItemIDs.Count; ++num2)
          {
            JSONStringValue generated_string_DefaultSelectedModifierOptionItemIDs = new JSONStringValue(storeDefaultSelectedModifierOptionItemIDs[num2]);
            generated_array_2_DefaultSelectedModifierOptionItemIDs.appendComponent(generated_string_DefaultSelectedModifierOptionItemIDs);
          }
        return generated_array_2_DefaultSelectedModifierOptionItemIDs;
      }

    private JSONValue  extraAvailabilityToJSON()
      {
        JSONValueHandler handler_Availability = new JSONValueHandler();
        storeAvailability.write_as_json(handler_Availability);
        return handler_Availability.result;
      }


    private void  fromJSONModifierOptionItemIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON has too few elements.");
        List< string > vector_ModifierOptionItemIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON is not a string.");
            vector_ModifierOptionItemIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_ModifierOptionItemIDs1.Count >= 1);
        initModifierOptionItemIDs();
        for (int num1 = 0; num1 < vector_ModifierOptionItemIDs1.Count; ++num1)
            appendModifierOptionItemIDs(vector_ModifierOptionItemIDs1[num1]);
        for (int num1 = 0; num1 < vector_ModifierOptionItemIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSelectionRules(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataSelectionRulesJSON convert_classy = RestaurantOrderingMenuDataSelectionRulesJSON.from_json(json_value, ignore_extras, true);
        setSelectionRules(convert_classy);
      }


    private void  fromJSONDefaultSelectedModifierOptionItemIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DefaultSelectedModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DefaultSelectedModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON has too few elements.");
        List< string > vector_DefaultSelectedModifierOptionItemIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DefaultSelectedModifierOptionItemIDs of RestaurantOrderingMenuDataModifierGroupJSON is not a string.");
            vector_DefaultSelectedModifierOptionItemIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_DefaultSelectedModifierOptionItemIDs1.Count >= 1);
        initDefaultSelectedModifierOptionItemIDs();
        for (int num2 = 0; num2 < vector_DefaultSelectedModifierOptionItemIDs1.Count; ++num2)
            appendDefaultSelectedModifierOptionItemIDs(vector_DefaultSelectedModifierOptionItemIDs1[num2]);
        for (int num1 = 0; num1 < vector_DefaultSelectedModifierOptionItemIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAvailability(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantOrderingMenuDataAvailabilityJSON convert_classy = RestaurantOrderingMenuDataAvailabilityJSON.from_json(json_value, ignore_extras, true);
        setAvailability(convert_classy);
      }


    public RestaurantOrderingMenuDataModifierGroupJSON()
      {
        flagHasModifierOptionItemIDs = false;
        flagHasSelectionRules = false;
        flagHasDefaultSelectedModifierOptionItemIDs = false;
        flagHasAvailability = false;
        storeModifierOptionItemIDs = new List< string >();
        storeDefaultSelectedModifierOptionItemIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getEntityKind()
      {
        return "ModifierGroup";
      }

    public bool  hasModifierOptionItemIDs()
      {
        return flagHasModifierOptionItemIDs;
      }

    public int  countOfModifierOptionItemIDs()
      {
        Debug.Assert(flagHasModifierOptionItemIDs);
        return storeModifierOptionItemIDs.Count;
      }

    public string  elementOfModifierOptionItemIDs(int element_num)
      {
        Debug.Assert(flagHasModifierOptionItemIDs);
        return storeModifierOptionItemIDs[element_num];
      }

    public List< string >  getModifierOptionItemIDs()
      {
        Debug.Assert(flagHasModifierOptionItemIDs);
        return storeModifierOptionItemIDs;
      }

    public bool  hasSelectionRules()
      {
        return flagHasSelectionRules;
      }

    public RestaurantOrderingMenuDataSelectionRulesJSON   getSelectionRules()
      {
        Debug.Assert(flagHasSelectionRules);
        return storeSelectionRules;
      }

    public bool  hasDefaultSelectedModifierOptionItemIDs()
      {
        return flagHasDefaultSelectedModifierOptionItemIDs;
      }

    public int  countOfDefaultSelectedModifierOptionItemIDs()
      {
        Debug.Assert(flagHasDefaultSelectedModifierOptionItemIDs);
        return storeDefaultSelectedModifierOptionItemIDs.Count;
      }

    public string  elementOfDefaultSelectedModifierOptionItemIDs(int element_num)
      {
        Debug.Assert(flagHasDefaultSelectedModifierOptionItemIDs);
        return storeDefaultSelectedModifierOptionItemIDs[element_num];
      }

    public List< string >  getDefaultSelectedModifierOptionItemIDs()
      {
        Debug.Assert(flagHasDefaultSelectedModifierOptionItemIDs);
        return storeDefaultSelectedModifierOptionItemIDs;
      }

    public bool  hasAvailability()
      {
        return flagHasAvailability;
      }

    public RestaurantOrderingMenuDataAvailabilityJSON   getAvailability()
      {
        Debug.Assert(flagHasAvailability);
        return storeAvailability;
      }


    public virtual int extraRestaurantOrderingMenuDataModifierGroupComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataModifierGroupComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataModifierGroupComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataModifierGroupLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRestaurantOrderingMenuDataEntityComponentCount()
      {
        int result = 0;
        if (flagHasModifierOptionItemIDs)
            ++result;
        if (flagHasSelectionRules)
            ++result;
        if (flagHasDefaultSelectedModifierOptionItemIDs)
            ++result;
        if (flagHasAvailability)
            ++result;
        result += extraRestaurantOrderingMenuDataModifierGroupComponentCount();
        return result;
      }
    public override string extraRestaurantOrderingMenuDataEntityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasModifierOptionItemIDs)
          {
            if (remainder == 0)
                return "ModifierOptionItemIDs";
            --remainder;
          }
        if (flagHasSelectionRules)
          {
            if (remainder == 0)
                return "SelectionRules";
            --remainder;
          }
        if (flagHasDefaultSelectedModifierOptionItemIDs)
          {
            if (remainder == 0)
                return "DefaultSelectedModifierOptionItemIDs";
            --remainder;
          }
        if (flagHasAvailability)
          {
            if (remainder == 0)
                return "Availability";
            --remainder;
          }
        return extraRestaurantOrderingMenuDataModifierGroupComponentKey(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasModifierOptionItemIDs)
          {
            if (remainder == 0)
                return extraModifierOptionItemIDsToJSON();
            --remainder;
          }
        if (flagHasSelectionRules)
          {
            if (remainder == 0)
                return extraSelectionRulesToJSON();
            --remainder;
          }
        if (flagHasDefaultSelectedModifierOptionItemIDs)
          {
            if (remainder == 0)
                return extraDefaultSelectedModifierOptionItemIDsToJSON();
            --remainder;
          }
        if (flagHasAvailability)
          {
            if (remainder == 0)
                return extraAvailabilityToJSON();
            --remainder;
          }
        return extraRestaurantOrderingMenuDataModifierGroupComponentValue(remainder);
      }
    public override JSONValue extraRestaurantOrderingMenuDataEntityLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "vailability", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasAvailability ? extraAvailabilityToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "efaultSelectedModifierOptionItemIDs", 0, 35, false) == 0) && (field_name.Length == 36))
                    return (flagHasDefaultSelectedModifierOptionItemIDs ? extraDefaultSelectedModifierOptionItemIDsToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "odifierOptionItemIDs", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasModifierOptionItemIDs ? extraModifierOptionItemIDsToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "electionRules", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasSelectionRules ? extraSelectionRulesToJSON() : null);
                break;
            default:
                break;
          }
        return extraRestaurantOrderingMenuDataModifierGroupLookup(field_name);
      }

    public void initModifierOptionItemIDs()
      {
        flagHasModifierOptionItemIDs = true;
        storeModifierOptionItemIDs.Clear();
      }
    public void appendModifierOptionItemIDs(string to_append)
      {
        if (!flagHasModifierOptionItemIDs)
          {
            flagHasModifierOptionItemIDs = true;
            storeModifierOptionItemIDs.Clear();
          }
        Debug.Assert(flagHasModifierOptionItemIDs);
        storeModifierOptionItemIDs.Add(to_append);
      }
    public void unsetModifierOptionItemIDs()
      {
        flagHasModifierOptionItemIDs = false;
        storeModifierOptionItemIDs.Clear();
      }
    public void setSelectionRules(RestaurantOrderingMenuDataSelectionRulesJSON  new_value)
      {
        if (flagHasSelectionRules)
          {
          }
        flagHasSelectionRules = true;
        storeSelectionRules = new_value;
      }
    public void unsetSelectionRules()
      {
        if (flagHasSelectionRules)
          {
          }
        flagHasSelectionRules = false;
      }
    public void initDefaultSelectedModifierOptionItemIDs()
      {
        flagHasDefaultSelectedModifierOptionItemIDs = true;
        storeDefaultSelectedModifierOptionItemIDs.Clear();
      }
    public void appendDefaultSelectedModifierOptionItemIDs(string to_append)
      {
        if (!flagHasDefaultSelectedModifierOptionItemIDs)
          {
            flagHasDefaultSelectedModifierOptionItemIDs = true;
            storeDefaultSelectedModifierOptionItemIDs.Clear();
          }
        Debug.Assert(flagHasDefaultSelectedModifierOptionItemIDs);
        storeDefaultSelectedModifierOptionItemIDs.Add(to_append);
      }
    public void unsetDefaultSelectedModifierOptionItemIDs()
      {
        flagHasDefaultSelectedModifierOptionItemIDs = false;
        storeDefaultSelectedModifierOptionItemIDs.Clear();
      }
    public void setAvailability(RestaurantOrderingMenuDataAvailabilityJSON  new_value)
      {
        if (flagHasAvailability)
          {
          }
        flagHasAvailability = true;
        storeAvailability = new_value;
      }
    public void unsetAvailability()
      {
        if (flagHasAvailability)
          {
          }
        flagHasAvailability = false;
      }

    public virtual void extraRestaurantOrderingMenuDataModifierGroupAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataModifierGroupSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataModifierGroupLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataModifierGroupAppendPair(key, new_component);
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
    public override void extraRestaurantOrderingMenuDataEntityAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "vailability", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONAvailability(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "efaultSelectedModifierOptionItemIDs", 0, 35, false) == 0) && (key.Length == 36))
                    {
                    fromJSONDefaultSelectedModifierOptionItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifierOptionItemIDs", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONModifierOptionItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "electionRules", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONSelectionRules(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataModifierGroupAppendPair(key, new_component);
      }
    public override void extraRestaurantOrderingMenuDataEntitySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "vailability", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONAvailability(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "efaultSelectedModifierOptionItemIDs", 0, 35, false) == 0) && (key.Length == 36))
                    {
                    fromJSONDefaultSelectedModifierOptionItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifierOptionItemIDs", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONModifierOptionItemIDs(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "electionRules", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONSelectionRules(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRestaurantOrderingMenuDataModifierGroupSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasModifierOptionItemIDs);
        if (flagHasModifierOptionItemIDs)
          {
            handler.start_pair("ModifierOptionItemIDs");
            Debug.Assert(storeModifierOptionItemIDs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeModifierOptionItemIDs.Count; ++num1)
              {
                handler.string_value(storeModifierOptionItemIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSelectionRules)
          {
            handler.start_pair("SelectionRules");
            if (partial_allowed)
                storeSelectionRules.write_partial_as_json(handler);
            else
                storeSelectionRules.write_as_json(handler);
          }
        if (flagHasDefaultSelectedModifierOptionItemIDs)
          {
            handler.start_pair("DefaultSelectedModifierOptionItemIDs");
            Debug.Assert(storeDefaultSelectedModifierOptionItemIDs.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeDefaultSelectedModifierOptionItemIDs.Count; ++num2)
              {
                handler.string_value(storeDefaultSelectedModifierOptionItemIDs[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAvailability)
          {
            handler.start_pair("Availability");
            if (partial_allowed)
                storeAvailability.write_partial_as_json(handler);
            else
                storeAvailability.write_as_json(handler);
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
        if (!(hasModifierOptionItemIDs()))
          {
            return "When parsing the object for %what%, the \"ModifierOptionItemIDs\" field was missing.";
          }
        return null;
      }

    public static new RestaurantOrderingMenuDataModifierGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataModifierGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataModifierGroup", ignore_extras);
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
    public static new RestaurantOrderingMenuDataModifierGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataModifierGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataModifierGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataModifierGroup", ignore_extras);
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
    public static new RestaurantOrderingMenuDataModifierGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RestaurantOrderingMenuDataModifierGroupJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataModifierGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataModifierGroup", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataModifierGroupJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RestaurantOrderingMenuDataModifierGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataModifierGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataModifierGroup", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RestaurantOrderingMenuDataEntityJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorModifierOptionItemIDs;
        private RestaurantOrderingMenuDataSelectionRulesJSON.HoldingGenerator fieldGeneratorSelectionRules;
        private JSONHoldingStringArrayGenerator fieldGeneratorDefaultSelectedModifierOptionItemIDs;
        private RestaurantOrderingMenuDataAvailabilityJSON.HoldingGenerator fieldGeneratorAvailability;
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
            if (!(getRestaurantOrderingMenuDataEntityJSONKey().Equals("ModifierGroup")))
                throw new Exception("The key field has a value other than `ModifierGroup'.");
            RestaurantOrderingMenuDataModifierGroupJSON result = new RestaurantOrderingMenuDataModifierGroupJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataModifierGroupAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RestaurantOrderingMenuDataEntityJSON new_result)
          {
            handle_result((RestaurantOrderingMenuDataModifierGroupJSON )new_result);
          }
        protected void finish(RestaurantOrderingMenuDataModifierGroupJSON result)
          {
            if (fieldGeneratorModifierOptionItemIDs.have_value)
              {
                result.initModifierOptionItemIDs();
                int count = fieldGeneratorModifierOptionItemIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifierOptionItemIDs(fieldGeneratorModifierOptionItemIDs.value[num]);
                  }
                fieldGeneratorModifierOptionItemIDs.value.Clear();
                fieldGeneratorModifierOptionItemIDs.have_value = false;
              }
            else if ((!(result.hasModifierOptionItemIDs())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ModifierOptionItemIDs\" field was missing.");
              }
            if (fieldGeneratorSelectionRules.have_value)
              {
                result.setSelectionRules(fieldGeneratorSelectionRules.value);
                fieldGeneratorSelectionRules.have_value = false;
              }
            if (fieldGeneratorDefaultSelectedModifierOptionItemIDs.have_value)
              {
                result.initDefaultSelectedModifierOptionItemIDs();
                int count = fieldGeneratorDefaultSelectedModifierOptionItemIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDefaultSelectedModifierOptionItemIDs(fieldGeneratorDefaultSelectedModifierOptionItemIDs.value[num]);
                  }
                fieldGeneratorDefaultSelectedModifierOptionItemIDs.value.Clear();
                fieldGeneratorDefaultSelectedModifierOptionItemIDs.have_value = false;
              }
            if (fieldGeneratorAvailability.have_value)
              {
                result.setAvailability(fieldGeneratorAvailability.value);
                fieldGeneratorAvailability.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataModifierGroupJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "vailability", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorAvailability;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "efaultSelectedModifierOptionItemIDs", 0, 35, false) == 0) && (field_name.Length == 36))
                        return fieldGeneratorDefaultSelectedModifierOptionItemIDs;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odifierOptionItemIDs", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorModifierOptionItemIDs;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "electionRules", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSelectionRules;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorModifierOptionItemIDs = new JSONHoldingStringArrayGenerator("field \"ModifierOptionItemIDs\" of the RestaurantOrderingMenuDataModifierGroup class");
            fieldGeneratorSelectionRules = new RestaurantOrderingMenuDataSelectionRulesJSON.HoldingGenerator("field \"SelectionRules\" of the RestaurantOrderingMenuDataModifierGroup class", ignore_extras);
            fieldGeneratorDefaultSelectedModifierOptionItemIDs = new JSONHoldingStringArrayGenerator("field \"DefaultSelectedModifierOptionItemIDs\" of the RestaurantOrderingMenuDataModifierGroup class");
            fieldGeneratorAvailability = new RestaurantOrderingMenuDataAvailabilityJSON.HoldingGenerator("field \"Availability\" of the RestaurantOrderingMenuDataModifierGroup class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataModifierGroup class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorModifierOptionItemIDs = new JSONHoldingStringArrayGenerator("field \"ModifierOptionItemIDs\" of the RestaurantOrderingMenuDataModifierGroup class");
            fieldGeneratorSelectionRules = new RestaurantOrderingMenuDataSelectionRulesJSON.HoldingGenerator("field \"SelectionRules\" of the RestaurantOrderingMenuDataModifierGroup class", false);
            fieldGeneratorDefaultSelectedModifierOptionItemIDs = new JSONHoldingStringArrayGenerator("field \"DefaultSelectedModifierOptionItemIDs\" of the RestaurantOrderingMenuDataModifierGroup class");
            fieldGeneratorAvailability = new RestaurantOrderingMenuDataAvailabilityJSON.HoldingGenerator("field \"Availability\" of the RestaurantOrderingMenuDataModifierGroup class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataModifierGroup class");
          }

        public override void reset()
          {
            fieldGeneratorModifierOptionItemIDs.reset();
            fieldGeneratorSelectionRules.reset();
            fieldGeneratorDefaultSelectedModifierOptionItemIDs.reset();
            fieldGeneratorAvailability.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataModifierGroupJSON  result)
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
        public RestaurantOrderingMenuDataModifierGroupJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataModifierGroupJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataModifierGroupJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataModifierGroupJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataModifierGroupJSON>();
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
    public List<RestaurantOrderingMenuDataModifierGroupJSON> value;
  };
  };
