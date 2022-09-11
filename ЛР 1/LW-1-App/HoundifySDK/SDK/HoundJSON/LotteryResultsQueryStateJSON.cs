/* file "LotteryResultsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LotteryResultsQueryStateJSON : JSONBase
  {
    private bool flagHasLastDrawNumbersRequested;
    private bool storeLastDrawNumbersRequested;
    private bool flagHasNextDrawDateRequested;
    private bool storeNextDrawDateRequested;
    private bool flagHasNextDrawJackpotRequested;
    private bool storeNextDrawJackpotRequested;
    private bool flagHasQueryGames;
    private List< LotteryGameIdentityJSON  > storeQueryGames;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLastDrawNumbersRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LastDrawNumbersRequested of LotteryResultsQueryStateJSON is not true for false.");
              }
          }
        setLastDrawNumbersRequested(the_bool);
      }


    private void  fromJSONNextDrawDateRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NextDrawDateRequested of LotteryResultsQueryStateJSON is not true for false.");
              }
          }
        setNextDrawDateRequested(the_bool);
      }


    private void  fromJSONNextDrawJackpotRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NextDrawJackpotRequested of LotteryResultsQueryStateJSON is not true for false.");
              }
          }
        setNextDrawJackpotRequested(the_bool);
      }


    private void  fromJSONQueryGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryGames of LotteryResultsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field QueryGames of LotteryResultsQueryStateJSON has too few elements.");
        List< LotteryGameIdentityJSON  > vector_QueryGames1 = new List< LotteryGameIdentityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LotteryGameIdentityJSON convert_classy = LotteryGameIdentityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryGames1.Add(convert_classy);
          }
        Debug.Assert(vector_QueryGames1.Count >= 1);
        initQueryGames();
        for (int num1 = 0; num1 < vector_QueryGames1.Count; ++num1)
            appendQueryGames(vector_QueryGames1[num1]);
        for (int num1 = 0; num1 < vector_QueryGames1.Count; ++num1)
          {
          }
      }


    public LotteryResultsQueryStateJSON()
      {
        flagHasLastDrawNumbersRequested = false;
        flagHasNextDrawDateRequested = false;
        flagHasNextDrawJackpotRequested = false;
        flagHasQueryGames = false;
        storeQueryGames = new List< LotteryGameIdentityJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLastDrawNumbersRequested()
      {
        return flagHasLastDrawNumbersRequested;
      }

    public bool  getLastDrawNumbersRequested()
      {
        Debug.Assert(flagHasLastDrawNumbersRequested);
        return storeLastDrawNumbersRequested;
      }

    public bool  hasNextDrawDateRequested()
      {
        return flagHasNextDrawDateRequested;
      }

    public bool  getNextDrawDateRequested()
      {
        Debug.Assert(flagHasNextDrawDateRequested);
        return storeNextDrawDateRequested;
      }

    public bool  hasNextDrawJackpotRequested()
      {
        return flagHasNextDrawJackpotRequested;
      }

    public bool  getNextDrawJackpotRequested()
      {
        Debug.Assert(flagHasNextDrawJackpotRequested);
        return storeNextDrawJackpotRequested;
      }

    public bool  hasQueryGames()
      {
        return flagHasQueryGames;
      }

    public int  countOfQueryGames()
      {
        Debug.Assert(flagHasQueryGames);
        return storeQueryGames.Count;
      }

    public LotteryGameIdentityJSON   elementOfQueryGames(int element_num)
      {
        Debug.Assert(flagHasQueryGames);
        return storeQueryGames[element_num];
      }

    public List< LotteryGameIdentityJSON  >  getQueryGames()
      {
        Debug.Assert(flagHasQueryGames);
        return storeQueryGames;
      }


    public virtual int extraLotteryResultsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLotteryResultsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLotteryResultsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLotteryResultsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLastDrawNumbersRequested(bool new_value)
      {
        flagHasLastDrawNumbersRequested = true;
        storeLastDrawNumbersRequested = new_value;
      }
    public void unsetLastDrawNumbersRequested()
      {
        flagHasLastDrawNumbersRequested = false;
      }
    public void setNextDrawDateRequested(bool new_value)
      {
        flagHasNextDrawDateRequested = true;
        storeNextDrawDateRequested = new_value;
      }
    public void unsetNextDrawDateRequested()
      {
        flagHasNextDrawDateRequested = false;
      }
    public void setNextDrawJackpotRequested(bool new_value)
      {
        flagHasNextDrawJackpotRequested = true;
        storeNextDrawJackpotRequested = new_value;
      }
    public void unsetNextDrawJackpotRequested()
      {
        flagHasNextDrawJackpotRequested = false;
      }
    public void initQueryGames()
      {
        if (flagHasQueryGames)
          {
            for (int num1 = 0; num1 < storeQueryGames.Count; ++num1)
              {
              }
          }
        flagHasQueryGames = true;
        storeQueryGames.Clear();
      }
    public void appendQueryGames(LotteryGameIdentityJSON  to_append)
      {
        if (!flagHasQueryGames)
          {
            flagHasQueryGames = true;
            storeQueryGames.Clear();
          }
        Debug.Assert(flagHasQueryGames);
        storeQueryGames.Add(to_append);
      }
    public void unsetQueryGames()
      {
        if (flagHasQueryGames)
          {
            for (int num2 = 0; num2 < storeQueryGames.Count; ++num2)
              {
              }
          }
        flagHasQueryGames = false;
        storeQueryGames.Clear();
      }

    public virtual void extraLotteryResultsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLotteryResultsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLotteryResultsQueryStateLookup(key);
        if (old_field == null)
          {
            extraLotteryResultsQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLastDrawNumbersRequested);
        if (flagHasLastDrawNumbersRequested)
          {
            handler.start_pair("LastDrawNumbersRequested");
            handler.boolean_value(storeLastDrawNumbersRequested);
          }
        Debug.Assert(partial_allowed || flagHasNextDrawDateRequested);
        if (flagHasNextDrawDateRequested)
          {
            handler.start_pair("NextDrawDateRequested");
            handler.boolean_value(storeNextDrawDateRequested);
          }
        Debug.Assert(partial_allowed || flagHasNextDrawJackpotRequested);
        if (flagHasNextDrawJackpotRequested)
          {
            handler.start_pair("NextDrawJackpotRequested");
            handler.boolean_value(storeNextDrawJackpotRequested);
          }
        Debug.Assert(partial_allowed || flagHasQueryGames);
        if (flagHasQueryGames)
          {
            handler.start_pair("QueryGames");
            Debug.Assert(storeQueryGames.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryGames.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryGames[num1].write_partial_as_json(handler);
                else
                    storeQueryGames[num1].write_as_json(handler);
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
        if (!(hasLastDrawNumbersRequested()))
          {
            return "When parsing the object for %what%, the \"LastDrawNumbersRequested\" field was missing.";
          }
        if (!(hasNextDrawDateRequested()))
          {
            return "When parsing the object for %what%, the \"NextDrawDateRequested\" field was missing.";
          }
        if (!(hasNextDrawJackpotRequested()))
          {
            return "When parsing the object for %what%, the \"NextDrawJackpotRequested\" field was missing.";
          }
        if (!(hasQueryGames()))
          {
            return "When parsing the object for %what%, the \"QueryGames\" field was missing.";
          }
        return null;
      }

    public static LotteryResultsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryResultsQueryState", ignore_extras);
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
    public static LotteryResultsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LotteryResultsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LotteryResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryResultsQueryState", ignore_extras);
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
    public static LotteryResultsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LotteryResultsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        LotteryResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryResultsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LotteryResultsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LotteryResultsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LotteryResultsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LotteryResultsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorLastDrawNumbersRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorNextDrawDateRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorNextDrawJackpotRequested;
        private LotteryGameIdentityJSON.HoldingArrayGenerator fieldGeneratorQueryGames;
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
            LotteryResultsQueryStateJSON result = new LotteryResultsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLotteryResultsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LotteryResultsQueryStateJSON result)
          {
            if (fieldGeneratorLastDrawNumbersRequested.have_value)
              {
                result.setLastDrawNumbersRequested(fieldGeneratorLastDrawNumbersRequested.value);
                fieldGeneratorLastDrawNumbersRequested.have_value = false;
              }
            else if ((!(result.hasLastDrawNumbersRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastDrawNumbersRequested\" field was missing.");
              }
            if (fieldGeneratorNextDrawDateRequested.have_value)
              {
                result.setNextDrawDateRequested(fieldGeneratorNextDrawDateRequested.value);
                fieldGeneratorNextDrawDateRequested.have_value = false;
              }
            else if ((!(result.hasNextDrawDateRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextDrawDateRequested\" field was missing.");
              }
            if (fieldGeneratorNextDrawJackpotRequested.have_value)
              {
                result.setNextDrawJackpotRequested(fieldGeneratorNextDrawJackpotRequested.value);
                fieldGeneratorNextDrawJackpotRequested.have_value = false;
              }
            else if ((!(result.hasNextDrawJackpotRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextDrawJackpotRequested\" field was missing.");
              }
            if (fieldGeneratorQueryGames.have_value)
              {
                result.initQueryGames();
                int count = fieldGeneratorQueryGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryGames(fieldGeneratorQueryGames.value[num]);
                  }
                fieldGeneratorQueryGames.value.Clear();
                fieldGeneratorQueryGames.have_value = false;
              }
            else if ((!(result.hasQueryGames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryGames\" field was missing.");
              }
          }
        protected abstract void handle_result(LotteryResultsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "astDrawNumbersRequested", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorLastDrawNumbersRequested;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "extDraw", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorNextDrawDateRequested;
                                break;
                            case 'J':
                                if ((String.Compare(field_name, 9, "ackpotRequested", 0, 15, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorNextDrawJackpotRequested;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryGames", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorQueryGames;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLastDrawNumbersRequested = new JSONHoldingBooleanGenerator("field \"LastDrawNumbersRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorNextDrawDateRequested = new JSONHoldingBooleanGenerator("field \"NextDrawDateRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorNextDrawJackpotRequested = new JSONHoldingBooleanGenerator("field \"NextDrawJackpotRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorQueryGames = new LotteryGameIdentityJSON.HoldingArrayGenerator("field \"QueryGames\" of the LotteryResultsQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LotteryResultsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLastDrawNumbersRequested = new JSONHoldingBooleanGenerator("field \"LastDrawNumbersRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorNextDrawDateRequested = new JSONHoldingBooleanGenerator("field \"NextDrawDateRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorNextDrawJackpotRequested = new JSONHoldingBooleanGenerator("field \"NextDrawJackpotRequested\" of the LotteryResultsQueryState class");
            fieldGeneratorQueryGames = new LotteryGameIdentityJSON.HoldingArrayGenerator("field \"QueryGames\" of the LotteryResultsQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LotteryResultsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLastDrawNumbersRequested.reset();
            fieldGeneratorNextDrawDateRequested.reset();
            fieldGeneratorNextDrawJackpotRequested.reset();
            fieldGeneratorQueryGames.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQueryGames.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQueryGames.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LotteryResultsQueryStateJSON  result)
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
        public LotteryResultsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LotteryResultsQueryStateJSON  result)
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
    protected virtual void handle_result(List<LotteryResultsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LotteryResultsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LotteryResultsQueryStateJSON>();
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
    public List<LotteryResultsQueryStateJSON> value;
  };
  };
