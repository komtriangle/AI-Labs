/* file "OutlookPhysicalAddressJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OutlookPhysicalAddressJSON : JSONBase
  {
    private bool flagHascity;
    private string storecity;
    private bool flagHascountryOrRegion;
    private string storecountryOrRegion;
    private bool flagHaspostalCode;
    private string storepostalCode;
    private bool flagHasstate;
    private string storestate;
    private bool flagHasstreet;
    private string storestreet;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONcity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field city of OutlookPhysicalAddressJSON is not a string.");
        setcity(json_string.getData());
      }


    private void  fromJSONcountryOrRegion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field countryOrRegion of OutlookPhysicalAddressJSON is not a string.");
        setcountryOrRegion(json_string.getData());
      }


    private void  fromJSONpostalCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field postalCode of OutlookPhysicalAddressJSON is not a string.");
        setpostalCode(json_string.getData());
      }


    private void  fromJSONstate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field state of OutlookPhysicalAddressJSON is not a string.");
        setstate(json_string.getData());
      }


    private void  fromJSONstreet(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field street of OutlookPhysicalAddressJSON is not a string.");
        setstreet(json_string.getData());
      }


    public OutlookPhysicalAddressJSON()
      {
        flagHascity = false;
        flagHascountryOrRegion = false;
        flagHaspostalCode = false;
        flagHasstate = false;
        flagHasstreet = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hascity()
      {
        return flagHascity;
      }

    public string  getcity()
      {
        Debug.Assert(flagHascity);
        return storecity;
      }

    public bool  hascountryOrRegion()
      {
        return flagHascountryOrRegion;
      }

    public string  getcountryOrRegion()
      {
        Debug.Assert(flagHascountryOrRegion);
        return storecountryOrRegion;
      }

    public bool  haspostalCode()
      {
        return flagHaspostalCode;
      }

    public string  getpostalCode()
      {
        Debug.Assert(flagHaspostalCode);
        return storepostalCode;
      }

    public bool  hasstate()
      {
        return flagHasstate;
      }

    public string  getstate()
      {
        Debug.Assert(flagHasstate);
        return storestate;
      }

    public bool  hasstreet()
      {
        return flagHasstreet;
      }

    public string  getstreet()
      {
        Debug.Assert(flagHasstreet);
        return storestreet;
      }


    public virtual int extraOutlookPhysicalAddressComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOutlookPhysicalAddressComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOutlookPhysicalAddressComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOutlookPhysicalAddressLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setcity(string new_value)
      {
        flagHascity = true;
        storecity = new_value;
      }
    public void unsetcity()
      {
        flagHascity = false;
      }
    public void setcountryOrRegion(string new_value)
      {
        flagHascountryOrRegion = true;
        storecountryOrRegion = new_value;
      }
    public void unsetcountryOrRegion()
      {
        flagHascountryOrRegion = false;
      }
    public void setpostalCode(string new_value)
      {
        flagHaspostalCode = true;
        storepostalCode = new_value;
      }
    public void unsetpostalCode()
      {
        flagHaspostalCode = false;
      }
    public void setstate(string new_value)
      {
        flagHasstate = true;
        storestate = new_value;
      }
    public void unsetstate()
      {
        flagHasstate = false;
      }
    public void setstreet(string new_value)
      {
        flagHasstreet = true;
        storestreet = new_value;
      }
    public void unsetstreet()
      {
        flagHasstreet = false;
      }

    public virtual void extraOutlookPhysicalAddressAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOutlookPhysicalAddressSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOutlookPhysicalAddressLookup(key);
        if (old_field == null)
          {
            extraOutlookPhysicalAddressAppendPair(key, new_component);
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
        if (flagHascity)
          {
            handler.start_pair("city");
            handler.string_value(storecity);
          }
        if (flagHascountryOrRegion)
          {
            handler.start_pair("countryOrRegion");
            handler.string_value(storecountryOrRegion);
          }
        if (flagHaspostalCode)
          {
            handler.start_pair("postalCode");
            handler.string_value(storepostalCode);
          }
        if (flagHasstate)
          {
            handler.start_pair("state");
            handler.string_value(storestate);
          }
        if (flagHasstreet)
          {
            handler.start_pair("street");
            handler.string_value(storestreet);
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

    public static OutlookPhysicalAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookPhysicalAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPhysicalAddress", ignore_extras);
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
    public static OutlookPhysicalAddressJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookPhysicalAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OutlookPhysicalAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPhysicalAddress", ignore_extras);
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
    public static OutlookPhysicalAddressJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OutlookPhysicalAddressJSON from_text(string text, bool ignore_extras)
      {
        OutlookPhysicalAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPhysicalAddress", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OutlookPhysicalAddressJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OutlookPhysicalAddressJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OutlookPhysicalAddressJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OutlookPhysicalAddress", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorcity;
        private JSONHoldingStringGenerator fieldGeneratorcountryOrRegion;
        private JSONHoldingStringGenerator fieldGeneratorpostalCode;
        private JSONHoldingStringGenerator fieldGeneratorstate;
        private JSONHoldingStringGenerator fieldGeneratorstreet;
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
            OutlookPhysicalAddressJSON result = new OutlookPhysicalAddressJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOutlookPhysicalAddressAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OutlookPhysicalAddressJSON result)
          {
            if (fieldGeneratorcity.have_value)
              {
                result.setcity(fieldGeneratorcity.value);
                fieldGeneratorcity.have_value = false;
              }
            if (fieldGeneratorcountryOrRegion.have_value)
              {
                result.setcountryOrRegion(fieldGeneratorcountryOrRegion.value);
                fieldGeneratorcountryOrRegion.have_value = false;
              }
            if (fieldGeneratorpostalCode.have_value)
              {
                result.setpostalCode(fieldGeneratorpostalCode.value);
                fieldGeneratorpostalCode.have_value = false;
              }
            if (fieldGeneratorstate.have_value)
              {
                result.setstate(fieldGeneratorstate.value);
                fieldGeneratorstate.have_value = false;
              }
            if (fieldGeneratorstreet.have_value)
              {
                result.setstreet(fieldGeneratorstreet.value);
                fieldGeneratorstreet.have_value = false;
              }
          }
        protected abstract void handle_result(OutlookPhysicalAddressJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ty", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorcity;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "untryOrRegion", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorcountryOrRegion;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "ostalCode", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorpostalCode;
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "t", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 3, "te", 0, 2, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorstate;
                                break;
                            case 'r':
                                if ((String.Compare(field_name, 3, "eet", 0, 3, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorstreet;
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
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the OutlookPhysicalAddress class");
            fieldGeneratorcountryOrRegion = new JSONHoldingStringGenerator("field \"countryOrRegion\" of the OutlookPhysicalAddress class");
            fieldGeneratorpostalCode = new JSONHoldingStringGenerator("field \"postalCode\" of the OutlookPhysicalAddress class");
            fieldGeneratorstate = new JSONHoldingStringGenerator("field \"state\" of the OutlookPhysicalAddress class");
            fieldGeneratorstreet = new JSONHoldingStringGenerator("field \"street\" of the OutlookPhysicalAddress class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OutlookPhysicalAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the OutlookPhysicalAddress class");
            fieldGeneratorcountryOrRegion = new JSONHoldingStringGenerator("field \"countryOrRegion\" of the OutlookPhysicalAddress class");
            fieldGeneratorpostalCode = new JSONHoldingStringGenerator("field \"postalCode\" of the OutlookPhysicalAddress class");
            fieldGeneratorstate = new JSONHoldingStringGenerator("field \"state\" of the OutlookPhysicalAddress class");
            fieldGeneratorstreet = new JSONHoldingStringGenerator("field \"street\" of the OutlookPhysicalAddress class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OutlookPhysicalAddress class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorcity.reset();
            fieldGeneratorcountryOrRegion.reset();
            fieldGeneratorpostalCode.reset();
            fieldGeneratorstate.reset();
            fieldGeneratorstreet.reset();
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
        protected override void handle_result(OutlookPhysicalAddressJSON  result)
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
        public OutlookPhysicalAddressJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OutlookPhysicalAddressJSON  result)
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
    protected virtual void handle_result(List<OutlookPhysicalAddressJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OutlookPhysicalAddressJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OutlookPhysicalAddressJSON>();
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
    public List<OutlookPhysicalAddressJSON> value;
  };
  };
