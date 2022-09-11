/* file "OrganizationMemberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OrganizationMemberJSON : JSONBase
  {
    private bool flagHasId;
    private string storeId;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasDepartment;
    private string storeDepartment;
    private bool flagHasLocale;
    private string storeLocale;
    private bool flagHasManagerId;
    private string storeManagerId;
    private bool flagHasManagerName;
    private string storeManagerName;
    private bool flagHasContact;
    private OneContactJSON  storeContact;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Id of OrganizationMemberJSON is not a string.");
        setId(json_string.getData());
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of OrganizationMemberJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONDepartment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Department of OrganizationMemberJSON is not a string.");
        setDepartment(json_string.getData());
      }


    private void  fromJSONLocale(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Locale of OrganizationMemberJSON is not a string.");
        setLocale(json_string.getData());
      }


    private void  fromJSONManagerId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ManagerId of OrganizationMemberJSON is not a string.");
        setManagerId(json_string.getData());
      }


    private void  fromJSONManagerName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ManagerName of OrganizationMemberJSON is not a string.");
        setManagerName(json_string.getData());
      }


    private void  fromJSONContact(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OneContactJSON convert_classy = OneContactJSON.from_json(json_value, ignore_extras, true);
        setContact(convert_classy);
      }


    public OrganizationMemberJSON()
      {
        flagHasId = false;
        flagHasTitle = false;
        flagHasDepartment = false;
        flagHasLocale = false;
        flagHasManagerId = false;
        flagHasManagerName = false;
        flagHasContact = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasId()
      {
        return flagHasId;
      }

    public string  getId()
      {
        Debug.Assert(flagHasId);
        return storeId;
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasDepartment()
      {
        return flagHasDepartment;
      }

    public string  getDepartment()
      {
        Debug.Assert(flagHasDepartment);
        return storeDepartment;
      }

    public bool  hasLocale()
      {
        return flagHasLocale;
      }

    public string  getLocale()
      {
        Debug.Assert(flagHasLocale);
        return storeLocale;
      }

    public bool  hasManagerId()
      {
        return flagHasManagerId;
      }

    public string  getManagerId()
      {
        Debug.Assert(flagHasManagerId);
        return storeManagerId;
      }

    public bool  hasManagerName()
      {
        return flagHasManagerName;
      }

    public string  getManagerName()
      {
        Debug.Assert(flagHasManagerName);
        return storeManagerName;
      }

    public bool  hasContact()
      {
        return flagHasContact;
      }

    public OneContactJSON   getContact()
      {
        Debug.Assert(flagHasContact);
        return storeContact;
      }


    public virtual int extraOrganizationMemberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOrganizationMemberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOrganizationMemberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOrganizationMemberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setId(string new_value)
      {
        flagHasId = true;
        storeId = new_value;
      }
    public void unsetId()
      {
        flagHasId = false;
      }
    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setDepartment(string new_value)
      {
        flagHasDepartment = true;
        storeDepartment = new_value;
      }
    public void unsetDepartment()
      {
        flagHasDepartment = false;
      }
    public void setLocale(string new_value)
      {
        flagHasLocale = true;
        storeLocale = new_value;
      }
    public void unsetLocale()
      {
        flagHasLocale = false;
      }
    public void setManagerId(string new_value)
      {
        flagHasManagerId = true;
        storeManagerId = new_value;
      }
    public void unsetManagerId()
      {
        flagHasManagerId = false;
      }
    public void setManagerName(string new_value)
      {
        flagHasManagerName = true;
        storeManagerName = new_value;
      }
    public void unsetManagerName()
      {
        flagHasManagerName = false;
      }
    public void setContact(OneContactJSON  new_value)
      {
        if (flagHasContact)
          {
          }
        flagHasContact = true;
        storeContact = new_value;
      }
    public void unsetContact()
      {
        if (flagHasContact)
          {
          }
        flagHasContact = false;
      }

    public virtual void extraOrganizationMemberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOrganizationMemberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOrganizationMemberLookup(key);
        if (old_field == null)
          {
            extraOrganizationMemberAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasId);
        if (flagHasId)
          {
            handler.start_pair("Id");
            handler.string_value(storeId);
          }
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasDepartment)
          {
            handler.start_pair("Department");
            handler.string_value(storeDepartment);
          }
        if (flagHasLocale)
          {
            handler.start_pair("Locale");
            handler.string_value(storeLocale);
          }
        if (flagHasManagerId)
          {
            handler.start_pair("ManagerId");
            handler.string_value(storeManagerId);
          }
        if (flagHasManagerName)
          {
            handler.start_pair("ManagerName");
            handler.string_value(storeManagerName);
          }
        Debug.Assert(partial_allowed || flagHasContact);
        if (flagHasContact)
          {
            handler.start_pair("Contact");
            if (partial_allowed)
                storeContact.write_partial_as_json(handler);
            else
                storeContact.write_as_json(handler);
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
        if (!(hasId()))
          {
            return "When parsing the object for %what%, the \"Id\" field was missing.";
          }
        if (!(hasContact()))
          {
            return "When parsing the object for %what%, the \"Contact\" field was missing.";
          }
        return null;
      }

    public static OrganizationMemberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OrganizationMemberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OrganizationMember", ignore_extras);
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
    public static OrganizationMemberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OrganizationMemberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OrganizationMemberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OrganizationMember", ignore_extras);
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
    public static OrganizationMemberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OrganizationMemberJSON from_text(string text, bool ignore_extras)
      {
        OrganizationMemberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OrganizationMember", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OrganizationMemberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OrganizationMemberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OrganizationMemberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OrganizationMember", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorId;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorDepartment;
        private JSONHoldingStringGenerator fieldGeneratorLocale;
        private JSONHoldingStringGenerator fieldGeneratorManagerId;
        private JSONHoldingStringGenerator fieldGeneratorManagerName;
        private OneContactJSON.HoldingGenerator fieldGeneratorContact;
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
            OrganizationMemberJSON result = new OrganizationMemberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOrganizationMemberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OrganizationMemberJSON result)
          {
            if (fieldGeneratorId.have_value)
              {
                result.setId(fieldGeneratorId.value);
                fieldGeneratorId.have_value = false;
              }
            else if ((!(result.hasId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Id\" field was missing.");
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorDepartment.have_value)
              {
                result.setDepartment(fieldGeneratorDepartment.value);
                fieldGeneratorDepartment.have_value = false;
              }
            if (fieldGeneratorLocale.have_value)
              {
                result.setLocale(fieldGeneratorLocale.value);
                fieldGeneratorLocale.have_value = false;
              }
            if (fieldGeneratorManagerId.have_value)
              {
                result.setManagerId(fieldGeneratorManagerId.value);
                fieldGeneratorManagerId.have_value = false;
              }
            if (fieldGeneratorManagerName.have_value)
              {
                result.setManagerName(fieldGeneratorManagerName.value);
                fieldGeneratorManagerName.have_value = false;
              }
            if (fieldGeneratorContact.have_value)
              {
                result.setContact(fieldGeneratorContact.value);
                fieldGeneratorContact.have_value = false;
              }
            else if ((!(result.hasContact())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Contact\" field was missing.");
              }
          }
        protected abstract void handle_result(OrganizationMemberJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontact", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorContact;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "epartment", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDepartment;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorId;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocale", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLocale;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "anager", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "d", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorManagerId;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorManagerName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the OrganizationMember class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the OrganizationMember class");
            fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the OrganizationMember class");
            fieldGeneratorLocale = new JSONHoldingStringGenerator("field \"Locale\" of the OrganizationMember class");
            fieldGeneratorManagerId = new JSONHoldingStringGenerator("field \"ManagerId\" of the OrganizationMember class");
            fieldGeneratorManagerName = new JSONHoldingStringGenerator("field \"ManagerName\" of the OrganizationMember class");
            fieldGeneratorContact = new OneContactJSON.HoldingGenerator("field \"Contact\" of the OrganizationMember class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OrganizationMember class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the OrganizationMember class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the OrganizationMember class");
            fieldGeneratorDepartment = new JSONHoldingStringGenerator("field \"Department\" of the OrganizationMember class");
            fieldGeneratorLocale = new JSONHoldingStringGenerator("field \"Locale\" of the OrganizationMember class");
            fieldGeneratorManagerId = new JSONHoldingStringGenerator("field \"ManagerId\" of the OrganizationMember class");
            fieldGeneratorManagerName = new JSONHoldingStringGenerator("field \"ManagerName\" of the OrganizationMember class");
            fieldGeneratorContact = new OneContactJSON.HoldingGenerator("field \"Contact\" of the OrganizationMember class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OrganizationMember class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorId.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorDepartment.reset();
            fieldGeneratorLocale.reset();
            fieldGeneratorManagerId.reset();
            fieldGeneratorManagerName.reset();
            fieldGeneratorContact.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorContact.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorContact.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OrganizationMemberJSON  result)
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
        public OrganizationMemberJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OrganizationMemberJSON  result)
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
    protected virtual void handle_result(List<OrganizationMemberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OrganizationMemberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OrganizationMemberJSON>();
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
    public List<OrganizationMemberJSON> value;
  };
  };
