/* file "SportsSeriesStatusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsSeriesStatusJSON : JSONBase
  {
    private bool flagHasSeriesResult;
    private bool storeSeriesResult;
    private bool flagHasSeriesComplete;
    private bool storeSeriesComplete;
    private bool flagHasSeriesName;
    private SportsPlayoffSpecialGameJSON  storeSeriesName;
    private bool flagHasTeams;
    private List< SportsTeamJSON  > storeTeams;
    private bool flagHasAwayGoals;
    private List< BigInteger > storeAwayGoals;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSeriesResult(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SeriesResult of SportsSeriesStatusJSON is not true for false.");
              }
          }
        setSeriesResult(the_bool);
      }


    private void  fromJSONSeriesComplete(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SeriesComplete of SportsSeriesStatusJSON is not true for false.");
              }
          }
        setSeriesComplete(the_bool);
      }


    private void  fromJSONSeriesName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setSeriesName(convert_classy);
      }


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsSeriesStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Teams of SportsSeriesStatusJSON has too few elements.");
        List< SportsTeamJSON  > vector_Teams1 = new List< SportsTeamJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamJSON convert_classy = SportsTeamJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 2);
        initTeams();
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
            appendTeams(vector_Teams1[num1]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAwayGoals(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AwayGoals of SportsSeriesStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field AwayGoals of SportsSeriesStatusJSON has too few elements.");
        List< BigInteger > vector_AwayGoals1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field AwayGoals of SportsSeriesStatusJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field AwayGoals of SportsSeriesStatusJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_AwayGoals1.Add(extracted_integer);
          }
        Debug.Assert(vector_AwayGoals1.Count >= 2);
        initAwayGoals();
        for (int num2 = 0; num2 < vector_AwayGoals1.Count; ++num2)
            appendAwayGoals(vector_AwayGoals1[num2]);
        for (int num1 = 0; num1 < vector_AwayGoals1.Count; ++num1)
          {
          }
      }


    public SportsSeriesStatusJSON()
      {
        flagHasSeriesResult = false;
        flagHasSeriesComplete = false;
        flagHasSeriesName = false;
        flagHasTeams = false;
        flagHasAwayGoals = false;
        storeTeams = new List< SportsTeamJSON  >();
        storeAwayGoals = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSeriesResult()
      {
        return flagHasSeriesResult;
      }

    public bool  getSeriesResult()
      {
        Debug.Assert(flagHasSeriesResult);
        return storeSeriesResult;
      }

    public bool  hasSeriesComplete()
      {
        return flagHasSeriesComplete;
      }

    public bool  getSeriesComplete()
      {
        Debug.Assert(flagHasSeriesComplete);
        return storeSeriesComplete;
      }

    public bool  hasSeriesName()
      {
        return flagHasSeriesName;
      }

    public SportsPlayoffSpecialGameJSON   getSeriesName()
      {
        Debug.Assert(flagHasSeriesName);
        return storeSeriesName;
      }

    public SportsPlayoffSpecialGameJSON.TypeValue  getSeriesNameValue()
      {
        return getSeriesName().getValue();
      }

    public string  getSeriesNameAsString()
      {
        return getSeriesName().getValueAsString();
      }

    public bool  hasTeams()
      {
        return flagHasTeams;
      }

    public int  countOfTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams.Count;
      }

    public SportsTeamJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< SportsTeamJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }

    public bool  hasAwayGoals()
      {
        return flagHasAwayGoals;
      }

    public int  countOfAwayGoals()
      {
        Debug.Assert(flagHasAwayGoals);
        return storeAwayGoals.Count;
      }

    public BigInteger  elementOfAwayGoals(int element_num)
      {
        Debug.Assert(flagHasAwayGoals);
        return storeAwayGoals[element_num];
      }

    public List< BigInteger >  getAwayGoals()
      {
        Debug.Assert(flagHasAwayGoals);
        return storeAwayGoals;
      }


    public virtual int extraSportsSeriesStatusComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsSeriesStatusComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsSeriesStatusComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsSeriesStatusLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSeriesResult(bool new_value)
      {
        flagHasSeriesResult = true;
        storeSeriesResult = new_value;
      }
    public void unsetSeriesResult()
      {
        flagHasSeriesResult = false;
      }
    public void setSeriesComplete(bool new_value)
      {
        flagHasSeriesComplete = true;
        storeSeriesComplete = new_value;
      }
    public void unsetSeriesComplete()
      {
        flagHasSeriesComplete = false;
      }
    public void setSeriesName(SportsPlayoffSpecialGameJSON  new_value)
      {
        if (flagHasSeriesName)
          {
          }
        flagHasSeriesName = true;
        storeSeriesName = new_value;
      }
    public void setSeriesName(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        setSeriesName(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void setSeriesName(string chars)
      {
        SportsPlayoffSpecialGameJSON.TypeValueKnownValues known = SportsPlayoffSpecialGameJSON.stringToValue(chars);
        SportsPlayoffSpecialGameJSON.TypeValue new_value = new SportsPlayoffSpecialGameJSON.TypeValue();
        if (known == SportsPlayoffSpecialGameJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSeriesName(new_value);
      }
    public void unsetSeriesName()
      {
        if (flagHasSeriesName)
          {
          }
        flagHasSeriesName = false;
      }
    public void initTeams()
      {
        if (flagHasTeams)
          {
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
              }
          }
        flagHasTeams = true;
        storeTeams.Clear();
      }
    public void appendTeams(SportsTeamJSON  to_append)
      {
        if (!flagHasTeams)
          {
            flagHasTeams = true;
            storeTeams.Clear();
          }
        Debug.Assert(flagHasTeams);
        storeTeams.Add(to_append);
      }
    public void unsetTeams()
      {
        if (flagHasTeams)
          {
            for (int num2 = 0; num2 < storeTeams.Count; ++num2)
              {
              }
          }
        flagHasTeams = false;
        storeTeams.Clear();
      }
    public void initAwayGoals()
      {
        flagHasAwayGoals = true;
        storeAwayGoals.Clear();
      }
    public void appendAwayGoals(BigInteger to_append)
      {
        if (!flagHasAwayGoals)
          {
            flagHasAwayGoals = true;
            storeAwayGoals.Clear();
          }
        Debug.Assert(flagHasAwayGoals);
        storeAwayGoals.Add(to_append);
      }
    public void unsetAwayGoals()
      {
        flagHasAwayGoals = false;
        storeAwayGoals.Clear();
      }

    public virtual void extraSportsSeriesStatusAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsSeriesStatusSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsSeriesStatusLookup(key);
        if (old_field == null)
          {
            extraSportsSeriesStatusAppendPair(key, new_component);
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
        if (flagHasSeriesResult)
          {
            handler.start_pair("SeriesResult");
            handler.boolean_value(storeSeriesResult);
          }
        if (flagHasSeriesComplete)
          {
            handler.start_pair("SeriesComplete");
            handler.boolean_value(storeSeriesComplete);
          }
        if (flagHasSeriesName)
          {
            handler.start_pair("SeriesName");
            if (partial_allowed)
                storeSeriesName.write_partial_as_json(handler);
            else
                storeSeriesName.write_as_json(handler);
          }
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
                if (partial_allowed)
                    storeTeams[num1].write_partial_as_json(handler);
                else
                    storeTeams[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAwayGoals)
          {
            handler.start_pair("AwayGoals");
            Debug.Assert(storeAwayGoals.Count >= 2);
            handler.start_array();
            for (int num2 = 0; num2 < storeAwayGoals.Count; ++num2)
              {
                handler.number_value(storeAwayGoals[num2]);
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
        return null;
      }

    public static SportsSeriesStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeriesStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatus", ignore_extras);
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
    public static SportsSeriesStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeriesStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeriesStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatus", ignore_extras);
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
    public static SportsSeriesStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeriesStatusJSON from_text(string text, bool ignore_extras)
      {
        SportsSeriesStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatus", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsSeriesStatusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsSeriesStatusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsSeriesStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeriesStatus", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorSeriesResult;
        private JSONHoldingBooleanGenerator fieldGeneratorSeriesComplete;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorSeriesName;
        private SportsTeamJSON.HoldingArrayGenerator fieldGeneratorTeams;
    private class FieldHoldingGeneratorAwayGoals : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAwayGoals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAwayGoals : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAwayGoals(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorAwayGoals fieldGeneratorAwayGoals;
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
            SportsSeriesStatusJSON result = new SportsSeriesStatusJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsSeriesStatusAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsSeriesStatusJSON result)
          {
            if (fieldGeneratorSeriesResult.have_value)
              {
                result.setSeriesResult(fieldGeneratorSeriesResult.value);
                fieldGeneratorSeriesResult.have_value = false;
              }
            if (fieldGeneratorSeriesComplete.have_value)
              {
                result.setSeriesComplete(fieldGeneratorSeriesComplete.value);
                fieldGeneratorSeriesComplete.have_value = false;
              }
            if (fieldGeneratorSeriesName.have_value)
              {
                result.setSeriesName(fieldGeneratorSeriesName.value);
                fieldGeneratorSeriesName.have_value = false;
              }
            if (fieldGeneratorTeams.have_value)
              {
                result.initTeams();
                int count = fieldGeneratorTeams.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTeams(fieldGeneratorTeams.value[num]);
                  }
                fieldGeneratorTeams.value.Clear();
                fieldGeneratorTeams.have_value = false;
              }
            if (fieldGeneratorAwayGoals.have_value)
              {
                result.initAwayGoals();
                int count = fieldGeneratorAwayGoals.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAwayGoals(fieldGeneratorAwayGoals.value[num]);
                  }
                fieldGeneratorAwayGoals.value.Clear();
                fieldGeneratorAwayGoals.have_value = false;
              }
          }
        protected abstract void handle_result(SportsSeriesStatusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "wayGoals", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorAwayGoals;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "eries", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 7, "omplete", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSeriesComplete;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSeriesName;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 7, "esult", 0, 5, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorSeriesResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eams", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTeams;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSeriesResult = new JSONHoldingBooleanGenerator("field \"SeriesResult\" of the SportsSeriesStatus class");
            fieldGeneratorSeriesComplete = new JSONHoldingBooleanGenerator("field \"SeriesComplete\" of the SportsSeriesStatus class");
            fieldGeneratorSeriesName = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SeriesName\" of the SportsSeriesStatus class", ignore_extras);
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsSeriesStatus class", ignore_extras);
            fieldGeneratorAwayGoals = new FieldHoldingArrayGeneratorAwayGoals("field \"AwayGoals\" of the SportsSeriesStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsSeriesStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSeriesResult = new JSONHoldingBooleanGenerator("field \"SeriesResult\" of the SportsSeriesStatus class");
            fieldGeneratorSeriesComplete = new JSONHoldingBooleanGenerator("field \"SeriesComplete\" of the SportsSeriesStatus class");
            fieldGeneratorSeriesName = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SeriesName\" of the SportsSeriesStatus class", false);
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsSeriesStatus class", false);
            fieldGeneratorAwayGoals = new FieldHoldingArrayGeneratorAwayGoals("field \"AwayGoals\" of the SportsSeriesStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsSeriesStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSeriesResult.reset();
            fieldGeneratorSeriesComplete.reset();
            fieldGeneratorSeriesName.reset();
            fieldGeneratorTeams.reset();
            fieldGeneratorAwayGoals.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSeriesName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSeriesName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsSeriesStatusJSON  result)
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
        public SportsSeriesStatusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsSeriesStatusJSON  result)
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
    protected virtual void handle_result(List<SportsSeriesStatusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsSeriesStatusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsSeriesStatusJSON>();
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
    public List<SportsSeriesStatusJSON> value;
  };
  };
