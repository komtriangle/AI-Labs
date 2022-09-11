/* file "PointOfSaleProviderConfigurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class PointOfSaleProviderConfigurationJSON : JSONBase
  {
    private bool flagHasProvider;
    private PointOfSalePointOfSaleProviderJSON  storeProvider;
    private bool flagHasProviderFulfillmentRequired;
    private bool storeProviderFulfillmentRequired;


    private void  fromJSONProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PointOfSalePointOfSaleProviderJSON convert_classy = PointOfSalePointOfSaleProviderJSON.from_json(json_value, ignore_extras, true);
        setProvider(convert_classy);
      }


    private void  fromJSONProviderFulfillmentRequired(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ProviderFulfillmentRequired of PointOfSaleProviderConfigurationJSON is not true for false.");
              }
          }
        setProviderFulfillmentRequired(the_bool);
      }


    public PointOfSaleProviderConfigurationJSON()
      {
        flagHasProvider = false;
        flagHasProviderFulfillmentRequired = false;
        storeProviderFulfillmentRequired = false;
      }

    public abstract string getPointOfSaleProviderConfigurationKind();
    public bool  hasProvider()
      {
        return flagHasProvider;
      }

    public PointOfSalePointOfSaleProviderJSON   getProvider()
      {
        Debug.Assert(flagHasProvider);
        return storeProvider;
      }

    public bool  hasProviderFulfillmentRequired()
      {
        return flagHasProviderFulfillmentRequired;
      }

    public bool  getProviderFulfillmentRequired()
      {
        return storeProviderFulfillmentRequired;
      }


    public abstract int extraPointOfSaleProviderConfigurationComponentCount();
    public abstract string extraPointOfSaleProviderConfigurationComponentKey(int component_num);
    public abstract JSONValue extraPointOfSaleProviderConfigurationComponentValue(int component_num);
    public abstract JSONValue extraPointOfSaleProviderConfigurationLookup(string field_name);

    public void setProvider(PointOfSalePointOfSaleProviderJSON  new_value)
      {
        if (flagHasProvider)
          {
          }
        flagHasProvider = true;
        storeProvider = new_value;
      }
    public void unsetProvider()
      {
        if (flagHasProvider)
          {
          }
        flagHasProvider = false;
      }
    public void setProviderFulfillmentRequired(bool new_value)
      {
        flagHasProviderFulfillmentRequired = true;
        storeProviderFulfillmentRequired = new_value;
      }
    public void unsetProviderFulfillmentRequired()
      {
        flagHasProviderFulfillmentRequired = false;
      }

    public abstract void extraPointOfSaleProviderConfigurationAppendPair(string key, JSONValue new_component);
    public abstract void extraPointOfSaleProviderConfigurationSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("PointOfSaleProviderConfigurationKind", getPointOfSaleProviderConfigurationKind());
        Debug.Assert(partial_allowed || flagHasProvider);
        if (flagHasProvider)
          {
            handler.start_pair("Provider");
            if (partial_allowed)
                storeProvider.write_partial_as_json(handler);
            else
                storeProvider.write_as_json(handler);
          }
        if (flagHasProviderFulfillmentRequired)
          {
            handler.start_pair("ProviderFulfillmentRequired");
            handler.boolean_value(storeProviderFulfillmentRequired);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasProvider()))
          {
            return "When parsing the object for %what%, the \"Provider\" field was missing.";
          }
        return null;
      }

    public static PointOfSaleProviderConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PointOfSaleProviderConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PointOfSaleProviderConfiguration", ignore_extras);
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
    public static PointOfSaleProviderConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PointOfSaleProviderConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PointOfSaleProviderConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PointOfSaleProviderConfiguration", ignore_extras);
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
    public static PointOfSaleProviderConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PointOfSaleProviderConfigurationJSON from_text(string text, bool ignore_extras)
      {
        PointOfSaleProviderConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PointOfSaleProviderConfiguration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PointOfSaleProviderConfigurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PointOfSaleProviderConfigurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PointOfSaleProviderConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PointOfSaleProviderConfiguration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private PointOfSalePointOfSaleProviderJSON.HoldingGenerator fieldGeneratorProvider;
        private JSONHoldingBooleanGenerator fieldGeneratorProviderFulfillmentRequired;
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
            if (!(keyGenerator.have_value))
                throw new Exception("The `PointOfSaleProviderConfigurationKind' field is missing.");
            PointOfSaleProviderConfigurationJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPointOfSaleProviderConfigurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getPointOfSaleProviderConfigurationJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `PointOfSaleProviderConfigurationKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(PointOfSaleProviderConfigurationJSON result)
          {
            if (fieldGeneratorProvider.have_value)
              {
                result.setProvider(fieldGeneratorProvider.value);
                fieldGeneratorProvider.have_value = false;
              }
            else if ((!(result.hasProvider())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Provider\" field was missing.");
              }
            if (fieldGeneratorProviderFulfillmentRequired.have_value)
              {
                result.setProviderFulfillmentRequired(fieldGeneratorProviderFulfillmentRequired.value);
                fieldGeneratorProviderFulfillmentRequired.have_value = false;
              }
          }
        protected abstract void handle_result(PointOfSaleProviderConfigurationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "P", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'o':
                        if ((String.Compare(field_name, 2, "intOfSaleProviderConfigurationKind", 0, 34, false) == 0) && (field_name.Length == 36))
                            {
                            keyGenerator.reset();
                            return keyGenerator;
                            }
                        break;
                    case 'r':
                        if (String.Compare(field_name, 2, "ovider", 0, 6, false) == 0)
                          {
                            if (field_name.Length == 8)
                              {
                                return fieldGeneratorProvider;
                              }
                            switch (field_name[8])
                              {
                                case 'F':
                                    if ((String.Compare(field_name, 9, "ulfillmentRequired", 0, 18, false) == 0) && (field_name.Length == 27))
                                        return fieldGeneratorProviderFulfillmentRequired;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProvider = new PointOfSalePointOfSaleProviderJSON.HoldingGenerator("field \"Provider\" of the PointOfSaleProviderConfiguration class", ignore_extras);
            fieldGeneratorProviderFulfillmentRequired = new JSONHoldingBooleanGenerator("field \"ProviderFulfillmentRequired\" of the PointOfSaleProviderConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PointOfSaleProviderConfigurationKind\" of the PointOfSaleProviderConfiguration class");
            set_what("the PointOfSaleProviderConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProvider = new PointOfSalePointOfSaleProviderJSON.HoldingGenerator("field \"Provider\" of the PointOfSaleProviderConfiguration class", false);
            fieldGeneratorProviderFulfillmentRequired = new JSONHoldingBooleanGenerator("field \"ProviderFulfillmentRequired\" of the PointOfSaleProviderConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"PointOfSaleProviderConfigurationKind\" of the PointOfSaleProviderConfiguration class");
            set_what("the PointOfSaleProviderConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProvider.reset();
            fieldGeneratorProviderFulfillmentRequired.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorProvider.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorProvider.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PointOfSaleProviderConfigurationJSON  result)
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
        public PointOfSaleProviderConfigurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PointOfSaleProviderConfigurationJSON  result)
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
    protected virtual void handle_result(List<PointOfSaleProviderConfigurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PointOfSaleProviderConfigurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PointOfSaleProviderConfigurationJSON>();
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
    public List<PointOfSaleProviderConfigurationJSON> value;
  };
    class GenericPointOfSaleProviderConfigurationJSON : PointOfSaleProviderConfigurationJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericPointOfSaleProviderConfigurationJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getPointOfSaleProviderConfigurationKind()  { return key; }
        public override int extraPointOfSaleProviderConfigurationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraPointOfSaleProviderConfigurationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraPointOfSaleProviderConfigurationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraPointOfSaleProviderConfigurationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraPointOfSaleProviderConfigurationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraPointOfSaleProviderConfigurationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraPointOfSaleProviderConfigurationLookup(key);
            if (old_field == null)
              {
                extraPointOfSaleProviderConfigurationAppendPair(key, new_component);
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
    public static PointOfSaleProviderConfigurationJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericPointOfSaleProviderConfigurationJSON(key);
      }
  };
