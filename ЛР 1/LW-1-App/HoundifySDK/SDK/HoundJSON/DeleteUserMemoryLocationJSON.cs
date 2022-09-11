/* file "DeleteUserMemoryLocationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DeleteUserMemoryLocationJSON : JSONBase
  {
    private bool flagHasIsOwned;
    private bool storeIsOwned;
    private bool flagHasTag;
    private string storeTag;
    private bool flagHasSpecialLocation;
    private UserMemorySpecialLocationJSON  storeSpecialLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIsOwned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsOwned of DeleteUserMemoryLocationJSON is not true for false.");
              }
          }
        setIsOwned(the_bool);
      }


    private void  fromJSONTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Tag of DeleteUserMemoryLocationJSON is not a string.");
        setTag(json_string.getData());
      }


    private void  fromJSONSpecialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserMemorySpecialLocationJSON convert_classy = UserMemorySpecialLocationJSON.from_json(json_value, ignore_extras, true);
        setSpecialLocation(convert_classy);
      }


    public DeleteUserMemoryLocationJSON()
      {
        flagHasIsOwned = false;
        flagHasTag = false;
        flagHasSpecialLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIsOwned()
      {
        return flagHasIsOwned;
      }

    public bool  getIsOwned()
      {
        Debug.Assert(flagHasIsOwned);
        return storeIsOwned;
      }

    public bool  hasTag()
      {
        return flagHasTag;
      }

    public string  getTag()
      {
        Debug.Assert(flagHasTag);
        return storeTag;
      }

    public bool  hasSpecialLocation()
      {
        return flagHasSpecialLocation;
      }

    public UserMemorySpecialLocationJSON   getSpecialLocation()
      {
        Debug.Assert(flagHasSpecialLocation);
        return storeSpecialLocation;
      }

    public UserMemorySpecialLocationJSON.TypeValue  getSpecialLocationValue()
      {
        return getSpecialLocation().getValue();
      }

    public string  getSpecialLocationAsString()
      {
        return getSpecialLocation().getValueAsString();
      }


    public virtual int extraDeleteUserMemoryLocationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDeleteUserMemoryLocationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDeleteUserMemoryLocationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDeleteUserMemoryLocationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIsOwned(bool new_value)
      {
        flagHasIsOwned = true;
        storeIsOwned = new_value;
      }
    public void unsetIsOwned()
      {
        flagHasIsOwned = false;
      }
    public void setTag(string new_value)
      {
        flagHasTag = true;
        storeTag = new_value;
      }
    public void unsetTag()
      {
        flagHasTag = false;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON  new_value)
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = true;
        storeSpecialLocation = new_value;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON.TypeValue new_value)
      {
        setSpecialLocation(new UserMemorySpecialLocationJSON(new_value));
      }
    public void setSpecialLocation(string chars)
      {
        UserMemorySpecialLocationJSON.TypeValueKnownValues known = UserMemorySpecialLocationJSON.stringToValue(chars);
        UserMemorySpecialLocationJSON.TypeValue new_value = new UserMemorySpecialLocationJSON.TypeValue();
        if (known == UserMemorySpecialLocationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSpecialLocation(new_value);
      }
    public void unsetSpecialLocation()
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = false;
      }

    public virtual void extraDeleteUserMemoryLocationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDeleteUserMemoryLocationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDeleteUserMemoryLocationLookup(key);
        if (old_field == null)
          {
            extraDeleteUserMemoryLocationAppendPair(key, new_component);
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
        if (flagHasIsOwned)
          {
            handler.start_pair("IsOwned");
            handler.boolean_value(storeIsOwned);
          }
        if (flagHasTag)
          {
            handler.start_pair("Tag");
            handler.string_value(storeTag);
          }
        if (flagHasSpecialLocation)
          {
            handler.start_pair("SpecialLocation");
            if (partial_allowed)
                storeSpecialLocation.write_partial_as_json(handler);
            else
                storeSpecialLocation.write_as_json(handler);
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

    public static DeleteUserMemoryLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DeleteUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DeleteUserMemoryLocation", ignore_extras);
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
    public static DeleteUserMemoryLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DeleteUserMemoryLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DeleteUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DeleteUserMemoryLocation", ignore_extras);
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
    public static DeleteUserMemoryLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DeleteUserMemoryLocationJSON from_text(string text, bool ignore_extras)
      {
        DeleteUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DeleteUserMemoryLocation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DeleteUserMemoryLocationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DeleteUserMemoryLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DeleteUserMemoryLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DeleteUserMemoryLocation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsOwned;
        private JSONHoldingStringGenerator fieldGeneratorTag;
        private UserMemorySpecialLocationJSON.HoldingGenerator fieldGeneratorSpecialLocation;
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
            DeleteUserMemoryLocationJSON result = new DeleteUserMemoryLocationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDeleteUserMemoryLocationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DeleteUserMemoryLocationJSON result)
          {
            if (fieldGeneratorIsOwned.have_value)
              {
                result.setIsOwned(fieldGeneratorIsOwned.value);
                fieldGeneratorIsOwned.have_value = false;
              }
            if (fieldGeneratorTag.have_value)
              {
                result.setTag(fieldGeneratorTag.value);
                fieldGeneratorTag.have_value = false;
              }
            if (fieldGeneratorSpecialLocation.have_value)
              {
                result.setSpecialLocation(fieldGeneratorSpecialLocation.value);
                fieldGeneratorSpecialLocation.have_value = false;
              }
          }
        protected abstract void handle_result(DeleteUserMemoryLocationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sOwned", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorIsOwned;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSpecialLocation;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ag", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorTag;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIsOwned = new JSONHoldingBooleanGenerator("field \"IsOwned\" of the DeleteUserMemoryLocation class");
            fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the DeleteUserMemoryLocation class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the DeleteUserMemoryLocation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DeleteUserMemoryLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIsOwned = new JSONHoldingBooleanGenerator("field \"IsOwned\" of the DeleteUserMemoryLocation class");
            fieldGeneratorTag = new JSONHoldingStringGenerator("field \"Tag\" of the DeleteUserMemoryLocation class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the DeleteUserMemoryLocation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DeleteUserMemoryLocation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIsOwned.reset();
            fieldGeneratorTag.reset();
            fieldGeneratorSpecialLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSpecialLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSpecialLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DeleteUserMemoryLocationJSON  result)
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
        public DeleteUserMemoryLocationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DeleteUserMemoryLocationJSON  result)
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
    protected virtual void handle_result(List<DeleteUserMemoryLocationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DeleteUserMemoryLocationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DeleteUserMemoryLocationJSON>();
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
    public List<DeleteUserMemoryLocationJSON> value;
  };
  };
