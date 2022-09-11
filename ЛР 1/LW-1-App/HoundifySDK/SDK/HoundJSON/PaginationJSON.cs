/* file "PaginationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class PaginationJSON : JSONBase
  {
    public enum TypeDisplayOrientation
      {
        DisplayOrientation_Horizontal,
        DisplayOrientation_Vertical
      };

    public static TypeDisplayOrientation  stringToDisplayOrientation(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "orizontal", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeDisplayOrientation.DisplayOrientation_Horizontal;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ertical", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeDisplayOrientation.DisplayOrientation_Vertical;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `DisplayOrientation' is not one of the legal values.");
      }

    public static string  stringFromDisplayOrientation(TypeDisplayOrientation the_enum)
      {
        switch (the_enum)
          {
            case TypeDisplayOrientation.DisplayOrientation_Horizontal:
                return "Horizontal";
            case TypeDisplayOrientation.DisplayOrientation_Vertical:
                return "Vertical";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSkippedItemCount;
    private BigInteger storeSkippedItemCount;
    private bool flagHasDisplayedItemCount;
    private BigInteger storeDisplayedItemCount;
    private bool flagHasDisplayOrientation;
    private TypeDisplayOrientation storeDisplayOrientation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSkippedItemCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SkippedItemCount of PaginationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SkippedItemCount of PaginationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSkippedItemCount(extracted_integer);
      }


    private void  fromJSONDisplayedItemCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DisplayedItemCount of PaginationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DisplayedItemCount of PaginationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDisplayedItemCount(extracted_integer);
      }


    private void  fromJSONDisplayOrientation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayOrientation of PaginationJSON is not a string.");
        TypeDisplayOrientation the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "orizontal", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeDisplayOrientation.DisplayOrientation_Horizontal;
                        goto enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ertical", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeDisplayOrientation.DisplayOrientation_Vertical;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field DisplayOrientation of PaginationJSON is not one of the legal strings.");
      enum_is_done:;
        setDisplayOrientation(the_enum);
      }


    public PaginationJSON()
      {
        flagHasSkippedItemCount = false;
        flagHasDisplayedItemCount = false;
        flagHasDisplayOrientation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSkippedItemCount()
      {
        return flagHasSkippedItemCount;
      }

    public BigInteger  getSkippedItemCount()
      {
        Debug.Assert(flagHasSkippedItemCount);
        return storeSkippedItemCount;
      }

    public bool  hasDisplayedItemCount()
      {
        return flagHasDisplayedItemCount;
      }

    public BigInteger  getDisplayedItemCount()
      {
        Debug.Assert(flagHasDisplayedItemCount);
        return storeDisplayedItemCount;
      }

    public bool  hasDisplayOrientation()
      {
        return flagHasDisplayOrientation;
      }

    public TypeDisplayOrientation  getDisplayOrientation()
      {
        Debug.Assert(flagHasDisplayOrientation);
        return storeDisplayOrientation;
      }

    public string  getDisplayOrientationAsString()
      {
        return stringFromDisplayOrientation(getDisplayOrientation());
      }


    public virtual int extraPaginationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPaginationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPaginationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPaginationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSkippedItemCount(BigInteger new_value)
      {
        flagHasSkippedItemCount = true;
        if (new_value < 0)
            throw new Exception("The value for field SkippedItemCount of PaginationJSON is less than the lower bound (0) for that field.");
        storeSkippedItemCount = new_value;
      }
    public void unsetSkippedItemCount()
      {
        flagHasSkippedItemCount = false;
      }
    public void setDisplayedItemCount(BigInteger new_value)
      {
        flagHasDisplayedItemCount = true;
        if (new_value < 0)
            throw new Exception("The value for field DisplayedItemCount of PaginationJSON is less than the lower bound (0) for that field.");
        storeDisplayedItemCount = new_value;
      }
    public void unsetDisplayedItemCount()
      {
        flagHasDisplayedItemCount = false;
      }
    public void setDisplayOrientation(TypeDisplayOrientation new_value)
      {
        flagHasDisplayOrientation = true;
        storeDisplayOrientation = new_value;
      }
    public void setDisplayOrientation(string chars)
      {
        setDisplayOrientation(stringToDisplayOrientation(chars));
      }
    public void unsetDisplayOrientation()
      {
        flagHasDisplayOrientation = false;
      }

    public virtual void extraPaginationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPaginationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPaginationLookup(key);
        if (old_field == null)
          {
            extraPaginationAppendPair(key, new_component);
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
        if (flagHasSkippedItemCount)
          {
            handler.start_pair("SkippedItemCount");
            handler.number_value(storeSkippedItemCount);
          }
        if (flagHasDisplayedItemCount)
          {
            handler.start_pair("DisplayedItemCount");
            handler.number_value(storeDisplayedItemCount);
          }
        if (flagHasDisplayOrientation)
          {
            handler.start_pair("DisplayOrientation");
            switch (storeDisplayOrientation)
              {
                case TypeDisplayOrientation.DisplayOrientation_Horizontal:
                    handler.string_value("Horizontal");
                    break;
                case TypeDisplayOrientation.DisplayOrientation_Vertical:
                    handler.string_value("Vertical");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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

    public static PaginationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PaginationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Pagination", ignore_extras);
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
    public static PaginationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PaginationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PaginationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Pagination", ignore_extras);
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
    public static PaginationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PaginationJSON from_text(string text, bool ignore_extras)
      {
        PaginationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Pagination", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PaginationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PaginationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PaginationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Pagination", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorSkippedItemCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSkippedItemCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSkippedItemCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSkippedItemCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSkippedItemCount fieldGeneratorSkippedItemCount;
    private class FieldHoldingGeneratorDisplayedItemCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDisplayedItemCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDisplayedItemCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDisplayedItemCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorDisplayedItemCount fieldGeneratorDisplayedItemCount;
    private abstract class FieldGeneratorDisplayOrientation : JSONStringGenerator
          {
            protected FieldGeneratorDisplayOrientation(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDisplayOrientation()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDisplayOrientation(result));
              }
            protected abstract void handle_result(TypeDisplayOrientation result);
          };
    private class FieldHoldingGeneratorDisplayOrientation : FieldGeneratorDisplayOrientation
  {
    protected override void handle_result(TypeDisplayOrientation result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDisplayOrientation(String what)
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
    public TypeDisplayOrientation value;
  };
    private class FieldHoldingArrayGeneratorDisplayOrientation : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDisplayOrientation
      {
        private FieldHoldingArrayGeneratorDisplayOrientation top;

        protected override void handle_result(TypeDisplayOrientation result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDisplayOrientation init_top)
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
    protected virtual void handle_result(List<TypeDisplayOrientation> result)
      {
      }

    public FieldHoldingArrayGeneratorDisplayOrientation(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDisplayOrientation>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDisplayOrientation()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDisplayOrientation>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDisplayOrientation> value;
  };
        private FieldHoldingGeneratorDisplayOrientation fieldGeneratorDisplayOrientation;
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
            PaginationJSON result = new PaginationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPaginationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PaginationJSON result)
          {
            if (fieldGeneratorSkippedItemCount.have_value)
              {
                result.setSkippedItemCount(fieldGeneratorSkippedItemCount.value);
                fieldGeneratorSkippedItemCount.have_value = false;
              }
            if (fieldGeneratorDisplayedItemCount.have_value)
              {
                result.setDisplayedItemCount(fieldGeneratorDisplayedItemCount.value);
                fieldGeneratorDisplayedItemCount.have_value = false;
              }
            if (fieldGeneratorDisplayOrientation.have_value)
              {
                result.setDisplayOrientation(fieldGeneratorDisplayOrientation.value);
                fieldGeneratorDisplayOrientation.have_value = false;
              }
          }
        protected abstract void handle_result(PaginationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "isplay", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'O':
                                if ((String.Compare(field_name, 8, "rientation", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDisplayOrientation;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 8, "dItemCount", 0, 10, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDisplayedItemCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "kippedItemCount", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorSkippedItemCount;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSkippedItemCount = new FieldHoldingGeneratorSkippedItemCount("field \"SkippedItemCount\" of the Pagination class");
            fieldGeneratorDisplayedItemCount = new FieldHoldingGeneratorDisplayedItemCount("field \"DisplayedItemCount\" of the Pagination class");
            fieldGeneratorDisplayOrientation = new FieldHoldingGeneratorDisplayOrientation("field \"DisplayOrientation\" of the Pagination class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Pagination class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSkippedItemCount = new FieldHoldingGeneratorSkippedItemCount("field \"SkippedItemCount\" of the Pagination class");
            fieldGeneratorDisplayedItemCount = new FieldHoldingGeneratorDisplayedItemCount("field \"DisplayedItemCount\" of the Pagination class");
            fieldGeneratorDisplayOrientation = new FieldHoldingGeneratorDisplayOrientation("field \"DisplayOrientation\" of the Pagination class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Pagination class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSkippedItemCount.reset();
            fieldGeneratorDisplayedItemCount.reset();
            fieldGeneratorDisplayOrientation.reset();
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
        protected override void handle_result(PaginationJSON  result)
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
        public PaginationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PaginationJSON  result)
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
    protected virtual void handle_result(List<PaginationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PaginationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PaginationJSON>();
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
    public List<PaginationJSON> value;
  };
  };
