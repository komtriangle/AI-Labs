/* file "IHeartRadioForYouAPIResponseContentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioForYouAPIResponseContentJSON : JSONBase
  {
    private bool flagHasid;
    private BigInteger storeid;
    private bool flagHasname;
    private string storename;
    private bool flagHaslogo;
    private string storelogo;
    private bool flagHasstreams;
    private IHeartRadioLiveStationsAPIResponseStreamJSON  storestreams;
    private bool flagHasdescription;
    private string storedescription;
    private bool flagHasgenres;
    private List< IHeartRadioLiveStationsAPIResponseGenreJSON  > storegenres;
    private bool flagHasfreq;
    private string storefreq;
    private bool flagHasband;
    private string storeband;
    private bool flagHascallLetters;
    private string storecallLetters;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field id of IHeartRadioForYouAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field id of IHeartRadioForYouAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setid(extracted_integer);
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONlogo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field logo of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setlogo(json_string.getData());
      }


    private void  fromJSONstreams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioLiveStationsAPIResponseStreamJSON convert_classy = IHeartRadioLiveStationsAPIResponseStreamJSON.from_json(json_value, ignore_extras, true);
        setstreams(convert_classy);
      }


    private void  fromJSONdescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field description of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setdescription(json_string.getData());
      }


    private void  fromJSONgenres(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field genres of IHeartRadioForYouAPIResponseContentJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioLiveStationsAPIResponseGenreJSON  > vector_genres1 = new List< IHeartRadioLiveStationsAPIResponseGenreJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioLiveStationsAPIResponseGenreJSON convert_classy = IHeartRadioLiveStationsAPIResponseGenreJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_genres1.Add(convert_classy);
          }
        initgenres();
        for (int num1 = 0; num1 < vector_genres1.Count; ++num1)
            appendgenres(vector_genres1[num1]);
        for (int num1 = 0; num1 < vector_genres1.Count; ++num1)
          {
          }
      }


    private void  fromJSONfreq(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field freq of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setfreq(json_string.getData());
      }


    private void  fromJSONband(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field band of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setband(json_string.getData());
      }


    private void  fromJSONcallLetters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field callLetters of IHeartRadioForYouAPIResponseContentJSON is not a string.");
        setcallLetters(json_string.getData());
      }


    public IHeartRadioForYouAPIResponseContentJSON()
      {
        flagHasid = false;
        flagHasname = false;
        flagHaslogo = false;
        flagHasstreams = false;
        flagHasdescription = false;
        flagHasgenres = false;
        flagHasfreq = false;
        flagHasband = false;
        flagHascallLetters = false;
        storegenres = new List< IHeartRadioLiveStationsAPIResponseGenreJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public BigInteger  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasname()
      {
        return flagHasname;
      }

    public string  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  haslogo()
      {
        return flagHaslogo;
      }

    public string  getlogo()
      {
        Debug.Assert(flagHaslogo);
        return storelogo;
      }

    public bool  hasstreams()
      {
        return flagHasstreams;
      }

    public IHeartRadioLiveStationsAPIResponseStreamJSON   getstreams()
      {
        Debug.Assert(flagHasstreams);
        return storestreams;
      }

    public bool  hasdescription()
      {
        return flagHasdescription;
      }

    public string  getdescription()
      {
        Debug.Assert(flagHasdescription);
        return storedescription;
      }

    public bool  hasgenres()
      {
        return flagHasgenres;
      }

    public int  countOfgenres()
      {
        Debug.Assert(flagHasgenres);
        return storegenres.Count;
      }

    public IHeartRadioLiveStationsAPIResponseGenreJSON   elementOfgenres(int element_num)
      {
        Debug.Assert(flagHasgenres);
        return storegenres[element_num];
      }

    public List< IHeartRadioLiveStationsAPIResponseGenreJSON  >  getgenres()
      {
        Debug.Assert(flagHasgenres);
        return storegenres;
      }

    public bool  hasfreq()
      {
        return flagHasfreq;
      }

    public string  getfreq()
      {
        Debug.Assert(flagHasfreq);
        return storefreq;
      }

    public bool  hasband()
      {
        return flagHasband;
      }

    public string  getband()
      {
        Debug.Assert(flagHasband);
        return storeband;
      }

    public bool  hascallLetters()
      {
        return flagHascallLetters;
      }

    public string  getcallLetters()
      {
        Debug.Assert(flagHascallLetters);
        return storecallLetters;
      }


    public virtual int extraIHeartRadioForYouAPIResponseContentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioForYouAPIResponseContentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseContentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseContentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(BigInteger new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setname(string new_value)
      {
        flagHasname = true;
        storename = new_value;
      }
    public void unsetname()
      {
        flagHasname = false;
      }
    public void setlogo(string new_value)
      {
        flagHaslogo = true;
        storelogo = new_value;
      }
    public void unsetlogo()
      {
        flagHaslogo = false;
      }
    public void setstreams(IHeartRadioLiveStationsAPIResponseStreamJSON  new_value)
      {
        if (flagHasstreams)
          {
          }
        flagHasstreams = true;
        storestreams = new_value;
      }
    public void unsetstreams()
      {
        if (flagHasstreams)
          {
          }
        flagHasstreams = false;
      }
    public void setdescription(string new_value)
      {
        flagHasdescription = true;
        storedescription = new_value;
      }
    public void unsetdescription()
      {
        flagHasdescription = false;
      }
    public void initgenres()
      {
        if (flagHasgenres)
          {
            for (int num1 = 0; num1 < storegenres.Count; ++num1)
              {
              }
          }
        flagHasgenres = true;
        storegenres.Clear();
      }
    public void appendgenres(IHeartRadioLiveStationsAPIResponseGenreJSON  to_append)
      {
        if (!flagHasgenres)
          {
            flagHasgenres = true;
            storegenres.Clear();
          }
        Debug.Assert(flagHasgenres);
        storegenres.Add(to_append);
      }
    public void unsetgenres()
      {
        if (flagHasgenres)
          {
            for (int num2 = 0; num2 < storegenres.Count; ++num2)
              {
              }
          }
        flagHasgenres = false;
        storegenres.Clear();
      }
    public void setfreq(string new_value)
      {
        flagHasfreq = true;
        storefreq = new_value;
      }
    public void unsetfreq()
      {
        flagHasfreq = false;
      }
    public void setband(string new_value)
      {
        flagHasband = true;
        storeband = new_value;
      }
    public void unsetband()
      {
        flagHasband = false;
      }
    public void setcallLetters(string new_value)
      {
        flagHascallLetters = true;
        storecallLetters = new_value;
      }
    public void unsetcallLetters()
      {
        flagHascallLetters = false;
      }

    public virtual void extraIHeartRadioForYouAPIResponseContentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioForYouAPIResponseContentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioForYouAPIResponseContentLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioForYouAPIResponseContentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.number_value(storeid);
          }
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        if (flagHaslogo)
          {
            handler.start_pair("logo");
            handler.string_value(storelogo);
          }
        if (flagHasstreams)
          {
            handler.start_pair("streams");
            if (partial_allowed)
                storestreams.write_partial_as_json(handler);
            else
                storestreams.write_as_json(handler);
          }
        if (flagHasdescription)
          {
            handler.start_pair("description");
            handler.string_value(storedescription);
          }
        if (flagHasgenres)
          {
            handler.start_pair("genres");
            handler.start_array();
            for (int num1 = 0; num1 < storegenres.Count; ++num1)
              {
                if (partial_allowed)
                    storegenres[num1].write_partial_as_json(handler);
                else
                    storegenres[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasfreq)
          {
            handler.start_pair("freq");
            handler.string_value(storefreq);
          }
        if (flagHasband)
          {
            handler.start_pair("band");
            handler.string_value(storeband);
          }
        if (flagHascallLetters)
          {
            handler.start_pair("callLetters");
            handler.string_value(storecallLetters);
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioForYouAPIResponseContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseContent", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseContent", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseContentJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseContent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioForYouAPIResponseContentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioForYouAPIResponseContentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseContent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorid : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorid(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorid : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorid(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorid fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingStringGenerator fieldGeneratorlogo;
        private IHeartRadioLiveStationsAPIResponseStreamJSON.HoldingGenerator fieldGeneratorstreams;
        private JSONHoldingStringGenerator fieldGeneratordescription;
        private IHeartRadioLiveStationsAPIResponseGenreJSON.HoldingArrayGenerator fieldGeneratorgenres;
        private JSONHoldingStringGenerator fieldGeneratorfreq;
        private JSONHoldingStringGenerator fieldGeneratorband;
        private JSONHoldingStringGenerator fieldGeneratorcallLetters;
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
            IHeartRadioForYouAPIResponseContentJSON result = new IHeartRadioForYouAPIResponseContentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioForYouAPIResponseContentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioForYouAPIResponseContentJSON result)
          {
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            else if ((!(result.hasname())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"name\" field was missing.");
              }
            if (fieldGeneratorlogo.have_value)
              {
                result.setlogo(fieldGeneratorlogo.value);
                fieldGeneratorlogo.have_value = false;
              }
            if (fieldGeneratorstreams.have_value)
              {
                result.setstreams(fieldGeneratorstreams.value);
                fieldGeneratorstreams.have_value = false;
              }
            if (fieldGeneratordescription.have_value)
              {
                result.setdescription(fieldGeneratordescription.value);
                fieldGeneratordescription.have_value = false;
              }
            if (fieldGeneratorgenres.have_value)
              {
                result.initgenres();
                int count = fieldGeneratorgenres.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendgenres(fieldGeneratorgenres.value[num]);
                  }
                fieldGeneratorgenres.value.Clear();
                fieldGeneratorgenres.have_value = false;
              }
            if (fieldGeneratorfreq.have_value)
              {
                result.setfreq(fieldGeneratorfreq.value);
                fieldGeneratorfreq.have_value = false;
              }
            if (fieldGeneratorband.have_value)
              {
                result.setband(fieldGeneratorband.value);
                fieldGeneratorband.have_value = false;
              }
            if (fieldGeneratorcallLetters.have_value)
              {
                result.setcallLetters(fieldGeneratorcallLetters.value);
                fieldGeneratorcallLetters.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioForYouAPIResponseContentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'b':
                    if ((String.Compare(field_name, 1, "and", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorband;
                    break;
                case 'c':
                    if ((String.Compare(field_name, 1, "allLetters", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorcallLetters;
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratordescription;
                    break;
                case 'f':
                    if ((String.Compare(field_name, 1, "req", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorfreq;
                    break;
                case 'g':
                    if ((String.Compare(field_name, 1, "enres", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorgenres;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "ogo", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorlogo;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "treams", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorstreams;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorlogo = new JSONHoldingStringGenerator("field \"logo\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorstreams = new IHeartRadioLiveStationsAPIResponseStreamJSON.HoldingGenerator("field \"streams\" of the IHeartRadioForYouAPIResponseContent class", ignore_extras);
            fieldGeneratordescription = new JSONHoldingStringGenerator("field \"description\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorgenres = new IHeartRadioLiveStationsAPIResponseGenreJSON.HoldingArrayGenerator("field \"genres\" of the IHeartRadioForYouAPIResponseContent class", ignore_extras);
            fieldGeneratorfreq = new JSONHoldingStringGenerator("field \"freq\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorband = new JSONHoldingStringGenerator("field \"band\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorcallLetters = new JSONHoldingStringGenerator("field \"callLetters\" of the IHeartRadioForYouAPIResponseContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioForYouAPIResponseContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorlogo = new JSONHoldingStringGenerator("field \"logo\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorstreams = new IHeartRadioLiveStationsAPIResponseStreamJSON.HoldingGenerator("field \"streams\" of the IHeartRadioForYouAPIResponseContent class", false);
            fieldGeneratordescription = new JSONHoldingStringGenerator("field \"description\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorgenres = new IHeartRadioLiveStationsAPIResponseGenreJSON.HoldingArrayGenerator("field \"genres\" of the IHeartRadioForYouAPIResponseContent class", false);
            fieldGeneratorfreq = new JSONHoldingStringGenerator("field \"freq\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorband = new JSONHoldingStringGenerator("field \"band\" of the IHeartRadioForYouAPIResponseContent class");
            fieldGeneratorcallLetters = new JSONHoldingStringGenerator("field \"callLetters\" of the IHeartRadioForYouAPIResponseContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioForYouAPIResponseContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratorname.reset();
            fieldGeneratorlogo.reset();
            fieldGeneratorstreams.reset();
            fieldGeneratordescription.reset();
            fieldGeneratorgenres.reset();
            fieldGeneratorfreq.reset();
            fieldGeneratorband.reset();
            fieldGeneratorcallLetters.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorstreams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorgenres.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorstreams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorgenres.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioForYouAPIResponseContentJSON  result)
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
        public IHeartRadioForYouAPIResponseContentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioForYouAPIResponseContentJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioForYouAPIResponseContentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioForYouAPIResponseContentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioForYouAPIResponseContentJSON>();
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
    public List<IHeartRadioForYouAPIResponseContentJSON> value;
  };
  };
