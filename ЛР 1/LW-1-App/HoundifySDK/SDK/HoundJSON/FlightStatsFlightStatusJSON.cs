/* file "FlightStatsFlightStatusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightStatsFlightStatusJSON : JSONBase
  {
    public enum Typestatus
      {
        status_A,
        status_C,
        status_D,
        status_DN,
        status_L,
        status_NO,
        status_R,
        status_S,
        status_U
      };

    public static Typestatus  stringTostatus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (chars.Length == 1)
                    return Typestatus.status_A;
                break;
            case 'C':
                if (chars.Length == 1)
                    return Typestatus.status_C;
                break;
            case 'D':
                if (chars.Length == 1)
                  {
                    return Typestatus.status_D;
                  }
                switch (chars[1])
                  {
                    case 'N':
                        if (chars.Length == 2)
                            return Typestatus.status_DN;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (chars.Length == 1)
                    return Typestatus.status_L;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "O", 0, 1, false) == 0) && (chars.Length == 2))
                    return Typestatus.status_NO;
                break;
            case 'R':
                if (chars.Length == 1)
                    return Typestatus.status_R;
                break;
            case 'S':
                if (chars.Length == 1)
                    return Typestatus.status_S;
                break;
            case 'U':
                if (chars.Length == 1)
                    return Typestatus.status_U;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `status' is not one of the legal values.");
      }

    public static string  stringFromstatus(Typestatus the_enum)
      {
        switch (the_enum)
          {
            case Typestatus.status_A:
                return "A";
            case Typestatus.status_C:
                return "C";
            case Typestatus.status_D:
                return "D";
            case Typestatus.status_DN:
                return "DN";
            case Typestatus.status_L:
                return "L";
            case Typestatus.status_NO:
                return "NO";
            case Typestatus.status_R:
                return "R";
            case Typestatus.status_S:
                return "S";
            case Typestatus.status_U:
                return "U";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeflightEquipmentJSON : JSONBase
      {
        private bool flagHasscheduledEquipment;
        private FlightStatsEquipmentJSON  storescheduledEquipment;
        private bool flagHasscheduledEquipmentIataCode;
        private string storescheduledEquipmentIataCode;
        private bool flagHasactualEquipment;
        private FlightStatsEquipmentJSON  storeactualEquipment;
        private bool flagHasactualEquipmentIataCode;
        private string storeactualEquipmentIataCode;
        private bool flagHastailNumber;
        private string storetailNumber;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONscheduledEquipment(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            FlightStatsEquipmentJSON convert_classy = FlightStatsEquipmentJSON.from_json(json_value, ignore_extras, true);
            setscheduledEquipment(convert_classy);
          }


        private void  fromJSONscheduledEquipmentIataCode(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field scheduledEquipmentIataCode of TypeflightEquipmentJSON is not a string.");
            setscheduledEquipmentIataCode(json_string.getData());
          }


        private void  fromJSONactualEquipment(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            FlightStatsEquipmentJSON convert_classy = FlightStatsEquipmentJSON.from_json(json_value, ignore_extras, true);
            setactualEquipment(convert_classy);
          }


        private void  fromJSONactualEquipmentIataCode(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field actualEquipmentIataCode of TypeflightEquipmentJSON is not a string.");
            setactualEquipmentIataCode(json_string.getData());
          }


        private void  fromJSONtailNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field tailNumber of TypeflightEquipmentJSON is not a string.");
            settailNumber(json_string.getData());
          }


        public TypeflightEquipmentJSON()
          {
            flagHasscheduledEquipment = false;
            flagHasscheduledEquipmentIataCode = false;
            flagHasactualEquipment = false;
            flagHasactualEquipmentIataCode = false;
            flagHastailNumber = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasscheduledEquipment()
          {
            return flagHasscheduledEquipment;
          }

        public FlightStatsEquipmentJSON   getscheduledEquipment()
          {
            Debug.Assert(flagHasscheduledEquipment);
            return storescheduledEquipment;
          }

        public bool  hasscheduledEquipmentIataCode()
          {
            return flagHasscheduledEquipmentIataCode;
          }

        public string  getscheduledEquipmentIataCode()
          {
            Debug.Assert(flagHasscheduledEquipmentIataCode);
            return storescheduledEquipmentIataCode;
          }

        public bool  hasactualEquipment()
          {
            return flagHasactualEquipment;
          }

        public FlightStatsEquipmentJSON   getactualEquipment()
          {
            Debug.Assert(flagHasactualEquipment);
            return storeactualEquipment;
          }

        public bool  hasactualEquipmentIataCode()
          {
            return flagHasactualEquipmentIataCode;
          }

        public string  getactualEquipmentIataCode()
          {
            Debug.Assert(flagHasactualEquipmentIataCode);
            return storeactualEquipmentIataCode;
          }

        public bool  hastailNumber()
          {
            return flagHastailNumber;
          }

        public string  gettailNumber()
          {
            Debug.Assert(flagHastailNumber);
            return storetailNumber;
          }


        public virtual int extraTypeflightEquipmentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeflightEquipmentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeflightEquipmentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeflightEquipmentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setscheduledEquipment(FlightStatsEquipmentJSON  new_value)
          {
            if (flagHasscheduledEquipment)
              {
              }
            flagHasscheduledEquipment = true;
            storescheduledEquipment = new_value;
          }
        public void unsetscheduledEquipment()
          {
            if (flagHasscheduledEquipment)
              {
              }
            flagHasscheduledEquipment = false;
          }
        public void setscheduledEquipmentIataCode(string new_value)
          {
            flagHasscheduledEquipmentIataCode = true;
            storescheduledEquipmentIataCode = new_value;
          }
        public void unsetscheduledEquipmentIataCode()
          {
            flagHasscheduledEquipmentIataCode = false;
          }
        public void setactualEquipment(FlightStatsEquipmentJSON  new_value)
          {
            if (flagHasactualEquipment)
              {
              }
            flagHasactualEquipment = true;
            storeactualEquipment = new_value;
          }
        public void unsetactualEquipment()
          {
            if (flagHasactualEquipment)
              {
              }
            flagHasactualEquipment = false;
          }
        public void setactualEquipmentIataCode(string new_value)
          {
            flagHasactualEquipmentIataCode = true;
            storeactualEquipmentIataCode = new_value;
          }
        public void unsetactualEquipmentIataCode()
          {
            flagHasactualEquipmentIataCode = false;
          }
        public void settailNumber(string new_value)
          {
            flagHastailNumber = true;
            storetailNumber = new_value;
          }
        public void unsettailNumber()
          {
            flagHastailNumber = false;
          }

        public virtual void extraTypeflightEquipmentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeflightEquipmentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeflightEquipmentLookup(key);
            if (old_field == null)
              {
                extraTypeflightEquipmentAppendPair(key, new_component);
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
            if (flagHasscheduledEquipment)
              {
                handler.start_pair("scheduledEquipment");
                if (partial_allowed)
                    storescheduledEquipment.write_partial_as_json(handler);
                else
                    storescheduledEquipment.write_as_json(handler);
              }
            if (flagHasscheduledEquipmentIataCode)
              {
                handler.start_pair("scheduledEquipmentIataCode");
                handler.string_value(storescheduledEquipmentIataCode);
              }
            if (flagHasactualEquipment)
              {
                handler.start_pair("actualEquipment");
                if (partial_allowed)
                    storeactualEquipment.write_partial_as_json(handler);
                else
                    storeactualEquipment.write_as_json(handler);
              }
            if (flagHasactualEquipmentIataCode)
              {
                handler.start_pair("actualEquipmentIataCode");
                handler.string_value(storeactualEquipmentIataCode);
              }
            if (flagHastailNumber)
              {
                handler.start_pair("tailNumber");
                handler.string_value(storetailNumber);
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

        public static TypeflightEquipmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeflightEquipmentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeflightEquipment", ignore_extras);
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
        public static TypeflightEquipmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeflightEquipmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeflightEquipmentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeflightEquipment", ignore_extras);
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
        public static TypeflightEquipmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeflightEquipmentJSON from_text(string text, bool ignore_extras)
          {
            TypeflightEquipmentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeflightEquipment", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeflightEquipmentJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeflightEquipmentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeflightEquipmentJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeflightEquipment", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private FlightStatsEquipmentJSON.HoldingGenerator fieldGeneratorscheduledEquipment;
            private JSONHoldingStringGenerator fieldGeneratorscheduledEquipmentIataCode;
            private FlightStatsEquipmentJSON.HoldingGenerator fieldGeneratoractualEquipment;
            private JSONHoldingStringGenerator fieldGeneratoractualEquipmentIataCode;
            private JSONHoldingStringGenerator fieldGeneratortailNumber;
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
                TypeflightEquipmentJSON result = new TypeflightEquipmentJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeflightEquipmentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeflightEquipmentJSON result)
              {
                if (fieldGeneratorscheduledEquipment.have_value)
                  {
                    result.setscheduledEquipment(fieldGeneratorscheduledEquipment.value);
                    fieldGeneratorscheduledEquipment.have_value = false;
                  }
                if (fieldGeneratorscheduledEquipmentIataCode.have_value)
                  {
                    result.setscheduledEquipmentIataCode(fieldGeneratorscheduledEquipmentIataCode.value);
                    fieldGeneratorscheduledEquipmentIataCode.have_value = false;
                  }
                if (fieldGeneratoractualEquipment.have_value)
                  {
                    result.setactualEquipment(fieldGeneratoractualEquipment.value);
                    fieldGeneratoractualEquipment.have_value = false;
                  }
                if (fieldGeneratoractualEquipmentIataCode.have_value)
                  {
                    result.setactualEquipmentIataCode(fieldGeneratoractualEquipmentIataCode.value);
                    fieldGeneratoractualEquipmentIataCode.have_value = false;
                  }
                if (fieldGeneratortailNumber.have_value)
                  {
                    result.settailNumber(fieldGeneratortailNumber.value);
                    fieldGeneratortailNumber.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeflightEquipmentJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'a':
                        if (String.Compare(field_name, 1, "ctualEquipment", 0, 14, false) == 0)
                          {
                            if (field_name.Length == 15)
                              {
                                return fieldGeneratoractualEquipment;
                              }
                            switch (field_name[15])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 16, "ataCode", 0, 7, false) == 0) && (field_name.Length == 23))
                                        return fieldGeneratoractualEquipmentIataCode;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 's':
                        if (String.Compare(field_name, 1, "cheduledEquipment", 0, 17, false) == 0)
                          {
                            if (field_name.Length == 18)
                              {
                                return fieldGeneratorscheduledEquipment;
                              }
                            switch (field_name[18])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 19, "ataCode", 0, 7, false) == 0) && (field_name.Length == 26))
                                        return fieldGeneratorscheduledEquipmentIataCode;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(field_name, 1, "ailNumber", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratortailNumber;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorscheduledEquipment = new FlightStatsEquipmentJSON.HoldingGenerator("field \"scheduledEquipment\" of the TypeflightEquipment class", ignore_extras);
                fieldGeneratorscheduledEquipmentIataCode = new JSONHoldingStringGenerator("field \"scheduledEquipmentIataCode\" of the TypeflightEquipment class");
                fieldGeneratoractualEquipment = new FlightStatsEquipmentJSON.HoldingGenerator("field \"actualEquipment\" of the TypeflightEquipment class", ignore_extras);
                fieldGeneratoractualEquipmentIataCode = new JSONHoldingStringGenerator("field \"actualEquipmentIataCode\" of the TypeflightEquipment class");
                fieldGeneratortailNumber = new JSONHoldingStringGenerator("field \"tailNumber\" of the TypeflightEquipment class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeflightEquipment class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorscheduledEquipment = new FlightStatsEquipmentJSON.HoldingGenerator("field \"scheduledEquipment\" of the TypeflightEquipment class", false);
                fieldGeneratorscheduledEquipmentIataCode = new JSONHoldingStringGenerator("field \"scheduledEquipmentIataCode\" of the TypeflightEquipment class");
                fieldGeneratoractualEquipment = new FlightStatsEquipmentJSON.HoldingGenerator("field \"actualEquipment\" of the TypeflightEquipment class", false);
                fieldGeneratoractualEquipmentIataCode = new JSONHoldingStringGenerator("field \"actualEquipmentIataCode\" of the TypeflightEquipment class");
                fieldGeneratortailNumber = new JSONHoldingStringGenerator("field \"tailNumber\" of the TypeflightEquipment class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeflightEquipment class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorscheduledEquipment.reset();
                fieldGeneratorscheduledEquipmentIataCode.reset();
                fieldGeneratoractualEquipment.reset();
                fieldGeneratoractualEquipmentIataCode.reset();
                fieldGeneratortailNumber.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorscheduledEquipment.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratoractualEquipment.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorscheduledEquipment.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratoractualEquipment.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeflightEquipmentJSON  result)
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
            public TypeflightEquipmentJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeflightEquipmentJSON  result)
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
        protected virtual void handle_result(List<TypeflightEquipmentJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeflightEquipmentJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeflightEquipmentJSON>();
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
        public List<TypeflightEquipmentJSON> value;
      };
      };
    private bool flagHasflightId;
    private BigInteger storeflightId;
    private bool flagHascarrier;
    private FlightStatsAirlineJSON  storecarrier;
    private bool flagHasflightNumber;
    private string storeflightNumber;
    private bool flagHasdepartureAirport;
    private FlightStatsAirportJSON  storedepartureAirport;
    private bool flagHasarrivalAirport;
    private FlightStatsAirportJSON  storearrivalAirport;
    private bool flagHasdivertedAirport;
    private FlightStatsAirportJSON  storedivertedAirport;
    private bool flagHasdepartureDate;
    private FlightStatsTimesJSON  storedepartureDate;
    private bool flagHasarrivalDate;
    private FlightStatsTimesJSON  storearrivalDate;
    private bool flagHasstatus;
    private Typestatus storestatus;
    private bool flagHasoperationalTimes;
    private FlightStatsOperationalTimesJSON  storeoperationalTimes;
    private bool flagHascodeshares;
    private List< FlightStatsCodeshareJSON  > storecodeshares;
    private bool flagHasairportResources;
    private FlightStatsAirportResourcesJSON  storeairportResources;
    private bool flagHasflightEquipment;
    private TypeflightEquipmentJSON  storeflightEquipment;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONflightId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field flightId of FlightStatsFlightStatusJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field flightId of FlightStatsFlightStatusJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setflightId(extracted_integer);
      }


    private void  fromJSONcarrier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsAirlineJSON convert_classy = FlightStatsAirlineJSON.from_json(json_value, ignore_extras, true);
        setcarrier(convert_classy);
      }


    private void  fromJSONflightNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field flightNumber of FlightStatsFlightStatusJSON is not a string.");
        setflightNumber(json_string.getData());
      }


    private void  fromJSONdepartureAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsAirportJSON convert_classy = FlightStatsAirportJSON.from_json(json_value, ignore_extras, true);
        setdepartureAirport(convert_classy);
      }


    private void  fromJSONarrivalAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsAirportJSON convert_classy = FlightStatsAirportJSON.from_json(json_value, ignore_extras, true);
        setarrivalAirport(convert_classy);
      }


    private void  fromJSONdivertedAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsAirportJSON convert_classy = FlightStatsAirportJSON.from_json(json_value, ignore_extras, true);
        setdivertedAirport(convert_classy);
      }


    private void  fromJSONdepartureDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setdepartureDate(convert_classy);
      }


    private void  fromJSONarrivalDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsTimesJSON convert_classy = FlightStatsTimesJSON.from_json(json_value, ignore_extras, true);
        setarrivalDate(convert_classy);
      }


    private void  fromJSONstatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field status of FlightStatsFlightStatusJSON is not a string.");
        Typestatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_A;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_C;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if (json_string.getData().Length == 1)
                  {
                      {
                        the_enum = Typestatus.status_D;
                        goto enum_is_done;
                      }
                  }
                switch (json_string.getData()[1])
                  {
                    case 'N':
                        if (json_string.getData().Length == 2)
                              {
                                the_enum = Typestatus.status_DN;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_L;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "O", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = Typestatus.status_NO;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_R;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_S;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = Typestatus.status_U;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field status of FlightStatsFlightStatusJSON is not one of the legal strings.");
      enum_is_done:;
        setstatus(the_enum);
      }


    private void  fromJSONoperationalTimes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsOperationalTimesJSON convert_classy = FlightStatsOperationalTimesJSON.from_json(json_value, ignore_extras, true);
        setoperationalTimes(convert_classy);
      }


    private void  fromJSONcodeshares(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field codeshares of FlightStatsFlightStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightStatsCodeshareJSON  > vector_codeshares1 = new List< FlightStatsCodeshareJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightStatsCodeshareJSON convert_classy = FlightStatsCodeshareJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_codeshares1.Add(convert_classy);
          }
        initcodeshares();
        for (int num1 = 0; num1 < vector_codeshares1.Count; ++num1)
            appendcodeshares(vector_codeshares1[num1]);
        for (int num1 = 0; num1 < vector_codeshares1.Count; ++num1)
          {
          }
      }


    private void  fromJSONairportResources(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatsAirportResourcesJSON convert_classy = FlightStatsAirportResourcesJSON.from_json(json_value, ignore_extras, true);
        setairportResources(convert_classy);
      }


    private void  fromJSONflightEquipment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeflightEquipmentJSON convert_classy = TypeflightEquipmentJSON.from_json(json_value, ignore_extras, true);
        setflightEquipment(convert_classy);
      }


    public FlightStatsFlightStatusJSON()
      {
        flagHasflightId = false;
        flagHascarrier = false;
        flagHasflightNumber = false;
        flagHasdepartureAirport = false;
        flagHasarrivalAirport = false;
        flagHasdivertedAirport = false;
        flagHasdepartureDate = false;
        flagHasarrivalDate = false;
        flagHasstatus = false;
        flagHasoperationalTimes = false;
        flagHascodeshares = false;
        flagHasairportResources = false;
        flagHasflightEquipment = false;
        storecodeshares = new List< FlightStatsCodeshareJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasflightId()
      {
        return flagHasflightId;
      }

    public BigInteger  getflightId()
      {
        Debug.Assert(flagHasflightId);
        return storeflightId;
      }

    public bool  hascarrier()
      {
        return flagHascarrier;
      }

    public FlightStatsAirlineJSON   getcarrier()
      {
        Debug.Assert(flagHascarrier);
        return storecarrier;
      }

    public bool  hasflightNumber()
      {
        return flagHasflightNumber;
      }

    public string  getflightNumber()
      {
        Debug.Assert(flagHasflightNumber);
        return storeflightNumber;
      }

    public bool  hasdepartureAirport()
      {
        return flagHasdepartureAirport;
      }

    public FlightStatsAirportJSON   getdepartureAirport()
      {
        Debug.Assert(flagHasdepartureAirport);
        return storedepartureAirport;
      }

    public bool  hasarrivalAirport()
      {
        return flagHasarrivalAirport;
      }

    public FlightStatsAirportJSON   getarrivalAirport()
      {
        Debug.Assert(flagHasarrivalAirport);
        return storearrivalAirport;
      }

    public bool  hasdivertedAirport()
      {
        return flagHasdivertedAirport;
      }

    public FlightStatsAirportJSON   getdivertedAirport()
      {
        Debug.Assert(flagHasdivertedAirport);
        return storedivertedAirport;
      }

    public bool  hasdepartureDate()
      {
        return flagHasdepartureDate;
      }

    public FlightStatsTimesJSON   getdepartureDate()
      {
        Debug.Assert(flagHasdepartureDate);
        return storedepartureDate;
      }

    public bool  hasarrivalDate()
      {
        return flagHasarrivalDate;
      }

    public FlightStatsTimesJSON   getarrivalDate()
      {
        Debug.Assert(flagHasarrivalDate);
        return storearrivalDate;
      }

    public bool  hasstatus()
      {
        return flagHasstatus;
      }

    public Typestatus  getstatus()
      {
        Debug.Assert(flagHasstatus);
        return storestatus;
      }

    public string  getstatusAsString()
      {
        return stringFromstatus(getstatus());
      }

    public bool  hasoperationalTimes()
      {
        return flagHasoperationalTimes;
      }

    public FlightStatsOperationalTimesJSON   getoperationalTimes()
      {
        Debug.Assert(flagHasoperationalTimes);
        return storeoperationalTimes;
      }

    public bool  hascodeshares()
      {
        return flagHascodeshares;
      }

    public int  countOfcodeshares()
      {
        Debug.Assert(flagHascodeshares);
        return storecodeshares.Count;
      }

    public FlightStatsCodeshareJSON   elementOfcodeshares(int element_num)
      {
        Debug.Assert(flagHascodeshares);
        return storecodeshares[element_num];
      }

    public List< FlightStatsCodeshareJSON  >  getcodeshares()
      {
        Debug.Assert(flagHascodeshares);
        return storecodeshares;
      }

    public bool  hasairportResources()
      {
        return flagHasairportResources;
      }

    public FlightStatsAirportResourcesJSON   getairportResources()
      {
        Debug.Assert(flagHasairportResources);
        return storeairportResources;
      }

    public bool  hasflightEquipment()
      {
        return flagHasflightEquipment;
      }

    public TypeflightEquipmentJSON   getflightEquipment()
      {
        Debug.Assert(flagHasflightEquipment);
        return storeflightEquipment;
      }


    public virtual int extraFlightStatsFlightStatusComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsFlightStatusComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsFlightStatusComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsFlightStatusLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setflightId(BigInteger new_value)
      {
        flagHasflightId = true;
        storeflightId = new_value;
      }
    public void unsetflightId()
      {
        flagHasflightId = false;
      }
    public void setcarrier(FlightStatsAirlineJSON  new_value)
      {
        if (flagHascarrier)
          {
          }
        flagHascarrier = true;
        storecarrier = new_value;
      }
    public void unsetcarrier()
      {
        if (flagHascarrier)
          {
          }
        flagHascarrier = false;
      }
    public void setflightNumber(string new_value)
      {
        flagHasflightNumber = true;
        storeflightNumber = new_value;
      }
    public void unsetflightNumber()
      {
        flagHasflightNumber = false;
      }
    public void setdepartureAirport(FlightStatsAirportJSON  new_value)
      {
        if (flagHasdepartureAirport)
          {
          }
        flagHasdepartureAirport = true;
        storedepartureAirport = new_value;
      }
    public void unsetdepartureAirport()
      {
        if (flagHasdepartureAirport)
          {
          }
        flagHasdepartureAirport = false;
      }
    public void setarrivalAirport(FlightStatsAirportJSON  new_value)
      {
        if (flagHasarrivalAirport)
          {
          }
        flagHasarrivalAirport = true;
        storearrivalAirport = new_value;
      }
    public void unsetarrivalAirport()
      {
        if (flagHasarrivalAirport)
          {
          }
        flagHasarrivalAirport = false;
      }
    public void setdivertedAirport(FlightStatsAirportJSON  new_value)
      {
        if (flagHasdivertedAirport)
          {
          }
        flagHasdivertedAirport = true;
        storedivertedAirport = new_value;
      }
    public void unsetdivertedAirport()
      {
        if (flagHasdivertedAirport)
          {
          }
        flagHasdivertedAirport = false;
      }
    public void setdepartureDate(FlightStatsTimesJSON  new_value)
      {
        if (flagHasdepartureDate)
          {
          }
        flagHasdepartureDate = true;
        storedepartureDate = new_value;
      }
    public void unsetdepartureDate()
      {
        if (flagHasdepartureDate)
          {
          }
        flagHasdepartureDate = false;
      }
    public void setarrivalDate(FlightStatsTimesJSON  new_value)
      {
        if (flagHasarrivalDate)
          {
          }
        flagHasarrivalDate = true;
        storearrivalDate = new_value;
      }
    public void unsetarrivalDate()
      {
        if (flagHasarrivalDate)
          {
          }
        flagHasarrivalDate = false;
      }
    public void setstatus(Typestatus new_value)
      {
        flagHasstatus = true;
        storestatus = new_value;
      }
    public void setstatus(string chars)
      {
        setstatus(stringTostatus(chars));
      }
    public void unsetstatus()
      {
        flagHasstatus = false;
      }
    public void setoperationalTimes(FlightStatsOperationalTimesJSON  new_value)
      {
        if (flagHasoperationalTimes)
          {
          }
        flagHasoperationalTimes = true;
        storeoperationalTimes = new_value;
      }
    public void unsetoperationalTimes()
      {
        if (flagHasoperationalTimes)
          {
          }
        flagHasoperationalTimes = false;
      }
    public void initcodeshares()
      {
        if (flagHascodeshares)
          {
            for (int num1 = 0; num1 < storecodeshares.Count; ++num1)
              {
              }
          }
        flagHascodeshares = true;
        storecodeshares.Clear();
      }
    public void appendcodeshares(FlightStatsCodeshareJSON  to_append)
      {
        if (!flagHascodeshares)
          {
            flagHascodeshares = true;
            storecodeshares.Clear();
          }
        Debug.Assert(flagHascodeshares);
        storecodeshares.Add(to_append);
      }
    public void unsetcodeshares()
      {
        if (flagHascodeshares)
          {
            for (int num2 = 0; num2 < storecodeshares.Count; ++num2)
              {
              }
          }
        flagHascodeshares = false;
        storecodeshares.Clear();
      }
    public void setairportResources(FlightStatsAirportResourcesJSON  new_value)
      {
        if (flagHasairportResources)
          {
          }
        flagHasairportResources = true;
        storeairportResources = new_value;
      }
    public void unsetairportResources()
      {
        if (flagHasairportResources)
          {
          }
        flagHasairportResources = false;
      }
    public void setflightEquipment(TypeflightEquipmentJSON  new_value)
      {
        if (flagHasflightEquipment)
          {
          }
        flagHasflightEquipment = true;
        storeflightEquipment = new_value;
      }
    public void unsetflightEquipment()
      {
        if (flagHasflightEquipment)
          {
          }
        flagHasflightEquipment = false;
      }

    public virtual void extraFlightStatsFlightStatusAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsFlightStatusSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsFlightStatusLookup(key);
        if (old_field == null)
          {
            extraFlightStatsFlightStatusAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasflightId);
        if (flagHasflightId)
          {
            handler.start_pair("flightId");
            handler.number_value(storeflightId);
          }
        if (flagHascarrier)
          {
            handler.start_pair("carrier");
            if (partial_allowed)
                storecarrier.write_partial_as_json(handler);
            else
                storecarrier.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasflightNumber);
        if (flagHasflightNumber)
          {
            handler.start_pair("flightNumber");
            handler.string_value(storeflightNumber);
          }
        if (flagHasdepartureAirport)
          {
            handler.start_pair("departureAirport");
            if (partial_allowed)
                storedepartureAirport.write_partial_as_json(handler);
            else
                storedepartureAirport.write_as_json(handler);
          }
        if (flagHasarrivalAirport)
          {
            handler.start_pair("arrivalAirport");
            if (partial_allowed)
                storearrivalAirport.write_partial_as_json(handler);
            else
                storearrivalAirport.write_as_json(handler);
          }
        if (flagHasdivertedAirport)
          {
            handler.start_pair("divertedAirport");
            if (partial_allowed)
                storedivertedAirport.write_partial_as_json(handler);
            else
                storedivertedAirport.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasdepartureDate);
        if (flagHasdepartureDate)
          {
            handler.start_pair("departureDate");
            if (partial_allowed)
                storedepartureDate.write_partial_as_json(handler);
            else
                storedepartureDate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasarrivalDate);
        if (flagHasarrivalDate)
          {
            handler.start_pair("arrivalDate");
            if (partial_allowed)
                storearrivalDate.write_partial_as_json(handler);
            else
                storearrivalDate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasstatus);
        if (flagHasstatus)
          {
            handler.start_pair("status");
            switch (storestatus)
              {
                case Typestatus.status_A:
                    handler.string_value("A");
                    break;
                case Typestatus.status_C:
                    handler.string_value("C");
                    break;
                case Typestatus.status_D:
                    handler.string_value("D");
                    break;
                case Typestatus.status_DN:
                    handler.string_value("DN");
                    break;
                case Typestatus.status_L:
                    handler.string_value("L");
                    break;
                case Typestatus.status_NO:
                    handler.string_value("NO");
                    break;
                case Typestatus.status_R:
                    handler.string_value("R");
                    break;
                case Typestatus.status_S:
                    handler.string_value("S");
                    break;
                case Typestatus.status_U:
                    handler.string_value("U");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasoperationalTimes);
        if (flagHasoperationalTimes)
          {
            handler.start_pair("operationalTimes");
            if (partial_allowed)
                storeoperationalTimes.write_partial_as_json(handler);
            else
                storeoperationalTimes.write_as_json(handler);
          }
        if (flagHascodeshares)
          {
            handler.start_pair("codeshares");
            handler.start_array();
            for (int num1 = 0; num1 < storecodeshares.Count; ++num1)
              {
                if (partial_allowed)
                    storecodeshares[num1].write_partial_as_json(handler);
                else
                    storecodeshares[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasairportResources)
          {
            handler.start_pair("airportResources");
            if (partial_allowed)
                storeairportResources.write_partial_as_json(handler);
            else
                storeairportResources.write_as_json(handler);
          }
        if (flagHasflightEquipment)
          {
            handler.start_pair("flightEquipment");
            if (partial_allowed)
                storeflightEquipment.write_partial_as_json(handler);
            else
                storeflightEquipment.write_as_json(handler);
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
        if (!(hasflightId()))
          {
            return "When parsing the object for %what%, the \"flightId\" field was missing.";
          }
        if (!(hasflightNumber()))
          {
            return "When parsing the object for %what%, the \"flightNumber\" field was missing.";
          }
        if (!(hasdepartureDate()))
          {
            return "When parsing the object for %what%, the \"departureDate\" field was missing.";
          }
        if (!(hasarrivalDate()))
          {
            return "When parsing the object for %what%, the \"arrivalDate\" field was missing.";
          }
        if (!(hasstatus()))
          {
            return "When parsing the object for %what%, the \"status\" field was missing.";
          }
        if (!(hasoperationalTimes()))
          {
            return "When parsing the object for %what%, the \"operationalTimes\" field was missing.";
          }
        return null;
      }

    public static FlightStatsFlightStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsFlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatus", ignore_extras);
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
    public static FlightStatsFlightStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsFlightStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsFlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatus", ignore_extras);
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
    public static FlightStatsFlightStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsFlightStatusJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsFlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatus", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsFlightStatusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsFlightStatusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsFlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsFlightStatus", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorflightId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorflightId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorflightId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorflightId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorflightId fieldGeneratorflightId;
        private FlightStatsAirlineJSON.HoldingGenerator fieldGeneratorcarrier;
        private JSONHoldingStringGenerator fieldGeneratorflightNumber;
        private FlightStatsAirportJSON.HoldingGenerator fieldGeneratordepartureAirport;
        private FlightStatsAirportJSON.HoldingGenerator fieldGeneratorarrivalAirport;
        private FlightStatsAirportJSON.HoldingGenerator fieldGeneratordivertedAirport;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratordepartureDate;
        private FlightStatsTimesJSON.HoldingGenerator fieldGeneratorarrivalDate;
    private abstract class FieldGeneratorstatus : JSONStringGenerator
          {
            protected FieldGeneratorstatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorstatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringTostatus(result));
              }
            protected abstract void handle_result(Typestatus result);
          };
    private class FieldHoldingGeneratorstatus : FieldGeneratorstatus
  {
    protected override void handle_result(Typestatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorstatus(String what)
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
    public Typestatus value;
  };
    private class FieldHoldingArrayGeneratorstatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorstatus
      {
        private FieldHoldingArrayGeneratorstatus top;

        protected override void handle_result(Typestatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorstatus init_top)
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
    protected virtual void handle_result(List<Typestatus> result)
      {
      }

    public FieldHoldingArrayGeneratorstatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typestatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorstatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typestatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typestatus> value;
  };
        private FieldHoldingGeneratorstatus fieldGeneratorstatus;
        private FlightStatsOperationalTimesJSON.HoldingGenerator fieldGeneratoroperationalTimes;
        private FlightStatsCodeshareJSON.HoldingArrayGenerator fieldGeneratorcodeshares;
        private FlightStatsAirportResourcesJSON.HoldingGenerator fieldGeneratorairportResources;
        private TypeflightEquipmentJSON.HoldingGenerator fieldGeneratorflightEquipment;
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
            FlightStatsFlightStatusJSON result = new FlightStatsFlightStatusJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsFlightStatusAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsFlightStatusJSON result)
          {
            if (fieldGeneratorflightId.have_value)
              {
                result.setflightId(fieldGeneratorflightId.value);
                fieldGeneratorflightId.have_value = false;
              }
            else if ((!(result.hasflightId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"flightId\" field was missing.");
              }
            if (fieldGeneratorcarrier.have_value)
              {
                result.setcarrier(fieldGeneratorcarrier.value);
                fieldGeneratorcarrier.have_value = false;
              }
            if (fieldGeneratorflightNumber.have_value)
              {
                result.setflightNumber(fieldGeneratorflightNumber.value);
                fieldGeneratorflightNumber.have_value = false;
              }
            else if ((!(result.hasflightNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"flightNumber\" field was missing.");
              }
            if (fieldGeneratordepartureAirport.have_value)
              {
                result.setdepartureAirport(fieldGeneratordepartureAirport.value);
                fieldGeneratordepartureAirport.have_value = false;
              }
            if (fieldGeneratorarrivalAirport.have_value)
              {
                result.setarrivalAirport(fieldGeneratorarrivalAirport.value);
                fieldGeneratorarrivalAirport.have_value = false;
              }
            if (fieldGeneratordivertedAirport.have_value)
              {
                result.setdivertedAirport(fieldGeneratordivertedAirport.value);
                fieldGeneratordivertedAirport.have_value = false;
              }
            if (fieldGeneratordepartureDate.have_value)
              {
                result.setdepartureDate(fieldGeneratordepartureDate.value);
                fieldGeneratordepartureDate.have_value = false;
              }
            else if ((!(result.hasdepartureDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"departureDate\" field was missing.");
              }
            if (fieldGeneratorarrivalDate.have_value)
              {
                result.setarrivalDate(fieldGeneratorarrivalDate.value);
                fieldGeneratorarrivalDate.have_value = false;
              }
            else if ((!(result.hasarrivalDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"arrivalDate\" field was missing.");
              }
            if (fieldGeneratorstatus.have_value)
              {
                result.setstatus(fieldGeneratorstatus.value);
                fieldGeneratorstatus.have_value = false;
              }
            else if ((!(result.hasstatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"status\" field was missing.");
              }
            if (fieldGeneratoroperationalTimes.have_value)
              {
                result.setoperationalTimes(fieldGeneratoroperationalTimes.value);
                fieldGeneratoroperationalTimes.have_value = false;
              }
            else if ((!(result.hasoperationalTimes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"operationalTimes\" field was missing.");
              }
            if (fieldGeneratorcodeshares.have_value)
              {
                result.initcodeshares();
                int count = fieldGeneratorcodeshares.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendcodeshares(fieldGeneratorcodeshares.value[num]);
                  }
                fieldGeneratorcodeshares.value.Clear();
                fieldGeneratorcodeshares.have_value = false;
              }
            if (fieldGeneratorairportResources.have_value)
              {
                result.setairportResources(fieldGeneratorairportResources.value);
                fieldGeneratorairportResources.have_value = false;
              }
            if (fieldGeneratorflightEquipment.have_value)
              {
                result.setflightEquipment(fieldGeneratorflightEquipment.value);
                fieldGeneratorflightEquipment.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatsFlightStatusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rportResources", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorairportResources;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "rival", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 8, "irport", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorarrivalAirport;
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "ate", 0, 3, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorarrivalDate;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'c':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "rrier", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorcarrier;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "deshares", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorcodeshares;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'd':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "parture", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 10, "irport", 0, 6, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratordepartureAirport;
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 10, "ate", 0, 3, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratordepartureDate;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "vertedAirport", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratordivertedAirport;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'f':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 7, "quipment", 0, 8, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorflightEquipment;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorflightId;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "umber", 0, 5, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorflightNumber;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'o':
                    if ((String.Compare(field_name, 1, "perationalTimes", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratoroperationalTimes;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "tatus", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorstatus;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorflightId = new FieldHoldingGeneratorflightId("field \"flightId\" of the FlightStatsFlightStatus class");
            fieldGeneratorcarrier = new FlightStatsAirlineJSON.HoldingGenerator("field \"carrier\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorflightNumber = new JSONHoldingStringGenerator("field \"flightNumber\" of the FlightStatsFlightStatus class");
            fieldGeneratordepartureAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"departureAirport\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorarrivalAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"arrivalAirport\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratordivertedAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"divertedAirport\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratordepartureDate = new FlightStatsTimesJSON.HoldingGenerator("field \"departureDate\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorarrivalDate = new FlightStatsTimesJSON.HoldingGenerator("field \"arrivalDate\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorstatus = new FieldHoldingGeneratorstatus("field \"status\" of the FlightStatsFlightStatus class");
            fieldGeneratoroperationalTimes = new FlightStatsOperationalTimesJSON.HoldingGenerator("field \"operationalTimes\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorcodeshares = new FlightStatsCodeshareJSON.HoldingArrayGenerator("field \"codeshares\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorairportResources = new FlightStatsAirportResourcesJSON.HoldingGenerator("field \"airportResources\" of the FlightStatsFlightStatus class", ignore_extras);
            fieldGeneratorflightEquipment = new TypeflightEquipmentJSON.HoldingGenerator("field \"flightEquipment\" of the FlightStatsFlightStatus class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsFlightStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorflightId = new FieldHoldingGeneratorflightId("field \"flightId\" of the FlightStatsFlightStatus class");
            fieldGeneratorcarrier = new FlightStatsAirlineJSON.HoldingGenerator("field \"carrier\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorflightNumber = new JSONHoldingStringGenerator("field \"flightNumber\" of the FlightStatsFlightStatus class");
            fieldGeneratordepartureAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"departureAirport\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorarrivalAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"arrivalAirport\" of the FlightStatsFlightStatus class", false);
            fieldGeneratordivertedAirport = new FlightStatsAirportJSON.HoldingGenerator("field \"divertedAirport\" of the FlightStatsFlightStatus class", false);
            fieldGeneratordepartureDate = new FlightStatsTimesJSON.HoldingGenerator("field \"departureDate\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorarrivalDate = new FlightStatsTimesJSON.HoldingGenerator("field \"arrivalDate\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorstatus = new FieldHoldingGeneratorstatus("field \"status\" of the FlightStatsFlightStatus class");
            fieldGeneratoroperationalTimes = new FlightStatsOperationalTimesJSON.HoldingGenerator("field \"operationalTimes\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorcodeshares = new FlightStatsCodeshareJSON.HoldingArrayGenerator("field \"codeshares\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorairportResources = new FlightStatsAirportResourcesJSON.HoldingGenerator("field \"airportResources\" of the FlightStatsFlightStatus class", false);
            fieldGeneratorflightEquipment = new TypeflightEquipmentJSON.HoldingGenerator("field \"flightEquipment\" of the FlightStatsFlightStatus class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsFlightStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorflightId.reset();
            fieldGeneratorcarrier.reset();
            fieldGeneratorflightNumber.reset();
            fieldGeneratordepartureAirport.reset();
            fieldGeneratorarrivalAirport.reset();
            fieldGeneratordivertedAirport.reset();
            fieldGeneratordepartureDate.reset();
            fieldGeneratorarrivalDate.reset();
            fieldGeneratorstatus.reset();
            fieldGeneratoroperationalTimes.reset();
            fieldGeneratorcodeshares.reset();
            fieldGeneratorairportResources.reset();
            fieldGeneratorflightEquipment.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorcarrier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratordepartureAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorarrivalAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratordivertedAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratordepartureDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorarrivalDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoroperationalTimes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorcodeshares.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorairportResources.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorflightEquipment.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorcarrier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratordepartureAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorarrivalAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratordivertedAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratordepartureDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorarrivalDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoroperationalTimes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorcodeshares.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorairportResources.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorflightEquipment.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatsFlightStatusJSON  result)
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
        public FlightStatsFlightStatusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsFlightStatusJSON  result)
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
    protected virtual void handle_result(List<FlightStatsFlightStatusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsFlightStatusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsFlightStatusJSON>();
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
    public List<FlightStatsFlightStatusJSON> value;
  };
  };
