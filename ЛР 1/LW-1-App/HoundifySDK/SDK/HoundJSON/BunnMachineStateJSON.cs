/* file "BunnMachineStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BunnMachineStateJSON : JSONBase
  {
    public enum TypeState
      {
        State_PoweredOff,
        State_PoweredOnInStandby,
        State_WarmingUp,
        State_SelfCleaningBeforeBrew,
        State_ReadyToBrew,
        State_DispensingCoffee,
        State_DispensingHotWater,
        State_NeedsBeans,
        State_NeedsWater,
        State_NeedsDregsCleaned,
        State_Descaling,
        State_Warning,
        State_Unknown
      };

    public static TypeState  stringToState(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "scaling", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeState.State_Descaling;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "spensing", 0, 8, false) == 0)
                          {
                            switch (chars[10])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 11, "offee", 0, 5, false) == 0) && (chars.Length == 16))
                                        return TypeState.State_DispensingCoffee;
                                    break;
                                case 'H':
                                    if ((String.Compare(chars, 11, "otWater", 0, 7, false) == 0) && (chars.Length == 18))
                                        return TypeState.State_DispensingHotWater;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(chars, 1, "eeds", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'B':
                            if ((String.Compare(chars, 6, "eans", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeState.State_NeedsBeans;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 6, "regsCleaned", 0, 11, false) == 0) && (chars.Length == 17))
                                return TypeState.State_NeedsDregsCleaned;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 6, "ater", 0, 4, false) == 0) && (chars.Length == 10))
                                return TypeState.State_NeedsWater;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(chars, 1, "oweredO", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'f':
                            if ((String.Compare(chars, 9, "f", 0, 1, false) == 0) && (chars.Length == 10))
                                return TypeState.State_PoweredOff;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 9, "InStandby", 0, 9, false) == 0) && (chars.Length == 18))
                                return TypeState.State_PoweredOnInStandby;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eadyToBrew", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeState.State_ReadyToBrew;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "elfCleaningBeforeBrew", 0, 21, false) == 0) && (chars.Length == 22))
                    return TypeState.State_SelfCleaningBeforeBrew;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeState.State_Unknown;
                break;
            case 'W':
                if (String.Compare(chars, 1, "ar", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'm':
                            if ((String.Compare(chars, 4, "ingUp", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeState.State_WarmingUp;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 4, "ing", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeState.State_Warning;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `State' is not one of the legal values.");
      }

    public static string  stringFromState(TypeState the_enum)
      {
        switch (the_enum)
          {
            case TypeState.State_PoweredOff:
                return "PoweredOff";
            case TypeState.State_PoweredOnInStandby:
                return "PoweredOnInStandby";
            case TypeState.State_WarmingUp:
                return "WarmingUp";
            case TypeState.State_SelfCleaningBeforeBrew:
                return "SelfCleaningBeforeBrew";
            case TypeState.State_ReadyToBrew:
                return "ReadyToBrew";
            case TypeState.State_DispensingCoffee:
                return "DispensingCoffee";
            case TypeState.State_DispensingHotWater:
                return "DispensingHotWater";
            case TypeState.State_NeedsBeans:
                return "NeedsBeans";
            case TypeState.State_NeedsWater:
                return "NeedsWater";
            case TypeState.State_NeedsDregsCleaned:
                return "NeedsDregsCleaned";
            case TypeState.State_Descaling:
                return "Descaling";
            case TypeState.State_Warning:
                return "Warning";
            case TypeState.State_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasAvailableDrinks;
    private List< BunnAvailableDrinkInfoJSON  > storeAvailableDrinks;
    private bool flagHasState;
    private TypeState storeState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONAvailableDrinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AvailableDrinks of BunnMachineStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BunnAvailableDrinkInfoJSON  > vector_AvailableDrinks1 = new List< BunnAvailableDrinkInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BunnAvailableDrinkInfoJSON convert_classy = BunnAvailableDrinkInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AvailableDrinks1.Add(convert_classy);
          }
        initAvailableDrinks();
        for (int num1 = 0; num1 < vector_AvailableDrinks1.Count; ++num1)
            appendAvailableDrinks(vector_AvailableDrinks1[num1]);
        for (int num1 = 0; num1 < vector_AvailableDrinks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field State of BunnMachineStateJSON is not a string.");
        TypeState the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "scaling", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_enum = TypeState.State_Descaling;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "spensing", 0, 8, false) == 0)
                          {
                            switch (json_string.getData()[10])
                              {
                                case 'C':
                                    if ((String.Compare(json_string.getData(), 11, "offee", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_enum = TypeState.State_DispensingCoffee;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'H':
                                    if ((String.Compare(json_string.getData(), 11, "otWater", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_enum = TypeState.State_DispensingHotWater;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "eeds", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'B':
                            if ((String.Compare(json_string.getData(), 6, "eans", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeState.State_NeedsBeans;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 6, "regsCleaned", 0, 11, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeState.State_NeedsDregsCleaned;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 6, "ater", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeState.State_NeedsWater;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(json_string.getData(), 1, "oweredO", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'f':
                            if ((String.Compare(json_string.getData(), 9, "f", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeState.State_PoweredOff;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 9, "InStandby", 0, 9, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeState.State_PoweredOnInStandby;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eadyToBrew", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeState.State_ReadyToBrew;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "elfCleaningBeforeBrew", 0, 21, false) == 0) && (json_string.getData().Length == 22))
                      {
                        the_enum = TypeState.State_SelfCleaningBeforeBrew;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeState.State_Unknown;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "ar", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'm':
                            if ((String.Compare(json_string.getData(), 4, "ingUp", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_enum = TypeState.State_WarmingUp;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 4, "ing", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_enum = TypeState.State_Warning;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field State of BunnMachineStateJSON is not one of the legal strings.");
      enum_is_done:;
        setState(the_enum);
      }


    public BunnMachineStateJSON()
      {
        flagHasAvailableDrinks = false;
        flagHasState = false;
        storeAvailableDrinks = new List< BunnAvailableDrinkInfoJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasAvailableDrinks()
      {
        return flagHasAvailableDrinks;
      }

    public int  countOfAvailableDrinks()
      {
        Debug.Assert(flagHasAvailableDrinks);
        return storeAvailableDrinks.Count;
      }

    public BunnAvailableDrinkInfoJSON   elementOfAvailableDrinks(int element_num)
      {
        Debug.Assert(flagHasAvailableDrinks);
        return storeAvailableDrinks[element_num];
      }

    public List< BunnAvailableDrinkInfoJSON  >  getAvailableDrinks()
      {
        Debug.Assert(flagHasAvailableDrinks);
        return storeAvailableDrinks;
      }

    public bool  hasState()
      {
        return flagHasState;
      }

    public TypeState  getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public string  getStateAsString()
      {
        return stringFromState(getState());
      }


    public virtual int extraBunnMachineStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBunnMachineStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBunnMachineStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBunnMachineStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initAvailableDrinks()
      {
        if (flagHasAvailableDrinks)
          {
            for (int num1 = 0; num1 < storeAvailableDrinks.Count; ++num1)
              {
              }
          }
        flagHasAvailableDrinks = true;
        storeAvailableDrinks.Clear();
      }
    public void appendAvailableDrinks(BunnAvailableDrinkInfoJSON  to_append)
      {
        if (!flagHasAvailableDrinks)
          {
            flagHasAvailableDrinks = true;
            storeAvailableDrinks.Clear();
          }
        Debug.Assert(flagHasAvailableDrinks);
        storeAvailableDrinks.Add(to_append);
      }
    public void unsetAvailableDrinks()
      {
        if (flagHasAvailableDrinks)
          {
            for (int num2 = 0; num2 < storeAvailableDrinks.Count; ++num2)
              {
              }
          }
        flagHasAvailableDrinks = false;
        storeAvailableDrinks.Clear();
      }
    public void setState(TypeState new_value)
      {
        flagHasState = true;
        storeState = new_value;
      }
    public void setState(string chars)
      {
        setState(stringToState(chars));
      }
    public void unsetState()
      {
        flagHasState = false;
      }

    public virtual void extraBunnMachineStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBunnMachineStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBunnMachineStateLookup(key);
        if (old_field == null)
          {
            extraBunnMachineStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasAvailableDrinks);
        if (flagHasAvailableDrinks)
          {
            handler.start_pair("AvailableDrinks");
            handler.start_array();
            for (int num1 = 0; num1 < storeAvailableDrinks.Count; ++num1)
              {
                if (partial_allowed)
                    storeAvailableDrinks[num1].write_partial_as_json(handler);
                else
                    storeAvailableDrinks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasState)
          {
            handler.start_pair("State");
            switch (storeState)
              {
                case TypeState.State_PoweredOff:
                    handler.string_value("PoweredOff");
                    break;
                case TypeState.State_PoweredOnInStandby:
                    handler.string_value("PoweredOnInStandby");
                    break;
                case TypeState.State_WarmingUp:
                    handler.string_value("WarmingUp");
                    break;
                case TypeState.State_SelfCleaningBeforeBrew:
                    handler.string_value("SelfCleaningBeforeBrew");
                    break;
                case TypeState.State_ReadyToBrew:
                    handler.string_value("ReadyToBrew");
                    break;
                case TypeState.State_DispensingCoffee:
                    handler.string_value("DispensingCoffee");
                    break;
                case TypeState.State_DispensingHotWater:
                    handler.string_value("DispensingHotWater");
                    break;
                case TypeState.State_NeedsBeans:
                    handler.string_value("NeedsBeans");
                    break;
                case TypeState.State_NeedsWater:
                    handler.string_value("NeedsWater");
                    break;
                case TypeState.State_NeedsDregsCleaned:
                    handler.string_value("NeedsDregsCleaned");
                    break;
                case TypeState.State_Descaling:
                    handler.string_value("Descaling");
                    break;
                case TypeState.State_Warning:
                    handler.string_value("Warning");
                    break;
                case TypeState.State_Unknown:
                    handler.string_value("Unknown");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasAvailableDrinks()))
          {
            return "When parsing the object for %what%, the \"AvailableDrinks\" field was missing.";
          }
        return null;
      }

    public static BunnMachineStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnMachineState", ignore_extras);
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
    public static BunnMachineStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnMachineStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BunnMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnMachineState", ignore_extras);
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
    public static BunnMachineStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BunnMachineStateJSON from_text(string text, bool ignore_extras)
      {
        BunnMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnMachineState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BunnMachineStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BunnMachineStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BunnMachineStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BunnMachineState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private BunnAvailableDrinkInfoJSON.HoldingArrayGenerator fieldGeneratorAvailableDrinks;
    private abstract class FieldGeneratorState : JSONStringGenerator
          {
            protected FieldGeneratorState(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorState()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToState(result));
              }
            protected abstract void handle_result(TypeState result);
          };
    private class FieldHoldingGeneratorState : FieldGeneratorState
  {
    protected override void handle_result(TypeState result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorState(String what)
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
    public TypeState value;
  };
    private class FieldHoldingArrayGeneratorState : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorState
      {
        private FieldHoldingArrayGeneratorState top;

        protected override void handle_result(TypeState result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorState init_top)
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
    protected virtual void handle_result(List<TypeState> result)
      {
      }

    public FieldHoldingArrayGeneratorState(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeState>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorState()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeState>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeState> value;
  };
        private FieldHoldingGeneratorState fieldGeneratorState;
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
            BunnMachineStateJSON result = new BunnMachineStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBunnMachineStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BunnMachineStateJSON result)
          {
            if (fieldGeneratorAvailableDrinks.have_value)
              {
                result.initAvailableDrinks();
                int count = fieldGeneratorAvailableDrinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAvailableDrinks(fieldGeneratorAvailableDrinks.value[num]);
                  }
                fieldGeneratorAvailableDrinks.value.Clear();
                fieldGeneratorAvailableDrinks.have_value = false;
              }
            else if ((!(result.hasAvailableDrinks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AvailableDrinks\" field was missing.");
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
          }
        protected abstract void handle_result(BunnMachineStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "vailableDrinks", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAvailableDrinks;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tate", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorState;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAvailableDrinks = new BunnAvailableDrinkInfoJSON.HoldingArrayGenerator("field \"AvailableDrinks\" of the BunnMachineState class", ignore_extras);
            fieldGeneratorState = new FieldHoldingGeneratorState("field \"State\" of the BunnMachineState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BunnMachineState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAvailableDrinks = new BunnAvailableDrinkInfoJSON.HoldingArrayGenerator("field \"AvailableDrinks\" of the BunnMachineState class", false);
            fieldGeneratorState = new FieldHoldingGeneratorState("field \"State\" of the BunnMachineState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BunnMachineState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAvailableDrinks.reset();
            fieldGeneratorState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAvailableDrinks.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAvailableDrinks.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BunnMachineStateJSON  result)
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
        public BunnMachineStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BunnMachineStateJSON  result)
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
    protected virtual void handle_result(List<BunnMachineStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BunnMachineStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BunnMachineStateJSON>();
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
    public List<BunnMachineStateJSON> value;
  };
  };
