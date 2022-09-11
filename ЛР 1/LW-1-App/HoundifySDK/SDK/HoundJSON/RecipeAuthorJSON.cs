/* file "RecipeAuthorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeAuthorJSON : JSONBase
  {
    private bool flagHasUserID;
    private BigInteger storeUserID;
    private bool flagHasUserName;
    private string storeUserName;
    private bool flagHasPhotoUrl;
    private string storePhotoUrl;
    private bool flagHasFirstName;
    private string storeFirstName;
    private bool flagHasLastName;
    private string storeLastName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUserID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field UserID of RecipeAuthorJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field UserID of RecipeAuthorJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setUserID(extracted_integer);
      }


    private void  fromJSONUserName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserName of RecipeAuthorJSON is not a string.");
        setUserName(json_string.getData());
      }


    private void  fromJSONPhotoUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhotoUrl of RecipeAuthorJSON is not a string.");
        setPhotoUrl(json_string.getData());
      }


    private void  fromJSONFirstName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstName of RecipeAuthorJSON is not a string.");
        setFirstName(json_string.getData());
      }


    private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastName of RecipeAuthorJSON is not a string.");
        setLastName(json_string.getData());
      }


    public RecipeAuthorJSON()
      {
        flagHasUserID = false;
        flagHasUserName = false;
        flagHasPhotoUrl = false;
        flagHasFirstName = false;
        flagHasLastName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUserID()
      {
        return flagHasUserID;
      }

    public BigInteger  getUserID()
      {
        Debug.Assert(flagHasUserID);
        return storeUserID;
      }

    public bool  hasUserName()
      {
        return flagHasUserName;
      }

    public string  getUserName()
      {
        Debug.Assert(flagHasUserName);
        return storeUserName;
      }

    public bool  hasPhotoUrl()
      {
        return flagHasPhotoUrl;
      }

    public string  getPhotoUrl()
      {
        Debug.Assert(flagHasPhotoUrl);
        return storePhotoUrl;
      }

    public bool  hasFirstName()
      {
        return flagHasFirstName;
      }

    public string  getFirstName()
      {
        Debug.Assert(flagHasFirstName);
        return storeFirstName;
      }

    public bool  hasLastName()
      {
        return flagHasLastName;
      }

    public string  getLastName()
      {
        Debug.Assert(flagHasLastName);
        return storeLastName;
      }


    public virtual int extraRecipeAuthorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAuthorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAuthorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAuthorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUserID(BigInteger new_value)
      {
        flagHasUserID = true;
        if (new_value < 0)
            throw new Exception("The value for field UserID of RecipeAuthorJSON is less than the lower bound (0) for that field.");
        storeUserID = new_value;
      }
    public void unsetUserID()
      {
        flagHasUserID = false;
      }
    public void setUserName(string new_value)
      {
        flagHasUserName = true;
        storeUserName = new_value;
      }
    public void unsetUserName()
      {
        flagHasUserName = false;
      }
    public void setPhotoUrl(string new_value)
      {
        flagHasPhotoUrl = true;
        storePhotoUrl = new_value;
      }
    public void unsetPhotoUrl()
      {
        flagHasPhotoUrl = false;
      }
    public void setFirstName(string new_value)
      {
        flagHasFirstName = true;
        storeFirstName = new_value;
      }
    public void unsetFirstName()
      {
        flagHasFirstName = false;
      }
    public void setLastName(string new_value)
      {
        flagHasLastName = true;
        storeLastName = new_value;
      }
    public void unsetLastName()
      {
        flagHasLastName = false;
      }

    public virtual void extraRecipeAuthorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAuthorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAuthorLookup(key);
        if (old_field == null)
          {
            extraRecipeAuthorAppendPair(key, new_component);
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
        if (flagHasUserID)
          {
            handler.start_pair("UserID");
            handler.number_value(storeUserID);
          }
        if (flagHasUserName)
          {
            handler.start_pair("UserName");
            handler.string_value(storeUserName);
          }
        if (flagHasPhotoUrl)
          {
            handler.start_pair("PhotoUrl");
            handler.string_value(storePhotoUrl);
          }
        if (flagHasFirstName)
          {
            handler.start_pair("FirstName");
            handler.string_value(storeFirstName);
          }
        if (flagHasLastName)
          {
            handler.start_pair("LastName");
            handler.string_value(storeLastName);
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

    public static RecipeAuthorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAuthorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAuthor", ignore_extras);
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
    public static RecipeAuthorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAuthorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAuthorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAuthor", ignore_extras);
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
    public static RecipeAuthorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAuthorJSON from_text(string text, bool ignore_extras)
      {
        RecipeAuthorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAuthor", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAuthorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeAuthorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAuthorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAuthor", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorUserID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorUserID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorUserID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorUserID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorUserID fieldGeneratorUserID;
        private JSONHoldingStringGenerator fieldGeneratorUserName;
        private JSONHoldingStringGenerator fieldGeneratorPhotoUrl;
        private JSONHoldingStringGenerator fieldGeneratorFirstName;
        private JSONHoldingStringGenerator fieldGeneratorLastName;
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
            RecipeAuthorJSON result = new RecipeAuthorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAuthorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeAuthorJSON result)
          {
            if (fieldGeneratorUserID.have_value)
              {
                result.setUserID(fieldGeneratorUserID.value);
                fieldGeneratorUserID.have_value = false;
              }
            if (fieldGeneratorUserName.have_value)
              {
                result.setUserName(fieldGeneratorUserName.value);
                fieldGeneratorUserName.have_value = false;
              }
            if (fieldGeneratorPhotoUrl.have_value)
              {
                result.setPhotoUrl(fieldGeneratorPhotoUrl.value);
                fieldGeneratorPhotoUrl.have_value = false;
              }
            if (fieldGeneratorFirstName.have_value)
              {
                result.setFirstName(fieldGeneratorFirstName.value);
                fieldGeneratorFirstName.have_value = false;
              }
            if (fieldGeneratorLastName.have_value)
              {
                result.setLastName(fieldGeneratorLastName.value);
                fieldGeneratorLastName.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeAuthorJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "irstName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFirstName;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLastName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "hotoUrl", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorPhotoUrl;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorUserID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorUserName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUserID = new FieldHoldingGeneratorUserID("field \"UserID\" of the RecipeAuthor class");
            fieldGeneratorUserName = new JSONHoldingStringGenerator("field \"UserName\" of the RecipeAuthor class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the RecipeAuthor class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the RecipeAuthor class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the RecipeAuthor class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAuthor class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUserID = new FieldHoldingGeneratorUserID("field \"UserID\" of the RecipeAuthor class");
            fieldGeneratorUserName = new JSONHoldingStringGenerator("field \"UserName\" of the RecipeAuthor class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the RecipeAuthor class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the RecipeAuthor class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the RecipeAuthor class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAuthor class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUserID.reset();
            fieldGeneratorUserName.reset();
            fieldGeneratorPhotoUrl.reset();
            fieldGeneratorFirstName.reset();
            fieldGeneratorLastName.reset();
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
        protected override void handle_result(RecipeAuthorJSON  result)
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
        public RecipeAuthorJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAuthorJSON  result)
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
    protected virtual void handle_result(List<RecipeAuthorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAuthorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAuthorJSON>();
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
    public List<RecipeAuthorJSON> value;
  };
  };
