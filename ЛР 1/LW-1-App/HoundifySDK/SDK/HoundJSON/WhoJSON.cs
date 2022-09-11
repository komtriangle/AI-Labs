/* file "WhoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WhoJSON : JSONBase
  {
    public enum TypeSex
      {
        Sex_Female,
        Sex_Male
      };

    public static TypeSex  stringToSex(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "emale", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeSex.Sex_Female;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "ale", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeSex.Sex_Male;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Sex' is not one of the legal values.");
      }

    public static string  stringFromSex(TypeSex the_enum)
      {
        switch (the_enum)
          {
            case TypeSex.Sex_Female:
                return "Female";
            case TypeSex.Sex_Male:
                return "Male";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFullName;
    private string storeFullName;
    private bool flagHasSpokenName;
    private string storeSpokenName;
    private bool flagHasFullNamePronunciation;
    private string storeFullNamePronunciation;
    private bool flagHasAliases;
    private List< string > storeAliases;
    private bool flagHasAliasPronunciations;
    private List< string > storeAliasPronunciations;
    private bool flagHasFirstName;
    private string storeFirstName;
    private bool flagHasLastName;
    private string storeLastName;
    private bool flagHasReferredToAs;
    private string storeReferredToAs;
    private bool flagHasSex;
    private TypeSex storeSex;
    private bool flagHasBirthday;
    private DateAndOrTimeJSON  storeBirthday;
    private bool flagHasWikipediaArticleTitle;
    private string storeWikipediaArticleTitle;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFullName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FullName of WhoJSON is not a string.");
        setFullName(json_string.getData());
      }


    private void  fromJSONSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenName of WhoJSON is not a string.");
        setSpokenName(json_string.getData());
      }


    private void  fromJSONFullNamePronunciation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FullNamePronunciation of WhoJSON is not a string.");
        setFullNamePronunciation(json_string.getData());
      }


    private void  fromJSONAliases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Aliases of WhoJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Aliases of WhoJSON has too few elements.");
        List< string > vector_Aliases1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Aliases of WhoJSON is not a string.");
            vector_Aliases1.Add(json_string.getData());
          }
        Debug.Assert(vector_Aliases1.Count >= 1);
        initAliases();
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
            appendAliases(vector_Aliases1[num1]);
        for (int num1 = 0; num1 < vector_Aliases1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAliasPronunciations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AliasPronunciations of WhoJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field AliasPronunciations of WhoJSON has too few elements.");
        List< string > vector_AliasPronunciations1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AliasPronunciations of WhoJSON is not a string.");
            vector_AliasPronunciations1.Add(json_string.getData());
          }
        Debug.Assert(vector_AliasPronunciations1.Count >= 1);
        initAliasPronunciations();
        for (int num2 = 0; num2 < vector_AliasPronunciations1.Count; ++num2)
            appendAliasPronunciations(vector_AliasPronunciations1[num2]);
        for (int num1 = 0; num1 < vector_AliasPronunciations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFirstName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FirstName of WhoJSON is not a string.");
        setFirstName(json_string.getData());
      }


    private void  fromJSONLastName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastName of WhoJSON is not a string.");
        setLastName(json_string.getData());
      }


    private void  fromJSONReferredToAs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ReferredToAs of WhoJSON is not a string.");
        setReferredToAs(json_string.getData());
      }


    private void  fromJSONSex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Sex of WhoJSON is not a string.");
        TypeSex the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "emale", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeSex.Sex_Female;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "ale", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeSex.Sex_Male;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Sex of WhoJSON is not one of the legal strings.");
      enum_is_done:;
        setSex(the_enum);
      }


    private void  fromJSONBirthday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setBirthday(convert_classy);
      }


    private void  fromJSONWikipediaArticleTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WikipediaArticleTitle of WhoJSON is not a string.");
        setWikipediaArticleTitle(json_string.getData());
      }


    public WhoJSON()
      {
        flagHasFullName = false;
        flagHasSpokenName = false;
        flagHasFullNamePronunciation = false;
        flagHasAliases = false;
        flagHasAliasPronunciations = false;
        flagHasFirstName = false;
        flagHasLastName = false;
        flagHasReferredToAs = false;
        flagHasSex = false;
        flagHasBirthday = false;
        flagHasWikipediaArticleTitle = false;
        storeAliases = new List< string >();
        storeAliasPronunciations = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFullName()
      {
        return flagHasFullName;
      }

    public string  getFullName()
      {
        Debug.Assert(flagHasFullName);
        return storeFullName;
      }

    public bool  hasSpokenName()
      {
        return flagHasSpokenName;
      }

    public string  getSpokenName()
      {
        Debug.Assert(flagHasSpokenName);
        return storeSpokenName;
      }

    public bool  hasFullNamePronunciation()
      {
        return flagHasFullNamePronunciation;
      }

    public string  getFullNamePronunciation()
      {
        Debug.Assert(flagHasFullNamePronunciation);
        return storeFullNamePronunciation;
      }

    public bool  hasAliases()
      {
        return flagHasAliases;
      }

    public int  countOfAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases.Count;
      }

    public string  elementOfAliases(int element_num)
      {
        Debug.Assert(flagHasAliases);
        return storeAliases[element_num];
      }

    public List< string >  getAliases()
      {
        Debug.Assert(flagHasAliases);
        return storeAliases;
      }

    public bool  hasAliasPronunciations()
      {
        return flagHasAliasPronunciations;
      }

    public int  countOfAliasPronunciations()
      {
        Debug.Assert(flagHasAliasPronunciations);
        return storeAliasPronunciations.Count;
      }

    public string  elementOfAliasPronunciations(int element_num)
      {
        Debug.Assert(flagHasAliasPronunciations);
        return storeAliasPronunciations[element_num];
      }

    public List< string >  getAliasPronunciations()
      {
        Debug.Assert(flagHasAliasPronunciations);
        return storeAliasPronunciations;
      }

    public bool  hasFirstName()
      {
        return flagHasFirstName;
      }

    public string  getFirstName()
      {
        Debug.Assert(flagHasFirstName);
        return storeFirstName;
      }

    public bool  hasLastName()
      {
        return flagHasLastName;
      }

    public string  getLastName()
      {
        Debug.Assert(flagHasLastName);
        return storeLastName;
      }

    public bool  hasReferredToAs()
      {
        return flagHasReferredToAs;
      }

    public string  getReferredToAs()
      {
        Debug.Assert(flagHasReferredToAs);
        return storeReferredToAs;
      }

    public bool  hasSex()
      {
        return flagHasSex;
      }

    public TypeSex  getSex()
      {
        Debug.Assert(flagHasSex);
        return storeSex;
      }

    public string  getSexAsString()
      {
        return stringFromSex(getSex());
      }

    public bool  hasBirthday()
      {
        return flagHasBirthday;
      }

    public DateAndOrTimeJSON   getBirthday()
      {
        Debug.Assert(flagHasBirthday);
        return storeBirthday;
      }

    public bool  hasWikipediaArticleTitle()
      {
        return flagHasWikipediaArticleTitle;
      }

    public string  getWikipediaArticleTitle()
      {
        Debug.Assert(flagHasWikipediaArticleTitle);
        return storeWikipediaArticleTitle;
      }


    public virtual int extraWhoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWhoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWhoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWhoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFullName(string new_value)
      {
        flagHasFullName = true;
        storeFullName = new_value;
      }
    public void unsetFullName()
      {
        flagHasFullName = false;
      }
    public void setSpokenName(string new_value)
      {
        flagHasSpokenName = true;
        storeSpokenName = new_value;
      }
    public void unsetSpokenName()
      {
        flagHasSpokenName = false;
      }
    public void setFullNamePronunciation(string new_value)
      {
        flagHasFullNamePronunciation = true;
        storeFullNamePronunciation = new_value;
      }
    public void unsetFullNamePronunciation()
      {
        flagHasFullNamePronunciation = false;
      }
    public void initAliases()
      {
        flagHasAliases = true;
        storeAliases.Clear();
      }
    public void appendAliases(string to_append)
      {
        if (!flagHasAliases)
          {
            flagHasAliases = true;
            storeAliases.Clear();
          }
        Debug.Assert(flagHasAliases);
        storeAliases.Add(to_append);
      }
    public void unsetAliases()
      {
        flagHasAliases = false;
        storeAliases.Clear();
      }
    public void initAliasPronunciations()
      {
        flagHasAliasPronunciations = true;
        storeAliasPronunciations.Clear();
      }
    public void appendAliasPronunciations(string to_append)
      {
        if (!flagHasAliasPronunciations)
          {
            flagHasAliasPronunciations = true;
            storeAliasPronunciations.Clear();
          }
        Debug.Assert(flagHasAliasPronunciations);
        storeAliasPronunciations.Add(to_append);
      }
    public void unsetAliasPronunciations()
      {
        flagHasAliasPronunciations = false;
        storeAliasPronunciations.Clear();
      }
    public void setFirstName(string new_value)
      {
        flagHasFirstName = true;
        storeFirstName = new_value;
      }
    public void unsetFirstName()
      {
        flagHasFirstName = false;
      }
    public void setLastName(string new_value)
      {
        flagHasLastName = true;
        storeLastName = new_value;
      }
    public void unsetLastName()
      {
        flagHasLastName = false;
      }
    public void setReferredToAs(string new_value)
      {
        flagHasReferredToAs = true;
        storeReferredToAs = new_value;
      }
    public void unsetReferredToAs()
      {
        flagHasReferredToAs = false;
      }
    public void setSex(TypeSex new_value)
      {
        flagHasSex = true;
        storeSex = new_value;
      }
    public void setSex(string chars)
      {
        setSex(stringToSex(chars));
      }
    public void unsetSex()
      {
        flagHasSex = false;
      }
    public void setBirthday(DateAndOrTimeJSON  new_value)
      {
        if (flagHasBirthday)
          {
          }
        flagHasBirthday = true;
        storeBirthday = new_value;
      }
    public void unsetBirthday()
      {
        if (flagHasBirthday)
          {
          }
        flagHasBirthday = false;
      }
    public void setWikipediaArticleTitle(string new_value)
      {
        flagHasWikipediaArticleTitle = true;
        storeWikipediaArticleTitle = new_value;
      }
    public void unsetWikipediaArticleTitle()
      {
        flagHasWikipediaArticleTitle = false;
      }

    public virtual void extraWhoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWhoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWhoLookup(key);
        if (old_field == null)
          {
            extraWhoAppendPair(key, new_component);
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
        if (flagHasFullName)
          {
            handler.start_pair("FullName");
            handler.string_value(storeFullName);
          }
        if (flagHasSpokenName)
          {
            handler.start_pair("SpokenName");
            handler.string_value(storeSpokenName);
          }
        if (flagHasFullNamePronunciation)
          {
            handler.start_pair("FullNamePronunciation");
            handler.string_value(storeFullNamePronunciation);
          }
        if (flagHasAliases)
          {
            handler.start_pair("Aliases");
            Debug.Assert(storeAliases.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeAliases.Count; ++num1)
              {
                handler.string_value(storeAliases[num1]);
              }
            handler.finish_array();
          }
        if (flagHasAliasPronunciations)
          {
            handler.start_pair("AliasPronunciations");
            Debug.Assert(storeAliasPronunciations.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeAliasPronunciations.Count; ++num2)
              {
                handler.string_value(storeAliasPronunciations[num2]);
              }
            handler.finish_array();
          }
        if (flagHasFirstName)
          {
            handler.start_pair("FirstName");
            handler.string_value(storeFirstName);
          }
        if (flagHasLastName)
          {
            handler.start_pair("LastName");
            handler.string_value(storeLastName);
          }
        if (flagHasReferredToAs)
          {
            handler.start_pair("ReferredToAs");
            handler.string_value(storeReferredToAs);
          }
        if (flagHasSex)
          {
            handler.start_pair("Sex");
            switch (storeSex)
              {
                case TypeSex.Sex_Female:
                    handler.string_value("Female");
                    break;
                case TypeSex.Sex_Male:
                    handler.string_value("Male");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasBirthday)
          {
            handler.start_pair("Birthday");
            if (partial_allowed)
                storeBirthday.write_partial_as_json(handler);
            else
                storeBirthday.write_as_json(handler);
          }
        if (flagHasWikipediaArticleTitle)
          {
            handler.start_pair("WikipediaArticleTitle");
            handler.string_value(storeWikipediaArticleTitle);
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

    public static WhoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Who", ignore_extras);
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
    public static WhoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Who", ignore_extras);
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
    public static WhoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhoJSON from_text(string text, bool ignore_extras)
      {
        WhoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Who", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WhoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WhoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WhoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Who", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFullName;
        private JSONHoldingStringGenerator fieldGeneratorSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorFullNamePronunciation;
        private JSONHoldingStringArrayGenerator fieldGeneratorAliases;
        private JSONHoldingStringArrayGenerator fieldGeneratorAliasPronunciations;
        private JSONHoldingStringGenerator fieldGeneratorFirstName;
        private JSONHoldingStringGenerator fieldGeneratorLastName;
        private JSONHoldingStringGenerator fieldGeneratorReferredToAs;
    private abstract class FieldGeneratorSex : JSONStringGenerator
          {
            protected FieldGeneratorSex(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSex()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSex(result));
              }
            protected abstract void handle_result(TypeSex result);
          };
    private class FieldHoldingGeneratorSex : FieldGeneratorSex
  {
    protected override void handle_result(TypeSex result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSex(String what)
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
    public TypeSex value;
  };
    private class FieldHoldingArrayGeneratorSex : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSex
      {
        private FieldHoldingArrayGeneratorSex top;

        protected override void handle_result(TypeSex result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSex init_top)
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
    protected virtual void handle_result(List<TypeSex> result)
      {
      }

    public FieldHoldingArrayGeneratorSex(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSex()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSex>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSex> value;
  };
        private FieldHoldingGeneratorSex fieldGeneratorSex;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorBirthday;
        private JSONHoldingStringGenerator fieldGeneratorWikipediaArticleTitle;
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
            WhoJSON result = new WhoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWhoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WhoJSON result)
          {
            if (fieldGeneratorFullName.have_value)
              {
                result.setFullName(fieldGeneratorFullName.value);
                fieldGeneratorFullName.have_value = false;
              }
            if (fieldGeneratorSpokenName.have_value)
              {
                result.setSpokenName(fieldGeneratorSpokenName.value);
                fieldGeneratorSpokenName.have_value = false;
              }
            if (fieldGeneratorFullNamePronunciation.have_value)
              {
                result.setFullNamePronunciation(fieldGeneratorFullNamePronunciation.value);
                fieldGeneratorFullNamePronunciation.have_value = false;
              }
            if (fieldGeneratorAliases.have_value)
              {
                result.initAliases();
                int count = fieldGeneratorAliases.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAliases(fieldGeneratorAliases.value[num]);
                  }
                fieldGeneratorAliases.value.Clear();
                fieldGeneratorAliases.have_value = false;
              }
            if (fieldGeneratorAliasPronunciations.have_value)
              {
                result.initAliasPronunciations();
                int count = fieldGeneratorAliasPronunciations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAliasPronunciations(fieldGeneratorAliasPronunciations.value[num]);
                  }
                fieldGeneratorAliasPronunciations.value.Clear();
                fieldGeneratorAliasPronunciations.have_value = false;
              }
            if (fieldGeneratorFirstName.have_value)
              {
                result.setFirstName(fieldGeneratorFirstName.value);
                fieldGeneratorFirstName.have_value = false;
              }
            if (fieldGeneratorLastName.have_value)
              {
                result.setLastName(fieldGeneratorLastName.value);
                fieldGeneratorLastName.have_value = false;
              }
            if (fieldGeneratorReferredToAs.have_value)
              {
                result.setReferredToAs(fieldGeneratorReferredToAs.value);
                fieldGeneratorReferredToAs.have_value = false;
              }
            if (fieldGeneratorSex.have_value)
              {
                result.setSex(fieldGeneratorSex.value);
                fieldGeneratorSex.have_value = false;
              }
            if (fieldGeneratorBirthday.have_value)
              {
                result.setBirthday(fieldGeneratorBirthday.value);
                fieldGeneratorBirthday.have_value = false;
              }
            if (fieldGeneratorWikipediaArticleTitle.have_value)
              {
                result.setWikipediaArticleTitle(fieldGeneratorWikipediaArticleTitle.value);
                fieldGeneratorWikipediaArticleTitle.have_value = false;
              }
          }
        protected abstract void handle_result(WhoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "lias", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 6, "ronunciations", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorAliasPronunciations;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 6, "s", 0, 1, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorAliases;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "irthday", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBirthday;
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "rstName", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorFirstName;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "llName", 0, 6, false) == 0)
                              {
                                if (field_name.Length == 8)
                                  {
                                    return fieldGeneratorFullName;
                                  }
                                switch (field_name[8])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 9, "ronunciation", 0, 12, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorFullNamePronunciation;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLastName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferredToAs", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorReferredToAs;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "x", 0, 1, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorSex;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSpokenName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ikipediaArticleTitle", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorWikipediaArticleTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the Who class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Who class");
            fieldGeneratorFullNamePronunciation = new JSONHoldingStringGenerator("field \"FullNamePronunciation\" of the Who class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the Who class");
            fieldGeneratorAliasPronunciations = new JSONHoldingStringArrayGenerator("field \"AliasPronunciations\" of the Who class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the Who class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the Who class");
            fieldGeneratorReferredToAs = new JSONHoldingStringGenerator("field \"ReferredToAs\" of the Who class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the Who class");
            fieldGeneratorBirthday = new DateAndOrTimeJSON.HoldingGenerator("field \"Birthday\" of the Who class", ignore_extras);
            fieldGeneratorWikipediaArticleTitle = new JSONHoldingStringGenerator("field \"WikipediaArticleTitle\" of the Who class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Who class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFullName = new JSONHoldingStringGenerator("field \"FullName\" of the Who class");
            fieldGeneratorSpokenName = new JSONHoldingStringGenerator("field \"SpokenName\" of the Who class");
            fieldGeneratorFullNamePronunciation = new JSONHoldingStringGenerator("field \"FullNamePronunciation\" of the Who class");
            fieldGeneratorAliases = new JSONHoldingStringArrayGenerator("field \"Aliases\" of the Who class");
            fieldGeneratorAliasPronunciations = new JSONHoldingStringArrayGenerator("field \"AliasPronunciations\" of the Who class");
            fieldGeneratorFirstName = new JSONHoldingStringGenerator("field \"FirstName\" of the Who class");
            fieldGeneratorLastName = new JSONHoldingStringGenerator("field \"LastName\" of the Who class");
            fieldGeneratorReferredToAs = new JSONHoldingStringGenerator("field \"ReferredToAs\" of the Who class");
            fieldGeneratorSex = new FieldHoldingGeneratorSex("field \"Sex\" of the Who class");
            fieldGeneratorBirthday = new DateAndOrTimeJSON.HoldingGenerator("field \"Birthday\" of the Who class", false);
            fieldGeneratorWikipediaArticleTitle = new JSONHoldingStringGenerator("field \"WikipediaArticleTitle\" of the Who class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Who class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFullName.reset();
            fieldGeneratorSpokenName.reset();
            fieldGeneratorFullNamePronunciation.reset();
            fieldGeneratorAliases.reset();
            fieldGeneratorAliasPronunciations.reset();
            fieldGeneratorFirstName.reset();
            fieldGeneratorLastName.reset();
            fieldGeneratorReferredToAs.reset();
            fieldGeneratorSex.reset();
            fieldGeneratorBirthday.reset();
            fieldGeneratorWikipediaArticleTitle.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBirthday.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBirthday.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WhoJSON  result)
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
        public WhoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WhoJSON  result)
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
    protected virtual void handle_result(List<WhoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WhoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WhoJSON>();
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
    public List<WhoJSON> value;
  };
  };
