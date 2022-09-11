/* file "BarometricPressureDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BarometricPressureDataJSON : JSONBase
  {
    public enum TypeTrendKnownValues
      {
        Trend_Steady,
        Trend_Rising,
        Trend_Falling,
        Trend__none
      };
    public struct TypeTrend
      {
        public bool in_known_list;
        public string string_value;
        public TypeTrendKnownValues list_value;
      };

    public static TypeTrendKnownValues  stringToTrend(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "alling", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeTrendKnownValues.Trend_Falling;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ising", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeTrendKnownValues.Trend_Rising;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "teady", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeTrendKnownValues.Trend_Steady;
                break;
            default:
                break;
          }
        return TypeTrendKnownValues.Trend__none;
      }

    public static string  stringFromTrend(TypeTrendKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTrendKnownValues.Trend_Steady:
                return "Steady";
            case TypeTrendKnownValues.Trend_Rising:
                return "Rising";
            case TypeTrendKnownValues.Trend_Falling:
                return "Falling";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private UnitsValue_PressureJSON  storeValue;
    private bool flagHasTrend;
    private TypeTrend storeTrend;
    private bool flagHasTrendText;
    private string storeTrendText;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitsValue_PressureJSON convert_classy = UnitsValue_PressureJSON.from_json(json_value, ignore_extras, true);
        setValue(convert_classy);
      }


    private void  fromJSONTrend(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Trend of BarometricPressureDataJSON is not a string.");
        TypeTrend the_open_enum = new TypeTrend();
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "alling", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTrendKnownValues.Trend_Falling;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ising", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTrendKnownValues.Trend_Rising;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "teady", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTrendKnownValues.Trend_Steady;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTrend(the_open_enum);
      }


    private void  fromJSONTrendText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TrendText of BarometricPressureDataJSON is not a string.");
        setTrendText(json_string.getData());
      }


    public BarometricPressureDataJSON()
      {
        flagHasValue = false;
        flagHasTrend = false;
        flagHasTrendText = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public UnitsValue_PressureJSON   getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public bool  hasTrend()
      {
        return flagHasTrend;
      }

    public TypeTrend  getTrend()
      {
        Debug.Assert(flagHasTrend);
        return storeTrend;
      }

    public string  getTrendAsString()
      {
        TypeTrend result = getTrend();
        if (result.in_known_list)
            return stringFromTrend(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasTrendText()
      {
        return flagHasTrendText;
      }

    public string  getTrendText()
      {
        Debug.Assert(flagHasTrendText);
        return storeTrendText;
      }


    public virtual int extraBarometricPressureDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBarometricPressureDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBarometricPressureDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBarometricPressureDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setValue(UnitsValue_PressureJSON  new_value)
      {
        if (flagHasValue)
          {
          }
        flagHasValue = true;
        storeValue = new_value;
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
          }
        flagHasValue = false;
      }
    public void setTrend(TypeTrend new_value)
      {
        flagHasTrend = true;
        storeTrend = new_value;
      }
    public void setTrend(string chars)
      {
        TypeTrendKnownValues known = stringToTrend(chars);
        TypeTrend new_value = new TypeTrend();
        if (known == TypeTrendKnownValues.Trend__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTrend(new_value);
      }
    public void setTrend(TypeTrendKnownValues new_value)
      {
        TypeTrend new_full_value = new TypeTrend();
        Debug.Assert(new_value != TypeTrendKnownValues.Trend__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTrend(new_full_value);
      }
    public void unsetTrend()
      {
        flagHasTrend = false;
      }
    public void setTrendText(string new_value)
      {
        flagHasTrendText = true;
        storeTrendText = new_value;
      }
    public void unsetTrendText()
      {
        flagHasTrendText = false;
      }

    public virtual void extraBarometricPressureDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBarometricPressureDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBarometricPressureDataLookup(key);
        if (old_field == null)
          {
            extraBarometricPressureDataAppendPair(key, new_component);
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
        if (flagHasValue)
          {
            handler.start_pair("Value");
            if (partial_allowed)
                storeValue.write_partial_as_json(handler);
            else
                storeValue.write_as_json(handler);
          }
        if (flagHasTrend)
          {
            handler.start_pair("Trend");
            if (storeTrend.in_known_list)
              {
                switch (storeTrend.list_value)
                  {
                    case TypeTrendKnownValues.Trend_Steady:
                        handler.string_value("Steady");
                        break;
                    case TypeTrendKnownValues.Trend_Rising:
                        handler.string_value("Rising");
                        break;
                    case TypeTrendKnownValues.Trend_Falling:
                        handler.string_value("Falling");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTrend.string_value);
              }
          }
        if (flagHasTrendText)
          {
            handler.start_pair("TrendText");
            handler.string_value(storeTrendText);
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
        return null;
      }

    public static BarometricPressureDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BarometricPressureDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BarometricPressureData", ignore_extras);
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
    public static BarometricPressureDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BarometricPressureDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BarometricPressureDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BarometricPressureData", ignore_extras);
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
    public static BarometricPressureDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BarometricPressureDataJSON from_text(string text, bool ignore_extras)
      {
        BarometricPressureDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BarometricPressureData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BarometricPressureDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BarometricPressureDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BarometricPressureDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BarometricPressureData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UnitsValue_PressureJSON.HoldingGenerator fieldGeneratorValue;
    private abstract class FieldGeneratorTrend : JSONStringGenerator
          {
            protected FieldGeneratorTrend(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTrend()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTrendKnownValues known = stringToTrend(result);
                TypeTrend new_value = new TypeTrend();
                if (known == TypeTrendKnownValues.Trend__none)
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
            protected abstract void handle_result(TypeTrend result);
          };
    private class FieldHoldingGeneratorTrend : FieldGeneratorTrend
  {
    protected override void handle_result(TypeTrend result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTrend(String what)
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
    public TypeTrend value;
  };
    private class FieldHoldingArrayGeneratorTrend : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTrend
      {
        private FieldHoldingArrayGeneratorTrend top;

        protected override void handle_result(TypeTrend result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTrend init_top)
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
    protected virtual void handle_result(List<TypeTrend> result)
      {
      }

    public FieldHoldingArrayGeneratorTrend(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTrend>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTrend()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTrend>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTrend> value;
  };
        private FieldHoldingGeneratorTrend fieldGeneratorTrend;
        private JSONHoldingStringGenerator fieldGeneratorTrendText;
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
            BarometricPressureDataJSON result = new BarometricPressureDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBarometricPressureDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BarometricPressureDataJSON result)
          {
            if (fieldGeneratorValue.have_value)
              {
                result.setValue(fieldGeneratorValue.value);
                fieldGeneratorValue.have_value = false;
              }
            if (fieldGeneratorTrend.have_value)
              {
                result.setTrend(fieldGeneratorTrend.value);
                fieldGeneratorTrend.have_value = false;
              }
            if (fieldGeneratorTrendText.have_value)
              {
                result.setTrendText(fieldGeneratorTrendText.value);
                fieldGeneratorTrendText.have_value = false;
              }
          }
        protected abstract void handle_result(BarometricPressureDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'T':
                    if (String.Compare(field_name, 1, "rend", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorTrend;
                          }
                        switch (field_name[5])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 6, "ext", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorTrendText;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorValue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the BarometricPressureData class", ignore_extras);
            fieldGeneratorTrend = new FieldHoldingGeneratorTrend("field \"Trend\" of the BarometricPressureData class");
            fieldGeneratorTrendText = new JSONHoldingStringGenerator("field \"TrendText\" of the BarometricPressureData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BarometricPressureData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorValue = new UnitsValue_PressureJSON.HoldingGenerator("field \"Value\" of the BarometricPressureData class", false);
            fieldGeneratorTrend = new FieldHoldingGeneratorTrend("field \"Trend\" of the BarometricPressureData class");
            fieldGeneratorTrendText = new JSONHoldingStringGenerator("field \"TrendText\" of the BarometricPressureData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BarometricPressureData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorValue.reset();
            fieldGeneratorTrend.reset();
            fieldGeneratorTrendText.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorValue.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorValue.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BarometricPressureDataJSON  result)
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
        public BarometricPressureDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BarometricPressureDataJSON  result)
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
    protected virtual void handle_result(List<BarometricPressureDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BarometricPressureDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BarometricPressureDataJSON>();
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
    public List<BarometricPressureDataJSON> value;
  };
  };
