/* file "UberRequestDetailsResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestDetailsResponseJSON : JSONBase
  {
    public struct Typevehicle
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public UberRequestVehicleJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct Typedriver
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public UberRequestDriverJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct Typelocation
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public UberRequestLocationJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    public struct Typesurge_multiplier
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    private bool flagHasrequest_id;
    private string storerequest_id;
    private bool flagHasstatus;
    private string storestatus;
    private bool flagHasvehicle;
    private Typevehicle storevehicle;
    private bool flagHasdriver;
    private Typedriver storedriver;
    private bool flagHaslocation;
    private Typelocation storelocation;
    private bool flagHassurge_multiplier;
    private Typesurge_multiplier storesurge_multiplier;
    private bool flagHaspickup;
    private UberRequestEndpointJSON  storepickup;
    private bool flagHasdestination;
    private UberRequestEndpointJSON  storedestination;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONrequest_id(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field request_id of UberRequestDetailsResponseJSON is not a string.");
        setrequest_id(json_string.getData());
      }


    private void  fromJSONstatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field status of UberRequestDetailsResponseJSON is not a string.");
        setstatus(json_string.getData());
      }


    private void  fromJSONvehicle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typevehicle or_result = new Typevehicle();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                UberRequestVehicleJSON convert_classy = UberRequestVehicleJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field vehicle of UberRequestDetailsResponseJSON is not one of the allowed values.");
        setvehicle(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONdriver(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typedriver or_result = new Typedriver();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                UberRequestDriverJSON convert_classy = UberRequestDriverJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field driver of UberRequestDetailsResponseJSON is not one of the allowed values.");
        setdriver(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONlocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typelocation or_result = new Typelocation();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                UberRequestLocationJSON convert_classy = UberRequestLocationJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field location of UberRequestDetailsResponseJSON is not one of the allowed values.");
        setlocation(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONsurge_multiplier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typesurge_multiplier or_result = new Typesurge_multiplier();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice0 = the_double;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field surge_multiplier of UberRequestDetailsResponseJSON is not one of the allowed values.");
        setsurge_multiplier(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONpickup(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberRequestEndpointJSON convert_classy = UberRequestEndpointJSON.from_json(json_value, ignore_extras, true);
        setpickup(convert_classy);
      }


    private void  fromJSONdestination(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberRequestEndpointJSON convert_classy = UberRequestEndpointJSON.from_json(json_value, ignore_extras, true);
        setdestination(convert_classy);
      }


    public UberRequestDetailsResponseJSON()
      {
        flagHasrequest_id = false;
        flagHasstatus = false;
        flagHasvehicle = false;
        flagHasdriver = false;
        flagHaslocation = false;
        flagHassurge_multiplier = false;
        flagHaspickup = false;
        flagHasdestination = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasrequest_id()
      {
        return flagHasrequest_id;
      }

    public string  getrequest_id()
      {
        Debug.Assert(flagHasrequest_id);
        return storerequest_id;
      }

    public bool  hasstatus()
      {
        return flagHasstatus;
      }

    public string  getstatus()
      {
        Debug.Assert(flagHasstatus);
        return storestatus;
      }

    public bool  hasvehicle()
      {
        return flagHasvehicle;
      }

    public Typevehicle  getvehicle()
      {
        Debug.Assert(flagHasvehicle);
        return storevehicle;
      }

    public bool  hasdriver()
      {
        return flagHasdriver;
      }

    public Typedriver  getdriver()
      {
        Debug.Assert(flagHasdriver);
        return storedriver;
      }

    public bool  haslocation()
      {
        return flagHaslocation;
      }

    public Typelocation  getlocation()
      {
        Debug.Assert(flagHaslocation);
        return storelocation;
      }

    public bool  hassurge_multiplier()
      {
        return flagHassurge_multiplier;
      }

    public Typesurge_multiplier  getsurge_multiplier()
      {
        Debug.Assert(flagHassurge_multiplier);
        return storesurge_multiplier;
      }

    public bool  haspickup()
      {
        return flagHaspickup;
      }

    public UberRequestEndpointJSON   getpickup()
      {
        Debug.Assert(flagHaspickup);
        return storepickup;
      }

    public bool  hasdestination()
      {
        return flagHasdestination;
      }

    public UberRequestEndpointJSON   getdestination()
      {
        Debug.Assert(flagHasdestination);
        return storedestination;
      }


    public virtual int extraUberRequestDetailsResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestDetailsResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestDetailsResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestDetailsResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setrequest_id(string new_value)
      {
        flagHasrequest_id = true;
        storerequest_id = new_value;
      }
    public void unsetrequest_id()
      {
        flagHasrequest_id = false;
      }
    public void setstatus(string new_value)
      {
        flagHasstatus = true;
        storestatus = new_value;
      }
    public void unsetstatus()
      {
        flagHasstatus = false;
      }
    public void setvehicle(Typevehicle new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasvehicle)
          {
            switch (storevehicle.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasvehicle = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storevehicle = new_value;
      }
    public void unsetvehicle()
      {
        if (flagHasvehicle)
          {
            switch (storevehicle.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasvehicle = false;
      }
    public void setdriver(Typedriver new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasdriver)
          {
            switch (storedriver.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasdriver = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storedriver = new_value;
      }
    public void unsetdriver()
      {
        if (flagHasdriver)
          {
            switch (storedriver.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasdriver = false;
      }
    public void setlocation(Typelocation new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHaslocation)
          {
            switch (storelocation.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaslocation = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storelocation = new_value;
      }
    public void unsetlocation()
      {
        if (flagHaslocation)
          {
            switch (storelocation.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaslocation = false;
      }
    public void setsurge_multiplier(Typesurge_multiplier new_value)
      {
        flagHassurge_multiplier = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storesurge_multiplier = new_value;
      }
    public void unsetsurge_multiplier()
      {
        flagHassurge_multiplier = false;
      }
    public void setpickup(UberRequestEndpointJSON  new_value)
      {
        if (flagHaspickup)
          {
          }
        flagHaspickup = true;
        storepickup = new_value;
      }
    public void unsetpickup()
      {
        if (flagHaspickup)
          {
          }
        flagHaspickup = false;
      }
    public void setdestination(UberRequestEndpointJSON  new_value)
      {
        if (flagHasdestination)
          {
          }
        flagHasdestination = true;
        storedestination = new_value;
      }
    public void unsetdestination()
      {
        if (flagHasdestination)
          {
          }
        flagHasdestination = false;
      }

    public virtual void extraUberRequestDetailsResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestDetailsResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestDetailsResponseLookup(key);
        if (old_field == null)
          {
            extraUberRequestDetailsResponseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasrequest_id);
        if (flagHasrequest_id)
          {
            handler.start_pair("request_id");
            handler.string_value(storerequest_id);
          }
        Debug.Assert(partial_allowed || flagHasstatus);
        if (flagHasstatus)
          {
            handler.start_pair("status");
            handler.string_value(storestatus);
          }
        Debug.Assert(partial_allowed || flagHasvehicle);
        if (flagHasvehicle)
          {
            handler.start_pair("vehicle");
            switch (storevehicle.key)
              {
                case 0:
                    if (partial_allowed)
                        storevehicle.u.choice0.write_partial_as_json(handler);
                    else
                        storevehicle.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasdriver);
        if (flagHasdriver)
          {
            handler.start_pair("driver");
            switch (storedriver.key)
              {
                case 0:
                    if (partial_allowed)
                        storedriver.u.choice0.write_partial_as_json(handler);
                    else
                        storedriver.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHaslocation);
        if (flagHaslocation)
          {
            handler.start_pair("location");
            switch (storelocation.key)
              {
                case 0:
                    if (partial_allowed)
                        storelocation.u.choice0.write_partial_as_json(handler);
                    else
                        storelocation.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHassurge_multiplier);
        if (flagHassurge_multiplier)
          {
            handler.start_pair("surge_multiplier");
            switch (storesurge_multiplier.key)
              {
                case 0:
                    if (((double)(long)storesurge_multiplier.u.choice0) == storesurge_multiplier.u.choice0)
                        handler.number_value((long)storesurge_multiplier.u.choice0);
                    else
                        handler.number_value(storesurge_multiplier.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHaspickup)
          {
            handler.start_pair("pickup");
            if (partial_allowed)
                storepickup.write_partial_as_json(handler);
            else
                storepickup.write_as_json(handler);
          }
        if (flagHasdestination)
          {
            handler.start_pair("destination");
            if (partial_allowed)
                storedestination.write_partial_as_json(handler);
            else
                storedestination.write_as_json(handler);
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
        if (!(hasrequest_id()))
          {
            return "When parsing the object for %what%, the \"request_id\" field was missing.";
          }
        if (!(hasstatus()))
          {
            return "When parsing the object for %what%, the \"status\" field was missing.";
          }
        if (!(hasvehicle()))
          {
            return "When parsing the object for %what%, the \"vehicle\" field was missing.";
          }
        if (!(hasdriver()))
          {
            return "When parsing the object for %what%, the \"driver\" field was missing.";
          }
        if (!(haslocation()))
          {
            return "When parsing the object for %what%, the \"location\" field was missing.";
          }
        if (!(hassurge_multiplier()))
          {
            return "When parsing the object for %what%, the \"surge_multiplier\" field was missing.";
          }
        return null;
      }

    public static UberRequestDetailsResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDetailsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDetailsResponse", ignore_extras);
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
    public static UberRequestDetailsResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDetailsResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestDetailsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDetailsResponse", ignore_extras);
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
    public static UberRequestDetailsResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestDetailsResponseJSON from_text(string text, bool ignore_extras)
      {
        UberRequestDetailsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDetailsResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestDetailsResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestDetailsResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestDetailsResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestDetailsResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorrequest_id;
        private JSONHoldingStringGenerator fieldGeneratorstatus;
    private abstract class FieldGeneratorvehicle : JSONParallelGenerator
          {
            private UberRequestVehicleJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typevehicle result = new Typevehicle();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typevehicle result);
            public FieldGeneratorvehicle(bool ignore_extras)
              {
                    field0 = new UberRequestVehicleJSON.HoldingGenerator("option 0 of field \"vehicle\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"vehicle\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorvehicle(string what, bool ignore_extras)
              {
                    field0 = new UberRequestVehicleJSON.HoldingGenerator("option 0 of field \"vehicle\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"vehicle\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holdervehicle
          {
            private bool have_data;
            private Typevehicle data;
            public Holdervehicle()  { have_data = false; }
            public Holdervehicle(Typevehicle init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdervehicle(Holdervehicle other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typevehicle referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorvehicle : FieldGeneratorvehicle
          {
            protected override void handle_result(Typevehicle result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdervehicle(result);
              }

            public FieldHoldingGeneratorvehicle(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdervehicle value;
          };
    private class FieldHoldingArrayGeneratorvehicle : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorvehicle
      {
        private FieldHoldingArrayGeneratorvehicle top;

        protected override void handle_result(Typevehicle result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorvehicle init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typevehicle> result)
      {
      }

    public FieldHoldingArrayGeneratorvehicle(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typevehicle>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorvehicle(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typevehicle>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typevehicle> value;
  };
        private FieldHoldingGeneratorvehicle fieldGeneratorvehicle;
    private abstract class FieldGeneratordriver : JSONParallelGenerator
          {
            private UberRequestDriverJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typedriver result = new Typedriver();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typedriver result);
            public FieldGeneratordriver(bool ignore_extras)
              {
                    field0 = new UberRequestDriverJSON.HoldingGenerator("option 0 of field \"driver\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"driver\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratordriver(string what, bool ignore_extras)
              {
                    field0 = new UberRequestDriverJSON.HoldingGenerator("option 0 of field \"driver\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"driver\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holderdriver
          {
            private bool have_data;
            private Typedriver data;
            public Holderdriver()  { have_data = false; }
            public Holderdriver(Typedriver init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderdriver(Holderdriver other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typedriver referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratordriver : FieldGeneratordriver
          {
            protected override void handle_result(Typedriver result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderdriver(result);
              }

            public FieldHoldingGeneratordriver(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderdriver value;
          };
    private class FieldHoldingArrayGeneratordriver : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratordriver
      {
        private FieldHoldingArrayGeneratordriver top;

        protected override void handle_result(Typedriver result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratordriver init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typedriver> result)
      {
      }

    public FieldHoldingArrayGeneratordriver(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typedriver>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratordriver(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typedriver>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typedriver> value;
  };
        private FieldHoldingGeneratordriver fieldGeneratordriver;
    private abstract class FieldGeneratorlocation : JSONParallelGenerator
          {
            private UberRequestLocationJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typelocation result = new Typelocation();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typelocation result);
            public FieldGeneratorlocation(bool ignore_extras)
              {
                    field0 = new UberRequestLocationJSON.HoldingGenerator("option 0 of field \"location\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"location\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorlocation(string what, bool ignore_extras)
              {
                    field0 = new UberRequestLocationJSON.HoldingGenerator("option 0 of field \"location\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"location\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holderlocation
          {
            private bool have_data;
            private Typelocation data;
            public Holderlocation()  { have_data = false; }
            public Holderlocation(Typelocation init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderlocation(Holderlocation other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typelocation referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorlocation : FieldGeneratorlocation
          {
            protected override void handle_result(Typelocation result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderlocation(result);
              }

            public FieldHoldingGeneratorlocation(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderlocation value;
          };
    private class FieldHoldingArrayGeneratorlocation : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorlocation
      {
        private FieldHoldingArrayGeneratorlocation top;

        protected override void handle_result(Typelocation result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorlocation init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typelocation> result)
      {
      }

    public FieldHoldingArrayGeneratorlocation(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typelocation>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorlocation(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typelocation>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typelocation> value;
  };
        private FieldHoldingGeneratorlocation fieldGeneratorlocation;
    private abstract class FieldGeneratorsurge_multiplier : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typesurge_multiplier result = new Typesurge_multiplier();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = Double.Parse(field0.value);
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typesurge_multiplier result);
            public FieldGeneratorsurge_multiplier(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"surge_multiplier\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_multiplier\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorsurge_multiplier(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"surge_multiplier\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_multiplier\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holdersurge_multiplier
          {
            private bool have_data;
            private Typesurge_multiplier data;
            public Holdersurge_multiplier()  { have_data = false; }
            public Holdersurge_multiplier(Typesurge_multiplier init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdersurge_multiplier(Holdersurge_multiplier other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typesurge_multiplier referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorsurge_multiplier : FieldGeneratorsurge_multiplier
          {
            protected override void handle_result(Typesurge_multiplier result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdersurge_multiplier(result);
              }

            public FieldHoldingGeneratorsurge_multiplier(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdersurge_multiplier value;
          };
    private class FieldHoldingArrayGeneratorsurge_multiplier : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorsurge_multiplier
      {
        private FieldHoldingArrayGeneratorsurge_multiplier top;

        protected override void handle_result(Typesurge_multiplier result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsurge_multiplier init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typesurge_multiplier> result)
      {
      }

    public FieldHoldingArrayGeneratorsurge_multiplier(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_multiplier>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsurge_multiplier(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_multiplier>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typesurge_multiplier> value;
  };
        private FieldHoldingGeneratorsurge_multiplier fieldGeneratorsurge_multiplier;
        private UberRequestEndpointJSON.HoldingGenerator fieldGeneratorpickup;
        private UberRequestEndpointJSON.HoldingGenerator fieldGeneratordestination;
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
            UberRequestDetailsResponseJSON result = new UberRequestDetailsResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestDetailsResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestDetailsResponseJSON result)
          {
            if (fieldGeneratorrequest_id.have_value)
              {
                result.setrequest_id(fieldGeneratorrequest_id.value);
                fieldGeneratorrequest_id.have_value = false;
              }
            else if ((!(result.hasrequest_id())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"request_id\" field was missing.");
              }
            if (fieldGeneratorstatus.have_value)
              {
                result.setstatus(fieldGeneratorstatus.value);
                fieldGeneratorstatus.have_value = false;
              }
            else if ((!(result.hasstatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"status\" field was missing.");
              }
            if (fieldGeneratorvehicle.have_value)
              {
                result.setvehicle(fieldGeneratorvehicle.value.referenced());
                fieldGeneratorvehicle.have_value = false;
              }
            else if ((!(result.hasvehicle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"vehicle\" field was missing.");
              }
            if (fieldGeneratordriver.have_value)
              {
                result.setdriver(fieldGeneratordriver.value.referenced());
                fieldGeneratordriver.have_value = false;
              }
            else if ((!(result.hasdriver())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"driver\" field was missing.");
              }
            if (fieldGeneratorlocation.have_value)
              {
                result.setlocation(fieldGeneratorlocation.value.referenced());
                fieldGeneratorlocation.have_value = false;
              }
            else if ((!(result.haslocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"location\" field was missing.");
              }
            if (fieldGeneratorsurge_multiplier.have_value)
              {
                result.setsurge_multiplier(fieldGeneratorsurge_multiplier.value.referenced());
                fieldGeneratorsurge_multiplier.have_value = false;
              }
            else if ((!(result.hassurge_multiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"surge_multiplier\" field was missing.");
              }
            if (fieldGeneratorpickup.have_value)
              {
                result.setpickup(fieldGeneratorpickup.value);
                fieldGeneratorpickup.have_value = false;
              }
            if (fieldGeneratordestination.have_value)
              {
                result.setdestination(fieldGeneratordestination.value);
                fieldGeneratordestination.have_value = false;
              }
          }
        protected abstract void handle_result(UberRequestDetailsResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "stination", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratordestination;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "iver", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratordriver;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorlocation;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "ickup", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorpickup;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "equest_id", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorrequest_id;
                    break;
                case 's':
                    switch (field_name[1])
                      {
                        case 't':
                            if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorstatus;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rge_multiplier", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorsurge_multiplier;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'v':
                    if ((String.Compare(field_name, 1, "ehicle", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorvehicle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorrequest_id = new JSONHoldingStringGenerator("field \"request_id\" of the UberRequestDetailsResponse class");
            fieldGeneratorstatus = new JSONHoldingStringGenerator("field \"status\" of the UberRequestDetailsResponse class");
            fieldGeneratorvehicle = new FieldHoldingGeneratorvehicle("field \"vehicle\" of the UberRequestDetailsResponse class", ignore_extras);
            fieldGeneratordriver = new FieldHoldingGeneratordriver("field \"driver\" of the UberRequestDetailsResponse class", ignore_extras);
            fieldGeneratorlocation = new FieldHoldingGeneratorlocation("field \"location\" of the UberRequestDetailsResponse class", ignore_extras);
            fieldGeneratorsurge_multiplier = new FieldHoldingGeneratorsurge_multiplier("field \"surge_multiplier\" of the UberRequestDetailsResponse class", ignore_extras);
            fieldGeneratorpickup = new UberRequestEndpointJSON.HoldingGenerator("field \"pickup\" of the UberRequestDetailsResponse class", ignore_extras);
            fieldGeneratordestination = new UberRequestEndpointJSON.HoldingGenerator("field \"destination\" of the UberRequestDetailsResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestDetailsResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorrequest_id = new JSONHoldingStringGenerator("field \"request_id\" of the UberRequestDetailsResponse class");
            fieldGeneratorstatus = new JSONHoldingStringGenerator("field \"status\" of the UberRequestDetailsResponse class");
            fieldGeneratorvehicle = new FieldHoldingGeneratorvehicle("field \"vehicle\" of the UberRequestDetailsResponse class", false);
            fieldGeneratordriver = new FieldHoldingGeneratordriver("field \"driver\" of the UberRequestDetailsResponse class", false);
            fieldGeneratorlocation = new FieldHoldingGeneratorlocation("field \"location\" of the UberRequestDetailsResponse class", false);
            fieldGeneratorsurge_multiplier = new FieldHoldingGeneratorsurge_multiplier("field \"surge_multiplier\" of the UberRequestDetailsResponse class", false);
            fieldGeneratorpickup = new UberRequestEndpointJSON.HoldingGenerator("field \"pickup\" of the UberRequestDetailsResponse class", false);
            fieldGeneratordestination = new UberRequestEndpointJSON.HoldingGenerator("field \"destination\" of the UberRequestDetailsResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestDetailsResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorrequest_id.reset();
            fieldGeneratorstatus.reset();
            fieldGeneratorvehicle.reset();
            fieldGeneratordriver.reset();
            fieldGeneratorlocation.reset();
            fieldGeneratorsurge_multiplier.reset();
            fieldGeneratorpickup.reset();
            fieldGeneratordestination.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorpickup.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratordestination.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorpickup.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratordestination.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestDetailsResponseJSON  result)
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
        public UberRequestDetailsResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestDetailsResponseJSON  result)
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
    protected virtual void handle_result(List<UberRequestDetailsResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestDetailsResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestDetailsResponseJSON>();
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
    public List<UberRequestDetailsResponseJSON> value;
  };
  };
