/* file "HondaAgentScheduleJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HondaAgentScheduleJSON : JSONBase
  {
    public class TypemeetingsJSON : JSONBase
      {
        public class TypeattendeesJSON : JSONBase
          {
            private bool flagHasfirst_name;
            private string storefirst_name;
            private bool flagHasphone;
            private string storephone;
            private bool flagHasemail;
            private string storeemail;


            private void  fromJSONfirst_name(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field first_name of TypeattendeesJSON is not a string.");
                setfirst_name(json_string.getData());
              }


            private void  fromJSONphone(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field phone of TypeattendeesJSON is not a string.");
                setphone(json_string.getData());
              }


            private void  fromJSONemail(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field email of TypeattendeesJSON is not a string.");
                setemail(json_string.getData());
              }


            public TypeattendeesJSON()
              {
                flagHasfirst_name = false;
                flagHasphone = false;
                flagHasemail = false;
              }

            public bool  hasfirst_name()
              {
                return flagHasfirst_name;
              }

            public string  getfirst_name()
              {
                Debug.Assert(flagHasfirst_name);
                return storefirst_name;
              }

            public bool  hasphone()
              {
                return flagHasphone;
              }

            public string  getphone()
              {
                Debug.Assert(flagHasphone);
                return storephone;
              }

            public bool  hasemail()
              {
                return flagHasemail;
              }

            public string  getemail()
              {
                Debug.Assert(flagHasemail);
                return storeemail;
              }



            public void setfirst_name(string new_value)
              {
                flagHasfirst_name = true;
                storefirst_name = new_value;
              }
            public void unsetfirst_name()
              {
                flagHasfirst_name = false;
              }
            public void setphone(string new_value)
              {
                flagHasphone = true;
                storephone = new_value;
              }
            public void unsetphone()
              {
                flagHasphone = false;
              }
            public void setemail(string new_value)
              {
                flagHasemail = true;
                storeemail = new_value;
              }
            public void unsetemail()
              {
                flagHasemail = false;
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
                if (flagHasfirst_name)
                  {
                    handler.start_pair("first_name");
                    handler.string_value(storefirst_name);
                  }
                if (flagHasphone)
                  {
                    handler.start_pair("phone");
                    handler.string_value(storephone);
                  }
                if (flagHasemail)
                  {
                    handler.start_pair("email");
                    handler.string_value(storeemail);
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
                return null;
              }

            public static TypeattendeesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeattendeesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeattendees", ignore_extras);
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
            public static TypeattendeesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeattendeesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeattendeesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeattendees", ignore_extras);
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
            public static TypeattendeesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeattendeesJSON from_text(string text, bool ignore_extras)
              {
                TypeattendeesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeattendees", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeattendeesJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeattendeesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeattendeesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type Typeattendees", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorfirst_name;
                private JSONHoldingStringGenerator fieldGeneratorphone;
                private JSONHoldingStringGenerator fieldGeneratoremail;

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
                    TypeattendeesJSON result = new TypeattendeesJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeattendeesJSON result)
                  {
                    if (fieldGeneratorfirst_name.have_value)
                      {
                        result.setfirst_name(fieldGeneratorfirst_name.value);
                        fieldGeneratorfirst_name.have_value = false;
                      }
                    if (fieldGeneratorphone.have_value)
                      {
                        result.setphone(fieldGeneratorphone.value);
                        fieldGeneratorphone.have_value = false;
                      }
                    if (fieldGeneratoremail.have_value)
                      {
                        result.setemail(fieldGeneratoremail.value);
                        fieldGeneratoremail.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeattendeesJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratoremail;
                            break;
                        case 'f':
                            if ((String.Compare(field_name, 1, "irst_name", 0, 9, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorfirst_name;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 1, "hone", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorphone;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorfirst_name = new JSONHoldingStringGenerator("field \"first_name\" of the Typeattendees class");
                    fieldGeneratorphone = new JSONHoldingStringGenerator("field \"phone\" of the Typeattendees class");
                    fieldGeneratoremail = new JSONHoldingStringGenerator("field \"email\" of the Typeattendees class");
                    set_what("the Typeattendees class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorfirst_name = new JSONHoldingStringGenerator("field \"first_name\" of the Typeattendees class");
                    fieldGeneratorphone = new JSONHoldingStringGenerator("field \"phone\" of the Typeattendees class");
                    fieldGeneratoremail = new JSONHoldingStringGenerator("field \"email\" of the Typeattendees class");
                    set_what("the Typeattendees class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorfirst_name.reset();
                    fieldGeneratorphone.reset();
                    fieldGeneratoremail.reset();
                    base.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeattendeesJSON  result)
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
                public TypeattendeesJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeattendeesJSON  result)
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
            protected virtual void handle_result(List<TypeattendeesJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeattendeesJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeattendeesJSON>();
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
            public List<TypeattendeesJSON> value;
          };
          };
        private bool flagHastitle;
        private string storetitle;
        private bool flagHasstart_time;
        private BigInteger storestart_time;
        private bool flagHasStartDateAndOrTime;
        private DateAndOrTimeJSON  storeStartDateAndOrTime;
        private bool flagHasend_time;
        private BigInteger storeend_time;
        private bool flagHasEndDateAndOrTime;
        private DateAndOrTimeJSON  storeEndDateAndOrTime;
        private bool flagHasattendees;
        private List< TypeattendeesJSON  > storeattendees;
        private bool flagHaslocation;
        private string storelocation;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONtitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field title of TypemeetingsJSON is not a string.");
            settitle(json_string.getData());
          }


        private void  fromJSONstart_time(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field start_time of TypemeetingsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field start_time of TypemeetingsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setstart_time(extracted_integer);
          }


        private void  fromJSONStartDateAndOrTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setStartDateAndOrTime(convert_classy);
          }


        private void  fromJSONend_time(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field end_time of TypemeetingsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field end_time of TypemeetingsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setend_time(extracted_integer);
          }


        private void  fromJSONEndDateAndOrTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setEndDateAndOrTime(convert_classy);
          }


        private void  fromJSONattendees(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field attendees of TypemeetingsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeattendeesJSON  > vector_attendees1 = new List< TypeattendeesJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeattendeesJSON convert_classy = TypeattendeesJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_attendees1.Add(convert_classy);
              }
            initattendees();
            for (int num1 = 0; num1 < vector_attendees1.Count; ++num1)
                appendattendees(vector_attendees1[num1]);
            for (int num1 = 0; num1 < vector_attendees1.Count; ++num1)
              {
              }
          }


        private void  fromJSONlocation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field location of TypemeetingsJSON is not a string.");
            setlocation(json_string.getData());
          }


        public TypemeetingsJSON()
          {
            flagHastitle = false;
            flagHasstart_time = false;
            flagHasStartDateAndOrTime = false;
            flagHasend_time = false;
            flagHasEndDateAndOrTime = false;
            flagHasattendees = false;
            flagHaslocation = false;
            storeattendees = new List< TypeattendeesJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hastitle()
          {
            return flagHastitle;
          }

        public string  gettitle()
          {
            Debug.Assert(flagHastitle);
            return storetitle;
          }

        public bool  hasstart_time()
          {
            return flagHasstart_time;
          }

        public BigInteger  getstart_time()
          {
            Debug.Assert(flagHasstart_time);
            return storestart_time;
          }

        public bool  hasStartDateAndOrTime()
          {
            return flagHasStartDateAndOrTime;
          }

        public DateAndOrTimeJSON   getStartDateAndOrTime()
          {
            Debug.Assert(flagHasStartDateAndOrTime);
            return storeStartDateAndOrTime;
          }

        public bool  hasend_time()
          {
            return flagHasend_time;
          }

        public BigInteger  getend_time()
          {
            Debug.Assert(flagHasend_time);
            return storeend_time;
          }

        public bool  hasEndDateAndOrTime()
          {
            return flagHasEndDateAndOrTime;
          }

        public DateAndOrTimeJSON   getEndDateAndOrTime()
          {
            Debug.Assert(flagHasEndDateAndOrTime);
            return storeEndDateAndOrTime;
          }

        public bool  hasattendees()
          {
            return flagHasattendees;
          }

        public int  countOfattendees()
          {
            Debug.Assert(flagHasattendees);
            return storeattendees.Count;
          }

        public TypeattendeesJSON   elementOfattendees(int element_num)
          {
            Debug.Assert(flagHasattendees);
            return storeattendees[element_num];
          }

        public List< TypeattendeesJSON  >  getattendees()
          {
            Debug.Assert(flagHasattendees);
            return storeattendees;
          }

        public bool  haslocation()
          {
            return flagHaslocation;
          }

        public string  getlocation()
          {
            Debug.Assert(flagHaslocation);
            return storelocation;
          }


        public virtual int extraTypemeetingsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypemeetingsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypemeetingsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypemeetingsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void settitle(string new_value)
          {
            flagHastitle = true;
            storetitle = new_value;
          }
        public void unsettitle()
          {
            flagHastitle = false;
          }
        public void setstart_time(BigInteger new_value)
          {
            flagHasstart_time = true;
            if (new_value < 0)
                throw new Exception("The value for field start_time of TypemeetingsJSON is less than the lower bound (0) for that field.");
            storestart_time = new_value;
          }
        public void unsetstart_time()
          {
            flagHasstart_time = false;
          }
        public void setStartDateAndOrTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasStartDateAndOrTime)
              {
              }
            flagHasStartDateAndOrTime = true;
            storeStartDateAndOrTime = new_value;
          }
        public void unsetStartDateAndOrTime()
          {
            if (flagHasStartDateAndOrTime)
              {
              }
            flagHasStartDateAndOrTime = false;
          }
        public void setend_time(BigInteger new_value)
          {
            flagHasend_time = true;
            if (new_value < 0)
                throw new Exception("The value for field end_time of TypemeetingsJSON is less than the lower bound (0) for that field.");
            storeend_time = new_value;
          }
        public void unsetend_time()
          {
            flagHasend_time = false;
          }
        public void setEndDateAndOrTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasEndDateAndOrTime)
              {
              }
            flagHasEndDateAndOrTime = true;
            storeEndDateAndOrTime = new_value;
          }
        public void unsetEndDateAndOrTime()
          {
            if (flagHasEndDateAndOrTime)
              {
              }
            flagHasEndDateAndOrTime = false;
          }
        public void initattendees()
          {
            if (flagHasattendees)
              {
                for (int num1 = 0; num1 < storeattendees.Count; ++num1)
                  {
                  }
              }
            flagHasattendees = true;
            storeattendees.Clear();
          }
        public void appendattendees(TypeattendeesJSON  to_append)
          {
            if (!flagHasattendees)
              {
                flagHasattendees = true;
                storeattendees.Clear();
              }
            Debug.Assert(flagHasattendees);
            storeattendees.Add(to_append);
          }
        public void unsetattendees()
          {
            if (flagHasattendees)
              {
                for (int num2 = 0; num2 < storeattendees.Count; ++num2)
                  {
                  }
              }
            flagHasattendees = false;
            storeattendees.Clear();
          }
        public void setlocation(string new_value)
          {
            flagHaslocation = true;
            storelocation = new_value;
          }
        public void unsetlocation()
          {
            flagHaslocation = false;
          }

        public virtual void extraTypemeetingsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypemeetingsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypemeetingsLookup(key);
            if (old_field == null)
              {
                extraTypemeetingsAppendPair(key, new_component);
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
            if (flagHastitle)
              {
                handler.start_pair("title");
                handler.string_value(storetitle);
              }
            if (flagHasstart_time)
              {
                handler.start_pair("start_time");
                handler.number_value(storestart_time);
              }
            if (flagHasStartDateAndOrTime)
              {
                handler.start_pair("StartDateAndOrTime");
                if (partial_allowed)
                    storeStartDateAndOrTime.write_partial_as_json(handler);
                else
                    storeStartDateAndOrTime.write_as_json(handler);
              }
            if (flagHasend_time)
              {
                handler.start_pair("end_time");
                handler.number_value(storeend_time);
              }
            if (flagHasEndDateAndOrTime)
              {
                handler.start_pair("EndDateAndOrTime");
                if (partial_allowed)
                    storeEndDateAndOrTime.write_partial_as_json(handler);
                else
                    storeEndDateAndOrTime.write_as_json(handler);
              }
            if (flagHasattendees)
              {
                handler.start_pair("attendees");
                handler.start_array();
                for (int num1 = 0; num1 < storeattendees.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeattendees[num1].write_partial_as_json(handler);
                    else
                        storeattendees[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHaslocation)
              {
                handler.start_pair("location");
                handler.string_value(storelocation);
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

        public static TypemeetingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypemeetingsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemeetings", ignore_extras);
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
        public static TypemeetingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypemeetingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypemeetingsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemeetings", ignore_extras);
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
        public static TypemeetingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypemeetingsJSON from_text(string text, bool ignore_extras)
          {
            TypemeetingsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemeetings", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypemeetingsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypemeetingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypemeetingsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typemeetings", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratortitle;
        private class FieldHoldingGeneratorstart_time : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorstart_time(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorstart_time : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorstart_time(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorstart_time fieldGeneratorstart_time;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartDateAndOrTime;
        private class FieldHoldingGeneratorend_time : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorend_time(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorend_time : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorend_time(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorend_time fieldGeneratorend_time;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEndDateAndOrTime;
            private TypeattendeesJSON.HoldingArrayGenerator fieldGeneratorattendees;
            private JSONHoldingStringGenerator fieldGeneratorlocation;
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
                TypemeetingsJSON result = new TypemeetingsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypemeetingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypemeetingsJSON result)
              {
                if (fieldGeneratortitle.have_value)
                  {
                    result.settitle(fieldGeneratortitle.value);
                    fieldGeneratortitle.have_value = false;
                  }
                if (fieldGeneratorstart_time.have_value)
                  {
                    result.setstart_time(fieldGeneratorstart_time.value);
                    fieldGeneratorstart_time.have_value = false;
                  }
                if (fieldGeneratorStartDateAndOrTime.have_value)
                  {
                    result.setStartDateAndOrTime(fieldGeneratorStartDateAndOrTime.value);
                    fieldGeneratorStartDateAndOrTime.have_value = false;
                  }
                if (fieldGeneratorend_time.have_value)
                  {
                    result.setend_time(fieldGeneratorend_time.value);
                    fieldGeneratorend_time.have_value = false;
                  }
                if (fieldGeneratorEndDateAndOrTime.have_value)
                  {
                    result.setEndDateAndOrTime(fieldGeneratorEndDateAndOrTime.value);
                    fieldGeneratorEndDateAndOrTime.have_value = false;
                  }
                if (fieldGeneratorattendees.have_value)
                  {
                    result.initattendees();
                    int count = fieldGeneratorattendees.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendattendees(fieldGeneratorattendees.value[num]);
                      }
                    fieldGeneratorattendees.value.Clear();
                    fieldGeneratorattendees.have_value = false;
                  }
                if (fieldGeneratorlocation.have_value)
                  {
                    result.setlocation(fieldGeneratorlocation.value);
                    fieldGeneratorlocation.have_value = false;
                  }
              }
            protected abstract void handle_result(TypemeetingsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "ndDateAndOrTime", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorEndDateAndOrTime;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tartDateAndOrTime", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorStartDateAndOrTime;
                        break;
                    case 'a':
                        if ((String.Compare(field_name, 1, "ttendees", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorattendees;
                        break;
                    case 'e':
                        if ((String.Compare(field_name, 1, "nd_time", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorend_time;
                        break;
                    case 'l':
                        if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorlocation;
                        break;
                    case 's':
                        if ((String.Compare(field_name, 1, "tart_time", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorstart_time;
                        break;
                    case 't':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratortitle;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the Typemeetings class");
                fieldGeneratorstart_time = new FieldHoldingGeneratorstart_time("field \"start_time\" of the Typemeetings class");
                fieldGeneratorStartDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndOrTime\" of the Typemeetings class", ignore_extras);
                fieldGeneratorend_time = new FieldHoldingGeneratorend_time("field \"end_time\" of the Typemeetings class");
                fieldGeneratorEndDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndOrTime\" of the Typemeetings class", ignore_extras);
                fieldGeneratorattendees = new TypeattendeesJSON.HoldingArrayGenerator("field \"attendees\" of the Typemeetings class", ignore_extras);
                fieldGeneratorlocation = new JSONHoldingStringGenerator("field \"location\" of the Typemeetings class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typemeetings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the Typemeetings class");
                fieldGeneratorstart_time = new FieldHoldingGeneratorstart_time("field \"start_time\" of the Typemeetings class");
                fieldGeneratorStartDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartDateAndOrTime\" of the Typemeetings class", false);
                fieldGeneratorend_time = new FieldHoldingGeneratorend_time("field \"end_time\" of the Typemeetings class");
                fieldGeneratorEndDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"EndDateAndOrTime\" of the Typemeetings class", false);
                fieldGeneratorattendees = new TypeattendeesJSON.HoldingArrayGenerator("field \"attendees\" of the Typemeetings class", false);
                fieldGeneratorlocation = new JSONHoldingStringGenerator("field \"location\" of the Typemeetings class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typemeetings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratortitle.reset();
                fieldGeneratorstart_time.reset();
                fieldGeneratorStartDateAndOrTime.reset();
                fieldGeneratorend_time.reset();
                fieldGeneratorEndDateAndOrTime.reset();
                fieldGeneratorattendees.reset();
                fieldGeneratorlocation.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorStartDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorEndDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorattendees.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorStartDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorEndDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorattendees.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypemeetingsJSON  result)
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
            public TypemeetingsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypemeetingsJSON  result)
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
        protected virtual void handle_result(List<TypemeetingsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypemeetingsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypemeetingsJSON>();
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
        public List<TypemeetingsJSON> value;
      };
      };
    private bool flagHasmeetings;
    private List< TypemeetingsJSON  > storemeetings;
    private bool flagHasreturn_next_meeting;
    private bool storereturn_next_meeting;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONmeetings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field meetings of HondaAgentScheduleJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypemeetingsJSON  > vector_meetings1 = new List< TypemeetingsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypemeetingsJSON convert_classy = TypemeetingsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_meetings1.Add(convert_classy);
          }
        initmeetings();
        for (int num2 = 0; num2 < vector_meetings1.Count; ++num2)
            appendmeetings(vector_meetings1[num2]);
        for (int num1 = 0; num1 < vector_meetings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONreturn_next_meeting(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field return_next_meeting of HondaAgentScheduleJSON is not true for false.");
              }
          }
        setreturn_next_meeting(the_bool);
      }


    public HondaAgentScheduleJSON()
      {
        flagHasmeetings = false;
        flagHasreturn_next_meeting = false;
        storemeetings = new List< TypemeetingsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasmeetings()
      {
        return flagHasmeetings;
      }

    public int  countOfmeetings()
      {
        Debug.Assert(flagHasmeetings);
        return storemeetings.Count;
      }

    public TypemeetingsJSON   elementOfmeetings(int element_num)
      {
        Debug.Assert(flagHasmeetings);
        return storemeetings[element_num];
      }

    public List< TypemeetingsJSON  >  getmeetings()
      {
        Debug.Assert(flagHasmeetings);
        return storemeetings;
      }

    public bool  hasreturn_next_meeting()
      {
        return flagHasreturn_next_meeting;
      }

    public bool  getreturn_next_meeting()
      {
        Debug.Assert(flagHasreturn_next_meeting);
        return storereturn_next_meeting;
      }


    public virtual int extraHondaAgentScheduleComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHondaAgentScheduleComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHondaAgentScheduleComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHondaAgentScheduleLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initmeetings()
      {
        if (flagHasmeetings)
          {
            for (int num3 = 0; num3 < storemeetings.Count; ++num3)
              {
              }
          }
        flagHasmeetings = true;
        storemeetings.Clear();
      }
    public void appendmeetings(TypemeetingsJSON  to_append)
      {
        if (!flagHasmeetings)
          {
            flagHasmeetings = true;
            storemeetings.Clear();
          }
        Debug.Assert(flagHasmeetings);
        storemeetings.Add(to_append);
      }
    public void unsetmeetings()
      {
        if (flagHasmeetings)
          {
            for (int num4 = 0; num4 < storemeetings.Count; ++num4)
              {
              }
          }
        flagHasmeetings = false;
        storemeetings.Clear();
      }
    public void setreturn_next_meeting(bool new_value)
      {
        flagHasreturn_next_meeting = true;
        storereturn_next_meeting = new_value;
      }
    public void unsetreturn_next_meeting()
      {
        flagHasreturn_next_meeting = false;
      }

    public virtual void extraHondaAgentScheduleAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHondaAgentScheduleSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHondaAgentScheduleLookup(key);
        if (old_field == null)
          {
            extraHondaAgentScheduleAppendPair(key, new_component);
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
        if (flagHasmeetings)
          {
            handler.start_pair("meetings");
            handler.start_array();
            for (int num1 = 0; num1 < storemeetings.Count; ++num1)
              {
                if (partial_allowed)
                    storemeetings[num1].write_partial_as_json(handler);
                else
                    storemeetings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasreturn_next_meeting)
          {
            handler.start_pair("return_next_meeting");
            handler.boolean_value(storereturn_next_meeting);
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

    public static HondaAgentScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgentScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentSchedule", ignore_extras);
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
    public static HondaAgentScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgentScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HondaAgentScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentSchedule", ignore_extras);
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
    public static HondaAgentScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HondaAgentScheduleJSON from_text(string text, bool ignore_extras)
      {
        HondaAgentScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentSchedule", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HondaAgentScheduleJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HondaAgentScheduleJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HondaAgentScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HondaAgentSchedule", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypemeetingsJSON.HoldingArrayGenerator fieldGeneratormeetings;
        private JSONHoldingBooleanGenerator fieldGeneratorreturn_next_meeting;
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
            HondaAgentScheduleJSON result = new HondaAgentScheduleJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHondaAgentScheduleAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HondaAgentScheduleJSON result)
          {
            if (fieldGeneratormeetings.have_value)
              {
                result.initmeetings();
                int count = fieldGeneratormeetings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendmeetings(fieldGeneratormeetings.value[num]);
                  }
                fieldGeneratormeetings.value.Clear();
                fieldGeneratormeetings.have_value = false;
              }
            if (fieldGeneratorreturn_next_meeting.have_value)
              {
                result.setreturn_next_meeting(fieldGeneratorreturn_next_meeting.value);
                fieldGeneratorreturn_next_meeting.have_value = false;
              }
          }
        protected abstract void handle_result(HondaAgentScheduleJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'm':
                    if ((String.Compare(field_name, 1, "eetings", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratormeetings;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "eturn_next_meeting", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorreturn_next_meeting;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratormeetings = new TypemeetingsJSON.HoldingArrayGenerator("field \"meetings\" of the HondaAgentSchedule class", ignore_extras);
            fieldGeneratorreturn_next_meeting = new JSONHoldingBooleanGenerator("field \"return_next_meeting\" of the HondaAgentSchedule class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HondaAgentSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratormeetings = new TypemeetingsJSON.HoldingArrayGenerator("field \"meetings\" of the HondaAgentSchedule class", false);
            fieldGeneratorreturn_next_meeting = new JSONHoldingBooleanGenerator("field \"return_next_meeting\" of the HondaAgentSchedule class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HondaAgentSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratormeetings.reset();
            fieldGeneratorreturn_next_meeting.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratormeetings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratormeetings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HondaAgentScheduleJSON  result)
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
        public HondaAgentScheduleJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HondaAgentScheduleJSON  result)
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
    protected virtual void handle_result(List<HondaAgentScheduleJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HondaAgentScheduleJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HondaAgentScheduleJSON>();
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
    public List<HondaAgentScheduleJSON> value;
  };
  };
