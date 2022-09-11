/* file "GeonameFactsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeonameFactsQueryStateJSON : JSONBase
  {
    public enum TypeGeonameFactsCommandKind
      {
        GeonameFactsCommandKind_GeonameFactsInformationNugget,
        GeonameFactsCommandKind_GeonameFactsCommand
      };

    public static TypeGeonameFactsCommandKind  stringToGeonameFactsCommandKind(string chars)
      {
        if (String.Compare(chars, 0, "GeonameFacts", 0, 12, false) == 0)
          {
            switch (chars[12])
              {
                case 'C':
                    if ((String.Compare(chars, 13, "ommand", 0, 6, false) == 0) && (chars.Length == 19))
                        return TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsCommand;
                    break;
                case 'I':
                    if ((String.Compare(chars, 13, "nformationNugget", 0, 16, false) == 0) && (chars.Length == 29))
                        return TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsInformationNugget;
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field `GeonameFactsCommandKind' is not one of the legal values.");
      }

    public static string  stringFromGeonameFactsCommandKind(TypeGeonameFactsCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsInformationNugget:
                return "GeonameFactsInformationNugget";
            case TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsCommand:
                return "GeonameFactsCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasGeonameFactsCommandKind;
    private TypeGeonameFactsCommandKind storeGeonameFactsCommandKind;
    private bool flagHasGeonames;
    private List< GeonameObjectJSON  > storeGeonames;
    private bool flagHasGeonameAttributes;
    private List< GeonameAttributeWithArgumentsJSON  > storeGeonameAttributes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGeonameFactsCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GeonameFactsCommandKind of GeonameFactsQueryStateJSON is not a string.");
        TypeGeonameFactsCommandKind the_enum;
        if (String.Compare(json_string.getData(), 0, "GeonameFacts", 0, 12, false) == 0)
          {
            switch (json_string.getData()[12])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 13, "ommand", 0, 6, false) == 0) && (json_string.getData().Length == 19))
                          {
                            the_enum = TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsCommand;
                            goto enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 13, "nformationNugget", 0, 16, false) == 0) && (json_string.getData().Length == 29))
                          {
                            the_enum = TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsInformationNugget;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        throw new Exception("The value for field GeonameFactsCommandKind of GeonameFactsQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setGeonameFactsCommandKind(the_enum);
      }


    private void  fromJSONGeonames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Geonames of GeonameFactsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameObjectJSON  > vector_Geonames1 = new List< GeonameObjectJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameObjectJSON convert_classy = GeonameObjectJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Geonames1.Add(convert_classy);
          }
        initGeonames();
        for (int num1 = 0; num1 < vector_Geonames1.Count; ++num1)
            appendGeonames(vector_Geonames1[num1]);
        for (int num1 = 0; num1 < vector_Geonames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGeonameAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GeonameAttributes of GeonameFactsQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< GeonameAttributeWithArgumentsJSON  > vector_GeonameAttributes1 = new List< GeonameAttributeWithArgumentsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeonameAttributeWithArgumentsJSON convert_classy = GeonameAttributeWithArgumentsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GeonameAttributes1.Add(convert_classy);
          }
        initGeonameAttributes();
        for (int num2 = 0; num2 < vector_GeonameAttributes1.Count; ++num2)
            appendGeonameAttributes(vector_GeonameAttributes1[num2]);
        for (int num1 = 0; num1 < vector_GeonameAttributes1.Count; ++num1)
          {
          }
      }


    public GeonameFactsQueryStateJSON()
      {
        flagHasGeonameFactsCommandKind = false;
        flagHasGeonames = false;
        flagHasGeonameAttributes = false;
        storeGeonames = new List< GeonameObjectJSON  >();
        storeGeonameAttributes = new List< GeonameAttributeWithArgumentsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGeonameFactsCommandKind()
      {
        return flagHasGeonameFactsCommandKind;
      }

    public TypeGeonameFactsCommandKind  getGeonameFactsCommandKind()
      {
        Debug.Assert(flagHasGeonameFactsCommandKind);
        return storeGeonameFactsCommandKind;
      }

    public string  getGeonameFactsCommandKindAsString()
      {
        return stringFromGeonameFactsCommandKind(getGeonameFactsCommandKind());
      }

    public bool  hasGeonames()
      {
        return flagHasGeonames;
      }

    public int  countOfGeonames()
      {
        Debug.Assert(flagHasGeonames);
        return storeGeonames.Count;
      }

    public GeonameObjectJSON   elementOfGeonames(int element_num)
      {
        Debug.Assert(flagHasGeonames);
        return storeGeonames[element_num];
      }

    public List< GeonameObjectJSON  >  getGeonames()
      {
        Debug.Assert(flagHasGeonames);
        return storeGeonames;
      }

    public bool  hasGeonameAttributes()
      {
        return flagHasGeonameAttributes;
      }

    public int  countOfGeonameAttributes()
      {
        Debug.Assert(flagHasGeonameAttributes);
        return storeGeonameAttributes.Count;
      }

    public GeonameAttributeWithArgumentsJSON   elementOfGeonameAttributes(int element_num)
      {
        Debug.Assert(flagHasGeonameAttributes);
        return storeGeonameAttributes[element_num];
      }

    public List< GeonameAttributeWithArgumentsJSON  >  getGeonameAttributes()
      {
        Debug.Assert(flagHasGeonameAttributes);
        return storeGeonameAttributes;
      }


    public virtual int extraGeonameFactsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeonameFactsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeonameFactsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeonameFactsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGeonameFactsCommandKind(TypeGeonameFactsCommandKind new_value)
      {
        flagHasGeonameFactsCommandKind = true;
        storeGeonameFactsCommandKind = new_value;
      }
    public void setGeonameFactsCommandKind(string chars)
      {
        setGeonameFactsCommandKind(stringToGeonameFactsCommandKind(chars));
      }
    public void unsetGeonameFactsCommandKind()
      {
        flagHasGeonameFactsCommandKind = false;
      }
    public void initGeonames()
      {
        if (flagHasGeonames)
          {
            for (int num1 = 0; num1 < storeGeonames.Count; ++num1)
              {
              }
          }
        flagHasGeonames = true;
        storeGeonames.Clear();
      }
    public void appendGeonames(GeonameObjectJSON  to_append)
      {
        if (!flagHasGeonames)
          {
            flagHasGeonames = true;
            storeGeonames.Clear();
          }
        Debug.Assert(flagHasGeonames);
        storeGeonames.Add(to_append);
      }
    public void unsetGeonames()
      {
        if (flagHasGeonames)
          {
            for (int num2 = 0; num2 < storeGeonames.Count; ++num2)
              {
              }
          }
        flagHasGeonames = false;
        storeGeonames.Clear();
      }
    public void initGeonameAttributes()
      {
        if (flagHasGeonameAttributes)
          {
            for (int num3 = 0; num3 < storeGeonameAttributes.Count; ++num3)
              {
              }
          }
        flagHasGeonameAttributes = true;
        storeGeonameAttributes.Clear();
      }
    public void appendGeonameAttributes(GeonameAttributeWithArgumentsJSON  to_append)
      {
        if (!flagHasGeonameAttributes)
          {
            flagHasGeonameAttributes = true;
            storeGeonameAttributes.Clear();
          }
        Debug.Assert(flagHasGeonameAttributes);
        storeGeonameAttributes.Add(to_append);
      }
    public void unsetGeonameAttributes()
      {
        if (flagHasGeonameAttributes)
          {
            for (int num4 = 0; num4 < storeGeonameAttributes.Count; ++num4)
              {
              }
          }
        flagHasGeonameAttributes = false;
        storeGeonameAttributes.Clear();
      }

    public virtual void extraGeonameFactsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeonameFactsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeonameFactsQueryStateLookup(key);
        if (old_field == null)
          {
            extraGeonameFactsQueryStateAppendPair(key, new_component);
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
        if (flagHasGeonameFactsCommandKind)
          {
            handler.start_pair("GeonameFactsCommandKind");
            switch (storeGeonameFactsCommandKind)
              {
                case TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsInformationNugget:
                    handler.string_value("GeonameFactsInformationNugget");
                    break;
                case TypeGeonameFactsCommandKind.GeonameFactsCommandKind_GeonameFactsCommand:
                    handler.string_value("GeonameFactsCommand");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasGeonames)
          {
            handler.start_pair("Geonames");
            handler.start_array();
            for (int num1 = 0; num1 < storeGeonames.Count; ++num1)
              {
                if (partial_allowed)
                    storeGeonames[num1].write_partial_as_json(handler);
                else
                    storeGeonames[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGeonameAttributes)
          {
            handler.start_pair("GeonameAttributes");
            handler.start_array();
            for (int num2 = 0; num2 < storeGeonameAttributes.Count; ++num2)
              {
                if (partial_allowed)
                    storeGeonameAttributes[num2].write_partial_as_json(handler);
                else
                    storeGeonameAttributes[num2].write_as_json(handler);
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
        return null;
      }

    public static GeonameFactsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameFactsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsQueryState", ignore_extras);
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
    public static GeonameFactsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameFactsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameFactsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsQueryState", ignore_extras);
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
    public static GeonameFactsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameFactsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        GeonameFactsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameFactsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeonameFactsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameFactsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameFactsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorGeonameFactsCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorGeonameFactsCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorGeonameFactsCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToGeonameFactsCommandKind(result));
              }
            protected abstract void handle_result(TypeGeonameFactsCommandKind result);
          };
    private class FieldHoldingGeneratorGeonameFactsCommandKind : FieldGeneratorGeonameFactsCommandKind
  {
    protected override void handle_result(TypeGeonameFactsCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorGeonameFactsCommandKind(String what)
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
    public TypeGeonameFactsCommandKind value;
  };
    private class FieldHoldingArrayGeneratorGeonameFactsCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGeonameFactsCommandKind
      {
        private FieldHoldingArrayGeneratorGeonameFactsCommandKind top;

        protected override void handle_result(TypeGeonameFactsCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGeonameFactsCommandKind init_top)
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
    protected virtual void handle_result(List<TypeGeonameFactsCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorGeonameFactsCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGeonameFactsCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGeonameFactsCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGeonameFactsCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGeonameFactsCommandKind> value;
  };
        private FieldHoldingGeneratorGeonameFactsCommandKind fieldGeneratorGeonameFactsCommandKind;
        private GeonameObjectJSON.HoldingArrayGenerator fieldGeneratorGeonames;
        private GeonameAttributeWithArgumentsJSON.HoldingArrayGenerator fieldGeneratorGeonameAttributes;
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
            GeonameFactsQueryStateJSON result = new GeonameFactsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeonameFactsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GeonameFactsQueryStateJSON result)
          {
            if (fieldGeneratorGeonameFactsCommandKind.have_value)
              {
                result.setGeonameFactsCommandKind(fieldGeneratorGeonameFactsCommandKind.value);
                fieldGeneratorGeonameFactsCommandKind.have_value = false;
              }
            if (fieldGeneratorGeonames.have_value)
              {
                result.initGeonames();
                int count = fieldGeneratorGeonames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGeonames(fieldGeneratorGeonames.value[num]);
                  }
                fieldGeneratorGeonames.value.Clear();
                fieldGeneratorGeonames.have_value = false;
              }
            if (fieldGeneratorGeonameAttributes.have_value)
              {
                result.initGeonameAttributes();
                int count = fieldGeneratorGeonameAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGeonameAttributes(fieldGeneratorGeonameAttributes.value[num]);
                  }
                fieldGeneratorGeonameAttributes.value.Clear();
                fieldGeneratorGeonameAttributes.have_value = false;
              }
          }
        protected abstract void handle_result(GeonameFactsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Geoname", 0, 7, false) == 0)
              {
                switch (field_name[7])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 8, "ttributes", 0, 9, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorGeonameAttributes;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 8, "actsCommandKind", 0, 15, false) == 0) && (field_name.Length == 23))
                            return fieldGeneratorGeonameFactsCommandKind;
                        break;
                    case 's':
                        if (field_name.Length == 8)
                            return fieldGeneratorGeonames;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGeonameFactsCommandKind = new FieldHoldingGeneratorGeonameFactsCommandKind("field \"GeonameFactsCommandKind\" of the GeonameFactsQueryState class");
            fieldGeneratorGeonames = new GeonameObjectJSON.HoldingArrayGenerator("field \"Geonames\" of the GeonameFactsQueryState class", ignore_extras);
            fieldGeneratorGeonameAttributes = new GeonameAttributeWithArgumentsJSON.HoldingArrayGenerator("field \"GeonameAttributes\" of the GeonameFactsQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeonameFactsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGeonameFactsCommandKind = new FieldHoldingGeneratorGeonameFactsCommandKind("field \"GeonameFactsCommandKind\" of the GeonameFactsQueryState class");
            fieldGeneratorGeonames = new GeonameObjectJSON.HoldingArrayGenerator("field \"Geonames\" of the GeonameFactsQueryState class", false);
            fieldGeneratorGeonameAttributes = new GeonameAttributeWithArgumentsJSON.HoldingArrayGenerator("field \"GeonameAttributes\" of the GeonameFactsQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeonameFactsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGeonameFactsCommandKind.reset();
            fieldGeneratorGeonames.reset();
            fieldGeneratorGeonameAttributes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorGeonames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGeonameAttributes.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorGeonames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGeonameAttributes.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameFactsQueryStateJSON  result)
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
        public GeonameFactsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameFactsQueryStateJSON  result)
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
    protected virtual void handle_result(List<GeonameFactsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameFactsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameFactsQueryStateJSON>();
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
    public List<GeonameFactsQueryStateJSON> value;
  };
  };
