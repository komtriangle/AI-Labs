/* file "LotteryGameInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LotteryGameInfoJSON : JSONBase
  {
    private bool flagHasGameName;
    private string storeGameName;
    private bool flagHasCountry;
    private string storeCountry;
    private bool flagHasCountryState;
    private string storeCountryState;
    private bool flagHasLastDrawDate;
    private DateAndOrTimeJSON  storeLastDrawDate;
    private bool flagHasLastDrawNumbers;
    private string storeLastDrawNumbers;
    private bool flagHasNextDrawDate;
    private DateAndOrTimeJSON  storeNextDrawDate;
    private bool flagHasNextDrawJackpot;
    private AmountJSON  storeNextDrawJackpot;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGameName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GameName of LotteryGameInfoJSON is not a string.");
        setGameName(json_string.getData());
      }


    private void  fromJSONCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Country of LotteryGameInfoJSON is not a string.");
        setCountry(json_string.getData());
      }


    private void  fromJSONCountryState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryState of LotteryGameInfoJSON is not a string.");
        setCountryState(json_string.getData());
      }


    private void  fromJSONLastDrawDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setLastDrawDate(convert_classy);
      }


    private void  fromJSONLastDrawNumbers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastDrawNumbers of LotteryGameInfoJSON is not a string.");
        setLastDrawNumbers(json_string.getData());
      }


    private void  fromJSONNextDrawDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNextDrawDate(convert_classy);
      }


    private void  fromJSONNextDrawJackpot(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setNextDrawJackpot(convert_classy);
      }


    public LotteryGameInfoJSON()
      {
        flagHasGameName = false;
        flagHasCountry = false;
        flagHasCountryState = false;
        flagHasLastDrawDate = false;
        flagHasLastDrawNumbers = false;
        flagHasNextDrawDate = false;
        flagHasNextDrawJackpot = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGameName()
      {
        return flagHasGameName;
      }

    public string  getGameName()
      {
        Debug.Assert(flagHasGameName);
        return storeGameName;
      }

    public bool  hasCountry()
      {
        return flagHasCountry;
      }

    public string  getCountry()
      {
        Debug.Assert(flagHasCountry);
        return storeCountry;
      }

    public bool  hasCountryState()
      {
        return flagHasCountryState;
      }

    public string  getCountryState()
      {
        Debug.Assert(flagHasCountryState);
        return storeCountryState;
      }

    public bool  hasLastDrawDate()
      {
        return flagHasLastDrawDate;
      }

    public DateAndOrTimeJSON   getLastDrawDate()
      {
        Debug.Assert(flagHasLastDrawDate);
        return storeLastDrawDate;
      }

    public bool  hasLastDrawNumbers()
      {
        return flagHasLastDrawNumbers;
      }

    public string  getLastDrawNumbers()
      {
        Debug.Assert(flagHasLastDrawNumbers);
        return storeLastDrawNumbers;
      }

    public bool  hasNextDrawDate()
      {
        return flagHasNextDrawDate;
      }

    public DateAndOrTimeJSON   getNextDrawDate()
      {
        Debug.Assert(flagHasNextDrawDate);
        return storeNextDrawDate;
      }

    public bool  hasNextDrawJackpot()
      {
        return flagHasNextDrawJackpot;
      }

    public AmountJSON   getNextDrawJackpot()
      {
        Debug.Assert(flagHasNextDrawJackpot);
        return storeNextDrawJackpot;
      }


    public virtual int extraLotteryGameInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLotteryGameInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLotteryGameInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLotteryGameInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGameName(string new_value)
      {
        flagHasGameName = true;
        storeGameName = new_value;
      }
    public void unsetGameName()
      {
        flagHasGameName = false;
      }
    public void setCountry(string new_value)
      {
        flagHasCountry = true;
        storeCountry = new_value;
      }
    public void unsetCountry()
      {
        flagHasCountry = false;
      }
    public void setCountryState(string new_value)
      {
        flagHasCountryState = true;
        storeCountryState = new_value;
      }
    public void unsetCountryState()
      {
        flagHasCountryState = false;
      }
    public void setLastDrawDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasLastDrawDate)
          {
          }
        flagHasLastDrawDate = true;
        storeLastDrawDate = new_value;
      }
    public void unsetLastDrawDate()
      {
        if (flagHasLastDrawDate)
          {
          }
        flagHasLastDrawDate = false;
      }
    public void setLastDrawNumbers(string new_value)
      {
        flagHasLastDrawNumbers = true;
        storeLastDrawNumbers = new_value;
      }
    public void unsetLastDrawNumbers()
      {
        flagHasLastDrawNumbers = false;
      }
    public void setNextDrawDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNextDrawDate)
          {
          }
        flagHasNextDrawDate = true;
        storeNextDrawDate = new_value;
      }
    public void unsetNextDrawDate()
      {
        if (flagHasNextDrawDate)
          {
          }
        flagHasNextDrawDate = false;
      }
    public void setNextDrawJackpot(AmountJSON  new_value)
      {
        if (flagHasNextDrawJackpot)
          {
          }
        flagHasNextDrawJackpot = true;
        storeNextDrawJackpot = new_value;
      }
    public void unsetNextDrawJackpot()
      {
        if (flagHasNextDrawJackpot)
          {
          }
        flagHasNextDrawJackpot = false;
      }

    public virtual void extraLotteryGameInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLotteryGameInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLotteryGameInfoLookup(key);
        if (old_field == null)
          {
            extraLotteryGameInfoAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasGameName);
        if (flagHasGameName)
          {
            handler.start_pair("GameName");
            handler.string_value(storeGameName);
          }
        Debug.Assert(partial_allowed || flagHasCountry);
        if (flagHasCountry)
          {
            handler.start_pair("Country");
            handler.string_value(storeCountry);
          }
        Debug.Assert(partial_allowed || flagHasCountryState);
        if (flagHasCountryState)
          {
            handler.start_pair("CountryState");
            handler.string_value(storeCountryState);
          }
        Debug.Assert(partial_allowed || flagHasLastDrawDate);
        if (flagHasLastDrawDate)
          {
            handler.start_pair("LastDrawDate");
            if (partial_allowed)
                storeLastDrawDate.write_partial_as_json(handler);
            else
                storeLastDrawDate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasLastDrawNumbers);
        if (flagHasLastDrawNumbers)
          {
            handler.start_pair("LastDrawNumbers");
            handler.string_value(storeLastDrawNumbers);
          }
        if (flagHasNextDrawDate)
          {
            handler.start_pair("NextDrawDate");
            if (partial_allowed)
                storeNextDrawDate.write_partial_as_json(handler);
            else
                storeNextDrawDate.write_as_json(handler);
          }
        if (flagHasNextDrawJackpot)
          {
            handler.start_pair("NextDrawJackpot");
            if (partial_allowed)
                storeNextDrawJackpot.write_partial_as_json(handler);
            else
                storeNextDrawJackpot.write_as_json(handler);
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
        if (!(hasGameName()))
          {
            return "When parsing the object for %what%, the \"GameName\" field was missing.";
          }
        if (!(hasCountry()))
          {
            return "When parsing the object for %what%, the \"Country\" field was missing.";
          }
        if (!(hasCountryState()))
          {
            return "When parsing the object for %what%, the \"CountryState\" field was missing.";
          }
        if (!(hasLastDrawDate()))
          {
            return "When parsing the object for %what%, the \"LastDrawDate\" field was missing.";
          }
        if (!(hasLastDrawNumbers()))
          {
            return "When parsing the object for %what%, the \"LastDrawNumbers\" field was missing.";
          }
        return null;
      }

    public static LotteryGameInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryGameInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryGameInfo", ignore_extras);
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
    public static LotteryGameInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LotteryGameInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryGameInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryGameInfo", ignore_extras);
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
    public static LotteryGameInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LotteryGameInfoJSON from_text(string text, bool ignore_extras)
      {
        LotteryGameInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryGameInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LotteryGameInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LotteryGameInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LotteryGameInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryGameInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorGameName;
        private JSONHoldingStringGenerator fieldGeneratorCountry;
        private JSONHoldingStringGenerator fieldGeneratorCountryState;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorLastDrawDate;
        private JSONHoldingStringGenerator fieldGeneratorLastDrawNumbers;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNextDrawDate;
        private AmountJSON.HoldingGenerator fieldGeneratorNextDrawJackpot;
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
            LotteryGameInfoJSON result = new LotteryGameInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLotteryGameInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LotteryGameInfoJSON result)
          {
            if (fieldGeneratorGameName.have_value)
              {
                result.setGameName(fieldGeneratorGameName.value);
                fieldGeneratorGameName.have_value = false;
              }
            else if ((!(result.hasGameName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GameName\" field was missing.");
              }
            if (fieldGeneratorCountry.have_value)
              {
                result.setCountry(fieldGeneratorCountry.value);
                fieldGeneratorCountry.have_value = false;
              }
            else if ((!(result.hasCountry())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Country\" field was missing.");
              }
            if (fieldGeneratorCountryState.have_value)
              {
                result.setCountryState(fieldGeneratorCountryState.value);
                fieldGeneratorCountryState.have_value = false;
              }
            else if ((!(result.hasCountryState())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CountryState\" field was missing.");
              }
            if (fieldGeneratorLastDrawDate.have_value)
              {
                result.setLastDrawDate(fieldGeneratorLastDrawDate.value);
                fieldGeneratorLastDrawDate.have_value = false;
              }
            else if ((!(result.hasLastDrawDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastDrawDate\" field was missing.");
              }
            if (fieldGeneratorLastDrawNumbers.have_value)
              {
                result.setLastDrawNumbers(fieldGeneratorLastDrawNumbers.value);
                fieldGeneratorLastDrawNumbers.have_value = false;
              }
            else if ((!(result.hasLastDrawNumbers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastDrawNumbers\" field was missing.");
              }
            if (fieldGeneratorNextDrawDate.have_value)
              {
                result.setNextDrawDate(fieldGeneratorNextDrawDate.value);
                fieldGeneratorNextDrawDate.have_value = false;
              }
            if (fieldGeneratorNextDrawJackpot.have_value)
              {
                result.setNextDrawJackpot(fieldGeneratorNextDrawJackpot.value);
                fieldGeneratorNextDrawJackpot.have_value = false;
              }
          }
        protected abstract void handle_result(LotteryGameInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ountry", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorCountry;
                          }
                        switch (field_name[7])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 8, "tate", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorCountryState;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ameName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorGameName;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "astDraw", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ate", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorLastDrawDate;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "umbers", 0, 6, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorLastDrawNumbers;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "extDraw", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ate", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorNextDrawDate;
                                break;
                            case 'J':
                                if ((String.Compare(field_name, 9, "ackpot", 0, 6, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorNextDrawJackpot;
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
            fieldGeneratorGameName = new JSONHoldingStringGenerator("field \"GameName\" of the LotteryGameInfo class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the LotteryGameInfo class");
            fieldGeneratorCountryState = new JSONHoldingStringGenerator("field \"CountryState\" of the LotteryGameInfo class");
            fieldGeneratorLastDrawDate = new DateAndOrTimeJSON.HoldingGenerator("field \"LastDrawDate\" of the LotteryGameInfo class", ignore_extras);
            fieldGeneratorLastDrawNumbers = new JSONHoldingStringGenerator("field \"LastDrawNumbers\" of the LotteryGameInfo class");
            fieldGeneratorNextDrawDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NextDrawDate\" of the LotteryGameInfo class", ignore_extras);
            fieldGeneratorNextDrawJackpot = new AmountJSON.HoldingGenerator("field \"NextDrawJackpot\" of the LotteryGameInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LotteryGameInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGameName = new JSONHoldingStringGenerator("field \"GameName\" of the LotteryGameInfo class");
            fieldGeneratorCountry = new JSONHoldingStringGenerator("field \"Country\" of the LotteryGameInfo class");
            fieldGeneratorCountryState = new JSONHoldingStringGenerator("field \"CountryState\" of the LotteryGameInfo class");
            fieldGeneratorLastDrawDate = new DateAndOrTimeJSON.HoldingGenerator("field \"LastDrawDate\" of the LotteryGameInfo class", false);
            fieldGeneratorLastDrawNumbers = new JSONHoldingStringGenerator("field \"LastDrawNumbers\" of the LotteryGameInfo class");
            fieldGeneratorNextDrawDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NextDrawDate\" of the LotteryGameInfo class", false);
            fieldGeneratorNextDrawJackpot = new AmountJSON.HoldingGenerator("field \"NextDrawJackpot\" of the LotteryGameInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LotteryGameInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGameName.reset();
            fieldGeneratorCountry.reset();
            fieldGeneratorCountryState.reset();
            fieldGeneratorLastDrawDate.reset();
            fieldGeneratorLastDrawNumbers.reset();
            fieldGeneratorNextDrawDate.reset();
            fieldGeneratorNextDrawJackpot.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLastDrawDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNextDrawDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNextDrawJackpot.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLastDrawDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNextDrawDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNextDrawJackpot.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LotteryGameInfoJSON  result)
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
        public LotteryGameInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LotteryGameInfoJSON  result)
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
    protected virtual void handle_result(List<LotteryGameInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LotteryGameInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LotteryGameInfoJSON>();
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
    public List<LotteryGameInfoJSON> value;
  };
  };
