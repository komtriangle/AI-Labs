/* file "AirlineFilterJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AirlineFilterJSON : JSONBase
  {
    private bool flagHasIncludes;
    private List< AirlineJSON  > storeIncludes;
    private bool flagHasExcludes;
    private List< AirlineJSON  > storeExcludes;
    private bool flagHasDefaultForOthers;
    private IncludeExcludeStateJSON  storeDefaultForOthers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIncludes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Includes of AirlineFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Includes of AirlineFilterJSON has too few elements.");
        List< AirlineJSON  > vector_Includes1 = new List< AirlineJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AirlineJSON convert_classy = AirlineJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Includes1.Add(convert_classy);
          }
        Debug.Assert(vector_Includes1.Count >= 1);
        initIncludes();
        for (int num1 = 0; num1 < vector_Includes1.Count; ++num1)
            appendIncludes(vector_Includes1[num1]);
        for (int num1 = 0; num1 < vector_Includes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExcludes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Excludes of AirlineFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Excludes of AirlineFilterJSON has too few elements.");
        List< AirlineJSON  > vector_Excludes1 = new List< AirlineJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AirlineJSON convert_classy = AirlineJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Excludes1.Add(convert_classy);
          }
        Debug.Assert(vector_Excludes1.Count >= 1);
        initExcludes();
        for (int num2 = 0; num2 < vector_Excludes1.Count; ++num2)
            appendExcludes(vector_Excludes1[num2]);
        for (int num1 = 0; num1 < vector_Excludes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultForOthers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IncludeExcludeStateJSON convert_classy = IncludeExcludeStateJSON.from_json(json_value, ignore_extras, true);
        setDefaultForOthers(convert_classy);
      }


    public AirlineFilterJSON()
      {
        flagHasIncludes = false;
        flagHasExcludes = false;
        flagHasDefaultForOthers = false;
        storeIncludes = new List< AirlineJSON  >();
        storeExcludes = new List< AirlineJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIncludes()
      {
        return flagHasIncludes;
      }

    public int  countOfIncludes()
      {
        Debug.Assert(flagHasIncludes);
        return storeIncludes.Count;
      }

    public AirlineJSON   elementOfIncludes(int element_num)
      {
        Debug.Assert(flagHasIncludes);
        return storeIncludes[element_num];
      }

    public List< AirlineJSON  >  getIncludes()
      {
        Debug.Assert(flagHasIncludes);
        return storeIncludes;
      }

    public bool  hasExcludes()
      {
        return flagHasExcludes;
      }

    public int  countOfExcludes()
      {
        Debug.Assert(flagHasExcludes);
        return storeExcludes.Count;
      }

    public AirlineJSON   elementOfExcludes(int element_num)
      {
        Debug.Assert(flagHasExcludes);
        return storeExcludes[element_num];
      }

    public List< AirlineJSON  >  getExcludes()
      {
        Debug.Assert(flagHasExcludes);
        return storeExcludes;
      }

    public bool  hasDefaultForOthers()
      {
        return flagHasDefaultForOthers;
      }

    public IncludeExcludeStateJSON   getDefaultForOthers()
      {
        Debug.Assert(flagHasDefaultForOthers);
        return storeDefaultForOthers;
      }

    public IncludeExcludeStateJSON.TypeValue  getDefaultForOthersValue()
      {
        return getDefaultForOthers().getValue();
      }

    public string  getDefaultForOthersAsString()
      {
        return getDefaultForOthers().getValueAsString();
      }


    public virtual int extraAirlineFilterComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAirlineFilterComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAirlineFilterComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAirlineFilterLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initIncludes()
      {
        if (flagHasIncludes)
          {
            for (int num1 = 0; num1 < storeIncludes.Count; ++num1)
              {
              }
          }
        flagHasIncludes = true;
        storeIncludes.Clear();
      }
    public void appendIncludes(AirlineJSON  to_append)
      {
        if (!flagHasIncludes)
          {
            flagHasIncludes = true;
            storeIncludes.Clear();
          }
        Debug.Assert(flagHasIncludes);
        storeIncludes.Add(to_append);
      }
    public void unsetIncludes()
      {
        if (flagHasIncludes)
          {
            for (int num2 = 0; num2 < storeIncludes.Count; ++num2)
              {
              }
          }
        flagHasIncludes = false;
        storeIncludes.Clear();
      }
    public void initExcludes()
      {
        if (flagHasExcludes)
          {
            for (int num3 = 0; num3 < storeExcludes.Count; ++num3)
              {
              }
          }
        flagHasExcludes = true;
        storeExcludes.Clear();
      }
    public void appendExcludes(AirlineJSON  to_append)
      {
        if (!flagHasExcludes)
          {
            flagHasExcludes = true;
            storeExcludes.Clear();
          }
        Debug.Assert(flagHasExcludes);
        storeExcludes.Add(to_append);
      }
    public void unsetExcludes()
      {
        if (flagHasExcludes)
          {
            for (int num4 = 0; num4 < storeExcludes.Count; ++num4)
              {
              }
          }
        flagHasExcludes = false;
        storeExcludes.Clear();
      }
    public void setDefaultForOthers(IncludeExcludeStateJSON  new_value)
      {
        if (flagHasDefaultForOthers)
          {
          }
        flagHasDefaultForOthers = true;
        storeDefaultForOthers = new_value;
      }
    public void setDefaultForOthers(IncludeExcludeStateJSON.TypeValue new_value)
      {
        setDefaultForOthers(new IncludeExcludeStateJSON(new_value));
      }
    public void setDefaultForOthers(string chars)
      {
        setDefaultForOthers(new IncludeExcludeStateJSON(chars));
      }
    public void unsetDefaultForOthers()
      {
        if (flagHasDefaultForOthers)
          {
          }
        flagHasDefaultForOthers = false;
      }

    public virtual void extraAirlineFilterAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAirlineFilterSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAirlineFilterLookup(key);
        if (old_field == null)
          {
            extraAirlineFilterAppendPair(key, new_component);
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
        if (flagHasIncludes)
          {
            handler.start_pair("Includes");
            Debug.Assert(storeIncludes.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeIncludes.Count; ++num1)
              {
                if (partial_allowed)
                    storeIncludes[num1].write_partial_as_json(handler);
                else
                    storeIncludes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasExcludes)
          {
            handler.start_pair("Excludes");
            Debug.Assert(storeExcludes.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeExcludes.Count; ++num2)
              {
                if (partial_allowed)
                    storeExcludes[num2].write_partial_as_json(handler);
                else
                    storeExcludes[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDefaultForOthers)
          {
            handler.start_pair("DefaultForOthers");
            if (partial_allowed)
                storeDefaultForOthers.write_partial_as_json(handler);
            else
                storeDefaultForOthers.write_as_json(handler);
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

    public static AirlineFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFilter", ignore_extras);
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
    public static AirlineFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AirlineFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFilter", ignore_extras);
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
    public static AirlineFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AirlineFilterJSON from_text(string text, bool ignore_extras)
      {
        AirlineFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFilter", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AirlineFilterJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AirlineFilterJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AirlineFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AirlineFilter", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private AirlineJSON.HoldingArrayGenerator fieldGeneratorIncludes;
        private AirlineJSON.HoldingArrayGenerator fieldGeneratorExcludes;
        private IncludeExcludeStateJSON.HoldingGenerator fieldGeneratorDefaultForOthers;
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
            AirlineFilterJSON result = new AirlineFilterJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAirlineFilterAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AirlineFilterJSON result)
          {
            if (fieldGeneratorIncludes.have_value)
              {
                result.initIncludes();
                int count = fieldGeneratorIncludes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIncludes(fieldGeneratorIncludes.value[num]);
                  }
                fieldGeneratorIncludes.value.Clear();
                fieldGeneratorIncludes.have_value = false;
              }
            if (fieldGeneratorExcludes.have_value)
              {
                result.initExcludes();
                int count = fieldGeneratorExcludes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExcludes(fieldGeneratorExcludes.value[num]);
                  }
                fieldGeneratorExcludes.value.Clear();
                fieldGeneratorExcludes.have_value = false;
              }
            if (fieldGeneratorDefaultForOthers.have_value)
              {
                result.setDefaultForOthers(fieldGeneratorDefaultForOthers.value);
                fieldGeneratorDefaultForOthers.have_value = false;
              }
          }
        protected abstract void handle_result(AirlineFilterJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "efaultForOthers", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorDefaultForOthers;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xcludes", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorExcludes;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ncludes", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIncludes;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIncludes = new AirlineJSON.HoldingArrayGenerator("field \"Includes\" of the AirlineFilter class", ignore_extras);
            fieldGeneratorExcludes = new AirlineJSON.HoldingArrayGenerator("field \"Excludes\" of the AirlineFilter class", ignore_extras);
            fieldGeneratorDefaultForOthers = new IncludeExcludeStateJSON.HoldingGenerator("field \"DefaultForOthers\" of the AirlineFilter class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AirlineFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIncludes = new AirlineJSON.HoldingArrayGenerator("field \"Includes\" of the AirlineFilter class", false);
            fieldGeneratorExcludes = new AirlineJSON.HoldingArrayGenerator("field \"Excludes\" of the AirlineFilter class", false);
            fieldGeneratorDefaultForOthers = new IncludeExcludeStateJSON.HoldingGenerator("field \"DefaultForOthers\" of the AirlineFilter class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AirlineFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIncludes.reset();
            fieldGeneratorExcludes.reset();
            fieldGeneratorDefaultForOthers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorIncludes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorExcludes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDefaultForOthers.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorIncludes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorExcludes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDefaultForOthers.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AirlineFilterJSON  result)
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
        public AirlineFilterJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AirlineFilterJSON  result)
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
    protected virtual void handle_result(List<AirlineFilterJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AirlineFilterJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AirlineFilterJSON>();
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
    public List<AirlineFilterJSON> value;
  };
  };
