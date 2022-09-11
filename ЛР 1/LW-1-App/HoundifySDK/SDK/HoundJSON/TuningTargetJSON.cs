/* file "TuningTargetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TuningTargetJSON : JSONBase
  {
    private bool flagHasStationName;
    private string storeStationName;
    private bool flagHasStationNameInLocalScript;
    private string storeStationNameInLocalScript;
    private bool flagHasLocalScript;
    private string storeLocalScript;
    private bool flagHasStationNameSpoken;
    private string storeStationNameSpoken;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStationName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationName of TuningTargetJSON is not a string.");
        setStationName(json_string.getData());
      }


    private void  fromJSONStationNameInLocalScript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationNameInLocalScript of TuningTargetJSON is not a string.");
        setStationNameInLocalScript(json_string.getData());
      }


    private void  fromJSONLocalScript(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalScript of TuningTargetJSON is not a string.");
        setLocalScript(json_string.getData());
      }


    private void  fromJSONStationNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationNameSpoken of TuningTargetJSON is not a string.");
        setStationNameSpoken(json_string.getData());
      }


    public TuningTargetJSON()
      {
        flagHasStationName = false;
        flagHasStationNameInLocalScript = false;
        flagHasLocalScript = false;
        flagHasStationNameSpoken = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStationName()
      {
        return flagHasStationName;
      }

    public string  getStationName()
      {
        Debug.Assert(flagHasStationName);
        return storeStationName;
      }

    public bool  hasStationNameInLocalScript()
      {
        return flagHasStationNameInLocalScript;
      }

    public string  getStationNameInLocalScript()
      {
        Debug.Assert(flagHasStationNameInLocalScript);
        return storeStationNameInLocalScript;
      }

    public bool  hasLocalScript()
      {
        return flagHasLocalScript;
      }

    public string  getLocalScript()
      {
        Debug.Assert(flagHasLocalScript);
        return storeLocalScript;
      }

    public bool  hasStationNameSpoken()
      {
        return flagHasStationNameSpoken;
      }

    public string  getStationNameSpoken()
      {
        Debug.Assert(flagHasStationNameSpoken);
        return storeStationNameSpoken;
      }


    public virtual int extraTuningTargetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTuningTargetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTuningTargetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTuningTargetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStationName(string new_value)
      {
        flagHasStationName = true;
        storeStationName = new_value;
      }
    public void unsetStationName()
      {
        flagHasStationName = false;
      }
    public void setStationNameInLocalScript(string new_value)
      {
        flagHasStationNameInLocalScript = true;
        storeStationNameInLocalScript = new_value;
      }
    public void unsetStationNameInLocalScript()
      {
        flagHasStationNameInLocalScript = false;
      }
    public void setLocalScript(string new_value)
      {
        flagHasLocalScript = true;
        storeLocalScript = new_value;
      }
    public void unsetLocalScript()
      {
        flagHasLocalScript = false;
      }
    public void setStationNameSpoken(string new_value)
      {
        flagHasStationNameSpoken = true;
        storeStationNameSpoken = new_value;
      }
    public void unsetStationNameSpoken()
      {
        flagHasStationNameSpoken = false;
      }

    public virtual void extraTuningTargetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTuningTargetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTuningTargetLookup(key);
        if (old_field == null)
          {
            extraTuningTargetAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStationName);
        if (flagHasStationName)
          {
            handler.start_pair("StationName");
            handler.string_value(storeStationName);
          }
        if (flagHasStationNameInLocalScript)
          {
            handler.start_pair("StationNameInLocalScript");
            handler.string_value(storeStationNameInLocalScript);
          }
        if (flagHasLocalScript)
          {
            handler.start_pair("LocalScript");
            handler.string_value(storeLocalScript);
          }
        Debug.Assert(partial_allowed || flagHasStationNameSpoken);
        if (flagHasStationNameSpoken)
          {
            handler.start_pair("StationNameSpoken");
            handler.string_value(storeStationNameSpoken);
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
        if (!(hasStationName()))
          {
            return "When parsing the object for %what%, the \"StationName\" field was missing.";
          }
        if (!(hasStationNameSpoken()))
          {
            return "When parsing the object for %what%, the \"StationNameSpoken\" field was missing.";
          }
        return null;
      }

    public static TuningTargetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuningTarget", ignore_extras);
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
    public static TuningTargetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TuningTargetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuningTarget", ignore_extras);
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
    public static TuningTargetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TuningTargetJSON from_text(string text, bool ignore_extras)
      {
        TuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuningTarget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TuningTargetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TuningTargetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TuningTargetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TuningTarget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStationName;
        private JSONHoldingStringGenerator fieldGeneratorStationNameInLocalScript;
        private JSONHoldingStringGenerator fieldGeneratorLocalScript;
        private JSONHoldingStringGenerator fieldGeneratorStationNameSpoken;
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
            TuningTargetJSON result = new TuningTargetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTuningTargetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TuningTargetJSON result)
          {
            if (fieldGeneratorStationName.have_value)
              {
                result.setStationName(fieldGeneratorStationName.value);
                fieldGeneratorStationName.have_value = false;
              }
            else if ((!(result.hasStationName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationName\" field was missing.");
              }
            if (fieldGeneratorStationNameInLocalScript.have_value)
              {
                result.setStationNameInLocalScript(fieldGeneratorStationNameInLocalScript.value);
                fieldGeneratorStationNameInLocalScript.have_value = false;
              }
            if (fieldGeneratorLocalScript.have_value)
              {
                result.setLocalScript(fieldGeneratorLocalScript.value);
                fieldGeneratorLocalScript.have_value = false;
              }
            if (fieldGeneratorStationNameSpoken.have_value)
              {
                result.setStationNameSpoken(fieldGeneratorStationNameSpoken.value);
                fieldGeneratorStationNameSpoken.have_value = false;
              }
            else if ((!(result.hasStationNameSpoken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationNameSpoken\" field was missing.");
              }
          }
        protected abstract void handle_result(TuningTargetJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "ocalScript", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorLocalScript;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tationName", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorStationName;
                          }
                        switch (field_name[11])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 12, "nLocalScript", 0, 12, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorStationNameInLocalScript;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 12, "poken", 0, 5, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorStationNameSpoken;
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
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the TuningTarget class");
            fieldGeneratorStationNameInLocalScript = new JSONHoldingStringGenerator("field \"StationNameInLocalScript\" of the TuningTarget class");
            fieldGeneratorLocalScript = new JSONHoldingStringGenerator("field \"LocalScript\" of the TuningTarget class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the TuningTarget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TuningTarget class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the TuningTarget class");
            fieldGeneratorStationNameInLocalScript = new JSONHoldingStringGenerator("field \"StationNameInLocalScript\" of the TuningTarget class");
            fieldGeneratorLocalScript = new JSONHoldingStringGenerator("field \"LocalScript\" of the TuningTarget class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the TuningTarget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TuningTarget class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStationName.reset();
            fieldGeneratorStationNameInLocalScript.reset();
            fieldGeneratorLocalScript.reset();
            fieldGeneratorStationNameSpoken.reset();
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
        protected override void handle_result(TuningTargetJSON  result)
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
        public TuningTargetJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TuningTargetJSON  result)
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
    protected virtual void handle_result(List<TuningTargetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TuningTargetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TuningTargetJSON>();
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
    public List<TuningTargetJSON> value;
  };
  };
