/* file "BattleshipShipTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class BattleshipShipTypeJSON : JSONBase
  {
    public enum TypeShipName
      {
        ShipName_Carrier,
        ShipName_Battleship,
        ShipName_Submarine,
        ShipName_Cruiser,
        ShipName_Destroyer
      };

    public static TypeShipName  stringToShipName(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "attleship", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeShipName.ShipName_Battleship;
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "rrier", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeShipName.ShipName_Carrier;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "uiser", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeShipName.ShipName_Cruiser;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "estroyer", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeShipName.ShipName_Destroyer;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "ubmarine", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeShipName.ShipName_Submarine;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ShipName' is not one of the legal values.");
      }

    public static string  stringFromShipName(TypeShipName the_enum)
      {
        switch (the_enum)
          {
            case TypeShipName.ShipName_Carrier:
                return "Carrier";
            case TypeShipName.ShipName_Battleship:
                return "Battleship";
            case TypeShipName.ShipName_Submarine:
                return "Submarine";
            case TypeShipName.ShipName_Cruiser:
                return "Cruiser";
            case TypeShipName.ShipName_Destroyer:
                return "Destroyer";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeDirection
      {
        Direction_North,
        Direction_East,
        Direction_South,
        Direction_West,
        Direction_None
      };

    public static TypeDirection  stringToDirection(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "ast", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDirection.Direction_East;
                break;
            case 'N':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'n':
                            if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypeDirection.Direction_None;
                            break;
                        case 'r':
                            if ((String.Compare(chars, 3, "th", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeDirection.Direction_North;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "outh", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeDirection.Direction_South;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "est", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeDirection.Direction_West;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Direction' is not one of the legal values.");
      }

    public static string  stringFromDirection(TypeDirection the_enum)
      {
        switch (the_enum)
          {
            case TypeDirection.Direction_North:
                return "North";
            case TypeDirection.Direction_East:
                return "East";
            case TypeDirection.Direction_South:
                return "South";
            case TypeDirection.Direction_West:
                return "West";
            case TypeDirection.Direction_None:
                return "None";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasShipName;
    private TypeShipName storeShipName;
    private bool flagHasDirection;
    private TypeDirection storeDirection;
    private bool flagHasLength;
    private BigInteger storeLength;
    private bool flagHasShipCoordinate;
    private BattleshipCoordinateJSON  storeShipCoordinate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONShipName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShipName of BattleshipShipTypeJSON is not a string.");
        TypeShipName the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "attleship", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeShipName.ShipName_Battleship;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "rrier", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeShipName.ShipName_Carrier;
                                goto enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "uiser", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeShipName.ShipName_Cruiser;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "estroyer", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeShipName.ShipName_Destroyer;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "ubmarine", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeShipName.ShipName_Submarine;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ShipName of BattleshipShipTypeJSON is not one of the legal strings.");
      enum_is_done:;
        setShipName(the_enum);
      }


    private void  fromJSONDirection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Direction of BattleshipShipTypeJSON is not a string.");
        TypeDirection the_enum;
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "ast", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeDirection.Direction_East;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_enum = TypeDirection.Direction_None;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 3, "th", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_enum = TypeDirection.Direction_North;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "outh", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeDirection.Direction_South;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "est", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeDirection.Direction_West;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Direction of BattleshipShipTypeJSON is not one of the legal strings.");
      enum_is_done:;
        setDirection(the_enum);
      }


    private void  fromJSONLength(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Length of BattleshipShipTypeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Length of BattleshipShipTypeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLength(extracted_integer);
      }


    private void  fromJSONShipCoordinate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BattleshipCoordinateJSON convert_classy = BattleshipCoordinateJSON.from_json(json_value, ignore_extras, true);
        setShipCoordinate(convert_classy);
      }


    public BattleshipShipTypeJSON()
      {
        flagHasShipName = false;
        flagHasDirection = false;
        flagHasLength = false;
        flagHasShipCoordinate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasShipName()
      {
        return flagHasShipName;
      }

    public TypeShipName  getShipName()
      {
        Debug.Assert(flagHasShipName);
        return storeShipName;
      }

    public string  getShipNameAsString()
      {
        return stringFromShipName(getShipName());
      }

    public bool  hasDirection()
      {
        return flagHasDirection;
      }

    public TypeDirection  getDirection()
      {
        Debug.Assert(flagHasDirection);
        return storeDirection;
      }

    public string  getDirectionAsString()
      {
        return stringFromDirection(getDirection());
      }

    public bool  hasLength()
      {
        return flagHasLength;
      }

    public BigInteger  getLength()
      {
        Debug.Assert(flagHasLength);
        return storeLength;
      }

    public bool  hasShipCoordinate()
      {
        return flagHasShipCoordinate;
      }

    public BattleshipCoordinateJSON   getShipCoordinate()
      {
        Debug.Assert(flagHasShipCoordinate);
        return storeShipCoordinate;
      }


    public virtual int extraBattleshipShipTypeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBattleshipShipTypeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBattleshipShipTypeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBattleshipShipTypeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setShipName(TypeShipName new_value)
      {
        flagHasShipName = true;
        storeShipName = new_value;
      }
    public void setShipName(string chars)
      {
        setShipName(stringToShipName(chars));
      }
    public void unsetShipName()
      {
        flagHasShipName = false;
      }
    public void setDirection(TypeDirection new_value)
      {
        flagHasDirection = true;
        storeDirection = new_value;
      }
    public void setDirection(string chars)
      {
        setDirection(stringToDirection(chars));
      }
    public void unsetDirection()
      {
        flagHasDirection = false;
      }
    public void setLength(BigInteger new_value)
      {
        flagHasLength = true;
        if (new_value < 0)
            throw new Exception("The value for field Length of BattleshipShipTypeJSON is less than the lower bound (0) for that field.");
        storeLength = new_value;
      }
    public void unsetLength()
      {
        flagHasLength = false;
      }
    public void setShipCoordinate(BattleshipCoordinateJSON  new_value)
      {
        if (flagHasShipCoordinate)
          {
          }
        flagHasShipCoordinate = true;
        storeShipCoordinate = new_value;
      }
    public void unsetShipCoordinate()
      {
        if (flagHasShipCoordinate)
          {
          }
        flagHasShipCoordinate = false;
      }

    public virtual void extraBattleshipShipTypeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBattleshipShipTypeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBattleshipShipTypeLookup(key);
        if (old_field == null)
          {
            extraBattleshipShipTypeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasShipName);
        if (flagHasShipName)
          {
            handler.start_pair("ShipName");
            switch (storeShipName)
              {
                case TypeShipName.ShipName_Carrier:
                    handler.string_value("Carrier");
                    break;
                case TypeShipName.ShipName_Battleship:
                    handler.string_value("Battleship");
                    break;
                case TypeShipName.ShipName_Submarine:
                    handler.string_value("Submarine");
                    break;
                case TypeShipName.ShipName_Cruiser:
                    handler.string_value("Cruiser");
                    break;
                case TypeShipName.ShipName_Destroyer:
                    handler.string_value("Destroyer");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDirection)
          {
            handler.start_pair("Direction");
            switch (storeDirection)
              {
                case TypeDirection.Direction_North:
                    handler.string_value("North");
                    break;
                case TypeDirection.Direction_East:
                    handler.string_value("East");
                    break;
                case TypeDirection.Direction_South:
                    handler.string_value("South");
                    break;
                case TypeDirection.Direction_West:
                    handler.string_value("West");
                    break;
                case TypeDirection.Direction_None:
                    handler.string_value("None");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLength)
          {
            handler.start_pair("Length");
            handler.number_value(storeLength);
          }
        if (flagHasShipCoordinate)
          {
            handler.start_pair("ShipCoordinate");
            if (partial_allowed)
                storeShipCoordinate.write_partial_as_json(handler);
            else
                storeShipCoordinate.write_as_json(handler);
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
        if (!(hasShipName()))
          {
            return "When parsing the object for %what%, the \"ShipName\" field was missing.";
          }
        return null;
      }

    public static BattleshipShipTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipShipTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipShipType", ignore_extras);
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
    public static BattleshipShipTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipShipTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipShipTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipShipType", ignore_extras);
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
    public static BattleshipShipTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BattleshipShipTypeJSON from_text(string text, bool ignore_extras)
      {
        BattleshipShipTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipShipType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipShipTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BattleshipShipTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipShipTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipShipType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorShipName : JSONStringGenerator
          {
            protected FieldGeneratorShipName(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorShipName()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToShipName(result));
              }
            protected abstract void handle_result(TypeShipName result);
          };
    private class FieldHoldingGeneratorShipName : FieldGeneratorShipName
  {
    protected override void handle_result(TypeShipName result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorShipName(String what)
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
    public TypeShipName value;
  };
    private class FieldHoldingArrayGeneratorShipName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorShipName
      {
        private FieldHoldingArrayGeneratorShipName top;

        protected override void handle_result(TypeShipName result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorShipName init_top)
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
    protected virtual void handle_result(List<TypeShipName> result)
      {
      }

    public FieldHoldingArrayGeneratorShipName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeShipName>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorShipName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeShipName>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeShipName> value;
  };
        private FieldHoldingGeneratorShipName fieldGeneratorShipName;
    private abstract class FieldGeneratorDirection : JSONStringGenerator
          {
            protected FieldGeneratorDirection(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDirection()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDirection(result));
              }
            protected abstract void handle_result(TypeDirection result);
          };
    private class FieldHoldingGeneratorDirection : FieldGeneratorDirection
  {
    protected override void handle_result(TypeDirection result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDirection(String what)
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
    public TypeDirection value;
  };
    private class FieldHoldingArrayGeneratorDirection : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDirection
      {
        private FieldHoldingArrayGeneratorDirection top;

        protected override void handle_result(TypeDirection result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDirection init_top)
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
    protected virtual void handle_result(List<TypeDirection> result)
      {
      }

    public FieldHoldingArrayGeneratorDirection(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDirection>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDirection()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDirection>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDirection> value;
  };
        private FieldHoldingGeneratorDirection fieldGeneratorDirection;
    private class FieldHoldingGeneratorLength : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLength(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLength : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLength(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorLength fieldGeneratorLength;
        private BattleshipCoordinateJSON.HoldingGenerator fieldGeneratorShipCoordinate;
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
            BattleshipShipTypeJSON result = new BattleshipShipTypeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipShipTypeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BattleshipShipTypeJSON result)
          {
            if (fieldGeneratorShipName.have_value)
              {
                result.setShipName(fieldGeneratorShipName.value);
                fieldGeneratorShipName.have_value = false;
              }
            else if ((!(result.hasShipName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShipName\" field was missing.");
              }
            if (fieldGeneratorDirection.have_value)
              {
                result.setDirection(fieldGeneratorDirection.value);
                fieldGeneratorDirection.have_value = false;
              }
            if (fieldGeneratorLength.have_value)
              {
                result.setLength(fieldGeneratorLength.value);
                fieldGeneratorLength.have_value = false;
              }
            if (fieldGeneratorShipCoordinate.have_value)
              {
                result.setShipCoordinate(fieldGeneratorShipCoordinate.value);
                fieldGeneratorShipCoordinate.have_value = false;
              }
          }
        protected abstract void handle_result(BattleshipShipTypeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "irection", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorDirection;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ength", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLength;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "hip", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 5, "oordinate", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorShipCoordinate;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ame", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorShipName;
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
            fieldGeneratorShipName = new FieldHoldingGeneratorShipName("field \"ShipName\" of the BattleshipShipType class");
            fieldGeneratorDirection = new FieldHoldingGeneratorDirection("field \"Direction\" of the BattleshipShipType class");
            fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the BattleshipShipType class");
            fieldGeneratorShipCoordinate = new BattleshipCoordinateJSON.HoldingGenerator("field \"ShipCoordinate\" of the BattleshipShipType class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BattleshipShipType class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorShipName = new FieldHoldingGeneratorShipName("field \"ShipName\" of the BattleshipShipType class");
            fieldGeneratorDirection = new FieldHoldingGeneratorDirection("field \"Direction\" of the BattleshipShipType class");
            fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the BattleshipShipType class");
            fieldGeneratorShipCoordinate = new BattleshipCoordinateJSON.HoldingGenerator("field \"ShipCoordinate\" of the BattleshipShipType class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BattleshipShipType class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorShipName.reset();
            fieldGeneratorDirection.reset();
            fieldGeneratorLength.reset();
            fieldGeneratorShipCoordinate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorShipCoordinate.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorShipCoordinate.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BattleshipShipTypeJSON  result)
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
        public BattleshipShipTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipShipTypeJSON  result)
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
    protected virtual void handle_result(List<BattleshipShipTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipShipTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipShipTypeJSON>();
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
    public List<BattleshipShipTypeJSON> value;
  };
  };
