/* file "MusicCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class MusicCommandJSON : CommandResultJSON
  {
    private bool flagHasAutoPlayPreviewResult;
    private DynamicResponseJSON  storeAutoPlayPreviewResult;
    private bool flagHasAutoPlayResult;
    private DynamicResponseJSON  storeAutoPlayResult;
    private bool flagHasAutoPlayFailedResult;
    private DynamicResponseJSON  storeAutoPlayFailedResult;
    private bool flagHasAutoPlayVideoResult;
    private DynamicResponseJSON  storeAutoPlayVideoResult;
    private bool flagHasShowVideoResult;
    private DynamicResponseJSON  storeShowVideoResult;
    private bool flagHasAutoPlayGenericResult;
    private DynamicResponseJSON  storeAutoPlayGenericResult;
    private bool flagHasNativeData;
    private MusicCommandNativeDataJSON  storeNativeData;


    private JSONValue  extraAutoPlayPreviewResultToJSON()
      {
        JSONValueHandler handler_AutoPlayPreviewResult = new JSONValueHandler();
        storeAutoPlayPreviewResult.write_as_json(handler_AutoPlayPreviewResult);
        return handler_AutoPlayPreviewResult.result;
      }

    private JSONValue  extraAutoPlayResultToJSON()
      {
        JSONValueHandler handler_AutoPlayResult = new JSONValueHandler();
        storeAutoPlayResult.write_as_json(handler_AutoPlayResult);
        return handler_AutoPlayResult.result;
      }

    private JSONValue  extraAutoPlayFailedResultToJSON()
      {
        JSONValueHandler handler_AutoPlayFailedResult = new JSONValueHandler();
        storeAutoPlayFailedResult.write_as_json(handler_AutoPlayFailedResult);
        return handler_AutoPlayFailedResult.result;
      }

    private JSONValue  extraAutoPlayVideoResultToJSON()
      {
        JSONValueHandler handler_AutoPlayVideoResult = new JSONValueHandler();
        storeAutoPlayVideoResult.write_as_json(handler_AutoPlayVideoResult);
        return handler_AutoPlayVideoResult.result;
      }

    private JSONValue  extraShowVideoResultToJSON()
      {
        JSONValueHandler handler_ShowVideoResult = new JSONValueHandler();
        storeShowVideoResult.write_as_json(handler_ShowVideoResult);
        return handler_ShowVideoResult.result;
      }

    private JSONValue  extraAutoPlayGenericResultToJSON()
      {
        JSONValueHandler handler_AutoPlayGenericResult = new JSONValueHandler();
        storeAutoPlayGenericResult.write_as_json(handler_AutoPlayGenericResult);
        return handler_AutoPlayGenericResult.result;
      }

    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONAutoPlayPreviewResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAutoPlayPreviewResult(convert_classy);
      }


    private void  fromJSONAutoPlayResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAutoPlayResult(convert_classy);
      }


    private void  fromJSONAutoPlayFailedResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAutoPlayFailedResult(convert_classy);
      }


    private void  fromJSONAutoPlayVideoResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAutoPlayVideoResult(convert_classy);
      }


    private void  fromJSONShowVideoResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setShowVideoResult(convert_classy);
      }


    private void  fromJSONAutoPlayGenericResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setAutoPlayGenericResult(convert_classy);
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicCommandNativeDataJSON convert_classy = MusicCommandNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public MusicCommandJSON()
      {
        flagHasAutoPlayPreviewResult = false;
        flagHasAutoPlayResult = false;
        flagHasAutoPlayFailedResult = false;
        flagHasAutoPlayVideoResult = false;
        flagHasShowVideoResult = false;
        flagHasAutoPlayGenericResult = false;
        flagHasNativeData = false;
      }

    public override string  getCommandKind()
      {
        return "MusicCommand";
      }

    public abstract string getMusicCommandKind();
    public bool  hasAutoPlayPreviewResult()
      {
        return flagHasAutoPlayPreviewResult;
      }

    public DynamicResponseJSON   getAutoPlayPreviewResult()
      {
        Debug.Assert(flagHasAutoPlayPreviewResult);
        return storeAutoPlayPreviewResult;
      }

    public bool  hasAutoPlayResult()
      {
        return flagHasAutoPlayResult;
      }

    public DynamicResponseJSON   getAutoPlayResult()
      {
        Debug.Assert(flagHasAutoPlayResult);
        return storeAutoPlayResult;
      }

    public bool  hasAutoPlayFailedResult()
      {
        return flagHasAutoPlayFailedResult;
      }

    public DynamicResponseJSON   getAutoPlayFailedResult()
      {
        Debug.Assert(flagHasAutoPlayFailedResult);
        return storeAutoPlayFailedResult;
      }

    public bool  hasAutoPlayVideoResult()
      {
        return flagHasAutoPlayVideoResult;
      }

    public DynamicResponseJSON   getAutoPlayVideoResult()
      {
        Debug.Assert(flagHasAutoPlayVideoResult);
        return storeAutoPlayVideoResult;
      }

    public bool  hasShowVideoResult()
      {
        return flagHasShowVideoResult;
      }

    public DynamicResponseJSON   getShowVideoResult()
      {
        Debug.Assert(flagHasShowVideoResult);
        return storeShowVideoResult;
      }

    public bool  hasAutoPlayGenericResult()
      {
        return flagHasAutoPlayGenericResult;
      }

    public DynamicResponseJSON   getAutoPlayGenericResult()
      {
        Debug.Assert(flagHasAutoPlayGenericResult);
        return storeAutoPlayGenericResult;
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public MusicCommandNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public abstract int extraMusicCommandComponentCount();
    public abstract string extraMusicCommandComponentKey(int component_num);
    public abstract JSONValue extraMusicCommandComponentValue(int component_num);
    public abstract JSONValue extraMusicCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        if (flagHasAutoPlayPreviewResult)
            ++result;
        if (flagHasAutoPlayResult)
            ++result;
        if (flagHasAutoPlayFailedResult)
            ++result;
        if (flagHasAutoPlayVideoResult)
            ++result;
        if (flagHasShowVideoResult)
            ++result;
        if (flagHasAutoPlayGenericResult)
            ++result;
        if (flagHasNativeData)
            ++result;
        result += extraMusicCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "MusicCommandKind";
        int remainder = (component_num - 1);
        if (flagHasAutoPlayPreviewResult)
          {
            if (remainder == 0)
                return "AutoPlayPreviewResult";
            --remainder;
          }
        if (flagHasAutoPlayResult)
          {
            if (remainder == 0)
                return "AutoPlayResult";
            --remainder;
          }
        if (flagHasAutoPlayFailedResult)
          {
            if (remainder == 0)
                return "AutoPlayFailedResult";
            --remainder;
          }
        if (flagHasAutoPlayVideoResult)
          {
            if (remainder == 0)
                return "AutoPlayVideoResult";
            --remainder;
          }
        if (flagHasShowVideoResult)
          {
            if (remainder == 0)
                return "ShowVideoResult";
            --remainder;
          }
        if (flagHasAutoPlayGenericResult)
          {
            if (remainder == 0)
                return "AutoPlayGenericResult";
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraMusicCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getMusicCommandKind());
        int remainder = (component_num - 1);
        if (flagHasAutoPlayPreviewResult)
          {
            if (remainder == 0)
                return extraAutoPlayPreviewResultToJSON();
            --remainder;
          }
        if (flagHasAutoPlayResult)
          {
            if (remainder == 0)
                return extraAutoPlayResultToJSON();
            --remainder;
          }
        if (flagHasAutoPlayFailedResult)
          {
            if (remainder == 0)
                return extraAutoPlayFailedResultToJSON();
            --remainder;
          }
        if (flagHasAutoPlayVideoResult)
          {
            if (remainder == 0)
                return extraAutoPlayVideoResultToJSON();
            --remainder;
          }
        if (flagHasShowVideoResult)
          {
            if (remainder == 0)
                return extraShowVideoResultToJSON();
            --remainder;
          }
        if (flagHasAutoPlayGenericResult)
          {
            if (remainder == 0)
                return extraAutoPlayGenericResultToJSON();
            --remainder;
          }
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraMusicCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if (String.Compare(field_name, 1, "utoPlay", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'F':
                            if ((String.Compare(field_name, 9, "ailedResult", 0, 11, false) == 0) && (field_name.Length == 20))
                                return (flagHasAutoPlayFailedResult ? extraAutoPlayFailedResultToJSON() : null);
                            break;
                        case 'G':
                            if ((String.Compare(field_name, 9, "enericResult", 0, 12, false) == 0) && (field_name.Length == 21))
                                return (flagHasAutoPlayGenericResult ? extraAutoPlayGenericResultToJSON() : null);
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 9, "reviewResult", 0, 12, false) == 0) && (field_name.Length == 21))
                                return (flagHasAutoPlayPreviewResult ? extraAutoPlayPreviewResultToJSON() : null);
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 9, "esult", 0, 5, false) == 0) && (field_name.Length == 14))
                                return (flagHasAutoPlayResult ? extraAutoPlayResultToJSON() : null);
                            break;
                        case 'V':
                            if ((String.Compare(field_name, 9, "ideoResult", 0, 10, false) == 0) && (field_name.Length == 19))
                                return (flagHasAutoPlayVideoResult ? extraAutoPlayVideoResultToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "usicCommandKind", 0, 15, false) == 0) && (field_name.Length == 16))
                    return new JSONStringValue(getMusicCommandKind());
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "howVideoResult", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasShowVideoResult ? extraShowVideoResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraMusicCommandLookup(field_name);
      }

    public void setAutoPlayPreviewResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAutoPlayPreviewResult)
          {
          }
        flagHasAutoPlayPreviewResult = true;
        storeAutoPlayPreviewResult = new_value;
      }
    public void unsetAutoPlayPreviewResult()
      {
        if (flagHasAutoPlayPreviewResult)
          {
          }
        flagHasAutoPlayPreviewResult = false;
      }
    public void setAutoPlayResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAutoPlayResult)
          {
          }
        flagHasAutoPlayResult = true;
        storeAutoPlayResult = new_value;
      }
    public void unsetAutoPlayResult()
      {
        if (flagHasAutoPlayResult)
          {
          }
        flagHasAutoPlayResult = false;
      }
    public void setAutoPlayFailedResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAutoPlayFailedResult)
          {
          }
        flagHasAutoPlayFailedResult = true;
        storeAutoPlayFailedResult = new_value;
      }
    public void unsetAutoPlayFailedResult()
      {
        if (flagHasAutoPlayFailedResult)
          {
          }
        flagHasAutoPlayFailedResult = false;
      }
    public void setAutoPlayVideoResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAutoPlayVideoResult)
          {
          }
        flagHasAutoPlayVideoResult = true;
        storeAutoPlayVideoResult = new_value;
      }
    public void unsetAutoPlayVideoResult()
      {
        if (flagHasAutoPlayVideoResult)
          {
          }
        flagHasAutoPlayVideoResult = false;
      }
    public void setShowVideoResult(DynamicResponseJSON  new_value)
      {
        if (flagHasShowVideoResult)
          {
          }
        flagHasShowVideoResult = true;
        storeShowVideoResult = new_value;
      }
    public void unsetShowVideoResult()
      {
        if (flagHasShowVideoResult)
          {
          }
        flagHasShowVideoResult = false;
      }
    public void setAutoPlayGenericResult(DynamicResponseJSON  new_value)
      {
        if (flagHasAutoPlayGenericResult)
          {
          }
        flagHasAutoPlayGenericResult = true;
        storeAutoPlayGenericResult = new_value;
      }
    public void unsetAutoPlayGenericResult()
      {
        if (flagHasAutoPlayGenericResult)
          {
          }
        flagHasAutoPlayGenericResult = false;
      }
    public void setNativeData(MusicCommandNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public virtual void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public abstract void extraMusicCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraMusicCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "utoPlay", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'F':
                            if ((String.Compare(key, 9, "ailedResult", 0, 11, false) == 0) && (key.Length == 20))
                                {
                                fromJSONAutoPlayFailedResult(new_component, false);
                                return;
                                }
                            break;
                        case 'G':
                            if ((String.Compare(key, 9, "enericResult", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONAutoPlayGenericResult(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 9, "reviewResult", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONAutoPlayPreviewResult(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 9, "esult", 0, 5, false) == 0) && (key.Length == 14))
                                {
                                fromJSONAutoPlayResult(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 9, "ideoResult", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONAutoPlayVideoResult(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "usicCommandKind", 0, 15, false) == 0) && (key.Length == 16))
                    return;
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "howVideoResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONShowVideoResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "utoPlay", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'F':
                            if ((String.Compare(key, 9, "ailedResult", 0, 11, false) == 0) && (key.Length == 20))
                                {
                                fromJSONAutoPlayFailedResult(new_component, false);
                                return;
                                }
                            break;
                        case 'G':
                            if ((String.Compare(key, 9, "enericResult", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONAutoPlayGenericResult(new_component, false);
                                return;
                                }
                            break;
                        case 'P':
                            if ((String.Compare(key, 9, "reviewResult", 0, 12, false) == 0) && (key.Length == 21))
                                {
                                fromJSONAutoPlayPreviewResult(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 9, "esult", 0, 5, false) == 0) && (key.Length == 14))
                                {
                                fromJSONAutoPlayResult(new_component, false);
                                return;
                                }
                            break;
                        case 'V':
                            if ((String.Compare(key, 9, "ideoResult", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONAutoPlayVideoResult(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "usicCommandKind", 0, 15, false) == 0) && (key.Length == 16))
                    return;
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "howVideoResult", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONShowVideoResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMusicCommandSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("MusicCommandKind", getMusicCommandKind());
        if (flagHasAutoPlayPreviewResult)
          {
            handler.start_pair("AutoPlayPreviewResult");
            if (partial_allowed)
                storeAutoPlayPreviewResult.write_partial_as_json(handler);
            else
                storeAutoPlayPreviewResult.write_as_json(handler);
          }
        if (flagHasAutoPlayResult)
          {
            handler.start_pair("AutoPlayResult");
            if (partial_allowed)
                storeAutoPlayResult.write_partial_as_json(handler);
            else
                storeAutoPlayResult.write_as_json(handler);
          }
        if (flagHasAutoPlayFailedResult)
          {
            handler.start_pair("AutoPlayFailedResult");
            if (partial_allowed)
                storeAutoPlayFailedResult.write_partial_as_json(handler);
            else
                storeAutoPlayFailedResult.write_as_json(handler);
          }
        if (flagHasAutoPlayVideoResult)
          {
            handler.start_pair("AutoPlayVideoResult");
            if (partial_allowed)
                storeAutoPlayVideoResult.write_partial_as_json(handler);
            else
                storeAutoPlayVideoResult.write_as_json(handler);
          }
        if (flagHasShowVideoResult)
          {
            handler.start_pair("ShowVideoResult");
            if (partial_allowed)
                storeShowVideoResult.write_partial_as_json(handler);
            else
                storeShowVideoResult.write_as_json(handler);
          }
        if (flagHasAutoPlayGenericResult)
          {
            handler.start_pair("AutoPlayGenericResult");
            if (partial_allowed)
                storeAutoPlayGenericResult.write_partial_as_json(handler);
            else
                storeAutoPlayGenericResult.write_as_json(handler);
          }
        writeFieldNativeData(handler);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual void writeFieldNativeData(JSONHandler handler)
      {
        Debug.Assert(flagHasNativeData);
        handler.start_pair("NativeData");
        storeNativeData.write_as_json(handler);
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new MusicCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommand", ignore_extras);
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
    public static new MusicCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommand", ignore_extras);
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
    public static new MusicCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicCommandJSON from_text(string text, bool ignore_extras)
      {
        MusicCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAutoPlayPreviewResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAutoPlayResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAutoPlayFailedResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAutoPlayVideoResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorShowVideoResult;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorAutoPlayGenericResult;
        private MusicCommandNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("MusicCommand")))
                throw new Exception("The key field has a value other than `MusicCommand'.");
            MusicCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getMusicCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `MusicCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((MusicCommandJSON )new_result);
          }
        protected void finish(MusicCommandJSON result)
          {
            if (fieldGeneratorAutoPlayPreviewResult.have_value)
              {
                result.setAutoPlayPreviewResult(fieldGeneratorAutoPlayPreviewResult.value);
                fieldGeneratorAutoPlayPreviewResult.have_value = false;
              }
            if (fieldGeneratorAutoPlayResult.have_value)
              {
                result.setAutoPlayResult(fieldGeneratorAutoPlayResult.value);
                fieldGeneratorAutoPlayResult.have_value = false;
              }
            if (fieldGeneratorAutoPlayFailedResult.have_value)
              {
                result.setAutoPlayFailedResult(fieldGeneratorAutoPlayFailedResult.value);
                fieldGeneratorAutoPlayFailedResult.have_value = false;
              }
            if (fieldGeneratorAutoPlayVideoResult.have_value)
              {
                result.setAutoPlayVideoResult(fieldGeneratorAutoPlayVideoResult.value);
                fieldGeneratorAutoPlayVideoResult.have_value = false;
              }
            if (fieldGeneratorShowVideoResult.have_value)
              {
                result.setShowVideoResult(fieldGeneratorShowVideoResult.value);
                fieldGeneratorShowVideoResult.have_value = false;
              }
            if (fieldGeneratorAutoPlayGenericResult.have_value)
              {
                result.setAutoPlayGenericResult(fieldGeneratorAutoPlayGenericResult.value);
                fieldGeneratorAutoPlayGenericResult.have_value = false;
              }
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "utoPlay", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 9, "ailedResult", 0, 11, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorAutoPlayFailedResult;
                                break;
                            case 'G':
                                if ((String.Compare(field_name, 9, "enericResult", 0, 12, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorAutoPlayGenericResult;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 9, "reviewResult", 0, 12, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorAutoPlayPreviewResult;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 9, "esult", 0, 5, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorAutoPlayResult;
                                break;
                            case 'V':
                                if ((String.Compare(field_name, 9, "ideoResult", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorAutoPlayVideoResult;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicCommandKind", 0, 15, false) == 0) && (field_name.Length == 16))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "howVideoResult", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorShowVideoResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAutoPlayPreviewResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayPreviewResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorAutoPlayResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorAutoPlayFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayFailedResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorAutoPlayVideoResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayVideoResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorShowVideoResult = new DynamicResponseJSON.HoldingGenerator("field \"ShowVideoResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorAutoPlayGenericResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayGenericResult\" of the MusicCommand class", ignore_extras);
            fieldGeneratorNativeData = new MusicCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MusicCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicCommandKind\" of the MusicCommand class");
            set_what("the MusicCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAutoPlayPreviewResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayPreviewResult\" of the MusicCommand class", false);
            fieldGeneratorAutoPlayResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayResult\" of the MusicCommand class", false);
            fieldGeneratorAutoPlayFailedResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayFailedResult\" of the MusicCommand class", false);
            fieldGeneratorAutoPlayVideoResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayVideoResult\" of the MusicCommand class", false);
            fieldGeneratorShowVideoResult = new DynamicResponseJSON.HoldingGenerator("field \"ShowVideoResult\" of the MusicCommand class", false);
            fieldGeneratorAutoPlayGenericResult = new DynamicResponseJSON.HoldingGenerator("field \"AutoPlayGenericResult\" of the MusicCommand class", false);
            fieldGeneratorNativeData = new MusicCommandNativeDataJSON.HoldingGenerator("field \"NativeData\" of the MusicCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"MusicCommandKind\" of the MusicCommand class");
            set_what("the MusicCommand class");
          }

        public override void reset()
          {
            fieldGeneratorAutoPlayPreviewResult.reset();
            fieldGeneratorAutoPlayResult.reset();
            fieldGeneratorAutoPlayFailedResult.reset();
            fieldGeneratorAutoPlayVideoResult.reset();
            fieldGeneratorShowVideoResult.reset();
            fieldGeneratorAutoPlayGenericResult.reset();
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicCommandJSON  result)
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
        public MusicCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicCommandJSON  result)
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
    protected virtual void handle_result(List<MusicCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicCommandJSON>();
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
    public List<MusicCommandJSON> value;
  };
    class GenericMusicCommandJSON : MusicCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericMusicCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getMusicCommandKind()  { return key; }
        public override int extraMusicCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraMusicCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraMusicCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraMusicCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraMusicCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraMusicCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraMusicCommandLookup(key);
            if (old_field == null)
              {
                extraMusicCommandAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new MusicCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'G':
            if ((String.Compare(key, 1, "uessThatLyricCommand", 0, 20, false) == 0) && (key.Length == 21))
              {
                JSONValue key_value = ((other_field_index == null) ? null : (other_field_index.ContainsKey("GuessThatLyricCommandKind") ? other_field_index["GuessThatLyricCommandKind"] : null));
                if (key_value == null)
                    throw new Exception("The `GuessThatLyricCommandKind' field is missing.");
                JSONStringValue key_string_value = key_value.string_value();
                if (key_string_value == null)
                    throw new Exception("The `GuessThatLyricCommandKind' field has a non-string value.");
                return GuessThatLyricCommandJSON.createForKey(key_string_value.getData(), other_field_index);
              }
            break;
        case 'M':
            if (String.Compare(key, 1, "usic", 0, 4, false) == 0)
              {
                switch (key[5])
                  {
                    case 'C':
                        if ((String.Compare(key, 6, "hartsCommand", 0, 12, false) == 0) && (key.Length == 18))
                            return new MusicChartsCommandJSON();
                        break;
                    case 'S':
                        if ((String.Compare(key, 6, "earchCommand", 0, 12, false) == 0) && (key.Length == 18))
                            return new MusicSearchCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        default:
            break;
      }

        return new GenericMusicCommandJSON(key);
      }
  };
