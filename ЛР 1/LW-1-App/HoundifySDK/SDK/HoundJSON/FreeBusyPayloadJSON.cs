/* file "FreeBusyPayloadJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FreeBusyPayloadJSON : JSONBase
  {
    public class TypeitemsJSON : JSONBase
      {
        private bool flagHasid;
        private string storeid;


        private void  fromJSONid(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field id of TypeitemsJSON is not a string.");
            setid(json_string.getData());
          }


        public TypeitemsJSON()
          {
            flagHasid = false;
          }

        public bool  hasid()
          {
            return flagHasid;
          }

        public string  getid()
          {
            Debug.Assert(flagHasid);
            return storeid;
          }



        public void setid(string new_value)
          {
            flagHasid = true;
            storeid = new_value;
          }
        public void unsetid()
          {
            flagHasid = false;
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
            if (flagHasid)
              {
                handler.start_pair("id");
                handler.string_value(storeid);
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
            return null;
          }

        public static TypeitemsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeitemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeitems", ignore_extras);
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
        public static TypeitemsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeitemsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeitemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeitems", ignore_extras);
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
        public static TypeitemsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeitemsJSON from_text(string text, bool ignore_extras)
          {
            TypeitemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeitems", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeitemsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeitemsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeitemsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type Typeitems", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorid;

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
                TypeitemsJSON result = new TypeitemsJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeitemsJSON result)
              {
                if (fieldGeneratorid.have_value)
                  {
                    result.setid(fieldGeneratorid.value);
                    fieldGeneratorid.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeitemsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "id", 0, 2, false) == 0) && (field_name.Length == 2))
                    return fieldGeneratorid;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeitems class");
                set_what("the Typeitems class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the Typeitems class");
                set_what("the Typeitems class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorid.reset();
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
            protected override void handle_result(TypeitemsJSON  result)
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
            public TypeitemsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeitemsJSON  result)
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
        protected virtual void handle_result(List<TypeitemsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeitemsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeitemsJSON>();
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
        public List<TypeitemsJSON> value;
      };
      };
    private bool flagHastimeMin;
    private string storetimeMin;
    private bool flagHastimeMax;
    private string storetimeMax;
    private bool flagHastimeZone;
    private string storetimeZone;
    private bool flagHascalendarExpansionMax;
    private BigInteger storecalendarExpansionMax;
    private bool flagHasitems;
    private List< TypeitemsJSON  > storeitems;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtimeMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field timeMin of FreeBusyPayloadJSON is not a string.");
        settimeMin(json_string.getData());
      }


    private void  fromJSONtimeMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field timeMax of FreeBusyPayloadJSON is not a string.");
        settimeMax(json_string.getData());
      }


    private void  fromJSONtimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field timeZone of FreeBusyPayloadJSON is not a string.");
        settimeZone(json_string.getData());
      }


    private void  fromJSONcalendarExpansionMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field calendarExpansionMax of FreeBusyPayloadJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field calendarExpansionMax of FreeBusyPayloadJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setcalendarExpansionMax(extracted_integer);
      }


    private void  fromJSONitems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field items of FreeBusyPayloadJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field items of FreeBusyPayloadJSON has too few elements.");
        List< TypeitemsJSON  > vector_items1 = new List< TypeitemsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeitemsJSON convert_classy = TypeitemsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_items1.Add(convert_classy);
          }
        Debug.Assert(vector_items1.Count >= 1);
        inititems();
        for (int num1 = 0; num1 < vector_items1.Count; ++num1)
            appenditems(vector_items1[num1]);
        for (int num1 = 0; num1 < vector_items1.Count; ++num1)
          {
          }
      }


    public FreeBusyPayloadJSON()
      {
        flagHastimeMin = false;
        flagHastimeMax = false;
        flagHastimeZone = false;
        flagHascalendarExpansionMax = false;
        flagHasitems = false;
        storeitems = new List< TypeitemsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hastimeMin()
      {
        return flagHastimeMin;
      }

    public string  gettimeMin()
      {
        Debug.Assert(flagHastimeMin);
        return storetimeMin;
      }

    public bool  hastimeMax()
      {
        return flagHastimeMax;
      }

    public string  gettimeMax()
      {
        Debug.Assert(flagHastimeMax);
        return storetimeMax;
      }

    public bool  hastimeZone()
      {
        return flagHastimeZone;
      }

    public string  gettimeZone()
      {
        Debug.Assert(flagHastimeZone);
        return storetimeZone;
      }

    public bool  hascalendarExpansionMax()
      {
        return flagHascalendarExpansionMax;
      }

    public BigInteger  getcalendarExpansionMax()
      {
        Debug.Assert(flagHascalendarExpansionMax);
        return storecalendarExpansionMax;
      }

    public bool  hasitems()
      {
        return flagHasitems;
      }

    public int  countOfitems()
      {
        Debug.Assert(flagHasitems);
        return storeitems.Count;
      }

    public TypeitemsJSON   elementOfitems(int element_num)
      {
        Debug.Assert(flagHasitems);
        return storeitems[element_num];
      }

    public List< TypeitemsJSON  >  getitems()
      {
        Debug.Assert(flagHasitems);
        return storeitems;
      }


    public virtual int extraFreeBusyPayloadComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFreeBusyPayloadComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFreeBusyPayloadComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFreeBusyPayloadLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void settimeMin(string new_value)
      {
        flagHastimeMin = true;
        storetimeMin = new_value;
      }
    public void unsettimeMin()
      {
        flagHastimeMin = false;
      }
    public void settimeMax(string new_value)
      {
        flagHastimeMax = true;
        storetimeMax = new_value;
      }
    public void unsettimeMax()
      {
        flagHastimeMax = false;
      }
    public void settimeZone(string new_value)
      {
        flagHastimeZone = true;
        storetimeZone = new_value;
      }
    public void unsettimeZone()
      {
        flagHastimeZone = false;
      }
    public void setcalendarExpansionMax(BigInteger new_value)
      {
        flagHascalendarExpansionMax = true;
        storecalendarExpansionMax = new_value;
      }
    public void unsetcalendarExpansionMax()
      {
        flagHascalendarExpansionMax = false;
      }
    public void inititems()
      {
        if (flagHasitems)
          {
            for (int num1 = 0; num1 < storeitems.Count; ++num1)
              {
              }
          }
        flagHasitems = true;
        storeitems.Clear();
      }
    public void appenditems(TypeitemsJSON  to_append)
      {
        if (!flagHasitems)
          {
            flagHasitems = true;
            storeitems.Clear();
          }
        Debug.Assert(flagHasitems);
        storeitems.Add(to_append);
      }
    public void unsetitems()
      {
        if (flagHasitems)
          {
            for (int num2 = 0; num2 < storeitems.Count; ++num2)
              {
              }
          }
        flagHasitems = false;
        storeitems.Clear();
      }

    public virtual void extraFreeBusyPayloadAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFreeBusyPayloadSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFreeBusyPayloadLookup(key);
        if (old_field == null)
          {
            extraFreeBusyPayloadAppendPair(key, new_component);
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
        if (flagHastimeMin)
          {
            handler.start_pair("timeMin");
            handler.string_value(storetimeMin);
          }
        if (flagHastimeMax)
          {
            handler.start_pair("timeMax");
            handler.string_value(storetimeMax);
          }
        if (flagHastimeZone)
          {
            handler.start_pair("timeZone");
            handler.string_value(storetimeZone);
          }
        if (flagHascalendarExpansionMax)
          {
            handler.start_pair("calendarExpansionMax");
            handler.number_value(storecalendarExpansionMax);
          }
        if (flagHasitems)
          {
            handler.start_pair("items");
            Debug.Assert(storeitems.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeitems.Count; ++num1)
              {
                if (partial_allowed)
                    storeitems[num1].write_partial_as_json(handler);
                else
                    storeitems[num1].write_as_json(handler);
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

    public static FreeBusyPayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyPayload", ignore_extras);
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
    public static FreeBusyPayloadJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FreeBusyPayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyPayload", ignore_extras);
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
    public static FreeBusyPayloadJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FreeBusyPayloadJSON from_text(string text, bool ignore_extras)
      {
        FreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyPayload", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FreeBusyPayloadJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FreeBusyPayloadJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FreeBusyPayloadJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FreeBusyPayload", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratortimeMin;
        private JSONHoldingStringGenerator fieldGeneratortimeMax;
        private JSONHoldingStringGenerator fieldGeneratortimeZone;
    private class FieldHoldingGeneratorcalendarExpansionMax : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorcalendarExpansionMax(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorcalendarExpansionMax : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorcalendarExpansionMax(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorcalendarExpansionMax fieldGeneratorcalendarExpansionMax;
        private TypeitemsJSON.HoldingArrayGenerator fieldGeneratoritems;
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
            FreeBusyPayloadJSON result = new FreeBusyPayloadJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFreeBusyPayloadAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FreeBusyPayloadJSON result)
          {
            if (fieldGeneratortimeMin.have_value)
              {
                result.settimeMin(fieldGeneratortimeMin.value);
                fieldGeneratortimeMin.have_value = false;
              }
            if (fieldGeneratortimeMax.have_value)
              {
                result.settimeMax(fieldGeneratortimeMax.value);
                fieldGeneratortimeMax.have_value = false;
              }
            if (fieldGeneratortimeZone.have_value)
              {
                result.settimeZone(fieldGeneratortimeZone.value);
                fieldGeneratortimeZone.have_value = false;
              }
            if (fieldGeneratorcalendarExpansionMax.have_value)
              {
                result.setcalendarExpansionMax(fieldGeneratorcalendarExpansionMax.value);
                fieldGeneratorcalendarExpansionMax.have_value = false;
              }
            if (fieldGeneratoritems.have_value)
              {
                result.inititems();
                int count = fieldGeneratoritems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appenditems(fieldGeneratoritems.value[num]);
                  }
                fieldGeneratoritems.value.Clear();
                fieldGeneratoritems.have_value = false;
              }
          }
        protected abstract void handle_result(FreeBusyPayloadJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if ((String.Compare(field_name, 1, "alendarExpansionMax", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorcalendarExpansionMax;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "tems", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratoritems;
                    break;
                case 't':
                    if (String.Compare(field_name, 1, "ime", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'M':
                                switch (field_name[5])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 6, "x", 0, 1, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratortimeMax;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 6, "n", 0, 1, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratortimeMin;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'Z':
                                if ((String.Compare(field_name, 5, "one", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratortimeZone;
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
            fieldGeneratortimeMin = new JSONHoldingStringGenerator("field \"timeMin\" of the FreeBusyPayload class");
            fieldGeneratortimeMax = new JSONHoldingStringGenerator("field \"timeMax\" of the FreeBusyPayload class");
            fieldGeneratortimeZone = new JSONHoldingStringGenerator("field \"timeZone\" of the FreeBusyPayload class");
            fieldGeneratorcalendarExpansionMax = new FieldHoldingGeneratorcalendarExpansionMax("field \"calendarExpansionMax\" of the FreeBusyPayload class");
            fieldGeneratoritems = new TypeitemsJSON.HoldingArrayGenerator("field \"items\" of the FreeBusyPayload class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FreeBusyPayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortimeMin = new JSONHoldingStringGenerator("field \"timeMin\" of the FreeBusyPayload class");
            fieldGeneratortimeMax = new JSONHoldingStringGenerator("field \"timeMax\" of the FreeBusyPayload class");
            fieldGeneratortimeZone = new JSONHoldingStringGenerator("field \"timeZone\" of the FreeBusyPayload class");
            fieldGeneratorcalendarExpansionMax = new FieldHoldingGeneratorcalendarExpansionMax("field \"calendarExpansionMax\" of the FreeBusyPayload class");
            fieldGeneratoritems = new TypeitemsJSON.HoldingArrayGenerator("field \"items\" of the FreeBusyPayload class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FreeBusyPayload class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortimeMin.reset();
            fieldGeneratortimeMax.reset();
            fieldGeneratortimeZone.reset();
            fieldGeneratorcalendarExpansionMax.reset();
            fieldGeneratoritems.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratoritems.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratoritems.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FreeBusyPayloadJSON  result)
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
        public FreeBusyPayloadJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FreeBusyPayloadJSON  result)
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
    protected virtual void handle_result(List<FreeBusyPayloadJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FreeBusyPayloadJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FreeBusyPayloadJSON>();
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
    public List<FreeBusyPayloadJSON> value;
  };
  };
