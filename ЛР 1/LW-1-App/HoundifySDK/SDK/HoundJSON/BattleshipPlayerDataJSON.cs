/* file "BattleshipPlayerDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BattleshipPlayerDataJSON : JSONBase
  {
    private bool flagHasCoordinates;
    private List< BattleshipCoordinateJSON  > storeCoordinates;
    private bool flagHasSunkShip;
    private BattleshipShipTypeJSON  storeSunkShip;
    private bool flagHasShipLocations;
    private List< BattleshipShipTypeJSON  > storeShipLocations;
    private bool flagHasIsGameOver;
    private bool storeIsGameOver;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Coordinates of BattleshipPlayerDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BattleshipCoordinateJSON  > vector_Coordinates1 = new List< BattleshipCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BattleshipCoordinateJSON convert_classy = BattleshipCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Coordinates1.Add(convert_classy);
          }
        initCoordinates();
        for (int num1 = 0; num1 < vector_Coordinates1.Count; ++num1)
            appendCoordinates(vector_Coordinates1[num1]);
        for (int num1 = 0; num1 < vector_Coordinates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSunkShip(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BattleshipShipTypeJSON convert_classy = BattleshipShipTypeJSON.from_json(json_value, ignore_extras, true);
        setSunkShip(convert_classy);
      }


    private void  fromJSONShipLocations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ShipLocations of BattleshipPlayerDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BattleshipShipTypeJSON  > vector_ShipLocations1 = new List< BattleshipShipTypeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BattleshipShipTypeJSON convert_classy = BattleshipShipTypeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ShipLocations1.Add(convert_classy);
          }
        initShipLocations();
        for (int num2 = 0; num2 < vector_ShipLocations1.Count; ++num2)
            appendShipLocations(vector_ShipLocations1[num2]);
        for (int num1 = 0; num1 < vector_ShipLocations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIsGameOver(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsGameOver of BattleshipPlayerDataJSON is not true for false.");
              }
          }
        setIsGameOver(the_bool);
      }


    public BattleshipPlayerDataJSON()
      {
        flagHasCoordinates = false;
        flagHasSunkShip = false;
        flagHasShipLocations = false;
        flagHasIsGameOver = false;
        storeCoordinates = new List< BattleshipCoordinateJSON  >();
        storeShipLocations = new List< BattleshipShipTypeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCoordinates()
      {
        return flagHasCoordinates;
      }

    public int  countOfCoordinates()
      {
        Debug.Assert(flagHasCoordinates);
        return storeCoordinates.Count;
      }

    public BattleshipCoordinateJSON   elementOfCoordinates(int element_num)
      {
        Debug.Assert(flagHasCoordinates);
        return storeCoordinates[element_num];
      }

    public List< BattleshipCoordinateJSON  >  getCoordinates()
      {
        Debug.Assert(flagHasCoordinates);
        return storeCoordinates;
      }

    public bool  hasSunkShip()
      {
        return flagHasSunkShip;
      }

    public BattleshipShipTypeJSON   getSunkShip()
      {
        Debug.Assert(flagHasSunkShip);
        return storeSunkShip;
      }

    public bool  hasShipLocations()
      {
        return flagHasShipLocations;
      }

    public int  countOfShipLocations()
      {
        Debug.Assert(flagHasShipLocations);
        return storeShipLocations.Count;
      }

    public BattleshipShipTypeJSON   elementOfShipLocations(int element_num)
      {
        Debug.Assert(flagHasShipLocations);
        return storeShipLocations[element_num];
      }

    public List< BattleshipShipTypeJSON  >  getShipLocations()
      {
        Debug.Assert(flagHasShipLocations);
        return storeShipLocations;
      }

    public bool  hasIsGameOver()
      {
        return flagHasIsGameOver;
      }

    public bool  getIsGameOver()
      {
        Debug.Assert(flagHasIsGameOver);
        return storeIsGameOver;
      }


    public virtual int extraBattleshipPlayerDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBattleshipPlayerDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBattleshipPlayerDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBattleshipPlayerDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initCoordinates()
      {
        if (flagHasCoordinates)
          {
            for (int num1 = 0; num1 < storeCoordinates.Count; ++num1)
              {
              }
          }
        flagHasCoordinates = true;
        storeCoordinates.Clear();
      }
    public void appendCoordinates(BattleshipCoordinateJSON  to_append)
      {
        if (!flagHasCoordinates)
          {
            flagHasCoordinates = true;
            storeCoordinates.Clear();
          }
        Debug.Assert(flagHasCoordinates);
        storeCoordinates.Add(to_append);
      }
    public void unsetCoordinates()
      {
        if (flagHasCoordinates)
          {
            for (int num2 = 0; num2 < storeCoordinates.Count; ++num2)
              {
              }
          }
        flagHasCoordinates = false;
        storeCoordinates.Clear();
      }
    public void setSunkShip(BattleshipShipTypeJSON  new_value)
      {
        if (flagHasSunkShip)
          {
          }
        flagHasSunkShip = true;
        storeSunkShip = new_value;
      }
    public void unsetSunkShip()
      {
        if (flagHasSunkShip)
          {
          }
        flagHasSunkShip = false;
      }
    public void initShipLocations()
      {
        if (flagHasShipLocations)
          {
            for (int num3 = 0; num3 < storeShipLocations.Count; ++num3)
              {
              }
          }
        flagHasShipLocations = true;
        storeShipLocations.Clear();
      }
    public void appendShipLocations(BattleshipShipTypeJSON  to_append)
      {
        if (!flagHasShipLocations)
          {
            flagHasShipLocations = true;
            storeShipLocations.Clear();
          }
        Debug.Assert(flagHasShipLocations);
        storeShipLocations.Add(to_append);
      }
    public void unsetShipLocations()
      {
        if (flagHasShipLocations)
          {
            for (int num4 = 0; num4 < storeShipLocations.Count; ++num4)
              {
              }
          }
        flagHasShipLocations = false;
        storeShipLocations.Clear();
      }
    public void setIsGameOver(bool new_value)
      {
        flagHasIsGameOver = true;
        storeIsGameOver = new_value;
      }
    public void unsetIsGameOver()
      {
        flagHasIsGameOver = false;
      }

    public virtual void extraBattleshipPlayerDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBattleshipPlayerDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBattleshipPlayerDataLookup(key);
        if (old_field == null)
          {
            extraBattleshipPlayerDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCoordinates);
        if (flagHasCoordinates)
          {
            handler.start_pair("Coordinates");
            handler.start_array();
            for (int num1 = 0; num1 < storeCoordinates.Count; ++num1)
              {
                if (partial_allowed)
                    storeCoordinates[num1].write_partial_as_json(handler);
                else
                    storeCoordinates[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSunkShip)
          {
            handler.start_pair("SunkShip");
            if (partial_allowed)
                storeSunkShip.write_partial_as_json(handler);
            else
                storeSunkShip.write_as_json(handler);
          }
        if (flagHasShipLocations)
          {
            handler.start_pair("ShipLocations");
            handler.start_array();
            for (int num2 = 0; num2 < storeShipLocations.Count; ++num2)
              {
                if (partial_allowed)
                    storeShipLocations[num2].write_partial_as_json(handler);
                else
                    storeShipLocations[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasIsGameOver);
        if (flagHasIsGameOver)
          {
            handler.start_pair("IsGameOver");
            handler.boolean_value(storeIsGameOver);
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
        if (!(hasCoordinates()))
          {
            return "When parsing the object for %what%, the \"Coordinates\" field was missing.";
          }
        if (!(hasIsGameOver()))
          {
            return "When parsing the object for %what%, the \"IsGameOver\" field was missing.";
          }
        return null;
      }

    public static BattleshipPlayerDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipPlayerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipPlayerData", ignore_extras);
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
    public static BattleshipPlayerDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipPlayerDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipPlayerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipPlayerData", ignore_extras);
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
    public static BattleshipPlayerDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipPlayerDataJSON from_text(string text, bool ignore_extras)
      {
        BattleshipPlayerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipPlayerData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipPlayerDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BattleshipPlayerDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipPlayerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipPlayerData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private BattleshipCoordinateJSON.HoldingArrayGenerator fieldGeneratorCoordinates;
        private BattleshipShipTypeJSON.HoldingGenerator fieldGeneratorSunkShip;
        private BattleshipShipTypeJSON.HoldingArrayGenerator fieldGeneratorShipLocations;
        private JSONHoldingBooleanGenerator fieldGeneratorIsGameOver;
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
            BattleshipPlayerDataJSON result = new BattleshipPlayerDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipPlayerDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BattleshipPlayerDataJSON result)
          {
            if (fieldGeneratorCoordinates.have_value)
              {
                result.initCoordinates();
                int count = fieldGeneratorCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCoordinates(fieldGeneratorCoordinates.value[num]);
                  }
                fieldGeneratorCoordinates.value.Clear();
                fieldGeneratorCoordinates.have_value = false;
              }
            else if ((!(result.hasCoordinates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Coordinates\" field was missing.");
              }
            if (fieldGeneratorSunkShip.have_value)
              {
                result.setSunkShip(fieldGeneratorSunkShip.value);
                fieldGeneratorSunkShip.have_value = false;
              }
            if (fieldGeneratorShipLocations.have_value)
              {
                result.initShipLocations();
                int count = fieldGeneratorShipLocations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendShipLocations(fieldGeneratorShipLocations.value[num]);
                  }
                fieldGeneratorShipLocations.value.Clear();
                fieldGeneratorShipLocations.have_value = false;
              }
            if (fieldGeneratorIsGameOver.have_value)
              {
                result.setIsGameOver(fieldGeneratorIsGameOver.value);
                fieldGeneratorIsGameOver.have_value = false;
              }
            else if ((!(result.hasIsGameOver())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsGameOver\" field was missing.");
              }
          }
        protected abstract void handle_result(BattleshipPlayerDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "oordinates", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCoordinates;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sGameOver", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsGameOver;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ipLocations", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorShipLocations;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "nkShip", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSunkShip;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"Coordinates\" of the BattleshipPlayerData class", ignore_extras);
            fieldGeneratorSunkShip = new BattleshipShipTypeJSON.HoldingGenerator("field \"SunkShip\" of the BattleshipPlayerData class", ignore_extras);
            fieldGeneratorShipLocations = new BattleshipShipTypeJSON.HoldingArrayGenerator("field \"ShipLocations\" of the BattleshipPlayerData class", ignore_extras);
            fieldGeneratorIsGameOver = new JSONHoldingBooleanGenerator("field \"IsGameOver\" of the BattleshipPlayerData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BattleshipPlayerData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCoordinates = new BattleshipCoordinateJSON.HoldingArrayGenerator("field \"Coordinates\" of the BattleshipPlayerData class", false);
            fieldGeneratorSunkShip = new BattleshipShipTypeJSON.HoldingGenerator("field \"SunkShip\" of the BattleshipPlayerData class", false);
            fieldGeneratorShipLocations = new BattleshipShipTypeJSON.HoldingArrayGenerator("field \"ShipLocations\" of the BattleshipPlayerData class", false);
            fieldGeneratorIsGameOver = new JSONHoldingBooleanGenerator("field \"IsGameOver\" of the BattleshipPlayerData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BattleshipPlayerData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCoordinates.reset();
            fieldGeneratorSunkShip.reset();
            fieldGeneratorShipLocations.reset();
            fieldGeneratorIsGameOver.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCoordinates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSunkShip.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorShipLocations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCoordinates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSunkShip.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorShipLocations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BattleshipPlayerDataJSON  result)
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
        public BattleshipPlayerDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipPlayerDataJSON  result)
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
    protected virtual void handle_result(List<BattleshipPlayerDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipPlayerDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipPlayerDataJSON>();
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
    public List<BattleshipPlayerDataJSON> value;
  };
  };
