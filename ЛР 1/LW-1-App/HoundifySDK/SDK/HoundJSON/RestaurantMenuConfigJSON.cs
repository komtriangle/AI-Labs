/* file "RestaurantMenuConfigJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantMenuConfigJSON : JSONBase
  {
    private bool flagHasSpecialAdjustments;
    private string storeSpecialAdjustments;
    private bool flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches;
    private bool storeRestaurantMenuEnableAffirmativeAndNegativeMatches;
    private bool flagHasRestaurantMenuEnableConsolidatedResponses;
    private bool storeRestaurantMenuEnableConsolidatedResponses;
    private bool flagHasRestaurantMenuEnableLooseMatchingForFoodQueries;
    private bool storeRestaurantMenuEnableLooseMatchingForFoodQueries;
    private bool flagHasRestaurantMenuEnableMenuInquiries;
    private bool storeRestaurantMenuEnableMenuInquiries;
    private bool flagHasRestaurantMenuEnablePersistentPrompt;
    private bool storeRestaurantMenuEnablePersistentPrompt;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpecialAdjustments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpecialAdjustments of RestaurantMenuConfigJSON is not a string.");
        setSpecialAdjustments(json_string.getData());
      }


    private void  fromJSONRestaurantMenuEnableAffirmativeAndNegativeMatches(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RestaurantMenuEnableAffirmativeAndNegativeMatches of RestaurantMenuConfigJSON is not true for false.");
              }
          }
        setRestaurantMenuEnableAffirmativeAndNegativeMatches(the_bool);
      }


    private void  fromJSONRestaurantMenuEnableConsolidatedResponses(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RestaurantMenuEnableConsolidatedResponses of RestaurantMenuConfigJSON is not true for false.");
              }
          }
        setRestaurantMenuEnableConsolidatedResponses(the_bool);
      }


    private void  fromJSONRestaurantMenuEnableLooseMatchingForFoodQueries(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RestaurantMenuEnableLooseMatchingForFoodQueries of RestaurantMenuConfigJSON is not true for false.");
              }
          }
        setRestaurantMenuEnableLooseMatchingForFoodQueries(the_bool);
      }


    private void  fromJSONRestaurantMenuEnableMenuInquiries(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RestaurantMenuEnableMenuInquiries of RestaurantMenuConfigJSON is not true for false.");
              }
          }
        setRestaurantMenuEnableMenuInquiries(the_bool);
      }


    private void  fromJSONRestaurantMenuEnablePersistentPrompt(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RestaurantMenuEnablePersistentPrompt of RestaurantMenuConfigJSON is not true for false.");
              }
          }
        setRestaurantMenuEnablePersistentPrompt(the_bool);
      }


    public RestaurantMenuConfigJSON()
      {
        flagHasSpecialAdjustments = false;
        flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches = false;
        flagHasRestaurantMenuEnableConsolidatedResponses = false;
        flagHasRestaurantMenuEnableLooseMatchingForFoodQueries = false;
        flagHasRestaurantMenuEnableMenuInquiries = false;
        flagHasRestaurantMenuEnablePersistentPrompt = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpecialAdjustments()
      {
        return flagHasSpecialAdjustments;
      }

    public string  getSpecialAdjustments()
      {
        Debug.Assert(flagHasSpecialAdjustments);
        return storeSpecialAdjustments;
      }

    public bool  hasRestaurantMenuEnableAffirmativeAndNegativeMatches()
      {
        return flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches;
      }

    public bool  getRestaurantMenuEnableAffirmativeAndNegativeMatches()
      {
        Debug.Assert(flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches);
        return storeRestaurantMenuEnableAffirmativeAndNegativeMatches;
      }

    public bool  hasRestaurantMenuEnableConsolidatedResponses()
      {
        return flagHasRestaurantMenuEnableConsolidatedResponses;
      }

    public bool  getRestaurantMenuEnableConsolidatedResponses()
      {
        Debug.Assert(flagHasRestaurantMenuEnableConsolidatedResponses);
        return storeRestaurantMenuEnableConsolidatedResponses;
      }

    public bool  hasRestaurantMenuEnableLooseMatchingForFoodQueries()
      {
        return flagHasRestaurantMenuEnableLooseMatchingForFoodQueries;
      }

    public bool  getRestaurantMenuEnableLooseMatchingForFoodQueries()
      {
        Debug.Assert(flagHasRestaurantMenuEnableLooseMatchingForFoodQueries);
        return storeRestaurantMenuEnableLooseMatchingForFoodQueries;
      }

    public bool  hasRestaurantMenuEnableMenuInquiries()
      {
        return flagHasRestaurantMenuEnableMenuInquiries;
      }

    public bool  getRestaurantMenuEnableMenuInquiries()
      {
        Debug.Assert(flagHasRestaurantMenuEnableMenuInquiries);
        return storeRestaurantMenuEnableMenuInquiries;
      }

    public bool  hasRestaurantMenuEnablePersistentPrompt()
      {
        return flagHasRestaurantMenuEnablePersistentPrompt;
      }

    public bool  getRestaurantMenuEnablePersistentPrompt()
      {
        Debug.Assert(flagHasRestaurantMenuEnablePersistentPrompt);
        return storeRestaurantMenuEnablePersistentPrompt;
      }


    public virtual int extraRestaurantMenuConfigComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuConfigComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuConfigComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuConfigLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpecialAdjustments(string new_value)
      {
        flagHasSpecialAdjustments = true;
        storeSpecialAdjustments = new_value;
      }
    public void unsetSpecialAdjustments()
      {
        flagHasSpecialAdjustments = false;
      }
    public void setRestaurantMenuEnableAffirmativeAndNegativeMatches(bool new_value)
      {
        flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches = true;
        storeRestaurantMenuEnableAffirmativeAndNegativeMatches = new_value;
      }
    public void unsetRestaurantMenuEnableAffirmativeAndNegativeMatches()
      {
        flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches = false;
      }
    public void setRestaurantMenuEnableConsolidatedResponses(bool new_value)
      {
        flagHasRestaurantMenuEnableConsolidatedResponses = true;
        storeRestaurantMenuEnableConsolidatedResponses = new_value;
      }
    public void unsetRestaurantMenuEnableConsolidatedResponses()
      {
        flagHasRestaurantMenuEnableConsolidatedResponses = false;
      }
    public void setRestaurantMenuEnableLooseMatchingForFoodQueries(bool new_value)
      {
        flagHasRestaurantMenuEnableLooseMatchingForFoodQueries = true;
        storeRestaurantMenuEnableLooseMatchingForFoodQueries = new_value;
      }
    public void unsetRestaurantMenuEnableLooseMatchingForFoodQueries()
      {
        flagHasRestaurantMenuEnableLooseMatchingForFoodQueries = false;
      }
    public void setRestaurantMenuEnableMenuInquiries(bool new_value)
      {
        flagHasRestaurantMenuEnableMenuInquiries = true;
        storeRestaurantMenuEnableMenuInquiries = new_value;
      }
    public void unsetRestaurantMenuEnableMenuInquiries()
      {
        flagHasRestaurantMenuEnableMenuInquiries = false;
      }
    public void setRestaurantMenuEnablePersistentPrompt(bool new_value)
      {
        flagHasRestaurantMenuEnablePersistentPrompt = true;
        storeRestaurantMenuEnablePersistentPrompt = new_value;
      }
    public void unsetRestaurantMenuEnablePersistentPrompt()
      {
        flagHasRestaurantMenuEnablePersistentPrompt = false;
      }

    public virtual void extraRestaurantMenuConfigAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuConfigSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuConfigLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuConfigAppendPair(key, new_component);
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
        if (flagHasSpecialAdjustments)
          {
            handler.start_pair("SpecialAdjustments");
            handler.string_value(storeSpecialAdjustments);
          }
        if (flagHasRestaurantMenuEnableAffirmativeAndNegativeMatches)
          {
            handler.start_pair("RestaurantMenuEnableAffirmativeAndNegativeMatches");
            handler.boolean_value(storeRestaurantMenuEnableAffirmativeAndNegativeMatches);
          }
        if (flagHasRestaurantMenuEnableConsolidatedResponses)
          {
            handler.start_pair("RestaurantMenuEnableConsolidatedResponses");
            handler.boolean_value(storeRestaurantMenuEnableConsolidatedResponses);
          }
        if (flagHasRestaurantMenuEnableLooseMatchingForFoodQueries)
          {
            handler.start_pair("RestaurantMenuEnableLooseMatchingForFoodQueries");
            handler.boolean_value(storeRestaurantMenuEnableLooseMatchingForFoodQueries);
          }
        if (flagHasRestaurantMenuEnableMenuInquiries)
          {
            handler.start_pair("RestaurantMenuEnableMenuInquiries");
            handler.boolean_value(storeRestaurantMenuEnableMenuInquiries);
          }
        if (flagHasRestaurantMenuEnablePersistentPrompt)
          {
            handler.start_pair("RestaurantMenuEnablePersistentPrompt");
            handler.boolean_value(storeRestaurantMenuEnablePersistentPrompt);
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

    public static RestaurantMenuConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuConfig", ignore_extras);
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
    public static RestaurantMenuConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuConfig", ignore_extras);
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
    public static RestaurantMenuConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuConfigJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuConfig", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuConfigJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuConfigJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuConfig", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSpecialAdjustments;
        private JSONHoldingBooleanGenerator fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches;
        private JSONHoldingBooleanGenerator fieldGeneratorRestaurantMenuEnableConsolidatedResponses;
        private JSONHoldingBooleanGenerator fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries;
        private JSONHoldingBooleanGenerator fieldGeneratorRestaurantMenuEnableMenuInquiries;
        private JSONHoldingBooleanGenerator fieldGeneratorRestaurantMenuEnablePersistentPrompt;
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
            RestaurantMenuConfigJSON result = new RestaurantMenuConfigJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuConfigAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuConfigJSON result)
          {
            if (fieldGeneratorSpecialAdjustments.have_value)
              {
                result.setSpecialAdjustments(fieldGeneratorSpecialAdjustments.value);
                fieldGeneratorSpecialAdjustments.have_value = false;
              }
            if (fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches.have_value)
              {
                result.setRestaurantMenuEnableAffirmativeAndNegativeMatches(fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches.value);
                fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches.have_value = false;
              }
            if (fieldGeneratorRestaurantMenuEnableConsolidatedResponses.have_value)
              {
                result.setRestaurantMenuEnableConsolidatedResponses(fieldGeneratorRestaurantMenuEnableConsolidatedResponses.value);
                fieldGeneratorRestaurantMenuEnableConsolidatedResponses.have_value = false;
              }
            if (fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries.have_value)
              {
                result.setRestaurantMenuEnableLooseMatchingForFoodQueries(fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries.value);
                fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries.have_value = false;
              }
            if (fieldGeneratorRestaurantMenuEnableMenuInquiries.have_value)
              {
                result.setRestaurantMenuEnableMenuInquiries(fieldGeneratorRestaurantMenuEnableMenuInquiries.value);
                fieldGeneratorRestaurantMenuEnableMenuInquiries.have_value = false;
              }
            if (fieldGeneratorRestaurantMenuEnablePersistentPrompt.have_value)
              {
                result.setRestaurantMenuEnablePersistentPrompt(fieldGeneratorRestaurantMenuEnablePersistentPrompt.value);
                fieldGeneratorRestaurantMenuEnablePersistentPrompt.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuConfigJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if (String.Compare(field_name, 1, "estaurantMenuEnable", 0, 19, false) == 0)
                      {
                        switch (field_name[20])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 21, "ffirmativeAndNegativeMatches", 0, 28, false) == 0) && (field_name.Length == 49))
                                    return fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches;
                                break;
                            case 'C':
                                if ((String.Compare(field_name, 21, "onsolidatedResponses", 0, 20, false) == 0) && (field_name.Length == 41))
                                    return fieldGeneratorRestaurantMenuEnableConsolidatedResponses;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 21, "ooseMatchingForFoodQueries", 0, 26, false) == 0) && (field_name.Length == 47))
                                    return fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 21, "enuInquiries", 0, 12, false) == 0) && (field_name.Length == 33))
                                    return fieldGeneratorRestaurantMenuEnableMenuInquiries;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 21, "ersistentPrompt", 0, 15, false) == 0) && (field_name.Length == 36))
                                    return fieldGeneratorRestaurantMenuEnablePersistentPrompt;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecialAdjustments", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorSpecialAdjustments;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSpecialAdjustments = new JSONHoldingStringGenerator("field \"SpecialAdjustments\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableAffirmativeAndNegativeMatches\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableConsolidatedResponses = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableConsolidatedResponses\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableLooseMatchingForFoodQueries\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableMenuInquiries = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableMenuInquiries\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnablePersistentPrompt = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnablePersistentPrompt\" of the RestaurantMenuConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpecialAdjustments = new JSONHoldingStringGenerator("field \"SpecialAdjustments\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableAffirmativeAndNegativeMatches\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableConsolidatedResponses = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableConsolidatedResponses\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableLooseMatchingForFoodQueries\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnableMenuInquiries = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnableMenuInquiries\" of the RestaurantMenuConfig class");
            fieldGeneratorRestaurantMenuEnablePersistentPrompt = new JSONHoldingBooleanGenerator("field \"RestaurantMenuEnablePersistentPrompt\" of the RestaurantMenuConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpecialAdjustments.reset();
            fieldGeneratorRestaurantMenuEnableAffirmativeAndNegativeMatches.reset();
            fieldGeneratorRestaurantMenuEnableConsolidatedResponses.reset();
            fieldGeneratorRestaurantMenuEnableLooseMatchingForFoodQueries.reset();
            fieldGeneratorRestaurantMenuEnableMenuInquiries.reset();
            fieldGeneratorRestaurantMenuEnablePersistentPrompt.reset();
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
        protected override void handle_result(RestaurantMenuConfigJSON  result)
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
        public RestaurantMenuConfigJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuConfigJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuConfigJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuConfigJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuConfigJSON>();
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
    public List<RestaurantMenuConfigJSON> value;
  };
  };
