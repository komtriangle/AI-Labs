/* file "UberRequestsContextJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestsContextJSON : JSONBase
  {
    public enum TypeNextStateKnownValues
      {
        NextState_select_pick_up_location,
        NextState_select_drop_off_location,
        NextState_request_confirmation,
        NextState_login,
        NextState_surge_confirmation,
        NextState__none
      };
    public struct TypeNextState
      {
        public bool in_known_list;
        public string string_value;
        public TypeNextStateKnownValues list_value;
      };

    public static TypeNextStateKnownValues  stringToNextState(string chars)
      {
        switch (chars[0])
          {
            case 'l':
                if ((String.Compare(chars, 1, "ogin", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNextStateKnownValues.NextState_login;
                break;
            case 'r':
                if ((String.Compare(chars, 1, "equest_confirmation", 0, 19, false) == 0) && (chars.Length == 20))
                    return TypeNextStateKnownValues.NextState_request_confirmation;
                break;
            case 's':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "lect_", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case 'd':
                                    if ((String.Compare(chars, 8, "rop_off_location", 0, 16, false) == 0) && (chars.Length == 24))
                                        return TypeNextStateKnownValues.NextState_select_drop_off_location;
                                    break;
                                case 'p':
                                    if ((String.Compare(chars, 8, "ick_up_location", 0, 15, false) == 0) && (chars.Length == 23))
                                        return TypeNextStateKnownValues.NextState_select_pick_up_location;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rge_confirmation", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeNextStateKnownValues.NextState_surge_confirmation;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeNextStateKnownValues.NextState__none;
      }

    public static string  stringFromNextState(TypeNextStateKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeNextStateKnownValues.NextState_select_pick_up_location:
                return "select_pick_up_location";
            case TypeNextStateKnownValues.NextState_select_drop_off_location:
                return "select_drop_off_location";
            case TypeNextStateKnownValues.NextState_request_confirmation:
                return "request_confirmation";
            case TypeNextStateKnownValues.NextState_login:
                return "login";
            case TypeNextStateKnownValues.NextState_surge_confirmation:
                return "surge_confirmation";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNextState;
    private TypeNextState storeNextState;
    private bool flagHasSurgeMultiplier;
    private double storeSurgeMultiplier;
    private string textStoreSurgeMultiplier;
    private bool flagHasUberRequestsSpec;
    private UberRequestsSpecJSON  storeUberRequestsSpec;
    private bool flagHasUberProducts;
    private UberCompositeProductsJSON  storeUberProducts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNextState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NextState of UberRequestsContextJSON is not a string.");
        TypeNextState the_open_enum = new TypeNextState();
        switch (json_string.getData()[0])
          {
            case 'l':
                if ((String.Compare(json_string.getData(), 1, "ogin", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextStateKnownValues.NextState_login;
                        goto open_enum_is_done;
                      }
                break;
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "equest_confirmation", 0, 19, false) == 0) && (json_string.getData().Length == 20))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeNextStateKnownValues.NextState_request_confirmation;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "lect_", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 8, "rop_off_location", 0, 16, false) == 0) && (json_string.getData().Length == 24))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNextStateKnownValues.NextState_select_drop_off_location;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if ((String.Compare(json_string.getData(), 8, "ick_up_location", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNextStateKnownValues.NextState_select_pick_up_location;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rge_confirmation", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNextStateKnownValues.NextState_surge_confirmation;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setNextState(the_open_enum);
      }


    private void  fromJSONSurgeMultiplier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field SurgeMultiplier of UberRequestsContextJSON is not a number.");
              }
          }
        setSurgeMultiplierText(the_rational_text);
      }


    private void  fromJSONUberRequestsSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberRequestsSpecJSON convert_classy = UberRequestsSpecJSON.from_json(json_value, ignore_extras, true);
        setUberRequestsSpec(convert_classy);
      }


    private void  fromJSONUberProducts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberCompositeProductsJSON convert_classy = UberCompositeProductsJSON.from_json(json_value, ignore_extras, true);
        setUberProducts(convert_classy);
      }


    public UberRequestsContextJSON()
      {
        flagHasNextState = false;
        flagHasSurgeMultiplier = false;
        flagHasUberRequestsSpec = false;
        flagHasUberProducts = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNextState()
      {
        return flagHasNextState;
      }

    public TypeNextState  getNextState()
      {
        Debug.Assert(flagHasNextState);
        return storeNextState;
      }

    public string  getNextStateAsString()
      {
        TypeNextState result = getNextState();
        if (result.in_known_list)
            return stringFromNextState(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSurgeMultiplier()
      {
        return flagHasSurgeMultiplier;
      }

    public double  getSurgeMultiplier()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier != "")
          {
            return Double.Parse(textStoreSurgeMultiplier);
          }
        return storeSurgeMultiplier;
      }

    public string  getSurgeMultiplierAsText()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier == "")
          {
            return Convert.ToString(storeSurgeMultiplier);
          }
        else
          {
            return (textStoreSurgeMultiplier);
          }
      }

    public bool  hasUberRequestsSpec()
      {
        return flagHasUberRequestsSpec;
      }

    public UberRequestsSpecJSON   getUberRequestsSpec()
      {
        Debug.Assert(flagHasUberRequestsSpec);
        return storeUberRequestsSpec;
      }

    public bool  hasUberProducts()
      {
        return flagHasUberProducts;
      }

    public UberCompositeProductsJSON   getUberProducts()
      {
        Debug.Assert(flagHasUberProducts);
        return storeUberProducts;
      }


    public virtual int extraUberRequestsContextComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestsContextComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestsContextComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestsContextLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNextState(TypeNextState new_value)
      {
        flagHasNextState = true;
        storeNextState = new_value;
      }
    public void setNextState(string chars)
      {
        TypeNextStateKnownValues known = stringToNextState(chars);
        TypeNextState new_value = new TypeNextState();
        if (known == TypeNextStateKnownValues.NextState__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setNextState(new_value);
      }
    public void setNextState(TypeNextStateKnownValues new_value)
      {
        TypeNextState new_full_value = new TypeNextState();
        Debug.Assert(new_value != TypeNextStateKnownValues.NextState__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setNextState(new_full_value);
      }
    public void unsetNextState()
      {
        flagHasNextState = false;
      }
    public void setSurgeMultiplier(double new_value)
      {
        flagHasSurgeMultiplier = true;
        storeSurgeMultiplier = new_value;
        textStoreSurgeMultiplier = "";
      }
    public void setSurgeMultiplierText(string new_value)
      {
        flagHasSurgeMultiplier = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SurgeMultiplier of UberRequestsContextJSON is not a valid number.");
        textStoreSurgeMultiplier = new_value;
      }
    public void unsetSurgeMultiplier()
      {
        flagHasSurgeMultiplier = false;
      }
    public void setUberRequestsSpec(UberRequestsSpecJSON  new_value)
      {
        if (flagHasUberRequestsSpec)
          {
          }
        flagHasUberRequestsSpec = true;
        storeUberRequestsSpec = new_value;
      }
    public void unsetUberRequestsSpec()
      {
        if (flagHasUberRequestsSpec)
          {
          }
        flagHasUberRequestsSpec = false;
      }
    public void setUberProducts(UberCompositeProductsJSON  new_value)
      {
        if (flagHasUberProducts)
          {
          }
        flagHasUberProducts = true;
        storeUberProducts = new_value;
      }
    public void unsetUberProducts()
      {
        if (flagHasUberProducts)
          {
          }
        flagHasUberProducts = false;
      }

    public virtual void extraUberRequestsContextAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestsContextSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestsContextLookup(key);
        if (old_field == null)
          {
            extraUberRequestsContextAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNextState);
        if (flagHasNextState)
          {
            handler.start_pair("NextState");
            if (storeNextState.in_known_list)
              {
                switch (storeNextState.list_value)
                  {
                    case TypeNextStateKnownValues.NextState_select_pick_up_location:
                        handler.string_value("select_pick_up_location");
                        break;
                    case TypeNextStateKnownValues.NextState_select_drop_off_location:
                        handler.string_value("select_drop_off_location");
                        break;
                    case TypeNextStateKnownValues.NextState_request_confirmation:
                        handler.string_value("request_confirmation");
                        break;
                    case TypeNextStateKnownValues.NextState_login:
                        handler.string_value("login");
                        break;
                    case TypeNextStateKnownValues.NextState_surge_confirmation:
                        handler.string_value("surge_confirmation");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeNextState.string_value);
              }
          }
        if (flagHasSurgeMultiplier)
          {
            handler.start_pair("SurgeMultiplier");
            if (textStoreSurgeMultiplier != "")
                handler.number_value(textStoreSurgeMultiplier);
            else if (((double)(long)storeSurgeMultiplier) == storeSurgeMultiplier)
                handler.number_value((long)storeSurgeMultiplier);
            else
                handler.number_value(storeSurgeMultiplier);
          }
        Debug.Assert(partial_allowed || flagHasUberRequestsSpec);
        if (flagHasUberRequestsSpec)
          {
            handler.start_pair("UberRequestsSpec");
            if (partial_allowed)
                storeUberRequestsSpec.write_partial_as_json(handler);
            else
                storeUberRequestsSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUberProducts);
        if (flagHasUberProducts)
          {
            handler.start_pair("UberProducts");
            if (partial_allowed)
                storeUberProducts.write_partial_as_json(handler);
            else
                storeUberProducts.write_as_json(handler);
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
        if (!(hasNextState()))
          {
            return "When parsing the object for %what%, the \"NextState\" field was missing.";
          }
        if (!(hasUberRequestsSpec()))
          {
            return "When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.";
          }
        if (!(hasUberProducts()))
          {
            return "When parsing the object for %what%, the \"UberProducts\" field was missing.";
          }
        return null;
      }

    public static UberRequestsContextJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsContextJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsContext", ignore_extras);
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
    public static UberRequestsContextJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestsContextJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsContextJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsContext", ignore_extras);
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
    public static UberRequestsContextJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestsContextJSON from_text(string text, bool ignore_extras)
      {
        UberRequestsContextJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsContext", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestsContextJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestsContextJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestsContextJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsContext", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorNextState : JSONStringGenerator
          {
            protected FieldGeneratorNextState(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNextState()
              {
              }
            protected override void handle_result(string result)
              {
                TypeNextStateKnownValues known = stringToNextState(result);
                TypeNextState new_value = new TypeNextState();
                if (known == TypeNextStateKnownValues.NextState__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeNextState result);
          };
    private class FieldHoldingGeneratorNextState : FieldGeneratorNextState
  {
    protected override void handle_result(TypeNextState result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNextState(String what)
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
    public TypeNextState value;
  };
    private class FieldHoldingArrayGeneratorNextState : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNextState
      {
        private FieldHoldingArrayGeneratorNextState top;

        protected override void handle_result(TypeNextState result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNextState init_top)
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
    protected virtual void handle_result(List<TypeNextState> result)
      {
      }

    public FieldHoldingArrayGeneratorNextState(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNextState>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNextState()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNextState>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNextState> value;
  };
        private FieldHoldingGeneratorNextState fieldGeneratorNextState;
        private JSONHoldingNumberTextGenerator fieldGeneratorSurgeMultiplier;
        private UberRequestsSpecJSON.HoldingGenerator fieldGeneratorUberRequestsSpec;
        private UberCompositeProductsJSON.HoldingGenerator fieldGeneratorUberProducts;
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
            UberRequestsContextJSON result = new UberRequestsContextJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestsContextAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestsContextJSON result)
          {
            if (fieldGeneratorNextState.have_value)
              {
                result.setNextState(fieldGeneratorNextState.value);
                fieldGeneratorNextState.have_value = false;
              }
            else if ((!(result.hasNextState())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NextState\" field was missing.");
              }
            if (fieldGeneratorSurgeMultiplier.have_value)
              {
                result.setSurgeMultiplierText(fieldGeneratorSurgeMultiplier.value);
                fieldGeneratorSurgeMultiplier.have_value = false;
              }
            if (fieldGeneratorUberRequestsSpec.have_value)
              {
                result.setUberRequestsSpec(fieldGeneratorUberRequestsSpec.value);
                fieldGeneratorUberRequestsSpec.have_value = false;
              }
            else if ((!(result.hasUberRequestsSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UberRequestsSpec\" field was missing.");
              }
            if (fieldGeneratorUberProducts.have_value)
              {
                result.setUberProducts(fieldGeneratorUberProducts.value);
                fieldGeneratorUberProducts.have_value = false;
              }
            else if ((!(result.hasUberProducts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UberProducts\" field was missing.");
              }
          }
        protected abstract void handle_result(UberRequestsContextJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "extState", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNextState;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "urgeMultiplier", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSurgeMultiplier;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ber", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 5, "roducts", 0, 7, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorUberProducts;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 5, "equestsSpec", 0, 11, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorUberRequestsSpec;
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
            fieldGeneratorNextState = new FieldHoldingGeneratorNextState("field \"NextState\" of the UberRequestsContext class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberRequestsContext class");
            fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the UberRequestsContext class", ignore_extras);
            fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the UberRequestsContext class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestsContext class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNextState = new FieldHoldingGeneratorNextState("field \"NextState\" of the UberRequestsContext class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberRequestsContext class");
            fieldGeneratorUberRequestsSpec = new UberRequestsSpecJSON.HoldingGenerator("field \"UberRequestsSpec\" of the UberRequestsContext class", false);
            fieldGeneratorUberProducts = new UberCompositeProductsJSON.HoldingGenerator("field \"UberProducts\" of the UberRequestsContext class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestsContext class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNextState.reset();
            fieldGeneratorSurgeMultiplier.reset();
            fieldGeneratorUberRequestsSpec.reset();
            fieldGeneratorUberProducts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorUberRequestsSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUberProducts.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorUberRequestsSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUberProducts.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestsContextJSON  result)
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
        public UberRequestsContextJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestsContextJSON  result)
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
    protected virtual void handle_result(List<UberRequestsContextJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestsContextJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestsContextJSON>();
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
    public List<UberRequestsContextJSON> value;
  };
  };
