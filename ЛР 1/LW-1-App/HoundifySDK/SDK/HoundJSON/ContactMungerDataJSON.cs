/* file "ContactMungerDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactMungerDataJSON : JSONBase
  {
    public class TypeMetaJSON : JSONBase
      {
        private bool flagHasRequestInfo;
        private RequestInfoJSON  storeRequestInfo;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONRequestInfo(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            RequestInfoJSON convert_classy = RequestInfoJSON.from_json(json_value, ignore_extras, true);
            setRequestInfo(convert_classy);
          }


        public TypeMetaJSON()
          {
            flagHasRequestInfo = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasRequestInfo()
          {
            return flagHasRequestInfo;
          }

        public RequestInfoJSON   getRequestInfo()
          {
            Debug.Assert(flagHasRequestInfo);
            return storeRequestInfo;
          }


        public virtual int extraTypeMetaComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeMetaComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeMetaComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeMetaLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setRequestInfo(RequestInfoJSON  new_value)
          {
            if (flagHasRequestInfo)
              {
              }
            flagHasRequestInfo = true;
            storeRequestInfo = new_value;
          }
        public void unsetRequestInfo()
          {
            if (flagHasRequestInfo)
              {
              }
            flagHasRequestInfo = false;
          }

        public virtual void extraTypeMetaAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeMetaSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeMetaLookup(key);
            if (old_field == null)
              {
                extraTypeMetaAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasRequestInfo);
            if (flagHasRequestInfo)
              {
                handler.start_pair("RequestInfo");
                if (partial_allowed)
                    storeRequestInfo.write_partial_as_json(handler);
                else
                    storeRequestInfo.write_as_json(handler);
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
            if (!(hasRequestInfo()))
              {
                return "When parsing the object for %what%, the \"RequestInfo\" field was missing.";
              }
            return null;
          }

        public static TypeMetaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMetaJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMeta", ignore_extras);
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
        public static TypeMetaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMetaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeMetaJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMeta", ignore_extras);
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
        public static TypeMetaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeMetaJSON from_text(string text, bool ignore_extras)
          {
            TypeMetaJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMeta", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeMetaJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeMetaJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeMetaJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeMeta", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private RequestInfoJSON.HoldingGenerator fieldGeneratorRequestInfo;
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
                TypeMetaJSON result = new TypeMetaJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeMetaAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeMetaJSON result)
              {
                if (fieldGeneratorRequestInfo.have_value)
                  {
                    result.setRequestInfo(fieldGeneratorRequestInfo.value);
                    fieldGeneratorRequestInfo.have_value = false;
                  }
                else if ((!(result.hasRequestInfo())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"RequestInfo\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeMetaJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "RequestInfo", 0, 11, false) == 0) && (field_name.Length == 11))
                    return fieldGeneratorRequestInfo;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorRequestInfo = new RequestInfoJSON.HoldingGenerator("field \"RequestInfo\" of the TypeMeta class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeMeta class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRequestInfo = new RequestInfoJSON.HoldingGenerator("field \"RequestInfo\" of the TypeMeta class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeMeta class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRequestInfo.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorRequestInfo.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorRequestInfo.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeMetaJSON  result)
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
            public TypeMetaJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeMetaJSON  result)
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
        protected virtual void handle_result(List<TypeMetaJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeMetaJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeMetaJSON>();
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
        public List<TypeMetaJSON> value;
      };
      };
    private bool flagHasMeta;
    private List< TypeMetaJSON  > storeMeta;
    private bool flagHasData;
    private ContactListJSON  storeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMeta(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Meta of ContactMungerDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Meta of ContactMungerDataJSON has too few elements.");
        List< TypeMetaJSON  > vector_Meta1 = new List< TypeMetaJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeMetaJSON convert_classy = TypeMetaJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Meta1.Add(convert_classy);
          }
        Debug.Assert(vector_Meta1.Count >= 1);
        initMeta();
        for (int num1 = 0; num1 < vector_Meta1.Count; ++num1)
            appendMeta(vector_Meta1[num1]);
        for (int num1 = 0; num1 < vector_Meta1.Count; ++num1)
          {
          }
      }


    private void  fromJSONData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ContactListJSON convert_classy = ContactListJSON.from_json(json_value, ignore_extras, true);
        setData(convert_classy);
      }


    public ContactMungerDataJSON()
      {
        flagHasMeta = false;
        flagHasData = false;
        storeMeta = new List< TypeMetaJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMeta()
      {
        return flagHasMeta;
      }

    public int  countOfMeta()
      {
        Debug.Assert(flagHasMeta);
        return storeMeta.Count;
      }

    public TypeMetaJSON   elementOfMeta(int element_num)
      {
        Debug.Assert(flagHasMeta);
        return storeMeta[element_num];
      }

    public List< TypeMetaJSON  >  getMeta()
      {
        Debug.Assert(flagHasMeta);
        return storeMeta;
      }

    public bool  hasData()
      {
        return flagHasData;
      }

    public ContactListJSON   getData()
      {
        Debug.Assert(flagHasData);
        return storeData;
      }


    public virtual int extraContactMungerDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactMungerDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactMungerDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactMungerDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initMeta()
      {
        if (flagHasMeta)
          {
            for (int num1 = 0; num1 < storeMeta.Count; ++num1)
              {
              }
          }
        flagHasMeta = true;
        storeMeta.Clear();
      }
    public void appendMeta(TypeMetaJSON  to_append)
      {
        if (!flagHasMeta)
          {
            flagHasMeta = true;
            storeMeta.Clear();
          }
        Debug.Assert(flagHasMeta);
        storeMeta.Add(to_append);
      }
    public void unsetMeta()
      {
        if (flagHasMeta)
          {
            for (int num2 = 0; num2 < storeMeta.Count; ++num2)
              {
              }
          }
        flagHasMeta = false;
        storeMeta.Clear();
      }
    public void setData(ContactListJSON  new_value)
      {
        if (flagHasData)
          {
          }
        flagHasData = true;
        storeData = new_value;
      }
    public void unsetData()
      {
        if (flagHasData)
          {
          }
        flagHasData = false;
      }

    public virtual void extraContactMungerDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactMungerDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactMungerDataLookup(key);
        if (old_field == null)
          {
            extraContactMungerDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMeta);
        if (flagHasMeta)
          {
            handler.start_pair("Meta");
            Debug.Assert(storeMeta.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeMeta.Count; ++num1)
              {
                if (partial_allowed)
                    storeMeta[num1].write_partial_as_json(handler);
                else
                    storeMeta[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasData);
        if (flagHasData)
          {
            handler.start_pair("Data");
            if (partial_allowed)
                storeData.write_partial_as_json(handler);
            else
                storeData.write_as_json(handler);
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
        if (!(hasMeta()))
          {
            return "When parsing the object for %what%, the \"Meta\" field was missing.";
          }
        if (!(hasData()))
          {
            return "When parsing the object for %what%, the \"Data\" field was missing.";
          }
        return null;
      }

    public static ContactMungerDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactMungerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerData", ignore_extras);
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
    public static ContactMungerDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactMungerDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactMungerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerData", ignore_extras);
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
    public static ContactMungerDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactMungerDataJSON from_text(string text, bool ignore_extras)
      {
        ContactMungerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactMungerDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactMungerDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactMungerDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactMungerData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeMetaJSON.HoldingArrayGenerator fieldGeneratorMeta;
        private ContactListJSON.HoldingGenerator fieldGeneratorData;
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
            ContactMungerDataJSON result = new ContactMungerDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactMungerDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ContactMungerDataJSON result)
          {
            if (fieldGeneratorMeta.have_value)
              {
                result.initMeta();
                int count = fieldGeneratorMeta.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMeta(fieldGeneratorMeta.value[num]);
                  }
                fieldGeneratorMeta.value.Clear();
                fieldGeneratorMeta.have_value = false;
              }
            else if ((!(result.hasMeta())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Meta\" field was missing.");
              }
            if (fieldGeneratorData.have_value)
              {
                result.setData(fieldGeneratorData.value);
                fieldGeneratorData.have_value = false;
              }
            else if ((!(result.hasData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Data\" field was missing.");
              }
          }
        protected abstract void handle_result(ContactMungerDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ata", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorData;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "eta", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorMeta;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMeta = new TypeMetaJSON.HoldingArrayGenerator("field \"Meta\" of the ContactMungerData class", ignore_extras);
            fieldGeneratorData = new ContactListJSON.HoldingGenerator("field \"Data\" of the ContactMungerData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactMungerData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMeta = new TypeMetaJSON.HoldingArrayGenerator("field \"Meta\" of the ContactMungerData class", false);
            fieldGeneratorData = new ContactListJSON.HoldingGenerator("field \"Data\" of the ContactMungerData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactMungerData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMeta.reset();
            fieldGeneratorData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMeta.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMeta.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactMungerDataJSON  result)
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
        public ContactMungerDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactMungerDataJSON  result)
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
    protected virtual void handle_result(List<ContactMungerDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactMungerDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactMungerDataJSON>();
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
    public List<ContactMungerDataJSON> value;
  };
  };
