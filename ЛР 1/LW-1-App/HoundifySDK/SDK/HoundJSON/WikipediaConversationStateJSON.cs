/* file "WikipediaConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class WikipediaConversationStateJSON : JSONBase
  {
    public class TypeEntriesJSON : JSONBase
      {
        private bool flagHasURI;
        private string storeURI;
        private bool flagHasOriginalID;
        private BigInteger storeOriginalID;
        private bool flagHasResolvedID;
        private BigInteger storeResolvedID;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONURI(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URI of TypeEntriesJSON is not a string.");
            setURI(json_string.getData());
          }


        private void  fromJSONOriginalID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OriginalID of TypeEntriesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OriginalID of TypeEntriesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOriginalID(extracted_integer);
          }


        private void  fromJSONResolvedID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ResolvedID of TypeEntriesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ResolvedID of TypeEntriesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setResolvedID(extracted_integer);
          }


        public TypeEntriesJSON()
          {
            flagHasURI = false;
            flagHasOriginalID = false;
            flagHasResolvedID = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasURI()
          {
            return flagHasURI;
          }

        public string  getURI()
          {
            Debug.Assert(flagHasURI);
            return storeURI;
          }

        public bool  hasOriginalID()
          {
            return flagHasOriginalID;
          }

        public BigInteger  getOriginalID()
          {
            Debug.Assert(flagHasOriginalID);
            return storeOriginalID;
          }

        public bool  hasResolvedID()
          {
            return flagHasResolvedID;
          }

        public BigInteger  getResolvedID()
          {
            Debug.Assert(flagHasResolvedID);
            return storeResolvedID;
          }


        public virtual int extraTypeEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEntriesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setURI(string new_value)
          {
            flagHasURI = true;
            storeURI = new_value;
          }
        public void unsetURI()
          {
            flagHasURI = false;
          }
        public void setOriginalID(BigInteger new_value)
          {
            flagHasOriginalID = true;
            storeOriginalID = new_value;
          }
        public void unsetOriginalID()
          {
            flagHasOriginalID = false;
          }
        public void setResolvedID(BigInteger new_value)
          {
            flagHasResolvedID = true;
            storeResolvedID = new_value;
          }
        public void unsetResolvedID()
          {
            flagHasResolvedID = false;
          }

        public virtual void extraTypeEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEntriesLookup(key);
            if (old_field == null)
              {
                extraTypeEntriesAppendPair(key, new_component);
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
            if (flagHasURI)
              {
                handler.start_pair("URI");
                handler.string_value(storeURI);
              }
            Debug.Assert(partial_allowed || flagHasOriginalID);
            if (flagHasOriginalID)
              {
                handler.start_pair("OriginalID");
                handler.number_value(storeOriginalID);
              }
            Debug.Assert(partial_allowed || flagHasResolvedID);
            if (flagHasResolvedID)
              {
                handler.start_pair("ResolvedID");
                handler.number_value(storeResolvedID);
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
            if (!(hasOriginalID()))
              {
                return "When parsing the object for %what%, the \"OriginalID\" field was missing.";
              }
            if (!(hasResolvedID()))
              {
                return "When parsing the object for %what%, the \"ResolvedID\" field was missing.";
              }
            return null;
          }

        public static TypeEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
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
        public static TypeEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
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
        public static TypeEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorURI;
        private class FieldHoldingGeneratorOriginalID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOriginalID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorOriginalID fieldGeneratorOriginalID;
        private class FieldHoldingGeneratorResolvedID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorResolvedID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorResolvedID fieldGeneratorResolvedID;
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
                TypeEntriesJSON result = new TypeEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEntriesJSON result)
              {
                if (fieldGeneratorURI.have_value)
                  {
                    result.setURI(fieldGeneratorURI.value);
                    fieldGeneratorURI.have_value = false;
                  }
                if (fieldGeneratorOriginalID.have_value)
                  {
                    result.setOriginalID(fieldGeneratorOriginalID.value);
                    fieldGeneratorOriginalID.have_value = false;
                  }
                else if ((!(result.hasOriginalID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"OriginalID\" field was missing.");
                  }
                if (fieldGeneratorResolvedID.have_value)
                  {
                    result.setResolvedID(fieldGeneratorResolvedID.value);
                    fieldGeneratorResolvedID.have_value = false;
                  }
                else if ((!(result.hasResolvedID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ResolvedID\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'O':
                        if ((String.Compare(field_name, 1, "riginalID", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorOriginalID;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "esolvedID", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorResolvedID;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RI", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURI;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeEntries class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeEntries class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeEntries class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeEntries class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorURI.reset();
                fieldGeneratorOriginalID.reset();
                fieldGeneratorResolvedID.reset();
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
            protected override void handle_result(TypeEntriesJSON  result)
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
            public TypeEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEntriesJSON  result)
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
        protected virtual void handle_result(List<TypeEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEntriesJSON>();
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
        public List<TypeEntriesJSON> value;
      };
      };
    private bool flagHasShortResponseOnly;
    private bool storeShortResponseOnly;
    private bool flagHasEntries;
    private List< TypeEntriesJSON  > storeEntries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONShortResponseOnly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ShortResponseOnly of WikipediaConversationStateJSON is not true for false.");
              }
          }
        setShortResponseOnly(the_bool);
      }


    private void  fromJSONEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Entries of WikipediaConversationStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Entries of WikipediaConversationStateJSON has too few elements.");
        List< TypeEntriesJSON  > vector_Entries1 = new List< TypeEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeEntriesJSON convert_classy = TypeEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Entries1.Add(convert_classy);
          }
        Debug.Assert(vector_Entries1.Count >= 1);
        initEntries();
        for (int num1 = 0; num1 < vector_Entries1.Count; ++num1)
            appendEntries(vector_Entries1[num1]);
        for (int num1 = 0; num1 < vector_Entries1.Count; ++num1)
          {
          }
      }


    public WikipediaConversationStateJSON()
      {
        flagHasShortResponseOnly = false;
        flagHasEntries = false;
        storeEntries = new List< TypeEntriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasShortResponseOnly()
      {
        return flagHasShortResponseOnly;
      }

    public bool  getShortResponseOnly()
      {
        Debug.Assert(flagHasShortResponseOnly);
        return storeShortResponseOnly;
      }

    public bool  hasEntries()
      {
        return flagHasEntries;
      }

    public int  countOfEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries.Count;
      }

    public TypeEntriesJSON   elementOfEntries(int element_num)
      {
        Debug.Assert(flagHasEntries);
        return storeEntries[element_num];
      }

    public List< TypeEntriesJSON  >  getEntries()
      {
        Debug.Assert(flagHasEntries);
        return storeEntries;
      }


    public virtual int extraWikipediaConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikipediaConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikipediaConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikipediaConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setShortResponseOnly(bool new_value)
      {
        flagHasShortResponseOnly = true;
        storeShortResponseOnly = new_value;
      }
    public void unsetShortResponseOnly()
      {
        flagHasShortResponseOnly = false;
      }
    public void initEntries()
      {
        if (flagHasEntries)
          {
            for (int num1 = 0; num1 < storeEntries.Count; ++num1)
              {
              }
          }
        flagHasEntries = true;
        storeEntries.Clear();
      }
    public void appendEntries(TypeEntriesJSON  to_append)
      {
        if (!flagHasEntries)
          {
            flagHasEntries = true;
            storeEntries.Clear();
          }
        Debug.Assert(flagHasEntries);
        storeEntries.Add(to_append);
      }
    public void unsetEntries()
      {
        if (flagHasEntries)
          {
            for (int num2 = 0; num2 < storeEntries.Count; ++num2)
              {
              }
          }
        flagHasEntries = false;
        storeEntries.Clear();
      }

    public virtual void extraWikipediaConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikipediaConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikipediaConversationStateLookup(key);
        if (old_field == null)
          {
            extraWikipediaConversationStateAppendPair(key, new_component);
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
        if (flagHasShortResponseOnly)
          {
            handler.start_pair("ShortResponseOnly");
            handler.boolean_value(storeShortResponseOnly);
          }
        Debug.Assert(partial_allowed || flagHasEntries);
        if (flagHasEntries)
          {
            handler.start_pair("Entries");
            Debug.Assert(storeEntries.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEntries.Count; ++num1)
              {
                if (partial_allowed)
                    storeEntries[num1].write_partial_as_json(handler);
                else
                    storeEntries[num1].write_as_json(handler);
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
        if (!(hasEntries()))
          {
            return "When parsing the object for %what%, the \"Entries\" field was missing.";
          }
        return null;
      }

    public static WikipediaConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaConversationState", ignore_extras);
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
    public static WikipediaConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikipediaConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaConversationState", ignore_extras);
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
    public static WikipediaConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikipediaConversationStateJSON from_text(string text, bool ignore_extras)
      {
        WikipediaConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikipediaConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WikipediaConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikipediaConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorShortResponseOnly;
        private TypeEntriesJSON.HoldingArrayGenerator fieldGeneratorEntries;
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
            WikipediaConversationStateJSON result = new WikipediaConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikipediaConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WikipediaConversationStateJSON result)
          {
            if (fieldGeneratorShortResponseOnly.have_value)
              {
                result.setShortResponseOnly(fieldGeneratorShortResponseOnly.value);
                fieldGeneratorShortResponseOnly.have_value = false;
              }
            if (fieldGeneratorEntries.have_value)
              {
                result.initEntries();
                int count = fieldGeneratorEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEntries(fieldGeneratorEntries.value[num]);
                  }
                fieldGeneratorEntries.value.Clear();
                fieldGeneratorEntries.have_value = false;
              }
            else if ((!(result.hasEntries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Entries\" field was missing.");
              }
          }
        protected abstract void handle_result(WikipediaConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ntries", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorEntries;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "hortResponseOnly", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorShortResponseOnly;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorShortResponseOnly = new JSONHoldingBooleanGenerator("field \"ShortResponseOnly\" of the WikipediaConversationState class");
            fieldGeneratorEntries = new TypeEntriesJSON.HoldingArrayGenerator("field \"Entries\" of the WikipediaConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikipediaConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorShortResponseOnly = new JSONHoldingBooleanGenerator("field \"ShortResponseOnly\" of the WikipediaConversationState class");
            fieldGeneratorEntries = new TypeEntriesJSON.HoldingArrayGenerator("field \"Entries\" of the WikipediaConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikipediaConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorShortResponseOnly.reset();
            fieldGeneratorEntries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEntries.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEntries.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WikipediaConversationStateJSON  result)
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
        public WikipediaConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikipediaConversationStateJSON  result)
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
    protected virtual void handle_result(List<WikipediaConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikipediaConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikipediaConversationStateJSON>();
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
    public List<WikipediaConversationStateJSON> value;
  };
  };
