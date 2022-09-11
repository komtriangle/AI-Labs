/* file "SportsOlympicsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class SportsOlympicsInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasNow;
    private DateAndOrTimeJSON  storeNow;


    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraNowToJSON()
      {
        JSONValueHandler handler_Now = new JSONValueHandler();
        storeNow.write_as_json(handler_Now);
        return handler_Now.result;
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONNow(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNow(convert_classy);
      }


    public SportsOlympicsInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasNow = false;
      }

    public override string  getNuggetKind()
      {
        return "SportsOlympicsInformationNugget";
      }

    public abstract string getSportsOlympicsInformationNuggetKind();
    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasNow()
      {
        return flagHasNow;
      }

    public DateAndOrTimeJSON   getNow()
      {
        Debug.Assert(flagHasNow);
        return storeNow;
      }


    public abstract int extraSportsOlympicsInformationNuggetComponentCount();
    public abstract string extraSportsOlympicsInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraSportsOlympicsInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraSportsOlympicsInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasAttribution)
            ++result;
        if (flagHasNow)
            ++result;
        result += extraSportsOlympicsInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "SportsOlympicsInformationNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasNow)
          {
            if (remainder == 0)
                return "Now";
            --remainder;
          }
        return extraSportsOlympicsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getSportsOlympicsInformationNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasNow)
          {
            if (remainder == 0)
                return extraNowToJSON();
            --remainder;
          }
        return extraSportsOlympicsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                    return (flagHasNow ? extraNowToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "portsOlympicsInformationNuggetKind", 0, 34, false) == 0) && (field_name.Length == 35))
                    return new JSONStringValue(getSportsOlympicsInformationNuggetKind());
                break;
            default:
                break;
          }
        return extraSportsOlympicsInformationNuggetLookup(field_name);
      }

    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }
    public void setNow(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNow)
          {
          }
        flagHasNow = true;
        storeNow = new_value;
      }
    public void unsetNow()
      {
        if (flagHasNow)
          {
          }
        flagHasNow = false;
      }

    public abstract void extraSportsOlympicsInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsOlympicsInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ow", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONNow(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "portsOlympicsInformationNuggetKind", 0, 34, false) == 0) && (key.Length == 35))
                    return;
                break;
            default:
                break;
          }
        extraSportsOlympicsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ow", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONNow(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "portsOlympicsInformationNuggetKind", 0, 34, false) == 0) && (key.Length == 35))
                    return;
                break;
            default:
                break;
          }
        extraSportsOlympicsInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("SportsOlympicsInformationNuggetKind", getSportsOlympicsInformationNuggetKind());
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        if (flagHasNow)
          {
            handler.start_pair("Now");
            if (partial_allowed)
                storeNow.write_partial_as_json(handler);
            else
                storeNow.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SportsOlympicsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNow;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsOlympicsInformationNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("SportsOlympicsInformationNugget")))
                throw new Exception("The key field has a value other than `SportsOlympicsInformationNugget'.");
            SportsOlympicsInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSportsOlympicsInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsOlympicsInformationNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((SportsOlympicsInformationNuggetJSON )new_result);
          }
        protected void finish(SportsOlympicsInformationNuggetJSON result)
          {
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorNow.have_value)
              {
                result.setNow(fieldGeneratorNow.value);
                fieldGeneratorNow.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorNow;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "portsOlympicsInformationNuggetKind", 0, 34, false) == 0) && (field_name.Length == 35))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the SportsOlympicsInformationNugget class", ignore_extras);
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the SportsOlympicsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsOlympicsInformationNuggetKind\" of the SportsOlympicsInformationNugget class");
            set_what("the SportsOlympicsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the SportsOlympicsInformationNugget class", false);
            fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the SportsOlympicsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsOlympicsInformationNuggetKind\" of the SportsOlympicsInformationNugget class");
            set_what("the SportsOlympicsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorNow.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsInformationNuggetJSON  result)
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
        public SportsOlympicsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsInformationNuggetJSON>();
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
    public List<SportsOlympicsInformationNuggetJSON> value;
  };
    class GenericSportsOlympicsInformationNuggetJSON : SportsOlympicsInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsOlympicsInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsOlympicsInformationNuggetKind()  { return key; }
        public override int extraSportsOlympicsInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsOlympicsInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsOlympicsInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsOlympicsInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsOlympicsInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsOlympicsInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsOlympicsInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraSportsOlympicsInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new SportsOlympicsInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "SportsOlympics", 0, 14, false) == 0)
      {
        switch (key[14])
          {
            case 'B':
                if ((String.Compare(key, 15, "asicAttributeInformationNugget", 0, 30, false) == 0) && (key.Length == 45))
                    return new SportsOlympicsBasicAttributeInformationNuggetJSON();
                break;
            case 'E':
                if ((String.Compare(key, 15, "ventSchedulesAndResultsInformationNugget", 0, 40, false) == 0) && (key.Length == 55))
                    return new SportsOlympicsEventSchedulesAndResultsInformationNuggetJSON();
                break;
            case 'M':
                if ((String.Compare(key, 15, "edalStandingsInformationNugget", 0, 30, false) == 0) && (key.Length == 45))
                    return new SportsOlympicsMedalStandingsInformationNuggetJSON();
                break;
            default:
                break;
          }
      }

        return new GenericSportsOlympicsInformationNuggetJSON(key);
      }
  };
