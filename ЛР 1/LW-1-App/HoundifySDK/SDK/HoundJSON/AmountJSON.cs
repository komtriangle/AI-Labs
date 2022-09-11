/* file "AmountJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AmountJSON : JSONBase
  {
    public class TypeUnitJSON : JSONBase
      {
        private bool flagHasSingularSpokenName;
        private string storeSingularSpokenName;
        private bool flagHasSingularWrittenName;
        private string storeSingularWrittenName;
        private bool flagHasPluralSpokenName;
        private string storePluralSpokenName;
        private bool flagHasPluralWrittenName;
        private string storePluralWrittenName;
        private bool flagHasAbbreviation;
        private string storeAbbreviation;
        private bool flagHasSymbol;
        private string storeSymbol;
        private bool flagHasSymbolIsPrefix;
        private bool storeSymbolIsPrefix;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSingularSpokenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SingularSpokenName of TypeUnitJSON is not a string.");
            setSingularSpokenName(json_string.getData());
          }


        private void  fromJSONSingularWrittenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SingularWrittenName of TypeUnitJSON is not a string.");
            setSingularWrittenName(json_string.getData());
          }


        private void  fromJSONPluralSpokenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PluralSpokenName of TypeUnitJSON is not a string.");
            setPluralSpokenName(json_string.getData());
          }


        private void  fromJSONPluralWrittenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PluralWrittenName of TypeUnitJSON is not a string.");
            setPluralWrittenName(json_string.getData());
          }


        private void  fromJSONAbbreviation(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Abbreviation of TypeUnitJSON is not a string.");
            setAbbreviation(json_string.getData());
          }


        private void  fromJSONSymbol(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Symbol of TypeUnitJSON is not a string.");
            setSymbol(json_string.getData());
          }


        private void  fromJSONSymbolIsPrefix(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field SymbolIsPrefix of TypeUnitJSON is not true for false.");
                  }
              }
            setSymbolIsPrefix(the_bool);
          }


        public TypeUnitJSON()
          {
            flagHasSingularSpokenName = false;
            flagHasSingularWrittenName = false;
            flagHasPluralSpokenName = false;
            flagHasPluralWrittenName = false;
            flagHasAbbreviation = false;
            flagHasSymbol = false;
            flagHasSymbolIsPrefix = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSingularSpokenName()
          {
            return flagHasSingularSpokenName;
          }

        public string  getSingularSpokenName()
          {
            Debug.Assert(flagHasSingularSpokenName);
            return storeSingularSpokenName;
          }

        public bool  hasSingularWrittenName()
          {
            return flagHasSingularWrittenName;
          }

        public string  getSingularWrittenName()
          {
            Debug.Assert(flagHasSingularWrittenName);
            return storeSingularWrittenName;
          }

        public bool  hasPluralSpokenName()
          {
            return flagHasPluralSpokenName;
          }

        public string  getPluralSpokenName()
          {
            Debug.Assert(flagHasPluralSpokenName);
            return storePluralSpokenName;
          }

        public bool  hasPluralWrittenName()
          {
            return flagHasPluralWrittenName;
          }

        public string  getPluralWrittenName()
          {
            Debug.Assert(flagHasPluralWrittenName);
            return storePluralWrittenName;
          }

        public bool  hasAbbreviation()
          {
            return flagHasAbbreviation;
          }

        public string  getAbbreviation()
          {
            Debug.Assert(flagHasAbbreviation);
            return storeAbbreviation;
          }

        public bool  hasSymbol()
          {
            return flagHasSymbol;
          }

        public string  getSymbol()
          {
            Debug.Assert(flagHasSymbol);
            return storeSymbol;
          }

        public bool  hasSymbolIsPrefix()
          {
            return flagHasSymbolIsPrefix;
          }

        public bool  getSymbolIsPrefix()
          {
            Debug.Assert(flagHasSymbolIsPrefix);
            return storeSymbolIsPrefix;
          }


        public virtual int extraTypeUnitComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeUnitComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeUnitComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeUnitLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSingularSpokenName(string new_value)
          {
            flagHasSingularSpokenName = true;
            storeSingularSpokenName = new_value;
          }
        public void unsetSingularSpokenName()
          {
            flagHasSingularSpokenName = false;
          }
        public void setSingularWrittenName(string new_value)
          {
            flagHasSingularWrittenName = true;
            storeSingularWrittenName = new_value;
          }
        public void unsetSingularWrittenName()
          {
            flagHasSingularWrittenName = false;
          }
        public void setPluralSpokenName(string new_value)
          {
            flagHasPluralSpokenName = true;
            storePluralSpokenName = new_value;
          }
        public void unsetPluralSpokenName()
          {
            flagHasPluralSpokenName = false;
          }
        public void setPluralWrittenName(string new_value)
          {
            flagHasPluralWrittenName = true;
            storePluralWrittenName = new_value;
          }
        public void unsetPluralWrittenName()
          {
            flagHasPluralWrittenName = false;
          }
        public void setAbbreviation(string new_value)
          {
            flagHasAbbreviation = true;
            storeAbbreviation = new_value;
          }
        public void unsetAbbreviation()
          {
            flagHasAbbreviation = false;
          }
        public void setSymbol(string new_value)
          {
            flagHasSymbol = true;
            storeSymbol = new_value;
          }
        public void unsetSymbol()
          {
            flagHasSymbol = false;
          }
        public void setSymbolIsPrefix(bool new_value)
          {
            flagHasSymbolIsPrefix = true;
            storeSymbolIsPrefix = new_value;
          }
        public void unsetSymbolIsPrefix()
          {
            flagHasSymbolIsPrefix = false;
          }

        public virtual void extraTypeUnitAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeUnitSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeUnitLookup(key);
            if (old_field == null)
              {
                extraTypeUnitAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasSingularSpokenName);
            if (flagHasSingularSpokenName)
              {
                handler.start_pair("SingularSpokenName");
                handler.string_value(storeSingularSpokenName);
              }
            Debug.Assert(partial_allowed || flagHasSingularWrittenName);
            if (flagHasSingularWrittenName)
              {
                handler.start_pair("SingularWrittenName");
                handler.string_value(storeSingularWrittenName);
              }
            Debug.Assert(partial_allowed || flagHasPluralSpokenName);
            if (flagHasPluralSpokenName)
              {
                handler.start_pair("PluralSpokenName");
                handler.string_value(storePluralSpokenName);
              }
            Debug.Assert(partial_allowed || flagHasPluralWrittenName);
            if (flagHasPluralWrittenName)
              {
                handler.start_pair("PluralWrittenName");
                handler.string_value(storePluralWrittenName);
              }
            if (flagHasAbbreviation)
              {
                handler.start_pair("Abbreviation");
                handler.string_value(storeAbbreviation);
              }
            if (flagHasSymbol)
              {
                handler.start_pair("Symbol");
                handler.string_value(storeSymbol);
              }
            if (flagHasSymbolIsPrefix)
              {
                handler.start_pair("SymbolIsPrefix");
                handler.boolean_value(storeSymbolIsPrefix);
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
            if (!(hasSingularSpokenName()))
              {
                return "When parsing the object for %what%, the \"SingularSpokenName\" field was missing.";
              }
            if (!(hasSingularWrittenName()))
              {
                return "When parsing the object for %what%, the \"SingularWrittenName\" field was missing.";
              }
            if (!(hasPluralSpokenName()))
              {
                return "When parsing the object for %what%, the \"PluralSpokenName\" field was missing.";
              }
            if (!(hasPluralWrittenName()))
              {
                return "When parsing the object for %what%, the \"PluralWrittenName\" field was missing.";
              }
            return null;
          }

        public static TypeUnitJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUnitJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUnit", ignore_extras);
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
        public static TypeUnitJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUnitJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUnitJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUnit", ignore_extras);
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
        public static TypeUnitJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUnitJSON from_text(string text, bool ignore_extras)
          {
            TypeUnitJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUnit", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeUnitJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeUnitJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeUnitJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUnit", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorSingularSpokenName;
            private JSONHoldingStringGenerator fieldGeneratorSingularWrittenName;
            private JSONHoldingStringGenerator fieldGeneratorPluralSpokenName;
            private JSONHoldingStringGenerator fieldGeneratorPluralWrittenName;
            private JSONHoldingStringGenerator fieldGeneratorAbbreviation;
            private JSONHoldingStringGenerator fieldGeneratorSymbol;
            private JSONHoldingBooleanGenerator fieldGeneratorSymbolIsPrefix;
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
                TypeUnitJSON result = new TypeUnitJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeUnitAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeUnitJSON result)
              {
                if (fieldGeneratorSingularSpokenName.have_value)
                  {
                    result.setSingularSpokenName(fieldGeneratorSingularSpokenName.value);
                    fieldGeneratorSingularSpokenName.have_value = false;
                  }
                else if ((!(result.hasSingularSpokenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SingularSpokenName\" field was missing.");
                  }
                if (fieldGeneratorSingularWrittenName.have_value)
                  {
                    result.setSingularWrittenName(fieldGeneratorSingularWrittenName.value);
                    fieldGeneratorSingularWrittenName.have_value = false;
                  }
                else if ((!(result.hasSingularWrittenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SingularWrittenName\" field was missing.");
                  }
                if (fieldGeneratorPluralSpokenName.have_value)
                  {
                    result.setPluralSpokenName(fieldGeneratorPluralSpokenName.value);
                    fieldGeneratorPluralSpokenName.have_value = false;
                  }
                else if ((!(result.hasPluralSpokenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PluralSpokenName\" field was missing.");
                  }
                if (fieldGeneratorPluralWrittenName.have_value)
                  {
                    result.setPluralWrittenName(fieldGeneratorPluralWrittenName.value);
                    fieldGeneratorPluralWrittenName.have_value = false;
                  }
                else if ((!(result.hasPluralWrittenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PluralWrittenName\" field was missing.");
                  }
                if (fieldGeneratorAbbreviation.have_value)
                  {
                    result.setAbbreviation(fieldGeneratorAbbreviation.value);
                    fieldGeneratorAbbreviation.have_value = false;
                  }
                if (fieldGeneratorSymbol.have_value)
                  {
                    result.setSymbol(fieldGeneratorSymbol.value);
                    fieldGeneratorSymbol.have_value = false;
                  }
                if (fieldGeneratorSymbolIsPrefix.have_value)
                  {
                    result.setSymbolIsPrefix(fieldGeneratorSymbolIsPrefix.value);
                    fieldGeneratorSymbolIsPrefix.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeUnitJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "bbreviation", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorAbbreviation;
                        break;
                    case 'P':
                        if (String.Compare(field_name, 1, "lural", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'S':
                                    if ((String.Compare(field_name, 7, "pokenName", 0, 9, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorPluralSpokenName;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 7, "rittenName", 0, 10, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorPluralWrittenName;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'i':
                                if (String.Compare(field_name, 2, "ngular", 0, 6, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 9, "pokenName", 0, 9, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorSingularSpokenName;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 9, "rittenName", 0, 10, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorSingularWrittenName;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'y':
                                if (String.Compare(field_name, 2, "mbol", 0, 4, false) == 0)
                                  {
                                    if (field_name.Length == 6)
                                      {
                                        return fieldGeneratorSymbol;
                                      }
                                    switch (field_name[6])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 7, "sPrefix", 0, 7, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorSymbolIsPrefix;
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
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSingularSpokenName = new JSONHoldingStringGenerator("field \"SingularSpokenName\" of the TypeUnit class");
                fieldGeneratorSingularWrittenName = new JSONHoldingStringGenerator("field \"SingularWrittenName\" of the TypeUnit class");
                fieldGeneratorPluralSpokenName = new JSONHoldingStringGenerator("field \"PluralSpokenName\" of the TypeUnit class");
                fieldGeneratorPluralWrittenName = new JSONHoldingStringGenerator("field \"PluralWrittenName\" of the TypeUnit class");
                fieldGeneratorAbbreviation = new JSONHoldingStringGenerator("field \"Abbreviation\" of the TypeUnit class");
                fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the TypeUnit class");
                fieldGeneratorSymbolIsPrefix = new JSONHoldingBooleanGenerator("field \"SymbolIsPrefix\" of the TypeUnit class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeUnit class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSingularSpokenName = new JSONHoldingStringGenerator("field \"SingularSpokenName\" of the TypeUnit class");
                fieldGeneratorSingularWrittenName = new JSONHoldingStringGenerator("field \"SingularWrittenName\" of the TypeUnit class");
                fieldGeneratorPluralSpokenName = new JSONHoldingStringGenerator("field \"PluralSpokenName\" of the TypeUnit class");
                fieldGeneratorPluralWrittenName = new JSONHoldingStringGenerator("field \"PluralWrittenName\" of the TypeUnit class");
                fieldGeneratorAbbreviation = new JSONHoldingStringGenerator("field \"Abbreviation\" of the TypeUnit class");
                fieldGeneratorSymbol = new JSONHoldingStringGenerator("field \"Symbol\" of the TypeUnit class");
                fieldGeneratorSymbolIsPrefix = new JSONHoldingBooleanGenerator("field \"SymbolIsPrefix\" of the TypeUnit class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeUnit class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSingularSpokenName.reset();
                fieldGeneratorSingularWrittenName.reset();
                fieldGeneratorPluralSpokenName.reset();
                fieldGeneratorPluralWrittenName.reset();
                fieldGeneratorAbbreviation.reset();
                fieldGeneratorSymbol.reset();
                fieldGeneratorSymbolIsPrefix.reset();
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
            protected override void handle_result(TypeUnitJSON  result)
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
            public TypeUnitJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeUnitJSON  result)
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
        protected virtual void handle_result(List<TypeUnitJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeUnitJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeUnitJSON>();
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
        public List<TypeUnitJSON> value;
      };
      };
    private bool flagHasQuantity;
    private double storeQuantity;
    private string textStoreQuantity;
    private bool flagHasQuantityDetails;
    private QuantityJSON  storeQuantityDetails;
    private bool flagHasUnit;
    private TypeUnitJSON  storeUnit;
    private bool flagHasUnitDetails;
    private UnitJSON  storeUnitDetails;
    private bool flagHasSpokenQuantityName;
    private string storeSpokenQuantityName;
    private bool flagHasWrittenQuantityName;
    private string storeWrittenQuantityName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQuantity(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Quantity of AmountJSON is not a number.");
              }
          }
        setQuantityText(the_rational_text);
      }


    private void  fromJSONQuantityDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        QuantityJSON convert_classy = QuantityJSON.from_json(json_value, ignore_extras, true);
        setQuantityDetails(convert_classy);
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeUnitJSON convert_classy = TypeUnitJSON.from_json(json_value, ignore_extras, true);
        setUnit(convert_classy);
      }


    private void  fromJSONUnitDetails(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitJSON convert_classy = UnitJSON.from_json(json_value, ignore_extras, true);
        setUnitDetails(convert_classy);
      }


    private void  fromJSONSpokenQuantityName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenQuantityName of AmountJSON is not a string.");
        setSpokenQuantityName(json_string.getData());
      }


    private void  fromJSONWrittenQuantityName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WrittenQuantityName of AmountJSON is not a string.");
        setWrittenQuantityName(json_string.getData());
      }


    public AmountJSON()
      {
        flagHasQuantity = false;
        flagHasQuantityDetails = false;
        flagHasUnit = false;
        flagHasUnitDetails = false;
        flagHasSpokenQuantityName = false;
        flagHasWrittenQuantityName = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQuantity()
      {
        return flagHasQuantity;
      }

    public double  getQuantity()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity != "")
          {
            return Double.Parse(textStoreQuantity);
          }
        return storeQuantity;
      }

    public string  getQuantityAsText()
      {
        Debug.Assert(flagHasQuantity);
        if (textStoreQuantity == "")
          {
            return Convert.ToString(storeQuantity);
          }
        else
          {
            return (textStoreQuantity);
          }
      }

    public bool  hasQuantityDetails()
      {
        return flagHasQuantityDetails;
      }

    public QuantityJSON   getQuantityDetails()
      {
        Debug.Assert(flagHasQuantityDetails);
        return storeQuantityDetails;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnitJSON   getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public bool  hasUnitDetails()
      {
        return flagHasUnitDetails;
      }

    public UnitJSON   getUnitDetails()
      {
        Debug.Assert(flagHasUnitDetails);
        return storeUnitDetails;
      }

    public bool  hasSpokenQuantityName()
      {
        return flagHasSpokenQuantityName;
      }

    public string  getSpokenQuantityName()
      {
        Debug.Assert(flagHasSpokenQuantityName);
        return storeSpokenQuantityName;
      }

    public bool  hasWrittenQuantityName()
      {
        return flagHasWrittenQuantityName;
      }

    public string  getWrittenQuantityName()
      {
        Debug.Assert(flagHasWrittenQuantityName);
        return storeWrittenQuantityName;
      }


    public virtual int extraAmountComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAmountComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAmountComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAmountLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQuantity(double new_value)
      {
        flagHasQuantity = true;
        storeQuantity = new_value;
        textStoreQuantity = "";
      }
    public void setQuantityText(string new_value)
      {
        flagHasQuantity = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Quantity of AmountJSON is not a valid number.");
        textStoreQuantity = new_value;
      }
    public void unsetQuantity()
      {
        flagHasQuantity = false;
      }
    public void setQuantityDetails(QuantityJSON  new_value)
      {
        if (flagHasQuantityDetails)
          {
          }
        flagHasQuantityDetails = true;
        storeQuantityDetails = new_value;
      }
    public void unsetQuantityDetails()
      {
        if (flagHasQuantityDetails)
          {
          }
        flagHasQuantityDetails = false;
      }
    public void setUnit(TypeUnitJSON  new_value)
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void unsetUnit()
      {
        if (flagHasUnit)
          {
          }
        flagHasUnit = false;
      }
    public void setUnitDetails(UnitJSON  new_value)
      {
        if (flagHasUnitDetails)
          {
          }
        flagHasUnitDetails = true;
        storeUnitDetails = new_value;
      }
    public void unsetUnitDetails()
      {
        if (flagHasUnitDetails)
          {
          }
        flagHasUnitDetails = false;
      }
    public void setSpokenQuantityName(string new_value)
      {
        flagHasSpokenQuantityName = true;
        storeSpokenQuantityName = new_value;
      }
    public void unsetSpokenQuantityName()
      {
        flagHasSpokenQuantityName = false;
      }
    public void setWrittenQuantityName(string new_value)
      {
        flagHasWrittenQuantityName = true;
        storeWrittenQuantityName = new_value;
      }
    public void unsetWrittenQuantityName()
      {
        flagHasWrittenQuantityName = false;
      }

    public virtual void extraAmountAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAmountSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAmountLookup(key);
        if (old_field == null)
          {
            extraAmountAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQuantity);
        if (flagHasQuantity)
          {
            handler.start_pair("Quantity");
            if (textStoreQuantity != "")
                handler.number_value(textStoreQuantity);
            else if (((double)(long)storeQuantity) == storeQuantity)
                handler.number_value((long)storeQuantity);
            else
                handler.number_value(storeQuantity);
          }
        if (flagHasQuantityDetails)
          {
            handler.start_pair("QuantityDetails");
            if (partial_allowed)
                storeQuantityDetails.write_partial_as_json(handler);
            else
                storeQuantityDetails.write_as_json(handler);
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            if (partial_allowed)
                storeUnit.write_partial_as_json(handler);
            else
                storeUnit.write_as_json(handler);
          }
        if (flagHasUnitDetails)
          {
            handler.start_pair("UnitDetails");
            if (partial_allowed)
                storeUnitDetails.write_partial_as_json(handler);
            else
                storeUnitDetails.write_as_json(handler);
          }
        if (flagHasSpokenQuantityName)
          {
            handler.start_pair("SpokenQuantityName");
            handler.string_value(storeSpokenQuantityName);
          }
        if (flagHasWrittenQuantityName)
          {
            handler.start_pair("WrittenQuantityName");
            handler.string_value(storeWrittenQuantityName);
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
        if (!(hasQuantity()))
          {
            return "When parsing the object for %what%, the \"Quantity\" field was missing.";
          }
        return null;
      }

    public static AmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Amount", ignore_extras);
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
    public static AmountJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Amount", ignore_extras);
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
    public static AmountJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AmountJSON from_text(string text, bool ignore_extras)
      {
        AmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Amount", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AmountJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AmountJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AmountJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Amount", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
        private QuantityJSON.HoldingGenerator fieldGeneratorQuantityDetails;
        private TypeUnitJSON.HoldingGenerator fieldGeneratorUnit;
        private UnitJSON.HoldingGenerator fieldGeneratorUnitDetails;
        private JSONHoldingStringGenerator fieldGeneratorSpokenQuantityName;
        private JSONHoldingStringGenerator fieldGeneratorWrittenQuantityName;
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
            AmountJSON result = new AmountJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAmountAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AmountJSON result)
          {
            if (fieldGeneratorQuantity.have_value)
              {
                result.setQuantityText(fieldGeneratorQuantity.value);
                fieldGeneratorQuantity.have_value = false;
              }
            else if ((!(result.hasQuantity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Quantity\" field was missing.");
              }
            if (fieldGeneratorQuantityDetails.have_value)
              {
                result.setQuantityDetails(fieldGeneratorQuantityDetails.value);
                fieldGeneratorQuantityDetails.have_value = false;
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            if (fieldGeneratorUnitDetails.have_value)
              {
                result.setUnitDetails(fieldGeneratorUnitDetails.value);
                fieldGeneratorUnitDetails.have_value = false;
              }
            if (fieldGeneratorSpokenQuantityName.have_value)
              {
                result.setSpokenQuantityName(fieldGeneratorSpokenQuantityName.value);
                fieldGeneratorSpokenQuantityName.have_value = false;
              }
            if (fieldGeneratorWrittenQuantityName.have_value)
              {
                result.setWrittenQuantityName(fieldGeneratorWrittenQuantityName.value);
                fieldGeneratorWrittenQuantityName.have_value = false;
              }
          }
        protected abstract void handle_result(AmountJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'Q':
                    if (String.Compare(field_name, 1, "uantity", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorQuantity;
                          }
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "etails", 0, 6, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorQuantityDetails;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenQuantityName", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorSpokenQuantityName;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "nit", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorUnit;
                          }
                        switch (field_name[4])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 5, "etails", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorUnitDetails;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenQuantityName", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorWrittenQuantityName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the Amount class");
            fieldGeneratorQuantityDetails = new QuantityJSON.HoldingGenerator("field \"QuantityDetails\" of the Amount class", ignore_extras);
            fieldGeneratorUnit = new TypeUnitJSON.HoldingGenerator("field \"Unit\" of the Amount class", ignore_extras);
            fieldGeneratorUnitDetails = new UnitJSON.HoldingGenerator("field \"UnitDetails\" of the Amount class", ignore_extras);
            fieldGeneratorSpokenQuantityName = new JSONHoldingStringGenerator("field \"SpokenQuantityName\" of the Amount class");
            fieldGeneratorWrittenQuantityName = new JSONHoldingStringGenerator("field \"WrittenQuantityName\" of the Amount class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Amount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the Amount class");
            fieldGeneratorQuantityDetails = new QuantityJSON.HoldingGenerator("field \"QuantityDetails\" of the Amount class", false);
            fieldGeneratorUnit = new TypeUnitJSON.HoldingGenerator("field \"Unit\" of the Amount class", false);
            fieldGeneratorUnitDetails = new UnitJSON.HoldingGenerator("field \"UnitDetails\" of the Amount class", false);
            fieldGeneratorSpokenQuantityName = new JSONHoldingStringGenerator("field \"SpokenQuantityName\" of the Amount class");
            fieldGeneratorWrittenQuantityName = new JSONHoldingStringGenerator("field \"WrittenQuantityName\" of the Amount class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Amount class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQuantity.reset();
            fieldGeneratorQuantityDetails.reset();
            fieldGeneratorUnit.reset();
            fieldGeneratorUnitDetails.reset();
            fieldGeneratorSpokenQuantityName.reset();
            fieldGeneratorWrittenQuantityName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQuantityDetails.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnit.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnitDetails.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQuantityDetails.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnit.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnitDetails.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AmountJSON  result)
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
        public AmountJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AmountJSON  result)
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
    protected virtual void handle_result(List<AmountJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AmountJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AmountJSON>();
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
    public List<AmountJSON> value;
  };
  };
