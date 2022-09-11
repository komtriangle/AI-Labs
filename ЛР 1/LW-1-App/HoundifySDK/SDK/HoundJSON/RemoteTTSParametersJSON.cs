/* file "RemoteTTSParametersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RemoteTTSParametersJSON : JSONBase
  {
    private bool flagHastext;
    private string storetext;
    private bool flagHasvoice;
    private string storevoice;
    private bool flagHaslanguage;
    private string storelanguage;
    private bool flagHasencoding;
    private string storeencoding;


    private void  fromJSONtext(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field text of RemoteTTSParametersJSON is not a string.");
        settext(json_string.getData());
      }


    private void  fromJSONvoice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field voice of RemoteTTSParametersJSON is not a string.");
        setvoice(json_string.getData());
      }


    private void  fromJSONlanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field language of RemoteTTSParametersJSON is not a string.");
        setlanguage(json_string.getData());
      }


    private void  fromJSONencoding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field encoding of RemoteTTSParametersJSON is not a string.");
        setencoding(json_string.getData());
      }


    public RemoteTTSParametersJSON()
      {
        flagHastext = false;
        flagHasvoice = false;
        flagHaslanguage = false;
        flagHasencoding = false;
      }

    public abstract string getengine();
    public bool  hastext()
      {
        return flagHastext;
      }

    public string  gettext()
      {
        Debug.Assert(flagHastext);
        return storetext;
      }

    public bool  hasvoice()
      {
        return flagHasvoice;
      }

    public string  getvoice()
      {
        Debug.Assert(flagHasvoice);
        return storevoice;
      }

    public bool  haslanguage()
      {
        return flagHaslanguage;
      }

    public string  getlanguage()
      {
        Debug.Assert(flagHaslanguage);
        return storelanguage;
      }

    public bool  hasencoding()
      {
        return flagHasencoding;
      }

    public string  getencoding()
      {
        Debug.Assert(flagHasencoding);
        return storeencoding;
      }


    public abstract int extraRemoteTTSParametersComponentCount();
    public abstract string extraRemoteTTSParametersComponentKey(int component_num);
    public abstract JSONValue extraRemoteTTSParametersComponentValue(int component_num);
    public abstract JSONValue extraRemoteTTSParametersLookup(string field_name);

    public void settext(string new_value)
      {
        flagHastext = true;
        storetext = new_value;
      }
    public void unsettext()
      {
        flagHastext = false;
      }
    public void setvoice(string new_value)
      {
        flagHasvoice = true;
        storevoice = new_value;
      }
    public void unsetvoice()
      {
        flagHasvoice = false;
      }
    public void setlanguage(string new_value)
      {
        flagHaslanguage = true;
        storelanguage = new_value;
      }
    public void unsetlanguage()
      {
        flagHaslanguage = false;
      }
    public void setencoding(string new_value)
      {
        flagHasencoding = true;
        storeencoding = new_value;
      }
    public void unsetencoding()
      {
        flagHasencoding = false;
      }

    public abstract void extraRemoteTTSParametersAppendPair(string key, JSONValue new_component);
    public abstract void extraRemoteTTSParametersSetField(string key, JSONValue new_component);

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
        handler.pair("engine", getengine());
        Debug.Assert(partial_allowed || flagHastext);
        if (flagHastext)
          {
            handler.start_pair("text");
            handler.string_value(storetext);
          }
        Debug.Assert(partial_allowed || flagHasvoice);
        if (flagHasvoice)
          {
            handler.start_pair("voice");
            handler.string_value(storevoice);
          }
        Debug.Assert(partial_allowed || flagHaslanguage);
        if (flagHaslanguage)
          {
            handler.start_pair("language");
            handler.string_value(storelanguage);
          }
        Debug.Assert(partial_allowed || flagHasencoding);
        if (flagHasencoding)
          {
            handler.start_pair("encoding");
            handler.string_value(storeencoding);
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
        if (!(hastext()))
          {
            return "When parsing the object for %what%, the \"text\" field was missing.";
          }
        if (!(hasvoice()))
          {
            return "When parsing the object for %what%, the \"voice\" field was missing.";
          }
        if (!(haslanguage()))
          {
            return "When parsing the object for %what%, the \"language\" field was missing.";
          }
        if (!(hasencoding()))
          {
            return "When parsing the object for %what%, the \"encoding\" field was missing.";
          }
        return null;
      }

    public static RemoteTTSParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RemoteTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemoteTTSParameters", ignore_extras);
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
    public static RemoteTTSParametersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RemoteTTSParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RemoteTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemoteTTSParameters", ignore_extras);
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
    public static RemoteTTSParametersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RemoteTTSParametersJSON from_text(string text, bool ignore_extras)
      {
        RemoteTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemoteTTSParameters", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RemoteTTSParametersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RemoteTTSParametersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RemoteTTSParametersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RemoteTTSParameters", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratortext;
        private JSONHoldingStringGenerator fieldGeneratorvoice;
        private JSONHoldingStringGenerator fieldGeneratorlanguage;
        private JSONHoldingStringGenerator fieldGeneratorencoding;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `engine' field is missing.");
            RemoteTTSParametersJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRemoteTTSParametersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getRemoteTTSParametersJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `engine' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(RemoteTTSParametersJSON result)
          {
            if (fieldGeneratortext.have_value)
              {
                result.settext(fieldGeneratortext.value);
                fieldGeneratortext.have_value = false;
              }
            else if ((!(result.hastext())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"text\" field was missing.");
              }
            if (fieldGeneratorvoice.have_value)
              {
                result.setvoice(fieldGeneratorvoice.value);
                fieldGeneratorvoice.have_value = false;
              }
            else if ((!(result.hasvoice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"voice\" field was missing.");
              }
            if (fieldGeneratorlanguage.have_value)
              {
                result.setlanguage(fieldGeneratorlanguage.value);
                fieldGeneratorlanguage.have_value = false;
              }
            else if ((!(result.haslanguage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"language\" field was missing.");
              }
            if (fieldGeneratorencoding.have_value)
              {
                result.setencoding(fieldGeneratorencoding.value);
                fieldGeneratorencoding.have_value = false;
              }
            else if ((!(result.hasencoding())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"encoding\" field was missing.");
              }
          }
        protected abstract void handle_result(RemoteTTSParametersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'e':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "oding", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorencoding;
                                break;
                            case 'g':
                                if ((String.Compare(field_name, 3, "ine", 0, 3, false) == 0) && (field_name.Length == 6))
                                    {
                                    keyGenerator.reset();
                                    return keyGenerator;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "anguage", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorlanguage;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratortext;
                    break;
                case 'v':
                    if ((String.Compare(field_name, 1, "oice", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorvoice;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratortext = new JSONHoldingStringGenerator("field \"text\" of the RemoteTTSParameters class");
            fieldGeneratorvoice = new JSONHoldingStringGenerator("field \"voice\" of the RemoteTTSParameters class");
            fieldGeneratorlanguage = new JSONHoldingStringGenerator("field \"language\" of the RemoteTTSParameters class");
            fieldGeneratorencoding = new JSONHoldingStringGenerator("field \"encoding\" of the RemoteTTSParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"engine\" of the RemoteTTSParameters class");
            set_what("the RemoteTTSParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortext = new JSONHoldingStringGenerator("field \"text\" of the RemoteTTSParameters class");
            fieldGeneratorvoice = new JSONHoldingStringGenerator("field \"voice\" of the RemoteTTSParameters class");
            fieldGeneratorlanguage = new JSONHoldingStringGenerator("field \"language\" of the RemoteTTSParameters class");
            fieldGeneratorencoding = new JSONHoldingStringGenerator("field \"encoding\" of the RemoteTTSParameters class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"engine\" of the RemoteTTSParameters class");
            set_what("the RemoteTTSParameters class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortext.reset();
            fieldGeneratorvoice.reset();
            fieldGeneratorlanguage.reset();
            fieldGeneratorencoding.reset();
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
        protected override void handle_result(RemoteTTSParametersJSON  result)
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
        public RemoteTTSParametersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RemoteTTSParametersJSON  result)
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
    protected virtual void handle_result(List<RemoteTTSParametersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RemoteTTSParametersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RemoteTTSParametersJSON>();
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
    public List<RemoteTTSParametersJSON> value;
  };
    class GenericRemoteTTSParametersJSON : RemoteTTSParametersJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRemoteTTSParametersJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getengine()  { return key; }
        public override int extraRemoteTTSParametersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRemoteTTSParametersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRemoteTTSParametersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRemoteTTSParametersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRemoteTTSParametersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRemoteTTSParametersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRemoteTTSParametersLookup(key);
            if (old_field == null)
              {
                extraRemoteTTSParametersAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static RemoteTTSParametersJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'a':
            if ((String.Compare(key, 1, "capela", 0, 6, false) == 0) && (key.Length == 7))
                return new AcapelaRemoteTTSParametersJSON();
            break;
        case 'r':
            if ((String.Compare(key, 1, "eadspeaker", 0, 10, false) == 0) && (key.Length == 11))
                return new ReadSpeakerRemoteTTSParametersJSON();
            break;
        case 's':
            if ((String.Compare(key, 1, "elvy", 0, 4, false) == 0) && (key.Length == 5))
                return new SelvyRemoteTTSParametersJSON();
            break;
        default:
            break;
      }

        return new GenericRemoteTTSParametersJSON(key);
      }
  };
