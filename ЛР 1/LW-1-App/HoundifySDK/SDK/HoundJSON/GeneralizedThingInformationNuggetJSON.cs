/* file "GeneralizedThingInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class GeneralizedThingInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasWhatInformation;
    private WhatInformationJSON  storeWhatInformation;
    private bool flagHasGeneralizedThing;
    private GeneralizedThingJSON  storeGeneralizedThing;
    private bool flagHasDerivation;
    private DerivationJSON  storeDerivation;


    private JSONValue  extraWhatInformationToJSON()
      {
        JSONValueHandler handler_WhatInformation = new JSONValueHandler();
        storeWhatInformation.write_as_json(handler_WhatInformation);
        return handler_WhatInformation.result;
      }

    private JSONValue  extraGeneralizedThingToJSON()
      {
        JSONValueHandler handler_GeneralizedThing = new JSONValueHandler();
        storeGeneralizedThing.write_as_json(handler_GeneralizedThing);
        return handler_GeneralizedThing.result;
      }

    private JSONValue  extraDerivationToJSON()
      {
        JSONValueHandler handler_Derivation = new JSONValueHandler();
        storeDerivation.write_as_json(handler_Derivation);
        return handler_Derivation.result;
      }


    private void  fromJSONWhatInformation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhatInformationJSON convert_classy = WhatInformationJSON.from_json(json_value, ignore_extras, true);
        setWhatInformation(convert_classy);
      }


    private void  fromJSONGeneralizedThing(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeneralizedThingJSON convert_classy = GeneralizedThingJSON.from_json(json_value, ignore_extras, true);
        setGeneralizedThing(convert_classy);
      }


    private void  fromJSONDerivation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DerivationJSON convert_classy = DerivationJSON.from_json(json_value, ignore_extras, true);
        setDerivation(convert_classy);
      }


    public GeneralizedThingInformationNuggetJSON()
      {
        flagHasWhatInformation = false;
        flagHasGeneralizedThing = false;
        flagHasDerivation = false;
      }

    public override string  getNuggetKind()
      {
        return "GeneralizedThing";
      }

    public abstract string getGeneralizedThingNuggetKind();
    public bool  hasWhatInformation()
      {
        return flagHasWhatInformation;
      }

    public WhatInformationJSON   getWhatInformation()
      {
        Debug.Assert(flagHasWhatInformation);
        return storeWhatInformation;
      }

    public bool  hasGeneralizedThing()
      {
        return flagHasGeneralizedThing;
      }

    public GeneralizedThingJSON   getGeneralizedThing()
      {
        Debug.Assert(flagHasGeneralizedThing);
        return storeGeneralizedThing;
      }

    public bool  hasDerivation()
      {
        return flagHasDerivation;
      }

    public DerivationJSON   getDerivation()
      {
        Debug.Assert(flagHasDerivation);
        return storeDerivation;
      }


    public abstract int extraGeneralizedThingInformationNuggetComponentCount();
    public abstract string extraGeneralizedThingInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraGeneralizedThingInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraGeneralizedThingInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasWhatInformation)
            ++result;
        if (flagHasGeneralizedThing)
            ++result;
        if (flagHasDerivation)
            ++result;
        result += extraGeneralizedThingInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "GeneralizedThingNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasWhatInformation)
          {
            if (remainder == 0)
                return "WhatInformation";
            --remainder;
          }
        if (flagHasGeneralizedThing)
          {
            if (remainder == 0)
                return "GeneralizedThing";
            --remainder;
          }
        if (flagHasDerivation)
          {
            if (remainder == 0)
                return "Derivation";
            --remainder;
          }
        return extraGeneralizedThingInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getGeneralizedThingNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasWhatInformation)
          {
            if (remainder == 0)
                return extraWhatInformationToJSON();
            --remainder;
          }
        if (flagHasGeneralizedThing)
          {
            if (remainder == 0)
                return extraGeneralizedThingToJSON();
            --remainder;
          }
        if (flagHasDerivation)
          {
            if (remainder == 0)
                return extraDerivationToJSON();
            --remainder;
          }
        return extraGeneralizedThingInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "erivation", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasDerivation ? extraDerivationToJSON() : null);
                break;
            case 'G':
                if (String.Compare(field_name, 1, "eneralizedThing", 0, 15, false) == 0)
                  {
                    if (field_name.Length == 16)
                      {
                        return (flagHasGeneralizedThing ? extraGeneralizedThingToJSON() : null);
                      }
                    switch (field_name[16])
                      {
                        case 'N':
                            if ((String.Compare(field_name, 17, "uggetKind", 0, 9, false) == 0) && (field_name.Length == 26))
                                return new JSONStringValue(getGeneralizedThingNuggetKind());
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "hatInformation", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasWhatInformation ? extraWhatInformationToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeneralizedThingInformationNuggetLookup(field_name);
      }

    public void setWhatInformation(WhatInformationJSON  new_value)
      {
        if (flagHasWhatInformation)
          {
          }
        flagHasWhatInformation = true;
        storeWhatInformation = new_value;
      }
    public void unsetWhatInformation()
      {
        if (flagHasWhatInformation)
          {
          }
        flagHasWhatInformation = false;
      }
    public void setGeneralizedThing(GeneralizedThingJSON  new_value)
      {
        if (flagHasGeneralizedThing)
          {
          }
        flagHasGeneralizedThing = true;
        storeGeneralizedThing = new_value;
      }
    public void unsetGeneralizedThing()
      {
        if (flagHasGeneralizedThing)
          {
          }
        flagHasGeneralizedThing = false;
      }
    public void setDerivation(DerivationJSON  new_value)
      {
        if (flagHasDerivation)
          {
          }
        flagHasDerivation = true;
        storeDerivation = new_value;
      }
    public void unsetDerivation()
      {
        if (flagHasDerivation)
          {
          }
        flagHasDerivation = false;
      }

    public abstract void extraGeneralizedThingInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraGeneralizedThingInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "erivation", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDerivation(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if (String.Compare(key, 1, "eneralizedThing", 0, 15, false) == 0)
                  {
                    if (key.Length == 16)
                      {
                        {
                        fromJSONGeneralizedThing(new_component, false);
                        return;
                        }
                      }
                    switch (key[16])
                      {
                        case 'N':
                            if ((String.Compare(key, 17, "uggetKind", 0, 9, false) == 0) && (key.Length == 26))
                                return;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "hatInformation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONWhatInformation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeneralizedThingInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "erivation", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONDerivation(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if (String.Compare(key, 1, "eneralizedThing", 0, 15, false) == 0)
                  {
                    if (key.Length == 16)
                      {
                        {
                        fromJSONGeneralizedThing(new_component, false);
                        return;
                        }
                      }
                    switch (key[16])
                      {
                        case 'N':
                            if ((String.Compare(key, 17, "uggetKind", 0, 9, false) == 0) && (key.Length == 26))
                                return;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "hatInformation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONWhatInformation(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeneralizedThingInformationNuggetSetField(key, new_component);
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
        handler.pair("GeneralizedThingNuggetKind", getGeneralizedThingNuggetKind());
        Debug.Assert(partial_allowed || flagHasWhatInformation);
        if (flagHasWhatInformation)
          {
            handler.start_pair("WhatInformation");
            if (partial_allowed)
                storeWhatInformation.write_partial_as_json(handler);
            else
                storeWhatInformation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasGeneralizedThing);
        if (flagHasGeneralizedThing)
          {
            handler.start_pair("GeneralizedThing");
            if (partial_allowed)
                storeGeneralizedThing.write_partial_as_json(handler);
            else
                storeGeneralizedThing.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDerivation);
        if (flagHasDerivation)
          {
            handler.start_pair("Derivation");
            if (partial_allowed)
                storeDerivation.write_partial_as_json(handler);
            else
                storeDerivation.write_as_json(handler);
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
        if (!(hasWhatInformation()))
          {
            return "When parsing the object for %what%, the \"WhatInformation\" field was missing.";
          }
        if (!(hasGeneralizedThing()))
          {
            return "When parsing the object for %what%, the \"GeneralizedThing\" field was missing.";
          }
        if (!(hasDerivation()))
          {
            return "When parsing the object for %what%, the \"Derivation\" field was missing.";
          }
        return null;
      }

    public static new GeneralizedThingInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeneralizedThingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeneralizedThingInformationNugget", ignore_extras);
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
    public static new GeneralizedThingInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeneralizedThingInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeneralizedThingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeneralizedThingInformationNugget", ignore_extras);
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
    public static new GeneralizedThingInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeneralizedThingInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        GeneralizedThingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeneralizedThingInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeneralizedThingInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeneralizedThingInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeneralizedThingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeneralizedThingInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private WhatInformationJSON.HoldingGenerator fieldGeneratorWhatInformation;
        private GeneralizedThingJSON.HoldingGenerator fieldGeneratorGeneralizedThing;
        private DerivationJSON.HoldingGenerator fieldGeneratorDerivation;
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
                throw new Exception("The `GeneralizedThingNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("GeneralizedThing")))
                throw new Exception("The key field has a value other than `GeneralizedThing'.");
            GeneralizedThingInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeneralizedThingInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getGeneralizedThingInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `GeneralizedThingNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((GeneralizedThingInformationNuggetJSON )new_result);
          }
        protected void finish(GeneralizedThingInformationNuggetJSON result)
          {
            if (fieldGeneratorWhatInformation.have_value)
              {
                result.setWhatInformation(fieldGeneratorWhatInformation.value);
                fieldGeneratorWhatInformation.have_value = false;
              }
            else if ((!(result.hasWhatInformation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WhatInformation\" field was missing.");
              }
            if (fieldGeneratorGeneralizedThing.have_value)
              {
                result.setGeneralizedThing(fieldGeneratorGeneralizedThing.value);
                fieldGeneratorGeneralizedThing.have_value = false;
              }
            else if ((!(result.hasGeneralizedThing())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GeneralizedThing\" field was missing.");
              }
            if (fieldGeneratorDerivation.have_value)
              {
                result.setDerivation(fieldGeneratorDerivation.value);
                fieldGeneratorDerivation.have_value = false;
              }
            else if ((!(result.hasDerivation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Derivation\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeneralizedThingInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "erivation", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDerivation;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "eneralizedThing", 0, 15, false) == 0)
                      {
                        if (field_name.Length == 16)
                          {
                            return fieldGeneratorGeneralizedThing;
                          }
                        switch (field_name[16])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 17, "uggetKind", 0, 9, false) == 0) && (field_name.Length == 26))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "hatInformation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorWhatInformation;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWhatInformation = new WhatInformationJSON.HoldingGenerator("field \"WhatInformation\" of the GeneralizedThingInformationNugget class", ignore_extras);
            fieldGeneratorGeneralizedThing = new GeneralizedThingJSON.HoldingGenerator("field \"GeneralizedThing\" of the GeneralizedThingInformationNugget class", ignore_extras);
            fieldGeneratorDerivation = new DerivationJSON.HoldingGenerator("field \"Derivation\" of the GeneralizedThingInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"GeneralizedThingNuggetKind\" of the GeneralizedThingInformationNugget class");
            set_what("the GeneralizedThingInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWhatInformation = new WhatInformationJSON.HoldingGenerator("field \"WhatInformation\" of the GeneralizedThingInformationNugget class", false);
            fieldGeneratorGeneralizedThing = new GeneralizedThingJSON.HoldingGenerator("field \"GeneralizedThing\" of the GeneralizedThingInformationNugget class", false);
            fieldGeneratorDerivation = new DerivationJSON.HoldingGenerator("field \"Derivation\" of the GeneralizedThingInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"GeneralizedThingNuggetKind\" of the GeneralizedThingInformationNugget class");
            set_what("the GeneralizedThingInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorWhatInformation.reset();
            fieldGeneratorGeneralizedThing.reset();
            fieldGeneratorDerivation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeneralizedThingInformationNuggetJSON  result)
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
        public GeneralizedThingInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeneralizedThingInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<GeneralizedThingInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeneralizedThingInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeneralizedThingInformationNuggetJSON>();
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
    public List<GeneralizedThingInformationNuggetJSON> value;
  };
    class GenericGeneralizedThingInformationNuggetJSON : GeneralizedThingInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericGeneralizedThingInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getGeneralizedThingNuggetKind()  { return key; }
        public override int extraGeneralizedThingInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraGeneralizedThingInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraGeneralizedThingInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraGeneralizedThingInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraGeneralizedThingInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraGeneralizedThingInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraGeneralizedThingInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraGeneralizedThingInformationNuggetAppendPair(key, new_component);
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
    public static new GeneralizedThingInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if ((String.Compare(key, 1, "ontact", 0, 6, false) == 0) && (key.Length == 7))
                return new ContactInformationJSON();
            break;
        case 'E':
            if ((String.Compare(key, 1, "mailAddress", 0, 11, false) == 0) && (key.Length == 12))
                return new EmailAddressInformationJSON();
            break;
        case 'L':
            if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                return new LocationInformationJSON();
            break;
        case 'P':
            if ((String.Compare(key, 1, "honeNumber", 0, 10, false) == 0) && (key.Length == 11))
                return new PhoneNumberInformationJSON();
            break;
        case 'U':
            if ((String.Compare(key, 1, "nknown", 0, 6, false) == 0) && (key.Length == 7))
                return new UnknownInformationJSON();
            break;
        default:
            break;
      }

        return new GenericGeneralizedThingInformationNuggetJSON(key);
      }
  };
