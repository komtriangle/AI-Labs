/* file "IHeartRadioForYouAPIResponseValueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioForYouAPIResponseValueJSON : JSONBase
  {
    public enum TypesubTypeKnownValues
      {
        subType_LIVE,
        subType__none
      };
    public struct TypesubType
      {
        public bool in_known_list;
        public string string_value;
        public TypesubTypeKnownValues list_value;
      };

    public static TypesubTypeKnownValues  stringTosubType(string chars)
      {
        if ((String.Compare(chars, 0, "LIVE", 0, 4, false) == 0) && (chars.Length == 4))
            return TypesubTypeKnownValues.subType_LIVE;
        return TypesubTypeKnownValues.subType__none;
      }

    public static string  stringFromsubType(TypesubTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypesubTypeKnownValues.subType_LIVE:
                return "LIVE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHassubType;
    private TypesubType storesubType;
    private bool flagHascontent;
    private IHeartRadioForYouAPIResponseContentJSON  storecontent;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONsubType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field subType of IHeartRadioForYouAPIResponseValueJSON is not a string.");
        TypesubType the_open_enum = new TypesubType();
        if ((String.Compare(json_string.getData(), 0, "LIVE", 0, 4, false) == 0) && (json_string.getData().Length == 4))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypesubTypeKnownValues.subType_LIVE;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setsubType(the_open_enum);
      }


    private void  fromJSONcontent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioForYouAPIResponseContentJSON convert_classy = IHeartRadioForYouAPIResponseContentJSON.from_json(json_value, ignore_extras, true);
        setcontent(convert_classy);
      }


    public IHeartRadioForYouAPIResponseValueJSON()
      {
        flagHassubType = false;
        flagHascontent = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hassubType()
      {
        return flagHassubType;
      }

    public TypesubType  getsubType()
      {
        Debug.Assert(flagHassubType);
        return storesubType;
      }

    public string  getsubTypeAsString()
      {
        TypesubType result = getsubType();
        if (result.in_known_list)
            return stringFromsubType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hascontent()
      {
        return flagHascontent;
      }

    public IHeartRadioForYouAPIResponseContentJSON   getcontent()
      {
        Debug.Assert(flagHascontent);
        return storecontent;
      }


    public virtual int extraIHeartRadioForYouAPIResponseValueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioForYouAPIResponseValueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseValueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioForYouAPIResponseValueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setsubType(TypesubType new_value)
      {
        flagHassubType = true;
        storesubType = new_value;
      }
    public void setsubType(string chars)
      {
        TypesubTypeKnownValues known = stringTosubType(chars);
        TypesubType new_value = new TypesubType();
        if (known == TypesubTypeKnownValues.subType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setsubType(new_value);
      }
    public void setsubType(TypesubTypeKnownValues new_value)
      {
        TypesubType new_full_value = new TypesubType();
        Debug.Assert(new_value != TypesubTypeKnownValues.subType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setsubType(new_full_value);
      }
    public void unsetsubType()
      {
        flagHassubType = false;
      }
    public void setcontent(IHeartRadioForYouAPIResponseContentJSON  new_value)
      {
        if (flagHascontent)
          {
          }
        flagHascontent = true;
        storecontent = new_value;
      }
    public void unsetcontent()
      {
        if (flagHascontent)
          {
          }
        flagHascontent = false;
      }

    public virtual void extraIHeartRadioForYouAPIResponseValueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioForYouAPIResponseValueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioForYouAPIResponseValueLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioForYouAPIResponseValueAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHassubType);
        if (flagHassubType)
          {
            handler.start_pair("subType");
            if (storesubType.in_known_list)
              {
                switch (storesubType.list_value)
                  {
                    case TypesubTypeKnownValues.subType_LIVE:
                        handler.string_value("LIVE");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storesubType.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHascontent);
        if (flagHascontent)
          {
            handler.start_pair("content");
            if (partial_allowed)
                storecontent.write_partial_as_json(handler);
            else
                storecontent.write_as_json(handler);
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
        if (!(hassubType()))
          {
            return "When parsing the object for %what%, the \"subType\" field was missing.";
          }
        if (!(hascontent()))
          {
            return "When parsing the object for %what%, the \"content\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioForYouAPIResponseValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseValue", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioForYouAPIResponseValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseValue", ignore_extras);
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
    public static IHeartRadioForYouAPIResponseValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioForYouAPIResponseValueJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseValue", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioForYouAPIResponseValueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioForYouAPIResponseValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioForYouAPIResponseValueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioForYouAPIResponseValue", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorsubType : JSONStringGenerator
          {
            protected FieldGeneratorsubType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorsubType()
              {
              }
            protected override void handle_result(string result)
              {
                TypesubTypeKnownValues known = stringTosubType(result);
                TypesubType new_value = new TypesubType();
                if (known == TypesubTypeKnownValues.subType__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypesubType result);
          };
    private class FieldHoldingGeneratorsubType : FieldGeneratorsubType
  {
    protected override void handle_result(TypesubType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorsubType(String what)
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
    public TypesubType value;
  };
    private class FieldHoldingArrayGeneratorsubType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorsubType
      {
        private FieldHoldingArrayGeneratorsubType top;

        protected override void handle_result(TypesubType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsubType init_top)
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
    protected virtual void handle_result(List<TypesubType> result)
      {
      }

    public FieldHoldingArrayGeneratorsubType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypesubType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsubType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypesubType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypesubType> value;
  };
        private FieldHoldingGeneratorsubType fieldGeneratorsubType;
        private IHeartRadioForYouAPIResponseContentJSON.HoldingGenerator fieldGeneratorcontent;
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
            IHeartRadioForYouAPIResponseValueJSON result = new IHeartRadioForYouAPIResponseValueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioForYouAPIResponseValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioForYouAPIResponseValueJSON result)
          {
            if (fieldGeneratorsubType.have_value)
              {
                result.setsubType(fieldGeneratorsubType.value);
                fieldGeneratorsubType.have_value = false;
              }
            else if ((!(result.hassubType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"subType\" field was missing.");
              }
            if (fieldGeneratorcontent.have_value)
              {
                result.setcontent(fieldGeneratorcontent.value);
                fieldGeneratorcontent.have_value = false;
              }
            else if ((!(result.hascontent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"content\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioForYouAPIResponseValueJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if ((String.Compare(field_name, 1, "ontent", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorcontent;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "ubType", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorsubType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorsubType = new FieldHoldingGeneratorsubType("field \"subType\" of the IHeartRadioForYouAPIResponseValue class");
            fieldGeneratorcontent = new IHeartRadioForYouAPIResponseContentJSON.HoldingGenerator("field \"content\" of the IHeartRadioForYouAPIResponseValue class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioForYouAPIResponseValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorsubType = new FieldHoldingGeneratorsubType("field \"subType\" of the IHeartRadioForYouAPIResponseValue class");
            fieldGeneratorcontent = new IHeartRadioForYouAPIResponseContentJSON.HoldingGenerator("field \"content\" of the IHeartRadioForYouAPIResponseValue class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioForYouAPIResponseValue class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorsubType.reset();
            fieldGeneratorcontent.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorcontent.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorcontent.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioForYouAPIResponseValueJSON  result)
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
        public IHeartRadioForYouAPIResponseValueJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioForYouAPIResponseValueJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioForYouAPIResponseValueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioForYouAPIResponseValueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioForYouAPIResponseValueJSON>();
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
    public List<IHeartRadioForYouAPIResponseValueJSON> value;
  };
  };
