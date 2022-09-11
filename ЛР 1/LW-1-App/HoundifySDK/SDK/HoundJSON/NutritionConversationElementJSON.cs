/* file "NutritionConversationElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NutritionConversationElementJSON : JSONBase
  {
    public enum TypeCommandKind
      {
        CommandKind_NutritionCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "NutritionCommand", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeCommandKind.CommandKind_NutritionCommand;
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_NutritionCommand:
                return "NutritionCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeNutritionCommandKind
      {
        NutritionCommandKind_NutritionCommand
      };

    public static TypeNutritionCommandKind  stringToNutritionCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "NutritionCommand", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand;
        throw new Exception("The value for field `NutritionCommandKind' is not one of the legal values.");
      }

    public static string  stringFromNutritionCommandKind(TypeNutritionCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand:
                return "NutritionCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeNutrientsJSON : JSONBase
      {
        private bool flagHasID;
        private BigInteger storeID;
        private bool flagHasOutputUnitsUOMAuxID;
        private BigInteger storeOutputUnitsUOMAuxID;
        private bool flagHasOutputUnitsUOMID;
        private string storeOutputUnitsUOMID;


        private void  fromJSONID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ID of TypeNutrientsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ID of TypeNutrientsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setID(extracted_integer);
          }


        private void  fromJSONOutputUnitsUOMAuxID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OutputUnitsUOMAuxID of TypeNutrientsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OutputUnitsUOMAuxID of TypeNutrientsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOutputUnitsUOMAuxID(extracted_integer);
          }


        private void  fromJSONOutputUnitsUOMID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field OutputUnitsUOMID of TypeNutrientsJSON is not a string.");
            setOutputUnitsUOMID(json_string.getData());
          }


        public TypeNutrientsJSON()
          {
            flagHasID = false;
            flagHasOutputUnitsUOMAuxID = false;
            flagHasOutputUnitsUOMID = false;
          }

        public bool  hasID()
          {
            return flagHasID;
          }

        public BigInteger  getID()
          {
            Debug.Assert(flagHasID);
            return storeID;
          }

        public bool  hasOutputUnitsUOMAuxID()
          {
            return flagHasOutputUnitsUOMAuxID;
          }

        public BigInteger  getOutputUnitsUOMAuxID()
          {
            Debug.Assert(flagHasOutputUnitsUOMAuxID);
            return storeOutputUnitsUOMAuxID;
          }

        public bool  hasOutputUnitsUOMID()
          {
            return flagHasOutputUnitsUOMID;
          }

        public string  getOutputUnitsUOMID()
          {
            Debug.Assert(flagHasOutputUnitsUOMID);
            return storeOutputUnitsUOMID;
          }



        public void setID(BigInteger new_value)
          {
            flagHasID = true;
            if (new_value < 0)
                throw new Exception("The value for field ID of TypeNutrientsJSON is less than the lower bound (0) for that field.");
            storeID = new_value;
          }
        public void unsetID()
          {
            flagHasID = false;
          }
        public void setOutputUnitsUOMAuxID(BigInteger new_value)
          {
            flagHasOutputUnitsUOMAuxID = true;
            if (new_value < -1)
                throw new Exception("The value for field OutputUnitsUOMAuxID of TypeNutrientsJSON is less than the lower bound (-1) for that field.");
            storeOutputUnitsUOMAuxID = new_value;
          }
        public void unsetOutputUnitsUOMAuxID()
          {
            flagHasOutputUnitsUOMAuxID = false;
          }
        public void setOutputUnitsUOMID(string new_value)
          {
            flagHasOutputUnitsUOMID = true;
            storeOutputUnitsUOMID = new_value;
          }
        public void unsetOutputUnitsUOMID()
          {
            flagHasOutputUnitsUOMID = false;
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
            Debug.Assert(partial_allowed || flagHasID);
            if (flagHasID)
              {
                handler.start_pair("ID");
                handler.number_value(storeID);
              }
            Debug.Assert(partial_allowed || flagHasOutputUnitsUOMAuxID);
            if (flagHasOutputUnitsUOMAuxID)
              {
                handler.start_pair("OutputUnitsUOMAuxID");
                handler.number_value(storeOutputUnitsUOMAuxID);
              }
            if (flagHasOutputUnitsUOMID)
              {
                handler.start_pair("OutputUnitsUOMID");
                handler.string_value(storeOutputUnitsUOMID);
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
            if (!(hasID()))
              {
                return "When parsing the object for %what%, the \"ID\" field was missing.";
              }
            if (!(hasOutputUnitsUOMAuxID()))
              {
                return "When parsing the object for %what%, the \"OutputUnitsUOMAuxID\" field was missing.";
              }
            return null;
          }

        public static TypeNutrientsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNutrientsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNutrients", ignore_extras);
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
        public static TypeNutrientsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNutrientsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNutrientsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNutrients", ignore_extras);
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
        public static TypeNutrientsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNutrientsJSON from_text(string text, bool ignore_extras)
          {
            TypeNutrientsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNutrients", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNutrientsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNutrientsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNutrientsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNutrients", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorID fieldGeneratorID;
        private class FieldHoldingGeneratorOutputUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorOutputUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOutputUnitsUOMAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorOutputUnitsUOMAuxID(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
            private FieldHoldingGeneratorOutputUnitsUOMAuxID fieldGeneratorOutputUnitsUOMAuxID;
            private JSONHoldingStringGenerator fieldGeneratorOutputUnitsUOMID;

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
                TypeNutrientsJSON result = new TypeNutrientsJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeNutrientsJSON result)
              {
                if (fieldGeneratorID.have_value)
                  {
                    result.setID(fieldGeneratorID.value);
                    fieldGeneratorID.have_value = false;
                  }
                else if ((!(result.hasID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ID\" field was missing.");
                  }
                if (fieldGeneratorOutputUnitsUOMAuxID.have_value)
                  {
                    result.setOutputUnitsUOMAuxID(fieldGeneratorOutputUnitsUOMAuxID.value);
                    fieldGeneratorOutputUnitsUOMAuxID.have_value = false;
                  }
                else if ((!(result.hasOutputUnitsUOMAuxID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"OutputUnitsUOMAuxID\" field was missing.");
                  }
                if (fieldGeneratorOutputUnitsUOMID.have_value)
                  {
                    result.setOutputUnitsUOMID(fieldGeneratorOutputUnitsUOMID.value);
                    fieldGeneratorOutputUnitsUOMID.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNutrientsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorID;
                        break;
                    case 'O':
                        if (String.Compare(field_name, 1, "utputUnitsUOM", 0, 13, false) == 0)
                          {
                            switch (field_name[14])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 15, "uxID", 0, 4, false) == 0) && (field_name.Length == 19))
                                        return fieldGeneratorOutputUnitsUOMAuxID;
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 15, "D", 0, 1, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorOutputUnitsUOMID;
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
                fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeNutrients class");
                fieldGeneratorOutputUnitsUOMAuxID = new FieldHoldingGeneratorOutputUnitsUOMAuxID("field \"OutputUnitsUOMAuxID\" of the TypeNutrients class");
                fieldGeneratorOutputUnitsUOMID = new JSONHoldingStringGenerator("field \"OutputUnitsUOMID\" of the TypeNutrients class");
                set_what("the TypeNutrients class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeNutrients class");
                fieldGeneratorOutputUnitsUOMAuxID = new FieldHoldingGeneratorOutputUnitsUOMAuxID("field \"OutputUnitsUOMAuxID\" of the TypeNutrients class");
                fieldGeneratorOutputUnitsUOMID = new JSONHoldingStringGenerator("field \"OutputUnitsUOMID\" of the TypeNutrients class");
                set_what("the TypeNutrients class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorID.reset();
                fieldGeneratorOutputUnitsUOMAuxID.reset();
                fieldGeneratorOutputUnitsUOMID.reset();
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
            protected override void handle_result(TypeNutrientsJSON  result)
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
            public TypeNutrientsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNutrientsJSON  result)
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
        protected virtual void handle_result(List<TypeNutrientsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNutrientsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNutrientsJSON>();
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
        public List<TypeNutrientsJSON> value;
      };
      };
    public class TypeConversationFoodBlocksJSON : JSONBase
      {
        private bool flagHasID;
        private BigInteger storeID;
        private bool flagHasQuantity;
        private double storeQuantity;
        private string textStoreQuantity;
        private bool flagHasSizeIndex;
        private BigInteger storeSizeIndex;
        private bool flagHasUOMAuxID;
        private BigInteger storeUOMAuxID;
        private bool flagHasUOMID;
        private string storeUOMID;


        private void  fromJSONID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ID of TypeConversationFoodBlocksJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ID of TypeConversationFoodBlocksJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setID(extracted_integer);
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
                    throw new Exception("The value for field Quantity of TypeConversationFoodBlocksJSON is not a number.");
                  }
              }
            setQuantityText(the_rational_text);
          }


        private void  fromJSONSizeIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field SizeIndex of TypeConversationFoodBlocksJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field SizeIndex of TypeConversationFoodBlocksJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setSizeIndex(extracted_integer);
          }


        private void  fromJSONUOMAuxID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field UOMAuxID of TypeConversationFoodBlocksJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field UOMAuxID of TypeConversationFoodBlocksJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setUOMAuxID(extracted_integer);
          }


        private void  fromJSONUOMID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field UOMID of TypeConversationFoodBlocksJSON is not a string.");
            setUOMID(json_string.getData());
          }


        public TypeConversationFoodBlocksJSON()
          {
            flagHasID = false;
            flagHasQuantity = false;
            flagHasSizeIndex = false;
            flagHasUOMAuxID = false;
            flagHasUOMID = false;
          }

        public bool  hasID()
          {
            return flagHasID;
          }

        public BigInteger  getID()
          {
            Debug.Assert(flagHasID);
            return storeID;
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

        public bool  hasSizeIndex()
          {
            return flagHasSizeIndex;
          }

        public BigInteger  getSizeIndex()
          {
            Debug.Assert(flagHasSizeIndex);
            return storeSizeIndex;
          }

        public bool  hasUOMAuxID()
          {
            return flagHasUOMAuxID;
          }

        public BigInteger  getUOMAuxID()
          {
            Debug.Assert(flagHasUOMAuxID);
            return storeUOMAuxID;
          }

        public bool  hasUOMID()
          {
            return flagHasUOMID;
          }

        public string  getUOMID()
          {
            Debug.Assert(flagHasUOMID);
            return storeUOMID;
          }



        public void setID(BigInteger new_value)
          {
            flagHasID = true;
            if (new_value < 0)
                throw new Exception("The value for field ID of TypeConversationFoodBlocksJSON is less than the lower bound (0) for that field.");
            storeID = new_value;
          }
        public void unsetID()
          {
            flagHasID = false;
          }
        public void setQuantity(double new_value)
          {
            flagHasQuantity = true;
            if (new_value < 0)
                throw new Exception("The value for field Quantity of TypeConversationFoodBlocksJSON is less than the lower bound (0) for that field.");
            storeQuantity = new_value;
            textStoreQuantity = "";
          }
        public void setQuantityText(string new_value)
          {
            flagHasQuantity = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Quantity of TypeConversationFoodBlocksJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Quantity of TypeConversationFoodBlocksJSON is less than the lower bound (0) for that field.");
            textStoreQuantity = new_value;
          }
        public void unsetQuantity()
          {
            flagHasQuantity = false;
          }
        public void setSizeIndex(BigInteger new_value)
          {
            flagHasSizeIndex = true;
            if (new_value < -1)
                throw new Exception("The value for field SizeIndex of TypeConversationFoodBlocksJSON is less than the lower bound (-1) for that field.");
            storeSizeIndex = new_value;
          }
        public void unsetSizeIndex()
          {
            flagHasSizeIndex = false;
          }
        public void setUOMAuxID(BigInteger new_value)
          {
            flagHasUOMAuxID = true;
            if (new_value < -1)
                throw new Exception("The value for field UOMAuxID of TypeConversationFoodBlocksJSON is less than the lower bound (-1) for that field.");
            storeUOMAuxID = new_value;
          }
        public void unsetUOMAuxID()
          {
            flagHasUOMAuxID = false;
          }
        public void setUOMID(string new_value)
          {
            flagHasUOMID = true;
            storeUOMID = new_value;
          }
        public void unsetUOMID()
          {
            flagHasUOMID = false;
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
            Debug.Assert(partial_allowed || flagHasID);
            if (flagHasID)
              {
                handler.start_pair("ID");
                handler.number_value(storeID);
              }
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
            Debug.Assert(partial_allowed || flagHasSizeIndex);
            if (flagHasSizeIndex)
              {
                handler.start_pair("SizeIndex");
                handler.number_value(storeSizeIndex);
              }
            Debug.Assert(partial_allowed || flagHasUOMAuxID);
            if (flagHasUOMAuxID)
              {
                handler.start_pair("UOMAuxID");
                handler.number_value(storeUOMAuxID);
              }
            if (flagHasUOMID)
              {
                handler.start_pair("UOMID");
                handler.string_value(storeUOMID);
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
            if (!(hasID()))
              {
                return "When parsing the object for %what%, the \"ID\" field was missing.";
              }
            if (!(hasQuantity()))
              {
                return "When parsing the object for %what%, the \"Quantity\" field was missing.";
              }
            if (!(hasSizeIndex()))
              {
                return "When parsing the object for %what%, the \"SizeIndex\" field was missing.";
              }
            if (!(hasUOMAuxID()))
              {
                return "When parsing the object for %what%, the \"UOMAuxID\" field was missing.";
              }
            return null;
          }

        public static TypeConversationFoodBlocksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeConversationFoodBlocksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConversationFoodBlocks", ignore_extras);
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
        public static TypeConversationFoodBlocksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeConversationFoodBlocksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeConversationFoodBlocksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConversationFoodBlocks", ignore_extras);
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
        public static TypeConversationFoodBlocksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeConversationFoodBlocksJSON from_text(string text, bool ignore_extras)
          {
            TypeConversationFoodBlocksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConversationFoodBlocks", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeConversationFoodBlocksJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeConversationFoodBlocksJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeConversationFoodBlocksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConversationFoodBlocks", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorID fieldGeneratorID;
            private JSONHoldingNumberTextGenerator fieldGeneratorQuantity;
        private class FieldHoldingGeneratorSizeIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorSizeIndex(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorSizeIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorSizeIndex(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
            private FieldHoldingGeneratorSizeIndex fieldGeneratorSizeIndex;
        private class FieldHoldingGeneratorUOMAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorUOMAuxID(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorUOMAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorUOMAuxID(String what) : base(what, (BigInteger)(-1))
                  {
                  }
              };
            private FieldHoldingGeneratorUOMAuxID fieldGeneratorUOMAuxID;
            private JSONHoldingStringGenerator fieldGeneratorUOMID;

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
                TypeConversationFoodBlocksJSON result = new TypeConversationFoodBlocksJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeConversationFoodBlocksJSON result)
              {
                if (fieldGeneratorID.have_value)
                  {
                    result.setID(fieldGeneratorID.value);
                    fieldGeneratorID.have_value = false;
                  }
                else if ((!(result.hasID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ID\" field was missing.");
                  }
                if (fieldGeneratorQuantity.have_value)
                  {
                    result.setQuantityText(fieldGeneratorQuantity.value);
                    fieldGeneratorQuantity.have_value = false;
                  }
                else if ((!(result.hasQuantity())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Quantity\" field was missing.");
                  }
                if (fieldGeneratorSizeIndex.have_value)
                  {
                    result.setSizeIndex(fieldGeneratorSizeIndex.value);
                    fieldGeneratorSizeIndex.have_value = false;
                  }
                else if ((!(result.hasSizeIndex())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SizeIndex\" field was missing.");
                  }
                if (fieldGeneratorUOMAuxID.have_value)
                  {
                    result.setUOMAuxID(fieldGeneratorUOMAuxID.value);
                    fieldGeneratorUOMAuxID.have_value = false;
                  }
                else if ((!(result.hasUOMAuxID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"UOMAuxID\" field was missing.");
                  }
                if (fieldGeneratorUOMID.have_value)
                  {
                    result.setUOMID(fieldGeneratorUOMID.value);
                    fieldGeneratorUOMID.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeConversationFoodBlocksJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                            return fieldGeneratorID;
                        break;
                    case 'Q':
                        if ((String.Compare(field_name, 1, "uantity", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorQuantity;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "izeIndex", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorSizeIndex;
                        break;
                    case 'U':
                        if (String.Compare(field_name, 1, "OM", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 4, "uxID", 0, 4, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorUOMAuxID;
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 4, "D", 0, 1, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorUOMID;
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
                fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeConversationFoodBlocks class");
                fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the TypeConversationFoodBlocks class");
                fieldGeneratorSizeIndex = new FieldHoldingGeneratorSizeIndex("field \"SizeIndex\" of the TypeConversationFoodBlocks class");
                fieldGeneratorUOMAuxID = new FieldHoldingGeneratorUOMAuxID("field \"UOMAuxID\" of the TypeConversationFoodBlocks class");
                fieldGeneratorUOMID = new JSONHoldingStringGenerator("field \"UOMID\" of the TypeConversationFoodBlocks class");
                set_what("the TypeConversationFoodBlocks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorID = new FieldHoldingGeneratorID("field \"ID\" of the TypeConversationFoodBlocks class");
                fieldGeneratorQuantity = new JSONHoldingNumberTextGenerator("field \"Quantity\" of the TypeConversationFoodBlocks class");
                fieldGeneratorSizeIndex = new FieldHoldingGeneratorSizeIndex("field \"SizeIndex\" of the TypeConversationFoodBlocks class");
                fieldGeneratorUOMAuxID = new FieldHoldingGeneratorUOMAuxID("field \"UOMAuxID\" of the TypeConversationFoodBlocks class");
                fieldGeneratorUOMID = new JSONHoldingStringGenerator("field \"UOMID\" of the TypeConversationFoodBlocks class");
                set_what("the TypeConversationFoodBlocks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorID.reset();
                fieldGeneratorQuantity.reset();
                fieldGeneratorSizeIndex.reset();
                fieldGeneratorUOMAuxID.reset();
                fieldGeneratorUOMID.reset();
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
            protected override void handle_result(TypeConversationFoodBlocksJSON  result)
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
            public TypeConversationFoodBlocksJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeConversationFoodBlocksJSON  result)
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
        protected virtual void handle_result(List<TypeConversationFoodBlocksJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeConversationFoodBlocksJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeConversationFoodBlocksJSON>();
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
        public List<TypeConversationFoodBlocksJSON> value;
      };
      };
    private bool flagHasCommandKind;
    private bool flagHasNutritionCommandKind;
    private bool flagHasNutrients;
    private List< TypeNutrientsJSON  > storeNutrients;
    private bool flagHasConversationFoodBlocks;
    private List< List< TypeConversationFoodBlocksJSON  > > storeConversationFoodBlocks;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of NutritionConversationElementJSON is not a string.");
        if (!(json_string.getData().Equals("NutritionCommand")))
            throw new Exception("The value for field CommandKind of NutritionConversationElementJSON is not `NutritionCommand'.");
        setCommandKind();
      }


    private void  fromJSONNutritionCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NutritionCommandKind of NutritionConversationElementJSON is not a string.");
        if (!(json_string.getData().Equals("NutritionCommand")))
            throw new Exception("The value for field NutritionCommandKind of NutritionConversationElementJSON is not `NutritionCommand'.");
        setNutritionCommandKind();
      }


    private void  fromJSONNutrients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Nutrients of NutritionConversationElementJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeNutrientsJSON  > vector_Nutrients1 = new List< TypeNutrientsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeNutrientsJSON convert_classy = TypeNutrientsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Nutrients1.Add(convert_classy);
          }
        initNutrients();
        for (int num1 = 0; num1 < vector_Nutrients1.Count; ++num1)
            appendNutrients(vector_Nutrients1[num1]);
        for (int num1 = 0; num1 < vector_Nutrients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONConversationFoodBlocks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ConversationFoodBlocks of NutritionConversationElementJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< List< TypeConversationFoodBlocksJSON  > > vector_ConversationFoodBlocks1 = new List< List< TypeConversationFoodBlocksJSON  > >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONArrayValue json_array2 = json_array1.component(num1).array_value();
            if (json_array2 == null)
                throw new Exception("The value for an element of field ConversationFoodBlocks of NutritionConversationElementJSON is not an array.");
            int count2 = json_array2.componentCount();
            List< TypeConversationFoodBlocksJSON  > vector_ConversationFoodBlocks2 = new List< TypeConversationFoodBlocksJSON  >(count2);
            for (int num2 = 0; num2 < count2; ++num2)
              {
                TypeConversationFoodBlocksJSON convert_classy = TypeConversationFoodBlocksJSON.from_json(json_array2.component(num2), ignore_extras, true);
                vector_ConversationFoodBlocks2.Add(convert_classy);
              }
            vector_ConversationFoodBlocks1.Add(vector_ConversationFoodBlocks2);
          }
        initConversationFoodBlocks();
        for (int num2 = 0; num2 < vector_ConversationFoodBlocks1.Count; ++num2)
            appendConversationFoodBlocks(vector_ConversationFoodBlocks1[num2]);
        for (int num1 = 0; num1 < vector_ConversationFoodBlocks1.Count; ++num1)
          {
            for (int num2 = 0; num2 < vector_ConversationFoodBlocks1[num1].Count; ++num2)
              {
              }
          }
      }


    public NutritionConversationElementJSON()
      {
        flagHasCommandKind = false;
        flagHasNutritionCommandKind = false;
        flagHasNutrients = false;
        flagHasConversationFoodBlocks = false;
        storeNutrients = new List< TypeNutrientsJSON  >();
        storeConversationFoodBlocks = new List< List< TypeConversationFoodBlocksJSON  > >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return TypeCommandKind.CommandKind_NutritionCommand;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }

    public bool  hasNutritionCommandKind()
      {
        return flagHasNutritionCommandKind;
      }

    public TypeNutritionCommandKind  getNutritionCommandKind()
      {
        Debug.Assert(flagHasNutritionCommandKind);
        return TypeNutritionCommandKind.NutritionCommandKind_NutritionCommand;
      }

    public string  getNutritionCommandKindAsString()
      {
        return stringFromNutritionCommandKind(getNutritionCommandKind());
      }

    public bool  hasNutrients()
      {
        return flagHasNutrients;
      }

    public int  countOfNutrients()
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients.Count;
      }

    public TypeNutrientsJSON   elementOfNutrients(int element_num)
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients[element_num];
      }

    public List< TypeNutrientsJSON  >  getNutrients()
      {
        Debug.Assert(flagHasNutrients);
        return storeNutrients;
      }

    public bool  hasConversationFoodBlocks()
      {
        return flagHasConversationFoodBlocks;
      }

    public int  countOfConversationFoodBlocks()
      {
        Debug.Assert(flagHasConversationFoodBlocks);
        return storeConversationFoodBlocks.Count;
      }

    public List< TypeConversationFoodBlocksJSON  >  elementOfConversationFoodBlocks(int element_num)
      {
        Debug.Assert(flagHasConversationFoodBlocks);
        return storeConversationFoodBlocks[element_num];
      }

    public List< List< TypeConversationFoodBlocksJSON  > >  getConversationFoodBlocks()
      {
        Debug.Assert(flagHasConversationFoodBlocks);
        return storeConversationFoodBlocks;
      }


    public virtual int extraNutritionConversationElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNutritionConversationElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNutritionConversationElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNutritionConversationElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCommandKind()
      {
        flagHasCommandKind = true;
      }
    public void setCommandKind(TypeCommandKind new_value)
      {
        setCommandKind();
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }
    public void setNutritionCommandKind()
      {
        flagHasNutritionCommandKind = true;
      }
    public void setNutritionCommandKind(TypeNutritionCommandKind new_value)
      {
        setNutritionCommandKind();
      }
    public void setNutritionCommandKind(string chars)
      {
        setNutritionCommandKind(stringToNutritionCommandKind(chars));
      }
    public void unsetNutritionCommandKind()
      {
        flagHasNutritionCommandKind = false;
      }
    public void initNutrients()
      {
        if (flagHasNutrients)
          {
            for (int num1 = 0; num1 < storeNutrients.Count; ++num1)
              {
              }
          }
        flagHasNutrients = true;
        storeNutrients.Clear();
      }
    public void appendNutrients(TypeNutrientsJSON  to_append)
      {
        if (!flagHasNutrients)
          {
            flagHasNutrients = true;
            storeNutrients.Clear();
          }
        Debug.Assert(flagHasNutrients);
        storeNutrients.Add(to_append);
      }
    public void unsetNutrients()
      {
        if (flagHasNutrients)
          {
            for (int num2 = 0; num2 < storeNutrients.Count; ++num2)
              {
              }
          }
        flagHasNutrients = false;
        storeNutrients.Clear();
      }
    public void initConversationFoodBlocks()
      {
        if (flagHasConversationFoodBlocks)
          {
            for (int num3 = 0; num3 < storeConversationFoodBlocks.Count; ++num3)
              {
                for (int num4 = 0; num4 < storeConversationFoodBlocks[num3].Count; ++num4)
                  {
                  }
              }
          }
        flagHasConversationFoodBlocks = true;
        storeConversationFoodBlocks.Clear();
      }
    public void appendConversationFoodBlocks(List< TypeConversationFoodBlocksJSON  > to_append)
      {
        if (!flagHasConversationFoodBlocks)
          {
            flagHasConversationFoodBlocks = true;
            storeConversationFoodBlocks.Clear();
          }
        Debug.Assert(flagHasConversationFoodBlocks);
        for (int num1 = 0; num1 < to_append.Count; ++num1)
          {
          }
        storeConversationFoodBlocks.Add(to_append);
      }
    public void unsetConversationFoodBlocks()
      {
        if (flagHasConversationFoodBlocks)
          {
            for (int num5 = 0; num5 < storeConversationFoodBlocks.Count; ++num5)
              {
                for (int num6 = 0; num6 < storeConversationFoodBlocks[num5].Count; ++num6)
                  {
                  }
              }
          }
        flagHasConversationFoodBlocks = false;
        storeConversationFoodBlocks.Clear();
      }

    public virtual void extraNutritionConversationElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNutritionConversationElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNutritionConversationElementLookup(key);
        if (old_field == null)
          {
            extraNutritionConversationElementAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCommandKind);
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            handler.string_value("NutritionCommand");
          }
        Debug.Assert(partial_allowed || flagHasNutritionCommandKind);
        if (flagHasNutritionCommandKind)
          {
            handler.start_pair("NutritionCommandKind");
            handler.string_value("NutritionCommand");
          }
        Debug.Assert(partial_allowed || flagHasNutrients);
        if (flagHasNutrients)
          {
            handler.start_pair("Nutrients");
            handler.start_array();
            for (int num1 = 0; num1 < storeNutrients.Count; ++num1)
              {
                if (partial_allowed)
                    storeNutrients[num1].write_partial_as_json(handler);
                else
                    storeNutrients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasConversationFoodBlocks);
        if (flagHasConversationFoodBlocks)
          {
            handler.start_pair("ConversationFoodBlocks");
            handler.start_array();
            for (int num2 = 0; num2 < storeConversationFoodBlocks.Count; ++num2)
              {
                handler.start_array();
                for (int num3 = 0; num3 < storeConversationFoodBlocks[num2].Count; ++num3)
                  {
                    if (partial_allowed)
                        storeConversationFoodBlocks[num2][num3].write_partial_as_json(handler);
                    else
                        storeConversationFoodBlocks[num2][num3].write_as_json(handler);
                  }
                handler.finish_array();
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
        if (!(hasCommandKind()))
          {
            return "When parsing the object for %what%, the \"CommandKind\" field was missing.";
          }
        if (!(hasNutritionCommandKind()))
          {
            return "When parsing the object for %what%, the \"NutritionCommandKind\" field was missing.";
          }
        if (!(hasNutrients()))
          {
            return "When parsing the object for %what%, the \"Nutrients\" field was missing.";
          }
        if (!(hasConversationFoodBlocks()))
          {
            return "When parsing the object for %what%, the \"ConversationFoodBlocks\" field was missing.";
          }
        return null;
      }

    public static NutritionConversationElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutritionConversationElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionConversationElement", ignore_extras);
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
    public static NutritionConversationElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NutritionConversationElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NutritionConversationElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionConversationElement", ignore_extras);
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
    public static NutritionConversationElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NutritionConversationElementJSON from_text(string text, bool ignore_extras)
      {
        NutritionConversationElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionConversationElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NutritionConversationElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NutritionConversationElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NutritionConversationElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NutritionConversationElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
    private abstract class FieldGeneratorNutritionCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorNutritionCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNutritionCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNutritionCommandKind(result));
              }
            protected abstract void handle_result(TypeNutritionCommandKind result);
          };
    private class FieldHoldingGeneratorNutritionCommandKind : FieldGeneratorNutritionCommandKind
  {
    protected override void handle_result(TypeNutritionCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNutritionCommandKind(String what)
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
    public TypeNutritionCommandKind value;
  };
    private class FieldHoldingArrayGeneratorNutritionCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNutritionCommandKind
      {
        private FieldHoldingArrayGeneratorNutritionCommandKind top;

        protected override void handle_result(TypeNutritionCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNutritionCommandKind init_top)
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
    protected virtual void handle_result(List<TypeNutritionCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorNutritionCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNutritionCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNutritionCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNutritionCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNutritionCommandKind> value;
  };
        private FieldHoldingGeneratorNutritionCommandKind fieldGeneratorNutritionCommandKind;
        private TypeNutrientsJSON.HoldingArrayGenerator fieldGeneratorNutrients;
    private class FieldHoldingArrayGeneratorConversationFoodBlocks : JSONArrayGenerator
  {
    protected class ElementHandler : TypeConversationFoodBlocksJSON.HoldingArrayGenerator
      {
        private FieldHoldingArrayGeneratorConversationFoodBlocks top;

        protected override void handle_result(List< TypeConversationFoodBlocksJSON  > result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorConversationFoodBlocks init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<List< TypeConversationFoodBlocksJSON  >> result)
      {
      }

    public FieldHoldingArrayGeneratorConversationFoodBlocks(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< TypeConversationFoodBlocksJSON  >>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorConversationFoodBlocks(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<List< TypeConversationFoodBlocksJSON  >>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<List< TypeConversationFoodBlocksJSON  >> value;
  };
        private FieldHoldingArrayGeneratorConversationFoodBlocks fieldGeneratorConversationFoodBlocks;
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
            NutritionConversationElementJSON result = new NutritionConversationElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNutritionConversationElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(NutritionConversationElementJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind();
                fieldGeneratorCommandKind.have_value = false;
              }
            else if ((!(result.hasCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CommandKind\" field was missing.");
              }
            if (fieldGeneratorNutritionCommandKind.have_value)
              {
                result.setNutritionCommandKind();
                fieldGeneratorNutritionCommandKind.have_value = false;
              }
            else if ((!(result.hasNutritionCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NutritionCommandKind\" field was missing.");
              }
            if (fieldGeneratorNutrients.have_value)
              {
                result.initNutrients();
                int count = fieldGeneratorNutrients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNutrients(fieldGeneratorNutrients.value[num]);
                  }
                fieldGeneratorNutrients.value.Clear();
                fieldGeneratorNutrients.have_value = false;
              }
            else if ((!(result.hasNutrients())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Nutrients\" field was missing.");
              }
            if (fieldGeneratorConversationFoodBlocks.have_value)
              {
                result.initConversationFoodBlocks();
                int count = fieldGeneratorConversationFoodBlocks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    List< TypeConversationFoodBlocksJSON  > unwrapped0 = new List< TypeConversationFoodBlocksJSON  >();
                    for (int num0 = 0; num0 < fieldGeneratorConversationFoodBlocks.value[num].Count; ++num0)
                      {
                        unwrapped0.Add(fieldGeneratorConversationFoodBlocks.value[num][num0]);
                      }
                    result.appendConversationFoodBlocks(unwrapped0);
                  }
                fieldGeneratorConversationFoodBlocks.value.Clear();
                fieldGeneratorConversationFoodBlocks.have_value = false;
              }
            else if ((!(result.hasConversationFoodBlocks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ConversationFoodBlocks\" field was missing.");
              }
          }
        protected abstract void handle_result(NutritionConversationElementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'm':
                                if ((String.Compare(field_name, 3, "mandKind", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorCommandKind;
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 3, "versationFoodBlocks", 0, 19, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorConversationFoodBlocks;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "utri", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 6, "nts", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorNutrients;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 6, "ionCommandKind", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorNutritionCommandKind;
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
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the NutritionConversationElement class");
            fieldGeneratorNutritionCommandKind = new FieldHoldingGeneratorNutritionCommandKind("field \"NutritionCommandKind\" of the NutritionConversationElement class");
            fieldGeneratorNutrients = new TypeNutrientsJSON.HoldingArrayGenerator("field \"Nutrients\" of the NutritionConversationElement class", ignore_extras);
            fieldGeneratorConversationFoodBlocks = new FieldHoldingArrayGeneratorConversationFoodBlocks("field \"ConversationFoodBlocks\" of the NutritionConversationElement class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NutritionConversationElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the NutritionConversationElement class");
            fieldGeneratorNutritionCommandKind = new FieldHoldingGeneratorNutritionCommandKind("field \"NutritionCommandKind\" of the NutritionConversationElement class");
            fieldGeneratorNutrients = new TypeNutrientsJSON.HoldingArrayGenerator("field \"Nutrients\" of the NutritionConversationElement class", false);
            fieldGeneratorConversationFoodBlocks = new FieldHoldingArrayGeneratorConversationFoodBlocks("field \"ConversationFoodBlocks\" of the NutritionConversationElement class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NutritionConversationElement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            fieldGeneratorNutritionCommandKind.reset();
            fieldGeneratorNutrients.reset();
            fieldGeneratorConversationFoodBlocks.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNutrients.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNutrients.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(NutritionConversationElementJSON  result)
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
        public NutritionConversationElementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NutritionConversationElementJSON  result)
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
    protected virtual void handle_result(List<NutritionConversationElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NutritionConversationElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NutritionConversationElementJSON>();
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
    public List<NutritionConversationElementJSON> value;
  };
  };
