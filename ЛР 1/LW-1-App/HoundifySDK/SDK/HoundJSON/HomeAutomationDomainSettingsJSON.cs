/* file "HomeAutomationDomainSettingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationDomainSettingsJSON : JSONBase
  {
    public enum TypeHereBehaviorKnownValues
      {
        HereBehavior_UseHere,
        HereBehavior_AskWhenNoHere,
        HereBehavior_AskAlways,
        HereBehavior_DoNotMatch,
        HereBehavior_HereAsAll,
        HereBehavior__none
      };
    public struct TypeHereBehavior
      {
        public bool in_known_list;
        public string string_value;
        public TypeHereBehaviorKnownValues list_value;
      };

    public static TypeHereBehaviorKnownValues  stringToHereBehavior(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "sk", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'A':
                            if ((String.Compare(chars, 4, "lways", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeHereBehaviorKnownValues.HereBehavior_AskAlways;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 4, "henNoHere", 0, 9, false) == 0) && (chars.Length == 13))
                                return TypeHereBehaviorKnownValues.HereBehavior_AskWhenNoHere;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "oNotMatch", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeHereBehaviorKnownValues.HereBehavior_DoNotMatch;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ereAsAll", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeHereBehaviorKnownValues.HereBehavior_HereAsAll;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "seHere", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeHereBehaviorKnownValues.HereBehavior_UseHere;
                break;
            default:
                break;
          }
        return TypeHereBehaviorKnownValues.HereBehavior__none;
      }

    public static string  stringFromHereBehavior(TypeHereBehaviorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeHereBehaviorKnownValues.HereBehavior_UseHere:
                return "UseHere";
            case TypeHereBehaviorKnownValues.HereBehavior_AskWhenNoHere:
                return "AskWhenNoHere";
            case TypeHereBehaviorKnownValues.HereBehavior_AskAlways:
                return "AskAlways";
            case TypeHereBehaviorKnownValues.HereBehavior_DoNotMatch:
                return "DoNotMatch";
            case TypeHereBehaviorKnownValues.HereBehavior_HereAsAll:
                return "HereAsAll";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeAmbiguousMatchBehaviorKnownValues
      {
        AmbiguousMatchBehavior_ReturnAllMatches,
        AmbiguousMatchBehavior_AskAlways,
        AmbiguousMatchBehavior__none
      };
    public struct TypeAmbiguousMatchBehavior
      {
        public bool in_known_list;
        public string string_value;
        public TypeAmbiguousMatchBehaviorKnownValues list_value;
      };

    public static TypeAmbiguousMatchBehaviorKnownValues  stringToAmbiguousMatchBehavior(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "skAlways", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_AskAlways;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eturnAllMatches", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_ReturnAllMatches;
                break;
            default:
                break;
          }
        return TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior__none;
      }

    public static string  stringFromAmbiguousMatchBehavior(TypeAmbiguousMatchBehaviorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_ReturnAllMatches:
                return "ReturnAllMatches";
            case TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_AskAlways:
                return "AskAlways";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeSupportedPhrasingJSON : JSONBase
      {
        private bool flagHasTypes;
        private List< HomeAutomationDeviceTypeJSON  > storeTypes;
        private bool flagHasOperations;
        private List< HomeAutomationOperationJSON  > storeOperations;
        private bool flagHasProperties;
        private List< HomeAutomationPropertyJSON  > storeProperties;
        private bool flagHasAllowControlCommands;
        private bool storeAllowControlCommands;
        private bool flagHasAllowQueryCommands;
        private bool storeAllowQueryCommands;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTypes(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Types of TypeSupportedPhrasingJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< HomeAutomationDeviceTypeJSON  > vector_Types1 = new List< HomeAutomationDeviceTypeJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                HomeAutomationDeviceTypeJSON convert_classy = HomeAutomationDeviceTypeJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Types1.Add(convert_classy);
              }
            initTypes();
            for (int num1 = 0; num1 < vector_Types1.Count; ++num1)
                appendTypes(vector_Types1[num1]);
            for (int num1 = 0; num1 < vector_Types1.Count; ++num1)
              {
              }
          }


        private void  fromJSONOperations(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Operations of TypeSupportedPhrasingJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< HomeAutomationOperationJSON  > vector_Operations1 = new List< HomeAutomationOperationJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                HomeAutomationOperationJSON convert_classy = HomeAutomationOperationJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Operations1.Add(convert_classy);
              }
            initOperations();
            for (int num2 = 0; num2 < vector_Operations1.Count; ++num2)
                appendOperations(vector_Operations1[num2]);
            for (int num1 = 0; num1 < vector_Operations1.Count; ++num1)
              {
              }
          }


        private void  fromJSONProperties(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Properties of TypeSupportedPhrasingJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< HomeAutomationPropertyJSON  > vector_Properties1 = new List< HomeAutomationPropertyJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                HomeAutomationPropertyJSON convert_classy = HomeAutomationPropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Properties1.Add(convert_classy);
              }
            initProperties();
            for (int num3 = 0; num3 < vector_Properties1.Count; ++num3)
                appendProperties(vector_Properties1[num3]);
            for (int num1 = 0; num1 < vector_Properties1.Count; ++num1)
              {
              }
          }


        private void  fromJSONAllowControlCommands(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AllowControlCommands of TypeSupportedPhrasingJSON is not true for false.");
                  }
              }
            setAllowControlCommands(the_bool);
          }


        private void  fromJSONAllowQueryCommands(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AllowQueryCommands of TypeSupportedPhrasingJSON is not true for false.");
                  }
              }
            setAllowQueryCommands(the_bool);
          }


        public TypeSupportedPhrasingJSON()
          {
            flagHasTypes = false;
            flagHasOperations = false;
            flagHasProperties = false;
            flagHasAllowControlCommands = false;
            flagHasAllowQueryCommands = false;
            storeTypes = new List< HomeAutomationDeviceTypeJSON  >();
            storeOperations = new List< HomeAutomationOperationJSON  >();
            storeProperties = new List< HomeAutomationPropertyJSON  >();
            storeAllowControlCommands = true;
            storeAllowQueryCommands = true;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTypes()
          {
            return flagHasTypes;
          }

        public int  countOfTypes()
          {
            Debug.Assert(flagHasTypes);
            return storeTypes.Count;
          }

        public HomeAutomationDeviceTypeJSON   elementOfTypes(int element_num)
          {
            Debug.Assert(flagHasTypes);
            return storeTypes[element_num];
          }

        public List< HomeAutomationDeviceTypeJSON  >  getTypes()
          {
            Debug.Assert(flagHasTypes);
            return storeTypes;
          }

        public bool  hasOperations()
          {
            return flagHasOperations;
          }

        public int  countOfOperations()
          {
            Debug.Assert(flagHasOperations);
            return storeOperations.Count;
          }

        public HomeAutomationOperationJSON   elementOfOperations(int element_num)
          {
            Debug.Assert(flagHasOperations);
            return storeOperations[element_num];
          }

        public List< HomeAutomationOperationJSON  >  getOperations()
          {
            Debug.Assert(flagHasOperations);
            return storeOperations;
          }

        public bool  hasProperties()
          {
            return flagHasProperties;
          }

        public int  countOfProperties()
          {
            Debug.Assert(flagHasProperties);
            return storeProperties.Count;
          }

        public HomeAutomationPropertyJSON   elementOfProperties(int element_num)
          {
            Debug.Assert(flagHasProperties);
            return storeProperties[element_num];
          }

        public List< HomeAutomationPropertyJSON  >  getProperties()
          {
            Debug.Assert(flagHasProperties);
            return storeProperties;
          }

        public bool  hasAllowControlCommands()
          {
            return flagHasAllowControlCommands;
          }

        public bool  getAllowControlCommands()
          {
            return storeAllowControlCommands;
          }

        public bool  hasAllowQueryCommands()
          {
            return flagHasAllowQueryCommands;
          }

        public bool  getAllowQueryCommands()
          {
            return storeAllowQueryCommands;
          }


        public virtual int extraTypeSupportedPhrasingComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSupportedPhrasingComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSupportedPhrasingComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSupportedPhrasingLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initTypes()
          {
            if (flagHasTypes)
              {
                for (int num1 = 0; num1 < storeTypes.Count; ++num1)
                  {
                  }
              }
            flagHasTypes = true;
            storeTypes.Clear();
          }
        public void appendTypes(HomeAutomationDeviceTypeJSON  to_append)
          {
            if (!flagHasTypes)
              {
                flagHasTypes = true;
                storeTypes.Clear();
              }
            Debug.Assert(flagHasTypes);
            storeTypes.Add(to_append);
          }
        public void appendTypes(HomeAutomationDeviceTypeJSON.TypeValue new_value)
          {
            appendTypes(new HomeAutomationDeviceTypeJSON(new_value));
          }
        public void appendTypes(string chars)
          {
            HomeAutomationDeviceTypeJSON.TypeValueKnownValues known = HomeAutomationDeviceTypeJSON.stringToValue(chars);
            HomeAutomationDeviceTypeJSON.TypeValue new_value = new HomeAutomationDeviceTypeJSON.TypeValue();
            if (known == HomeAutomationDeviceTypeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            appendTypes(new_value);
          }
        public void unsetTypes()
          {
            if (flagHasTypes)
              {
                for (int num2 = 0; num2 < storeTypes.Count; ++num2)
                  {
                  }
              }
            flagHasTypes = false;
            storeTypes.Clear();
          }
        public void initOperations()
          {
            if (flagHasOperations)
              {
                for (int num3 = 0; num3 < storeOperations.Count; ++num3)
                  {
                  }
              }
            flagHasOperations = true;
            storeOperations.Clear();
          }
        public void appendOperations(HomeAutomationOperationJSON  to_append)
          {
            if (!flagHasOperations)
              {
                flagHasOperations = true;
                storeOperations.Clear();
              }
            Debug.Assert(flagHasOperations);
            storeOperations.Add(to_append);
          }
        public void appendOperations(HomeAutomationOperationJSON.TypeValue new_value)
          {
            appendOperations(new HomeAutomationOperationJSON(new_value));
          }
        public void appendOperations(string chars)
          {
            HomeAutomationOperationJSON.TypeValueKnownValues known = HomeAutomationOperationJSON.stringToValue(chars);
            HomeAutomationOperationJSON.TypeValue new_value = new HomeAutomationOperationJSON.TypeValue();
            if (known == HomeAutomationOperationJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            appendOperations(new_value);
          }
        public void unsetOperations()
          {
            if (flagHasOperations)
              {
                for (int num4 = 0; num4 < storeOperations.Count; ++num4)
                  {
                  }
              }
            flagHasOperations = false;
            storeOperations.Clear();
          }
        public void initProperties()
          {
            if (flagHasProperties)
              {
                for (int num5 = 0; num5 < storeProperties.Count; ++num5)
                  {
                  }
              }
            flagHasProperties = true;
            storeProperties.Clear();
          }
        public void appendProperties(HomeAutomationPropertyJSON  to_append)
          {
            if (!flagHasProperties)
              {
                flagHasProperties = true;
                storeProperties.Clear();
              }
            Debug.Assert(flagHasProperties);
            storeProperties.Add(to_append);
          }
        public void appendProperties(HomeAutomationPropertyJSON.TypeValue new_value)
          {
            appendProperties(new HomeAutomationPropertyJSON(new_value));
          }
        public void appendProperties(string chars)
          {
            HomeAutomationPropertyJSON.TypeValueKnownValues known = HomeAutomationPropertyJSON.stringToValue(chars);
            HomeAutomationPropertyJSON.TypeValue new_value = new HomeAutomationPropertyJSON.TypeValue();
            if (known == HomeAutomationPropertyJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            appendProperties(new_value);
          }
        public void unsetProperties()
          {
            if (flagHasProperties)
              {
                for (int num6 = 0; num6 < storeProperties.Count; ++num6)
                  {
                  }
              }
            flagHasProperties = false;
            storeProperties.Clear();
          }
        public void setAllowControlCommands(bool new_value)
          {
            flagHasAllowControlCommands = true;
            storeAllowControlCommands = new_value;
          }
        public void unsetAllowControlCommands()
          {
            flagHasAllowControlCommands = false;
          }
        public void setAllowQueryCommands(bool new_value)
          {
            flagHasAllowQueryCommands = true;
            storeAllowQueryCommands = new_value;
          }
        public void unsetAllowQueryCommands()
          {
            flagHasAllowQueryCommands = false;
          }

        public virtual void extraTypeSupportedPhrasingAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSupportedPhrasingSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSupportedPhrasingLookup(key);
            if (old_field == null)
              {
                extraTypeSupportedPhrasingAppendPair(key, new_component);
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
            if (flagHasTypes)
              {
                handler.start_pair("Types");
                handler.start_array();
                for (int num1 = 0; num1 < storeTypes.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeTypes[num1].write_partial_as_json(handler);
                    else
                        storeTypes[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasOperations)
              {
                handler.start_pair("Operations");
                handler.start_array();
                for (int num2 = 0; num2 < storeOperations.Count; ++num2)
                  {
                    if (partial_allowed)
                        storeOperations[num2].write_partial_as_json(handler);
                    else
                        storeOperations[num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasProperties)
              {
                handler.start_pair("Properties");
                handler.start_array();
                for (int num3 = 0; num3 < storeProperties.Count; ++num3)
                  {
                    if (partial_allowed)
                        storeProperties[num3].write_partial_as_json(handler);
                    else
                        storeProperties[num3].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasAllowControlCommands)
              {
                handler.start_pair("AllowControlCommands");
                handler.boolean_value(storeAllowControlCommands);
              }
            if (flagHasAllowQueryCommands)
              {
                handler.start_pair("AllowQueryCommands");
                handler.boolean_value(storeAllowQueryCommands);
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

        public static TypeSupportedPhrasingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSupportedPhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSupportedPhrasing", ignore_extras);
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
        public static TypeSupportedPhrasingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSupportedPhrasingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSupportedPhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSupportedPhrasing", ignore_extras);
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
        public static TypeSupportedPhrasingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSupportedPhrasingJSON from_text(string text, bool ignore_extras)
          {
            TypeSupportedPhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSupportedPhrasing", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSupportedPhrasingJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSupportedPhrasingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSupportedPhrasingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSupportedPhrasing", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private HomeAutomationDeviceTypeJSON.HoldingArrayGenerator fieldGeneratorTypes;
            private HomeAutomationOperationJSON.HoldingArrayGenerator fieldGeneratorOperations;
            private HomeAutomationPropertyJSON.HoldingArrayGenerator fieldGeneratorProperties;
            private JSONHoldingBooleanGenerator fieldGeneratorAllowControlCommands;
            private JSONHoldingBooleanGenerator fieldGeneratorAllowQueryCommands;
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
                TypeSupportedPhrasingJSON result = new TypeSupportedPhrasingJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSupportedPhrasingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSupportedPhrasingJSON result)
              {
                if (fieldGeneratorTypes.have_value)
                  {
                    result.initTypes();
                    int count = fieldGeneratorTypes.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTypes(fieldGeneratorTypes.value[num]);
                      }
                    fieldGeneratorTypes.value.Clear();
                    fieldGeneratorTypes.have_value = false;
                  }
                if (fieldGeneratorOperations.have_value)
                  {
                    result.initOperations();
                    int count = fieldGeneratorOperations.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendOperations(fieldGeneratorOperations.value[num]);
                      }
                    fieldGeneratorOperations.value.Clear();
                    fieldGeneratorOperations.have_value = false;
                  }
                if (fieldGeneratorProperties.have_value)
                  {
                    result.initProperties();
                    int count = fieldGeneratorProperties.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendProperties(fieldGeneratorProperties.value[num]);
                      }
                    fieldGeneratorProperties.value.Clear();
                    fieldGeneratorProperties.have_value = false;
                  }
                if (fieldGeneratorAllowControlCommands.have_value)
                  {
                    result.setAllowControlCommands(fieldGeneratorAllowControlCommands.value);
                    fieldGeneratorAllowControlCommands.have_value = false;
                  }
                if (fieldGeneratorAllowQueryCommands.have_value)
                  {
                    result.setAllowQueryCommands(fieldGeneratorAllowQueryCommands.value);
                    fieldGeneratorAllowQueryCommands.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSupportedPhrasingJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if (String.Compare(field_name, 1, "llow", 0, 4, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 6, "ontrolCommands", 0, 14, false) == 0) && (field_name.Length == 20))
                                        return fieldGeneratorAllowControlCommands;
                                    break;
                                case 'Q':
                                    if ((String.Compare(field_name, 6, "ueryCommands", 0, 12, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorAllowQueryCommands;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "perations", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorOperations;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "roperties", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorProperties;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ypes", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTypes;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTypes = new HomeAutomationDeviceTypeJSON.HoldingArrayGenerator("field \"Types\" of the TypeSupportedPhrasing class", ignore_extras);
                fieldGeneratorOperations = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Operations\" of the TypeSupportedPhrasing class", ignore_extras);
                fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the TypeSupportedPhrasing class", ignore_extras);
                fieldGeneratorAllowControlCommands = new JSONHoldingBooleanGenerator("field \"AllowControlCommands\" of the TypeSupportedPhrasing class");
                fieldGeneratorAllowQueryCommands = new JSONHoldingBooleanGenerator("field \"AllowQueryCommands\" of the TypeSupportedPhrasing class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSupportedPhrasing class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTypes = new HomeAutomationDeviceTypeJSON.HoldingArrayGenerator("field \"Types\" of the TypeSupportedPhrasing class", false);
                fieldGeneratorOperations = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Operations\" of the TypeSupportedPhrasing class", false);
                fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the TypeSupportedPhrasing class", false);
                fieldGeneratorAllowControlCommands = new JSONHoldingBooleanGenerator("field \"AllowControlCommands\" of the TypeSupportedPhrasing class");
                fieldGeneratorAllowQueryCommands = new JSONHoldingBooleanGenerator("field \"AllowQueryCommands\" of the TypeSupportedPhrasing class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSupportedPhrasing class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTypes.reset();
                fieldGeneratorOperations.reset();
                fieldGeneratorProperties.reset();
                fieldGeneratorAllowControlCommands.reset();
                fieldGeneratorAllowQueryCommands.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTypes.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorOperations.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorProperties.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTypes.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorOperations.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorProperties.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeSupportedPhrasingJSON  result)
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
            public TypeSupportedPhrasingJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSupportedPhrasingJSON  result)
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
        protected virtual void handle_result(List<TypeSupportedPhrasingJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSupportedPhrasingJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSupportedPhrasingJSON>();
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
        public List<TypeSupportedPhrasingJSON> value;
      };
      };
    private bool flagHasHereBehavior;
    private TypeHereBehavior storeHereBehavior;
    private bool flagHasHereDevices;
    private HomeAutomationDeviceListJSON  storeHereDevices;
    private bool flagHasHereGroups;
    private HomeAutomationGroupListJSON  storeHereGroups;
    private bool flagHasAmbiguousMatchBehavior;
    private TypeAmbiguousMatchBehavior storeAmbiguousMatchBehavior;
    private bool flagHasSupportedPhrasing;
    private TypeSupportedPhrasingJSON  storeSupportedPhrasing;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHereBehavior(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HereBehavior of HomeAutomationDomainSettingsJSON is not a string.");
        TypeHereBehavior the_open_enum = new TypeHereBehavior();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "sk", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 4, "lways", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeHereBehaviorKnownValues.HereBehavior_AskAlways;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 4, "henNoHere", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeHereBehaviorKnownValues.HereBehavior_AskWhenNoHere;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "oNotMatch", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeHereBehaviorKnownValues.HereBehavior_DoNotMatch;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ereAsAll", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeHereBehaviorKnownValues.HereBehavior_HereAsAll;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "seHere", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeHereBehaviorKnownValues.HereBehavior_UseHere;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setHereBehavior(the_open_enum);
      }


    private void  fromJSONHereDevices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceListJSON convert_classy = HomeAutomationDeviceListJSON.from_json(json_value, ignore_extras, true);
        setHereDevices(convert_classy);
      }


    private void  fromJSONHereGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationGroupListJSON convert_classy = HomeAutomationGroupListJSON.from_json(json_value, ignore_extras, true);
        setHereGroups(convert_classy);
      }


    private void  fromJSONAmbiguousMatchBehavior(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AmbiguousMatchBehavior of HomeAutomationDomainSettingsJSON is not a string.");
        TypeAmbiguousMatchBehavior the_open_enum = new TypeAmbiguousMatchBehavior();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "skAlways", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_AskAlways;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eturnAllMatches", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_ReturnAllMatches;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setAmbiguousMatchBehavior(the_open_enum);
      }


    private void  fromJSONSupportedPhrasing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSupportedPhrasingJSON convert_classy = TypeSupportedPhrasingJSON.from_json(json_value, ignore_extras, true);
        setSupportedPhrasing(convert_classy);
      }


    public HomeAutomationDomainSettingsJSON()
      {
        flagHasHereBehavior = false;
        flagHasHereDevices = false;
        flagHasHereGroups = false;
        flagHasAmbiguousMatchBehavior = false;
        flagHasSupportedPhrasing = false;
        storeHereBehavior.in_known_list = true;
        storeHereBehavior.list_value = TypeHereBehaviorKnownValues.HereBehavior_AskWhenNoHere;
        storeAmbiguousMatchBehavior.in_known_list = true;
        storeAmbiguousMatchBehavior.list_value = TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_AskAlways;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHereBehavior()
      {
        return flagHasHereBehavior;
      }

    public TypeHereBehavior  getHereBehavior()
      {
        return storeHereBehavior;
      }

    public string  getHereBehaviorAsString()
      {
        TypeHereBehavior result = getHereBehavior();
        if (result.in_known_list)
            return stringFromHereBehavior(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasHereDevices()
      {
        return flagHasHereDevices;
      }

    public HomeAutomationDeviceListJSON   getHereDevices()
      {
        Debug.Assert(flagHasHereDevices);
        return storeHereDevices;
      }

    public bool  hasHereGroups()
      {
        return flagHasHereGroups;
      }

    public HomeAutomationGroupListJSON   getHereGroups()
      {
        Debug.Assert(flagHasHereGroups);
        return storeHereGroups;
      }

    public bool  hasAmbiguousMatchBehavior()
      {
        return flagHasAmbiguousMatchBehavior;
      }

    public TypeAmbiguousMatchBehavior  getAmbiguousMatchBehavior()
      {
        return storeAmbiguousMatchBehavior;
      }

    public string  getAmbiguousMatchBehaviorAsString()
      {
        TypeAmbiguousMatchBehavior result = getAmbiguousMatchBehavior();
        if (result.in_known_list)
            return stringFromAmbiguousMatchBehavior(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSupportedPhrasing()
      {
        return flagHasSupportedPhrasing;
      }

    public TypeSupportedPhrasingJSON   getSupportedPhrasing()
      {
        Debug.Assert(flagHasSupportedPhrasing);
        return storeSupportedPhrasing;
      }


    public virtual int extraHomeAutomationDomainSettingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationDomainSettingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationDomainSettingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationDomainSettingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHereBehavior(TypeHereBehavior new_value)
      {
        flagHasHereBehavior = true;
        storeHereBehavior = new_value;
      }
    public void setHereBehavior(string chars)
      {
        TypeHereBehaviorKnownValues known = stringToHereBehavior(chars);
        TypeHereBehavior new_value = new TypeHereBehavior();
        if (known == TypeHereBehaviorKnownValues.HereBehavior__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setHereBehavior(new_value);
      }
    public void setHereBehavior(TypeHereBehaviorKnownValues new_value)
      {
        TypeHereBehavior new_full_value = new TypeHereBehavior();
        Debug.Assert(new_value != TypeHereBehaviorKnownValues.HereBehavior__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setHereBehavior(new_full_value);
      }
    public void unsetHereBehavior()
      {
        flagHasHereBehavior = false;
      }
    public void setHereDevices(HomeAutomationDeviceListJSON  new_value)
      {
        if (flagHasHereDevices)
          {
          }
        flagHasHereDevices = true;
        storeHereDevices = new_value;
      }
    public void unsetHereDevices()
      {
        if (flagHasHereDevices)
          {
          }
        flagHasHereDevices = false;
      }
    public void setHereGroups(HomeAutomationGroupListJSON  new_value)
      {
        if (flagHasHereGroups)
          {
          }
        flagHasHereGroups = true;
        storeHereGroups = new_value;
      }
    public void unsetHereGroups()
      {
        if (flagHasHereGroups)
          {
          }
        flagHasHereGroups = false;
      }
    public void setAmbiguousMatchBehavior(TypeAmbiguousMatchBehavior new_value)
      {
        flagHasAmbiguousMatchBehavior = true;
        storeAmbiguousMatchBehavior = new_value;
      }
    public void setAmbiguousMatchBehavior(string chars)
      {
        TypeAmbiguousMatchBehaviorKnownValues known = stringToAmbiguousMatchBehavior(chars);
        TypeAmbiguousMatchBehavior new_value = new TypeAmbiguousMatchBehavior();
        if (known == TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAmbiguousMatchBehavior(new_value);
      }
    public void setAmbiguousMatchBehavior(TypeAmbiguousMatchBehaviorKnownValues new_value)
      {
        TypeAmbiguousMatchBehavior new_full_value = new TypeAmbiguousMatchBehavior();
        Debug.Assert(new_value != TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setAmbiguousMatchBehavior(new_full_value);
      }
    public void unsetAmbiguousMatchBehavior()
      {
        flagHasAmbiguousMatchBehavior = false;
      }
    public void setSupportedPhrasing(TypeSupportedPhrasingJSON  new_value)
      {
        if (flagHasSupportedPhrasing)
          {
          }
        flagHasSupportedPhrasing = true;
        storeSupportedPhrasing = new_value;
      }
    public void unsetSupportedPhrasing()
      {
        if (flagHasSupportedPhrasing)
          {
          }
        flagHasSupportedPhrasing = false;
      }

    public virtual void extraHomeAutomationDomainSettingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationDomainSettingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationDomainSettingsLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationDomainSettingsAppendPair(key, new_component);
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
        if (flagHasHereBehavior)
          {
            handler.start_pair("HereBehavior");
            if (storeHereBehavior.in_known_list)
              {
                switch (storeHereBehavior.list_value)
                  {
                    case TypeHereBehaviorKnownValues.HereBehavior_UseHere:
                        handler.string_value("UseHere");
                        break;
                    case TypeHereBehaviorKnownValues.HereBehavior_AskWhenNoHere:
                        handler.string_value("AskWhenNoHere");
                        break;
                    case TypeHereBehaviorKnownValues.HereBehavior_AskAlways:
                        handler.string_value("AskAlways");
                        break;
                    case TypeHereBehaviorKnownValues.HereBehavior_DoNotMatch:
                        handler.string_value("DoNotMatch");
                        break;
                    case TypeHereBehaviorKnownValues.HereBehavior_HereAsAll:
                        handler.string_value("HereAsAll");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeHereBehavior.string_value);
              }
          }
        if (flagHasHereDevices)
          {
            handler.start_pair("HereDevices");
            if (partial_allowed)
                storeHereDevices.write_partial_as_json(handler);
            else
                storeHereDevices.write_as_json(handler);
          }
        if (flagHasHereGroups)
          {
            handler.start_pair("HereGroups");
            if (partial_allowed)
                storeHereGroups.write_partial_as_json(handler);
            else
                storeHereGroups.write_as_json(handler);
          }
        if (flagHasAmbiguousMatchBehavior)
          {
            handler.start_pair("AmbiguousMatchBehavior");
            if (storeAmbiguousMatchBehavior.in_known_list)
              {
                switch (storeAmbiguousMatchBehavior.list_value)
                  {
                    case TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_ReturnAllMatches:
                        handler.string_value("ReturnAllMatches");
                        break;
                    case TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior_AskAlways:
                        handler.string_value("AskAlways");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeAmbiguousMatchBehavior.string_value);
              }
          }
        if (flagHasSupportedPhrasing)
          {
            handler.start_pair("SupportedPhrasing");
            if (partial_allowed)
                storeSupportedPhrasing.write_partial_as_json(handler);
            else
                storeSupportedPhrasing.write_as_json(handler);
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

    public static HomeAutomationDomainSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDomainSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDomainSettings", ignore_extras);
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
    public static HomeAutomationDomainSettingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDomainSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDomainSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDomainSettings", ignore_extras);
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
    public static HomeAutomationDomainSettingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDomainSettingsJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationDomainSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDomainSettings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationDomainSettingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationDomainSettingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationDomainSettingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDomainSettings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorHereBehavior : JSONStringGenerator
          {
            protected FieldGeneratorHereBehavior(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHereBehavior()
              {
              }
            protected override void handle_result(string result)
              {
                TypeHereBehaviorKnownValues known = stringToHereBehavior(result);
                TypeHereBehavior new_value = new TypeHereBehavior();
                if (known == TypeHereBehaviorKnownValues.HereBehavior__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeHereBehavior result);
          };
    private class FieldHoldingGeneratorHereBehavior : FieldGeneratorHereBehavior
  {
    protected override void handle_result(TypeHereBehavior result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHereBehavior(String what)
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
    public TypeHereBehavior value;
  };
    private class FieldHoldingArrayGeneratorHereBehavior : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHereBehavior
      {
        private FieldHoldingArrayGeneratorHereBehavior top;

        protected override void handle_result(TypeHereBehavior result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHereBehavior init_top)
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
    protected virtual void handle_result(List<TypeHereBehavior> result)
      {
      }

    public FieldHoldingArrayGeneratorHereBehavior(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHereBehavior>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHereBehavior()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHereBehavior>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHereBehavior> value;
  };
        private FieldHoldingGeneratorHereBehavior fieldGeneratorHereBehavior;
        private HomeAutomationDeviceListJSON.HoldingGenerator fieldGeneratorHereDevices;
        private HomeAutomationGroupListJSON.HoldingGenerator fieldGeneratorHereGroups;
    private abstract class FieldGeneratorAmbiguousMatchBehavior : JSONStringGenerator
          {
            protected FieldGeneratorAmbiguousMatchBehavior(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAmbiguousMatchBehavior()
              {
              }
            protected override void handle_result(string result)
              {
                TypeAmbiguousMatchBehaviorKnownValues known = stringToAmbiguousMatchBehavior(result);
                TypeAmbiguousMatchBehavior new_value = new TypeAmbiguousMatchBehavior();
                if (known == TypeAmbiguousMatchBehaviorKnownValues.AmbiguousMatchBehavior__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeAmbiguousMatchBehavior result);
          };
    private class FieldHoldingGeneratorAmbiguousMatchBehavior : FieldGeneratorAmbiguousMatchBehavior
  {
    protected override void handle_result(TypeAmbiguousMatchBehavior result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAmbiguousMatchBehavior(String what)
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
    public TypeAmbiguousMatchBehavior value;
  };
    private class FieldHoldingArrayGeneratorAmbiguousMatchBehavior : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAmbiguousMatchBehavior
      {
        private FieldHoldingArrayGeneratorAmbiguousMatchBehavior top;

        protected override void handle_result(TypeAmbiguousMatchBehavior result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAmbiguousMatchBehavior init_top)
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
    protected virtual void handle_result(List<TypeAmbiguousMatchBehavior> result)
      {
      }

    public FieldHoldingArrayGeneratorAmbiguousMatchBehavior(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAmbiguousMatchBehavior>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAmbiguousMatchBehavior()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAmbiguousMatchBehavior>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAmbiguousMatchBehavior> value;
  };
        private FieldHoldingGeneratorAmbiguousMatchBehavior fieldGeneratorAmbiguousMatchBehavior;
        private TypeSupportedPhrasingJSON.HoldingGenerator fieldGeneratorSupportedPhrasing;
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
            HomeAutomationDomainSettingsJSON result = new HomeAutomationDomainSettingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationDomainSettingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationDomainSettingsJSON result)
          {
            if (fieldGeneratorHereBehavior.have_value)
              {
                result.setHereBehavior(fieldGeneratorHereBehavior.value);
                fieldGeneratorHereBehavior.have_value = false;
              }
            if (fieldGeneratorHereDevices.have_value)
              {
                result.setHereDevices(fieldGeneratorHereDevices.value);
                fieldGeneratorHereDevices.have_value = false;
              }
            if (fieldGeneratorHereGroups.have_value)
              {
                result.setHereGroups(fieldGeneratorHereGroups.value);
                fieldGeneratorHereGroups.have_value = false;
              }
            if (fieldGeneratorAmbiguousMatchBehavior.have_value)
              {
                result.setAmbiguousMatchBehavior(fieldGeneratorAmbiguousMatchBehavior.value);
                fieldGeneratorAmbiguousMatchBehavior.have_value = false;
              }
            if (fieldGeneratorSupportedPhrasing.have_value)
              {
                result.setSupportedPhrasing(fieldGeneratorSupportedPhrasing.value);
                fieldGeneratorSupportedPhrasing.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationDomainSettingsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mbiguousMatchBehavior", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorAmbiguousMatchBehavior;
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "ere", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 5, "ehavior", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorHereBehavior;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 5, "evices", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorHereDevices;
                                break;
                            case 'G':
                                if ((String.Compare(field_name, 5, "roups", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorHereGroups;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "upportedPhrasing", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorSupportedPhrasing;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHereBehavior = new FieldHoldingGeneratorHereBehavior("field \"HereBehavior\" of the HomeAutomationDomainSettings class");
            fieldGeneratorHereDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"HereDevices\" of the HomeAutomationDomainSettings class", ignore_extras);
            fieldGeneratorHereGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"HereGroups\" of the HomeAutomationDomainSettings class", ignore_extras);
            fieldGeneratorAmbiguousMatchBehavior = new FieldHoldingGeneratorAmbiguousMatchBehavior("field \"AmbiguousMatchBehavior\" of the HomeAutomationDomainSettings class");
            fieldGeneratorSupportedPhrasing = new TypeSupportedPhrasingJSON.HoldingGenerator("field \"SupportedPhrasing\" of the HomeAutomationDomainSettings class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationDomainSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHereBehavior = new FieldHoldingGeneratorHereBehavior("field \"HereBehavior\" of the HomeAutomationDomainSettings class");
            fieldGeneratorHereDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"HereDevices\" of the HomeAutomationDomainSettings class", false);
            fieldGeneratorHereGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"HereGroups\" of the HomeAutomationDomainSettings class", false);
            fieldGeneratorAmbiguousMatchBehavior = new FieldHoldingGeneratorAmbiguousMatchBehavior("field \"AmbiguousMatchBehavior\" of the HomeAutomationDomainSettings class");
            fieldGeneratorSupportedPhrasing = new TypeSupportedPhrasingJSON.HoldingGenerator("field \"SupportedPhrasing\" of the HomeAutomationDomainSettings class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationDomainSettings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHereBehavior.reset();
            fieldGeneratorHereDevices.reset();
            fieldGeneratorHereGroups.reset();
            fieldGeneratorAmbiguousMatchBehavior.reset();
            fieldGeneratorSupportedPhrasing.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHereDevices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHereGroups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSupportedPhrasing.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHereDevices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHereGroups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSupportedPhrasing.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationDomainSettingsJSON  result)
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
        public HomeAutomationDomainSettingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationDomainSettingsJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationDomainSettingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationDomainSettingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationDomainSettingsJSON>();
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
    public List<HomeAutomationDomainSettingsJSON> value;
  };
  };
