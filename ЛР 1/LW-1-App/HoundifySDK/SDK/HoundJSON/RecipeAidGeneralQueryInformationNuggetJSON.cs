/* file "RecipeAidGeneralQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RecipeAidGeneralQueryInformationNuggetJSON : RecipeAidInformationNuggetJSON
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_Title,
        QueryType_Ingredients,
        QueryType_CookTime,
        QueryType_Yield,
        QueryType_Unknown,
        QueryType__none
      };
    public struct TypeQueryType
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryTypeKnownValues list_value;
      };

    public static TypeQueryTypeKnownValues  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "ookTime", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeQueryTypeKnownValues.QueryType_CookTime;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "ngredients", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeQueryTypeKnownValues.QueryType_Ingredients;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "itle", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQueryTypeKnownValues.QueryType_Title;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeQueryTypeKnownValues.QueryType_Unknown;
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "ield", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQueryTypeKnownValues.QueryType_Yield;
                break;
            default:
                break;
          }
        return TypeQueryTypeKnownValues.QueryType__none;
      }

    public static string  stringFromQueryType(TypeQueryTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryTypeKnownValues.QueryType_Title:
                return "Title";
            case TypeQueryTypeKnownValues.QueryType_Ingredients:
                return "Ingredients";
            case TypeQueryTypeKnownValues.QueryType_CookTime:
                return "CookTime";
            case TypeQueryTypeKnownValues.QueryType_Yield:
                return "Yield";
            case TypeQueryTypeKnownValues.QueryType_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryTypeToJSON()
      {
        JSONStringValue generated_string_QueryType;
        if (!(storeQueryType.in_known_list))
          {
        generated_string_QueryType = new JSONStringValue(storeQueryType.string_value);
          }
        else
          {
        switch (storeQueryType.list_value)
          {
            case TypeQueryTypeKnownValues.QueryType_Title:
                generated_string_QueryType = new JSONStringValue("Title");
                break;
            case TypeQueryTypeKnownValues.QueryType_Ingredients:
                generated_string_QueryType = new JSONStringValue("Ingredients");
                break;
            case TypeQueryTypeKnownValues.QueryType_CookTime:
                generated_string_QueryType = new JSONStringValue("CookTime");
                break;
            case TypeQueryTypeKnownValues.QueryType_Yield:
                generated_string_QueryType = new JSONStringValue("Yield");
                break;
            case TypeQueryTypeKnownValues.QueryType_Unknown:
                generated_string_QueryType = new JSONStringValue("Unknown");
                break;
            default:
                Debug.Assert(false);
                generated_string_QueryType = null;
                break;
          }
          }
        return generated_string_QueryType;
      }


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of RecipeAidGeneralQueryInformationNuggetJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ookTime", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_CookTime;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "ngredients", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Ingredients;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "itle", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Title;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "ield", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Yield;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryType(the_open_enum);
      }


    public RecipeAidGeneralQueryInformationNuggetJSON()
      {
        flagHasQueryType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRecipeAidNuggetKind()
      {
        return "GeneralQuery";
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        TypeQueryType result = getQueryType();
        if (result.in_known_list)
            return stringFromQueryType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraRecipeAidGeneralQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAidGeneralQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAidGeneralQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAidGeneralQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRecipeAidInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryType)
            ++result;
        result += extraRecipeAidGeneralQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraRecipeAidInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return "QueryType";
            --remainder;
          }
        return extraRecipeAidGeneralQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraRecipeAidInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return extraQueryTypeToJSON();
            --remainder;
          }
        return extraRecipeAidGeneralQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraRecipeAidInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "QueryType", 0, 9, false) == 0) && (field_name.Length == 9))
            return (flagHasQueryType ? extraQueryTypeToJSON() : null);
        return extraRecipeAidGeneralQueryInformationNuggetLookup(field_name);
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        TypeQueryTypeKnownValues known = stringToQueryType(chars);
        TypeQueryType new_value = new TypeQueryType();
        if (known == TypeQueryTypeKnownValues.QueryType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void setQueryType(TypeQueryTypeKnownValues new_value)
      {
        TypeQueryType new_full_value = new TypeQueryType();
        Debug.Assert(new_value != TypeQueryTypeKnownValues.QueryType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryType(new_full_value);
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
      }

    public virtual void extraRecipeAidGeneralQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAidGeneralQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAidGeneralQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRecipeAidGeneralQueryInformationNuggetAppendPair(key, new_component);
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
    public override void extraRecipeAidInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "QueryType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONQueryType(new_component, false);
            return;
            }
        extraRecipeAidGeneralQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraRecipeAidInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "QueryType", 0, 9, false) == 0) && (key.Length == 9))
            {
            fromJSONQueryType(new_component, false);
            return;
            }
        extraRecipeAidGeneralQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (storeQueryType.in_known_list)
              {
                switch (storeQueryType.list_value)
                  {
                    case TypeQueryTypeKnownValues.QueryType_Title:
                        handler.string_value("Title");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Ingredients:
                        handler.string_value("Ingredients");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_CookTime:
                        handler.string_value("CookTime");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Yield:
                        handler.string_value("Yield");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryType.string_value);
              }
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static new RecipeAidGeneralQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidGeneralQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidGeneralQueryInformationNugget", ignore_extras);
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
    public static new RecipeAidGeneralQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidGeneralQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidGeneralQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidGeneralQueryInformationNugget", ignore_extras);
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
    public static new RecipeAidGeneralQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidGeneralQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidGeneralQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidGeneralQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidGeneralQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RecipeAidGeneralQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidGeneralQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidGeneralQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RecipeAidInformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryTypeKnownValues known = stringToQueryType(result);
                TypeQueryType new_value = new TypeQueryType();
                if (known == TypeQueryTypeKnownValues.QueryType__none)
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
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
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
            if (!(getRecipeAidInformationNuggetJSONKey().Equals("GeneralQuery")))
                throw new Exception("The key field has a value other than `GeneralQuery'.");
            RecipeAidGeneralQueryInformationNuggetJSON result = new RecipeAidGeneralQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidGeneralQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RecipeAidInformationNuggetJSON new_result)
          {
            handle_result((RecipeAidGeneralQueryInformationNuggetJSON )new_result);
          }
        protected void finish(RecipeAidGeneralQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RecipeAidGeneralQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "QueryType", 0, 9, false) == 0) && (field_name.Length == 9))
                return fieldGeneratorQueryType;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the RecipeAidGeneralQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAidGeneralQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the RecipeAidGeneralQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAidGeneralQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeAidGeneralQueryInformationNuggetJSON  result)
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
        public RecipeAidGeneralQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidGeneralQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RecipeAidGeneralQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidGeneralQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidGeneralQueryInformationNuggetJSON>();
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
    public List<RecipeAidGeneralQueryInformationNuggetJSON> value;
  };
  };
