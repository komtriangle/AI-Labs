/* file "FlightBookingCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightBookingCommandJSON : CommandResultJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasFlightBookingSearchSpec;
        private FlightBookingSearchSpecJSON  storeFlightBookingSearchSpec;
        private bool flagHasCurrentDateAndTime;
        private FlightTimesJSON  storeCurrentDateAndTime;
        private bool flagHasFlightSearchProgressDetails;
        private FlightSearchProgressDetailsJSON  storeFlightSearchProgressDetails;
        private bool flagHasErrorMessage;
        private string storeErrorMessage;
        private bool flagHasFlightProducts;
        private List< FlightProductJSON  > storeFlightProducts;
        private bool flagHasFlightSegments;
        private List< FlightSegmentJSON  > storeFlightSegments;


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


        private void  fromJSONFlightSearchProgressDetails(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            FlightSearchProgressDetailsJSON convert_classy = FlightSearchProgressDetailsJSON.from_json(json_value, ignore_extras, true);
            setFlightSearchProgressDetails(convert_classy);
          }


        private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ErrorMessage of TypeNativeDataJSON is not a string.");
            setErrorMessage(json_string.getData());
          }


        private void  fromJSONFlightProducts(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field FlightProducts of TypeNativeDataJSON is not an array.");
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
                throw new Exception("The value for field FlightSegments of TypeNativeDataJSON is not an array.");
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


        public TypeNativeDataJSON()
          {
            flagHasFlightBookingSearchSpec = false;
            flagHasCurrentDateAndTime = false;
            flagHasFlightSearchProgressDetails = false;
            flagHasErrorMessage = false;
            flagHasFlightProducts = false;
            flagHasFlightSegments = false;
            storeFlightProducts = new List< FlightProductJSON  >();
            storeFlightSegments = new List< FlightSegmentJSON  >();
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

        public bool  hasFlightSearchProgressDetails()
          {
            return flagHasFlightSearchProgressDetails;
          }

        public FlightSearchProgressDetailsJSON   getFlightSearchProgressDetails()
          {
            Debug.Assert(flagHasFlightSearchProgressDetails);
            return storeFlightSearchProgressDetails;
          }

        public bool  hasErrorMessage()
          {
            return flagHasErrorMessage;
          }

        public string  getErrorMessage()
          {
            Debug.Assert(flagHasErrorMessage);
            return storeErrorMessage;
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
        public void setFlightSearchProgressDetails(FlightSearchProgressDetailsJSON  new_value)
          {
            if (flagHasFlightSearchProgressDetails)
              {
              }
            flagHasFlightSearchProgressDetails = true;
            storeFlightSearchProgressDetails = new_value;
          }
        public void unsetFlightSearchProgressDetails()
          {
            if (flagHasFlightSearchProgressDetails)
              {
              }
            flagHasFlightSearchProgressDetails = false;
          }
        public void setErrorMessage(string new_value)
          {
            flagHasErrorMessage = true;
            storeErrorMessage = new_value;
          }
        public void unsetErrorMessage()
          {
            flagHasErrorMessage = false;
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
            if (flagHasFlightSearchProgressDetails)
              {
                handler.start_pair("FlightSearchProgressDetails");
                if (partial_allowed)
                    storeFlightSearchProgressDetails.write_partial_as_json(handler);
                else
                    storeFlightSearchProgressDetails.write_as_json(handler);
              }
            if (flagHasErrorMessage)
              {
                handler.start_pair("ErrorMessage");
                handler.string_value(storeErrorMessage);
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
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
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

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private FlightBookingSearchSpecJSON.HoldingGenerator fieldGeneratorFlightBookingSearchSpec;
            private FlightTimesJSON.HoldingGenerator fieldGeneratorCurrentDateAndTime;
            private FlightSearchProgressDetailsJSON.HoldingGenerator fieldGeneratorFlightSearchProgressDetails;
            private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
            private FlightProductJSON.HoldingArrayGenerator fieldGeneratorFlightProducts;
            private FlightSegmentJSON.HoldingArrayGenerator fieldGeneratorFlightSegments;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
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
                if (fieldGeneratorFlightSearchProgressDetails.have_value)
                  {
                    result.setFlightSearchProgressDetails(fieldGeneratorFlightSearchProgressDetails.value);
                    fieldGeneratorFlightSearchProgressDetails.have_value = false;
                  }
                if (fieldGeneratorErrorMessage.have_value)
                  {
                    result.setErrorMessage(fieldGeneratorErrorMessage.value);
                    fieldGeneratorErrorMessage.have_value = false;
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
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "urrentDateAndTime", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorCurrentDateAndTime;
                        break;
                    case 'E':
                        if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorErrorMessage;
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
                                    if (String.Compare(field_name, 7, "e", 0, 1, false) == 0)
                                      {
                                        switch (field_name[8])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 9, "rchProgressDetails", 0, 18, false) == 0) && (field_name.Length == 27))
                                                    return fieldGeneratorFlightSearchProgressDetails;
                                                break;
                                            case 'g':
                                                if ((String.Compare(field_name, 9, "ments", 0, 5, false) == 0) && (field_name.Length == 14))
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
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorFlightBookingSearchSpec = new FlightBookingSearchSpecJSON.HoldingGenerator("field \"FlightBookingSearchSpec\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorFlightSearchProgressDetails = new FlightSearchProgressDetailsJSON.HoldingGenerator("field \"FlightSearchProgressDetails\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                fieldGeneratorFlightProducts = new FlightProductJSON.HoldingArrayGenerator("field \"FlightProducts\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorFlightSegments = new FlightSegmentJSON.HoldingArrayGenerator("field \"FlightSegments\" of the TypeNativeData class", ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorFlightBookingSearchSpec = new FlightBookingSearchSpecJSON.HoldingGenerator("field \"FlightBookingSearchSpec\" of the TypeNativeData class", false);
                fieldGeneratorCurrentDateAndTime = new FlightTimesJSON.HoldingGenerator("field \"CurrentDateAndTime\" of the TypeNativeData class", false);
                fieldGeneratorFlightSearchProgressDetails = new FlightSearchProgressDetailsJSON.HoldingGenerator("field \"FlightSearchProgressDetails\" of the TypeNativeData class", false);
                fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the TypeNativeData class");
                fieldGeneratorFlightProducts = new FlightProductJSON.HoldingArrayGenerator("field \"FlightProducts\" of the TypeNativeData class", false);
                fieldGeneratorFlightSegments = new FlightSegmentJSON.HoldingArrayGenerator("field \"FlightSegments\" of the TypeNativeData class", false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorFlightBookingSearchSpec.reset();
                fieldGeneratorCurrentDateAndTime.reset();
                fieldGeneratorFlightSearchProgressDetails.reset();
                fieldGeneratorErrorMessage.reset();
                fieldGeneratorFlightProducts.reset();
                fieldGeneratorFlightSegments.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorFlightBookingSearchSpec.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorCurrentDateAndTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFlightSearchProgressDetails.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFlightProducts.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFlightSegments.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorFlightBookingSearchSpec.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorCurrentDateAndTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFlightSearchProgressDetails.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFlightProducts.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFlightSegments.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public FlightBookingCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "FlightBookingCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraFlightBookingCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightBookingCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightBookingCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightBookingCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraFlightBookingCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraFlightBookingCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraFlightBookingCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraFlightBookingCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraFlightBookingCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightBookingCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightBookingCommandLookup(key);
        if (old_field == null)
          {
            extraFlightBookingCommandAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraFlightBookingCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraFlightBookingCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new FlightBookingCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingCommand", ignore_extras);
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
    public static new FlightBookingCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightBookingCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingCommand", ignore_extras);
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
    public static new FlightBookingCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightBookingCommandJSON from_text(string text, bool ignore_extras)
      {
        FlightBookingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightBookingCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FlightBookingCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightBookingCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getCommandResultJSONKey().Equals("FlightBookingCommand")))
                throw new Exception("The key field has a value other than `FlightBookingCommand'.");
            FlightBookingCommandJSON result = new FlightBookingCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightBookingCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((FlightBookingCommandJSON )new_result);
          }
        protected void finish(FlightBookingCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(FlightBookingCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the FlightBookingCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightBookingCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the FlightBookingCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightBookingCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightBookingCommandJSON  result)
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
        public FlightBookingCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightBookingCommandJSON  result)
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
    protected virtual void handle_result(List<FlightBookingCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightBookingCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightBookingCommandJSON>();
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
    public List<FlightBookingCommandJSON> value;
  };
  };
