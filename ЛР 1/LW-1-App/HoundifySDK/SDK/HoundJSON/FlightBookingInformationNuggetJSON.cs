/* file "FlightBookingInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightBookingInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasFlightBookingSearchSpec;
    private FlightBookingSearchSpecJSON  storeFlightBookingSearchSpec;
    private bool flagHasCurrentDateAndTime;
    private FlightTimesJSON  storeCurrentDateAndTime;
    private bool flagHasFlightProducts;
    private List< FlightProductJSON  > storeFlightProducts;
    private bool flagHasFlightSegments;
    private List< FlightSegmentJSON  > storeFlightSegments;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraFlightBookingSearchSpecToJSON()
      {
        JSONValueHandler handler_FlightBookingSearchSpec = new JSONValueHandler();
        storeFlightBookingSearchSpec.write_as_json(handler_FlightBookingSearchSpec);
        return handler_FlightBookingSearchSpec.result;
      }

    private JSONValue  extraCurrentDateAndTimeToJSON()
      {
        JSONValueHandler handler_CurrentDateAndTime = new JSONValueHandler();
        storeCurrentDateAndTime.write_as_json(handler_CurrentDateAndTime);
        return handler_CurrentDateAndTime.result;
      }

    private JSONValue  extraFlightProductsToJSON()
      {
        JSONArrayValue generated_array_1_FlightProducts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeFlightProducts.Count; ++num1)
          {
            JSONValueHandler handler_FlightProducts = new JSONValueHandler();
            storeFlightProducts[num1].write_as_json(handler_FlightProducts);
            generated_array_1_FlightProducts.appendComponent(handler_FlightProducts.result);
          }
        return generated_array_1_FlightProducts;
      }

    private JSONValue  extraFlightSegmentsToJSON()
      {
        JSONArrayValue generated_array_2_FlightSegments = new JSONArrayValue();
        for (int num2 = 0; num2 < storeFlightSegments.Count; ++num2)
          {
            JSONValueHandler handler_FlightSegments = new JSONValueHandler();
            storeFlightSegments[num2].write_as_json(handler_FlightSegments);
            generated_array_2_FlightSegments.appendComponent(handler_FlightSegments.result);
          }
        return generated_array_2_FlightSegments;
      }


    private void  fromJSONFlightBookingSearchSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightBookingSearchSpecJSON convert_classy = FlightBookingSearchSpecJSON.from_json(json_value, ignore_extras, true);
        setFlightBookingSearchSpec(convert_classy);
      }


    private void  fromJSONCurrentDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setCurrentDateAndTime(convert_classy);
      }


    private void  fromJSONFlightProducts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightProducts of FlightBookingInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightProductJSON  > vector_FlightProducts1 = new List< FlightProductJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightProductJSON convert_classy = FlightProductJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightProducts1.Add(convert_classy);
          }
        initFlightProducts();
        for (int num1 = 0; num1 < vector_FlightProducts1.Count; ++num1)
            appendFlightProducts(vector_FlightProducts1[num1]);
        for (int num1 = 0; num1 < vector_FlightProducts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFlightSegments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightSegments of FlightBookingInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightSegmentJSON  > vector_FlightSegments1 = new List< FlightSegmentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentJSON convert_classy = FlightSegmentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightSegments1.Add(convert_classy);
          }
        initFlightSegments();
        for (int num2 = 0; num2 < vector_FlightSegments1.Count; ++num2)
            appendFlightSegments(vector_FlightSegments1[num2]);
        for (int num1 = 0; num1 < vector_FlightSegments1.Count; ++num1)
          {
          }
      }


    public FlightBookingInformationNuggetJSON()
      {
        flagHasFlightBookingSearchSpec = false;
        flagHasCurrentDateAndTime = false;
        flagHasFlightProducts = false;
        flagHasFlightSegments = false;
        storeFlightProducts = new List< FlightProductJSON  >();
        storeFlightSegments = new List< FlightSegmentJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "FlightBooking";
      }

    public bool  hasFlightBookingSearchSpec()
      {
        return flagHasFlightBookingSearchSpec;
      }

    public FlightBookingSearchSpecJSON   getFlightBookingSearchSpec()
      {
        Debug.Assert(flagHasFlightBookingSearchSpec);
        return storeFlightBookingSearchSpec;
      }

    public bool  hasCurrentDateAndTime()
      {
        return flagHasCurrentDateAndTime;
      }

    public FlightTimesJSON   getCurrentDateAndTime()
      {
        Debug.Assert(flagHasCurrentDateAndTime);
        return storeCurrentDateAndTime;
      }

    public bool  hasFlightProducts()
      {
        return flagHasFlightProducts;
      }

    public int  countOfFlightProducts()
      {
        Debug.Assert(flagHasFlightProducts);
        return storeFlightProducts.Count;
      }

    public FlightProductJSON   elementOfFlightProducts(int element_num)
      {
        Debug.Assert(flagHasFlightProducts);
        return storeFlightProducts[element_num];
      }

    public List< FlightProductJSON  >  getFlightProducts()
      {
        Debug.Assert(flagHasFlightProducts);
        return storeFlightProducts;
      }

    public bool  hasFlightSegments()
      {
        return flagHasFlightSegments;
      }

    public int  countOfFlightSegments()
      {
        Debug.Assert(flagHasFlightSegments);
        return storeFlightSegments.Count;
      }

    public FlightSegmentJSON   elementOfFlightSegments(int element_num)
      {
        Debug.Assert(flagHasFlightSegments);
        return storeFlightSegments[element_num];
      }

    public List< FlightSegmentJSON  >  getFlightSegments()
      {
        Debug.Assert(flagHasFlightSegments);
        return storeFlightSegments;
      }


    public virtual int extraFlightBookingInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightBookingInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightBookingInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightBookingInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasFlightBookingSearchSpec)
            ++result;
        if (flagHasCurrentDateAndTime)
            ++result;
        if (flagHasFlightProducts)
            ++result;
        if (flagHasFlightSegments)
            ++result;
        result += extraFlightBookingInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasFlightBookingSearchSpec)
          {
            if (remainder == 0)
                return "FlightBookingSearchSpec";
            --remainder;
          }
        if (flagHasCurrentDateAndTime)
          {
            if (remainder == 0)
                return "CurrentDateAndTime";
            --remainder;
          }
        if (flagHasFlightProducts)
          {
            if (remainder == 0)
                return "FlightProducts";
            --remainder;
          }
        if (flagHasFlightSegments)
          {
            if (remainder == 0)
                return "FlightSegments";
            --remainder;
          }
        return extraFlightBookingInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasFlightBookingSearchSpec)
          {
            if (remainder == 0)
                return extraFlightBookingSearchSpecToJSON();
            --remainder;
          }
        if (flagHasCurrentDateAndTime)
          {
            if (remainder == 0)
                return extraCurrentDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasFlightProducts)
          {
            if (remainder == 0)
                return extraFlightProductsToJSON();
            --remainder;
          }
        if (flagHasFlightSegments)
          {
            if (remainder == 0)
                return extraFlightSegmentsToJSON();
            --remainder;
          }
        return extraFlightBookingInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasCurrentDateAndTime ? extraCurrentDateAndTimeToJSON() : null);
                break;
            case 'F':
                if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'B':
                            if ((String.Compare(field_name, 7, "ookingSearchSpec", 0, 16, false) == 0) && (field_name.Length == 23))
                                return (flagHasFlightBookingSearchSpec ? extraFlightBookingSearchSpecToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 7, "roducts", 0, 7, false) == 0) && (field_name.Length == 14))
                                return (flagHasFlightProducts ? extraFlightProductsToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 7, "egments", 0, 7, false) == 0) && (field_name.Length == 14))
                                return (flagHasFlightSegments ? extraFlightSegmentsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraFlightBookingInformationNuggetLookup(field_name);
      }

    public void setFlightBookingSearchSpec(FlightBookingSearchSpecJSON  new_value)
      {
        if (flagHasFlightBookingSearchSpec)
          {
          }
        flagHasFlightBookingSearchSpec = true;
        storeFlightBookingSearchSpec = new_value;
      }
    public void unsetFlightBookingSearchSpec()
      {
        if (flagHasFlightBookingSearchSpec)
          {
          }
        flagHasFlightBookingSearchSpec = false;
      }
    public void setCurrentDateAndTime(FlightTimesJSON  new_value)
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = true;
        storeCurrentDateAndTime = new_value;
      }
    public void unsetCurrentDateAndTime()
      {
        if (flagHasCurrentDateAndTime)
          {
          }
        flagHasCurrentDateAndTime = false;
      }
    public void initFlightProducts()
      {
        if (flagHasFlightProducts)
          {
            for (int num1 = 0; num1 < storeFlightProducts.Count; ++num1)
              {
              }
          }
        flagHasFlightProducts = true;
        storeFlightProducts.Clear();
      }
    public void appendFlightProducts(FlightProductJSON  to_append)
      {
        if (!flagHasFlightProducts)
          {
            flagHasFlightProducts = true;
            storeFlightProducts.Clear();
          }
        Debug.Assert(flagHasFlightProducts);
        storeFlightProducts.Add(to_append);
      }
    public void unsetFlightProducts()
      {
        if (flagHasFlightProducts)
          {
            for (int num2 = 0; num2 < storeFlightProducts.Count; ++num2)
              {
              }
          }
        flagHasFlightProducts = false;
        storeFlightProducts.Clear();
      }
    public void initFlightSegments()
      {
        if (flagHasFlightSegments)
          {
            for (int num3 = 0; num3 < storeFlightSegments.Count; ++num3)
              {
              }
          }
        flagHasFlightSegments = true;
        storeFlightSegments.Clear();
      }
    public void appendFlightSegments(FlightSegmentJSON  to_append)
      {
        if (!flagHasFlightSegments)
          {
            flagHasFlightSegments = true;
            storeFlightSegments.Clear();
          }
        Debug.Assert(flagHasFlightSegments);
        storeFlightSegments.Add(to_append);
      }
    public void unsetFlightSegments()
      {
        if (flagHasFlightSegments)
          {
            for (int num4 = 0; num4 < storeFlightSegments.Count; ++num4)
              {
              }
          }
        flagHasFlightSegments = false;
        storeFlightSegments.Clear();
      }

    public virtual void extraFlightBookingInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightBookingInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightBookingInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraFlightBookingInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentDateAndTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONCurrentDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if (String.Compare(key, 1, "light", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'B':
                            if ((String.Compare(key, 7, "ookingSearchSpec", 0, 16, false) == 0) && (key.Length == 23))
                                {
                                fromJSONFlightBookingSearchSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "roducts", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFlightProducts(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 7, "egments", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFlightSegments(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraFlightBookingInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentDateAndTime", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONCurrentDateAndTime(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if (String.Compare(key, 1, "light", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'B':
                            if ((String.Compare(key, 7, "ookingSearchSpec", 0, 16, false) == 0) && (key.Length == 23))
                                {
                                fromJSONFlightBookingSearchSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 7, "roducts", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFlightProducts(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 7, "egments", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONFlightSegments(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraFlightBookingInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFlightBookingSearchSpec);
        if (flagHasFlightBookingSearchSpec)
          {
            handler.start_pair("FlightBookingSearchSpec");
            if (partial_allowed)
                storeFlightBookingSearchSpec.write_partial_as_json(handler);
            else
                storeFlightBookingSearchSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasCurrentDateAndTime);
        if (flagHasCurrentDateAndTime)
          {
            handler.start_pair("CurrentDateAndTime");
            if (partial_allowed)
                storeCurrentDateAndTime.write_partial_as_json(handler);
            else
                storeCurrentDateAndTime.write_as_json(handler);
          }
        if (flagHasFlightProducts)
          {
            handler.start_pair("FlightProducts");
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightProducts.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightProducts[num1].write_partial_as_json(handler);
                else
                    storeFlightProducts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasFlightSegments)
          {
            handler.start_pair("FlightSegments");
            handler.start_array();
            for (int num2 = 0; num2 < storeFlightSegments.Count; ++num2)
              {
                if (partial_allowed)
                    storeFlightSegments[num2].write_partial_as_json(handler);
                else
                    storeFlightSegments[num2].write_as_json(handler);
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
        if (!(hasFlightBookingSearchSpec()))
          {
            return "When parsing the object for %what%, the \"FlightBookingSearchSpec\" field was missing.";
          }
        if (!(hasCurrentDateAndTime()))
          {
            return "When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.";
          }
        return null;
      }

    public static new FlightBookingInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingInformationNugget", ignore_extras);
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
    public static new FlightBookingInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightBookingInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingInformationNugget", ignore_extras);
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
    public static new FlightBookingInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightBookingInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        FlightBookingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightBookingInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FlightBookingInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightBookingInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private FlightBookingSearchSpecJSON.HoldingGenerator fieldGeneratorFlightBookingSearchSpec;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
        private FlightProductJSON.HoldingArrayGenerator fieldGeneratorFlightProducts;
        private FlightSegmentJSON.HoldingArrayGenerator fieldGeneratorFlightSegments;
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
            if (!(getInformationNuggetJSONKey().Equals("FlightBooking")))
                throw new Exception("The key field has a value other than `FlightBooking'.");
            FlightBookingInformationNuggetJSON result = new FlightBookingInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightBookingInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((FlightBookingInformationNuggetJSON )new_result);
          }
        protected void finish(FlightBookingInformationNuggetJSON result)
          {
            if (fieldGeneratorFlightBookingSearchSpec.have_value)
              {
                result.setFlightBookingSearchSpec(fieldGeneratorFlightBookingSearchSpec.value);
                fieldGeneratorFlightBookingSearchSpec.have_value = false;
              }
            else if ((!(result.hasFlightBookingSearchSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightBookingSearchSpec\" field was missing.");
              }
            if (fieldGeneratorCurrentDateAndTime.have_value)
              {
                result.setCurrentDateAndTime(fieldGeneratorCurrentDateAndTime.value);
                fieldGeneratorCurrentDateAndTime.have_value = false;
              }
            else if ((!(result.hasCurrentDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentDateAndTime\" field was missing.");
              }
            if (fieldGeneratorFlightProducts.have_value)
              {
                result.initFlightProducts();
                int count = fieldGeneratorFlightProducts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightProducts(fieldGeneratorFlightProducts.value[num]);
                  }
                fieldGeneratorFlightProducts.value.Clear();
                fieldGeneratorFlightProducts.have_value = false;
              }
            if (fieldGeneratorFlightSegments.have_value)
              {
                result.initFlightSegments();
                int count = fieldGeneratorFlightSegments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightSegments(fieldGeneratorFlightSegments.value[num]);
                  }
                fieldGeneratorFlightSegments.value.Clear();
                fieldGeneratorFlightSegments.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FlightBookingInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorCurrentDateAndTime;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 7, "ookingSearchSpec", 0, 16, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorFlightBookingSearchSpec;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 7, "roducts", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFlightProducts;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "egments", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFlightSegments;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorFlightBookingSearchSpec = new FlightBookingSearchSpecJSON.HoldingGenerator("field \"FlightBookingSearchSpec\" of the FlightBookingInformationNugget class", ignore_extras);
            fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the FlightBookingInformationNugget class", ignore_extras);
            fieldGeneratorFlightProducts = new FlightProductJSON.HoldingArrayGenerator("field \"FlightProducts\" of the FlightBookingInformationNugget class", ignore_extras);
            fieldGeneratorFlightSegments = new FlightSegmentJSON.HoldingArrayGenerator("field \"FlightSegments\" of the FlightBookingInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightBookingInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorFlightBookingSearchSpec = new FlightBookingSearchSpecJSON.HoldingGenerator("field \"FlightBookingSearchSpec\" of the FlightBookingInformationNugget class", false);
            fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the FlightBookingInformationNugget class", false);
            fieldGeneratorFlightProducts = new FlightProductJSON.HoldingArrayGenerator("field \"FlightProducts\" of the FlightBookingInformationNugget class", false);
            fieldGeneratorFlightSegments = new FlightSegmentJSON.HoldingArrayGenerator("field \"FlightSegments\" of the FlightBookingInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightBookingInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorFlightBookingSearchSpec.reset();
            fieldGeneratorCurrentDateAndTime.reset();
            fieldGeneratorFlightProducts.reset();
            fieldGeneratorFlightSegments.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightBookingInformationNuggetJSON  result)
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
        public FlightBookingInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightBookingInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<FlightBookingInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightBookingInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightBookingInformationNuggetJSON>();
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
    public List<FlightBookingInformationNuggetJSON> value;
  };
  };
