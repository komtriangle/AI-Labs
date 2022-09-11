/* file "HomeAutomationActionResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationActionResponseJSON : JSONBase
  {
    public class TypeErrorJSON : JSONBase
      {
        private bool flagHasErrorCode;
        private string storeErrorCode;
        private bool flagHasErrorString;
        private string storeErrorString;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONErrorCode(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ErrorCode of TypeErrorJSON is not a string.");
            setErrorCode(json_string.getData());
          }


        private void  fromJSONErrorString(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ErrorString of TypeErrorJSON is not a string.");
            setErrorString(json_string.getData());
          }


        public TypeErrorJSON()
          {
            flagHasErrorCode = false;
            flagHasErrorString = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasErrorCode()
          {
            return flagHasErrorCode;
          }

        public string  getErrorCode()
          {
            Debug.Assert(flagHasErrorCode);
            return storeErrorCode;
          }

        public bool  hasErrorString()
          {
            return flagHasErrorString;
          }

        public string  getErrorString()
          {
            Debug.Assert(flagHasErrorString);
            return storeErrorString;
          }


        public virtual int extraTypeErrorComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeErrorComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeErrorComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeErrorLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setErrorCode(string new_value)
          {
            flagHasErrorCode = true;
            storeErrorCode = new_value;
          }
        public void unsetErrorCode()
          {
            flagHasErrorCode = false;
          }
        public void setErrorString(string new_value)
          {
            flagHasErrorString = true;
            storeErrorString = new_value;
          }
        public void unsetErrorString()
          {
            flagHasErrorString = false;
          }

        public virtual void extraTypeErrorAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeErrorSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeErrorLookup(key);
            if (old_field == null)
              {
                extraTypeErrorAppendPair(key, new_component);
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
            if (flagHasErrorCode)
              {
                handler.start_pair("ErrorCode");
                handler.string_value(storeErrorCode);
              }
            if (flagHasErrorString)
              {
                handler.start_pair("ErrorString");
                handler.string_value(storeErrorString);
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

        public static TypeErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeErrorJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeError", ignore_extras);
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
        public static TypeErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeErrorJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeError", ignore_extras);
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
        public static TypeErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeErrorJSON from_text(string text, bool ignore_extras)
          {
            TypeErrorJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeError", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeErrorJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeErrorJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeError", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorErrorCode;
            private JSONHoldingStringGenerator fieldGeneratorErrorString;
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
                TypeErrorJSON result = new TypeErrorJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeErrorJSON result)
              {
                if (fieldGeneratorErrorCode.have_value)
                  {
                    result.setErrorCode(fieldGeneratorErrorCode.value);
                    fieldGeneratorErrorCode.have_value = false;
                  }
                if (fieldGeneratorErrorString.have_value)
                  {
                    result.setErrorString(fieldGeneratorErrorString.value);
                    fieldGeneratorErrorString.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeErrorJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Error", 0, 5, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 6, "ode", 0, 3, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorErrorCode;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "tring", 0, 5, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorErrorString;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorErrorCode = new JSONHoldingStringGenerator("field \"ErrorCode\" of the TypeError class");
                fieldGeneratorErrorString = new JSONHoldingStringGenerator("field \"ErrorString\" of the TypeError class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeError class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorErrorCode = new JSONHoldingStringGenerator("field \"ErrorCode\" of the TypeError class");
                fieldGeneratorErrorString = new JSONHoldingStringGenerator("field \"ErrorString\" of the TypeError class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeError class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorErrorCode.reset();
                fieldGeneratorErrorString.reset();
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
            protected override void handle_result(TypeErrorJSON  result)
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
            public TypeErrorJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeErrorJSON  result)
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
        protected virtual void handle_result(List<TypeErrorJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeErrorJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeErrorJSON>();
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
        public List<TypeErrorJSON> value;
      };
      };
    public class TypeSensorReadingJSON : JSONBase
      {
        private bool flagHasName;
        private string storeName;
        private bool flagHasLevel;
        private double storeLevel;
        private string textStoreLevel;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Name of TypeSensorReadingJSON is not a string.");
            setName(json_string.getData());
          }


        private void  fromJSONLevel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field Level of TypeSensorReadingJSON is not a number.");
                  }
              }
            setLevelText(the_rational_text);
          }


        public TypeSensorReadingJSON()
          {
            flagHasName = false;
            flagHasLevel = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasName()
          {
            return flagHasName;
          }

        public string  getName()
          {
            Debug.Assert(flagHasName);
            return storeName;
          }

        public bool  hasLevel()
          {
            return flagHasLevel;
          }

        public double  getLevel()
          {
            Debug.Assert(flagHasLevel);
            if (textStoreLevel != "")
              {
                return Double.Parse(textStoreLevel);
              }
            return storeLevel;
          }

        public string  getLevelAsText()
          {
            Debug.Assert(flagHasLevel);
            if (textStoreLevel == "")
              {
                return Convert.ToString(storeLevel);
              }
            else
              {
                return (textStoreLevel);
              }
          }


        public virtual int extraTypeSensorReadingComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSensorReadingComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSensorReadingComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSensorReadingLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setName(string new_value)
          {
            flagHasName = true;
            storeName = new_value;
          }
        public void unsetName()
          {
            flagHasName = false;
          }
        public void setLevel(double new_value)
          {
            flagHasLevel = true;
            storeLevel = new_value;
            textStoreLevel = "";
          }
        public void setLevelText(string new_value)
          {
            flagHasLevel = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Level of TypeSensorReadingJSON is not a valid number.");
            textStoreLevel = new_value;
          }
        public void unsetLevel()
          {
            flagHasLevel = false;
          }

        public virtual void extraTypeSensorReadingAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSensorReadingSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSensorReadingLookup(key);
            if (old_field == null)
              {
                extraTypeSensorReadingAppendPair(key, new_component);
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
            if (flagHasName)
              {
                handler.start_pair("Name");
                handler.string_value(storeName);
              }
            if (flagHasLevel)
              {
                handler.start_pair("Level");
                if (textStoreLevel != "")
                    handler.number_value(textStoreLevel);
                else if (((double)(long)storeLevel) == storeLevel)
                    handler.number_value((long)storeLevel);
                else
                    handler.number_value(storeLevel);
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

        public static TypeSensorReadingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSensorReadingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensorReading", ignore_extras);
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
        public static TypeSensorReadingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSensorReadingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSensorReadingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensorReading", ignore_extras);
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
        public static TypeSensorReadingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSensorReadingJSON from_text(string text, bool ignore_extras)
          {
            TypeSensorReadingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensorReading", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSensorReadingJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSensorReadingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSensorReadingJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensorReading", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorName;
            private JSONHoldingNumberTextGenerator fieldGeneratorLevel;
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
                TypeSensorReadingJSON result = new TypeSensorReadingJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSensorReadingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSensorReadingJSON result)
              {
                if (fieldGeneratorName.have_value)
                  {
                    result.setName(fieldGeneratorName.value);
                    fieldGeneratorName.have_value = false;
                  }
                if (fieldGeneratorLevel.have_value)
                  {
                    result.setLevelText(fieldGeneratorLevel.value);
                    fieldGeneratorLevel.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSensorReadingJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "evel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLevel;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorName;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeSensorReading class");
                fieldGeneratorLevel = new JSONHoldingNumberTextGenerator("field \"Level\" of the TypeSensorReading class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSensorReading class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeSensorReading class");
                fieldGeneratorLevel = new JSONHoldingNumberTextGenerator("field \"Level\" of the TypeSensorReading class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSensorReading class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorName.reset();
                fieldGeneratorLevel.reset();
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
            protected override void handle_result(TypeSensorReadingJSON  result)
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
            public TypeSensorReadingJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSensorReadingJSON  result)
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
        protected virtual void handle_result(List<TypeSensorReadingJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSensorReadingJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSensorReadingJSON>();
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
        public List<TypeSensorReadingJSON> value;
      };
      };
    private bool flagHasError;
    private TypeErrorJSON  storeError;
    private bool flagHasAuto;
    private bool storeAuto;
    private bool flagHasSleep;
    private bool storeSleep;
    private bool flagHasWake;
    private bool storeWake;
    private bool flagHasTurnOn;
    private bool storeTurnOn;
    private bool flagHasTurnOff;
    private bool storeTurnOff;
    private bool flagHasSetBrightness;
    private double storeSetBrightness;
    private string textStoreSetBrightness;
    private bool flagHasSetColor;
    private ColorJSON  storeSetColor;
    private bool flagHasHeat;
    private bool storeHeat;
    private bool flagHasCool;
    private bool storeCool;
    private bool flagHasDry;
    private bool storeDry;
    private bool flagHasWind;
    private bool storeWind;
    private bool flagHasSetTemperature;
    private HomeAutomationTemperatureJSON  storeSetTemperature;
    private bool flagHasSetWindSpeed;
    private double storeSetWindSpeed;
    private string textStoreSetWindSpeed;
    private bool flagHasStartCleaning;
    private bool storeStartCleaning;
    private bool flagHasStopCleaning;
    private bool storeStopCleaning;
    private bool flagHasTurboControl;
    private HomeAutomationTurboModeJSON  storeTurboControl;
    private bool flagHasReady;
    private bool storeReady;
    private bool flagHasPause;
    private bool storePause;
    private bool flagHasCancel;
    private bool storeCancel;
    private bool flagHasCurrentTemperature;
    private HomeAutomationTemperatureJSON  storeCurrentTemperature;
    private bool flagHasLock;
    private bool storeLock;
    private bool flagHasUnlock;
    private bool storeUnlock;
    private bool flagHasOpen;
    private bool storeOpen;
    private bool flagHasClose;
    private bool storeClose;
    private bool flagHasAlarm;
    private bool storeAlarm;
    private bool flagHasTimeRemaining;
    private double storeTimeRemaining;
    private string textStoreTimeRemaining;
    private bool flagHasStage;
    private string storeStage;
    private bool flagHasSensorReading;
    private List< TypeSensorReadingJSON  > storeSensorReading;
    private bool flagHasMotionSensor;
    private HomeAutomationMotionStatusJSON  storeMotionSensor;
    private bool flagHasMovementSensor;
    private HomeAutomationMovementStatusJSON  storeMovementSensor;
    private bool flagHasSetVolume;
    private double storeSetVolume;
    private string textStoreSetVolume;
    private bool flagHasMute;
    private bool storeMute;
    private bool flagHasUnmute;
    private bool storeUnmute;
    private bool flagHasChangeChannel;
    private double storeChangeChannel;
    private string textStoreChangeChannel;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeErrorJSON convert_classy = TypeErrorJSON.from_json(json_value, ignore_extras, true);
        setError(convert_classy);
      }


    private void  fromJSONAuto(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Auto of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setAuto(the_bool);
      }


    private void  fromJSONSleep(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Sleep of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setSleep(the_bool);
      }


    private void  fromJSONWake(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Wake of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setWake(the_bool);
      }


    private void  fromJSONTurnOn(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TurnOn of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setTurnOn(the_bool);
      }


    private void  fromJSONTurnOff(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TurnOff of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setTurnOff(the_bool);
      }


    private void  fromJSONSetBrightness(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field SetBrightness of HomeAutomationActionResponseJSON is not a number.");
              }
          }
        setSetBrightnessText(the_rational_text);
      }


    private void  fromJSONSetColor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ColorJSON convert_classy = ColorJSON.from_json(json_value, ignore_extras, true);
        setSetColor(convert_classy);
      }


    private void  fromJSONHeat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Heat of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setHeat(the_bool);
      }


    private void  fromJSONCool(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cool of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setCool(the_bool);
      }


    private void  fromJSONDry(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Dry of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setDry(the_bool);
      }


    private void  fromJSONWind(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Wind of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setWind(the_bool);
      }


    private void  fromJSONSetTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTemperatureJSON convert_classy = HomeAutomationTemperatureJSON.from_json(json_value, ignore_extras, true);
        setSetTemperature(convert_classy);
      }


    private void  fromJSONSetWindSpeed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field SetWindSpeed of HomeAutomationActionResponseJSON is not a number.");
              }
          }
        setSetWindSpeedText(the_rational_text);
      }


    private void  fromJSONStartCleaning(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartCleaning of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setStartCleaning(the_bool);
      }


    private void  fromJSONStopCleaning(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StopCleaning of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setStopCleaning(the_bool);
      }


    private void  fromJSONTurboControl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTurboModeJSON convert_classy = HomeAutomationTurboModeJSON.from_json(json_value, ignore_extras, true);
        setTurboControl(convert_classy);
      }


    private void  fromJSONReady(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Ready of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setReady(the_bool);
      }


    private void  fromJSONPause(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Pause of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setPause(the_bool);
      }


    private void  fromJSONCancel(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cancel of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setCancel(the_bool);
      }


    private void  fromJSONCurrentTemperature(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationTemperatureJSON convert_classy = HomeAutomationTemperatureJSON.from_json(json_value, ignore_extras, true);
        setCurrentTemperature(convert_classy);
      }


    private void  fromJSONLock(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Lock of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setLock(the_bool);
      }


    private void  fromJSONUnlock(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Unlock of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setUnlock(the_bool);
      }


    private void  fromJSONOpen(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Open of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setOpen(the_bool);
      }


    private void  fromJSONClose(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Close of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setClose(the_bool);
      }


    private void  fromJSONAlarm(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Alarm of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setAlarm(the_bool);
      }


    private void  fromJSONTimeRemaining(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field TimeRemaining of HomeAutomationActionResponseJSON is not a number.");
              }
          }
        setTimeRemainingText(the_rational_text);
      }


    private void  fromJSONStage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Stage of HomeAutomationActionResponseJSON is not a string.");
        setStage(json_string.getData());
      }


    private void  fromJSONSensorReading(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SensorReading of HomeAutomationActionResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SensorReading of HomeAutomationActionResponseJSON has too few elements.");
        List< TypeSensorReadingJSON  > vector_SensorReading1 = new List< TypeSensorReadingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeSensorReadingJSON convert_classy = TypeSensorReadingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SensorReading1.Add(convert_classy);
          }
        Debug.Assert(vector_SensorReading1.Count >= 1);
        initSensorReading();
        for (int num1 = 0; num1 < vector_SensorReading1.Count; ++num1)
            appendSensorReading(vector_SensorReading1[num1]);
        for (int num1 = 0; num1 < vector_SensorReading1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMotionSensor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationMotionStatusJSON convert_classy = HomeAutomationMotionStatusJSON.from_json(json_value, ignore_extras, true);
        setMotionSensor(convert_classy);
      }


    private void  fromJSONMovementSensor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationMovementStatusJSON convert_classy = HomeAutomationMovementStatusJSON.from_json(json_value, ignore_extras, true);
        setMovementSensor(convert_classy);
      }


    private void  fromJSONSetVolume(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field SetVolume of HomeAutomationActionResponseJSON is not a number.");
              }
          }
        setSetVolumeText(the_rational_text);
      }


    private void  fromJSONMute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Mute of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setMute(the_bool);
      }


    private void  fromJSONUnmute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Unmute of HomeAutomationActionResponseJSON is not true for false.");
              }
          }
        setUnmute(the_bool);
      }


    private void  fromJSONChangeChannel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field ChangeChannel of HomeAutomationActionResponseJSON is not a number.");
              }
          }
        setChangeChannelText(the_rational_text);
      }


    public HomeAutomationActionResponseJSON()
      {
        flagHasError = false;
        flagHasAuto = false;
        flagHasSleep = false;
        flagHasWake = false;
        flagHasTurnOn = false;
        flagHasTurnOff = false;
        flagHasSetBrightness = false;
        flagHasSetColor = false;
        flagHasHeat = false;
        flagHasCool = false;
        flagHasDry = false;
        flagHasWind = false;
        flagHasSetTemperature = false;
        flagHasSetWindSpeed = false;
        flagHasStartCleaning = false;
        flagHasStopCleaning = false;
        flagHasTurboControl = false;
        flagHasReady = false;
        flagHasPause = false;
        flagHasCancel = false;
        flagHasCurrentTemperature = false;
        flagHasLock = false;
        flagHasUnlock = false;
        flagHasOpen = false;
        flagHasClose = false;
        flagHasAlarm = false;
        flagHasTimeRemaining = false;
        flagHasStage = false;
        flagHasSensorReading = false;
        flagHasMotionSensor = false;
        flagHasMovementSensor = false;
        flagHasSetVolume = false;
        flagHasMute = false;
        flagHasUnmute = false;
        flagHasChangeChannel = false;
        storeSensorReading = new List< TypeSensorReadingJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public TypeErrorJSON   getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public bool  hasAuto()
      {
        return flagHasAuto;
      }

    public bool  getAuto()
      {
        Debug.Assert(flagHasAuto);
        return storeAuto;
      }

    public bool  hasSleep()
      {
        return flagHasSleep;
      }

    public bool  getSleep()
      {
        Debug.Assert(flagHasSleep);
        return storeSleep;
      }

    public bool  hasWake()
      {
        return flagHasWake;
      }

    public bool  getWake()
      {
        Debug.Assert(flagHasWake);
        return storeWake;
      }

    public bool  hasTurnOn()
      {
        return flagHasTurnOn;
      }

    public bool  getTurnOn()
      {
        Debug.Assert(flagHasTurnOn);
        return storeTurnOn;
      }

    public bool  hasTurnOff()
      {
        return flagHasTurnOff;
      }

    public bool  getTurnOff()
      {
        Debug.Assert(flagHasTurnOff);
        return storeTurnOff;
      }

    public bool  hasSetBrightness()
      {
        return flagHasSetBrightness;
      }

    public double  getSetBrightness()
      {
        Debug.Assert(flagHasSetBrightness);
        if (textStoreSetBrightness != "")
          {
            return Double.Parse(textStoreSetBrightness);
          }
        return storeSetBrightness;
      }

    public string  getSetBrightnessAsText()
      {
        Debug.Assert(flagHasSetBrightness);
        if (textStoreSetBrightness == "")
          {
            return Convert.ToString(storeSetBrightness);
          }
        else
          {
            return (textStoreSetBrightness);
          }
      }

    public bool  hasSetColor()
      {
        return flagHasSetColor;
      }

    public ColorJSON   getSetColor()
      {
        Debug.Assert(flagHasSetColor);
        return storeSetColor;
      }

    public bool  hasHeat()
      {
        return flagHasHeat;
      }

    public bool  getHeat()
      {
        Debug.Assert(flagHasHeat);
        return storeHeat;
      }

    public bool  hasCool()
      {
        return flagHasCool;
      }

    public bool  getCool()
      {
        Debug.Assert(flagHasCool);
        return storeCool;
      }

    public bool  hasDry()
      {
        return flagHasDry;
      }

    public bool  getDry()
      {
        Debug.Assert(flagHasDry);
        return storeDry;
      }

    public bool  hasWind()
      {
        return flagHasWind;
      }

    public bool  getWind()
      {
        Debug.Assert(flagHasWind);
        return storeWind;
      }

    public bool  hasSetTemperature()
      {
        return flagHasSetTemperature;
      }

    public HomeAutomationTemperatureJSON   getSetTemperature()
      {
        Debug.Assert(flagHasSetTemperature);
        return storeSetTemperature;
      }

    public bool  hasSetWindSpeed()
      {
        return flagHasSetWindSpeed;
      }

    public double  getSetWindSpeed()
      {
        Debug.Assert(flagHasSetWindSpeed);
        if (textStoreSetWindSpeed != "")
          {
            return Double.Parse(textStoreSetWindSpeed);
          }
        return storeSetWindSpeed;
      }

    public string  getSetWindSpeedAsText()
      {
        Debug.Assert(flagHasSetWindSpeed);
        if (textStoreSetWindSpeed == "")
          {
            return Convert.ToString(storeSetWindSpeed);
          }
        else
          {
            return (textStoreSetWindSpeed);
          }
      }

    public bool  hasStartCleaning()
      {
        return flagHasStartCleaning;
      }

    public bool  getStartCleaning()
      {
        Debug.Assert(flagHasStartCleaning);
        return storeStartCleaning;
      }

    public bool  hasStopCleaning()
      {
        return flagHasStopCleaning;
      }

    public bool  getStopCleaning()
      {
        Debug.Assert(flagHasStopCleaning);
        return storeStopCleaning;
      }

    public bool  hasTurboControl()
      {
        return flagHasTurboControl;
      }

    public HomeAutomationTurboModeJSON   getTurboControl()
      {
        Debug.Assert(flagHasTurboControl);
        return storeTurboControl;
      }

    public HomeAutomationTurboModeJSON.TypeValue  getTurboControlValue()
      {
        return getTurboControl().getValue();
      }

    public string  getTurboControlAsString()
      {
        return getTurboControl().getValueAsString();
      }

    public bool  hasReady()
      {
        return flagHasReady;
      }

    public bool  getReady()
      {
        Debug.Assert(flagHasReady);
        return storeReady;
      }

    public bool  hasPause()
      {
        return flagHasPause;
      }

    public bool  getPause()
      {
        Debug.Assert(flagHasPause);
        return storePause;
      }

    public bool  hasCancel()
      {
        return flagHasCancel;
      }

    public bool  getCancel()
      {
        Debug.Assert(flagHasCancel);
        return storeCancel;
      }

    public bool  hasCurrentTemperature()
      {
        return flagHasCurrentTemperature;
      }

    public HomeAutomationTemperatureJSON   getCurrentTemperature()
      {
        Debug.Assert(flagHasCurrentTemperature);
        return storeCurrentTemperature;
      }

    public bool  hasLock()
      {
        return flagHasLock;
      }

    public bool  getLock()
      {
        Debug.Assert(flagHasLock);
        return storeLock;
      }

    public bool  hasUnlock()
      {
        return flagHasUnlock;
      }

    public bool  getUnlock()
      {
        Debug.Assert(flagHasUnlock);
        return storeUnlock;
      }

    public bool  hasOpen()
      {
        return flagHasOpen;
      }

    public bool  getOpen()
      {
        Debug.Assert(flagHasOpen);
        return storeOpen;
      }

    public bool  hasClose()
      {
        return flagHasClose;
      }

    public bool  getClose()
      {
        Debug.Assert(flagHasClose);
        return storeClose;
      }

    public bool  hasAlarm()
      {
        return flagHasAlarm;
      }

    public bool  getAlarm()
      {
        Debug.Assert(flagHasAlarm);
        return storeAlarm;
      }

    public bool  hasTimeRemaining()
      {
        return flagHasTimeRemaining;
      }

    public double  getTimeRemaining()
      {
        Debug.Assert(flagHasTimeRemaining);
        if (textStoreTimeRemaining != "")
          {
            return Double.Parse(textStoreTimeRemaining);
          }
        return storeTimeRemaining;
      }

    public string  getTimeRemainingAsText()
      {
        Debug.Assert(flagHasTimeRemaining);
        if (textStoreTimeRemaining == "")
          {
            return Convert.ToString(storeTimeRemaining);
          }
        else
          {
            return (textStoreTimeRemaining);
          }
      }

    public bool  hasStage()
      {
        return flagHasStage;
      }

    public string  getStage()
      {
        Debug.Assert(flagHasStage);
        return storeStage;
      }

    public bool  hasSensorReading()
      {
        return flagHasSensorReading;
      }

    public int  countOfSensorReading()
      {
        Debug.Assert(flagHasSensorReading);
        return storeSensorReading.Count;
      }

    public TypeSensorReadingJSON   elementOfSensorReading(int element_num)
      {
        Debug.Assert(flagHasSensorReading);
        return storeSensorReading[element_num];
      }

    public List< TypeSensorReadingJSON  >  getSensorReading()
      {
        Debug.Assert(flagHasSensorReading);
        return storeSensorReading;
      }

    public bool  hasMotionSensor()
      {
        return flagHasMotionSensor;
      }

    public HomeAutomationMotionStatusJSON   getMotionSensor()
      {
        Debug.Assert(flagHasMotionSensor);
        return storeMotionSensor;
      }

    public bool  hasMovementSensor()
      {
        return flagHasMovementSensor;
      }

    public HomeAutomationMovementStatusJSON   getMovementSensor()
      {
        Debug.Assert(flagHasMovementSensor);
        return storeMovementSensor;
      }

    public bool  hasSetVolume()
      {
        return flagHasSetVolume;
      }

    public double  getSetVolume()
      {
        Debug.Assert(flagHasSetVolume);
        if (textStoreSetVolume != "")
          {
            return Double.Parse(textStoreSetVolume);
          }
        return storeSetVolume;
      }

    public string  getSetVolumeAsText()
      {
        Debug.Assert(flagHasSetVolume);
        if (textStoreSetVolume == "")
          {
            return Convert.ToString(storeSetVolume);
          }
        else
          {
            return (textStoreSetVolume);
          }
      }

    public bool  hasMute()
      {
        return flagHasMute;
      }

    public bool  getMute()
      {
        Debug.Assert(flagHasMute);
        return storeMute;
      }

    public bool  hasUnmute()
      {
        return flagHasUnmute;
      }

    public bool  getUnmute()
      {
        Debug.Assert(flagHasUnmute);
        return storeUnmute;
      }

    public bool  hasChangeChannel()
      {
        return flagHasChangeChannel;
      }

    public double  getChangeChannel()
      {
        Debug.Assert(flagHasChangeChannel);
        if (textStoreChangeChannel != "")
          {
            return Double.Parse(textStoreChangeChannel);
          }
        return storeChangeChannel;
      }

    public string  getChangeChannelAsText()
      {
        Debug.Assert(flagHasChangeChannel);
        if (textStoreChangeChannel == "")
          {
            return Convert.ToString(storeChangeChannel);
          }
        else
          {
            return (textStoreChangeChannel);
          }
      }


    public virtual int extraHomeAutomationActionResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationActionResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setError(TypeErrorJSON  new_value)
      {
        if (flagHasError)
          {
          }
        flagHasError = true;
        storeError = new_value;
      }
    public void unsetError()
      {
        if (flagHasError)
          {
          }
        flagHasError = false;
      }
    public void setAuto(bool new_value)
      {
        flagHasAuto = true;
        storeAuto = new_value;
      }
    public void unsetAuto()
      {
        flagHasAuto = false;
      }
    public void setSleep(bool new_value)
      {
        flagHasSleep = true;
        storeSleep = new_value;
      }
    public void unsetSleep()
      {
        flagHasSleep = false;
      }
    public void setWake(bool new_value)
      {
        flagHasWake = true;
        storeWake = new_value;
      }
    public void unsetWake()
      {
        flagHasWake = false;
      }
    public void setTurnOn(bool new_value)
      {
        flagHasTurnOn = true;
        storeTurnOn = new_value;
      }
    public void unsetTurnOn()
      {
        flagHasTurnOn = false;
      }
    public void setTurnOff(bool new_value)
      {
        flagHasTurnOff = true;
        storeTurnOff = new_value;
      }
    public void unsetTurnOff()
      {
        flagHasTurnOff = false;
      }
    public void setSetBrightness(double new_value)
      {
        flagHasSetBrightness = true;
        if (new_value < 0)
            throw new Exception("The value for field SetBrightness of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field SetBrightness of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        storeSetBrightness = new_value;
        textStoreSetBrightness = "";
      }
    public void setSetBrightnessText(string new_value)
      {
        flagHasSetBrightness = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SetBrightness of HomeAutomationActionResponseJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field SetBrightness of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field SetBrightness of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        textStoreSetBrightness = new_value;
      }
    public void unsetSetBrightness()
      {
        flagHasSetBrightness = false;
      }
    public void setSetColor(ColorJSON  new_value)
      {
        if (flagHasSetColor)
          {
          }
        flagHasSetColor = true;
        storeSetColor = new_value;
      }
    public void unsetSetColor()
      {
        if (flagHasSetColor)
          {
          }
        flagHasSetColor = false;
      }
    public void setHeat(bool new_value)
      {
        flagHasHeat = true;
        storeHeat = new_value;
      }
    public void unsetHeat()
      {
        flagHasHeat = false;
      }
    public void setCool(bool new_value)
      {
        flagHasCool = true;
        storeCool = new_value;
      }
    public void unsetCool()
      {
        flagHasCool = false;
      }
    public void setDry(bool new_value)
      {
        flagHasDry = true;
        storeDry = new_value;
      }
    public void unsetDry()
      {
        flagHasDry = false;
      }
    public void setWind(bool new_value)
      {
        flagHasWind = true;
        storeWind = new_value;
      }
    public void unsetWind()
      {
        flagHasWind = false;
      }
    public void setSetTemperature(HomeAutomationTemperatureJSON  new_value)
      {
        if (flagHasSetTemperature)
          {
          }
        flagHasSetTemperature = true;
        storeSetTemperature = new_value;
      }
    public void unsetSetTemperature()
      {
        if (flagHasSetTemperature)
          {
          }
        flagHasSetTemperature = false;
      }
    public void setSetWindSpeed(double new_value)
      {
        flagHasSetWindSpeed = true;
        if (new_value < 0)
            throw new Exception("The value for field SetWindSpeed of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field SetWindSpeed of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        storeSetWindSpeed = new_value;
        textStoreSetWindSpeed = "";
      }
    public void setSetWindSpeedText(string new_value)
      {
        flagHasSetWindSpeed = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SetWindSpeed of HomeAutomationActionResponseJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field SetWindSpeed of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field SetWindSpeed of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        textStoreSetWindSpeed = new_value;
      }
    public void unsetSetWindSpeed()
      {
        flagHasSetWindSpeed = false;
      }
    public void setStartCleaning(bool new_value)
      {
        flagHasStartCleaning = true;
        storeStartCleaning = new_value;
      }
    public void unsetStartCleaning()
      {
        flagHasStartCleaning = false;
      }
    public void setStopCleaning(bool new_value)
      {
        flagHasStopCleaning = true;
        storeStopCleaning = new_value;
      }
    public void unsetStopCleaning()
      {
        flagHasStopCleaning = false;
      }
    public void setTurboControl(HomeAutomationTurboModeJSON  new_value)
      {
        if (flagHasTurboControl)
          {
          }
        flagHasTurboControl = true;
        storeTurboControl = new_value;
      }
    public void setTurboControl(HomeAutomationTurboModeJSON.TypeValue new_value)
      {
        setTurboControl(new HomeAutomationTurboModeJSON(new_value));
      }
    public void setTurboControl(string chars)
      {
        HomeAutomationTurboModeJSON.TypeValueKnownValues known = HomeAutomationTurboModeJSON.stringToValue(chars);
        HomeAutomationTurboModeJSON.TypeValue new_value = new HomeAutomationTurboModeJSON.TypeValue();
        if (known == HomeAutomationTurboModeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTurboControl(new_value);
      }
    public void unsetTurboControl()
      {
        if (flagHasTurboControl)
          {
          }
        flagHasTurboControl = false;
      }
    public void setReady(bool new_value)
      {
        flagHasReady = true;
        storeReady = new_value;
      }
    public void unsetReady()
      {
        flagHasReady = false;
      }
    public void setPause(bool new_value)
      {
        flagHasPause = true;
        storePause = new_value;
      }
    public void unsetPause()
      {
        flagHasPause = false;
      }
    public void setCancel(bool new_value)
      {
        flagHasCancel = true;
        storeCancel = new_value;
      }
    public void unsetCancel()
      {
        flagHasCancel = false;
      }
    public void setCurrentTemperature(HomeAutomationTemperatureJSON  new_value)
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = true;
        storeCurrentTemperature = new_value;
      }
    public void unsetCurrentTemperature()
      {
        if (flagHasCurrentTemperature)
          {
          }
        flagHasCurrentTemperature = false;
      }
    public void setLock(bool new_value)
      {
        flagHasLock = true;
        storeLock = new_value;
      }
    public void unsetLock()
      {
        flagHasLock = false;
      }
    public void setUnlock(bool new_value)
      {
        flagHasUnlock = true;
        storeUnlock = new_value;
      }
    public void unsetUnlock()
      {
        flagHasUnlock = false;
      }
    public void setOpen(bool new_value)
      {
        flagHasOpen = true;
        storeOpen = new_value;
      }
    public void unsetOpen()
      {
        flagHasOpen = false;
      }
    public void setClose(bool new_value)
      {
        flagHasClose = true;
        storeClose = new_value;
      }
    public void unsetClose()
      {
        flagHasClose = false;
      }
    public void setAlarm(bool new_value)
      {
        flagHasAlarm = true;
        storeAlarm = new_value;
      }
    public void unsetAlarm()
      {
        flagHasAlarm = false;
      }
    public void setTimeRemaining(double new_value)
      {
        flagHasTimeRemaining = true;
        if (new_value < 0)
            throw new Exception("The value for field TimeRemaining of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        storeTimeRemaining = new_value;
        textStoreTimeRemaining = "";
      }
    public void setTimeRemainingText(string new_value)
      {
        flagHasTimeRemaining = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TimeRemaining of HomeAutomationActionResponseJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field TimeRemaining of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        textStoreTimeRemaining = new_value;
      }
    public void unsetTimeRemaining()
      {
        flagHasTimeRemaining = false;
      }
    public void setStage(string new_value)
      {
        flagHasStage = true;
        storeStage = new_value;
      }
    public void unsetStage()
      {
        flagHasStage = false;
      }
    public void initSensorReading()
      {
        if (flagHasSensorReading)
          {
            for (int num1 = 0; num1 < storeSensorReading.Count; ++num1)
              {
              }
          }
        flagHasSensorReading = true;
        storeSensorReading.Clear();
      }
    public void appendSensorReading(TypeSensorReadingJSON  to_append)
      {
        if (!flagHasSensorReading)
          {
            flagHasSensorReading = true;
            storeSensorReading.Clear();
          }
        Debug.Assert(flagHasSensorReading);
        storeSensorReading.Add(to_append);
      }
    public void unsetSensorReading()
      {
        if (flagHasSensorReading)
          {
            for (int num2 = 0; num2 < storeSensorReading.Count; ++num2)
              {
              }
          }
        flagHasSensorReading = false;
        storeSensorReading.Clear();
      }
    public void setMotionSensor(HomeAutomationMotionStatusJSON  new_value)
      {
        if (flagHasMotionSensor)
          {
          }
        flagHasMotionSensor = true;
        storeMotionSensor = new_value;
      }
    public void unsetMotionSensor()
      {
        if (flagHasMotionSensor)
          {
          }
        flagHasMotionSensor = false;
      }
    public void setMovementSensor(HomeAutomationMovementStatusJSON  new_value)
      {
        if (flagHasMovementSensor)
          {
          }
        flagHasMovementSensor = true;
        storeMovementSensor = new_value;
      }
    public void unsetMovementSensor()
      {
        if (flagHasMovementSensor)
          {
          }
        flagHasMovementSensor = false;
      }
    public void setSetVolume(double new_value)
      {
        flagHasSetVolume = true;
        if (new_value < 0)
            throw new Exception("The value for field SetVolume of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field SetVolume of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        storeSetVolume = new_value;
        textStoreSetVolume = "";
      }
    public void setSetVolumeText(string new_value)
      {
        flagHasSetVolume = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SetVolume of HomeAutomationActionResponseJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field SetVolume of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field SetVolume of HomeAutomationActionResponseJSON is greater than the upper bound (1) for that field.");
        textStoreSetVolume = new_value;
      }
    public void unsetSetVolume()
      {
        flagHasSetVolume = false;
      }
    public void setMute(bool new_value)
      {
        flagHasMute = true;
        storeMute = new_value;
      }
    public void unsetMute()
      {
        flagHasMute = false;
      }
    public void setUnmute(bool new_value)
      {
        flagHasUnmute = true;
        storeUnmute = new_value;
      }
    public void unsetUnmute()
      {
        flagHasUnmute = false;
      }
    public void setChangeChannel(double new_value)
      {
        flagHasChangeChannel = true;
        if (new_value < 0)
            throw new Exception("The value for field ChangeChannel of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        storeChangeChannel = new_value;
        textStoreChangeChannel = "";
      }
    public void setChangeChannelText(string new_value)
      {
        flagHasChangeChannel = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ChangeChannel of HomeAutomationActionResponseJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field ChangeChannel of HomeAutomationActionResponseJSON is less than the lower bound (0) for that field.");
        textStoreChangeChannel = new_value;
      }
    public void unsetChangeChannel()
      {
        flagHasChangeChannel = false;
      }

    public virtual void extraHomeAutomationActionResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationActionResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationActionResponseLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationActionResponseAppendPair(key, new_component);
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
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (partial_allowed)
                storeError.write_partial_as_json(handler);
            else
                storeError.write_as_json(handler);
          }
        if (flagHasAuto)
          {
            handler.start_pair("Auto");
            handler.boolean_value(storeAuto);
          }
        if (flagHasSleep)
          {
            handler.start_pair("Sleep");
            handler.boolean_value(storeSleep);
          }
        if (flagHasWake)
          {
            handler.start_pair("Wake");
            handler.boolean_value(storeWake);
          }
        if (flagHasTurnOn)
          {
            handler.start_pair("TurnOn");
            handler.boolean_value(storeTurnOn);
          }
        if (flagHasTurnOff)
          {
            handler.start_pair("TurnOff");
            handler.boolean_value(storeTurnOff);
          }
        if (flagHasSetBrightness)
          {
            handler.start_pair("SetBrightness");
            if (textStoreSetBrightness != "")
                handler.number_value(textStoreSetBrightness);
            else if (((double)(long)storeSetBrightness) == storeSetBrightness)
                handler.number_value((long)storeSetBrightness);
            else
                handler.number_value(storeSetBrightness);
          }
        if (flagHasSetColor)
          {
            handler.start_pair("SetColor");
            if (partial_allowed)
                storeSetColor.write_partial_as_json(handler);
            else
                storeSetColor.write_as_json(handler);
          }
        if (flagHasHeat)
          {
            handler.start_pair("Heat");
            handler.boolean_value(storeHeat);
          }
        if (flagHasCool)
          {
            handler.start_pair("Cool");
            handler.boolean_value(storeCool);
          }
        if (flagHasDry)
          {
            handler.start_pair("Dry");
            handler.boolean_value(storeDry);
          }
        if (flagHasWind)
          {
            handler.start_pair("Wind");
            handler.boolean_value(storeWind);
          }
        if (flagHasSetTemperature)
          {
            handler.start_pair("SetTemperature");
            if (partial_allowed)
                storeSetTemperature.write_partial_as_json(handler);
            else
                storeSetTemperature.write_as_json(handler);
          }
        if (flagHasSetWindSpeed)
          {
            handler.start_pair("SetWindSpeed");
            if (textStoreSetWindSpeed != "")
                handler.number_value(textStoreSetWindSpeed);
            else if (((double)(long)storeSetWindSpeed) == storeSetWindSpeed)
                handler.number_value((long)storeSetWindSpeed);
            else
                handler.number_value(storeSetWindSpeed);
          }
        if (flagHasStartCleaning)
          {
            handler.start_pair("StartCleaning");
            handler.boolean_value(storeStartCleaning);
          }
        if (flagHasStopCleaning)
          {
            handler.start_pair("StopCleaning");
            handler.boolean_value(storeStopCleaning);
          }
        if (flagHasTurboControl)
          {
            handler.start_pair("TurboControl");
            if (partial_allowed)
                storeTurboControl.write_partial_as_json(handler);
            else
                storeTurboControl.write_as_json(handler);
          }
        if (flagHasReady)
          {
            handler.start_pair("Ready");
            handler.boolean_value(storeReady);
          }
        if (flagHasPause)
          {
            handler.start_pair("Pause");
            handler.boolean_value(storePause);
          }
        if (flagHasCancel)
          {
            handler.start_pair("Cancel");
            handler.boolean_value(storeCancel);
          }
        if (flagHasCurrentTemperature)
          {
            handler.start_pair("CurrentTemperature");
            if (partial_allowed)
                storeCurrentTemperature.write_partial_as_json(handler);
            else
                storeCurrentTemperature.write_as_json(handler);
          }
        if (flagHasLock)
          {
            handler.start_pair("Lock");
            handler.boolean_value(storeLock);
          }
        if (flagHasUnlock)
          {
            handler.start_pair("Unlock");
            handler.boolean_value(storeUnlock);
          }
        if (flagHasOpen)
          {
            handler.start_pair("Open");
            handler.boolean_value(storeOpen);
          }
        if (flagHasClose)
          {
            handler.start_pair("Close");
            handler.boolean_value(storeClose);
          }
        if (flagHasAlarm)
          {
            handler.start_pair("Alarm");
            handler.boolean_value(storeAlarm);
          }
        if (flagHasTimeRemaining)
          {
            handler.start_pair("TimeRemaining");
            if (textStoreTimeRemaining != "")
                handler.number_value(textStoreTimeRemaining);
            else if (((double)(long)storeTimeRemaining) == storeTimeRemaining)
                handler.number_value((long)storeTimeRemaining);
            else
                handler.number_value(storeTimeRemaining);
          }
        if (flagHasStage)
          {
            handler.start_pair("Stage");
            handler.string_value(storeStage);
          }
        if (flagHasSensorReading)
          {
            handler.start_pair("SensorReading");
            Debug.Assert(storeSensorReading.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeSensorReading.Count; ++num1)
              {
                if (partial_allowed)
                    storeSensorReading[num1].write_partial_as_json(handler);
                else
                    storeSensorReading[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMotionSensor)
          {
            handler.start_pair("MotionSensor");
            if (partial_allowed)
                storeMotionSensor.write_partial_as_json(handler);
            else
                storeMotionSensor.write_as_json(handler);
          }
        if (flagHasMovementSensor)
          {
            handler.start_pair("MovementSensor");
            if (partial_allowed)
                storeMovementSensor.write_partial_as_json(handler);
            else
                storeMovementSensor.write_as_json(handler);
          }
        if (flagHasSetVolume)
          {
            handler.start_pair("SetVolume");
            if (textStoreSetVolume != "")
                handler.number_value(textStoreSetVolume);
            else if (((double)(long)storeSetVolume) == storeSetVolume)
                handler.number_value((long)storeSetVolume);
            else
                handler.number_value(storeSetVolume);
          }
        if (flagHasMute)
          {
            handler.start_pair("Mute");
            handler.boolean_value(storeMute);
          }
        if (flagHasUnmute)
          {
            handler.start_pair("Unmute");
            handler.boolean_value(storeUnmute);
          }
        if (flagHasChangeChannel)
          {
            handler.start_pair("ChangeChannel");
            if (textStoreChangeChannel != "")
                handler.number_value(textStoreChangeChannel);
            else if (((double)(long)storeChangeChannel) == storeChangeChannel)
                handler.number_value((long)storeChangeChannel);
            else
                handler.number_value(storeChangeChannel);
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

    public static HomeAutomationActionResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponse", ignore_extras);
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
    public static HomeAutomationActionResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponse", ignore_extras);
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
    public static HomeAutomationActionResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResponseJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationActionResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationActionResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationActionResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationActionResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeErrorJSON.HoldingGenerator fieldGeneratorError;
        private JSONHoldingBooleanGenerator fieldGeneratorAuto;
        private JSONHoldingBooleanGenerator fieldGeneratorSleep;
        private JSONHoldingBooleanGenerator fieldGeneratorWake;
        private JSONHoldingBooleanGenerator fieldGeneratorTurnOn;
        private JSONHoldingBooleanGenerator fieldGeneratorTurnOff;
        private JSONHoldingNumberTextGenerator fieldGeneratorSetBrightness;
        private ColorJSON.HoldingGenerator fieldGeneratorSetColor;
        private JSONHoldingBooleanGenerator fieldGeneratorHeat;
        private JSONHoldingBooleanGenerator fieldGeneratorCool;
        private JSONHoldingBooleanGenerator fieldGeneratorDry;
        private JSONHoldingBooleanGenerator fieldGeneratorWind;
        private HomeAutomationTemperatureJSON.HoldingGenerator fieldGeneratorSetTemperature;
        private JSONHoldingNumberTextGenerator fieldGeneratorSetWindSpeed;
        private JSONHoldingBooleanGenerator fieldGeneratorStartCleaning;
        private JSONHoldingBooleanGenerator fieldGeneratorStopCleaning;
        private HomeAutomationTurboModeJSON.HoldingGenerator fieldGeneratorTurboControl;
        private JSONHoldingBooleanGenerator fieldGeneratorReady;
        private JSONHoldingBooleanGenerator fieldGeneratorPause;
        private JSONHoldingBooleanGenerator fieldGeneratorCancel;
        private HomeAutomationTemperatureJSON.HoldingGenerator fieldGeneratorCurrentTemperature;
        private JSONHoldingBooleanGenerator fieldGeneratorLock;
        private JSONHoldingBooleanGenerator fieldGeneratorUnlock;
        private JSONHoldingBooleanGenerator fieldGeneratorOpen;
        private JSONHoldingBooleanGenerator fieldGeneratorClose;
        private JSONHoldingBooleanGenerator fieldGeneratorAlarm;
        private JSONHoldingNumberTextGenerator fieldGeneratorTimeRemaining;
        private JSONHoldingStringGenerator fieldGeneratorStage;
        private TypeSensorReadingJSON.HoldingArrayGenerator fieldGeneratorSensorReading;
        private HomeAutomationMotionStatusJSON.HoldingGenerator fieldGeneratorMotionSensor;
        private HomeAutomationMovementStatusJSON.HoldingGenerator fieldGeneratorMovementSensor;
        private JSONHoldingNumberTextGenerator fieldGeneratorSetVolume;
        private JSONHoldingBooleanGenerator fieldGeneratorMute;
        private JSONHoldingBooleanGenerator fieldGeneratorUnmute;
        private JSONHoldingNumberTextGenerator fieldGeneratorChangeChannel;
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
            HomeAutomationActionResponseJSON result = new HomeAutomationActionResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationActionResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationActionResponseJSON result)
          {
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
            if (fieldGeneratorAuto.have_value)
              {
                result.setAuto(fieldGeneratorAuto.value);
                fieldGeneratorAuto.have_value = false;
              }
            if (fieldGeneratorSleep.have_value)
              {
                result.setSleep(fieldGeneratorSleep.value);
                fieldGeneratorSleep.have_value = false;
              }
            if (fieldGeneratorWake.have_value)
              {
                result.setWake(fieldGeneratorWake.value);
                fieldGeneratorWake.have_value = false;
              }
            if (fieldGeneratorTurnOn.have_value)
              {
                result.setTurnOn(fieldGeneratorTurnOn.value);
                fieldGeneratorTurnOn.have_value = false;
              }
            if (fieldGeneratorTurnOff.have_value)
              {
                result.setTurnOff(fieldGeneratorTurnOff.value);
                fieldGeneratorTurnOff.have_value = false;
              }
            if (fieldGeneratorSetBrightness.have_value)
              {
                result.setSetBrightnessText(fieldGeneratorSetBrightness.value);
                fieldGeneratorSetBrightness.have_value = false;
              }
            if (fieldGeneratorSetColor.have_value)
              {
                result.setSetColor(fieldGeneratorSetColor.value);
                fieldGeneratorSetColor.have_value = false;
              }
            if (fieldGeneratorHeat.have_value)
              {
                result.setHeat(fieldGeneratorHeat.value);
                fieldGeneratorHeat.have_value = false;
              }
            if (fieldGeneratorCool.have_value)
              {
                result.setCool(fieldGeneratorCool.value);
                fieldGeneratorCool.have_value = false;
              }
            if (fieldGeneratorDry.have_value)
              {
                result.setDry(fieldGeneratorDry.value);
                fieldGeneratorDry.have_value = false;
              }
            if (fieldGeneratorWind.have_value)
              {
                result.setWind(fieldGeneratorWind.value);
                fieldGeneratorWind.have_value = false;
              }
            if (fieldGeneratorSetTemperature.have_value)
              {
                result.setSetTemperature(fieldGeneratorSetTemperature.value);
                fieldGeneratorSetTemperature.have_value = false;
              }
            if (fieldGeneratorSetWindSpeed.have_value)
              {
                result.setSetWindSpeedText(fieldGeneratorSetWindSpeed.value);
                fieldGeneratorSetWindSpeed.have_value = false;
              }
            if (fieldGeneratorStartCleaning.have_value)
              {
                result.setStartCleaning(fieldGeneratorStartCleaning.value);
                fieldGeneratorStartCleaning.have_value = false;
              }
            if (fieldGeneratorStopCleaning.have_value)
              {
                result.setStopCleaning(fieldGeneratorStopCleaning.value);
                fieldGeneratorStopCleaning.have_value = false;
              }
            if (fieldGeneratorTurboControl.have_value)
              {
                result.setTurboControl(fieldGeneratorTurboControl.value);
                fieldGeneratorTurboControl.have_value = false;
              }
            if (fieldGeneratorReady.have_value)
              {
                result.setReady(fieldGeneratorReady.value);
                fieldGeneratorReady.have_value = false;
              }
            if (fieldGeneratorPause.have_value)
              {
                result.setPause(fieldGeneratorPause.value);
                fieldGeneratorPause.have_value = false;
              }
            if (fieldGeneratorCancel.have_value)
              {
                result.setCancel(fieldGeneratorCancel.value);
                fieldGeneratorCancel.have_value = false;
              }
            if (fieldGeneratorCurrentTemperature.have_value)
              {
                result.setCurrentTemperature(fieldGeneratorCurrentTemperature.value);
                fieldGeneratorCurrentTemperature.have_value = false;
              }
            if (fieldGeneratorLock.have_value)
              {
                result.setLock(fieldGeneratorLock.value);
                fieldGeneratorLock.have_value = false;
              }
            if (fieldGeneratorUnlock.have_value)
              {
                result.setUnlock(fieldGeneratorUnlock.value);
                fieldGeneratorUnlock.have_value = false;
              }
            if (fieldGeneratorOpen.have_value)
              {
                result.setOpen(fieldGeneratorOpen.value);
                fieldGeneratorOpen.have_value = false;
              }
            if (fieldGeneratorClose.have_value)
              {
                result.setClose(fieldGeneratorClose.value);
                fieldGeneratorClose.have_value = false;
              }
            if (fieldGeneratorAlarm.have_value)
              {
                result.setAlarm(fieldGeneratorAlarm.value);
                fieldGeneratorAlarm.have_value = false;
              }
            if (fieldGeneratorTimeRemaining.have_value)
              {
                result.setTimeRemainingText(fieldGeneratorTimeRemaining.value);
                fieldGeneratorTimeRemaining.have_value = false;
              }
            if (fieldGeneratorStage.have_value)
              {
                result.setStage(fieldGeneratorStage.value);
                fieldGeneratorStage.have_value = false;
              }
            if (fieldGeneratorSensorReading.have_value)
              {
                result.initSensorReading();
                int count = fieldGeneratorSensorReading.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSensorReading(fieldGeneratorSensorReading.value[num]);
                  }
                fieldGeneratorSensorReading.value.Clear();
                fieldGeneratorSensorReading.have_value = false;
              }
            if (fieldGeneratorMotionSensor.have_value)
              {
                result.setMotionSensor(fieldGeneratorMotionSensor.value);
                fieldGeneratorMotionSensor.have_value = false;
              }
            if (fieldGeneratorMovementSensor.have_value)
              {
                result.setMovementSensor(fieldGeneratorMovementSensor.value);
                fieldGeneratorMovementSensor.have_value = false;
              }
            if (fieldGeneratorSetVolume.have_value)
              {
                result.setSetVolumeText(fieldGeneratorSetVolume.value);
                fieldGeneratorSetVolume.have_value = false;
              }
            if (fieldGeneratorMute.have_value)
              {
                result.setMute(fieldGeneratorMute.value);
                fieldGeneratorMute.have_value = false;
              }
            if (fieldGeneratorUnmute.have_value)
              {
                result.setUnmute(fieldGeneratorUnmute.value);
                fieldGeneratorUnmute.have_value = false;
              }
            if (fieldGeneratorChangeChannel.have_value)
              {
                result.setChangeChannelText(fieldGeneratorChangeChannel.value);
                fieldGeneratorChangeChannel.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationActionResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "arm", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorAlarm;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "to", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorAuto;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ncel", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorCancel;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "angeChannel", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorChangeChannel;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ose", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorClose;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ol", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorCool;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrentTemperature", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorCurrentTemperature;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ry", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorDry;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "eat", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHeat;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ock", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorLock;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'o':
                            switch (field_name[2])
                              {
                                case 't':
                                    if ((String.Compare(field_name, 3, "ionSensor", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorMotionSensor;
                                    break;
                                case 'v':
                                    if ((String.Compare(field_name, 3, "ementSensor", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorMovementSensor;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "te", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorMute;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "pen", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorOpen;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ause", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorPause;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eady", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorReady;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 3, "sorReading", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorSensorReading;
                                    break;
                                case 't':
                                    switch (field_name[3])
                                      {
                                        case 'B':
                                            if ((String.Compare(field_name, 4, "rightness", 0, 9, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorSetBrightness;
                                            break;
                                        case 'C':
                                            if ((String.Compare(field_name, 4, "olor", 0, 4, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorSetColor;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 4, "emperature", 0, 10, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorSetTemperature;
                                            break;
                                        case 'V':
                                            if ((String.Compare(field_name, 4, "olume", 0, 5, false) == 0) && (field_name.Length == 9))
                                                return fieldGeneratorSetVolume;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 4, "indSpeed", 0, 8, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorSetWindSpeed;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "eep", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorSleep;
                            break;
                        case 't':
                            switch (field_name[2])
                              {
                                case 'a':
                                    switch (field_name[3])
                                      {
                                        case 'g':
                                            if ((String.Compare(field_name, 4, "e", 0, 1, false) == 0) && (field_name.Length == 5))
                                                return fieldGeneratorStage;
                                            break;
                                        case 'r':
                                            if ((String.Compare(field_name, 4, "tCleaning", 0, 9, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorStartCleaning;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 3, "pCleaning", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorStopCleaning;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "meRemaining", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorTimeRemaining;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "r", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'b':
                                        if ((String.Compare(field_name, 4, "oControl", 0, 8, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorTurboControl;
                                        break;
                                    case 'n':
                                        if (String.Compare(field_name, 4, "O", 0, 1, false) == 0)
                                          {
                                            switch (field_name[5])
                                              {
                                                case 'f':
                                                    if ((String.Compare(field_name, 6, "f", 0, 1, false) == 0) && (field_name.Length == 7))
                                                        return fieldGeneratorTurnOff;
                                                    break;
                                                case 'n':
                                                    if (field_name.Length == 6)
                                                        return fieldGeneratorTurnOn;
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
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 3, "ock", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorUnlock;
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 3, "ute", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorUnmute;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ke", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorWake;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nd", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorWind;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorError = new TypeErrorJSON.HoldingGenerator("field \"Error\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorAuto = new JSONHoldingBooleanGenerator("field \"Auto\" of the HomeAutomationActionResponse class");
            fieldGeneratorSleep = new JSONHoldingBooleanGenerator("field \"Sleep\" of the HomeAutomationActionResponse class");
            fieldGeneratorWake = new JSONHoldingBooleanGenerator("field \"Wake\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurnOn = new JSONHoldingBooleanGenerator("field \"TurnOn\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurnOff = new JSONHoldingBooleanGenerator("field \"TurnOff\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetBrightness = new JSONHoldingNumberTextGenerator("field \"SetBrightness\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetColor = new ColorJSON.HoldingGenerator("field \"SetColor\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorHeat = new JSONHoldingBooleanGenerator("field \"Heat\" of the HomeAutomationActionResponse class");
            fieldGeneratorCool = new JSONHoldingBooleanGenerator("field \"Cool\" of the HomeAutomationActionResponse class");
            fieldGeneratorDry = new JSONHoldingBooleanGenerator("field \"Dry\" of the HomeAutomationActionResponse class");
            fieldGeneratorWind = new JSONHoldingBooleanGenerator("field \"Wind\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetTemperature = new HomeAutomationTemperatureJSON.HoldingGenerator("field \"SetTemperature\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorSetWindSpeed = new JSONHoldingNumberTextGenerator("field \"SetWindSpeed\" of the HomeAutomationActionResponse class");
            fieldGeneratorStartCleaning = new JSONHoldingBooleanGenerator("field \"StartCleaning\" of the HomeAutomationActionResponse class");
            fieldGeneratorStopCleaning = new JSONHoldingBooleanGenerator("field \"StopCleaning\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurboControl = new HomeAutomationTurboModeJSON.HoldingGenerator("field \"TurboControl\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorReady = new JSONHoldingBooleanGenerator("field \"Ready\" of the HomeAutomationActionResponse class");
            fieldGeneratorPause = new JSONHoldingBooleanGenerator("field \"Pause\" of the HomeAutomationActionResponse class");
            fieldGeneratorCancel = new JSONHoldingBooleanGenerator("field \"Cancel\" of the HomeAutomationActionResponse class");
            fieldGeneratorCurrentTemperature = new HomeAutomationTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorLock = new JSONHoldingBooleanGenerator("field \"Lock\" of the HomeAutomationActionResponse class");
            fieldGeneratorUnlock = new JSONHoldingBooleanGenerator("field \"Unlock\" of the HomeAutomationActionResponse class");
            fieldGeneratorOpen = new JSONHoldingBooleanGenerator("field \"Open\" of the HomeAutomationActionResponse class");
            fieldGeneratorClose = new JSONHoldingBooleanGenerator("field \"Close\" of the HomeAutomationActionResponse class");
            fieldGeneratorAlarm = new JSONHoldingBooleanGenerator("field \"Alarm\" of the HomeAutomationActionResponse class");
            fieldGeneratorTimeRemaining = new JSONHoldingNumberTextGenerator("field \"TimeRemaining\" of the HomeAutomationActionResponse class");
            fieldGeneratorStage = new JSONHoldingStringGenerator("field \"Stage\" of the HomeAutomationActionResponse class");
            fieldGeneratorSensorReading = new TypeSensorReadingJSON.HoldingArrayGenerator("field \"SensorReading\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorMotionSensor = new HomeAutomationMotionStatusJSON.HoldingGenerator("field \"MotionSensor\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorMovementSensor = new HomeAutomationMovementStatusJSON.HoldingGenerator("field \"MovementSensor\" of the HomeAutomationActionResponse class", ignore_extras);
            fieldGeneratorSetVolume = new JSONHoldingNumberTextGenerator("field \"SetVolume\" of the HomeAutomationActionResponse class");
            fieldGeneratorMute = new JSONHoldingBooleanGenerator("field \"Mute\" of the HomeAutomationActionResponse class");
            fieldGeneratorUnmute = new JSONHoldingBooleanGenerator("field \"Unmute\" of the HomeAutomationActionResponse class");
            fieldGeneratorChangeChannel = new JSONHoldingNumberTextGenerator("field \"ChangeChannel\" of the HomeAutomationActionResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationActionResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorError = new TypeErrorJSON.HoldingGenerator("field \"Error\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorAuto = new JSONHoldingBooleanGenerator("field \"Auto\" of the HomeAutomationActionResponse class");
            fieldGeneratorSleep = new JSONHoldingBooleanGenerator("field \"Sleep\" of the HomeAutomationActionResponse class");
            fieldGeneratorWake = new JSONHoldingBooleanGenerator("field \"Wake\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurnOn = new JSONHoldingBooleanGenerator("field \"TurnOn\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurnOff = new JSONHoldingBooleanGenerator("field \"TurnOff\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetBrightness = new JSONHoldingNumberTextGenerator("field \"SetBrightness\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetColor = new ColorJSON.HoldingGenerator("field \"SetColor\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorHeat = new JSONHoldingBooleanGenerator("field \"Heat\" of the HomeAutomationActionResponse class");
            fieldGeneratorCool = new JSONHoldingBooleanGenerator("field \"Cool\" of the HomeAutomationActionResponse class");
            fieldGeneratorDry = new JSONHoldingBooleanGenerator("field \"Dry\" of the HomeAutomationActionResponse class");
            fieldGeneratorWind = new JSONHoldingBooleanGenerator("field \"Wind\" of the HomeAutomationActionResponse class");
            fieldGeneratorSetTemperature = new HomeAutomationTemperatureJSON.HoldingGenerator("field \"SetTemperature\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorSetWindSpeed = new JSONHoldingNumberTextGenerator("field \"SetWindSpeed\" of the HomeAutomationActionResponse class");
            fieldGeneratorStartCleaning = new JSONHoldingBooleanGenerator("field \"StartCleaning\" of the HomeAutomationActionResponse class");
            fieldGeneratorStopCleaning = new JSONHoldingBooleanGenerator("field \"StopCleaning\" of the HomeAutomationActionResponse class");
            fieldGeneratorTurboControl = new HomeAutomationTurboModeJSON.HoldingGenerator("field \"TurboControl\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorReady = new JSONHoldingBooleanGenerator("field \"Ready\" of the HomeAutomationActionResponse class");
            fieldGeneratorPause = new JSONHoldingBooleanGenerator("field \"Pause\" of the HomeAutomationActionResponse class");
            fieldGeneratorCancel = new JSONHoldingBooleanGenerator("field \"Cancel\" of the HomeAutomationActionResponse class");
            fieldGeneratorCurrentTemperature = new HomeAutomationTemperatureJSON.HoldingGenerator("field \"CurrentTemperature\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorLock = new JSONHoldingBooleanGenerator("field \"Lock\" of the HomeAutomationActionResponse class");
            fieldGeneratorUnlock = new JSONHoldingBooleanGenerator("field \"Unlock\" of the HomeAutomationActionResponse class");
            fieldGeneratorOpen = new JSONHoldingBooleanGenerator("field \"Open\" of the HomeAutomationActionResponse class");
            fieldGeneratorClose = new JSONHoldingBooleanGenerator("field \"Close\" of the HomeAutomationActionResponse class");
            fieldGeneratorAlarm = new JSONHoldingBooleanGenerator("field \"Alarm\" of the HomeAutomationActionResponse class");
            fieldGeneratorTimeRemaining = new JSONHoldingNumberTextGenerator("field \"TimeRemaining\" of the HomeAutomationActionResponse class");
            fieldGeneratorStage = new JSONHoldingStringGenerator("field \"Stage\" of the HomeAutomationActionResponse class");
            fieldGeneratorSensorReading = new TypeSensorReadingJSON.HoldingArrayGenerator("field \"SensorReading\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorMotionSensor = new HomeAutomationMotionStatusJSON.HoldingGenerator("field \"MotionSensor\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorMovementSensor = new HomeAutomationMovementStatusJSON.HoldingGenerator("field \"MovementSensor\" of the HomeAutomationActionResponse class", false);
            fieldGeneratorSetVolume = new JSONHoldingNumberTextGenerator("field \"SetVolume\" of the HomeAutomationActionResponse class");
            fieldGeneratorMute = new JSONHoldingBooleanGenerator("field \"Mute\" of the HomeAutomationActionResponse class");
            fieldGeneratorUnmute = new JSONHoldingBooleanGenerator("field \"Unmute\" of the HomeAutomationActionResponse class");
            fieldGeneratorChangeChannel = new JSONHoldingNumberTextGenerator("field \"ChangeChannel\" of the HomeAutomationActionResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationActionResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorError.reset();
            fieldGeneratorAuto.reset();
            fieldGeneratorSleep.reset();
            fieldGeneratorWake.reset();
            fieldGeneratorTurnOn.reset();
            fieldGeneratorTurnOff.reset();
            fieldGeneratorSetBrightness.reset();
            fieldGeneratorSetColor.reset();
            fieldGeneratorHeat.reset();
            fieldGeneratorCool.reset();
            fieldGeneratorDry.reset();
            fieldGeneratorWind.reset();
            fieldGeneratorSetTemperature.reset();
            fieldGeneratorSetWindSpeed.reset();
            fieldGeneratorStartCleaning.reset();
            fieldGeneratorStopCleaning.reset();
            fieldGeneratorTurboControl.reset();
            fieldGeneratorReady.reset();
            fieldGeneratorPause.reset();
            fieldGeneratorCancel.reset();
            fieldGeneratorCurrentTemperature.reset();
            fieldGeneratorLock.reset();
            fieldGeneratorUnlock.reset();
            fieldGeneratorOpen.reset();
            fieldGeneratorClose.reset();
            fieldGeneratorAlarm.reset();
            fieldGeneratorTimeRemaining.reset();
            fieldGeneratorStage.reset();
            fieldGeneratorSensorReading.reset();
            fieldGeneratorMotionSensor.reset();
            fieldGeneratorMovementSensor.reset();
            fieldGeneratorSetVolume.reset();
            fieldGeneratorMute.reset();
            fieldGeneratorUnmute.reset();
            fieldGeneratorChangeChannel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorError.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSetColor.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSetTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTurboControl.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCurrentTemperature.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSensorReading.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMotionSensor.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMovementSensor.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorError.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSetColor.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSetTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTurboControl.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCurrentTemperature.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSensorReading.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMotionSensor.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMovementSensor.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationActionResponseJSON  result)
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
        public HomeAutomationActionResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationActionResponseJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationActionResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationActionResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationActionResponseJSON>();
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
    public List<HomeAutomationActionResponseJSON> value;
  };
  };
