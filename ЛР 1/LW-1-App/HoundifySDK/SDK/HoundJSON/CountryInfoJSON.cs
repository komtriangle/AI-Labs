/* file "CountryInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CountryInfoJSON : CountryProfileJSON
  {
    public class TypePopulationJSON : JSONBase
      {
        private bool flagHasAmount;
        private AmountJSON  storeAmount;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONAmount(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
            setAmount(convert_classy);
          }


        public TypePopulationJSON()
          {
            flagHasAmount = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasAmount()
          {
            return flagHasAmount;
          }

        public AmountJSON   getAmount()
          {
            Debug.Assert(flagHasAmount);
            return storeAmount;
          }


        public virtual int extraTypePopulationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePopulationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePopulationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePopulationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setAmount(AmountJSON  new_value)
          {
            if (flagHasAmount)
              {
              }
            flagHasAmount = true;
            storeAmount = new_value;
          }
        public void unsetAmount()
          {
            if (flagHasAmount)
              {
              }
            flagHasAmount = false;
          }

        public virtual void extraTypePopulationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePopulationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePopulationLookup(key);
            if (old_field == null)
              {
                extraTypePopulationAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasAmount);
            if (flagHasAmount)
              {
                handler.start_pair("Amount");
                if (partial_allowed)
                    storeAmount.write_partial_as_json(handler);
                else
                    storeAmount.write_as_json(handler);
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
            if (!(hasAmount()))
              {
                return "When parsing the object for %what%, the \"Amount\" field was missing.";
              }
            return null;
          }

        public static TypePopulationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePopulationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePopulation", ignore_extras);
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
        public static TypePopulationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePopulationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePopulationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePopulation", ignore_extras);
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
        public static TypePopulationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePopulationJSON from_text(string text, bool ignore_extras)
          {
            TypePopulationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePopulation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePopulationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePopulationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePopulationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePopulation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private AmountJSON.HoldingGenerator fieldGeneratorAmount;
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
                TypePopulationJSON result = new TypePopulationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePopulationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePopulationJSON result)
              {
                if (fieldGeneratorAmount.have_value)
                  {
                    result.setAmount(fieldGeneratorAmount.value);
                    fieldGeneratorAmount.have_value = false;
                  }
                else if ((!(result.hasAmount())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Amount\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePopulationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Amount", 0, 6, false) == 0) && (field_name.Length == 6))
                    return fieldGeneratorAmount;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAmount = new AmountJSON.HoldingGenerator("field \"Amount\" of the TypePopulation class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePopulation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAmount = new AmountJSON.HoldingGenerator("field \"Amount\" of the TypePopulation class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePopulation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAmount.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAmount.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAmount.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePopulationJSON  result)
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
            public TypePopulationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePopulationJSON  result)
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
        protected virtual void handle_result(List<TypePopulationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePopulationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePopulationJSON>();
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
        public List<TypePopulationJSON> value;
      };
      };
    private bool flagHasSummary;
    private WrittenSpokenStringJSON  storeSummary;
    private bool flagHasLeader;
    private WhoJSON  storeLeader;
    private bool flagHasCapital;
    private List< MapLocationJSON  > storeCapital;
    private bool flagHasInception;
    private WhenJSON  storeInception;
    private bool flagHasPopulation;
    private TypePopulationJSON  storePopulation;
    private bool flagHasContinent;
    private List< MapLocationJSON  > storeContinent;
    private bool flagHasCurrency;
    private List< WrittenSpokenStringJSON  > storeCurrency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSummaryToJSON()
      {
        JSONValueHandler handler_Summary = new JSONValueHandler();
        storeSummary.write_as_json(handler_Summary);
        return handler_Summary.result;
      }

    private JSONValue  extraLeaderToJSON()
      {
        JSONValueHandler handler_Leader = new JSONValueHandler();
        storeLeader.write_as_json(handler_Leader);
        return handler_Leader.result;
      }

    private JSONValue  extraCapitalToJSON()
      {
        JSONArrayValue generated_array_1_Capital = new JSONArrayValue();
        for (int num1 = 0; num1 < storeCapital.Count; ++num1)
          {
            JSONValueHandler handler_Capital = new JSONValueHandler();
            storeCapital[num1].write_as_json(handler_Capital);
            generated_array_1_Capital.appendComponent(handler_Capital.result);
          }
        return generated_array_1_Capital;
      }

    private JSONValue  extraInceptionToJSON()
      {
        JSONValueHandler handler_Inception = new JSONValueHandler();
        storeInception.write_as_json(handler_Inception);
        return handler_Inception.result;
      }

    private JSONValue  extraPopulationToJSON()
      {
        JSONValueHandler handler_Population = new JSONValueHandler();
        storePopulation.write_as_json(handler_Population);
        return handler_Population.result;
      }

    private JSONValue  extraContinentToJSON()
      {
        JSONArrayValue generated_array_2_Continent = new JSONArrayValue();
        for (int num2 = 0; num2 < storeContinent.Count; ++num2)
          {
            JSONValueHandler handler_Continent = new JSONValueHandler();
            storeContinent[num2].write_as_json(handler_Continent);
            generated_array_2_Continent.appendComponent(handler_Continent.result);
          }
        return generated_array_2_Continent;
      }

    private JSONValue  extraCurrencyToJSON()
      {
        JSONArrayValue generated_array_3_Currency = new JSONArrayValue();
        for (int num3 = 0; num3 < storeCurrency.Count; ++num3)
          {
            JSONValueHandler handler_Currency = new JSONValueHandler();
            storeCurrency[num3].write_as_json(handler_Currency);
            generated_array_3_Currency.appendComponent(handler_Currency.result);
          }
        return generated_array_3_Currency;
      }


    private void  fromJSONSummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_value, ignore_extras, true);
        setSummary(convert_classy);
      }


    private void  fromJSONLeader(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhoJSON convert_classy = WhoJSON.from_json(json_value, ignore_extras, true);
        setLeader(convert_classy);
      }


    private void  fromJSONCapital(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Capital of CountryInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MapLocationJSON  > vector_Capital1 = new List< MapLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MapLocationJSON convert_classy = MapLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Capital1.Add(convert_classy);
          }
        initCapital();
        for (int num1 = 0; num1 < vector_Capital1.Count; ++num1)
            appendCapital(vector_Capital1[num1]);
        for (int num1 = 0; num1 < vector_Capital1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInception(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhenJSON convert_classy = WhenJSON.from_json(json_value, ignore_extras, true);
        setInception(convert_classy);
      }


    private void  fromJSONPopulation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypePopulationJSON convert_classy = TypePopulationJSON.from_json(json_value, ignore_extras, true);
        setPopulation(convert_classy);
      }


    private void  fromJSONContinent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Continent of CountryInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MapLocationJSON  > vector_Continent1 = new List< MapLocationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MapLocationJSON convert_classy = MapLocationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Continent1.Add(convert_classy);
          }
        initContinent();
        for (int num2 = 0; num2 < vector_Continent1.Count; ++num2)
            appendContinent(vector_Continent1[num2]);
        for (int num1 = 0; num1 < vector_Continent1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Currency of CountryInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WrittenSpokenStringJSON  > vector_Currency1 = new List< WrittenSpokenStringJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Currency1.Add(convert_classy);
          }
        initCurrency();
        for (int num3 = 0; num3 < vector_Currency1.Count; ++num3)
            appendCurrency(vector_Currency1[num3]);
        for (int num1 = 0; num1 < vector_Currency1.Count; ++num1)
          {
          }
      }


    public CountryInfoJSON()
      {
        flagHasSummary = false;
        flagHasLeader = false;
        flagHasCapital = false;
        flagHasInception = false;
        flagHasPopulation = false;
        flagHasContinent = false;
        flagHasCurrency = false;
        storeCapital = new List< MapLocationJSON  >();
        storeContinent = new List< MapLocationJSON  >();
        storeCurrency = new List< WrittenSpokenStringJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSummary()
      {
        return flagHasSummary;
      }

    public WrittenSpokenStringJSON   getSummary()
      {
        Debug.Assert(flagHasSummary);
        return storeSummary;
      }

    public bool  hasLeader()
      {
        return flagHasLeader;
      }

    public WhoJSON   getLeader()
      {
        Debug.Assert(flagHasLeader);
        return storeLeader;
      }

    public bool  hasCapital()
      {
        return flagHasCapital;
      }

    public int  countOfCapital()
      {
        Debug.Assert(flagHasCapital);
        return storeCapital.Count;
      }

    public MapLocationJSON   elementOfCapital(int element_num)
      {
        Debug.Assert(flagHasCapital);
        return storeCapital[element_num];
      }

    public List< MapLocationJSON  >  getCapital()
      {
        Debug.Assert(flagHasCapital);
        return storeCapital;
      }

    public bool  hasInception()
      {
        return flagHasInception;
      }

    public WhenJSON   getInception()
      {
        Debug.Assert(flagHasInception);
        return storeInception;
      }

    public bool  hasPopulation()
      {
        return flagHasPopulation;
      }

    public TypePopulationJSON   getPopulation()
      {
        Debug.Assert(flagHasPopulation);
        return storePopulation;
      }

    public bool  hasContinent()
      {
        return flagHasContinent;
      }

    public int  countOfContinent()
      {
        Debug.Assert(flagHasContinent);
        return storeContinent.Count;
      }

    public MapLocationJSON   elementOfContinent(int element_num)
      {
        Debug.Assert(flagHasContinent);
        return storeContinent[element_num];
      }

    public List< MapLocationJSON  >  getContinent()
      {
        Debug.Assert(flagHasContinent);
        return storeContinent;
      }

    public bool  hasCurrency()
      {
        return flagHasCurrency;
      }

    public int  countOfCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency.Count;
      }

    public WrittenSpokenStringJSON   elementOfCurrency(int element_num)
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency[element_num];
      }

    public List< WrittenSpokenStringJSON  >  getCurrency()
      {
        Debug.Assert(flagHasCurrency);
        return storeCurrency;
      }


    public virtual int extraCountryInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCountryInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCountryInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCountryInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCountryProfileComponentCount()
      {
        int result = 0;
        if (flagHasSummary)
            ++result;
        if (flagHasLeader)
            ++result;
        if (flagHasCapital)
            ++result;
        if (flagHasInception)
            ++result;
        if (flagHasPopulation)
            ++result;
        if (flagHasContinent)
            ++result;
        if (flagHasCurrency)
            ++result;
        result += extraCountryInfoComponentCount();
        return result;
      }
    public override string extraCountryProfileComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSummary)
          {
            if (remainder == 0)
                return "Summary";
            --remainder;
          }
        if (flagHasLeader)
          {
            if (remainder == 0)
                return "Leader";
            --remainder;
          }
        if (flagHasCapital)
          {
            if (remainder == 0)
                return "Capital";
            --remainder;
          }
        if (flagHasInception)
          {
            if (remainder == 0)
                return "Inception";
            --remainder;
          }
        if (flagHasPopulation)
          {
            if (remainder == 0)
                return "Population";
            --remainder;
          }
        if (flagHasContinent)
          {
            if (remainder == 0)
                return "Continent";
            --remainder;
          }
        if (flagHasCurrency)
          {
            if (remainder == 0)
                return "Currency";
            --remainder;
          }
        return extraCountryInfoComponentKey(remainder);
      }
    public override JSONValue extraCountryProfileComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSummary)
          {
            if (remainder == 0)
                return extraSummaryToJSON();
            --remainder;
          }
        if (flagHasLeader)
          {
            if (remainder == 0)
                return extraLeaderToJSON();
            --remainder;
          }
        if (flagHasCapital)
          {
            if (remainder == 0)
                return extraCapitalToJSON();
            --remainder;
          }
        if (flagHasInception)
          {
            if (remainder == 0)
                return extraInceptionToJSON();
            --remainder;
          }
        if (flagHasPopulation)
          {
            if (remainder == 0)
                return extraPopulationToJSON();
            --remainder;
          }
        if (flagHasContinent)
          {
            if (remainder == 0)
                return extraContinentToJSON();
            --remainder;
          }
        if (flagHasCurrency)
          {
            if (remainder == 0)
                return extraCurrencyToJSON();
            --remainder;
          }
        return extraCountryInfoComponentValue(remainder);
      }
    public override JSONValue extraCountryProfileLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "pital", 0, 5, false) == 0) && (field_name.Length == 7))
                            return (flagHasCapital ? extraCapitalToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "ntinent", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasContinent ? extraContinentToJSON() : null);
                        break;
                    case 'u':
                        if ((String.Compare(field_name, 2, "rrency", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasCurrency ? extraCurrencyToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "nception", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasInception ? extraInceptionToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "eader", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasLeader ? extraLeaderToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "opulation", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasPopulation ? extraPopulationToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ummary", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasSummary ? extraSummaryToJSON() : null);
                break;
            default:
                break;
          }
        return extraCountryInfoLookup(field_name);
      }

    public void setSummary(WrittenSpokenStringJSON  new_value)
      {
        if (flagHasSummary)
          {
          }
        flagHasSummary = true;
        storeSummary = new_value;
      }
    public void unsetSummary()
      {
        if (flagHasSummary)
          {
          }
        flagHasSummary = false;
      }
    public void setLeader(WhoJSON  new_value)
      {
        if (flagHasLeader)
          {
          }
        flagHasLeader = true;
        storeLeader = new_value;
      }
    public void unsetLeader()
      {
        if (flagHasLeader)
          {
          }
        flagHasLeader = false;
      }
    public void initCapital()
      {
        if (flagHasCapital)
          {
            for (int num1 = 0; num1 < storeCapital.Count; ++num1)
              {
              }
          }
        flagHasCapital = true;
        storeCapital.Clear();
      }
    public void appendCapital(MapLocationJSON  to_append)
      {
        if (!flagHasCapital)
          {
            flagHasCapital = true;
            storeCapital.Clear();
          }
        Debug.Assert(flagHasCapital);
        storeCapital.Add(to_append);
      }
    public void unsetCapital()
      {
        if (flagHasCapital)
          {
            for (int num2 = 0; num2 < storeCapital.Count; ++num2)
              {
              }
          }
        flagHasCapital = false;
        storeCapital.Clear();
      }
    public void setInception(WhenJSON  new_value)
      {
        if (flagHasInception)
          {
          }
        flagHasInception = true;
        storeInception = new_value;
      }
    public void unsetInception()
      {
        if (flagHasInception)
          {
          }
        flagHasInception = false;
      }
    public void setPopulation(TypePopulationJSON  new_value)
      {
        if (flagHasPopulation)
          {
          }
        flagHasPopulation = true;
        storePopulation = new_value;
      }
    public void unsetPopulation()
      {
        if (flagHasPopulation)
          {
          }
        flagHasPopulation = false;
      }
    public void initContinent()
      {
        if (flagHasContinent)
          {
            for (int num3 = 0; num3 < storeContinent.Count; ++num3)
              {
              }
          }
        flagHasContinent = true;
        storeContinent.Clear();
      }
    public void appendContinent(MapLocationJSON  to_append)
      {
        if (!flagHasContinent)
          {
            flagHasContinent = true;
            storeContinent.Clear();
          }
        Debug.Assert(flagHasContinent);
        storeContinent.Add(to_append);
      }
    public void unsetContinent()
      {
        if (flagHasContinent)
          {
            for (int num4 = 0; num4 < storeContinent.Count; ++num4)
              {
              }
          }
        flagHasContinent = false;
        storeContinent.Clear();
      }
    public void initCurrency()
      {
        if (flagHasCurrency)
          {
            for (int num5 = 0; num5 < storeCurrency.Count; ++num5)
              {
              }
          }
        flagHasCurrency = true;
        storeCurrency.Clear();
      }
    public void appendCurrency(WrittenSpokenStringJSON  to_append)
      {
        if (!flagHasCurrency)
          {
            flagHasCurrency = true;
            storeCurrency.Clear();
          }
        Debug.Assert(flagHasCurrency);
        storeCurrency.Add(to_append);
      }
    public void unsetCurrency()
      {
        if (flagHasCurrency)
          {
            for (int num6 = 0; num6 < storeCurrency.Count; ++num6)
              {
              }
          }
        flagHasCurrency = false;
        storeCurrency.Clear();
      }

    public virtual void extraCountryInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCountryInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCountryInfoLookup(key);
        if (old_field == null)
          {
            extraCountryInfoAppendPair(key, new_component);
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
    public override void extraCountryProfileAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "pital", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONCapital(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ntinent", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONContinent(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "rrency", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONCurrency(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nception", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONInception(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "eader", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONLeader(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "opulation", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONPopulation(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ummary", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONSummary(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCountryInfoAppendPair(key, new_component);
      }
    public override void extraCountryProfileSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "pital", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONCapital(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ntinent", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONContinent(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if ((String.Compare(key, 2, "rrency", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONCurrency(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nception", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONInception(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "eader", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONLeader(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "opulation", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONPopulation(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ummary", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONSummary(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraCountryInfoSetField(key, new_component);
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
        if (flagHasSummary)
          {
            handler.start_pair("Summary");
            if (partial_allowed)
                storeSummary.write_partial_as_json(handler);
            else
                storeSummary.write_as_json(handler);
          }
        if (flagHasLeader)
          {
            handler.start_pair("Leader");
            if (partial_allowed)
                storeLeader.write_partial_as_json(handler);
            else
                storeLeader.write_as_json(handler);
          }
        if (flagHasCapital)
          {
            handler.start_pair("Capital");
            handler.start_array();
            for (int num1 = 0; num1 < storeCapital.Count; ++num1)
              {
                if (partial_allowed)
                    storeCapital[num1].write_partial_as_json(handler);
                else
                    storeCapital[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInception)
          {
            handler.start_pair("Inception");
            if (partial_allowed)
                storeInception.write_partial_as_json(handler);
            else
                storeInception.write_as_json(handler);
          }
        if (flagHasPopulation)
          {
            handler.start_pair("Population");
            if (partial_allowed)
                storePopulation.write_partial_as_json(handler);
            else
                storePopulation.write_as_json(handler);
          }
        if (flagHasContinent)
          {
            handler.start_pair("Continent");
            handler.start_array();
            for (int num2 = 0; num2 < storeContinent.Count; ++num2)
              {
                if (partial_allowed)
                    storeContinent[num2].write_partial_as_json(handler);
                else
                    storeContinent[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCurrency)
          {
            handler.start_pair("Currency");
            handler.start_array();
            for (int num3 = 0; num3 < storeCurrency.Count; ++num3)
              {
                if (partial_allowed)
                    storeCurrency[num3].write_partial_as_json(handler);
                else
                    storeCurrency[num3].write_as_json(handler);
              }
            handler.finish_array();
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
        return null;
      }

    public static new CountryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CountryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryInfo", ignore_extras);
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
    public static new CountryInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CountryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CountryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryInfo", ignore_extras);
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
    public static new CountryInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CountryInfoJSON from_text(string text, bool ignore_extras)
      {
        CountryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CountryInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CountryInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CountryInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CountryInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CountryProfileJSON.Generator
      {
        private WrittenSpokenStringJSON.HoldingGenerator fieldGeneratorSummary;
        private WhoJSON.HoldingGenerator fieldGeneratorLeader;
        private MapLocationJSON.HoldingArrayGenerator fieldGeneratorCapital;
        private WhenJSON.HoldingGenerator fieldGeneratorInception;
        private TypePopulationJSON.HoldingGenerator fieldGeneratorPopulation;
        private MapLocationJSON.HoldingArrayGenerator fieldGeneratorContinent;
        private WrittenSpokenStringJSON.HoldingArrayGenerator fieldGeneratorCurrency;
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
            CountryInfoJSON result = new CountryInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCountryInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CountryProfileJSON new_result)
          {
            handle_result((CountryInfoJSON )new_result);
          }
        protected void finish(CountryInfoJSON result)
          {
            if (fieldGeneratorSummary.have_value)
              {
                result.setSummary(fieldGeneratorSummary.value);
                fieldGeneratorSummary.have_value = false;
              }
            if (fieldGeneratorLeader.have_value)
              {
                result.setLeader(fieldGeneratorLeader.value);
                fieldGeneratorLeader.have_value = false;
              }
            if (fieldGeneratorCapital.have_value)
              {
                result.initCapital();
                int count = fieldGeneratorCapital.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCapital(fieldGeneratorCapital.value[num]);
                  }
                fieldGeneratorCapital.value.Clear();
                fieldGeneratorCapital.have_value = false;
              }
            if (fieldGeneratorInception.have_value)
              {
                result.setInception(fieldGeneratorInception.value);
                fieldGeneratorInception.have_value = false;
              }
            if (fieldGeneratorPopulation.have_value)
              {
                result.setPopulation(fieldGeneratorPopulation.value);
                fieldGeneratorPopulation.have_value = false;
              }
            if (fieldGeneratorContinent.have_value)
              {
                result.initContinent();
                int count = fieldGeneratorContinent.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContinent(fieldGeneratorContinent.value[num]);
                  }
                fieldGeneratorContinent.value.Clear();
                fieldGeneratorContinent.have_value = false;
              }
            if (fieldGeneratorCurrency.have_value)
              {
                result.initCurrency();
                int count = fieldGeneratorCurrency.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCurrency(fieldGeneratorCurrency.value[num]);
                  }
                fieldGeneratorCurrency.value.Clear();
                fieldGeneratorCurrency.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CountryInfoJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "pital", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorCapital;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ntinent", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorContinent;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rrency", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCurrency;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nception", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorInception;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eader", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLeader;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "opulation", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPopulation;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ummary", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorSummary;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSummary = new WrittenSpokenStringJSON.HoldingGenerator("field \"Summary\" of the CountryInfo class", ignore_extras);
            fieldGeneratorLeader = new WhoJSON.HoldingGenerator("field \"Leader\" of the CountryInfo class", ignore_extras);
            fieldGeneratorCapital = new MapLocationJSON.HoldingArrayGenerator("field \"Capital\" of the CountryInfo class", ignore_extras);
            fieldGeneratorInception = new WhenJSON.HoldingGenerator("field \"Inception\" of the CountryInfo class", ignore_extras);
            fieldGeneratorPopulation = new TypePopulationJSON.HoldingGenerator("field \"Population\" of the CountryInfo class", ignore_extras);
            fieldGeneratorContinent = new MapLocationJSON.HoldingArrayGenerator("field \"Continent\" of the CountryInfo class", ignore_extras);
            fieldGeneratorCurrency = new WrittenSpokenStringJSON.HoldingArrayGenerator("field \"Currency\" of the CountryInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CountryInfo class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSummary = new WrittenSpokenStringJSON.HoldingGenerator("field \"Summary\" of the CountryInfo class", false);
            fieldGeneratorLeader = new WhoJSON.HoldingGenerator("field \"Leader\" of the CountryInfo class", false);
            fieldGeneratorCapital = new MapLocationJSON.HoldingArrayGenerator("field \"Capital\" of the CountryInfo class", false);
            fieldGeneratorInception = new WhenJSON.HoldingGenerator("field \"Inception\" of the CountryInfo class", false);
            fieldGeneratorPopulation = new TypePopulationJSON.HoldingGenerator("field \"Population\" of the CountryInfo class", false);
            fieldGeneratorContinent = new MapLocationJSON.HoldingArrayGenerator("field \"Continent\" of the CountryInfo class", false);
            fieldGeneratorCurrency = new WrittenSpokenStringJSON.HoldingArrayGenerator("field \"Currency\" of the CountryInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CountryInfo class");
          }

        public override void reset()
          {
            fieldGeneratorSummary.reset();
            fieldGeneratorLeader.reset();
            fieldGeneratorCapital.reset();
            fieldGeneratorInception.reset();
            fieldGeneratorPopulation.reset();
            fieldGeneratorContinent.reset();
            fieldGeneratorCurrency.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CountryInfoJSON  result)
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
        public CountryInfoJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CountryInfoJSON  result)
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
    protected virtual void handle_result(List<CountryInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CountryInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CountryInfoJSON>();
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
    public List<CountryInfoJSON> value;
  };
    public static new CountryInfoJSON from_MapLocationJSON_json(MapLocationJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        CountryInfoJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type CountryInfo", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
    public static CountryInfoJSON from_CountryProfileJSON_json(CountryProfileJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        CountryInfoJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type CountryInfo", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
