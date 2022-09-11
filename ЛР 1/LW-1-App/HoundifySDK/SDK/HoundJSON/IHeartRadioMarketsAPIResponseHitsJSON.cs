/* file "IHeartRadioMarketsAPIResponseHitsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioMarketsAPIResponseHitsJSON : JSONBase
  {
    private bool flagHasname;
    private string storename;
    private bool flagHasmarketId;
    private BigInteger storemarketId;
    private bool flagHasstationCount;
    private BigInteger storestationCount;
    private bool flagHasstateId;
    private string storestateId;
    private bool flagHasstateName;
    private string storestateName;
    private bool flagHascity;
    private string storecity;
    private bool flagHascountryName;
    private string storecountryName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of IHeartRadioMarketsAPIResponseHitsJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONmarketId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field marketId of IHeartRadioMarketsAPIResponseHitsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field marketId of IHeartRadioMarketsAPIResponseHitsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setmarketId(extracted_integer);
      }


    private void  fromJSONstationCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field stationCount of IHeartRadioMarketsAPIResponseHitsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field stationCount of IHeartRadioMarketsAPIResponseHitsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setstationCount(extracted_integer);
      }


    private void  fromJSONstateId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field stateId of IHeartRadioMarketsAPIResponseHitsJSON is not a string.");
        setstateId(json_string.getData());
      }


    private void  fromJSONstateName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field stateName of IHeartRadioMarketsAPIResponseHitsJSON is not a string.");
        setstateName(json_string.getData());
      }


    private void  fromJSONcity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field city of IHeartRadioMarketsAPIResponseHitsJSON is not a string.");
        setcity(json_string.getData());
      }


    private void  fromJSONcountryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field countryName of IHeartRadioMarketsAPIResponseHitsJSON is not a string.");
        setcountryName(json_string.getData());
      }


    public IHeartRadioMarketsAPIResponseHitsJSON()
      {
        flagHasname = false;
        flagHasmarketId = false;
        flagHasstationCount = false;
        flagHasstateId = false;
        flagHasstateName = false;
        flagHascity = false;
        flagHascountryName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasmarketId()
      {
        return flagHasmarketId;
      }

    public BigInteger  getmarketId()
      {
        Debug.Assert(flagHasmarketId);
        return storemarketId;
      }

    public bool  hasstationCount()
      {
        return flagHasstationCount;
      }

    public BigInteger  getstationCount()
      {
        Debug.Assert(flagHasstationCount);
        return storestationCount;
      }

    public bool  hasstateId()
      {
        return flagHasstateId;
      }

    public string  getstateId()
      {
        Debug.Assert(flagHasstateId);
        return storestateId;
      }

    public bool  hasstateName()
      {
        return flagHasstateName;
      }

    public string  getstateName()
      {
        Debug.Assert(flagHasstateName);
        return storestateName;
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

    public bool  hascountryName()
      {
        return flagHascountryName;
      }

    public string  getcountryName()
      {
        Debug.Assert(flagHascountryName);
        return storecountryName;
      }


    public virtual int extraIHeartRadioMarketsAPIResponseHitsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioMarketsAPIResponseHitsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioMarketsAPIResponseHitsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioMarketsAPIResponseHitsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setmarketId(BigInteger new_value)
      {
        flagHasmarketId = true;
        storemarketId = new_value;
      }
    public void unsetmarketId()
      {
        flagHasmarketId = false;
      }
    public void setstationCount(BigInteger new_value)
      {
        flagHasstationCount = true;
        storestationCount = new_value;
      }
    public void unsetstationCount()
      {
        flagHasstationCount = false;
      }
    public void setstateId(string new_value)
      {
        flagHasstateId = true;
        storestateId = new_value;
      }
    public void unsetstateId()
      {
        flagHasstateId = false;
      }
    public void setstateName(string new_value)
      {
        flagHasstateName = true;
        storestateName = new_value;
      }
    public void unsetstateName()
      {
        flagHasstateName = false;
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
    public void setcountryName(string new_value)
      {
        flagHascountryName = true;
        storecountryName = new_value;
      }
    public void unsetcountryName()
      {
        flagHascountryName = false;
      }

    public virtual void extraIHeartRadioMarketsAPIResponseHitsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioMarketsAPIResponseHitsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioMarketsAPIResponseHitsLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioMarketsAPIResponseHitsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasmarketId);
        if (flagHasmarketId)
          {
            handler.start_pair("marketId");
            handler.number_value(storemarketId);
          }
        Debug.Assert(partial_allowed || flagHasstationCount);
        if (flagHasstationCount)
          {
            handler.start_pair("stationCount");
            handler.number_value(storestationCount);
          }
        Debug.Assert(partial_allowed || flagHasstateId);
        if (flagHasstateId)
          {
            handler.start_pair("stateId");
            handler.string_value(storestateId);
          }
        Debug.Assert(partial_allowed || flagHasstateName);
        if (flagHasstateName)
          {
            handler.start_pair("stateName");
            handler.string_value(storestateName);
          }
        Debug.Assert(partial_allowed || flagHascity);
        if (flagHascity)
          {
            handler.start_pair("city");
            handler.string_value(storecity);
          }
        Debug.Assert(partial_allowed || flagHascountryName);
        if (flagHascountryName)
          {
            handler.start_pair("countryName");
            handler.string_value(storecountryName);
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
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        if (!(hasmarketId()))
          {
            return "When parsing the object for %what%, the \"marketId\" field was missing.";
          }
        if (!(hasstationCount()))
          {
            return "When parsing the object for %what%, the \"stationCount\" field was missing.";
          }
        if (!(hasstateId()))
          {
            return "When parsing the object for %what%, the \"stateId\" field was missing.";
          }
        if (!(hasstateName()))
          {
            return "When parsing the object for %what%, the \"stateName\" field was missing.";
          }
        if (!(hascity()))
          {
            return "When parsing the object for %what%, the \"city\" field was missing.";
          }
        if (!(hascountryName()))
          {
            return "When parsing the object for %what%, the \"countryName\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioMarketsAPIResponseHitsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioMarketsAPIResponseHitsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioMarketsAPIResponseHits", ignore_extras);
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
    public static IHeartRadioMarketsAPIResponseHitsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioMarketsAPIResponseHitsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioMarketsAPIResponseHitsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioMarketsAPIResponseHits", ignore_extras);
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
    public static IHeartRadioMarketsAPIResponseHitsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioMarketsAPIResponseHitsJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioMarketsAPIResponseHitsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioMarketsAPIResponseHits", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioMarketsAPIResponseHitsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioMarketsAPIResponseHitsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioMarketsAPIResponseHitsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioMarketsAPIResponseHits", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorname;
    private class FieldHoldingGeneratormarketId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratormarketId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratormarketId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratormarketId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratormarketId fieldGeneratormarketId;
    private class FieldHoldingGeneratorstationCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorstationCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorstationCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorstationCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorstationCount fieldGeneratorstationCount;
        private JSONHoldingStringGenerator fieldGeneratorstateId;
        private JSONHoldingStringGenerator fieldGeneratorstateName;
        private JSONHoldingStringGenerator fieldGeneratorcity;
        private JSONHoldingStringGenerator fieldGeneratorcountryName;
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
            IHeartRadioMarketsAPIResponseHitsJSON result = new IHeartRadioMarketsAPIResponseHitsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioMarketsAPIResponseHitsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioMarketsAPIResponseHitsJSON result)
          {
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            else if ((!(result.hasname())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"name\" field was missing.");
              }
            if (fieldGeneratormarketId.have_value)
              {
                result.setmarketId(fieldGeneratormarketId.value);
                fieldGeneratormarketId.have_value = false;
              }
            else if ((!(result.hasmarketId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"marketId\" field was missing.");
              }
            if (fieldGeneratorstationCount.have_value)
              {
                result.setstationCount(fieldGeneratorstationCount.value);
                fieldGeneratorstationCount.have_value = false;
              }
            else if ((!(result.hasstationCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stationCount\" field was missing.");
              }
            if (fieldGeneratorstateId.have_value)
              {
                result.setstateId(fieldGeneratorstateId.value);
                fieldGeneratorstateId.have_value = false;
              }
            else if ((!(result.hasstateId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stateId\" field was missing.");
              }
            if (fieldGeneratorstateName.have_value)
              {
                result.setstateName(fieldGeneratorstateName.value);
                fieldGeneratorstateName.have_value = false;
              }
            else if ((!(result.hasstateName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stateName\" field was missing.");
              }
            if (fieldGeneratorcity.have_value)
              {
                result.setcity(fieldGeneratorcity.value);
                fieldGeneratorcity.have_value = false;
              }
            else if ((!(result.hascity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"city\" field was missing.");
              }
            if (fieldGeneratorcountryName.have_value)
              {
                result.setcountryName(fieldGeneratorcountryName.value);
                fieldGeneratorcountryName.have_value = false;
              }
            else if ((!(result.hascountryName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"countryName\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioMarketsAPIResponseHitsJSON new_result);
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
                            if ((String.Compare(field_name, 2, "untryName", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorcountryName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'm':
                    if ((String.Compare(field_name, 1, "arketId", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratormarketId;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "tat", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'e':
                                switch (field_name[5])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 6, "d", 0, 1, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorstateId;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorstateName;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 5, "onCount", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorstationCount;
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
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratormarketId = new FieldHoldingGeneratormarketId("field \"marketId\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstationCount = new FieldHoldingGeneratorstationCount("field \"stationCount\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstateId = new JSONHoldingStringGenerator("field \"stateId\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstateName = new JSONHoldingStringGenerator("field \"stateName\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorcountryName = new JSONHoldingStringGenerator("field \"countryName\" of the IHeartRadioMarketsAPIResponseHits class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioMarketsAPIResponseHits class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratormarketId = new FieldHoldingGeneratormarketId("field \"marketId\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstationCount = new FieldHoldingGeneratorstationCount("field \"stationCount\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstateId = new JSONHoldingStringGenerator("field \"stateId\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorstateName = new JSONHoldingStringGenerator("field \"stateName\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorcity = new JSONHoldingStringGenerator("field \"city\" of the IHeartRadioMarketsAPIResponseHits class");
            fieldGeneratorcountryName = new JSONHoldingStringGenerator("field \"countryName\" of the IHeartRadioMarketsAPIResponseHits class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioMarketsAPIResponseHits class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorname.reset();
            fieldGeneratormarketId.reset();
            fieldGeneratorstationCount.reset();
            fieldGeneratorstateId.reset();
            fieldGeneratorstateName.reset();
            fieldGeneratorcity.reset();
            fieldGeneratorcountryName.reset();
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
        protected override void handle_result(IHeartRadioMarketsAPIResponseHitsJSON  result)
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
        public IHeartRadioMarketsAPIResponseHitsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioMarketsAPIResponseHitsJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioMarketsAPIResponseHitsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioMarketsAPIResponseHitsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioMarketsAPIResponseHitsJSON>();
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
    public List<IHeartRadioMarketsAPIResponseHitsJSON> value;
  };
  };
