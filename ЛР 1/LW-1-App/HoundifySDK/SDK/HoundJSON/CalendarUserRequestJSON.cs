/* file "CalendarUserRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CalendarUserRequestJSON : JSONBase
  {
    public enum TypeVerb
      {
        Verb_LookLike,
        Verb_WhatIsOn,
        Verb_WhatIsNext,
        Verb_WhatsUp,
        Verb_Plans,
        Verb_Do,
        Verb_Have,
        Verb_Show,
        Verb_Free,
        Verb_Open,
        Verb_Busy,
        Verb_IsThere,
        Verb_Made
      };

    public static TypeVerb  stringToVerb(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "usy", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Busy;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "o", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeVerb.Verb_Do;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ree", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Free;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "ave", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Have;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "sThere", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeVerb.Verb_IsThere;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "ookLike", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeVerb.Verb_LookLike;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ade", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Made;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "pen", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Open;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "lans", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeVerb.Verb_Plans;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "how", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeVerb.Verb_Show;
                break;
            case 'W':
                if (String.Compare(chars, 1, "hat", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'I':
                            if (String.Compare(chars, 5, "s", 0, 1, false) == 0)
                              {
                                switch (chars[6])
                                  {
                                    case 'N':
                                        if ((String.Compare(chars, 7, "ext", 0, 3, false) == 0) && (chars.Length == 10))
                                            return TypeVerb.Verb_WhatIsNext;
                                        break;
                                    case 'O':
                                        if ((String.Compare(chars, 7, "n", 0, 1, false) == 0) && (chars.Length == 8))
                                            return TypeVerb.Verb_WhatIsOn;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(chars, 5, "Up", 0, 2, false) == 0) && (chars.Length == 7))
                                return TypeVerb.Verb_WhatsUp;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Verb' is not one of the legal values.");
      }

    public static string  stringFromVerb(TypeVerb the_enum)
      {
        switch (the_enum)
          {
            case TypeVerb.Verb_LookLike:
                return "LookLike";
            case TypeVerb.Verb_WhatIsOn:
                return "WhatIsOn";
            case TypeVerb.Verb_WhatIsNext:
                return "WhatIsNext";
            case TypeVerb.Verb_WhatsUp:
                return "WhatsUp";
            case TypeVerb.Verb_Plans:
                return "Plans";
            case TypeVerb.Verb_Do:
                return "Do";
            case TypeVerb.Verb_Have:
                return "Have";
            case TypeVerb.Verb_Show:
                return "Show";
            case TypeVerb.Verb_Free:
                return "Free";
            case TypeVerb.Verb_Open:
                return "Open";
            case TypeVerb.Verb_Busy:
                return "Busy";
            case TypeVerb.Verb_IsThere:
                return "IsThere";
            case TypeVerb.Verb_Made:
                return "Made";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasVerb;
    private TypeVerb storeVerb;
    private bool flagHasDetail;
    private string storeDetail;
    private bool flagHasFrom;
    private string storeFrom;
    private bool flagHasTo;
    private string storeTo;
    private bool flagHasQuery;
    private CalendarQueryJSON  storeQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONVerb(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Verb of CalendarUserRequestJSON is not a string.");
        TypeVerb the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "usy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Busy;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeVerb.Verb_Do;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ree", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Free;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "ave", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Have;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "sThere", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeVerb.Verb_IsThere;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ookLike", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeVerb.Verb_LookLike;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ade", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Made;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Open;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "lans", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeVerb.Verb_Plans;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "how", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeVerb.Verb_Show;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "hat", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'I':
                            if (String.Compare(json_string.getData(), 5, "s", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[6])
                                  {
                                    case 'N':
                                        if ((String.Compare(json_string.getData(), 7, "ext", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_enum = TypeVerb.Verb_WhatIsNext;
                                                goto enum_is_done;
                                              }
                                        break;
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 7, "n", 0, 1, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_enum = TypeVerb.Verb_WhatIsOn;
                                                goto enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 5, "Up", 0, 2, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_enum = TypeVerb.Verb_WhatsUp;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Verb of CalendarUserRequestJSON is not one of the legal strings.");
      enum_is_done:;
        setVerb(the_enum);
      }


    private void  fromJSONDetail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Detail of CalendarUserRequestJSON is not a string.");
        setDetail(json_string.getData());
      }


    private void  fromJSONFrom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field From of CalendarUserRequestJSON is not a string.");
        setFrom(json_string.getData());
      }


    private void  fromJSONTo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field To of CalendarUserRequestJSON is not a string.");
        setTo(json_string.getData());
      }


    private void  fromJSONQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CalendarQueryJSON convert_classy = CalendarQueryJSON.from_json(json_value, ignore_extras, true);
        setQuery(convert_classy);
      }


    public CalendarUserRequestJSON()
      {
        flagHasVerb = false;
        flagHasDetail = false;
        flagHasFrom = false;
        flagHasTo = false;
        flagHasQuery = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasVerb()
      {
        return flagHasVerb;
      }

    public TypeVerb  getVerb()
      {
        Debug.Assert(flagHasVerb);
        return storeVerb;
      }

    public string  getVerbAsString()
      {
        return stringFromVerb(getVerb());
      }

    public bool  hasDetail()
      {
        return flagHasDetail;
      }

    public string  getDetail()
      {
        Debug.Assert(flagHasDetail);
        return storeDetail;
      }

    public bool  hasFrom()
      {
        return flagHasFrom;
      }

    public string  getFrom()
      {
        Debug.Assert(flagHasFrom);
        return storeFrom;
      }

    public bool  hasTo()
      {
        return flagHasTo;
      }

    public string  getTo()
      {
        Debug.Assert(flagHasTo);
        return storeTo;
      }

    public bool  hasQuery()
      {
        return flagHasQuery;
      }

    public CalendarQueryJSON   getQuery()
      {
        Debug.Assert(flagHasQuery);
        return storeQuery;
      }


    public virtual int extraCalendarUserRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCalendarUserRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCalendarUserRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCalendarUserRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setVerb(TypeVerb new_value)
      {
        flagHasVerb = true;
        storeVerb = new_value;
      }
    public void setVerb(string chars)
      {
        setVerb(stringToVerb(chars));
      }
    public void unsetVerb()
      {
        flagHasVerb = false;
      }
    public void setDetail(string new_value)
      {
        flagHasDetail = true;
        storeDetail = new_value;
      }
    public void unsetDetail()
      {
        flagHasDetail = false;
      }
    public void setFrom(string new_value)
      {
        flagHasFrom = true;
        storeFrom = new_value;
      }
    public void unsetFrom()
      {
        flagHasFrom = false;
      }
    public void setTo(string new_value)
      {
        flagHasTo = true;
        storeTo = new_value;
      }
    public void unsetTo()
      {
        flagHasTo = false;
      }
    public void setQuery(CalendarQueryJSON  new_value)
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = true;
        storeQuery = new_value;
      }
    public void unsetQuery()
      {
        if (flagHasQuery)
          {
          }
        flagHasQuery = false;
      }

    public virtual void extraCalendarUserRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCalendarUserRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCalendarUserRequestLookup(key);
        if (old_field == null)
          {
            extraCalendarUserRequestAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasVerb);
        if (flagHasVerb)
          {
            handler.start_pair("Verb");
            switch (storeVerb)
              {
                case TypeVerb.Verb_LookLike:
                    handler.string_value("LookLike");
                    break;
                case TypeVerb.Verb_WhatIsOn:
                    handler.string_value("WhatIsOn");
                    break;
                case TypeVerb.Verb_WhatIsNext:
                    handler.string_value("WhatIsNext");
                    break;
                case TypeVerb.Verb_WhatsUp:
                    handler.string_value("WhatsUp");
                    break;
                case TypeVerb.Verb_Plans:
                    handler.string_value("Plans");
                    break;
                case TypeVerb.Verb_Do:
                    handler.string_value("Do");
                    break;
                case TypeVerb.Verb_Have:
                    handler.string_value("Have");
                    break;
                case TypeVerb.Verb_Show:
                    handler.string_value("Show");
                    break;
                case TypeVerb.Verb_Free:
                    handler.string_value("Free");
                    break;
                case TypeVerb.Verb_Open:
                    handler.string_value("Open");
                    break;
                case TypeVerb.Verb_Busy:
                    handler.string_value("Busy");
                    break;
                case TypeVerb.Verb_IsThere:
                    handler.string_value("IsThere");
                    break;
                case TypeVerb.Verb_Made:
                    handler.string_value("Made");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasDetail);
        if (flagHasDetail)
          {
            handler.start_pair("Detail");
            handler.string_value(storeDetail);
          }
        Debug.Assert(partial_allowed || flagHasFrom);
        if (flagHasFrom)
          {
            handler.start_pair("From");
            handler.string_value(storeFrom);
          }
        Debug.Assert(partial_allowed || flagHasTo);
        if (flagHasTo)
          {
            handler.start_pair("To");
            handler.string_value(storeTo);
          }
        Debug.Assert(partial_allowed || flagHasQuery);
        if (flagHasQuery)
          {
            handler.start_pair("Query");
            if (partial_allowed)
                storeQuery.write_partial_as_json(handler);
            else
                storeQuery.write_as_json(handler);
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
        if (!(hasVerb()))
          {
            return "When parsing the object for %what%, the \"Verb\" field was missing.";
          }
        if (!(hasDetail()))
          {
            return "When parsing the object for %what%, the \"Detail\" field was missing.";
          }
        if (!(hasFrom()))
          {
            return "When parsing the object for %what%, the \"From\" field was missing.";
          }
        if (!(hasTo()))
          {
            return "When parsing the object for %what%, the \"To\" field was missing.";
          }
        if (!(hasQuery()))
          {
            return "When parsing the object for %what%, the \"Query\" field was missing.";
          }
        return null;
      }

    public static CalendarUserRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUserRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUserRequest", ignore_extras);
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
    public static CalendarUserRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarUserRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarUserRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUserRequest", ignore_extras);
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
    public static CalendarUserRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarUserRequestJSON from_text(string text, bool ignore_extras)
      {
        CalendarUserRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUserRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarUserRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarUserRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarUserRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarUserRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorVerb : JSONStringGenerator
          {
            protected FieldGeneratorVerb(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorVerb()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToVerb(result));
              }
            protected abstract void handle_result(TypeVerb result);
          };
    private class FieldHoldingGeneratorVerb : FieldGeneratorVerb
  {
    protected override void handle_result(TypeVerb result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorVerb(String what)
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
    public TypeVerb value;
  };
    private class FieldHoldingArrayGeneratorVerb : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorVerb
      {
        private FieldHoldingArrayGeneratorVerb top;

        protected override void handle_result(TypeVerb result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorVerb init_top)
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
    protected virtual void handle_result(List<TypeVerb> result)
      {
      }

    public FieldHoldingArrayGeneratorVerb(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVerb>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorVerb()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVerb>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeVerb> value;
  };
        private FieldHoldingGeneratorVerb fieldGeneratorVerb;
        private JSONHoldingStringGenerator fieldGeneratorDetail;
        private JSONHoldingStringGenerator fieldGeneratorFrom;
        private JSONHoldingStringGenerator fieldGeneratorTo;
        private CalendarQueryJSON.HoldingGenerator fieldGeneratorQuery;
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
            CalendarUserRequestJSON result = new CalendarUserRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarUserRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CalendarUserRequestJSON result)
          {
            if (fieldGeneratorVerb.have_value)
              {
                result.setVerb(fieldGeneratorVerb.value);
                fieldGeneratorVerb.have_value = false;
              }
            else if ((!(result.hasVerb())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Verb\" field was missing.");
              }
            if (fieldGeneratorDetail.have_value)
              {
                result.setDetail(fieldGeneratorDetail.value);
                fieldGeneratorDetail.have_value = false;
              }
            else if ((!(result.hasDetail())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Detail\" field was missing.");
              }
            if (fieldGeneratorFrom.have_value)
              {
                result.setFrom(fieldGeneratorFrom.value);
                fieldGeneratorFrom.have_value = false;
              }
            else if ((!(result.hasFrom())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"From\" field was missing.");
              }
            if (fieldGeneratorTo.have_value)
              {
                result.setTo(fieldGeneratorTo.value);
                fieldGeneratorTo.have_value = false;
              }
            else if ((!(result.hasTo())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"To\" field was missing.");
              }
            if (fieldGeneratorQuery.have_value)
              {
                result.setQuery(fieldGeneratorQuery.value);
                fieldGeneratorQuery.have_value = false;
              }
            else if ((!(result.hasQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Query\" field was missing.");
              }
          }
        protected abstract void handle_result(CalendarUserRequestJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "etail", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorDetail;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "rom", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorFrom;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uery", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorQuery;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "o", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorTo;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "erb", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorVerb;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorVerb = new FieldHoldingGeneratorVerb("field \"Verb\" of the CalendarUserRequest class");
            fieldGeneratorDetail = new JSONHoldingStringGenerator("field \"Detail\" of the CalendarUserRequest class");
            fieldGeneratorFrom = new JSONHoldingStringGenerator("field \"From\" of the CalendarUserRequest class");
            fieldGeneratorTo = new JSONHoldingStringGenerator("field \"To\" of the CalendarUserRequest class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the CalendarUserRequest class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CalendarUserRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorVerb = new FieldHoldingGeneratorVerb("field \"Verb\" of the CalendarUserRequest class");
            fieldGeneratorDetail = new JSONHoldingStringGenerator("field \"Detail\" of the CalendarUserRequest class");
            fieldGeneratorFrom = new JSONHoldingStringGenerator("field \"From\" of the CalendarUserRequest class");
            fieldGeneratorTo = new JSONHoldingStringGenerator("field \"To\" of the CalendarUserRequest class");
            fieldGeneratorQuery = new CalendarQueryJSON.HoldingGenerator("field \"Query\" of the CalendarUserRequest class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CalendarUserRequest class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorVerb.reset();
            fieldGeneratorDetail.reset();
            fieldGeneratorFrom.reset();
            fieldGeneratorTo.reset();
            fieldGeneratorQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQuery.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQuery.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarUserRequestJSON  result)
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
        public CalendarUserRequestJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarUserRequestJSON  result)
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
    protected virtual void handle_result(List<CalendarUserRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarUserRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarUserRequestJSON>();
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
    public List<CalendarUserRequestJSON> value;
  };
  };
