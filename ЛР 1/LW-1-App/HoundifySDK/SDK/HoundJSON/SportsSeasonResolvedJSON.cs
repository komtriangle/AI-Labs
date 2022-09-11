/* file "SportsSeasonResolvedJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsSeasonResolvedJSON : JSONBase
  {
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasYearEnd;
    private BigInteger storeYearEnd;
    private bool flagHasIsCurrentSeason;
    private bool storeIsCurrentSeason;
    private bool flagHasType;
    private SportsSeasonTypeJSON  storeType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of SportsSeasonResolvedJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of SportsSeasonResolvedJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONYearEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field YearEnd of SportsSeasonResolvedJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field YearEnd of SportsSeasonResolvedJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYearEnd(extracted_integer);
      }


    private void  fromJSONIsCurrentSeason(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsCurrentSeason of SportsSeasonResolvedJSON is not true for false.");
              }
          }
        setIsCurrentSeason(the_bool);
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonTypeJSON convert_classy = SportsSeasonTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    public SportsSeasonResolvedJSON()
      {
        flagHasYear = false;
        flagHasYearEnd = false;
        flagHasIsCurrentSeason = false;
        flagHasType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasYearEnd()
      {
        return flagHasYearEnd;
      }

    public BigInteger  getYearEnd()
      {
        Debug.Assert(flagHasYearEnd);
        return storeYearEnd;
      }

    public bool  hasIsCurrentSeason()
      {
        return flagHasIsCurrentSeason;
      }

    public bool  getIsCurrentSeason()
      {
        Debug.Assert(flagHasIsCurrentSeason);
        return storeIsCurrentSeason;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public SportsSeasonTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public SportsSeasonTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }


    public virtual int extraSportsSeasonResolvedComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsSeasonResolvedComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsSeasonResolvedComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsSeasonResolvedLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        if (new_value < 1)
            throw new Exception("The value for field Year of SportsSeasonResolvedJSON is less than the lower bound (1) for that field.");
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setYearEnd(BigInteger new_value)
      {
        flagHasYearEnd = true;
        if (new_value < 1)
            throw new Exception("The value for field YearEnd of SportsSeasonResolvedJSON is less than the lower bound (1) for that field.");
        storeYearEnd = new_value;
      }
    public void unsetYearEnd()
      {
        flagHasYearEnd = false;
      }
    public void setIsCurrentSeason(bool new_value)
      {
        flagHasIsCurrentSeason = true;
        storeIsCurrentSeason = new_value;
      }
    public void unsetIsCurrentSeason()
      {
        flagHasIsCurrentSeason = false;
      }
    public void setType(SportsSeasonTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(SportsSeasonTypeJSON.TypeValue new_value)
      {
        setType(new SportsSeasonTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        SportsSeasonTypeJSON.TypeValueKnownValues known = SportsSeasonTypeJSON.stringToValue(chars);
        SportsSeasonTypeJSON.TypeValue new_value = new SportsSeasonTypeJSON.TypeValue();
        if (known == SportsSeasonTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }

    public virtual void extraSportsSeasonResolvedAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsSeasonResolvedSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsSeasonResolvedLookup(key);
        if (old_field == null)
          {
            extraSportsSeasonResolvedAppendPair(key, new_component);
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
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        if (flagHasYearEnd)
          {
            handler.start_pair("YearEnd");
            handler.number_value(storeYearEnd);
          }
        if (flagHasIsCurrentSeason)
          {
            handler.start_pair("IsCurrentSeason");
            handler.boolean_value(storeIsCurrentSeason);
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
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

    public static SportsSeasonResolvedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeasonResolvedJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeasonResolved", ignore_extras);
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
    public static SportsSeasonResolvedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeasonResolvedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsSeasonResolvedJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeasonResolved", ignore_extras);
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
    public static SportsSeasonResolvedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsSeasonResolvedJSON from_text(string text, bool ignore_extras)
      {
        SportsSeasonResolvedJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeasonResolved", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsSeasonResolvedJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsSeasonResolvedJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsSeasonResolvedJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsSeasonResolved", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
    private class FieldHoldingGeneratorYearEnd : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYearEnd(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYearEnd : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYearEnd(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorYearEnd fieldGeneratorYearEnd;
        private JSONHoldingBooleanGenerator fieldGeneratorIsCurrentSeason;
        private SportsSeasonTypeJSON.HoldingGenerator fieldGeneratorType;
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
            SportsSeasonResolvedJSON result = new SportsSeasonResolvedJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsSeasonResolvedAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsSeasonResolvedJSON result)
          {
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            if (fieldGeneratorYearEnd.have_value)
              {
                result.setYearEnd(fieldGeneratorYearEnd.value);
                fieldGeneratorYearEnd.have_value = false;
              }
            if (fieldGeneratorIsCurrentSeason.have_value)
              {
                result.setIsCurrentSeason(fieldGeneratorIsCurrentSeason.value);
                fieldGeneratorIsCurrentSeason.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
          }
        protected abstract void handle_result(SportsSeasonResolvedJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sCurrentSeason", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorIsCurrentSeason;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "ear", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorYear;
                          }
                        switch (field_name[4])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 5, "nd", 0, 2, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorYearEnd;
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
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the SportsSeasonResolved class");
            fieldGeneratorYearEnd = new FieldHoldingGeneratorYearEnd("field \"YearEnd\" of the SportsSeasonResolved class");
            fieldGeneratorIsCurrentSeason = new JSONHoldingBooleanGenerator("field \"IsCurrentSeason\" of the SportsSeasonResolved class");
            fieldGeneratorType = new SportsSeasonTypeJSON.HoldingGenerator("field \"Type\" of the SportsSeasonResolved class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsSeasonResolved class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the SportsSeasonResolved class");
            fieldGeneratorYearEnd = new FieldHoldingGeneratorYearEnd("field \"YearEnd\" of the SportsSeasonResolved class");
            fieldGeneratorIsCurrentSeason = new JSONHoldingBooleanGenerator("field \"IsCurrentSeason\" of the SportsSeasonResolved class");
            fieldGeneratorType = new SportsSeasonTypeJSON.HoldingGenerator("field \"Type\" of the SportsSeasonResolved class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsSeasonResolved class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorYear.reset();
            fieldGeneratorYearEnd.reset();
            fieldGeneratorIsCurrentSeason.reset();
            fieldGeneratorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsSeasonResolvedJSON  result)
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
        public SportsSeasonResolvedJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsSeasonResolvedJSON  result)
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
    protected virtual void handle_result(List<SportsSeasonResolvedJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsSeasonResolvedJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsSeasonResolvedJSON>();
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
    public List<SportsSeasonResolvedJSON> value;
  };
  };
