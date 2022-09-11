/* file "CalendarQueryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarQueryJSON : JSONBase
  {
    public enum TypeSelectionTarget
      {
        SelectionTarget_First,
        SelectionTarget_Last,
        SelectionTarget_All
      };

    public static TypeSelectionTarget  stringToSelectionTarget(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ll", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeSelectionTarget.SelectionTarget_All;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "irst", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSelectionTarget.SelectionTarget_First;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ast", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSelectionTarget.SelectionTarget_Last;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SelectionTarget' is not one of the legal values.");
      }

    public static string  stringFromSelectionTarget(TypeSelectionTarget the_enum)
      {
        switch (the_enum)
          {
            case TypeSelectionTarget.SelectionTarget_First:
                return "First";
            case TypeSelectionTarget.SelectionTarget_Last:
                return "Last";
            case TypeSelectionTarget.SelectionTarget_All:
                return "All";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeRecurringTarget
      {
        RecurringTarget_SpecifiedOnly,
        RecurringTarget_AllFollowing
      };

    public static TypeRecurringTarget  stringToRecurringTarget(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "llFollowing", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeRecurringTarget.RecurringTarget_AllFollowing;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "pecifiedOnly", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeRecurringTarget.RecurringTarget_SpecifiedOnly;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `RecurringTarget' is not one of the legal values.");
      }

    public static string  stringFromRecurringTarget(TypeRecurringTarget the_enum)
      {
        switch (the_enum)
          {
            case TypeRecurringTarget.RecurringTarget_SpecifiedOnly:
                return "SpecifiedOnly";
            case TypeRecurringTarget.RecurringTarget_AllFollowing:
                return "AllFollowing";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeStartTimeRangeJSON : JSONBase
      {
        private bool flagHasRangeStart;
        private DateAndOrTimeJSON  storeRangeStart;
        private bool flagHasRangeEnd;
        private DateAndOrTimeJSON  storeRangeEnd;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRangeStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setRangeStart(convert_classy);
          }


        private void  fromJSONRangeEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setRangeEnd(convert_classy);
          }


        public TypeStartTimeRangeJSON()
          {
            flagHasRangeStart = false;
            flagHasRangeEnd = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasRangeStart()
          {
            return flagHasRangeStart;
          }

        public DateAndOrTimeJSON   getRangeStart()
          {
            Debug.Assert(flagHasRangeStart);
            return storeRangeStart;
          }

        public bool  hasRangeEnd()
          {
            return flagHasRangeEnd;
          }

        public DateAndOrTimeJSON   getRangeEnd()
          {
            Debug.Assert(flagHasRangeEnd);
            return storeRangeEnd;
          }


        public virtual int extraTypeStartTimeRangeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStartTimeRangeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStartTimeRangeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStartTimeRangeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setRangeStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasRangeStart)
              {
              }
            flagHasRangeStart = true;
            storeRangeStart = new_value;
          }
        public void unsetRangeStart()
          {
            if (flagHasRangeStart)
              {
              }
            flagHasRangeStart = false;
          }
        public void setRangeEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasRangeEnd)
              {
              }
            flagHasRangeEnd = true;
            storeRangeEnd = new_value;
          }
        public void unsetRangeEnd()
          {
            if (flagHasRangeEnd)
              {
              }
            flagHasRangeEnd = false;
          }

        public virtual void extraTypeStartTimeRangeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStartTimeRangeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStartTimeRangeLookup(key);
            if (old_field == null)
              {
                extraTypeStartTimeRangeAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasRangeStart);
            if (flagHasRangeStart)
              {
                handler.start_pair("RangeStart");
                if (partial_allowed)
                    storeRangeStart.write_partial_as_json(handler);
                else
                    storeRangeStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasRangeEnd);
            if (flagHasRangeEnd)
              {
                handler.start_pair("RangeEnd");
                if (partial_allowed)
                    storeRangeEnd.write_partial_as_json(handler);
                else
                    storeRangeEnd.write_as_json(handler);
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
            if (!(hasRangeStart()))
              {
                return "When parsing the object for %what%, the \"RangeStart\" field was missing.";
              }
            if (!(hasRangeEnd()))
              {
                return "When parsing the object for %what%, the \"RangeEnd\" field was missing.";
              }
            return null;
          }

        public static TypeStartTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStartTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStartTimeRange", ignore_extras);
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
        public static TypeStartTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStartTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStartTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStartTimeRange", ignore_extras);
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
        public static TypeStartTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStartTimeRangeJSON from_text(string text, bool ignore_extras)
          {
            TypeStartTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStartTimeRange", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStartTimeRangeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStartTimeRangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStartTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStartTimeRange", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRangeStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRangeEnd;
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
                TypeStartTimeRangeJSON result = new TypeStartTimeRangeJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStartTimeRangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStartTimeRangeJSON result)
              {
                if (fieldGeneratorRangeStart.have_value)
                  {
                    result.setRangeStart(fieldGeneratorRangeStart.value);
                    fieldGeneratorRangeStart.have_value = false;
                  }
                else if ((!(result.hasRangeStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RangeStart\" field was missing.");
                  }
                if (fieldGeneratorRangeEnd.have_value)
                  {
                    result.setRangeEnd(fieldGeneratorRangeEnd.value);
                    fieldGeneratorRangeEnd.have_value = false;
                  }
                else if ((!(result.hasRangeEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RangeEnd\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeStartTimeRangeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Range", 0, 5, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'E':
                            if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorRangeEnd;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorRangeStart;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRangeStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeStart\" of the TypeStartTimeRange class", ignore_extras);
                fieldGeneratorRangeEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeEnd\" of the TypeStartTimeRange class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStartTimeRange class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRangeStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeStart\" of the TypeStartTimeRange class", false);
                fieldGeneratorRangeEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeEnd\" of the TypeStartTimeRange class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStartTimeRange class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRangeStart.reset();
                fieldGeneratorRangeEnd.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorRangeStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorRangeEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorRangeStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorRangeEnd.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeStartTimeRangeJSON  result)
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
            public TypeStartTimeRangeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStartTimeRangeJSON  result)
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
        protected virtual void handle_result(List<TypeStartTimeRangeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStartTimeRangeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStartTimeRangeJSON>();
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
        public List<TypeStartTimeRangeJSON> value;
      };
      };
    public class TypeEndTimeRangeJSON : JSONBase
      {
        private bool flagHasRangeStart;
        private DateAndOrTimeJSON  storeRangeStart;
        private bool flagHasRangeEnd;
        private DateAndOrTimeJSON  storeRangeEnd;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRangeStart(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setRangeStart(convert_classy);
          }


        private void  fromJSONRangeEnd(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setRangeEnd(convert_classy);
          }


        public TypeEndTimeRangeJSON()
          {
            flagHasRangeStart = false;
            flagHasRangeEnd = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasRangeStart()
          {
            return flagHasRangeStart;
          }

        public DateAndOrTimeJSON   getRangeStart()
          {
            Debug.Assert(flagHasRangeStart);
            return storeRangeStart;
          }

        public bool  hasRangeEnd()
          {
            return flagHasRangeEnd;
          }

        public DateAndOrTimeJSON   getRangeEnd()
          {
            Debug.Assert(flagHasRangeEnd);
            return storeRangeEnd;
          }


        public virtual int extraTypeEndTimeRangeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEndTimeRangeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEndTimeRangeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEndTimeRangeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setRangeStart(DateAndOrTimeJSON  new_value)
          {
            if (flagHasRangeStart)
              {
              }
            flagHasRangeStart = true;
            storeRangeStart = new_value;
          }
        public void unsetRangeStart()
          {
            if (flagHasRangeStart)
              {
              }
            flagHasRangeStart = false;
          }
        public void setRangeEnd(DateAndOrTimeJSON  new_value)
          {
            if (flagHasRangeEnd)
              {
              }
            flagHasRangeEnd = true;
            storeRangeEnd = new_value;
          }
        public void unsetRangeEnd()
          {
            if (flagHasRangeEnd)
              {
              }
            flagHasRangeEnd = false;
          }

        public virtual void extraTypeEndTimeRangeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEndTimeRangeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEndTimeRangeLookup(key);
            if (old_field == null)
              {
                extraTypeEndTimeRangeAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasRangeStart);
            if (flagHasRangeStart)
              {
                handler.start_pair("RangeStart");
                if (partial_allowed)
                    storeRangeStart.write_partial_as_json(handler);
                else
                    storeRangeStart.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasRangeEnd);
            if (flagHasRangeEnd)
              {
                handler.start_pair("RangeEnd");
                if (partial_allowed)
                    storeRangeEnd.write_partial_as_json(handler);
                else
                    storeRangeEnd.write_as_json(handler);
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
            if (!(hasRangeStart()))
              {
                return "When parsing the object for %what%, the \"RangeStart\" field was missing.";
              }
            if (!(hasRangeEnd()))
              {
                return "When parsing the object for %what%, the \"RangeEnd\" field was missing.";
              }
            return null;
          }

        public static TypeEndTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEndTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEndTimeRange", ignore_extras);
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
        public static TypeEndTimeRangeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEndTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEndTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEndTimeRange", ignore_extras);
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
        public static TypeEndTimeRangeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEndTimeRangeJSON from_text(string text, bool ignore_extras)
          {
            TypeEndTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEndTimeRange", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEndTimeRangeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEndTimeRangeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEndTimeRangeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEndTimeRange", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRangeStart;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRangeEnd;
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
                TypeEndTimeRangeJSON result = new TypeEndTimeRangeJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEndTimeRangeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEndTimeRangeJSON result)
              {
                if (fieldGeneratorRangeStart.have_value)
                  {
                    result.setRangeStart(fieldGeneratorRangeStart.value);
                    fieldGeneratorRangeStart.have_value = false;
                  }
                else if ((!(result.hasRangeStart())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RangeStart\" field was missing.");
                  }
                if (fieldGeneratorRangeEnd.have_value)
                  {
                    result.setRangeEnd(fieldGeneratorRangeEnd.value);
                    fieldGeneratorRangeEnd.have_value = false;
                  }
                else if ((!(result.hasRangeEnd())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RangeEnd\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEndTimeRangeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Range", 0, 5, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'E':
                            if ((String.Compare(field_name, 6, "nd", 0, 2, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorRangeEnd;
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 6, "tart", 0, 4, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorRangeStart;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRangeStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeStart\" of the TypeEndTimeRange class", ignore_extras);
                fieldGeneratorRangeEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeEnd\" of the TypeEndTimeRange class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEndTimeRange class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRangeStart = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeStart\" of the TypeEndTimeRange class", false);
                fieldGeneratorRangeEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"RangeEnd\" of the TypeEndTimeRange class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEndTimeRange class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRangeStart.reset();
                fieldGeneratorRangeEnd.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorRangeStart.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorRangeEnd.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorRangeStart.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorRangeEnd.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeEndTimeRangeJSON  result)
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
            public TypeEndTimeRangeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEndTimeRangeJSON  result)
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
        protected virtual void handle_result(List<TypeEndTimeRangeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEndTimeRangeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEndTimeRangeJSON>();
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
        public List<TypeEndTimeRangeJSON> value;
      };
      };
    public enum TypeSelfAttendeeStatus
      {
        SelfAttendeeStatus_None,
        SelfAttendeeStatus_Accepted,
        SelfAttendeeStatus_Declined,
        SelfAttendeeStatus_Invited,
        SelfAttendeeStatus_Tentative
      };

    public static TypeSelfAttendeeStatus  stringToSelfAttendeeStatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ccepted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "eclined", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nvited", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "entative", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SelfAttendeeStatus' is not one of the legal values.");
      }

    public static string  stringFromSelfAttendeeStatus(TypeSelfAttendeeStatus the_enum)
      {
        switch (the_enum)
          {
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                return "None";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                return "Accepted";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                return "Declined";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                return "Invited";
            case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                return "Tentative";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSelectionTarget;
    private TypeSelectionTarget storeSelectionTarget;
    private bool flagHasRecurringTarget;
    private TypeRecurringTarget storeRecurringTarget;
    private bool flagHasExactCalendarName;
    private string storeExactCalendarName;
    private bool flagHasPartialCalendarName;
    private string storePartialCalendarName;
    private bool flagHasCalendarIDs;
    private List< string > storeCalendarIDs;
    private bool flagHasItemType;
    private string storeItemType;
    private bool flagHasExactTitle;
    private string storeExactTitle;
    private bool flagHasPartialTitle;
    private string storePartialTitle;
    private bool flagHasExactLocation;
    private string storeExactLocation;
    private bool flagHasPartialLocation;
    private string storePartialLocation;
    private bool flagHasLocationSpecifier;
    private CalendarLocationJSON  storeLocationSpecifier;
    private bool flagHasStartTimeRange;
    private TypeStartTimeRangeJSON  storeStartTimeRange;
    private bool flagHasEndTimeRange;
    private TypeEndTimeRangeJSON  storeEndTimeRange;
    private bool flagHasIsRecurring;
    private bool storeIsRecurring;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasAttendees;
    private List< string > storeAttendees;
    private bool flagHasSelfAttendeeStatus;
    private TypeSelfAttendeeStatus storeSelfAttendeeStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSelectionTarget(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelectionTarget of CalendarQueryJSON is not a string.");
        TypeSelectionTarget the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ll", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeSelectionTarget.SelectionTarget_All;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "irst", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeSelectionTarget.SelectionTarget_First;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSelectionTarget.SelectionTarget_Last;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field SelectionTarget of CalendarQueryJSON is not one of the legal strings.");
      enum_is_done:;
        setSelectionTarget(the_enum);
      }


    private void  fromJSONRecurringTarget(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RecurringTarget of CalendarQueryJSON is not a string.");
        TypeRecurringTarget the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "llFollowing", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeRecurringTarget.RecurringTarget_AllFollowing;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "pecifiedOnly", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeRecurringTarget.RecurringTarget_SpecifiedOnly;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field RecurringTarget of CalendarQueryJSON is not one of the legal strings.");
      enum_is_done:;
        setRecurringTarget(the_enum);
      }


    private void  fromJSONExactCalendarName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactCalendarName of CalendarQueryJSON is not a string.");
        setExactCalendarName(json_string.getData());
      }


    private void  fromJSONPartialCalendarName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialCalendarName of CalendarQueryJSON is not a string.");
        setPartialCalendarName(json_string.getData());
      }


    private void  fromJSONCalendarIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CalendarIDs of CalendarQueryJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field CalendarIDs of CalendarQueryJSON has too few elements.");
        List< string > vector_CalendarIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CalendarIDs of CalendarQueryJSON is not a string.");
            vector_CalendarIDs1.Add(json_string.getData());
          }
        Debug.Assert(vector_CalendarIDs1.Count >= 1);
        initCalendarIDs();
        for (int num1 = 0; num1 < vector_CalendarIDs1.Count; ++num1)
            appendCalendarIDs(vector_CalendarIDs1[num1]);
        for (int num1 = 0; num1 < vector_CalendarIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONItemType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemType of CalendarQueryJSON is not a string.");
        setItemType(json_string.getData());
      }


    private void  fromJSONExactTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactTitle of CalendarQueryJSON is not a string.");
        setExactTitle(json_string.getData());
      }


    private void  fromJSONPartialTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialTitle of CalendarQueryJSON is not a string.");
        setPartialTitle(json_string.getData());
      }


    private void  fromJSONExactLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExactLocation of CalendarQueryJSON is not a string.");
        setExactLocation(json_string.getData());
      }


    private void  fromJSONPartialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PartialLocation of CalendarQueryJSON is not a string.");
        setPartialLocation(json_string.getData());
      }


    private void  fromJSONLocationSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarLocationJSON convert_classy = CalendarLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationSpecifier(convert_classy);
      }


    private void  fromJSONStartTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeStartTimeRangeJSON convert_classy = TypeStartTimeRangeJSON.from_json(json_value, ignore_extras, true);
        setStartTimeRange(convert_classy);
      }


    private void  fromJSONEndTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeEndTimeRangeJSON convert_classy = TypeEndTimeRangeJSON.from_json(json_value, ignore_extras, true);
        setEndTimeRange(convert_classy);
      }


    private void  fromJSONIsRecurring(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRecurring of CalendarQueryJSON is not true for false.");
              }
          }
        setIsRecurring(the_bool);
      }


    private void  fromJSONIsAllDay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAllDay of CalendarQueryJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONAttendees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attendees of CalendarQueryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Attendees1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Attendees of CalendarQueryJSON is not a string.");
            vector_Attendees1.Add(json_string.getData());
          }
        initAttendees();
        for (int num2 = 0; num2 < vector_Attendees1.Count; ++num2)
            appendAttendees(vector_Attendees1[num2]);
        for (int num1 = 0; num1 < vector_Attendees1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSelfAttendeeStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SelfAttendeeStatus of CalendarQueryJSON is not a string.");
        TypeSelfAttendeeStatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ccepted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "eclined", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nvited", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_None;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "entative", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field SelfAttendeeStatus of CalendarQueryJSON is not one of the legal strings.");
      enum_is_done:;
        setSelfAttendeeStatus(the_enum);
      }


    public CalendarQueryJSON()
      {
        flagHasSelectionTarget = false;
        flagHasRecurringTarget = false;
        flagHasExactCalendarName = false;
        flagHasPartialCalendarName = false;
        flagHasCalendarIDs = false;
        flagHasItemType = false;
        flagHasExactTitle = false;
        flagHasPartialTitle = false;
        flagHasExactLocation = false;
        flagHasPartialLocation = false;
        flagHasLocationSpecifier = false;
        flagHasStartTimeRange = false;
        flagHasEndTimeRange = false;
        flagHasIsRecurring = false;
        flagHasIsAllDay = false;
        flagHasAttendees = false;
        flagHasSelfAttendeeStatus = false;
        storeCalendarIDs = new List< string >();
        storeAttendees = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSelectionTarget()
      {
        return flagHasSelectionTarget;
      }

    public TypeSelectionTarget  getSelectionTarget()
      {
        Debug.Assert(flagHasSelectionTarget);
        return storeSelectionTarget;
      }

    public string  getSelectionTargetAsString()
      {
        return stringFromSelectionTarget(getSelectionTarget());
      }

    public bool  hasRecurringTarget()
      {
        return flagHasRecurringTarget;
      }

    public TypeRecurringTarget  getRecurringTarget()
      {
        Debug.Assert(flagHasRecurringTarget);
        return storeRecurringTarget;
      }

    public string  getRecurringTargetAsString()
      {
        return stringFromRecurringTarget(getRecurringTarget());
      }

    public bool  hasExactCalendarName()
      {
        return flagHasExactCalendarName;
      }

    public string  getExactCalendarName()
      {
        Debug.Assert(flagHasExactCalendarName);
        return storeExactCalendarName;
      }

    public bool  hasPartialCalendarName()
      {
        return flagHasPartialCalendarName;
      }

    public string  getPartialCalendarName()
      {
        Debug.Assert(flagHasPartialCalendarName);
        return storePartialCalendarName;
      }

    public bool  hasCalendarIDs()
      {
        return flagHasCalendarIDs;
      }

    public int  countOfCalendarIDs()
      {
        Debug.Assert(flagHasCalendarIDs);
        return storeCalendarIDs.Count;
      }

    public string  elementOfCalendarIDs(int element_num)
      {
        Debug.Assert(flagHasCalendarIDs);
        return storeCalendarIDs[element_num];
      }

    public List< string >  getCalendarIDs()
      {
        Debug.Assert(flagHasCalendarIDs);
        return storeCalendarIDs;
      }

    public bool  hasItemType()
      {
        return flagHasItemType;
      }

    public string  getItemType()
      {
        Debug.Assert(flagHasItemType);
        return storeItemType;
      }

    public bool  hasExactTitle()
      {
        return flagHasExactTitle;
      }

    public string  getExactTitle()
      {
        Debug.Assert(flagHasExactTitle);
        return storeExactTitle;
      }

    public bool  hasPartialTitle()
      {
        return flagHasPartialTitle;
      }

    public string  getPartialTitle()
      {
        Debug.Assert(flagHasPartialTitle);
        return storePartialTitle;
      }

    public bool  hasExactLocation()
      {
        return flagHasExactLocation;
      }

    public string  getExactLocation()
      {
        Debug.Assert(flagHasExactLocation);
        return storeExactLocation;
      }

    public bool  hasPartialLocation()
      {
        return flagHasPartialLocation;
      }

    public string  getPartialLocation()
      {
        Debug.Assert(flagHasPartialLocation);
        return storePartialLocation;
      }

    public bool  hasLocationSpecifier()
      {
        return flagHasLocationSpecifier;
      }

    public CalendarLocationJSON   getLocationSpecifier()
      {
        Debug.Assert(flagHasLocationSpecifier);
        return storeLocationSpecifier;
      }

    public bool  hasStartTimeRange()
      {
        return flagHasStartTimeRange;
      }

    public TypeStartTimeRangeJSON   getStartTimeRange()
      {
        Debug.Assert(flagHasStartTimeRange);
        return storeStartTimeRange;
      }

    public bool  hasEndTimeRange()
      {
        return flagHasEndTimeRange;
      }

    public TypeEndTimeRangeJSON   getEndTimeRange()
      {
        Debug.Assert(flagHasEndTimeRange);
        return storeEndTimeRange;
      }

    public bool  hasIsRecurring()
      {
        return flagHasIsRecurring;
      }

    public bool  getIsRecurring()
      {
        Debug.Assert(flagHasIsRecurring);
        return storeIsRecurring;
      }

    public bool  hasIsAllDay()
      {
        return flagHasIsAllDay;
      }

    public bool  getIsAllDay()
      {
        Debug.Assert(flagHasIsAllDay);
        return storeIsAllDay;
      }

    public bool  hasAttendees()
      {
        return flagHasAttendees;
      }

    public int  countOfAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees.Count;
      }

    public string  elementOfAttendees(int element_num)
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees[element_num];
      }

    public List< string >  getAttendees()
      {
        Debug.Assert(flagHasAttendees);
        return storeAttendees;
      }

    public bool  hasSelfAttendeeStatus()
      {
        return flagHasSelfAttendeeStatus;
      }

    public TypeSelfAttendeeStatus  getSelfAttendeeStatus()
      {
        Debug.Assert(flagHasSelfAttendeeStatus);
        return storeSelfAttendeeStatus;
      }

    public string  getSelfAttendeeStatusAsString()
      {
        return stringFromSelfAttendeeStatus(getSelfAttendeeStatus());
      }


    public virtual int extraCalendarQueryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarQueryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarQueryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarQueryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSelectionTarget(TypeSelectionTarget new_value)
      {
        flagHasSelectionTarget = true;
        storeSelectionTarget = new_value;
      }
    public void setSelectionTarget(string chars)
      {
        setSelectionTarget(stringToSelectionTarget(chars));
      }
    public void unsetSelectionTarget()
      {
        flagHasSelectionTarget = false;
      }
    public void setRecurringTarget(TypeRecurringTarget new_value)
      {
        flagHasRecurringTarget = true;
        storeRecurringTarget = new_value;
      }
    public void setRecurringTarget(string chars)
      {
        setRecurringTarget(stringToRecurringTarget(chars));
      }
    public void unsetRecurringTarget()
      {
        flagHasRecurringTarget = false;
      }
    public void setExactCalendarName(string new_value)
      {
        flagHasExactCalendarName = true;
        storeExactCalendarName = new_value;
      }
    public void unsetExactCalendarName()
      {
        flagHasExactCalendarName = false;
      }
    public void setPartialCalendarName(string new_value)
      {
        flagHasPartialCalendarName = true;
        storePartialCalendarName = new_value;
      }
    public void unsetPartialCalendarName()
      {
        flagHasPartialCalendarName = false;
      }
    public void initCalendarIDs()
      {
        flagHasCalendarIDs = true;
        storeCalendarIDs.Clear();
      }
    public void appendCalendarIDs(string to_append)
      {
        if (!flagHasCalendarIDs)
          {
            flagHasCalendarIDs = true;
            storeCalendarIDs.Clear();
          }
        Debug.Assert(flagHasCalendarIDs);
        storeCalendarIDs.Add(to_append);
      }
    public void unsetCalendarIDs()
      {
        flagHasCalendarIDs = false;
        storeCalendarIDs.Clear();
      }
    public void setItemType(string new_value)
      {
        flagHasItemType = true;
        storeItemType = new_value;
      }
    public void unsetItemType()
      {
        flagHasItemType = false;
      }
    public void setExactTitle(string new_value)
      {
        flagHasExactTitle = true;
        storeExactTitle = new_value;
      }
    public void unsetExactTitle()
      {
        flagHasExactTitle = false;
      }
    public void setPartialTitle(string new_value)
      {
        flagHasPartialTitle = true;
        storePartialTitle = new_value;
      }
    public void unsetPartialTitle()
      {
        flagHasPartialTitle = false;
      }
    public void setExactLocation(string new_value)
      {
        flagHasExactLocation = true;
        storeExactLocation = new_value;
      }
    public void unsetExactLocation()
      {
        flagHasExactLocation = false;
      }
    public void setPartialLocation(string new_value)
      {
        flagHasPartialLocation = true;
        storePartialLocation = new_value;
      }
    public void unsetPartialLocation()
      {
        flagHasPartialLocation = false;
      }
    public void setLocationSpecifier(CalendarLocationJSON  new_value)
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = true;
        storeLocationSpecifier = new_value;
      }
    public void unsetLocationSpecifier()
      {
        if (flagHasLocationSpecifier)
          {
          }
        flagHasLocationSpecifier = false;
      }
    public void setStartTimeRange(TypeStartTimeRangeJSON  new_value)
      {
        if (flagHasStartTimeRange)
          {
          }
        flagHasStartTimeRange = true;
        storeStartTimeRange = new_value;
      }
    public void unsetStartTimeRange()
      {
        if (flagHasStartTimeRange)
          {
          }
        flagHasStartTimeRange = false;
      }
    public void setEndTimeRange(TypeEndTimeRangeJSON  new_value)
      {
        if (flagHasEndTimeRange)
          {
          }
        flagHasEndTimeRange = true;
        storeEndTimeRange = new_value;
      }
    public void unsetEndTimeRange()
      {
        if (flagHasEndTimeRange)
          {
          }
        flagHasEndTimeRange = false;
      }
    public void setIsRecurring(bool new_value)
      {
        flagHasIsRecurring = true;
        storeIsRecurring = new_value;
      }
    public void unsetIsRecurring()
      {
        flagHasIsRecurring = false;
      }
    public void setIsAllDay(bool new_value)
      {
        flagHasIsAllDay = true;
        storeIsAllDay = new_value;
      }
    public void unsetIsAllDay()
      {
        flagHasIsAllDay = false;
      }
    public void initAttendees()
      {
        flagHasAttendees = true;
        storeAttendees.Clear();
      }
    public void appendAttendees(string to_append)
      {
        if (!flagHasAttendees)
          {
            flagHasAttendees = true;
            storeAttendees.Clear();
          }
        Debug.Assert(flagHasAttendees);
        storeAttendees.Add(to_append);
      }
    public void unsetAttendees()
      {
        flagHasAttendees = false;
        storeAttendees.Clear();
      }
    public void setSelfAttendeeStatus(TypeSelfAttendeeStatus new_value)
      {
        flagHasSelfAttendeeStatus = true;
        storeSelfAttendeeStatus = new_value;
      }
    public void setSelfAttendeeStatus(string chars)
      {
        setSelfAttendeeStatus(stringToSelfAttendeeStatus(chars));
      }
    public void unsetSelfAttendeeStatus()
      {
        flagHasSelfAttendeeStatus = false;
      }

    public virtual void extraCalendarQueryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarQuerySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarQueryLookup(key);
        if (old_field == null)
          {
            extraCalendarQueryAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSelectionTarget);
        if (flagHasSelectionTarget)
          {
            handler.start_pair("SelectionTarget");
            switch (storeSelectionTarget)
              {
                case TypeSelectionTarget.SelectionTarget_First:
                    handler.string_value("First");
                    break;
                case TypeSelectionTarget.SelectionTarget_Last:
                    handler.string_value("Last");
                    break;
                case TypeSelectionTarget.SelectionTarget_All:
                    handler.string_value("All");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasRecurringTarget);
        if (flagHasRecurringTarget)
          {
            handler.start_pair("RecurringTarget");
            switch (storeRecurringTarget)
              {
                case TypeRecurringTarget.RecurringTarget_SpecifiedOnly:
                    handler.string_value("SpecifiedOnly");
                    break;
                case TypeRecurringTarget.RecurringTarget_AllFollowing:
                    handler.string_value("AllFollowing");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasExactCalendarName)
          {
            handler.start_pair("ExactCalendarName");
            handler.string_value(storeExactCalendarName);
          }
        if (flagHasPartialCalendarName)
          {
            handler.start_pair("PartialCalendarName");
            handler.string_value(storePartialCalendarName);
          }
        if (flagHasCalendarIDs)
          {
            handler.start_pair("CalendarIDs");
            Debug.Assert(storeCalendarIDs.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeCalendarIDs.Count; ++num1)
              {
                handler.string_value(storeCalendarIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasItemType)
          {
            handler.start_pair("ItemType");
            handler.string_value(storeItemType);
          }
        if (flagHasExactTitle)
          {
            handler.start_pair("ExactTitle");
            handler.string_value(storeExactTitle);
          }
        if (flagHasPartialTitle)
          {
            handler.start_pair("PartialTitle");
            handler.string_value(storePartialTitle);
          }
        if (flagHasExactLocation)
          {
            handler.start_pair("ExactLocation");
            handler.string_value(storeExactLocation);
          }
        if (flagHasPartialLocation)
          {
            handler.start_pair("PartialLocation");
            handler.string_value(storePartialLocation);
          }
        if (flagHasLocationSpecifier)
          {
            handler.start_pair("LocationSpecifier");
            if (partial_allowed)
                storeLocationSpecifier.write_partial_as_json(handler);
            else
                storeLocationSpecifier.write_as_json(handler);
          }
        if (flagHasStartTimeRange)
          {
            handler.start_pair("StartTimeRange");
            if (partial_allowed)
                storeStartTimeRange.write_partial_as_json(handler);
            else
                storeStartTimeRange.write_as_json(handler);
          }
        if (flagHasEndTimeRange)
          {
            handler.start_pair("EndTimeRange");
            if (partial_allowed)
                storeEndTimeRange.write_partial_as_json(handler);
            else
                storeEndTimeRange.write_as_json(handler);
          }
        if (flagHasIsRecurring)
          {
            handler.start_pair("IsRecurring");
            handler.boolean_value(storeIsRecurring);
          }
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        if (flagHasAttendees)
          {
            handler.start_pair("Attendees");
            handler.start_array();
            for (int num2 = 0; num2 < storeAttendees.Count; ++num2)
              {
                handler.string_value(storeAttendees[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSelfAttendeeStatus)
          {
            handler.start_pair("SelfAttendeeStatus");
            switch (storeSelfAttendeeStatus)
              {
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_None:
                    handler.string_value("None");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Accepted:
                    handler.string_value("Accepted");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Declined:
                    handler.string_value("Declined");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Invited:
                    handler.string_value("Invited");
                    break;
                case TypeSelfAttendeeStatus.SelfAttendeeStatus_Tentative:
                    handler.string_value("Tentative");
                    break;
                default:
                    Debug.Assert(false);
                    break;
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSelectionTarget()))
          {
            return "When parsing the object for %what%, the \"SelectionTarget\" field was missing.";
          }
        if (!(hasRecurringTarget()))
          {
            return "When parsing the object for %what%, the \"RecurringTarget\" field was missing.";
          }
        return null;
      }

    public static CalendarQueryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarQuery", ignore_extras);
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
    public static CalendarQueryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarQueryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarQuery", ignore_extras);
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
    public static CalendarQueryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarQueryJSON from_text(string text, bool ignore_extras)
      {
        CalendarQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarQuery", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarQueryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarQueryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarQueryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarQuery", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorSelectionTarget : JSONStringGenerator
          {
            protected FieldGeneratorSelectionTarget(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSelectionTarget()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSelectionTarget(result));
              }
            protected abstract void handle_result(TypeSelectionTarget result);
          };
    private class FieldHoldingGeneratorSelectionTarget : FieldGeneratorSelectionTarget
  {
    protected override void handle_result(TypeSelectionTarget result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSelectionTarget(String what)
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
    public TypeSelectionTarget value;
  };
    private class FieldHoldingArrayGeneratorSelectionTarget : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSelectionTarget
      {
        private FieldHoldingArrayGeneratorSelectionTarget top;

        protected override void handle_result(TypeSelectionTarget result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSelectionTarget init_top)
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
    protected virtual void handle_result(List<TypeSelectionTarget> result)
      {
      }

    public FieldHoldingArrayGeneratorSelectionTarget(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelectionTarget>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSelectionTarget()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelectionTarget>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSelectionTarget> value;
  };
        private FieldHoldingGeneratorSelectionTarget fieldGeneratorSelectionTarget;
    private abstract class FieldGeneratorRecurringTarget : JSONStringGenerator
          {
            protected FieldGeneratorRecurringTarget(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRecurringTarget()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToRecurringTarget(result));
              }
            protected abstract void handle_result(TypeRecurringTarget result);
          };
    private class FieldHoldingGeneratorRecurringTarget : FieldGeneratorRecurringTarget
  {
    protected override void handle_result(TypeRecurringTarget result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRecurringTarget(String what)
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
    public TypeRecurringTarget value;
  };
    private class FieldHoldingArrayGeneratorRecurringTarget : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRecurringTarget
      {
        private FieldHoldingArrayGeneratorRecurringTarget top;

        protected override void handle_result(TypeRecurringTarget result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRecurringTarget init_top)
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
    protected virtual void handle_result(List<TypeRecurringTarget> result)
      {
      }

    public FieldHoldingArrayGeneratorRecurringTarget(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRecurringTarget>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRecurringTarget()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRecurringTarget>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRecurringTarget> value;
  };
        private FieldHoldingGeneratorRecurringTarget fieldGeneratorRecurringTarget;
        private JSONHoldingStringGenerator fieldGeneratorExactCalendarName;
        private JSONHoldingStringGenerator fieldGeneratorPartialCalendarName;
        private JSONHoldingStringArrayGenerator fieldGeneratorCalendarIDs;
        private JSONHoldingStringGenerator fieldGeneratorItemType;
        private JSONHoldingStringGenerator fieldGeneratorExactTitle;
        private JSONHoldingStringGenerator fieldGeneratorPartialTitle;
        private JSONHoldingStringGenerator fieldGeneratorExactLocation;
        private JSONHoldingStringGenerator fieldGeneratorPartialLocation;
        private CalendarLocationJSON.HoldingGenerator fieldGeneratorLocationSpecifier;
        private TypeStartTimeRangeJSON.HoldingGenerator fieldGeneratorStartTimeRange;
        private TypeEndTimeRangeJSON.HoldingGenerator fieldGeneratorEndTimeRange;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAllDay;
        private JSONHoldingStringArrayGenerator fieldGeneratorAttendees;
    private abstract class FieldGeneratorSelfAttendeeStatus : JSONStringGenerator
          {
            protected FieldGeneratorSelfAttendeeStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSelfAttendeeStatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSelfAttendeeStatus(result));
              }
            protected abstract void handle_result(TypeSelfAttendeeStatus result);
          };
    private class FieldHoldingGeneratorSelfAttendeeStatus : FieldGeneratorSelfAttendeeStatus
  {
    protected override void handle_result(TypeSelfAttendeeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSelfAttendeeStatus(String what)
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
    public TypeSelfAttendeeStatus value;
  };
    private class FieldHoldingArrayGeneratorSelfAttendeeStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSelfAttendeeStatus
      {
        private FieldHoldingArrayGeneratorSelfAttendeeStatus top;

        protected override void handle_result(TypeSelfAttendeeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSelfAttendeeStatus init_top)
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
    protected virtual void handle_result(List<TypeSelfAttendeeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorSelfAttendeeStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSelfAttendeeStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSelfAttendeeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSelfAttendeeStatus> value;
  };
        private FieldHoldingGeneratorSelfAttendeeStatus fieldGeneratorSelfAttendeeStatus;
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
            CalendarQueryJSON result = new CalendarQueryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarQueryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarQueryJSON result)
          {
            if (fieldGeneratorSelectionTarget.have_value)
              {
                result.setSelectionTarget(fieldGeneratorSelectionTarget.value);
                fieldGeneratorSelectionTarget.have_value = false;
              }
            else if ((!(result.hasSelectionTarget())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SelectionTarget\" field was missing.");
              }
            if (fieldGeneratorRecurringTarget.have_value)
              {
                result.setRecurringTarget(fieldGeneratorRecurringTarget.value);
                fieldGeneratorRecurringTarget.have_value = false;
              }
            else if ((!(result.hasRecurringTarget())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RecurringTarget\" field was missing.");
              }
            if (fieldGeneratorExactCalendarName.have_value)
              {
                result.setExactCalendarName(fieldGeneratorExactCalendarName.value);
                fieldGeneratorExactCalendarName.have_value = false;
              }
            if (fieldGeneratorPartialCalendarName.have_value)
              {
                result.setPartialCalendarName(fieldGeneratorPartialCalendarName.value);
                fieldGeneratorPartialCalendarName.have_value = false;
              }
            if (fieldGeneratorCalendarIDs.have_value)
              {
                result.initCalendarIDs();
                int count = fieldGeneratorCalendarIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCalendarIDs(fieldGeneratorCalendarIDs.value[num]);
                  }
                fieldGeneratorCalendarIDs.value.Clear();
                fieldGeneratorCalendarIDs.have_value = false;
              }
            if (fieldGeneratorItemType.have_value)
              {
                result.setItemType(fieldGeneratorItemType.value);
                fieldGeneratorItemType.have_value = false;
              }
            if (fieldGeneratorExactTitle.have_value)
              {
                result.setExactTitle(fieldGeneratorExactTitle.value);
                fieldGeneratorExactTitle.have_value = false;
              }
            if (fieldGeneratorPartialTitle.have_value)
              {
                result.setPartialTitle(fieldGeneratorPartialTitle.value);
                fieldGeneratorPartialTitle.have_value = false;
              }
            if (fieldGeneratorExactLocation.have_value)
              {
                result.setExactLocation(fieldGeneratorExactLocation.value);
                fieldGeneratorExactLocation.have_value = false;
              }
            if (fieldGeneratorPartialLocation.have_value)
              {
                result.setPartialLocation(fieldGeneratorPartialLocation.value);
                fieldGeneratorPartialLocation.have_value = false;
              }
            if (fieldGeneratorLocationSpecifier.have_value)
              {
                result.setLocationSpecifier(fieldGeneratorLocationSpecifier.value);
                fieldGeneratorLocationSpecifier.have_value = false;
              }
            if (fieldGeneratorStartTimeRange.have_value)
              {
                result.setStartTimeRange(fieldGeneratorStartTimeRange.value);
                fieldGeneratorStartTimeRange.have_value = false;
              }
            if (fieldGeneratorEndTimeRange.have_value)
              {
                result.setEndTimeRange(fieldGeneratorEndTimeRange.value);
                fieldGeneratorEndTimeRange.have_value = false;
              }
            if (fieldGeneratorIsRecurring.have_value)
              {
                result.setIsRecurring(fieldGeneratorIsRecurring.value);
                fieldGeneratorIsRecurring.have_value = false;
              }
            if (fieldGeneratorIsAllDay.have_value)
              {
                result.setIsAllDay(fieldGeneratorIsAllDay.value);
                fieldGeneratorIsAllDay.have_value = false;
              }
            if (fieldGeneratorAttendees.have_value)
              {
                result.initAttendees();
                int count = fieldGeneratorAttendees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttendees(fieldGeneratorAttendees.value[num]);
                  }
                fieldGeneratorAttendees.value.Clear();
                fieldGeneratorAttendees.have_value = false;
              }
            if (fieldGeneratorSelfAttendeeStatus.have_value)
              {
                result.setSelfAttendeeStatus(fieldGeneratorSelfAttendeeStatus.value);
                fieldGeneratorSelfAttendeeStatus.have_value = false;
              }
          }
        protected abstract void handle_result(CalendarQueryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAttendees;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "alendarIDs", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCalendarIDs;
                    break;
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "dTimeRange", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorEndTimeRange;
                            break;
                        case 'x':
                            if (String.Compare(field_name, 2, "act", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 6, "alendarName", 0, 11, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorExactCalendarName;
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 6, "ocation", 0, 7, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorExactLocation;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "itle", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorExactTitle;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 's':
                            switch (field_name[2])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 3, "llDay", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorIsAllDay;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 3, "ecurring", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsRecurring;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "emType", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorItemType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocationSpecifier", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorLocationSpecifier;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "artial", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 8, "alendarName", 0, 11, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorPartialCalendarName;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 8, "ocation", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorPartialLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "itle", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorPartialTitle;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ecurringTarget", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRecurringTarget;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "l", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 4, "ctionTarget", 0, 11, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorSelectionTarget;
                                        break;
                                    case 'f':
                                        if ((String.Compare(field_name, 4, "AttendeeStatus", 0, 14, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorSelfAttendeeStatus;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artTimeRange", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorStartTimeRange;
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
            fieldGeneratorSelectionTarget = new FieldHoldingGeneratorSelectionTarget("field \"SelectionTarget\" of the CalendarQuery class");
            fieldGeneratorRecurringTarget = new FieldHoldingGeneratorRecurringTarget("field \"RecurringTarget\" of the CalendarQuery class");
            fieldGeneratorExactCalendarName = new JSONHoldingStringGenerator("field \"ExactCalendarName\" of the CalendarQuery class");
            fieldGeneratorPartialCalendarName = new JSONHoldingStringGenerator("field \"PartialCalendarName\" of the CalendarQuery class");
            fieldGeneratorCalendarIDs = new JSONHoldingStringArrayGenerator("field \"CalendarIDs\" of the CalendarQuery class");
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the CalendarQuery class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the CalendarQuery class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the CalendarQuery class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the CalendarQuery class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the CalendarQuery class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarQuery class", ignore_extras);
            fieldGeneratorStartTimeRange = new TypeStartTimeRangeJSON.HoldingGenerator("field \"StartTimeRange\" of the CalendarQuery class", ignore_extras);
            fieldGeneratorEndTimeRange = new TypeEndTimeRangeJSON.HoldingGenerator("field \"EndTimeRange\" of the CalendarQuery class", ignore_extras);
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarQuery class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarQuery class");
            fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the CalendarQuery class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarQuery class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarQuery class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSelectionTarget = new FieldHoldingGeneratorSelectionTarget("field \"SelectionTarget\" of the CalendarQuery class");
            fieldGeneratorRecurringTarget = new FieldHoldingGeneratorRecurringTarget("field \"RecurringTarget\" of the CalendarQuery class");
            fieldGeneratorExactCalendarName = new JSONHoldingStringGenerator("field \"ExactCalendarName\" of the CalendarQuery class");
            fieldGeneratorPartialCalendarName = new JSONHoldingStringGenerator("field \"PartialCalendarName\" of the CalendarQuery class");
            fieldGeneratorCalendarIDs = new JSONHoldingStringArrayGenerator("field \"CalendarIDs\" of the CalendarQuery class");
            fieldGeneratorItemType = new JSONHoldingStringGenerator("field \"ItemType\" of the CalendarQuery class");
            fieldGeneratorExactTitle = new JSONHoldingStringGenerator("field \"ExactTitle\" of the CalendarQuery class");
            fieldGeneratorPartialTitle = new JSONHoldingStringGenerator("field \"PartialTitle\" of the CalendarQuery class");
            fieldGeneratorExactLocation = new JSONHoldingStringGenerator("field \"ExactLocation\" of the CalendarQuery class");
            fieldGeneratorPartialLocation = new JSONHoldingStringGenerator("field \"PartialLocation\" of the CalendarQuery class");
            fieldGeneratorLocationSpecifier = new CalendarLocationJSON.HoldingGenerator("field \"LocationSpecifier\" of the CalendarQuery class", false);
            fieldGeneratorStartTimeRange = new TypeStartTimeRangeJSON.HoldingGenerator("field \"StartTimeRange\" of the CalendarQuery class", false);
            fieldGeneratorEndTimeRange = new TypeEndTimeRangeJSON.HoldingGenerator("field \"EndTimeRange\" of the CalendarQuery class", false);
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the CalendarQuery class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the CalendarQuery class");
            fieldGeneratorAttendees = new JSONHoldingStringArrayGenerator("field \"Attendees\" of the CalendarQuery class");
            fieldGeneratorSelfAttendeeStatus = new FieldHoldingGeneratorSelfAttendeeStatus("field \"SelfAttendeeStatus\" of the CalendarQuery class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarQuery class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSelectionTarget.reset();
            fieldGeneratorRecurringTarget.reset();
            fieldGeneratorExactCalendarName.reset();
            fieldGeneratorPartialCalendarName.reset();
            fieldGeneratorCalendarIDs.reset();
            fieldGeneratorItemType.reset();
            fieldGeneratorExactTitle.reset();
            fieldGeneratorPartialTitle.reset();
            fieldGeneratorExactLocation.reset();
            fieldGeneratorPartialLocation.reset();
            fieldGeneratorLocationSpecifier.reset();
            fieldGeneratorStartTimeRange.reset();
            fieldGeneratorEndTimeRange.reset();
            fieldGeneratorIsRecurring.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorAttendees.reset();
            fieldGeneratorSelfAttendeeStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocationSpecifier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndTimeRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocationSpecifier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndTimeRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarQueryJSON  result)
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
        public CalendarQueryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarQueryJSON  result)
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
    protected virtual void handle_result(List<CalendarQueryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarQueryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarQueryJSON>();
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
    public List<CalendarQueryJSON> value;
  };
  };
