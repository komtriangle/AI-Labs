/* file "UberRequestEstimatePriceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UberRequestEstimatePriceJSON : JSONBase
  {
    public struct Typelow_estimate
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
            [FieldOffset(0)]
            public EmptyObjectJSON  choice2;
          };
        public Utype u;
      };
    public struct Typehigh_estimate
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
            [FieldOffset(0)]
            public EmptyObjectJSON  choice2;
          };
        public Utype u;
      };
    public struct Typeminimum
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public double choice0;
            [FieldOffset(0)]
            public bool choice1;
            [FieldOffset(0)]
            public EmptyObjectJSON  choice2;
          };
        public Utype u;
      };
    public struct Typecurrency_code
      {
        public int key;
        public string choice0;
        public bool choice1;
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
    public struct Typesurge_confirmation_href
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct Typesurge_confirmation_id
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    private bool flagHasdisplay;
    private string storedisplay;
    private bool flagHaslow_estimate;
    private Typelow_estimate storelow_estimate;
    private bool flagHashigh_estimate;
    private Typehigh_estimate storehigh_estimate;
    private bool flagHasminimum;
    private Typeminimum storeminimum;
    private bool flagHascurrency_code;
    private Typecurrency_code storecurrency_code;
    private bool flagHassurge_multiplier;
    private Typesurge_multiplier storesurge_multiplier;
    private bool flagHassurge_confirmation_href;
    private Typesurge_confirmation_href storesurge_confirmation_href;
    private bool flagHassurge_confirmation_id;
    private Typesurge_confirmation_id storesurge_confirmation_id;
    private bool flagHasfare_id;
    private string storefare_id;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONdisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field display of UberRequestEstimatePriceJSON is not a string.");
        setdisplay(json_string.getData());
      }


    private void  fromJSONlow_estimate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typelow_estimate or_result = new Typelow_estimate();
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
          {
            try
              {
                EmptyObjectJSON convert_classy = EmptyObjectJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice2 = convert_classy;
                or_result.key = 2;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field low_estimate of UberRequestEstimatePriceJSON is not one of the allowed values.");
        setlow_estimate(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONhigh_estimate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typehigh_estimate or_result = new Typehigh_estimate();
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
          {
            try
              {
                EmptyObjectJSON convert_classy = EmptyObjectJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice2 = convert_classy;
                or_result.key = 2;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field high_estimate of UberRequestEstimatePriceJSON is not one of the allowed values.");
        sethigh_estimate(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONminimum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typeminimum or_result = new Typeminimum();
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
          {
            try
              {
                EmptyObjectJSON convert_classy = EmptyObjectJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice2 = convert_classy;
                or_result.key = 2;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field minimum of UberRequestEstimatePriceJSON is not one of the allowed values.");
        setminimum(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONcurrency_code(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typecurrency_code or_result = new Typecurrency_code();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field currency_code of UberRequestEstimatePriceJSON is not one of the allowed values.");
        setcurrency_code(or_result);
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
            throw new Exception("The value for field surge_multiplier of UberRequestEstimatePriceJSON is not one of the allowed values.");
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


    private void  fromJSONsurge_confirmation_href(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typesurge_confirmation_href or_result = new Typesurge_confirmation_href();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field surge_confirmation_href of UberRequestEstimatePriceJSON is not one of the allowed values.");
        setsurge_confirmation_href(or_result);
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


    private void  fromJSONsurge_confirmation_id(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typesurge_confirmation_id or_result = new Typesurge_confirmation_id();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
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
            throw new Exception("The value for field surge_confirmation_id of UberRequestEstimatePriceJSON is not one of the allowed values.");
        setsurge_confirmation_id(or_result);
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


    private void  fromJSONfare_id(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field fare_id of UberRequestEstimatePriceJSON is not a string.");
        setfare_id(json_string.getData());
      }


    public UberRequestEstimatePriceJSON()
      {
        flagHasdisplay = false;
        flagHaslow_estimate = false;
        flagHashigh_estimate = false;
        flagHasminimum = false;
        flagHascurrency_code = false;
        flagHassurge_multiplier = false;
        flagHassurge_confirmation_href = false;
        flagHassurge_confirmation_id = false;
        flagHasfare_id = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasdisplay()
      {
        return flagHasdisplay;
      }

    public string  getdisplay()
      {
        Debug.Assert(flagHasdisplay);
        return storedisplay;
      }

    public bool  haslow_estimate()
      {
        return flagHaslow_estimate;
      }

    public Typelow_estimate  getlow_estimate()
      {
        Debug.Assert(flagHaslow_estimate);
        return storelow_estimate;
      }

    public bool  hashigh_estimate()
      {
        return flagHashigh_estimate;
      }

    public Typehigh_estimate  gethigh_estimate()
      {
        Debug.Assert(flagHashigh_estimate);
        return storehigh_estimate;
      }

    public bool  hasminimum()
      {
        return flagHasminimum;
      }

    public Typeminimum  getminimum()
      {
        Debug.Assert(flagHasminimum);
        return storeminimum;
      }

    public bool  hascurrency_code()
      {
        return flagHascurrency_code;
      }

    public Typecurrency_code  getcurrency_code()
      {
        Debug.Assert(flagHascurrency_code);
        return storecurrency_code;
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

    public bool  hassurge_confirmation_href()
      {
        return flagHassurge_confirmation_href;
      }

    public Typesurge_confirmation_href  getsurge_confirmation_href()
      {
        Debug.Assert(flagHassurge_confirmation_href);
        return storesurge_confirmation_href;
      }

    public bool  hassurge_confirmation_id()
      {
        return flagHassurge_confirmation_id;
      }

    public Typesurge_confirmation_id  getsurge_confirmation_id()
      {
        Debug.Assert(flagHassurge_confirmation_id);
        return storesurge_confirmation_id;
      }

    public bool  hasfare_id()
      {
        return flagHasfare_id;
      }

    public string  getfare_id()
      {
        Debug.Assert(flagHasfare_id);
        return storefare_id;
      }


    public virtual int extraUberRequestEstimatePriceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestEstimatePriceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestEstimatePriceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestEstimatePriceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setdisplay(string new_value)
      {
        flagHasdisplay = true;
        storedisplay = new_value;
      }
    public void unsetdisplay()
      {
        flagHasdisplay = false;
      }
    public void setlow_estimate(Typelow_estimate new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHaslow_estimate)
          {
            switch (storelow_estimate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaslow_estimate = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storelow_estimate = new_value;
      }
    public void unsetlow_estimate()
      {
        if (flagHaslow_estimate)
          {
            switch (storelow_estimate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaslow_estimate = false;
      }
    public void sethigh_estimate(Typehigh_estimate new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHashigh_estimate)
          {
            switch (storehigh_estimate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHashigh_estimate = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storehigh_estimate = new_value;
      }
    public void unsethigh_estimate()
      {
        if (flagHashigh_estimate)
          {
            switch (storehigh_estimate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHashigh_estimate = false;
      }
    public void setminimum(Typeminimum new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasminimum)
          {
            switch (storeminimum.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasminimum = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeminimum = new_value;
      }
    public void unsetminimum()
      {
        if (flagHasminimum)
          {
            switch (storeminimum.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasminimum = false;
      }
    public void setcurrency_code(Typecurrency_code new_value)
      {
        flagHascurrency_code = true;
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
        storecurrency_code = new_value;
      }
    public void unsetcurrency_code()
      {
        flagHascurrency_code = false;
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
    public void setsurge_confirmation_href(Typesurge_confirmation_href new_value)
      {
        flagHassurge_confirmation_href = true;
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
        storesurge_confirmation_href = new_value;
      }
    public void unsetsurge_confirmation_href()
      {
        flagHassurge_confirmation_href = false;
      }
    public void setsurge_confirmation_id(Typesurge_confirmation_id new_value)
      {
        flagHassurge_confirmation_id = true;
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
        storesurge_confirmation_id = new_value;
      }
    public void unsetsurge_confirmation_id()
      {
        flagHassurge_confirmation_id = false;
      }
    public void setfare_id(string new_value)
      {
        flagHasfare_id = true;
        storefare_id = new_value;
      }
    public void unsetfare_id()
      {
        flagHasfare_id = false;
      }

    public virtual void extraUberRequestEstimatePriceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestEstimatePriceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestEstimatePriceLookup(key);
        if (old_field == null)
          {
            extraUberRequestEstimatePriceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasdisplay);
        if (flagHasdisplay)
          {
            handler.start_pair("display");
            handler.string_value(storedisplay);
          }
        Debug.Assert(partial_allowed || flagHaslow_estimate);
        if (flagHaslow_estimate)
          {
            handler.start_pair("low_estimate");
            switch (storelow_estimate.key)
              {
                case 0:
                    if (((double)(long)storelow_estimate.u.choice0) == storelow_estimate.u.choice0)
                        handler.number_value((long)storelow_estimate.u.choice0);
                    else
                        handler.number_value(storelow_estimate.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                case 2:
                    if (partial_allowed)
                        storelow_estimate.u.choice2.write_partial_as_json(handler);
                    else
                        storelow_estimate.u.choice2.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHashigh_estimate);
        if (flagHashigh_estimate)
          {
            handler.start_pair("high_estimate");
            switch (storehigh_estimate.key)
              {
                case 0:
                    if (((double)(long)storehigh_estimate.u.choice0) == storehigh_estimate.u.choice0)
                        handler.number_value((long)storehigh_estimate.u.choice0);
                    else
                        handler.number_value(storehigh_estimate.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                case 2:
                    if (partial_allowed)
                        storehigh_estimate.u.choice2.write_partial_as_json(handler);
                    else
                        storehigh_estimate.u.choice2.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasminimum);
        if (flagHasminimum)
          {
            handler.start_pair("minimum");
            switch (storeminimum.key)
              {
                case 0:
                    if (((double)(long)storeminimum.u.choice0) == storeminimum.u.choice0)
                        handler.number_value((long)storeminimum.u.choice0);
                    else
                        handler.number_value(storeminimum.u.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                case 2:
                    if (partial_allowed)
                        storeminimum.u.choice2.write_partial_as_json(handler);
                    else
                        storeminimum.u.choice2.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHascurrency_code);
        if (flagHascurrency_code)
          {
            handler.start_pair("currency_code");
            switch (storecurrency_code.key)
              {
                case 0:
                    handler.string_value(storecurrency_code.choice0);
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
        Debug.Assert(partial_allowed || flagHassurge_confirmation_href);
        if (flagHassurge_confirmation_href)
          {
            handler.start_pair("surge_confirmation_href");
            switch (storesurge_confirmation_href.key)
              {
                case 0:
                    handler.string_value(storesurge_confirmation_href.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHassurge_confirmation_id);
        if (flagHassurge_confirmation_id)
          {
            handler.start_pair("surge_confirmation_id");
            switch (storesurge_confirmation_id.key)
              {
                case 0:
                    handler.string_value(storesurge_confirmation_id.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasfare_id)
          {
            handler.start_pair("fare_id");
            handler.string_value(storefare_id);
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
        if (!(hasdisplay()))
          {
            return "When parsing the object for %what%, the \"display\" field was missing.";
          }
        if (!(haslow_estimate()))
          {
            return "When parsing the object for %what%, the \"low_estimate\" field was missing.";
          }
        if (!(hashigh_estimate()))
          {
            return "When parsing the object for %what%, the \"high_estimate\" field was missing.";
          }
        if (!(hasminimum()))
          {
            return "When parsing the object for %what%, the \"minimum\" field was missing.";
          }
        if (!(hascurrency_code()))
          {
            return "When parsing the object for %what%, the \"currency_code\" field was missing.";
          }
        if (!(hassurge_multiplier()))
          {
            return "When parsing the object for %what%, the \"surge_multiplier\" field was missing.";
          }
        if (!(hassurge_confirmation_href()))
          {
            return "When parsing the object for %what%, the \"surge_confirmation_href\" field was missing.";
          }
        if (!(hassurge_confirmation_id()))
          {
            return "When parsing the object for %what%, the \"surge_confirmation_id\" field was missing.";
          }
        return null;
      }

    public static UberRequestEstimatePriceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestEstimatePriceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimatePrice", ignore_extras);
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
    public static UberRequestEstimatePriceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestEstimatePriceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestEstimatePriceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimatePrice", ignore_extras);
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
    public static UberRequestEstimatePriceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberRequestEstimatePriceJSON from_text(string text, bool ignore_extras)
      {
        UberRequestEstimatePriceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimatePrice", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestEstimatePriceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberRequestEstimatePriceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestEstimatePriceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestEstimatePrice", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratordisplay;
    private abstract class FieldGeneratorlow_estimate : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private EmptyObjectJSON.HoldingGenerator field2;
            private JSONHandler [] all_handlers = new JSONHandler [3];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typelow_estimate result = new Typelow_estimate();
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
                    case 2:
                      {
                        Debug.Assert(field2.have_value);
                        result.u.choice2 = field2.value;
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
            protected abstract void handle_result(Typelow_estimate result);
            public FieldGeneratorlow_estimate(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"low_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"low_estimate\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"low_estimate\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }
            public FieldGeneratorlow_estimate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"low_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"low_estimate\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"low_estimate\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                field2.reset();
                base.reset();
              }
          };
        private class Holderlow_estimate
          {
            private bool have_data;
            private Typelow_estimate data;
            public Holderlow_estimate()  { have_data = false; }
            public Holderlow_estimate(Typelow_estimate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderlow_estimate(Holderlow_estimate other)
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
            public Typelow_estimate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorlow_estimate : FieldGeneratorlow_estimate
          {
            protected override void handle_result(Typelow_estimate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderlow_estimate(result);
              }

            public FieldHoldingGeneratorlow_estimate(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderlow_estimate value;
          };
    private class FieldHoldingArrayGeneratorlow_estimate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorlow_estimate
      {
        private FieldHoldingArrayGeneratorlow_estimate top;

        protected override void handle_result(Typelow_estimate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorlow_estimate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typelow_estimate> result)
      {
      }

    public FieldHoldingArrayGeneratorlow_estimate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typelow_estimate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorlow_estimate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typelow_estimate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typelow_estimate> value;
  };
        private FieldHoldingGeneratorlow_estimate fieldGeneratorlow_estimate;
    private abstract class FieldGeneratorhigh_estimate : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private EmptyObjectJSON.HoldingGenerator field2;
            private JSONHandler [] all_handlers = new JSONHandler [3];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typehigh_estimate result = new Typehigh_estimate();
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
                    case 2:
                      {
                        Debug.Assert(field2.have_value);
                        result.u.choice2 = field2.value;
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
            protected abstract void handle_result(Typehigh_estimate result);
            public FieldGeneratorhigh_estimate(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"high_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"high_estimate\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"high_estimate\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }
            public FieldGeneratorhigh_estimate(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"high_estimate\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"high_estimate\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"high_estimate\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                field2.reset();
                base.reset();
              }
          };
        private class Holderhigh_estimate
          {
            private bool have_data;
            private Typehigh_estimate data;
            public Holderhigh_estimate()  { have_data = false; }
            public Holderhigh_estimate(Typehigh_estimate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderhigh_estimate(Holderhigh_estimate other)
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
            public Typehigh_estimate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorhigh_estimate : FieldGeneratorhigh_estimate
          {
            protected override void handle_result(Typehigh_estimate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderhigh_estimate(result);
              }

            public FieldHoldingGeneratorhigh_estimate(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderhigh_estimate value;
          };
    private class FieldHoldingArrayGeneratorhigh_estimate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorhigh_estimate
      {
        private FieldHoldingArrayGeneratorhigh_estimate top;

        protected override void handle_result(Typehigh_estimate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorhigh_estimate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typehigh_estimate> result)
      {
      }

    public FieldHoldingArrayGeneratorhigh_estimate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typehigh_estimate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorhigh_estimate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typehigh_estimate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typehigh_estimate> value;
  };
        private FieldHoldingGeneratorhigh_estimate fieldGeneratorhigh_estimate;
    private abstract class FieldGeneratorminimum : JSONParallelGenerator
          {
            private JSONHoldingNumberTextGenerator field0;
            private JSONHoldingNullGenerator field1;
            private EmptyObjectJSON.HoldingGenerator field2;
            private JSONHandler [] all_handlers = new JSONHandler [3];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typeminimum result = new Typeminimum();
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
                    case 2:
                      {
                        Debug.Assert(field2.have_value);
                        result.u.choice2 = field2.value;
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
            protected abstract void handle_result(Typeminimum result);
            public FieldGeneratorminimum(bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"minimum\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"minimum\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"minimum\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }
            public FieldGeneratorminimum(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"minimum\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"minimum\"");
                    field2 = new EmptyObjectJSON.HoldingGenerator("option 2 of field \"minimum\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
                all_handlers[2] = field2;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                field2.reset();
                base.reset();
              }
          };
        private class Holderminimum
          {
            private bool have_data;
            private Typeminimum data;
            public Holderminimum()  { have_data = false; }
            public Holderminimum(Typeminimum init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holderminimum(Holderminimum other)
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
            public Typeminimum referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorminimum : FieldGeneratorminimum
          {
            protected override void handle_result(Typeminimum result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holderminimum(result);
              }

            public FieldHoldingGeneratorminimum(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holderminimum value;
          };
    private class FieldHoldingArrayGeneratorminimum : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorminimum
      {
        private FieldHoldingArrayGeneratorminimum top;

        protected override void handle_result(Typeminimum result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorminimum init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typeminimum> result)
      {
      }

    public FieldHoldingArrayGeneratorminimum(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeminimum>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorminimum(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeminimum>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typeminimum> value;
  };
        private FieldHoldingGeneratorminimum fieldGeneratorminimum;
    private abstract class FieldGeneratorcurrency_code : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typecurrency_code result = new Typecurrency_code();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(Typecurrency_code result);
            public FieldGeneratorcurrency_code(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"currency_code\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"currency_code\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorcurrency_code(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"currency_code\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"currency_code\"");
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
        private class Holdercurrency_code
          {
            private bool have_data;
            private Typecurrency_code data;
            public Holdercurrency_code()  { have_data = false; }
            public Holdercurrency_code(Typecurrency_code init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdercurrency_code(Holdercurrency_code other)
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
            public Typecurrency_code referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorcurrency_code : FieldGeneratorcurrency_code
          {
            protected override void handle_result(Typecurrency_code result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdercurrency_code(result);
              }

            public FieldHoldingGeneratorcurrency_code(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdercurrency_code value;
          };
    private class FieldHoldingArrayGeneratorcurrency_code : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorcurrency_code
      {
        private FieldHoldingArrayGeneratorcurrency_code top;

        protected override void handle_result(Typecurrency_code result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorcurrency_code init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typecurrency_code> result)
      {
      }

    public FieldHoldingArrayGeneratorcurrency_code(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typecurrency_code>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorcurrency_code(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typecurrency_code>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typecurrency_code> value;
  };
        private FieldHoldingGeneratorcurrency_code fieldGeneratorcurrency_code;
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
    private abstract class FieldGeneratorsurge_confirmation_href : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typesurge_confirmation_href result = new Typesurge_confirmation_href();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(Typesurge_confirmation_href result);
            public FieldGeneratorsurge_confirmation_href(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"surge_confirmation_href\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_confirmation_href\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorsurge_confirmation_href(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"surge_confirmation_href\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_confirmation_href\"");
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
        private class Holdersurge_confirmation_href
          {
            private bool have_data;
            private Typesurge_confirmation_href data;
            public Holdersurge_confirmation_href()  { have_data = false; }
            public Holdersurge_confirmation_href(Typesurge_confirmation_href init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdersurge_confirmation_href(Holdersurge_confirmation_href other)
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
            public Typesurge_confirmation_href referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorsurge_confirmation_href : FieldGeneratorsurge_confirmation_href
          {
            protected override void handle_result(Typesurge_confirmation_href result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdersurge_confirmation_href(result);
              }

            public FieldHoldingGeneratorsurge_confirmation_href(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdersurge_confirmation_href value;
          };
    private class FieldHoldingArrayGeneratorsurge_confirmation_href : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorsurge_confirmation_href
      {
        private FieldHoldingArrayGeneratorsurge_confirmation_href top;

        protected override void handle_result(Typesurge_confirmation_href result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsurge_confirmation_href init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typesurge_confirmation_href> result)
      {
      }

    public FieldHoldingArrayGeneratorsurge_confirmation_href(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_confirmation_href>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsurge_confirmation_href(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_confirmation_href>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typesurge_confirmation_href> value;
  };
        private FieldHoldingGeneratorsurge_confirmation_href fieldGeneratorsurge_confirmation_href;
    private abstract class FieldGeneratorsurge_confirmation_id : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typesurge_confirmation_id result = new Typesurge_confirmation_id();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
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
            protected abstract void handle_result(Typesurge_confirmation_id result);
            public FieldGeneratorsurge_confirmation_id(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"surge_confirmation_id\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_confirmation_id\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorsurge_confirmation_id(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"surge_confirmation_id\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"surge_confirmation_id\"");
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
        private class Holdersurge_confirmation_id
          {
            private bool have_data;
            private Typesurge_confirmation_id data;
            public Holdersurge_confirmation_id()  { have_data = false; }
            public Holdersurge_confirmation_id(Typesurge_confirmation_id init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdersurge_confirmation_id(Holdersurge_confirmation_id other)
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
            public Typesurge_confirmation_id referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorsurge_confirmation_id : FieldGeneratorsurge_confirmation_id
          {
            protected override void handle_result(Typesurge_confirmation_id result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdersurge_confirmation_id(result);
              }

            public FieldHoldingGeneratorsurge_confirmation_id(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdersurge_confirmation_id value;
          };
    private class FieldHoldingArrayGeneratorsurge_confirmation_id : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorsurge_confirmation_id
      {
        private FieldHoldingArrayGeneratorsurge_confirmation_id top;

        protected override void handle_result(Typesurge_confirmation_id result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsurge_confirmation_id init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typesurge_confirmation_id> result)
      {
      }

    public FieldHoldingArrayGeneratorsurge_confirmation_id(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_confirmation_id>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsurge_confirmation_id(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typesurge_confirmation_id>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typesurge_confirmation_id> value;
  };
        private FieldHoldingGeneratorsurge_confirmation_id fieldGeneratorsurge_confirmation_id;
        private JSONHoldingStringGenerator fieldGeneratorfare_id;
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
            UberRequestEstimatePriceJSON result = new UberRequestEstimatePriceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestEstimatePriceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberRequestEstimatePriceJSON result)
          {
            if (fieldGeneratordisplay.have_value)
              {
                result.setdisplay(fieldGeneratordisplay.value);
                fieldGeneratordisplay.have_value = false;
              }
            else if ((!(result.hasdisplay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"display\" field was missing.");
              }
            if (fieldGeneratorlow_estimate.have_value)
              {
                result.setlow_estimate(fieldGeneratorlow_estimate.value.referenced());
                fieldGeneratorlow_estimate.have_value = false;
              }
            else if ((!(result.haslow_estimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"low_estimate\" field was missing.");
              }
            if (fieldGeneratorhigh_estimate.have_value)
              {
                result.sethigh_estimate(fieldGeneratorhigh_estimate.value.referenced());
                fieldGeneratorhigh_estimate.have_value = false;
              }
            else if ((!(result.hashigh_estimate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"high_estimate\" field was missing.");
              }
            if (fieldGeneratorminimum.have_value)
              {
                result.setminimum(fieldGeneratorminimum.value.referenced());
                fieldGeneratorminimum.have_value = false;
              }
            else if ((!(result.hasminimum())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"minimum\" field was missing.");
              }
            if (fieldGeneratorcurrency_code.have_value)
              {
                result.setcurrency_code(fieldGeneratorcurrency_code.value.referenced());
                fieldGeneratorcurrency_code.have_value = false;
              }
            else if ((!(result.hascurrency_code())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"currency_code\" field was missing.");
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
            if (fieldGeneratorsurge_confirmation_href.have_value)
              {
                result.setsurge_confirmation_href(fieldGeneratorsurge_confirmation_href.value.referenced());
                fieldGeneratorsurge_confirmation_href.have_value = false;
              }
            else if ((!(result.hassurge_confirmation_href())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"surge_confirmation_href\" field was missing.");
              }
            if (fieldGeneratorsurge_confirmation_id.have_value)
              {
                result.setsurge_confirmation_id(fieldGeneratorsurge_confirmation_id.value.referenced());
                fieldGeneratorsurge_confirmation_id.have_value = false;
              }
            else if ((!(result.hassurge_confirmation_id())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"surge_confirmation_id\" field was missing.");
              }
            if (fieldGeneratorfare_id.have_value)
              {
                result.setfare_id(fieldGeneratorfare_id.value);
                fieldGeneratorfare_id.have_value = false;
              }
          }
        protected abstract void handle_result(UberRequestEstimatePriceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if ((String.Compare(field_name, 1, "urrency_code", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorcurrency_code;
                    break;
                case 'd':
                    if ((String.Compare(field_name, 1, "isplay", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratordisplay;
                    break;
                case 'f':
                    if ((String.Compare(field_name, 1, "are_id", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorfare_id;
                    break;
                case 'h':
                    if ((String.Compare(field_name, 1, "igh_estimate", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorhigh_estimate;
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "ow_estimate", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorlow_estimate;
                    break;
                case 'm':
                    if ((String.Compare(field_name, 1, "inimum", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorminimum;
                    break;
                case 's':
                    if (String.Compare(field_name, 1, "urge_", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'c':
                                if (String.Compare(field_name, 7, "onfirmation_", 0, 12, false) == 0)
                                  {
                                    switch (field_name[19])
                                      {
                                        case 'h':
                                            if ((String.Compare(field_name, 20, "ref", 0, 3, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorsurge_confirmation_href;
                                            break;
                                        case 'i':
                                            if ((String.Compare(field_name, 20, "d", 0, 1, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorsurge_confirmation_id;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 7, "ultiplier", 0, 9, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorsurge_multiplier;
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
            fieldGeneratordisplay = new JSONHoldingStringGenerator("field \"display\" of the UberRequestEstimatePrice class");
            fieldGeneratorlow_estimate = new FieldHoldingGeneratorlow_estimate("field \"low_estimate\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorhigh_estimate = new FieldHoldingGeneratorhigh_estimate("field \"high_estimate\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorminimum = new FieldHoldingGeneratorminimum("field \"minimum\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorcurrency_code = new FieldHoldingGeneratorcurrency_code("field \"currency_code\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorsurge_multiplier = new FieldHoldingGeneratorsurge_multiplier("field \"surge_multiplier\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorsurge_confirmation_href = new FieldHoldingGeneratorsurge_confirmation_href("field \"surge_confirmation_href\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorsurge_confirmation_id = new FieldHoldingGeneratorsurge_confirmation_id("field \"surge_confirmation_id\" of the UberRequestEstimatePrice class", ignore_extras);
            fieldGeneratorfare_id = new JSONHoldingStringGenerator("field \"fare_id\" of the UberRequestEstimatePrice class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestEstimatePrice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratordisplay = new JSONHoldingStringGenerator("field \"display\" of the UberRequestEstimatePrice class");
            fieldGeneratorlow_estimate = new FieldHoldingGeneratorlow_estimate("field \"low_estimate\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorhigh_estimate = new FieldHoldingGeneratorhigh_estimate("field \"high_estimate\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorminimum = new FieldHoldingGeneratorminimum("field \"minimum\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorcurrency_code = new FieldHoldingGeneratorcurrency_code("field \"currency_code\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorsurge_multiplier = new FieldHoldingGeneratorsurge_multiplier("field \"surge_multiplier\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorsurge_confirmation_href = new FieldHoldingGeneratorsurge_confirmation_href("field \"surge_confirmation_href\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorsurge_confirmation_id = new FieldHoldingGeneratorsurge_confirmation_id("field \"surge_confirmation_id\" of the UberRequestEstimatePrice class", false);
            fieldGeneratorfare_id = new JSONHoldingStringGenerator("field \"fare_id\" of the UberRequestEstimatePrice class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestEstimatePrice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratordisplay.reset();
            fieldGeneratorlow_estimate.reset();
            fieldGeneratorhigh_estimate.reset();
            fieldGeneratorminimum.reset();
            fieldGeneratorcurrency_code.reset();
            fieldGeneratorsurge_multiplier.reset();
            fieldGeneratorsurge_confirmation_href.reset();
            fieldGeneratorsurge_confirmation_id.reset();
            fieldGeneratorfare_id.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestEstimatePriceJSON  result)
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
        public UberRequestEstimatePriceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestEstimatePriceJSON  result)
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
    protected virtual void handle_result(List<UberRequestEstimatePriceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestEstimatePriceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestEstimatePriceJSON>();
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
    public List<UberRequestEstimatePriceJSON> value;
  };
  };
