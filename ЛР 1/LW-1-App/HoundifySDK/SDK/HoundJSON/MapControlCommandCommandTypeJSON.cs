/* file "MapControlCommandCommandTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MapControlCommandCommandTypeJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_PanMapAbsolute,
        Value_PanMapRelative,
        Value_ZoomMap,
        Value_RotateMap,
        Value_RotateMapToHeading,
        Value_MapView2D,
        Value_MapView3D
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'M':
                if (String.Compare(chars, 1, "apView", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case '2':
                            if ((String.Compare(chars, 8, "D", 0, 1, false) == 0) && (chars.Length == 9))
                                return TypeValue.Value_MapView2D;
                            break;
                        case '3':
                            if ((String.Compare(chars, 8, "D", 0, 1, false) == 0) && (chars.Length == 9))
                                return TypeValue.Value_MapView3D;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(chars, 1, "anMap", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if ((String.Compare(chars, 7, "bsolute", 0, 7, false) == 0) && (chars.Length == 14))
                                return TypeValue.Value_PanMapAbsolute;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 7, "elative", 0, 7, false) == 0) && (chars.Length == 14))
                                return TypeValue.Value_PanMapRelative;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(chars, 1, "otateMap", 0, 8, false) == 0)
                  {
                    if (chars.Length == 9)
                      {
                        return TypeValue.Value_RotateMap;
                      }
                    switch (chars[9])
                      {
                        case 'T':
                            if ((String.Compare(chars, 10, "oHeading", 0, 8, false) == 0) && (chars.Length == 18))
                                return TypeValue.Value_RotateMapToHeading;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if ((String.Compare(chars, 1, "oomMap", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValue.Value_ZoomMap;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_PanMapAbsolute:
                return "PanMapAbsolute";
            case TypeValue.Value_PanMapRelative:
                return "PanMapRelative";
            case TypeValue.Value_ZoomMap:
                return "ZoomMap";
            case TypeValue.Value_RotateMap:
                return "RotateMap";
            case TypeValue.Value_RotateMapToHeading:
                return "RotateMapToHeading";
            case TypeValue.Value_MapView2D:
                return "MapView2D";
            case TypeValue.Value_MapView3D:
                return "MapView3D";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of MapControlCommandCommandTypeJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'M':
                if (String.Compare(json_string.getData(), 1, "apView", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case '2':
                            if ((String.Compare(json_string.getData(), 8, "D", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeValue.Value_MapView2D;
                                    goto enum_is_done;
                                  }
                            break;
                        case '3':
                            if ((String.Compare(json_string.getData(), 8, "D", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeValue.Value_MapView3D;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "anMap", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 7, "bsolute", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeValue.Value_PanMapAbsolute;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 7, "elative", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeValue.Value_PanMapRelative;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "otateMap", 0, 8, false) == 0)
                  {
                    if (json_string.getData().Length == 9)
                      {
                          {
                            the_enum = TypeValue.Value_RotateMap;
                            goto enum_is_done;
                          }
                      }
                    switch (json_string.getData()[9])
                      {
                        case 'T':
                            if ((String.Compare(json_string.getData(), 10, "oHeading", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeValue.Value_RotateMapToHeading;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Z':
                if ((String.Compare(json_string.getData(), 1, "oomMap", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeValue.Value_ZoomMap;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of MapControlCommandCommandTypeJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public MapControlCommandCommandTypeJSON()
      {
        flagHasValue = false;
      }

    public MapControlCommandCommandTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public MapControlCommandCommandTypeJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_PanMapAbsolute:
                handler.string_value("PanMapAbsolute");
                break;
            case TypeValue.Value_PanMapRelative:
                handler.string_value("PanMapRelative");
                break;
            case TypeValue.Value_ZoomMap:
                handler.string_value("ZoomMap");
                break;
            case TypeValue.Value_RotateMap:
                handler.string_value("RotateMap");
                break;
            case TypeValue.Value_RotateMapToHeading:
                handler.string_value("RotateMapToHeading");
                break;
            case TypeValue.Value_MapView2D:
                handler.string_value("MapView2D");
                break;
            case TypeValue.Value_MapView3D:
                handler.string_value("MapView3D");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_PanMapAbsolute:
                handler.string_value("PanMapAbsolute");
                break;
            case TypeValue.Value_PanMapRelative:
                handler.string_value("PanMapRelative");
                break;
            case TypeValue.Value_ZoomMap:
                handler.string_value("ZoomMap");
                break;
            case TypeValue.Value_RotateMap:
                handler.string_value("RotateMap");
                break;
            case TypeValue.Value_RotateMapToHeading:
                handler.string_value("RotateMapToHeading");
                break;
            case TypeValue.Value_MapView2D:
                handler.string_value("MapView2D");
                break;
            case TypeValue.Value_MapView3D:
                handler.string_value("MapView3D");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static MapControlCommandCommandTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlCommandCommandTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommandCommandType", ignore_extras);
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
    public static MapControlCommandCommandTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapControlCommandCommandTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MapControlCommandCommandTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommandCommandType", ignore_extras);
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
    public static MapControlCommandCommandTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MapControlCommandCommandTypeJSON from_text(string text, bool ignore_extras)
      {
        MapControlCommandCommandTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommandCommandType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MapControlCommandCommandTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MapControlCommandCommandTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MapControlCommandCommandTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MapControlCommandCommandType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            handle_result(stringToValue(result));
          }
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            MapControlCommandCommandTypeJSON result = new MapControlCommandCommandTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(MapControlCommandCommandTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type MapControlCommandCommandType")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MapControlCommandCommandTypeJSON  result)
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
        public MapControlCommandCommandTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MapControlCommandCommandTypeJSON  result)
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
    protected virtual void handle_result(List<MapControlCommandCommandTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MapControlCommandCommandTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MapControlCommandCommandTypeJSON>();
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
    public List<MapControlCommandCommandTypeJSON> value;
  };
  };
