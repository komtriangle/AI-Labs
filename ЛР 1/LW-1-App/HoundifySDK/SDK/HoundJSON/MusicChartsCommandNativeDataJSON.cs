/* file "MusicChartsCommandNativeDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicChartsCommandNativeDataJSON : MusicCommandNativeDataJSON
  {
    private bool flagHasSearchCriteria;
    private MusicChartsSearchCriteriaJSON  storeSearchCriteria;
    private bool flagHasSearchCriteriaAdditional;
    private MusicChartsSearchCriteriaAdditionalJSON  storeSearchCriteriaAdditional;
    private bool flagHasChartTitle;
    private string storeChartTitle;
    private bool flagHasVideos;
    private List< MusicVideoJSON  > storeVideos;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSearchCriteriaToJSON()
      {
        JSONValueHandler handler_SearchCriteria = new JSONValueHandler();
        storeSearchCriteria.write_as_json(handler_SearchCriteria);
        return handler_SearchCriteria.result;
      }

    private JSONValue  extraSearchCriteriaAdditionalToJSON()
      {
        JSONValueHandler handler_SearchCriteriaAdditional = new JSONValueHandler();
        storeSearchCriteriaAdditional.write_as_json(handler_SearchCriteriaAdditional);
        return handler_SearchCriteriaAdditional.result;
      }

    private JSONValue  extraChartTitleToJSON()
      {
        JSONStringValue generated_string_ChartTitle = new JSONStringValue(storeChartTitle);
        return generated_string_ChartTitle;
      }

    private JSONValue  extraVideosToJSON()
      {
        JSONArrayValue generated_array_1_Videos = new JSONArrayValue();
        for (int num1 = 0; num1 < storeVideos.Count; ++num1)
          {
            JSONValueHandler handler_Videos = new JSONValueHandler();
            storeVideos[num1].write_as_json(handler_Videos);
            generated_array_1_Videos.appendComponent(handler_Videos.result);
          }
        return generated_array_1_Videos;
      }


    private void  fromJSONSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicChartsSearchCriteriaJSON convert_classy = MusicChartsSearchCriteriaJSON.from_json(json_value, ignore_extras, true);
        setSearchCriteria(convert_classy);
      }


    private void  fromJSONSearchCriteriaAdditional(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicChartsSearchCriteriaAdditionalJSON convert_classy = MusicChartsSearchCriteriaAdditionalJSON.from_json(json_value, ignore_extras, true);
        setSearchCriteriaAdditional(convert_classy);
      }


    private void  fromJSONChartTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ChartTitle of MusicChartsCommandNativeDataJSON is not a string.");
        setChartTitle(json_string.getData());
      }


    private void  fromJSONVideos(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Videos of MusicChartsCommandNativeDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MusicVideoJSON  > vector_Videos1 = new List< MusicVideoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicVideoJSON convert_classy = MusicVideoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Videos1.Add(convert_classy);
          }
        initVideos();
        for (int num1 = 0; num1 < vector_Videos1.Count; ++num1)
            appendVideos(vector_Videos1[num1]);
        for (int num1 = 0; num1 < vector_Videos1.Count; ++num1)
          {
          }
      }


    public MusicChartsCommandNativeDataJSON()
      {
        flagHasSearchCriteria = false;
        flagHasSearchCriteriaAdditional = false;
        flagHasChartTitle = false;
        flagHasVideos = false;
        storeVideos = new List< MusicVideoJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMusicCommandNativeDataKind()
      {
        return "MusicChartsCommandNativeData";
      }

    public bool  hasSearchCriteria()
      {
        return flagHasSearchCriteria;
      }

    public MusicChartsSearchCriteriaJSON   getSearchCriteria()
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria;
      }

    public bool  hasSearchCriteriaAdditional()
      {
        return flagHasSearchCriteriaAdditional;
      }

    public MusicChartsSearchCriteriaAdditionalJSON   getSearchCriteriaAdditional()
      {
        Debug.Assert(flagHasSearchCriteriaAdditional);
        return storeSearchCriteriaAdditional;
      }

    public bool  hasChartTitle()
      {
        return flagHasChartTitle;
      }

    public string  getChartTitle()
      {
        Debug.Assert(flagHasChartTitle);
        return storeChartTitle;
      }

    public bool  hasVideos()
      {
        return flagHasVideos;
      }

    public int  countOfVideos()
      {
        Debug.Assert(flagHasVideos);
        return storeVideos.Count;
      }

    public MusicVideoJSON   elementOfVideos(int element_num)
      {
        Debug.Assert(flagHasVideos);
        return storeVideos[element_num];
      }

    public List< MusicVideoJSON  >  getVideos()
      {
        Debug.Assert(flagHasVideos);
        return storeVideos;
      }


    public virtual int extraMusicChartsCommandNativeDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicChartsCommandNativeDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicChartsCommandNativeDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicChartsCommandNativeDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMusicCommandNativeDataComponentCount()
      {
        int result = 0;
        if (flagHasSearchCriteria)
            ++result;
        if (flagHasSearchCriteriaAdditional)
            ++result;
        if (flagHasChartTitle)
            ++result;
        if (flagHasVideos)
            ++result;
        result += extraMusicChartsCommandNativeDataComponentCount();
        return result;
      }
    public override string extraMusicCommandNativeDataComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSearchCriteria)
          {
            if (remainder == 0)
                return "SearchCriteria";
            --remainder;
          }
        if (flagHasSearchCriteriaAdditional)
          {
            if (remainder == 0)
                return "SearchCriteriaAdditional";
            --remainder;
          }
        if (flagHasChartTitle)
          {
            if (remainder == 0)
                return "ChartTitle";
            --remainder;
          }
        if (flagHasVideos)
          {
            if (remainder == 0)
                return "Videos";
            --remainder;
          }
        return extraMusicChartsCommandNativeDataComponentKey(remainder);
      }
    public override JSONValue extraMusicCommandNativeDataComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSearchCriteria)
          {
            if (remainder == 0)
                return extraSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasSearchCriteriaAdditional)
          {
            if (remainder == 0)
                return extraSearchCriteriaAdditionalToJSON();
            --remainder;
          }
        if (flagHasChartTitle)
          {
            if (remainder == 0)
                return extraChartTitleToJSON();
            --remainder;
          }
        if (flagHasVideos)
          {
            if (remainder == 0)
                return extraVideosToJSON();
            --remainder;
          }
        return extraMusicChartsCommandNativeDataComponentValue(remainder);
      }
    public override JSONValue extraMusicCommandNativeDataLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "hartTitle", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasChartTitle ? extraChartTitleToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "earchCriteria", 0, 13, false) == 0)
                  {
                    if (field_name.Length == 14)
                      {
                        return (flagHasSearchCriteria ? extraSearchCriteriaToJSON() : null);
                      }
                    switch (field_name[14])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 15, "dditional", 0, 9, false) == 0) && (field_name.Length == 24))
                                return (flagHasSearchCriteriaAdditional ? extraSearchCriteriaAdditionalToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "ideos", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasVideos ? extraVideosToJSON() : null);
                break;
            default:
                break;
          }
        return extraMusicChartsCommandNativeDataLookup(field_name);
      }

    public void setSearchCriteria(MusicChartsSearchCriteriaJSON  new_value)
      {
        if (flagHasSearchCriteria)
          {
          }
        flagHasSearchCriteria = true;
        storeSearchCriteria = new_value;
      }
    public void unsetSearchCriteria()
      {
        if (flagHasSearchCriteria)
          {
          }
        flagHasSearchCriteria = false;
      }
    public void setSearchCriteriaAdditional(MusicChartsSearchCriteriaAdditionalJSON  new_value)
      {
        if (flagHasSearchCriteriaAdditional)
          {
          }
        flagHasSearchCriteriaAdditional = true;
        storeSearchCriteriaAdditional = new_value;
      }
    public void unsetSearchCriteriaAdditional()
      {
        if (flagHasSearchCriteriaAdditional)
          {
          }
        flagHasSearchCriteriaAdditional = false;
      }
    public void setChartTitle(string new_value)
      {
        flagHasChartTitle = true;
        storeChartTitle = new_value;
      }
    public void unsetChartTitle()
      {
        flagHasChartTitle = false;
      }
    public void initVideos()
      {
        if (flagHasVideos)
          {
            for (int num1 = 0; num1 < storeVideos.Count; ++num1)
              {
              }
          }
        flagHasVideos = true;
        storeVideos.Clear();
      }
    public void appendVideos(MusicVideoJSON  to_append)
      {
        if (!flagHasVideos)
          {
            flagHasVideos = true;
            storeVideos.Clear();
          }
        Debug.Assert(flagHasVideos);
        storeVideos.Add(to_append);
      }
    public void unsetVideos()
      {
        if (flagHasVideos)
          {
            for (int num2 = 0; num2 < storeVideos.Count; ++num2)
              {
              }
          }
        flagHasVideos = false;
        storeVideos.Clear();
      }

    public virtual void extraMusicChartsCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicChartsCommandNativeDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicChartsCommandNativeDataLookup(key);
        if (old_field == null)
          {
            extraMusicChartsCommandNativeDataAppendPair(key, new_component);
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
    public override void extraMusicCommandNativeDataAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hartTitle", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONChartTitle(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "earchCriteria", 0, 13, false) == 0)
                  {
                    if (key.Length == 14)
                      {
                        {
                        fromJSONSearchCriteria(new_component, false);
                        return;
                        }
                      }
                    switch (key[14])
                      {
                        case 'A':
                            if ((String.Compare(key, 15, "dditional", 0, 9, false) == 0) && (key.Length == 24))
                                {
                                fromJSONSearchCriteriaAdditional(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ideos", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONVideos(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicChartsCommandNativeDataAppendPair(key, new_component);
      }
    public override void extraMusicCommandNativeDataSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "hartTitle", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONChartTitle(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "earchCriteria", 0, 13, false) == 0)
                  {
                    if (key.Length == 14)
                      {
                        {
                        fromJSONSearchCriteria(new_component, false);
                        return;
                        }
                      }
                    switch (key[14])
                      {
                        case 'A':
                            if ((String.Compare(key, 15, "dditional", 0, 9, false) == 0) && (key.Length == 24))
                                {
                                fromJSONSearchCriteriaAdditional(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ideos", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONVideos(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicChartsCommandNativeDataSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSearchCriteria);
        if (flagHasSearchCriteria)
          {
            handler.start_pair("SearchCriteria");
            if (partial_allowed)
                storeSearchCriteria.write_partial_as_json(handler);
            else
                storeSearchCriteria.write_as_json(handler);
          }
        if (flagHasSearchCriteriaAdditional)
          {
            handler.start_pair("SearchCriteriaAdditional");
            if (partial_allowed)
                storeSearchCriteriaAdditional.write_partial_as_json(handler);
            else
                storeSearchCriteriaAdditional.write_as_json(handler);
          }
        if (flagHasChartTitle)
          {
            handler.start_pair("ChartTitle");
            handler.string_value(storeChartTitle);
          }
        if (flagHasVideos)
          {
            handler.start_pair("Videos");
            handler.start_array();
            for (int num1 = 0; num1 < storeVideos.Count; ++num1)
              {
                if (partial_allowed)
                    storeVideos[num1].write_partial_as_json(handler);
                else
                    storeVideos[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasSearchCriteria()))
          {
            return "When parsing the object for %what%, the \"SearchCriteria\" field was missing.";
          }
        return null;
      }

    public static new MusicChartsCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandNativeData", ignore_extras);
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
    public static new MusicChartsCommandNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicChartsCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicChartsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandNativeData", ignore_extras);
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
    public static new MusicChartsCommandNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicChartsCommandNativeDataJSON from_text(string text, bool ignore_extras)
      {
        MusicChartsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicChartsCommandNativeDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicChartsCommandNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicChartsCommandNativeDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicChartsCommandNativeData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicCommandNativeDataJSON.Generator
      {
        private MusicChartsSearchCriteriaJSON.HoldingGenerator fieldGeneratorSearchCriteria;
        private MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator fieldGeneratorSearchCriteriaAdditional;
        private JSONHoldingStringGenerator fieldGeneratorChartTitle;
        private MusicVideoJSON.HoldingArrayGenerator fieldGeneratorVideos;
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
            if (!(getMusicCommandNativeDataJSONKey().Equals("MusicChartsCommandNativeData")))
                throw new Exception("The key field has a value other than `MusicChartsCommandNativeData'.");
            MusicChartsCommandNativeDataJSON result = new MusicChartsCommandNativeDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicChartsCommandNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MusicCommandNativeDataJSON new_result)
          {
            handle_result((MusicChartsCommandNativeDataJSON )new_result);
          }
        protected void finish(MusicChartsCommandNativeDataJSON result)
          {
            if (fieldGeneratorSearchCriteria.have_value)
              {
                result.setSearchCriteria(fieldGeneratorSearchCriteria.value);
                fieldGeneratorSearchCriteria.have_value = false;
              }
            else if ((!(result.hasSearchCriteria())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SearchCriteria\" field was missing.");
              }
            if (fieldGeneratorSearchCriteriaAdditional.have_value)
              {
                result.setSearchCriteriaAdditional(fieldGeneratorSearchCriteriaAdditional.value);
                fieldGeneratorSearchCriteriaAdditional.have_value = false;
              }
            if (fieldGeneratorChartTitle.have_value)
              {
                result.setChartTitle(fieldGeneratorChartTitle.value);
                fieldGeneratorChartTitle.have_value = false;
              }
            if (fieldGeneratorVideos.have_value)
              {
                result.initVideos();
                int count = fieldGeneratorVideos.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendVideos(fieldGeneratorVideos.value[num]);
                  }
                fieldGeneratorVideos.value.Clear();
                fieldGeneratorVideos.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicChartsCommandNativeDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hartTitle", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorChartTitle;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "earchCriteria", 0, 13, false) == 0)
                      {
                        if (field_name.Length == 14)
                          {
                            return fieldGeneratorSearchCriteria;
                          }
                        switch (field_name[14])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 15, "dditional", 0, 9, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorSearchCriteriaAdditional;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ideos", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorVideos;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSearchCriteria = new MusicChartsSearchCriteriaJSON.HoldingGenerator("field \"SearchCriteria\" of the MusicChartsCommandNativeData class", ignore_extras);
            fieldGeneratorSearchCriteriaAdditional = new MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator("field \"SearchCriteriaAdditional\" of the MusicChartsCommandNativeData class", ignore_extras);
            fieldGeneratorChartTitle = new JSONHoldingStringGenerator("field \"ChartTitle\" of the MusicChartsCommandNativeData class");
            fieldGeneratorVideos = new MusicVideoJSON.HoldingArrayGenerator("field \"Videos\" of the MusicChartsCommandNativeData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicChartsCommandNativeData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSearchCriteria = new MusicChartsSearchCriteriaJSON.HoldingGenerator("field \"SearchCriteria\" of the MusicChartsCommandNativeData class", false);
            fieldGeneratorSearchCriteriaAdditional = new MusicChartsSearchCriteriaAdditionalJSON.HoldingGenerator("field \"SearchCriteriaAdditional\" of the MusicChartsCommandNativeData class", false);
            fieldGeneratorChartTitle = new JSONHoldingStringGenerator("field \"ChartTitle\" of the MusicChartsCommandNativeData class");
            fieldGeneratorVideos = new MusicVideoJSON.HoldingArrayGenerator("field \"Videos\" of the MusicChartsCommandNativeData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicChartsCommandNativeData class");
          }

        public override void reset()
          {
            fieldGeneratorSearchCriteria.reset();
            fieldGeneratorSearchCriteriaAdditional.reset();
            fieldGeneratorChartTitle.reset();
            fieldGeneratorVideos.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicChartsCommandNativeDataJSON  result)
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
        public MusicChartsCommandNativeDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicChartsCommandNativeDataJSON  result)
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
    protected virtual void handle_result(List<MusicChartsCommandNativeDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicChartsCommandNativeDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicChartsCommandNativeDataJSON>();
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
    public List<MusicChartsCommandNativeDataJSON> value;
  };
  };
