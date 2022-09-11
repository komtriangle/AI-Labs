/* file "UserFeedbackJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserFeedbackJSON : JSONBase
  {
    private bool flagHasQueryRequestID;
    private string storeQueryRequestID;
    private bool flagHasServerGeneratedID;
    private string storeServerGeneratedID;
    private bool flagHasFeedbackItems;
    private List< UserFeedbackItemJSON  > storeFeedbackItems;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryRequestID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryRequestID of UserFeedbackJSON is not a string.");
        setQueryRequestID(json_string.getData());
      }


    private void  fromJSONServerGeneratedID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ServerGeneratedID of UserFeedbackJSON is not a string.");
        setServerGeneratedID(json_string.getData());
      }


    private void  fromJSONFeedbackItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FeedbackItems of UserFeedbackJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UserFeedbackItemJSON  > vector_FeedbackItems1 = new List< UserFeedbackItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UserFeedbackItemJSON convert_classy = UserFeedbackItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FeedbackItems1.Add(convert_classy);
          }
        initFeedbackItems();
        for (int num1 = 0; num1 < vector_FeedbackItems1.Count; ++num1)
            appendFeedbackItems(vector_FeedbackItems1[num1]);
        for (int num1 = 0; num1 < vector_FeedbackItems1.Count; ++num1)
          {
          }
      }


    public UserFeedbackJSON()
      {
        flagHasQueryRequestID = false;
        flagHasServerGeneratedID = false;
        flagHasFeedbackItems = false;
        storeFeedbackItems = new List< UserFeedbackItemJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryRequestID()
      {
        return flagHasQueryRequestID;
      }

    public string  getQueryRequestID()
      {
        Debug.Assert(flagHasQueryRequestID);
        return storeQueryRequestID;
      }

    public bool  hasServerGeneratedID()
      {
        return flagHasServerGeneratedID;
      }

    public string  getServerGeneratedID()
      {
        Debug.Assert(flagHasServerGeneratedID);
        return storeServerGeneratedID;
      }

    public bool  hasFeedbackItems()
      {
        return flagHasFeedbackItems;
      }

    public int  countOfFeedbackItems()
      {
        Debug.Assert(flagHasFeedbackItems);
        return storeFeedbackItems.Count;
      }

    public UserFeedbackItemJSON   elementOfFeedbackItems(int element_num)
      {
        Debug.Assert(flagHasFeedbackItems);
        return storeFeedbackItems[element_num];
      }

    public List< UserFeedbackItemJSON  >  getFeedbackItems()
      {
        Debug.Assert(flagHasFeedbackItems);
        return storeFeedbackItems;
      }


    public virtual int extraUserFeedbackComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserFeedbackComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserFeedbackComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserFeedbackLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryRequestID(string new_value)
      {
        flagHasQueryRequestID = true;
        storeQueryRequestID = new_value;
      }
    public void unsetQueryRequestID()
      {
        flagHasQueryRequestID = false;
      }
    public void setServerGeneratedID(string new_value)
      {
        flagHasServerGeneratedID = true;
        storeServerGeneratedID = new_value;
      }
    public void unsetServerGeneratedID()
      {
        flagHasServerGeneratedID = false;
      }
    public void initFeedbackItems()
      {
        if (flagHasFeedbackItems)
          {
            for (int num1 = 0; num1 < storeFeedbackItems.Count; ++num1)
              {
              }
          }
        flagHasFeedbackItems = true;
        storeFeedbackItems.Clear();
      }
    public void appendFeedbackItems(UserFeedbackItemJSON  to_append)
      {
        if (!flagHasFeedbackItems)
          {
            flagHasFeedbackItems = true;
            storeFeedbackItems.Clear();
          }
        Debug.Assert(flagHasFeedbackItems);
        storeFeedbackItems.Add(to_append);
      }
    public void unsetFeedbackItems()
      {
        if (flagHasFeedbackItems)
          {
            for (int num2 = 0; num2 < storeFeedbackItems.Count; ++num2)
              {
              }
          }
        flagHasFeedbackItems = false;
        storeFeedbackItems.Clear();
      }

    public virtual void extraUserFeedbackAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserFeedbackSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserFeedbackLookup(key);
        if (old_field == null)
          {
            extraUserFeedbackAppendPair(key, new_component);
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
        if (flagHasQueryRequestID)
          {
            handler.start_pair("QueryRequestID");
            handler.string_value(storeQueryRequestID);
          }
        if (flagHasServerGeneratedID)
          {
            handler.start_pair("ServerGeneratedID");
            handler.string_value(storeServerGeneratedID);
          }
        Debug.Assert(partial_allowed || flagHasFeedbackItems);
        if (flagHasFeedbackItems)
          {
            handler.start_pair("FeedbackItems");
            handler.start_array();
            for (int num1 = 0; num1 < storeFeedbackItems.Count; ++num1)
              {
                if (partial_allowed)
                    storeFeedbackItems[num1].write_partial_as_json(handler);
                else
                    storeFeedbackItems[num1].write_as_json(handler);
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
        if (!(hasFeedbackItems()))
          {
            return "When parsing the object for %what%, the \"FeedbackItems\" field was missing.";
          }
        return null;
      }

    public static UserFeedbackJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserFeedbackJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedback", ignore_extras);
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
    public static UserFeedbackJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserFeedbackJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserFeedbackJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedback", ignore_extras);
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
    public static UserFeedbackJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserFeedbackJSON from_text(string text, bool ignore_extras)
      {
        UserFeedbackJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedback", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserFeedbackJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserFeedbackJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserFeedbackJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedback", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorQueryRequestID;
        private JSONHoldingStringGenerator fieldGeneratorServerGeneratedID;
        private UserFeedbackItemJSON.HoldingArrayGenerator fieldGeneratorFeedbackItems;
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
            UserFeedbackJSON result = new UserFeedbackJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserFeedbackAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserFeedbackJSON result)
          {
            if (fieldGeneratorQueryRequestID.have_value)
              {
                result.setQueryRequestID(fieldGeneratorQueryRequestID.value);
                fieldGeneratorQueryRequestID.have_value = false;
              }
            if (fieldGeneratorServerGeneratedID.have_value)
              {
                result.setServerGeneratedID(fieldGeneratorServerGeneratedID.value);
                fieldGeneratorServerGeneratedID.have_value = false;
              }
            if (fieldGeneratorFeedbackItems.have_value)
              {
                result.initFeedbackItems();
                int count = fieldGeneratorFeedbackItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFeedbackItems(fieldGeneratorFeedbackItems.value[num]);
                  }
                fieldGeneratorFeedbackItems.value.Clear();
                fieldGeneratorFeedbackItems.have_value = false;
              }
            else if ((!(result.hasFeedbackItems())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FeedbackItems\" field was missing.");
              }
          }
        protected abstract void handle_result(UserFeedbackJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "eedbackItems", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorFeedbackItems;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryRequestID", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorQueryRequestID;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "erverGeneratedID", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorServerGeneratedID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryRequestID = new JSONHoldingStringGenerator("field \"QueryRequestID\" of the UserFeedback class");
            fieldGeneratorServerGeneratedID = new JSONHoldingStringGenerator("field \"ServerGeneratedID\" of the UserFeedback class");
            fieldGeneratorFeedbackItems = new UserFeedbackItemJSON.HoldingArrayGenerator("field \"FeedbackItems\" of the UserFeedback class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserFeedback class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryRequestID = new JSONHoldingStringGenerator("field \"QueryRequestID\" of the UserFeedback class");
            fieldGeneratorServerGeneratedID = new JSONHoldingStringGenerator("field \"ServerGeneratedID\" of the UserFeedback class");
            fieldGeneratorFeedbackItems = new UserFeedbackItemJSON.HoldingArrayGenerator("field \"FeedbackItems\" of the UserFeedback class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserFeedback class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryRequestID.reset();
            fieldGeneratorServerGeneratedID.reset();
            fieldGeneratorFeedbackItems.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFeedbackItems.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFeedbackItems.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UserFeedbackJSON  result)
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
        public UserFeedbackJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserFeedbackJSON  result)
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
    protected virtual void handle_result(List<UserFeedbackJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserFeedbackJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserFeedbackJSON>();
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
    public List<UserFeedbackJSON> value;
  };
  };
