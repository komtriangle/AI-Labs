/* file "DisambiguateCommunicationCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DisambiguateCommunicationCommandNativeDataJSON : DisambiguateCommandNativeDataJSON
  {
    public struct TypeContactResultChoices
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public SMSContactResultJSON  choice0;
            [FieldOffset(0)]
            public EmailContactResultJSON  choice1;
          };
        public Utype u;
      };
    public class TypeLastSelectedInfoAsStringsJSON : JSONBase
      {
        private bool flagHasSpoken;
        private string storeSpoken;
        private bool flagHasWritten;
        private string storeWritten;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSpoken(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Spoken of TypeLastSelectedInfoAsStringsJSON is not a string.");
            setSpoken(json_string.getData());
          }


        private void  fromJSONWritten(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Written of TypeLastSelectedInfoAsStringsJSON is not a string.");
            setWritten(json_string.getData());
          }


        public TypeLastSelectedInfoAsStringsJSON()
          {
            flagHasSpoken = false;
            flagHasWritten = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSpoken()
          {
            return flagHasSpoken;
          }

        public string  getSpoken()
          {
            Debug.Assert(flagHasSpoken);
            return storeSpoken;
          }

        public bool  hasWritten()
          {
            return flagHasWritten;
          }

        public string  getWritten()
          {
            Debug.Assert(flagHasWritten);
            return storeWritten;
          }


        public virtual int extraTypeLastSelectedInfoAsStringsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLastSelectedInfoAsStringsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLastSelectedInfoAsStringsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLastSelectedInfoAsStringsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSpoken(string new_value)
          {
            flagHasSpoken = true;
            storeSpoken = new_value;
          }
        public void unsetSpoken()
          {
            flagHasSpoken = false;
          }
        public void setWritten(string new_value)
          {
            flagHasWritten = true;
            storeWritten = new_value;
          }
        public void unsetWritten()
          {
            flagHasWritten = false;
          }

        public virtual void extraTypeLastSelectedInfoAsStringsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLastSelectedInfoAsStringsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLastSelectedInfoAsStringsLookup(key);
            if (old_field == null)
              {
                extraTypeLastSelectedInfoAsStringsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasSpoken);
            if (flagHasSpoken)
              {
                handler.start_pair("Spoken");
                handler.string_value(storeSpoken);
              }
            Debug.Assert(partial_allowed || flagHasWritten);
            if (flagHasWritten)
              {
                handler.start_pair("Written");
                handler.string_value(storeWritten);
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
            if (!(hasSpoken()))
              {
                return "When parsing the object for %what%, the \"Spoken\" field was missing.";
              }
            if (!(hasWritten()))
              {
                return "When parsing the object for %what%, the \"Written\" field was missing.";
              }
            return null;
          }

        public static TypeLastSelectedInfoAsStringsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLastSelectedInfoAsStringsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastSelectedInfoAsStrings", ignore_extras);
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
        public static TypeLastSelectedInfoAsStringsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLastSelectedInfoAsStringsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLastSelectedInfoAsStringsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastSelectedInfoAsStrings", ignore_extras);
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
        public static TypeLastSelectedInfoAsStringsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLastSelectedInfoAsStringsJSON from_text(string text, bool ignore_extras)
          {
            TypeLastSelectedInfoAsStringsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastSelectedInfoAsStrings", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLastSelectedInfoAsStringsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLastSelectedInfoAsStringsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLastSelectedInfoAsStringsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastSelectedInfoAsStrings", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorSpoken;
            private JSONHoldingStringGenerator fieldGeneratorWritten;
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
                TypeLastSelectedInfoAsStringsJSON result = new TypeLastSelectedInfoAsStringsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLastSelectedInfoAsStringsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLastSelectedInfoAsStringsJSON result)
              {
                if (fieldGeneratorSpoken.have_value)
                  {
                    result.setSpoken(fieldGeneratorSpoken.value);
                    fieldGeneratorSpoken.have_value = false;
                  }
                else if ((!(result.hasSpoken())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Spoken\" field was missing.");
                  }
                if (fieldGeneratorWritten.have_value)
                  {
                    result.setWritten(fieldGeneratorWritten.value);
                    fieldGeneratorWritten.have_value = false;
                  }
                else if ((!(result.hasWritten())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Written\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeLastSelectedInfoAsStringsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'S':
                        if ((String.Compare(field_name, 1, "poken", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorSpoken;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "ritten", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorWritten;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the TypeLastSelectedInfoAsStrings class");
                fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the TypeLastSelectedInfoAsStrings class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLastSelectedInfoAsStrings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the TypeLastSelectedInfoAsStrings class");
                fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the TypeLastSelectedInfoAsStrings class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLastSelectedInfoAsStrings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSpoken.reset();
                fieldGeneratorWritten.reset();
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
            protected override void handle_result(TypeLastSelectedInfoAsStringsJSON  result)
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
            public TypeLastSelectedInfoAsStringsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLastSelectedInfoAsStringsJSON  result)
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
        protected virtual void handle_result(List<TypeLastSelectedInfoAsStringsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLastSelectedInfoAsStringsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLastSelectedInfoAsStringsJSON>();
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
        public List<TypeLastSelectedInfoAsStringsJSON> value;
      };
      };
    private bool flagHasErrorSpokenResponse;
    private string storeErrorSpokenResponse;
    private bool flagHasErrorSpokenResponseLong;
    private string storeErrorSpokenResponseLong;
    private bool flagHasErrorWrittenResponse;
    private string storeErrorWrittenResponse;
    private bool flagHasErrorWrittenResponseLong;
    private string storeErrorWrittenResponseLong;
    private bool flagHasHadInvalidChoice;
    private bool storeHadInvalidChoice;
    private bool flagHasCommunicationType;
    private CommunicationTypeJSON  storeCommunicationType;
    private bool flagHasAutoListen;
    private bool storeAutoListen;
    private bool flagHasContactResultChoices;
    private List< TypeContactResultChoices > storeContactResultChoices;
    private bool flagHasLastSelectedInfoAsStrings;
    private List< TypeLastSelectedInfoAsStringsJSON  > storeLastSelectedInfoAsStrings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraErrorSpokenResponseToJSON()
      {
        JSONStringValue generated_string_ErrorSpokenResponse = new JSONStringValue(storeErrorSpokenResponse);
        return generated_string_ErrorSpokenResponse;
      }

    private JSONValue  extraErrorSpokenResponseLongToJSON()
      {
        JSONStringValue generated_string_ErrorSpokenResponseLong = new JSONStringValue(storeErrorSpokenResponseLong);
        return generated_string_ErrorSpokenResponseLong;
      }

    private JSONValue  extraErrorWrittenResponseToJSON()
      {
        JSONStringValue generated_string_ErrorWrittenResponse = new JSONStringValue(storeErrorWrittenResponse);
        return generated_string_ErrorWrittenResponse;
      }

    private JSONValue  extraErrorWrittenResponseLongToJSON()
      {
        JSONStringValue generated_string_ErrorWrittenResponseLong = new JSONStringValue(storeErrorWrittenResponseLong);
        return generated_string_ErrorWrittenResponseLong;
      }

    private JSONValue  extraHadInvalidChoiceToJSON()
      {
        JSONValue generated_boolean_HadInvalidChoice = (storeHadInvalidChoice ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_HadInvalidChoice;
      }

    private JSONValue  extraCommunicationTypeToJSON()
      {
        JSONValueHandler handler_CommunicationType = new JSONValueHandler();
        storeCommunicationType.write_as_json(handler_CommunicationType);
        return handler_CommunicationType.result;
      }

    private JSONValue  extraAutoListenToJSON()
      {
        JSONValue generated_boolean_AutoListen = (storeAutoListen ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_AutoListen;
      }

    private JSONValue  extraContactResultChoicesToJSON()
      {
        JSONArrayValue generated_array_1_ContactResultChoices = new JSONArrayValue();
        for (int num1 = 0; num1 < storeContactResultChoices.Count; ++num1)
          {
            JSONValue generated_or_ContactResultChoices;
            switch (storeContactResultChoices[num1].key)
              {
                case 0:
                  {
                    JSONValueHandler handler_ContactResultChoices = new JSONValueHandler();
                    storeContactResultChoices[num1].u.choice0.write_as_json(handler_ContactResultChoices);
                    generated_or_ContactResultChoices = handler_ContactResultChoices.result;
                    break;
                  }
                case 1:
                  {
                    JSONValueHandler handler_ContactResultChoices = new JSONValueHandler();
                    storeContactResultChoices[num1].u.choice1.write_as_json(handler_ContactResultChoices);
                    generated_or_ContactResultChoices = handler_ContactResultChoices.result;
                    break;
                  }
                default:
                    Debug.Assert(false);
                    generated_or_ContactResultChoices = null;
                    break;
              }
            generated_array_1_ContactResultChoices.appendComponent(generated_or_ContactResultChoices);
          }
        return generated_array_1_ContactResultChoices;
      }

    private JSONValue  extraLastSelectedInfoAsStringsToJSON()
      {
        JSONArrayValue generated_array_2_LastSelectedInfoAsStrings = new JSONArrayValue();
        for (int num2 = 0; num2 < storeLastSelectedInfoAsStrings.Count; ++num2)
          {
            JSONValueHandler handler_LastSelectedInfoAsStrings = new JSONValueHandler();
            storeLastSelectedInfoAsStrings[num2].write_as_json(handler_LastSelectedInfoAsStrings);
            generated_array_2_LastSelectedInfoAsStrings.appendComponent(handler_LastSelectedInfoAsStrings.result);
          }
        return generated_array_2_LastSelectedInfoAsStrings;
      }


    private void  fromJSONErrorSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorSpokenResponse of DisambiguateCommunicationCommandNativeDataJSON is not a string.");
        setErrorSpokenResponse(json_string.getData());
      }


    private void  fromJSONErrorSpokenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorSpokenResponseLong of DisambiguateCommunicationCommandNativeDataJSON is not a string.");
        setErrorSpokenResponseLong(json_string.getData());
      }


    private void  fromJSONErrorWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorWrittenResponse of DisambiguateCommunicationCommandNativeDataJSON is not a string.");
        setErrorWrittenResponse(json_string.getData());
      }


    private void  fromJSONErrorWrittenResponseLong(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorWrittenResponseLong of DisambiguateCommunicationCommandNativeDataJSON is not a string.");
        setErrorWrittenResponseLong(json_string.getData());
      }


    private void  fromJSONHadInvalidChoice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HadInvalidChoice of DisambiguateCommunicationCommandNativeDataJSON is not true for false.");
              }
          }
        setHadInvalidChoice(the_bool);
      }


    private void  fromJSONCommunicationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CommunicationTypeJSON convert_classy = CommunicationTypeJSON.from_json(json_value, ignore_extras, true);
        setCommunicationType(convert_classy);
      }


    private void  fromJSONAutoListen(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AutoListen of DisambiguateCommunicationCommandNativeDataJSON is not true for false.");
              }
          }
        setAutoListen(the_bool);
      }


    private void  fromJSONContactResultChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ContactResultChoices of DisambiguateCommunicationCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeContactResultChoices > vector_ContactResultChoices1 = new List< TypeContactResultChoices >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeContactResultChoices or_result = new TypeContactResultChoices();
            bool or_done = false;
            if (!or_done)
              {
                try
                  {
                    SMSContactResultJSON convert_classy = SMSContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    or_result.u.choice0 = convert_classy;
                    or_result.key = 0;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
              {
                try
                  {
                    EmailContactResultJSON convert_classy = EmailContactResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    or_result.u.choice1 = convert_classy;
                    or_result.key = 1;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
                throw new Exception("The value for an element of field ContactResultChoices of DisambiguateCommunicationCommandNativeDataJSON is not one of the allowed values.");
            vector_ContactResultChoices1.Add(or_result);
          }
        initContactResultChoices();
        for (int num1 = 0; num1 < vector_ContactResultChoices1.Count; ++num1)
            appendContactResultChoices(vector_ContactResultChoices1[num1]);
        for (int num1 = 0; num1 < vector_ContactResultChoices1.Count; ++num1)
          {
            switch (vector_ContactResultChoices1[num1].key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
      }


    private void  fromJSONLastSelectedInfoAsStrings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LastSelectedInfoAsStrings of DisambiguateCommunicationCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeLastSelectedInfoAsStringsJSON  > vector_LastSelectedInfoAsStrings1 = new List< TypeLastSelectedInfoAsStringsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeLastSelectedInfoAsStringsJSON convert_classy = TypeLastSelectedInfoAsStringsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LastSelectedInfoAsStrings1.Add(convert_classy);
          }
        initLastSelectedInfoAsStrings();
        for (int num2 = 0; num2 < vector_LastSelectedInfoAsStrings1.Count; ++num2)
            appendLastSelectedInfoAsStrings(vector_LastSelectedInfoAsStrings1[num2]);
        for (int num1 = 0; num1 < vector_LastSelectedInfoAsStrings1.Count; ++num1)
          {
          }
      }


    public DisambiguateCommunicationCommandNativeDataJSON()
      {
        flagHasErrorSpokenResponse = false;
        flagHasErrorSpokenResponseLong = false;
        flagHasErrorWrittenResponse = false;
        flagHasErrorWrittenResponseLong = false;
        flagHasHadInvalidChoice = false;
        flagHasCommunicationType = false;
        flagHasAutoListen = false;
        flagHasContactResultChoices = false;
        flagHasLastSelectedInfoAsStrings = false;
        storeContactResultChoices = new List< TypeContactResultChoices >();
        storeLastSelectedInfoAsStrings = new List< TypeLastSelectedInfoAsStringsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasErrorSpokenResponse()
      {
        return flagHasErrorSpokenResponse;
      }

    public string  getErrorSpokenResponse()
      {
        Debug.Assert(flagHasErrorSpokenResponse);
        return storeErrorSpokenResponse;
      }

    public bool  hasErrorSpokenResponseLong()
      {
        return flagHasErrorSpokenResponseLong;
      }

    public string  getErrorSpokenResponseLong()
      {
        Debug.Assert(flagHasErrorSpokenResponseLong);
        return storeErrorSpokenResponseLong;
      }

    public bool  hasErrorWrittenResponse()
      {
        return flagHasErrorWrittenResponse;
      }

    public string  getErrorWrittenResponse()
      {
        Debug.Assert(flagHasErrorWrittenResponse);
        return storeErrorWrittenResponse;
      }

    public bool  hasErrorWrittenResponseLong()
      {
        return flagHasErrorWrittenResponseLong;
      }

    public string  getErrorWrittenResponseLong()
      {
        Debug.Assert(flagHasErrorWrittenResponseLong);
        return storeErrorWrittenResponseLong;
      }

    public bool  hasHadInvalidChoice()
      {
        return flagHasHadInvalidChoice;
      }

    public bool  getHadInvalidChoice()
      {
        Debug.Assert(flagHasHadInvalidChoice);
        return storeHadInvalidChoice;
      }

    public bool  hasCommunicationType()
      {
        return flagHasCommunicationType;
      }

    public CommunicationTypeJSON   getCommunicationType()
      {
        Debug.Assert(flagHasCommunicationType);
        return storeCommunicationType;
      }

    public CommunicationTypeJSON.TypeValue  getCommunicationTypeValue()
      {
        return getCommunicationType().getValue();
      }

    public string  getCommunicationTypeAsString()
      {
        return getCommunicationType().getValueAsString();
      }

    public bool  hasAutoListen()
      {
        return flagHasAutoListen;
      }

    public bool  getAutoListen()
      {
        Debug.Assert(flagHasAutoListen);
        return storeAutoListen;
      }

    public bool  hasContactResultChoices()
      {
        return flagHasContactResultChoices;
      }

    public int  countOfContactResultChoices()
      {
        Debug.Assert(flagHasContactResultChoices);
        return storeContactResultChoices.Count;
      }

    public TypeContactResultChoices  elementOfContactResultChoices(int element_num)
      {
        Debug.Assert(flagHasContactResultChoices);
        return storeContactResultChoices[element_num];
      }

    public List< TypeContactResultChoices >  getContactResultChoices()
      {
        Debug.Assert(flagHasContactResultChoices);
        return storeContactResultChoices;
      }

    public bool  hasLastSelectedInfoAsStrings()
      {
        return flagHasLastSelectedInfoAsStrings;
      }

    public int  countOfLastSelectedInfoAsStrings()
      {
        Debug.Assert(flagHasLastSelectedInfoAsStrings);
        return storeLastSelectedInfoAsStrings.Count;
      }

    public TypeLastSelectedInfoAsStringsJSON   elementOfLastSelectedInfoAsStrings(int element_num)
      {
        Debug.Assert(flagHasLastSelectedInfoAsStrings);
        return storeLastSelectedInfoAsStrings[element_num];
      }

    public List< TypeLastSelectedInfoAsStringsJSON  >  getLastSelectedInfoAsStrings()
      {
        Debug.Assert(flagHasLastSelectedInfoAsStrings);
        return storeLastSelectedInfoAsStrings;
      }


    public virtual int extraDisambiguateCommunicationCommandNativeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDisambiguateCommunicationCommandNativeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDisambiguateCommunicationCommandNativeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDisambiguateCommunicationCommandNativeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDisambiguateCommandNativeDataComponentCount()
      {
        int result = 0;
        if (flagHasErrorSpokenResponse)
            ++result;
        if (flagHasErrorSpokenResponseLong)
            ++result;
        if (flagHasErrorWrittenResponse)
            ++result;
        if (flagHasErrorWrittenResponseLong)
            ++result;
        if (flagHasHadInvalidChoice)
            ++result;
        if (flagHasCommunicationType)
            ++result;
        if (flagHasAutoListen)
            ++result;
        if (flagHasContactResultChoices)
            ++result;
        if (flagHasLastSelectedInfoAsStrings)
            ++result;
        result += extraDisambiguateCommunicationCommandNativeDataComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandNativeDataComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasErrorSpokenResponse)
          {
            if (remainder == 0)
                return "ErrorSpokenResponse";
            --remainder;
          }
        if (flagHasErrorSpokenResponseLong)
          {
            if (remainder == 0)
                return "ErrorSpokenResponseLong";
            --remainder;
          }
        if (flagHasErrorWrittenResponse)
          {
            if (remainder == 0)
                return "ErrorWrittenResponse";
            --remainder;
          }
        if (flagHasErrorWrittenResponseLong)
          {
            if (remainder == 0)
                return "ErrorWrittenResponseLong";
            --remainder;
          }
        if (flagHasHadInvalidChoice)
          {
            if (remainder == 0)
                return "HadInvalidChoice";
            --remainder;
          }
        if (flagHasCommunicationType)
          {
            if (remainder == 0)
                return "CommunicationType";
            --remainder;
          }
        if (flagHasAutoListen)
          {
            if (remainder == 0)
                return "AutoListen";
            --remainder;
          }
        if (flagHasContactResultChoices)
          {
            if (remainder == 0)
                return "ContactResultChoices";
            --remainder;
          }
        if (flagHasLastSelectedInfoAsStrings)
          {
            if (remainder == 0)
                return "LastSelectedInfoAsStrings";
            --remainder;
          }
        return extraDisambiguateCommunicationCommandNativeDataComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandNativeDataComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasErrorSpokenResponse)
          {
            if (remainder == 0)
                return extraErrorSpokenResponseToJSON();
            --remainder;
          }
        if (flagHasErrorSpokenResponseLong)
          {
            if (remainder == 0)
                return extraErrorSpokenResponseLongToJSON();
            --remainder;
          }
        if (flagHasErrorWrittenResponse)
          {
            if (remainder == 0)
                return extraErrorWrittenResponseToJSON();
            --remainder;
          }
        if (flagHasErrorWrittenResponseLong)
          {
            if (remainder == 0)
                return extraErrorWrittenResponseLongToJSON();
            --remainder;
          }
        if (flagHasHadInvalidChoice)
          {
            if (remainder == 0)
                return extraHadInvalidChoiceToJSON();
            --remainder;
          }
        if (flagHasCommunicationType)
          {
            if (remainder == 0)
                return extraCommunicationTypeToJSON();
            --remainder;
          }
        if (flagHasAutoListen)
          {
            if (remainder == 0)
                return extraAutoListenToJSON();
            --remainder;
          }
        if (flagHasContactResultChoices)
          {
            if (remainder == 0)
                return extraContactResultChoicesToJSON();
            --remainder;
          }
        if (flagHasLastSelectedInfoAsStrings)
          {
            if (remainder == 0)
                return extraLastSelectedInfoAsStringsToJSON();
            --remainder;
          }
        return extraDisambiguateCommunicationCommandNativeDataComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandNativeDataLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "utoListen", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasAutoListen ? extraAutoListenToJSON() : null);
                break;
            case 'C':
                if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 3, "municationType", 0, 14, false) == 0) && (field_name.Length == 17))
                                return (flagHasCommunicationType ? extraCommunicationTypeToJSON() : null);
                            break;
                        case 'n':
                            if ((String.Compare(field_name, 3, "tactResultChoices", 0, 17, false) == 0) && (field_name.Length == 20))
                                return (flagHasContactResultChoices ? extraContactResultChoicesToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if (String.Compare(field_name, 1, "rror", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'S':
                            if (String.Compare(field_name, 6, "pokenResponse", 0, 13, false) == 0)
                              {
                                if (field_name.Length == 19)
                                  {
                                    return (flagHasErrorSpokenResponse ? extraErrorSpokenResponseToJSON() : null);
                                  }
                                switch (field_name[19])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 20, "ong", 0, 3, false) == 0) && (field_name.Length == 23))
                                            return (flagHasErrorSpokenResponseLong ? extraErrorSpokenResponseLongToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'W':
                            if (String.Compare(field_name, 6, "rittenResponse", 0, 14, false) == 0)
                              {
                                if (field_name.Length == 20)
                                  {
                                    return (flagHasErrorWrittenResponse ? extraErrorWrittenResponseToJSON() : null);
                                  }
                                switch (field_name[20])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 21, "ong", 0, 3, false) == 0) && (field_name.Length == 24))
                                            return (flagHasErrorWrittenResponseLong ? extraErrorWrittenResponseLongToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "adInvalidChoice", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasHadInvalidChoice ? extraHadInvalidChoiceToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "astSelectedInfoAsStrings", 0, 24, false) == 0) && (field_name.Length == 25))
                    return (flagHasLastSelectedInfoAsStrings ? extraLastSelectedInfoAsStringsToJSON() : null);
                break;
            default:
                break;
          }
        return extraDisambiguateCommunicationCommandNativeDataLookup(field_name);
      }

    public void setErrorSpokenResponse(string new_value)
      {
        flagHasErrorSpokenResponse = true;
        storeErrorSpokenResponse = new_value;
      }
    public void unsetErrorSpokenResponse()
      {
        flagHasErrorSpokenResponse = false;
      }
    public void setErrorSpokenResponseLong(string new_value)
      {
        flagHasErrorSpokenResponseLong = true;
        storeErrorSpokenResponseLong = new_value;
      }
    public void unsetErrorSpokenResponseLong()
      {
        flagHasErrorSpokenResponseLong = false;
      }
    public void setErrorWrittenResponse(string new_value)
      {
        flagHasErrorWrittenResponse = true;
        storeErrorWrittenResponse = new_value;
      }
    public void unsetErrorWrittenResponse()
      {
        flagHasErrorWrittenResponse = false;
      }
    public void setErrorWrittenResponseLong(string new_value)
      {
        flagHasErrorWrittenResponseLong = true;
        storeErrorWrittenResponseLong = new_value;
      }
    public void unsetErrorWrittenResponseLong()
      {
        flagHasErrorWrittenResponseLong = false;
      }
    public void setHadInvalidChoice(bool new_value)
      {
        flagHasHadInvalidChoice = true;
        storeHadInvalidChoice = new_value;
      }
    public void unsetHadInvalidChoice()
      {
        flagHasHadInvalidChoice = false;
      }
    public void setCommunicationType(CommunicationTypeJSON  new_value)
      {
        if (flagHasCommunicationType)
          {
          }
        flagHasCommunicationType = true;
        storeCommunicationType = new_value;
      }
    public void setCommunicationType(CommunicationTypeJSON.TypeValue new_value)
      {
        setCommunicationType(new CommunicationTypeJSON(new_value));
      }
    public void setCommunicationType(string chars)
      {
        setCommunicationType(new CommunicationTypeJSON(chars));
      }
    public void unsetCommunicationType()
      {
        if (flagHasCommunicationType)
          {
          }
        flagHasCommunicationType = false;
      }
    public void setAutoListen(bool new_value)
      {
        flagHasAutoListen = true;
        storeAutoListen = new_value;
      }
    public void unsetAutoListen()
      {
        flagHasAutoListen = false;
      }
    public void initContactResultChoices()
      {
        if (flagHasContactResultChoices)
          {
            for (int num1 = 0; num1 < storeContactResultChoices.Count; ++num1)
              {
                switch (storeContactResultChoices[num1].key)
                  {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
          }
        flagHasContactResultChoices = true;
        storeContactResultChoices.Clear();
      }
    public void appendContactResultChoices(TypeContactResultChoices to_append)
      {
        if (!flagHasContactResultChoices)
          {
            flagHasContactResultChoices = true;
            storeContactResultChoices.Clear();
          }
        Debug.Assert(flagHasContactResultChoices);
        switch (to_append.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeContactResultChoices.Add(to_append);
      }
    public void unsetContactResultChoices()
      {
        if (flagHasContactResultChoices)
          {
            for (int num2 = 0; num2 < storeContactResultChoices.Count; ++num2)
              {
                switch (storeContactResultChoices[num2].key)
                  {
                    case 0:
                        break;
                    case 1:
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
          }
        flagHasContactResultChoices = false;
        storeContactResultChoices.Clear();
      }
    public void initLastSelectedInfoAsStrings()
      {
        if (flagHasLastSelectedInfoAsStrings)
          {
            for (int num3 = 0; num3 < storeLastSelectedInfoAsStrings.Count; ++num3)
              {
              }
          }
        flagHasLastSelectedInfoAsStrings = true;
        storeLastSelectedInfoAsStrings.Clear();
      }
    public void appendLastSelectedInfoAsStrings(TypeLastSelectedInfoAsStringsJSON  to_append)
      {
        if (!flagHasLastSelectedInfoAsStrings)
          {
            flagHasLastSelectedInfoAsStrings = true;
            storeLastSelectedInfoAsStrings.Clear();
          }
        Debug.Assert(flagHasLastSelectedInfoAsStrings);
        storeLastSelectedInfoAsStrings.Add(to_append);
      }
    public void unsetLastSelectedInfoAsStrings()
      {
        if (flagHasLastSelectedInfoAsStrings)
          {
            for (int num4 = 0; num4 < storeLastSelectedInfoAsStrings.Count; ++num4)
              {
              }
          }
        flagHasLastSelectedInfoAsStrings = false;
        storeLastSelectedInfoAsStrings.Clear();
      }

    public virtual void extraDisambiguateCommunicationCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDisambiguateCommunicationCommandNativeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDisambiguateCommunicationCommandNativeDataLookup(key);
        if (old_field == null)
          {
            extraDisambiguateCommunicationCommandNativeDataAppendPair(key, new_component);
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
    public override void extraDisambiguateCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "utoListen", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONAutoListen(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if (String.Compare(key, 1, "o", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'm':
                            if ((String.Compare(key, 3, "municationType", 0, 14, false) == 0) && (key.Length == 17))
                                {
                                fromJSONCommunicationType(new_component, false);
                                return;
                                }
                            break;
                        case 'n':
                            if ((String.Compare(key, 3, "tactResultChoices", 0, 17, false) == 0) && (key.Length == 20))
                                {
                                fromJSONContactResultChoices(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if (String.Compare(key, 1, "rror", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'S':
                            if (String.Compare(key, 6, "pokenResponse", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONErrorSpokenResponse(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'L':
                                        if ((String.Compare(key, 20, "ong", 0, 3, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONErrorSpokenResponseLong(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'W':
                            if (String.Compare(key, 6, "rittenResponse", 0, 14, false) == 0)
                              {
                                if (key.Length == 20)
                                  {
                                    {
                                    fromJSONErrorWrittenResponse(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[20])
                                  {
                                    case 'L':
                                        if ((String.Compare(key, 21, "ong", 0, 3, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONErrorWrittenResponseLong(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "adInvalidChoice", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONHadInvalidChoice(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astSelectedInfoAsStrings", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLastSelectedInfoAsStrings(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisambiguateCommunicationCommandNativeDataAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandNativeDataSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "utoListen", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONAutoListen(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if (String.Compare(key, 1, "o", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'm':
                            if ((String.Compare(key, 3, "municationType", 0, 14, false) == 0) && (key.Length == 17))
                                {
                                fromJSONCommunicationType(new_component, false);
                                return;
                                }
                            break;
                        case 'n':
                            if ((String.Compare(key, 3, "tactResultChoices", 0, 17, false) == 0) && (key.Length == 20))
                                {
                                fromJSONContactResultChoices(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if (String.Compare(key, 1, "rror", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'S':
                            if (String.Compare(key, 6, "pokenResponse", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONErrorSpokenResponse(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'L':
                                        if ((String.Compare(key, 20, "ong", 0, 3, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONErrorSpokenResponseLong(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'W':
                            if (String.Compare(key, 6, "rittenResponse", 0, 14, false) == 0)
                              {
                                if (key.Length == 20)
                                  {
                                    {
                                    fromJSONErrorWrittenResponse(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[20])
                                  {
                                    case 'L':
                                        if ((String.Compare(key, 21, "ong", 0, 3, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONErrorWrittenResponseLong(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if ((String.Compare(key, 1, "adInvalidChoice", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONHadInvalidChoice(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astSelectedInfoAsStrings", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLastSelectedInfoAsStrings(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDisambiguateCommunicationCommandNativeDataSetField(key, new_component);
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
        if (flagHasErrorSpokenResponse)
          {
            handler.start_pair("ErrorSpokenResponse");
            handler.string_value(storeErrorSpokenResponse);
          }
        if (flagHasErrorSpokenResponseLong)
          {
            handler.start_pair("ErrorSpokenResponseLong");
            handler.string_value(storeErrorSpokenResponseLong);
          }
        if (flagHasErrorWrittenResponse)
          {
            handler.start_pair("ErrorWrittenResponse");
            handler.string_value(storeErrorWrittenResponse);
          }
        if (flagHasErrorWrittenResponseLong)
          {
            handler.start_pair("ErrorWrittenResponseLong");
            handler.string_value(storeErrorWrittenResponseLong);
          }
        Debug.Assert(partial_allowed || flagHasHadInvalidChoice);
        if (flagHasHadInvalidChoice)
          {
            handler.start_pair("HadInvalidChoice");
            handler.boolean_value(storeHadInvalidChoice);
          }
        Debug.Assert(partial_allowed || flagHasCommunicationType);
        if (flagHasCommunicationType)
          {
            handler.start_pair("CommunicationType");
            if (partial_allowed)
                storeCommunicationType.write_partial_as_json(handler);
            else
                storeCommunicationType.write_as_json(handler);
          }
        if (flagHasAutoListen)
          {
            handler.start_pair("AutoListen");
            handler.boolean_value(storeAutoListen);
          }
        if (flagHasContactResultChoices)
          {
            handler.start_pair("ContactResultChoices");
            handler.start_array();
            for (int num1 = 0; num1 < storeContactResultChoices.Count; ++num1)
              {
                switch (storeContactResultChoices[num1].key)
                  {
                    case 0:
                        if (partial_allowed)
                            storeContactResultChoices[num1].u.choice0.write_partial_as_json(handler);
                        else
                            storeContactResultChoices[num1].u.choice0.write_as_json(handler);
                        break;
                    case 1:
                        if (partial_allowed)
                            storeContactResultChoices[num1].u.choice1.write_partial_as_json(handler);
                        else
                            storeContactResultChoices[num1].u.choice1.write_as_json(handler);
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasLastSelectedInfoAsStrings)
          {
            handler.start_pair("LastSelectedInfoAsStrings");
            handler.start_array();
            for (int num2 = 0; num2 < storeLastSelectedInfoAsStrings.Count; ++num2)
              {
                if (partial_allowed)
                    storeLastSelectedInfoAsStrings[num2].write_partial_as_json(handler);
                else
                    storeLastSelectedInfoAsStrings[num2].write_as_json(handler);
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
        if (!(hasHadInvalidChoice()))
          {
            return "When parsing the object for %what%, the \"HadInvalidChoice\" field was missing.";
          }
        if (!(hasCommunicationType()))
          {
            return "When parsing the object for %what%, the \"CommunicationType\" field was missing.";
          }
        return null;
      }

    public static new DisambiguateCommunicationCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommunicationCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommunicationCommandNativeData", ignore_extras);
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
    public static new DisambiguateCommunicationCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateCommunicationCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DisambiguateCommunicationCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommunicationCommandNativeData", ignore_extras);
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
    public static new DisambiguateCommunicationCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DisambiguateCommunicationCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        DisambiguateCommunicationCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommunicationCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DisambiguateCommunicationCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DisambiguateCommunicationCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DisambiguateCommunicationCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DisambiguateCommunicationCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandNativeDataJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorErrorSpokenResponse;
        private JSONHoldingStringGenerator fieldGeneratorErrorSpokenResponseLong;
        private JSONHoldingStringGenerator fieldGeneratorErrorWrittenResponse;
        private JSONHoldingStringGenerator fieldGeneratorErrorWrittenResponseLong;
        private JSONHoldingBooleanGenerator fieldGeneratorHadInvalidChoice;
        private CommunicationTypeJSON.HoldingGenerator fieldGeneratorCommunicationType;
        private JSONHoldingBooleanGenerator fieldGeneratorAutoListen;
    private abstract class FieldGeneratorContactResultChoices : JSONParallelGenerator
          {
            private SMSContactResultJSON.HoldingGenerator field0;
            private EmailContactResultJSON.HoldingGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeContactResultChoices result = new TypeContactResultChoices();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeContactResultChoices result);
            public FieldGeneratorContactResultChoices(bool ignore_extras)
              {
                    field0 = new SMSContactResultJSON.HoldingGenerator("option 0 of field \"ContactResultChoices\"", ignore_extras);
                    field1 = new EmailContactResultJSON.HoldingGenerator("option 1 of field \"ContactResultChoices\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorContactResultChoices(string what, bool ignore_extras)
              {
                    field0 = new SMSContactResultJSON.HoldingGenerator("option 0 of field \"ContactResultChoices\"", ignore_extras);
                    field1 = new EmailContactResultJSON.HoldingGenerator("option 1 of field \"ContactResultChoices\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderContactResultChoices
          {
            private bool have_data;
            private TypeContactResultChoices data;
            public HolderContactResultChoices()  { have_data = false; }
            public HolderContactResultChoices(TypeContactResultChoices init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderContactResultChoices(HolderContactResultChoices other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeContactResultChoices referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorContactResultChoices : FieldGeneratorContactResultChoices
          {
            protected override void handle_result(TypeContactResultChoices result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderContactResultChoices(result);
              }

            public FieldHoldingGeneratorContactResultChoices(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderContactResultChoices value;
          };
    private class FieldHoldingArrayGeneratorContactResultChoices : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorContactResultChoices
      {
        private FieldHoldingArrayGeneratorContactResultChoices top;

        protected override void handle_result(TypeContactResultChoices result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorContactResultChoices init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeContactResultChoices> result)
      {
      }

    public FieldHoldingArrayGeneratorContactResultChoices(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeContactResultChoices>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorContactResultChoices(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeContactResultChoices>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeContactResultChoices> value;
  };
        private FieldHoldingArrayGeneratorContactResultChoices fieldGeneratorContactResultChoices;
        private TypeLastSelectedInfoAsStringsJSON.HoldingArrayGenerator fieldGeneratorLastSelectedInfoAsStrings;
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
            DisambiguateCommunicationCommandNativeDataJSON result = new DisambiguateCommunicationCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDisambiguateCommunicationCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DisambiguateCommandNativeDataJSON new_result)
          {
            handle_result((DisambiguateCommunicationCommandNativeDataJSON )new_result);
          }
        protected void finish(DisambiguateCommunicationCommandNativeDataJSON result)
          {
            if (fieldGeneratorErrorSpokenResponse.have_value)
              {
                result.setErrorSpokenResponse(fieldGeneratorErrorSpokenResponse.value);
                fieldGeneratorErrorSpokenResponse.have_value = false;
              }
            if (fieldGeneratorErrorSpokenResponseLong.have_value)
              {
                result.setErrorSpokenResponseLong(fieldGeneratorErrorSpokenResponseLong.value);
                fieldGeneratorErrorSpokenResponseLong.have_value = false;
              }
            if (fieldGeneratorErrorWrittenResponse.have_value)
              {
                result.setErrorWrittenResponse(fieldGeneratorErrorWrittenResponse.value);
                fieldGeneratorErrorWrittenResponse.have_value = false;
              }
            if (fieldGeneratorErrorWrittenResponseLong.have_value)
              {
                result.setErrorWrittenResponseLong(fieldGeneratorErrorWrittenResponseLong.value);
                fieldGeneratorErrorWrittenResponseLong.have_value = false;
              }
            if (fieldGeneratorHadInvalidChoice.have_value)
              {
                result.setHadInvalidChoice(fieldGeneratorHadInvalidChoice.value);
                fieldGeneratorHadInvalidChoice.have_value = false;
              }
            else if ((!(result.hasHadInvalidChoice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HadInvalidChoice\" field was missing.");
              }
            if (fieldGeneratorCommunicationType.have_value)
              {
                result.setCommunicationType(fieldGeneratorCommunicationType.value);
                fieldGeneratorCommunicationType.have_value = false;
              }
            else if ((!(result.hasCommunicationType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommunicationType\" field was missing.");
              }
            if (fieldGeneratorAutoListen.have_value)
              {
                result.setAutoListen(fieldGeneratorAutoListen.value);
                fieldGeneratorAutoListen.have_value = false;
              }
            if (fieldGeneratorContactResultChoices.have_value)
              {
                result.initContactResultChoices();
                int count = fieldGeneratorContactResultChoices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContactResultChoices(fieldGeneratorContactResultChoices.value[num]);
                  }
                fieldGeneratorContactResultChoices.value.Clear();
                fieldGeneratorContactResultChoices.have_value = false;
              }
            if (fieldGeneratorLastSelectedInfoAsStrings.have_value)
              {
                result.initLastSelectedInfoAsStrings();
                int count = fieldGeneratorLastSelectedInfoAsStrings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLastSelectedInfoAsStrings(fieldGeneratorLastSelectedInfoAsStrings.value[num]);
                  }
                fieldGeneratorLastSelectedInfoAsStrings.value.Clear();
                fieldGeneratorLastSelectedInfoAsStrings.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DisambiguateCommunicationCommandNativeDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "utoListen", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorAutoListen;
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'm':
                                if ((String.Compare(field_name, 3, "municationType", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorCommunicationType;
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 3, "tactResultChoices", 0, 17, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorContactResultChoices;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "rror", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'S':
                                if (String.Compare(field_name, 6, "pokenResponse", 0, 13, false) == 0)
                                  {
                                    if (field_name.Length == 19)
                                      {
                                        return fieldGeneratorErrorSpokenResponse;
                                      }
                                    switch (field_name[19])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 20, "ong", 0, 3, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorErrorSpokenResponseLong;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'W':
                                if (String.Compare(field_name, 6, "rittenResponse", 0, 14, false) == 0)
                                  {
                                    if (field_name.Length == 20)
                                      {
                                        return fieldGeneratorErrorWrittenResponse;
                                      }
                                    switch (field_name[20])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 21, "ong", 0, 3, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorErrorWrittenResponseLong;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "adInvalidChoice", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorHadInvalidChoice;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astSelectedInfoAsStrings", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorLastSelectedInfoAsStrings;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorErrorSpokenResponse = new JSONHoldingStringGenerator("field \"ErrorSpokenResponse\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorSpokenResponseLong = new JSONHoldingStringGenerator("field \"ErrorSpokenResponseLong\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorWrittenResponse = new JSONHoldingStringGenerator("field \"ErrorWrittenResponse\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorWrittenResponseLong = new JSONHoldingStringGenerator("field \"ErrorWrittenResponseLong\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorHadInvalidChoice = new JSONHoldingBooleanGenerator("field \"HadInvalidChoice\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorCommunicationType = new CommunicationTypeJSON.HoldingGenerator("field \"CommunicationType\" of the DisambiguateCommunicationCommandNativeData class", ignore_extras);
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorContactResultChoices = new FieldHoldingArrayGeneratorContactResultChoices("field \"ContactResultChoices\" of the DisambiguateCommunicationCommandNativeData class", ignore_extras);
            fieldGeneratorLastSelectedInfoAsStrings = new TypeLastSelectedInfoAsStringsJSON.HoldingArrayGenerator("field \"LastSelectedInfoAsStrings\" of the DisambiguateCommunicationCommandNativeData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DisambiguateCommunicationCommandNativeData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorErrorSpokenResponse = new JSONHoldingStringGenerator("field \"ErrorSpokenResponse\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorSpokenResponseLong = new JSONHoldingStringGenerator("field \"ErrorSpokenResponseLong\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorWrittenResponse = new JSONHoldingStringGenerator("field \"ErrorWrittenResponse\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorErrorWrittenResponseLong = new JSONHoldingStringGenerator("field \"ErrorWrittenResponseLong\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorHadInvalidChoice = new JSONHoldingBooleanGenerator("field \"HadInvalidChoice\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorCommunicationType = new CommunicationTypeJSON.HoldingGenerator("field \"CommunicationType\" of the DisambiguateCommunicationCommandNativeData class", false);
            fieldGeneratorAutoListen = new JSONHoldingBooleanGenerator("field \"AutoListen\" of the DisambiguateCommunicationCommandNativeData class");
            fieldGeneratorContactResultChoices = new FieldHoldingArrayGeneratorContactResultChoices("field \"ContactResultChoices\" of the DisambiguateCommunicationCommandNativeData class", false);
            fieldGeneratorLastSelectedInfoAsStrings = new TypeLastSelectedInfoAsStringsJSON.HoldingArrayGenerator("field \"LastSelectedInfoAsStrings\" of the DisambiguateCommunicationCommandNativeData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DisambiguateCommunicationCommandNativeData class");
          }

        public override void reset()
          {
            fieldGeneratorErrorSpokenResponse.reset();
            fieldGeneratorErrorSpokenResponseLong.reset();
            fieldGeneratorErrorWrittenResponse.reset();
            fieldGeneratorErrorWrittenResponseLong.reset();
            fieldGeneratorHadInvalidChoice.reset();
            fieldGeneratorCommunicationType.reset();
            fieldGeneratorAutoListen.reset();
            fieldGeneratorContactResultChoices.reset();
            fieldGeneratorLastSelectedInfoAsStrings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DisambiguateCommunicationCommandNativeDataJSON  result)
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
        public DisambiguateCommunicationCommandNativeDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DisambiguateCommunicationCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<DisambiguateCommunicationCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DisambiguateCommunicationCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DisambiguateCommunicationCommandNativeDataJSON>();
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
    public List<DisambiguateCommunicationCommandNativeDataJSON> value;
  };
    public static DisambiguateCommunicationCommandNativeDataJSON from_DisambiguateCommandNativeDataJSON_json(DisambiguateCommandNativeDataJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        DisambiguateCommunicationCommandNativeDataJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type DisambiguateCommunicationCommandNativeData", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
