/* file "FlightStatsEquipmentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsEquipmentJSON : JSONBase
  {
    private bool flagHasiata;
    private string storeiata;
    private bool flagHasname;
    private string storename;
    private bool flagHasturboProp;
    private bool storeturboProp;
    private bool flagHasjet;
    private bool storejet;
    private bool flagHaswidebody;
    private bool storewidebody;
    private bool flagHasregional;
    private bool storeregional;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONiata(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field iata of FlightStatsEquipmentJSON is not a string.");
        setiata(json_string.getData());
      }


    private void  fromJSONname(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field name of FlightStatsEquipmentJSON is not a string.");
        setname(json_string.getData());
      }


    private void  fromJSONturboProp(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field turboProp of FlightStatsEquipmentJSON is not true for false.");
              }
          }
        setturboProp(the_bool);
      }


    private void  fromJSONjet(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field jet of FlightStatsEquipmentJSON is not true for false.");
              }
          }
        setjet(the_bool);
      }


    private void  fromJSONwidebody(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field widebody of FlightStatsEquipmentJSON is not true for false.");
              }
          }
        setwidebody(the_bool);
      }


    private void  fromJSONregional(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field regional of FlightStatsEquipmentJSON is not true for false.");
              }
          }
        setregional(the_bool);
      }


    public FlightStatsEquipmentJSON()
      {
        flagHasiata = false;
        flagHasname = false;
        flagHasturboProp = false;
        flagHasjet = false;
        flagHaswidebody = false;
        flagHasregional = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasiata()
      {
        return flagHasiata;
      }

    public string  getiata()
      {
        Debug.Assert(flagHasiata);
        return storeiata;
      }

    public bool  hasname()
      {
        return flagHasname;
      }

    public string  getname()
      {
        Debug.Assert(flagHasname);
        return storename;
      }

    public bool  hasturboProp()
      {
        return flagHasturboProp;
      }

    public bool  getturboProp()
      {
        Debug.Assert(flagHasturboProp);
        return storeturboProp;
      }

    public bool  hasjet()
      {
        return flagHasjet;
      }

    public bool  getjet()
      {
        Debug.Assert(flagHasjet);
        return storejet;
      }

    public bool  haswidebody()
      {
        return flagHaswidebody;
      }

    public bool  getwidebody()
      {
        Debug.Assert(flagHaswidebody);
        return storewidebody;
      }

    public bool  hasregional()
      {
        return flagHasregional;
      }

    public bool  getregional()
      {
        Debug.Assert(flagHasregional);
        return storeregional;
      }


    public virtual int extraFlightStatsEquipmentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsEquipmentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsEquipmentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsEquipmentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setiata(string new_value)
      {
        flagHasiata = true;
        storeiata = new_value;
      }
    public void unsetiata()
      {
        flagHasiata = false;
      }
    public void setname(string new_value)
      {
        flagHasname = true;
        storename = new_value;
      }
    public void unsetname()
      {
        flagHasname = false;
      }
    public void setturboProp(bool new_value)
      {
        flagHasturboProp = true;
        storeturboProp = new_value;
      }
    public void unsetturboProp()
      {
        flagHasturboProp = false;
      }
    public void setjet(bool new_value)
      {
        flagHasjet = true;
        storejet = new_value;
      }
    public void unsetjet()
      {
        flagHasjet = false;
      }
    public void setwidebody(bool new_value)
      {
        flagHaswidebody = true;
        storewidebody = new_value;
      }
    public void unsetwidebody()
      {
        flagHaswidebody = false;
      }
    public void setregional(bool new_value)
      {
        flagHasregional = true;
        storeregional = new_value;
      }
    public void unsetregional()
      {
        flagHasregional = false;
      }

    public virtual void extraFlightStatsEquipmentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsEquipmentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsEquipmentLookup(key);
        if (old_field == null)
          {
            extraFlightStatsEquipmentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasiata);
        if (flagHasiata)
          {
            handler.start_pair("iata");
            handler.string_value(storeiata);
          }
        Debug.Assert(partial_allowed || flagHasname);
        if (flagHasname)
          {
            handler.start_pair("name");
            handler.string_value(storename);
          }
        Debug.Assert(partial_allowed || flagHasturboProp);
        if (flagHasturboProp)
          {
            handler.start_pair("turboProp");
            handler.boolean_value(storeturboProp);
          }
        Debug.Assert(partial_allowed || flagHasjet);
        if (flagHasjet)
          {
            handler.start_pair("jet");
            handler.boolean_value(storejet);
          }
        Debug.Assert(partial_allowed || flagHaswidebody);
        if (flagHaswidebody)
          {
            handler.start_pair("widebody");
            handler.boolean_value(storewidebody);
          }
        Debug.Assert(partial_allowed || flagHasregional);
        if (flagHasregional)
          {
            handler.start_pair("regional");
            handler.boolean_value(storeregional);
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
        if (!(hasiata()))
          {
            return "When parsing the object for %what%, the \"iata\" field was missing.";
          }
        if (!(hasname()))
          {
            return "When parsing the object for %what%, the \"name\" field was missing.";
          }
        if (!(hasturboProp()))
          {
            return "When parsing the object for %what%, the \"turboProp\" field was missing.";
          }
        if (!(hasjet()))
          {
            return "When parsing the object for %what%, the \"jet\" field was missing.";
          }
        if (!(haswidebody()))
          {
            return "When parsing the object for %what%, the \"widebody\" field was missing.";
          }
        if (!(hasregional()))
          {
            return "When parsing the object for %what%, the \"regional\" field was missing.";
          }
        return null;
      }

    public static FlightStatsEquipmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsEquipmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsEquipment", ignore_extras);
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
    public static FlightStatsEquipmentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsEquipmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsEquipmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsEquipment", ignore_extras);
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
    public static FlightStatsEquipmentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatsEquipmentJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsEquipmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsEquipment", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsEquipmentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatsEquipmentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsEquipmentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsEquipment", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratoriata;
        private JSONHoldingStringGenerator fieldGeneratorname;
        private JSONHoldingBooleanGenerator fieldGeneratorturboProp;
        private JSONHoldingBooleanGenerator fieldGeneratorjet;
        private JSONHoldingBooleanGenerator fieldGeneratorwidebody;
        private JSONHoldingBooleanGenerator fieldGeneratorregional;
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
            FlightStatsEquipmentJSON result = new FlightStatsEquipmentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsEquipmentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatsEquipmentJSON result)
          {
            if (fieldGeneratoriata.have_value)
              {
                result.setiata(fieldGeneratoriata.value);
                fieldGeneratoriata.have_value = false;
              }
            else if ((!(result.hasiata())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"iata\" field was missing.");
              }
            if (fieldGeneratorname.have_value)
              {
                result.setname(fieldGeneratorname.value);
                fieldGeneratorname.have_value = false;
              }
            else if ((!(result.hasname())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"name\" field was missing.");
              }
            if (fieldGeneratorturboProp.have_value)
              {
                result.setturboProp(fieldGeneratorturboProp.value);
                fieldGeneratorturboProp.have_value = false;
              }
            else if ((!(result.hasturboProp())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"turboProp\" field was missing.");
              }
            if (fieldGeneratorjet.have_value)
              {
                result.setjet(fieldGeneratorjet.value);
                fieldGeneratorjet.have_value = false;
              }
            else if ((!(result.hasjet())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"jet\" field was missing.");
              }
            if (fieldGeneratorwidebody.have_value)
              {
                result.setwidebody(fieldGeneratorwidebody.value);
                fieldGeneratorwidebody.have_value = false;
              }
            else if ((!(result.haswidebody())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"widebody\" field was missing.");
              }
            if (fieldGeneratorregional.have_value)
              {
                result.setregional(fieldGeneratorregional.value);
                fieldGeneratorregional.have_value = false;
              }
            else if ((!(result.hasregional())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"regional\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightStatsEquipmentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'i':
                    if ((String.Compare(field_name, 1, "ata", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratoriata;
                    break;
                case 'j':
                    if ((String.Compare(field_name, 1, "et", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorjet;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorname;
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "egional", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorregional;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "urboProp", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorturboProp;
                    break;
                case 'w':
                    if ((String.Compare(field_name, 1, "idebody", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorwidebody;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratoriata = new JSONHoldingStringGenerator("field \"iata\" of the FlightStatsEquipment class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the FlightStatsEquipment class");
            fieldGeneratorturboProp = new JSONHoldingBooleanGenerator("field \"turboProp\" of the FlightStatsEquipment class");
            fieldGeneratorjet = new JSONHoldingBooleanGenerator("field \"jet\" of the FlightStatsEquipment class");
            fieldGeneratorwidebody = new JSONHoldingBooleanGenerator("field \"widebody\" of the FlightStatsEquipment class");
            fieldGeneratorregional = new JSONHoldingBooleanGenerator("field \"regional\" of the FlightStatsEquipment class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsEquipment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratoriata = new JSONHoldingStringGenerator("field \"iata\" of the FlightStatsEquipment class");
            fieldGeneratorname = new JSONHoldingStringGenerator("field \"name\" of the FlightStatsEquipment class");
            fieldGeneratorturboProp = new JSONHoldingBooleanGenerator("field \"turboProp\" of the FlightStatsEquipment class");
            fieldGeneratorjet = new JSONHoldingBooleanGenerator("field \"jet\" of the FlightStatsEquipment class");
            fieldGeneratorwidebody = new JSONHoldingBooleanGenerator("field \"widebody\" of the FlightStatsEquipment class");
            fieldGeneratorregional = new JSONHoldingBooleanGenerator("field \"regional\" of the FlightStatsEquipment class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsEquipment class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratoriata.reset();
            fieldGeneratorname.reset();
            fieldGeneratorturboProp.reset();
            fieldGeneratorjet.reset();
            fieldGeneratorwidebody.reset();
            fieldGeneratorregional.reset();
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
        protected override void handle_result(FlightStatsEquipmentJSON  result)
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
        public FlightStatsEquipmentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsEquipmentJSON  result)
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
    protected virtual void handle_result(List<FlightStatsEquipmentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsEquipmentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsEquipmentJSON>();
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
    public List<FlightStatsEquipmentJSON> value;
  };
  };
