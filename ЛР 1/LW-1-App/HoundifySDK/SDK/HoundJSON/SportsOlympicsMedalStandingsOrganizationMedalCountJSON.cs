/* file "SportsOlympicsMedalStandingsOrganizationMedalCountJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsMedalStandingsOrganizationMedalCountJSON : JSONBase
  {
    private bool flagHasOrganization;
    private SportsOlympicsOrganizationJSON  storeOrganization;
    private bool flagHasGoldMedals;
    private BigInteger storeGoldMedals;
    private bool flagHasSilverMedals;
    private BigInteger storeSilverMedals;
    private bool flagHasBronzeMedals;
    private BigInteger storeBronzeMedals;
    private bool flagHasTotalMedals;
    private BigInteger storeTotalMedals;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasRankIsTied;
    private bool storeRankIsTied;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOrganization(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsOrganizationJSON convert_classy = SportsOlympicsOrganizationJSON.from_json(json_value, ignore_extras, true);
        setOrganization(convert_classy);
      }


    private void  fromJSONGoldMedals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GoldMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GoldMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGoldMedals(extracted_integer);
      }


    private void  fromJSONSilverMedals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SilverMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SilverMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSilverMedals(extracted_integer);
      }


    private void  fromJSONBronzeMedals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field BronzeMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field BronzeMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setBronzeMedals(extracted_integer);
      }


    private void  fromJSONTotalMedals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalMedals(extracted_integer);
      }


    private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONRankIsTied(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RankIsTied of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is not true for false.");
              }
          }
        setRankIsTied(the_bool);
      }


    public SportsOlympicsMedalStandingsOrganizationMedalCountJSON()
      {
        flagHasOrganization = false;
        flagHasGoldMedals = false;
        flagHasSilverMedals = false;
        flagHasBronzeMedals = false;
        flagHasTotalMedals = false;
        flagHasRank = false;
        flagHasRankIsTied = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOrganization()
      {
        return flagHasOrganization;
      }

    public SportsOlympicsOrganizationJSON   getOrganization()
      {
        Debug.Assert(flagHasOrganization);
        return storeOrganization;
      }

    public bool  hasGoldMedals()
      {
        return flagHasGoldMedals;
      }

    public BigInteger  getGoldMedals()
      {
        Debug.Assert(flagHasGoldMedals);
        return storeGoldMedals;
      }

    public bool  hasSilverMedals()
      {
        return flagHasSilverMedals;
      }

    public BigInteger  getSilverMedals()
      {
        Debug.Assert(flagHasSilverMedals);
        return storeSilverMedals;
      }

    public bool  hasBronzeMedals()
      {
        return flagHasBronzeMedals;
      }

    public BigInteger  getBronzeMedals()
      {
        Debug.Assert(flagHasBronzeMedals);
        return storeBronzeMedals;
      }

    public bool  hasTotalMedals()
      {
        return flagHasTotalMedals;
      }

    public BigInteger  getTotalMedals()
      {
        Debug.Assert(flagHasTotalMedals);
        return storeTotalMedals;
      }

    public bool  hasRank()
      {
        return flagHasRank;
      }

    public BigInteger  getRank()
      {
        Debug.Assert(flagHasRank);
        return storeRank;
      }

    public bool  hasRankIsTied()
      {
        return flagHasRankIsTied;
      }

    public bool  getRankIsTied()
      {
        Debug.Assert(flagHasRankIsTied);
        return storeRankIsTied;
      }


    public virtual int extraSportsOlympicsMedalStandingsOrganizationMedalCountComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsOrganizationMedalCountComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsOrganizationMedalCountComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsOrganizationMedalCountLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOrganization(SportsOlympicsOrganizationJSON  new_value)
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = true;
        storeOrganization = new_value;
      }
    public void unsetOrganization()
      {
        if (flagHasOrganization)
          {
          }
        flagHasOrganization = false;
      }
    public void setGoldMedals(BigInteger new_value)
      {
        flagHasGoldMedals = true;
        if (new_value < 0)
            throw new Exception("The value for field GoldMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is less than the lower bound (0) for that field.");
        storeGoldMedals = new_value;
      }
    public void unsetGoldMedals()
      {
        flagHasGoldMedals = false;
      }
    public void setSilverMedals(BigInteger new_value)
      {
        flagHasSilverMedals = true;
        if (new_value < 0)
            throw new Exception("The value for field SilverMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is less than the lower bound (0) for that field.");
        storeSilverMedals = new_value;
      }
    public void unsetSilverMedals()
      {
        flagHasSilverMedals = false;
      }
    public void setBronzeMedals(BigInteger new_value)
      {
        flagHasBronzeMedals = true;
        if (new_value < 0)
            throw new Exception("The value for field BronzeMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is less than the lower bound (0) for that field.");
        storeBronzeMedals = new_value;
      }
    public void unsetBronzeMedals()
      {
        flagHasBronzeMedals = false;
      }
    public void setTotalMedals(BigInteger new_value)
      {
        flagHasTotalMedals = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalMedals of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is less than the lower bound (0) for that field.");
        storeTotalMedals = new_value;
      }
    public void unsetTotalMedals()
      {
        flagHasTotalMedals = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsOlympicsMedalStandingsOrganizationMedalCountJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setRankIsTied(bool new_value)
      {
        flagHasRankIsTied = true;
        storeRankIsTied = new_value;
      }
    public void unsetRankIsTied()
      {
        flagHasRankIsTied = false;
      }

    public virtual void extraSportsOlympicsMedalStandingsOrganizationMedalCountAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsOrganizationMedalCountSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsOrganizationMedalCountLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsOrganizationMedalCountAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasOrganization);
        if (flagHasOrganization)
          {
            handler.start_pair("Organization");
            if (partial_allowed)
                storeOrganization.write_partial_as_json(handler);
            else
                storeOrganization.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasGoldMedals);
        if (flagHasGoldMedals)
          {
            handler.start_pair("GoldMedals");
            handler.number_value(storeGoldMedals);
          }
        Debug.Assert(partial_allowed || flagHasSilverMedals);
        if (flagHasSilverMedals)
          {
            handler.start_pair("SilverMedals");
            handler.number_value(storeSilverMedals);
          }
        Debug.Assert(partial_allowed || flagHasBronzeMedals);
        if (flagHasBronzeMedals)
          {
            handler.start_pair("BronzeMedals");
            handler.number_value(storeBronzeMedals);
          }
        Debug.Assert(partial_allowed || flagHasTotalMedals);
        if (flagHasTotalMedals)
          {
            handler.start_pair("TotalMedals");
            handler.number_value(storeTotalMedals);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasRankIsTied)
          {
            handler.start_pair("RankIsTied");
            handler.boolean_value(storeRankIsTied);
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
        if (!(hasOrganization()))
          {
            return "When parsing the object for %what%, the \"Organization\" field was missing.";
          }
        if (!(hasGoldMedals()))
          {
            return "When parsing the object for %what%, the \"GoldMedals\" field was missing.";
          }
        if (!(hasSilverMedals()))
          {
            return "When parsing the object for %what%, the \"SilverMedals\" field was missing.";
          }
        if (!(hasBronzeMedals()))
          {
            return "When parsing the object for %what%, the \"BronzeMedals\" field was missing.";
          }
        if (!(hasTotalMedals()))
          {
            return "When parsing the object for %what%, the \"TotalMedals\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsOrganizationMedalCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsOrganizationMedalCount", ignore_extras);
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
    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsOrganizationMedalCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsOrganizationMedalCount", ignore_extras);
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
    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsOrganizationMedalCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsOrganizationMedalCount", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsOrganizationMedalCountJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsMedalStandingsOrganizationMedalCountJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsOrganizationMedalCountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsOrganizationMedalCount", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsOrganizationJSON.HoldingGenerator fieldGeneratorOrganization;
    private class FieldHoldingGeneratorGoldMedals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGoldMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGoldMedals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGoldMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGoldMedals fieldGeneratorGoldMedals;
    private class FieldHoldingGeneratorSilverMedals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSilverMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSilverMedals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSilverMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSilverMedals fieldGeneratorSilverMedals;
    private class FieldHoldingGeneratorBronzeMedals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorBronzeMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorBronzeMedals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorBronzeMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorBronzeMedals fieldGeneratorBronzeMedals;
    private class FieldHoldingGeneratorTotalMedals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalMedals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalMedals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalMedals fieldGeneratorTotalMedals;
    private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRank fieldGeneratorRank;
        private JSONHoldingBooleanGenerator fieldGeneratorRankIsTied;
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
            SportsOlympicsMedalStandingsOrganizationMedalCountJSON result = new SportsOlympicsMedalStandingsOrganizationMedalCountJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsOrganizationMedalCountAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsMedalStandingsOrganizationMedalCountJSON result)
          {
            if (fieldGeneratorOrganization.have_value)
              {
                result.setOrganization(fieldGeneratorOrganization.value);
                fieldGeneratorOrganization.have_value = false;
              }
            else if ((!(result.hasOrganization())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Organization\" field was missing.");
              }
            if (fieldGeneratorGoldMedals.have_value)
              {
                result.setGoldMedals(fieldGeneratorGoldMedals.value);
                fieldGeneratorGoldMedals.have_value = false;
              }
            else if ((!(result.hasGoldMedals())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GoldMedals\" field was missing.");
              }
            if (fieldGeneratorSilverMedals.have_value)
              {
                result.setSilverMedals(fieldGeneratorSilverMedals.value);
                fieldGeneratorSilverMedals.have_value = false;
              }
            else if ((!(result.hasSilverMedals())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SilverMedals\" field was missing.");
              }
            if (fieldGeneratorBronzeMedals.have_value)
              {
                result.setBronzeMedals(fieldGeneratorBronzeMedals.value);
                fieldGeneratorBronzeMedals.have_value = false;
              }
            else if ((!(result.hasBronzeMedals())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BronzeMedals\" field was missing.");
              }
            if (fieldGeneratorTotalMedals.have_value)
              {
                result.setTotalMedals(fieldGeneratorTotalMedals.value);
                fieldGeneratorTotalMedals.have_value = false;
              }
            else if ((!(result.hasTotalMedals())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalMedals\" field was missing.");
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorRankIsTied.have_value)
              {
                result.setRankIsTied(fieldGeneratorRankIsTied.value);
                fieldGeneratorRankIsTied.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsOrganizationMedalCountJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ronzeMedals", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorBronzeMedals;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "oldMedals", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorGoldMedals;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rganization", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorOrganization;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ank", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRank;
                          }
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "sTied", 0, 5, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorRankIsTied;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ilverMedals", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSilverMedals;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalMedals", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTotalMedals;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class", ignore_extras);
            fieldGeneratorGoldMedals = new FieldHoldingGeneratorGoldMedals("field \"GoldMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorSilverMedals = new FieldHoldingGeneratorSilverMedals("field \"SilverMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorBronzeMedals = new FieldHoldingGeneratorBronzeMedals("field \"BronzeMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorTotalMedals = new FieldHoldingGeneratorTotalMedals("field \"TotalMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorRankIsTied = new JSONHoldingBooleanGenerator("field \"RankIsTied\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOrganization = new SportsOlympicsOrganizationJSON.HoldingGenerator("field \"Organization\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class", false);
            fieldGeneratorGoldMedals = new FieldHoldingGeneratorGoldMedals("field \"GoldMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorSilverMedals = new FieldHoldingGeneratorSilverMedals("field \"SilverMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorBronzeMedals = new FieldHoldingGeneratorBronzeMedals("field \"BronzeMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorTotalMedals = new FieldHoldingGeneratorTotalMedals("field \"TotalMedals\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            fieldGeneratorRankIsTied = new JSONHoldingBooleanGenerator("field \"RankIsTied\" of the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsOrganizationMedalCount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOrganization.reset();
            fieldGeneratorGoldMedals.reset();
            fieldGeneratorSilverMedals.reset();
            fieldGeneratorBronzeMedals.reset();
            fieldGeneratorTotalMedals.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorRankIsTied.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOrganization.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOrganization.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsOrganizationMedalCountJSON  result)
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
        public SportsOlympicsMedalStandingsOrganizationMedalCountJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsOrganizationMedalCountJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsOrganizationMedalCountJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsOrganizationMedalCountJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsOrganizationMedalCountJSON>();
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
    public List<SportsOlympicsMedalStandingsOrganizationMedalCountJSON> value;
  };
  };
