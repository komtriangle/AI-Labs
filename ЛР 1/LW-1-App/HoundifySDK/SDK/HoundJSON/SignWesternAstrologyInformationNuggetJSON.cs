/* file "SignWesternAstrologyInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SignWesternAstrologyInformationNuggetJSON : WesternAstrologyInformationNuggetJSON
  {
    public enum TypeQueryIntentKnownValues
      {
        QueryIntent_GeneralInformation,
        QueryIntent_BirthDate,
        QueryIntent__none
      };
    public struct TypeQueryIntent
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryIntentKnownValues list_value;
      };

    public static TypeQueryIntentKnownValues  stringToQueryIntent(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "irthDate", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeQueryIntentKnownValues.QueryIntent_BirthDate;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "eneralInformation", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeQueryIntentKnownValues.QueryIntent_GeneralInformation;
                break;
            default:
                break;
          }
        return TypeQueryIntentKnownValues.QueryIntent__none;
      }

    public static string  stringFromQueryIntent(TypeQueryIntentKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryIntentKnownValues.QueryIntent_GeneralInformation:
                return "GeneralInformation";
            case TypeQueryIntentKnownValues.QueryIntent_BirthDate:
                return "BirthDate";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryIntent;
    private TypeQueryIntent storeQueryIntent;
    private bool flagHasWesternAstrologySignsInformation;
    private List< WesternAstrologySignInformationJSON  > storeWesternAstrologySignsInformation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryIntentToJSON()
      {
        JSONStringValue generated_string_QueryIntent;
        if (!(storeQueryIntent.in_known_list))
          {
        generated_string_QueryIntent = new JSONStringValue(storeQueryIntent.string_value);
          }
        else
          {
        switch (storeQueryIntent.list_value)
          {
            case TypeQueryIntentKnownValues.QueryIntent_GeneralInformation:
                generated_string_QueryIntent = new JSONStringValue("GeneralInformation");
                break;
            case TypeQueryIntentKnownValues.QueryIntent_BirthDate:
                generated_string_QueryIntent = new JSONStringValue("BirthDate");
                break;
            default:
                Debug.Assert(false);
                generated_string_QueryIntent = null;
                break;
          }
          }
        return generated_string_QueryIntent;
      }

    private JSONValue  extraWesternAstrologySignsInformationToJSON()
      {
        JSONArrayValue generated_array_1_WesternAstrologySignsInformation = new JSONArrayValue();
        for (int num1 = 0; num1 < storeWesternAstrologySignsInformation.Count; ++num1)
          {
            JSONValueHandler handler_WesternAstrologySignsInformation = new JSONValueHandler();
            storeWesternAstrologySignsInformation[num1].write_as_json(handler_WesternAstrologySignsInformation);
            generated_array_1_WesternAstrologySignsInformation.appendComponent(handler_WesternAstrologySignsInformation.result);
          }
        return generated_array_1_WesternAstrologySignsInformation;
      }


    private void  fromJSONQueryIntent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryIntent of SignWesternAstrologyInformationNuggetJSON is not a string.");
        TypeQueryIntent the_open_enum = new TypeQueryIntent();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "irthDate", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryIntentKnownValues.QueryIntent_BirthDate;
                        goto open_enum_is_done;
                      }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "eneralInformation", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryIntentKnownValues.QueryIntent_GeneralInformation;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryIntent(the_open_enum);
      }


    private void  fromJSONWesternAstrologySignsInformation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WesternAstrologySignsInformation of SignWesternAstrologyInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field WesternAstrologySignsInformation of SignWesternAstrologyInformationNuggetJSON has too few elements.");
        List< WesternAstrologySignInformationJSON  > vector_WesternAstrologySignsInformation1 = new List< WesternAstrologySignInformationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WesternAstrologySignInformationJSON convert_classy = WesternAstrologySignInformationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_WesternAstrologySignsInformation1.Add(convert_classy);
          }
        Debug.Assert(vector_WesternAstrologySignsInformation1.Count >= 1);
        initWesternAstrologySignsInformation();
        for (int num1 = 0; num1 < vector_WesternAstrologySignsInformation1.Count; ++num1)
            appendWesternAstrologySignsInformation(vector_WesternAstrologySignsInformation1[num1]);
        for (int num1 = 0; num1 < vector_WesternAstrologySignsInformation1.Count; ++num1)
          {
          }
      }


    public SignWesternAstrologyInformationNuggetJSON()
      {
        flagHasQueryIntent = false;
        flagHasWesternAstrologySignsInformation = false;
        storeWesternAstrologySignsInformation = new List< WesternAstrologySignInformationJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWesternAstrologyInformationNuggetKind()
      {
        return "SignWesternAstrologyInformationNugget";
      }

    public bool  hasQueryIntent()
      {
        return flagHasQueryIntent;
      }

    public TypeQueryIntent  getQueryIntent()
      {
        Debug.Assert(flagHasQueryIntent);
        return storeQueryIntent;
      }

    public string  getQueryIntentAsString()
      {
        TypeQueryIntent result = getQueryIntent();
        if (result.in_known_list)
            return stringFromQueryIntent(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasWesternAstrologySignsInformation()
      {
        return flagHasWesternAstrologySignsInformation;
      }

    public int  countOfWesternAstrologySignsInformation()
      {
        Debug.Assert(flagHasWesternAstrologySignsInformation);
        return storeWesternAstrologySignsInformation.Count;
      }

    public WesternAstrologySignInformationJSON   elementOfWesternAstrologySignsInformation(int element_num)
      {
        Debug.Assert(flagHasWesternAstrologySignsInformation);
        return storeWesternAstrologySignsInformation[element_num];
      }

    public List< WesternAstrologySignInformationJSON  >  getWesternAstrologySignsInformation()
      {
        Debug.Assert(flagHasWesternAstrologySignsInformation);
        return storeWesternAstrologySignsInformation;
      }


    public virtual int extraSignWesternAstrologyInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSignWesternAstrologyInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSignWesternAstrologyInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSignWesternAstrologyInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWesternAstrologyInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryIntent)
            ++result;
        if (flagHasWesternAstrologySignsInformation)
            ++result;
        result += extraSignWesternAstrologyInformationNuggetComponentCount();
        return result;
      }
    public override string extraWesternAstrologyInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryIntent)
          {
            if (remainder == 0)
                return "QueryIntent";
            --remainder;
          }
        if (flagHasWesternAstrologySignsInformation)
          {
            if (remainder == 0)
                return "WesternAstrologySignsInformation";
            --remainder;
          }
        return extraSignWesternAstrologyInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraWesternAstrologyInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryIntent)
          {
            if (remainder == 0)
                return extraQueryIntentToJSON();
            --remainder;
          }
        if (flagHasWesternAstrologySignsInformation)
          {
            if (remainder == 0)
                return extraWesternAstrologySignsInformationToJSON();
            --remainder;
          }
        return extraSignWesternAstrologyInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWesternAstrologyInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryIntent", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasQueryIntent ? extraQueryIntentToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "esternAstrologySignsInformation", 0, 31, false) == 0) && (field_name.Length == 32))
                    return (flagHasWesternAstrologySignsInformation ? extraWesternAstrologySignsInformationToJSON() : null);
                break;
            default:
                break;
          }
        return extraSignWesternAstrologyInformationNuggetLookup(field_name);
      }

    public void setQueryIntent(TypeQueryIntent new_value)
      {
        flagHasQueryIntent = true;
        storeQueryIntent = new_value;
      }
    public void setQueryIntent(string chars)
      {
        TypeQueryIntentKnownValues known = stringToQueryIntent(chars);
        TypeQueryIntent new_value = new TypeQueryIntent();
        if (known == TypeQueryIntentKnownValues.QueryIntent__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryIntent(new_value);
      }
    public void setQueryIntent(TypeQueryIntentKnownValues new_value)
      {
        TypeQueryIntent new_full_value = new TypeQueryIntent();
        Debug.Assert(new_value != TypeQueryIntentKnownValues.QueryIntent__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryIntent(new_full_value);
      }
    public void unsetQueryIntent()
      {
        flagHasQueryIntent = false;
      }
    public void initWesternAstrologySignsInformation()
      {
        if (flagHasWesternAstrologySignsInformation)
          {
            for (int num1 = 0; num1 < storeWesternAstrologySignsInformation.Count; ++num1)
              {
              }
          }
        flagHasWesternAstrologySignsInformation = true;
        storeWesternAstrologySignsInformation.Clear();
      }
    public void appendWesternAstrologySignsInformation(WesternAstrologySignInformationJSON  to_append)
      {
        if (!flagHasWesternAstrologySignsInformation)
          {
            flagHasWesternAstrologySignsInformation = true;
            storeWesternAstrologySignsInformation.Clear();
          }
        Debug.Assert(flagHasWesternAstrologySignsInformation);
        storeWesternAstrologySignsInformation.Add(to_append);
      }
    public void unsetWesternAstrologySignsInformation()
      {
        if (flagHasWesternAstrologySignsInformation)
          {
            for (int num2 = 0; num2 < storeWesternAstrologySignsInformation.Count; ++num2)
              {
              }
          }
        flagHasWesternAstrologySignsInformation = false;
        storeWesternAstrologySignsInformation.Clear();
      }

    public virtual void extraSignWesternAstrologyInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSignWesternAstrologyInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSignWesternAstrologyInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSignWesternAstrologyInformationNuggetAppendPair(key, new_component);
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
    public override void extraWesternAstrologyInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'Q':
                if ((String.Compare(key, 1, "ueryIntent", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryIntent(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "esternAstrologySignsInformation", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONWesternAstrologySignsInformation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSignWesternAstrologyInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWesternAstrologyInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'Q':
                if ((String.Compare(key, 1, "ueryIntent", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONQueryIntent(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "esternAstrologySignsInformation", 0, 31, false) == 0) && (key.Length == 32))
                    {
                    fromJSONWesternAstrologySignsInformation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSignWesternAstrologyInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryIntent);
        if (flagHasQueryIntent)
          {
            handler.start_pair("QueryIntent");
            if (storeQueryIntent.in_known_list)
              {
                switch (storeQueryIntent.list_value)
                  {
                    case TypeQueryIntentKnownValues.QueryIntent_GeneralInformation:
                        handler.string_value("GeneralInformation");
                        break;
                    case TypeQueryIntentKnownValues.QueryIntent_BirthDate:
                        handler.string_value("BirthDate");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryIntent.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasWesternAstrologySignsInformation);
        if (flagHasWesternAstrologySignsInformation)
          {
            handler.start_pair("WesternAstrologySignsInformation");
            Debug.Assert(storeWesternAstrologySignsInformation.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeWesternAstrologySignsInformation.Count; ++num1)
              {
                if (partial_allowed)
                    storeWesternAstrologySignsInformation[num1].write_partial_as_json(handler);
                else
                    storeWesternAstrologySignsInformation[num1].write_as_json(handler);
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
        if (!(hasQueryIntent()))
          {
            return "When parsing the object for %what%, the \"QueryIntent\" field was missing.";
          }
        if (!(hasWesternAstrologySignsInformation()))
          {
            return "When parsing the object for %what%, the \"WesternAstrologySignsInformation\" field was missing.";
          }
        return null;
      }

    public static new SignWesternAstrologyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SignWesternAstrologyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SignWesternAstrologyInformationNugget", ignore_extras);
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
    public static new SignWesternAstrologyInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SignWesternAstrologyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SignWesternAstrologyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SignWesternAstrologyInformationNugget", ignore_extras);
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
    public static new SignWesternAstrologyInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SignWesternAstrologyInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SignWesternAstrologyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SignWesternAstrologyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SignWesternAstrologyInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SignWesternAstrologyInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SignWesternAstrologyInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SignWesternAstrologyInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WesternAstrologyInformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorQueryIntent : JSONStringGenerator
          {
            protected FieldGeneratorQueryIntent(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryIntent()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryIntentKnownValues known = stringToQueryIntent(result);
                TypeQueryIntent new_value = new TypeQueryIntent();
                if (known == TypeQueryIntentKnownValues.QueryIntent__none)
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
            protected abstract void handle_result(TypeQueryIntent result);
          };
    private class FieldHoldingGeneratorQueryIntent : FieldGeneratorQueryIntent
  {
    protected override void handle_result(TypeQueryIntent result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryIntent(String what)
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
    public TypeQueryIntent value;
  };
    private class FieldHoldingArrayGeneratorQueryIntent : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryIntent
      {
        private FieldHoldingArrayGeneratorQueryIntent top;

        protected override void handle_result(TypeQueryIntent result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryIntent init_top)
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
    protected virtual void handle_result(List<TypeQueryIntent> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryIntent(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryIntent>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryIntent()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryIntent>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryIntent> value;
  };
        private FieldHoldingGeneratorQueryIntent fieldGeneratorQueryIntent;
        private WesternAstrologySignInformationJSON.HoldingArrayGenerator fieldGeneratorWesternAstrologySignsInformation;
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
            if (!(getWesternAstrologyInformationNuggetJSONKey().Equals("SignWesternAstrologyInformationNugget")))
                throw new Exception("The key field has a value other than `SignWesternAstrologyInformationNugget'.");
            SignWesternAstrologyInformationNuggetJSON result = new SignWesternAstrologyInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSignWesternAstrologyInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WesternAstrologyInformationNuggetJSON new_result)
          {
            handle_result((SignWesternAstrologyInformationNuggetJSON )new_result);
          }
        protected void finish(SignWesternAstrologyInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryIntent.have_value)
              {
                result.setQueryIntent(fieldGeneratorQueryIntent.value);
                fieldGeneratorQueryIntent.have_value = false;
              }
            else if ((!(result.hasQueryIntent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryIntent\" field was missing.");
              }
            if (fieldGeneratorWesternAstrologySignsInformation.have_value)
              {
                result.initWesternAstrologySignsInformation();
                int count = fieldGeneratorWesternAstrologySignsInformation.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWesternAstrologySignsInformation(fieldGeneratorWesternAstrologySignsInformation.value[num]);
                  }
                fieldGeneratorWesternAstrologySignsInformation.value.Clear();
                fieldGeneratorWesternAstrologySignsInformation.have_value = false;
              }
            else if ((!(result.hasWesternAstrologySignsInformation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WesternAstrologySignsInformation\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SignWesternAstrologyInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryIntent", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorQueryIntent;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "esternAstrologySignsInformation", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorWesternAstrologySignsInformation;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryIntent = new FieldHoldingGeneratorQueryIntent("field \"QueryIntent\" of the SignWesternAstrologyInformationNugget class");
            fieldGeneratorWesternAstrologySignsInformation = new WesternAstrologySignInformationJSON.HoldingArrayGenerator("field \"WesternAstrologySignsInformation\" of the SignWesternAstrologyInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SignWesternAstrologyInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryIntent = new FieldHoldingGeneratorQueryIntent("field \"QueryIntent\" of the SignWesternAstrologyInformationNugget class");
            fieldGeneratorWesternAstrologySignsInformation = new WesternAstrologySignInformationJSON.HoldingArrayGenerator("field \"WesternAstrologySignsInformation\" of the SignWesternAstrologyInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SignWesternAstrologyInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryIntent.reset();
            fieldGeneratorWesternAstrologySignsInformation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SignWesternAstrologyInformationNuggetJSON  result)
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
        public SignWesternAstrologyInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SignWesternAstrologyInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SignWesternAstrologyInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SignWesternAstrologyInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SignWesternAstrologyInformationNuggetJSON>();
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
    public List<SignWesternAstrologyInformationNuggetJSON> value;
  };
  };
