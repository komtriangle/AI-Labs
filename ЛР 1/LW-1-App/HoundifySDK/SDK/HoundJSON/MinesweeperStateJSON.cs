/* file "MinesweeperStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MinesweeperStateJSON : JSONBase
  {
    private bool flagHasHeight;
    private sbyte storeHeight;
    private bool flagHasWidth;
    private sbyte storeWidth;
    private bool flagHasMineCount;
    private short storeMineCount;
    private bool flagHasMineCoordinates;
    private List< MinesweeperCoordinateJSON  > storeMineCoordinates;
    private bool flagHasUncoveredCellCoordinates;
    private List< MinesweeperCoordinateJSON  > storeUncoveredCellCoordinates;
    private bool flagHasFlagCoordinates;
    private List< MinesweeperCoordinateJSON  > storeFlagCoordinates;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHeight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Height of MinesweeperStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Height of MinesweeperStateJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHeight(extracted_integer);
      }


    private void  fromJSONWidth(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Width of MinesweeperStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Width of MinesweeperStateJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setWidth(extracted_integer);
      }


    private void  fromJSONMineCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MineCount of MinesweeperStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MineCount of MinesweeperStateJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setMineCount(extracted_integer);
      }


    private void  fromJSONMineCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MineCoordinates of MinesweeperStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MinesweeperCoordinateJSON  > vector_MineCoordinates1 = new List< MinesweeperCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MinesweeperCoordinateJSON convert_classy = MinesweeperCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MineCoordinates1.Add(convert_classy);
          }
        initMineCoordinates();
        for (int num1 = 0; num1 < vector_MineCoordinates1.Count; ++num1)
            appendMineCoordinates(vector_MineCoordinates1[num1]);
        for (int num1 = 0; num1 < vector_MineCoordinates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUncoveredCellCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UncoveredCellCoordinates of MinesweeperStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MinesweeperCoordinateJSON  > vector_UncoveredCellCoordinates1 = new List< MinesweeperCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MinesweeperCoordinateJSON convert_classy = MinesweeperCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UncoveredCellCoordinates1.Add(convert_classy);
          }
        initUncoveredCellCoordinates();
        for (int num2 = 0; num2 < vector_UncoveredCellCoordinates1.Count; ++num2)
            appendUncoveredCellCoordinates(vector_UncoveredCellCoordinates1[num2]);
        for (int num1 = 0; num1 < vector_UncoveredCellCoordinates1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFlagCoordinates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlagCoordinates of MinesweeperStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MinesweeperCoordinateJSON  > vector_FlagCoordinates1 = new List< MinesweeperCoordinateJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MinesweeperCoordinateJSON convert_classy = MinesweeperCoordinateJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlagCoordinates1.Add(convert_classy);
          }
        initFlagCoordinates();
        for (int num3 = 0; num3 < vector_FlagCoordinates1.Count; ++num3)
            appendFlagCoordinates(vector_FlagCoordinates1[num3]);
        for (int num1 = 0; num1 < vector_FlagCoordinates1.Count; ++num1)
          {
          }
      }


    public MinesweeperStateJSON()
      {
        flagHasHeight = false;
        flagHasWidth = false;
        flagHasMineCount = false;
        flagHasMineCoordinates = false;
        flagHasUncoveredCellCoordinates = false;
        flagHasFlagCoordinates = false;
        storeMineCoordinates = new List< MinesweeperCoordinateJSON  >();
        storeUncoveredCellCoordinates = new List< MinesweeperCoordinateJSON  >();
        storeFlagCoordinates = new List< MinesweeperCoordinateJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHeight()
      {
        return flagHasHeight;
      }

    public sbyte  getHeight()
      {
        Debug.Assert(flagHasHeight);
        return storeHeight;
      }

    public bool  hasWidth()
      {
        return flagHasWidth;
      }

    public sbyte  getWidth()
      {
        Debug.Assert(flagHasWidth);
        return storeWidth;
      }

    public bool  hasMineCount()
      {
        return flagHasMineCount;
      }

    public short  getMineCount()
      {
        Debug.Assert(flagHasMineCount);
        return storeMineCount;
      }

    public bool  hasMineCoordinates()
      {
        return flagHasMineCoordinates;
      }

    public int  countOfMineCoordinates()
      {
        Debug.Assert(flagHasMineCoordinates);
        return storeMineCoordinates.Count;
      }

    public MinesweeperCoordinateJSON   elementOfMineCoordinates(int element_num)
      {
        Debug.Assert(flagHasMineCoordinates);
        return storeMineCoordinates[element_num];
      }

    public List< MinesweeperCoordinateJSON  >  getMineCoordinates()
      {
        Debug.Assert(flagHasMineCoordinates);
        return storeMineCoordinates;
      }

    public bool  hasUncoveredCellCoordinates()
      {
        return flagHasUncoveredCellCoordinates;
      }

    public int  countOfUncoveredCellCoordinates()
      {
        Debug.Assert(flagHasUncoveredCellCoordinates);
        return storeUncoveredCellCoordinates.Count;
      }

    public MinesweeperCoordinateJSON   elementOfUncoveredCellCoordinates(int element_num)
      {
        Debug.Assert(flagHasUncoveredCellCoordinates);
        return storeUncoveredCellCoordinates[element_num];
      }

    public List< MinesweeperCoordinateJSON  >  getUncoveredCellCoordinates()
      {
        Debug.Assert(flagHasUncoveredCellCoordinates);
        return storeUncoveredCellCoordinates;
      }

    public bool  hasFlagCoordinates()
      {
        return flagHasFlagCoordinates;
      }

    public int  countOfFlagCoordinates()
      {
        Debug.Assert(flagHasFlagCoordinates);
        return storeFlagCoordinates.Count;
      }

    public MinesweeperCoordinateJSON   elementOfFlagCoordinates(int element_num)
      {
        Debug.Assert(flagHasFlagCoordinates);
        return storeFlagCoordinates[element_num];
      }

    public List< MinesweeperCoordinateJSON  >  getFlagCoordinates()
      {
        Debug.Assert(flagHasFlagCoordinates);
        return storeFlagCoordinates;
      }


    public virtual int extraMinesweeperStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMinesweeperStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMinesweeperStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMinesweeperStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHeight(sbyte new_value)
      {
        flagHasHeight = true;
        if (new_value < 1)
            throw new Exception("The value for field Height of MinesweeperStateJSON is less than the lower bound (1) for that field.");
        if (new_value > 127)
            throw new Exception("The value for field Height of MinesweeperStateJSON is greater than the upper bound (127) for that field.");
        storeHeight = new_value;
      }
    public void unsetHeight()
      {
        flagHasHeight = false;
      }
    public void setWidth(sbyte new_value)
      {
        flagHasWidth = true;
        if (new_value < 1)
            throw new Exception("The value for field Width of MinesweeperStateJSON is less than the lower bound (1) for that field.");
        if (new_value > 127)
            throw new Exception("The value for field Width of MinesweeperStateJSON is greater than the upper bound (127) for that field.");
        storeWidth = new_value;
      }
    public void unsetWidth()
      {
        flagHasWidth = false;
      }
    public void setMineCount(short new_value)
      {
        flagHasMineCount = true;
        if (new_value < 0)
            throw new Exception("The value for field MineCount of MinesweeperStateJSON is less than the lower bound (0) for that field.");
        if (new_value > 16129)
            throw new Exception("The value for field MineCount of MinesweeperStateJSON is greater than the upper bound (16129) for that field.");
        storeMineCount = new_value;
      }
    public void unsetMineCount()
      {
        flagHasMineCount = false;
      }
    public void initMineCoordinates()
      {
        if (flagHasMineCoordinates)
          {
            for (int num1 = 0; num1 < storeMineCoordinates.Count; ++num1)
              {
              }
          }
        flagHasMineCoordinates = true;
        storeMineCoordinates.Clear();
      }
    public void appendMineCoordinates(MinesweeperCoordinateJSON  to_append)
      {
        if (!flagHasMineCoordinates)
          {
            flagHasMineCoordinates = true;
            storeMineCoordinates.Clear();
          }
        Debug.Assert(flagHasMineCoordinates);
        storeMineCoordinates.Add(to_append);
      }
    public void unsetMineCoordinates()
      {
        if (flagHasMineCoordinates)
          {
            for (int num2 = 0; num2 < storeMineCoordinates.Count; ++num2)
              {
              }
          }
        flagHasMineCoordinates = false;
        storeMineCoordinates.Clear();
      }
    public void initUncoveredCellCoordinates()
      {
        if (flagHasUncoveredCellCoordinates)
          {
            for (int num3 = 0; num3 < storeUncoveredCellCoordinates.Count; ++num3)
              {
              }
          }
        flagHasUncoveredCellCoordinates = true;
        storeUncoveredCellCoordinates.Clear();
      }
    public void appendUncoveredCellCoordinates(MinesweeperCoordinateJSON  to_append)
      {
        if (!flagHasUncoveredCellCoordinates)
          {
            flagHasUncoveredCellCoordinates = true;
            storeUncoveredCellCoordinates.Clear();
          }
        Debug.Assert(flagHasUncoveredCellCoordinates);
        storeUncoveredCellCoordinates.Add(to_append);
      }
    public void unsetUncoveredCellCoordinates()
      {
        if (flagHasUncoveredCellCoordinates)
          {
            for (int num4 = 0; num4 < storeUncoveredCellCoordinates.Count; ++num4)
              {
              }
          }
        flagHasUncoveredCellCoordinates = false;
        storeUncoveredCellCoordinates.Clear();
      }
    public void initFlagCoordinates()
      {
        if (flagHasFlagCoordinates)
          {
            for (int num5 = 0; num5 < storeFlagCoordinates.Count; ++num5)
              {
              }
          }
        flagHasFlagCoordinates = true;
        storeFlagCoordinates.Clear();
      }
    public void appendFlagCoordinates(MinesweeperCoordinateJSON  to_append)
      {
        if (!flagHasFlagCoordinates)
          {
            flagHasFlagCoordinates = true;
            storeFlagCoordinates.Clear();
          }
        Debug.Assert(flagHasFlagCoordinates);
        storeFlagCoordinates.Add(to_append);
      }
    public void unsetFlagCoordinates()
      {
        if (flagHasFlagCoordinates)
          {
            for (int num6 = 0; num6 < storeFlagCoordinates.Count; ++num6)
              {
              }
          }
        flagHasFlagCoordinates = false;
        storeFlagCoordinates.Clear();
      }

    public virtual void extraMinesweeperStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMinesweeperStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMinesweeperStateLookup(key);
        if (old_field == null)
          {
            extraMinesweeperStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHeight);
        if (flagHasHeight)
          {
            handler.start_pair("Height");
            handler.number_value(storeHeight);
          }
        Debug.Assert(partial_allowed || flagHasWidth);
        if (flagHasWidth)
          {
            handler.start_pair("Width");
            handler.number_value(storeWidth);
          }
        Debug.Assert(partial_allowed || flagHasMineCount);
        if (flagHasMineCount)
          {
            handler.start_pair("MineCount");
            handler.number_value(storeMineCount);
          }
        if (flagHasMineCoordinates)
          {
            handler.start_pair("MineCoordinates");
            handler.start_array();
            for (int num1 = 0; num1 < storeMineCoordinates.Count; ++num1)
              {
                if (partial_allowed)
                    storeMineCoordinates[num1].write_partial_as_json(handler);
                else
                    storeMineCoordinates[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasUncoveredCellCoordinates);
        if (flagHasUncoveredCellCoordinates)
          {
            handler.start_pair("UncoveredCellCoordinates");
            handler.start_array();
            for (int num2 = 0; num2 < storeUncoveredCellCoordinates.Count; ++num2)
              {
                if (partial_allowed)
                    storeUncoveredCellCoordinates[num2].write_partial_as_json(handler);
                else
                    storeUncoveredCellCoordinates[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasFlagCoordinates);
        if (flagHasFlagCoordinates)
          {
            handler.start_pair("FlagCoordinates");
            handler.start_array();
            for (int num3 = 0; num3 < storeFlagCoordinates.Count; ++num3)
              {
                if (partial_allowed)
                    storeFlagCoordinates[num3].write_partial_as_json(handler);
                else
                    storeFlagCoordinates[num3].write_as_json(handler);
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
        if (!(hasHeight()))
          {
            return "When parsing the object for %what%, the \"Height\" field was missing.";
          }
        if (!(hasWidth()))
          {
            return "When parsing the object for %what%, the \"Width\" field was missing.";
          }
        if (!(hasMineCount()))
          {
            return "When parsing the object for %what%, the \"MineCount\" field was missing.";
          }
        if (!(hasUncoveredCellCoordinates()))
          {
            return "When parsing the object for %what%, the \"UncoveredCellCoordinates\" field was missing.";
          }
        if (!(hasFlagCoordinates()))
          {
            return "When parsing the object for %what%, the \"FlagCoordinates\" field was missing.";
          }
        return null;
      }

    public static MinesweeperStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperState", ignore_extras);
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
    public static MinesweeperStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MinesweeperStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MinesweeperStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperState", ignore_extras);
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
    public static MinesweeperStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MinesweeperStateJSON from_text(string text, bool ignore_extras)
      {
        MinesweeperStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MinesweeperStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MinesweeperStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MinesweeperStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MinesweeperState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorHeight : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHeight(String what) : base(what, 1, 127)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHeight : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHeight(String what) : base(what, 1, 127)
              {
              }
          };
        private FieldHoldingGeneratorHeight fieldGeneratorHeight;
    private class FieldHoldingGeneratorWidth : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorWidth(String what) : base(what, 1, 127)
              {
              }
          };
    private class FieldHoldingArrayGeneratorWidth : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorWidth(String what) : base(what, 1, 127)
              {
              }
          };
        private FieldHoldingGeneratorWidth fieldGeneratorWidth;
    private class FieldHoldingGeneratorMineCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorMineCount(String what) : base(what, 0, 16129)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMineCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMineCount(String what) : base(what, 0, 16129)
              {
              }
          };
        private FieldHoldingGeneratorMineCount fieldGeneratorMineCount;
        private MinesweeperCoordinateJSON.HoldingArrayGenerator fieldGeneratorMineCoordinates;
        private MinesweeperCoordinateJSON.HoldingArrayGenerator fieldGeneratorUncoveredCellCoordinates;
        private MinesweeperCoordinateJSON.HoldingArrayGenerator fieldGeneratorFlagCoordinates;
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
            MinesweeperStateJSON result = new MinesweeperStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMinesweeperStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MinesweeperStateJSON result)
          {
            if (fieldGeneratorHeight.have_value)
              {
                result.setHeight((sbyte)(fieldGeneratorHeight.value));
                fieldGeneratorHeight.have_value = false;
              }
            else if ((!(result.hasHeight())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Height\" field was missing.");
              }
            if (fieldGeneratorWidth.have_value)
              {
                result.setWidth((sbyte)(fieldGeneratorWidth.value));
                fieldGeneratorWidth.have_value = false;
              }
            else if ((!(result.hasWidth())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Width\" field was missing.");
              }
            if (fieldGeneratorMineCount.have_value)
              {
                result.setMineCount((short)(fieldGeneratorMineCount.value));
                fieldGeneratorMineCount.have_value = false;
              }
            else if ((!(result.hasMineCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MineCount\" field was missing.");
              }
            if (fieldGeneratorMineCoordinates.have_value)
              {
                result.initMineCoordinates();
                int count = fieldGeneratorMineCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMineCoordinates(fieldGeneratorMineCoordinates.value[num]);
                  }
                fieldGeneratorMineCoordinates.value.Clear();
                fieldGeneratorMineCoordinates.have_value = false;
              }
            if (fieldGeneratorUncoveredCellCoordinates.have_value)
              {
                result.initUncoveredCellCoordinates();
                int count = fieldGeneratorUncoveredCellCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUncoveredCellCoordinates(fieldGeneratorUncoveredCellCoordinates.value[num]);
                  }
                fieldGeneratorUncoveredCellCoordinates.value.Clear();
                fieldGeneratorUncoveredCellCoordinates.have_value = false;
              }
            else if ((!(result.hasUncoveredCellCoordinates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UncoveredCellCoordinates\" field was missing.");
              }
            if (fieldGeneratorFlagCoordinates.have_value)
              {
                result.initFlagCoordinates();
                int count = fieldGeneratorFlagCoordinates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlagCoordinates(fieldGeneratorFlagCoordinates.value[num]);
                  }
                fieldGeneratorFlagCoordinates.value.Clear();
                fieldGeneratorFlagCoordinates.have_value = false;
              }
            else if ((!(result.hasFlagCoordinates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlagCoordinates\" field was missing.");
              }
          }
        protected abstract void handle_result(MinesweeperStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "lagCoordinates", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorFlagCoordinates;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorHeight;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ineCo", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'o':
                                if ((String.Compare(field_name, 7, "rdinates", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorMineCoordinates;
                                break;
                            case 'u':
                                if ((String.Compare(field_name, 7, "nt", 0, 2, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorMineCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "ncoveredCellCoordinates", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorUncoveredCellCoordinates;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "idth", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorWidth;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHeight = new FieldHoldingGeneratorHeight("field \"Height\" of the MinesweeperState class");
            fieldGeneratorWidth = new FieldHoldingGeneratorWidth("field \"Width\" of the MinesweeperState class");
            fieldGeneratorMineCount = new FieldHoldingGeneratorMineCount("field \"MineCount\" of the MinesweeperState class");
            fieldGeneratorMineCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"MineCoordinates\" of the MinesweeperState class", ignore_extras);
            fieldGeneratorUncoveredCellCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"UncoveredCellCoordinates\" of the MinesweeperState class", ignore_extras);
            fieldGeneratorFlagCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"FlagCoordinates\" of the MinesweeperState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MinesweeperState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHeight = new FieldHoldingGeneratorHeight("field \"Height\" of the MinesweeperState class");
            fieldGeneratorWidth = new FieldHoldingGeneratorWidth("field \"Width\" of the MinesweeperState class");
            fieldGeneratorMineCount = new FieldHoldingGeneratorMineCount("field \"MineCount\" of the MinesweeperState class");
            fieldGeneratorMineCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"MineCoordinates\" of the MinesweeperState class", false);
            fieldGeneratorUncoveredCellCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"UncoveredCellCoordinates\" of the MinesweeperState class", false);
            fieldGeneratorFlagCoordinates = new MinesweeperCoordinateJSON.HoldingArrayGenerator("field \"FlagCoordinates\" of the MinesweeperState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MinesweeperState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHeight.reset();
            fieldGeneratorWidth.reset();
            fieldGeneratorMineCount.reset();
            fieldGeneratorMineCoordinates.reset();
            fieldGeneratorUncoveredCellCoordinates.reset();
            fieldGeneratorFlagCoordinates.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMineCoordinates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUncoveredCellCoordinates.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlagCoordinates.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMineCoordinates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUncoveredCellCoordinates.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlagCoordinates.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MinesweeperStateJSON  result)
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
        public MinesweeperStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MinesweeperStateJSON  result)
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
    protected virtual void handle_result(List<MinesweeperStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MinesweeperStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MinesweeperStateJSON>();
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
    public List<MinesweeperStateJSON> value;
  };
  };
