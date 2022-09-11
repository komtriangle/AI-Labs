/* file "UserAppParsingItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UserAppParsingItemJSON : JSONBase
  {
    public enum TypePlatformKnownValues
      {
        Platform_Android,
        Platform_iOS,
        Platform__none
      };
    public struct TypePlatform
      {
        public bool in_known_list;
        public string string_value;
        public TypePlatformKnownValues list_value;
      };

    public static TypePlatformKnownValues  stringToPlatform(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ndroid", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypePlatformKnownValues.Platform_Android;
                break;
            case 'i':
                if ((String.Compare(chars, 1, "OS", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypePlatformKnownValues.Platform_iOS;
                break;
            default:
                break;
          }
        return TypePlatformKnownValues.Platform__none;
      }

    public static string  stringFromPlatform(TypePlatformKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePlatformKnownValues.Platform_Android:
                return "Android";
            case TypePlatformKnownValues.Platform_iOS:
                return "iOS";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasIndex;
    private BigInteger storeIndex;
    private bool flagHasPlatform;
    private TypePlatform storePlatform;
    private bool flagHasAppID;
    private string storeAppID;
    private bool flagHasAliasMatched;
    private bool storeAliasMatched;
    private bool flagHasPopularityMeasure;
    private double storePopularityMeasure;
    private string textStorePopularityMeasure;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Index of UserAppParsingItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Index of UserAppParsingItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIndex(extracted_integer);
      }


    private void  fromJSONPlatform(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Platform of UserAppParsingItemJSON is not a string.");
        TypePlatform the_open_enum = new TypePlatform();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ndroid", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlatformKnownValues.Platform_Android;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "OS", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePlatformKnownValues.Platform_iOS;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPlatform(the_open_enum);
      }


    private void  fromJSONAppID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AppID of UserAppParsingItemJSON is not a string.");
        setAppID(json_string.getData());
      }


    private void  fromJSONAliasMatched(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AliasMatched of UserAppParsingItemJSON is not true for false.");
              }
          }
        setAliasMatched(the_bool);
      }


    private void  fromJSONPopularityMeasure(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PopularityMeasure of UserAppParsingItemJSON is not a number.");
              }
          }
        setPopularityMeasureText(the_rational_text);
      }


    public UserAppParsingItemJSON()
      {
        flagHasIndex = false;
        flagHasPlatform = false;
        flagHasAppID = false;
        flagHasAliasMatched = false;
        flagHasPopularityMeasure = false;
        storePopularityMeasure = 1;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIndex()
      {
        return flagHasIndex;
      }

    public BigInteger  getIndex()
      {
        Debug.Assert(flagHasIndex);
        return storeIndex;
      }

    public bool  hasPlatform()
      {
        return flagHasPlatform;
      }

    public TypePlatform  getPlatform()
      {
        Debug.Assert(flagHasPlatform);
        return storePlatform;
      }

    public string  getPlatformAsString()
      {
        TypePlatform result = getPlatform();
        if (result.in_known_list)
            return stringFromPlatform(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasAppID()
      {
        return flagHasAppID;
      }

    public string  getAppID()
      {
        Debug.Assert(flagHasAppID);
        return storeAppID;
      }

    public bool  hasAliasMatched()
      {
        return flagHasAliasMatched;
      }

    public bool  getAliasMatched()
      {
        Debug.Assert(flagHasAliasMatched);
        return storeAliasMatched;
      }

    public bool  hasPopularityMeasure()
      {
        return flagHasPopularityMeasure;
      }

    public double  getPopularityMeasure()
      {
        if (textStorePopularityMeasure != "")
          {
            return Double.Parse(textStorePopularityMeasure);
          }
        return storePopularityMeasure;
      }

    public string  getPopularityMeasureAsText()
      {
        if (textStorePopularityMeasure == "")
          {
            return Convert.ToString(storePopularityMeasure);
          }
        else
          {
            return (textStorePopularityMeasure);
          }
      }


    public virtual int extraUserAppParsingItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserAppParsingItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserAppParsingItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserAppParsingItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIndex(BigInteger new_value)
      {
        flagHasIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field Index of UserAppParsingItemJSON is less than the lower bound (0) for that field.");
        storeIndex = new_value;
      }
    public void unsetIndex()
      {
        flagHasIndex = false;
      }
    public void setPlatform(TypePlatform new_value)
      {
        flagHasPlatform = true;
        storePlatform = new_value;
      }
    public void setPlatform(string chars)
      {
        TypePlatformKnownValues known = stringToPlatform(chars);
        TypePlatform new_value = new TypePlatform();
        if (known == TypePlatformKnownValues.Platform__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPlatform(new_value);
      }
    public void setPlatform(TypePlatformKnownValues new_value)
      {
        TypePlatform new_full_value = new TypePlatform();
        Debug.Assert(new_value != TypePlatformKnownValues.Platform__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPlatform(new_full_value);
      }
    public void unsetPlatform()
      {
        flagHasPlatform = false;
      }
    public void setAppID(string new_value)
      {
        flagHasAppID = true;
        storeAppID = new_value;
      }
    public void unsetAppID()
      {
        flagHasAppID = false;
      }
    public void setAliasMatched(bool new_value)
      {
        flagHasAliasMatched = true;
        storeAliasMatched = new_value;
      }
    public void unsetAliasMatched()
      {
        flagHasAliasMatched = false;
      }
    public void setPopularityMeasure(double new_value)
      {
        flagHasPopularityMeasure = true;
        storePopularityMeasure = new_value;
        textStorePopularityMeasure = "";
      }
    public void setPopularityMeasureText(string new_value)
      {
        flagHasPopularityMeasure = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PopularityMeasure of UserAppParsingItemJSON is not a valid number.");
        textStorePopularityMeasure = new_value;
      }
    public void unsetPopularityMeasure()
      {
        flagHasPopularityMeasure = false;
      }

    public virtual void extraUserAppParsingItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserAppParsingItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserAppParsingItemLookup(key);
        if (old_field == null)
          {
            extraUserAppParsingItemAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasIndex);
        if (flagHasIndex)
          {
            handler.start_pair("Index");
            handler.number_value(storeIndex);
          }
        Debug.Assert(partial_allowed || flagHasPlatform);
        if (flagHasPlatform)
          {
            handler.start_pair("Platform");
            if (storePlatform.in_known_list)
              {
                switch (storePlatform.list_value)
                  {
                    case TypePlatformKnownValues.Platform_Android:
                        handler.string_value("Android");
                        break;
                    case TypePlatformKnownValues.Platform_iOS:
                        handler.string_value("iOS");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePlatform.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasAppID);
        if (flagHasAppID)
          {
            handler.start_pair("AppID");
            handler.string_value(storeAppID);
          }
        Debug.Assert(partial_allowed || flagHasAliasMatched);
        if (flagHasAliasMatched)
          {
            handler.start_pair("AliasMatched");
            handler.boolean_value(storeAliasMatched);
          }
        if (flagHasPopularityMeasure)
          {
            handler.start_pair("PopularityMeasure");
            if (textStorePopularityMeasure != "")
                handler.number_value(textStorePopularityMeasure);
            else if (((double)(long)storePopularityMeasure) == storePopularityMeasure)
                handler.number_value((long)storePopularityMeasure);
            else
                handler.number_value(storePopularityMeasure);
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
        if (!(hasIndex()))
          {
            return "When parsing the object for %what%, the \"Index\" field was missing.";
          }
        if (!(hasPlatform()))
          {
            return "When parsing the object for %what%, the \"Platform\" field was missing.";
          }
        if (!(hasAppID()))
          {
            return "When parsing the object for %what%, the \"AppID\" field was missing.";
          }
        if (!(hasAliasMatched()))
          {
            return "When parsing the object for %what%, the \"AliasMatched\" field was missing.";
          }
        return null;
      }

    public static UserAppParsingItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserAppParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserAppParsingItem", ignore_extras);
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
    public static UserAppParsingItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserAppParsingItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserAppParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserAppParsingItem", ignore_extras);
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
    public static UserAppParsingItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserAppParsingItemJSON from_text(string text, bool ignore_extras)
      {
        UserAppParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserAppParsingItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserAppParsingItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserAppParsingItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserAppParsingItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserAppParsingItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIndex fieldGeneratorIndex;
    private abstract class FieldGeneratorPlatform : JSONStringGenerator
          {
            protected FieldGeneratorPlatform(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPlatform()
              {
              }
            protected override void handle_result(string result)
              {
                TypePlatformKnownValues known = stringToPlatform(result);
                TypePlatform new_value = new TypePlatform();
                if (known == TypePlatformKnownValues.Platform__none)
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
            protected abstract void handle_result(TypePlatform result);
          };
    private class FieldHoldingGeneratorPlatform : FieldGeneratorPlatform
  {
    protected override void handle_result(TypePlatform result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPlatform(String what)
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
    public TypePlatform value;
  };
    private class FieldHoldingArrayGeneratorPlatform : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPlatform
      {
        private FieldHoldingArrayGeneratorPlatform top;

        protected override void handle_result(TypePlatform result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPlatform init_top)
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
    protected virtual void handle_result(List<TypePlatform> result)
      {
      }

    public FieldHoldingArrayGeneratorPlatform(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlatform>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPlatform()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePlatform>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePlatform> value;
  };
        private FieldHoldingGeneratorPlatform fieldGeneratorPlatform;
        private JSONHoldingStringGenerator fieldGeneratorAppID;
        private JSONHoldingBooleanGenerator fieldGeneratorAliasMatched;
        private JSONHoldingNumberTextGenerator fieldGeneratorPopularityMeasure;
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
            UserAppParsingItemJSON result = new UserAppParsingItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserAppParsingItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserAppParsingItemJSON result)
          {
            if (fieldGeneratorIndex.have_value)
              {
                result.setIndex(fieldGeneratorIndex.value);
                fieldGeneratorIndex.have_value = false;
              }
            else if ((!(result.hasIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Index\" field was missing.");
              }
            if (fieldGeneratorPlatform.have_value)
              {
                result.setPlatform(fieldGeneratorPlatform.value);
                fieldGeneratorPlatform.have_value = false;
              }
            else if ((!(result.hasPlatform())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Platform\" field was missing.");
              }
            if (fieldGeneratorAppID.have_value)
              {
                result.setAppID(fieldGeneratorAppID.value);
                fieldGeneratorAppID.have_value = false;
              }
            else if ((!(result.hasAppID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AppID\" field was missing.");
              }
            if (fieldGeneratorAliasMatched.have_value)
              {
                result.setAliasMatched(fieldGeneratorAliasMatched.value);
                fieldGeneratorAliasMatched.have_value = false;
              }
            else if ((!(result.hasAliasMatched())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AliasMatched\" field was missing.");
              }
            if (fieldGeneratorPopularityMeasure.have_value)
              {
                result.setPopularityMeasureText(fieldGeneratorPopularityMeasure.value);
                fieldGeneratorPopularityMeasure.have_value = false;
              }
          }
        protected abstract void handle_result(UserAppParsingItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "iasMatched", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorAliasMatched;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "pID", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorAppID;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ndex", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorIndex;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "atform", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPlatform;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "pularityMeasure", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPopularityMeasure;
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
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the UserAppParsingItem class");
            fieldGeneratorPlatform = new FieldHoldingGeneratorPlatform("field \"Platform\" of the UserAppParsingItem class");
            fieldGeneratorAppID = new JSONHoldingStringGenerator("field \"AppID\" of the UserAppParsingItem class");
            fieldGeneratorAliasMatched = new JSONHoldingBooleanGenerator("field \"AliasMatched\" of the UserAppParsingItem class");
            fieldGeneratorPopularityMeasure = new JSONHoldingNumberTextGenerator("field \"PopularityMeasure\" of the UserAppParsingItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserAppParsingItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIndex = new FieldHoldingGeneratorIndex("field \"Index\" of the UserAppParsingItem class");
            fieldGeneratorPlatform = new FieldHoldingGeneratorPlatform("field \"Platform\" of the UserAppParsingItem class");
            fieldGeneratorAppID = new JSONHoldingStringGenerator("field \"AppID\" of the UserAppParsingItem class");
            fieldGeneratorAliasMatched = new JSONHoldingBooleanGenerator("field \"AliasMatched\" of the UserAppParsingItem class");
            fieldGeneratorPopularityMeasure = new JSONHoldingNumberTextGenerator("field \"PopularityMeasure\" of the UserAppParsingItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserAppParsingItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIndex.reset();
            fieldGeneratorPlatform.reset();
            fieldGeneratorAppID.reset();
            fieldGeneratorAliasMatched.reset();
            fieldGeneratorPopularityMeasure.reset();
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
        protected override void handle_result(UserAppParsingItemJSON  result)
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
        public UserAppParsingItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserAppParsingItemJSON  result)
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
    protected virtual void handle_result(List<UserAppParsingItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserAppParsingItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserAppParsingItemJSON>();
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
    public List<UserAppParsingItemJSON> value;
  };
  };
