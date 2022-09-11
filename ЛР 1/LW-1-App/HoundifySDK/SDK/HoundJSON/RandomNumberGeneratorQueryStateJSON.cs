/* file "RandomNumberGeneratorQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RandomNumberGeneratorQueryStateJSON : JSONBase
  {
    private bool flagHasRequests;
    private List< RandomNumberGeneratorRequestResultJSON  > storeRequests;
    private bool flagHasIsMetaquery;
    private bool storeIsMetaquery;
    private bool flagHasSpecificMetaquery;
    private bool storeSpecificMetaquery;


    private void  fromJSONRequests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Requests of RandomNumberGeneratorQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RandomNumberGeneratorRequestResultJSON  > vector_Requests1 = new List< RandomNumberGeneratorRequestResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RandomNumberGeneratorRequestResultJSON convert_classy = RandomNumberGeneratorRequestResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Requests1.Add(convert_classy);
          }
        initRequests();
        for (int num1 = 0; num1 < vector_Requests1.Count; ++num1)
            appendRequests(vector_Requests1[num1]);
        for (int num1 = 0; num1 < vector_Requests1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIsMetaquery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsMetaquery of RandomNumberGeneratorQueryStateJSON is not true for false.");
              }
          }
        setIsMetaquery(the_bool);
      }


    private void  fromJSONSpecificMetaquery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SpecificMetaquery of RandomNumberGeneratorQueryStateJSON is not true for false.");
              }
          }
        setSpecificMetaquery(the_bool);
      }


    public RandomNumberGeneratorQueryStateJSON()
      {
        flagHasRequests = false;
        flagHasIsMetaquery = false;
        flagHasSpecificMetaquery = false;
        storeRequests = new List< RandomNumberGeneratorRequestResultJSON  >();
      }

    public bool  hasRequests()
      {
        return flagHasRequests;
      }

    public int  countOfRequests()
      {
        Debug.Assert(flagHasRequests);
        return storeRequests.Count;
      }

    public RandomNumberGeneratorRequestResultJSON   elementOfRequests(int element_num)
      {
        Debug.Assert(flagHasRequests);
        return storeRequests[element_num];
      }

    public List< RandomNumberGeneratorRequestResultJSON  >  getRequests()
      {
        Debug.Assert(flagHasRequests);
        return storeRequests;
      }

    public bool  hasIsMetaquery()
      {
        return flagHasIsMetaquery;
      }

    public bool  getIsMetaquery()
      {
        Debug.Assert(flagHasIsMetaquery);
        return storeIsMetaquery;
      }

    public bool  hasSpecificMetaquery()
      {
        return flagHasSpecificMetaquery;
      }

    public bool  getSpecificMetaquery()
      {
        Debug.Assert(flagHasSpecificMetaquery);
        return storeSpecificMetaquery;
      }



    public void initRequests()
      {
        if (flagHasRequests)
          {
            for (int num1 = 0; num1 < storeRequests.Count; ++num1)
              {
              }
          }
        flagHasRequests = true;
        storeRequests.Clear();
      }
    public void appendRequests(RandomNumberGeneratorRequestResultJSON  to_append)
      {
        if (!flagHasRequests)
          {
            flagHasRequests = true;
            storeRequests.Clear();
          }
        Debug.Assert(flagHasRequests);
        storeRequests.Add(to_append);
      }
    public void unsetRequests()
      {
        if (flagHasRequests)
          {
            for (int num2 = 0; num2 < storeRequests.Count; ++num2)
              {
              }
          }
        flagHasRequests = false;
        storeRequests.Clear();
      }
    public void setIsMetaquery(bool new_value)
      {
        flagHasIsMetaquery = true;
        storeIsMetaquery = new_value;
      }
    public void unsetIsMetaquery()
      {
        flagHasIsMetaquery = false;
      }
    public void setSpecificMetaquery(bool new_value)
      {
        flagHasSpecificMetaquery = true;
        storeSpecificMetaquery = new_value;
      }
    public void unsetSpecificMetaquery()
      {
        flagHasSpecificMetaquery = false;
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
        if (flagHasRequests)
          {
            handler.start_pair("Requests");
            handler.start_array();
            for (int num1 = 0; num1 < storeRequests.Count; ++num1)
              {
                if (partial_allowed)
                    storeRequests[num1].write_partial_as_json(handler);
                else
                    storeRequests[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasIsMetaquery);
        if (flagHasIsMetaquery)
          {
            handler.start_pair("IsMetaquery");
            handler.boolean_value(storeIsMetaquery);
          }
        if (flagHasSpecificMetaquery)
          {
            handler.start_pair("SpecificMetaquery");
            handler.boolean_value(storeSpecificMetaquery);
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
        if (!(hasIsMetaquery()))
          {
            return "When parsing the object for %what%, the \"IsMetaquery\" field was missing.";
          }
        return null;
      }

    public static RandomNumberGeneratorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorQueryState", ignore_extras);
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
    public static RandomNumberGeneratorQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RandomNumberGeneratorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorQueryState", ignore_extras);
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
    public static RandomNumberGeneratorQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RandomNumberGeneratorQueryStateJSON from_text(string text, bool ignore_extras)
      {
        RandomNumberGeneratorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RandomNumberGeneratorQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RandomNumberGeneratorQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RandomNumberGeneratorQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator fieldGeneratorRequests;
        private JSONHoldingBooleanGenerator fieldGeneratorIsMetaquery;
        private JSONHoldingBooleanGenerator fieldGeneratorSpecificMetaquery;

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
            RandomNumberGeneratorQueryStateJSON result = new RandomNumberGeneratorQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(RandomNumberGeneratorQueryStateJSON result)
          {
            if (fieldGeneratorRequests.have_value)
              {
                result.initRequests();
                int count = fieldGeneratorRequests.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequests(fieldGeneratorRequests.value[num]);
                  }
                fieldGeneratorRequests.value.Clear();
                fieldGeneratorRequests.have_value = false;
              }
            if (fieldGeneratorIsMetaquery.have_value)
              {
                result.setIsMetaquery(fieldGeneratorIsMetaquery.value);
                fieldGeneratorIsMetaquery.have_value = false;
              }
            else if ((!(result.hasIsMetaquery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsMetaquery\" field was missing.");
              }
            if (fieldGeneratorSpecificMetaquery.have_value)
              {
                result.setSpecificMetaquery(fieldGeneratorSpecificMetaquery.value);
                fieldGeneratorSpecificMetaquery.have_value = false;
              }
          }
        protected abstract void handle_result(RandomNumberGeneratorQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sMetaquery", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIsMetaquery;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equests", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorRequests;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecificMetaquery", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorSpecificMetaquery;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRequests = new RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator("field \"Requests\" of the RandomNumberGeneratorQueryState class", ignore_extras);
            fieldGeneratorIsMetaquery = new JSONHoldingBooleanGenerator("field \"IsMetaquery\" of the RandomNumberGeneratorQueryState class");
            fieldGeneratorSpecificMetaquery = new JSONHoldingBooleanGenerator("field \"SpecificMetaquery\" of the RandomNumberGeneratorQueryState class");
            set_what("the RandomNumberGeneratorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRequests = new RandomNumberGeneratorRequestResultJSON.HoldingArrayGenerator("field \"Requests\" of the RandomNumberGeneratorQueryState class", false);
            fieldGeneratorIsMetaquery = new JSONHoldingBooleanGenerator("field \"IsMetaquery\" of the RandomNumberGeneratorQueryState class");
            fieldGeneratorSpecificMetaquery = new JSONHoldingBooleanGenerator("field \"SpecificMetaquery\" of the RandomNumberGeneratorQueryState class");
            set_what("the RandomNumberGeneratorQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRequests.reset();
            fieldGeneratorIsMetaquery.reset();
            fieldGeneratorSpecificMetaquery.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRequests.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRequests.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RandomNumberGeneratorQueryStateJSON  result)
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
        public RandomNumberGeneratorQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RandomNumberGeneratorQueryStateJSON  result)
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
    protected virtual void handle_result(List<RandomNumberGeneratorQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RandomNumberGeneratorQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RandomNumberGeneratorQueryStateJSON>();
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
    public List<RandomNumberGeneratorQueryStateJSON> value;
  };
  };
