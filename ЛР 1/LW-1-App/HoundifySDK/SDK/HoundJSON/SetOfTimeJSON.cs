/* file "SetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class SetOfTimeJSON : JSONBase
  {

    public SetOfTimeJSON()
      {
      }

    public abstract string getSetOfTimeKind();

    public abstract int extraSetOfTimeComponentCount();
    public abstract string extraSetOfTimeComponentKey(int component_num);
    public abstract JSONValue extraSetOfTimeComponentValue(int component_num);
    public abstract JSONValue extraSetOfTimeLookup(string field_name);


    public abstract void extraSetOfTimeAppendPair(string key, JSONValue new_component);
    public abstract void extraSetOfTimeSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("SetOfTimeKind", getSetOfTimeKind());
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static SetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetOfTime", ignore_extras);
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
    public static SetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetOfTime", ignore_extras);
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
    public static SetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        SetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SetOfTimeKind' field is missing.");
            SetOfTimeJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSetOfTimeJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SetOfTimeKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SetOfTimeJSON result)
          {
          }
        protected abstract void handle_result(SetOfTimeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "SetOfTimeKind", 0, 13, false) == 0) && (field_name.Length == 13))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SetOfTimeKind\" of the SetOfTime class");
            set_what("the SetOfTime class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SetOfTimeKind\" of the SetOfTime class");
            set_what("the SetOfTime class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
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
        protected override void handle_result(SetOfTimeJSON  result)
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
        public SetOfTimeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SetOfTimeJSON  result)
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
    protected virtual void handle_result(List<SetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SetOfTimeJSON>();
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
    public List<SetOfTimeJSON> value;
  };
    class GenericSetOfTimeJSON : SetOfTimeJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSetOfTimeJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSetOfTimeKind()  { return key; }
        public override int extraSetOfTimeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSetOfTimeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSetOfTimeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSetOfTimeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSetOfTimeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSetOfTimeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSetOfTimeLookup(key);
            if (old_field == null)
              {
                extraSetOfTimeAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SetOfTimeJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            if ((String.Compare(key, 1, "lways", 0, 5, false) == 0) && (key.Length == 6))
                return new AlwaysSetOfTimeJSON();
            break;
        case 'D':
            if (String.Compare(key, 1, "ate", 0, 3, false) == 0)
              {
                switch (key[4])
                  {
                    case 'A':
                        if (String.Compare(key, 5, "ndOrTime", 0, 8, false) == 0)
                          {
                            if (key.Length == 13)
                              {
                                return new DateAndOrTimeSetOfTimeJSON();
                              }
                            switch (key[13])
                              {
                                case 'R':
                                    if ((String.Compare(key, 14, "ange", 0, 4, false) == 0) && (key.Length == 18))
                                        return new DateAndOrTimeRangeSetOfTimeJSON();
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'T':
                        if ((String.Compare(key, 5, "imeSpecRange", 0, 12, false) == 0) && (key.Length == 17))
                            return new DateTimeSpecRangeSetOfTimeJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'E':
            if ((String.Compare(key, 1, "ndOfTime", 0, 8, false) == 0) && (key.Length == 9))
                return new EndOfTimePointInTimeJSON();
            break;
        case 'I':
            if ((String.Compare(key, 1, "ntersection", 0, 11, false) == 0) && (key.Length == 12))
                return new IntersectionSetOfTimeJSON();
            break;
        case 'N':
            switch (key[1])
              {
                case 'e':
                    if ((String.Compare(key, 2, "ver", 0, 3, false) == 0) && (key.Length == 5))
                        return new NeverSetOfTimeJSON();
                    break;
                case 'o':
                    if ((String.Compare(key, 2, "t", 0, 1, false) == 0) && (key.Length == 3))
                        return new NotSetOfTimeJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'P':
            if ((String.Compare(key, 1, "oint", 0, 4, false) == 0) && (key.Length == 5))
                return new PointInTimeSetOfTimeJSON();
            break;
        case 'R':
            switch (key[1])
              {
                case 'a':
                    if ((String.Compare(key, 2, "nge", 0, 3, false) == 0) && (key.Length == 5))
                        return new RangeSetOfTimeJSON();
                    break;
                case 'e':
                    if ((String.Compare(key, 2, "peated", 0, 6, false) == 0) && (key.Length == 8))
                        return new RepeatedSetOfTimeJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'S':
            if (String.Compare(key, 1, "tart", 0, 4, false) == 0)
              {
                switch (key[5])
                  {
                    case 'O':
                        if ((String.Compare(key, 6, "fTime", 0, 5, false) == 0) && (key.Length == 11))
                            return new StartOfTimePointInTimeJSON();
                        break;
                    case 'P':
                        if ((String.Compare(key, 6, "lusDuration", 0, 11, false) == 0) && (key.Length == 17))
                            return new StartPlusDurationSetOfTimeJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'U':
            if (String.Compare(key, 1, "n", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'i':
                        if ((String.Compare(key, 3, "on", 0, 2, false) == 0) && (key.Length == 5))
                            return new UnionSetOfTimeJSON();
                        break;
                    case 'k':
                        if ((String.Compare(key, 3, "nown", 0, 4, false) == 0) && (key.Length == 7))
                            return new UnknownSetOfTimeJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'W':
            if ((String.Compare(key, 1, "eeklyOperatingHours", 0, 19, false) == 0) && (key.Length == 20))
                return new WeeklyOperatingHoursJSON();
            break;
        default:
            break;
      }

        return new GenericSetOfTimeJSON(key);
      }
  };
