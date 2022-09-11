/* file "HotelSearchConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HotelSearchConversationStateElementJSON : JSONBase
  {
    public enum TypeHotelKind
      {
        HotelKind_Hotel,
        HotelKind_ShowList
      };

    public static TypeHotelKind  stringToHotelKind(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "otel", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeHotelKind.HotelKind_Hotel;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "howList", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeHotelKind.HotelKind_ShowList;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `HotelKind' is not one of the legal values.");
      }

    public static string  stringFromHotelKind(TypeHotelKind the_enum)
      {
        switch (the_enum)
          {
            case TypeHotelKind.HotelKind_Hotel:
                return "Hotel";
            case TypeHotelKind.HotelKind_ShowList:
                return "ShowList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasHotelKind;
    private TypeHotelKind storeHotelKind;
    private bool flagHasHotelFilterSpec;
    private HotelFilterSpecJSON  storeHotelFilterSpec;
    private bool flagHasHotelSearchResults;
    private List< HotelJSON  > storeHotelSearchResults;
    private bool flagHasResultIndexReferenced;
    private BigInteger storeResultIndexReferenced;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHotelKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelKind of HotelSearchConversationStateElementJSON is not a string.");
        TypeHotelKind the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "otel", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeHotelKind.HotelKind_Hotel;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "howList", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeHotelKind.HotelKind_ShowList;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field HotelKind of HotelSearchConversationStateElementJSON is not one of the legal strings.");
      enum_is_done:;
        setHotelKind(the_enum);
      }


    private void  fromJSONHotelFilterSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelFilterSpecJSON convert_classy = HotelFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setHotelFilterSpec(convert_classy);
      }


    private void  fromJSONHotelSearchResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HotelSearchResults of HotelSearchConversationStateElementJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HotelJSON  > vector_HotelSearchResults1 = new List< HotelJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HotelJSON convert_classy = HotelJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HotelSearchResults1.Add(convert_classy);
          }
        initHotelSearchResults();
        for (int num1 = 0; num1 < vector_HotelSearchResults1.Count; ++num1)
            appendHotelSearchResults(vector_HotelSearchResults1[num1]);
        for (int num1 = 0; num1 < vector_HotelSearchResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResultIndexReferenced(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultIndexReferenced of HotelSearchConversationStateElementJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultIndexReferenced of HotelSearchConversationStateElementJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setResultIndexReferenced(extracted_integer);
      }


    public HotelSearchConversationStateElementJSON()
      {
        flagHasHotelKind = false;
        flagHasHotelFilterSpec = false;
        flagHasHotelSearchResults = false;
        flagHasResultIndexReferenced = false;
        storeHotelSearchResults = new List< HotelJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHotelKind()
      {
        return flagHasHotelKind;
      }

    public TypeHotelKind  getHotelKind()
      {
        Debug.Assert(flagHasHotelKind);
        return storeHotelKind;
      }

    public string  getHotelKindAsString()
      {
        return stringFromHotelKind(getHotelKind());
      }

    public bool  hasHotelFilterSpec()
      {
        return flagHasHotelFilterSpec;
      }

    public HotelFilterSpecJSON   getHotelFilterSpec()
      {
        Debug.Assert(flagHasHotelFilterSpec);
        return storeHotelFilterSpec;
      }

    public bool  hasHotelSearchResults()
      {
        return flagHasHotelSearchResults;
      }

    public int  countOfHotelSearchResults()
      {
        Debug.Assert(flagHasHotelSearchResults);
        return storeHotelSearchResults.Count;
      }

    public HotelJSON   elementOfHotelSearchResults(int element_num)
      {
        Debug.Assert(flagHasHotelSearchResults);
        return storeHotelSearchResults[element_num];
      }

    public List< HotelJSON  >  getHotelSearchResults()
      {
        Debug.Assert(flagHasHotelSearchResults);
        return storeHotelSearchResults;
      }

    public bool  hasResultIndexReferenced()
      {
        return flagHasResultIndexReferenced;
      }

    public BigInteger  getResultIndexReferenced()
      {
        Debug.Assert(flagHasResultIndexReferenced);
        return storeResultIndexReferenced;
      }


    public virtual int extraHotelSearchConversationStateElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHotelSearchConversationStateElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHotelSearchConversationStateElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHotelSearchConversationStateElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHotelKind(TypeHotelKind new_value)
      {
        flagHasHotelKind = true;
        storeHotelKind = new_value;
      }
    public void setHotelKind(string chars)
      {
        setHotelKind(stringToHotelKind(chars));
      }
    public void unsetHotelKind()
      {
        flagHasHotelKind = false;
      }
    public void setHotelFilterSpec(HotelFilterSpecJSON  new_value)
      {
        if (flagHasHotelFilterSpec)
          {
          }
        flagHasHotelFilterSpec = true;
        storeHotelFilterSpec = new_value;
      }
    public void unsetHotelFilterSpec()
      {
        if (flagHasHotelFilterSpec)
          {
          }
        flagHasHotelFilterSpec = false;
      }
    public void initHotelSearchResults()
      {
        if (flagHasHotelSearchResults)
          {
            for (int num1 = 0; num1 < storeHotelSearchResults.Count; ++num1)
              {
              }
          }
        flagHasHotelSearchResults = true;
        storeHotelSearchResults.Clear();
      }
    public void appendHotelSearchResults(HotelJSON  to_append)
      {
        if (!flagHasHotelSearchResults)
          {
            flagHasHotelSearchResults = true;
            storeHotelSearchResults.Clear();
          }
        Debug.Assert(flagHasHotelSearchResults);
        storeHotelSearchResults.Add(to_append);
      }
    public void unsetHotelSearchResults()
      {
        if (flagHasHotelSearchResults)
          {
            for (int num2 = 0; num2 < storeHotelSearchResults.Count; ++num2)
              {
              }
          }
        flagHasHotelSearchResults = false;
        storeHotelSearchResults.Clear();
      }
    public void setResultIndexReferenced(BigInteger new_value)
      {
        flagHasResultIndexReferenced = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultIndexReferenced of HotelSearchConversationStateElementJSON is less than the lower bound (0) for that field.");
        storeResultIndexReferenced = new_value;
      }
    public void unsetResultIndexReferenced()
      {
        flagHasResultIndexReferenced = false;
      }

    public virtual void extraHotelSearchConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHotelSearchConversationStateElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHotelSearchConversationStateElementLookup(key);
        if (old_field == null)
          {
            extraHotelSearchConversationStateElementAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHotelKind);
        if (flagHasHotelKind)
          {
            handler.start_pair("HotelKind");
            switch (storeHotelKind)
              {
                case TypeHotelKind.HotelKind_Hotel:
                    handler.string_value("Hotel");
                    break;
                case TypeHotelKind.HotelKind_ShowList:
                    handler.string_value("ShowList");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasHotelFilterSpec)
          {
            handler.start_pair("HotelFilterSpec");
            if (partial_allowed)
                storeHotelFilterSpec.write_partial_as_json(handler);
            else
                storeHotelFilterSpec.write_as_json(handler);
          }
        if (flagHasHotelSearchResults)
          {
            handler.start_pair("HotelSearchResults");
            handler.start_array();
            for (int num1 = 0; num1 < storeHotelSearchResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeHotelSearchResults[num1].write_partial_as_json(handler);
                else
                    storeHotelSearchResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasResultIndexReferenced)
          {
            handler.start_pair("ResultIndexReferenced");
            handler.number_value(storeResultIndexReferenced);
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
        if (!(hasHotelKind()))
          {
            return "When parsing the object for %what%, the \"HotelKind\" field was missing.";
          }
        return null;
      }

    public static HotelSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelSearchConversationStateElement", ignore_extras);
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
    public static HotelSearchConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelSearchConversationStateElement", ignore_extras);
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
    public static HotelSearchConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HotelSearchConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        HotelSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelSearchConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HotelSearchConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelSearchConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelSearchConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorHotelKind : JSONStringGenerator
          {
            protected FieldGeneratorHotelKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHotelKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToHotelKind(result));
              }
            protected abstract void handle_result(TypeHotelKind result);
          };
    private class FieldHoldingGeneratorHotelKind : FieldGeneratorHotelKind
  {
    protected override void handle_result(TypeHotelKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHotelKind(String what)
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
    public TypeHotelKind value;
  };
    private class FieldHoldingArrayGeneratorHotelKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHotelKind
      {
        private FieldHoldingArrayGeneratorHotelKind top;

        protected override void handle_result(TypeHotelKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHotelKind init_top)
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
    protected virtual void handle_result(List<TypeHotelKind> result)
      {
      }

    public FieldHoldingArrayGeneratorHotelKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHotelKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHotelKind> value;
  };
        private FieldHoldingGeneratorHotelKind fieldGeneratorHotelKind;
        private HotelFilterSpecJSON.HoldingGenerator fieldGeneratorHotelFilterSpec;
        private HotelJSON.HoldingArrayGenerator fieldGeneratorHotelSearchResults;
    private class FieldHoldingGeneratorResultIndexReferenced : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorResultIndexReferenced(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultIndexReferenced : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultIndexReferenced(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorResultIndexReferenced fieldGeneratorResultIndexReferenced;
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
            HotelSearchConversationStateElementJSON result = new HotelSearchConversationStateElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHotelSearchConversationStateElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HotelSearchConversationStateElementJSON result)
          {
            if (fieldGeneratorHotelKind.have_value)
              {
                result.setHotelKind(fieldGeneratorHotelKind.value);
                fieldGeneratorHotelKind.have_value = false;
              }
            else if ((!(result.hasHotelKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HotelKind\" field was missing.");
              }
            if (fieldGeneratorHotelFilterSpec.have_value)
              {
                result.setHotelFilterSpec(fieldGeneratorHotelFilterSpec.value);
                fieldGeneratorHotelFilterSpec.have_value = false;
              }
            if (fieldGeneratorHotelSearchResults.have_value)
              {
                result.initHotelSearchResults();
                int count = fieldGeneratorHotelSearchResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotelSearchResults(fieldGeneratorHotelSearchResults.value[num]);
                  }
                fieldGeneratorHotelSearchResults.value.Clear();
                fieldGeneratorHotelSearchResults.have_value = false;
              }
            if (fieldGeneratorResultIndexReferenced.have_value)
              {
                result.setResultIndexReferenced(fieldGeneratorResultIndexReferenced.value);
                fieldGeneratorResultIndexReferenced.have_value = false;
              }
          }
        protected abstract void handle_result(HotelSearchConversationStateElementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 6, "ilterSpec", 0, 9, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorHotelFilterSpec;
                                break;
                            case 'K':
                                if ((String.Compare(field_name, 6, "ind", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorHotelKind;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 6, "earchResults", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorHotelSearchResults;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultIndexReferenced", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorResultIndexReferenced;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHotelKind = new FieldHoldingGeneratorHotelKind("field \"HotelKind\" of the HotelSearchConversationStateElement class");
            fieldGeneratorHotelFilterSpec = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelFilterSpec\" of the HotelSearchConversationStateElement class", ignore_extras);
            fieldGeneratorHotelSearchResults = new HotelJSON.HoldingArrayGenerator("field \"HotelSearchResults\" of the HotelSearchConversationStateElement class", ignore_extras);
            fieldGeneratorResultIndexReferenced = new FieldHoldingGeneratorResultIndexReferenced("field \"ResultIndexReferenced\" of the HotelSearchConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HotelSearchConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHotelKind = new FieldHoldingGeneratorHotelKind("field \"HotelKind\" of the HotelSearchConversationStateElement class");
            fieldGeneratorHotelFilterSpec = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelFilterSpec\" of the HotelSearchConversationStateElement class", false);
            fieldGeneratorHotelSearchResults = new HotelJSON.HoldingArrayGenerator("field \"HotelSearchResults\" of the HotelSearchConversationStateElement class", false);
            fieldGeneratorResultIndexReferenced = new FieldHoldingGeneratorResultIndexReferenced("field \"ResultIndexReferenced\" of the HotelSearchConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HotelSearchConversationStateElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHotelKind.reset();
            fieldGeneratorHotelFilterSpec.reset();
            fieldGeneratorHotelSearchResults.reset();
            fieldGeneratorResultIndexReferenced.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHotelFilterSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHotelSearchResults.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHotelFilterSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHotelSearchResults.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HotelSearchConversationStateElementJSON  result)
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
        public HotelSearchConversationStateElementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelSearchConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<HotelSearchConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelSearchConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelSearchConversationStateElementJSON>();
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
    public List<HotelSearchConversationStateElementJSON> value;
  };
  };
