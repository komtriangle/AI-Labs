/* file "RadioControlTunableStationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RadioControlTunableStationJSON : JSONBase
  {
    private bool flagHasStationUID;
    private uint storeStationUID;
    private bool flagHasPI;
    private string storePI;
    private bool flagHasSI;
    private string storeSI;
    private bool flagHasName;
    private string storeName;
    private bool flagHasECC;
    private string storeECC;
    private bool flagHasRecordID;
    private int storeRecordID;
    private bool flagHasProgramType;
    private sbyte storeProgramType;
    private bool flagHasReceptionStrength;
    private byte storeReceptionStrength;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStationUID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        uint extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StationUID of RadioControlTunableStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StationUID of RadioControlTunableStationJSON is not an integer.");
              }
            extracted_integer = (uint)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (uint)(json_integer.getLongInt())        ;
          }
        setStationUID(extracted_integer);
      }


    private void  fromJSONPI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PI of RadioControlTunableStationJSON is not a string.");
        setPI(json_string.getData());
      }


    private void  fromJSONSI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SI of RadioControlTunableStationJSON is not a string.");
        setSI(json_string.getData());
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of RadioControlTunableStationJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONECC(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ECC of RadioControlTunableStationJSON is not a string.");
        setECC(json_string.getData());
      }


    private void  fromJSONRecordID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        int extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RecordID of RadioControlTunableStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecordID of RadioControlTunableStationJSON is not an integer.");
              }
            extracted_integer = (int)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (int)(json_integer.getLongInt())        ;
          }
        setRecordID(extracted_integer);
      }


    private void  fromJSONProgramType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProgramType of RadioControlTunableStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProgramType of RadioControlTunableStationJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setProgramType(extracted_integer);
      }


    private void  fromJSONReceptionStrength(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        byte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReceptionStrength of RadioControlTunableStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReceptionStrength of RadioControlTunableStationJSON is not an integer.");
              }
            extracted_integer = (byte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (byte)(json_integer.getLongInt())        ;
          }
        setReceptionStrength(extracted_integer);
      }


    public RadioControlTunableStationJSON()
      {
        flagHasStationUID = false;
        flagHasPI = false;
        flagHasSI = false;
        flagHasName = false;
        flagHasECC = false;
        flagHasRecordID = false;
        flagHasProgramType = false;
        flagHasReceptionStrength = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStationUID()
      {
        return flagHasStationUID;
      }

    public uint  getStationUID()
      {
        Debug.Assert(flagHasStationUID);
        return storeStationUID;
      }

    public bool  hasPI()
      {
        return flagHasPI;
      }

    public string  getPI()
      {
        Debug.Assert(flagHasPI);
        return storePI;
      }

    public bool  hasSI()
      {
        return flagHasSI;
      }

    public string  getSI()
      {
        Debug.Assert(flagHasSI);
        return storeSI;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasECC()
      {
        return flagHasECC;
      }

    public string  getECC()
      {
        Debug.Assert(flagHasECC);
        return storeECC;
      }

    public bool  hasRecordID()
      {
        return flagHasRecordID;
      }

    public int  getRecordID()
      {
        Debug.Assert(flagHasRecordID);
        return storeRecordID;
      }

    public bool  hasProgramType()
      {
        return flagHasProgramType;
      }

    public sbyte  getProgramType()
      {
        Debug.Assert(flagHasProgramType);
        return storeProgramType;
      }

    public bool  hasReceptionStrength()
      {
        return flagHasReceptionStrength;
      }

    public byte  getReceptionStrength()
      {
        Debug.Assert(flagHasReceptionStrength);
        return storeReceptionStrength;
      }


    public virtual int extraRadioControlTunableStationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioControlTunableStationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioControlTunableStationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioControlTunableStationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStationUID(uint new_value)
      {
        flagHasStationUID = true;
        if (new_value < 0)
            throw new Exception("The value for field StationUID of RadioControlTunableStationJSON is less than the lower bound (0) for that field.");
        if (new_value > 4294967295)
            throw new Exception("The value for field StationUID of RadioControlTunableStationJSON is greater than the upper bound (4294967295) for that field.");
        storeStationUID = new_value;
      }
    public void unsetStationUID()
      {
        flagHasStationUID = false;
      }
    public void setPI(string new_value)
      {
        flagHasPI = true;
        storePI = new_value;
      }
    public void unsetPI()
      {
        flagHasPI = false;
      }
    public void setSI(string new_value)
      {
        flagHasSI = true;
        storeSI = new_value;
      }
    public void unsetSI()
      {
        flagHasSI = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setECC(string new_value)
      {
        flagHasECC = true;
        storeECC = new_value;
      }
    public void unsetECC()
      {
        flagHasECC = false;
      }
    public void setRecordID(int new_value)
      {
        flagHasRecordID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecordID of RadioControlTunableStationJSON is less than the lower bound (0) for that field.");
        if (new_value > 1000000)
            throw new Exception("The value for field RecordID of RadioControlTunableStationJSON is greater than the upper bound (1000000) for that field.");
        storeRecordID = new_value;
      }
    public void unsetRecordID()
      {
        flagHasRecordID = false;
      }
    public void setProgramType(sbyte new_value)
      {
        flagHasProgramType = true;
        if (new_value < 0)
            throw new Exception("The value for field ProgramType of RadioControlTunableStationJSON is less than the lower bound (0) for that field.");
        if (new_value > 31)
            throw new Exception("The value for field ProgramType of RadioControlTunableStationJSON is greater than the upper bound (31) for that field.");
        storeProgramType = new_value;
      }
    public void unsetProgramType()
      {
        flagHasProgramType = false;
      }
    public void setReceptionStrength(byte new_value)
      {
        flagHasReceptionStrength = true;
        if (new_value < 0)
            throw new Exception("The value for field ReceptionStrength of RadioControlTunableStationJSON is less than the lower bound (0) for that field.");
        if (new_value > 255)
            throw new Exception("The value for field ReceptionStrength of RadioControlTunableStationJSON is greater than the upper bound (255) for that field.");
        storeReceptionStrength = new_value;
      }
    public void unsetReceptionStrength()
      {
        flagHasReceptionStrength = false;
      }

    public virtual void extraRadioControlTunableStationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioControlTunableStationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioControlTunableStationLookup(key);
        if (old_field == null)
          {
            extraRadioControlTunableStationAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStationUID);
        if (flagHasStationUID)
          {
            handler.start_pair("StationUID");
            handler.number_value(storeStationUID);
          }
        if (flagHasPI)
          {
            handler.start_pair("PI");
            handler.string_value(storePI);
          }
        if (flagHasSI)
          {
            handler.start_pair("SI");
            handler.string_value(storeSI);
          }
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasECC)
          {
            handler.start_pair("ECC");
            handler.string_value(storeECC);
          }
        if (flagHasRecordID)
          {
            handler.start_pair("RecordID");
            handler.number_value(storeRecordID);
          }
        if (flagHasProgramType)
          {
            handler.start_pair("ProgramType");
            handler.number_value(storeProgramType);
          }
        if (flagHasReceptionStrength)
          {
            handler.start_pair("ReceptionStrength");
            handler.number_value(storeReceptionStrength);
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
        if (!(hasStationUID()))
          {
            return "When parsing the object for %what%, the \"StationUID\" field was missing.";
          }
        return null;
      }

    public static RadioControlTunableStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioControlTunableStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlTunableStation", ignore_extras);
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
    public static RadioControlTunableStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioControlTunableStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioControlTunableStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlTunableStation", ignore_extras);
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
    public static RadioControlTunableStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioControlTunableStationJSON from_text(string text, bool ignore_extras)
      {
        RadioControlTunableStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlTunableStation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioControlTunableStationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RadioControlTunableStationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioControlTunableStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioControlTunableStation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorStationUID : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorStationUID(String what) : base(what, 0, 4294967295L)
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationUID : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationUID(String what) : base(what, 0, 4294967295L)
              {
              }
          };
        private FieldHoldingGeneratorStationUID fieldGeneratorStationUID;
        private JSONHoldingStringGenerator fieldGeneratorPI;
        private JSONHoldingStringGenerator fieldGeneratorSI;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorECC;
    private class FieldHoldingGeneratorRecordID : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorRecordID(String what) : base(what, 0, 1000000)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRecordID : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRecordID(String what) : base(what, 0, 1000000)
              {
              }
          };
        private FieldHoldingGeneratorRecordID fieldGeneratorRecordID;
    private class FieldHoldingGeneratorProgramType : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorProgramType(String what) : base(what, 0, 31)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProgramType : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProgramType(String what) : base(what, 0, 31)
              {
              }
          };
        private FieldHoldingGeneratorProgramType fieldGeneratorProgramType;
    private class FieldHoldingGeneratorReceptionStrength : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorReceptionStrength(String what) : base(what, 0, 255)
              {
              }
          };
    private class FieldHoldingArrayGeneratorReceptionStrength : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorReceptionStrength(String what) : base(what, 0, 255)
              {
              }
          };
        private FieldHoldingGeneratorReceptionStrength fieldGeneratorReceptionStrength;
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
            RadioControlTunableStationJSON result = new RadioControlTunableStationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioControlTunableStationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RadioControlTunableStationJSON result)
          {
            if (fieldGeneratorStationUID.have_value)
              {
                result.setStationUID((uint)(fieldGeneratorStationUID.value));
                fieldGeneratorStationUID.have_value = false;
              }
            else if ((!(result.hasStationUID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StationUID\" field was missing.");
              }
            if (fieldGeneratorPI.have_value)
              {
                result.setPI(fieldGeneratorPI.value);
                fieldGeneratorPI.have_value = false;
              }
            if (fieldGeneratorSI.have_value)
              {
                result.setSI(fieldGeneratorSI.value);
                fieldGeneratorSI.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorECC.have_value)
              {
                result.setECC(fieldGeneratorECC.value);
                fieldGeneratorECC.have_value = false;
              }
            if (fieldGeneratorRecordID.have_value)
              {
                result.setRecordID((int)(fieldGeneratorRecordID.value));
                fieldGeneratorRecordID.have_value = false;
              }
            if (fieldGeneratorProgramType.have_value)
              {
                result.setProgramType((sbyte)(fieldGeneratorProgramType.value));
                fieldGeneratorProgramType.have_value = false;
              }
            if (fieldGeneratorReceptionStrength.have_value)
              {
                result.setReceptionStrength((byte)(fieldGeneratorReceptionStrength.value));
                fieldGeneratorReceptionStrength.have_value = false;
              }
          }
        protected abstract void handle_result(RadioControlTunableStationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "CC", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorECC;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'I':
                            if (field_name.Length == 2)
                                return fieldGeneratorPI;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ogramType", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorProgramType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ec", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 4, "ptionStrength", 0, 13, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorReceptionStrength;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 4, "rdID", 0, 4, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorRecordID;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'I':
                            if (field_name.Length == 2)
                                return fieldGeneratorSI;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ationUID", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorStationUID;
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
            fieldGeneratorStationUID = new FieldHoldingGeneratorStationUID("field \"StationUID\" of the RadioControlTunableStation class");
            fieldGeneratorPI = new JSONHoldingStringGenerator("field \"PI\" of the RadioControlTunableStation class");
            fieldGeneratorSI = new JSONHoldingStringGenerator("field \"SI\" of the RadioControlTunableStation class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the RadioControlTunableStation class");
            fieldGeneratorECC = new JSONHoldingStringGenerator("field \"ECC\" of the RadioControlTunableStation class");
            fieldGeneratorRecordID = new FieldHoldingGeneratorRecordID("field \"RecordID\" of the RadioControlTunableStation class");
            fieldGeneratorProgramType = new FieldHoldingGeneratorProgramType("field \"ProgramType\" of the RadioControlTunableStation class");
            fieldGeneratorReceptionStrength = new FieldHoldingGeneratorReceptionStrength("field \"ReceptionStrength\" of the RadioControlTunableStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioControlTunableStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStationUID = new FieldHoldingGeneratorStationUID("field \"StationUID\" of the RadioControlTunableStation class");
            fieldGeneratorPI = new JSONHoldingStringGenerator("field \"PI\" of the RadioControlTunableStation class");
            fieldGeneratorSI = new JSONHoldingStringGenerator("field \"SI\" of the RadioControlTunableStation class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the RadioControlTunableStation class");
            fieldGeneratorECC = new JSONHoldingStringGenerator("field \"ECC\" of the RadioControlTunableStation class");
            fieldGeneratorRecordID = new FieldHoldingGeneratorRecordID("field \"RecordID\" of the RadioControlTunableStation class");
            fieldGeneratorProgramType = new FieldHoldingGeneratorProgramType("field \"ProgramType\" of the RadioControlTunableStation class");
            fieldGeneratorReceptionStrength = new FieldHoldingGeneratorReceptionStrength("field \"ReceptionStrength\" of the RadioControlTunableStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioControlTunableStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStationUID.reset();
            fieldGeneratorPI.reset();
            fieldGeneratorSI.reset();
            fieldGeneratorName.reset();
            fieldGeneratorECC.reset();
            fieldGeneratorRecordID.reset();
            fieldGeneratorProgramType.reset();
            fieldGeneratorReceptionStrength.reset();
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
        protected override void handle_result(RadioControlTunableStationJSON  result)
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
        public RadioControlTunableStationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioControlTunableStationJSON  result)
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
    protected virtual void handle_result(List<RadioControlTunableStationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioControlTunableStationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioControlTunableStationJSON>();
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
    public List<RadioControlTunableStationJSON> value;
  };
  };
