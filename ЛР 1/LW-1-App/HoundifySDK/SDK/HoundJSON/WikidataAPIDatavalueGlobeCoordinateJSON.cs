/* file "WikidataAPIDatavalueGlobeCoordinateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPIDatavalueGlobeCoordinateJSON : WikidataAPIDatavalueJSON
  {
    public class TypevalueJSON : JSONBase
      {
        public struct Typeprecision
          {
            public int key;
            [StructLayout(LayoutKind.Explicit)]
            public struct Utype
              {
                [FieldOffset(0)]
                public double choice0;
                [FieldOffset(0)]
                public bool choice1;
              };
            public Utype u;
          };
        private bool flagHaslongitude;
        private double storelongitude;
        private string textStorelongitude;
        private bool flagHaslatitude;
        private double storelatitude;
        private string textStorelatitude;
        private bool flagHasprecision;
        private Typeprecision storeprecision;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONlongitude(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field longitude of TypevalueJSON is not a number.");
                  }
              }
            setlongitudeText(the_rational_text);
          }


        private void  fromJSONlatitude(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field latitude of TypevalueJSON is not a number.");
                  }
              }
            setlatitudeText(the_rational_text);
          }


        private void  fromJSONprecision(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            Typeprecision or_result = new Typeprecision();
            bool or_done = false;
            if (!or_done)
              {
                try
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    double the_double;
                    if (json_rational != null)
                      {
                        the_double = json_rational.getDouble();
                      }
                    else
                      {
                        JSONIntegerValue json_integer = json_value.integer_value();
                        if (json_integer != null)
                          {
                            the_double = json_integer.getLongInt();
                          }
                        else
                          {
                            throw new Exception("The value for ??? is not a number.");
                          }
                      }
                    or_result.u.choice0 = the_double;
                    or_result.key = 0;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
              {
                try
                  {
                    or_result.key = 1;
                    or_done = true;
                  }
                catch (Exception )
                  {
                  }
              }
            if (!or_done)
                throw new Exception("The value for field precision of TypevalueJSON is not one of the allowed values.");
            setprecision(or_result);
            switch (or_result.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }


        public TypevalueJSON()
          {
            flagHaslongitude = false;
            flagHaslatitude = false;
            flagHasprecision = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  haslongitude()
          {
            return flagHaslongitude;
          }

        public double  getlongitude()
          {
            Debug.Assert(flagHaslongitude);
            if (textStorelongitude != "")
              {
                return Double.Parse(textStorelongitude);
              }
            return storelongitude;
          }

        public string  getlongitudeAsText()
          {
            Debug.Assert(flagHaslongitude);
            if (textStorelongitude == "")
              {
                return Convert.ToString(storelongitude);
              }
            else
              {
                return (textStorelongitude);
              }
          }

        public bool  haslatitude()
          {
            return flagHaslatitude;
          }

        public double  getlatitude()
          {
            Debug.Assert(flagHaslatitude);
            if (textStorelatitude != "")
              {
                return Double.Parse(textStorelatitude);
              }
            return storelatitude;
          }

        public string  getlatitudeAsText()
          {
            Debug.Assert(flagHaslatitude);
            if (textStorelatitude == "")
              {
                return Convert.ToString(storelatitude);
              }
            else
              {
                return (textStorelatitude);
              }
          }

        public bool  hasprecision()
          {
            return flagHasprecision;
          }

        public Typeprecision  getprecision()
          {
            Debug.Assert(flagHasprecision);
            return storeprecision;
          }


        public virtual int extraTypevalueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypevalueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypevalueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypevalueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setlongitude(double new_value)
          {
            flagHaslongitude = true;
            storelongitude = new_value;
            textStorelongitude = "";
          }
        public void setlongitudeText(string new_value)
          {
            flagHaslongitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field longitude of TypevalueJSON is not a valid number.");
            textStorelongitude = new_value;
          }
        public void unsetlongitude()
          {
            flagHaslongitude = false;
          }
        public void setlatitude(double new_value)
          {
            flagHaslatitude = true;
            storelatitude = new_value;
            textStorelatitude = "";
          }
        public void setlatitudeText(string new_value)
          {
            flagHaslatitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field latitude of TypevalueJSON is not a valid number.");
            textStorelatitude = new_value;
          }
        public void unsetlatitude()
          {
            flagHaslatitude = false;
          }
        public void setprecision(Typeprecision new_value)
          {
            flagHasprecision = true;
            switch (new_value.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
            storeprecision = new_value;
          }
        public void unsetprecision()
          {
            flagHasprecision = false;
          }

        public virtual void extraTypevalueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypevalueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypevalueLookup(key);
            if (old_field == null)
              {
                extraTypevalueAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHaslongitude);
            if (flagHaslongitude)
              {
                handler.start_pair("longitude");
                if (textStorelongitude != "")
                    handler.number_value(textStorelongitude);
                else if (((double)(long)storelongitude) == storelongitude)
                    handler.number_value((long)storelongitude);
                else
                    handler.number_value(storelongitude);
              }
            Debug.Assert(partial_allowed || flagHaslatitude);
            if (flagHaslatitude)
              {
                handler.start_pair("latitude");
                if (textStorelatitude != "")
                    handler.number_value(textStorelatitude);
                else if (((double)(long)storelatitude) == storelatitude)
                    handler.number_value((long)storelatitude);
                else
                    handler.number_value(storelatitude);
              }
            Debug.Assert(partial_allowed || flagHasprecision);
            if (flagHasprecision)
              {
                handler.start_pair("precision");
                switch (storeprecision.key)
                  {
                    case 0:
                        if (((double)(long)storeprecision.u.choice0) == storeprecision.u.choice0)
                            handler.number_value((long)storeprecision.u.choice0);
                        else
                            handler.number_value(storeprecision.u.choice0);
                        break;
                    case 1:
                        handler.null_value();
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
            if (!(haslongitude()))
              {
                return "When parsing the object for %what%, the \"longitude\" field was missing.";
              }
            if (!(haslatitude()))
              {
                return "When parsing the object for %what%, the \"latitude\" field was missing.";
              }
            if (!(hasprecision()))
              {
                return "When parsing the object for %what%, the \"precision\" field was missing.";
              }
            return null;
          }

        public static TypevalueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
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
        public static TypevalueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypevalueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
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
        public static TypevalueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypevalueJSON from_text(string text, bool ignore_extras)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypevalueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypevalueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypevalueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typevalue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorlongitude;
            private JSONHoldingNumberTextGenerator fieldGeneratorlatitude;
        private abstract class FieldGeneratorprecision : JSONParallelGenerator
              {
                private JSONHoldingNumberTextGenerator field0;
                private JSONHoldingNullGenerator field1;
                private JSONHandler [] all_handlers = new JSONHandler [2];
                protected override JSONHandler[] start()
                  {
                    return all_handlers;
                  }
                protected override void finish(int winning_index)
                  {
                    Typeprecision result = new Typeprecision();
                    result.key = winning_index;
                    switch (winning_index)
                      {
                        case 0:
                          {
                            Debug.Assert(field0.have_value);
                            result.u.choice0 = Double.Parse(field0.value);
                            break;
                          }
                        case 1:
                          {
                            Debug.Assert(field1.have_value);
                            result.u.choice1 = field1.value;
                            break;
                          }
                        default:
                          {
                            Debug.Assert(false);
                            break;
                          }
                      }
                    handle_result(result);
                  }
                protected abstract void handle_result(Typeprecision result);
                public FieldGeneratorprecision(bool ignore_extras)
                  {
                        field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"precision\"");
                        field1 = new JSONHoldingNullGenerator("option 1 of field \"precision\"");
                    all_handlers[0] = field0;
                    all_handlers[1] = field1;
                  }
                public FieldGeneratorprecision(string what, bool ignore_extras)
                  {
                        field0 = new JSONHoldingNumberTextGenerator("option 0 of field \"precision\"");
                        field1 = new JSONHoldingNullGenerator("option 1 of field \"precision\"");
                    all_handlers[0] = field0;
                    all_handlers[1] = field1;
                  }

                public override void reset()
                  {
                    field0.reset();
                    field1.reset();
                    base.reset();
                  }
              };
            private class Holderprecision
              {
                private bool have_data;
                private Typeprecision data;
                public Holderprecision()  { have_data = false; }
                public Holderprecision(Typeprecision init_data)
                  {
                    have_data = true;
                    data = init_data;
                    if (have_data)
                      {
                      }
                  }
                public Holderprecision(Holderprecision other)
                  {
                    have_data = other.haveData();
                    data = other.referenced();
                    if (have_data)
                      {
                      }
                  }

                public bool haveData()
                  {
                    return have_data;
                  }
                public Typeprecision referenced()
                  {
                    return data;
                  }
              };
        private class FieldHoldingGeneratorprecision : FieldGeneratorprecision
              {
                protected override void handle_result(Typeprecision result)
                  {
            //@@@        Debug.Assert(!have_value);
                    have_value = true;
                    value = new Holderprecision(result);
                  }

                public FieldHoldingGeneratorprecision(String what, bool ignore_extras) : base(ignore_extras)
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
                public Holderprecision value;
              };
        private class FieldHoldingArrayGeneratorprecision : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorprecision
          {
            private FieldHoldingArrayGeneratorprecision top;

            protected override void handle_result(Typeprecision result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorprecision init_top, bool ignore_extras) : base(ignore_extras)
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
        protected virtual void handle_result(List<Typeprecision> result)
          {
          }

        public FieldHoldingArrayGeneratorprecision(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typeprecision>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorprecision(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<Typeprecision>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<Typeprecision> value;
      };
            private FieldHoldingGeneratorprecision fieldGeneratorprecision;
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
                TypevalueJSON result = new TypevalueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypevalueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypevalueJSON result)
              {
                if (fieldGeneratorlongitude.have_value)
                  {
                    result.setlongitudeText(fieldGeneratorlongitude.value);
                    fieldGeneratorlongitude.have_value = false;
                  }
                else if ((!(result.haslongitude())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"longitude\" field was missing.");
                  }
                if (fieldGeneratorlatitude.have_value)
                  {
                    result.setlatitudeText(fieldGeneratorlatitude.value);
                    fieldGeneratorlatitude.have_value = false;
                  }
                else if ((!(result.haslatitude())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"latitude\" field was missing.");
                  }
                if (fieldGeneratorprecision.have_value)
                  {
                    result.setprecision(fieldGeneratorprecision.value.referenced());
                    fieldGeneratorprecision.have_value = false;
                  }
                else if ((!(result.hasprecision())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"precision\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypevalueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'l':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorlatitude;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorlongitude;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 1, "recision", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorprecision;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the Typevalue class");
                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the Typevalue class");
                fieldGeneratorprecision = new FieldHoldingGeneratorprecision("field \"precision\" of the Typevalue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorlongitude = new JSONHoldingNumberTextGenerator("field \"longitude\" of the Typevalue class");
                fieldGeneratorlatitude = new JSONHoldingNumberTextGenerator("field \"latitude\" of the Typevalue class");
                fieldGeneratorprecision = new FieldHoldingGeneratorprecision("field \"precision\" of the Typevalue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the Typevalue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorlongitude.reset();
                fieldGeneratorlatitude.reset();
                fieldGeneratorprecision.reset();
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
            protected override void handle_result(TypevalueJSON  result)
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
            public TypevalueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypevalueJSON  result)
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
        protected virtual void handle_result(List<TypevalueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypevalueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypevalueJSON>();
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
        public List<TypevalueJSON> value;
      };
      };
    private bool flagHasvalue;
    private TypevalueJSON  storevalue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extravalueToJSON()
      {
        JSONValueHandler handler_value = new JSONValueHandler();
        storevalue.write_as_json(handler_value);
        return handler_value.result;
      }


    private void  fromJSONvalue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypevalueJSON convert_classy = TypevalueJSON.from_json(json_value, ignore_extras, true);
        setvalue(convert_classy);
      }


    public WikidataAPIDatavalueGlobeCoordinateJSON()
      {
        flagHasvalue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  gettype()
      {
        return "globecoordinate";
      }

    public bool  hasvalue()
      {
        return flagHasvalue;
      }

    public TypevalueJSON   getvalue()
      {
        Debug.Assert(flagHasvalue);
        return storevalue;
      }


    public virtual int extraWikidataAPIDatavalueGlobeCoordinateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPIDatavalueGlobeCoordinateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueGlobeCoordinateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPIDatavalueGlobeCoordinateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWikidataAPIDatavalueComponentCount()
      {
        int result = 0;
        if (flagHasvalue)
            ++result;
        result += extraWikidataAPIDatavalueGlobeCoordinateComponentCount();
        return result;
      }
    public override string extraWikidataAPIDatavalueComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasvalue)
          {
            if (remainder == 0)
                return "value";
            --remainder;
          }
        return extraWikidataAPIDatavalueGlobeCoordinateComponentKey(remainder);
      }
    public override JSONValue extraWikidataAPIDatavalueComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasvalue)
          {
            if (remainder == 0)
                return extravalueToJSON();
            --remainder;
          }
        return extraWikidataAPIDatavalueGlobeCoordinateComponentValue(remainder);
      }
    public override JSONValue extraWikidataAPIDatavalueLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
            return (flagHasvalue ? extravalueToJSON() : null);
        return extraWikidataAPIDatavalueGlobeCoordinateLookup(field_name);
      }

    public void setvalue(TypevalueJSON  new_value)
      {
        if (flagHasvalue)
          {
          }
        flagHasvalue = true;
        storevalue = new_value;
      }
    public void unsetvalue()
      {
        if (flagHasvalue)
          {
          }
        flagHasvalue = false;
      }

    public virtual void extraWikidataAPIDatavalueGlobeCoordinateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPIDatavalueGlobeCoordinateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPIDatavalueGlobeCoordinateLookup(key);
        if (old_field == null)
          {
            extraWikidataAPIDatavalueGlobeCoordinateAppendPair(key, new_component);
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
    public override void extraWikidataAPIDatavalueAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "value", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONvalue(new_component, false);
            return;
            }
        extraWikidataAPIDatavalueGlobeCoordinateAppendPair(key, new_component);
      }
    public override void extraWikidataAPIDatavalueSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "value", 0, 5, false) == 0) && (key.Length == 5))
            {
            fromJSONvalue(new_component, false);
            return;
            }
        extraWikidataAPIDatavalueGlobeCoordinateSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasvalue);
        if (flagHasvalue)
          {
            handler.start_pair("value");
            if (partial_allowed)
                storevalue.write_partial_as_json(handler);
            else
                storevalue.write_as_json(handler);
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
        if (!(hasvalue()))
          {
            return "When parsing the object for %what%, the \"value\" field was missing.";
          }
        return null;
      }

    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueGlobeCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueGlobeCoordinate", ignore_extras);
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
    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIDatavalueGlobeCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueGlobeCoordinate", ignore_extras);
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
    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPIDatavalueGlobeCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueGlobeCoordinate", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPIDatavalueGlobeCoordinateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WikidataAPIDatavalueGlobeCoordinateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPIDatavalueGlobeCoordinateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIDatavalueGlobeCoordinate", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WikidataAPIDatavalueJSON.Generator
      {
        private TypevalueJSON.HoldingGenerator fieldGeneratorvalue;
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
            if (!(getWikidataAPIDatavalueJSONKey().Equals("globecoordinate")))
                throw new Exception("The key field has a value other than `globecoordinate'.");
            WikidataAPIDatavalueGlobeCoordinateJSON result = new WikidataAPIDatavalueGlobeCoordinateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPIDatavalueGlobeCoordinateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WikidataAPIDatavalueJSON new_result)
          {
            handle_result((WikidataAPIDatavalueGlobeCoordinateJSON )new_result);
          }
        protected void finish(WikidataAPIDatavalueGlobeCoordinateJSON result)
          {
            if (fieldGeneratorvalue.have_value)
              {
                result.setvalue(fieldGeneratorvalue.value);
                fieldGeneratorvalue.have_value = false;
              }
            else if ((!(result.hasvalue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"value\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(WikidataAPIDatavalueGlobeCoordinateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "value", 0, 5, false) == 0) && (field_name.Length == 5))
                return fieldGeneratorvalue;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueGlobeCoordinate class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPIDatavalueGlobeCoordinate class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorvalue = new TypevalueJSON.HoldingGenerator("field \"value\" of the WikidataAPIDatavalueGlobeCoordinate class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPIDatavalueGlobeCoordinate class");
          }

        public override void reset()
          {
            fieldGeneratorvalue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WikidataAPIDatavalueGlobeCoordinateJSON  result)
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
        public WikidataAPIDatavalueGlobeCoordinateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPIDatavalueGlobeCoordinateJSON  result)
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
    protected virtual void handle_result(List<WikidataAPIDatavalueGlobeCoordinateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPIDatavalueGlobeCoordinateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPIDatavalueGlobeCoordinateJSON>();
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
    public List<WikidataAPIDatavalueGlobeCoordinateJSON> value;
  };
  };
