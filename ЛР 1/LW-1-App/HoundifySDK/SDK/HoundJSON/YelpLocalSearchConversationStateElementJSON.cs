/* file "YelpLocalSearchConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class YelpLocalSearchConversationStateElementJSON : LocalSearchConversationStateElementJSON
  {
    public enum TypeCommandKind
      {
        CommandKind_LocalSearchCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "LocalSearchCommand", 0, 18, false) == 0) && (chars.Length == 18))
            return TypeCommandKind.CommandKind_LocalSearchCommand;
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_LocalSearchCommand:
                return "LocalSearchCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeLocalSearchCommandKind
      {
        LocalSearchCommandKind_ShowList
      };

    public static TypeLocalSearchCommandKind  stringToLocalSearchCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ShowList", 0, 8, false) == 0) && (chars.Length == 8))
            return TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList;
        throw new Exception("The value for field `LocalSearchCommandKind' is not one of the legal values.");
      }

    public static string  stringFromLocalSearchCommandKind(TypeLocalSearchCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList:
                return "ShowList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeResultIDsJSON : JSONBase
      {
        private bool flagHasYelpID;
        private string storeYelpID;
        private bool flagHasAuxiliaryID;
        private BigInteger storeAuxiliaryID;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONYelpID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field YelpID of TypeResultIDsJSON is not a string.");
            setYelpID(json_string.getData());
          }


        private void  fromJSONAuxiliaryID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field AuxiliaryID of TypeResultIDsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field AuxiliaryID of TypeResultIDsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setAuxiliaryID(extracted_integer);
          }


        public TypeResultIDsJSON()
          {
            flagHasYelpID = false;
            flagHasAuxiliaryID = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasYelpID()
          {
            return flagHasYelpID;
          }

        public string  getYelpID()
          {
            Debug.Assert(flagHasYelpID);
            return storeYelpID;
          }

        public bool  hasAuxiliaryID()
          {
            return flagHasAuxiliaryID;
          }

        public BigInteger  getAuxiliaryID()
          {
            Debug.Assert(flagHasAuxiliaryID);
            return storeAuxiliaryID;
          }


        public virtual int extraTypeResultIDsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeResultIDsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeResultIDsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeResultIDsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setYelpID(string new_value)
          {
            flagHasYelpID = true;
            storeYelpID = new_value;
          }
        public void unsetYelpID()
          {
            flagHasYelpID = false;
          }
        public void setAuxiliaryID(BigInteger new_value)
          {
            flagHasAuxiliaryID = true;
            if (new_value < 0)
                throw new Exception("The value for field AuxiliaryID of TypeResultIDsJSON is less than the lower bound (0) for that field.");
            storeAuxiliaryID = new_value;
          }
        public void unsetAuxiliaryID()
          {
            flagHasAuxiliaryID = false;
          }

        public virtual void extraTypeResultIDsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeResultIDsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeResultIDsLookup(key);
            if (old_field == null)
              {
                extraTypeResultIDsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasYelpID);
            if (flagHasYelpID)
              {
                handler.start_pair("YelpID");
                handler.string_value(storeYelpID);
              }
            if (flagHasAuxiliaryID)
              {
                handler.start_pair("AuxiliaryID");
                handler.number_value(storeAuxiliaryID);
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
            if (!(hasYelpID()))
              {
                return "When parsing the object for %what%, the \"YelpID\" field was missing.";
              }
            return null;
          }

        public static TypeResultIDsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeResultIDsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeResultIDs", ignore_extras);
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
        public static TypeResultIDsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeResultIDsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeResultIDsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeResultIDs", ignore_extras);
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
        public static TypeResultIDsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeResultIDsJSON from_text(string text, bool ignore_extras)
          {
            TypeResultIDsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeResultIDs", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeResultIDsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeResultIDsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeResultIDsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeResultIDs", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorYelpID;
        private class FieldHoldingGeneratorAuxiliaryID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorAuxiliaryID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorAuxiliaryID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorAuxiliaryID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorAuxiliaryID fieldGeneratorAuxiliaryID;
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
                TypeResultIDsJSON result = new TypeResultIDsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeResultIDsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeResultIDsJSON result)
              {
                if (fieldGeneratorYelpID.have_value)
                  {
                    result.setYelpID(fieldGeneratorYelpID.value);
                    fieldGeneratorYelpID.have_value = false;
                  }
                else if ((!(result.hasYelpID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"YelpID\" field was missing.");
                  }
                if (fieldGeneratorAuxiliaryID.have_value)
                  {
                    result.setAuxiliaryID(fieldGeneratorAuxiliaryID.value);
                    fieldGeneratorAuxiliaryID.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeResultIDsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "uxiliaryID", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorAuxiliaryID;
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "elpID", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorYelpID;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorYelpID = new JSONHoldingStringGenerator("field \"YelpID\" of the TypeResultIDs class");
                fieldGeneratorAuxiliaryID = new FieldHoldingGeneratorAuxiliaryID("field \"AuxiliaryID\" of the TypeResultIDs class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeResultIDs class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorYelpID = new JSONHoldingStringGenerator("field \"YelpID\" of the TypeResultIDs class");
                fieldGeneratorAuxiliaryID = new FieldHoldingGeneratorAuxiliaryID("field \"AuxiliaryID\" of the TypeResultIDs class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeResultIDs class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorYelpID.reset();
                fieldGeneratorAuxiliaryID.reset();
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
            protected override void handle_result(TypeResultIDsJSON  result)
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
            public TypeResultIDsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeResultIDsJSON  result)
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
        protected virtual void handle_result(List<TypeResultIDsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeResultIDsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeResultIDsJSON>();
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
        public List<TypeResultIDsJSON> value;
      };
      };
    private bool flagHasCommandKind;
    private bool flagHasLocalSearchCommandKind;
    private bool flagHasLocalSearchCriteria;
    private LocalSearchFilterSpecJSON  storeLocalSearchCriteria;
    private bool flagHasResultIDs;
    private List< TypeResultIDsJSON  > storeResultIDs;


    private JSONValue  extraCommandKindToJSON()
      {
        JSONStringValue generated_string_CommandKind;
        generated_string_CommandKind = new JSONStringValue("LocalSearchCommand");
        return generated_string_CommandKind;
      }

    private JSONValue  extraLocalSearchCommandKindToJSON()
      {
        JSONStringValue generated_string_LocalSearchCommandKind;
        generated_string_LocalSearchCommandKind = new JSONStringValue("ShowList");
        return generated_string_LocalSearchCommandKind;
      }

    private JSONValue  extraLocalSearchCriteriaToJSON()
      {
        JSONValueHandler handler_LocalSearchCriteria = new JSONValueHandler();
        storeLocalSearchCriteria.write_as_json(handler_LocalSearchCriteria);
        return handler_LocalSearchCriteria.result;
      }

    private JSONValue  extraResultIDsToJSON()
      {
        JSONArrayValue generated_array_1_ResultIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeResultIDs.Count; ++num1)
          {
            JSONValueHandler handler_ResultIDs = new JSONValueHandler();
            storeResultIDs[num1].write_as_json(handler_ResultIDs);
            generated_array_1_ResultIDs.appendComponent(handler_ResultIDs.result);
          }
        return generated_array_1_ResultIDs;
      }


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of YelpLocalSearchConversationStateElementJSON is not a string.");
        if (!(json_string.getData().Equals("LocalSearchCommand")))
            throw new Exception("The value for field CommandKind of YelpLocalSearchConversationStateElementJSON is not `LocalSearchCommand'.");
        setCommandKind();
      }


    private void  fromJSONLocalSearchCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalSearchCommandKind of YelpLocalSearchConversationStateElementJSON is not a string.");
        if (!(json_string.getData().Equals("ShowList")))
            throw new Exception("The value for field LocalSearchCommandKind of YelpLocalSearchConversationStateElementJSON is not `ShowList'.");
        setLocalSearchCommandKind();
      }


    private void  fromJSONLocalSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchFilterSpecJSON convert_classy = LocalSearchFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setLocalSearchCriteria(convert_classy);
      }


    private void  fromJSONResultIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ResultIDs of YelpLocalSearchConversationStateElementJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeResultIDsJSON  > vector_ResultIDs1 = new List< TypeResultIDsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeResultIDsJSON convert_classy = TypeResultIDsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ResultIDs1.Add(convert_classy);
          }
        initResultIDs();
        for (int num1 = 0; num1 < vector_ResultIDs1.Count; ++num1)
            appendResultIDs(vector_ResultIDs1[num1]);
        for (int num1 = 0; num1 < vector_ResultIDs1.Count; ++num1)
          {
          }
      }


    public YelpLocalSearchConversationStateElementJSON()
      {
        flagHasCommandKind = false;
        flagHasLocalSearchCommandKind = false;
        flagHasLocalSearchCriteria = false;
        flagHasResultIDs = false;
        storeResultIDs = new List< TypeResultIDsJSON  >();
      }

    public override string  getLocalSearchKind()
      {
        return "YelpLocalSearch";
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return TypeCommandKind.CommandKind_LocalSearchCommand;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasLocalSearchCommandKind()
      {
        return flagHasLocalSearchCommandKind;
      }

    public TypeLocalSearchCommandKind  getLocalSearchCommandKind()
      {
        Debug.Assert(flagHasLocalSearchCommandKind);
        return TypeLocalSearchCommandKind.LocalSearchCommandKind_ShowList;
      }

    public string  getLocalSearchCommandKindAsString()
      {
        return stringFromLocalSearchCommandKind(getLocalSearchCommandKind());
      }

    public bool  hasLocalSearchCriteria()
      {
        return flagHasLocalSearchCriteria;
      }

    public LocalSearchFilterSpecJSON   getLocalSearchCriteria()
      {
        Debug.Assert(flagHasLocalSearchCriteria);
        return storeLocalSearchCriteria;
      }

    public bool  hasResultIDs()
      {
        return flagHasResultIDs;
      }

    public int  countOfResultIDs()
      {
        Debug.Assert(flagHasResultIDs);
        return storeResultIDs.Count;
      }

    public TypeResultIDsJSON   elementOfResultIDs(int element_num)
      {
        Debug.Assert(flagHasResultIDs);
        return storeResultIDs[element_num];
      }

    public List< TypeResultIDsJSON  >  getResultIDs()
      {
        Debug.Assert(flagHasResultIDs);
        return storeResultIDs;
      }


    public override int extraLocalSearchConversationStateElementComponentCount()
      {
        int result = 0;
        if (flagHasCommandKind)
            ++result;
        if (flagHasLocalSearchCommandKind)
            ++result;
        if (flagHasLocalSearchCriteria)
            ++result;
        if (flagHasResultIDs)
            ++result;
        return result;
      }
    public override string extraLocalSearchConversationStateElementComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandKind)
          {
            if (remainder == 0)
                return "CommandKind";
            --remainder;
          }
        if (flagHasLocalSearchCommandKind)
          {
            if (remainder == 0)
                return "LocalSearchCommandKind";
            --remainder;
          }
        if (flagHasLocalSearchCriteria)
          {
            if (remainder == 0)
                return "LocalSearchCriteria";
            --remainder;
          }
        if (flagHasResultIDs)
          {
            if (remainder == 0)
                return "ResultIDs";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraLocalSearchConversationStateElementComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandKind)
          {
            if (remainder == 0)
                return extraCommandKindToJSON();
            --remainder;
          }
        if (flagHasLocalSearchCommandKind)
          {
            if (remainder == 0)
                return extraLocalSearchCommandKindToJSON();
            --remainder;
          }
        if (flagHasLocalSearchCriteria)
          {
            if (remainder == 0)
                return extraLocalSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasResultIDs)
          {
            if (remainder == 0)
                return extraResultIDsToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraLocalSearchConversationStateElementLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCommandKind ? extraCommandKindToJSON() : null);
                break;
            case 'L':
                if (String.Compare(field_name, 1, "ocalSearchC", 0, 11, false) == 0)
                  {
                    switch (field_name[12])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 13, "mmandKind", 0, 9, false) == 0) && (field_name.Length == 22))
                                return (flagHasLocalSearchCommandKind ? extraLocalSearchCommandKindToJSON() : null);
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 13, "iteria", 0, 6, false) == 0) && (field_name.Length == 19))
                                return (flagHasLocalSearchCriteria ? extraLocalSearchCriteriaToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esultIDs", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasResultIDs ? extraResultIDsToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void setCommandKind()
      {
        flagHasCommandKind = true;
      }
    public void setCommandKind(TypeCommandKind new_value)
      {
        setCommandKind();
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setLocalSearchCommandKind()
      {
        flagHasLocalSearchCommandKind = true;
      }
    public void setLocalSearchCommandKind(TypeLocalSearchCommandKind new_value)
      {
        setLocalSearchCommandKind();
      }
    public void setLocalSearchCommandKind(string chars)
      {
        setLocalSearchCommandKind(stringToLocalSearchCommandKind(chars));
      }
    public void unsetLocalSearchCommandKind()
      {
        flagHasLocalSearchCommandKind = false;
      }
    public void setLocalSearchCriteria(LocalSearchFilterSpecJSON  new_value)
      {
        if (flagHasLocalSearchCriteria)
          {
          }
        flagHasLocalSearchCriteria = true;
        storeLocalSearchCriteria = new_value;
      }
    public void unsetLocalSearchCriteria()
      {
        if (flagHasLocalSearchCriteria)
          {
          }
        flagHasLocalSearchCriteria = false;
      }
    public void initResultIDs()
      {
        if (flagHasResultIDs)
          {
            for (int num1 = 0; num1 < storeResultIDs.Count; ++num1)
              {
              }
          }
        flagHasResultIDs = true;
        storeResultIDs.Clear();
      }
    public void appendResultIDs(TypeResultIDsJSON  to_append)
      {
        if (!flagHasResultIDs)
          {
            flagHasResultIDs = true;
            storeResultIDs.Clear();
          }
        Debug.Assert(flagHasResultIDs);
        storeResultIDs.Add(to_append);
      }
    public void unsetResultIDs()
      {
        if (flagHasResultIDs)
          {
            for (int num2 = 0; num2 < storeResultIDs.Count; ++num2)
              {
              }
          }
        flagHasResultIDs = false;
        storeResultIDs.Clear();
      }

    public override void extraLocalSearchConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandKind", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandKind(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "ocalSearchC", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'o':
                            if ((String.Compare(key, 13, "mmandKind", 0, 9, false) == 0) && (key.Length == 22))
                                {
                                fromJSONLocalSearchCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'r':
                            if ((String.Compare(key, 13, "iteria", 0, 6, false) == 0) && (key.Length == 19))
                                {
                                fromJSONLocalSearchCriteria(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultIDs", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONResultIDs(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraLocalSearchConversationStateElementSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ommandKind", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCommandKind(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if (String.Compare(key, 1, "ocalSearchC", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'o':
                            if ((String.Compare(key, 13, "mmandKind", 0, 9, false) == 0) && (key.Length == 22))
                                {
                                fromJSONLocalSearchCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'r':
                            if ((String.Compare(key, 13, "iteria", 0, 6, false) == 0) && (key.Length == 19))
                                {
                                fromJSONLocalSearchCriteria(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultIDs", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONResultIDs(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasCommandKind);
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            handler.string_value("LocalSearchCommand");
          }
        Debug.Assert(partial_allowed || flagHasLocalSearchCommandKind);
        if (flagHasLocalSearchCommandKind)
          {
            handler.start_pair("LocalSearchCommandKind");
            handler.string_value("ShowList");
          }
        if (flagHasLocalSearchCriteria)
          {
            handler.start_pair("LocalSearchCriteria");
            if (partial_allowed)
                storeLocalSearchCriteria.write_partial_as_json(handler);
            else
                storeLocalSearchCriteria.write_as_json(handler);
          }
        if (flagHasResultIDs)
          {
            handler.start_pair("ResultIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeResultIDs.Count; ++num1)
              {
                if (partial_allowed)
                    storeResultIDs[num1].write_partial_as_json(handler);
                else
                    storeResultIDs[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCommandKind()))
          {
            return "When parsing the object for %what%, the \"CommandKind\" field was missing.";
          }
        if (!(hasLocalSearchCommandKind()))
          {
            return "When parsing the object for %what%, the \"LocalSearchCommandKind\" field was missing.";
          }
        return null;
      }

    public static new YelpLocalSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpLocalSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpLocalSearchConversationStateElement", ignore_extras);
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
    public static new YelpLocalSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new YelpLocalSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        YelpLocalSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpLocalSearchConversationStateElement", ignore_extras);
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
    public static new YelpLocalSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new YelpLocalSearchConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        YelpLocalSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpLocalSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for YelpLocalSearchConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new YelpLocalSearchConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        YelpLocalSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type YelpLocalSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : LocalSearchConversationStateElementJSON.Generator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
    private abstract class FieldGeneratorLocalSearchCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorLocalSearchCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLocalSearchCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLocalSearchCommandKind(result));
              }
            protected abstract void handle_result(TypeLocalSearchCommandKind result);
          };
    private class FieldHoldingGeneratorLocalSearchCommandKind : FieldGeneratorLocalSearchCommandKind
  {
    protected override void handle_result(TypeLocalSearchCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLocalSearchCommandKind(String what)
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
    public TypeLocalSearchCommandKind value;
  };
    private class FieldHoldingArrayGeneratorLocalSearchCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLocalSearchCommandKind
      {
        private FieldHoldingArrayGeneratorLocalSearchCommandKind top;

        protected override void handle_result(TypeLocalSearchCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLocalSearchCommandKind init_top)
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
    protected virtual void handle_result(List<TypeLocalSearchCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorLocalSearchCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalSearchCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLocalSearchCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalSearchCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLocalSearchCommandKind> value;
  };
        private FieldHoldingGeneratorLocalSearchCommandKind fieldGeneratorLocalSearchCommandKind;
        private LocalSearchFilterSpecJSON.HoldingGenerator fieldGeneratorLocalSearchCriteria;
        private TypeResultIDsJSON.HoldingArrayGenerator fieldGeneratorResultIDs;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getLocalSearchConversationStateElementJSONKey().Equals("YelpLocalSearch")))
                throw new Exception("The key field has a value other than `YelpLocalSearch'.");
            YelpLocalSearchConversationStateElementJSON result = new YelpLocalSearchConversationStateElementJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(LocalSearchConversationStateElementJSON new_result)
          {
            handle_result((YelpLocalSearchConversationStateElementJSON )new_result);
          }
        protected void finish(YelpLocalSearchConversationStateElementJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind();
                fieldGeneratorCommandKind.have_value = false;
              }
            else if ((!(result.hasCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandKind\" field was missing.");
              }
            if (fieldGeneratorLocalSearchCommandKind.have_value)
              {
                result.setLocalSearchCommandKind();
                fieldGeneratorLocalSearchCommandKind.have_value = false;
              }
            else if ((!(result.hasLocalSearchCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LocalSearchCommandKind\" field was missing.");
              }
            if (fieldGeneratorLocalSearchCriteria.have_value)
              {
                result.setLocalSearchCriteria(fieldGeneratorLocalSearchCriteria.value);
                fieldGeneratorLocalSearchCriteria.have_value = false;
              }
            if (fieldGeneratorResultIDs.have_value)
              {
                result.initResultIDs();
                int count = fieldGeneratorResultIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResultIDs(fieldGeneratorResultIDs.value[num]);
                  }
                fieldGeneratorResultIDs.value.Clear();
                fieldGeneratorResultIDs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(YelpLocalSearchConversationStateElementJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCommandKind;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ocalSearchC", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'o':
                                if ((String.Compare(field_name, 13, "mmandKind", 0, 9, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorLocalSearchCommandKind;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 13, "iteria", 0, 6, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorLocalSearchCriteria;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultIDs", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorResultIDs;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the YelpLocalSearchConversationStateElement class");
            fieldGeneratorLocalSearchCommandKind = new FieldHoldingGeneratorLocalSearchCommandKind("field \"LocalSearchCommandKind\" of the YelpLocalSearchConversationStateElement class");
            fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the YelpLocalSearchConversationStateElement class", ignore_extras);
            fieldGeneratorResultIDs = new TypeResultIDsJSON.HoldingArrayGenerator("field \"ResultIDs\" of the YelpLocalSearchConversationStateElement class", ignore_extras);
            set_what("the YelpLocalSearchConversationStateElement class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the YelpLocalSearchConversationStateElement class");
            fieldGeneratorLocalSearchCommandKind = new FieldHoldingGeneratorLocalSearchCommandKind("field \"LocalSearchCommandKind\" of the YelpLocalSearchConversationStateElement class");
            fieldGeneratorLocalSearchCriteria = new LocalSearchFilterSpecJSON.HoldingGenerator("field \"LocalSearchCriteria\" of the YelpLocalSearchConversationStateElement class", false);
            fieldGeneratorResultIDs = new TypeResultIDsJSON.HoldingArrayGenerator("field \"ResultIDs\" of the YelpLocalSearchConversationStateElement class", false);
            set_what("the YelpLocalSearchConversationStateElement class");
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorLocalSearchCommandKind.reset();
            fieldGeneratorLocalSearchCriteria.reset();
            fieldGeneratorResultIDs.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(YelpLocalSearchConversationStateElementJSON  result)
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
        public YelpLocalSearchConversationStateElementJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(YelpLocalSearchConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<YelpLocalSearchConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<YelpLocalSearchConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<YelpLocalSearchConversationStateElementJSON>();
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
    public List<YelpLocalSearchConversationStateElementJSON> value;
  };
  };
