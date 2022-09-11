/* file "ContactMungerInputJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactMungerInputJSON : JSONBase
  {
    public class TypeCommandJSON : JSONBase
      {
        private bool flagHasPath;
        private string storePath;
        private bool flagHasAction;
        private string storeAction;
        private bool flagHasData;
        private ContactMungerDataJSON  storeData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPath(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Path of TypeCommandJSON is not a string.");
            setPath(json_string.getData());
          }


        private void  fromJSONAction(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Action of TypeCommandJSON is not a string.");
            setAction(json_string.getData());
          }


        private void  fromJSONData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            ContactMungerDataJSON convert_classy = ContactMungerDataJSON.from_json(json_value, ignore_extras, true);
            setData(convert_classy);
          }


        public TypeCommandJSON()
          {
            flagHasPath = false;
            flagHasAction = false;
            flagHasData = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPath()
          {
            return flagHasPath;
          }

        public string  getPath()
          {
            Debug.Assert(flagHasPath);
            return storePath;
          }

        public bool  hasAction()
          {
            return flagHasAction;
          }

        public string  getAction()
          {
            Debug.Assert(flagHasAction);
            return storeAction;
          }

        public bool  hasData()
          {
            return flagHasData;
          }

        public ContactMungerDataJSON   getData()
          {
            Debug.Assert(flagHasData);
            return storeData;
          }


        public virtual int extraTypeCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setPath(string new_value)
          {
            flagHasPath = true;
            storePath = new_value;
          }
        public void unsetPath()
          {
            flagHasPath = false;
          }
        public void setAction(string new_value)
          {
            flagHasAction = true;
            storeAction = new_value;
          }
        public void unsetAction()
          {
            flagHasAction = false;
          }
        public void setData(ContactMungerDataJSON  new_value)
          {
            if (flagHasData)
              {
              }
            flagHasData = true;
            storeData = new_value;
          }
        public void unsetData()
          {
            if (flagHasData)
              {
              }
            flagHasData = false;
          }

        public virtual void extraTypeCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeCommandLookup(key);
            if (old_field == null)
              {
                extraTypeCommandAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasPath);
            if (flagHasPath)
              {
                handler.start_pair("Path");
                handler.string_value(storePath);
              }
            Debug.Assert(partial_allowed || flagHasAction);
            if (flagHasAction)
              {
                handler.start_pair("Action");
                handler.string_value(storeAction);
              }
            Debug.Assert(partial_allowed || flagHasData);
            if (flagHasData)
              {
                handler.start_pair("Data");
                if (partial_allowed)
                    storeData.write_partial_as_json(handler);
                else
                    storeData.write_as_json(handler);
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
            if (!(hasPath()))
              {
                return "When parsing the object for %what%, the \"Path\" field was missing.";
              }
            if (!(hasAction()))
              {
                return "When parsing the object for %what%, the \"Action\" field was missing.";
              }
            if (!(hasData()))
              {
                return "When parsing the object for %what%, the \"Data\" field was missing.";
              }
            return null;
          }

        public static TypeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCommandJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCommand", ignore_extras);
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
        public static TypeCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCommandJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCommand", ignore_extras);
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
        public static TypeCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCommandJSON from_text(string text, bool ignore_extras)
          {
            TypeCommandJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCommand", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeCommandJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeCommandJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCommand", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorPath;
            private JSONHoldingStringGenerator fieldGeneratorAction;
            private ContactMungerDataJSON.HoldingGenerator fieldGeneratorData;
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
                TypeCommandJSON result = new TypeCommandJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeCommandJSON result)
              {
                if (fieldGeneratorPath.have_value)
                  {
                    result.setPath(fieldGeneratorPath.value);
                    fieldGeneratorPath.have_value = false;
                  }
                else if ((!(result.hasPath())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Path\" field was missing.");
                  }
                if (fieldGeneratorAction.have_value)
                  {
                    result.setAction(fieldGeneratorAction.value);
                    fieldGeneratorAction.have_value = false;
                  }
                else if ((!(result.hasAction())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Action\" field was missing.");
                  }
                if (fieldGeneratorData.have_value)
                  {
                    result.setData(fieldGeneratorData.value);
                    fieldGeneratorData.have_value = false;
                  }
                else if ((!(result.hasData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Data\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeCommandJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ction", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorAction;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "ata", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorData;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "ath", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorPath;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPath = new JSONHoldingStringGenerator("field \"Path\" of the TypeCommand class");
                fieldGeneratorAction = new JSONHoldingStringGenerator("field \"Action\" of the TypeCommand class");
                fieldGeneratorData = new ContactMungerDataJSON.HoldingGenerator("field \"Data\" of the TypeCommand class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeCommand class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPath = new JSONHoldingStringGenerator("field \"Path\" of the TypeCommand class");
                fieldGeneratorAction = new JSONHoldingStringGenerator("field \"Action\" of the TypeCommand class");
                fieldGeneratorData = new ContactMungerDataJSON.HoldingGenerator("field \"Data\" of the TypeCommand class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeCommand class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPath.reset();
                fieldGeneratorAction.reset();
                fieldGeneratorData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeCommandJSON  result)
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
            public TypeCommandJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeCommandJSON  result)
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
        protected virtual void handle_result(List<TypeCommandJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeCommandJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeCommandJSON>();
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
        public List<TypeCommandJSON> value;
      };
      };
    private bool flagHasCommand;
    private List< TypeCommandJSON  > storeCommand;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommand(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Command of ContactMungerInputJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Command of ContactMungerInputJSON has too few elements.");
        List< TypeCommandJSON  > vector_Command1 = new List< TypeCommandJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeCommandJSON convert_classy = TypeCommandJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Command1.Add(convert_classy);
          }
        Debug.Assert(vector_Command1.Count >= 1);
        initCommand();
        for (int num1 = 0; num1 < vector_Command1.Count; ++num1)
            appendCommand(vector_Command1[num1]);
        for (int num1 = 0; num1 < vector_Command1.Count; ++num1)
          {
          }
      }


    public ContactMungerInputJSON()
      {
        flagHasCommand = false;
        storeCommand = new List< TypeCommandJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCommand()
      {
        return flagHasCommand;
      }

    public int  countOfCommand()
      {
        Debug.Assert(flagHasCommand);
        return storeCommand.Count;
      }

    public TypeCommandJSON   elementOfCommand(int element_num)
      {
        Debug.Assert(flagHasCommand);
        return storeCommand[element_num];
      }

    public List< TypeCommandJSON  >  getCommand()
      {
        Debug.Assert(flagHasCommand);
        return storeCommand;
      }


    public virtual int extraContactMungerInputComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactMungerInputComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactMungerInputComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactMungerInputLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initCommand()
      {
        if (flagHasCommand)
          {
            for (int num1 = 0; num1 < storeCommand.Count; ++num1)
              {
              }
          }
        flagHasCommand = true;
        storeCommand.Clear();
      }
    public void appendCommand(TypeCommandJSON  to_append)
      {
        if (!flagHasCommand)
          {
            flagHasCommand = true;
            storeCommand.Clear();
          }
        Debug.Assert(flagHasCommand);
        storeCommand.Add(to_append);
      }
    public void unsetCommand()
      {
        if (flagHasCommand)
          {
            for (int num2 = 0; num2 < storeCommand.Count; ++num2)
              {
              }
          }
        flagHasCommand = false;
        storeCommand.Clear();
      }

    public virtual void extraContactMungerInputAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactMungerInputSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactMungerInputLookup(key);
        if (old_field == null)
          {
            extraContactMungerInputAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommand);
        if (flagHasCommand)
          {
            handler.start_pair("Command");
            Debug.Assert(storeCommand.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeCommand.Count; ++num1)
              {
                if (partial_allowed)
                    storeCommand[num1].write_partial_as_json(handler);
                else
                    storeCommand[num1].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasCommand()))
          {
            return "When parsing the object for %what%, the \"Command\" field was missing.";
          }
        return null;
      }

    public static ContactMungerInputJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactMungerInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerInput", ignore_extras);
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
    public static ContactMungerInputJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactMungerInputJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactMungerInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerInput", ignore_extras);
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
    public static ContactMungerInputJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactMungerInputJSON from_text(string text, bool ignore_extras)
      {
        ContactMungerInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerInput", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactMungerInputJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactMungerInputJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactMungerInputJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerInput", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeCommandJSON.HoldingArrayGenerator fieldGeneratorCommand;
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
            ContactMungerInputJSON result = new ContactMungerInputJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactMungerInputAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ContactMungerInputJSON result)
          {
            if (fieldGeneratorCommand.have_value)
              {
                result.initCommand();
                int count = fieldGeneratorCommand.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCommand(fieldGeneratorCommand.value[num]);
                  }
                fieldGeneratorCommand.value.Clear();
                fieldGeneratorCommand.have_value = false;
              }
            else if ((!(result.hasCommand())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Command\" field was missing.");
              }
          }
        protected abstract void handle_result(ContactMungerInputJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Command", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorCommand;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCommand = new TypeCommandJSON.HoldingArrayGenerator("field \"Command\" of the ContactMungerInput class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactMungerInput class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommand = new TypeCommandJSON.HoldingArrayGenerator("field \"Command\" of the ContactMungerInput class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactMungerInput class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommand.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCommand.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCommand.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactMungerInputJSON  result)
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
        public ContactMungerInputJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactMungerInputJSON  result)
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
    protected virtual void handle_result(List<ContactMungerInputJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactMungerInputJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactMungerInputJSON>();
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
    public List<ContactMungerInputJSON> value;
  };
  };
