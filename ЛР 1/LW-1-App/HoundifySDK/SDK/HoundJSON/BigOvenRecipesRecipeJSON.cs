/* file "BigOvenRecipesRecipeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class BigOvenRecipesRecipeJSON : JSONBase
  {
    public class TypeStepsJSON : JSONBase
      {
        private bool flagHasText;
        private string storeText;
        private bool flagHasStartGantt;
        private BigInteger storeStartGantt;
        private bool flagHasEndGantt;
        private BigInteger storeEndGantt;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Text of TypeStepsJSON is not a string.");
            setText(json_string.getData());
          }


        private void  fromJSONStartGantt(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartGantt of TypeStepsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartGantt of TypeStepsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartGantt(extracted_integer);
          }


        private void  fromJSONEndGantt(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndGantt of TypeStepsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndGantt of TypeStepsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndGantt(extracted_integer);
          }


        public TypeStepsJSON()
          {
            flagHasText = false;
            flagHasStartGantt = false;
            flagHasEndGantt = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasText()
          {
            return flagHasText;
          }

        public string  getText()
          {
            Debug.Assert(flagHasText);
            return storeText;
          }

        public bool  hasStartGantt()
          {
            return flagHasStartGantt;
          }

        public BigInteger  getStartGantt()
          {
            Debug.Assert(flagHasStartGantt);
            return storeStartGantt;
          }

        public bool  hasEndGantt()
          {
            return flagHasEndGantt;
          }

        public BigInteger  getEndGantt()
          {
            Debug.Assert(flagHasEndGantt);
            return storeEndGantt;
          }


        public virtual int extraTypeStepsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStepsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStepsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStepsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setText(string new_value)
          {
            flagHasText = true;
            storeText = new_value;
          }
        public void unsetText()
          {
            flagHasText = false;
          }
        public void setStartGantt(BigInteger new_value)
          {
            flagHasStartGantt = true;
            storeStartGantt = new_value;
          }
        public void unsetStartGantt()
          {
            flagHasStartGantt = false;
          }
        public void setEndGantt(BigInteger new_value)
          {
            flagHasEndGantt = true;
            storeEndGantt = new_value;
          }
        public void unsetEndGantt()
          {
            flagHasEndGantt = false;
          }

        public virtual void extraTypeStepsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStepsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStepsLookup(key);
            if (old_field == null)
              {
                extraTypeStepsAppendPair(key, new_component);
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
            if (flagHasText)
              {
                handler.start_pair("Text");
                handler.string_value(storeText);
              }
            if (flagHasStartGantt)
              {
                handler.start_pair("StartGantt");
                handler.number_value(storeStartGantt);
              }
            if (flagHasEndGantt)
              {
                handler.start_pair("EndGantt");
                handler.number_value(storeEndGantt);
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

        public static TypeStepsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStepsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSteps", ignore_extras);
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
        public static TypeStepsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStepsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStepsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSteps", ignore_extras);
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
        public static TypeStepsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStepsJSON from_text(string text, bool ignore_extras)
          {
            TypeStepsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSteps", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStepsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStepsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStepsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSteps", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorText;
        private class FieldHoldingGeneratorStartGantt : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorStartGantt(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartGantt : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartGantt(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorStartGantt fieldGeneratorStartGantt;
        private class FieldHoldingGeneratorEndGantt : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorEndGantt(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndGantt : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndGantt(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorEndGantt fieldGeneratorEndGantt;
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
                TypeStepsJSON result = new TypeStepsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStepsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStepsJSON result)
              {
                if (fieldGeneratorText.have_value)
                  {
                    result.setText(fieldGeneratorText.value);
                    fieldGeneratorText.have_value = false;
                  }
                if (fieldGeneratorStartGantt.have_value)
                  {
                    result.setStartGantt(fieldGeneratorStartGantt.value);
                    fieldGeneratorStartGantt.have_value = false;
                  }
                if (fieldGeneratorEndGantt.have_value)
                  {
                    result.setEndGantt(fieldGeneratorEndGantt.value);
                    fieldGeneratorEndGantt.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeStepsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "ndGantt", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorEndGantt;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tartGantt", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorStartGantt;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorText;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeSteps class");
                fieldGeneratorStartGantt = new FieldHoldingGeneratorStartGantt("field \"StartGantt\" of the TypeSteps class");
                fieldGeneratorEndGantt = new FieldHoldingGeneratorEndGantt("field \"EndGantt\" of the TypeSteps class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSteps class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeSteps class");
                fieldGeneratorStartGantt = new FieldHoldingGeneratorStartGantt("field \"StartGantt\" of the TypeSteps class");
                fieldGeneratorEndGantt = new FieldHoldingGeneratorEndGantt("field \"EndGantt\" of the TypeSteps class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSteps class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorText.reset();
                fieldGeneratorStartGantt.reset();
                fieldGeneratorEndGantt.reset();
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
            protected override void handle_result(TypeStepsJSON  result)
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
            public TypeStepsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStepsJSON  result)
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
        protected virtual void handle_result(List<TypeStepsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStepsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStepsJSON>();
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
        public List<TypeStepsJSON> value;
      };
      };
    private bool flagHasRecipeID;
    private BigInteger storeRecipeID;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasCuisine;
    private string storeCuisine;
    private bool flagHasCategory;
    private string storeCategory;
    private bool flagHasSubcategory;
    private string storeSubcategory;
    private bool flagHasMicrocategory;
    private string storeMicrocategory;
    private bool flagHasPrimaryIngredient;
    private string storePrimaryIngredient;
    private bool flagHasStarRating;
    private double storeStarRating;
    private string textStoreStarRating;
    private bool flagHasWebURL;
    private string storeWebURL;
    private bool flagHasImageURL;
    private string storeImageURL;
    private bool flagHasReviewCount;
    private BigInteger storeReviewCount;
    private bool flagHasMedalCount;
    private BigInteger storeMedalCount;
    private bool flagHasFavoriteCount;
    private BigInteger storeFavoriteCount;
    private bool flagHasPoster;
    private BigOvenRecipesPosterSingleRecipeJSON  storePoster;
    private bool flagHasIngredients;
    private List< BigOvenRecipesIngredientJSON  > storeIngredients;
    private bool flagHasSteps;
    private List< TypeStepsJSON  > storeSteps;
    private bool flagHasInstructions;
    private string storeInstructions;
    private bool flagHasYieldNumber;
    private double storeYieldNumber;
    private string textStoreYieldNumber;
    private bool flagHasYieldUnit;
    private string storeYieldUnit;
    private bool flagHasTotalMinutes;
    private BigInteger storeTotalMinutes;
    private bool flagHasActiveMinutes;
    private BigInteger storeActiveMinutes;
    private bool flagHasNutritionInfo;
    private BigOvenRecipesNutritionInfoJSON  storeNutritionInfo;
    private bool flagHasIsPrivate;
    private bool storeIsPrivate;
    private bool flagHasCreationDate;
    private string storeCreationDate;
    private bool flagHasLastModified;
    private string storeLastModified;
    private bool flagHasIsBookmark;
    private bool storeIsBookmark;
    private bool flagHasBookmarkURL;
    private string storeBookmarkURL;
    private bool flagHasBookmarkSiteLogo;
    private string storeBookmarkSiteLogo;
    private bool flagHasBookmarkImageURL;
    private string storeBookmarkImageURL;
    private bool flagHasIsRecipeScan;
    private bool storeIsRecipeScan;
    private bool flagHasMenuCount;
    private BigInteger storeMenuCount;
    private bool flagHasNotesCount;
    private BigInteger storeNotesCount;
    private bool flagHasAdTags;
    private string storeAdTags;
    private bool flagHasIngredientsTextBlock;
    private string storeIngredientsTextBlock;
    private bool flagHasAllCategoriesText;
    private string storeAllCategoriesText;
    private bool flagHasIsSponsored;
    private bool storeIsSponsored;
    private bool flagHasVariantOfRecipeID;
    private BigInteger storeVariantOfRecipeID;
    private bool flagHasCollection;
    private string storeCollection;
    private bool flagHasCollectionID;
    private BigInteger storeCollectionID;
    private bool flagHasAdminBoost;
    private BigInteger storeAdminBoost;
    private bool flagHasVerifiedDateTime;
    private string storeVerifiedDateTime;
    private bool flagHasMaxImageSquare;
    private BigInteger storeMaxImageSquare;
    private bool flagHasImageSquares;
    private List< BigInteger > storeImageSquares;
    private bool flagHasPhotoUrl;
    private string storePhotoUrl;
    private bool flagHasVerifiedByClass;
    private string storeVerifiedByClass;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRecipeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RecipeID of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecipeID of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRecipeID(extracted_integer);
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of BigOvenRecipesRecipeJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of BigOvenRecipesRecipeJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONCuisine(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Cuisine of BigOvenRecipesRecipeJSON is not a string.");
        setCuisine(json_string.getData());
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of BigOvenRecipesRecipeJSON is not a string.");
        setCategory(json_string.getData());
      }


    private void  fromJSONSubcategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subcategory of BigOvenRecipesRecipeJSON is not a string.");
        setSubcategory(json_string.getData());
      }


    private void  fromJSONMicrocategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Microcategory of BigOvenRecipesRecipeJSON is not a string.");
        setMicrocategory(json_string.getData());
      }


    private void  fromJSONPrimaryIngredient(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrimaryIngredient of BigOvenRecipesRecipeJSON is not a string.");
        setPrimaryIngredient(json_string.getData());
      }


    private void  fromJSONStarRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRating of BigOvenRecipesRecipeJSON is not a number.");
              }
          }
        setStarRatingText(the_rational_text);
      }


    private void  fromJSONWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WebURL of BigOvenRecipesRecipeJSON is not a string.");
        setWebURL(json_string.getData());
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of BigOvenRecipesRecipeJSON is not a string.");
        setImageURL(json_string.getData());
      }


    private void  fromJSONReviewCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReviewCount of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCount of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCount(extracted_integer);
      }


    private void  fromJSONMedalCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MedalCount of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MedalCount of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMedalCount(extracted_integer);
      }


    private void  fromJSONFavoriteCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FavoriteCount of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FavoriteCount of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFavoriteCount(extracted_integer);
      }


    private void  fromJSONPoster(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigOvenRecipesPosterSingleRecipeJSON convert_classy = BigOvenRecipesPosterSingleRecipeJSON.from_json(json_value, ignore_extras, true);
        setPoster(convert_classy);
      }


    private void  fromJSONIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ingredients of BigOvenRecipesRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigOvenRecipesIngredientJSON  > vector_Ingredients1 = new List< BigOvenRecipesIngredientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigOvenRecipesIngredientJSON convert_classy = BigOvenRecipesIngredientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ingredients1.Add(convert_classy);
          }
        initIngredients();
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
            appendIngredients(vector_Ingredients1[num1]);
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSteps(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Steps of BigOvenRecipesRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeStepsJSON  > vector_Steps1 = new List< TypeStepsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeStepsJSON convert_classy = TypeStepsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Steps1.Add(convert_classy);
          }
        initSteps();
        for (int num2 = 0; num2 < vector_Steps1.Count; ++num2)
            appendSteps(vector_Steps1[num2]);
        for (int num1 = 0; num1 < vector_Steps1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInstructions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Instructions of BigOvenRecipesRecipeJSON is not a string.");
        setInstructions(json_string.getData());
      }


    private void  fromJSONYieldNumber(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YieldNumber of BigOvenRecipesRecipeJSON is not a number.");
              }
          }
        setYieldNumberText(the_rational_text);
      }


    private void  fromJSONYieldUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YieldUnit of BigOvenRecipesRecipeJSON is not a string.");
        setYieldUnit(json_string.getData());
      }


    private void  fromJSONTotalMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalMinutes of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalMinutes of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalMinutes(extracted_integer);
      }


    private void  fromJSONActiveMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ActiveMinutes of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ActiveMinutes of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setActiveMinutes(extracted_integer);
      }


    private void  fromJSONNutritionInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigOvenRecipesNutritionInfoJSON convert_classy = BigOvenRecipesNutritionInfoJSON.from_json(json_value, ignore_extras, true);
        setNutritionInfo(convert_classy);
      }


    private void  fromJSONIsPrivate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPrivate of BigOvenRecipesRecipeJSON is not true for false.");
              }
          }
        setIsPrivate(the_bool);
      }


    private void  fromJSONCreationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CreationDate of BigOvenRecipesRecipeJSON is not a string.");
        setCreationDate(json_string.getData());
      }


    private void  fromJSONLastModified(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastModified of BigOvenRecipesRecipeJSON is not a string.");
        setLastModified(json_string.getData());
      }


    private void  fromJSONIsBookmark(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsBookmark of BigOvenRecipesRecipeJSON is not true for false.");
              }
          }
        setIsBookmark(the_bool);
      }


    private void  fromJSONBookmarkURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BookmarkURL of BigOvenRecipesRecipeJSON is not a string.");
        setBookmarkURL(json_string.getData());
      }


    private void  fromJSONBookmarkSiteLogo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BookmarkSiteLogo of BigOvenRecipesRecipeJSON is not a string.");
        setBookmarkSiteLogo(json_string.getData());
      }


    private void  fromJSONBookmarkImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BookmarkImageURL of BigOvenRecipesRecipeJSON is not a string.");
        setBookmarkImageURL(json_string.getData());
      }


    private void  fromJSONIsRecipeScan(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRecipeScan of BigOvenRecipesRecipeJSON is not true for false.");
              }
          }
        setIsRecipeScan(the_bool);
      }


    private void  fromJSONMenuCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MenuCount of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MenuCount of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMenuCount(extracted_integer);
      }


    private void  fromJSONNotesCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NotesCount of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NotesCount of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNotesCount(extracted_integer);
      }


    private void  fromJSONAdTags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AdTags of BigOvenRecipesRecipeJSON is not a string.");
        setAdTags(json_string.getData());
      }


    private void  fromJSONIngredientsTextBlock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IngredientsTextBlock of BigOvenRecipesRecipeJSON is not a string.");
        setIngredientsTextBlock(json_string.getData());
      }


    private void  fromJSONAllCategoriesText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AllCategoriesText of BigOvenRecipesRecipeJSON is not a string.");
        setAllCategoriesText(json_string.getData());
      }


    private void  fromJSONIsSponsored(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSponsored of BigOvenRecipesRecipeJSON is not true for false.");
              }
          }
        setIsSponsored(the_bool);
      }


    private void  fromJSONVariantOfRecipeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field VariantOfRecipeID of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field VariantOfRecipeID of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setVariantOfRecipeID(extracted_integer);
      }


    private void  fromJSONCollection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Collection of BigOvenRecipesRecipeJSON is not a string.");
        setCollection(json_string.getData());
      }


    private void  fromJSONCollectionID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CollectionID of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CollectionID of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCollectionID(extracted_integer);
      }


    private void  fromJSONAdminBoost(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AdminBoost of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AdminBoost of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAdminBoost(extracted_integer);
      }


    private void  fromJSONVerifiedDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VerifiedDateTime of BigOvenRecipesRecipeJSON is not a string.");
        setVerifiedDateTime(json_string.getData());
      }


    private void  fromJSONMaxImageSquare(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MaxImageSquare of BigOvenRecipesRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MaxImageSquare of BigOvenRecipesRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMaxImageSquare(extracted_integer);
      }


    private void  fromJSONImageSquares(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ImageSquares of BigOvenRecipesRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_ImageSquares1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ImageSquares of BigOvenRecipesRecipeJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ImageSquares of BigOvenRecipesRecipeJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ImageSquares1.Add(extracted_integer);
          }
        initImageSquares();
        for (int num3 = 0; num3 < vector_ImageSquares1.Count; ++num3)
            appendImageSquares(vector_ImageSquares1[num3]);
        for (int num1 = 0; num1 < vector_ImageSquares1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPhotoUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhotoUrl of BigOvenRecipesRecipeJSON is not a string.");
        setPhotoUrl(json_string.getData());
      }


    private void  fromJSONVerifiedByClass(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VerifiedByClass of BigOvenRecipesRecipeJSON is not a string.");
        setVerifiedByClass(json_string.getData());
      }


    public BigOvenRecipesRecipeJSON()
      {
        flagHasRecipeID = false;
        flagHasTitle = false;
        flagHasDescription = false;
        flagHasCuisine = false;
        flagHasCategory = false;
        flagHasSubcategory = false;
        flagHasMicrocategory = false;
        flagHasPrimaryIngredient = false;
        flagHasStarRating = false;
        flagHasWebURL = false;
        flagHasImageURL = false;
        flagHasReviewCount = false;
        flagHasMedalCount = false;
        flagHasFavoriteCount = false;
        flagHasPoster = false;
        flagHasIngredients = false;
        flagHasSteps = false;
        flagHasInstructions = false;
        flagHasYieldNumber = false;
        flagHasYieldUnit = false;
        flagHasTotalMinutes = false;
        flagHasActiveMinutes = false;
        flagHasNutritionInfo = false;
        flagHasIsPrivate = false;
        flagHasCreationDate = false;
        flagHasLastModified = false;
        flagHasIsBookmark = false;
        flagHasBookmarkURL = false;
        flagHasBookmarkSiteLogo = false;
        flagHasBookmarkImageURL = false;
        flagHasIsRecipeScan = false;
        flagHasMenuCount = false;
        flagHasNotesCount = false;
        flagHasAdTags = false;
        flagHasIngredientsTextBlock = false;
        flagHasAllCategoriesText = false;
        flagHasIsSponsored = false;
        flagHasVariantOfRecipeID = false;
        flagHasCollection = false;
        flagHasCollectionID = false;
        flagHasAdminBoost = false;
        flagHasVerifiedDateTime = false;
        flagHasMaxImageSquare = false;
        flagHasImageSquares = false;
        flagHasPhotoUrl = false;
        flagHasVerifiedByClass = false;
        storeIngredients = new List< BigOvenRecipesIngredientJSON  >();
        storeSteps = new List< TypeStepsJSON  >();
        storeImageSquares = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRecipeID()
      {
        return flagHasRecipeID;
      }

    public BigInteger  getRecipeID()
      {
        Debug.Assert(flagHasRecipeID);
        return storeRecipeID;
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

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasCuisine()
      {
        return flagHasCuisine;
      }

    public string  getCuisine()
      {
        Debug.Assert(flagHasCuisine);
        return storeCuisine;
      }

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public string  getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
      }

    public bool  hasSubcategory()
      {
        return flagHasSubcategory;
      }

    public string  getSubcategory()
      {
        Debug.Assert(flagHasSubcategory);
        return storeSubcategory;
      }

    public bool  hasMicrocategory()
      {
        return flagHasMicrocategory;
      }

    public string  getMicrocategory()
      {
        Debug.Assert(flagHasMicrocategory);
        return storeMicrocategory;
      }

    public bool  hasPrimaryIngredient()
      {
        return flagHasPrimaryIngredient;
      }

    public string  getPrimaryIngredient()
      {
        Debug.Assert(flagHasPrimaryIngredient);
        return storePrimaryIngredient;
      }

    public bool  hasStarRating()
      {
        return flagHasStarRating;
      }

    public double  getStarRating()
      {
        Debug.Assert(flagHasStarRating);
        if (textStoreStarRating != "")
          {
            return Double.Parse(textStoreStarRating);
          }
        return storeStarRating;
      }

    public string  getStarRatingAsText()
      {
        Debug.Assert(flagHasStarRating);
        if (textStoreStarRating == "")
          {
            return Convert.ToString(storeStarRating);
          }
        else
          {
            return (textStoreStarRating);
          }
      }

    public bool  hasWebURL()
      {
        return flagHasWebURL;
      }

    public string  getWebURL()
      {
        Debug.Assert(flagHasWebURL);
        return storeWebURL;
      }

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
      }

    public bool  hasReviewCount()
      {
        return flagHasReviewCount;
      }

    public BigInteger  getReviewCount()
      {
        Debug.Assert(flagHasReviewCount);
        return storeReviewCount;
      }

    public bool  hasMedalCount()
      {
        return flagHasMedalCount;
      }

    public BigInteger  getMedalCount()
      {
        Debug.Assert(flagHasMedalCount);
        return storeMedalCount;
      }

    public bool  hasFavoriteCount()
      {
        return flagHasFavoriteCount;
      }

    public BigInteger  getFavoriteCount()
      {
        Debug.Assert(flagHasFavoriteCount);
        return storeFavoriteCount;
      }

    public bool  hasPoster()
      {
        return flagHasPoster;
      }

    public BigOvenRecipesPosterSingleRecipeJSON   getPoster()
      {
        Debug.Assert(flagHasPoster);
        return storePoster;
      }

    public bool  hasIngredients()
      {
        return flagHasIngredients;
      }

    public int  countOfIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients.Count;
      }

    public BigOvenRecipesIngredientJSON   elementOfIngredients(int element_num)
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients[element_num];
      }

    public List< BigOvenRecipesIngredientJSON  >  getIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients;
      }

    public bool  hasSteps()
      {
        return flagHasSteps;
      }

    public int  countOfSteps()
      {
        Debug.Assert(flagHasSteps);
        return storeSteps.Count;
      }

    public TypeStepsJSON   elementOfSteps(int element_num)
      {
        Debug.Assert(flagHasSteps);
        return storeSteps[element_num];
      }

    public List< TypeStepsJSON  >  getSteps()
      {
        Debug.Assert(flagHasSteps);
        return storeSteps;
      }

    public bool  hasInstructions()
      {
        return flagHasInstructions;
      }

    public string  getInstructions()
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions;
      }

    public bool  hasYieldNumber()
      {
        return flagHasYieldNumber;
      }

    public double  getYieldNumber()
      {
        Debug.Assert(flagHasYieldNumber);
        if (textStoreYieldNumber != "")
          {
            return Double.Parse(textStoreYieldNumber);
          }
        return storeYieldNumber;
      }

    public string  getYieldNumberAsText()
      {
        Debug.Assert(flagHasYieldNumber);
        if (textStoreYieldNumber == "")
          {
            return Convert.ToString(storeYieldNumber);
          }
        else
          {
            return (textStoreYieldNumber);
          }
      }

    public bool  hasYieldUnit()
      {
        return flagHasYieldUnit;
      }

    public string  getYieldUnit()
      {
        Debug.Assert(flagHasYieldUnit);
        return storeYieldUnit;
      }

    public bool  hasTotalMinutes()
      {
        return flagHasTotalMinutes;
      }

    public BigInteger  getTotalMinutes()
      {
        Debug.Assert(flagHasTotalMinutes);
        return storeTotalMinutes;
      }

    public bool  hasActiveMinutes()
      {
        return flagHasActiveMinutes;
      }

    public BigInteger  getActiveMinutes()
      {
        Debug.Assert(flagHasActiveMinutes);
        return storeActiveMinutes;
      }

    public bool  hasNutritionInfo()
      {
        return flagHasNutritionInfo;
      }

    public BigOvenRecipesNutritionInfoJSON   getNutritionInfo()
      {
        Debug.Assert(flagHasNutritionInfo);
        return storeNutritionInfo;
      }

    public bool  hasIsPrivate()
      {
        return flagHasIsPrivate;
      }

    public bool  getIsPrivate()
      {
        Debug.Assert(flagHasIsPrivate);
        return storeIsPrivate;
      }

    public bool  hasCreationDate()
      {
        return flagHasCreationDate;
      }

    public string  getCreationDate()
      {
        Debug.Assert(flagHasCreationDate);
        return storeCreationDate;
      }

    public bool  hasLastModified()
      {
        return flagHasLastModified;
      }

    public string  getLastModified()
      {
        Debug.Assert(flagHasLastModified);
        return storeLastModified;
      }

    public bool  hasIsBookmark()
      {
        return flagHasIsBookmark;
      }

    public bool  getIsBookmark()
      {
        Debug.Assert(flagHasIsBookmark);
        return storeIsBookmark;
      }

    public bool  hasBookmarkURL()
      {
        return flagHasBookmarkURL;
      }

    public string  getBookmarkURL()
      {
        Debug.Assert(flagHasBookmarkURL);
        return storeBookmarkURL;
      }

    public bool  hasBookmarkSiteLogo()
      {
        return flagHasBookmarkSiteLogo;
      }

    public string  getBookmarkSiteLogo()
      {
        Debug.Assert(flagHasBookmarkSiteLogo);
        return storeBookmarkSiteLogo;
      }

    public bool  hasBookmarkImageURL()
      {
        return flagHasBookmarkImageURL;
      }

    public string  getBookmarkImageURL()
      {
        Debug.Assert(flagHasBookmarkImageURL);
        return storeBookmarkImageURL;
      }

    public bool  hasIsRecipeScan()
      {
        return flagHasIsRecipeScan;
      }

    public bool  getIsRecipeScan()
      {
        Debug.Assert(flagHasIsRecipeScan);
        return storeIsRecipeScan;
      }

    public bool  hasMenuCount()
      {
        return flagHasMenuCount;
      }

    public BigInteger  getMenuCount()
      {
        Debug.Assert(flagHasMenuCount);
        return storeMenuCount;
      }

    public bool  hasNotesCount()
      {
        return flagHasNotesCount;
      }

    public BigInteger  getNotesCount()
      {
        Debug.Assert(flagHasNotesCount);
        return storeNotesCount;
      }

    public bool  hasAdTags()
      {
        return flagHasAdTags;
      }

    public string  getAdTags()
      {
        Debug.Assert(flagHasAdTags);
        return storeAdTags;
      }

    public bool  hasIngredientsTextBlock()
      {
        return flagHasIngredientsTextBlock;
      }

    public string  getIngredientsTextBlock()
      {
        Debug.Assert(flagHasIngredientsTextBlock);
        return storeIngredientsTextBlock;
      }

    public bool  hasAllCategoriesText()
      {
        return flagHasAllCategoriesText;
      }

    public string  getAllCategoriesText()
      {
        Debug.Assert(flagHasAllCategoriesText);
        return storeAllCategoriesText;
      }

    public bool  hasIsSponsored()
      {
        return flagHasIsSponsored;
      }

    public bool  getIsSponsored()
      {
        Debug.Assert(flagHasIsSponsored);
        return storeIsSponsored;
      }

    public bool  hasVariantOfRecipeID()
      {
        return flagHasVariantOfRecipeID;
      }

    public BigInteger  getVariantOfRecipeID()
      {
        Debug.Assert(flagHasVariantOfRecipeID);
        return storeVariantOfRecipeID;
      }

    public bool  hasCollection()
      {
        return flagHasCollection;
      }

    public string  getCollection()
      {
        Debug.Assert(flagHasCollection);
        return storeCollection;
      }

    public bool  hasCollectionID()
      {
        return flagHasCollectionID;
      }

    public BigInteger  getCollectionID()
      {
        Debug.Assert(flagHasCollectionID);
        return storeCollectionID;
      }

    public bool  hasAdminBoost()
      {
        return flagHasAdminBoost;
      }

    public BigInteger  getAdminBoost()
      {
        Debug.Assert(flagHasAdminBoost);
        return storeAdminBoost;
      }

    public bool  hasVerifiedDateTime()
      {
        return flagHasVerifiedDateTime;
      }

    public string  getVerifiedDateTime()
      {
        Debug.Assert(flagHasVerifiedDateTime);
        return storeVerifiedDateTime;
      }

    public bool  hasMaxImageSquare()
      {
        return flagHasMaxImageSquare;
      }

    public BigInteger  getMaxImageSquare()
      {
        Debug.Assert(flagHasMaxImageSquare);
        return storeMaxImageSquare;
      }

    public bool  hasImageSquares()
      {
        return flagHasImageSquares;
      }

    public int  countOfImageSquares()
      {
        Debug.Assert(flagHasImageSquares);
        return storeImageSquares.Count;
      }

    public BigInteger  elementOfImageSquares(int element_num)
      {
        Debug.Assert(flagHasImageSquares);
        return storeImageSquares[element_num];
      }

    public List< BigInteger >  getImageSquares()
      {
        Debug.Assert(flagHasImageSquares);
        return storeImageSquares;
      }

    public bool  hasPhotoUrl()
      {
        return flagHasPhotoUrl;
      }

    public string  getPhotoUrl()
      {
        Debug.Assert(flagHasPhotoUrl);
        return storePhotoUrl;
      }

    public bool  hasVerifiedByClass()
      {
        return flagHasVerifiedByClass;
      }

    public string  getVerifiedByClass()
      {
        Debug.Assert(flagHasVerifiedByClass);
        return storeVerifiedByClass;
      }


    public virtual int extraBigOvenRecipesRecipeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBigOvenRecipesRecipeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesRecipeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesRecipeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRecipeID(BigInteger new_value)
      {
        flagHasRecipeID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecipeID of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeRecipeID = new_value;
      }
    public void unsetRecipeID()
      {
        flagHasRecipeID = false;
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
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setCuisine(string new_value)
      {
        flagHasCuisine = true;
        storeCuisine = new_value;
      }
    public void unsetCuisine()
      {
        flagHasCuisine = false;
      }
    public void setCategory(string new_value)
      {
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void unsetCategory()
      {
        flagHasCategory = false;
      }
    public void setSubcategory(string new_value)
      {
        flagHasSubcategory = true;
        storeSubcategory = new_value;
      }
    public void unsetSubcategory()
      {
        flagHasSubcategory = false;
      }
    public void setMicrocategory(string new_value)
      {
        flagHasMicrocategory = true;
        storeMicrocategory = new_value;
      }
    public void unsetMicrocategory()
      {
        flagHasMicrocategory = false;
      }
    public void setPrimaryIngredient(string new_value)
      {
        flagHasPrimaryIngredient = true;
        storePrimaryIngredient = new_value;
      }
    public void unsetPrimaryIngredient()
      {
        flagHasPrimaryIngredient = false;
      }
    public void setStarRating(double new_value)
      {
        flagHasStarRating = true;
        storeStarRating = new_value;
        textStoreStarRating = "";
      }
    public void setStarRatingText(string new_value)
      {
        flagHasStarRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRating of BigOvenRecipesRecipeJSON is not a valid number.");
        textStoreStarRating = new_value;
      }
    public void unsetStarRating()
      {
        flagHasStarRating = false;
      }
    public void setWebURL(string new_value)
      {
        flagHasWebURL = true;
        storeWebURL = new_value;
      }
    public void unsetWebURL()
      {
        flagHasWebURL = false;
      }
    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
      }
    public void setReviewCount(BigInteger new_value)
      {
        flagHasReviewCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCount of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeReviewCount = new_value;
      }
    public void unsetReviewCount()
      {
        flagHasReviewCount = false;
      }
    public void setMedalCount(BigInteger new_value)
      {
        flagHasMedalCount = true;
        if (new_value < 0)
            throw new Exception("The value for field MedalCount of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeMedalCount = new_value;
      }
    public void unsetMedalCount()
      {
        flagHasMedalCount = false;
      }
    public void setFavoriteCount(BigInteger new_value)
      {
        flagHasFavoriteCount = true;
        if (new_value < 0)
            throw new Exception("The value for field FavoriteCount of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeFavoriteCount = new_value;
      }
    public void unsetFavoriteCount()
      {
        flagHasFavoriteCount = false;
      }
    public void setPoster(BigOvenRecipesPosterSingleRecipeJSON  new_value)
      {
        if (flagHasPoster)
          {
          }
        flagHasPoster = true;
        storePoster = new_value;
      }
    public void unsetPoster()
      {
        if (flagHasPoster)
          {
          }
        flagHasPoster = false;
      }
    public void initIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
              }
          }
        flagHasIngredients = true;
        storeIngredients.Clear();
      }
    public void appendIngredients(BigOvenRecipesIngredientJSON  to_append)
      {
        if (!flagHasIngredients)
          {
            flagHasIngredients = true;
            storeIngredients.Clear();
          }
        Debug.Assert(flagHasIngredients);
        storeIngredients.Add(to_append);
      }
    public void unsetIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num2 = 0; num2 < storeIngredients.Count; ++num2)
              {
              }
          }
        flagHasIngredients = false;
        storeIngredients.Clear();
      }
    public void initSteps()
      {
        if (flagHasSteps)
          {
            for (int num3 = 0; num3 < storeSteps.Count; ++num3)
              {
              }
          }
        flagHasSteps = true;
        storeSteps.Clear();
      }
    public void appendSteps(TypeStepsJSON  to_append)
      {
        if (!flagHasSteps)
          {
            flagHasSteps = true;
            storeSteps.Clear();
          }
        Debug.Assert(flagHasSteps);
        storeSteps.Add(to_append);
      }
    public void unsetSteps()
      {
        if (flagHasSteps)
          {
            for (int num4 = 0; num4 < storeSteps.Count; ++num4)
              {
              }
          }
        flagHasSteps = false;
        storeSteps.Clear();
      }
    public void setInstructions(string new_value)
      {
        flagHasInstructions = true;
        storeInstructions = new_value;
      }
    public void unsetInstructions()
      {
        flagHasInstructions = false;
      }
    public void setYieldNumber(double new_value)
      {
        flagHasYieldNumber = true;
        storeYieldNumber = new_value;
        textStoreYieldNumber = "";
      }
    public void setYieldNumberText(string new_value)
      {
        flagHasYieldNumber = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field YieldNumber of BigOvenRecipesRecipeJSON is not a valid number.");
        textStoreYieldNumber = new_value;
      }
    public void unsetYieldNumber()
      {
        flagHasYieldNumber = false;
      }
    public void setYieldUnit(string new_value)
      {
        flagHasYieldUnit = true;
        storeYieldUnit = new_value;
      }
    public void unsetYieldUnit()
      {
        flagHasYieldUnit = false;
      }
    public void setTotalMinutes(BigInteger new_value)
      {
        flagHasTotalMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalMinutes of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeTotalMinutes = new_value;
      }
    public void unsetTotalMinutes()
      {
        flagHasTotalMinutes = false;
      }
    public void setActiveMinutes(BigInteger new_value)
      {
        flagHasActiveMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field ActiveMinutes of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeActiveMinutes = new_value;
      }
    public void unsetActiveMinutes()
      {
        flagHasActiveMinutes = false;
      }
    public void setNutritionInfo(BigOvenRecipesNutritionInfoJSON  new_value)
      {
        if (flagHasNutritionInfo)
          {
          }
        flagHasNutritionInfo = true;
        storeNutritionInfo = new_value;
      }
    public void unsetNutritionInfo()
      {
        if (flagHasNutritionInfo)
          {
          }
        flagHasNutritionInfo = false;
      }
    public void setIsPrivate(bool new_value)
      {
        flagHasIsPrivate = true;
        storeIsPrivate = new_value;
      }
    public void unsetIsPrivate()
      {
        flagHasIsPrivate = false;
      }
    public void setCreationDate(string new_value)
      {
        flagHasCreationDate = true;
        storeCreationDate = new_value;
      }
    public void unsetCreationDate()
      {
        flagHasCreationDate = false;
      }
    public void setLastModified(string new_value)
      {
        flagHasLastModified = true;
        storeLastModified = new_value;
      }
    public void unsetLastModified()
      {
        flagHasLastModified = false;
      }
    public void setIsBookmark(bool new_value)
      {
        flagHasIsBookmark = true;
        storeIsBookmark = new_value;
      }
    public void unsetIsBookmark()
      {
        flagHasIsBookmark = false;
      }
    public void setBookmarkURL(string new_value)
      {
        flagHasBookmarkURL = true;
        storeBookmarkURL = new_value;
      }
    public void unsetBookmarkURL()
      {
        flagHasBookmarkURL = false;
      }
    public void setBookmarkSiteLogo(string new_value)
      {
        flagHasBookmarkSiteLogo = true;
        storeBookmarkSiteLogo = new_value;
      }
    public void unsetBookmarkSiteLogo()
      {
        flagHasBookmarkSiteLogo = false;
      }
    public void setBookmarkImageURL(string new_value)
      {
        flagHasBookmarkImageURL = true;
        storeBookmarkImageURL = new_value;
      }
    public void unsetBookmarkImageURL()
      {
        flagHasBookmarkImageURL = false;
      }
    public void setIsRecipeScan(bool new_value)
      {
        flagHasIsRecipeScan = true;
        storeIsRecipeScan = new_value;
      }
    public void unsetIsRecipeScan()
      {
        flagHasIsRecipeScan = false;
      }
    public void setMenuCount(BigInteger new_value)
      {
        flagHasMenuCount = true;
        if (new_value < 0)
            throw new Exception("The value for field MenuCount of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeMenuCount = new_value;
      }
    public void unsetMenuCount()
      {
        flagHasMenuCount = false;
      }
    public void setNotesCount(BigInteger new_value)
      {
        flagHasNotesCount = true;
        if (new_value < 0)
            throw new Exception("The value for field NotesCount of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeNotesCount = new_value;
      }
    public void unsetNotesCount()
      {
        flagHasNotesCount = false;
      }
    public void setAdTags(string new_value)
      {
        flagHasAdTags = true;
        storeAdTags = new_value;
      }
    public void unsetAdTags()
      {
        flagHasAdTags = false;
      }
    public void setIngredientsTextBlock(string new_value)
      {
        flagHasIngredientsTextBlock = true;
        storeIngredientsTextBlock = new_value;
      }
    public void unsetIngredientsTextBlock()
      {
        flagHasIngredientsTextBlock = false;
      }
    public void setAllCategoriesText(string new_value)
      {
        flagHasAllCategoriesText = true;
        storeAllCategoriesText = new_value;
      }
    public void unsetAllCategoriesText()
      {
        flagHasAllCategoriesText = false;
      }
    public void setIsSponsored(bool new_value)
      {
        flagHasIsSponsored = true;
        storeIsSponsored = new_value;
      }
    public void unsetIsSponsored()
      {
        flagHasIsSponsored = false;
      }
    public void setVariantOfRecipeID(BigInteger new_value)
      {
        flagHasVariantOfRecipeID = true;
        if (new_value < 0)
            throw new Exception("The value for field VariantOfRecipeID of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeVariantOfRecipeID = new_value;
      }
    public void unsetVariantOfRecipeID()
      {
        flagHasVariantOfRecipeID = false;
      }
    public void setCollection(string new_value)
      {
        flagHasCollection = true;
        storeCollection = new_value;
      }
    public void unsetCollection()
      {
        flagHasCollection = false;
      }
    public void setCollectionID(BigInteger new_value)
      {
        flagHasCollectionID = true;
        if (new_value < 0)
            throw new Exception("The value for field CollectionID of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeCollectionID = new_value;
      }
    public void unsetCollectionID()
      {
        flagHasCollectionID = false;
      }
    public void setAdminBoost(BigInteger new_value)
      {
        flagHasAdminBoost = true;
        storeAdminBoost = new_value;
      }
    public void unsetAdminBoost()
      {
        flagHasAdminBoost = false;
      }
    public void setVerifiedDateTime(string new_value)
      {
        flagHasVerifiedDateTime = true;
        storeVerifiedDateTime = new_value;
      }
    public void unsetVerifiedDateTime()
      {
        flagHasVerifiedDateTime = false;
      }
    public void setMaxImageSquare(BigInteger new_value)
      {
        flagHasMaxImageSquare = true;
        if (new_value < 0)
            throw new Exception("The value for field MaxImageSquare of BigOvenRecipesRecipeJSON is less than the lower bound (0) for that field.");
        storeMaxImageSquare = new_value;
      }
    public void unsetMaxImageSquare()
      {
        flagHasMaxImageSquare = false;
      }
    public void initImageSquares()
      {
        flagHasImageSquares = true;
        storeImageSquares.Clear();
      }
    public void appendImageSquares(BigInteger to_append)
      {
        if (!flagHasImageSquares)
          {
            flagHasImageSquares = true;
            storeImageSquares.Clear();
          }
        Debug.Assert(flagHasImageSquares);
        storeImageSquares.Add(to_append);
      }
    public void unsetImageSquares()
      {
        flagHasImageSquares = false;
        storeImageSquares.Clear();
      }
    public void setPhotoUrl(string new_value)
      {
        flagHasPhotoUrl = true;
        storePhotoUrl = new_value;
      }
    public void unsetPhotoUrl()
      {
        flagHasPhotoUrl = false;
      }
    public void setVerifiedByClass(string new_value)
      {
        flagHasVerifiedByClass = true;
        storeVerifiedByClass = new_value;
      }
    public void unsetVerifiedByClass()
      {
        flagHasVerifiedByClass = false;
      }

    public virtual void extraBigOvenRecipesRecipeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBigOvenRecipesRecipeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBigOvenRecipesRecipeLookup(key);
        if (old_field == null)
          {
            extraBigOvenRecipesRecipeAppendPair(key, new_component);
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
        if (flagHasRecipeID)
          {
            handler.start_pair("RecipeID");
            handler.number_value(storeRecipeID);
          }
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasCuisine)
          {
            handler.start_pair("Cuisine");
            handler.string_value(storeCuisine);
          }
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            handler.string_value(storeCategory);
          }
        if (flagHasSubcategory)
          {
            handler.start_pair("Subcategory");
            handler.string_value(storeSubcategory);
          }
        if (flagHasMicrocategory)
          {
            handler.start_pair("Microcategory");
            handler.string_value(storeMicrocategory);
          }
        if (flagHasPrimaryIngredient)
          {
            handler.start_pair("PrimaryIngredient");
            handler.string_value(storePrimaryIngredient);
          }
        if (flagHasStarRating)
          {
            handler.start_pair("StarRating");
            if (textStoreStarRating != "")
                handler.number_value(textStoreStarRating);
            else if (((double)(long)storeStarRating) == storeStarRating)
                handler.number_value((long)storeStarRating);
            else
                handler.number_value(storeStarRating);
          }
        if (flagHasWebURL)
          {
            handler.start_pair("WebURL");
            handler.string_value(storeWebURL);
          }
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
          }
        if (flagHasReviewCount)
          {
            handler.start_pair("ReviewCount");
            handler.number_value(storeReviewCount);
          }
        if (flagHasMedalCount)
          {
            handler.start_pair("MedalCount");
            handler.number_value(storeMedalCount);
          }
        if (flagHasFavoriteCount)
          {
            handler.start_pair("FavoriteCount");
            handler.number_value(storeFavoriteCount);
          }
        if (flagHasPoster)
          {
            handler.start_pair("Poster");
            if (partial_allowed)
                storePoster.write_partial_as_json(handler);
            else
                storePoster.write_as_json(handler);
          }
        if (flagHasIngredients)
          {
            handler.start_pair("Ingredients");
            handler.start_array();
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
                if (partial_allowed)
                    storeIngredients[num1].write_partial_as_json(handler);
                else
                    storeIngredients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSteps)
          {
            handler.start_pair("Steps");
            handler.start_array();
            for (int num2 = 0; num2 < storeSteps.Count; ++num2)
              {
                if (partial_allowed)
                    storeSteps[num2].write_partial_as_json(handler);
                else
                    storeSteps[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInstructions)
          {
            handler.start_pair("Instructions");
            handler.string_value(storeInstructions);
          }
        if (flagHasYieldNumber)
          {
            handler.start_pair("YieldNumber");
            if (textStoreYieldNumber != "")
                handler.number_value(textStoreYieldNumber);
            else if (((double)(long)storeYieldNumber) == storeYieldNumber)
                handler.number_value((long)storeYieldNumber);
            else
                handler.number_value(storeYieldNumber);
          }
        if (flagHasYieldUnit)
          {
            handler.start_pair("YieldUnit");
            handler.string_value(storeYieldUnit);
          }
        if (flagHasTotalMinutes)
          {
            handler.start_pair("TotalMinutes");
            handler.number_value(storeTotalMinutes);
          }
        if (flagHasActiveMinutes)
          {
            handler.start_pair("ActiveMinutes");
            handler.number_value(storeActiveMinutes);
          }
        if (flagHasNutritionInfo)
          {
            handler.start_pair("NutritionInfo");
            if (partial_allowed)
                storeNutritionInfo.write_partial_as_json(handler);
            else
                storeNutritionInfo.write_as_json(handler);
          }
        if (flagHasIsPrivate)
          {
            handler.start_pair("IsPrivate");
            handler.boolean_value(storeIsPrivate);
          }
        if (flagHasCreationDate)
          {
            handler.start_pair("CreationDate");
            handler.string_value(storeCreationDate);
          }
        if (flagHasLastModified)
          {
            handler.start_pair("LastModified");
            handler.string_value(storeLastModified);
          }
        if (flagHasIsBookmark)
          {
            handler.start_pair("IsBookmark");
            handler.boolean_value(storeIsBookmark);
          }
        if (flagHasBookmarkURL)
          {
            handler.start_pair("BookmarkURL");
            handler.string_value(storeBookmarkURL);
          }
        if (flagHasBookmarkSiteLogo)
          {
            handler.start_pair("BookmarkSiteLogo");
            handler.string_value(storeBookmarkSiteLogo);
          }
        if (flagHasBookmarkImageURL)
          {
            handler.start_pair("BookmarkImageURL");
            handler.string_value(storeBookmarkImageURL);
          }
        if (flagHasIsRecipeScan)
          {
            handler.start_pair("IsRecipeScan");
            handler.boolean_value(storeIsRecipeScan);
          }
        if (flagHasMenuCount)
          {
            handler.start_pair("MenuCount");
            handler.number_value(storeMenuCount);
          }
        if (flagHasNotesCount)
          {
            handler.start_pair("NotesCount");
            handler.number_value(storeNotesCount);
          }
        if (flagHasAdTags)
          {
            handler.start_pair("AdTags");
            handler.string_value(storeAdTags);
          }
        if (flagHasIngredientsTextBlock)
          {
            handler.start_pair("IngredientsTextBlock");
            handler.string_value(storeIngredientsTextBlock);
          }
        if (flagHasAllCategoriesText)
          {
            handler.start_pair("AllCategoriesText");
            handler.string_value(storeAllCategoriesText);
          }
        if (flagHasIsSponsored)
          {
            handler.start_pair("IsSponsored");
            handler.boolean_value(storeIsSponsored);
          }
        if (flagHasVariantOfRecipeID)
          {
            handler.start_pair("VariantOfRecipeID");
            handler.number_value(storeVariantOfRecipeID);
          }
        if (flagHasCollection)
          {
            handler.start_pair("Collection");
            handler.string_value(storeCollection);
          }
        if (flagHasCollectionID)
          {
            handler.start_pair("CollectionID");
            handler.number_value(storeCollectionID);
          }
        if (flagHasAdminBoost)
          {
            handler.start_pair("AdminBoost");
            handler.number_value(storeAdminBoost);
          }
        if (flagHasVerifiedDateTime)
          {
            handler.start_pair("VerifiedDateTime");
            handler.string_value(storeVerifiedDateTime);
          }
        if (flagHasMaxImageSquare)
          {
            handler.start_pair("MaxImageSquare");
            handler.number_value(storeMaxImageSquare);
          }
        if (flagHasImageSquares)
          {
            handler.start_pair("ImageSquares");
            handler.start_array();
            for (int num3 = 0; num3 < storeImageSquares.Count; ++num3)
              {
                handler.number_value(storeImageSquares[num3]);
              }
            handler.finish_array();
          }
        if (flagHasPhotoUrl)
          {
            handler.start_pair("PhotoUrl");
            handler.string_value(storePhotoUrl);
          }
        if (flagHasVerifiedByClass)
          {
            handler.start_pair("VerifiedByClass");
            handler.string_value(storeVerifiedByClass);
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

    public static BigOvenRecipesRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesRecipe", ignore_extras);
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
    public static BigOvenRecipesRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesRecipe", ignore_extras);
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
    public static BigOvenRecipesRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesRecipeJSON from_text(string text, bool ignore_extras)
      {
        BigOvenRecipesRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesRecipe", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BigOvenRecipesRecipeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BigOvenRecipesRecipeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BigOvenRecipesRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesRecipe", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorRecipeID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRecipeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorRecipeID fieldGeneratorRecipeID;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorCuisine;
        private JSONHoldingStringGenerator fieldGeneratorCategory;
        private JSONHoldingStringGenerator fieldGeneratorSubcategory;
        private JSONHoldingStringGenerator fieldGeneratorMicrocategory;
        private JSONHoldingStringGenerator fieldGeneratorPrimaryIngredient;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRating;
        private JSONHoldingStringGenerator fieldGeneratorWebURL;
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
    private class FieldHoldingGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorReviewCount fieldGeneratorReviewCount;
    private class FieldHoldingGeneratorMedalCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMedalCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMedalCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMedalCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMedalCount fieldGeneratorMedalCount;
    private class FieldHoldingGeneratorFavoriteCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFavoriteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFavoriteCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFavoriteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFavoriteCount fieldGeneratorFavoriteCount;
        private BigOvenRecipesPosterSingleRecipeJSON.HoldingGenerator fieldGeneratorPoster;
        private BigOvenRecipesIngredientJSON.HoldingArrayGenerator fieldGeneratorIngredients;
        private TypeStepsJSON.HoldingArrayGenerator fieldGeneratorSteps;
        private JSONHoldingStringGenerator fieldGeneratorInstructions;
        private JSONHoldingNumberTextGenerator fieldGeneratorYieldNumber;
        private JSONHoldingStringGenerator fieldGeneratorYieldUnit;
    private class FieldHoldingGeneratorTotalMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalMinutes fieldGeneratorTotalMinutes;
    private class FieldHoldingGeneratorActiveMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorActiveMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorActiveMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorActiveMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorActiveMinutes fieldGeneratorActiveMinutes;
        private BigOvenRecipesNutritionInfoJSON.HoldingGenerator fieldGeneratorNutritionInfo;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPrivate;
        private JSONHoldingStringGenerator fieldGeneratorCreationDate;
        private JSONHoldingStringGenerator fieldGeneratorLastModified;
        private JSONHoldingBooleanGenerator fieldGeneratorIsBookmark;
        private JSONHoldingStringGenerator fieldGeneratorBookmarkURL;
        private JSONHoldingStringGenerator fieldGeneratorBookmarkSiteLogo;
        private JSONHoldingStringGenerator fieldGeneratorBookmarkImageURL;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecipeScan;
    private class FieldHoldingGeneratorMenuCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMenuCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMenuCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMenuCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMenuCount fieldGeneratorMenuCount;
    private class FieldHoldingGeneratorNotesCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNotesCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNotesCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNotesCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNotesCount fieldGeneratorNotesCount;
        private JSONHoldingStringGenerator fieldGeneratorAdTags;
        private JSONHoldingStringGenerator fieldGeneratorIngredientsTextBlock;
        private JSONHoldingStringGenerator fieldGeneratorAllCategoriesText;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSponsored;
    private class FieldHoldingGeneratorVariantOfRecipeID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorVariantOfRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorVariantOfRecipeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorVariantOfRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorVariantOfRecipeID fieldGeneratorVariantOfRecipeID;
        private JSONHoldingStringGenerator fieldGeneratorCollection;
    private class FieldHoldingGeneratorCollectionID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCollectionID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCollectionID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCollectionID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCollectionID fieldGeneratorCollectionID;
    private class FieldHoldingGeneratorAdminBoost : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAdminBoost(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAdminBoost : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAdminBoost(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAdminBoost fieldGeneratorAdminBoost;
        private JSONHoldingStringGenerator fieldGeneratorVerifiedDateTime;
    private class FieldHoldingGeneratorMaxImageSquare : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMaxImageSquare(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMaxImageSquare : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMaxImageSquare(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMaxImageSquare fieldGeneratorMaxImageSquare;
    private class FieldHoldingGeneratorImageSquares : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorImageSquares(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorImageSquares : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorImageSquares(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorImageSquares fieldGeneratorImageSquares;
        private JSONHoldingStringGenerator fieldGeneratorPhotoUrl;
        private JSONHoldingStringGenerator fieldGeneratorVerifiedByClass;
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
            BigOvenRecipesRecipeJSON result = new BigOvenRecipesRecipeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBigOvenRecipesRecipeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BigOvenRecipesRecipeJSON result)
          {
            if (fieldGeneratorRecipeID.have_value)
              {
                result.setRecipeID(fieldGeneratorRecipeID.value);
                fieldGeneratorRecipeID.have_value = false;
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorCuisine.have_value)
              {
                result.setCuisine(fieldGeneratorCuisine.value);
                fieldGeneratorCuisine.have_value = false;
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            if (fieldGeneratorSubcategory.have_value)
              {
                result.setSubcategory(fieldGeneratorSubcategory.value);
                fieldGeneratorSubcategory.have_value = false;
              }
            if (fieldGeneratorMicrocategory.have_value)
              {
                result.setMicrocategory(fieldGeneratorMicrocategory.value);
                fieldGeneratorMicrocategory.have_value = false;
              }
            if (fieldGeneratorPrimaryIngredient.have_value)
              {
                result.setPrimaryIngredient(fieldGeneratorPrimaryIngredient.value);
                fieldGeneratorPrimaryIngredient.have_value = false;
              }
            if (fieldGeneratorStarRating.have_value)
              {
                result.setStarRatingText(fieldGeneratorStarRating.value);
                fieldGeneratorStarRating.have_value = false;
              }
            if (fieldGeneratorWebURL.have_value)
              {
                result.setWebURL(fieldGeneratorWebURL.value);
                fieldGeneratorWebURL.have_value = false;
              }
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
            if (fieldGeneratorReviewCount.have_value)
              {
                result.setReviewCount(fieldGeneratorReviewCount.value);
                fieldGeneratorReviewCount.have_value = false;
              }
            if (fieldGeneratorMedalCount.have_value)
              {
                result.setMedalCount(fieldGeneratorMedalCount.value);
                fieldGeneratorMedalCount.have_value = false;
              }
            if (fieldGeneratorFavoriteCount.have_value)
              {
                result.setFavoriteCount(fieldGeneratorFavoriteCount.value);
                fieldGeneratorFavoriteCount.have_value = false;
              }
            if (fieldGeneratorPoster.have_value)
              {
                result.setPoster(fieldGeneratorPoster.value);
                fieldGeneratorPoster.have_value = false;
              }
            if (fieldGeneratorIngredients.have_value)
              {
                result.initIngredients();
                int count = fieldGeneratorIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIngredients(fieldGeneratorIngredients.value[num]);
                  }
                fieldGeneratorIngredients.value.Clear();
                fieldGeneratorIngredients.have_value = false;
              }
            if (fieldGeneratorSteps.have_value)
              {
                result.initSteps();
                int count = fieldGeneratorSteps.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSteps(fieldGeneratorSteps.value[num]);
                  }
                fieldGeneratorSteps.value.Clear();
                fieldGeneratorSteps.have_value = false;
              }
            if (fieldGeneratorInstructions.have_value)
              {
                result.setInstructions(fieldGeneratorInstructions.value);
                fieldGeneratorInstructions.have_value = false;
              }
            if (fieldGeneratorYieldNumber.have_value)
              {
                result.setYieldNumberText(fieldGeneratorYieldNumber.value);
                fieldGeneratorYieldNumber.have_value = false;
              }
            if (fieldGeneratorYieldUnit.have_value)
              {
                result.setYieldUnit(fieldGeneratorYieldUnit.value);
                fieldGeneratorYieldUnit.have_value = false;
              }
            if (fieldGeneratorTotalMinutes.have_value)
              {
                result.setTotalMinutes(fieldGeneratorTotalMinutes.value);
                fieldGeneratorTotalMinutes.have_value = false;
              }
            if (fieldGeneratorActiveMinutes.have_value)
              {
                result.setActiveMinutes(fieldGeneratorActiveMinutes.value);
                fieldGeneratorActiveMinutes.have_value = false;
              }
            if (fieldGeneratorNutritionInfo.have_value)
              {
                result.setNutritionInfo(fieldGeneratorNutritionInfo.value);
                fieldGeneratorNutritionInfo.have_value = false;
              }
            if (fieldGeneratorIsPrivate.have_value)
              {
                result.setIsPrivate(fieldGeneratorIsPrivate.value);
                fieldGeneratorIsPrivate.have_value = false;
              }
            if (fieldGeneratorCreationDate.have_value)
              {
                result.setCreationDate(fieldGeneratorCreationDate.value);
                fieldGeneratorCreationDate.have_value = false;
              }
            if (fieldGeneratorLastModified.have_value)
              {
                result.setLastModified(fieldGeneratorLastModified.value);
                fieldGeneratorLastModified.have_value = false;
              }
            if (fieldGeneratorIsBookmark.have_value)
              {
                result.setIsBookmark(fieldGeneratorIsBookmark.value);
                fieldGeneratorIsBookmark.have_value = false;
              }
            if (fieldGeneratorBookmarkURL.have_value)
              {
                result.setBookmarkURL(fieldGeneratorBookmarkURL.value);
                fieldGeneratorBookmarkURL.have_value = false;
              }
            if (fieldGeneratorBookmarkSiteLogo.have_value)
              {
                result.setBookmarkSiteLogo(fieldGeneratorBookmarkSiteLogo.value);
                fieldGeneratorBookmarkSiteLogo.have_value = false;
              }
            if (fieldGeneratorBookmarkImageURL.have_value)
              {
                result.setBookmarkImageURL(fieldGeneratorBookmarkImageURL.value);
                fieldGeneratorBookmarkImageURL.have_value = false;
              }
            if (fieldGeneratorIsRecipeScan.have_value)
              {
                result.setIsRecipeScan(fieldGeneratorIsRecipeScan.value);
                fieldGeneratorIsRecipeScan.have_value = false;
              }
            if (fieldGeneratorMenuCount.have_value)
              {
                result.setMenuCount(fieldGeneratorMenuCount.value);
                fieldGeneratorMenuCount.have_value = false;
              }
            if (fieldGeneratorNotesCount.have_value)
              {
                result.setNotesCount(fieldGeneratorNotesCount.value);
                fieldGeneratorNotesCount.have_value = false;
              }
            if (fieldGeneratorAdTags.have_value)
              {
                result.setAdTags(fieldGeneratorAdTags.value);
                fieldGeneratorAdTags.have_value = false;
              }
            if (fieldGeneratorIngredientsTextBlock.have_value)
              {
                result.setIngredientsTextBlock(fieldGeneratorIngredientsTextBlock.value);
                fieldGeneratorIngredientsTextBlock.have_value = false;
              }
            if (fieldGeneratorAllCategoriesText.have_value)
              {
                result.setAllCategoriesText(fieldGeneratorAllCategoriesText.value);
                fieldGeneratorAllCategoriesText.have_value = false;
              }
            if (fieldGeneratorIsSponsored.have_value)
              {
                result.setIsSponsored(fieldGeneratorIsSponsored.value);
                fieldGeneratorIsSponsored.have_value = false;
              }
            if (fieldGeneratorVariantOfRecipeID.have_value)
              {
                result.setVariantOfRecipeID(fieldGeneratorVariantOfRecipeID.value);
                fieldGeneratorVariantOfRecipeID.have_value = false;
              }
            if (fieldGeneratorCollection.have_value)
              {
                result.setCollection(fieldGeneratorCollection.value);
                fieldGeneratorCollection.have_value = false;
              }
            if (fieldGeneratorCollectionID.have_value)
              {
                result.setCollectionID(fieldGeneratorCollectionID.value);
                fieldGeneratorCollectionID.have_value = false;
              }
            if (fieldGeneratorAdminBoost.have_value)
              {
                result.setAdminBoost(fieldGeneratorAdminBoost.value);
                fieldGeneratorAdminBoost.have_value = false;
              }
            if (fieldGeneratorVerifiedDateTime.have_value)
              {
                result.setVerifiedDateTime(fieldGeneratorVerifiedDateTime.value);
                fieldGeneratorVerifiedDateTime.have_value = false;
              }
            if (fieldGeneratorMaxImageSquare.have_value)
              {
                result.setMaxImageSquare(fieldGeneratorMaxImageSquare.value);
                fieldGeneratorMaxImageSquare.have_value = false;
              }
            if (fieldGeneratorImageSquares.have_value)
              {
                result.initImageSquares();
                int count = fieldGeneratorImageSquares.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendImageSquares(fieldGeneratorImageSquares.value[num]);
                  }
                fieldGeneratorImageSquares.value.Clear();
                fieldGeneratorImageSquares.have_value = false;
              }
            if (fieldGeneratorPhotoUrl.have_value)
              {
                result.setPhotoUrl(fieldGeneratorPhotoUrl.value);
                fieldGeneratorPhotoUrl.have_value = false;
              }
            if (fieldGeneratorVerifiedByClass.have_value)
              {
                result.setVerifiedByClass(fieldGeneratorVerifiedByClass.value);
                fieldGeneratorVerifiedByClass.have_value = false;
              }
          }
        protected abstract void handle_result(BigOvenRecipesRecipeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "tiveMinutes", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorActiveMinutes;
                            break;
                        case 'd':
                            switch (field_name[2])
                              {
                                case 'T':
                                    if ((String.Compare(field_name, 3, "ags", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorAdTags;
                                    break;
                                case 'm':
                                    if ((String.Compare(field_name, 3, "inBoost", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorAdminBoost;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "lCategoriesText", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorAllCategoriesText;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if (String.Compare(field_name, 1, "ookmark", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 9, "mageURL", 0, 7, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorBookmarkImageURL;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 9, "iteLogo", 0, 7, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorBookmarkSiteLogo;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 9, "RL", 0, 2, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorBookmarkURL;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tegory", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCategory;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "llection", 0, 8, false) == 0)
                              {
                                if (field_name.Length == 10)
                                  {
                                    return fieldGeneratorCollection;
                                  }
                                switch (field_name[10])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 11, "D", 0, 1, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorCollectionID;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "eationDate", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCreationDate;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "isine", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorCuisine;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "avoriteCount", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorFavoriteCount;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if (String.Compare(field_name, 2, "age", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 6, "quares", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorImageSquares;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 6, "RL", 0, 2, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorImageURL;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'n':
                            switch (field_name[2])
                              {
                                case 'g':
                                    if (String.Compare(field_name, 3, "redients", 0, 8, false) == 0)
                                      {
                                        if (field_name.Length == 11)
                                          {
                                            return fieldGeneratorIngredients;
                                          }
                                        switch (field_name[11])
                                          {
                                            case 'T':
                                                if ((String.Compare(field_name, 12, "extBlock", 0, 8, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorIngredientsTextBlock;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "tructions", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorInstructions;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'B':
                                    if ((String.Compare(field_name, 3, "ookmark", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorIsBookmark;
                                    break;
                                case 'P':
                                    if ((String.Compare(field_name, 3, "rivate", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorIsPrivate;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 3, "ecipeScan", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorIsRecipeScan;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 3, "ponsored", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsSponsored;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astModified", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorLastModified;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "xImageSquare", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorMaxImageSquare;
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'd':
                                    if ((String.Compare(field_name, 3, "alCount", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorMedalCount;
                                    break;
                                case 'n':
                                    if ((String.Compare(field_name, 3, "uCount", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorMenuCount;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "crocategory", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorMicrocategory;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "tesCount", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorNotesCount;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "tritionInfo", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorNutritionInfo;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "otoUrl", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhotoUrl;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ster", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorPoster;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "imaryIngredient", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPrimaryIngredient;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "ipeID", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorRecipeID;
                                break;
                            case 'v':
                                if ((String.Compare(field_name, 3, "iewCount", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorReviewCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 't':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "rRating", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorStarRating;
                                    break;
                                case 'e':
                                    if ((String.Compare(field_name, 3, "ps", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorSteps;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bcategory", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSubcategory;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "tle", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTitle;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "talMinutes", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorTotalMinutes;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "riantOfRecipeID", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorVariantOfRecipeID;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "rified", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 9, "yClass", 0, 6, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorVerifiedByClass;
                                        break;
                                    case 'D':
                                        if ((String.Compare(field_name, 9, "ateTime", 0, 7, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorVerifiedDateTime;
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
                case 'W':
                    if ((String.Compare(field_name, 1, "ebURL", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorWebURL;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "ield", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "umber", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorYieldNumber;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 6, "nit", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorYieldUnit;
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
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the BigOvenRecipesRecipe class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the BigOvenRecipesRecipe class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMicrocategory = new JSONHoldingStringGenerator("field \"Microcategory\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the BigOvenRecipesRecipe class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the BigOvenRecipesRecipe class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMedalCount = new FieldHoldingGeneratorMedalCount("field \"MedalCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorFavoriteCount = new FieldHoldingGeneratorFavoriteCount("field \"FavoriteCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPoster = new BigOvenRecipesPosterSingleRecipeJSON.HoldingGenerator("field \"Poster\" of the BigOvenRecipesRecipe class", ignore_extras);
            fieldGeneratorIngredients = new BigOvenRecipesIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the BigOvenRecipesRecipe class", ignore_extras);
            fieldGeneratorSteps = new TypeStepsJSON.HoldingArrayGenerator("field \"Steps\" of the BigOvenRecipesRecipe class", ignore_extras);
            fieldGeneratorInstructions = new JSONHoldingStringGenerator("field \"Instructions\" of the BigOvenRecipesRecipe class");
            fieldGeneratorYieldNumber = new JSONHoldingNumberTextGenerator("field \"YieldNumber\" of the BigOvenRecipesRecipe class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the BigOvenRecipesRecipe class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the BigOvenRecipesRecipe class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the BigOvenRecipesRecipe class");
            fieldGeneratorNutritionInfo = new BigOvenRecipesNutritionInfoJSON.HoldingGenerator("field \"NutritionInfo\" of the BigOvenRecipesRecipe class", ignore_extras);
            fieldGeneratorIsPrivate = new JSONHoldingBooleanGenerator("field \"IsPrivate\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the BigOvenRecipesRecipe class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsBookmark = new JSONHoldingBooleanGenerator("field \"IsBookmark\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkURL = new JSONHoldingStringGenerator("field \"BookmarkURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkSiteLogo = new JSONHoldingStringGenerator("field \"BookmarkSiteLogo\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkImageURL = new JSONHoldingStringGenerator("field \"BookmarkImageURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsRecipeScan = new JSONHoldingBooleanGenerator("field \"IsRecipeScan\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMenuCount = new FieldHoldingGeneratorMenuCount("field \"MenuCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorNotesCount = new FieldHoldingGeneratorNotesCount("field \"NotesCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAdTags = new JSONHoldingStringGenerator("field \"AdTags\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIngredientsTextBlock = new JSONHoldingStringGenerator("field \"IngredientsTextBlock\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAllCategoriesText = new JSONHoldingStringGenerator("field \"AllCategoriesText\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsSponsored = new JSONHoldingBooleanGenerator("field \"IsSponsored\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVariantOfRecipeID = new FieldHoldingGeneratorVariantOfRecipeID("field \"VariantOfRecipeID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCollection = new JSONHoldingStringGenerator("field \"Collection\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCollectionID = new FieldHoldingGeneratorCollectionID("field \"CollectionID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAdminBoost = new FieldHoldingGeneratorAdminBoost("field \"AdminBoost\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVerifiedDateTime = new JSONHoldingStringGenerator("field \"VerifiedDateTime\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMaxImageSquare = new FieldHoldingGeneratorMaxImageSquare("field \"MaxImageSquare\" of the BigOvenRecipesRecipe class");
            fieldGeneratorImageSquares = new FieldHoldingArrayGeneratorImageSquares("field \"ImageSquares\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVerifiedByClass = new JSONHoldingStringGenerator("field \"VerifiedByClass\" of the BigOvenRecipesRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BigOvenRecipesRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the BigOvenRecipesRecipe class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the BigOvenRecipesRecipe class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMicrocategory = new JSONHoldingStringGenerator("field \"Microcategory\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the BigOvenRecipesRecipe class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the BigOvenRecipesRecipe class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMedalCount = new FieldHoldingGeneratorMedalCount("field \"MedalCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorFavoriteCount = new FieldHoldingGeneratorFavoriteCount("field \"FavoriteCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPoster = new BigOvenRecipesPosterSingleRecipeJSON.HoldingGenerator("field \"Poster\" of the BigOvenRecipesRecipe class", false);
            fieldGeneratorIngredients = new BigOvenRecipesIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the BigOvenRecipesRecipe class", false);
            fieldGeneratorSteps = new TypeStepsJSON.HoldingArrayGenerator("field \"Steps\" of the BigOvenRecipesRecipe class", false);
            fieldGeneratorInstructions = new JSONHoldingStringGenerator("field \"Instructions\" of the BigOvenRecipesRecipe class");
            fieldGeneratorYieldNumber = new JSONHoldingNumberTextGenerator("field \"YieldNumber\" of the BigOvenRecipesRecipe class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the BigOvenRecipesRecipe class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the BigOvenRecipesRecipe class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the BigOvenRecipesRecipe class");
            fieldGeneratorNutritionInfo = new BigOvenRecipesNutritionInfoJSON.HoldingGenerator("field \"NutritionInfo\" of the BigOvenRecipesRecipe class", false);
            fieldGeneratorIsPrivate = new JSONHoldingBooleanGenerator("field \"IsPrivate\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the BigOvenRecipesRecipe class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsBookmark = new JSONHoldingBooleanGenerator("field \"IsBookmark\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkURL = new JSONHoldingStringGenerator("field \"BookmarkURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkSiteLogo = new JSONHoldingStringGenerator("field \"BookmarkSiteLogo\" of the BigOvenRecipesRecipe class");
            fieldGeneratorBookmarkImageURL = new JSONHoldingStringGenerator("field \"BookmarkImageURL\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsRecipeScan = new JSONHoldingBooleanGenerator("field \"IsRecipeScan\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMenuCount = new FieldHoldingGeneratorMenuCount("field \"MenuCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorNotesCount = new FieldHoldingGeneratorNotesCount("field \"NotesCount\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAdTags = new JSONHoldingStringGenerator("field \"AdTags\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIngredientsTextBlock = new JSONHoldingStringGenerator("field \"IngredientsTextBlock\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAllCategoriesText = new JSONHoldingStringGenerator("field \"AllCategoriesText\" of the BigOvenRecipesRecipe class");
            fieldGeneratorIsSponsored = new JSONHoldingBooleanGenerator("field \"IsSponsored\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVariantOfRecipeID = new FieldHoldingGeneratorVariantOfRecipeID("field \"VariantOfRecipeID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCollection = new JSONHoldingStringGenerator("field \"Collection\" of the BigOvenRecipesRecipe class");
            fieldGeneratorCollectionID = new FieldHoldingGeneratorCollectionID("field \"CollectionID\" of the BigOvenRecipesRecipe class");
            fieldGeneratorAdminBoost = new FieldHoldingGeneratorAdminBoost("field \"AdminBoost\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVerifiedDateTime = new JSONHoldingStringGenerator("field \"VerifiedDateTime\" of the BigOvenRecipesRecipe class");
            fieldGeneratorMaxImageSquare = new FieldHoldingGeneratorMaxImageSquare("field \"MaxImageSquare\" of the BigOvenRecipesRecipe class");
            fieldGeneratorImageSquares = new FieldHoldingArrayGeneratorImageSquares("field \"ImageSquares\" of the BigOvenRecipesRecipe class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesRecipe class");
            fieldGeneratorVerifiedByClass = new JSONHoldingStringGenerator("field \"VerifiedByClass\" of the BigOvenRecipesRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BigOvenRecipesRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRecipeID.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorCuisine.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorSubcategory.reset();
            fieldGeneratorMicrocategory.reset();
            fieldGeneratorPrimaryIngredient.reset();
            fieldGeneratorStarRating.reset();
            fieldGeneratorWebURL.reset();
            fieldGeneratorImageURL.reset();
            fieldGeneratorReviewCount.reset();
            fieldGeneratorMedalCount.reset();
            fieldGeneratorFavoriteCount.reset();
            fieldGeneratorPoster.reset();
            fieldGeneratorIngredients.reset();
            fieldGeneratorSteps.reset();
            fieldGeneratorInstructions.reset();
            fieldGeneratorYieldNumber.reset();
            fieldGeneratorYieldUnit.reset();
            fieldGeneratorTotalMinutes.reset();
            fieldGeneratorActiveMinutes.reset();
            fieldGeneratorNutritionInfo.reset();
            fieldGeneratorIsPrivate.reset();
            fieldGeneratorCreationDate.reset();
            fieldGeneratorLastModified.reset();
            fieldGeneratorIsBookmark.reset();
            fieldGeneratorBookmarkURL.reset();
            fieldGeneratorBookmarkSiteLogo.reset();
            fieldGeneratorBookmarkImageURL.reset();
            fieldGeneratorIsRecipeScan.reset();
            fieldGeneratorMenuCount.reset();
            fieldGeneratorNotesCount.reset();
            fieldGeneratorAdTags.reset();
            fieldGeneratorIngredientsTextBlock.reset();
            fieldGeneratorAllCategoriesText.reset();
            fieldGeneratorIsSponsored.reset();
            fieldGeneratorVariantOfRecipeID.reset();
            fieldGeneratorCollection.reset();
            fieldGeneratorCollectionID.reset();
            fieldGeneratorAdminBoost.reset();
            fieldGeneratorVerifiedDateTime.reset();
            fieldGeneratorMaxImageSquare.reset();
            fieldGeneratorImageSquares.reset();
            fieldGeneratorPhotoUrl.reset();
            fieldGeneratorVerifiedByClass.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPoster.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIngredients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSteps.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNutritionInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPoster.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIngredients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSteps.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNutritionInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BigOvenRecipesRecipeJSON  result)
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
        public BigOvenRecipesRecipeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BigOvenRecipesRecipeJSON  result)
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
    protected virtual void handle_result(List<BigOvenRecipesRecipeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BigOvenRecipesRecipeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BigOvenRecipesRecipeJSON>();
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
    public List<BigOvenRecipesRecipeJSON> value;
  };
  };
