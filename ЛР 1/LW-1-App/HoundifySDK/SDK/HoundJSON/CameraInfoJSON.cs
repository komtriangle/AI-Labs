/* file "CameraInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CameraInfoJSON : JSONBase
  {
    private bool flagHasCanPan;
    private bool storeCanPan;
    private bool flagHasCanTilt;
    private bool storeCanTilt;
    private bool flagHasCanZoom;
    private bool storeCanZoom;
    private bool flagHasCanAlert;
    private bool storeCanAlert;
    private bool flagHasCanRecord;
    private bool storeCanRecord;
    private bool flagHasCanTakePic;
    private bool storeCanTakePic;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCanPan(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanPan of CameraInfoJSON is not true for false.");
              }
          }
        setCanPan(the_bool);
      }


    private void  fromJSONCanTilt(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanTilt of CameraInfoJSON is not true for false.");
              }
          }
        setCanTilt(the_bool);
      }


    private void  fromJSONCanZoom(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanZoom of CameraInfoJSON is not true for false.");
              }
          }
        setCanZoom(the_bool);
      }


    private void  fromJSONCanAlert(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanAlert of CameraInfoJSON is not true for false.");
              }
          }
        setCanAlert(the_bool);
      }


    private void  fromJSONCanRecord(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanRecord of CameraInfoJSON is not true for false.");
              }
          }
        setCanRecord(the_bool);
      }


    private void  fromJSONCanTakePic(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CanTakePic of CameraInfoJSON is not true for false.");
              }
          }
        setCanTakePic(the_bool);
      }


    public CameraInfoJSON()
      {
        flagHasCanPan = false;
        flagHasCanTilt = false;
        flagHasCanZoom = false;
        flagHasCanAlert = false;
        flagHasCanRecord = false;
        flagHasCanTakePic = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCanPan()
      {
        return flagHasCanPan;
      }

    public bool  getCanPan()
      {
        Debug.Assert(flagHasCanPan);
        return storeCanPan;
      }

    public bool  hasCanTilt()
      {
        return flagHasCanTilt;
      }

    public bool  getCanTilt()
      {
        Debug.Assert(flagHasCanTilt);
        return storeCanTilt;
      }

    public bool  hasCanZoom()
      {
        return flagHasCanZoom;
      }

    public bool  getCanZoom()
      {
        Debug.Assert(flagHasCanZoom);
        return storeCanZoom;
      }

    public bool  hasCanAlert()
      {
        return flagHasCanAlert;
      }

    public bool  getCanAlert()
      {
        Debug.Assert(flagHasCanAlert);
        return storeCanAlert;
      }

    public bool  hasCanRecord()
      {
        return flagHasCanRecord;
      }

    public bool  getCanRecord()
      {
        Debug.Assert(flagHasCanRecord);
        return storeCanRecord;
      }

    public bool  hasCanTakePic()
      {
        return flagHasCanTakePic;
      }

    public bool  getCanTakePic()
      {
        Debug.Assert(flagHasCanTakePic);
        return storeCanTakePic;
      }


    public virtual int extraCameraInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCameraInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCameraInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCameraInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCanPan(bool new_value)
      {
        flagHasCanPan = true;
        storeCanPan = new_value;
      }
    public void unsetCanPan()
      {
        flagHasCanPan = false;
      }
    public void setCanTilt(bool new_value)
      {
        flagHasCanTilt = true;
        storeCanTilt = new_value;
      }
    public void unsetCanTilt()
      {
        flagHasCanTilt = false;
      }
    public void setCanZoom(bool new_value)
      {
        flagHasCanZoom = true;
        storeCanZoom = new_value;
      }
    public void unsetCanZoom()
      {
        flagHasCanZoom = false;
      }
    public void setCanAlert(bool new_value)
      {
        flagHasCanAlert = true;
        storeCanAlert = new_value;
      }
    public void unsetCanAlert()
      {
        flagHasCanAlert = false;
      }
    public void setCanRecord(bool new_value)
      {
        flagHasCanRecord = true;
        storeCanRecord = new_value;
      }
    public void unsetCanRecord()
      {
        flagHasCanRecord = false;
      }
    public void setCanTakePic(bool new_value)
      {
        flagHasCanTakePic = true;
        storeCanTakePic = new_value;
      }
    public void unsetCanTakePic()
      {
        flagHasCanTakePic = false;
      }

    public virtual void extraCameraInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCameraInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCameraInfoLookup(key);
        if (old_field == null)
          {
            extraCameraInfoAppendPair(key, new_component);
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
        if (flagHasCanPan)
          {
            handler.start_pair("CanPan");
            handler.boolean_value(storeCanPan);
          }
        if (flagHasCanTilt)
          {
            handler.start_pair("CanTilt");
            handler.boolean_value(storeCanTilt);
          }
        if (flagHasCanZoom)
          {
            handler.start_pair("CanZoom");
            handler.boolean_value(storeCanZoom);
          }
        if (flagHasCanAlert)
          {
            handler.start_pair("CanAlert");
            handler.boolean_value(storeCanAlert);
          }
        if (flagHasCanRecord)
          {
            handler.start_pair("CanRecord");
            handler.boolean_value(storeCanRecord);
          }
        if (flagHasCanTakePic)
          {
            handler.start_pair("CanTakePic");
            handler.boolean_value(storeCanTakePic);
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

    public static CameraInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CameraInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraInfo", ignore_extras);
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
    public static CameraInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CameraInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CameraInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraInfo", ignore_extras);
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
    public static CameraInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CameraInfoJSON from_text(string text, bool ignore_extras)
      {
        CameraInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CameraInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CameraInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CameraInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CameraInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorCanPan;
        private JSONHoldingBooleanGenerator fieldGeneratorCanTilt;
        private JSONHoldingBooleanGenerator fieldGeneratorCanZoom;
        private JSONHoldingBooleanGenerator fieldGeneratorCanAlert;
        private JSONHoldingBooleanGenerator fieldGeneratorCanRecord;
        private JSONHoldingBooleanGenerator fieldGeneratorCanTakePic;
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
            CameraInfoJSON result = new CameraInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCameraInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CameraInfoJSON result)
          {
            if (fieldGeneratorCanPan.have_value)
              {
                result.setCanPan(fieldGeneratorCanPan.value);
                fieldGeneratorCanPan.have_value = false;
              }
            if (fieldGeneratorCanTilt.have_value)
              {
                result.setCanTilt(fieldGeneratorCanTilt.value);
                fieldGeneratorCanTilt.have_value = false;
              }
            if (fieldGeneratorCanZoom.have_value)
              {
                result.setCanZoom(fieldGeneratorCanZoom.value);
                fieldGeneratorCanZoom.have_value = false;
              }
            if (fieldGeneratorCanAlert.have_value)
              {
                result.setCanAlert(fieldGeneratorCanAlert.value);
                fieldGeneratorCanAlert.have_value = false;
              }
            if (fieldGeneratorCanRecord.have_value)
              {
                result.setCanRecord(fieldGeneratorCanRecord.value);
                fieldGeneratorCanRecord.have_value = false;
              }
            if (fieldGeneratorCanTakePic.have_value)
              {
                result.setCanTakePic(fieldGeneratorCanTakePic.value);
                fieldGeneratorCanTakePic.have_value = false;
              }
          }
        protected abstract void handle_result(CameraInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Can", 0, 3, false) == 0)
              {
                switch (field_name[3])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 4, "lert", 0, 4, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorCanAlert;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 4, "an", 0, 2, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorCanPan;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 4, "ecord", 0, 5, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorCanRecord;
                        break;
                    case 'T':
                        switch (field_name[4])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 5, "kePic", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorCanTakePic;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 5, "lt", 0, 2, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorCanTilt;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'Z':
                        if ((String.Compare(field_name, 4, "oom", 0, 3, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorCanZoom;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCanPan = new JSONHoldingBooleanGenerator("field \"CanPan\" of the CameraInfo class");
            fieldGeneratorCanTilt = new JSONHoldingBooleanGenerator("field \"CanTilt\" of the CameraInfo class");
            fieldGeneratorCanZoom = new JSONHoldingBooleanGenerator("field \"CanZoom\" of the CameraInfo class");
            fieldGeneratorCanAlert = new JSONHoldingBooleanGenerator("field \"CanAlert\" of the CameraInfo class");
            fieldGeneratorCanRecord = new JSONHoldingBooleanGenerator("field \"CanRecord\" of the CameraInfo class");
            fieldGeneratorCanTakePic = new JSONHoldingBooleanGenerator("field \"CanTakePic\" of the CameraInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CameraInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCanPan = new JSONHoldingBooleanGenerator("field \"CanPan\" of the CameraInfo class");
            fieldGeneratorCanTilt = new JSONHoldingBooleanGenerator("field \"CanTilt\" of the CameraInfo class");
            fieldGeneratorCanZoom = new JSONHoldingBooleanGenerator("field \"CanZoom\" of the CameraInfo class");
            fieldGeneratorCanAlert = new JSONHoldingBooleanGenerator("field \"CanAlert\" of the CameraInfo class");
            fieldGeneratorCanRecord = new JSONHoldingBooleanGenerator("field \"CanRecord\" of the CameraInfo class");
            fieldGeneratorCanTakePic = new JSONHoldingBooleanGenerator("field \"CanTakePic\" of the CameraInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CameraInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCanPan.reset();
            fieldGeneratorCanTilt.reset();
            fieldGeneratorCanZoom.reset();
            fieldGeneratorCanAlert.reset();
            fieldGeneratorCanRecord.reset();
            fieldGeneratorCanTakePic.reset();
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
        protected override void handle_result(CameraInfoJSON  result)
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
        public CameraInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CameraInfoJSON  result)
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
    protected virtual void handle_result(List<CameraInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CameraInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CameraInfoJSON>();
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
    public List<CameraInfoJSON> value;
  };
  };
