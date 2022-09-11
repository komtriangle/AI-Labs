/* file "RobotConfigurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RobotConfigurationJSON : JSONBase
  {
    public class TypeSensorsJSON : JSONBase
      {
        private bool flagHasHasCamera;
        private bool storeHasCamera;
        private bool flagHasHasVideoCamera;
        private bool storeHasVideoCamera;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONHasCamera(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field HasCamera of TypeSensorsJSON is not true for false.");
                  }
              }
            setHasCamera(the_bool);
          }


        private void  fromJSONHasVideoCamera(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field HasVideoCamera of TypeSensorsJSON is not true for false.");
                  }
              }
            setHasVideoCamera(the_bool);
          }


        public TypeSensorsJSON()
          {
            flagHasHasCamera = false;
            flagHasHasVideoCamera = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasHasCamera()
          {
            return flagHasHasCamera;
          }

        public bool  getHasCamera()
          {
            Debug.Assert(flagHasHasCamera);
            return storeHasCamera;
          }

        public bool  hasHasVideoCamera()
          {
            return flagHasHasVideoCamera;
          }

        public bool  getHasVideoCamera()
          {
            Debug.Assert(flagHasHasVideoCamera);
            return storeHasVideoCamera;
          }


        public virtual int extraTypeSensorsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeSensorsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeSensorsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeSensorsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setHasCamera(bool new_value)
          {
            flagHasHasCamera = true;
            storeHasCamera = new_value;
          }
        public void unsetHasCamera()
          {
            flagHasHasCamera = false;
          }
        public void setHasVideoCamera(bool new_value)
          {
            flagHasHasVideoCamera = true;
            storeHasVideoCamera = new_value;
          }
        public void unsetHasVideoCamera()
          {
            flagHasHasVideoCamera = false;
          }

        public virtual void extraTypeSensorsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeSensorsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeSensorsLookup(key);
            if (old_field == null)
              {
                extraTypeSensorsAppendPair(key, new_component);
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
            if (flagHasHasCamera)
              {
                handler.start_pair("HasCamera");
                handler.boolean_value(storeHasCamera);
              }
            if (flagHasHasVideoCamera)
              {
                handler.start_pair("HasVideoCamera");
                handler.boolean_value(storeHasVideoCamera);
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

        public static TypeSensorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSensorsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensors", ignore_extras);
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
        public static TypeSensorsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSensorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeSensorsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensors", ignore_extras);
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
        public static TypeSensorsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeSensorsJSON from_text(string text, bool ignore_extras)
          {
            TypeSensorsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensors", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeSensorsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeSensorsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeSensorsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeSensors", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorHasCamera;
            private JSONHoldingBooleanGenerator fieldGeneratorHasVideoCamera;
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
                TypeSensorsJSON result = new TypeSensorsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeSensorsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeSensorsJSON result)
              {
                if (fieldGeneratorHasCamera.have_value)
                  {
                    result.setHasCamera(fieldGeneratorHasCamera.value);
                    fieldGeneratorHasCamera.have_value = false;
                  }
                if (fieldGeneratorHasVideoCamera.have_value)
                  {
                    result.setHasVideoCamera(fieldGeneratorHasVideoCamera.value);
                    fieldGeneratorHasVideoCamera.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeSensorsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Has", 0, 3, false) == 0)
                  {
                    switch (field_name[3])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 4, "amera", 0, 5, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorHasCamera;
                            break;
                        case 'V':
                            if ((String.Compare(field_name, 4, "ideoCamera", 0, 10, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorHasVideoCamera;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorHasCamera = new JSONHoldingBooleanGenerator("field \"HasCamera\" of the TypeSensors class");
                fieldGeneratorHasVideoCamera = new JSONHoldingBooleanGenerator("field \"HasVideoCamera\" of the TypeSensors class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeSensors class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorHasCamera = new JSONHoldingBooleanGenerator("field \"HasCamera\" of the TypeSensors class");
                fieldGeneratorHasVideoCamera = new JSONHoldingBooleanGenerator("field \"HasVideoCamera\" of the TypeSensors class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeSensors class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorHasCamera.reset();
                fieldGeneratorHasVideoCamera.reset();
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
            protected override void handle_result(TypeSensorsJSON  result)
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
            public TypeSensorsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeSensorsJSON  result)
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
        protected virtual void handle_result(List<TypeSensorsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeSensorsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeSensorsJSON>();
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
        public List<TypeSensorsJSON> value;
      };
      };
    private bool flagHasArmCount;
    private BigInteger storeArmCount;
    private bool flagHasLegCount;
    private BigInteger storeLegCount;
    private bool flagHasIsMobile;
    private bool storeIsMobile;
    private bool flagHasSensors;
    private TypeSensorsJSON  storeSensors;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONArmCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ArmCount of RobotConfigurationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ArmCount of RobotConfigurationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setArmCount(extracted_integer);
      }


    private void  fromJSONLegCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field LegCount of RobotConfigurationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field LegCount of RobotConfigurationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLegCount(extracted_integer);
      }


    private void  fromJSONIsMobile(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsMobile of RobotConfigurationJSON is not true for false.");
              }
          }
        setIsMobile(the_bool);
      }


    private void  fromJSONSensors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeSensorsJSON convert_classy = TypeSensorsJSON.from_json(json_value, ignore_extras, true);
        setSensors(convert_classy);
      }


    public RobotConfigurationJSON()
      {
        flagHasArmCount = false;
        flagHasLegCount = false;
        flagHasIsMobile = false;
        flagHasSensors = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasArmCount()
      {
        return flagHasArmCount;
      }

    public BigInteger  getArmCount()
      {
        Debug.Assert(flagHasArmCount);
        return storeArmCount;
      }

    public bool  hasLegCount()
      {
        return flagHasLegCount;
      }

    public BigInteger  getLegCount()
      {
        Debug.Assert(flagHasLegCount);
        return storeLegCount;
      }

    public bool  hasIsMobile()
      {
        return flagHasIsMobile;
      }

    public bool  getIsMobile()
      {
        Debug.Assert(flagHasIsMobile);
        return storeIsMobile;
      }

    public bool  hasSensors()
      {
        return flagHasSensors;
      }

    public TypeSensorsJSON   getSensors()
      {
        Debug.Assert(flagHasSensors);
        return storeSensors;
      }


    public virtual int extraRobotConfigurationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRobotConfigurationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRobotConfigurationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRobotConfigurationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setArmCount(BigInteger new_value)
      {
        flagHasArmCount = true;
        storeArmCount = new_value;
      }
    public void unsetArmCount()
      {
        flagHasArmCount = false;
      }
    public void setLegCount(BigInteger new_value)
      {
        flagHasLegCount = true;
        storeLegCount = new_value;
      }
    public void unsetLegCount()
      {
        flagHasLegCount = false;
      }
    public void setIsMobile(bool new_value)
      {
        flagHasIsMobile = true;
        storeIsMobile = new_value;
      }
    public void unsetIsMobile()
      {
        flagHasIsMobile = false;
      }
    public void setSensors(TypeSensorsJSON  new_value)
      {
        if (flagHasSensors)
          {
          }
        flagHasSensors = true;
        storeSensors = new_value;
      }
    public void unsetSensors()
      {
        if (flagHasSensors)
          {
          }
        flagHasSensors = false;
      }

    public virtual void extraRobotConfigurationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRobotConfigurationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRobotConfigurationLookup(key);
        if (old_field == null)
          {
            extraRobotConfigurationAppendPair(key, new_component);
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
        if (flagHasArmCount)
          {
            handler.start_pair("ArmCount");
            handler.number_value(storeArmCount);
          }
        if (flagHasLegCount)
          {
            handler.start_pair("LegCount");
            handler.number_value(storeLegCount);
          }
        if (flagHasIsMobile)
          {
            handler.start_pair("IsMobile");
            handler.boolean_value(storeIsMobile);
          }
        if (flagHasSensors)
          {
            handler.start_pair("Sensors");
            if (partial_allowed)
                storeSensors.write_partial_as_json(handler);
            else
                storeSensors.write_as_json(handler);
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

    public static RobotConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotConfiguration", ignore_extras);
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
    public static RobotConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RobotConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotConfiguration", ignore_extras);
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
    public static RobotConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RobotConfigurationJSON from_text(string text, bool ignore_extras)
      {
        RobotConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotConfiguration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotConfigurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RobotConfigurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotConfiguration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorArmCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorArmCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorArmCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorArmCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorArmCount fieldGeneratorArmCount;
    private class FieldHoldingGeneratorLegCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorLegCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorLegCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorLegCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorLegCount fieldGeneratorLegCount;
        private JSONHoldingBooleanGenerator fieldGeneratorIsMobile;
        private TypeSensorsJSON.HoldingGenerator fieldGeneratorSensors;
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
            RobotConfigurationJSON result = new RobotConfigurationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotConfigurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RobotConfigurationJSON result)
          {
            if (fieldGeneratorArmCount.have_value)
              {
                result.setArmCount(fieldGeneratorArmCount.value);
                fieldGeneratorArmCount.have_value = false;
              }
            if (fieldGeneratorLegCount.have_value)
              {
                result.setLegCount(fieldGeneratorLegCount.value);
                fieldGeneratorLegCount.have_value = false;
              }
            if (fieldGeneratorIsMobile.have_value)
              {
                result.setIsMobile(fieldGeneratorIsMobile.value);
                fieldGeneratorIsMobile.have_value = false;
              }
            if (fieldGeneratorSensors.have_value)
              {
                result.setSensors(fieldGeneratorSensors.value);
                fieldGeneratorSensors.have_value = false;
              }
          }
        protected abstract void handle_result(RobotConfigurationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rmCount", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorArmCount;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sMobile", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIsMobile;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "egCount", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLegCount;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ensors", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorSensors;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArmCount = new FieldHoldingGeneratorArmCount("field \"ArmCount\" of the RobotConfiguration class");
            fieldGeneratorLegCount = new FieldHoldingGeneratorLegCount("field \"LegCount\" of the RobotConfiguration class");
            fieldGeneratorIsMobile = new JSONHoldingBooleanGenerator("field \"IsMobile\" of the RobotConfiguration class");
            fieldGeneratorSensors = new TypeSensorsJSON.HoldingGenerator("field \"Sensors\" of the RobotConfiguration class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RobotConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArmCount = new FieldHoldingGeneratorArmCount("field \"ArmCount\" of the RobotConfiguration class");
            fieldGeneratorLegCount = new FieldHoldingGeneratorLegCount("field \"LegCount\" of the RobotConfiguration class");
            fieldGeneratorIsMobile = new JSONHoldingBooleanGenerator("field \"IsMobile\" of the RobotConfiguration class");
            fieldGeneratorSensors = new TypeSensorsJSON.HoldingGenerator("field \"Sensors\" of the RobotConfiguration class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RobotConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArmCount.reset();
            fieldGeneratorLegCount.reset();
            fieldGeneratorIsMobile.reset();
            fieldGeneratorSensors.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSensors.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSensors.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotConfigurationJSON  result)
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
        public RobotConfigurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotConfigurationJSON  result)
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
    protected virtual void handle_result(List<RobotConfigurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotConfigurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotConfigurationJSON>();
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
    public List<RobotConfigurationJSON> value;
  };
  };
