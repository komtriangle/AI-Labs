/* file "HomeAutomationAmbiguityFlagsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationAmbiguityFlagsJSON : JSONBase
  {
    private bool flagHasHomeAutomationSolution;
    private bool storeHomeAutomationSolution;
    private bool flagHasName;
    private bool storeName;
    private bool flagHasID;
    private bool storeID;
    private bool flagHasType;
    private bool storeType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHomeAutomationSolution(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HomeAutomationSolution of HomeAutomationAmbiguityFlagsJSON is not true for false.");
              }
          }
        setHomeAutomationSolution(the_bool);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Name of HomeAutomationAmbiguityFlagsJSON is not true for false.");
              }
          }
        setName(the_bool);
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ID of HomeAutomationAmbiguityFlagsJSON is not true for false.");
              }
          }
        setID(the_bool);
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Type of HomeAutomationAmbiguityFlagsJSON is not true for false.");
              }
          }
        setType(the_bool);
      }


    public HomeAutomationAmbiguityFlagsJSON()
      {
        flagHasHomeAutomationSolution = false;
        flagHasName = false;
        flagHasID = false;
        flagHasType = false;
        storeHomeAutomationSolution = false;
        storeName = false;
        storeID = false;
        storeType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHomeAutomationSolution()
      {
        return flagHasHomeAutomationSolution;
      }

    public bool  getHomeAutomationSolution()
      {
        return storeHomeAutomationSolution;
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public bool  getName()
      {
        return storeName;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public bool  getID()
      {
        return storeID;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public bool  getType()
      {
        return storeType;
      }


    public virtual int extraHomeAutomationAmbiguityFlagsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationAmbiguityFlagsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationAmbiguityFlagsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationAmbiguityFlagsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHomeAutomationSolution(bool new_value)
      {
        flagHasHomeAutomationSolution = true;
        storeHomeAutomationSolution = new_value;
      }
    public void unsetHomeAutomationSolution()
      {
        flagHasHomeAutomationSolution = false;
      }
    public void setName(bool new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setID(bool new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setType(bool new_value)
      {
        flagHasType = true;
        storeType = new_value;
      }
    public void unsetType()
      {
        flagHasType = false;
      }

    public virtual void extraHomeAutomationAmbiguityFlagsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationAmbiguityFlagsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationAmbiguityFlagsLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationAmbiguityFlagsAppendPair(key, new_component);
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
        if (flagHasHomeAutomationSolution)
          {
            handler.start_pair("HomeAutomationSolution");
            handler.boolean_value(storeHomeAutomationSolution);
          }
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.boolean_value(storeName);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.boolean_value(storeID);
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            handler.boolean_value(storeType);
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

    public static HomeAutomationAmbiguityFlagsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationAmbiguityFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguityFlags", ignore_extras);
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
    public static HomeAutomationAmbiguityFlagsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationAmbiguityFlagsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationAmbiguityFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguityFlags", ignore_extras);
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
    public static HomeAutomationAmbiguityFlagsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationAmbiguityFlagsJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationAmbiguityFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguityFlags", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationAmbiguityFlagsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationAmbiguityFlagsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationAmbiguityFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguityFlags", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorHomeAutomationSolution;
        private JSONHoldingBooleanGenerator fieldGeneratorName;
        private JSONHoldingBooleanGenerator fieldGeneratorID;
        private JSONHoldingBooleanGenerator fieldGeneratorType;
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
            HomeAutomationAmbiguityFlagsJSON result = new HomeAutomationAmbiguityFlagsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationAmbiguityFlagsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationAmbiguityFlagsJSON result)
          {
            if (fieldGeneratorHomeAutomationSolution.have_value)
              {
                result.setHomeAutomationSolution(fieldGeneratorHomeAutomationSolution.value);
                fieldGeneratorHomeAutomationSolution.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationAmbiguityFlagsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationSolution", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorHomeAutomationSolution;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHomeAutomationSolution = new JSONHoldingBooleanGenerator("field \"HomeAutomationSolution\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorName = new JSONHoldingBooleanGenerator("field \"Name\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorID = new JSONHoldingBooleanGenerator("field \"ID\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorType = new JSONHoldingBooleanGenerator("field \"Type\" of the HomeAutomationAmbiguityFlags class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationAmbiguityFlags class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHomeAutomationSolution = new JSONHoldingBooleanGenerator("field \"HomeAutomationSolution\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorName = new JSONHoldingBooleanGenerator("field \"Name\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorID = new JSONHoldingBooleanGenerator("field \"ID\" of the HomeAutomationAmbiguityFlags class");
            fieldGeneratorType = new JSONHoldingBooleanGenerator("field \"Type\" of the HomeAutomationAmbiguityFlags class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationAmbiguityFlags class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHomeAutomationSolution.reset();
            fieldGeneratorName.reset();
            fieldGeneratorID.reset();
            fieldGeneratorType.reset();
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
        protected override void handle_result(HomeAutomationAmbiguityFlagsJSON  result)
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
        public HomeAutomationAmbiguityFlagsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationAmbiguityFlagsJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationAmbiguityFlagsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationAmbiguityFlagsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationAmbiguityFlagsJSON>();
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
    public List<HomeAutomationAmbiguityFlagsJSON> value;
  };
  };
