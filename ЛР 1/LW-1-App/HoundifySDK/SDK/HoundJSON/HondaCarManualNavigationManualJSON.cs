/* file "HondaCarManualNavigationManualJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HondaCarManualNavigationManualJSON : JSONBase
  {
    private bool flagHasDocumentNumber;
    private string storeDocumentNumber;
    private bool flagHasVersionNumber;
    private string storeVersionNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDocumentNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DocumentNumber of HondaCarManualNavigationManualJSON is not a string.");
        setDocumentNumber(json_string.getData());
      }


    private void  fromJSONVersionNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VersionNumber of HondaCarManualNavigationManualJSON is not a string.");
        setVersionNumber(json_string.getData());
      }


    public HondaCarManualNavigationManualJSON()
      {
        flagHasDocumentNumber = false;
        flagHasVersionNumber = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDocumentNumber()
      {
        return flagHasDocumentNumber;
      }

    public string  getDocumentNumber()
      {
        Debug.Assert(flagHasDocumentNumber);
        return storeDocumentNumber;
      }

    public bool  hasVersionNumber()
      {
        return flagHasVersionNumber;
      }

    public string  getVersionNumber()
      {
        Debug.Assert(flagHasVersionNumber);
        return storeVersionNumber;
      }


    public virtual int extraHondaCarManualNavigationManualComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHondaCarManualNavigationManualComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHondaCarManualNavigationManualComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHondaCarManualNavigationManualLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDocumentNumber(string new_value)
      {
        flagHasDocumentNumber = true;
        storeDocumentNumber = new_value;
      }
    public void unsetDocumentNumber()
      {
        flagHasDocumentNumber = false;
      }
    public void setVersionNumber(string new_value)
      {
        flagHasVersionNumber = true;
        storeVersionNumber = new_value;
      }
    public void unsetVersionNumber()
      {
        flagHasVersionNumber = false;
      }

    public virtual void extraHondaCarManualNavigationManualAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHondaCarManualNavigationManualSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHondaCarManualNavigationManualLookup(key);
        if (old_field == null)
          {
            extraHondaCarManualNavigationManualAppendPair(key, new_component);
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
        if (flagHasDocumentNumber)
          {
            handler.start_pair("DocumentNumber");
            handler.string_value(storeDocumentNumber);
          }
        if (flagHasVersionNumber)
          {
            handler.start_pair("VersionNumber");
            handler.string_value(storeVersionNumber);
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

    public static HondaCarManualNavigationManualJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaCarManualNavigationManualJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualNavigationManual", ignore_extras);
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
    public static HondaCarManualNavigationManualJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaCarManualNavigationManualJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaCarManualNavigationManualJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualNavigationManual", ignore_extras);
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
    public static HondaCarManualNavigationManualJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaCarManualNavigationManualJSON from_text(string text, bool ignore_extras)
      {
        HondaCarManualNavigationManualJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualNavigationManual", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HondaCarManualNavigationManualJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HondaCarManualNavigationManualJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HondaCarManualNavigationManualJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaCarManualNavigationManual", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDocumentNumber;
        private JSONHoldingStringGenerator fieldGeneratorVersionNumber;
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
            HondaCarManualNavigationManualJSON result = new HondaCarManualNavigationManualJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHondaCarManualNavigationManualAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HondaCarManualNavigationManualJSON result)
          {
            if (fieldGeneratorDocumentNumber.have_value)
              {
                result.setDocumentNumber(fieldGeneratorDocumentNumber.value);
                fieldGeneratorDocumentNumber.have_value = false;
              }
            if (fieldGeneratorVersionNumber.have_value)
              {
                result.setVersionNumber(fieldGeneratorVersionNumber.value);
                fieldGeneratorVersionNumber.have_value = false;
              }
          }
        protected abstract void handle_result(HondaCarManualNavigationManualJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ocumentNumber", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorDocumentNumber;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ersionNumber", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorVersionNumber;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDocumentNumber = new JSONHoldingStringGenerator("field \"DocumentNumber\" of the HondaCarManualNavigationManual class");
            fieldGeneratorVersionNumber = new JSONHoldingStringGenerator("field \"VersionNumber\" of the HondaCarManualNavigationManual class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HondaCarManualNavigationManual class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDocumentNumber = new JSONHoldingStringGenerator("field \"DocumentNumber\" of the HondaCarManualNavigationManual class");
            fieldGeneratorVersionNumber = new JSONHoldingStringGenerator("field \"VersionNumber\" of the HondaCarManualNavigationManual class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HondaCarManualNavigationManual class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDocumentNumber.reset();
            fieldGeneratorVersionNumber.reset();
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
        protected override void handle_result(HondaCarManualNavigationManualJSON  result)
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
        public HondaCarManualNavigationManualJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HondaCarManualNavigationManualJSON  result)
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
    protected virtual void handle_result(List<HondaCarManualNavigationManualJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HondaCarManualNavigationManualJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HondaCarManualNavigationManualJSON>();
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
    public List<HondaCarManualNavigationManualJSON> value;
  };
  };
