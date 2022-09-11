/* file "UberVehicleJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UberVehicleJSON : JSONBase
  {
    private bool flagHasMake;
    private string storeMake;
    private bool flagHasModel;
    private string storeModel;
    private bool flagHasLicensePlate;
    private string storeLicensePlate;
    private bool flagHasPictureUrl;
    private string storePictureUrl;
    private bool flagHasLatitude;
    private double storeLatitude;
    private string textStoreLatitude;
    private bool flagHasLongitude;
    private double storeLongitude;
    private string textStoreLongitude;
    private bool flagHasBearing;
    private BigInteger storeBearing;
    private bool flagHasDriver;
    private UberDriverJSON  storeDriver;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMake(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Make of UberVehicleJSON is not a string.");
        setMake(json_string.getData());
      }


    private void  fromJSONModel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Model of UberVehicleJSON is not a string.");
        setModel(json_string.getData());
      }


    private void  fromJSONLicensePlate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LicensePlate of UberVehicleJSON is not a string.");
        setLicensePlate(json_string.getData());
      }


    private void  fromJSONPictureUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PictureUrl of UberVehicleJSON is not a string.");
        setPictureUrl(json_string.getData());
      }


    private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Latitude of UberVehicleJSON is not a number.");
              }
          }
        setLatitudeText(the_rational_text);
      }


    private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Longitude of UberVehicleJSON is not a number.");
              }
          }
        setLongitudeText(the_rational_text);
      }


    private void  fromJSONBearing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Bearing of UberVehicleJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Bearing of UberVehicleJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setBearing(extracted_integer);
      }


    private void  fromJSONDriver(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberDriverJSON convert_classy = UberDriverJSON.from_json(json_value, ignore_extras, true);
        setDriver(convert_classy);
      }


    public UberVehicleJSON()
      {
        flagHasMake = false;
        flagHasModel = false;
        flagHasLicensePlate = false;
        flagHasPictureUrl = false;
        flagHasLatitude = false;
        flagHasLongitude = false;
        flagHasBearing = false;
        flagHasDriver = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMake()
      {
        return flagHasMake;
      }

    public string  getMake()
      {
        Debug.Assert(flagHasMake);
        return storeMake;
      }

    public bool  hasModel()
      {
        return flagHasModel;
      }

    public string  getModel()
      {
        Debug.Assert(flagHasModel);
        return storeModel;
      }

    public bool  hasLicensePlate()
      {
        return flagHasLicensePlate;
      }

    public string  getLicensePlate()
      {
        Debug.Assert(flagHasLicensePlate);
        return storeLicensePlate;
      }

    public bool  hasPictureUrl()
      {
        return flagHasPictureUrl;
      }

    public string  getPictureUrl()
      {
        Debug.Assert(flagHasPictureUrl);
        return storePictureUrl;
      }

    public bool  hasLatitude()
      {
        return flagHasLatitude;
      }

    public double  getLatitude()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude != "")
          {
            return Double.Parse(textStoreLatitude);
          }
        return storeLatitude;
      }

    public string  getLatitudeAsText()
      {
        Debug.Assert(flagHasLatitude);
        if (textStoreLatitude == "")
          {
            return Convert.ToString(storeLatitude);
          }
        else
          {
            return (textStoreLatitude);
          }
      }

    public bool  hasLongitude()
      {
        return flagHasLongitude;
      }

    public double  getLongitude()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude != "")
          {
            return Double.Parse(textStoreLongitude);
          }
        return storeLongitude;
      }

    public string  getLongitudeAsText()
      {
        Debug.Assert(flagHasLongitude);
        if (textStoreLongitude == "")
          {
            return Convert.ToString(storeLongitude);
          }
        else
          {
            return (textStoreLongitude);
          }
      }

    public bool  hasBearing()
      {
        return flagHasBearing;
      }

    public BigInteger  getBearing()
      {
        Debug.Assert(flagHasBearing);
        return storeBearing;
      }

    public bool  hasDriver()
      {
        return flagHasDriver;
      }

    public UberDriverJSON   getDriver()
      {
        Debug.Assert(flagHasDriver);
        return storeDriver;
      }


    public virtual int extraUberVehicleComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberVehicleComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberVehicleComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberVehicleLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMake(string new_value)
      {
        flagHasMake = true;
        storeMake = new_value;
      }
    public void unsetMake()
      {
        flagHasMake = false;
      }
    public void setModel(string new_value)
      {
        flagHasModel = true;
        storeModel = new_value;
      }
    public void unsetModel()
      {
        flagHasModel = false;
      }
    public void setLicensePlate(string new_value)
      {
        flagHasLicensePlate = true;
        storeLicensePlate = new_value;
      }
    public void unsetLicensePlate()
      {
        flagHasLicensePlate = false;
      }
    public void setPictureUrl(string new_value)
      {
        flagHasPictureUrl = true;
        storePictureUrl = new_value;
      }
    public void unsetPictureUrl()
      {
        flagHasPictureUrl = false;
      }
    public void setLatitude(double new_value)
      {
        flagHasLatitude = true;
        storeLatitude = new_value;
        textStoreLatitude = "";
      }
    public void setLatitudeText(string new_value)
      {
        flagHasLatitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Latitude of UberVehicleJSON is not a valid number.");
        textStoreLatitude = new_value;
      }
    public void unsetLatitude()
      {
        flagHasLatitude = false;
      }
    public void setLongitude(double new_value)
      {
        flagHasLongitude = true;
        storeLongitude = new_value;
        textStoreLongitude = "";
      }
    public void setLongitudeText(string new_value)
      {
        flagHasLongitude = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Longitude of UberVehicleJSON is not a valid number.");
        textStoreLongitude = new_value;
      }
    public void unsetLongitude()
      {
        flagHasLongitude = false;
      }
    public void setBearing(BigInteger new_value)
      {
        flagHasBearing = true;
        storeBearing = new_value;
      }
    public void unsetBearing()
      {
        flagHasBearing = false;
      }
    public void setDriver(UberDriverJSON  new_value)
      {
        if (flagHasDriver)
          {
          }
        flagHasDriver = true;
        storeDriver = new_value;
      }
    public void unsetDriver()
      {
        if (flagHasDriver)
          {
          }
        flagHasDriver = false;
      }

    public virtual void extraUberVehicleAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberVehicleSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberVehicleLookup(key);
        if (old_field == null)
          {
            extraUberVehicleAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMake);
        if (flagHasMake)
          {
            handler.start_pair("Make");
            handler.string_value(storeMake);
          }
        Debug.Assert(partial_allowed || flagHasModel);
        if (flagHasModel)
          {
            handler.start_pair("Model");
            handler.string_value(storeModel);
          }
        Debug.Assert(partial_allowed || flagHasLicensePlate);
        if (flagHasLicensePlate)
          {
            handler.start_pair("LicensePlate");
            handler.string_value(storeLicensePlate);
          }
        if (flagHasPictureUrl)
          {
            handler.start_pair("PictureUrl");
            handler.string_value(storePictureUrl);
          }
        Debug.Assert(partial_allowed || flagHasLatitude);
        if (flagHasLatitude)
          {
            handler.start_pair("Latitude");
            if (textStoreLatitude != "")
                handler.number_value(textStoreLatitude);
            else if (((double)(long)storeLatitude) == storeLatitude)
                handler.number_value((long)storeLatitude);
            else
                handler.number_value(storeLatitude);
          }
        Debug.Assert(partial_allowed || flagHasLongitude);
        if (flagHasLongitude)
          {
            handler.start_pair("Longitude");
            if (textStoreLongitude != "")
                handler.number_value(textStoreLongitude);
            else if (((double)(long)storeLongitude) == storeLongitude)
                handler.number_value((long)storeLongitude);
            else
                handler.number_value(storeLongitude);
          }
        Debug.Assert(partial_allowed || flagHasBearing);
        if (flagHasBearing)
          {
            handler.start_pair("Bearing");
            handler.number_value(storeBearing);
          }
        if (flagHasDriver)
          {
            handler.start_pair("Driver");
            if (partial_allowed)
                storeDriver.write_partial_as_json(handler);
            else
                storeDriver.write_as_json(handler);
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
        if (!(hasMake()))
          {
            return "When parsing the object for %what%, the \"Make\" field was missing.";
          }
        if (!(hasModel()))
          {
            return "When parsing the object for %what%, the \"Model\" field was missing.";
          }
        if (!(hasLicensePlate()))
          {
            return "When parsing the object for %what%, the \"LicensePlate\" field was missing.";
          }
        if (!(hasLatitude()))
          {
            return "When parsing the object for %what%, the \"Latitude\" field was missing.";
          }
        if (!(hasLongitude()))
          {
            return "When parsing the object for %what%, the \"Longitude\" field was missing.";
          }
        if (!(hasBearing()))
          {
            return "When parsing the object for %what%, the \"Bearing\" field was missing.";
          }
        return null;
      }

    public static UberVehicleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberVehicleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberVehicle", ignore_extras);
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
    public static UberVehicleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberVehicleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberVehicleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberVehicle", ignore_extras);
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
    public static UberVehicleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberVehicleJSON from_text(string text, bool ignore_extras)
      {
        UberVehicleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberVehicle", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberVehicleJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberVehicleJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberVehicleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberVehicle", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorMake;
        private JSONHoldingStringGenerator fieldGeneratorModel;
        private JSONHoldingStringGenerator fieldGeneratorLicensePlate;
        private JSONHoldingStringGenerator fieldGeneratorPictureUrl;
        private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
        private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
    private class FieldHoldingGeneratorBearing : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorBearing(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorBearing : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorBearing(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorBearing fieldGeneratorBearing;
        private UberDriverJSON.HoldingGenerator fieldGeneratorDriver;
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
            UberVehicleJSON result = new UberVehicleJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberVehicleAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberVehicleJSON result)
          {
            if (fieldGeneratorMake.have_value)
              {
                result.setMake(fieldGeneratorMake.value);
                fieldGeneratorMake.have_value = false;
              }
            else if ((!(result.hasMake())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Make\" field was missing.");
              }
            if (fieldGeneratorModel.have_value)
              {
                result.setModel(fieldGeneratorModel.value);
                fieldGeneratorModel.have_value = false;
              }
            else if ((!(result.hasModel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Model\" field was missing.");
              }
            if (fieldGeneratorLicensePlate.have_value)
              {
                result.setLicensePlate(fieldGeneratorLicensePlate.value);
                fieldGeneratorLicensePlate.have_value = false;
              }
            else if ((!(result.hasLicensePlate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LicensePlate\" field was missing.");
              }
            if (fieldGeneratorPictureUrl.have_value)
              {
                result.setPictureUrl(fieldGeneratorPictureUrl.value);
                fieldGeneratorPictureUrl.have_value = false;
              }
            if (fieldGeneratorLatitude.have_value)
              {
                result.setLatitudeText(fieldGeneratorLatitude.value);
                fieldGeneratorLatitude.have_value = false;
              }
            else if ((!(result.hasLatitude())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Latitude\" field was missing.");
              }
            if (fieldGeneratorLongitude.have_value)
              {
                result.setLongitudeText(fieldGeneratorLongitude.value);
                fieldGeneratorLongitude.have_value = false;
              }
            else if ((!(result.hasLongitude())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Longitude\" field was missing.");
              }
            if (fieldGeneratorBearing.have_value)
              {
                result.setBearing(fieldGeneratorBearing.value);
                fieldGeneratorBearing.have_value = false;
              }
            else if ((!(result.hasBearing())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Bearing\" field was missing.");
              }
            if (fieldGeneratorDriver.have_value)
              {
                result.setDriver(fieldGeneratorDriver.value);
                fieldGeneratorDriver.have_value = false;
              }
          }
        protected abstract void handle_result(UberVehicleJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "earing", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorBearing;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "river", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorDriver;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorLatitude;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "censePlate", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorLicensePlate;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorLongitude;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ke", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorMake;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "del", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorModel;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ictureUrl", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPictureUrl;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMake = new JSONHoldingStringGenerator("field \"Make\" of the UberVehicle class");
            fieldGeneratorModel = new JSONHoldingStringGenerator("field \"Model\" of the UberVehicle class");
            fieldGeneratorLicensePlate = new JSONHoldingStringGenerator("field \"LicensePlate\" of the UberVehicle class");
            fieldGeneratorPictureUrl = new JSONHoldingStringGenerator("field \"PictureUrl\" of the UberVehicle class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the UberVehicle class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the UberVehicle class");
            fieldGeneratorBearing = new FieldHoldingGeneratorBearing("field \"Bearing\" of the UberVehicle class");
            fieldGeneratorDriver = new UberDriverJSON.HoldingGenerator("field \"Driver\" of the UberVehicle class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberVehicle class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMake = new JSONHoldingStringGenerator("field \"Make\" of the UberVehicle class");
            fieldGeneratorModel = new JSONHoldingStringGenerator("field \"Model\" of the UberVehicle class");
            fieldGeneratorLicensePlate = new JSONHoldingStringGenerator("field \"LicensePlate\" of the UberVehicle class");
            fieldGeneratorPictureUrl = new JSONHoldingStringGenerator("field \"PictureUrl\" of the UberVehicle class");
            fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the UberVehicle class");
            fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the UberVehicle class");
            fieldGeneratorBearing = new FieldHoldingGeneratorBearing("field \"Bearing\" of the UberVehicle class");
            fieldGeneratorDriver = new UberDriverJSON.HoldingGenerator("field \"Driver\" of the UberVehicle class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberVehicle class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMake.reset();
            fieldGeneratorModel.reset();
            fieldGeneratorLicensePlate.reset();
            fieldGeneratorPictureUrl.reset();
            fieldGeneratorLatitude.reset();
            fieldGeneratorLongitude.reset();
            fieldGeneratorBearing.reset();
            fieldGeneratorDriver.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDriver.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDriver.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberVehicleJSON  result)
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
        public UberVehicleJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberVehicleJSON  result)
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
    protected virtual void handle_result(List<UberVehicleJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberVehicleJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberVehicleJSON>();
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
    public List<UberVehicleJSON> value;
  };
  };
