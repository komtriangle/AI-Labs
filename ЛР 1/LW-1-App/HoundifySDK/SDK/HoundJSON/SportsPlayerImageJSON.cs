/* file "SportsPlayerImageJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsPlayerImageJSON : JSONBase
  {
    private bool flagHasURL;
    private string storeURL;
    private bool flagHasWidth;
    private BigInteger storeWidth;
    private bool flagHasHeight;
    private BigInteger storeHeight;
    private bool flagHasIsPlaceholderImage;
    private bool storeIsPlaceholderImage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field URL of SportsPlayerImageJSON is not a string.");
        setURL(json_string.getData());
      }


    private void  fromJSONWidth(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Width of SportsPlayerImageJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Width of SportsPlayerImageJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setWidth(extracted_integer);
      }


    private void  fromJSONHeight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Height of SportsPlayerImageJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Height of SportsPlayerImageJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setHeight(extracted_integer);
      }


    private void  fromJSONIsPlaceholderImage(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPlaceholderImage of SportsPlayerImageJSON is not true for false.");
              }
          }
        setIsPlaceholderImage(the_bool);
      }


    public SportsPlayerImageJSON()
      {
        flagHasURL = false;
        flagHasWidth = false;
        flagHasHeight = false;
        flagHasIsPlaceholderImage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasURL()
      {
        return flagHasURL;
      }

    public string  getURL()
      {
        Debug.Assert(flagHasURL);
        return storeURL;
      }

    public bool  hasWidth()
      {
        return flagHasWidth;
      }

    public BigInteger  getWidth()
      {
        Debug.Assert(flagHasWidth);
        return storeWidth;
      }

    public bool  hasHeight()
      {
        return flagHasHeight;
      }

    public BigInteger  getHeight()
      {
        Debug.Assert(flagHasHeight);
        return storeHeight;
      }

    public bool  hasIsPlaceholderImage()
      {
        return flagHasIsPlaceholderImage;
      }

    public bool  getIsPlaceholderImage()
      {
        Debug.Assert(flagHasIsPlaceholderImage);
        return storeIsPlaceholderImage;
      }


    public virtual int extraSportsPlayerImageComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayerImageComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayerImageComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayerImageLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setURL(string new_value)
      {
        flagHasURL = true;
        storeURL = new_value;
      }
    public void unsetURL()
      {
        flagHasURL = false;
      }
    public void setWidth(BigInteger new_value)
      {
        flagHasWidth = true;
        if (new_value < 1)
            throw new Exception("The value for field Width of SportsPlayerImageJSON is less than the lower bound (1) for that field.");
        storeWidth = new_value;
      }
    public void unsetWidth()
      {
        flagHasWidth = false;
      }
    public void setHeight(BigInteger new_value)
      {
        flagHasHeight = true;
        if (new_value < 1)
            throw new Exception("The value for field Height of SportsPlayerImageJSON is less than the lower bound (1) for that field.");
        storeHeight = new_value;
      }
    public void unsetHeight()
      {
        flagHasHeight = false;
      }
    public void setIsPlaceholderImage(bool new_value)
      {
        flagHasIsPlaceholderImage = true;
        storeIsPlaceholderImage = new_value;
      }
    public void unsetIsPlaceholderImage()
      {
        flagHasIsPlaceholderImage = false;
      }

    public virtual void extraSportsPlayerImageAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayerImageSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayerImageLookup(key);
        if (old_field == null)
          {
            extraSportsPlayerImageAppendPair(key, new_component);
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
        if (flagHasURL)
          {
            handler.start_pair("URL");
            handler.string_value(storeURL);
          }
        if (flagHasWidth)
          {
            handler.start_pair("Width");
            handler.number_value(storeWidth);
          }
        if (flagHasHeight)
          {
            handler.start_pair("Height");
            handler.number_value(storeHeight);
          }
        if (flagHasIsPlaceholderImage)
          {
            handler.start_pair("IsPlaceholderImage");
            handler.boolean_value(storeIsPlaceholderImage);
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

    public static SportsPlayerImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerImage", ignore_extras);
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
    public static SportsPlayerImageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayerImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerImage", ignore_extras);
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
    public static SportsPlayerImageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayerImageJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayerImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerImage", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayerImageJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayerImageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayerImageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayerImage", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorURL;
    private class FieldHoldingGeneratorWidth : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorWidth(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorWidth : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorWidth(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorWidth fieldGeneratorWidth;
    private class FieldHoldingGeneratorHeight : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorHeight(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorHeight : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorHeight(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorHeight fieldGeneratorHeight;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPlaceholderImage;
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
            SportsPlayerImageJSON result = new SportsPlayerImageJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayerImageAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayerImageJSON result)
          {
            if (fieldGeneratorURL.have_value)
              {
                result.setURL(fieldGeneratorURL.value);
                fieldGeneratorURL.have_value = false;
              }
            if (fieldGeneratorWidth.have_value)
              {
                result.setWidth(fieldGeneratorWidth.value);
                fieldGeneratorWidth.have_value = false;
              }
            if (fieldGeneratorHeight.have_value)
              {
                result.setHeight(fieldGeneratorHeight.value);
                fieldGeneratorHeight.have_value = false;
              }
            if (fieldGeneratorIsPlaceholderImage.have_value)
              {
                result.setIsPlaceholderImage(fieldGeneratorIsPlaceholderImage.value);
                fieldGeneratorIsPlaceholderImage.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayerImageJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'H':
                    if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorHeight;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sPlaceholderImage", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorIsPlaceholderImage;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorURL;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "idth", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorWidth;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the SportsPlayerImage class");
            fieldGeneratorWidth = new FieldHoldingGeneratorWidth("field \"Width\" of the SportsPlayerImage class");
            fieldGeneratorHeight = new FieldHoldingGeneratorHeight("field \"Height\" of the SportsPlayerImage class");
            fieldGeneratorIsPlaceholderImage = new JSONHoldingBooleanGenerator("field \"IsPlaceholderImage\" of the SportsPlayerImage class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayerImage class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the SportsPlayerImage class");
            fieldGeneratorWidth = new FieldHoldingGeneratorWidth("field \"Width\" of the SportsPlayerImage class");
            fieldGeneratorHeight = new FieldHoldingGeneratorHeight("field \"Height\" of the SportsPlayerImage class");
            fieldGeneratorIsPlaceholderImage = new JSONHoldingBooleanGenerator("field \"IsPlaceholderImage\" of the SportsPlayerImage class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayerImage class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorURL.reset();
            fieldGeneratorWidth.reset();
            fieldGeneratorHeight.reset();
            fieldGeneratorIsPlaceholderImage.reset();
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
        protected override void handle_result(SportsPlayerImageJSON  result)
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
        public SportsPlayerImageJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayerImageJSON  result)
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
    protected virtual void handle_result(List<SportsPlayerImageJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayerImageJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayerImageJSON>();
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
    public List<SportsPlayerImageJSON> value;
  };
  };
