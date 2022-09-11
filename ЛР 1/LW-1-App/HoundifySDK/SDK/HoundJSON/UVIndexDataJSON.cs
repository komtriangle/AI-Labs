/* file "UVIndexDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UVIndexDataJSON : JSONBase
  {
    public enum TypeCategoryKnownValues
      {
        Category_Low,
        Category_Moderate,
        Category_High,
        Category_Very_x20_High,
        Category_Extreme,
        Category__none
      };
    public struct TypeCategory
      {
        public bool in_known_list;
        public string string_value;
        public TypeCategoryKnownValues list_value;
      };

    public static TypeCategoryKnownValues  stringToCategory(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "xtreme", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeCategoryKnownValues.Category_Extreme;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "igh", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCategoryKnownValues.Category_High;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ow", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeCategoryKnownValues.Category_Low;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "oderate", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeCategoryKnownValues.Category_Moderate;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ery High", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCategoryKnownValues.Category_Very_x20_High;
                break;
            default:
                break;
          }
        return TypeCategoryKnownValues.Category__none;
      }

    public static string  stringFromCategory(TypeCategoryKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCategoryKnownValues.Category_Low:
                return "Low";
            case TypeCategoryKnownValues.Category_Moderate:
                return "Moderate";
            case TypeCategoryKnownValues.Category_High:
                return "High";
            case TypeCategoryKnownValues.Category_Very_x20_High:
                return "Very High";
            case TypeCategoryKnownValues.Category_Extreme:
                return "Extreme";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private sbyte storeValue;
    private bool flagHasCategory;
    private TypeCategory storeCategory;
    private bool flagHasText;
    private string storeText;
    private bool flagHasDisplayText;
    private string storeDisplayText;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Value of UVIndexDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Value of UVIndexDataJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setValue(extracted_integer);
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of UVIndexDataJSON is not a string.");
        TypeCategory the_open_enum = new TypeCategory();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "xtreme", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCategoryKnownValues.Category_Extreme;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "igh", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCategoryKnownValues.Category_High;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCategoryKnownValues.Category_Low;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "oderate", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCategoryKnownValues.Category_Moderate;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ery High", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCategoryKnownValues.Category_Very_x20_High;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCategory(the_open_enum);
      }


    private void  fromJSONText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Text of UVIndexDataJSON is not a string.");
        setText(json_string.getData());
      }


    private void  fromJSONDisplayText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayText of UVIndexDataJSON is not a string.");
        setDisplayText(json_string.getData());
      }


    public UVIndexDataJSON()
      {
        flagHasValue = false;
        flagHasCategory = false;
        flagHasText = false;
        flagHasDisplayText = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public sbyte  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public TypeCategory  getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
      }

    public string  getCategoryAsString()
      {
        TypeCategory result = getCategory();
        if (result.in_known_list)
            return stringFromCategory(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasText()
      {
        return flagHasText;
      }

    public string  getText()
      {
        Debug.Assert(flagHasText);
        return storeText;
      }

    public bool  hasDisplayText()
      {
        return flagHasDisplayText;
      }

    public string  getDisplayText()
      {
        Debug.Assert(flagHasDisplayText);
        return storeDisplayText;
      }


    public virtual int extraUVIndexDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUVIndexDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUVIndexDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUVIndexDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setValue(sbyte new_value)
      {
        flagHasValue = true;
        if (new_value < 0)
            throw new Exception("The value for field Value of UVIndexDataJSON is less than the lower bound (0) for that field.");
        if (new_value > 30)
            throw new Exception("The value for field Value of UVIndexDataJSON is greater than the upper bound (30) for that field.");
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }
    public void setCategory(TypeCategory new_value)
      {
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void setCategory(string chars)
      {
        TypeCategoryKnownValues known = stringToCategory(chars);
        TypeCategory new_value = new TypeCategory();
        if (known == TypeCategoryKnownValues.Category__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCategory(new_value);
      }
    public void setCategory(TypeCategoryKnownValues new_value)
      {
        TypeCategory new_full_value = new TypeCategory();
        Debug.Assert(new_value != TypeCategoryKnownValues.Category__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCategory(new_full_value);
      }
    public void unsetCategory()
      {
        flagHasCategory = false;
      }
    public void setText(string new_value)
      {
        flagHasText = true;
        storeText = new_value;
      }
    public void unsetText()
      {
        flagHasText = false;
      }
    public void setDisplayText(string new_value)
      {
        flagHasDisplayText = true;
        storeDisplayText = new_value;
      }
    public void unsetDisplayText()
      {
        flagHasDisplayText = false;
      }

    public virtual void extraUVIndexDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUVIndexDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUVIndexDataLookup(key);
        if (old_field == null)
          {
            extraUVIndexDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasValue);
        if (flagHasValue)
          {
            handler.start_pair("Value");
            handler.number_value(storeValue);
          }
        Debug.Assert(partial_allowed || flagHasCategory);
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            if (storeCategory.in_known_list)
              {
                switch (storeCategory.list_value)
                  {
                    case TypeCategoryKnownValues.Category_Low:
                        handler.string_value("Low");
                        break;
                    case TypeCategoryKnownValues.Category_Moderate:
                        handler.string_value("Moderate");
                        break;
                    case TypeCategoryKnownValues.Category_High:
                        handler.string_value("High");
                        break;
                    case TypeCategoryKnownValues.Category_Very_x20_High:
                        handler.string_value("Very High");
                        break;
                    case TypeCategoryKnownValues.Category_Extreme:
                        handler.string_value("Extreme");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCategory.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasText);
        if (flagHasText)
          {
            handler.start_pair("Text");
            handler.string_value(storeText);
          }
        Debug.Assert(partial_allowed || flagHasDisplayText);
        if (flagHasDisplayText)
          {
            handler.start_pair("DisplayText");
            handler.string_value(storeDisplayText);
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
        if (!(hasValue()))
          {
            return "When parsing the object for %what%, the \"Value\" field was missing.";
          }
        if (!(hasCategory()))
          {
            return "When parsing the object for %what%, the \"Category\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasText()))
          {
            return "When parsing the object for %what%, the \"Text\" field was missing.";
          }
        if ((!allow_unpolished) && !(hasDisplayText()))
          {
            return "When parsing the object for %what%, the \"DisplayText\" field was missing.";
          }
        return null;
      }

    public static UVIndexDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UVIndexDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UVIndexData", ignore_extras);
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
    public static UVIndexDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UVIndexDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UVIndexDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UVIndexData", ignore_extras);
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
    public static UVIndexDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UVIndexDataJSON from_text(string text, bool ignore_extras)
      {
        UVIndexDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UVIndexData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UVIndexDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UVIndexDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UVIndexDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UVIndexData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorValue : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorValue(String what) : base(what, 0, 30)
              {
              }
          };
    private class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorValue(String what) : base(what, 0, 30)
              {
              }
          };
        private FieldHoldingGeneratorValue fieldGeneratorValue;
    private abstract class FieldGeneratorCategory : JSONStringGenerator
          {
            protected FieldGeneratorCategory(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCategory()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCategoryKnownValues known = stringToCategory(result);
                TypeCategory new_value = new TypeCategory();
                if (known == TypeCategoryKnownValues.Category__none)
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
            protected abstract void handle_result(TypeCategory result);
          };
    private class FieldHoldingGeneratorCategory : FieldGeneratorCategory
  {
    protected override void handle_result(TypeCategory result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCategory(String what)
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
    public TypeCategory value;
  };
    private class FieldHoldingArrayGeneratorCategory : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCategory
      {
        private FieldHoldingArrayGeneratorCategory top;

        protected override void handle_result(TypeCategory result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCategory init_top)
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
    protected virtual void handle_result(List<TypeCategory> result)
      {
      }

    public FieldHoldingArrayGeneratorCategory(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCategory>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCategory()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCategory>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCategory> value;
  };
        private FieldHoldingGeneratorCategory fieldGeneratorCategory;
        private JSONHoldingStringGenerator fieldGeneratorText;
        private JSONHoldingStringGenerator fieldGeneratorDisplayText;
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
            UVIndexDataJSON result = new UVIndexDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUVIndexDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UVIndexDataJSON result)
          {
            if (fieldGeneratorValue.have_value)
              {
                result.setValue((sbyte)(fieldGeneratorValue.value));
                fieldGeneratorValue.have_value = false;
              }
            else if ((!(result.hasValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Value\" field was missing.");
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            else if ((!(result.hasCategory())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Category\" field was missing.");
              }
            if (fieldGeneratorText.have_value)
              {
                result.setText(fieldGeneratorText.value);
                fieldGeneratorText.have_value = false;
              }
            else if ((!(result.hasText())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Text\" field was missing.");
              }
            if (fieldGeneratorDisplayText.have_value)
              {
                result.setDisplayText(fieldGeneratorDisplayText.value);
                fieldGeneratorDisplayText.have_value = false;
              }
            else if ((!(result.hasDisplayText())) && (!allow_unpolished) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisplayText\" field was missing.");
              }
          }
        protected abstract void handle_result(UVIndexDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCategory;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isplayText", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDisplayText;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorText;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the UVIndexData class");
            fieldGeneratorCategory = new FieldHoldingGeneratorCategory("field \"Category\" of the UVIndexData class");
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the UVIndexData class");
            fieldGeneratorDisplayText = new JSONHoldingStringGenerator("field \"DisplayText\" of the UVIndexData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UVIndexData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the UVIndexData class");
            fieldGeneratorCategory = new FieldHoldingGeneratorCategory("field \"Category\" of the UVIndexData class");
            fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the UVIndexData class");
            fieldGeneratorDisplayText = new JSONHoldingStringGenerator("field \"DisplayText\" of the UVIndexData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UVIndexData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorValue.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorText.reset();
            fieldGeneratorDisplayText.reset();
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
        protected override void handle_result(UVIndexDataJSON  result)
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
        public UVIndexDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UVIndexDataJSON  result)
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
    protected virtual void handle_result(List<UVIndexDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UVIndexDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UVIndexDataJSON>();
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
    public List<UVIndexDataJSON> value;
  };
  };
