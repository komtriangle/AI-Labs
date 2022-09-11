/* file "RobotStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RobotStateJSON : JSONBase
  {
    private bool flagHasCurrentAction;
    private string storeCurrentAction;
    private bool flagHasRecordingVideo;
    private bool storeRecordingVideo;
    private bool flagHasKnownRooms;
    private KnownRoomsJSON  storeKnownRooms;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCurrentAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrentAction of RobotStateJSON is not a string.");
        setCurrentAction(json_string.getData());
      }


    private void  fromJSONRecordingVideo(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RecordingVideo of RobotStateJSON is not true for false.");
              }
          }
        setRecordingVideo(the_bool);
      }


    private void  fromJSONKnownRooms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        KnownRoomsJSON convert_classy = KnownRoomsJSON.from_json(json_value, ignore_extras, true);
        setKnownRooms(convert_classy);
      }


    public RobotStateJSON()
      {
        flagHasCurrentAction = false;
        flagHasRecordingVideo = false;
        flagHasKnownRooms = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCurrentAction()
      {
        return flagHasCurrentAction;
      }

    public string  getCurrentAction()
      {
        Debug.Assert(flagHasCurrentAction);
        return storeCurrentAction;
      }

    public bool  hasRecordingVideo()
      {
        return flagHasRecordingVideo;
      }

    public bool  getRecordingVideo()
      {
        Debug.Assert(flagHasRecordingVideo);
        return storeRecordingVideo;
      }

    public bool  hasKnownRooms()
      {
        return flagHasKnownRooms;
      }

    public KnownRoomsJSON   getKnownRooms()
      {
        Debug.Assert(flagHasKnownRooms);
        return storeKnownRooms;
      }


    public virtual int extraRobotStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRobotStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRobotStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRobotStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCurrentAction(string new_value)
      {
        flagHasCurrentAction = true;
        storeCurrentAction = new_value;
      }
    public void unsetCurrentAction()
      {
        flagHasCurrentAction = false;
      }
    public void setRecordingVideo(bool new_value)
      {
        flagHasRecordingVideo = true;
        storeRecordingVideo = new_value;
      }
    public void unsetRecordingVideo()
      {
        flagHasRecordingVideo = false;
      }
    public void setKnownRooms(KnownRoomsJSON  new_value)
      {
        if (flagHasKnownRooms)
          {
          }
        flagHasKnownRooms = true;
        storeKnownRooms = new_value;
      }
    public void unsetKnownRooms()
      {
        if (flagHasKnownRooms)
          {
          }
        flagHasKnownRooms = false;
      }

    public virtual void extraRobotStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRobotStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRobotStateLookup(key);
        if (old_field == null)
          {
            extraRobotStateAppendPair(key, new_component);
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
        if (flagHasCurrentAction)
          {
            handler.start_pair("CurrentAction");
            handler.string_value(storeCurrentAction);
          }
        if (flagHasRecordingVideo)
          {
            handler.start_pair("RecordingVideo");
            handler.boolean_value(storeRecordingVideo);
          }
        if (flagHasKnownRooms)
          {
            handler.start_pair("KnownRooms");
            if (partial_allowed)
                storeKnownRooms.write_partial_as_json(handler);
            else
                storeKnownRooms.write_as_json(handler);
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
        return null;
      }

    public static RobotStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotState", ignore_extras);
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
    public static RobotStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RobotStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotState", ignore_extras);
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
    public static RobotStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RobotStateJSON from_text(string text, bool ignore_extras)
      {
        RobotStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RobotStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorCurrentAction;
        private JSONHoldingBooleanGenerator fieldGeneratorRecordingVideo;
        private KnownRoomsJSON.HoldingGenerator fieldGeneratorKnownRooms;
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
            RobotStateJSON result = new RobotStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RobotStateJSON result)
          {
            if (fieldGeneratorCurrentAction.have_value)
              {
                result.setCurrentAction(fieldGeneratorCurrentAction.value);
                fieldGeneratorCurrentAction.have_value = false;
              }
            if (fieldGeneratorRecordingVideo.have_value)
              {
                result.setRecordingVideo(fieldGeneratorRecordingVideo.value);
                fieldGeneratorRecordingVideo.have_value = false;
              }
            if (fieldGeneratorKnownRooms.have_value)
              {
                result.setKnownRooms(fieldGeneratorKnownRooms.value);
                fieldGeneratorKnownRooms.have_value = false;
              }
          }
        protected abstract void handle_result(RobotStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentAction", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorCurrentAction;
                    break;
                case 'K':
                    if ((String.Compare(field_name, 1, "nownRooms", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorKnownRooms;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ecordingVideo", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorRecordingVideo;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCurrentAction = new JSONHoldingStringGenerator("field \"CurrentAction\" of the RobotState class");
            fieldGeneratorRecordingVideo = new JSONHoldingBooleanGenerator("field \"RecordingVideo\" of the RobotState class");
            fieldGeneratorKnownRooms = new KnownRoomsJSON.HoldingGenerator("field \"KnownRooms\" of the RobotState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RobotState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCurrentAction = new JSONHoldingStringGenerator("field \"CurrentAction\" of the RobotState class");
            fieldGeneratorRecordingVideo = new JSONHoldingBooleanGenerator("field \"RecordingVideo\" of the RobotState class");
            fieldGeneratorKnownRooms = new KnownRoomsJSON.HoldingGenerator("field \"KnownRooms\" of the RobotState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RobotState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCurrentAction.reset();
            fieldGeneratorRecordingVideo.reset();
            fieldGeneratorKnownRooms.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorKnownRooms.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorKnownRooms.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotStateJSON  result)
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
        public RobotStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotStateJSON  result)
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
    protected virtual void handle_result(List<RobotStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotStateJSON>();
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
    public List<RobotStateJSON> value;
  };
  };
