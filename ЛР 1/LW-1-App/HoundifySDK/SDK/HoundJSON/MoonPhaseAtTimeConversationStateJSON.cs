/* file "MoonPhaseAtTimeConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MoonPhaseAtTimeConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_MoonPhaseAtTime
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "MoonPhaseAtTime", 0, 15, false) == 0) && (chars.Length == 15))
            return TypeDateAndTimeKind.DateAndTimeKind_MoonPhaseAtTime;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_MoonPhaseAtTime:
                return "MoonPhaseAtTime";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasDateTimeSpec;
    private DateTimeSpecJSON  storeDateTimeSpec;
    private bool flagHasMoonPhase;
    private string storeMoonPhase;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of MoonPhaseAtTimeConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("MoonPhaseAtTime")))
            throw new Exception("The value for field DateAndTimeKind of MoonPhaseAtTimeConversationStateJSON is not `MoonPhaseAtTime'.");
        setDateAndTimeKind();
      }


    private void  fromJSONDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeSpec(convert_classy);
      }


    private void  fromJSONMoonPhase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MoonPhase of MoonPhaseAtTimeConversationStateJSON is not a string.");
        setMoonPhase(json_string.getData());
      }


    public MoonPhaseAtTimeConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasDateTimeSpec = false;
        flagHasMoonPhase = false;
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
        return TypeDateAndTimeKind.DateAndTimeKind_MoonPhaseAtTime;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
      }

    public bool  hasDateTimeSpec()
      {
        return flagHasDateTimeSpec;
      }

    public DateTimeSpecJSON   getDateTimeSpec()
      {
        Debug.Assert(flagHasDateTimeSpec);
        return storeDateTimeSpec;
      }

    public bool  hasMoonPhase()
      {
        return flagHasMoonPhase;
      }

    public string  getMoonPhase()
      {
        Debug.Assert(flagHasMoonPhase);
        return storeMoonPhase;
      }


    public virtual int extraMoonPhaseAtTimeConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMoonPhaseAtTimeConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMoonPhaseAtTimeConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMoonPhaseAtTimeConversationStateLookup(string field_name)
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
    public void setDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = true;
        storeDateTimeSpec = new_value;
      }
    public void unsetDateTimeSpec()
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = false;
      }
    public void setMoonPhase(string new_value)
      {
        flagHasMoonPhase = true;
        storeMoonPhase = new_value;
      }
    public void unsetMoonPhase()
      {
        flagHasMoonPhase = false;
      }

    public virtual void extraMoonPhaseAtTimeConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMoonPhaseAtTimeConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMoonPhaseAtTimeConversationStateLookup(key);
        if (old_field == null)
          {
            extraMoonPhaseAtTimeConversationStateAppendPair(key, new_component);
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
            handler.string_value("MoonPhaseAtTime");
          }
        Debug.Assert(partial_allowed || flagHasDateTimeSpec);
        if (flagHasDateTimeSpec)
          {
            handler.start_pair("DateTimeSpec");
            if (partial_allowed)
                storeDateTimeSpec.write_partial_as_json(handler);
            else
                storeDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasMoonPhase);
        if (flagHasMoonPhase)
          {
            handler.start_pair("MoonPhase");
            handler.string_value(storeMoonPhase);
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
        if (!(hasDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateTimeSpec\" field was missing.";
          }
        if (!(hasMoonPhase()))
          {
            return "When parsing the object for %what%, the \"MoonPhase\" field was missing.";
          }
        return null;
      }

    public static MoonPhaseAtTimeConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoonPhaseAtTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeConversationState", ignore_extras);
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
    public static MoonPhaseAtTimeConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MoonPhaseAtTimeConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MoonPhaseAtTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeConversationState", ignore_extras);
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
    public static MoonPhaseAtTimeConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MoonPhaseAtTimeConversationStateJSON from_text(string text, bool ignore_extras)
      {
        MoonPhaseAtTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MoonPhaseAtTimeConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MoonPhaseAtTimeConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MoonPhaseAtTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MoonPhaseAtTimeConversationState", ignore_extras);
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
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorDateTimeSpec;
        private JSONHoldingStringGenerator fieldGeneratorMoonPhase;
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
            MoonPhaseAtTimeConversationStateJSON result = new MoonPhaseAtTimeConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMoonPhaseAtTimeConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MoonPhaseAtTimeConversationStateJSON result)
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
            if (fieldGeneratorDateTimeSpec.have_value)
              {
                result.setDateTimeSpec(fieldGeneratorDateTimeSpec.value);
                fieldGeneratorDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorMoonPhase.have_value)
              {
                result.setMoonPhase(fieldGeneratorMoonPhase.value);
                fieldGeneratorMoonPhase.have_value = false;
              }
            else if ((!(result.hasMoonPhase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MoonPhase\" field was missing.");
              }
          }
        protected abstract void handle_result(MoonPhaseAtTimeConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ate", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 5, "ndTimeKind", 0, 10, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDateAndTimeKind;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 5, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDateTimeSpec;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "oonPhase", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorMoonPhase;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the MoonPhaseAtTimeConversationState class");
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the MoonPhaseAtTimeConversationState class", ignore_extras);
            fieldGeneratorMoonPhase = new JSONHoldingStringGenerator("field \"MoonPhase\" of the MoonPhaseAtTimeConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MoonPhaseAtTimeConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the MoonPhaseAtTimeConversationState class");
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the MoonPhaseAtTimeConversationState class", false);
            fieldGeneratorMoonPhase = new JSONHoldingStringGenerator("field \"MoonPhase\" of the MoonPhaseAtTimeConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MoonPhaseAtTimeConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorDateTimeSpec.reset();
            fieldGeneratorMoonPhase.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MoonPhaseAtTimeConversationStateJSON  result)
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
        public MoonPhaseAtTimeConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MoonPhaseAtTimeConversationStateJSON  result)
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
    protected virtual void handle_result(List<MoonPhaseAtTimeConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MoonPhaseAtTimeConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MoonPhaseAtTimeConversationStateJSON>();
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
    public List<MoonPhaseAtTimeConversationStateJSON> value;
  };
  };
