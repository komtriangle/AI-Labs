/* file "WikidataAPIStatementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WikidataAPIStatementJSON : JSONBase
  {
    private bool flagHasmainsnak;
    private WikidataAPISnakJSON  storemainsnak;
    private bool flagHasrank;
    private string storerank;
    private bool flagHasqualifiers;
    private JSONObjectValue  storequalifiers;
    private bool flagHasqualifiersorder;
    private List< string > storequalifiersorder;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONmainsnak(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WikidataAPISnakJSON convert_classy = WikidataAPISnakJSON.from_json(json_value, ignore_extras, true);
        setmainsnak(convert_classy);
      }


    private void  fromJSONrank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field rank of WikidataAPIStatementJSON is not a string.");
        setrank(json_string.getData());
      }


    private void  fromJSONqualifiers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        if (json_value.object_value() == null)
            throw new Exception("The value for field qualifiers of WikidataAPIStatementJSON is not an object.");
        setqualifiers(json_value.object_value());
      }


    private void  fromJSONqualifiersorder(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field qualifiersorder of WikidataAPIStatementJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field qualifiersorder of WikidataAPIStatementJSON has too few elements.");
        List< string > vector_qualifiersorder1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field qualifiersorder of WikidataAPIStatementJSON is not a string.");
            vector_qualifiersorder1.Add(json_string.getData());
          }
        Debug.Assert(vector_qualifiersorder1.Count >= 1);
        initqualifiersorder();
        for (int num1 = 0; num1 < vector_qualifiersorder1.Count; ++num1)
            appendqualifiersorder(vector_qualifiersorder1[num1]);
        for (int num1 = 0; num1 < vector_qualifiersorder1.Count; ++num1)
          {
          }
      }


    public WikidataAPIStatementJSON()
      {
        flagHasmainsnak = false;
        flagHasrank = false;
        flagHasqualifiers = false;
        flagHasqualifiersorder = false;
        storequalifiersorder = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasmainsnak()
      {
        return flagHasmainsnak;
      }

    public WikidataAPISnakJSON   getmainsnak()
      {
        Debug.Assert(flagHasmainsnak);
        return storemainsnak;
      }

    public bool  hasrank()
      {
        return flagHasrank;
      }

    public string  getrank()
      {
        Debug.Assert(flagHasrank);
        return storerank;
      }

    public bool  hasqualifiers()
      {
        return flagHasqualifiers;
      }

    public JSONObjectValue   getqualifiers()
      {
        Debug.Assert(flagHasqualifiers);
        return storequalifiers;
      }

    public bool  hasqualifiersorder()
      {
        return flagHasqualifiersorder;
      }

    public int  countOfqualifiersorder()
      {
        Debug.Assert(flagHasqualifiersorder);
        return storequalifiersorder.Count;
      }

    public string  elementOfqualifiersorder(int element_num)
      {
        Debug.Assert(flagHasqualifiersorder);
        return storequalifiersorder[element_num];
      }

    public List< string >  getqualifiersorder()
      {
        Debug.Assert(flagHasqualifiersorder);
        return storequalifiersorder;
      }


    public virtual int extraWikidataAPIStatementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikidataAPIStatementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikidataAPIStatementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikidataAPIStatementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setmainsnak(WikidataAPISnakJSON  new_value)
      {
        if (flagHasmainsnak)
          {
          }
        flagHasmainsnak = true;
        storemainsnak = new_value;
      }
    public void unsetmainsnak()
      {
        if (flagHasmainsnak)
          {
          }
        flagHasmainsnak = false;
      }
    public void setrank(string new_value)
      {
        flagHasrank = true;
        storerank = new_value;
      }
    public void unsetrank()
      {
        flagHasrank = false;
      }
    public void setqualifiers(JSONObjectValue  new_value)
      {
        if (flagHasqualifiers)
          {
          }
        flagHasqualifiers = true;
        storequalifiers = new_value;
      }
    public void unsetqualifiers()
      {
        if (flagHasqualifiers)
          {
          }
        flagHasqualifiers = false;
      }
    public void initqualifiersorder()
      {
        flagHasqualifiersorder = true;
        storequalifiersorder.Clear();
      }
    public void appendqualifiersorder(string to_append)
      {
        if (!flagHasqualifiersorder)
          {
            flagHasqualifiersorder = true;
            storequalifiersorder.Clear();
          }
        Debug.Assert(flagHasqualifiersorder);
        storequalifiersorder.Add(to_append);
      }
    public void unsetqualifiersorder()
      {
        flagHasqualifiersorder = false;
        storequalifiersorder.Clear();
      }

    public virtual void extraWikidataAPIStatementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikidataAPIStatementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikidataAPIStatementLookup(key);
        if (old_field == null)
          {
            extraWikidataAPIStatementAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasmainsnak);
        if (flagHasmainsnak)
          {
            handler.start_pair("mainsnak");
            if (partial_allowed)
                storemainsnak.write_partial_as_json(handler);
            else
                storemainsnak.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasrank);
        if (flagHasrank)
          {
            handler.start_pair("rank");
            handler.string_value(storerank);
          }
        if (flagHasqualifiers)
          {
            handler.start_pair("qualifiers");
            storequalifiers.write(handler);
          }
        if (flagHasqualifiersorder)
          {
            handler.start_pair("qualifiers-order");
            Debug.Assert(storequalifiersorder.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storequalifiersorder.Count; ++num1)
              {
                handler.string_value(storequalifiersorder[num1]);
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
        if (!(hasmainsnak()))
          {
            return "When parsing the object for %what%, the \"mainsnak\" field was missing.";
          }
        if (!(hasrank()))
          {
            return "When parsing the object for %what%, the \"rank\" field was missing.";
          }
        return null;
      }

    public static WikidataAPIStatementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIStatementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIStatement", ignore_extras);
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
    public static WikidataAPIStatementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPIStatementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikidataAPIStatementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIStatement", ignore_extras);
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
    public static WikidataAPIStatementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WikidataAPIStatementJSON from_text(string text, bool ignore_extras)
      {
        WikidataAPIStatementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIStatement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikidataAPIStatementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WikidataAPIStatementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikidataAPIStatementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikidataAPIStatement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private WikidataAPISnakJSON.HoldingGenerator fieldGeneratormainsnak;
        private JSONHoldingStringGenerator fieldGeneratorrank;
        private JSONHoldingObjectValueGenerator fieldGeneratorqualifiers;
        private JSONHoldingStringArrayGenerator fieldGeneratorqualifiersorder;
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
            WikidataAPIStatementJSON result = new WikidataAPIStatementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikidataAPIStatementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WikidataAPIStatementJSON result)
          {
            if (fieldGeneratormainsnak.have_value)
              {
                result.setmainsnak(fieldGeneratormainsnak.value);
                fieldGeneratormainsnak.have_value = false;
              }
            else if ((!(result.hasmainsnak())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"mainsnak\" field was missing.");
              }
            if (fieldGeneratorrank.have_value)
              {
                result.setrank(fieldGeneratorrank.value);
                fieldGeneratorrank.have_value = false;
              }
            else if ((!(result.hasrank())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"rank\" field was missing.");
              }
            if (fieldGeneratorqualifiers.have_value)
              {
                result.setqualifiers(fieldGeneratorqualifiers.value);
                fieldGeneratorqualifiers.have_value = false;
              }
            if (fieldGeneratorqualifiersorder.have_value)
              {
                result.initqualifiersorder();
                int count = fieldGeneratorqualifiersorder.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendqualifiersorder(fieldGeneratorqualifiersorder.value[num]);
                  }
                fieldGeneratorqualifiersorder.value.Clear();
                fieldGeneratorqualifiersorder.have_value = false;
              }
          }
        protected abstract void handle_result(WikidataAPIStatementJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'm':
                    if ((String.Compare(field_name, 1, "ainsnak", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratormainsnak;
                    break;
                case 'q':
                    if (String.Compare(field_name, 1, "ualifiers", 0, 9, false) == 0)
                      {
                        if (field_name.Length == 10)
                          {
                            return fieldGeneratorqualifiers;
                          }
                        switch (field_name[10])
                          {
                            case '-':
                                if ((String.Compare(field_name, 11, "order", 0, 5, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorqualifiersorder;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorrank;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratormainsnak = new WikidataAPISnakJSON.HoldingGenerator("field \"mainsnak\" of the WikidataAPIStatement class", ignore_extras);
            fieldGeneratorrank = new JSONHoldingStringGenerator("field \"rank\" of the WikidataAPIStatement class");
            fieldGeneratorqualifiers = new JSONHoldingObjectValueGenerator("field \"qualifiers\" of the WikidataAPIStatement class");
            fieldGeneratorqualifiersorder = new JSONHoldingStringArrayGenerator("field \"qualifiers-order\" of the WikidataAPIStatement class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikidataAPIStatement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratormainsnak = new WikidataAPISnakJSON.HoldingGenerator("field \"mainsnak\" of the WikidataAPIStatement class", false);
            fieldGeneratorrank = new JSONHoldingStringGenerator("field \"rank\" of the WikidataAPIStatement class");
            fieldGeneratorqualifiers = new JSONHoldingObjectValueGenerator("field \"qualifiers\" of the WikidataAPIStatement class");
            fieldGeneratorqualifiersorder = new JSONHoldingStringArrayGenerator("field \"qualifiers-order\" of the WikidataAPIStatement class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikidataAPIStatement class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratormainsnak.reset();
            fieldGeneratorrank.reset();
            fieldGeneratorqualifiers.reset();
            fieldGeneratorqualifiersorder.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratormainsnak.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratormainsnak.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WikidataAPIStatementJSON  result)
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
        public WikidataAPIStatementJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikidataAPIStatementJSON  result)
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
    protected virtual void handle_result(List<WikidataAPIStatementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikidataAPIStatementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikidataAPIStatementJSON>();
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
    public List<WikidataAPIStatementJSON> value;
  };
  };
