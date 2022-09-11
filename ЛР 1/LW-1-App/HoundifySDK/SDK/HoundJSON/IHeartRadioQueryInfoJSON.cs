/* file "IHeartRadioQueryInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioQueryInfoJSON : JSONBase
  {
    private bool flagHasGenreId;
    private BigInteger storeGenreId;
    private bool flagHasGenreName;
    private string storeGenreName;
    private bool flagHasStationId;
    private BigInteger storeStationId;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasUserRequestedLocationRetrievalSuccess;
    private bool storeUserRequestedLocationRetrievalSuccess;
    private bool flagHasFrequency;
    private string storeFrequency;
    private bool flagHasUserSpecifiedPopularStations;
    private bool storeUserSpecifiedPopularStations;
    private bool flagHasAffiliation;
    private string storeAffiliation;
    private bool flagHasUserDidNotProvideEnoughContextForStationTypes;
    private bool storeUserDidNotProvideEnoughContextForStationTypes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGenreId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GenreId of IHeartRadioQueryInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GenreId of IHeartRadioQueryInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGenreId(extracted_integer);
      }


    private void  fromJSONGenreName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GenreName of IHeartRadioQueryInfoJSON is not a string.");
        setGenreName(json_string.getData());
      }


    private void  fromJSONStationId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StationId of IHeartRadioQueryInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StationId of IHeartRadioQueryInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStationId(extracted_integer);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONUserRequestedLocationRetrievalSuccess(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UserRequestedLocationRetrievalSuccess of IHeartRadioQueryInfoJSON is not true for false.");
              }
          }
        setUserRequestedLocationRetrievalSuccess(the_bool);
      }


    private void  fromJSONFrequency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Frequency of IHeartRadioQueryInfoJSON is not a string.");
        setFrequency(json_string.getData());
      }


    private void  fromJSONUserSpecifiedPopularStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UserSpecifiedPopularStations of IHeartRadioQueryInfoJSON is not true for false.");
              }
          }
        setUserSpecifiedPopularStations(the_bool);
      }


    private void  fromJSONAffiliation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Affiliation of IHeartRadioQueryInfoJSON is not a string.");
        setAffiliation(json_string.getData());
      }


    private void  fromJSONUserDidNotProvideEnoughContextForStationTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field UserDidNotProvideEnoughContextForStationTypes of IHeartRadioQueryInfoJSON is not true for false.");
              }
          }
        setUserDidNotProvideEnoughContextForStationTypes(the_bool);
      }


    public IHeartRadioQueryInfoJSON()
      {
        flagHasGenreId = false;
        flagHasGenreName = false;
        flagHasStationId = false;
        flagHasLocation = false;
        flagHasUserRequestedLocationRetrievalSuccess = false;
        flagHasFrequency = false;
        flagHasUserSpecifiedPopularStations = false;
        flagHasAffiliation = false;
        flagHasUserDidNotProvideEnoughContextForStationTypes = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGenreId()
      {
        return flagHasGenreId;
      }

    public BigInteger  getGenreId()
      {
        Debug.Assert(flagHasGenreId);
        return storeGenreId;
      }

    public bool  hasGenreName()
      {
        return flagHasGenreName;
      }

    public string  getGenreName()
      {
        Debug.Assert(flagHasGenreName);
        return storeGenreName;
      }

    public bool  hasStationId()
      {
        return flagHasStationId;
      }

    public BigInteger  getStationId()
      {
        Debug.Assert(flagHasStationId);
        return storeStationId;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasUserRequestedLocationRetrievalSuccess()
      {
        return flagHasUserRequestedLocationRetrievalSuccess;
      }

    public bool  getUserRequestedLocationRetrievalSuccess()
      {
        Debug.Assert(flagHasUserRequestedLocationRetrievalSuccess);
        return storeUserRequestedLocationRetrievalSuccess;
      }

    public bool  hasFrequency()
      {
        return flagHasFrequency;
      }

    public string  getFrequency()
      {
        Debug.Assert(flagHasFrequency);
        return storeFrequency;
      }

    public bool  hasUserSpecifiedPopularStations()
      {
        return flagHasUserSpecifiedPopularStations;
      }

    public bool  getUserSpecifiedPopularStations()
      {
        Debug.Assert(flagHasUserSpecifiedPopularStations);
        return storeUserSpecifiedPopularStations;
      }

    public bool  hasAffiliation()
      {
        return flagHasAffiliation;
      }

    public string  getAffiliation()
      {
        Debug.Assert(flagHasAffiliation);
        return storeAffiliation;
      }

    public bool  hasUserDidNotProvideEnoughContextForStationTypes()
      {
        return flagHasUserDidNotProvideEnoughContextForStationTypes;
      }

    public bool  getUserDidNotProvideEnoughContextForStationTypes()
      {
        Debug.Assert(flagHasUserDidNotProvideEnoughContextForStationTypes);
        return storeUserDidNotProvideEnoughContextForStationTypes;
      }


    public virtual int extraIHeartRadioQueryInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioQueryInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioQueryInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioQueryInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGenreId(BigInteger new_value)
      {
        flagHasGenreId = true;
        if (new_value < 0)
            throw new Exception("The value for field GenreId of IHeartRadioQueryInfoJSON is less than the lower bound (0) for that field.");
        storeGenreId = new_value;
      }
    public void unsetGenreId()
      {
        flagHasGenreId = false;
      }
    public void setGenreName(string new_value)
      {
        flagHasGenreName = true;
        storeGenreName = new_value;
      }
    public void unsetGenreName()
      {
        flagHasGenreName = false;
      }
    public void setStationId(BigInteger new_value)
      {
        flagHasStationId = true;
        if (new_value < 0)
            throw new Exception("The value for field StationId of IHeartRadioQueryInfoJSON is less than the lower bound (0) for that field.");
        storeStationId = new_value;
      }
    public void unsetStationId()
      {
        flagHasStationId = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setUserRequestedLocationRetrievalSuccess(bool new_value)
      {
        flagHasUserRequestedLocationRetrievalSuccess = true;
        storeUserRequestedLocationRetrievalSuccess = new_value;
      }
    public void unsetUserRequestedLocationRetrievalSuccess()
      {
        flagHasUserRequestedLocationRetrievalSuccess = false;
      }
    public void setFrequency(string new_value)
      {
        flagHasFrequency = true;
        storeFrequency = new_value;
      }
    public void unsetFrequency()
      {
        flagHasFrequency = false;
      }
    public void setUserSpecifiedPopularStations(bool new_value)
      {
        flagHasUserSpecifiedPopularStations = true;
        storeUserSpecifiedPopularStations = new_value;
      }
    public void unsetUserSpecifiedPopularStations()
      {
        flagHasUserSpecifiedPopularStations = false;
      }
    public void setAffiliation(string new_value)
      {
        flagHasAffiliation = true;
        storeAffiliation = new_value;
      }
    public void unsetAffiliation()
      {
        flagHasAffiliation = false;
      }
    public void setUserDidNotProvideEnoughContextForStationTypes(bool new_value)
      {
        flagHasUserDidNotProvideEnoughContextForStationTypes = true;
        storeUserDidNotProvideEnoughContextForStationTypes = new_value;
      }
    public void unsetUserDidNotProvideEnoughContextForStationTypes()
      {
        flagHasUserDidNotProvideEnoughContextForStationTypes = false;
      }

    public virtual void extraIHeartRadioQueryInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioQueryInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioQueryInfoLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioQueryInfoAppendPair(key, new_component);
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
        if (flagHasGenreId)
          {
            handler.start_pair("GenreId");
            handler.number_value(storeGenreId);
          }
        if (flagHasGenreName)
          {
            handler.start_pair("GenreName");
            handler.string_value(storeGenreName);
          }
        if (flagHasStationId)
          {
            handler.start_pair("StationId");
            handler.number_value(storeStationId);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasUserRequestedLocationRetrievalSuccess)
          {
            handler.start_pair("UserRequestedLocationRetrievalSuccess");
            handler.boolean_value(storeUserRequestedLocationRetrievalSuccess);
          }
        if (flagHasFrequency)
          {
            handler.start_pair("Frequency");
            handler.string_value(storeFrequency);
          }
        if (flagHasUserSpecifiedPopularStations)
          {
            handler.start_pair("UserSpecifiedPopularStations");
            handler.boolean_value(storeUserSpecifiedPopularStations);
          }
        if (flagHasAffiliation)
          {
            handler.start_pair("Affiliation");
            handler.string_value(storeAffiliation);
          }
        if (flagHasUserDidNotProvideEnoughContextForStationTypes)
          {
            handler.start_pair("UserDidNotProvideEnoughContextForStationTypes");
            handler.boolean_value(storeUserDidNotProvideEnoughContextForStationTypes);
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

    public static IHeartRadioQueryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioQueryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioQueryInfo", ignore_extras);
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
    public static IHeartRadioQueryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioQueryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioQueryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioQueryInfo", ignore_extras);
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
    public static IHeartRadioQueryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioQueryInfoJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioQueryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioQueryInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioQueryInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioQueryInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioQueryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioQueryInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorGenreId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGenreId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGenreId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGenreId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGenreId fieldGeneratorGenreId;
        private JSONHoldingStringGenerator fieldGeneratorGenreName;
    private class FieldHoldingGeneratorStationId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStationId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStationId fieldGeneratorStationId;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedLocationRetrievalSuccess;
        private JSONHoldingStringGenerator fieldGeneratorFrequency;
        private JSONHoldingBooleanGenerator fieldGeneratorUserSpecifiedPopularStations;
        private JSONHoldingStringGenerator fieldGeneratorAffiliation;
        private JSONHoldingBooleanGenerator fieldGeneratorUserDidNotProvideEnoughContextForStationTypes;
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
            IHeartRadioQueryInfoJSON result = new IHeartRadioQueryInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioQueryInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioQueryInfoJSON result)
          {
            if (fieldGeneratorGenreId.have_value)
              {
                result.setGenreId(fieldGeneratorGenreId.value);
                fieldGeneratorGenreId.have_value = false;
              }
            if (fieldGeneratorGenreName.have_value)
              {
                result.setGenreName(fieldGeneratorGenreName.value);
                fieldGeneratorGenreName.have_value = false;
              }
            if (fieldGeneratorStationId.have_value)
              {
                result.setStationId(fieldGeneratorStationId.value);
                fieldGeneratorStationId.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorUserRequestedLocationRetrievalSuccess.have_value)
              {
                result.setUserRequestedLocationRetrievalSuccess(fieldGeneratorUserRequestedLocationRetrievalSuccess.value);
                fieldGeneratorUserRequestedLocationRetrievalSuccess.have_value = false;
              }
            if (fieldGeneratorFrequency.have_value)
              {
                result.setFrequency(fieldGeneratorFrequency.value);
                fieldGeneratorFrequency.have_value = false;
              }
            if (fieldGeneratorUserSpecifiedPopularStations.have_value)
              {
                result.setUserSpecifiedPopularStations(fieldGeneratorUserSpecifiedPopularStations.value);
                fieldGeneratorUserSpecifiedPopularStations.have_value = false;
              }
            if (fieldGeneratorAffiliation.have_value)
              {
                result.setAffiliation(fieldGeneratorAffiliation.value);
                fieldGeneratorAffiliation.have_value = false;
              }
            if (fieldGeneratorUserDidNotProvideEnoughContextForStationTypes.have_value)
              {
                result.setUserDidNotProvideEnoughContextForStationTypes(fieldGeneratorUserDidNotProvideEnoughContextForStationTypes.value);
                fieldGeneratorUserDidNotProvideEnoughContextForStationTypes.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioQueryInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ffiliation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAffiliation;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "requency", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFrequency;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "enre", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "d", 0, 1, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorGenreId;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorGenreName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tationId", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorStationId;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 5, "idNotProvideEnoughContextForStationTypes", 0, 40, false) == 0) && (field_name.Length == 45))
                                    return fieldGeneratorUserDidNotProvideEnoughContextForStationTypes;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 5, "equestedLocationRetrievalSuccess", 0, 32, false) == 0) && (field_name.Length == 37))
                                    return fieldGeneratorUserRequestedLocationRetrievalSuccess;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 5, "pecifiedPopularStations", 0, 23, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorUserSpecifiedPopularStations;
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
            fieldGeneratorGenreId = new FieldHoldingGeneratorGenreId("field \"GenreId\" of the IHeartRadioQueryInfo class");
            fieldGeneratorGenreName = new JSONHoldingStringGenerator("field \"GenreName\" of the IHeartRadioQueryInfo class");
            fieldGeneratorStationId = new FieldHoldingGeneratorStationId("field \"StationId\" of the IHeartRadioQueryInfo class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the IHeartRadioQueryInfo class", ignore_extras);
            fieldGeneratorUserRequestedLocationRetrievalSuccess = new JSONHoldingBooleanGenerator("field \"UserRequestedLocationRetrievalSuccess\" of the IHeartRadioQueryInfo class");
            fieldGeneratorFrequency = new JSONHoldingStringGenerator("field \"Frequency\" of the IHeartRadioQueryInfo class");
            fieldGeneratorUserSpecifiedPopularStations = new JSONHoldingBooleanGenerator("field \"UserSpecifiedPopularStations\" of the IHeartRadioQueryInfo class");
            fieldGeneratorAffiliation = new JSONHoldingStringGenerator("field \"Affiliation\" of the IHeartRadioQueryInfo class");
            fieldGeneratorUserDidNotProvideEnoughContextForStationTypes = new JSONHoldingBooleanGenerator("field \"UserDidNotProvideEnoughContextForStationTypes\" of the IHeartRadioQueryInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioQueryInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGenreId = new FieldHoldingGeneratorGenreId("field \"GenreId\" of the IHeartRadioQueryInfo class");
            fieldGeneratorGenreName = new JSONHoldingStringGenerator("field \"GenreName\" of the IHeartRadioQueryInfo class");
            fieldGeneratorStationId = new FieldHoldingGeneratorStationId("field \"StationId\" of the IHeartRadioQueryInfo class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the IHeartRadioQueryInfo class", false);
            fieldGeneratorUserRequestedLocationRetrievalSuccess = new JSONHoldingBooleanGenerator("field \"UserRequestedLocationRetrievalSuccess\" of the IHeartRadioQueryInfo class");
            fieldGeneratorFrequency = new JSONHoldingStringGenerator("field \"Frequency\" of the IHeartRadioQueryInfo class");
            fieldGeneratorUserSpecifiedPopularStations = new JSONHoldingBooleanGenerator("field \"UserSpecifiedPopularStations\" of the IHeartRadioQueryInfo class");
            fieldGeneratorAffiliation = new JSONHoldingStringGenerator("field \"Affiliation\" of the IHeartRadioQueryInfo class");
            fieldGeneratorUserDidNotProvideEnoughContextForStationTypes = new JSONHoldingBooleanGenerator("field \"UserDidNotProvideEnoughContextForStationTypes\" of the IHeartRadioQueryInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioQueryInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGenreId.reset();
            fieldGeneratorGenreName.reset();
            fieldGeneratorStationId.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorUserRequestedLocationRetrievalSuccess.reset();
            fieldGeneratorFrequency.reset();
            fieldGeneratorUserSpecifiedPopularStations.reset();
            fieldGeneratorAffiliation.reset();
            fieldGeneratorUserDidNotProvideEnoughContextForStationTypes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioQueryInfoJSON  result)
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
        public IHeartRadioQueryInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioQueryInfoJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioQueryInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioQueryInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioQueryInfoJSON>();
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
    public List<IHeartRadioQueryInfoJSON> value;
  };
  };
