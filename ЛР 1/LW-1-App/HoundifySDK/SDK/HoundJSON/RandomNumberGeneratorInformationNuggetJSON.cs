/* file "RandomNumberGeneratorInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RandomNumberGeneratorInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasRequests;
    private List< RandomNumberGeneratorRequestResultJSON  > storeRequests;
    private bool flagHasIsMetaquery;
    private bool storeIsMetaquery;
    private bool flagHasSpecificMetaquery;
    private bool storeSpecificMetaquery;
    private bool flagHasTooLarge;
    private bool storeTooLarge;


    private JSONValue  extraRequestsToJSON()
      {
        JSONArrayValue generated_array_1_Requests = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRequests.Count; ++num1)
          {
            JSONValueHandler handler_Requests = new JSONValueHandler();
            storeRequests[num1].write_as_json(handler_Requests);
            generated_array_1_Requests.appendComponent(handler_Requests.result);
          }
        return generated_array_1_Requests;
      }

    private JSONValue  extraIsMetaqueryToJSON()
      {
        JSONValue generated_boolean_IsMetaquery = (storeIsMetaquery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsMetaquery;
      }

    private JSONValue  extraSpecificMetaqueryToJSON()
      {
        JSONValue generated_boolean_SpecificMetaquery = (storeSpecificMetaquery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_SpecificMetaquery;
      }

    private JSONValue  extraTooLargeToJSON()
      {
        JSONValue generated_boolean_TooLarge = (storeTooLarge ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_TooLarge;
      }


    private void  fromJSONRequests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Requests of RandomNumberGeneratorInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RandomNumberGeneratorRequestResultJSON  > vector_Requests1 = new List< RandomNumberGeneratorRequestResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RandomNumberGeneratorRequestResultJSON convert_classy = RandomNumberGeneratorRequestResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Requests1.Add(convert_classy);
          }
        initRequests();
        for (int num1 = 0; num1 < vector_Requests1.Count; ++num1)
            appendRequests(vector_Requests1[num1]);
        for (int num1 = 0; num1 < vector_Requests1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIsMetaquery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsMetaquery of RandomNumberGeneratorInformationNuggetJSON is not true for false.");
              }
          }
        setIsMetaquery(the_bool);
      }


    private void  fromJSONSpecificMetaquery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SpecificMetaquery of RandomNumberGeneratorInformationNuggetJSON is not true for false.");
              }
          }
        setSpecificMetaquery(the_bool);
      }


    private void  fromJSONTooLarge(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TooLarge of RandomNumberGeneratorInformationNuggetJSON is not true for false.");
              }
          }
        setTooLarge(the_bool);
      }


    public RandomNumberGeneratorInformationNuggetJSON()
      {
        flagHasRequests = false;
        flagHasIsMetaquery = false;
        flagHasSpecificMetaquery = false;
        flagHasTooLarge = false;
        storeRequests = new List< RandomNumberGeneratorRequestResultJSON  >();
      }

    public override string  getNuggetKind()
      {
        return "RandomNumberGenerator";
      }

    public bool  hasRequests()
      {
        return flagHasRequests;
      }

    public int  countOfRequests()
      {
        Debug.Assert(flagHasRequests);
        return storeRequests.Count;
      }

    public RandomNumberGeneratorRequestResultJSON   elementOfRequests(int element_num)
      {
        Debug.Assert(flagHasRequests);
        return storeRequests[element_num];
      }

    public List< RandomNumberGeneratorRequestResultJSON  >  getRequests()
      {
        Debug.Assert(flagHasRequests);
        return storeRequests;
      }

    public bool  hasIsMetaquery()
      {
        return flagHasIsMetaquery;
      }

    public bool  getIsMetaquery()
      {
        Debug.Assert(flagHasIsMetaquery);
        return storeIsMetaquery;
      }

    public bool  hasSpecificMetaquery()
      {
        return flagHasSpecificMetaquery;
      }

    public bool  getSpecificMetaquery()
      {
        Debug.Assert(flagHasSpecificMetaquery);
        return storeSpecificMetaquery;
      }

    public bool  hasTooLarge()
      {
        return flagHasTooLarge;
      }

    public bool  getTooLarge()
      {
        Debug.Assert(flagHasTooLarge);
        return storeTooLarge;
      }


    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRequests)
            ++result;
        if (flagHasIsMetaquery)
            ++result;
        if (flagHasSpecificMetaquery)
            ++result;
        if (flagHasTooLarge)
            ++result;
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequests)
          {
            if (remainder == 0)
                return "Requests";
            --remainder;
          }
        if (flagHasIsMetaquery)
          {
            if (remainder == 0)
                return "IsMetaquery";
            --remainder;
          }
        if (flagHasSpecificMetaquery)
          {
            if (remainder == 0)
                return "SpecificMetaquery";
            --remainder;
          }
        if (flagHasTooLarge)
          {
            if (remainder == 0)
                return "TooLarge";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequests)
          {
            if (remainder == 0)
                return extraRequestsToJSON();
            --remainder;
          }
        if (flagHasIsMetaquery)
          {
            if (remainder == 0)
                return extraIsMetaqueryToJSON();
            --remainder;
          }
        if (flagHasSpecificMetaquery)
          {
            if (remainder == 0)
                return extraSpecificMetaqueryToJSON();
            --remainder;
          }
        if (flagHasTooLarge)
          {
            if (remainder == 0)
                return extraTooLargeToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sMetaquery", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasIsMetaquery ? extraIsMetaqueryToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equests", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasRequests ? extraRequestsToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "pecificMetaquery", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasSpecificMetaquery ? extraSpecificMetaqueryToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "ooLarge", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasTooLarge ? extraTooLargeToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void initRequests()
      {
        if (flagHasRequests)
          {
            for (int num1 = 0; num1 < storeRequests.Count; ++num1)
              {
              }
          }
        flagHasRequests = true;
        storeRequests.Clear();
      }
    public void appendRequests(RandomNumberGeneratorRequestResultJSON  to_append)
      {
        if (!flagHasRequests)
          {
            flagHasRequests = true;
            storeRequests.Clear();
          }
        Debug.Assert(flagHasRequests);
        storeRequests.Add(to_append);
      }
    public void unsetRequests()
      {
        if (flagHasRequests)
          {
            for (int num2 = 0; num2 < storeRequests.Count; ++num2)
              {
              }
          }
        flagHasRequests = false;
        storeRequests.Clear();
      }
    public void setIsMetaquery(bool new_value)
      {
        flagHasIsMetaquery = true;
        storeIsMetaquery = new_value;
      }
    public void unsetIsMetaquery()
      {
        flagHasIsMetaquery = false;
      }
    public void setSpecificMetaquery(bool new_value)
      {
        flagHasSpecificMetaquery = true;
        storeSpecificMetaquery = new_value;
      }
    public void unsetSpecificMetaquery()
      {
        flagHasSpecificMetaquery = false;
      }
    public void setTooLarge(bool new_value)
      {
        flagHasTooLarge = true;
        storeTooLarge = new_value;
      }
    public void unsetTooLarge()
      {
        flagHasTooLarge = false;
      }

    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sMetaquery", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIsMetaquery(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equests", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONRequests(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pecificMetaquery", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONSpecificMetaquery(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ooLarge", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONTooLarge(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sMetaquery", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIsMetaquery(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equests", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONRequests(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pecificMetaquery", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONSpecificMetaquery(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "ooLarge", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONTooLarge(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
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
        if (flagHasRequests)
          {
            handler.start_pair("Requests");
            handler.start_array();
            for (int num1 = 0; num1 < storeRequests.Count; ++num1)
              {
                if (partial_allowed)
                    storeRequests[num1].write_partial_as_json(handler);
                else
                    storeRequests[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasIsMetaquery);
        if (flagHasIsMetaquery)
          {
            handler.start_pair("IsMetaquery");
            handler.boolean_value(storeIsMetaquery);
          }
        if (flagHasSpecificMetaquery)
          {
            handler.start_pair("SpecificMetaquery");
            handler.boolean_value(storeSpecificMetaquery);
          }
        if (flagHasTooLarge)
          {
            handler.start_pair("TooLarge");
            handler.boolean_value(storeTooLarge);
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
        if (!(hasIsMetaquery()))
          {
            return "When parsing the object for %what%, the \"IsMetaquery\" field was missing.";
          }
        return null;
      }

    public static new RandomNumberGeneratorInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorInformationNugget", ignore_extras);
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
    public static new RandomNumberGeneratorInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorInformationNugget", ignore_extras);
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
    public static new RandomNumberGeneratorInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RandomNumberGeneratorInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RandomNumberGeneratorInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RandomNumberGeneratorInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RandomNumberGeneratorInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator fieldGeneratorRequests;
        private JSONHoldingBooleanGenerator fieldGeneratorIsMetaquery;
        private JSONHoldingBooleanGenerator fieldGeneratorSpecificMetaquery;
        private JSONHoldingBooleanGenerator fieldGeneratorTooLarge;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getInformationNuggetJSONKey().Equals("RandomNumberGenerator")))
                throw new Exception("The key field has a value other than `RandomNumberGenerator'.");
            RandomNumberGeneratorInformationNuggetJSON result = new RandomNumberGeneratorInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RandomNumberGeneratorInformationNuggetJSON )new_result);
          }
        protected void finish(RandomNumberGeneratorInformationNuggetJSON result)
          {
            if (fieldGeneratorRequests.have_value)
              {
                result.initRequests();
                int count = fieldGeneratorRequests.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequests(fieldGeneratorRequests.value[num]);
                  }
                fieldGeneratorRequests.value.Clear();
                fieldGeneratorRequests.have_value = false;
              }
            if (fieldGeneratorIsMetaquery.have_value)
              {
                result.setIsMetaquery(fieldGeneratorIsMetaquery.value);
                fieldGeneratorIsMetaquery.have_value = false;
              }
            else if ((!(result.hasIsMetaquery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsMetaquery\" field was missing.");
              }
            if (fieldGeneratorSpecificMetaquery.have_value)
              {
                result.setSpecificMetaquery(fieldGeneratorSpecificMetaquery.value);
                fieldGeneratorSpecificMetaquery.have_value = false;
              }
            if (fieldGeneratorTooLarge.have_value)
              {
                result.setTooLarge(fieldGeneratorTooLarge.value);
                fieldGeneratorTooLarge.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RandomNumberGeneratorInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sMetaquery", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIsMetaquery;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equests", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorRequests;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecificMetaquery", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorSpecificMetaquery;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ooLarge", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorTooLarge;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRequests = new RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator("field \"Requests\" of the RandomNumberGeneratorInformationNugget class", ignore_extras);
            fieldGeneratorIsMetaquery = new JSONHoldingBooleanGenerator("field \"IsMetaquery\" of the RandomNumberGeneratorInformationNugget class");
            fieldGeneratorSpecificMetaquery = new JSONHoldingBooleanGenerator("field \"SpecificMetaquery\" of the RandomNumberGeneratorInformationNugget class");
            fieldGeneratorTooLarge = new JSONHoldingBooleanGenerator("field \"TooLarge\" of the RandomNumberGeneratorInformationNugget class");
            set_what("the RandomNumberGeneratorInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRequests = new RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator("field \"Requests\" of the RandomNumberGeneratorInformationNugget class", false);
            fieldGeneratorIsMetaquery = new JSONHoldingBooleanGenerator("field \"IsMetaquery\" of the RandomNumberGeneratorInformationNugget class");
            fieldGeneratorSpecificMetaquery = new JSONHoldingBooleanGenerator("field \"SpecificMetaquery\" of the RandomNumberGeneratorInformationNugget class");
            fieldGeneratorTooLarge = new JSONHoldingBooleanGenerator("field \"TooLarge\" of the RandomNumberGeneratorInformationNugget class");
            set_what("the RandomNumberGeneratorInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRequests.reset();
            fieldGeneratorIsMetaquery.reset();
            fieldGeneratorSpecificMetaquery.reset();
            fieldGeneratorTooLarge.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RandomNumberGeneratorInformationNuggetJSON  result)
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
        public RandomNumberGeneratorInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RandomNumberGeneratorInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RandomNumberGeneratorInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RandomNumberGeneratorInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RandomNumberGeneratorInformationNuggetJSON>();
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
    public List<RandomNumberGeneratorInformationNuggetJSON> value;
  };
  };
