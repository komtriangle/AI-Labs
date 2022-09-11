/* file "AlertJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AlertJSON : JSONBase
  {
    private bool flagHasType;
    private string storeType;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasMessage;
    private string storeMessage;
    private bool flagHasLevelMeteoalarmName;
    private string storeLevelMeteoalarmName;
    private bool flagHasWtypeMeteoalarmName;
    private string storeWtypeMeteoalarmName;
    private bool flagHasAttribution;
    private string storeAttribution;
    private bool flagHasPhenomena;
    private string storePhenomena;
    private bool flagHasSignificance;
    private string storeSignificance;
    private bool flagHasStartDateAndTime;
    private DateAndOrTimeJSON  storeStartDateAndTime;
    private bool flagHasEndDateAndTime;
    private DateAndOrTimeJSON  storeEndDateAndTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Type of AlertJSON is not a string.");
        setType(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of AlertJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Message of AlertJSON is not a string.");
        setMessage(json_string.getData());
      }


    private void  fromJSONLevelMeteoalarmName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LevelMeteoalarmName of AlertJSON is not a string.");
        setLevelMeteoalarmName(json_string.getData());
      }


    private void  fromJSONWtypeMeteoalarmName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WtypeMeteoalarmName of AlertJSON is not a string.");
        setWtypeMeteoalarmName(json_string.getData());
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Attribution of AlertJSON is not a string.");
        setAttribution(json_string.getData());
      }


    private void  fromJSONPhenomena(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Phenomena of AlertJSON is not a string.");
        setPhenomena(json_string.getData());
      }


    private void  fromJSONSignificance(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Significance of AlertJSON is not a string.");
        setSignificance(json_string.getData());
      }


    private void  fromJSONStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartDateAndTime(convert_classy);
      }


    private void  fromJSONEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEndDateAndTime(convert_classy);
      }


    public AlertJSON()
      {
        flagHasType = false;
        flagHasDescription = false;
        flagHasMessage = false;
        flagHasLevelMeteoalarmName = false;
        flagHasWtypeMeteoalarmName = false;
        flagHasAttribution = false;
        flagHasPhenomena = false;
        flagHasSignificance = false;
        flagHasStartDateAndTime = false;
        flagHasEndDateAndTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public string  getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasMessage()
      {
        return flagHasMessage;
      }

    public string  getMessage()
      {
        Debug.Assert(flagHasMessage);
        return storeMessage;
      }

    public bool  hasLevelMeteoalarmName()
      {
        return flagHasLevelMeteoalarmName;
      }

    public string  getLevelMeteoalarmName()
      {
        Debug.Assert(flagHasLevelMeteoalarmName);
        return storeLevelMeteoalarmName;
      }

    public bool  hasWtypeMeteoalarmName()
      {
        return flagHasWtypeMeteoalarmName;
      }

    public string  getWtypeMeteoalarmName()
      {
        Debug.Assert(flagHasWtypeMeteoalarmName);
        return storeWtypeMeteoalarmName;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public string  getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasPhenomena()
      {
        return flagHasPhenomena;
      }

    public string  getPhenomena()
      {
        Debug.Assert(flagHasPhenomena);
        return storePhenomena;
      }

    public bool  hasSignificance()
      {
        return flagHasSignificance;
      }

    public string  getSignificance()
      {
        Debug.Assert(flagHasSignificance);
        return storeSignificance;
      }

    public bool  hasStartDateAndTime()
      {
        return flagHasStartDateAndTime;
      }

    public DateAndOrTimeJSON   getStartDateAndTime()
      {
        Debug.Assert(flagHasStartDateAndTime);
        return storeStartDateAndTime;
      }

    public bool  hasEndDateAndTime()
      {
        return flagHasEndDateAndTime;
      }

    public DateAndOrTimeJSON   getEndDateAndTime()
      {
        Debug.Assert(flagHasEndDateAndTime);
        return storeEndDateAndTime;
      }


    public virtual int extraAlertComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAlertComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAlertComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAlertLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(string new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void unsetType()
      {
        flagHasType = false;
      }
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setMessage(string new_value)
      {
        flagHasMessage = true;
        storeMessage = new_value;
      }
    public void unsetMessage()
      {
        flagHasMessage = false;
      }
    public void setLevelMeteoalarmName(string new_value)
      {
        flagHasLevelMeteoalarmName = true;
        storeLevelMeteoalarmName = new_value;
      }
    public void unsetLevelMeteoalarmName()
      {
        flagHasLevelMeteoalarmName = false;
      }
    public void setWtypeMeteoalarmName(string new_value)
      {
        flagHasWtypeMeteoalarmName = true;
        storeWtypeMeteoalarmName = new_value;
      }
    public void unsetWtypeMeteoalarmName()
      {
        flagHasWtypeMeteoalarmName = false;
      }
    public void setAttribution(string new_value)
      {
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        flagHasAttribution = false;
      }
    public void setPhenomena(string new_value)
      {
        flagHasPhenomena = true;
        storePhenomena = new_value;
      }
    public void unsetPhenomena()
      {
        flagHasPhenomena = false;
      }
    public void setSignificance(string new_value)
      {
        flagHasSignificance = true;
        storeSignificance = new_value;
      }
    public void unsetSignificance()
      {
        flagHasSignificance = false;
      }
    public void setStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = true;
        storeStartDateAndTime = new_value;
      }
    public void unsetStartDateAndTime()
      {
        if (flagHasStartDateAndTime)
          {
          }
        flagHasStartDateAndTime = false;
      }
    public void setEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = true;
        storeEndDateAndTime = new_value;
      }
    public void unsetEndDateAndTime()
      {
        if (flagHasEndDateAndTime)
          {
          }
        flagHasEndDateAndTime = false;
      }

    public virtual void extraAlertAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAlertSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAlertLookup(key);
        if (old_field == null)
          {
            extraAlertAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasType);
        if (flagHasType)
          {
            handler.start_pair("Type");
            handler.string_value(storeType);
          }
        Debug.Assert(partial_allowed || flagHasDescription);
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        Debug.Assert(partial_allowed || flagHasMessage);
        if (flagHasMessage)
          {
            handler.start_pair("Message");
            handler.string_value(storeMessage);
          }
        if (flagHasLevelMeteoalarmName)
          {
            handler.start_pair("LevelMeteoalarmName");
            handler.string_value(storeLevelMeteoalarmName);
          }
        if (flagHasWtypeMeteoalarmName)
          {
            handler.start_pair("WtypeMeteoalarmName");
            handler.string_value(storeWtypeMeteoalarmName);
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            handler.string_value(storeAttribution);
          }
        if (flagHasPhenomena)
          {
            handler.start_pair("Phenomena");
            handler.string_value(storePhenomena);
          }
        if (flagHasSignificance)
          {
            handler.start_pair("Significance");
            handler.string_value(storeSignificance);
          }
        Debug.Assert(partial_allowed || flagHasStartDateAndTime);
        if (flagHasStartDateAndTime)
          {
            handler.start_pair("StartDateAndTime");
            if (partial_allowed)
                storeStartDateAndTime.write_partial_as_json(handler);
            else
                storeStartDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEndDateAndTime);
        if (flagHasEndDateAndTime)
          {
            handler.start_pair("EndDateAndTime");
            if (partial_allowed)
                storeEndDateAndTime.write_partial_as_json(handler);
            else
                storeEndDateAndTime.write_as_json(handler);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        if (!(hasDescription()))
          {
            return "When parsing the object for %what%, the \"Description\" field was missing.";
          }
        if (!(hasMessage()))
          {
            return "When parsing the object for %what%, the \"Message\" field was missing.";
          }
        if (!(hasStartDateAndTime()))
          {
            return "When parsing the object for %what%, the \"StartDateAndTime\" field was missing.";
          }
        if (!(hasEndDateAndTime()))
          {
            return "When parsing the object for %what%, the \"EndDateAndTime\" field was missing.";
          }
        return null;
      }

    public static AlertJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlertJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alert", ignore_extras);
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
    public static AlertJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AlertJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlertJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alert", ignore_extras);
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
    public static AlertJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AlertJSON from_text(string text, bool ignore_extras)
      {
        AlertJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alert", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AlertJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AlertJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AlertJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alert", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorType;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorMessage;
        private JSONHoldingStringGenerator fieldGeneratorLevelMeteoalarmName;
        private JSONHoldingStringGenerator fieldGeneratorWtypeMeteoalarmName;
        private JSONHoldingStringGenerator fieldGeneratorAttribution;
        private JSONHoldingStringGenerator fieldGeneratorPhenomena;
        private JSONHoldingStringGenerator fieldGeneratorSignificance;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndTime;
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
            AlertJSON result = new AlertJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAlertAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AlertJSON result)
          {
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            else if ((!(result.hasType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Type\" field was missing.");
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            else if ((!(result.hasDescription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Description\" field was missing.");
              }
            if (fieldGeneratorMessage.have_value)
              {
                result.setMessage(fieldGeneratorMessage.value);
                fieldGeneratorMessage.have_value = false;
              }
            else if ((!(result.hasMessage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Message\" field was missing.");
              }
            if (fieldGeneratorLevelMeteoalarmName.have_value)
              {
                result.setLevelMeteoalarmName(fieldGeneratorLevelMeteoalarmName.value);
                fieldGeneratorLevelMeteoalarmName.have_value = false;
              }
            if (fieldGeneratorWtypeMeteoalarmName.have_value)
              {
                result.setWtypeMeteoalarmName(fieldGeneratorWtypeMeteoalarmName.value);
                fieldGeneratorWtypeMeteoalarmName.have_value = false;
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorPhenomena.have_value)
              {
                result.setPhenomena(fieldGeneratorPhenomena.value);
                fieldGeneratorPhenomena.have_value = false;
              }
            if (fieldGeneratorSignificance.have_value)
              {
                result.setSignificance(fieldGeneratorSignificance.value);
                fieldGeneratorSignificance.have_value = false;
              }
            if (fieldGeneratorStartDateAndTime.have_value)
              {
                result.setStartDateAndTime(fieldGeneratorStartDateAndTime.value);
                fieldGeneratorStartDateAndTime.have_value = false;
              }
            else if ((!(result.hasStartDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateAndTime\" field was missing.");
              }
            if (fieldGeneratorEndDateAndTime.have_value)
              {
                result.setEndDateAndTime(fieldGeneratorEndDateAndTime.value);
                fieldGeneratorEndDateAndTime.have_value = false;
              }
            else if ((!(result.hasEndDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateAndTime\" field was missing.");
              }
          }
        protected abstract void handle_result(AlertJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ndDateAndTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorEndDateAndTime;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "evelMeteoalarmName", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorLevelMeteoalarmName;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "essage", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorMessage;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "henomena", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorPhenomena;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "gnificance", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorSignificance;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "artDateAndTime", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorStartDateAndTime;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "typeMeteoalarmName", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorWtypeMeteoalarmName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the Alert class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Alert class");
            fieldGeneratorMessage = new JSONHoldingStringGenerator("field \"Message\" of the Alert class");
            fieldGeneratorLevelMeteoalarmName = new JSONHoldingStringGenerator("field \"LevelMeteoalarmName\" of the Alert class");
            fieldGeneratorWtypeMeteoalarmName = new JSONHoldingStringGenerator("field \"WtypeMeteoalarmName\" of the Alert class");
            fieldGeneratorAttribution = new JSONHoldingStringGenerator("field \"Attribution\" of the Alert class");
            fieldGeneratorPhenomena = new JSONHoldingStringGenerator("field \"Phenomena\" of the Alert class");
            fieldGeneratorSignificance = new JSONHoldingStringGenerator("field \"Significance\" of the Alert class");
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the Alert class", ignore_extras);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the Alert class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Alert class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the Alert class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Alert class");
            fieldGeneratorMessage = new JSONHoldingStringGenerator("field \"Message\" of the Alert class");
            fieldGeneratorLevelMeteoalarmName = new JSONHoldingStringGenerator("field \"LevelMeteoalarmName\" of the Alert class");
            fieldGeneratorWtypeMeteoalarmName = new JSONHoldingStringGenerator("field \"WtypeMeteoalarmName\" of the Alert class");
            fieldGeneratorAttribution = new JSONHoldingStringGenerator("field \"Attribution\" of the Alert class");
            fieldGeneratorPhenomena = new JSONHoldingStringGenerator("field \"Phenomena\" of the Alert class");
            fieldGeneratorSignificance = new JSONHoldingStringGenerator("field \"Significance\" of the Alert class");
            fieldGeneratorStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndTime\" of the Alert class", false);
            fieldGeneratorEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndTime\" of the Alert class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Alert class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorMessage.reset();
            fieldGeneratorLevelMeteoalarmName.reset();
            fieldGeneratorWtypeMeteoalarmName.reset();
            fieldGeneratorAttribution.reset();
            fieldGeneratorPhenomena.reset();
            fieldGeneratorSignificance.reset();
            fieldGeneratorStartDateAndTime.reset();
            fieldGeneratorEndDateAndTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEndDateAndTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEndDateAndTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AlertJSON  result)
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
        public AlertJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AlertJSON  result)
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
    protected virtual void handle_result(List<AlertJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AlertJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AlertJSON>();
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
    public List<AlertJSON> value;
  };
  };
