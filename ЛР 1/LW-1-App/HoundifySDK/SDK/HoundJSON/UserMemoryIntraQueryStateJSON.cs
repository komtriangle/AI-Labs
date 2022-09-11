/* file "UserMemoryIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserMemoryIntraQueryStateJSON : JSONBase
  {
    public enum TypeWhatToRemember
      {
        WhatToRemember_Name,
        WhatToRemember_Location
      };

    public static TypeWhatToRemember  stringToWhatToRemember(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ocation", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeWhatToRemember.WhatToRemember_Location;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "ame", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeWhatToRemember.WhatToRemember_Name;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `WhatToRemember' is not one of the legal values.");
      }

    public static string  stringFromWhatToRemember(TypeWhatToRemember the_enum)
      {
        switch (the_enum)
          {
            case TypeWhatToRemember.WhatToRemember_Name:
                return "Name";
            case TypeWhatToRemember.WhatToRemember_Location:
                return "Location";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasWhatToRemember;
    private TypeWhatToRemember storeWhatToRemember;
    private bool flagHasWhat;
    private string storeWhat;
    private bool flagHasSpecialLocation;
    private UserMemorySpecialLocationJSON  storeSpecialLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWhatToRemember(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WhatToRemember of UserMemoryIntraQueryStateJSON is not a string.");
        TypeWhatToRemember the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeWhatToRemember.WhatToRemember_Location;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeWhatToRemember.WhatToRemember_Name;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field WhatToRemember of UserMemoryIntraQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setWhatToRemember(the_enum);
      }


    private void  fromJSONWhat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field What of UserMemoryIntraQueryStateJSON is not a string.");
        setWhat(json_string.getData());
      }


    private void  fromJSONSpecialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserMemorySpecialLocationJSON convert_classy = UserMemorySpecialLocationJSON.from_json(json_value, ignore_extras, true);
        setSpecialLocation(convert_classy);
      }


    public UserMemoryIntraQueryStateJSON()
      {
        flagHasWhatToRemember = false;
        flagHasWhat = false;
        flagHasSpecialLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWhatToRemember()
      {
        return flagHasWhatToRemember;
      }

    public TypeWhatToRemember  getWhatToRemember()
      {
        Debug.Assert(flagHasWhatToRemember);
        return storeWhatToRemember;
      }

    public string  getWhatToRememberAsString()
      {
        return stringFromWhatToRemember(getWhatToRemember());
      }

    public bool  hasWhat()
      {
        return flagHasWhat;
      }

    public string  getWhat()
      {
        Debug.Assert(flagHasWhat);
        return storeWhat;
      }

    public bool  hasSpecialLocation()
      {
        return flagHasSpecialLocation;
      }

    public UserMemorySpecialLocationJSON   getSpecialLocation()
      {
        Debug.Assert(flagHasSpecialLocation);
        return storeSpecialLocation;
      }

    public UserMemorySpecialLocationJSON.TypeValue  getSpecialLocationValue()
      {
        return getSpecialLocation().getValue();
      }

    public string  getSpecialLocationAsString()
      {
        return getSpecialLocation().getValueAsString();
      }


    public virtual int extraUserMemoryIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserMemoryIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserMemoryIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserMemoryIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setWhatToRemember(TypeWhatToRemember new_value)
      {
        flagHasWhatToRemember = true;
        storeWhatToRemember = new_value;
      }
    public void setWhatToRemember(string chars)
      {
        setWhatToRemember(stringToWhatToRemember(chars));
      }
    public void unsetWhatToRemember()
      {
        flagHasWhatToRemember = false;
      }
    public void setWhat(string new_value)
      {
        flagHasWhat = true;
        storeWhat = new_value;
      }
    public void unsetWhat()
      {
        flagHasWhat = false;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON  new_value)
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = true;
        storeSpecialLocation = new_value;
      }
    public void setSpecialLocation(UserMemorySpecialLocationJSON.TypeValue new_value)
      {
        setSpecialLocation(new UserMemorySpecialLocationJSON(new_value));
      }
    public void setSpecialLocation(string chars)
      {
        UserMemorySpecialLocationJSON.TypeValueKnownValues known = UserMemorySpecialLocationJSON.stringToValue(chars);
        UserMemorySpecialLocationJSON.TypeValue new_value = new UserMemorySpecialLocationJSON.TypeValue();
        if (known == UserMemorySpecialLocationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSpecialLocation(new_value);
      }
    public void unsetSpecialLocation()
      {
        if (flagHasSpecialLocation)
          {
          }
        flagHasSpecialLocation = false;
      }

    public virtual void extraUserMemoryIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserMemoryIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserMemoryIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraUserMemoryIntraQueryStateAppendPair(key, new_component);
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
        if (flagHasWhatToRemember)
          {
            handler.start_pair("WhatToRemember");
            switch (storeWhatToRemember)
              {
                case TypeWhatToRemember.WhatToRemember_Name:
                    handler.string_value("Name");
                    break;
                case TypeWhatToRemember.WhatToRemember_Location:
                    handler.string_value("Location");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasWhat)
          {
            handler.start_pair("What");
            handler.string_value(storeWhat);
          }
        if (flagHasSpecialLocation)
          {
            handler.start_pair("SpecialLocation");
            if (partial_allowed)
                storeSpecialLocation.write_partial_as_json(handler);
            else
                storeSpecialLocation.write_as_json(handler);
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

    public static UserMemoryIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryIntraQueryState", ignore_extras);
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
    public static UserMemoryIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMemoryIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryIntraQueryState", ignore_extras);
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
    public static UserMemoryIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMemoryIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        UserMemoryIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserMemoryIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserMemoryIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserMemoryIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorWhatToRemember : JSONStringGenerator
          {
            protected FieldGeneratorWhatToRemember(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorWhatToRemember()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToWhatToRemember(result));
              }
            protected abstract void handle_result(TypeWhatToRemember result);
          };
    private class FieldHoldingGeneratorWhatToRemember : FieldGeneratorWhatToRemember
  {
    protected override void handle_result(TypeWhatToRemember result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorWhatToRemember(String what)
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
    public TypeWhatToRemember value;
  };
    private class FieldHoldingArrayGeneratorWhatToRemember : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorWhatToRemember
      {
        private FieldHoldingArrayGeneratorWhatToRemember top;

        protected override void handle_result(TypeWhatToRemember result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorWhatToRemember init_top)
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
    protected virtual void handle_result(List<TypeWhatToRemember> result)
      {
      }

    public FieldHoldingArrayGeneratorWhatToRemember(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWhatToRemember>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorWhatToRemember()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeWhatToRemember>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeWhatToRemember> value;
  };
        private FieldHoldingGeneratorWhatToRemember fieldGeneratorWhatToRemember;
        private JSONHoldingStringGenerator fieldGeneratorWhat;
        private UserMemorySpecialLocationJSON.HoldingGenerator fieldGeneratorSpecialLocation;
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
            UserMemoryIntraQueryStateJSON result = new UserMemoryIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserMemoryIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserMemoryIntraQueryStateJSON result)
          {
            if (fieldGeneratorWhatToRemember.have_value)
              {
                result.setWhatToRemember(fieldGeneratorWhatToRemember.value);
                fieldGeneratorWhatToRemember.have_value = false;
              }
            if (fieldGeneratorWhat.have_value)
              {
                result.setWhat(fieldGeneratorWhat.value);
                fieldGeneratorWhat.have_value = false;
              }
            if (fieldGeneratorSpecialLocation.have_value)
              {
                result.setSpecialLocation(fieldGeneratorSpecialLocation.value);
                fieldGeneratorSpecialLocation.have_value = false;
              }
          }
        protected abstract void handle_result(UserMemoryIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    if ((String.Compare(field_name, 1, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSpecialLocation;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "hat", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorWhat;
                          }
                        switch (field_name[4])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 5, "oRemember", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorWhatToRemember;
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
            fieldGeneratorWhatToRemember = new FieldHoldingGeneratorWhatToRemember("field \"WhatToRemember\" of the UserMemoryIntraQueryState class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the UserMemoryIntraQueryState class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the UserMemoryIntraQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserMemoryIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWhatToRemember = new FieldHoldingGeneratorWhatToRemember("field \"WhatToRemember\" of the UserMemoryIntraQueryState class");
            fieldGeneratorWhat = new JSONHoldingStringGenerator("field \"What\" of the UserMemoryIntraQueryState class");
            fieldGeneratorSpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"SpecialLocation\" of the UserMemoryIntraQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserMemoryIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWhatToRemember.reset();
            fieldGeneratorWhat.reset();
            fieldGeneratorSpecialLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSpecialLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSpecialLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UserMemoryIntraQueryStateJSON  result)
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
        public UserMemoryIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserMemoryIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<UserMemoryIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserMemoryIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserMemoryIntraQueryStateJSON>();
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
    public List<UserMemoryIntraQueryStateJSON> value;
  };
  };
