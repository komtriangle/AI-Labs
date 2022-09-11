/* file "SportsTeamNewJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsTeamNewJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasNameShort;
    private string storeNameShort;
    private bool flagHasAlias;
    private string storeAlias;
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private bool flagHasDivision;
    private SportsLeagueDivisionJSON  storeDivision;
    private bool flagHasToBeDetermined;
    private bool storeToBeDetermined;
    private bool flagHasLogos;
    private List< SportsTeamLogoJSON  > storeLogos;
    private bool flagHasID;
    private string storeID;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of SportsTeamNewJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONNameShort(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NameShort of SportsTeamNewJSON is not a string.");
        setNameShort(json_string.getData());
      }


    private void  fromJSONAlias(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Alias of SportsTeamNewJSON is not a string.");
        setAlias(json_string.getData());
      }


    private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
        setLeague(convert_classy);
      }


    private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Latitude of SportsTeamNewJSON is not a number.");
              }
          }
        setLatitudeText(the_rational_text);
      }


    private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Longitude of SportsTeamNewJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    private void  fromJSONDivision(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_value, ignore_extras, true);
        setDivision(convert_classy);
      }


    private void  fromJSONToBeDetermined(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ToBeDetermined of SportsTeamNewJSON is not true for false.");
              }
          }
        setToBeDetermined(the_bool);
      }


    private void  fromJSONLogos(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Logos of SportsTeamNewJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsTeamLogoJSON  > vector_Logos1 = new List< SportsTeamLogoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamLogoJSON convert_classy = SportsTeamLogoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Logos1.Add(convert_classy);
          }
        initLogos();
        for (int num1 = 0; num1 < vector_Logos1.Count; ++num1)
            appendLogos(vector_Logos1[num1]);
        for (int num1 = 0; num1 < vector_Logos1.Count; ++num1)
          {
          }
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of SportsTeamNewJSON is not a string.");
        setID(json_string.getData());
      }


    public SportsTeamNewJSON()
      {
        flagHasName = false;
        flagHasNameShort = false;
        flagHasAlias = false;
        flagHasLeague = false;
        flagHasLatitude = false;
        flagHasLongitude = false;
        flagHasDivision = false;
        flagHasToBeDetermined = false;
        flagHasLogos = false;
        flagHasID = false;
        storeLogos = new List< SportsTeamLogoJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasNameShort()
      {
        return flagHasNameShort;
      }

    public string  getNameShort()
      {
        Debug.Assert(flagHasNameShort);
        return storeNameShort;
      }

    public bool  hasAlias()
      {
        return flagHasAlias;
      }

    public string  getAlias()
      {
        Debug.Assert(flagHasAlias);
        return storeAlias;
      }

    public bool  hasLeague()
      {
        return flagHasLeague;
      }

    public SportsLeagueCodeJSON   getLeague()
      {
        Debug.Assert(flagHasLeague);
        return storeLeague;
      }

    public SportsLeagueCodeJSON.TypeValue  getLeagueValue()
      {
        return getLeague().getValue();
      }

    public string  getLeagueAsString()
      {
        return getLeague().getValueAsString();
      }

    public bool  hasLatitude()
      {
        return flagHasLatitude;
      }

    public double  getLatitude()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude != "")
          {
            return Double.Parse(textStoreLatitude);
          }
        return storeLatitude;
      }

    public string  getLatitudeAsText()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude == "")
          {
            return Convert.ToString(storeLatitude);
          }
        else
          {
            return (textStoreLatitude);
          }
      }

    public bool  hasLongitude()
      {
        return flagHasLongitude;
      }

    public double  getLongitude()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude != "")
          {
            return Double.Parse(textStoreLongitude);
          }
        return storeLongitude;
      }

    public string  getLongitudeAsText()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude == "")
          {
            return Convert.ToString(storeLongitude);
          }
        else
          {
            return (textStoreLongitude);
          }
      }

    public bool  hasDivision()
      {
        return flagHasDivision;
      }

    public SportsLeagueDivisionJSON   getDivision()
      {
        Debug.Assert(flagHasDivision);
        return storeDivision;
      }

    public SportsLeagueDivisionJSON.TypeValue  getDivisionValue()
      {
        return getDivision().getValue();
      }

    public string  getDivisionAsString()
      {
        return getDivision().getValueAsString();
      }

    public bool  hasToBeDetermined()
      {
        return flagHasToBeDetermined;
      }

    public bool  getToBeDetermined()
      {
        Debug.Assert(flagHasToBeDetermined);
        return storeToBeDetermined;
      }

    public bool  hasLogos()
      {
        return flagHasLogos;
      }

    public int  countOfLogos()
      {
        Debug.Assert(flagHasLogos);
        return storeLogos.Count;
      }

    public SportsTeamLogoJSON   elementOfLogos(int element_num)
      {
        Debug.Assert(flagHasLogos);
        return storeLogos[element_num];
      }

    public List< SportsTeamLogoJSON  >  getLogos()
      {
        Debug.Assert(flagHasLogos);
        return storeLogos;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }


    public virtual int extraSportsTeamNewComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsTeamNewComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsTeamNewComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsTeamNewLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setNameShort(string new_value)
      {
        flagHasNameShort = true;
        storeNameShort = new_value;
      }
    public void unsetNameShort()
      {
        flagHasNameShort = false;
      }
    public void setAlias(string new_value)
      {
        flagHasAlias = true;
        storeAlias = new_value;
      }
    public void unsetAlias()
      {
        flagHasAlias = false;
      }
    public void setLeague(SportsLeagueCodeJSON  new_value)
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = true;
        storeLeague = new_value;
      }
    public void setLeague(SportsLeagueCodeJSON.TypeValue new_value)
      {
        setLeague(new SportsLeagueCodeJSON(new_value));
      }
    public void setLeague(string chars)
      {
        SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
        SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
        if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLeague(new_value);
      }
    public void unsetLeague()
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = false;
      }
    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        if (new_value < -90)
            throw new Exception("The value for field Latitude of SportsTeamNewJSON is less than the lower bound (-90) for that field.");
        if (new_value > 90)
            throw new Exception("The value for field Latitude of SportsTeamNewJSON is greater than the upper bound (90) for that field.");
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of SportsTeamNewJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
            throw new Exception("The value for field Latitude of SportsTeamNewJSON is less than the lower bound (-90) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
            throw new Exception("The value for field Latitude of SportsTeamNewJSON is greater than the upper bound (90) for that field.");
        textStoreLatitude = new_value;
      }
    public void unsetLatitude()
      {
        flagHasLatitude = false;
      }
    public void setLongitude(double new_value)
      {
        flagHasLongitude = true;
        if (new_value < -180)
            throw new Exception("The value for field Longitude of SportsTeamNewJSON is less than the lower bound (-180) for that field.");
        if (new_value > 180)
            throw new Exception("The value for field Longitude of SportsTeamNewJSON is greater than the upper bound (180) for that field.");
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of SportsTeamNewJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
            throw new Exception("The value for field Longitude of SportsTeamNewJSON is less than the lower bound (-180) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
            throw new Exception("The value for field Longitude of SportsTeamNewJSON is greater than the upper bound (180) for that field.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
      }
    public void setDivision(SportsLeagueDivisionJSON  new_value)
      {
        if (flagHasDivision)
          {
          }
        flagHasDivision = true;
        storeDivision = new_value;
      }
    public void setDivision(SportsLeagueDivisionJSON.TypeValue new_value)
      {
        setDivision(new SportsLeagueDivisionJSON(new_value));
      }
    public void setDivision(string chars)
      {
        SportsLeagueDivisionJSON.TypeValueKnownValues known = SportsLeagueDivisionJSON.stringToValue(chars);
        SportsLeagueDivisionJSON.TypeValue new_value = new SportsLeagueDivisionJSON.TypeValue();
        if (known == SportsLeagueDivisionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDivision(new_value);
      }
    public void unsetDivision()
      {
        if (flagHasDivision)
          {
          }
        flagHasDivision = false;
      }
    public void setToBeDetermined(bool new_value)
      {
        flagHasToBeDetermined = true;
        storeToBeDetermined = new_value;
      }
    public void unsetToBeDetermined()
      {
        flagHasToBeDetermined = false;
      }
    public void initLogos()
      {
        if (flagHasLogos)
          {
            for (int num1 = 0; num1 < storeLogos.Count; ++num1)
              {
              }
          }
        flagHasLogos = true;
        storeLogos.Clear();
      }
    public void appendLogos(SportsTeamLogoJSON  to_append)
      {
        if (!flagHasLogos)
          {
            flagHasLogos = true;
            storeLogos.Clear();
          }
        Debug.Assert(flagHasLogos);
        storeLogos.Add(to_append);
      }
    public void unsetLogos()
      {
        if (flagHasLogos)
          {
            for (int num2 = 0; num2 < storeLogos.Count; ++num2)
              {
              }
          }
        flagHasLogos = false;
        storeLogos.Clear();
      }
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }

    public virtual void extraSportsTeamNewAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsTeamNewSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsTeamNewLookup(key);
        if (old_field == null)
          {
            extraSportsTeamNewAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasNameShort)
          {
            handler.start_pair("NameShort");
            handler.string_value(storeNameShort);
          }
        if (flagHasAlias)
          {
            handler.start_pair("Alias");
            handler.string_value(storeAlias);
          }
        Debug.Assert(partial_allowed || flagHasLeague);
        if (flagHasLeague)
          {
            handler.start_pair("League");
            if (partial_allowed)
                storeLeague.write_partial_as_json(handler);
            else
                storeLeague.write_as_json(handler);
          }
        if (flagHasLatitude)
          {
            handler.start_pair("Latitude");
            if (textStoreLatitude != "")
                handler.number_value(textStoreLatitude);
            else if (((double)(long)storeLatitude) == storeLatitude)
                handler.number_value((long)storeLatitude);
            else
                handler.number_value(storeLatitude);
          }
        if (flagHasLongitude)
          {
            handler.start_pair("Longitude");
            if (textStoreLongitude != "")
                handler.number_value(textStoreLongitude);
            else if (((double)(long)storeLongitude) == storeLongitude)
                handler.number_value((long)storeLongitude);
            else
                handler.number_value(storeLongitude);
          }
        if (flagHasDivision)
          {
            handler.start_pair("Division");
            if (partial_allowed)
                storeDivision.write_partial_as_json(handler);
            else
                storeDivision.write_as_json(handler);
          }
        if (flagHasToBeDetermined)
          {
            handler.start_pair("ToBeDetermined");
            handler.boolean_value(storeToBeDetermined);
          }
        if (flagHasLogos)
          {
            handler.start_pair("Logos");
            handler.start_array();
            for (int num1 = 0; num1 < storeLogos.Count; ++num1)
              {
                if (partial_allowed)
                    storeLogos[num1].write_partial_as_json(handler);
                else
                    storeLogos[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasLeague()))
          {
            return "When parsing the object for %what%, the \"League\" field was missing.";
          }
        return null;
      }

    public static SportsTeamNewJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamNew", ignore_extras);
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
    public static SportsTeamNewJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamNewJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamNew", ignore_extras);
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
    public static SportsTeamNewJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamNewJSON from_text(string text, bool ignore_extras)
      {
        SportsTeamNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamNew", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsTeamNewJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsTeamNewJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsTeamNewJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamNew", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorNameShort;
        private JSONHoldingStringGenerator fieldGeneratorAlias;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
        private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivision;
        private JSONHoldingBooleanGenerator fieldGeneratorToBeDetermined;
        private SportsTeamLogoJSON.HoldingArrayGenerator fieldGeneratorLogos;
        private JSONHoldingStringGenerator fieldGeneratorID;
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
            SportsTeamNewJSON result = new SportsTeamNewJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsTeamNewAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsTeamNewJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorNameShort.have_value)
              {
                result.setNameShort(fieldGeneratorNameShort.value);
                fieldGeneratorNameShort.have_value = false;
              }
            if (fieldGeneratorAlias.have_value)
              {
                result.setAlias(fieldGeneratorAlias.value);
                fieldGeneratorAlias.have_value = false;
              }
            if (fieldGeneratorLeague.have_value)
              {
                result.setLeague(fieldGeneratorLeague.value);
                fieldGeneratorLeague.have_value = false;
              }
            else if ((!(result.hasLeague())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"League\" field was missing.");
              }
            if (fieldGeneratorLatitude.have_value)
              {
                result.setLatitudeText(fieldGeneratorLatitude.value);
                fieldGeneratorLatitude.have_value = false;
              }
            if (fieldGeneratorLongitude.have_value)
              {
                result.setLongitudeText(fieldGeneratorLongitude.value);
                fieldGeneratorLongitude.have_value = false;
              }
            if (fieldGeneratorDivision.have_value)
              {
                result.setDivision(fieldGeneratorDivision.value);
                fieldGeneratorDivision.have_value = false;
              }
            if (fieldGeneratorToBeDetermined.have_value)
              {
                result.setToBeDetermined(fieldGeneratorToBeDetermined.value);
                fieldGeneratorToBeDetermined.have_value = false;
              }
            if (fieldGeneratorLogos.have_value)
              {
                result.initLogos();
                int count = fieldGeneratorLogos.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLogos(fieldGeneratorLogos.value[num]);
                  }
                fieldGeneratorLogos.value.Clear();
                fieldGeneratorLogos.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
          }
        protected abstract void handle_result(SportsTeamNewJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lias", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorAlias;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDivision;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLatitude;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "ague", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorLeague;
                            break;
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'g':
                                    if ((String.Compare(field_name, 3, "os", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorLogos;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "gitude", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorLongitude;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "ame", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorName;
                          }
                        switch (field_name[4])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 5, "hort", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorNameShort;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "oBeDetermined", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorToBeDetermined;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the SportsTeamNew class");
            fieldGeneratorNameShort = new JSONHoldingStringGenerator("field \"NameShort\" of the SportsTeamNew class");
            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the SportsTeamNew class");
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsTeamNew class", ignore_extras);
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the SportsTeamNew class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the SportsTeamNew class");
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsTeamNew class", ignore_extras);
            fieldGeneratorToBeDetermined = new JSONHoldingBooleanGenerator("field \"ToBeDetermined\" of the SportsTeamNew class");
            fieldGeneratorLogos = new SportsTeamLogoJSON.HoldingArrayGenerator("field \"Logos\" of the SportsTeamNew class", ignore_extras);
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsTeamNew class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsTeamNew class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the SportsTeamNew class");
            fieldGeneratorNameShort = new JSONHoldingStringGenerator("field \"NameShort\" of the SportsTeamNew class");
            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the SportsTeamNew class");
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsTeamNew class", false);
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the SportsTeamNew class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the SportsTeamNew class");
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsTeamNew class", false);
            fieldGeneratorToBeDetermined = new JSONHoldingBooleanGenerator("field \"ToBeDetermined\" of the SportsTeamNew class");
            fieldGeneratorLogos = new SportsTeamLogoJSON.HoldingArrayGenerator("field \"Logos\" of the SportsTeamNew class", false);
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsTeamNew class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsTeamNew class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorNameShort.reset();
            fieldGeneratorAlias.reset();
            fieldGeneratorLeague.reset();
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            fieldGeneratorDivision.reset();
            fieldGeneratorToBeDetermined.reset();
            fieldGeneratorLogos.reset();
            fieldGeneratorID.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLogos.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLogos.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsTeamNewJSON  result)
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
        public SportsTeamNewJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsTeamNewJSON  result)
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
    protected virtual void handle_result(List<SportsTeamNewJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsTeamNewJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsTeamNewJSON>();
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
    public List<SportsTeamNewJSON> value;
  };
  };
