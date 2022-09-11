/* file "GeonameObjectJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class GeonameObjectJSON : JSONBase
  {
    public class TypeAttributesJSON : JSONBase
      {
        private bool flagHasAttributeRequested;
        private bool storeAttributeRequested;
        private bool flagHasAttributeName;
        private string storeAttributeName;
        private bool flagHasAttributeValue;
        private string storeAttributeValue;
        private bool flagHasAttributeValueRaw;
        private BigInteger storeAttributeValueRaw;
        private bool flagHasUnitOfMeasure;
        private UnitOfMeasureJSON  storeUnitOfMeasure;
        private bool flagHasAttributeValueIsLong;
        private bool storeAttributeValueIsLong;
        private bool flagHasDateAndOrTime;
        private DateAndOrTimeJSON  storeDateAndOrTime;
        private bool flagHasAttributeDataOutOfDate;
        private bool storeAttributeDataOutOfDate;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONAttributeRequested(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AttributeRequested of TypeAttributesJSON is not true for false.");
                  }
              }
            setAttributeRequested(the_bool);
          }


        private void  fromJSONAttributeName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AttributeName of TypeAttributesJSON is not a string.");
            setAttributeName(json_string.getData());
          }


        private void  fromJSONAttributeValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AttributeValue of TypeAttributesJSON is not a string.");
            setAttributeValue(json_string.getData());
          }


        private void  fromJSONAttributeValueRaw(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field AttributeValueRaw of TypeAttributesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field AttributeValueRaw of TypeAttributesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setAttributeValueRaw(extracted_integer);
          }


        private void  fromJSONUnitOfMeasure(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            UnitOfMeasureJSON convert_classy = UnitOfMeasureJSON.from_json(json_value, ignore_extras, true);
            setUnitOfMeasure(convert_classy);
          }


        private void  fromJSONAttributeValueIsLong(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AttributeValueIsLong of TypeAttributesJSON is not true for false.");
                  }
              }
            setAttributeValueIsLong(the_bool);
          }


        private void  fromJSONDateAndOrTime(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setDateAndOrTime(convert_classy);
          }


        private void  fromJSONAttributeDataOutOfDate(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AttributeDataOutOfDate of TypeAttributesJSON is not true for false.");
                  }
              }
            setAttributeDataOutOfDate(the_bool);
          }


        public TypeAttributesJSON()
          {
            flagHasAttributeRequested = false;
            flagHasAttributeName = false;
            flagHasAttributeValue = false;
            flagHasAttributeValueRaw = false;
            flagHasUnitOfMeasure = false;
            flagHasAttributeValueIsLong = false;
            flagHasDateAndOrTime = false;
            flagHasAttributeDataOutOfDate = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasAttributeRequested()
          {
            return flagHasAttributeRequested;
          }

        public bool  getAttributeRequested()
          {
            Debug.Assert(flagHasAttributeRequested);
            return storeAttributeRequested;
          }

        public bool  hasAttributeName()
          {
            return flagHasAttributeName;
          }

        public string  getAttributeName()
          {
            Debug.Assert(flagHasAttributeName);
            return storeAttributeName;
          }

        public bool  hasAttributeValue()
          {
            return flagHasAttributeValue;
          }

        public string  getAttributeValue()
          {
            Debug.Assert(flagHasAttributeValue);
            return storeAttributeValue;
          }

        public bool  hasAttributeValueRaw()
          {
            return flagHasAttributeValueRaw;
          }

        public BigInteger  getAttributeValueRaw()
          {
            Debug.Assert(flagHasAttributeValueRaw);
            return storeAttributeValueRaw;
          }

        public bool  hasUnitOfMeasure()
          {
            return flagHasUnitOfMeasure;
          }

        public UnitOfMeasureJSON   getUnitOfMeasure()
          {
            Debug.Assert(flagHasUnitOfMeasure);
            return storeUnitOfMeasure;
          }

        public UnitOfMeasureJSON.TypeValue  getUnitOfMeasureValue()
          {
            return getUnitOfMeasure().getValue();
          }

        public string  getUnitOfMeasureAsString()
          {
            return getUnitOfMeasure().getValueAsString();
          }

        public bool  hasAttributeValueIsLong()
          {
            return flagHasAttributeValueIsLong;
          }

        public bool  getAttributeValueIsLong()
          {
            Debug.Assert(flagHasAttributeValueIsLong);
            return storeAttributeValueIsLong;
          }

        public bool  hasDateAndOrTime()
          {
            return flagHasDateAndOrTime;
          }

        public DateAndOrTimeJSON   getDateAndOrTime()
          {
            Debug.Assert(flagHasDateAndOrTime);
            return storeDateAndOrTime;
          }

        public bool  hasAttributeDataOutOfDate()
          {
            return flagHasAttributeDataOutOfDate;
          }

        public bool  getAttributeDataOutOfDate()
          {
            Debug.Assert(flagHasAttributeDataOutOfDate);
            return storeAttributeDataOutOfDate;
          }


        public virtual int extraTypeAttributesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAttributesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAttributesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAttributesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setAttributeRequested(bool new_value)
          {
            flagHasAttributeRequested = true;
            storeAttributeRequested = new_value;
          }
        public void unsetAttributeRequested()
          {
            flagHasAttributeRequested = false;
          }
        public void setAttributeName(string new_value)
          {
            flagHasAttributeName = true;
            storeAttributeName = new_value;
          }
        public void unsetAttributeName()
          {
            flagHasAttributeName = false;
          }
        public void setAttributeValue(string new_value)
          {
            flagHasAttributeValue = true;
            storeAttributeValue = new_value;
          }
        public void unsetAttributeValue()
          {
            flagHasAttributeValue = false;
          }
        public void setAttributeValueRaw(BigInteger new_value)
          {
            flagHasAttributeValueRaw = true;
            storeAttributeValueRaw = new_value;
          }
        public void unsetAttributeValueRaw()
          {
            flagHasAttributeValueRaw = false;
          }
        public void setUnitOfMeasure(UnitOfMeasureJSON  new_value)
          {
            if (flagHasUnitOfMeasure)
              {
              }
            flagHasUnitOfMeasure = true;
            storeUnitOfMeasure = new_value;
          }
        public void setUnitOfMeasure(UnitOfMeasureJSON.TypeValue new_value)
          {
            setUnitOfMeasure(new UnitOfMeasureJSON(new_value));
          }
        public void setUnitOfMeasure(string chars)
          {
            UnitOfMeasureJSON.TypeValueKnownValues known = UnitOfMeasureJSON.stringToValue(chars);
            UnitOfMeasureJSON.TypeValue new_value = new UnitOfMeasureJSON.TypeValue();
            if (known == UnitOfMeasureJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setUnitOfMeasure(new_value);
          }
        public void unsetUnitOfMeasure()
          {
            if (flagHasUnitOfMeasure)
              {
              }
            flagHasUnitOfMeasure = false;
          }
        public void setAttributeValueIsLong(bool new_value)
          {
            flagHasAttributeValueIsLong = true;
            storeAttributeValueIsLong = new_value;
          }
        public void unsetAttributeValueIsLong()
          {
            flagHasAttributeValueIsLong = false;
          }
        public void setDateAndOrTime(DateAndOrTimeJSON  new_value)
          {
            if (flagHasDateAndOrTime)
              {
              }
            flagHasDateAndOrTime = true;
            storeDateAndOrTime = new_value;
          }
        public void unsetDateAndOrTime()
          {
            if (flagHasDateAndOrTime)
              {
              }
            flagHasDateAndOrTime = false;
          }
        public void setAttributeDataOutOfDate(bool new_value)
          {
            flagHasAttributeDataOutOfDate = true;
            storeAttributeDataOutOfDate = new_value;
          }
        public void unsetAttributeDataOutOfDate()
          {
            flagHasAttributeDataOutOfDate = false;
          }

        public virtual void extraTypeAttributesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAttributesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAttributesLookup(key);
            if (old_field == null)
              {
                extraTypeAttributesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasAttributeRequested);
            if (flagHasAttributeRequested)
              {
                handler.start_pair("AttributeRequested");
                handler.boolean_value(storeAttributeRequested);
              }
            Debug.Assert(partial_allowed || flagHasAttributeName);
            if (flagHasAttributeName)
              {
                handler.start_pair("AttributeName");
                handler.string_value(storeAttributeName);
              }
            if (flagHasAttributeValue)
              {
                handler.start_pair("AttributeValue");
                handler.string_value(storeAttributeValue);
              }
            if (flagHasAttributeValueRaw)
              {
                handler.start_pair("AttributeValueRaw");
                handler.number_value(storeAttributeValueRaw);
              }
            if (flagHasUnitOfMeasure)
              {
                handler.start_pair("UnitOfMeasure");
                if (partial_allowed)
                    storeUnitOfMeasure.write_partial_as_json(handler);
                else
                    storeUnitOfMeasure.write_as_json(handler);
              }
            if (flagHasAttributeValueIsLong)
              {
                handler.start_pair("AttributeValueIsLong");
                handler.boolean_value(storeAttributeValueIsLong);
              }
            if (flagHasDateAndOrTime)
              {
                handler.start_pair("DateAndOrTime");
                if (partial_allowed)
                    storeDateAndOrTime.write_partial_as_json(handler);
                else
                    storeDateAndOrTime.write_as_json(handler);
              }
            if (flagHasAttributeDataOutOfDate)
              {
                handler.start_pair("AttributeDataOutOfDate");
                handler.boolean_value(storeAttributeDataOutOfDate);
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
            if (!(hasAttributeRequested()))
              {
                return "When parsing the object for %what%, the \"AttributeRequested\" field was missing.";
              }
            if (!(hasAttributeName()))
              {
                return "When parsing the object for %what%, the \"AttributeName\" field was missing.";
              }
            return null;
          }

        public static TypeAttributesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
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
        public static TypeAttributesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
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
        public static TypeAttributesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesJSON from_text(string text, bool ignore_extras)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAttributesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAttributesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorAttributeRequested;
            private JSONHoldingStringGenerator fieldGeneratorAttributeName;
            private JSONHoldingStringGenerator fieldGeneratorAttributeValue;
        private class FieldHoldingGeneratorAttributeValueRaw : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorAttributeValueRaw(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorAttributeValueRaw : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorAttributeValueRaw(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorAttributeValueRaw fieldGeneratorAttributeValueRaw;
            private UnitOfMeasureJSON.HoldingGenerator fieldGeneratorUnitOfMeasure;
            private JSONHoldingBooleanGenerator fieldGeneratorAttributeValueIsLong;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndOrTime;
            private JSONHoldingBooleanGenerator fieldGeneratorAttributeDataOutOfDate;
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
                TypeAttributesJSON result = new TypeAttributesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAttributesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAttributesJSON result)
              {
                if (fieldGeneratorAttributeRequested.have_value)
                  {
                    result.setAttributeRequested(fieldGeneratorAttributeRequested.value);
                    fieldGeneratorAttributeRequested.have_value = false;
                  }
                else if ((!(result.hasAttributeRequested())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AttributeRequested\" field was missing.");
                  }
                if (fieldGeneratorAttributeName.have_value)
                  {
                    result.setAttributeName(fieldGeneratorAttributeName.value);
                    fieldGeneratorAttributeName.have_value = false;
                  }
                else if ((!(result.hasAttributeName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AttributeName\" field was missing.");
                  }
                if (fieldGeneratorAttributeValue.have_value)
                  {
                    result.setAttributeValue(fieldGeneratorAttributeValue.value);
                    fieldGeneratorAttributeValue.have_value = false;
                  }
                if (fieldGeneratorAttributeValueRaw.have_value)
                  {
                    result.setAttributeValueRaw(fieldGeneratorAttributeValueRaw.value);
                    fieldGeneratorAttributeValueRaw.have_value = false;
                  }
                if (fieldGeneratorUnitOfMeasure.have_value)
                  {
                    result.setUnitOfMeasure(fieldGeneratorUnitOfMeasure.value);
                    fieldGeneratorUnitOfMeasure.have_value = false;
                  }
                if (fieldGeneratorAttributeValueIsLong.have_value)
                  {
                    result.setAttributeValueIsLong(fieldGeneratorAttributeValueIsLong.value);
                    fieldGeneratorAttributeValueIsLong.have_value = false;
                  }
                if (fieldGeneratorDateAndOrTime.have_value)
                  {
                    result.setDateAndOrTime(fieldGeneratorDateAndOrTime.value);
                    fieldGeneratorDateAndOrTime.have_value = false;
                  }
                if (fieldGeneratorAttributeDataOutOfDate.have_value)
                  {
                    result.setAttributeDataOutOfDate(fieldGeneratorAttributeDataOutOfDate.value);
                    fieldGeneratorAttributeDataOutOfDate.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeAttributesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if (String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0)
                          {
                            switch (field_name[9])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 10, "ataOutOfDate", 0, 12, false) == 0) && (field_name.Length == 22))
                                        return fieldGeneratorAttributeDataOutOfDate;
                                    break;
                                case 'N':
                                    if ((String.Compare(field_name, 10, "ame", 0, 3, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorAttributeName;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 10, "equested", 0, 8, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorAttributeRequested;
                                    break;
                                case 'V':
                                    if (String.Compare(field_name, 10, "alue", 0, 4, false) == 0)
                                      {
                                        if (field_name.Length == 14)
                                          {
                                            return fieldGeneratorAttributeValue;
                                          }
                                        switch (field_name[14])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 15, "sLong", 0, 5, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorAttributeValueIsLong;
                                                break;
                                            case 'R':
                                                if ((String.Compare(field_name, 15, "aw", 0, 2, false) == 0) && (field_name.Length == 17))
                                                    return fieldGeneratorAttributeValueRaw;
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
                    case 'D':
                        if ((String.Compare(field_name, 1, "ateAndOrTime", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorDateAndOrTime;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "nitOfMeasure", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorUnitOfMeasure;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAttributeRequested = new JSONHoldingBooleanGenerator("field \"AttributeRequested\" of the TypeAttributes class");
                fieldGeneratorAttributeName = new JSONHoldingStringGenerator("field \"AttributeName\" of the TypeAttributes class");
                fieldGeneratorAttributeValue = new JSONHoldingStringGenerator("field \"AttributeValue\" of the TypeAttributes class");
                fieldGeneratorAttributeValueRaw = new FieldHoldingGeneratorAttributeValueRaw("field \"AttributeValueRaw\" of the TypeAttributes class");
                fieldGeneratorUnitOfMeasure = new UnitOfMeasureJSON.HoldingGenerator("field \"UnitOfMeasure\" of the TypeAttributes class", ignore_extras);
                fieldGeneratorAttributeValueIsLong = new JSONHoldingBooleanGenerator("field \"AttributeValueIsLong\" of the TypeAttributes class");
                fieldGeneratorDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndOrTime\" of the TypeAttributes class", ignore_extras);
                fieldGeneratorAttributeDataOutOfDate = new JSONHoldingBooleanGenerator("field \"AttributeDataOutOfDate\" of the TypeAttributes class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAttributes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAttributeRequested = new JSONHoldingBooleanGenerator("field \"AttributeRequested\" of the TypeAttributes class");
                fieldGeneratorAttributeName = new JSONHoldingStringGenerator("field \"AttributeName\" of the TypeAttributes class");
                fieldGeneratorAttributeValue = new JSONHoldingStringGenerator("field \"AttributeValue\" of the TypeAttributes class");
                fieldGeneratorAttributeValueRaw = new FieldHoldingGeneratorAttributeValueRaw("field \"AttributeValueRaw\" of the TypeAttributes class");
                fieldGeneratorUnitOfMeasure = new UnitOfMeasureJSON.HoldingGenerator("field \"UnitOfMeasure\" of the TypeAttributes class", false);
                fieldGeneratorAttributeValueIsLong = new JSONHoldingBooleanGenerator("field \"AttributeValueIsLong\" of the TypeAttributes class");
                fieldGeneratorDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndOrTime\" of the TypeAttributes class", false);
                fieldGeneratorAttributeDataOutOfDate = new JSONHoldingBooleanGenerator("field \"AttributeDataOutOfDate\" of the TypeAttributes class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAttributes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAttributeRequested.reset();
                fieldGeneratorAttributeName.reset();
                fieldGeneratorAttributeValue.reset();
                fieldGeneratorAttributeValueRaw.reset();
                fieldGeneratorUnitOfMeasure.reset();
                fieldGeneratorAttributeValueIsLong.reset();
                fieldGeneratorDateAndOrTime.reset();
                fieldGeneratorAttributeDataOutOfDate.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorUnitOfMeasure.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorUnitOfMeasure.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeAttributesJSON  result)
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
            public TypeAttributesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAttributesJSON  result)
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
        protected virtual void handle_result(List<TypeAttributesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAttributesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAttributesJSON>();
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
        public List<TypeAttributesJSON> value;
      };
      };
    private bool flagHasGeonameID;
    private BigInteger storeGeonameID;
    private bool flagHasGeonameObjectType;
    private BigInteger storeGeonameObjectType;
    private bool flagHasGeonameAuxID;
    private BigInteger storeGeonameAuxID;
    private bool flagHasGeonameName;
    private string storeGeonameName;
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasTotalRows;
    private BigInteger storeTotalRows;
    private bool flagHasAttributes;
    private List< TypeAttributesJSON  > storeAttributes;
    private bool flagHasAttributesNew;
    private List< GeonameAttributeJSON  > storeAttributesNew;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGeonameID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GeonameID of GeonameObjectJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GeonameID of GeonameObjectJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGeonameID(extracted_integer);
      }


    private void  fromJSONGeonameObjectType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GeonameObjectType of GeonameObjectJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GeonameObjectType of GeonameObjectJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGeonameObjectType(extracted_integer);
      }


    private void  fromJSONGeonameAuxID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GeonameAuxID of GeonameObjectJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GeonameAuxID of GeonameObjectJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGeonameAuxID(extracted_integer);
      }


    private void  fromJSONGeonameName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GeonameName of GeonameObjectJSON is not a string.");
        setGeonameName(json_string.getData());
      }


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of GeonameObjectJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONTotalRows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalRows of GeonameObjectJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalRows of GeonameObjectJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalRows(extracted_integer);
      }


    private void  fromJSONAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Attributes of GeonameObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAttributesJSON  > vector_Attributes1 = new List< TypeAttributesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAttributesJSON convert_classy = TypeAttributesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Attributes1.Add(convert_classy);
          }
        initAttributes();
        for (int num1 = 0; num1 < vector_Attributes1.Count; ++num1)
            appendAttributes(vector_Attributes1[num1]);
        for (int num1 = 0; num1 < vector_Attributes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttributesNew(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AttributesNew of GeonameObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameAttributeJSON  > vector_AttributesNew1 = new List< GeonameAttributeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameAttributeJSON convert_classy = GeonameAttributeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AttributesNew1.Add(convert_classy);
          }
        initAttributesNew();
        for (int num2 = 0; num2 < vector_AttributesNew1.Count; ++num2)
            appendAttributesNew(vector_AttributesNew1[num2]);
        for (int num1 = 0; num1 < vector_AttributesNew1.Count; ++num1)
          {
          }
      }


    public GeonameObjectJSON()
      {
        flagHasGeonameID = false;
        flagHasGeonameObjectType = false;
        flagHasGeonameAuxID = false;
        flagHasGeonameName = false;
        flagHasURL = false;
        flagHasTotalRows = false;
        flagHasAttributes = false;
        flagHasAttributesNew = false;
        storeAttributes = new List< TypeAttributesJSON  >();
        storeAttributesNew = new List< GeonameAttributeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGeonameID()
      {
        return flagHasGeonameID;
      }

    public BigInteger  getGeonameID()
      {
        Debug.Assert(flagHasGeonameID);
        return storeGeonameID;
      }

    public bool  hasGeonameObjectType()
      {
        return flagHasGeonameObjectType;
      }

    public BigInteger  getGeonameObjectType()
      {
        Debug.Assert(flagHasGeonameObjectType);
        return storeGeonameObjectType;
      }

    public bool  hasGeonameAuxID()
      {
        return flagHasGeonameAuxID;
      }

    public BigInteger  getGeonameAuxID()
      {
        Debug.Assert(flagHasGeonameAuxID);
        return storeGeonameAuxID;
      }

    public bool  hasGeonameName()
      {
        return flagHasGeonameName;
      }

    public string  getGeonameName()
      {
        Debug.Assert(flagHasGeonameName);
        return storeGeonameName;
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }

    public bool  hasTotalRows()
      {
        return flagHasTotalRows;
      }

    public BigInteger  getTotalRows()
      {
        Debug.Assert(flagHasTotalRows);
        return storeTotalRows;
      }

    public bool  hasAttributes()
      {
        return flagHasAttributes;
      }

    public int  countOfAttributes()
      {
        Debug.Assert(flagHasAttributes);
        return storeAttributes.Count;
      }

    public TypeAttributesJSON   elementOfAttributes(int element_num)
      {
        Debug.Assert(flagHasAttributes);
        return storeAttributes[element_num];
      }

    public List< TypeAttributesJSON  >  getAttributes()
      {
        Debug.Assert(flagHasAttributes);
        return storeAttributes;
      }

    public bool  hasAttributesNew()
      {
        return flagHasAttributesNew;
      }

    public int  countOfAttributesNew()
      {
        Debug.Assert(flagHasAttributesNew);
        return storeAttributesNew.Count;
      }

    public GeonameAttributeJSON   elementOfAttributesNew(int element_num)
      {
        Debug.Assert(flagHasAttributesNew);
        return storeAttributesNew[element_num];
      }

    public List< GeonameAttributeJSON  >  getAttributesNew()
      {
        Debug.Assert(flagHasAttributesNew);
        return storeAttributesNew;
      }


    public virtual int extraGeonameObjectComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeonameObjectComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeonameObjectComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeonameObjectLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGeonameID(BigInteger new_value)
      {
        flagHasGeonameID = true;
        if (new_value < 1)
            throw new Exception("The value for field GeonameID of GeonameObjectJSON is less than the lower bound (1) for that field.");
        storeGeonameID = new_value;
      }
    public void unsetGeonameID()
      {
        flagHasGeonameID = false;
      }
    public void setGeonameObjectType(BigInteger new_value)
      {
        flagHasGeonameObjectType = true;
        if (new_value < 1)
            throw new Exception("The value for field GeonameObjectType of GeonameObjectJSON is less than the lower bound (1) for that field.");
        storeGeonameObjectType = new_value;
      }
    public void unsetGeonameObjectType()
      {
        flagHasGeonameObjectType = false;
      }
    public void setGeonameAuxID(BigInteger new_value)
      {
        flagHasGeonameAuxID = true;
        if (new_value < 0)
            throw new Exception("The value for field GeonameAuxID of GeonameObjectJSON is less than the lower bound (0) for that field.");
        storeGeonameAuxID = new_value;
      }
    public void unsetGeonameAuxID()
      {
        flagHasGeonameAuxID = false;
      }
    public void setGeonameName(string new_value)
      {
        flagHasGeonameName = true;
        storeGeonameName = new_value;
      }
    public void unsetGeonameName()
      {
        flagHasGeonameName = false;
      }
    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
      }
    public void setTotalRows(BigInteger new_value)
      {
        flagHasTotalRows = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalRows of GeonameObjectJSON is less than the lower bound (0) for that field.");
        storeTotalRows = new_value;
      }
    public void unsetTotalRows()
      {
        flagHasTotalRows = false;
      }
    public void initAttributes()
      {
        if (flagHasAttributes)
          {
            for (int num1 = 0; num1 < storeAttributes.Count; ++num1)
              {
              }
          }
        flagHasAttributes = true;
        storeAttributes.Clear();
      }
    public void appendAttributes(TypeAttributesJSON  to_append)
      {
        if (!flagHasAttributes)
          {
            flagHasAttributes = true;
            storeAttributes.Clear();
          }
        Debug.Assert(flagHasAttributes);
        storeAttributes.Add(to_append);
      }
    public void unsetAttributes()
      {
        if (flagHasAttributes)
          {
            for (int num2 = 0; num2 < storeAttributes.Count; ++num2)
              {
              }
          }
        flagHasAttributes = false;
        storeAttributes.Clear();
      }
    public void initAttributesNew()
      {
        if (flagHasAttributesNew)
          {
            for (int num3 = 0; num3 < storeAttributesNew.Count; ++num3)
              {
              }
          }
        flagHasAttributesNew = true;
        storeAttributesNew.Clear();
      }
    public void appendAttributesNew(GeonameAttributeJSON  to_append)
      {
        if (!flagHasAttributesNew)
          {
            flagHasAttributesNew = true;
            storeAttributesNew.Clear();
          }
        Debug.Assert(flagHasAttributesNew);
        storeAttributesNew.Add(to_append);
      }
    public void unsetAttributesNew()
      {
        if (flagHasAttributesNew)
          {
            for (int num4 = 0; num4 < storeAttributesNew.Count; ++num4)
              {
              }
          }
        flagHasAttributesNew = false;
        storeAttributesNew.Clear();
      }

    public virtual void extraGeonameObjectAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeonameObjectSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeonameObjectLookup(key);
        if (old_field == null)
          {
            extraGeonameObjectAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasGeonameID);
        if (flagHasGeonameID)
          {
            handler.start_pair("GeonameID");
            handler.number_value(storeGeonameID);
          }
        Debug.Assert(partial_allowed || flagHasGeonameObjectType);
        if (flagHasGeonameObjectType)
          {
            handler.start_pair("GeonameObjectType");
            handler.number_value(storeGeonameObjectType);
          }
        if (flagHasGeonameAuxID)
          {
            handler.start_pair("GeonameAuxID");
            handler.number_value(storeGeonameAuxID);
          }
        if (flagHasGeonameName)
          {
            handler.start_pair("GeonameName");
            handler.string_value(storeGeonameName);
          }
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasTotalRows)
          {
            handler.start_pair("TotalRows");
            handler.number_value(storeTotalRows);
          }
        if (flagHasAttributes)
          {
            handler.start_pair("Attributes");
            handler.start_array();
            for (int num1 = 0; num1 < storeAttributes.Count; ++num1)
              {
                if (partial_allowed)
                    storeAttributes[num1].write_partial_as_json(handler);
                else
                    storeAttributes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAttributesNew)
          {
            handler.start_pair("AttributesNew");
            handler.start_array();
            for (int num2 = 0; num2 < storeAttributesNew.Count; ++num2)
              {
                if (partial_allowed)
                    storeAttributesNew[num2].write_partial_as_json(handler);
                else
                    storeAttributesNew[num2].write_as_json(handler);
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
        if (!(hasGeonameID()))
          {
            return "When parsing the object for %what%, the \"GeonameID\" field was missing.";
          }
        if (!(hasGeonameObjectType()))
          {
            return "When parsing the object for %what%, the \"GeonameObjectType\" field was missing.";
          }
        return null;
      }

    public static GeonameObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameObject", ignore_extras);
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
    public static GeonameObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameObject", ignore_extras);
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
    public static GeonameObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameObjectJSON from_text(string text, bool ignore_extras)
      {
        GeonameObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameObject", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameObjectJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeonameObjectJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameObject", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorGeonameID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGeonameID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGeonameID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGeonameID(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorGeonameID fieldGeneratorGeonameID;
    private class FieldHoldingGeneratorGeonameObjectType : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGeonameObjectType(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGeonameObjectType : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGeonameObjectType(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorGeonameObjectType fieldGeneratorGeonameObjectType;
    private class FieldHoldingGeneratorGeonameAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGeonameAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGeonameAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGeonameAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGeonameAuxID fieldGeneratorGeonameAuxID;
        private JSONHoldingStringGenerator fieldGeneratorGeonameName;
        private JSONHoldingStringGenerator fieldGeneratorURL;
    private class FieldHoldingGeneratorTotalRows : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalRows(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalRows : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalRows(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalRows fieldGeneratorTotalRows;
        private TypeAttributesJSON.HoldingArrayGenerator fieldGeneratorAttributes;
        private GeonameAttributeJSON.HoldingArrayGenerator fieldGeneratorAttributesNew;
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
            GeonameObjectJSON result = new GeonameObjectJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeonameObjectAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GeonameObjectJSON result)
          {
            if (fieldGeneratorGeonameID.have_value)
              {
                result.setGeonameID(fieldGeneratorGeonameID.value);
                fieldGeneratorGeonameID.have_value = false;
              }
            else if ((!(result.hasGeonameID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GeonameID\" field was missing.");
              }
            if (fieldGeneratorGeonameObjectType.have_value)
              {
                result.setGeonameObjectType(fieldGeneratorGeonameObjectType.value);
                fieldGeneratorGeonameObjectType.have_value = false;
              }
            else if ((!(result.hasGeonameObjectType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"GeonameObjectType\" field was missing.");
              }
            if (fieldGeneratorGeonameAuxID.have_value)
              {
                result.setGeonameAuxID(fieldGeneratorGeonameAuxID.value);
                fieldGeneratorGeonameAuxID.have_value = false;
              }
            if (fieldGeneratorGeonameName.have_value)
              {
                result.setGeonameName(fieldGeneratorGeonameName.value);
                fieldGeneratorGeonameName.have_value = false;
              }
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            if (fieldGeneratorTotalRows.have_value)
              {
                result.setTotalRows(fieldGeneratorTotalRows.value);
                fieldGeneratorTotalRows.have_value = false;
              }
            if (fieldGeneratorAttributes.have_value)
              {
                result.initAttributes();
                int count = fieldGeneratorAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttributes(fieldGeneratorAttributes.value[num]);
                  }
                fieldGeneratorAttributes.value.Clear();
                fieldGeneratorAttributes.have_value = false;
              }
            if (fieldGeneratorAttributesNew.have_value)
              {
                result.initAttributesNew();
                int count = fieldGeneratorAttributesNew.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttributesNew(fieldGeneratorAttributesNew.value[num]);
                  }
                fieldGeneratorAttributesNew.value.Clear();
                fieldGeneratorAttributesNew.have_value = false;
              }
          }
        protected abstract void handle_result(GeonameObjectJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ttributes", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorAttributes;
                          }
                        switch (field_name[10])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 11, "ew", 0, 2, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorAttributesNew;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "eoname", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 8, "uxID", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorGeonameAuxID;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorGeonameID;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorGeonameName;
                                break;
                            case 'O':
                                if ((String.Compare(field_name, 8, "bjectType", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorGeonameObjectType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalRows", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTotalRows;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGeonameID = new FieldHoldingGeneratorGeonameID("field \"GeonameID\" of the GeonameObject class");
            fieldGeneratorGeonameObjectType = new FieldHoldingGeneratorGeonameObjectType("field \"GeonameObjectType\" of the GeonameObject class");
            fieldGeneratorGeonameAuxID = new FieldHoldingGeneratorGeonameAuxID("field \"GeonameAuxID\" of the GeonameObject class");
            fieldGeneratorGeonameName = new JSONHoldingStringGenerator("field \"GeonameName\" of the GeonameObject class");
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the GeonameObject class");
            fieldGeneratorTotalRows = new FieldHoldingGeneratorTotalRows("field \"TotalRows\" of the GeonameObject class");
            fieldGeneratorAttributes = new TypeAttributesJSON.HoldingArrayGenerator("field \"Attributes\" of the GeonameObject class", ignore_extras);
            fieldGeneratorAttributesNew = new GeonameAttributeJSON.HoldingArrayGenerator("field \"AttributesNew\" of the GeonameObject class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeonameObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGeonameID = new FieldHoldingGeneratorGeonameID("field \"GeonameID\" of the GeonameObject class");
            fieldGeneratorGeonameObjectType = new FieldHoldingGeneratorGeonameObjectType("field \"GeonameObjectType\" of the GeonameObject class");
            fieldGeneratorGeonameAuxID = new FieldHoldingGeneratorGeonameAuxID("field \"GeonameAuxID\" of the GeonameObject class");
            fieldGeneratorGeonameName = new JSONHoldingStringGenerator("field \"GeonameName\" of the GeonameObject class");
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the GeonameObject class");
            fieldGeneratorTotalRows = new FieldHoldingGeneratorTotalRows("field \"TotalRows\" of the GeonameObject class");
            fieldGeneratorAttributes = new TypeAttributesJSON.HoldingArrayGenerator("field \"Attributes\" of the GeonameObject class", false);
            fieldGeneratorAttributesNew = new GeonameAttributeJSON.HoldingArrayGenerator("field \"AttributesNew\" of the GeonameObject class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeonameObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGeonameID.reset();
            fieldGeneratorGeonameObjectType.reset();
            fieldGeneratorGeonameAuxID.reset();
            fieldGeneratorGeonameName.reset();
            fieldGeneratorURL.reset();
            fieldGeneratorTotalRows.reset();
            fieldGeneratorAttributes.reset();
            fieldGeneratorAttributesNew.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAttributes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttributesNew.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAttributes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttributesNew.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameObjectJSON  result)
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
        public GeonameObjectJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameObjectJSON  result)
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
    protected virtual void handle_result(List<GeonameObjectJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameObjectJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameObjectJSON>();
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
    public List<GeonameObjectJSON> value;
  };
  };
