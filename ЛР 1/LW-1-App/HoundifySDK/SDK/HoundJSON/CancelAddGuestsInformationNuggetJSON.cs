/* file "CancelAddGuestsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CancelAddGuestsInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeReasonKnownValues
      {
        Reason_UserFailedToProvideValidName,
        Reason_UserCancelled,
        Reason__none
      };
    public struct TypeReason
      {
        public bool in_known_list;
        public string string_value;
        public TypeReasonKnownValues list_value;
      };

    public static TypeReasonKnownValues  stringToReason(string chars)
      {
        if (String.Compare(chars, 0, "User", 0, 4, false) == 0)
          {
            switch (chars[4])
              {
                case 'C':
                    if ((String.Compare(chars, 5, "ancelled", 0, 8, false) == 0) && (chars.Length == 13))
                        return TypeReasonKnownValues.Reason_UserCancelled;
                    break;
                case 'F':
                    if ((String.Compare(chars, 5, "ailedToProvideValidName", 0, 23, false) == 0) && (chars.Length == 28))
                        return TypeReasonKnownValues.Reason_UserFailedToProvideValidName;
                    break;
                default:
                    break;
              }
          }
        return TypeReasonKnownValues.Reason__none;
      }

    public static string  stringFromReason(TypeReasonKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeReasonKnownValues.Reason_UserFailedToProvideValidName:
                return "UserFailedToProvideValidName";
            case TypeReasonKnownValues.Reason_UserCancelled:
                return "UserCancelled";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasReason;
    private TypeReason storeReason;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraReasonToJSON()
      {
        JSONStringValue generated_string_Reason;
        if (!(storeReason.in_known_list))
          {
        generated_string_Reason = new JSONStringValue(storeReason.string_value);
          }
        else
          {
        switch (storeReason.list_value)
          {
            case TypeReasonKnownValues.Reason_UserFailedToProvideValidName:
                generated_string_Reason = new JSONStringValue("UserFailedToProvideValidName");
                break;
            case TypeReasonKnownValues.Reason_UserCancelled:
                generated_string_Reason = new JSONStringValue("UserCancelled");
                break;
            default:
                Debug.Assert(false);
                generated_string_Reason = null;
                break;
          }
          }
        return generated_string_Reason;
      }


    private void  fromJSONReason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Reason of CancelAddGuestsInformationNuggetJSON is not a string.");
        TypeReason the_open_enum = new TypeReason();
        if (String.Compare(json_string.getData(), 0, "User", 0, 4, false) == 0)
          {
            switch (json_string.getData()[4])
              {
                case 'C':
                    if ((String.Compare(json_string.getData(), 5, "ancelled", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_UserCancelled;
                            goto open_enum_is_done;
                          }
                    break;
                case 'F':
                    if ((String.Compare(json_string.getData(), 5, "ailedToProvideValidName", 0, 23, false) == 0) && (json_string.getData().Length == 28))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeReasonKnownValues.Reason_UserFailedToProvideValidName;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setReason(the_open_enum);
      }


    public CancelAddGuestsInformationNuggetJSON()
      {
        flagHasReason = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "CancelAddGuestsInformationNugget";
      }

    public bool  hasReason()
      {
        return flagHasReason;
      }

    public TypeReason  getReason()
      {
        Debug.Assert(flagHasReason);
        return storeReason;
      }

    public string  getReasonAsString()
      {
        TypeReason result = getReason();
        if (result.in_known_list)
            return stringFromReason(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCancelAddGuestsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCancelAddGuestsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCancelAddGuestsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCancelAddGuestsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasReason)
            ++result;
        result += extraCancelAddGuestsInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasReason)
          {
            if (remainder == 0)
                return "Reason";
            --remainder;
          }
        return extraCancelAddGuestsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasReason)
          {
            if (remainder == 0)
                return extraReasonToJSON();
            --remainder;
          }
        return extraCancelAddGuestsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Reason", 0, 6, false) == 0) && (field_name.Length == 6))
            return (flagHasReason ? extraReasonToJSON() : null);
        return extraCancelAddGuestsInformationNuggetLookup(field_name);
      }

    public void setReason(TypeReason new_value)
      {
        flagHasReason = true;
        storeReason = new_value;
      }
    public void setReason(string chars)
      {
        TypeReasonKnownValues known = stringToReason(chars);
        TypeReason new_value = new TypeReason();
        if (known == TypeReasonKnownValues.Reason__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setReason(new_value);
      }
    public void setReason(TypeReasonKnownValues new_value)
      {
        TypeReason new_full_value = new TypeReason();
        Debug.Assert(new_value != TypeReasonKnownValues.Reason__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setReason(new_full_value);
      }
    public void unsetReason()
      {
        flagHasReason = false;
      }

    public virtual void extraCancelAddGuestsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCancelAddGuestsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCancelAddGuestsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraCancelAddGuestsInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Reason", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONReason(new_component, false);
            return;
            }
        extraCancelAddGuestsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Reason", 0, 6, false) == 0) && (key.Length == 6))
            {
            fromJSONReason(new_component, false);
            return;
            }
        extraCancelAddGuestsInformationNuggetSetField(key, new_component);
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
        if (flagHasReason)
          {
            handler.start_pair("Reason");
            if (storeReason.in_known_list)
              {
                switch (storeReason.list_value)
                  {
                    case TypeReasonKnownValues.Reason_UserFailedToProvideValidName:
                        handler.string_value("UserFailedToProvideValidName");
                        break;
                    case TypeReasonKnownValues.Reason_UserCancelled:
                        handler.string_value("UserCancelled");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeReason.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new CancelAddGuestsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CancelAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CancelAddGuestsInformationNugget", ignore_extras);
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
    public static new CancelAddGuestsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CancelAddGuestsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CancelAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CancelAddGuestsInformationNugget", ignore_extras);
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
    public static new CancelAddGuestsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CancelAddGuestsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        CancelAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CancelAddGuestsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CancelAddGuestsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CancelAddGuestsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CancelAddGuestsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CancelAddGuestsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorReason : JSONStringGenerator
          {
            protected FieldGeneratorReason(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorReason()
              {
              }
            protected override void handle_result(string result)
              {
                TypeReasonKnownValues known = stringToReason(result);
                TypeReason new_value = new TypeReason();
                if (known == TypeReasonKnownValues.Reason__none)
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
            protected abstract void handle_result(TypeReason result);
          };
    private class FieldHoldingGeneratorReason : FieldGeneratorReason
  {
    protected override void handle_result(TypeReason result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorReason(String what)
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
    public TypeReason value;
  };
    private class FieldHoldingArrayGeneratorReason : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorReason
      {
        private FieldHoldingArrayGeneratorReason top;

        protected override void handle_result(TypeReason result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorReason init_top)
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
    protected virtual void handle_result(List<TypeReason> result)
      {
      }

    public FieldHoldingArrayGeneratorReason(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReason>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorReason()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeReason>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeReason> value;
  };
        private FieldHoldingGeneratorReason fieldGeneratorReason;
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
            if (!(getInformationNuggetJSONKey().Equals("CancelAddGuestsInformationNugget")))
                throw new Exception("The key field has a value other than `CancelAddGuestsInformationNugget'.");
            CancelAddGuestsInformationNuggetJSON result = new CancelAddGuestsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCancelAddGuestsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((CancelAddGuestsInformationNuggetJSON )new_result);
          }
        protected void finish(CancelAddGuestsInformationNuggetJSON result)
          {
            if (fieldGeneratorReason.have_value)
              {
                result.setReason(fieldGeneratorReason.value);
                fieldGeneratorReason.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CancelAddGuestsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Reason", 0, 6, false) == 0) && (field_name.Length == 6))
                return fieldGeneratorReason;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the CancelAddGuestsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CancelAddGuestsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorReason = new FieldHoldingGeneratorReason("field \"Reason\" of the CancelAddGuestsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CancelAddGuestsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorReason.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CancelAddGuestsInformationNuggetJSON  result)
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
        public CancelAddGuestsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CancelAddGuestsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<CancelAddGuestsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CancelAddGuestsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CancelAddGuestsInformationNuggetJSON>();
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
    public List<CancelAddGuestsInformationNuggetJSON> value;
  };
  };
