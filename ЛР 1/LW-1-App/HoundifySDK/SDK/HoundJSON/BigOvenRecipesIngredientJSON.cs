/* file "BigOvenRecipesIngredientJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class BigOvenRecipesIngredientJSON : JSONBase
  {
    public class TypeIngredientInfoJSON : JSONBase
      {
        private bool flagHasName;
        private string storeName;
        private bool flagHasDepartment;
        private string storeDepartment;
        private bool flagHasMasterIngredientID;
        private BigInteger storeMasterIngredientID;
        private bool flagHasUsuallyOnHand;
        private bool storeUsuallyOnHand;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Name of TypeIngredientInfoJSON is not a string.");
            setName(json_string.getData());
          }


        private void  fromJSONDepartment(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Department of TypeIngredientInfoJSON is not a string.");
            setDepartment(json_string.getData());
          }


        private void  fromJSONMasterIngredientID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MasterIngredientID of TypeIngredientInfoJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MasterIngredientID of TypeIngredientInfoJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMasterIngredientID(extracted_integer);
          }


        private void  fromJSONUsuallyOnHand(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field UsuallyOnHand of TypeIngredientInfoJSON is not true for false.");
                  }
              }
            setUsuallyOnHand(the_bool);
          }


        public TypeIngredientInfoJSON()
          {
            flagHasName = false;
            flagHasDepartment = false;
            flagHasMasterIngredientID = false;
            flagHasUsuallyOnHand = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasName()
          {
            return flagHasName;
          }

        public string  getName()
          {
            Debug.Assert(flagHasName);
            return storeName;
          }

        public bool  hasDepartment()
          {
            return flagHasDepartment;
          }

        public string  getDepartment()
          {
            Debug.Assert(flagHasDepartment);
            return storeDepartment;
          }

        public bool  hasMasterIngredientID()
          {
            return flagHasMasterIngredientID;
          }

        public BigInteger  getMasterIngredientID()
          {
            Debug.Assert(flagHasMasterIngredientID);
            return storeMasterIngredientID;
          }

        public bool  hasUsuallyOnHand()
          {
            return flagHasUsuallyOnHand;
          }

        public bool  getUsuallyOnHand()
          {
            Debug.Assert(flagHasUsuallyOnHand);
            return storeUsuallyOnHand;
          }


        public virtual int extraTypeIngredientInfoComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeIngredientInfoComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeIngredientInfoComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeIngredientInfoLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setName(string new_value)
          {
            flagHasName = true;
            storeName = new_value;
          }
        public void unsetName()
          {
            flagHasName = false;
          }
        public void setDepartment(string new_value)
          {
            flagHasDepartment = true;
            storeDepartment = new_value;
          }
        public void unsetDepartment()
          {
            flagHasDepartment = false;
          }
        public void setMasterIngredientID(BigInteger new_value)
          {
            flagHasMasterIngredientID = true;
            if (new_value < 0)
                throw new Exception("The value for field MasterIngredientID of TypeIngredientInfoJSON is less than the lower bound (0) for that field.");
            storeMasterIngredientID = new_value;
          }
        public void unsetMasterIngredientID()
          {
            flagHasMasterIngredientID = false;
          }
        public void setUsuallyOnHand(bool new_value)
          {
            flagHasUsuallyOnHand = true;
            storeUsuallyOnHand = new_value;
          }
        public void unsetUsuallyOnHand()
          {
            flagHasUsuallyOnHand = false;
          }

        public virtual void extraTypeIngredientInfoAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeIngredientInfoSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeIngredientInfoLookup(key);
            if (old_field == null)
              {
                extraTypeIngredientInfoAppendPair(key, new_component);
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
            if (flagHasName)
              {
                handler.start_pair("Name");
                handler.string_value(storeName);
              }
            if (flagHasDepartment)
              {
                handler.start_pair("Department");
                handler.string_value(storeDepartment);
              }
            if (flagHasMasterIngredientID)
              {
                handler.start_pair("MasterIngredientID");
                handler.number_value(storeMasterIngredientID);
              }
            if (flagHasUsuallyOnHand)
              {
                handler.start_pair("UsuallyOnHand");
                handler.boolean_value(storeUsuallyOnHand);
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

        public static TypeIngredientInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeIngredientInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIngredientInfo", ignore_extras);
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
        public static TypeIngredientInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeIngredientInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeIngredientInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIngredientInfo", ignore_extras);
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
        public static TypeIngredientInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeIngredientInfoJSON from_text(string text, bool ignore_extras)
          {
            TypeIngredientInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIngredientInfo", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeIngredientInfoJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeIngredientInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeIngredientInfoJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeIngredientInfo", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorName;
            private JSONHoldingStringGenerator fieldGeneratorDepartment;
        private class FieldHoldingGeneratorMasterIngredientID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMasterIngredientID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMasterIngredientID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMasterIngredientID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorMasterIngredientID fieldGeneratorMasterIngredientID;
            private JSONHoldingBooleanGenerator fieldGeneratorUsuallyOnHand;
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
                TypeIngredientInfoJSON result = new TypeIngredientInfoJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeIngredientInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeIngredientInfoJSON result)
              {
                if (fieldGeneratorName.have_value)
                  {
                    result.setName(fieldGeneratorName.value);
                    fieldGeneratorName.have_value = false;
                  }
                if (fieldGeneratorDepartment.have_value)
                  {
                    result.setDepartment(fieldGeneratorDepartment.value);
                    fieldGeneratorDepartment.have_value = false;
                  }
                if (fieldGeneratorMasterIngredientID.have_value)
                  {
                    result.setMasterIngredientID(fieldGeneratorMasterIngredientID.value);
                    fieldGeneratorMasterIngredientID.have_value = false;
                  }
                if (fieldGeneratorUsuallyOnHand.have_value)
                  {
                    result.setUsuallyOnHand(fieldGeneratorUsuallyOnHand.value);
                    fieldGeneratorUsuallyOnHand.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeIngredientInfoJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "epartment", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDepartment;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "asterIngredientID", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorMasterIngredientID;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorName;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "suallyOnHand", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorUsuallyOnHand;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeIngredientInfo class");
                fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the TypeIngredientInfo class");
                fieldGeneratorMasterIngredientID = new FieldHoldingGeneratorMasterIngredientID("field \"MasterIngredientID\" of the TypeIngredientInfo class");
                fieldGeneratorUsuallyOnHand = new JSONHoldingBooleanGenerator("field \"UsuallyOnHand\" of the TypeIngredientInfo class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeIngredientInfo class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeIngredientInfo class");
                fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the TypeIngredientInfo class");
                fieldGeneratorMasterIngredientID = new FieldHoldingGeneratorMasterIngredientID("field \"MasterIngredientID\" of the TypeIngredientInfo class");
                fieldGeneratorUsuallyOnHand = new JSONHoldingBooleanGenerator("field \"UsuallyOnHand\" of the TypeIngredientInfo class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeIngredientInfo class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorName.reset();
                fieldGeneratorDepartment.reset();
                fieldGeneratorMasterIngredientID.reset();
                fieldGeneratorUsuallyOnHand.reset();
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
            protected override void handle_result(TypeIngredientInfoJSON  result)
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
            public TypeIngredientInfoJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeIngredientInfoJSON  result)
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
        protected virtual void handle_result(List<TypeIngredientInfoJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeIngredientInfoJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeIngredientInfoJSON>();
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
        public List<TypeIngredientInfoJSON> value;
      };
      };
    private bool flagHasIngredientID;
    private BigInteger storeIngredientID;
    private bool flagHasDisplayIndex;
    private BigInteger storeDisplayIndex;
    private bool flagHasIsHeading;
    private bool storeIsHeading;
    private bool flagHasName;
    private string storeName;
    private bool flagHasHTMLName;
    private string storeHTMLName;
    private bool flagHasQuantity;
    private double storeQuantity;
    private string textStoreQuantity;
    private bool flagHasDisplayQuantity;
    private string storeDisplayQuantity;
    private bool flagHasUnit;
    private string storeUnit;
    private bool flagHasMetricQuantity;
    private double storeMetricQuantity;
    private string textStoreMetricQuantity;
    private bool flagHasMetricDisplayQuantity;
    private string storeMetricDisplayQuantity;
    private bool flagHasMetricUnit;
    private string storeMetricUnit;
    private bool flagHasPreparationNotes;
    private string storePreparationNotes;
    private bool flagHasIngredientInfo;
    private TypeIngredientInfoJSON  storeIngredientInfo;
    private bool flagHasIsLinked;
    private bool storeIsLinked;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONIngredientID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IngredientID of BigOvenRecipesIngredientJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IngredientID of BigOvenRecipesIngredientJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIngredientID(extracted_integer);
      }


    private void  fromJSONDisplayIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DisplayIndex of BigOvenRecipesIngredientJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DisplayIndex of BigOvenRecipesIngredientJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDisplayIndex(extracted_integer);
      }


    private void  fromJSONIsHeading(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsHeading of BigOvenRecipesIngredientJSON is not true for false.");
              }
          }
        setIsHeading(the_bool);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of BigOvenRecipesIngredientJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONHTMLName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HTMLName of BigOvenRecipesIngredientJSON is not a string.");
        setHTMLName(json_string.getData());
      }


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
                throw new Exception("The value for field Quantity of BigOvenRecipesIngredientJSON is not a number.");
              }
          }
        setQuantityText(the_rational_text);
      }


    private void  fromJSONDisplayQuantity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayQuantity of BigOvenRecipesIngredientJSON is not a string.");
        setDisplayQuantity(json_string.getData());
      }


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of BigOvenRecipesIngredientJSON is not a string.");
        setUnit(json_string.getData());
      }


    private void  fromJSONMetricQuantity(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MetricQuantity of BigOvenRecipesIngredientJSON is not a number.");
              }
          }
        setMetricQuantityText(the_rational_text);
      }


    private void  fromJSONMetricDisplayQuantity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MetricDisplayQuantity of BigOvenRecipesIngredientJSON is not a string.");
        setMetricDisplayQuantity(json_string.getData());
      }


    private void  fromJSONMetricUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MetricUnit of BigOvenRecipesIngredientJSON is not a string.");
        setMetricUnit(json_string.getData());
      }


    private void  fromJSONPreparationNotes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreparationNotes of BigOvenRecipesIngredientJSON is not a string.");
        setPreparationNotes(json_string.getData());
      }


    private void  fromJSONIngredientInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeIngredientInfoJSON convert_classy = TypeIngredientInfoJSON.from_json(json_value, ignore_extras, true);
        setIngredientInfo(convert_classy);
      }


    private void  fromJSONIsLinked(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsLinked of BigOvenRecipesIngredientJSON is not true for false.");
              }
          }
        setIsLinked(the_bool);
      }


    public BigOvenRecipesIngredientJSON()
      {
        flagHasIngredientID = false;
        flagHasDisplayIndex = false;
        flagHasIsHeading = false;
        flagHasName = false;
        flagHasHTMLName = false;
        flagHasQuantity = false;
        flagHasDisplayQuantity = false;
        flagHasUnit = false;
        flagHasMetricQuantity = false;
        flagHasMetricDisplayQuantity = false;
        flagHasMetricUnit = false;
        flagHasPreparationNotes = false;
        flagHasIngredientInfo = false;
        flagHasIsLinked = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasIngredientID()
      {
        return flagHasIngredientID;
      }

    public BigInteger  getIngredientID()
      {
        Debug.Assert(flagHasIngredientID);
        return storeIngredientID;
      }

    public bool  hasDisplayIndex()
      {
        return flagHasDisplayIndex;
      }

    public BigInteger  getDisplayIndex()
      {
        Debug.Assert(flagHasDisplayIndex);
        return storeDisplayIndex;
      }

    public bool  hasIsHeading()
      {
        return flagHasIsHeading;
      }

    public bool  getIsHeading()
      {
        Debug.Assert(flagHasIsHeading);
        return storeIsHeading;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasHTMLName()
      {
        return flagHasHTMLName;
      }

    public string  getHTMLName()
      {
        Debug.Assert(flagHasHTMLName);
        return storeHTMLName;
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

    public bool  hasDisplayQuantity()
      {
        return flagHasDisplayQuantity;
      }

    public string  getDisplayQuantity()
      {
        Debug.Assert(flagHasDisplayQuantity);
        return storeDisplayQuantity;
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public string  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public bool  hasMetricQuantity()
      {
        return flagHasMetricQuantity;
      }

    public double  getMetricQuantity()
      {
        Debug.Assert(flagHasMetricQuantity);
        if (textStoreMetricQuantity != "")
          {
            return Double.Parse(textStoreMetricQuantity);
          }
        return storeMetricQuantity;
      }

    public string  getMetricQuantityAsText()
      {
        Debug.Assert(flagHasMetricQuantity);
        if (textStoreMetricQuantity == "")
          {
            return Convert.ToString(storeMetricQuantity);
          }
        else
          {
            return (textStoreMetricQuantity);
          }
      }

    public bool  hasMetricDisplayQuantity()
      {
        return flagHasMetricDisplayQuantity;
      }

    public string  getMetricDisplayQuantity()
      {
        Debug.Assert(flagHasMetricDisplayQuantity);
        return storeMetricDisplayQuantity;
      }

    public bool  hasMetricUnit()
      {
        return flagHasMetricUnit;
      }

    public string  getMetricUnit()
      {
        Debug.Assert(flagHasMetricUnit);
        return storeMetricUnit;
      }

    public bool  hasPreparationNotes()
      {
        return flagHasPreparationNotes;
      }

    public string  getPreparationNotes()
      {
        Debug.Assert(flagHasPreparationNotes);
        return storePreparationNotes;
      }

    public bool  hasIngredientInfo()
      {
        return flagHasIngredientInfo;
      }

    public TypeIngredientInfoJSON   getIngredientInfo()
      {
        Debug.Assert(flagHasIngredientInfo);
        return storeIngredientInfo;
      }

    public bool  hasIsLinked()
      {
        return flagHasIsLinked;
      }

    public bool  getIsLinked()
      {
        Debug.Assert(flagHasIsLinked);
        return storeIsLinked;
      }


    public virtual int extraBigOvenRecipesIngredientComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBigOvenRecipesIngredientComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesIngredientComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesIngredientLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setIngredientID(BigInteger new_value)
      {
        flagHasIngredientID = true;
        if (new_value < 0)
            throw new Exception("The value for field IngredientID of BigOvenRecipesIngredientJSON is less than the lower bound (0) for that field.");
        storeIngredientID = new_value;
      }
    public void unsetIngredientID()
      {
        flagHasIngredientID = false;
      }
    public void setDisplayIndex(BigInteger new_value)
      {
        flagHasDisplayIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field DisplayIndex of BigOvenRecipesIngredientJSON is less than the lower bound (0) for that field.");
        storeDisplayIndex = new_value;
      }
    public void unsetDisplayIndex()
      {
        flagHasDisplayIndex = false;
      }
    public void setIsHeading(bool new_value)
      {
        flagHasIsHeading = true;
        storeIsHeading = new_value;
      }
    public void unsetIsHeading()
      {
        flagHasIsHeading = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setHTMLName(string new_value)
      {
        flagHasHTMLName = true;
        storeHTMLName = new_value;
      }
    public void unsetHTMLName()
      {
        flagHasHTMLName = false;
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
            throw new Exception("The text value for field Quantity of BigOvenRecipesIngredientJSON is not a valid number.");
        textStoreQuantity = new_value;
      }
    public void unsetQuantity()
      {
        flagHasQuantity = false;
      }
    public void setDisplayQuantity(string new_value)
      {
        flagHasDisplayQuantity = true;
        storeDisplayQuantity = new_value;
      }
    public void unsetDisplayQuantity()
      {
        flagHasDisplayQuantity = false;
      }
    public void setUnit(string new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }
    public void setMetricQuantity(double new_value)
      {
        flagHasMetricQuantity = true;
        storeMetricQuantity = new_value;
        textStoreMetricQuantity = "";
      }
    public void setMetricQuantityText(string new_value)
      {
        flagHasMetricQuantity = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MetricQuantity of BigOvenRecipesIngredientJSON is not a valid number.");
        textStoreMetricQuantity = new_value;
      }
    public void unsetMetricQuantity()
      {
        flagHasMetricQuantity = false;
      }
    public void setMetricDisplayQuantity(string new_value)
      {
        flagHasMetricDisplayQuantity = true;
        storeMetricDisplayQuantity = new_value;
      }
    public void unsetMetricDisplayQuantity()
      {
        flagHasMetricDisplayQuantity = false;
      }
    public void setMetricUnit(string new_value)
      {
        flagHasMetricUnit = true;
        storeMetricUnit = new_value;
      }
    public void unsetMetricUnit()
      {
        flagHasMetricUnit = false;
      }
    public void setPreparationNotes(string new_value)
      {
        flagHasPreparationNotes = true;
        storePreparationNotes = new_value;
      }
    public void unsetPreparationNotes()
      {
        flagHasPreparationNotes = false;
      }
    public void setIngredientInfo(TypeIngredientInfoJSON  new_value)
      {
        if (flagHasIngredientInfo)
          {
          }
        flagHasIngredientInfo = true;
        storeIngredientInfo = new_value;
      }
    public void unsetIngredientInfo()
      {
        if (flagHasIngredientInfo)
          {
          }
        flagHasIngredientInfo = false;
      }
    public void setIsLinked(bool new_value)
      {
        flagHasIsLinked = true;
        storeIsLinked = new_value;
      }
    public void unsetIsLinked()
      {
        flagHasIsLinked = false;
      }

    public virtual void extraBigOvenRecipesIngredientAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBigOvenRecipesIngredientSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBigOvenRecipesIngredientLookup(key);
        if (old_field == null)
          {
            extraBigOvenRecipesIngredientAppendPair(key, new_component);
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
        if (flagHasIngredientID)
          {
            handler.start_pair("IngredientID");
            handler.number_value(storeIngredientID);
          }
        if (flagHasDisplayIndex)
          {
            handler.start_pair("DisplayIndex");
            handler.number_value(storeDisplayIndex);
          }
        if (flagHasIsHeading)
          {
            handler.start_pair("IsHeading");
            handler.boolean_value(storeIsHeading);
          }
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasHTMLName)
          {
            handler.start_pair("HTMLName");
            handler.string_value(storeHTMLName);
          }
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
        if (flagHasDisplayQuantity)
          {
            handler.start_pair("DisplayQuantity");
            handler.string_value(storeDisplayQuantity);
          }
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            handler.string_value(storeUnit);
          }
        if (flagHasMetricQuantity)
          {
            handler.start_pair("MetricQuantity");
            if (textStoreMetricQuantity != "")
                handler.number_value(textStoreMetricQuantity);
            else if (((double)(long)storeMetricQuantity) == storeMetricQuantity)
                handler.number_value((long)storeMetricQuantity);
            else
                handler.number_value(storeMetricQuantity);
          }
        if (flagHasMetricDisplayQuantity)
          {
            handler.start_pair("MetricDisplayQuantity");
            handler.string_value(storeMetricDisplayQuantity);
          }
        if (flagHasMetricUnit)
          {
            handler.start_pair("MetricUnit");
            handler.string_value(storeMetricUnit);
          }
        if (flagHasPreparationNotes)
          {
            handler.start_pair("PreparationNotes");
            handler.string_value(storePreparationNotes);
          }
        if (flagHasIngredientInfo)
          {
            handler.start_pair("IngredientInfo");
            if (partial_allowed)
                storeIngredientInfo.write_partial_as_json(handler);
            else
                storeIngredientInfo.write_as_json(handler);
          }
        if (flagHasIsLinked)
          {
            handler.start_pair("IsLinked");
            handler.boolean_value(storeIsLinked);
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

    public static BigOvenRecipesIngredientJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesIngredientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesIngredient", ignore_extras);
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
    public static BigOvenRecipesIngredientJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesIngredientJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesIngredientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesIngredient", ignore_extras);
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
    public static BigOvenRecipesIngredientJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesIngredientJSON from_text(string text, bool ignore_extras)
      {
        BigOvenRecipesIngredientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesIngredient", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BigOvenRecipesIngredientJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BigOvenRecipesIngredientJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BigOvenRecipesIngredientJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesIngredient", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorIngredientID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIngredientID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIngredientID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIngredientID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIngredientID fieldGeneratorIngredientID;
    private class FieldHoldingGeneratorDisplayIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDisplayIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDisplayIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDisplayIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDisplayIndex fieldGeneratorDisplayIndex;
        private JSONHoldingBooleanGenerator fieldGeneratorIsHeading;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorHTMLName;
        private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
        private JSONHoldingStringGenerator fieldGeneratorDisplayQuantity;
        private JSONHoldingStringGenerator fieldGeneratorUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorMetricQuantity;
        private JSONHoldingStringGenerator fieldGeneratorMetricDisplayQuantity;
        private JSONHoldingStringGenerator fieldGeneratorMetricUnit;
        private JSONHoldingStringGenerator fieldGeneratorPreparationNotes;
        private TypeIngredientInfoJSON.HoldingGenerator fieldGeneratorIngredientInfo;
        private JSONHoldingBooleanGenerator fieldGeneratorIsLinked;
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
            BigOvenRecipesIngredientJSON result = new BigOvenRecipesIngredientJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBigOvenRecipesIngredientAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BigOvenRecipesIngredientJSON result)
          {
            if (fieldGeneratorIngredientID.have_value)
              {
                result.setIngredientID(fieldGeneratorIngredientID.value);
                fieldGeneratorIngredientID.have_value = false;
              }
            if (fieldGeneratorDisplayIndex.have_value)
              {
                result.setDisplayIndex(fieldGeneratorDisplayIndex.value);
                fieldGeneratorDisplayIndex.have_value = false;
              }
            if (fieldGeneratorIsHeading.have_value)
              {
                result.setIsHeading(fieldGeneratorIsHeading.value);
                fieldGeneratorIsHeading.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorHTMLName.have_value)
              {
                result.setHTMLName(fieldGeneratorHTMLName.value);
                fieldGeneratorHTMLName.have_value = false;
              }
            if (fieldGeneratorQuantity.have_value)
              {
                result.setQuantityText(fieldGeneratorQuantity.value);
                fieldGeneratorQuantity.have_value = false;
              }
            if (fieldGeneratorDisplayQuantity.have_value)
              {
                result.setDisplayQuantity(fieldGeneratorDisplayQuantity.value);
                fieldGeneratorDisplayQuantity.have_value = false;
              }
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            if (fieldGeneratorMetricQuantity.have_value)
              {
                result.setMetricQuantityText(fieldGeneratorMetricQuantity.value);
                fieldGeneratorMetricQuantity.have_value = false;
              }
            if (fieldGeneratorMetricDisplayQuantity.have_value)
              {
                result.setMetricDisplayQuantity(fieldGeneratorMetricDisplayQuantity.value);
                fieldGeneratorMetricDisplayQuantity.have_value = false;
              }
            if (fieldGeneratorMetricUnit.have_value)
              {
                result.setMetricUnit(fieldGeneratorMetricUnit.value);
                fieldGeneratorMetricUnit.have_value = false;
              }
            if (fieldGeneratorPreparationNotes.have_value)
              {
                result.setPreparationNotes(fieldGeneratorPreparationNotes.value);
                fieldGeneratorPreparationNotes.have_value = false;
              }
            if (fieldGeneratorIngredientInfo.have_value)
              {
                result.setIngredientInfo(fieldGeneratorIngredientInfo.value);
                fieldGeneratorIngredientInfo.have_value = false;
              }
            if (fieldGeneratorIsLinked.have_value)
              {
                result.setIsLinked(fieldGeneratorIsLinked.value);
                fieldGeneratorIsLinked.have_value = false;
              }
          }
        protected abstract void handle_result(BigOvenRecipesIngredientJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "isplay", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "ndex", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorDisplayIndex;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 8, "uantity", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDisplayQuantity;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "TMLName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHTMLName;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "gredientI", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'D':
                                        if (field_name.Length == 12)
                                            return fieldGeneratorIngredientID;
                                        break;
                                    case 'n':
                                        if ((String.Compare(field_name, 12, "fo", 0, 2, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorIngredientInfo;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'H':
                                    if ((String.Compare(field_name, 3, "eading", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorIsHeading;
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 3, "inked", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorIsLinked;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "etric", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "isplayQuantity", 0, 14, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorMetricDisplayQuantity;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 7, "uantity", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorMetricQuantity;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 7, "nit", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorMetricUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "reparationNotes", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorPreparationNotes;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uantity", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuantity;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorIngredientID = new FieldHoldingGeneratorIngredientID("field \"IngredientID\" of the BigOvenRecipesIngredient class");
            fieldGeneratorDisplayIndex = new FieldHoldingGeneratorDisplayIndex("field \"DisplayIndex\" of the BigOvenRecipesIngredient class");
            fieldGeneratorIsHeading = new JSONHoldingBooleanGenerator("field \"IsHeading\" of the BigOvenRecipesIngredient class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the BigOvenRecipesIngredient class");
            fieldGeneratorHTMLName = new JSONHoldingStringGenerator("field \"HTMLName\" of the BigOvenRecipesIngredient class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorDisplayQuantity = new JSONHoldingStringGenerator("field \"DisplayQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricQuantity = new JSONHoldingNumberTextGenerator("field \"MetricQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricDisplayQuantity = new JSONHoldingStringGenerator("field \"MetricDisplayQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricUnit = new JSONHoldingStringGenerator("field \"MetricUnit\" of the BigOvenRecipesIngredient class");
            fieldGeneratorPreparationNotes = new JSONHoldingStringGenerator("field \"PreparationNotes\" of the BigOvenRecipesIngredient class");
            fieldGeneratorIngredientInfo = new TypeIngredientInfoJSON.HoldingGenerator("field \"IngredientInfo\" of the BigOvenRecipesIngredient class", ignore_extras);
            fieldGeneratorIsLinked = new JSONHoldingBooleanGenerator("field \"IsLinked\" of the BigOvenRecipesIngredient class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BigOvenRecipesIngredient class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorIngredientID = new FieldHoldingGeneratorIngredientID("field \"IngredientID\" of the BigOvenRecipesIngredient class");
            fieldGeneratorDisplayIndex = new FieldHoldingGeneratorDisplayIndex("field \"DisplayIndex\" of the BigOvenRecipesIngredient class");
            fieldGeneratorIsHeading = new JSONHoldingBooleanGenerator("field \"IsHeading\" of the BigOvenRecipesIngredient class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the BigOvenRecipesIngredient class");
            fieldGeneratorHTMLName = new JSONHoldingStringGenerator("field \"HTMLName\" of the BigOvenRecipesIngredient class");
            fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorDisplayQuantity = new JSONHoldingStringGenerator("field \"DisplayQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorUnit = new JSONHoldingStringGenerator("field \"Unit\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricQuantity = new JSONHoldingNumberTextGenerator("field \"MetricQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricDisplayQuantity = new JSONHoldingStringGenerator("field \"MetricDisplayQuantity\" of the BigOvenRecipesIngredient class");
            fieldGeneratorMetricUnit = new JSONHoldingStringGenerator("field \"MetricUnit\" of the BigOvenRecipesIngredient class");
            fieldGeneratorPreparationNotes = new JSONHoldingStringGenerator("field \"PreparationNotes\" of the BigOvenRecipesIngredient class");
            fieldGeneratorIngredientInfo = new TypeIngredientInfoJSON.HoldingGenerator("field \"IngredientInfo\" of the BigOvenRecipesIngredient class", false);
            fieldGeneratorIsLinked = new JSONHoldingBooleanGenerator("field \"IsLinked\" of the BigOvenRecipesIngredient class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BigOvenRecipesIngredient class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorIngredientID.reset();
            fieldGeneratorDisplayIndex.reset();
            fieldGeneratorIsHeading.reset();
            fieldGeneratorName.reset();
            fieldGeneratorHTMLName.reset();
            fieldGeneratorQuantity.reset();
            fieldGeneratorDisplayQuantity.reset();
            fieldGeneratorUnit.reset();
            fieldGeneratorMetricQuantity.reset();
            fieldGeneratorMetricDisplayQuantity.reset();
            fieldGeneratorMetricUnit.reset();
            fieldGeneratorPreparationNotes.reset();
            fieldGeneratorIngredientInfo.reset();
            fieldGeneratorIsLinked.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorIngredientInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorIngredientInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BigOvenRecipesIngredientJSON  result)
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
        public BigOvenRecipesIngredientJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BigOvenRecipesIngredientJSON  result)
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
    protected virtual void handle_result(List<BigOvenRecipesIngredientJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BigOvenRecipesIngredientJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BigOvenRecipesIngredientJSON>();
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
    public List<BigOvenRecipesIngredientJSON> value;
  };
  };
