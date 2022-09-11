/* file "UberCompositeRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberCompositeRequestJSON : JSONBase
  {
    public enum TypeStatusKnownValues
      {
        Status_processing,
        Status_no_drivers_available,
        Status_accepted,
        Status_arriving,
        Status_in_progress,
        Status_driver_canceled,
        Status_rider_canceled,
        Status_completed,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'a':
                switch (chars[1])
                  {
                    case 'c':
                        if ((String.Compare(chars, 2, "cepted", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeStatusKnownValues.Status_accepted;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "riving", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeStatusKnownValues.Status_arriving;
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                if ((String.Compare(chars, 1, "ompleted", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeStatusKnownValues.Status_completed;
                break;
            case 'd':
                if ((String.Compare(chars, 1, "river_canceled", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeStatusKnownValues.Status_driver_canceled;
                break;
            case 'i':
                if ((String.Compare(chars, 1, "n_progress", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeStatusKnownValues.Status_in_progress;
                break;
            case 'n':
                if ((String.Compare(chars, 1, "o_drivers_available", 0, 19, false) == 0) && (chars.Length == 20))
                    return TypeStatusKnownValues.Status_no_drivers_available;
                break;
            case 'p':
                if ((String.Compare(chars, 1, "rocessing", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeStatusKnownValues.Status_processing;
                break;
            case 'r':
                if ((String.Compare(chars, 1, "ider_canceled", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeStatusKnownValues.Status_rider_canceled;
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_processing:
                return "processing";
            case TypeStatusKnownValues.Status_no_drivers_available:
                return "no_drivers_available";
            case TypeStatusKnownValues.Status_accepted:
                return "accepted";
            case TypeStatusKnownValues.Status_arriving:
                return "arriving";
            case TypeStatusKnownValues.Status_in_progress:
                return "in_progress";
            case TypeStatusKnownValues.Status_driver_canceled:
                return "driver_canceled";
            case TypeStatusKnownValues.Status_rider_canceled:
                return "rider_canceled";
            case TypeStatusKnownValues.Status_completed:
                return "completed";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRequestId;
    private string storeRequestId;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private bool flagHasArrivalEstimateInMinutes;
    private double storeArrivalEstimateInMinutes;
    private string textStoreArrivalEstimateInMinutes;
    private bool flagHasVehicle;
    private UberVehicleJSON  storeVehicle;
    private bool flagHasSurgeMultiplier;
    private double storeSurgeMultiplier;
    private string textStoreSurgeMultiplier;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRequestId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestId of UberCompositeRequestJSON is not a string.");
        setRequestId(json_string.getData());
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of UberCompositeRequestJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'a':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if ((String.Compare(json_string.getData(), 2, "cepted", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeStatusKnownValues.Status_accepted;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "riving", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeStatusKnownValues.Status_arriving;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                if ((String.Compare(json_string.getData(), 1, "ompleted", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_completed;
                        goto open_enum_is_done;
                      }
                break;
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "river_canceled", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_driver_canceled;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                if ((String.Compare(json_string.getData(), 1, "n_progress", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_in_progress;
                        goto open_enum_is_done;
                      }
                break;
            case 'n':
                if ((String.Compare(json_string.getData(), 1, "o_drivers_available", 0, 19, false) == 0) && (json_string.getData().Length == 20))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_no_drivers_available;
                        goto open_enum_is_done;
                      }
                break;
            case 'p':
                if ((String.Compare(json_string.getData(), 1, "rocessing", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_processing;
                        goto open_enum_is_done;
                      }
                break;
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "ider_canceled", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_rider_canceled;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    private void  fromJSONArrivalEstimateInMinutes(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ArrivalEstimateInMinutes of UberCompositeRequestJSON is not a number.");
              }
          }
        setArrivalEstimateInMinutesText(the_rational_text);
      }


    private void  fromJSONVehicle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberVehicleJSON convert_classy = UberVehicleJSON.from_json(json_value, ignore_extras, true);
        setVehicle(convert_classy);
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
                throw new Exception("The value for field SurgeMultiplier of UberCompositeRequestJSON is not a number.");
              }
          }
        setSurgeMultiplierText(the_rational_text);
      }


    public UberCompositeRequestJSON()
      {
        flagHasRequestId = false;
        flagHasStatus = false;
        flagHasArrivalEstimateInMinutes = false;
        flagHasVehicle = false;
        flagHasSurgeMultiplier = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRequestId()
      {
        return flagHasRequestId;
      }

    public string  getRequestId()
      {
        Debug.Assert(flagHasRequestId);
        return storeRequestId;
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasArrivalEstimateInMinutes()
      {
        return flagHasArrivalEstimateInMinutes;
      }

    public double  getArrivalEstimateInMinutes()
      {
        Debug.Assert(flagHasArrivalEstimateInMinutes);
        if (textStoreArrivalEstimateInMinutes != "")
          {
            return Double.Parse(textStoreArrivalEstimateInMinutes);
          }
        return storeArrivalEstimateInMinutes;
      }

    public string  getArrivalEstimateInMinutesAsText()
      {
        Debug.Assert(flagHasArrivalEstimateInMinutes);
        if (textStoreArrivalEstimateInMinutes == "")
          {
            return Convert.ToString(storeArrivalEstimateInMinutes);
          }
        else
          {
            return (textStoreArrivalEstimateInMinutes);
          }
      }

    public bool  hasVehicle()
      {
        return flagHasVehicle;
      }

    public UberVehicleJSON   getVehicle()
      {
        Debug.Assert(flagHasVehicle);
        return storeVehicle;
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


    public virtual int extraUberCompositeRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberCompositeRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberCompositeRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberCompositeRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRequestId(string new_value)
      {
        flagHasRequestId = true;
        storeRequestId = new_value;
      }
    public void unsetRequestId()
      {
        flagHasRequestId = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }
    public void setArrivalEstimateInMinutes(double new_value)
      {
        flagHasArrivalEstimateInMinutes = true;
        storeArrivalEstimateInMinutes = new_value;
        textStoreArrivalEstimateInMinutes = "";
      }
    public void setArrivalEstimateInMinutesText(string new_value)
      {
        flagHasArrivalEstimateInMinutes = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ArrivalEstimateInMinutes of UberCompositeRequestJSON is not a valid number.");
        textStoreArrivalEstimateInMinutes = new_value;
      }
    public void unsetArrivalEstimateInMinutes()
      {
        flagHasArrivalEstimateInMinutes = false;
      }
    public void setVehicle(UberVehicleJSON  new_value)
      {
        if (flagHasVehicle)
          {
          }
        flagHasVehicle = true;
        storeVehicle = new_value;
      }
    public void unsetVehicle()
      {
        if (flagHasVehicle)
          {
          }
        flagHasVehicle = false;
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
            throw new Exception("The text value for field SurgeMultiplier of UberCompositeRequestJSON is not a valid number.");
        textStoreSurgeMultiplier = new_value;
      }
    public void unsetSurgeMultiplier()
      {
        flagHasSurgeMultiplier = false;
      }

    public virtual void extraUberCompositeRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberCompositeRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberCompositeRequestLookup(key);
        if (old_field == null)
          {
            extraUberCompositeRequestAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRequestId);
        if (flagHasRequestId)
          {
            handler.start_pair("RequestId");
            handler.string_value(storeRequestId);
          }
        Debug.Assert(partial_allowed || flagHasStatus);
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_processing:
                        handler.string_value("processing");
                        break;
                    case TypeStatusKnownValues.Status_no_drivers_available:
                        handler.string_value("no_drivers_available");
                        break;
                    case TypeStatusKnownValues.Status_accepted:
                        handler.string_value("accepted");
                        break;
                    case TypeStatusKnownValues.Status_arriving:
                        handler.string_value("arriving");
                        break;
                    case TypeStatusKnownValues.Status_in_progress:
                        handler.string_value("in_progress");
                        break;
                    case TypeStatusKnownValues.Status_driver_canceled:
                        handler.string_value("driver_canceled");
                        break;
                    case TypeStatusKnownValues.Status_rider_canceled:
                        handler.string_value("rider_canceled");
                        break;
                    case TypeStatusKnownValues.Status_completed:
                        handler.string_value("completed");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
              }
          }
        if (flagHasArrivalEstimateInMinutes)
          {
            handler.start_pair("ArrivalEstimateInMinutes");
            if (textStoreArrivalEstimateInMinutes != "")
                handler.number_value(textStoreArrivalEstimateInMinutes);
            else if (((double)(long)storeArrivalEstimateInMinutes) == storeArrivalEstimateInMinutes)
                handler.number_value((long)storeArrivalEstimateInMinutes);
            else
                handler.number_value(storeArrivalEstimateInMinutes);
          }
        if (flagHasVehicle)
          {
            handler.start_pair("Vehicle");
            if (partial_allowed)
                storeVehicle.write_partial_as_json(handler);
            else
                storeVehicle.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSurgeMultiplier);
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
        if (!(hasRequestId()))
          {
            return "When parsing the object for %what%, the \"RequestId\" field was missing.";
          }
        if (!(hasStatus()))
          {
            return "When parsing the object for %what%, the \"Status\" field was missing.";
          }
        if (!(hasSurgeMultiplier()))
          {
            return "When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.";
          }
        return null;
      }

    public static UberCompositeRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCompositeRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeRequest", ignore_extras);
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
    public static UberCompositeRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberCompositeRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCompositeRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeRequest", ignore_extras);
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
    public static UberCompositeRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberCompositeRequestJSON from_text(string text, bool ignore_extras)
      {
        UberCompositeRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberCompositeRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberCompositeRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberCompositeRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorRequestId;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
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
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
        private JSONHoldingNumberTextGenerator fieldGeneratorArrivalEstimateInMinutes;
        private UberVehicleJSON.HoldingGenerator fieldGeneratorVehicle;
        private JSONHoldingNumberTextGenerator fieldGeneratorSurgeMultiplier;
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
            UberCompositeRequestJSON result = new UberCompositeRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberCompositeRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberCompositeRequestJSON result)
          {
            if (fieldGeneratorRequestId.have_value)
              {
                result.setRequestId(fieldGeneratorRequestId.value);
                fieldGeneratorRequestId.have_value = false;
              }
            else if ((!(result.hasRequestId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestId\" field was missing.");
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            else if ((!(result.hasStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Status\" field was missing.");
              }
            if (fieldGeneratorArrivalEstimateInMinutes.have_value)
              {
                result.setArrivalEstimateInMinutesText(fieldGeneratorArrivalEstimateInMinutes.value);
                fieldGeneratorArrivalEstimateInMinutes.have_value = false;
              }
            if (fieldGeneratorVehicle.have_value)
              {
                result.setVehicle(fieldGeneratorVehicle.value);
                fieldGeneratorVehicle.have_value = false;
              }
            if (fieldGeneratorSurgeMultiplier.have_value)
              {
                result.setSurgeMultiplierText(fieldGeneratorSurgeMultiplier.value);
                fieldGeneratorSurgeMultiplier.have_value = false;
              }
            else if ((!(result.hasSurgeMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.");
              }
          }
        protected abstract void handle_result(UberCompositeRequestJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rrivalEstimateInMinutes", 0, 23, false) == 0) && (field_name.Length == 24))
                        return fieldGeneratorArrivalEstimateInMinutes;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestId", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorRequestId;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 't':
                            if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorStatus;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rgeMultiplier", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSurgeMultiplier;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ehicle", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorVehicle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRequestId = new JSONHoldingStringGenerator("field \"RequestId\" of the UberCompositeRequest class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the UberCompositeRequest class");
            fieldGeneratorArrivalEstimateInMinutes = new JSONHoldingNumberTextGenerator("field \"ArrivalEstimateInMinutes\" of the UberCompositeRequest class");
            fieldGeneratorVehicle = new UberVehicleJSON.HoldingGenerator("field \"Vehicle\" of the UberCompositeRequest class", ignore_extras);
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberCompositeRequest class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberCompositeRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRequestId = new JSONHoldingStringGenerator("field \"RequestId\" of the UberCompositeRequest class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the UberCompositeRequest class");
            fieldGeneratorArrivalEstimateInMinutes = new JSONHoldingNumberTextGenerator("field \"ArrivalEstimateInMinutes\" of the UberCompositeRequest class");
            fieldGeneratorVehicle = new UberVehicleJSON.HoldingGenerator("field \"Vehicle\" of the UberCompositeRequest class", false);
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberCompositeRequest class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberCompositeRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRequestId.reset();
            fieldGeneratorStatus.reset();
            fieldGeneratorArrivalEstimateInMinutes.reset();
            fieldGeneratorVehicle.reset();
            fieldGeneratorSurgeMultiplier.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorVehicle.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorVehicle.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberCompositeRequestJSON  result)
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
        public UberCompositeRequestJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberCompositeRequestJSON  result)
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
    protected virtual void handle_result(List<UberCompositeRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberCompositeRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberCompositeRequestJSON>();
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
    public List<UberCompositeRequestJSON> value;
  };
  };
