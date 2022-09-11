/* file "HomeAutomationTemperatureJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationTemperatureJSON : JSONBase
  {
    public enum TypeUnit
      {
        Unit_Default,
        Unit_Fahrenheit,
        Unit_Celsius,
        Unit_Kelvin
      };

    public static TypeUnit  stringToUnit(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "elsius", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeUnit.Unit_Celsius;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "efault", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeUnit.Unit_Default;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ahrenheit", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeUnit.Unit_Fahrenheit;
                break;
            case 'K':
                if ((String.Compare(chars, 1, "elvin", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeUnit.Unit_Kelvin;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Unit' is not one of the legal values.");
      }

    public static string  stringFromUnit(TypeUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeUnit.Unit_Default:
                return "Default";
            case TypeUnit.Unit_Fahrenheit:
                return "Fahrenheit";
            case TypeUnit.Unit_Celsius:
                return "Celsius";
            case TypeUnit.Unit_Kelvin:
                return "Kelvin";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTemperature;
    private double storeTemperature;
    private string textStoreTemperature;
    private bool flagHasUnit;
    private TypeUnit storeUnit;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTemperature(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Temperature of HomeAutomationTemperatureJSON is not a number.");
              }
          }
        setTemperatureText(the_rational_text);
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of HomeAutomationTemperatureJSON is not a string.");
        TypeUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "elsius", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeUnit.Unit_Celsius;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "efault", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeUnit.Unit_Default;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ahrenheit", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeUnit.Unit_Fahrenheit;
                        goto enum_is_done;
                      }
                break;
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "elvin", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeUnit.Unit_Kelvin;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Unit of HomeAutomationTemperatureJSON is not one of the legal strings.");
      enum_is_done:;
        setUnit(the_enum);
      }


    public HomeAutomationTemperatureJSON()
      {
        flagHasTemperature = false;
        flagHasUnit = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTemperature()
      {
        return flagHasTemperature;
      }

    public double  getTemperature()
      {
        Debug.Assert(flagHasTemperature);
        if (textStoreTemperature != "")
          {
            return Double.Parse(textStoreTemperature);
          }
        return storeTemperature;
      }

    public string  getTemperatureAsText()
      {
        Debug.Assert(flagHasTemperature);
        if (textStoreTemperature == "")
          {
            return Convert.ToString(storeTemperature);
          }
        else
          {
            return (textStoreTemperature);
          }
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnit  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public string  getUnitAsString()
      {
        return stringFromUnit(getUnit());
      }


    public virtual int extraHomeAutomationTemperatureComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationTemperatureComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationTemperatureComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationTemperatureLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTemperature(double new_value)
      {
        flagHasTemperature = true;
        storeTemperature = new_value;
        textStoreTemperature = "";
      }
    public void setTemperatureText(string new_value)
      {
        flagHasTemperature = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Temperature of HomeAutomationTemperatureJSON is not a valid number.");
        textStoreTemperature = new_value;
      }
    public void unsetTemperature()
      {
        flagHasTemperature = false;
      }
    public void setUnit(TypeUnit new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(string chars)
      {
        setUnit(stringToUnit(chars));
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }

    public virtual void extraHomeAutomationTemperatureAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationTemperatureSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationTemperatureLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationTemperatureAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTemperature);
        if (flagHasTemperature)
          {
            handler.start_pair("Temperature");
            if (textStoreTemperature != "")
                handler.number_value(textStoreTemperature);
            else if (((double)(long)storeTemperature) == storeTemperature)
                handler.number_value((long)storeTemperature);
            else
                handler.number_value(storeTemperature);
          }
        Debug.Assert(partial_allowed || flagHasUnit);
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            switch (storeUnit)
              {
                case TypeUnit.Unit_Default:
                    handler.string_value("Default");
                    break;
                case TypeUnit.Unit_Fahrenheit:
                    handler.string_value("Fahrenheit");
                    break;
                case TypeUnit.Unit_Celsius:
                    handler.string_value("Celsius");
                    break;
                case TypeUnit.Unit_Kelvin:
                    handler.string_value("Kelvin");
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
        if (!(hasTemperature()))
          {
            return "When parsing the object for %what%, the \"Temperature\" field was missing.";
          }
        if (!(hasUnit()))
          {
            return "When parsing the object for %what%, the \"Unit\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationTemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTemperature", ignore_extras);
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
    public static HomeAutomationTemperatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationTemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTemperature", ignore_extras);
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
    public static HomeAutomationTemperatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationTemperatureJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationTemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTemperature", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationTemperatureJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationTemperatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationTemperatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationTemperature", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorTemperature;
    private abstract class FieldGeneratorUnit : JSONStringGenerator
          {
            protected FieldGeneratorUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnit(result));
              }
            protected abstract void handle_result(TypeUnit result);
          };
    private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
  {
    protected override void handle_result(TypeUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnit(String what)
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
    public TypeUnit value;
  };
    private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnit
      {
        private FieldHoldingArrayGeneratorUnit top;

        protected override void handle_result(TypeUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
    protected virtual void handle_result(List<TypeUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnit> value;
  };
        private FieldHoldingGeneratorUnit fieldGeneratorUnit;
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
            HomeAutomationTemperatureJSON result = new HomeAutomationTemperatureJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationTemperatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationTemperatureJSON result)
          {
            if (fieldGeneratorTemperature.have_value)
              {
                result.setTemperatureText(fieldGeneratorTemperature.value);
                fieldGeneratorTemperature.have_value = false;
              }
            else if ((!(result.hasTemperature())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Temperature\" field was missing.");
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            else if ((!(result.hasUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Unit\" field was missing.");
              }
          }
        protected abstract void handle_result(HomeAutomationTemperatureJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'T':
                    if ((String.Compare(field_name, 1, "emperature", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTemperature;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTemperature = new JSONHoldingNumberTextGenerator("field \"Temperature\" of the HomeAutomationTemperature class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the HomeAutomationTemperature class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationTemperature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTemperature = new JSONHoldingNumberTextGenerator("field \"Temperature\" of the HomeAutomationTemperature class");
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the HomeAutomationTemperature class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationTemperature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTemperature.reset();
            fieldGeneratorUnit.reset();
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
        protected override void handle_result(HomeAutomationTemperatureJSON  result)
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
        public HomeAutomationTemperatureJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationTemperatureJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationTemperatureJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationTemperatureJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationTemperatureJSON>();
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
    public List<HomeAutomationTemperatureJSON> value;
  };
  };
