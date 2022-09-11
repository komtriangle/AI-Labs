/* file "IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON : JSONBase
  {
    public struct TypesessionId
      {
        public int key;
        public string choice0;
        public bool choice1;
      };
    public struct Typeerrors
      {
        public int key;
        public List< IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON  > choice0;
        public bool choice1;
      };
    public struct TypefirstError
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON  choice0;
            [FieldOffset(0)]
            public bool choice1;
          };
        public Utype u;
      };
    private bool flagHassessionId;
    private TypesessionId storesessionId;
    private bool flagHasprofileId;
    private BigInteger storeprofileId;
    private bool flagHasnewUser;
    private bool storenewUser;
    private bool flagHassuccess;
    private bool storesuccess;
    private bool flagHasduration;
    private BigInteger storeduration;
    private bool flagHaserrors;
    private Typeerrors storeerrors;
    private bool flagHasfirstError;
    private TypefirstError storefirstError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONsessionId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypesessionId or_result = new TypesessionId();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for ??? is not a string.");
                or_result.choice0 = json_string.getData();
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field sessionId of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not one of the allowed values.");
        setsessionId(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONprofileId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field profileId of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field profileId of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setprofileId(extracted_integer);
      }


    private void  fromJSONnewUser(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field newUser of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not true for false.");
              }
          }
        setnewUser(the_bool);
      }


    private void  fromJSONsuccess(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field success of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not true for false.");
              }
          }
        setsuccess(the_bool);
      }


    private void  fromJSONduration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field duration of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field duration of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setduration(extracted_integer);
      }


    private void  fromJSONerrors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        Typeerrors or_result = new Typeerrors();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for ??? is not an array.");
                int count1 = json_array1.componentCount();
                List< IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON  > vector_errors_01 = new List< IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON  >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON convert_classy = IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.from_json(json_array1.component(num1), ignore_extras, true);
                    vector_errors_01.Add(convert_classy);
                  }
                or_result.choice0 = vector_errors_01;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field errors of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not one of the allowed values.");
        seterrors(or_result);
        switch (or_result.key)
          {
            case 0:
                for (int num1 = 0; num1 < or_result.choice0.Count; ++num1)
                  {
                  }
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONfirstError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypefirstError or_result = new TypefirstError();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON convert_classy = IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field firstError of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is not one of the allowed values.");
        setfirstError(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON()
      {
        flagHassessionId = false;
        flagHasprofileId = false;
        flagHasnewUser = false;
        flagHassuccess = false;
        flagHasduration = false;
        flagHaserrors = false;
        flagHasfirstError = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hassessionId()
      {
        return flagHassessionId;
      }

    public TypesessionId  getsessionId()
      {
        Debug.Assert(flagHassessionId);
        return storesessionId;
      }

    public bool  hasprofileId()
      {
        return flagHasprofileId;
      }

    public BigInteger  getprofileId()
      {
        Debug.Assert(flagHasprofileId);
        return storeprofileId;
      }

    public bool  hasnewUser()
      {
        return flagHasnewUser;
      }

    public bool  getnewUser()
      {
        Debug.Assert(flagHasnewUser);
        return storenewUser;
      }

    public bool  hassuccess()
      {
        return flagHassuccess;
      }

    public bool  getsuccess()
      {
        Debug.Assert(flagHassuccess);
        return storesuccess;
      }

    public bool  hasduration()
      {
        return flagHasduration;
      }

    public BigInteger  getduration()
      {
        Debug.Assert(flagHasduration);
        return storeduration;
      }

    public bool  haserrors()
      {
        return flagHaserrors;
      }

    public Typeerrors  geterrors()
      {
        Debug.Assert(flagHaserrors);
        return storeerrors;
      }

    public bool  hasfirstError()
      {
        return flagHasfirstError;
      }

    public TypefirstError  getfirstError()
      {
        Debug.Assert(flagHasfirstError);
        return storefirstError;
      }


    public virtual int extraIHeartMediaLoginOrCreateOAuthUserAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartMediaLoginOrCreateOAuthUserAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartMediaLoginOrCreateOAuthUserAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartMediaLoginOrCreateOAuthUserAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setsessionId(TypesessionId new_value)
      {
        flagHassessionId = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storesessionId = new_value;
      }
    public void unsetsessionId()
      {
        flagHassessionId = false;
      }
    public void setprofileId(BigInteger new_value)
      {
        flagHasprofileId = true;
        if (new_value < 0)
            throw new Exception("The value for field profileId of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is less than the lower bound (0) for that field.");
        storeprofileId = new_value;
      }
    public void unsetprofileId()
      {
        flagHasprofileId = false;
      }
    public void setnewUser(bool new_value)
      {
        flagHasnewUser = true;
        storenewUser = new_value;
      }
    public void unsetnewUser()
      {
        flagHasnewUser = false;
      }
    public void setsuccess(bool new_value)
      {
        flagHassuccess = true;
        storesuccess = new_value;
      }
    public void unsetsuccess()
      {
        flagHassuccess = false;
      }
    public void setduration(BigInteger new_value)
      {
        flagHasduration = true;
        if (new_value < 0)
            throw new Exception("The value for field duration of IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON is less than the lower bound (0) for that field.");
        storeduration = new_value;
      }
    public void unsetduration()
      {
        flagHasduration = false;
      }
    public void seterrors(Typeerrors new_value)
      {
        switch (new_value.key)
          {
            case 0:
                for (int num1 = 0; num1 < new_value.choice0.Count; ++num1)
                  {
                  }
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHaserrors)
          {
            switch (storeerrors.key)
              {
                case 0:
                    for (int num1 = 0; num1 < storeerrors.choice0.Count; ++num1)
                      {
                      }
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaserrors = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeerrors = new_value;
      }
    public void unseterrors()
      {
        if (flagHaserrors)
          {
            switch (storeerrors.key)
              {
                case 0:
                    for (int num2 = 0; num2 < storeerrors.choice0.Count; ++num2)
                      {
                      }
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHaserrors = false;
      }
    public void setfirstError(TypefirstError new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasfirstError)
          {
            switch (storefirstError.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasfirstError = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storefirstError = new_value;
      }
    public void unsetfirstError()
      {
        if (flagHasfirstError)
          {
            switch (storefirstError.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasfirstError = false;
      }

    public virtual void extraIHeartMediaLoginOrCreateOAuthUserAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartMediaLoginOrCreateOAuthUserAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartMediaLoginOrCreateOAuthUserAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartMediaLoginOrCreateOAuthUserAPIResponseAppendPair(key, new_component);
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
        if (flagHassessionId)
          {
            handler.start_pair("sessionId");
            switch (storesessionId.key)
              {
                case 0:
                    handler.string_value(storesessionId.choice0);
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasprofileId)
          {
            handler.start_pair("profileId");
            handler.number_value(storeprofileId);
          }
        if (flagHasnewUser)
          {
            handler.start_pair("newUser");
            handler.boolean_value(storenewUser);
          }
        if (flagHassuccess)
          {
            handler.start_pair("success");
            handler.boolean_value(storesuccess);
          }
        if (flagHasduration)
          {
            handler.start_pair("duration");
            handler.number_value(storeduration);
          }
        if (flagHaserrors)
          {
            handler.start_pair("errors");
            switch (storeerrors.key)
              {
                case 0:
                    handler.start_array();
                    for (int num1 = 0; num1 < storeerrors.choice0.Count; ++num1)
                      {
                        if (partial_allowed)
                            storeerrors.choice0[num1].write_partial_as_json(handler);
                        else
                            storeerrors.choice0[num1].write_as_json(handler);
                      }
                    handler.finish_array();
                    break;
                case 1:
                    handler.null_value();
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasfirstError)
          {
            handler.start_pair("firstError");
            switch (storefirstError.key)
              {
                case 0:
                    if (partial_allowed)
                        storefirstError.u.choice0.write_partial_as_json(handler);
                    else
                        storefirstError.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    handler.null_value();
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

    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaLoginOrCreateOAuthUserAPIResponse", ignore_extras);
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
    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaLoginOrCreateOAuthUserAPIResponse", ignore_extras);
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
    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaLoginOrCreateOAuthUserAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartMediaLoginOrCreateOAuthUserAPIResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorsessionId : JSONParallelGenerator
          {
            private JSONHoldingStringGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypesessionId result = new TypesessionId();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypesessionId result);
            public FieldGeneratorsessionId(bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"sessionId\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"sessionId\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorsessionId(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingStringGenerator("option 0 of field \"sessionId\"");
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"sessionId\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HoldersessionId
          {
            private bool have_data;
            private TypesessionId data;
            public HoldersessionId()  { have_data = false; }
            public HoldersessionId(TypesessionId init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HoldersessionId(HoldersessionId other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypesessionId referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorsessionId : FieldGeneratorsessionId
          {
            protected override void handle_result(TypesessionId result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HoldersessionId(result);
              }

            public FieldHoldingGeneratorsessionId(String what, bool ignore_extras) : base(ignore_extras)
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
            public HoldersessionId value;
          };
    private class FieldHoldingArrayGeneratorsessionId : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorsessionId
      {
        private FieldHoldingArrayGeneratorsessionId top;

        protected override void handle_result(TypesessionId result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorsessionId init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypesessionId> result)
      {
      }

    public FieldHoldingArrayGeneratorsessionId(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypesessionId>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorsessionId(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypesessionId>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypesessionId> value;
  };
        private FieldHoldingGeneratorsessionId fieldGeneratorsessionId;
    private class FieldHoldingGeneratorprofileId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorprofileId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorprofileId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorprofileId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorprofileId fieldGeneratorprofileId;
        private JSONHoldingBooleanGenerator fieldGeneratornewUser;
        private JSONHoldingBooleanGenerator fieldGeneratorsuccess;
    private class FieldHoldingGeneratorduration : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorduration : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorduration fieldGeneratorduration;
    private abstract class FieldGeneratorerrors : JSONParallelGenerator
          {
            private IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingArrayGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                Typeerrors result = new Typeerrors();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        int count = field0.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.choice0.Add(field0.value[num]);
                          }
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(Typeerrors result);
            public FieldGeneratorerrors(bool ignore_extras)
              {
                    field0 = new IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingArrayGenerator("option 0 of field \"errors\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"errors\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorerrors(string what, bool ignore_extras)
              {
                    field0 = new IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingArrayGenerator("option 0 of field \"errors\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"errors\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class Holdererrors
          {
            private bool have_data;
            private Typeerrors data;
            public Holdererrors()  { have_data = false; }
            public Holdererrors(Typeerrors init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public Holdererrors(Holdererrors other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public Typeerrors referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorerrors : FieldGeneratorerrors
          {
            protected override void handle_result(Typeerrors result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new Holdererrors(result);
              }

            public FieldHoldingGeneratorerrors(String what, bool ignore_extras) : base(ignore_extras)
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
            public Holdererrors value;
          };
    private class FieldHoldingArrayGeneratorerrors : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorerrors
      {
        private FieldHoldingArrayGeneratorerrors top;

        protected override void handle_result(Typeerrors result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorerrors init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<Typeerrors> result)
      {
      }

    public FieldHoldingArrayGeneratorerrors(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeerrors>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorerrors(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<Typeerrors>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typeerrors> value;
  };
        private FieldHoldingGeneratorerrors fieldGeneratorerrors;
    private abstract class FieldGeneratorfirstError : JSONParallelGenerator
          {
            private IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingGenerator field0;
            private JSONHoldingNullGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypefirstError result = new TypefirstError();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypefirstError result);
            public FieldGeneratorfirstError(bool ignore_extras)
              {
                    field0 = new IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingGenerator("option 0 of field \"firstError\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"firstError\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorfirstError(string what, bool ignore_extras)
              {
                    field0 = new IHeartMediaLoginOrCreateOAuthUserAPIResponseErrorJSON.HoldingGenerator("option 0 of field \"firstError\"", ignore_extras);
                    field1 = new JSONHoldingNullGenerator("option 1 of field \"firstError\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderfirstError
          {
            private bool have_data;
            private TypefirstError data;
            public HolderfirstError()  { have_data = false; }
            public HolderfirstError(TypefirstError init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderfirstError(HolderfirstError other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypefirstError referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorfirstError : FieldGeneratorfirstError
          {
            protected override void handle_result(TypefirstError result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderfirstError(result);
              }

            public FieldHoldingGeneratorfirstError(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderfirstError value;
          };
    private class FieldHoldingArrayGeneratorfirstError : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorfirstError
      {
        private FieldHoldingArrayGeneratorfirstError top;

        protected override void handle_result(TypefirstError result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorfirstError init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypefirstError> result)
      {
      }

    public FieldHoldingArrayGeneratorfirstError(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypefirstError>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorfirstError(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypefirstError>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypefirstError> value;
  };
        private FieldHoldingGeneratorfirstError fieldGeneratorfirstError;
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
            IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result = new IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartMediaLoginOrCreateOAuthUserAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON result)
          {
            if (fieldGeneratorsessionId.have_value)
              {
                result.setsessionId(fieldGeneratorsessionId.value.referenced());
                fieldGeneratorsessionId.have_value = false;
              }
            if (fieldGeneratorprofileId.have_value)
              {
                result.setprofileId(fieldGeneratorprofileId.value);
                fieldGeneratorprofileId.have_value = false;
              }
            if (fieldGeneratornewUser.have_value)
              {
                result.setnewUser(fieldGeneratornewUser.value);
                fieldGeneratornewUser.have_value = false;
              }
            if (fieldGeneratorsuccess.have_value)
              {
                result.setsuccess(fieldGeneratorsuccess.value);
                fieldGeneratorsuccess.have_value = false;
              }
            if (fieldGeneratorduration.have_value)
              {
                result.setduration(fieldGeneratorduration.value);
                fieldGeneratorduration.have_value = false;
              }
            if (fieldGeneratorerrors.have_value)
              {
                result.seterrors(fieldGeneratorerrors.value.referenced());
                fieldGeneratorerrors.have_value = false;
              }
            if (fieldGeneratorfirstError.have_value)
              {
                result.setfirstError(fieldGeneratorfirstError.value.referenced());
                fieldGeneratorfirstError.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorduration;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "rrors", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorerrors;
                    break;
                case 'f':
                    if ((String.Compare(field_name, 1, "irstError", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorfirstError;
                    break;
                case 'n':
                    if ((String.Compare(field_name, 1, "ewUser", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratornewUser;
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "rofileId", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorprofileId;
                    break;
                case 's':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ssionId", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorsessionId;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "ccess", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorsuccess;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorsessionId = new FieldHoldingGeneratorsessionId("field \"sessionId\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", ignore_extras);
            fieldGeneratorprofileId = new FieldHoldingGeneratorprofileId("field \"profileId\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratornewUser = new JSONHoldingBooleanGenerator("field \"newUser\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorsuccess = new JSONHoldingBooleanGenerator("field \"success\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorerrors = new FieldHoldingGeneratorerrors("field \"errors\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", ignore_extras);
            fieldGeneratorfirstError = new FieldHoldingGeneratorfirstError("field \"firstError\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorsessionId = new FieldHoldingGeneratorsessionId("field \"sessionId\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", false);
            fieldGeneratorprofileId = new FieldHoldingGeneratorprofileId("field \"profileId\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratornewUser = new JSONHoldingBooleanGenerator("field \"newUser\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorsuccess = new JSONHoldingBooleanGenerator("field \"success\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            fieldGeneratorerrors = new FieldHoldingGeneratorerrors("field \"errors\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", false);
            fieldGeneratorfirstError = new FieldHoldingGeneratorfirstError("field \"firstError\" of the IHeartMediaLoginOrCreateOAuthUserAPIResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartMediaLoginOrCreateOAuthUserAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorsessionId.reset();
            fieldGeneratorprofileId.reset();
            fieldGeneratornewUser.reset();
            fieldGeneratorsuccess.reset();
            fieldGeneratorduration.reset();
            fieldGeneratorerrors.reset();
            fieldGeneratorfirstError.reset();
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
        protected override void handle_result(IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON  result)
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
        public IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON>();
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
    public List<IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON> value;
  };
  };
