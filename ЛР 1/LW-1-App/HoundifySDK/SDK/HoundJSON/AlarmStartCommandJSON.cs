/* file "AlarmStartCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AlarmStartCommandJSON : AlarmCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeDaysOfWeekKnownValues
          {
            DaysOfWeek_Sunday,
            DaysOfWeek_Monday,
            DaysOfWeek_Tuesday,
            DaysOfWeek_Wednesday,
            DaysOfWeek_Thursday,
            DaysOfWeek_Friday,
            DaysOfWeek_Saturday,
            DaysOfWeek__none
          };
        public struct TypeDaysOfWeek
          {
            public bool in_known_list;
            public string string_value;
            public TypeDaysOfWeekKnownValues list_value;
          };

        public static TypeDaysOfWeekKnownValues  stringToDaysOfWeek(string chars)
          {
            switch (chars[0])
              {
                case 'F':
                    if ((String.Compare(chars, 1, "riday", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeDaysOfWeekKnownValues.DaysOfWeek_Friday;
                    break;
                case 'M':
                    if ((String.Compare(chars, 1, "onday", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeDaysOfWeekKnownValues.DaysOfWeek_Monday;
                    break;
                case 'S':
                    switch (chars[1])
                      {
                        case 'a':
                            if ((String.Compare(chars, 2, "turday", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday;
                            break;
                        case 'u':
                            if ((String.Compare(chars, 2, "nday", 0, 4, false) == 0) && (chars.Length == 6))
                                return TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (chars[1])
                      {
                        case 'h':
                            if ((String.Compare(chars, 2, "ursday", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday;
                            break;
                        case 'u':
                            if ((String.Compare(chars, 2, "esday", 0, 5, false) == 0) && (chars.Length == 7))
                                return TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "ednesday", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday;
                    break;
                default:
                    break;
              }
            return TypeDaysOfWeekKnownValues.DaysOfWeek__none;
          }

        public static string  stringFromDaysOfWeek(TypeDaysOfWeekKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday:
                    return "Sunday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Monday:
                    return "Monday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday:
                    return "Tuesday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday:
                    return "Wednesday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday:
                    return "Thursday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Friday:
                    return "Friday";
                case TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday:
                    return "Saturday";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasTitle;
        private string storeTitle;
        private bool flagHasIsWake;
        private bool storeIsWake;
        private bool flagHasIsRecurring;
        private bool storeIsRecurring;
        private bool flagHasDaysOfWeek;
        private List< TypeDaysOfWeek > storeDaysOfWeek;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Title of TypeNativeDataJSON is not a string.");
            setTitle(json_string.getData());
          }


        private void  fromJSONIsWake(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsWake of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsWake(the_bool);
          }


        private void  fromJSONIsRecurring(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsRecurring of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsRecurring(the_bool);
          }


        private void  fromJSONDaysOfWeek(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field DaysOfWeek of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeDaysOfWeek > vector_DaysOfWeek1 = new List< TypeDaysOfWeek >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field DaysOfWeek of TypeNativeDataJSON is not a string.");
                TypeDaysOfWeek the_open_enum = new TypeDaysOfWeek();
                switch (json_string.getData()[0])
                  {
                    case 'F':
                        if ((String.Compare(json_string.getData(), 1, "riday", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Friday;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'M':
                        if ((String.Compare(json_string.getData(), 1, "onday", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Monday;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'S':
                        switch (json_string.getData()[1])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 2, "turday", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 2, "nday", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        switch (json_string.getData()[1])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 2, "ursday", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 2, "esday", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if ((String.Compare(json_string.getData(), 1, "ednesday", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                the_open_enum.in_known_list = false;
                the_open_enum.string_value = json_string.getData();
              open_enum_is_done:;
                vector_DaysOfWeek1.Add(the_open_enum);
              }
            initDaysOfWeek();
            for (int num1 = 0; num1 < vector_DaysOfWeek1.Count; ++num1)
                appendDaysOfWeek(vector_DaysOfWeek1[num1]);
            for (int num1 = 0; num1 < vector_DaysOfWeek1.Count; ++num1)
              {
              }
          }


        public TypeNativeDataJSON()
          {
            flagHasTitle = false;
            flagHasIsWake = false;
            flagHasIsRecurring = false;
            flagHasDaysOfWeek = false;
            storeIsWake = false;
            storeIsRecurring = false;
            storeDaysOfWeek = new List< TypeDaysOfWeek >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTitle()
          {
            return flagHasTitle;
          }

        public string  getTitle()
          {
            Debug.Assert(flagHasTitle);
            return storeTitle;
          }

        public bool  hasIsWake()
          {
            return flagHasIsWake;
          }

        public bool  getIsWake()
          {
            return storeIsWake;
          }

        public bool  hasIsRecurring()
          {
            return flagHasIsRecurring;
          }

        public bool  getIsRecurring()
          {
            return storeIsRecurring;
          }

        public bool  hasDaysOfWeek()
          {
            return flagHasDaysOfWeek;
          }

        public int  countOfDaysOfWeek()
          {
            Debug.Assert(flagHasDaysOfWeek);
            return storeDaysOfWeek.Count;
          }

        public TypeDaysOfWeek  elementOfDaysOfWeek(int element_num)
          {
            Debug.Assert(flagHasDaysOfWeek);
            return storeDaysOfWeek[element_num];
          }

        public List< TypeDaysOfWeek >  getDaysOfWeek()
          {
            Debug.Assert(flagHasDaysOfWeek);
            return storeDaysOfWeek;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTitle(string new_value)
          {
            flagHasTitle = true;
            storeTitle = new_value;
          }
        public void unsetTitle()
          {
            flagHasTitle = false;
          }
        public void setIsWake(bool new_value)
          {
            flagHasIsWake = true;
            storeIsWake = new_value;
          }
        public void unsetIsWake()
          {
            flagHasIsWake = false;
          }
        public void setIsRecurring(bool new_value)
          {
            flagHasIsRecurring = true;
            storeIsRecurring = new_value;
          }
        public void unsetIsRecurring()
          {
            flagHasIsRecurring = false;
          }
        public void initDaysOfWeek()
          {
            flagHasDaysOfWeek = true;
            storeDaysOfWeek.Clear();
          }
        public void appendDaysOfWeek(TypeDaysOfWeek to_append)
          {
            if (!flagHasDaysOfWeek)
              {
                flagHasDaysOfWeek = true;
                storeDaysOfWeek.Clear();
              }
            Debug.Assert(flagHasDaysOfWeek);
            storeDaysOfWeek.Add(to_append);
          }
        public void appendDaysOfWeek(string chars)
          {
            TypeDaysOfWeekKnownValues known = stringToDaysOfWeek(chars);
            TypeDaysOfWeek new_value = new TypeDaysOfWeek();
            if (known == TypeDaysOfWeekKnownValues.DaysOfWeek__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            appendDaysOfWeek(new_value);
          }
        public void appendDaysOfWeek(TypeDaysOfWeekKnownValues new_value)
          {
            TypeDaysOfWeek new_full_value = new TypeDaysOfWeek();
            Debug.Assert(new_value != TypeDaysOfWeekKnownValues.DaysOfWeek__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            appendDaysOfWeek(new_full_value);
          }
        public void unsetDaysOfWeek()
          {
            flagHasDaysOfWeek = false;
            storeDaysOfWeek.Clear();
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasTitle)
              {
                handler.start_pair("Title");
                handler.string_value(storeTitle);
              }
            if (flagHasIsWake)
              {
                handler.start_pair("IsWake");
                handler.boolean_value(storeIsWake);
              }
            if (flagHasIsRecurring)
              {
                handler.start_pair("IsRecurring");
                handler.boolean_value(storeIsRecurring);
              }
            if (flagHasDaysOfWeek)
              {
                handler.start_pair("DaysOfWeek");
                handler.start_array();
                for (int num1 = 0; num1 < storeDaysOfWeek.Count; ++num1)
                  {
                    if (storeDaysOfWeek[num1].in_known_list)
                      {
                        switch (storeDaysOfWeek[num1].list_value)
                          {
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday:
                                handler.string_value("Sunday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Monday:
                                handler.string_value("Monday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday:
                                handler.string_value("Tuesday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday:
                                handler.string_value("Wednesday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday:
                                handler.string_value("Thursday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Friday:
                                handler.string_value("Friday");
                                break;
                            case TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday:
                                handler.string_value("Saturday");
                                break;
                            default:
                                Debug.Assert(false);
                                break;
                          }
                      }
                    else
                      {
                                handler.string_value(storeDaysOfWeek[num1].string_value);
                      }
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
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
            private JSONHoldingStringGenerator fieldGeneratorTitle;
            private JSONHoldingBooleanGenerator fieldGeneratorIsWake;
            private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
        private abstract class FieldGeneratorDaysOfWeek : JSONStringGenerator
              {
                protected FieldGeneratorDaysOfWeek(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorDaysOfWeek()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeDaysOfWeekKnownValues known = stringToDaysOfWeek(result);
                    TypeDaysOfWeek new_value = new TypeDaysOfWeek();
                    if (known == TypeDaysOfWeekKnownValues.DaysOfWeek__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeDaysOfWeek result);
              };
        private class FieldHoldingGeneratorDaysOfWeek : FieldGeneratorDaysOfWeek
      {
        protected override void handle_result(TypeDaysOfWeek result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorDaysOfWeek(String what)
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
        public TypeDaysOfWeek value;
      };
        private class FieldHoldingArrayGeneratorDaysOfWeek : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorDaysOfWeek
          {
            private FieldHoldingArrayGeneratorDaysOfWeek top;

            protected override void handle_result(TypeDaysOfWeek result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorDaysOfWeek init_top)
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
        protected virtual void handle_result(List<TypeDaysOfWeek> result)
          {
          }

        public FieldHoldingArrayGeneratorDaysOfWeek(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDaysOfWeek>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorDaysOfWeek()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDaysOfWeek>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeDaysOfWeek> value;
      };
            private FieldHoldingArrayGeneratorDaysOfWeek fieldGeneratorDaysOfWeek;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorTitle.have_value)
                  {
                    result.setTitle(fieldGeneratorTitle.value);
                    fieldGeneratorTitle.have_value = false;
                  }
                if (fieldGeneratorIsWake.have_value)
                  {
                    result.setIsWake(fieldGeneratorIsWake.value);
                    fieldGeneratorIsWake.have_value = false;
                  }
                if (fieldGeneratorIsRecurring.have_value)
                  {
                    result.setIsRecurring(fieldGeneratorIsRecurring.value);
                    fieldGeneratorIsRecurring.have_value = false;
                  }
                if (fieldGeneratorDaysOfWeek.have_value)
                  {
                    result.initDaysOfWeek();
                    int count = fieldGeneratorDaysOfWeek.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendDaysOfWeek(fieldGeneratorDaysOfWeek.value[num]);
                      }
                    fieldGeneratorDaysOfWeek.value.Clear();
                    fieldGeneratorDaysOfWeek.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "aysOfWeek", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDaysOfWeek;
                        break;
                    case 'I':
                        if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                          {
                            switch (field_name[2])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 3, "ecurring", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsRecurring;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 3, "ake", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorIsWake;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTitle;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorIsWake = new JSONHoldingBooleanGenerator("field \"IsWake\" of the TypeNativeData class");
                fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the TypeNativeData class");
                fieldGeneratorDaysOfWeek = new FieldHoldingArrayGeneratorDaysOfWeek("field \"DaysOfWeek\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeNativeData class");
                fieldGeneratorIsWake = new JSONHoldingBooleanGenerator("field \"IsWake\" of the TypeNativeData class");
                fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the TypeNativeData class");
                fieldGeneratorDaysOfWeek = new FieldHoldingArrayGeneratorDaysOfWeek("field \"DaysOfWeek\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTitle.reset();
                fieldGeneratorIsWake.reset();
                fieldGeneratorIsRecurring.reset();
                fieldGeneratorDaysOfWeek.reset();
                base.reset();
                unknownFieldGenerator.reset();
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


    public AlarmStartCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAlarmCommandKind()
      {
        return "AlarmStartCommand";
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


    public virtual int extraAlarmStartCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAlarmStartCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAlarmStartCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAlarmStartCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAlarmCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraAlarmStartCommandComponentCount();
        return result;
      }
    public override string extraAlarmCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraAlarmStartCommandComponentKey(remainder);
      }
    public override JSONValue extraAlarmCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraAlarmStartCommandComponentValue(remainder);
      }
    public override JSONValue extraAlarmCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraAlarmStartCommandLookup(field_name);
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

    public virtual void extraAlarmStartCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAlarmStartCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAlarmStartCommandLookup(key);
        if (old_field == null)
          {
            extraAlarmStartCommandAppendPair(key, new_component);
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
    public override void extraAlarmCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraAlarmStartCommandAppendPair(key, new_component);
      }
    public override void extraAlarmCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraAlarmStartCommandSetField(key, new_component);
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

    public static new AlarmStartCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmStartCommand", ignore_extras);
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
    public static new AlarmStartCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlarmStartCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmStartCommand", ignore_extras);
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
    public static new AlarmStartCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AlarmStartCommandJSON from_text(string text, bool ignore_extras)
      {
        AlarmStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmStartCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AlarmStartCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AlarmStartCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AlarmStartCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AlarmStartCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AlarmCommandJSON.Generator
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
            if (!(getAlarmCommandJSONKey().Equals("AlarmStartCommand")))
                throw new Exception("The key field has a value other than `AlarmStartCommand'.");
            AlarmStartCommandJSON result = new AlarmStartCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAlarmStartCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AlarmCommandJSON new_result)
          {
            handle_result((AlarmStartCommandJSON )new_result);
          }
        protected void finish(AlarmStartCommandJSON result)
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
        protected abstract void handle_result(AlarmStartCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the AlarmStartCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the AlarmStartCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the AlarmStartCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the AlarmStartCommand class");
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
        protected override void handle_result(AlarmStartCommandJSON  result)
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
        public AlarmStartCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AlarmStartCommandJSON  result)
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
    protected virtual void handle_result(List<AlarmStartCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AlarmStartCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AlarmStartCommandJSON>();
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
    public List<AlarmStartCommandJSON> value;
  };
  };
