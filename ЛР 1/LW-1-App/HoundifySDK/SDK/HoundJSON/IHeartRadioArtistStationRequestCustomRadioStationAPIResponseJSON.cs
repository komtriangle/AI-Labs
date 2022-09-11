/* file "IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON : JSONBase
  {
    private bool flagHasduration;
    private BigInteger storeduration;
    private bool flagHasitems;
    private List< IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  > storeitems;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONduration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setduration(extracted_integer);
      }


    private void  fromJSONitems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field items of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  > vector_items1 = new List< IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON convert_classy = IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_items1.Add(convert_classy);
          }
        inititems();
        for (int num1 = 0; num1 < vector_items1.Count; ++num1)
            appenditems(vector_items1[num1]);
        for (int num1 = 0; num1 < vector_items1.Count; ++num1)
          {
          }
      }


    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON()
      {
        flagHasduration = false;
        flagHasitems = false;
        storeitems = new List< IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasduration()
      {
        return flagHasduration;
      }

    public BigInteger  getduration()
      {
        Debug.Assert(flagHasduration);
        return storeduration;
      }

    public bool  hasitems()
      {
        return flagHasitems;
      }

    public int  countOfitems()
      {
        Debug.Assert(flagHasitems);
        return storeitems.Count;
      }

    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON   elementOfitems(int element_num)
      {
        Debug.Assert(flagHasitems);
        return storeitems[element_num];
      }

    public List< IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  >  getitems()
      {
        Debug.Assert(flagHasitems);
        return storeitems;
      }


    public virtual int extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setduration(BigInteger new_value)
      {
        flagHasduration = true;
        if (new_value < 0)
            throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storeduration = new_value;
      }
    public void unsetduration()
      {
        flagHasduration = false;
      }
    public void inititems()
      {
        if (flagHasitems)
          {
            for (int num1 = 0; num1 < storeitems.Count; ++num1)
              {
              }
          }
        flagHasitems = true;
        storeitems.Clear();
      }
    public void appenditems(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  to_append)
      {
        if (!flagHasitems)
          {
            flagHasitems = true;
            storeitems.Clear();
          }
        Debug.Assert(flagHasitems);
        storeitems.Add(to_append);
      }
    public void unsetitems()
      {
        if (flagHasitems)
          {
            for (int num2 = 0; num2 < storeitems.Count; ++num2)
              {
              }
          }
        flagHasitems = false;
        storeitems.Clear();
      }

    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseAppendPair(key, new_component);
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
        if (flagHasduration)
          {
            handler.start_pair("duration");
            handler.number_value(storeduration);
          }
        Debug.Assert(partial_allowed || flagHasitems);
        if (flagHasitems)
          {
            handler.start_pair("items");
            handler.start_array();
            for (int num1 = 0; num1 < storeitems.Count; ++num1)
              {
                if (partial_allowed)
                    storeitems[num1].write_partial_as_json(handler);
                else
                    storeitems[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasitems()))
          {
            return "When parsing the object for %what%, the \"items\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponse", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponse", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorduration : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorduration : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorduration fieldGeneratorduration;
        private IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON.HoldingArrayGenerator fieldGeneratoritems;
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
            IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON result)
          {
            if (fieldGeneratorduration.have_value)
              {
                result.setduration(fieldGeneratorduration.value);
                fieldGeneratorduration.have_value = false;
              }
            if (fieldGeneratoritems.have_value)
              {
                result.inititems();
                int count = fieldGeneratoritems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appenditems(fieldGeneratoritems.value[num]);
                  }
                fieldGeneratoritems.value.Clear();
                fieldGeneratoritems.have_value = false;
              }
            else if ((!(result.hasitems())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"items\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorduration;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "tems", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratoritems;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class");
            fieldGeneratoritems = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON.HoldingArrayGenerator("field \"items\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class");
            fieldGeneratoritems = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON.HoldingArrayGenerator("field \"items\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorduration.reset();
            fieldGeneratoritems.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratoritems.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratoritems.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON  result)
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
        public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON>();
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
    public List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON> value;
  };
  };
