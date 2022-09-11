/* file "DateTimeRangeSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateTimeRangeSpecJSON : JSONBase
  {
    private bool flagHasStartDateTimeSpec;
    private DateTimeSpecJSON  storeStartDateTimeSpec;
    private bool flagHasEndDateTimeSpec;
    private DateTimeSpecJSON  storeEndDateTimeSpec;
    private bool flagHasStartDateTimeInferred;
    private bool storeStartDateTimeInferred;
    private bool flagHasEndDateTimeInferred;
    private bool storeEndDateTimeInferred;
    private bool flagHasRangeIsExplicit;
    private bool storeRangeIsExplicit;
    private bool flagHasExpressedAsDuration;
    private bool storeExpressedAsDuration;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStartDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setStartDateTimeSpec(convert_classy);
      }


    private void  fromJSONEndDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setEndDateTimeSpec(convert_classy);
      }


    private void  fromJSONStartDateTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartDateTimeInferred of DateTimeRangeSpecJSON is not true for false.");
              }
          }
        setStartDateTimeInferred(the_bool);
      }


    private void  fromJSONEndDateTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EndDateTimeInferred of DateTimeRangeSpecJSON is not true for false.");
              }
          }
        setEndDateTimeInferred(the_bool);
      }


    private void  fromJSONRangeIsExplicit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RangeIsExplicit of DateTimeRangeSpecJSON is not true for false.");
              }
          }
        setRangeIsExplicit(the_bool);
      }


    private void  fromJSONExpressedAsDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExpressedAsDuration of DateTimeRangeSpecJSON is not true for false.");
              }
          }
        setExpressedAsDuration(the_bool);
      }


    public DateTimeRangeSpecJSON()
      {
        flagHasStartDateTimeSpec = false;
        flagHasEndDateTimeSpec = false;
        flagHasStartDateTimeInferred = false;
        flagHasEndDateTimeInferred = false;
        flagHasRangeIsExplicit = false;
        flagHasExpressedAsDuration = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStartDateTimeSpec()
      {
        return flagHasStartDateTimeSpec;
      }

    public DateTimeSpecJSON   getStartDateTimeSpec()
      {
        Debug.Assert(flagHasStartDateTimeSpec);
        return storeStartDateTimeSpec;
      }

    public bool  hasEndDateTimeSpec()
      {
        return flagHasEndDateTimeSpec;
      }

    public DateTimeSpecJSON   getEndDateTimeSpec()
      {
        Debug.Assert(flagHasEndDateTimeSpec);
        return storeEndDateTimeSpec;
      }

    public bool  hasStartDateTimeInferred()
      {
        return flagHasStartDateTimeInferred;
      }

    public bool  getStartDateTimeInferred()
      {
        Debug.Assert(flagHasStartDateTimeInferred);
        return storeStartDateTimeInferred;
      }

    public bool  hasEndDateTimeInferred()
      {
        return flagHasEndDateTimeInferred;
      }

    public bool  getEndDateTimeInferred()
      {
        Debug.Assert(flagHasEndDateTimeInferred);
        return storeEndDateTimeInferred;
      }

    public bool  hasRangeIsExplicit()
      {
        return flagHasRangeIsExplicit;
      }

    public bool  getRangeIsExplicit()
      {
        Debug.Assert(flagHasRangeIsExplicit);
        return storeRangeIsExplicit;
      }

    public bool  hasExpressedAsDuration()
      {
        return flagHasExpressedAsDuration;
      }

    public bool  getExpressedAsDuration()
      {
        Debug.Assert(flagHasExpressedAsDuration);
        return storeExpressedAsDuration;
      }


    public virtual int extraDateTimeRangeSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateTimeRangeSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateTimeRangeSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateTimeRangeSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStartDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasStartDateTimeSpec)
          {
          }
        flagHasStartDateTimeSpec = true;
        storeStartDateTimeSpec = new_value;
      }
    public void unsetStartDateTimeSpec()
      {
        if (flagHasStartDateTimeSpec)
          {
          }
        flagHasStartDateTimeSpec = false;
      }
    public void setEndDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasEndDateTimeSpec)
          {
          }
        flagHasEndDateTimeSpec = true;
        storeEndDateTimeSpec = new_value;
      }
    public void unsetEndDateTimeSpec()
      {
        if (flagHasEndDateTimeSpec)
          {
          }
        flagHasEndDateTimeSpec = false;
      }
    public void setStartDateTimeInferred(bool new_value)
      {
        flagHasStartDateTimeInferred = true;
        storeStartDateTimeInferred = new_value;
      }
    public void unsetStartDateTimeInferred()
      {
        flagHasStartDateTimeInferred = false;
      }
    public void setEndDateTimeInferred(bool new_value)
      {
        flagHasEndDateTimeInferred = true;
        storeEndDateTimeInferred = new_value;
      }
    public void unsetEndDateTimeInferred()
      {
        flagHasEndDateTimeInferred = false;
      }
    public void setRangeIsExplicit(bool new_value)
      {
        flagHasRangeIsExplicit = true;
        storeRangeIsExplicit = new_value;
      }
    public void unsetRangeIsExplicit()
      {
        flagHasRangeIsExplicit = false;
      }
    public void setExpressedAsDuration(bool new_value)
      {
        flagHasExpressedAsDuration = true;
        storeExpressedAsDuration = new_value;
      }
    public void unsetExpressedAsDuration()
      {
        flagHasExpressedAsDuration = false;
      }

    public virtual void extraDateTimeRangeSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateTimeRangeSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateTimeRangeSpecLookup(key);
        if (old_field == null)
          {
            extraDateTimeRangeSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStartDateTimeSpec);
        if (flagHasStartDateTimeSpec)
          {
            handler.start_pair("StartDateTimeSpec");
            if (partial_allowed)
                storeStartDateTimeSpec.write_partial_as_json(handler);
            else
                storeStartDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDateTimeSpec);
        if (flagHasEndDateTimeSpec)
          {
            handler.start_pair("EndDateTimeSpec");
            if (partial_allowed)
                storeEndDateTimeSpec.write_partial_as_json(handler);
            else
                storeEndDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStartDateTimeInferred);
        if (flagHasStartDateTimeInferred)
          {
            handler.start_pair("StartDateTimeInferred");
            handler.boolean_value(storeStartDateTimeInferred);
          }
        Debug.Assert(partial_allowed || flagHasEndDateTimeInferred);
        if (flagHasEndDateTimeInferred)
          {
            handler.start_pair("EndDateTimeInferred");
            handler.boolean_value(storeEndDateTimeInferred);
          }
        Debug.Assert(partial_allowed || flagHasRangeIsExplicit);
        if (flagHasRangeIsExplicit)
          {
            handler.start_pair("RangeIsExplicit");
            handler.boolean_value(storeRangeIsExplicit);
          }
        Debug.Assert(partial_allowed || flagHasExpressedAsDuration);
        if (flagHasExpressedAsDuration)
          {
            handler.start_pair("ExpressedAsDuration");
            handler.boolean_value(storeExpressedAsDuration);
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
        if (!(hasStartDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"StartDateTimeSpec\" field was missing.";
          }
        if (!(hasEndDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"EndDateTimeSpec\" field was missing.";
          }
        if (!(hasStartDateTimeInferred()))
          {
            return "When parsing the object for %what%, the \"StartDateTimeInferred\" field was missing.";
          }
        if (!(hasEndDateTimeInferred()))
          {
            return "When parsing the object for %what%, the \"EndDateTimeInferred\" field was missing.";
          }
        if (!(hasRangeIsExplicit()))
          {
            return "When parsing the object for %what%, the \"RangeIsExplicit\" field was missing.";
          }
        if (!(hasExpressedAsDuration()))
          {
            return "When parsing the object for %what%, the \"ExpressedAsDuration\" field was missing.";
          }
        return null;
      }

    public static DateTimeRangeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeRangeSpec", ignore_extras);
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
    public static DateTimeRangeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateTimeRangeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeRangeSpec", ignore_extras);
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
    public static DateTimeRangeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateTimeRangeSpecJSON from_text(string text, bool ignore_extras)
      {
        DateTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeRangeSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateTimeRangeSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DateTimeRangeSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeRangeSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorStartDateTimeSpec;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorEndDateTimeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorStartDateTimeInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorEndDateTimeInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorRangeIsExplicit;
        private JSONHoldingBooleanGenerator fieldGeneratorExpressedAsDuration;
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
            DateTimeRangeSpecJSON result = new DateTimeRangeSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateTimeRangeSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DateTimeRangeSpecJSON result)
          {
            if (fieldGeneratorStartDateTimeSpec.have_value)
              {
                result.setStartDateTimeSpec(fieldGeneratorStartDateTimeSpec.value);
                fieldGeneratorStartDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasStartDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorEndDateTimeSpec.have_value)
              {
                result.setEndDateTimeSpec(fieldGeneratorEndDateTimeSpec.value);
                fieldGeneratorEndDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasEndDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorStartDateTimeInferred.have_value)
              {
                result.setStartDateTimeInferred(fieldGeneratorStartDateTimeInferred.value);
                fieldGeneratorStartDateTimeInferred.have_value = false;
              }
            else if ((!(result.hasStartDateTimeInferred())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateTimeInferred\" field was missing.");
              }
            if (fieldGeneratorEndDateTimeInferred.have_value)
              {
                result.setEndDateTimeInferred(fieldGeneratorEndDateTimeInferred.value);
                fieldGeneratorEndDateTimeInferred.have_value = false;
              }
            else if ((!(result.hasEndDateTimeInferred())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateTimeInferred\" field was missing.");
              }
            if (fieldGeneratorRangeIsExplicit.have_value)
              {
                result.setRangeIsExplicit(fieldGeneratorRangeIsExplicit.value);
                fieldGeneratorRangeIsExplicit.have_value = false;
              }
            else if ((!(result.hasRangeIsExplicit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RangeIsExplicit\" field was missing.");
              }
            if (fieldGeneratorExpressedAsDuration.have_value)
              {
                result.setExpressedAsDuration(fieldGeneratorExpressedAsDuration.value);
                fieldGeneratorExpressedAsDuration.have_value = false;
              }
            else if ((!(result.hasExpressedAsDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExpressedAsDuration\" field was missing.");
              }
          }
        protected abstract void handle_result(DateTimeRangeSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "dDateTime", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 12, "nferred", 0, 7, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorEndDateTimeInferred;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 12, "pec", 0, 3, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorEndDateTimeSpec;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'x':
                            if ((String.Compare(field_name, 2, "pressedAsDuration", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorExpressedAsDuration;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "angeIsExplicit", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRangeIsExplicit;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tartDateTime", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 14, "nferred", 0, 7, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorStartDateTimeInferred;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 14, "pec", 0, 3, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorStartDateTimeSpec;
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
            fieldGeneratorStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"StartDateTimeSpec\" of the DateTimeRangeSpec class", ignore_extras);
            fieldGeneratorEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"EndDateTimeSpec\" of the DateTimeRangeSpec class", ignore_extras);
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateTimeRangeSpec class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateTimeRangeSpec class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateTimeRangeSpec class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateTimeRangeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateTimeRangeSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"StartDateTimeSpec\" of the DateTimeRangeSpec class", false);
            fieldGeneratorEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"EndDateTimeSpec\" of the DateTimeRangeSpec class", false);
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateTimeRangeSpec class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateTimeRangeSpec class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateTimeRangeSpec class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateTimeRangeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateTimeRangeSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartDateTimeSpec.reset();
            fieldGeneratorEndDateTimeSpec.reset();
            fieldGeneratorStartDateTimeInferred.reset();
            fieldGeneratorEndDateTimeInferred.reset();
            fieldGeneratorRangeIsExplicit.reset();
            fieldGeneratorExpressedAsDuration.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DateTimeRangeSpecJSON  result)
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
        public DateTimeRangeSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateTimeRangeSpecJSON  result)
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
    protected virtual void handle_result(List<DateTimeRangeSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateTimeRangeSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateTimeRangeSpecJSON>();
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
    public List<DateTimeRangeSpecJSON> value;
  };
  };
