/* file "HondaAgentParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HondaAgentParametersJSON : JSONBase
  {
    public class TypeUsersJSON : JSONBase
      {
        private bool flagHasID;
        private string storeID;
        private bool flagHasFaceRecognized;
        private bool storeFaceRecognized;
        private bool flagHasFaceExpression;
        private string storeFaceExpression;
        private bool flagHasDriver;
        private bool storeDriver;
        private bool flagHasName;
        private string storeName;
        private bool flagHasRunTutorial;
        private bool storeRunTutorial;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ID of TypeUsersJSON is not a string.");
            setID(json_string.getData());
          }


        private void  fromJSONFaceRecognized(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field FaceRecognized of TypeUsersJSON is not true for false.");
                  }
              }
            setFaceRecognized(the_bool);
          }


        private void  fromJSONFaceExpression(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field FaceExpression of TypeUsersJSON is not a string.");
            setFaceExpression(json_string.getData());
          }


        private void  fromJSONDriver(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Driver of TypeUsersJSON is not true for false.");
                  }
              }
            setDriver(the_bool);
          }


        private void  fromJSONName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Name of TypeUsersJSON is not a string.");
            setName(json_string.getData());
          }


        private void  fromJSONRunTutorial(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field RunTutorial of TypeUsersJSON is not true for false.");
                  }
              }
            setRunTutorial(the_bool);
          }


        public TypeUsersJSON()
          {
            flagHasID = false;
            flagHasFaceRecognized = false;
            flagHasFaceExpression = false;
            flagHasDriver = false;
            flagHasName = false;
            flagHasRunTutorial = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasID()
          {
            return flagHasID;
          }

        public string  getID()
          {
            Debug.Assert(flagHasID);
            return storeID;
          }

        public bool  hasFaceRecognized()
          {
            return flagHasFaceRecognized;
          }

        public bool  getFaceRecognized()
          {
            Debug.Assert(flagHasFaceRecognized);
            return storeFaceRecognized;
          }

        public bool  hasFaceExpression()
          {
            return flagHasFaceExpression;
          }

        public string  getFaceExpression()
          {
            Debug.Assert(flagHasFaceExpression);
            return storeFaceExpression;
          }

        public bool  hasDriver()
          {
            return flagHasDriver;
          }

        public bool  getDriver()
          {
            Debug.Assert(flagHasDriver);
            return storeDriver;
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

        public bool  hasRunTutorial()
          {
            return flagHasRunTutorial;
          }

        public bool  getRunTutorial()
          {
            Debug.Assert(flagHasRunTutorial);
            return storeRunTutorial;
          }


        public virtual int extraTypeUsersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeUsersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeUsersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeUsersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setID(string new_value)
          {
            flagHasID = true;
            storeID = new_value;
          }
        public void unsetID()
          {
            flagHasID = false;
          }
        public void setFaceRecognized(bool new_value)
          {
            flagHasFaceRecognized = true;
            storeFaceRecognized = new_value;
          }
        public void unsetFaceRecognized()
          {
            flagHasFaceRecognized = false;
          }
        public void setFaceExpression(string new_value)
          {
            flagHasFaceExpression = true;
            storeFaceExpression = new_value;
          }
        public void unsetFaceExpression()
          {
            flagHasFaceExpression = false;
          }
        public void setDriver(bool new_value)
          {
            flagHasDriver = true;
            storeDriver = new_value;
          }
        public void unsetDriver()
          {
            flagHasDriver = false;
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
        public void setRunTutorial(bool new_value)
          {
            flagHasRunTutorial = true;
            storeRunTutorial = new_value;
          }
        public void unsetRunTutorial()
          {
            flagHasRunTutorial = false;
          }

        public virtual void extraTypeUsersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeUsersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeUsersLookup(key);
            if (old_field == null)
              {
                extraTypeUsersAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasID);
            if (flagHasID)
              {
                handler.start_pair("ID");
                handler.string_value(storeID);
              }
            if (flagHasFaceRecognized)
              {
                handler.start_pair("FaceRecognized");
                handler.boolean_value(storeFaceRecognized);
              }
            if (flagHasFaceExpression)
              {
                handler.start_pair("FaceExpression");
                handler.string_value(storeFaceExpression);
              }
            Debug.Assert(partial_allowed || flagHasDriver);
            if (flagHasDriver)
              {
                handler.start_pair("Driver");
                handler.boolean_value(storeDriver);
              }
            if (flagHasName)
              {
                handler.start_pair("Name");
                handler.string_value(storeName);
              }
            if (flagHasRunTutorial)
              {
                handler.start_pair("RunTutorial");
                handler.boolean_value(storeRunTutorial);
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
            if (!(hasID()))
              {
                return "When parsing the object for %what%, the \"ID\" field was missing.";
              }
            if (!(hasDriver()))
              {
                return "When parsing the object for %what%, the \"Driver\" field was missing.";
              }
            return null;
          }

        public static TypeUsersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUsersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUsers", ignore_extras);
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
        public static TypeUsersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUsersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUsersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUsers", ignore_extras);
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
        public static TypeUsersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUsersJSON from_text(string text, bool ignore_extras)
          {
            TypeUsersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUsers", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeUsersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeUsersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeUsersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUsers", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorID;
            private JSONHoldingBooleanGenerator fieldGeneratorFaceRecognized;
            private JSONHoldingStringGenerator fieldGeneratorFaceExpression;
            private JSONHoldingBooleanGenerator fieldGeneratorDriver;
            private JSONHoldingStringGenerator fieldGeneratorName;
            private JSONHoldingBooleanGenerator fieldGeneratorRunTutorial;
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
                TypeUsersJSON result = new TypeUsersJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeUsersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeUsersJSON result)
              {
                if (fieldGeneratorID.have_value)
                  {
                    result.setID(fieldGeneratorID.value);
                    fieldGeneratorID.have_value = false;
                  }
                else if ((!(result.hasID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ID\" field was missing.");
                  }
                if (fieldGeneratorFaceRecognized.have_value)
                  {
                    result.setFaceRecognized(fieldGeneratorFaceRecognized.value);
                    fieldGeneratorFaceRecognized.have_value = false;
                  }
                if (fieldGeneratorFaceExpression.have_value)
                  {
                    result.setFaceExpression(fieldGeneratorFaceExpression.value);
                    fieldGeneratorFaceExpression.have_value = false;
                  }
                if (fieldGeneratorDriver.have_value)
                  {
                    result.setDriver(fieldGeneratorDriver.value);
                    fieldGeneratorDriver.have_value = false;
                  }
                else if ((!(result.hasDriver())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Driver\" field was missing.");
                  }
                if (fieldGeneratorName.have_value)
                  {
                    result.setName(fieldGeneratorName.value);
                    fieldGeneratorName.have_value = false;
                  }
                if (fieldGeneratorRunTutorial.have_value)
                  {
                    result.setRunTutorial(fieldGeneratorRunTutorial.value);
                    fieldGeneratorRunTutorial.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeUsersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "river", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorDriver;
                        break;
                    case 'F':
                        if (String.Compare(field_name, 1, "ace", 0, 3, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 5, "xpression", 0, 9, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorFaceExpression;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 5, "ecognized", 0, 9, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorFaceRecognized;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorID;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorName;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "unTutorial", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorRunTutorial;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeUsers class");
                fieldGeneratorFaceRecognized = new JSONHoldingBooleanGenerator("field \"FaceRecognized\" of the TypeUsers class");
                fieldGeneratorFaceExpression = new JSONHoldingStringGenerator("field \"FaceExpression\" of the TypeUsers class");
                fieldGeneratorDriver = new JSONHoldingBooleanGenerator("field \"Driver\" of the TypeUsers class");
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeUsers class");
                fieldGeneratorRunTutorial = new JSONHoldingBooleanGenerator("field \"RunTutorial\" of the TypeUsers class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeUsers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeUsers class");
                fieldGeneratorFaceRecognized = new JSONHoldingBooleanGenerator("field \"FaceRecognized\" of the TypeUsers class");
                fieldGeneratorFaceExpression = new JSONHoldingStringGenerator("field \"FaceExpression\" of the TypeUsers class");
                fieldGeneratorDriver = new JSONHoldingBooleanGenerator("field \"Driver\" of the TypeUsers class");
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeUsers class");
                fieldGeneratorRunTutorial = new JSONHoldingBooleanGenerator("field \"RunTutorial\" of the TypeUsers class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeUsers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorID.reset();
                fieldGeneratorFaceRecognized.reset();
                fieldGeneratorFaceExpression.reset();
                fieldGeneratorDriver.reset();
                fieldGeneratorName.reset();
                fieldGeneratorRunTutorial.reset();
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
            protected override void handle_result(TypeUsersJSON  result)
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
            public TypeUsersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeUsersJSON  result)
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
        protected virtual void handle_result(List<TypeUsersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeUsersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeUsersJSON>();
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
        public List<TypeUsersJSON> value;
      };
      };
    public class TypeTrackPlayedJSON : JSONBase
      {
        private bool flagHastitle;
        private string storetitle;
        private bool flagHasartist;
        private string storeartist;
        private bool flagHasalbum;
        private string storealbum;
        private bool flagHasyear_released;
        private string storeyear_released;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONtitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field title of TypeTrackPlayedJSON is not a string.");
            settitle(json_string.getData());
          }


        private void  fromJSONartist(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field artist of TypeTrackPlayedJSON is not a string.");
            setartist(json_string.getData());
          }


        private void  fromJSONalbum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field album of TypeTrackPlayedJSON is not a string.");
            setalbum(json_string.getData());
          }


        private void  fromJSONyear_released(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field year_released of TypeTrackPlayedJSON is not a string.");
            setyear_released(json_string.getData());
          }


        public TypeTrackPlayedJSON()
          {
            flagHastitle = false;
            flagHasartist = false;
            flagHasalbum = false;
            flagHasyear_released = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hastitle()
          {
            return flagHastitle;
          }

        public string  gettitle()
          {
            Debug.Assert(flagHastitle);
            return storetitle;
          }

        public bool  hasartist()
          {
            return flagHasartist;
          }

        public string  getartist()
          {
            Debug.Assert(flagHasartist);
            return storeartist;
          }

        public bool  hasalbum()
          {
            return flagHasalbum;
          }

        public string  getalbum()
          {
            Debug.Assert(flagHasalbum);
            return storealbum;
          }

        public bool  hasyear_released()
          {
            return flagHasyear_released;
          }

        public string  getyear_released()
          {
            Debug.Assert(flagHasyear_released);
            return storeyear_released;
          }


        public virtual int extraTypeTrackPlayedComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTrackPlayedComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTrackPlayedComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTrackPlayedLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void settitle(string new_value)
          {
            flagHastitle = true;
            storetitle = new_value;
          }
        public void unsettitle()
          {
            flagHastitle = false;
          }
        public void setartist(string new_value)
          {
            flagHasartist = true;
            storeartist = new_value;
          }
        public void unsetartist()
          {
            flagHasartist = false;
          }
        public void setalbum(string new_value)
          {
            flagHasalbum = true;
            storealbum = new_value;
          }
        public void unsetalbum()
          {
            flagHasalbum = false;
          }
        public void setyear_released(string new_value)
          {
            flagHasyear_released = true;
            storeyear_released = new_value;
          }
        public void unsetyear_released()
          {
            flagHasyear_released = false;
          }

        public virtual void extraTypeTrackPlayedAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTrackPlayedSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTrackPlayedLookup(key);
            if (old_field == null)
              {
                extraTypeTrackPlayedAppendPair(key, new_component);
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
            if (flagHastitle)
              {
                handler.start_pair("title");
                handler.string_value(storetitle);
              }
            if (flagHasartist)
              {
                handler.start_pair("artist");
                handler.string_value(storeartist);
              }
            if (flagHasalbum)
              {
                handler.start_pair("album");
                handler.string_value(storealbum);
              }
            if (flagHasyear_released)
              {
                handler.start_pair("year_released");
                handler.string_value(storeyear_released);
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

        public static TypeTrackPlayedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTrackPlayedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackPlayed", ignore_extras);
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
        public static TypeTrackPlayedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTrackPlayedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTrackPlayedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackPlayed", ignore_extras);
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
        public static TypeTrackPlayedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTrackPlayedJSON from_text(string text, bool ignore_extras)
          {
            TypeTrackPlayedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackPlayed", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTrackPlayedJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTrackPlayedJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTrackPlayedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackPlayed", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratortitle;
            private JSONHoldingStringGenerator fieldGeneratorartist;
            private JSONHoldingStringGenerator fieldGeneratoralbum;
            private JSONHoldingStringGenerator fieldGeneratoryear_released;
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
                TypeTrackPlayedJSON result = new TypeTrackPlayedJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTrackPlayedAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTrackPlayedJSON result)
              {
                if (fieldGeneratortitle.have_value)
                  {
                    result.settitle(fieldGeneratortitle.value);
                    fieldGeneratortitle.have_value = false;
                  }
                if (fieldGeneratorartist.have_value)
                  {
                    result.setartist(fieldGeneratorartist.value);
                    fieldGeneratorartist.have_value = false;
                  }
                if (fieldGeneratoralbum.have_value)
                  {
                    result.setalbum(fieldGeneratoralbum.value);
                    fieldGeneratoralbum.have_value = false;
                  }
                if (fieldGeneratoryear_released.have_value)
                  {
                    result.setyear_released(fieldGeneratoryear_released.value);
                    fieldGeneratoryear_released.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeTrackPlayedJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'a':
                        switch (field_name[1])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 2, "bum", 0, 3, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratoralbum;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 2, "tist", 0, 4, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorartist;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 't':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratortitle;
                        break;
                    case 'y':
                        if ((String.Compare(field_name, 1, "ear_released", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratoryear_released;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the TypeTrackPlayed class");
                fieldGeneratorartist = new JSONHoldingStringGenerator("field \"artist\" of the TypeTrackPlayed class");
                fieldGeneratoralbum = new JSONHoldingStringGenerator("field \"album\" of the TypeTrackPlayed class");
                fieldGeneratoryear_released = new JSONHoldingStringGenerator("field \"year_released\" of the TypeTrackPlayed class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTrackPlayed class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the TypeTrackPlayed class");
                fieldGeneratorartist = new JSONHoldingStringGenerator("field \"artist\" of the TypeTrackPlayed class");
                fieldGeneratoralbum = new JSONHoldingStringGenerator("field \"album\" of the TypeTrackPlayed class");
                fieldGeneratoryear_released = new JSONHoldingStringGenerator("field \"year_released\" of the TypeTrackPlayed class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTrackPlayed class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratortitle.reset();
                fieldGeneratorartist.reset();
                fieldGeneratoralbum.reset();
                fieldGeneratoryear_released.reset();
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
            protected override void handle_result(TypeTrackPlayedJSON  result)
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
            public TypeTrackPlayedJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTrackPlayedJSON  result)
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
        protected virtual void handle_result(List<TypeTrackPlayedJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTrackPlayedJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTrackPlayedJSON>();
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
        public List<TypeTrackPlayedJSON> value;
      };
      };
    public class TypeTrackRecommendedJSON : JSONBase
      {
        private bool flagHastitle;
        private string storetitle;
        private bool flagHasartist;
        private string storeartist;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONtitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field title of TypeTrackRecommendedJSON is not a string.");
            settitle(json_string.getData());
          }


        private void  fromJSONartist(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field artist of TypeTrackRecommendedJSON is not a string.");
            setartist(json_string.getData());
          }


        public TypeTrackRecommendedJSON()
          {
            flagHastitle = false;
            flagHasartist = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hastitle()
          {
            return flagHastitle;
          }

        public string  gettitle()
          {
            Debug.Assert(flagHastitle);
            return storetitle;
          }

        public bool  hasartist()
          {
            return flagHasartist;
          }

        public string  getartist()
          {
            Debug.Assert(flagHasartist);
            return storeartist;
          }


        public virtual int extraTypeTrackRecommendedComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTrackRecommendedComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTrackRecommendedComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTrackRecommendedLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void settitle(string new_value)
          {
            flagHastitle = true;
            storetitle = new_value;
          }
        public void unsettitle()
          {
            flagHastitle = false;
          }
        public void setartist(string new_value)
          {
            flagHasartist = true;
            storeartist = new_value;
          }
        public void unsetartist()
          {
            flagHasartist = false;
          }

        public virtual void extraTypeTrackRecommendedAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTrackRecommendedSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTrackRecommendedLookup(key);
            if (old_field == null)
              {
                extraTypeTrackRecommendedAppendPair(key, new_component);
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
            if (flagHastitle)
              {
                handler.start_pair("title");
                handler.string_value(storetitle);
              }
            if (flagHasartist)
              {
                handler.start_pair("artist");
                handler.string_value(storeartist);
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

        public static TypeTrackRecommendedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTrackRecommendedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackRecommended", ignore_extras);
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
        public static TypeTrackRecommendedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTrackRecommendedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTrackRecommendedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackRecommended", ignore_extras);
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
        public static TypeTrackRecommendedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTrackRecommendedJSON from_text(string text, bool ignore_extras)
          {
            TypeTrackRecommendedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackRecommended", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTrackRecommendedJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTrackRecommendedJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTrackRecommendedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTrackRecommended", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratortitle;
            private JSONHoldingStringGenerator fieldGeneratorartist;
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
                TypeTrackRecommendedJSON result = new TypeTrackRecommendedJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTrackRecommendedAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTrackRecommendedJSON result)
              {
                if (fieldGeneratortitle.have_value)
                  {
                    result.settitle(fieldGeneratortitle.value);
                    fieldGeneratortitle.have_value = false;
                  }
                if (fieldGeneratorartist.have_value)
                  {
                    result.setartist(fieldGeneratorartist.value);
                    fieldGeneratorartist.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeTrackRecommendedJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 1, "rtist", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorartist;
                        break;
                    case 't':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratortitle;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the TypeTrackRecommended class");
                fieldGeneratorartist = new JSONHoldingStringGenerator("field \"artist\" of the TypeTrackRecommended class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTrackRecommended class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the TypeTrackRecommended class");
                fieldGeneratorartist = new JSONHoldingStringGenerator("field \"artist\" of the TypeTrackRecommended class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTrackRecommended class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratortitle.reset();
                fieldGeneratorartist.reset();
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
            protected override void handle_result(TypeTrackRecommendedJSON  result)
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
            public TypeTrackRecommendedJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTrackRecommendedJSON  result)
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
        protected virtual void handle_result(List<TypeTrackRecommendedJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTrackRecommendedJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTrackRecommendedJSON>();
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
        public List<TypeTrackRecommendedJSON> value;
      };
      };
    private bool flagHasUsers;
    private List< TypeUsersJSON  > storeUsers;
    private bool flagHasDoorAction;
    private string storeDoorAction;
    private bool flagHasShowTutorialPhraseNumber;
    private sbyte storeShowTutorialPhraseNumber;
    private bool flagHasACStatus;
    private string storeACStatus;
    private bool flagHasACTemp;
    private byte storeACTemp;
    private bool flagHasFanSpeed;
    private sbyte storeFanSpeed;
    private bool flagHasNetworkQuerySucceeded;
    private bool storeNetworkQuerySucceeded;
    private bool flagHasNetworkQueryQueueNumber;
    private BigInteger storeNetworkQueryQueueNumber;
    private bool flagHasTrackPlayed;
    private TypeTrackPlayedJSON  storeTrackPlayed;
    private bool flagHasTrackRecommended;
    private List< TypeTrackRecommendedJSON  > storeTrackRecommended;
    private bool flagHasSchedule;
    private HondaAgentScheduleJSON  storeSchedule;
    private bool flagHasReminders;
    private List< HondaAgentReminderJSON  > storeReminders;
    private bool flagHasDestinationLocation;
    private MapLocationJSON  storeDestinationLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUsers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Users of HondaAgentParametersJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeUsersJSON  > vector_Users1 = new List< TypeUsersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeUsersJSON convert_classy = TypeUsersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Users1.Add(convert_classy);
          }
        initUsers();
        for (int num1 = 0; num1 < vector_Users1.Count; ++num1)
            appendUsers(vector_Users1[num1]);
        for (int num1 = 0; num1 < vector_Users1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDoorAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DoorAction of HondaAgentParametersJSON is not a string.");
        setDoorAction(json_string.getData());
      }


    private void  fromJSONShowTutorialPhraseNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ShowTutorialPhraseNumber of HondaAgentParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ShowTutorialPhraseNumber of HondaAgentParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setShowTutorialPhraseNumber(extracted_integer);
      }


    private void  fromJSONACStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ACStatus of HondaAgentParametersJSON is not a string.");
        setACStatus(json_string.getData());
      }


    private void  fromJSONACTemp(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ACTemp of HondaAgentParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ACTemp of HondaAgentParametersJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setACTemp(extracted_integer);
      }


    private void  fromJSONFanSpeed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FanSpeed of HondaAgentParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FanSpeed of HondaAgentParametersJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setFanSpeed(extracted_integer);
      }


    private void  fromJSONNetworkQuerySucceeded(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NetworkQuerySucceeded of HondaAgentParametersJSON is not true for false.");
              }
          }
        setNetworkQuerySucceeded(the_bool);
      }


    private void  fromJSONNetworkQueryQueueNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NetworkQueryQueueNumber of HondaAgentParametersJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NetworkQueryQueueNumber of HondaAgentParametersJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNetworkQueryQueueNumber(extracted_integer);
      }


    private void  fromJSONTrackPlayed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeTrackPlayedJSON convert_classy = TypeTrackPlayedJSON.from_json(json_value, ignore_extras, true);
        setTrackPlayed(convert_classy);
      }


    private void  fromJSONTrackRecommended(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackRecommended of HondaAgentParametersJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeTrackRecommendedJSON  > vector_TrackRecommended1 = new List< TypeTrackRecommendedJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeTrackRecommendedJSON convert_classy = TypeTrackRecommendedJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TrackRecommended1.Add(convert_classy);
          }
        initTrackRecommended();
        for (int num2 = 0; num2 < vector_TrackRecommended1.Count; ++num2)
            appendTrackRecommended(vector_TrackRecommended1[num2]);
        for (int num1 = 0; num1 < vector_TrackRecommended1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSchedule(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HondaAgentScheduleJSON convert_classy = HondaAgentScheduleJSON.from_json(json_value, ignore_extras, true);
        setSchedule(convert_classy);
      }


    private void  fromJSONReminders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reminders of HondaAgentParametersJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Reminders of HondaAgentParametersJSON has too few elements.");
        List< HondaAgentReminderJSON  > vector_Reminders1 = new List< HondaAgentReminderJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HondaAgentReminderJSON convert_classy = HondaAgentReminderJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Reminders1.Add(convert_classy);
          }
        Debug.Assert(vector_Reminders1.Count >= 1);
        initReminders();
        for (int num3 = 0; num3 < vector_Reminders1.Count; ++num3)
            appendReminders(vector_Reminders1[num3]);
        for (int num1 = 0; num1 < vector_Reminders1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDestinationLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationLocation(convert_classy);
      }


    public HondaAgentParametersJSON()
      {
        flagHasUsers = false;
        flagHasDoorAction = false;
        flagHasShowTutorialPhraseNumber = false;
        flagHasACStatus = false;
        flagHasACTemp = false;
        flagHasFanSpeed = false;
        flagHasNetworkQuerySucceeded = false;
        flagHasNetworkQueryQueueNumber = false;
        flagHasTrackPlayed = false;
        flagHasTrackRecommended = false;
        flagHasSchedule = false;
        flagHasReminders = false;
        flagHasDestinationLocation = false;
        storeUsers = new List< TypeUsersJSON  >();
        storeTrackRecommended = new List< TypeTrackRecommendedJSON  >();
        storeReminders = new List< HondaAgentReminderJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUsers()
      {
        return flagHasUsers;
      }

    public int  countOfUsers()
      {
        Debug.Assert(flagHasUsers);
        return storeUsers.Count;
      }

    public TypeUsersJSON   elementOfUsers(int element_num)
      {
        Debug.Assert(flagHasUsers);
        return storeUsers[element_num];
      }

    public List< TypeUsersJSON  >  getUsers()
      {
        Debug.Assert(flagHasUsers);
        return storeUsers;
      }

    public bool  hasDoorAction()
      {
        return flagHasDoorAction;
      }

    public string  getDoorAction()
      {
        Debug.Assert(flagHasDoorAction);
        return storeDoorAction;
      }

    public bool  hasShowTutorialPhraseNumber()
      {
        return flagHasShowTutorialPhraseNumber;
      }

    public sbyte  getShowTutorialPhraseNumber()
      {
        Debug.Assert(flagHasShowTutorialPhraseNumber);
        return storeShowTutorialPhraseNumber;
      }

    public bool  hasACStatus()
      {
        return flagHasACStatus;
      }

    public string  getACStatus()
      {
        Debug.Assert(flagHasACStatus);
        return storeACStatus;
      }

    public bool  hasACTemp()
      {
        return flagHasACTemp;
      }

    public byte  getACTemp()
      {
        Debug.Assert(flagHasACTemp);
        return storeACTemp;
      }

    public bool  hasFanSpeed()
      {
        return flagHasFanSpeed;
      }

    public sbyte  getFanSpeed()
      {
        Debug.Assert(flagHasFanSpeed);
        return storeFanSpeed;
      }

    public bool  hasNetworkQuerySucceeded()
      {
        return flagHasNetworkQuerySucceeded;
      }

    public bool  getNetworkQuerySucceeded()
      {
        Debug.Assert(flagHasNetworkQuerySucceeded);
        return storeNetworkQuerySucceeded;
      }

    public bool  hasNetworkQueryQueueNumber()
      {
        return flagHasNetworkQueryQueueNumber;
      }

    public BigInteger  getNetworkQueryQueueNumber()
      {
        Debug.Assert(flagHasNetworkQueryQueueNumber);
        return storeNetworkQueryQueueNumber;
      }

    public bool  hasTrackPlayed()
      {
        return flagHasTrackPlayed;
      }

    public TypeTrackPlayedJSON   getTrackPlayed()
      {
        Debug.Assert(flagHasTrackPlayed);
        return storeTrackPlayed;
      }

    public bool  hasTrackRecommended()
      {
        return flagHasTrackRecommended;
      }

    public int  countOfTrackRecommended()
      {
        Debug.Assert(flagHasTrackRecommended);
        return storeTrackRecommended.Count;
      }

    public TypeTrackRecommendedJSON   elementOfTrackRecommended(int element_num)
      {
        Debug.Assert(flagHasTrackRecommended);
        return storeTrackRecommended[element_num];
      }

    public List< TypeTrackRecommendedJSON  >  getTrackRecommended()
      {
        Debug.Assert(flagHasTrackRecommended);
        return storeTrackRecommended;
      }

    public bool  hasSchedule()
      {
        return flagHasSchedule;
      }

    public HondaAgentScheduleJSON   getSchedule()
      {
        Debug.Assert(flagHasSchedule);
        return storeSchedule;
      }

    public bool  hasReminders()
      {
        return flagHasReminders;
      }

    public int  countOfReminders()
      {
        Debug.Assert(flagHasReminders);
        return storeReminders.Count;
      }

    public HondaAgentReminderJSON   elementOfReminders(int element_num)
      {
        Debug.Assert(flagHasReminders);
        return storeReminders[element_num];
      }

    public List< HondaAgentReminderJSON  >  getReminders()
      {
        Debug.Assert(flagHasReminders);
        return storeReminders;
      }

    public bool  hasDestinationLocation()
      {
        return flagHasDestinationLocation;
      }

    public MapLocationJSON   getDestinationLocation()
      {
        Debug.Assert(flagHasDestinationLocation);
        return storeDestinationLocation;
      }


    public virtual int extraHondaAgentParametersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHondaAgentParametersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHondaAgentParametersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHondaAgentParametersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initUsers()
      {
        if (flagHasUsers)
          {
            for (int num1 = 0; num1 < storeUsers.Count; ++num1)
              {
              }
          }
        flagHasUsers = true;
        storeUsers.Clear();
      }
    public void appendUsers(TypeUsersJSON  to_append)
      {
        if (!flagHasUsers)
          {
            flagHasUsers = true;
            storeUsers.Clear();
          }
        Debug.Assert(flagHasUsers);
        storeUsers.Add(to_append);
      }
    public void unsetUsers()
      {
        if (flagHasUsers)
          {
            for (int num2 = 0; num2 < storeUsers.Count; ++num2)
              {
              }
          }
        flagHasUsers = false;
        storeUsers.Clear();
      }
    public void setDoorAction(string new_value)
      {
        flagHasDoorAction = true;
        storeDoorAction = new_value;
      }
    public void unsetDoorAction()
      {
        flagHasDoorAction = false;
      }
    public void setShowTutorialPhraseNumber(sbyte new_value)
      {
        flagHasShowTutorialPhraseNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field ShowTutorialPhraseNumber of HondaAgentParametersJSON is less than the lower bound (1) for that field.");
        if (new_value > 20)
            throw new Exception("The value for field ShowTutorialPhraseNumber of HondaAgentParametersJSON is greater than the upper bound (20) for that field.");
        storeShowTutorialPhraseNumber = new_value;
      }
    public void unsetShowTutorialPhraseNumber()
      {
        flagHasShowTutorialPhraseNumber = false;
      }
    public void setACStatus(string new_value)
      {
        flagHasACStatus = true;
        storeACStatus = new_value;
      }
    public void unsetACStatus()
      {
        flagHasACStatus = false;
      }
    public void setACTemp(byte new_value)
      {
        flagHasACTemp = true;
        if (new_value < 0)
            throw new Exception("The value for field ACTemp of HondaAgentParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 200)
            throw new Exception("The value for field ACTemp of HondaAgentParametersJSON is greater than the upper bound (200) for that field.");
        storeACTemp = new_value;
      }
    public void unsetACTemp()
      {
        flagHasACTemp = false;
      }
    public void setFanSpeed(sbyte new_value)
      {
        flagHasFanSpeed = true;
        if (new_value < 0)
            throw new Exception("The value for field FanSpeed of HondaAgentParametersJSON is less than the lower bound (0) for that field.");
        if (new_value > 10)
            throw new Exception("The value for field FanSpeed of HondaAgentParametersJSON is greater than the upper bound (10) for that field.");
        storeFanSpeed = new_value;
      }
    public void unsetFanSpeed()
      {
        flagHasFanSpeed = false;
      }
    public void setNetworkQuerySucceeded(bool new_value)
      {
        flagHasNetworkQuerySucceeded = true;
        storeNetworkQuerySucceeded = new_value;
      }
    public void unsetNetworkQuerySucceeded()
      {
        flagHasNetworkQuerySucceeded = false;
      }
    public void setNetworkQueryQueueNumber(BigInteger new_value)
      {
        flagHasNetworkQueryQueueNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field NetworkQueryQueueNumber of HondaAgentParametersJSON is less than the lower bound (1) for that field.");
        storeNetworkQueryQueueNumber = new_value;
      }
    public void unsetNetworkQueryQueueNumber()
      {
        flagHasNetworkQueryQueueNumber = false;
      }
    public void setTrackPlayed(TypeTrackPlayedJSON  new_value)
      {
        if (flagHasTrackPlayed)
          {
          }
        flagHasTrackPlayed = true;
        storeTrackPlayed = new_value;
      }
    public void unsetTrackPlayed()
      {
        if (flagHasTrackPlayed)
          {
          }
        flagHasTrackPlayed = false;
      }
    public void initTrackRecommended()
      {
        if (flagHasTrackRecommended)
          {
            for (int num3 = 0; num3 < storeTrackRecommended.Count; ++num3)
              {
              }
          }
        flagHasTrackRecommended = true;
        storeTrackRecommended.Clear();
      }
    public void appendTrackRecommended(TypeTrackRecommendedJSON  to_append)
      {
        if (!flagHasTrackRecommended)
          {
            flagHasTrackRecommended = true;
            storeTrackRecommended.Clear();
          }
        Debug.Assert(flagHasTrackRecommended);
        storeTrackRecommended.Add(to_append);
      }
    public void unsetTrackRecommended()
      {
        if (flagHasTrackRecommended)
          {
            for (int num4 = 0; num4 < storeTrackRecommended.Count; ++num4)
              {
              }
          }
        flagHasTrackRecommended = false;
        storeTrackRecommended.Clear();
      }
    public void setSchedule(HondaAgentScheduleJSON  new_value)
      {
        if (flagHasSchedule)
          {
          }
        flagHasSchedule = true;
        storeSchedule = new_value;
      }
    public void unsetSchedule()
      {
        if (flagHasSchedule)
          {
          }
        flagHasSchedule = false;
      }
    public void initReminders()
      {
        if (flagHasReminders)
          {
            for (int num5 = 0; num5 < storeReminders.Count; ++num5)
              {
              }
          }
        flagHasReminders = true;
        storeReminders.Clear();
      }
    public void appendReminders(HondaAgentReminderJSON  to_append)
      {
        if (!flagHasReminders)
          {
            flagHasReminders = true;
            storeReminders.Clear();
          }
        Debug.Assert(flagHasReminders);
        storeReminders.Add(to_append);
      }
    public void unsetReminders()
      {
        if (flagHasReminders)
          {
            for (int num6 = 0; num6 < storeReminders.Count; ++num6)
              {
              }
          }
        flagHasReminders = false;
        storeReminders.Clear();
      }
    public void setDestinationLocation(MapLocationJSON  new_value)
      {
        if (flagHasDestinationLocation)
          {
          }
        flagHasDestinationLocation = true;
        storeDestinationLocation = new_value;
      }
    public void unsetDestinationLocation()
      {
        if (flagHasDestinationLocation)
          {
          }
        flagHasDestinationLocation = false;
      }

    public virtual void extraHondaAgentParametersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHondaAgentParametersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHondaAgentParametersLookup(key);
        if (old_field == null)
          {
            extraHondaAgentParametersAppendPair(key, new_component);
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
        if (flagHasUsers)
          {
            handler.start_pair("Users");
            handler.start_array();
            for (int num1 = 0; num1 < storeUsers.Count; ++num1)
              {
                if (partial_allowed)
                    storeUsers[num1].write_partial_as_json(handler);
                else
                    storeUsers[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDoorAction)
          {
            handler.start_pair("DoorAction");
            handler.string_value(storeDoorAction);
          }
        if (flagHasShowTutorialPhraseNumber)
          {
            handler.start_pair("ShowTutorialPhraseNumber");
            handler.number_value(storeShowTutorialPhraseNumber);
          }
        if (flagHasACStatus)
          {
            handler.start_pair("ACStatus");
            handler.string_value(storeACStatus);
          }
        if (flagHasACTemp)
          {
            handler.start_pair("ACTemp");
            handler.number_value(storeACTemp);
          }
        if (flagHasFanSpeed)
          {
            handler.start_pair("FanSpeed");
            handler.number_value(storeFanSpeed);
          }
        if (flagHasNetworkQuerySucceeded)
          {
            handler.start_pair("NetworkQuerySucceeded");
            handler.boolean_value(storeNetworkQuerySucceeded);
          }
        if (flagHasNetworkQueryQueueNumber)
          {
            handler.start_pair("NetworkQueryQueueNumber");
            handler.number_value(storeNetworkQueryQueueNumber);
          }
        if (flagHasTrackPlayed)
          {
            handler.start_pair("TrackPlayed");
            if (partial_allowed)
                storeTrackPlayed.write_partial_as_json(handler);
            else
                storeTrackPlayed.write_as_json(handler);
          }
        if (flagHasTrackRecommended)
          {
            handler.start_pair("TrackRecommended");
            handler.start_array();
            for (int num2 = 0; num2 < storeTrackRecommended.Count; ++num2)
              {
                if (partial_allowed)
                    storeTrackRecommended[num2].write_partial_as_json(handler);
                else
                    storeTrackRecommended[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSchedule)
          {
            handler.start_pair("Schedule");
            if (partial_allowed)
                storeSchedule.write_partial_as_json(handler);
            else
                storeSchedule.write_as_json(handler);
          }
        if (flagHasReminders)
          {
            handler.start_pair("Reminders");
            Debug.Assert(storeReminders.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeReminders.Count; ++num3)
              {
                if (partial_allowed)
                    storeReminders[num3].write_partial_as_json(handler);
                else
                    storeReminders[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDestinationLocation)
          {
            handler.start_pair("DestinationLocation");
            if (partial_allowed)
                storeDestinationLocation.write_partial_as_json(handler);
            else
                storeDestinationLocation.write_as_json(handler);
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

    public static HondaAgentParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgentParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentParameters", ignore_extras);
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
    public static HondaAgentParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgentParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgentParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentParameters", ignore_extras);
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
    public static HondaAgentParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgentParametersJSON from_text(string text, bool ignore_extras)
      {
        HondaAgentParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HondaAgentParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HondaAgentParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HondaAgentParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeUsersJSON.HoldingArrayGenerator fieldGeneratorUsers;
        private JSONHoldingStringGenerator fieldGeneratorDoorAction;
    private class FieldHoldingGeneratorShowTutorialPhraseNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorShowTutorialPhraseNumber(String what) : base(what, 1, 20)
              {
              }
          };
    private class FieldHoldingArrayGeneratorShowTutorialPhraseNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorShowTutorialPhraseNumber(String what) : base(what, 1, 20)
              {
              }
          };
        private FieldHoldingGeneratorShowTutorialPhraseNumber fieldGeneratorShowTutorialPhraseNumber;
        private JSONHoldingStringGenerator fieldGeneratorACStatus;
    private class FieldHoldingGeneratorACTemp : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorACTemp(String what) : base(what, 0, 200)
              {
              }
          };
    private class FieldHoldingArrayGeneratorACTemp : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorACTemp(String what) : base(what, 0, 200)
              {
              }
          };
        private FieldHoldingGeneratorACTemp fieldGeneratorACTemp;
    private class FieldHoldingGeneratorFanSpeed : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFanSpeed(String what) : base(what, 0, 10)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFanSpeed : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFanSpeed(String what) : base(what, 0, 10)
              {
              }
          };
        private FieldHoldingGeneratorFanSpeed fieldGeneratorFanSpeed;
        private JSONHoldingBooleanGenerator fieldGeneratorNetworkQuerySucceeded;
    private class FieldHoldingGeneratorNetworkQueryQueueNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNetworkQueryQueueNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNetworkQueryQueueNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNetworkQueryQueueNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorNetworkQueryQueueNumber fieldGeneratorNetworkQueryQueueNumber;
        private TypeTrackPlayedJSON.HoldingGenerator fieldGeneratorTrackPlayed;
        private TypeTrackRecommendedJSON.HoldingArrayGenerator fieldGeneratorTrackRecommended;
        private HondaAgentScheduleJSON.HoldingGenerator fieldGeneratorSchedule;
        private HondaAgentReminderJSON.HoldingArrayGenerator fieldGeneratorReminders;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationLocation;
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
            HondaAgentParametersJSON result = new HondaAgentParametersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHondaAgentParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HondaAgentParametersJSON result)
          {
            if (fieldGeneratorUsers.have_value)
              {
                result.initUsers();
                int count = fieldGeneratorUsers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUsers(fieldGeneratorUsers.value[num]);
                  }
                fieldGeneratorUsers.value.Clear();
                fieldGeneratorUsers.have_value = false;
              }
            if (fieldGeneratorDoorAction.have_value)
              {
                result.setDoorAction(fieldGeneratorDoorAction.value);
                fieldGeneratorDoorAction.have_value = false;
              }
            if (fieldGeneratorShowTutorialPhraseNumber.have_value)
              {
                result.setShowTutorialPhraseNumber((sbyte)(fieldGeneratorShowTutorialPhraseNumber.value));
                fieldGeneratorShowTutorialPhraseNumber.have_value = false;
              }
            if (fieldGeneratorACStatus.have_value)
              {
                result.setACStatus(fieldGeneratorACStatus.value);
                fieldGeneratorACStatus.have_value = false;
              }
            if (fieldGeneratorACTemp.have_value)
              {
                result.setACTemp((byte)(fieldGeneratorACTemp.value));
                fieldGeneratorACTemp.have_value = false;
              }
            if (fieldGeneratorFanSpeed.have_value)
              {
                result.setFanSpeed((sbyte)(fieldGeneratorFanSpeed.value));
                fieldGeneratorFanSpeed.have_value = false;
              }
            if (fieldGeneratorNetworkQuerySucceeded.have_value)
              {
                result.setNetworkQuerySucceeded(fieldGeneratorNetworkQuerySucceeded.value);
                fieldGeneratorNetworkQuerySucceeded.have_value = false;
              }
            if (fieldGeneratorNetworkQueryQueueNumber.have_value)
              {
                result.setNetworkQueryQueueNumber(fieldGeneratorNetworkQueryQueueNumber.value);
                fieldGeneratorNetworkQueryQueueNumber.have_value = false;
              }
            if (fieldGeneratorTrackPlayed.have_value)
              {
                result.setTrackPlayed(fieldGeneratorTrackPlayed.value);
                fieldGeneratorTrackPlayed.have_value = false;
              }
            if (fieldGeneratorTrackRecommended.have_value)
              {
                result.initTrackRecommended();
                int count = fieldGeneratorTrackRecommended.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackRecommended(fieldGeneratorTrackRecommended.value[num]);
                  }
                fieldGeneratorTrackRecommended.value.Clear();
                fieldGeneratorTrackRecommended.have_value = false;
              }
            if (fieldGeneratorSchedule.have_value)
              {
                result.setSchedule(fieldGeneratorSchedule.value);
                fieldGeneratorSchedule.have_value = false;
              }
            if (fieldGeneratorReminders.have_value)
              {
                result.initReminders();
                int count = fieldGeneratorReminders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendReminders(fieldGeneratorReminders.value[num]);
                  }
                fieldGeneratorReminders.value.Clear();
                fieldGeneratorReminders.have_value = false;
              }
            if (fieldGeneratorDestinationLocation.have_value)
              {
                result.setDestinationLocation(fieldGeneratorDestinationLocation.value);
                fieldGeneratorDestinationLocation.have_value = false;
              }
          }
        protected abstract void handle_result(HondaAgentParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "C", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 3, "tatus", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorACStatus;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 3, "emp", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorACTemp;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "stinationLocation", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorDestinationLocation;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "orAction", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDoorAction;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "anSpeed", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorFanSpeed;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "etworkQuery", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'Q':
                                if ((String.Compare(field_name, 13, "ueueNumber", 0, 10, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorNetworkQueryQueueNumber;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 13, "ucceeded", 0, 8, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorNetworkQuerySucceeded;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eminders", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorReminders;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "hedule", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSchedule;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "owTutorialPhraseNumber", 0, 22, false) == 0) && (field_name.Length == 24))
                                return fieldGeneratorShowTutorialPhraseNumber;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "rack", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 6, "layed", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorTrackPlayed;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 6, "ecommended", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorTrackRecommended;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "sers", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorUsers;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUsers = new TypeUsersJSON.HoldingArrayGenerator("field \"Users\" of the HondaAgentParameters class", ignore_extras);
            fieldGeneratorDoorAction = new JSONHoldingStringGenerator("field \"DoorAction\" of the HondaAgentParameters class");
            fieldGeneratorShowTutorialPhraseNumber = new FieldHoldingGeneratorShowTutorialPhraseNumber("field \"ShowTutorialPhraseNumber\" of the HondaAgentParameters class");
            fieldGeneratorACStatus = new JSONHoldingStringGenerator("field \"ACStatus\" of the HondaAgentParameters class");
            fieldGeneratorACTemp = new FieldHoldingGeneratorACTemp("field \"ACTemp\" of the HondaAgentParameters class");
            fieldGeneratorFanSpeed = new FieldHoldingGeneratorFanSpeed("field \"FanSpeed\" of the HondaAgentParameters class");
            fieldGeneratorNetworkQuerySucceeded = new JSONHoldingBooleanGenerator("field \"NetworkQuerySucceeded\" of the HondaAgentParameters class");
            fieldGeneratorNetworkQueryQueueNumber = new FieldHoldingGeneratorNetworkQueryQueueNumber("field \"NetworkQueryQueueNumber\" of the HondaAgentParameters class");
            fieldGeneratorTrackPlayed = new TypeTrackPlayedJSON.HoldingGenerator("field \"TrackPlayed\" of the HondaAgentParameters class", ignore_extras);
            fieldGeneratorTrackRecommended = new TypeTrackRecommendedJSON.HoldingArrayGenerator("field \"TrackRecommended\" of the HondaAgentParameters class", ignore_extras);
            fieldGeneratorSchedule = new HondaAgentScheduleJSON.HoldingGenerator("field \"Schedule\" of the HondaAgentParameters class", ignore_extras);
            fieldGeneratorReminders = new HondaAgentReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the HondaAgentParameters class", ignore_extras);
            fieldGeneratorDestinationLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationLocation\" of the HondaAgentParameters class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HondaAgentParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUsers = new TypeUsersJSON.HoldingArrayGenerator("field \"Users\" of the HondaAgentParameters class", false);
            fieldGeneratorDoorAction = new JSONHoldingStringGenerator("field \"DoorAction\" of the HondaAgentParameters class");
            fieldGeneratorShowTutorialPhraseNumber = new FieldHoldingGeneratorShowTutorialPhraseNumber("field \"ShowTutorialPhraseNumber\" of the HondaAgentParameters class");
            fieldGeneratorACStatus = new JSONHoldingStringGenerator("field \"ACStatus\" of the HondaAgentParameters class");
            fieldGeneratorACTemp = new FieldHoldingGeneratorACTemp("field \"ACTemp\" of the HondaAgentParameters class");
            fieldGeneratorFanSpeed = new FieldHoldingGeneratorFanSpeed("field \"FanSpeed\" of the HondaAgentParameters class");
            fieldGeneratorNetworkQuerySucceeded = new JSONHoldingBooleanGenerator("field \"NetworkQuerySucceeded\" of the HondaAgentParameters class");
            fieldGeneratorNetworkQueryQueueNumber = new FieldHoldingGeneratorNetworkQueryQueueNumber("field \"NetworkQueryQueueNumber\" of the HondaAgentParameters class");
            fieldGeneratorTrackPlayed = new TypeTrackPlayedJSON.HoldingGenerator("field \"TrackPlayed\" of the HondaAgentParameters class", false);
            fieldGeneratorTrackRecommended = new TypeTrackRecommendedJSON.HoldingArrayGenerator("field \"TrackRecommended\" of the HondaAgentParameters class", false);
            fieldGeneratorSchedule = new HondaAgentScheduleJSON.HoldingGenerator("field \"Schedule\" of the HondaAgentParameters class", false);
            fieldGeneratorReminders = new HondaAgentReminderJSON.HoldingArrayGenerator("field \"Reminders\" of the HondaAgentParameters class", false);
            fieldGeneratorDestinationLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationLocation\" of the HondaAgentParameters class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HondaAgentParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUsers.reset();
            fieldGeneratorDoorAction.reset();
            fieldGeneratorShowTutorialPhraseNumber.reset();
            fieldGeneratorACStatus.reset();
            fieldGeneratorACTemp.reset();
            fieldGeneratorFanSpeed.reset();
            fieldGeneratorNetworkQuerySucceeded.reset();
            fieldGeneratorNetworkQueryQueueNumber.reset();
            fieldGeneratorTrackPlayed.reset();
            fieldGeneratorTrackRecommended.reset();
            fieldGeneratorSchedule.reset();
            fieldGeneratorReminders.reset();
            fieldGeneratorDestinationLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUsers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrackPlayed.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTrackRecommended.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSchedule.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReminders.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUsers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrackPlayed.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTrackRecommended.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSchedule.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReminders.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HondaAgentParametersJSON  result)
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
        public HondaAgentParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HondaAgentParametersJSON  result)
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
    protected virtual void handle_result(List<HondaAgentParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HondaAgentParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HondaAgentParametersJSON>();
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
    public List<HondaAgentParametersJSON> value;
  };
  };
