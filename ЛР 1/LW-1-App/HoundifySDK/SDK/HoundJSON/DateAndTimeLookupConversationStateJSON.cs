/* file "DateAndTimeLookupConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateAndTimeLookupConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_DateAndTimeLookup
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "DateAndTimeLookup", 0, 17, false) == 0) && (chars.Length == 17))
            return TypeDateAndTimeKind.DateAndTimeKind_DateAndTimeLookup;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_DateAndTimeLookup:
                return "DateAndTimeLookup";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDateAndOrTimeSpec;
    private bool flagHasComparisonRequested;
    private bool storeComparisonRequested;
    private bool flagHasComparisonDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeComparisonDateAndOrTimeSpec;
    private bool flagHasComparisonDateAndOrTimeSpecEnd;
    private DateAndOrTimeSpecJSON  storeComparisonDateAndOrTimeSpecEnd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of DateAndTimeLookupConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("DateAndTimeLookup")))
            throw new Exception("The value for field DateAndTimeKind of DateAndTimeLookupConversationStateJSON is not `DateAndTimeLookup'.");
        setDateAndTimeKind();
      }


    private void  fromJSONDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONComparisonRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ComparisonRequested of DateAndTimeLookupConversationStateJSON is not true for false.");
              }
          }
        setComparisonRequested(the_bool);
      }


    private void  fromJSONComparisonDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setComparisonDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONComparisonDateAndOrTimeSpecEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setComparisonDateAndOrTimeSpecEnd(convert_classy);
      }


    public DateAndTimeLookupConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasDateAndOrTimeSpec = false;
        flagHasComparisonRequested = false;
        flagHasComparisonDateAndOrTimeSpec = false;
        flagHasComparisonDateAndOrTimeSpecEnd = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDateAndTimeKind()
      {
        return flagHasDateAndTimeKind;
      }

    public TypeDateAndTimeKind  getDateAndTimeKind()
      {
        Debug.Assert(flagHasDateAndTimeKind);
        return TypeDateAndTimeKind.DateAndTimeKind_DateAndTimeLookup;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
      }

    public bool  hasDateAndOrTimeSpec()
      {
        return flagHasDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasDateAndOrTimeSpec);
        return storeDateAndOrTimeSpec;
      }

    public bool  hasComparisonRequested()
      {
        return flagHasComparisonRequested;
      }

    public bool  getComparisonRequested()
      {
        Debug.Assert(flagHasComparisonRequested);
        return storeComparisonRequested;
      }

    public bool  hasComparisonDateAndOrTimeSpec()
      {
        return flagHasComparisonDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getComparisonDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasComparisonDateAndOrTimeSpec);
        return storeComparisonDateAndOrTimeSpec;
      }

    public bool  hasComparisonDateAndOrTimeSpecEnd()
      {
        return flagHasComparisonDateAndOrTimeSpecEnd;
      }

    public DateAndOrTimeSpecJSON   getComparisonDateAndOrTimeSpecEnd()
      {
        Debug.Assert(flagHasComparisonDateAndOrTimeSpecEnd);
        return storeComparisonDateAndOrTimeSpecEnd;
      }


    public virtual int extraDateAndTimeLookupConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateAndTimeLookupConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateAndTimeLookupConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateAndTimeLookupConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDateAndTimeKind()
      {
        flagHasDateAndTimeKind = true;
      }
    public void setDateAndTimeKind(TypeDateAndTimeKind new_value)
      {
        setDateAndTimeKind();
      }
    public void setDateAndTimeKind(string chars)
      {
        setDateAndTimeKind(stringToDateAndTimeKind(chars));
      }
    public void unsetDateAndTimeKind()
      {
        flagHasDateAndTimeKind = false;
      }
    public void setDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = true;
        storeDateAndOrTimeSpec = new_value;
      }
    public void unsetDateAndOrTimeSpec()
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = false;
      }
    public void setComparisonRequested(bool new_value)
      {
        flagHasComparisonRequested = true;
        storeComparisonRequested = new_value;
      }
    public void unsetComparisonRequested()
      {
        flagHasComparisonRequested = false;
      }
    public void setComparisonDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasComparisonDateAndOrTimeSpec)
          {
          }
        flagHasComparisonDateAndOrTimeSpec = true;
        storeComparisonDateAndOrTimeSpec = new_value;
      }
    public void unsetComparisonDateAndOrTimeSpec()
      {
        if (flagHasComparisonDateAndOrTimeSpec)
          {
          }
        flagHasComparisonDateAndOrTimeSpec = false;
      }
    public void setComparisonDateAndOrTimeSpecEnd(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
          }
        flagHasComparisonDateAndOrTimeSpecEnd = true;
        storeComparisonDateAndOrTimeSpecEnd = new_value;
      }
    public void unsetComparisonDateAndOrTimeSpecEnd()
      {
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
          }
        flagHasComparisonDateAndOrTimeSpecEnd = false;
      }

    public virtual void extraDateAndTimeLookupConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateAndTimeLookupConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateAndTimeLookupConversationStateLookup(key);
        if (old_field == null)
          {
            extraDateAndTimeLookupConversationStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndTimeKind);
        if (flagHasDateAndTimeKind)
          {
            handler.start_pair("DateAndTimeKind");
            handler.string_value("DateAndTimeLookup");
          }
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpec);
        if (flagHasDateAndOrTimeSpec)
          {
            handler.start_pair("DateAndOrTimeSpec");
            if (partial_allowed)
                storeDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeDateAndOrTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasComparisonRequested);
        if (flagHasComparisonRequested)
          {
            handler.start_pair("ComparisonRequested");
            handler.boolean_value(storeComparisonRequested);
          }
        if (flagHasComparisonDateAndOrTimeSpec)
          {
            handler.start_pair("ComparisonDateAndOrTimeSpec");
            if (partial_allowed)
                storeComparisonDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeComparisonDateAndOrTimeSpec.write_as_json(handler);
          }
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
            handler.start_pair("ComparisonDateAndOrTimeSpecEnd");
            if (partial_allowed)
                storeComparisonDateAndOrTimeSpecEnd.write_partial_as_json(handler);
            else
                storeComparisonDateAndOrTimeSpecEnd.write_as_json(handler);
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
        if (!(hasDateAndTimeKind()))
          {
            return "When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.";
          }
        if (!(hasDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasComparisonRequested()))
          {
            return "When parsing the object for %what%, the \"ComparisonRequested\" field was missing.";
          }
        return null;
      }

    public static DateAndTimeLookupConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeLookupConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupConversationState", ignore_extras);
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
    public static DateAndTimeLookupConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateAndTimeLookupConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeLookupConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupConversationState", ignore_extras);
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
    public static DateAndTimeLookupConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateAndTimeLookupConversationStateJSON from_text(string text, bool ignore_extras)
      {
        DateAndTimeLookupConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndTimeLookupConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DateAndTimeLookupConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndTimeLookupConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorDateAndTimeKind : JSONStringGenerator
          {
            protected FieldGeneratorDateAndTimeKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDateAndTimeKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDateAndTimeKind(result));
              }
            protected abstract void handle_result(TypeDateAndTimeKind result);
          };
    private class FieldHoldingGeneratorDateAndTimeKind : FieldGeneratorDateAndTimeKind
  {
    protected override void handle_result(TypeDateAndTimeKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDateAndTimeKind(String what)
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
    public TypeDateAndTimeKind value;
  };
    private class FieldHoldingArrayGeneratorDateAndTimeKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDateAndTimeKind
      {
        private FieldHoldingArrayGeneratorDateAndTimeKind top;

        protected override void handle_result(TypeDateAndTimeKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDateAndTimeKind init_top)
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
    protected virtual void handle_result(List<TypeDateAndTimeKind> result)
      {
      }

    public FieldHoldingArrayGeneratorDateAndTimeKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDateAndTimeKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDateAndTimeKind> value;
  };
        private FieldHoldingGeneratorDateAndTimeKind fieldGeneratorDateAndTimeKind;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDateAndOrTimeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorComparisonRequested;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorComparisonDateAndOrTimeSpec;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorComparisonDateAndOrTimeSpecEnd;
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
            DateAndTimeLookupConversationStateJSON result = new DateAndTimeLookupConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndTimeLookupConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DateAndTimeLookupConversationStateJSON result)
          {
            if (fieldGeneratorDateAndTimeKind.have_value)
              {
                result.setDateAndTimeKind();
                fieldGeneratorDateAndTimeKind.have_value = false;
              }
            else if ((!(result.hasDateAndTimeKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.");
              }
            if (fieldGeneratorDateAndOrTimeSpec.have_value)
              {
                result.setDateAndOrTimeSpec(fieldGeneratorDateAndOrTimeSpec.value);
                fieldGeneratorDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.");
              }
            if (fieldGeneratorComparisonRequested.have_value)
              {
                result.setComparisonRequested(fieldGeneratorComparisonRequested.value);
                fieldGeneratorComparisonRequested.have_value = false;
              }
            else if ((!(result.hasComparisonRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ComparisonRequested\" field was missing.");
              }
            if (fieldGeneratorComparisonDateAndOrTimeSpec.have_value)
              {
                result.setComparisonDateAndOrTimeSpec(fieldGeneratorComparisonDateAndOrTimeSpec.value);
                fieldGeneratorComparisonDateAndOrTimeSpec.have_value = false;
              }
            if (fieldGeneratorComparisonDateAndOrTimeSpecEnd.have_value)
              {
                result.setComparisonDateAndOrTimeSpecEnd(fieldGeneratorComparisonDateAndOrTimeSpecEnd.value);
                fieldGeneratorComparisonDateAndOrTimeSpecEnd.have_value = false;
              }
          }
        protected abstract void handle_result(DateAndTimeLookupConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "omparison", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'D':
                                if (String.Compare(field_name, 11, "ateAndOrTimeSpec", 0, 16, false) == 0)
                                  {
                                    if (field_name.Length == 27)
                                      {
                                        return fieldGeneratorComparisonDateAndOrTimeSpec;
                                      }
                                    switch (field_name[27])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 28, "nd", 0, 2, false) == 0) && (field_name.Length == 30))
                                                return fieldGeneratorComparisonDateAndOrTimeSpecEnd;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 11, "equested", 0, 8, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorComparisonRequested;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "ateAnd", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'O':
                                if ((String.Compare(field_name, 8, "rTimeSpec", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorDateAndOrTimeSpec;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "imeKind", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDateAndTimeKind;
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
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the DateAndTimeLookupConversationState class");
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the DateAndTimeLookupConversationState class", ignore_extras);
            fieldGeneratorComparisonRequested = new JSONHoldingBooleanGenerator("field \"ComparisonRequested\" of the DateAndTimeLookupConversationState class");
            fieldGeneratorComparisonDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpec\" of the DateAndTimeLookupConversationState class", ignore_extras);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpecEnd\" of the DateAndTimeLookupConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateAndTimeLookupConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the DateAndTimeLookupConversationState class");
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the DateAndTimeLookupConversationState class", false);
            fieldGeneratorComparisonRequested = new JSONHoldingBooleanGenerator("field \"ComparisonRequested\" of the DateAndTimeLookupConversationState class");
            fieldGeneratorComparisonDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpec\" of the DateAndTimeLookupConversationState class", false);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpecEnd\" of the DateAndTimeLookupConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateAndTimeLookupConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorDateAndOrTimeSpec.reset();
            fieldGeneratorComparisonRequested.reset();
            fieldGeneratorComparisonDateAndOrTimeSpec.reset();
            fieldGeneratorComparisonDateAndOrTimeSpecEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateAndOrTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorComparisonDateAndOrTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateAndOrTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorComparisonDateAndOrTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DateAndTimeLookupConversationStateJSON  result)
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
        public DateAndTimeLookupConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndTimeLookupConversationStateJSON  result)
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
    protected virtual void handle_result(List<DateAndTimeLookupConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndTimeLookupConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndTimeLookupConversationStateJSON>();
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
    public List<DateAndTimeLookupConversationStateJSON> value;
  };
  };
