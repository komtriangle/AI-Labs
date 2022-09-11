/* file "ImplicitPropertyDerivationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ImplicitPropertyDerivationJSON : DerivationJSON
  {
    private bool flagHasBase;
    private DerivedGeneralizedThingJSON  storeBase;
    private bool flagHasProperty;
    private PropertyJSON  storeProperty;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraBaseToJSON()
      {
        JSONValueHandler handler_Base = new JSONValueHandler();
        storeBase.write_as_json(handler_Base);
        return handler_Base.result;
      }

    private JSONValue  extraPropertyToJSON()
      {
        JSONValueHandler handler_Property = new JSONValueHandler();
        storeProperty.write_as_json(handler_Property);
        return handler_Property.result;
      }


    private void  fromJSONBase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DerivedGeneralizedThingJSON convert_classy = DerivedGeneralizedThingJSON.from_json(json_value, ignore_extras, true);
        setBase(convert_classy);
      }


    private void  fromJSONProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PropertyJSON convert_classy = PropertyJSON.from_json(json_value, ignore_extras, true);
        setProperty(convert_classy);
      }


    public ImplicitPropertyDerivationJSON()
      {
        flagHasBase = false;
        flagHasProperty = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDerivationKind()
      {
        return "ImplicitProperty";
      }

    public bool  hasBase()
      {
        return flagHasBase;
      }

    public DerivedGeneralizedThingJSON   getBase()
      {
        Debug.Assert(flagHasBase);
        return storeBase;
      }

    public bool  hasProperty()
      {
        return flagHasProperty;
      }

    public PropertyJSON   getProperty()
      {
        Debug.Assert(flagHasProperty);
        return storeProperty;
      }


    public virtual int extraImplicitPropertyDerivationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraImplicitPropertyDerivationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraImplicitPropertyDerivationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraImplicitPropertyDerivationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDerivationComponentCount()
      {
        int result = 0;
        if (flagHasBase)
            ++result;
        if (flagHasProperty)
            ++result;
        result += extraImplicitPropertyDerivationComponentCount();
        return result;
      }
    public override string extraDerivationComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBase)
          {
            if (remainder == 0)
                return "Base";
            --remainder;
          }
        if (flagHasProperty)
          {
            if (remainder == 0)
                return "Property";
            --remainder;
          }
        return extraImplicitPropertyDerivationComponentKey(remainder);
      }
    public override JSONValue extraDerivationComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBase)
          {
            if (remainder == 0)
                return extraBaseToJSON();
            --remainder;
          }
        if (flagHasProperty)
          {
            if (remainder == 0)
                return extraPropertyToJSON();
            --remainder;
          }
        return extraImplicitPropertyDerivationComponentValue(remainder);
      }
    public override JSONValue extraDerivationLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasBase ? extraBaseToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "roperty", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasProperty ? extraPropertyToJSON() : null);
                break;
            default:
                break;
          }
        return extraImplicitPropertyDerivationLookup(field_name);
      }

    public void setBase(DerivedGeneralizedThingJSON  new_value)
      {
        if (flagHasBase)
          {
          }
        flagHasBase = true;
        storeBase = new_value;
      }
    public void unsetBase()
      {
        if (flagHasBase)
          {
          }
        flagHasBase = false;
      }
    public void setProperty(PropertyJSON  new_value)
      {
        if (flagHasProperty)
          {
          }
        flagHasProperty = true;
        storeProperty = new_value;
      }
    public void unsetProperty()
      {
        if (flagHasProperty)
          {
          }
        flagHasProperty = false;
      }

    public virtual void extraImplicitPropertyDerivationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraImplicitPropertyDerivationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraImplicitPropertyDerivationLookup(key);
        if (old_field == null)
          {
            extraImplicitPropertyDerivationAppendPair(key, new_component);
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
    public override void extraDerivationAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "roperty", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONProperty(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraImplicitPropertyDerivationAppendPair(key, new_component);
      }
    public override void extraDerivationSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "ase", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONBase(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "roperty", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONProperty(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraImplicitPropertyDerivationSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasBase);
        if (flagHasBase)
          {
            handler.start_pair("Base");
            if (partial_allowed)
                storeBase.write_partial_as_json(handler);
            else
                storeBase.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasProperty);
        if (flagHasProperty)
          {
            handler.start_pair("Property");
            if (partial_allowed)
                storeProperty.write_partial_as_json(handler);
            else
                storeProperty.write_as_json(handler);
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
        if (!(hasBase()))
          {
            return "When parsing the object for %what%, the \"Base\" field was missing.";
          }
        if (!(hasProperty()))
          {
            return "When parsing the object for %what%, the \"Property\" field was missing.";
          }
        return null;
      }

    public static new ImplicitPropertyDerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ImplicitPropertyDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImplicitPropertyDerivation", ignore_extras);
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
    public static new ImplicitPropertyDerivationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ImplicitPropertyDerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ImplicitPropertyDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImplicitPropertyDerivation", ignore_extras);
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
    public static new ImplicitPropertyDerivationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ImplicitPropertyDerivationJSON from_text(string text, bool ignore_extras)
      {
        ImplicitPropertyDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImplicitPropertyDerivation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ImplicitPropertyDerivationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ImplicitPropertyDerivationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ImplicitPropertyDerivationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ImplicitPropertyDerivation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DerivationJSON.Generator
      {
        private DerivedGeneralizedThingJSON.HoldingGenerator fieldGeneratorBase;
        private PropertyJSON.HoldingGenerator fieldGeneratorProperty;
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
            if (!(getDerivationJSONKey().Equals("ImplicitProperty")))
                throw new Exception("The key field has a value other than `ImplicitProperty'.");
            ImplicitPropertyDerivationJSON result = new ImplicitPropertyDerivationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraImplicitPropertyDerivationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DerivationJSON new_result)
          {
            handle_result((ImplicitPropertyDerivationJSON )new_result);
          }
        protected void finish(ImplicitPropertyDerivationJSON result)
          {
            if (fieldGeneratorBase.have_value)
              {
                result.setBase(fieldGeneratorBase.value);
                fieldGeneratorBase.have_value = false;
              }
            else if ((!(result.hasBase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Base\" field was missing.");
              }
            if (fieldGeneratorProperty.have_value)
              {
                result.setProperty(fieldGeneratorProperty.value);
                fieldGeneratorProperty.have_value = false;
              }
            else if ((!(result.hasProperty())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Property\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ImplicitPropertyDerivationJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "ase", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorBase;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roperty", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorProperty;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBase = new DerivedGeneralizedThingJSON.HoldingGenerator("field \"Base\" of the ImplicitPropertyDerivation class", ignore_extras);
            fieldGeneratorProperty = new PropertyJSON.HoldingGenerator("field \"Property\" of the ImplicitPropertyDerivation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ImplicitPropertyDerivation class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBase = new DerivedGeneralizedThingJSON.HoldingGenerator("field \"Base\" of the ImplicitPropertyDerivation class", false);
            fieldGeneratorProperty = new PropertyJSON.HoldingGenerator("field \"Property\" of the ImplicitPropertyDerivation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ImplicitPropertyDerivation class");
          }

        public override void reset()
          {
            fieldGeneratorBase.reset();
            fieldGeneratorProperty.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ImplicitPropertyDerivationJSON  result)
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
        public ImplicitPropertyDerivationJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ImplicitPropertyDerivationJSON  result)
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
    protected virtual void handle_result(List<ImplicitPropertyDerivationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ImplicitPropertyDerivationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ImplicitPropertyDerivationJSON>();
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
    public List<ImplicitPropertyDerivationJSON> value;
  };
  };
