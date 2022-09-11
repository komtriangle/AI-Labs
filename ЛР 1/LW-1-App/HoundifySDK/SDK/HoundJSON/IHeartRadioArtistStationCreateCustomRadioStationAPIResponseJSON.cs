/* file "IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON : JSONBase
  {
    private bool flagHasduration;
    private BigInteger storeduration;
    private bool flagHasname;
    private string storename;
    private bool flagHasid;
    private string storeid;
    private bool flagHasvariety;
    private string storevariety;
    private bool flagHaslastPlayedDate;
    private BigInteger storelastPlayedDate;
    private bool flagHasregisteredDate;
    private BigInteger storeregisteredDate;
    private bool flagHaslastModifiedDate;
    private BigInteger storelastModifiedDate;
    private bool flagHasstationType;
    private string storestationType;
    private bool flagHasplayCount;
    private BigInteger storeplayCount;
    private bool flagHasseedArtistId;
    private BigInteger storeseedArtistId;
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
                throw new Exception("The value for field duration of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field duration of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setduration(extracted_integer);
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field id of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a string.");
        setid(json_string.getData());
      }


    private void  fromJSONvariety(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field variety of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a string.");
        setvariety(json_string.getData());
      }


    private void  fromJSONlastPlayedDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field lastPlayedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field lastPlayedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setlastPlayedDate(extracted_integer);
      }


    private void  fromJSONregisteredDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field registeredDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field registeredDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setregisteredDate(extracted_integer);
      }


    private void  fromJSONlastModifiedDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field lastModifiedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field lastModifiedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setlastModifiedDate(extracted_integer);
      }


    private void  fromJSONstationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field stationType of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a string.");
        setstationType(json_string.getData());
      }


    private void  fromJSONplayCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field playCount of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field playCount of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setplayCount(extracted_integer);
      }


    private void  fromJSONseedArtistId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field seedArtistId of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field seedArtistId of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setseedArtistId(extracted_integer);
      }


    public IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON()
      {
        flagHasduration = false;
        flagHasname = false;
        flagHasid = false;
        flagHasvariety = false;
        flagHaslastPlayedDate = false;
        flagHasregisteredDate = false;
        flagHaslastModifiedDate = false;
        flagHasstationType = false;
        flagHasplayCount = false;
        flagHasseedArtistId = false;
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

    public bool  hasname()
      {
        return flagHasname;
      }

    public string  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public string  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasvariety()
      {
        return flagHasvariety;
      }

    public string  getvariety()
      {
        Debug.Assert(flagHasvariety);
        return storevariety;
      }

    public bool  haslastPlayedDate()
      {
        return flagHaslastPlayedDate;
      }

    public BigInteger  getlastPlayedDate()
      {
        Debug.Assert(flagHaslastPlayedDate);
        return storelastPlayedDate;
      }

    public bool  hasregisteredDate()
      {
        return flagHasregisteredDate;
      }

    public BigInteger  getregisteredDate()
      {
        Debug.Assert(flagHasregisteredDate);
        return storeregisteredDate;
      }

    public bool  haslastModifiedDate()
      {
        return flagHaslastModifiedDate;
      }

    public BigInteger  getlastModifiedDate()
      {
        Debug.Assert(flagHaslastModifiedDate);
        return storelastModifiedDate;
      }

    public bool  hasstationType()
      {
        return flagHasstationType;
      }

    public string  getstationType()
      {
        Debug.Assert(flagHasstationType);
        return storestationType;
      }

    public bool  hasplayCount()
      {
        return flagHasplayCount;
      }

    public BigInteger  getplayCount()
      {
        Debug.Assert(flagHasplayCount);
        return storeplayCount;
      }

    public bool  hasseedArtistId()
      {
        return flagHasseedArtistId;
      }

    public BigInteger  getseedArtistId()
      {
        Debug.Assert(flagHasseedArtistId);
        return storeseedArtistId;
      }


    public virtual int extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setduration(BigInteger new_value)
      {
        flagHasduration = true;
        if (new_value < 0)
            throw new Exception("The value for field duration of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storeduration = new_value;
      }
    public void unsetduration()
      {
        flagHasduration = false;
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
    public void setid(string new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setvariety(string new_value)
      {
        flagHasvariety = true;
        storevariety = new_value;
      }
    public void unsetvariety()
      {
        flagHasvariety = false;
      }
    public void setlastPlayedDate(BigInteger new_value)
      {
        flagHaslastPlayedDate = true;
        if (new_value < 0)
            throw new Exception("The value for field lastPlayedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storelastPlayedDate = new_value;
      }
    public void unsetlastPlayedDate()
      {
        flagHaslastPlayedDate = false;
      }
    public void setregisteredDate(BigInteger new_value)
      {
        flagHasregisteredDate = true;
        if (new_value < 0)
            throw new Exception("The value for field registeredDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storeregisteredDate = new_value;
      }
    public void unsetregisteredDate()
      {
        flagHasregisteredDate = false;
      }
    public void setlastModifiedDate(BigInteger new_value)
      {
        flagHaslastModifiedDate = true;
        if (new_value < 0)
            throw new Exception("The value for field lastModifiedDate of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storelastModifiedDate = new_value;
      }
    public void unsetlastModifiedDate()
      {
        flagHaslastModifiedDate = false;
      }
    public void setstationType(string new_value)
      {
        flagHasstationType = true;
        storestationType = new_value;
      }
    public void unsetstationType()
      {
        flagHasstationType = false;
      }
    public void setplayCount(BigInteger new_value)
      {
        flagHasplayCount = true;
        if (new_value < 0)
            throw new Exception("The value for field playCount of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storeplayCount = new_value;
      }
    public void unsetplayCount()
      {
        flagHasplayCount = false;
      }
    public void setseedArtistId(BigInteger new_value)
      {
        flagHasseedArtistId = true;
        if (new_value < 0)
            throw new Exception("The value for field seedArtistId of IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON is less than the lower bound (0) for that field.");
        storeseedArtistId = new_value;
      }
    public void unsetseedArtistId()
      {
        flagHasseedArtistId = false;
      }

    public virtual void extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.string_value(storeid);
          }
        if (flagHasvariety)
          {
            handler.start_pair("variety");
            handler.string_value(storevariety);
          }
        if (flagHaslastPlayedDate)
          {
            handler.start_pair("lastPlayedDate");
            handler.number_value(storelastPlayedDate);
          }
        if (flagHasregisteredDate)
          {
            handler.start_pair("registeredDate");
            handler.number_value(storeregisteredDate);
          }
        if (flagHaslastModifiedDate)
          {
            handler.start_pair("lastModifiedDate");
            handler.number_value(storelastModifiedDate);
          }
        Debug.Assert(partial_allowed || flagHasstationType);
        if (flagHasstationType)
          {
            handler.start_pair("stationType");
            handler.string_value(storestationType);
          }
        if (flagHasplayCount)
          {
            handler.start_pair("playCount");
            handler.number_value(storeplayCount);
          }
        if (flagHasseedArtistId)
          {
            handler.start_pair("seedArtistId");
            handler.number_value(storeseedArtistId);
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        if (!(hasstationType()))
          {
            return "When parsing the object for %what%, the \"stationType\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationCreateCustomRadioStationAPIResponse", ignore_extras);
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
    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationCreateCustomRadioStationAPIResponse", ignore_extras);
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
    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationCreateCustomRadioStationAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationCreateCustomRadioStationAPIResponse", ignore_extras);
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
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingStringGenerator fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratorvariety;
    private class FieldHoldingGeneratorlastPlayedDate : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorlastPlayedDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorlastPlayedDate : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorlastPlayedDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorlastPlayedDate fieldGeneratorlastPlayedDate;
    private class FieldHoldingGeneratorregisteredDate : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorregisteredDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorregisteredDate : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorregisteredDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorregisteredDate fieldGeneratorregisteredDate;
    private class FieldHoldingGeneratorlastModifiedDate : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorlastModifiedDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorlastModifiedDate : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorlastModifiedDate(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorlastModifiedDate fieldGeneratorlastModifiedDate;
        private JSONHoldingStringGenerator fieldGeneratorstationType;
    private class FieldHoldingGeneratorplayCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorplayCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorplayCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorplayCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorplayCount fieldGeneratorplayCount;
    private class FieldHoldingGeneratorseedArtistId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorseedArtistId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorseedArtistId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorseedArtistId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorseedArtistId fieldGeneratorseedArtistId;
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
            IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result = new IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioArtistStationCreateCustomRadioStationAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON result)
          {
            if (fieldGeneratorduration.have_value)
              {
                result.setduration(fieldGeneratorduration.value);
                fieldGeneratorduration.have_value = false;
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
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratorvariety.have_value)
              {
                result.setvariety(fieldGeneratorvariety.value);
                fieldGeneratorvariety.have_value = false;
              }
            if (fieldGeneratorlastPlayedDate.have_value)
              {
                result.setlastPlayedDate(fieldGeneratorlastPlayedDate.value);
                fieldGeneratorlastPlayedDate.have_value = false;
              }
            if (fieldGeneratorregisteredDate.have_value)
              {
                result.setregisteredDate(fieldGeneratorregisteredDate.value);
                fieldGeneratorregisteredDate.have_value = false;
              }
            if (fieldGeneratorlastModifiedDate.have_value)
              {
                result.setlastModifiedDate(fieldGeneratorlastModifiedDate.value);
                fieldGeneratorlastModifiedDate.have_value = false;
              }
            if (fieldGeneratorstationType.have_value)
              {
                result.setstationType(fieldGeneratorstationType.value);
                fieldGeneratorstationType.have_value = false;
              }
            else if ((!(result.hasstationType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stationType\" field was missing.");
              }
            if (fieldGeneratorplayCount.have_value)
              {
                result.setplayCount(fieldGeneratorplayCount.value);
                fieldGeneratorplayCount.have_value = false;
              }
            if (fieldGeneratorseedArtistId.have_value)
              {
                result.setseedArtistId(fieldGeneratorseedArtistId.value);
                fieldGeneratorseedArtistId.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorduration;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 'l':
                    if (String.Compare(field_name, 1, "ast", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'M':
                                if ((String.Compare(field_name, 5, "odifiedDate", 0, 11, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorlastModifiedDate;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 5, "layedDate", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorlastPlayedDate;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "layCount", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorplayCount;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "egisteredDate", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorregisteredDate;
                    break;
                case 's':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "edArtistId", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorseedArtistId;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ationType", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorstationType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'v':
                    if ((String.Compare(field_name, 1, "ariety", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorvariety;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorvariety = new JSONHoldingStringGenerator("field \"variety\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorlastPlayedDate = new FieldHoldingGeneratorlastPlayedDate("field \"lastPlayedDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorregisteredDate = new FieldHoldingGeneratorregisteredDate("field \"registeredDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorlastModifiedDate = new FieldHoldingGeneratorlastModifiedDate("field \"lastModifiedDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorstationType = new JSONHoldingStringGenerator("field \"stationType\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorplayCount = new FieldHoldingGeneratorplayCount("field \"playCount\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorseedArtistId = new FieldHoldingGeneratorseedArtistId("field \"seedArtistId\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorvariety = new JSONHoldingStringGenerator("field \"variety\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorlastPlayedDate = new FieldHoldingGeneratorlastPlayedDate("field \"lastPlayedDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorregisteredDate = new FieldHoldingGeneratorregisteredDate("field \"registeredDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorlastModifiedDate = new FieldHoldingGeneratorlastModifiedDate("field \"lastModifiedDate\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorstationType = new JSONHoldingStringGenerator("field \"stationType\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorplayCount = new FieldHoldingGeneratorplayCount("field \"playCount\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            fieldGeneratorseedArtistId = new FieldHoldingGeneratorseedArtistId("field \"seedArtistId\" of the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioArtistStationCreateCustomRadioStationAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorduration.reset();
            fieldGeneratorname.reset();
            fieldGeneratorid.reset();
            fieldGeneratorvariety.reset();
            fieldGeneratorlastPlayedDate.reset();
            fieldGeneratorregisteredDate.reset();
            fieldGeneratorlastModifiedDate.reset();
            fieldGeneratorstationType.reset();
            fieldGeneratorplayCount.reset();
            fieldGeneratorseedArtistId.reset();
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
        protected override void handle_result(IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON  result)
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
        public IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON>();
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
    public List<IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON> value;
  };
  };
