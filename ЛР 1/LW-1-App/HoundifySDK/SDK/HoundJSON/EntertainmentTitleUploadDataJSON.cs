/* file "EntertainmentTitleUploadDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class EntertainmentTitleUploadDataJSON : JSONBase
  {
    public enum TypePopularityKnownValues
      {
        Popularity_VERY_HIGH_POPULARITY,
        Popularity_HIGH_POPULARITY,
        Popularity_MEDIUM_POPULARITY,
        Popularity_MEDIUM_LOW_POPULARITY,
        Popularity_LOW_POPULARITY,
        Popularity__none
      };
    public struct TypePopularity
      {
        public bool in_known_list;
        public string string_value;
        public TypePopularityKnownValues list_value;
      };

    public static TypePopularityKnownValues  stringToPopularity(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "IGH_POPULARITY", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypePopularityKnownValues.Popularity_HIGH_POPULARITY;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "OW_POPULARITY", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypePopularityKnownValues.Popularity_LOW_POPULARITY;
                break;
            case 'M':
                if (String.Compare(chars, 1, "EDIUM_", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'L':
                            if ((String.Compare(chars, 8, "OW_POPULARITY", 0, 13, false) == 0) && (chars.Length == 21))
                                return TypePopularityKnownValues.Popularity_MEDIUM_LOW_POPULARITY;
                            break;
                        case 'P':
                            if ((String.Compare(chars, 8, "OPULARITY", 0, 9, false) == 0) && (chars.Length == 17))
                                return TypePopularityKnownValues.Popularity_MEDIUM_POPULARITY;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(chars, 1, "ERY_HIGH_POPULARITY", 0, 19, false) == 0) && (chars.Length == 20))
                    return TypePopularityKnownValues.Popularity_VERY_HIGH_POPULARITY;
                break;
            default:
                break;
          }
        return TypePopularityKnownValues.Popularity__none;
      }

    public static string  stringFromPopularity(TypePopularityKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypePopularityKnownValues.Popularity_VERY_HIGH_POPULARITY:
                return "VERY_HIGH_POPULARITY";
            case TypePopularityKnownValues.Popularity_HIGH_POPULARITY:
                return "HIGH_POPULARITY";
            case TypePopularityKnownValues.Popularity_MEDIUM_POPULARITY:
                return "MEDIUM_POPULARITY";
            case TypePopularityKnownValues.Popularity_MEDIUM_LOW_POPULARITY:
                return "MEDIUM_LOW_POPULARITY";
            case TypePopularityKnownValues.Popularity_LOW_POPULARITY:
                return "LOW_POPULARITY";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasID;
    private string storeID;
    private bool flagHasSpokenTitle;
    private string storeSpokenTitle;
    private bool flagHasDisplayTitle;
    private string storeDisplayTitle;
    private bool flagHasAlternateTitles;
    private List< string > storeAlternateTitles;
    private bool flagHasTitleMatchExpression;
    private string storeTitleMatchExpression;
    private bool flagHasShowType;
    private EntertainmentWorkTypeJSON  storeShowType;
    private bool flagHasReleaseYear;
    private BigInteger storeReleaseYear;
    private bool flagHasReleaseDate;
    private DateAndOrTimeJSON  storeReleaseDate;
    private bool flagHasPopularity;
    private TypePopularity storePopularity;
    private bool flagHasRequireContext;
    private bool storeRequireContext;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of EntertainmentTitleUploadDataJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of EntertainmentTitleUploadDataJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONSpokenTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenTitle of EntertainmentTitleUploadDataJSON is not a string.");
        setSpokenTitle(json_string.getData());
      }


    private void  fromJSONDisplayTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayTitle of EntertainmentTitleUploadDataJSON is not a string.");
        setDisplayTitle(json_string.getData());
      }


    private void  fromJSONAlternateTitles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlternateTitles of EntertainmentTitleUploadDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AlternateTitles1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AlternateTitles of EntertainmentTitleUploadDataJSON is not a string.");
            vector_AlternateTitles1.Add(json_string.getData());
          }
        initAlternateTitles();
        for (int num1 = 0; num1 < vector_AlternateTitles1.Count; ++num1)
            appendAlternateTitles(vector_AlternateTitles1[num1]);
        for (int num1 = 0; num1 < vector_AlternateTitles1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTitleMatchExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TitleMatchExpression of EntertainmentTitleUploadDataJSON is not a string.");
        setTitleMatchExpression(json_string.getData());
      }


    private void  fromJSONShowType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EntertainmentWorkTypeJSON convert_classy = EntertainmentWorkTypeJSON.from_json(json_value, ignore_extras, true);
        setShowType(convert_classy);
      }


    private void  fromJSONReleaseYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReleaseYear of EntertainmentTitleUploadDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReleaseYear of EntertainmentTitleUploadDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReleaseYear(extracted_integer);
      }


    private void  fromJSONReleaseDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setReleaseDate(convert_classy);
      }


    private void  fromJSONPopularity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Popularity of EntertainmentTitleUploadDataJSON is not a string.");
        TypePopularity the_open_enum = new TypePopularity();
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "IGH_POPULARITY", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePopularityKnownValues.Popularity_HIGH_POPULARITY;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "OW_POPULARITY", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePopularityKnownValues.Popularity_LOW_POPULARITY;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "EDIUM_", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'L':
                            if ((String.Compare(json_string.getData(), 8, "OW_POPULARITY", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypePopularityKnownValues.Popularity_MEDIUM_LOW_POPULARITY;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'P':
                            if ((String.Compare(json_string.getData(), 8, "OPULARITY", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypePopularityKnownValues.Popularity_MEDIUM_POPULARITY;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "ERY_HIGH_POPULARITY", 0, 19, false) == 0) && (json_string.getData().Length == 20))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypePopularityKnownValues.Popularity_VERY_HIGH_POPULARITY;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setPopularity(the_open_enum);
      }


    private void  fromJSONRequireContext(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequireContext of EntertainmentTitleUploadDataJSON is not true for false.");
              }
          }
        setRequireContext(the_bool);
      }


    public EntertainmentTitleUploadDataJSON()
      {
        flagHasTitle = false;
        flagHasID = false;
        flagHasSpokenTitle = false;
        flagHasDisplayTitle = false;
        flagHasAlternateTitles = false;
        flagHasTitleMatchExpression = false;
        flagHasShowType = false;
        flagHasReleaseYear = false;
        flagHasReleaseDate = false;
        flagHasPopularity = false;
        flagHasRequireContext = false;
        storeAlternateTitles = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasSpokenTitle()
      {
        return flagHasSpokenTitle;
      }

    public string  getSpokenTitle()
      {
        Debug.Assert(flagHasSpokenTitle);
        return storeSpokenTitle;
      }

    public bool  hasDisplayTitle()
      {
        return flagHasDisplayTitle;
      }

    public string  getDisplayTitle()
      {
        Debug.Assert(flagHasDisplayTitle);
        return storeDisplayTitle;
      }

    public bool  hasAlternateTitles()
      {
        return flagHasAlternateTitles;
      }

    public int  countOfAlternateTitles()
      {
        Debug.Assert(flagHasAlternateTitles);
        return storeAlternateTitles.Count;
      }

    public string  elementOfAlternateTitles(int element_num)
      {
        Debug.Assert(flagHasAlternateTitles);
        return storeAlternateTitles[element_num];
      }

    public List< string >  getAlternateTitles()
      {
        Debug.Assert(flagHasAlternateTitles);
        return storeAlternateTitles;
      }

    public bool  hasTitleMatchExpression()
      {
        return flagHasTitleMatchExpression;
      }

    public string  getTitleMatchExpression()
      {
        Debug.Assert(flagHasTitleMatchExpression);
        return storeTitleMatchExpression;
      }

    public bool  hasShowType()
      {
        return flagHasShowType;
      }

    public EntertainmentWorkTypeJSON   getShowType()
      {
        Debug.Assert(flagHasShowType);
        return storeShowType;
      }

    public EntertainmentWorkTypeJSON.TypeValue  getShowTypeValue()
      {
        return getShowType().getValue();
      }

    public string  getShowTypeAsString()
      {
        return getShowType().getValueAsString();
      }

    public bool  hasReleaseYear()
      {
        return flagHasReleaseYear;
      }

    public BigInteger  getReleaseYear()
      {
        Debug.Assert(flagHasReleaseYear);
        return storeReleaseYear;
      }

    public bool  hasReleaseDate()
      {
        return flagHasReleaseDate;
      }

    public DateAndOrTimeJSON   getReleaseDate()
      {
        Debug.Assert(flagHasReleaseDate);
        return storeReleaseDate;
      }

    public bool  hasPopularity()
      {
        return flagHasPopularity;
      }

    public TypePopularity  getPopularity()
      {
        Debug.Assert(flagHasPopularity);
        return storePopularity;
      }

    public string  getPopularityAsString()
      {
        TypePopularity result = getPopularity();
        if (result.in_known_list)
            return stringFromPopularity(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasRequireContext()
      {
        return flagHasRequireContext;
      }

    public bool  getRequireContext()
      {
        Debug.Assert(flagHasRequireContext);
        return storeRequireContext;
      }


    public virtual int extraEntertainmentTitleUploadDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraEntertainmentTitleUploadDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraEntertainmentTitleUploadDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraEntertainmentTitleUploadDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setSpokenTitle(string new_value)
      {
        flagHasSpokenTitle = true;
        storeSpokenTitle = new_value;
      }
    public void unsetSpokenTitle()
      {
        flagHasSpokenTitle = false;
      }
    public void setDisplayTitle(string new_value)
      {
        flagHasDisplayTitle = true;
        storeDisplayTitle = new_value;
      }
    public void unsetDisplayTitle()
      {
        flagHasDisplayTitle = false;
      }
    public void initAlternateTitles()
      {
        flagHasAlternateTitles = true;
        storeAlternateTitles.Clear();
      }
    public void appendAlternateTitles(string to_append)
      {
        if (!flagHasAlternateTitles)
          {
            flagHasAlternateTitles = true;
            storeAlternateTitles.Clear();
          }
        Debug.Assert(flagHasAlternateTitles);
        storeAlternateTitles.Add(to_append);
      }
    public void unsetAlternateTitles()
      {
        flagHasAlternateTitles = false;
        storeAlternateTitles.Clear();
      }
    public void setTitleMatchExpression(string new_value)
      {
        flagHasTitleMatchExpression = true;
        storeTitleMatchExpression = new_value;
      }
    public void unsetTitleMatchExpression()
      {
        flagHasTitleMatchExpression = false;
      }
    public void setShowType(EntertainmentWorkTypeJSON  new_value)
      {
        if (flagHasShowType)
          {
          }
        flagHasShowType = true;
        storeShowType = new_value;
      }
    public void setShowType(EntertainmentWorkTypeJSON.TypeValue new_value)
      {
        setShowType(new EntertainmentWorkTypeJSON(new_value));
      }
    public void setShowType(string chars)
      {
        EntertainmentWorkTypeJSON.TypeValueKnownValues known = EntertainmentWorkTypeJSON.stringToValue(chars);
        EntertainmentWorkTypeJSON.TypeValue new_value = new EntertainmentWorkTypeJSON.TypeValue();
        if (known == EntertainmentWorkTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setShowType(new_value);
      }
    public void unsetShowType()
      {
        if (flagHasShowType)
          {
          }
        flagHasShowType = false;
      }
    public void setReleaseYear(BigInteger new_value)
      {
        flagHasReleaseYear = true;
        storeReleaseYear = new_value;
      }
    public void unsetReleaseYear()
      {
        flagHasReleaseYear = false;
      }
    public void setReleaseDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasReleaseDate)
          {
          }
        flagHasReleaseDate = true;
        storeReleaseDate = new_value;
      }
    public void unsetReleaseDate()
      {
        if (flagHasReleaseDate)
          {
          }
        flagHasReleaseDate = false;
      }
    public void setPopularity(TypePopularity new_value)
      {
        flagHasPopularity = true;
        storePopularity = new_value;
      }
    public void setPopularity(string chars)
      {
        TypePopularityKnownValues known = stringToPopularity(chars);
        TypePopularity new_value = new TypePopularity();
        if (known == TypePopularityKnownValues.Popularity__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPopularity(new_value);
      }
    public void setPopularity(TypePopularityKnownValues new_value)
      {
        TypePopularity new_full_value = new TypePopularity();
        Debug.Assert(new_value != TypePopularityKnownValues.Popularity__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setPopularity(new_full_value);
      }
    public void unsetPopularity()
      {
        flagHasPopularity = false;
      }
    public void setRequireContext(bool new_value)
      {
        flagHasRequireContext = true;
        storeRequireContext = new_value;
      }
    public void unsetRequireContext()
      {
        flagHasRequireContext = false;
      }

    public virtual void extraEntertainmentTitleUploadDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraEntertainmentTitleUploadDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraEntertainmentTitleUploadDataLookup(key);
        if (old_field == null)
          {
            extraEntertainmentTitleUploadDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasSpokenTitle)
          {
            handler.start_pair("SpokenTitle");
            handler.string_value(storeSpokenTitle);
          }
        if (flagHasDisplayTitle)
          {
            handler.start_pair("DisplayTitle");
            handler.string_value(storeDisplayTitle);
          }
        if (flagHasAlternateTitles)
          {
            handler.start_pair("AlternateTitles");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlternateTitles.Count; ++num1)
              {
                handler.string_value(storeAlternateTitles[num1]);
              }
            handler.finish_array();
          }
        if (flagHasTitleMatchExpression)
          {
            handler.start_pair("TitleMatchExpression");
            handler.string_value(storeTitleMatchExpression);
          }
        if (flagHasShowType)
          {
            handler.start_pair("ShowType");
            if (partial_allowed)
                storeShowType.write_partial_as_json(handler);
            else
                storeShowType.write_as_json(handler);
          }
        if (flagHasReleaseYear)
          {
            handler.start_pair("ReleaseYear");
            handler.number_value(storeReleaseYear);
          }
        if (flagHasReleaseDate)
          {
            handler.start_pair("ReleaseDate");
            if (partial_allowed)
                storeReleaseDate.write_partial_as_json(handler);
            else
                storeReleaseDate.write_as_json(handler);
          }
        if (flagHasPopularity)
          {
            handler.start_pair("Popularity");
            if (storePopularity.in_known_list)
              {
                switch (storePopularity.list_value)
                  {
                    case TypePopularityKnownValues.Popularity_VERY_HIGH_POPULARITY:
                        handler.string_value("VERY_HIGH_POPULARITY");
                        break;
                    case TypePopularityKnownValues.Popularity_HIGH_POPULARITY:
                        handler.string_value("HIGH_POPULARITY");
                        break;
                    case TypePopularityKnownValues.Popularity_MEDIUM_POPULARITY:
                        handler.string_value("MEDIUM_POPULARITY");
                        break;
                    case TypePopularityKnownValues.Popularity_MEDIUM_LOW_POPULARITY:
                        handler.string_value("MEDIUM_LOW_POPULARITY");
                        break;
                    case TypePopularityKnownValues.Popularity_LOW_POPULARITY:
                        handler.string_value("LOW_POPULARITY");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storePopularity.string_value);
              }
          }
        if (flagHasRequireContext)
          {
            handler.start_pair("RequireContext");
            handler.boolean_value(storeRequireContext);
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
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        return null;
      }

    public static EntertainmentTitleUploadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntertainmentTitleUploadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntertainmentTitleUploadData", ignore_extras);
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
    public static EntertainmentTitleUploadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntertainmentTitleUploadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntertainmentTitleUploadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntertainmentTitleUploadData", ignore_extras);
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
    public static EntertainmentTitleUploadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntertainmentTitleUploadDataJSON from_text(string text, bool ignore_extras)
      {
        EntertainmentTitleUploadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntertainmentTitleUploadData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EntertainmentTitleUploadDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EntertainmentTitleUploadDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EntertainmentTitleUploadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntertainmentTitleUploadData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingStringGenerator fieldGeneratorSpokenTitle;
        private JSONHoldingStringGenerator fieldGeneratorDisplayTitle;
        private JSONHoldingStringArrayGenerator fieldGeneratorAlternateTitles;
        private JSONHoldingStringGenerator fieldGeneratorTitleMatchExpression;
        private EntertainmentWorkTypeJSON.HoldingGenerator fieldGeneratorShowType;
    private class FieldHoldingGeneratorReleaseYear : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorReleaseYear(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorReleaseYear : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorReleaseYear(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorReleaseYear fieldGeneratorReleaseYear;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorReleaseDate;
    private abstract class FieldGeneratorPopularity : JSONStringGenerator
          {
            protected FieldGeneratorPopularity(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorPopularity()
              {
              }
            protected override void handle_result(string result)
              {
                TypePopularityKnownValues known = stringToPopularity(result);
                TypePopularity new_value = new TypePopularity();
                if (known == TypePopularityKnownValues.Popularity__none)
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
            protected abstract void handle_result(TypePopularity result);
          };
    private class FieldHoldingGeneratorPopularity : FieldGeneratorPopularity
  {
    protected override void handle_result(TypePopularity result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorPopularity(String what)
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
    public TypePopularity value;
  };
    private class FieldHoldingArrayGeneratorPopularity : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorPopularity
      {
        private FieldHoldingArrayGeneratorPopularity top;

        protected override void handle_result(TypePopularity result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorPopularity init_top)
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
    protected virtual void handle_result(List<TypePopularity> result)
      {
      }

    public FieldHoldingArrayGeneratorPopularity(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePopularity>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorPopularity()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypePopularity>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypePopularity> value;
  };
        private FieldHoldingGeneratorPopularity fieldGeneratorPopularity;
        private JSONHoldingBooleanGenerator fieldGeneratorRequireContext;
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
            EntertainmentTitleUploadDataJSON result = new EntertainmentTitleUploadDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraEntertainmentTitleUploadDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(EntertainmentTitleUploadDataJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorSpokenTitle.have_value)
              {
                result.setSpokenTitle(fieldGeneratorSpokenTitle.value);
                fieldGeneratorSpokenTitle.have_value = false;
              }
            if (fieldGeneratorDisplayTitle.have_value)
              {
                result.setDisplayTitle(fieldGeneratorDisplayTitle.value);
                fieldGeneratorDisplayTitle.have_value = false;
              }
            if (fieldGeneratorAlternateTitles.have_value)
              {
                result.initAlternateTitles();
                int count = fieldGeneratorAlternateTitles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlternateTitles(fieldGeneratorAlternateTitles.value[num]);
                  }
                fieldGeneratorAlternateTitles.value.Clear();
                fieldGeneratorAlternateTitles.have_value = false;
              }
            if (fieldGeneratorTitleMatchExpression.have_value)
              {
                result.setTitleMatchExpression(fieldGeneratorTitleMatchExpression.value);
                fieldGeneratorTitleMatchExpression.have_value = false;
              }
            if (fieldGeneratorShowType.have_value)
              {
                result.setShowType(fieldGeneratorShowType.value);
                fieldGeneratorShowType.have_value = false;
              }
            if (fieldGeneratorReleaseYear.have_value)
              {
                result.setReleaseYear(fieldGeneratorReleaseYear.value);
                fieldGeneratorReleaseYear.have_value = false;
              }
            if (fieldGeneratorReleaseDate.have_value)
              {
                result.setReleaseDate(fieldGeneratorReleaseDate.value);
                fieldGeneratorReleaseDate.have_value = false;
              }
            if (fieldGeneratorPopularity.have_value)
              {
                result.setPopularity(fieldGeneratorPopularity.value);
                fieldGeneratorPopularity.have_value = false;
              }
            if (fieldGeneratorRequireContext.have_value)
              {
                result.setRequireContext(fieldGeneratorRequireContext.value);
                fieldGeneratorRequireContext.have_value = false;
              }
          }
        protected abstract void handle_result(EntertainmentTitleUploadDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "lternateTitles", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorAlternateTitles;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "isplayTitle", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorDisplayTitle;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "opularity", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPopularity;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'l':
                                if (String.Compare(field_name, 3, "ease", 0, 4, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 8, "ate", 0, 3, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorReleaseDate;
                                            break;
                                        case 'Y':
                                            if ((String.Compare(field_name, 8, "ear", 0, 3, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorReleaseYear;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'q':
                                if ((String.Compare(field_name, 3, "uireContext", 0, 11, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorRequireContext;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "owType", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorShowType;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenTitle", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSpokenTitle;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "itle", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorTitle;
                          }
                        switch (field_name[5])
                          {
                            case 'M':
                                if ((String.Compare(field_name, 6, "atchExpression", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorTitleMatchExpression;
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
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the EntertainmentTitleUploadData class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the EntertainmentTitleUploadData class");
            fieldGeneratorSpokenTitle = new JSONHoldingStringGenerator("field \"SpokenTitle\" of the EntertainmentTitleUploadData class");
            fieldGeneratorDisplayTitle = new JSONHoldingStringGenerator("field \"DisplayTitle\" of the EntertainmentTitleUploadData class");
            fieldGeneratorAlternateTitles = new JSONHoldingStringArrayGenerator("field \"AlternateTitles\" of the EntertainmentTitleUploadData class");
            fieldGeneratorTitleMatchExpression = new JSONHoldingStringGenerator("field \"TitleMatchExpression\" of the EntertainmentTitleUploadData class");
            fieldGeneratorShowType = new EntertainmentWorkTypeJSON.HoldingGenerator("field \"ShowType\" of the EntertainmentTitleUploadData class", ignore_extras);
            fieldGeneratorReleaseYear = new FieldHoldingGeneratorReleaseYear("field \"ReleaseYear\" of the EntertainmentTitleUploadData class");
            fieldGeneratorReleaseDate = new DateAndOrTimeJSON.HoldingGenerator("field \"ReleaseDate\" of the EntertainmentTitleUploadData class", ignore_extras);
            fieldGeneratorPopularity = new FieldHoldingGeneratorPopularity("field \"Popularity\" of the EntertainmentTitleUploadData class");
            fieldGeneratorRequireContext = new JSONHoldingBooleanGenerator("field \"RequireContext\" of the EntertainmentTitleUploadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the EntertainmentTitleUploadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the EntertainmentTitleUploadData class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the EntertainmentTitleUploadData class");
            fieldGeneratorSpokenTitle = new JSONHoldingStringGenerator("field \"SpokenTitle\" of the EntertainmentTitleUploadData class");
            fieldGeneratorDisplayTitle = new JSONHoldingStringGenerator("field \"DisplayTitle\" of the EntertainmentTitleUploadData class");
            fieldGeneratorAlternateTitles = new JSONHoldingStringArrayGenerator("field \"AlternateTitles\" of the EntertainmentTitleUploadData class");
            fieldGeneratorTitleMatchExpression = new JSONHoldingStringGenerator("field \"TitleMatchExpression\" of the EntertainmentTitleUploadData class");
            fieldGeneratorShowType = new EntertainmentWorkTypeJSON.HoldingGenerator("field \"ShowType\" of the EntertainmentTitleUploadData class", false);
            fieldGeneratorReleaseYear = new FieldHoldingGeneratorReleaseYear("field \"ReleaseYear\" of the EntertainmentTitleUploadData class");
            fieldGeneratorReleaseDate = new DateAndOrTimeJSON.HoldingGenerator("field \"ReleaseDate\" of the EntertainmentTitleUploadData class", false);
            fieldGeneratorPopularity = new FieldHoldingGeneratorPopularity("field \"Popularity\" of the EntertainmentTitleUploadData class");
            fieldGeneratorRequireContext = new JSONHoldingBooleanGenerator("field \"RequireContext\" of the EntertainmentTitleUploadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the EntertainmentTitleUploadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorID.reset();
            fieldGeneratorSpokenTitle.reset();
            fieldGeneratorDisplayTitle.reset();
            fieldGeneratorAlternateTitles.reset();
            fieldGeneratorTitleMatchExpression.reset();
            fieldGeneratorShowType.reset();
            fieldGeneratorReleaseYear.reset();
            fieldGeneratorReleaseDate.reset();
            fieldGeneratorPopularity.reset();
            fieldGeneratorRequireContext.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorShowType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReleaseDate.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorShowType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReleaseDate.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(EntertainmentTitleUploadDataJSON  result)
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
        public EntertainmentTitleUploadDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EntertainmentTitleUploadDataJSON  result)
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
    protected virtual void handle_result(List<EntertainmentTitleUploadDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EntertainmentTitleUploadDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EntertainmentTitleUploadDataJSON>();
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
    public List<EntertainmentTitleUploadDataJSON> value;
  };
  };
