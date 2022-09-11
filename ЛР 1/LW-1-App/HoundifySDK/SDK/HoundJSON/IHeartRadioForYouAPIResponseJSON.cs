/* file "IHeartRadioForYouAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioForYouAPIResponseJSON : JSONBase
  {
    private bool flagHasvalues;
    private List< IHeartRadioForYouAPIResponseValueJSON  > storevalues;
    private bool flagHaserror;
    private IHeartRadioForYouAPIResponseErrorJSON  storeerror;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONvalues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field values of IHeartRadioForYouAPIResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioForYouAPIResponseValueJSON  > vector_values1 = new List< IHeartRadioForYouAPIResponseValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioForYouAPIResponseValueJSON convert_classy = IHeartRadioForYouAPIResponseValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_values1.Add(convert_classy);
          }
        initvalues();
        for (int num1 = 0; num1 < vector_values1.Count; ++num1)
            appendvalues(vector_values1[num1]);
        for (int num1 = 0; num1 < vector_values1.Count; ++num1)
          {
          }
      }


    private void  fromJSONerror(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioForYouAPIResponseErrorJSON convert_classy = IHeartRadioForYouAPIResponseErrorJSON.from_json(json_value, ignore_extras, true);
        seterror(convert_classy);
      }


    public IHeartRadioForYouAPIResponseJSON()
      {
        flagHasvalues = false;
        flagHaserror = false;
        storevalues = new List< IHeartRadioForYouAPIResponseValueJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasvalues()
      {
        return flagHasvalues;
      }

    public int  countOfvalues()
      {
        Debug.Assert(flagHasvalues);
        return storevalues.Count;
      }

    public IHeartRadioForYouAPIResponseValueJSON   elementOfvalues(int element_num)
      {
        Debug.Assert(flagHasvalues);
        return storevalues[element_num];
      }

    public List< IHeartRadioForYouAPIResponseValueJSON  >  getvalues()
      {
        Debug.Assert(flagHasvalues);
        return storevalues;
      }

    public bool  haserror()
      {
        return flagHaserror;
      }

    public IHeartRadioForYouAPIResponseErrorJSON   geterror()
      {
        Debug.Assert(flagHaserror);
        return storeerror;
      }


    public virtual int extraIHeartRadioForYouAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioForYouAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initvalues()
      {
        if (flagHasvalues)
          {
            for (int num1 = 0; num1 < storevalues.Count; ++num1)
              {
              }
          }
        flagHasvalues = true;
        storevalues.Clear();
      }
    public void appendvalues(IHeartRadioForYouAPIResponseValueJSON  to_append)
      {
        if (!flagHasvalues)
          {
            flagHasvalues = true;
            storevalues.Clear();
          }
        Debug.Assert(flagHasvalues);
        storevalues.Add(to_append);
      }
    public void unsetvalues()
      {
        if (flagHasvalues)
          {
            for (int num2 = 0; num2 < storevalues.Count; ++num2)
              {
              }
          }
        flagHasvalues = false;
        storevalues.Clear();
      }
    public void seterror(IHeartRadioForYouAPIResponseErrorJSON  new_value)
      {
        if (flagHaserror)
          {
          }
        flagHaserror = true;
        storeerror = new_value;
      }
    public void unseterror()
      {
        if (flagHaserror)
          {
          }
        flagHaserror = false;
      }

    public virtual void extraIHeartRadioForYouAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioForYouAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioForYouAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioForYouAPIResponseAppendPair(key, new_component);
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
        if (flagHasvalues)
          {
            handler.start_pair("values");
            handler.start_array();
            for (int num1 = 0; num1 < storevalues.Count; ++num1)
              {
                if (partial_allowed)
                    storevalues[num1].write_partial_as_json(handler);
                else
                    storevalues[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHaserror)
          {
            handler.start_pair("error");
            if (partial_allowed)
                storeerror.write_partial_as_json(handler);
            else
                storeerror.write_as_json(handler);
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

    public static IHeartRadioForYouAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponse", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponse", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioForYouAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioForYouAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private IHeartRadioForYouAPIResponseValueJSON.HoldingArrayGenerator fieldGeneratorvalues;
        private IHeartRadioForYouAPIResponseErrorJSON.HoldingGenerator fieldGeneratorerror;
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
            IHeartRadioForYouAPIResponseJSON result = new IHeartRadioForYouAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioForYouAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioForYouAPIResponseJSON result)
          {
            if (fieldGeneratorvalues.have_value)
              {
                result.initvalues();
                int count = fieldGeneratorvalues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendvalues(fieldGeneratorvalues.value[num]);
                  }
                fieldGeneratorvalues.value.Clear();
                fieldGeneratorvalues.have_value = false;
              }
            if (fieldGeneratorerror.have_value)
              {
                result.seterror(fieldGeneratorerror.value);
                fieldGeneratorerror.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioForYouAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'e':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorerror;
                    break;
                case 'v':
                    if ((String.Compare(field_name, 1, "alues", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorvalues;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorvalues = new IHeartRadioForYouAPIResponseValueJSON.HoldingArrayGenerator("field \"values\" of the IHeartRadioForYouAPIResponse class", ignore_extras);
            fieldGeneratorerror = new IHeartRadioForYouAPIResponseErrorJSON.HoldingGenerator("field \"error\" of the IHeartRadioForYouAPIResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioForYouAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorvalues = new IHeartRadioForYouAPIResponseValueJSON.HoldingArrayGenerator("field \"values\" of the IHeartRadioForYouAPIResponse class", false);
            fieldGeneratorerror = new IHeartRadioForYouAPIResponseErrorJSON.HoldingGenerator("field \"error\" of the IHeartRadioForYouAPIResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioForYouAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorvalues.reset();
            fieldGeneratorerror.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorvalues.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorerror.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorvalues.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorerror.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioForYouAPIResponseJSON  result)
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
        public IHeartRadioForYouAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioForYouAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioForYouAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioForYouAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioForYouAPIResponseJSON>();
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
    public List<IHeartRadioForYouAPIResponseJSON> value;
  };
  };
