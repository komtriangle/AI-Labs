/* file "AstronomyDistanceFromEarthCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AstronomyDistanceFromEarthCommandJSON : CommandResultJSON
  {
    private bool flagHasObjectName;
    private string storeObjectName;
    private bool flagHasMinimumDistanceMiles;
    private double storeMinimumDistanceMiles;
    private string textStoreMinimumDistanceMiles;
    private bool flagHasMaximumDistanceMiles;
    private double storeMaximumDistanceMiles;
    private string textStoreMaximumDistanceMiles;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraObjectNameToJSON()
      {
        JSONStringValue generated_string_ObjectName = new JSONStringValue(storeObjectName);
        return generated_string_ObjectName;
      }

    private JSONValue  extraMinimumDistanceMilesToJSON()
      {
        JSONValue generated_rational_MinimumDistanceMiles;
        if (textStoreMinimumDistanceMiles != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreMinimumDistanceMiles);
            generated_rational_MinimumDistanceMiles = handler.result;
          }
        else if (((double)(long)storeMinimumDistanceMiles) == storeMinimumDistanceMiles)
            generated_rational_MinimumDistanceMiles = new JSONIntegerValue((long)(storeMinimumDistanceMiles));
        else
            generated_rational_MinimumDistanceMiles = new JSONRationalValue(storeMinimumDistanceMiles, 15);
        return generated_rational_MinimumDistanceMiles;
      }

    private JSONValue  extraMaximumDistanceMilesToJSON()
      {
        JSONValue generated_rational_MaximumDistanceMiles;
        if (textStoreMaximumDistanceMiles != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreMaximumDistanceMiles);
            generated_rational_MaximumDistanceMiles = handler.result;
          }
        else if (((double)(long)storeMaximumDistanceMiles) == storeMaximumDistanceMiles)
            generated_rational_MaximumDistanceMiles = new JSONIntegerValue((long)(storeMaximumDistanceMiles));
        else
            generated_rational_MaximumDistanceMiles = new JSONRationalValue(storeMaximumDistanceMiles, 15);
        return generated_rational_MaximumDistanceMiles;
      }


    private void  fromJSONObjectName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ObjectName of AstronomyDistanceFromEarthCommandJSON is not a string.");
        setObjectName(json_string.getData());
      }


    private void  fromJSONMinimumDistanceMiles(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MinimumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is not a number.");
              }
          }
        setMinimumDistanceMilesText(the_rational_text);
      }


    private void  fromJSONMaximumDistanceMiles(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MaximumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is not a number.");
              }
          }
        setMaximumDistanceMilesText(the_rational_text);
      }


    public AstronomyDistanceFromEarthCommandJSON()
      {
        flagHasObjectName = false;
        flagHasMinimumDistanceMiles = false;
        flagHasMaximumDistanceMiles = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "AstronomyDistanceFromEarthCommand";
      }

    public bool  hasObjectName()
      {
        return flagHasObjectName;
      }

    public string  getObjectName()
      {
        Debug.Assert(flagHasObjectName);
        return storeObjectName;
      }

    public bool  hasMinimumDistanceMiles()
      {
        return flagHasMinimumDistanceMiles;
      }

    public double  getMinimumDistanceMiles()
      {
        Debug.Assert(flagHasMinimumDistanceMiles);
        if (textStoreMinimumDistanceMiles != "")
          {
            return Double.Parse(textStoreMinimumDistanceMiles);
          }
        return storeMinimumDistanceMiles;
      }

    public string  getMinimumDistanceMilesAsText()
      {
        Debug.Assert(flagHasMinimumDistanceMiles);
        if (textStoreMinimumDistanceMiles == "")
          {
            return Convert.ToString(storeMinimumDistanceMiles);
          }
        else
          {
            return (textStoreMinimumDistanceMiles);
          }
      }

    public bool  hasMaximumDistanceMiles()
      {
        return flagHasMaximumDistanceMiles;
      }

    public double  getMaximumDistanceMiles()
      {
        Debug.Assert(flagHasMaximumDistanceMiles);
        if (textStoreMaximumDistanceMiles != "")
          {
            return Double.Parse(textStoreMaximumDistanceMiles);
          }
        return storeMaximumDistanceMiles;
      }

    public string  getMaximumDistanceMilesAsText()
      {
        Debug.Assert(flagHasMaximumDistanceMiles);
        if (textStoreMaximumDistanceMiles == "")
          {
            return Convert.ToString(storeMaximumDistanceMiles);
          }
        else
          {
            return (textStoreMaximumDistanceMiles);
          }
      }


    public virtual int extraAstronomyDistanceFromEarthCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAstronomyDistanceFromEarthCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAstronomyDistanceFromEarthCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAstronomyDistanceFromEarthCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasObjectName)
            ++result;
        if (flagHasMinimumDistanceMiles)
            ++result;
        if (flagHasMaximumDistanceMiles)
            ++result;
        result += extraAstronomyDistanceFromEarthCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasObjectName)
          {
            if (remainder == 0)
                return "ObjectName";
            --remainder;
          }
        if (flagHasMinimumDistanceMiles)
          {
            if (remainder == 0)
                return "MinimumDistanceMiles";
            --remainder;
          }
        if (flagHasMaximumDistanceMiles)
          {
            if (remainder == 0)
                return "MaximumDistanceMiles";
            --remainder;
          }
        return extraAstronomyDistanceFromEarthCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasObjectName)
          {
            if (remainder == 0)
                return extraObjectNameToJSON();
            --remainder;
          }
        if (flagHasMinimumDistanceMiles)
          {
            if (remainder == 0)
                return extraMinimumDistanceMilesToJSON();
            --remainder;
          }
        if (flagHasMaximumDistanceMiles)
          {
            if (remainder == 0)
                return extraMaximumDistanceMilesToJSON();
            --remainder;
          }
        return extraAstronomyDistanceFromEarthCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ximumDistanceMiles", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasMaximumDistanceMiles ? extraMaximumDistanceMilesToJSON() : null);
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "nimumDistanceMiles", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasMinimumDistanceMiles ? extraMinimumDistanceMilesToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "bjectName", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasObjectName ? extraObjectNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraAstronomyDistanceFromEarthCommandLookup(field_name);
      }

    public void setObjectName(string new_value)
      {
        flagHasObjectName = true;
        storeObjectName = new_value;
      }
    public void unsetObjectName()
      {
        flagHasObjectName = false;
      }
    public void setMinimumDistanceMiles(double new_value)
      {
        flagHasMinimumDistanceMiles = true;
        if (new_value < 0)
            throw new Exception("The value for field MinimumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is less than the lower bound (0) for that field.");
        storeMinimumDistanceMiles = new_value;
        textStoreMinimumDistanceMiles = "";
      }
    public void setMinimumDistanceMilesText(string new_value)
      {
        flagHasMinimumDistanceMiles = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MinimumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MinimumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is less than the lower bound (0) for that field.");
        textStoreMinimumDistanceMiles = new_value;
      }
    public void unsetMinimumDistanceMiles()
      {
        flagHasMinimumDistanceMiles = false;
      }
    public void setMaximumDistanceMiles(double new_value)
      {
        flagHasMaximumDistanceMiles = true;
        if (new_value < 0)
            throw new Exception("The value for field MaximumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is less than the lower bound (0) for that field.");
        storeMaximumDistanceMiles = new_value;
        textStoreMaximumDistanceMiles = "";
      }
    public void setMaximumDistanceMilesText(string new_value)
      {
        flagHasMaximumDistanceMiles = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MaximumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field MaximumDistanceMiles of AstronomyDistanceFromEarthCommandJSON is less than the lower bound (0) for that field.");
        textStoreMaximumDistanceMiles = new_value;
      }
    public void unsetMaximumDistanceMiles()
      {
        flagHasMaximumDistanceMiles = false;
      }

    public virtual void extraAstronomyDistanceFromEarthCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAstronomyDistanceFromEarthCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAstronomyDistanceFromEarthCommandLookup(key);
        if (old_field == null)
          {
            extraAstronomyDistanceFromEarthCommandAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ximumDistanceMiles", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMaximumDistanceMiles(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "nimumDistanceMiles", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMinimumDistanceMiles(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bjectName", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONObjectName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAstronomyDistanceFromEarthCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ximumDistanceMiles", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMaximumDistanceMiles(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "nimumDistanceMiles", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONMinimumDistanceMiles(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                if ((String.Compare(key, 1, "bjectName", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONObjectName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraAstronomyDistanceFromEarthCommandSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasObjectName);
        if (flagHasObjectName)
          {
            handler.start_pair("ObjectName");
            handler.string_value(storeObjectName);
          }
        Debug.Assert(partial_allowed || flagHasMinimumDistanceMiles);
        if (flagHasMinimumDistanceMiles)
          {
            handler.start_pair("MinimumDistanceMiles");
            if (textStoreMinimumDistanceMiles != "")
                handler.number_value(textStoreMinimumDistanceMiles);
            else if (((double)(long)storeMinimumDistanceMiles) == storeMinimumDistanceMiles)
                handler.number_value((long)storeMinimumDistanceMiles);
            else
                handler.number_value(storeMinimumDistanceMiles);
          }
        Debug.Assert(partial_allowed || flagHasMaximumDistanceMiles);
        if (flagHasMaximumDistanceMiles)
          {
            handler.start_pair("MaximumDistanceMiles");
            if (textStoreMaximumDistanceMiles != "")
                handler.number_value(textStoreMaximumDistanceMiles);
            else if (((double)(long)storeMaximumDistanceMiles) == storeMaximumDistanceMiles)
                handler.number_value((long)storeMaximumDistanceMiles);
            else
                handler.number_value(storeMaximumDistanceMiles);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasObjectName()))
          {
            return "When parsing the object for %what%, the \"ObjectName\" field was missing.";
          }
        if (!(hasMinimumDistanceMiles()))
          {
            return "When parsing the object for %what%, the \"MinimumDistanceMiles\" field was missing.";
          }
        if (!(hasMaximumDistanceMiles()))
          {
            return "When parsing the object for %what%, the \"MaximumDistanceMiles\" field was missing.";
          }
        return null;
      }

    public static new AstronomyDistanceFromEarthCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AstronomyDistanceFromEarthCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyDistanceFromEarthCommand", ignore_extras);
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
    public static new AstronomyDistanceFromEarthCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AstronomyDistanceFromEarthCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AstronomyDistanceFromEarthCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyDistanceFromEarthCommand", ignore_extras);
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
    public static new AstronomyDistanceFromEarthCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AstronomyDistanceFromEarthCommandJSON from_text(string text, bool ignore_extras)
      {
        AstronomyDistanceFromEarthCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyDistanceFromEarthCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AstronomyDistanceFromEarthCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AstronomyDistanceFromEarthCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AstronomyDistanceFromEarthCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AstronomyDistanceFromEarthCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorObjectName;
        private JSONHoldingNumberTextGenerator fieldGeneratorMinimumDistanceMiles;
        private JSONHoldingNumberTextGenerator fieldGeneratorMaximumDistanceMiles;
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
            if (!(getCommandResultJSONKey().Equals("AstronomyDistanceFromEarthCommand")))
                throw new Exception("The key field has a value other than `AstronomyDistanceFromEarthCommand'.");
            AstronomyDistanceFromEarthCommandJSON result = new AstronomyDistanceFromEarthCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAstronomyDistanceFromEarthCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((AstronomyDistanceFromEarthCommandJSON )new_result);
          }
        protected void finish(AstronomyDistanceFromEarthCommandJSON result)
          {
            if (fieldGeneratorObjectName.have_value)
              {
                result.setObjectName(fieldGeneratorObjectName.value);
                fieldGeneratorObjectName.have_value = false;
              }
            else if ((!(result.hasObjectName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ObjectName\" field was missing.");
              }
            if (fieldGeneratorMinimumDistanceMiles.have_value)
              {
                result.setMinimumDistanceMilesText(fieldGeneratorMinimumDistanceMiles.value);
                fieldGeneratorMinimumDistanceMiles.have_value = false;
              }
            else if ((!(result.hasMinimumDistanceMiles())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MinimumDistanceMiles\" field was missing.");
              }
            if (fieldGeneratorMaximumDistanceMiles.have_value)
              {
                result.setMaximumDistanceMilesText(fieldGeneratorMaximumDistanceMiles.value);
                fieldGeneratorMaximumDistanceMiles.have_value = false;
              }
            else if ((!(result.hasMaximumDistanceMiles())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MaximumDistanceMiles\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(AstronomyDistanceFromEarthCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximumDistanceMiles", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorMaximumDistanceMiles;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimumDistanceMiles", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorMinimumDistanceMiles;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "bjectName", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorObjectName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorObjectName = new JSONHoldingStringGenerator("field \"ObjectName\" of the AstronomyDistanceFromEarthCommand class");
            fieldGeneratorMinimumDistanceMiles = new JSONHoldingNumberTextGenerator("field \"MinimumDistanceMiles\" of the AstronomyDistanceFromEarthCommand class");
            fieldGeneratorMaximumDistanceMiles = new JSONHoldingNumberTextGenerator("field \"MaximumDistanceMiles\" of the AstronomyDistanceFromEarthCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AstronomyDistanceFromEarthCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorObjectName = new JSONHoldingStringGenerator("field \"ObjectName\" of the AstronomyDistanceFromEarthCommand class");
            fieldGeneratorMinimumDistanceMiles = new JSONHoldingNumberTextGenerator("field \"MinimumDistanceMiles\" of the AstronomyDistanceFromEarthCommand class");
            fieldGeneratorMaximumDistanceMiles = new JSONHoldingNumberTextGenerator("field \"MaximumDistanceMiles\" of the AstronomyDistanceFromEarthCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AstronomyDistanceFromEarthCommand class");
          }

        public override void reset()
          {
            fieldGeneratorObjectName.reset();
            fieldGeneratorMinimumDistanceMiles.reset();
            fieldGeneratorMaximumDistanceMiles.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AstronomyDistanceFromEarthCommandJSON  result)
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
        public AstronomyDistanceFromEarthCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AstronomyDistanceFromEarthCommandJSON  result)
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
    protected virtual void handle_result(List<AstronomyDistanceFromEarthCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AstronomyDistanceFromEarthCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AstronomyDistanceFromEarthCommandJSON>();
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
    public List<AstronomyDistanceFromEarthCommandJSON> value;
  };
  };
