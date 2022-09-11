/* file "TipCalculatorQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TipCalculatorQueryStateJSON : JSONBase
  {
    public enum TypeTipCalculatorCommandKind
      {
        TipCalculatorCommandKind_TipCalculatorShowResultsCommand,
        TipCalculatorCommandKind_TipCalculatorCancelInformationNugget
      };

    public static TypeTipCalculatorCommandKind  stringToTipCalculatorCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "TipCalculator", 0, 13, false) == 0)
          {
            switch (chars[13])
              {
                case 'C':
                    if ((String.Compare(chars, 14, "ancelInformationNugget", 0, 22, false) == 0) && (chars.Length == 36))
                        return TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorCancelInformationNugget;
                    break;
                case 'S':
                    if ((String.Compare(chars, 14, "howResultsCommand", 0, 17, false) == 0) && (chars.Length == 31))
                        return TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorShowResultsCommand;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `TipCalculatorCommandKind' is not one of the legal values.");
      }

    public static string  stringFromTipCalculatorCommandKind(TypeTipCalculatorCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorShowResultsCommand:
                return "TipCalculatorShowResultsCommand";
            case TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorCancelInformationNugget:
                return "TipCalculatorCancelInformationNugget";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTipCalculatorCommandKind;
    private TypeTipCalculatorCommandKind storeTipCalculatorCommandKind;
    private bool flagHasTipCalculatorInputData;
    private TipCalculatorInputDataJSON  storeTipCalculatorInputData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTipCalculatorCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TipCalculatorCommandKind of TipCalculatorQueryStateJSON is not a string.");
        TypeTipCalculatorCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "TipCalculator", 0, 13, false) == 0)
          {
            switch (json_string.getData()[13])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 14, "ancelInformationNugget", 0, 22, false) == 0) && (json_string.getData().Length == 36))
                          {
                            the_enum = TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorCancelInformationNugget;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 14, "howResultsCommand", 0, 17, false) == 0) && (json_string.getData().Length == 31))
                          {
                            the_enum = TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorShowResultsCommand;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field TipCalculatorCommandKind of TipCalculatorQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setTipCalculatorCommandKind(the_enum);
      }


    private void  fromJSONTipCalculatorInputData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TipCalculatorInputDataJSON convert_classy = TipCalculatorInputDataJSON.from_json(json_value, ignore_extras, true);
        setTipCalculatorInputData(convert_classy);
      }


    public TipCalculatorQueryStateJSON()
      {
        flagHasTipCalculatorCommandKind = false;
        flagHasTipCalculatorInputData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTipCalculatorCommandKind()
      {
        return flagHasTipCalculatorCommandKind;
      }

    public TypeTipCalculatorCommandKind  getTipCalculatorCommandKind()
      {
        Debug.Assert(flagHasTipCalculatorCommandKind);
        return storeTipCalculatorCommandKind;
      }

    public string  getTipCalculatorCommandKindAsString()
      {
        return stringFromTipCalculatorCommandKind(getTipCalculatorCommandKind());
      }

    public bool  hasTipCalculatorInputData()
      {
        return flagHasTipCalculatorInputData;
      }

    public TipCalculatorInputDataJSON   getTipCalculatorInputData()
      {
        Debug.Assert(flagHasTipCalculatorInputData);
        return storeTipCalculatorInputData;
      }


    public virtual int extraTipCalculatorQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTipCalculatorQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTipCalculatorQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTipCalculatorQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTipCalculatorCommandKind(TypeTipCalculatorCommandKind new_value)
      {
        flagHasTipCalculatorCommandKind = true;
        storeTipCalculatorCommandKind = new_value;
      }
    public void setTipCalculatorCommandKind(string chars)
      {
        setTipCalculatorCommandKind(stringToTipCalculatorCommandKind(chars));
      }
    public void unsetTipCalculatorCommandKind()
      {
        flagHasTipCalculatorCommandKind = false;
      }
    public void setTipCalculatorInputData(TipCalculatorInputDataJSON  new_value)
      {
        if (flagHasTipCalculatorInputData)
          {
          }
        flagHasTipCalculatorInputData = true;
        storeTipCalculatorInputData = new_value;
      }
    public void unsetTipCalculatorInputData()
      {
        if (flagHasTipCalculatorInputData)
          {
          }
        flagHasTipCalculatorInputData = false;
      }

    public virtual void extraTipCalculatorQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTipCalculatorQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTipCalculatorQueryStateLookup(key);
        if (old_field == null)
          {
            extraTipCalculatorQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTipCalculatorCommandKind);
        if (flagHasTipCalculatorCommandKind)
          {
            handler.start_pair("TipCalculatorCommandKind");
            switch (storeTipCalculatorCommandKind)
              {
                case TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorShowResultsCommand:
                    handler.string_value("TipCalculatorShowResultsCommand");
                    break;
                case TypeTipCalculatorCommandKind.TipCalculatorCommandKind_TipCalculatorCancelInformationNugget:
                    handler.string_value("TipCalculatorCancelInformationNugget");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasTipCalculatorInputData)
          {
            handler.start_pair("TipCalculatorInputData");
            if (partial_allowed)
                storeTipCalculatorInputData.write_partial_as_json(handler);
            else
                storeTipCalculatorInputData.write_as_json(handler);
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
        if (!(hasTipCalculatorCommandKind()))
          {
            return "When parsing the object for %what%, the \"TipCalculatorCommandKind\" field was missing.";
          }
        return null;
      }

    public static TipCalculatorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorQueryState", ignore_extras);
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
    public static TipCalculatorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TipCalculatorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TipCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorQueryState", ignore_extras);
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
    public static TipCalculatorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TipCalculatorQueryStateJSON from_text(string text, bool ignore_extras)
      {
        TipCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TipCalculatorQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TipCalculatorQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TipCalculatorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TipCalculatorQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorTipCalculatorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorTipCalculatorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTipCalculatorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToTipCalculatorCommandKind(result));
              }
            protected abstract void handle_result(TypeTipCalculatorCommandKind result);
          };
    private class FieldHoldingGeneratorTipCalculatorCommandKind : FieldGeneratorTipCalculatorCommandKind
  {
    protected override void handle_result(TypeTipCalculatorCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTipCalculatorCommandKind(String what)
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
    public TypeTipCalculatorCommandKind value;
  };
    private class FieldHoldingArrayGeneratorTipCalculatorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTipCalculatorCommandKind
      {
        private FieldHoldingArrayGeneratorTipCalculatorCommandKind top;

        protected override void handle_result(TypeTipCalculatorCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTipCalculatorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeTipCalculatorCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorTipCalculatorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTipCalculatorCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTipCalculatorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTipCalculatorCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTipCalculatorCommandKind> value;
  };
        private FieldHoldingGeneratorTipCalculatorCommandKind fieldGeneratorTipCalculatorCommandKind;
        private TipCalculatorInputDataJSON.HoldingGenerator fieldGeneratorTipCalculatorInputData;
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
            TipCalculatorQueryStateJSON result = new TipCalculatorQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTipCalculatorQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TipCalculatorQueryStateJSON result)
          {
            if (fieldGeneratorTipCalculatorCommandKind.have_value)
              {
                result.setTipCalculatorCommandKind(fieldGeneratorTipCalculatorCommandKind.value);
                fieldGeneratorTipCalculatorCommandKind.have_value = false;
              }
            else if ((!(result.hasTipCalculatorCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TipCalculatorCommandKind\" field was missing.");
              }
            if (fieldGeneratorTipCalculatorInputData.have_value)
              {
                result.setTipCalculatorInputData(fieldGeneratorTipCalculatorInputData.value);
                fieldGeneratorTipCalculatorInputData.have_value = false;
              }
          }
        protected abstract void handle_result(TipCalculatorQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "TipCalculator", 0, 13, false) == 0)
              {
                switch (field_name[13])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 14, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 24))
                            return fieldGeneratorTipCalculatorCommandKind;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 14, "nputData", 0, 8, false) == 0) && (field_name.Length == 22))
                            return fieldGeneratorTipCalculatorInputData;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTipCalculatorCommandKind = new FieldHoldingGeneratorTipCalculatorCommandKind("field \"TipCalculatorCommandKind\" of the TipCalculatorQueryState class");
            fieldGeneratorTipCalculatorInputData = new TipCalculatorInputDataJSON.HoldingGenerator("field \"TipCalculatorInputData\" of the TipCalculatorQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TipCalculatorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTipCalculatorCommandKind = new FieldHoldingGeneratorTipCalculatorCommandKind("field \"TipCalculatorCommandKind\" of the TipCalculatorQueryState class");
            fieldGeneratorTipCalculatorInputData = new TipCalculatorInputDataJSON.HoldingGenerator("field \"TipCalculatorInputData\" of the TipCalculatorQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TipCalculatorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTipCalculatorCommandKind.reset();
            fieldGeneratorTipCalculatorInputData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTipCalculatorInputData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTipCalculatorInputData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TipCalculatorQueryStateJSON  result)
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
        public TipCalculatorQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TipCalculatorQueryStateJSON  result)
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
    protected virtual void handle_result(List<TipCalculatorQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TipCalculatorQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TipCalculatorQueryStateJSON>();
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
    public List<TipCalculatorQueryStateJSON> value;
  };
  };
