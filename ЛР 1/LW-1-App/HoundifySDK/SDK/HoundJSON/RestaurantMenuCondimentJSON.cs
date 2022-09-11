/* file "RestaurantMenuCondimentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuCondimentJSON : JSONBase
  {
    private bool flagHasCondimentId;
    private BigInteger storeCondimentId;
    private bool flagHasExternalCondimentId;
    private BigInteger storeExternalCondimentId;
    private bool flagHasCondimentName;
    private string storeCondimentName;
    private bool flagHasCondimentNameSpoken;
    private string storeCondimentNameSpoken;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCondimentId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CondimentId of RestaurantMenuCondimentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CondimentId of RestaurantMenuCondimentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCondimentId(extracted_integer);
      }


    private void  fromJSONExternalCondimentId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ExternalCondimentId of RestaurantMenuCondimentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ExternalCondimentId of RestaurantMenuCondimentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setExternalCondimentId(extracted_integer);
      }


    private void  fromJSONCondimentName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CondimentName of RestaurantMenuCondimentJSON is not a string.");
        setCondimentName(json_string.getData());
      }


    private void  fromJSONCondimentNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CondimentNameSpoken of RestaurantMenuCondimentJSON is not a string.");
        setCondimentNameSpoken(json_string.getData());
      }


    public RestaurantMenuCondimentJSON()
      {
        flagHasCondimentId = false;
        flagHasExternalCondimentId = false;
        flagHasCondimentName = false;
        flagHasCondimentNameSpoken = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCondimentId()
      {
        return flagHasCondimentId;
      }

    public BigInteger  getCondimentId()
      {
        Debug.Assert(flagHasCondimentId);
        return storeCondimentId;
      }

    public bool  hasExternalCondimentId()
      {
        return flagHasExternalCondimentId;
      }

    public BigInteger  getExternalCondimentId()
      {
        Debug.Assert(flagHasExternalCondimentId);
        return storeExternalCondimentId;
      }

    public bool  hasCondimentName()
      {
        return flagHasCondimentName;
      }

    public string  getCondimentName()
      {
        Debug.Assert(flagHasCondimentName);
        return storeCondimentName;
      }

    public bool  hasCondimentNameSpoken()
      {
        return flagHasCondimentNameSpoken;
      }

    public string  getCondimentNameSpoken()
      {
        Debug.Assert(flagHasCondimentNameSpoken);
        return storeCondimentNameSpoken;
      }


    public virtual int extraRestaurantMenuCondimentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuCondimentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCondimentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCondimentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCondimentId(BigInteger new_value)
      {
        flagHasCondimentId = true;
        storeCondimentId = new_value;
      }
    public void unsetCondimentId()
      {
        flagHasCondimentId = false;
      }
    public void setExternalCondimentId(BigInteger new_value)
      {
        flagHasExternalCondimentId = true;
        storeExternalCondimentId = new_value;
      }
    public void unsetExternalCondimentId()
      {
        flagHasExternalCondimentId = false;
      }
    public void setCondimentName(string new_value)
      {
        flagHasCondimentName = true;
        storeCondimentName = new_value;
      }
    public void unsetCondimentName()
      {
        flagHasCondimentName = false;
      }
    public void setCondimentNameSpoken(string new_value)
      {
        flagHasCondimentNameSpoken = true;
        storeCondimentNameSpoken = new_value;
      }
    public void unsetCondimentNameSpoken()
      {
        flagHasCondimentNameSpoken = false;
      }

    public virtual void extraRestaurantMenuCondimentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuCondimentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuCondimentLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuCondimentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCondimentId);
        if (flagHasCondimentId)
          {
            handler.start_pair("CondimentId");
            handler.number_value(storeCondimentId);
          }
        Debug.Assert(partial_allowed || flagHasExternalCondimentId);
        if (flagHasExternalCondimentId)
          {
            handler.start_pair("ExternalCondimentId");
            handler.number_value(storeExternalCondimentId);
          }
        Debug.Assert(partial_allowed || flagHasCondimentName);
        if (flagHasCondimentName)
          {
            handler.start_pair("CondimentName");
            handler.string_value(storeCondimentName);
          }
        if (flagHasCondimentNameSpoken)
          {
            handler.start_pair("CondimentNameSpoken");
            handler.string_value(storeCondimentNameSpoken);
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
        if (!(hasCondimentId()))
          {
            return "When parsing the object for %what%, the \"CondimentId\" field was missing.";
          }
        if (!(hasExternalCondimentId()))
          {
            return "When parsing the object for %what%, the \"ExternalCondimentId\" field was missing.";
          }
        if (!(hasCondimentName()))
          {
            return "When parsing the object for %what%, the \"CondimentName\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuCondimentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCondimentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCondiment", ignore_extras);
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
    public static RestaurantMenuCondimentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCondimentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCondimentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCondiment", ignore_extras);
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
    public static RestaurantMenuCondimentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCondimentJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuCondimentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCondiment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuCondimentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuCondimentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuCondimentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCondiment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorCondimentId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCondimentId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCondimentId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCondimentId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCondimentId fieldGeneratorCondimentId;
    private class FieldHoldingGeneratorExternalCondimentId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorExternalCondimentId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorExternalCondimentId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorExternalCondimentId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorExternalCondimentId fieldGeneratorExternalCondimentId;
        private JSONHoldingStringGenerator fieldGeneratorCondimentName;
        private JSONHoldingStringGenerator fieldGeneratorCondimentNameSpoken;
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
            RestaurantMenuCondimentJSON result = new RestaurantMenuCondimentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuCondimentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuCondimentJSON result)
          {
            if (fieldGeneratorCondimentId.have_value)
              {
                result.setCondimentId(fieldGeneratorCondimentId.value);
                fieldGeneratorCondimentId.have_value = false;
              }
            else if ((!(result.hasCondimentId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CondimentId\" field was missing.");
              }
            if (fieldGeneratorExternalCondimentId.have_value)
              {
                result.setExternalCondimentId(fieldGeneratorExternalCondimentId.value);
                fieldGeneratorExternalCondimentId.have_value = false;
              }
            else if ((!(result.hasExternalCondimentId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExternalCondimentId\" field was missing.");
              }
            if (fieldGeneratorCondimentName.have_value)
              {
                result.setCondimentName(fieldGeneratorCondimentName.value);
                fieldGeneratorCondimentName.have_value = false;
              }
            else if ((!(result.hasCondimentName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CondimentName\" field was missing.");
              }
            if (fieldGeneratorCondimentNameSpoken.have_value)
              {
                result.setCondimentNameSpoken(fieldGeneratorCondimentNameSpoken.value);
                fieldGeneratorCondimentNameSpoken.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuCondimentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ondiment", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "d", 0, 1, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCondimentId;
                                break;
                            case 'N':
                                if (String.Compare(field_name, 10, "ame", 0, 3, false) == 0)
                                  {
                                    if (field_name.Length == 13)
                                      {
                                        return fieldGeneratorCondimentName;
                                      }
                                    switch (field_name[13])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 14, "poken", 0, 5, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorCondimentNameSpoken;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "xternalCondimentId", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorExternalCondimentId;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCondimentId = new FieldHoldingGeneratorCondimentId("field \"CondimentId\" of the RestaurantMenuCondiment class");
            fieldGeneratorExternalCondimentId = new FieldHoldingGeneratorExternalCondimentId("field \"ExternalCondimentId\" of the RestaurantMenuCondiment class");
            fieldGeneratorCondimentName = new JSONHoldingStringGenerator("field \"CondimentName\" of the RestaurantMenuCondiment class");
            fieldGeneratorCondimentNameSpoken = new JSONHoldingStringGenerator("field \"CondimentNameSpoken\" of the RestaurantMenuCondiment class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuCondiment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCondimentId = new FieldHoldingGeneratorCondimentId("field \"CondimentId\" of the RestaurantMenuCondiment class");
            fieldGeneratorExternalCondimentId = new FieldHoldingGeneratorExternalCondimentId("field \"ExternalCondimentId\" of the RestaurantMenuCondiment class");
            fieldGeneratorCondimentName = new JSONHoldingStringGenerator("field \"CondimentName\" of the RestaurantMenuCondiment class");
            fieldGeneratorCondimentNameSpoken = new JSONHoldingStringGenerator("field \"CondimentNameSpoken\" of the RestaurantMenuCondiment class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuCondiment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCondimentId.reset();
            fieldGeneratorExternalCondimentId.reset();
            fieldGeneratorCondimentName.reset();
            fieldGeneratorCondimentNameSpoken.reset();
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
        protected override void handle_result(RestaurantMenuCondimentJSON  result)
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
        public RestaurantMenuCondimentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuCondimentJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuCondimentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuCondimentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuCondimentJSON>();
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
    public List<RestaurantMenuCondimentJSON> value;
  };
  };
