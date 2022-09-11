/* file "IHeartRadioSearchAllAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioSearchAllAPIResponseJSON : JSONBase
  {
    private bool flagHasresults;
    private IHeartRadioSearchAllAPIResponseResultsJSON  storeresults;
    private bool flagHasbestMatch;
    private IHeartRadioSearchAllAPIResponseBestMatchJSON  storebestMatch;
    private bool flagHascounts;
    private IHeartRadioSearchAllAPIResponseCountsJSON  storecounts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONresults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioSearchAllAPIResponseResultsJSON convert_classy = IHeartRadioSearchAllAPIResponseResultsJSON.from_json(json_value, ignore_extras, true);
        setresults(convert_classy);
      }


    private void  fromJSONbestMatch(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioSearchAllAPIResponseBestMatchJSON convert_classy = IHeartRadioSearchAllAPIResponseBestMatchJSON.from_json(json_value, ignore_extras, true);
        setbestMatch(convert_classy);
      }


    private void  fromJSONcounts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioSearchAllAPIResponseCountsJSON convert_classy = IHeartRadioSearchAllAPIResponseCountsJSON.from_json(json_value, ignore_extras, true);
        setcounts(convert_classy);
      }


    public IHeartRadioSearchAllAPIResponseJSON()
      {
        flagHasresults = false;
        flagHasbestMatch = false;
        flagHascounts = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasresults()
      {
        return flagHasresults;
      }

    public IHeartRadioSearchAllAPIResponseResultsJSON   getresults()
      {
        Debug.Assert(flagHasresults);
        return storeresults;
      }

    public bool  hasbestMatch()
      {
        return flagHasbestMatch;
      }

    public IHeartRadioSearchAllAPIResponseBestMatchJSON   getbestMatch()
      {
        Debug.Assert(flagHasbestMatch);
        return storebestMatch;
      }

    public bool  hascounts()
      {
        return flagHascounts;
      }

    public IHeartRadioSearchAllAPIResponseCountsJSON   getcounts()
      {
        Debug.Assert(flagHascounts);
        return storecounts;
      }


    public virtual int extraIHeartRadioSearchAllAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setresults(IHeartRadioSearchAllAPIResponseResultsJSON  new_value)
      {
        if (flagHasresults)
          {
          }
        flagHasresults = true;
        storeresults = new_value;
      }
    public void unsetresults()
      {
        if (flagHasresults)
          {
          }
        flagHasresults = false;
      }
    public void setbestMatch(IHeartRadioSearchAllAPIResponseBestMatchJSON  new_value)
      {
        if (flagHasbestMatch)
          {
          }
        flagHasbestMatch = true;
        storebestMatch = new_value;
      }
    public void unsetbestMatch()
      {
        if (flagHasbestMatch)
          {
          }
        flagHasbestMatch = false;
      }
    public void setcounts(IHeartRadioSearchAllAPIResponseCountsJSON  new_value)
      {
        if (flagHascounts)
          {
          }
        flagHascounts = true;
        storecounts = new_value;
      }
    public void unsetcounts()
      {
        if (flagHascounts)
          {
          }
        flagHascounts = false;
      }

    public virtual void extraIHeartRadioSearchAllAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasresults);
        if (flagHasresults)
          {
            handler.start_pair("results");
            if (partial_allowed)
                storeresults.write_partial_as_json(handler);
            else
                storeresults.write_as_json(handler);
          }
        if (flagHasbestMatch)
          {
            handler.start_pair("bestMatch");
            if (partial_allowed)
                storebestMatch.write_partial_as_json(handler);
            else
                storebestMatch.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHascounts);
        if (flagHascounts)
          {
            handler.start_pair("counts");
            if (partial_allowed)
                storecounts.write_partial_as_json(handler);
            else
                storecounts.write_as_json(handler);
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
        if (!(hasresults()))
          {
            return "When parsing the object for %what%, the \"results\" field was missing.";
          }
        if (!(hascounts()))
          {
            return "When parsing the object for %what%, the \"counts\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponse", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponse", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private IHeartRadioSearchAllAPIResponseResultsJSON.HoldingGenerator fieldGeneratorresults;
        private IHeartRadioSearchAllAPIResponseBestMatchJSON.HoldingGenerator fieldGeneratorbestMatch;
        private IHeartRadioSearchAllAPIResponseCountsJSON.HoldingGenerator fieldGeneratorcounts;
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
            IHeartRadioSearchAllAPIResponseJSON result = new IHeartRadioSearchAllAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponseJSON result)
          {
            if (fieldGeneratorresults.have_value)
              {
                result.setresults(fieldGeneratorresults.value);
                fieldGeneratorresults.have_value = false;
              }
            else if ((!(result.hasresults())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"results\" field was missing.");
              }
            if (fieldGeneratorbestMatch.have_value)
              {
                result.setbestMatch(fieldGeneratorbestMatch.value);
                fieldGeneratorbestMatch.have_value = false;
              }
            if (fieldGeneratorcounts.have_value)
              {
                result.setcounts(fieldGeneratorcounts.value);
                fieldGeneratorcounts.have_value = false;
              }
            else if ((!(result.hascounts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"counts\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'b':
                    if ((String.Compare(field_name, 1, "estMatch", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorbestMatch;
                    break;
                case 'c':
                    if ((String.Compare(field_name, 1, "ounts", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorcounts;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorresults;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorresults = new IHeartRadioSearchAllAPIResponseResultsJSON.HoldingGenerator("field \"results\" of the IHeartRadioSearchAllAPIResponse class", ignore_extras);
            fieldGeneratorbestMatch = new IHeartRadioSearchAllAPIResponseBestMatchJSON.HoldingGenerator("field \"bestMatch\" of the IHeartRadioSearchAllAPIResponse class", ignore_extras);
            fieldGeneratorcounts = new IHeartRadioSearchAllAPIResponseCountsJSON.HoldingGenerator("field \"counts\" of the IHeartRadioSearchAllAPIResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorresults = new IHeartRadioSearchAllAPIResponseResultsJSON.HoldingGenerator("field \"results\" of the IHeartRadioSearchAllAPIResponse class", false);
            fieldGeneratorbestMatch = new IHeartRadioSearchAllAPIResponseBestMatchJSON.HoldingGenerator("field \"bestMatch\" of the IHeartRadioSearchAllAPIResponse class", false);
            fieldGeneratorcounts = new IHeartRadioSearchAllAPIResponseCountsJSON.HoldingGenerator("field \"counts\" of the IHeartRadioSearchAllAPIResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorresults.reset();
            fieldGeneratorbestMatch.reset();
            fieldGeneratorcounts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorresults.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorbestMatch.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorcounts.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorresults.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorbestMatch.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorcounts.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioSearchAllAPIResponseJSON  result)
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
        public IHeartRadioSearchAllAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponseJSON>();
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
    public List<IHeartRadioSearchAllAPIResponseJSON> value;
  };
  };
