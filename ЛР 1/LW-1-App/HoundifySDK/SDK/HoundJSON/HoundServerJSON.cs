/* file "HoundServerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HoundServerJSON : JSONBase
  {
    public enum TypeFormat
      {
        Format_SoundHoundVoiceSearchResult,
        Format_HoundQueryResult
      };

    public static TypeFormat  stringToFormat(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "oundQueryResult", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeFormat.Format_HoundQueryResult;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "oundHoundVoiceSearchResult", 0, 26, false) == 0) && (chars.Length == 27))
                    return TypeFormat.Format_SoundHoundVoiceSearchResult;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Format' is not one of the legal values.");
      }

    public static string  stringFromFormat(TypeFormat the_enum)
      {
        switch (the_enum)
          {
            case TypeFormat.Format_SoundHoundVoiceSearchResult:
                return "SoundHoundVoiceSearchResult";
            case TypeFormat.Format_HoundQueryResult:
                return "HoundQueryResult";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeFormatVersion
      {
        FormatVersion_1_x2e_0
      };

    public static TypeFormatVersion  stringToFormatVersion(string chars)
      {
        if ((String.Compare(chars, 0, "1.0", 0, 3, false) == 0) && (chars.Length == 3))
            return TypeFormatVersion.FormatVersion_1_x2e_0;
        throw new Exception("The value for field `FormatVersion' is not one of the legal values.");
      }

    public static string  stringFromFormatVersion(TypeFormatVersion the_enum)
      {
        switch (the_enum)
          {
            case TypeFormatVersion.FormatVersion_1_x2e_0:
                return "1.0";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeStatus
      {
        Status_OK,
        Status_Error
      };

    public static TypeStatus  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "rror", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeStatus.Status_Error;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "K", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeStatus.Status_OK;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Status' is not one of the legal values.");
      }

    public static string  stringFromStatus(TypeStatus the_enum)
      {
        switch (the_enum)
          {
            case TypeStatus.Status_OK:
                return "OK";
            case TypeStatus.Status_Error:
                return "Error";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeDisambiguationJSON : JSONBase
      {
        public class TypeChoiceDataJSON : JSONBase
          {
            private bool flagHasTranscription;
            private string storeTranscription;
            private bool flagHasConfidenceScore;
            private double storeConfidenceScore;
            private string textStoreConfidenceScore;
            private bool flagHasASRConfidence;
            private double storeASRConfidence;
            private string textStoreASRConfidence;
            private bool flagHasFormattedTranscription;
            private string storeFormattedTranscription;
            private bool flagHasFixedTranscription;
            private string storeFixedTranscription;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONTranscription(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Transcription of TypeChoiceDataJSON is not a string.");
                setTranscription(json_string.getData());
              }


            private void  fromJSONConfidenceScore(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONRationalValue json_rational = json_value.rational_value();
                string the_rational_text;
                if (json_rational != null)
                  {
                    the_rational_text = json_rational.getText();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_rational_text = json_integer.getText();
                      }
                    else
                      {
                        throw new Exception("The value for field ConfidenceScore of TypeChoiceDataJSON is not a number.");
                      }
                  }
                setConfidenceScoreText(the_rational_text);
              }


            private void  fromJSONASRConfidence(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONRationalValue json_rational = json_value.rational_value();
                string the_rational_text;
                if (json_rational != null)
                  {
                    the_rational_text = json_rational.getText();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_rational_text = json_integer.getText();
                      }
                    else
                      {
                        throw new Exception("The value for field ASRConfidence of TypeChoiceDataJSON is not a number.");
                      }
                  }
                setASRConfidenceText(the_rational_text);
              }


            private void  fromJSONFormattedTranscription(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field FormattedTranscription of TypeChoiceDataJSON is not a string.");
                setFormattedTranscription(json_string.getData());
              }


            private void  fromJSONFixedTranscription(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field FixedTranscription of TypeChoiceDataJSON is not a string.");
                setFixedTranscription(json_string.getData());
              }


            public TypeChoiceDataJSON()
              {
                flagHasTranscription = false;
                flagHasConfidenceScore = false;
                flagHasASRConfidence = false;
                flagHasFormattedTranscription = false;
                flagHasFixedTranscription = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasTranscription()
              {
                return flagHasTranscription;
              }

            public string  getTranscription()
              {
                Debug.Assert(flagHasTranscription);
                return storeTranscription;
              }

            public bool  hasConfidenceScore()
              {
                return flagHasConfidenceScore;
              }

            public double  getConfidenceScore()
              {
                Debug.Assert(flagHasConfidenceScore);
                if (textStoreConfidenceScore != "")
                  {
                    return Double.Parse(textStoreConfidenceScore);
                  }
                return storeConfidenceScore;
              }

            public string  getConfidenceScoreAsText()
              {
                Debug.Assert(flagHasConfidenceScore);
                if (textStoreConfidenceScore == "")
                  {
                    return Convert.ToString(storeConfidenceScore);
                  }
                else
                  {
                    return (textStoreConfidenceScore);
                  }
              }

            public bool  hasASRConfidence()
              {
                return flagHasASRConfidence;
              }

            public double  getASRConfidence()
              {
                Debug.Assert(flagHasASRConfidence);
                if (textStoreASRConfidence != "")
                  {
                    return Double.Parse(textStoreASRConfidence);
                  }
                return storeASRConfidence;
              }

            public string  getASRConfidenceAsText()
              {
                Debug.Assert(flagHasASRConfidence);
                if (textStoreASRConfidence == "")
                  {
                    return Convert.ToString(storeASRConfidence);
                  }
                else
                  {
                    return (textStoreASRConfidence);
                  }
              }

            public bool  hasFormattedTranscription()
              {
                return flagHasFormattedTranscription;
              }

            public string  getFormattedTranscription()
              {
                Debug.Assert(flagHasFormattedTranscription);
                return storeFormattedTranscription;
              }

            public bool  hasFixedTranscription()
              {
                return flagHasFixedTranscription;
              }

            public string  getFixedTranscription()
              {
                Debug.Assert(flagHasFixedTranscription);
                return storeFixedTranscription;
              }


            public virtual int extraTypeChoiceDataComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeChoiceDataComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeChoiceDataComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeChoiceDataLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setTranscription(string new_value)
              {
                flagHasTranscription = true;
                storeTranscription = new_value;
              }
            public void unsetTranscription()
              {
                flagHasTranscription = false;
              }
            public void setConfidenceScore(double new_value)
              {
                flagHasConfidenceScore = true;
                if (new_value < 0)
                    throw new Exception("The value for field ConfidenceScore of TypeChoiceDataJSON is less than the lower bound (0) for that field.");
                if (new_value > 1)
                    throw new Exception("The value for field ConfidenceScore of TypeChoiceDataJSON is greater than the upper bound (1) for that field.");
                storeConfidenceScore = new_value;
                textStoreConfidenceScore = "";
              }
            public void setConfidenceScoreText(string new_value)
              {
                flagHasConfidenceScore = true;
                if (!(JSONWriter.is_valid_number_format(new_value)))
                    throw new Exception("The text value for field ConfidenceScore of TypeChoiceDataJSON is not a valid number.");
                if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                    throw new Exception("The value for field ConfidenceScore of TypeChoiceDataJSON is less than the lower bound (0) for that field.");
                if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
                    throw new Exception("The value for field ConfidenceScore of TypeChoiceDataJSON is greater than the upper bound (1) for that field.");
                textStoreConfidenceScore = new_value;
              }
            public void unsetConfidenceScore()
              {
                flagHasConfidenceScore = false;
              }
            public void setASRConfidence(double new_value)
              {
                flagHasASRConfidence = true;
                storeASRConfidence = new_value;
                textStoreASRConfidence = "";
              }
            public void setASRConfidenceText(string new_value)
              {
                flagHasASRConfidence = true;
                if (!(JSONWriter.is_valid_number_format(new_value)))
                    throw new Exception("The text value for field ASRConfidence of TypeChoiceDataJSON is not a valid number.");
                textStoreASRConfidence = new_value;
              }
            public void unsetASRConfidence()
              {
                flagHasASRConfidence = false;
              }
            public void setFormattedTranscription(string new_value)
              {
                flagHasFormattedTranscription = true;
                storeFormattedTranscription = new_value;
              }
            public void unsetFormattedTranscription()
              {
                flagHasFormattedTranscription = false;
              }
            public void setFixedTranscription(string new_value)
              {
                flagHasFixedTranscription = true;
                storeFixedTranscription = new_value;
              }
            public void unsetFixedTranscription()
              {
                flagHasFixedTranscription = false;
              }

            public virtual void extraTypeChoiceDataAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeChoiceDataSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeChoiceDataLookup(key);
                if (old_field == null)
                  {
                    extraTypeChoiceDataAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasTranscription);
                if (flagHasTranscription)
                  {
                    handler.start_pair("Transcription");
                    handler.string_value(storeTranscription);
                  }
                Debug.Assert(partial_allowed || flagHasConfidenceScore);
                if (flagHasConfidenceScore)
                  {
                    handler.start_pair("ConfidenceScore");
                    if (textStoreConfidenceScore != "")
                        handler.number_value(textStoreConfidenceScore);
                    else if (((double)(long)storeConfidenceScore) == storeConfidenceScore)
                        handler.number_value((long)storeConfidenceScore);
                    else
                        handler.number_value(storeConfidenceScore);
                  }
                if (flagHasASRConfidence)
                  {
                    handler.start_pair("ASRConfidence");
                    if (textStoreASRConfidence != "")
                        handler.number_value(textStoreASRConfidence);
                    else if (((double)(long)storeASRConfidence) == storeASRConfidence)
                        handler.number_value((long)storeASRConfidence);
                    else
                        handler.number_value(storeASRConfidence);
                  }
                Debug.Assert(partial_allowed || flagHasFormattedTranscription);
                if (flagHasFormattedTranscription)
                  {
                    handler.start_pair("FormattedTranscription");
                    handler.string_value(storeFormattedTranscription);
                  }
                if (flagHasFixedTranscription)
                  {
                    handler.start_pair("FixedTranscription");
                    handler.string_value(storeFixedTranscription);
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
                if (!(hasTranscription()))
                  {
                    return "When parsing the object for %what%, the \"Transcription\" field was missing.";
                  }
                if (!(hasConfidenceScore()))
                  {
                    return "When parsing the object for %what%, the \"ConfidenceScore\" field was missing.";
                  }
                if (!(hasFormattedTranscription()))
                  {
                    return "When parsing the object for %what%, the \"FormattedTranscription\" field was missing.";
                  }
                return null;
              }

            public static TypeChoiceDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeChoiceDataJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeChoiceData", ignore_extras);
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
            public static TypeChoiceDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeChoiceDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeChoiceDataJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeChoiceData", ignore_extras);
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
            public static TypeChoiceDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeChoiceDataJSON from_text(string text, bool ignore_extras)
              {
                TypeChoiceDataJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeChoiceData", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeChoiceDataJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeChoiceDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeChoiceDataJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeChoiceData", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorTranscription;
                private JSONHoldingNumberTextGenerator fieldGeneratorConfidenceScore;
                private JSONHoldingNumberTextGenerator fieldGeneratorASRConfidence;
                private JSONHoldingStringGenerator fieldGeneratorFormattedTranscription;
                private JSONHoldingStringGenerator fieldGeneratorFixedTranscription;
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
                    TypeChoiceDataJSON result = new TypeChoiceDataJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeChoiceDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeChoiceDataJSON result)
                  {
                    if (fieldGeneratorTranscription.have_value)
                      {
                        result.setTranscription(fieldGeneratorTranscription.value);
                        fieldGeneratorTranscription.have_value = false;
                      }
                    else if ((!(result.hasTranscription())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Transcription\" field was missing.");
                      }
                    if (fieldGeneratorConfidenceScore.have_value)
                      {
                        result.setConfidenceScoreText(fieldGeneratorConfidenceScore.value);
                        fieldGeneratorConfidenceScore.have_value = false;
                      }
                    else if ((!(result.hasConfidenceScore())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"ConfidenceScore\" field was missing.");
                      }
                    if (fieldGeneratorASRConfidence.have_value)
                      {
                        result.setASRConfidenceText(fieldGeneratorASRConfidence.value);
                        fieldGeneratorASRConfidence.have_value = false;
                      }
                    if (fieldGeneratorFormattedTranscription.have_value)
                      {
                        result.setFormattedTranscription(fieldGeneratorFormattedTranscription.value);
                        fieldGeneratorFormattedTranscription.have_value = false;
                      }
                    else if ((!(result.hasFormattedTranscription())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"FormattedTranscription\" field was missing.");
                      }
                    if (fieldGeneratorFixedTranscription.have_value)
                      {
                        result.setFixedTranscription(fieldGeneratorFixedTranscription.value);
                        fieldGeneratorFixedTranscription.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeChoiceDataJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 1, "SRConfidence", 0, 12, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorASRConfidence;
                            break;
                        case 'C':
                            if ((String.Compare(field_name, 1, "onfidenceScore", 0, 14, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorConfidenceScore;
                            break;
                        case 'F':
                            switch (field_name[1])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 2, "xedTranscription", 0, 16, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorFixedTranscription;
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 2, "rmattedTranscription", 0, 20, false) == 0) && (field_name.Length == 22))
                                        return fieldGeneratorFormattedTranscription;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "ranscription", 0, 12, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorTranscription;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorTranscription = new JSONHoldingStringGenerator("field \"Transcription\" of the TypeChoiceData class");
                    fieldGeneratorConfidenceScore = new JSONHoldingNumberTextGenerator("field \"ConfidenceScore\" of the TypeChoiceData class");
                    fieldGeneratorASRConfidence = new JSONHoldingNumberTextGenerator("field \"ASRConfidence\" of the TypeChoiceData class");
                    fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the TypeChoiceData class");
                    fieldGeneratorFixedTranscription = new JSONHoldingStringGenerator("field \"FixedTranscription\" of the TypeChoiceData class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeChoiceData class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorTranscription = new JSONHoldingStringGenerator("field \"Transcription\" of the TypeChoiceData class");
                    fieldGeneratorConfidenceScore = new JSONHoldingNumberTextGenerator("field \"ConfidenceScore\" of the TypeChoiceData class");
                    fieldGeneratorASRConfidence = new JSONHoldingNumberTextGenerator("field \"ASRConfidence\" of the TypeChoiceData class");
                    fieldGeneratorFormattedTranscription = new JSONHoldingStringGenerator("field \"FormattedTranscription\" of the TypeChoiceData class");
                    fieldGeneratorFixedTranscription = new JSONHoldingStringGenerator("field \"FixedTranscription\" of the TypeChoiceData class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeChoiceData class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorTranscription.reset();
                    fieldGeneratorConfidenceScore.reset();
                    fieldGeneratorASRConfidence.reset();
                    fieldGeneratorFormattedTranscription.reset();
                    fieldGeneratorFixedTranscription.reset();
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
                protected override void handle_result(TypeChoiceDataJSON  result)
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
                public TypeChoiceDataJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeChoiceDataJSON  result)
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
            protected virtual void handle_result(List<TypeChoiceDataJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeChoiceDataJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeChoiceDataJSON>();
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
            public List<TypeChoiceDataJSON> value;
          };
          };
        private bool flagHasNumToShow;
        private BigInteger storeNumToShow;
        private bool flagHasChoiceData;
        private List< TypeChoiceDataJSON  > storeChoiceData;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONNumToShow(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumToShow of TypeDisambiguationJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumToShow of TypeDisambiguationJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumToShow(extracted_integer);
          }


        private void  fromJSONChoiceData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field ChoiceData of TypeDisambiguationJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field ChoiceData of TypeDisambiguationJSON has too few elements.");
            List< TypeChoiceDataJSON  > vector_ChoiceData1 = new List< TypeChoiceDataJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeChoiceDataJSON convert_classy = TypeChoiceDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_ChoiceData1.Add(convert_classy);
              }
            Debug.Assert(vector_ChoiceData1.Count >= 1);
            initChoiceData();
            for (int num1 = 0; num1 < vector_ChoiceData1.Count; ++num1)
                appendChoiceData(vector_ChoiceData1[num1]);
            for (int num1 = 0; num1 < vector_ChoiceData1.Count; ++num1)
              {
              }
          }


        public TypeDisambiguationJSON()
          {
            flagHasNumToShow = false;
            flagHasChoiceData = false;
            storeChoiceData = new List< TypeChoiceDataJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasNumToShow()
          {
            return flagHasNumToShow;
          }

        public BigInteger  getNumToShow()
          {
            Debug.Assert(flagHasNumToShow);
            return storeNumToShow;
          }

        public bool  hasChoiceData()
          {
            return flagHasChoiceData;
          }

        public int  countOfChoiceData()
          {
            Debug.Assert(flagHasChoiceData);
            return storeChoiceData.Count;
          }

        public TypeChoiceDataJSON   elementOfChoiceData(int element_num)
          {
            Debug.Assert(flagHasChoiceData);
            return storeChoiceData[element_num];
          }

        public List< TypeChoiceDataJSON  >  getChoiceData()
          {
            Debug.Assert(flagHasChoiceData);
            return storeChoiceData;
          }


        public virtual int extraTypeDisambiguationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDisambiguationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDisambiguationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDisambiguationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setNumToShow(BigInteger new_value)
          {
            flagHasNumToShow = true;
            if (new_value < 1)
                throw new Exception("The value for field NumToShow of TypeDisambiguationJSON is less than the lower bound (1) for that field.");
            storeNumToShow = new_value;
          }
        public void unsetNumToShow()
          {
            flagHasNumToShow = false;
          }
        public void initChoiceData()
          {
            if (flagHasChoiceData)
              {
                for (int num1 = 0; num1 < storeChoiceData.Count; ++num1)
                  {
                  }
              }
            flagHasChoiceData = true;
            storeChoiceData.Clear();
          }
        public void appendChoiceData(TypeChoiceDataJSON  to_append)
          {
            if (!flagHasChoiceData)
              {
                flagHasChoiceData = true;
                storeChoiceData.Clear();
              }
            Debug.Assert(flagHasChoiceData);
            storeChoiceData.Add(to_append);
          }
        public void unsetChoiceData()
          {
            if (flagHasChoiceData)
              {
                for (int num2 = 0; num2 < storeChoiceData.Count; ++num2)
                  {
                  }
              }
            flagHasChoiceData = false;
            storeChoiceData.Clear();
          }

        public virtual void extraTypeDisambiguationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDisambiguationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDisambiguationLookup(key);
            if (old_field == null)
              {
                extraTypeDisambiguationAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasNumToShow);
            if (flagHasNumToShow)
              {
                handler.start_pair("NumToShow");
                handler.number_value(storeNumToShow);
              }
            Debug.Assert(partial_allowed || flagHasChoiceData);
            if (flagHasChoiceData)
              {
                handler.start_pair("ChoiceData");
                Debug.Assert(storeChoiceData.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeChoiceData.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeChoiceData[num1].write_partial_as_json(handler);
                    else
                        storeChoiceData[num1].write_as_json(handler);
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
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasNumToShow()))
              {
                return "When parsing the object for %what%, the \"NumToShow\" field was missing.";
              }
            if (!(hasChoiceData()))
              {
                return "When parsing the object for %what%, the \"ChoiceData\" field was missing.";
              }
            return null;
          }

        public static TypeDisambiguationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDisambiguationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDisambiguation", ignore_extras);
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
        public static TypeDisambiguationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDisambiguationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDisambiguationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDisambiguation", ignore_extras);
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
        public static TypeDisambiguationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDisambiguationJSON from_text(string text, bool ignore_extras)
          {
            TypeDisambiguationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDisambiguation", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDisambiguationJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDisambiguationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDisambiguationJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDisambiguation", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorNumToShow : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNumToShow(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumToShow : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumToShow(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorNumToShow fieldGeneratorNumToShow;
            private TypeChoiceDataJSON.HoldingArrayGenerator fieldGeneratorChoiceData;
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
                TypeDisambiguationJSON result = new TypeDisambiguationJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDisambiguationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDisambiguationJSON result)
              {
                if (fieldGeneratorNumToShow.have_value)
                  {
                    result.setNumToShow(fieldGeneratorNumToShow.value);
                    fieldGeneratorNumToShow.have_value = false;
                  }
                else if ((!(result.hasNumToShow())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NumToShow\" field was missing.");
                  }
                if (fieldGeneratorChoiceData.have_value)
                  {
                    result.initChoiceData();
                    int count = fieldGeneratorChoiceData.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendChoiceData(fieldGeneratorChoiceData.value[num]);
                      }
                    fieldGeneratorChoiceData.value.Clear();
                    fieldGeneratorChoiceData.have_value = false;
                  }
                else if ((!(result.hasChoiceData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ChoiceData\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDisambiguationJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "hoiceData", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorChoiceData;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "umToShow", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorNumToShow;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorNumToShow = new FieldHoldingGeneratorNumToShow("field \"NumToShow\" of the TypeDisambiguation class");
                fieldGeneratorChoiceData = new TypeChoiceDataJSON.HoldingArrayGenerator("field \"ChoiceData\" of the TypeDisambiguation class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDisambiguation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorNumToShow = new FieldHoldingGeneratorNumToShow("field \"NumToShow\" of the TypeDisambiguation class");
                fieldGeneratorChoiceData = new TypeChoiceDataJSON.HoldingArrayGenerator("field \"ChoiceData\" of the TypeDisambiguation class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDisambiguation class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorNumToShow.reset();
                fieldGeneratorChoiceData.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorChoiceData.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorChoiceData.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDisambiguationJSON  result)
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
            public TypeDisambiguationJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDisambiguationJSON  result)
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
        protected virtual void handle_result(List<TypeDisambiguationJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDisambiguationJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDisambiguationJSON>();
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
        public List<TypeDisambiguationJSON> value;
      };
      };
    public class TypeASRUsageJSON : JSONBase
      {
        private bool flagHasASRComponent;
        private string storeASRComponent;
        private bool flagHasComponentUniqueID;
        private string storeComponentUniqueID;
        private bool flagHasAudioLength;
        private double storeAudioLength;
        private string textStoreAudioLength;
        private bool flagHasIncrementalAudioLength;
        private double storeIncrementalAudioLength;
        private string textStoreIncrementalAudioLength;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONASRComponent(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ASRComponent of TypeASRUsageJSON is not a string.");
            setASRComponent(json_string.getData());
          }


        private void  fromJSONComponentUniqueID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ComponentUniqueID of TypeASRUsageJSON is not a string.");
            setComponentUniqueID(json_string.getData());
          }


        private void  fromJSONAudioLength(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field AudioLength of TypeASRUsageJSON is not a number.");
                  }
              }
            setAudioLengthText(the_rational_text);
          }


        private void  fromJSONIncrementalAudioLength(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field IncrementalAudioLength of TypeASRUsageJSON is not a number.");
                  }
              }
            setIncrementalAudioLengthText(the_rational_text);
          }


        public TypeASRUsageJSON()
          {
            flagHasASRComponent = false;
            flagHasComponentUniqueID = false;
            flagHasAudioLength = false;
            flagHasIncrementalAudioLength = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasASRComponent()
          {
            return flagHasASRComponent;
          }

        public string  getASRComponent()
          {
            Debug.Assert(flagHasASRComponent);
            return storeASRComponent;
          }

        public bool  hasComponentUniqueID()
          {
            return flagHasComponentUniqueID;
          }

        public string  getComponentUniqueID()
          {
            Debug.Assert(flagHasComponentUniqueID);
            return storeComponentUniqueID;
          }

        public bool  hasAudioLength()
          {
            return flagHasAudioLength;
          }

        public double  getAudioLength()
          {
            Debug.Assert(flagHasAudioLength);
            if (textStoreAudioLength != "")
              {
                return Double.Parse(textStoreAudioLength);
              }
            return storeAudioLength;
          }

        public string  getAudioLengthAsText()
          {
            Debug.Assert(flagHasAudioLength);
            if (textStoreAudioLength == "")
              {
                return Convert.ToString(storeAudioLength);
              }
            else
              {
                return (textStoreAudioLength);
              }
          }

        public bool  hasIncrementalAudioLength()
          {
            return flagHasIncrementalAudioLength;
          }

        public double  getIncrementalAudioLength()
          {
            Debug.Assert(flagHasIncrementalAudioLength);
            if (textStoreIncrementalAudioLength != "")
              {
                return Double.Parse(textStoreIncrementalAudioLength);
              }
            return storeIncrementalAudioLength;
          }

        public string  getIncrementalAudioLengthAsText()
          {
            Debug.Assert(flagHasIncrementalAudioLength);
            if (textStoreIncrementalAudioLength == "")
              {
                return Convert.ToString(storeIncrementalAudioLength);
              }
            else
              {
                return (textStoreIncrementalAudioLength);
              }
          }


        public virtual int extraTypeASRUsageComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeASRUsageComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeASRUsageComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeASRUsageLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setASRComponent(string new_value)
          {
            flagHasASRComponent = true;
            storeASRComponent = new_value;
          }
        public void unsetASRComponent()
          {
            flagHasASRComponent = false;
          }
        public void setComponentUniqueID(string new_value)
          {
            flagHasComponentUniqueID = true;
            storeComponentUniqueID = new_value;
          }
        public void unsetComponentUniqueID()
          {
            flagHasComponentUniqueID = false;
          }
        public void setAudioLength(double new_value)
          {
            flagHasAudioLength = true;
            if (new_value < 0)
                throw new Exception("The value for field AudioLength of TypeASRUsageJSON is less than the lower bound (0) for that field.");
            storeAudioLength = new_value;
            textStoreAudioLength = "";
          }
        public void setAudioLengthText(string new_value)
          {
            flagHasAudioLength = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field AudioLength of TypeASRUsageJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field AudioLength of TypeASRUsageJSON is less than the lower bound (0) for that field.");
            textStoreAudioLength = new_value;
          }
        public void unsetAudioLength()
          {
            flagHasAudioLength = false;
          }
        public void setIncrementalAudioLength(double new_value)
          {
            flagHasIncrementalAudioLength = true;
            if (new_value < 0)
                throw new Exception("The value for field IncrementalAudioLength of TypeASRUsageJSON is less than the lower bound (0) for that field.");
            storeIncrementalAudioLength = new_value;
            textStoreIncrementalAudioLength = "";
          }
        public void setIncrementalAudioLengthText(string new_value)
          {
            flagHasIncrementalAudioLength = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field IncrementalAudioLength of TypeASRUsageJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field IncrementalAudioLength of TypeASRUsageJSON is less than the lower bound (0) for that field.");
            textStoreIncrementalAudioLength = new_value;
          }
        public void unsetIncrementalAudioLength()
          {
            flagHasIncrementalAudioLength = false;
          }

        public virtual void extraTypeASRUsageAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeASRUsageSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeASRUsageLookup(key);
            if (old_field == null)
              {
                extraTypeASRUsageAppendPair(key, new_component);
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
            if (flagHasASRComponent)
              {
                handler.start_pair("ASRComponent");
                handler.string_value(storeASRComponent);
              }
            Debug.Assert(partial_allowed || flagHasComponentUniqueID);
            if (flagHasComponentUniqueID)
              {
                handler.start_pair("ComponentUniqueID");
                handler.string_value(storeComponentUniqueID);
              }
            if (flagHasAudioLength)
              {
                handler.start_pair("AudioLength");
                if (textStoreAudioLength != "")
                    handler.number_value(textStoreAudioLength);
                else if (((double)(long)storeAudioLength) == storeAudioLength)
                    handler.number_value((long)storeAudioLength);
                else
                    handler.number_value(storeAudioLength);
              }
            if (flagHasIncrementalAudioLength)
              {
                handler.start_pair("IncrementalAudioLength");
                if (textStoreIncrementalAudioLength != "")
                    handler.number_value(textStoreIncrementalAudioLength);
                else if (((double)(long)storeIncrementalAudioLength) == storeIncrementalAudioLength)
                    handler.number_value((long)storeIncrementalAudioLength);
                else
                    handler.number_value(storeIncrementalAudioLength);
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
            if (!(hasComponentUniqueID()))
              {
                return "When parsing the object for %what%, the \"ComponentUniqueID\" field was missing.";
              }
            return null;
          }

        public static TypeASRUsageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeASRUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeASRUsage", ignore_extras);
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
        public static TypeASRUsageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeASRUsageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeASRUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeASRUsage", ignore_extras);
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
        public static TypeASRUsageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeASRUsageJSON from_text(string text, bool ignore_extras)
          {
            TypeASRUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeASRUsage", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeASRUsageJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeASRUsageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeASRUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeASRUsage", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorASRComponent;
            private JSONHoldingStringGenerator fieldGeneratorComponentUniqueID;
            private JSONHoldingNumberTextGenerator fieldGeneratorAudioLength;
            private JSONHoldingNumberTextGenerator fieldGeneratorIncrementalAudioLength;
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
                TypeASRUsageJSON result = new TypeASRUsageJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeASRUsageAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeASRUsageJSON result)
              {
                if (fieldGeneratorASRComponent.have_value)
                  {
                    result.setASRComponent(fieldGeneratorASRComponent.value);
                    fieldGeneratorASRComponent.have_value = false;
                  }
                if (fieldGeneratorComponentUniqueID.have_value)
                  {
                    result.setComponentUniqueID(fieldGeneratorComponentUniqueID.value);
                    fieldGeneratorComponentUniqueID.have_value = false;
                  }
                else if ((!(result.hasComponentUniqueID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ComponentUniqueID\" field was missing.");
                  }
                if (fieldGeneratorAudioLength.have_value)
                  {
                    result.setAudioLengthText(fieldGeneratorAudioLength.value);
                    fieldGeneratorAudioLength.have_value = false;
                  }
                if (fieldGeneratorIncrementalAudioLength.have_value)
                  {
                    result.setIncrementalAudioLengthText(fieldGeneratorIncrementalAudioLength.value);
                    fieldGeneratorIncrementalAudioLength.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeASRUsageJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        switch (field_name[1])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 2, "RComponent", 0, 10, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorASRComponent;
                                break;
                            case 'u':
                                if ((String.Compare(field_name, 2, "dioLength", 0, 9, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorAudioLength;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'C':
                        if ((String.Compare(field_name, 1, "omponentUniqueID", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorComponentUniqueID;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "ncrementalAudioLength", 0, 21, false) == 0) && (field_name.Length == 22))
                            return fieldGeneratorIncrementalAudioLength;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorASRComponent = new JSONHoldingStringGenerator("field \"ASRComponent\" of the TypeASRUsage class");
                fieldGeneratorComponentUniqueID = new JSONHoldingStringGenerator("field \"ComponentUniqueID\" of the TypeASRUsage class");
                fieldGeneratorAudioLength = new JSONHoldingNumberTextGenerator("field \"AudioLength\" of the TypeASRUsage class");
                fieldGeneratorIncrementalAudioLength = new JSONHoldingNumberTextGenerator("field \"IncrementalAudioLength\" of the TypeASRUsage class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeASRUsage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorASRComponent = new JSONHoldingStringGenerator("field \"ASRComponent\" of the TypeASRUsage class");
                fieldGeneratorComponentUniqueID = new JSONHoldingStringGenerator("field \"ComponentUniqueID\" of the TypeASRUsage class");
                fieldGeneratorAudioLength = new JSONHoldingNumberTextGenerator("field \"AudioLength\" of the TypeASRUsage class");
                fieldGeneratorIncrementalAudioLength = new JSONHoldingNumberTextGenerator("field \"IncrementalAudioLength\" of the TypeASRUsage class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeASRUsage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorASRComponent.reset();
                fieldGeneratorComponentUniqueID.reset();
                fieldGeneratorAudioLength.reset();
                fieldGeneratorIncrementalAudioLength.reset();
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
            protected override void handle_result(TypeASRUsageJSON  result)
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
            public TypeASRUsageJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeASRUsageJSON  result)
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
        protected virtual void handle_result(List<TypeASRUsageJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeASRUsageJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeASRUsageJSON>();
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
        public List<TypeASRUsageJSON> value;
      };
      };
    public class TypeDomainUsageJSON : JSONBase
      {
        private bool flagHasDomain;
        private string storeDomain;
        private bool flagHasDomainUniqueID;
        private string storeDomainUniqueID;
        private bool flagHasCreditsUsed;
        private double storeCreditsUsed;
        private string textStoreCreditsUsed;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDomain(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Domain of TypeDomainUsageJSON is not a string.");
            setDomain(json_string.getData());
          }


        private void  fromJSONDomainUniqueID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field DomainUniqueID of TypeDomainUsageJSON is not a string.");
            setDomainUniqueID(json_string.getData());
          }


        private void  fromJSONCreditsUsed(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field CreditsUsed of TypeDomainUsageJSON is not a number.");
                  }
              }
            setCreditsUsedText(the_rational_text);
          }


        public TypeDomainUsageJSON()
          {
            flagHasDomain = false;
            flagHasDomainUniqueID = false;
            flagHasCreditsUsed = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDomain()
          {
            return flagHasDomain;
          }

        public string  getDomain()
          {
            Debug.Assert(flagHasDomain);
            return storeDomain;
          }

        public bool  hasDomainUniqueID()
          {
            return flagHasDomainUniqueID;
          }

        public string  getDomainUniqueID()
          {
            Debug.Assert(flagHasDomainUniqueID);
            return storeDomainUniqueID;
          }

        public bool  hasCreditsUsed()
          {
            return flagHasCreditsUsed;
          }

        public double  getCreditsUsed()
          {
            Debug.Assert(flagHasCreditsUsed);
            if (textStoreCreditsUsed != "")
              {
                return Double.Parse(textStoreCreditsUsed);
              }
            return storeCreditsUsed;
          }

        public string  getCreditsUsedAsText()
          {
            Debug.Assert(flagHasCreditsUsed);
            if (textStoreCreditsUsed == "")
              {
                return Convert.ToString(storeCreditsUsed);
              }
            else
              {
                return (textStoreCreditsUsed);
              }
          }


        public virtual int extraTypeDomainUsageComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDomainUsageComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDomainUsageComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDomainUsageLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDomain(string new_value)
          {
            flagHasDomain = true;
            storeDomain = new_value;
          }
        public void unsetDomain()
          {
            flagHasDomain = false;
          }
        public void setDomainUniqueID(string new_value)
          {
            flagHasDomainUniqueID = true;
            storeDomainUniqueID = new_value;
          }
        public void unsetDomainUniqueID()
          {
            flagHasDomainUniqueID = false;
          }
        public void setCreditsUsed(double new_value)
          {
            flagHasCreditsUsed = true;
            if (new_value < 0)
                throw new Exception("The value for field CreditsUsed of TypeDomainUsageJSON is less than the lower bound (0) for that field.");
            storeCreditsUsed = new_value;
            textStoreCreditsUsed = "";
          }
        public void setCreditsUsedText(string new_value)
          {
            flagHasCreditsUsed = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field CreditsUsed of TypeDomainUsageJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field CreditsUsed of TypeDomainUsageJSON is less than the lower bound (0) for that field.");
            textStoreCreditsUsed = new_value;
          }
        public void unsetCreditsUsed()
          {
            flagHasCreditsUsed = false;
          }

        public virtual void extraTypeDomainUsageAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDomainUsageSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDomainUsageLookup(key);
            if (old_field == null)
              {
                extraTypeDomainUsageAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasDomain);
            if (flagHasDomain)
              {
                handler.start_pair("Domain");
                handler.string_value(storeDomain);
              }
            Debug.Assert(partial_allowed || flagHasDomainUniqueID);
            if (flagHasDomainUniqueID)
              {
                handler.start_pair("DomainUniqueID");
                handler.string_value(storeDomainUniqueID);
              }
            Debug.Assert(partial_allowed || flagHasCreditsUsed);
            if (flagHasCreditsUsed)
              {
                handler.start_pair("CreditsUsed");
                if (textStoreCreditsUsed != "")
                    handler.number_value(textStoreCreditsUsed);
                else if (((double)(long)storeCreditsUsed) == storeCreditsUsed)
                    handler.number_value((long)storeCreditsUsed);
                else
                    handler.number_value(storeCreditsUsed);
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
            if (!(hasDomain()))
              {
                return "When parsing the object for %what%, the \"Domain\" field was missing.";
              }
            if (!(hasDomainUniqueID()))
              {
                return "When parsing the object for %what%, the \"DomainUniqueID\" field was missing.";
              }
            if (!(hasCreditsUsed()))
              {
                return "When parsing the object for %what%, the \"CreditsUsed\" field was missing.";
              }
            return null;
          }

        public static TypeDomainUsageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDomainUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDomainUsage", ignore_extras);
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
        public static TypeDomainUsageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDomainUsageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDomainUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDomainUsage", ignore_extras);
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
        public static TypeDomainUsageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDomainUsageJSON from_text(string text, bool ignore_extras)
          {
            TypeDomainUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDomainUsage", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDomainUsageJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDomainUsageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDomainUsageJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDomainUsage", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorDomain;
            private JSONHoldingStringGenerator fieldGeneratorDomainUniqueID;
            private JSONHoldingNumberTextGenerator fieldGeneratorCreditsUsed;
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
                TypeDomainUsageJSON result = new TypeDomainUsageJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDomainUsageAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDomainUsageJSON result)
              {
                if (fieldGeneratorDomain.have_value)
                  {
                    result.setDomain(fieldGeneratorDomain.value);
                    fieldGeneratorDomain.have_value = false;
                  }
                else if ((!(result.hasDomain())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Domain\" field was missing.");
                  }
                if (fieldGeneratorDomainUniqueID.have_value)
                  {
                    result.setDomainUniqueID(fieldGeneratorDomainUniqueID.value);
                    fieldGeneratorDomainUniqueID.have_value = false;
                  }
                else if ((!(result.hasDomainUniqueID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"DomainUniqueID\" field was missing.");
                  }
                if (fieldGeneratorCreditsUsed.have_value)
                  {
                    result.setCreditsUsedText(fieldGeneratorCreditsUsed.value);
                    fieldGeneratorCreditsUsed.have_value = false;
                  }
                else if ((!(result.hasCreditsUsed())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"CreditsUsed\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDomainUsageJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "reditsUsed", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorCreditsUsed;
                        break;
                    case 'D':
                        if (String.Compare(field_name, 1, "omain", 0, 5, false) == 0)
                          {
                            if (field_name.Length == 6)
                              {
                                return fieldGeneratorDomain;
                              }
                            switch (field_name[6])
                              {
                                case 'U':
                                    if ((String.Compare(field_name, 7, "niqueID", 0, 7, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorDomainUniqueID;
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
                fieldGeneratorDomain = new JSONHoldingStringGenerator("field \"Domain\" of the TypeDomainUsage class");
                fieldGeneratorDomainUniqueID = new JSONHoldingStringGenerator("field \"DomainUniqueID\" of the TypeDomainUsage class");
                fieldGeneratorCreditsUsed = new JSONHoldingNumberTextGenerator("field \"CreditsUsed\" of the TypeDomainUsage class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDomainUsage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDomain = new JSONHoldingStringGenerator("field \"Domain\" of the TypeDomainUsage class");
                fieldGeneratorDomainUniqueID = new JSONHoldingStringGenerator("field \"DomainUniqueID\" of the TypeDomainUsage class");
                fieldGeneratorCreditsUsed = new JSONHoldingNumberTextGenerator("field \"CreditsUsed\" of the TypeDomainUsage class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDomainUsage class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDomain.reset();
                fieldGeneratorDomainUniqueID.reset();
                fieldGeneratorCreditsUsed.reset();
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
            protected override void handle_result(TypeDomainUsageJSON  result)
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
            public TypeDomainUsageJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDomainUsageJSON  result)
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
        protected virtual void handle_result(List<TypeDomainUsageJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDomainUsageJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDomainUsageJSON>();
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
        public List<TypeDomainUsageJSON> value;
      };
      };
    public class TypeTranscriptionLatticeJSON : JSONBase
      {
        public class TypeOutgoingTransitionsJSON : JSONBase
          {
            private bool flagHasDestinationID;
            private BigInteger storeDestinationID;
            private bool flagHasToken;
            private string storeToken;
            private bool flagHasScore;
            private double storeScore;
            private string textStoreScore;
            private bool flagHasStartMillisecond;
            private BigInteger storeStartMillisecond;
            private bool flagHasEndMillisecond;
            private BigInteger storeEndMillisecond;


            private void  fromJSONDestinationID(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field DestinationID of TypeOutgoingTransitionsJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field DestinationID of TypeOutgoingTransitionsJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setDestinationID(extracted_integer);
              }


            private void  fromJSONToken(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Token of TypeOutgoingTransitionsJSON is not a string.");
                setToken(json_string.getData());
              }


            private void  fromJSONScore(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONRationalValue json_rational = json_value.rational_value();
                string the_rational_text;
                if (json_rational != null)
                  {
                    the_rational_text = json_rational.getText();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_rational_text = json_integer.getText();
                      }
                    else
                      {
                        throw new Exception("The value for field Score of TypeOutgoingTransitionsJSON is not a number.");
                      }
                  }
                setScoreText(the_rational_text);
              }


            private void  fromJSONStartMillisecond(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field StartMillisecond of TypeOutgoingTransitionsJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field StartMillisecond of TypeOutgoingTransitionsJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setStartMillisecond(extracted_integer);
              }


            private void  fromJSONEndMillisecond(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field EndMillisecond of TypeOutgoingTransitionsJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field EndMillisecond of TypeOutgoingTransitionsJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setEndMillisecond(extracted_integer);
              }


            public TypeOutgoingTransitionsJSON()
              {
                flagHasDestinationID = false;
                flagHasToken = false;
                flagHasScore = false;
                flagHasStartMillisecond = false;
                flagHasEndMillisecond = false;
              }

            public bool  hasDestinationID()
              {
                return flagHasDestinationID;
              }

            public BigInteger  getDestinationID()
              {
                Debug.Assert(flagHasDestinationID);
                return storeDestinationID;
              }

            public bool  hasToken()
              {
                return flagHasToken;
              }

            public string  getToken()
              {
                Debug.Assert(flagHasToken);
                return storeToken;
              }

            public bool  hasScore()
              {
                return flagHasScore;
              }

            public double  getScore()
              {
                Debug.Assert(flagHasScore);
                if (textStoreScore != "")
                  {
                    return Double.Parse(textStoreScore);
                  }
                return storeScore;
              }

            public string  getScoreAsText()
              {
                Debug.Assert(flagHasScore);
                if (textStoreScore == "")
                  {
                    return Convert.ToString(storeScore);
                  }
                else
                  {
                    return (textStoreScore);
                  }
              }

            public bool  hasStartMillisecond()
              {
                return flagHasStartMillisecond;
              }

            public BigInteger  getStartMillisecond()
              {
                Debug.Assert(flagHasStartMillisecond);
                return storeStartMillisecond;
              }

            public bool  hasEndMillisecond()
              {
                return flagHasEndMillisecond;
              }

            public BigInteger  getEndMillisecond()
              {
                Debug.Assert(flagHasEndMillisecond);
                return storeEndMillisecond;
              }



            public void setDestinationID(BigInteger new_value)
              {
                flagHasDestinationID = true;
                if (new_value < 0)
                    throw new Exception("The value for field DestinationID of TypeOutgoingTransitionsJSON is less than the lower bound (0) for that field.");
                storeDestinationID = new_value;
              }
            public void unsetDestinationID()
              {
                flagHasDestinationID = false;
              }
            public void setToken(string new_value)
              {
                flagHasToken = true;
                storeToken = new_value;
              }
            public void unsetToken()
              {
                flagHasToken = false;
              }
            public void setScore(double new_value)
              {
                flagHasScore = true;
                if (new_value < 0)
                    throw new Exception("The value for field Score of TypeOutgoingTransitionsJSON is less than the lower bound (0) for that field.");
                if (new_value > 1)
                    throw new Exception("The value for field Score of TypeOutgoingTransitionsJSON is greater than the upper bound (1) for that field.");
                storeScore = new_value;
                textStoreScore = "";
              }
            public void setScoreText(string new_value)
              {
                flagHasScore = true;
                if (!(JSONWriter.is_valid_number_format(new_value)))
                    throw new Exception("The text value for field Score of TypeOutgoingTransitionsJSON is not a valid number.");
                if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                    throw new Exception("The value for field Score of TypeOutgoingTransitionsJSON is less than the lower bound (0) for that field.");
                if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
                    throw new Exception("The value for field Score of TypeOutgoingTransitionsJSON is greater than the upper bound (1) for that field.");
                textStoreScore = new_value;
              }
            public void unsetScore()
              {
                flagHasScore = false;
              }
            public void setStartMillisecond(BigInteger new_value)
              {
                flagHasStartMillisecond = true;
                if (new_value < 0)
                    throw new Exception("The value for field StartMillisecond of TypeOutgoingTransitionsJSON is less than the lower bound (0) for that field.");
                storeStartMillisecond = new_value;
              }
            public void unsetStartMillisecond()
              {
                flagHasStartMillisecond = false;
              }
            public void setEndMillisecond(BigInteger new_value)
              {
                flagHasEndMillisecond = true;
                if (new_value < 0)
                    throw new Exception("The value for field EndMillisecond of TypeOutgoingTransitionsJSON is less than the lower bound (0) for that field.");
                storeEndMillisecond = new_value;
              }
            public void unsetEndMillisecond()
              {
                flagHasEndMillisecond = false;
              }


            public override void write_as_json(JSONHandler handler)
              {
                handler.start_object();
                write_fields_as_json(handler);
                handler.finish_object();
              }

            public virtual void write_fields_as_json(JSONHandler handler)
              {
                write_fields_as_json(handler, false);
              }

            public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
              {
                Debug.Assert(partial_allowed || flagHasDestinationID);
                if (flagHasDestinationID)
                  {
                    handler.start_pair("DestinationID");
                    handler.number_value(storeDestinationID);
                  }
                Debug.Assert(partial_allowed || flagHasToken);
                if (flagHasToken)
                  {
                    handler.start_pair("Token");
                    handler.string_value(storeToken);
                  }
                Debug.Assert(partial_allowed || flagHasScore);
                if (flagHasScore)
                  {
                    handler.start_pair("Score");
                    if (textStoreScore != "")
                        handler.number_value(textStoreScore);
                    else if (((double)(long)storeScore) == storeScore)
                        handler.number_value((long)storeScore);
                    else
                        handler.number_value(storeScore);
                  }
                if (flagHasStartMillisecond)
                  {
                    handler.start_pair("StartMillisecond");
                    handler.number_value(storeStartMillisecond);
                  }
                if (flagHasEndMillisecond)
                  {
                    handler.start_pair("EndMillisecond");
                    handler.number_value(storeEndMillisecond);
                  }
              }
            public override void write_partial_as_json(JSONHandler handler)
              {
                handler.start_object();
                write_fields_as_json(handler, true);
                handler.finish_object();
              }
            public virtual string missing_field_error(bool allow_unpolished)
              {
                if (!(hasDestinationID()))
                  {
                    return "When parsing the object for %what%, the \"DestinationID\" field was missing.";
                  }
                if (!(hasToken()))
                  {
                    return "When parsing the object for %what%, the \"Token\" field was missing.";
                  }
                if (!(hasScore()))
                  {
                    return "When parsing the object for %what%, the \"Score\" field was missing.";
                  }
                return null;
              }

            public static TypeOutgoingTransitionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeOutgoingTransitionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeOutgoingTransitions", ignore_extras);
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
            public static TypeOutgoingTransitionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeOutgoingTransitionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeOutgoingTransitionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeOutgoingTransitions", ignore_extras);
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
            public static TypeOutgoingTransitionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeOutgoingTransitionsJSON from_text(string text, bool ignore_extras)
              {
                TypeOutgoingTransitionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeOutgoingTransitions", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeOutgoingTransitionsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeOutgoingTransitionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeOutgoingTransitionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeOutgoingTransitions", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
            private class FieldHoldingGeneratorDestinationID : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorDestinationID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorDestinationID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorDestinationID(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorDestinationID fieldGeneratorDestinationID;
                private JSONHoldingStringGenerator fieldGeneratorToken;
                private JSONHoldingNumberTextGenerator fieldGeneratorScore;
            private class FieldHoldingGeneratorStartMillisecond : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorStartMillisecond(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorStartMillisecond : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorStartMillisecond(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorStartMillisecond fieldGeneratorStartMillisecond;
            private class FieldHoldingGeneratorEndMillisecond : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorEndMillisecond(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorEndMillisecond : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorEndMillisecond(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorEndMillisecond fieldGeneratorEndMillisecond;

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
                    string message = "";
                    message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                    throw new Exception(message);
                  }
                protected override void finish_field(string field_name, JSONHandler field_handler)
                  {
                  }
                protected override void finish()
                  {
                    TypeOutgoingTransitionsJSON result = new TypeOutgoingTransitionsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeOutgoingTransitionsJSON result)
                  {
                    if (fieldGeneratorDestinationID.have_value)
                      {
                        result.setDestinationID(fieldGeneratorDestinationID.value);
                        fieldGeneratorDestinationID.have_value = false;
                      }
                    else if ((!(result.hasDestinationID())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"DestinationID\" field was missing.");
                      }
                    if (fieldGeneratorToken.have_value)
                      {
                        result.setToken(fieldGeneratorToken.value);
                        fieldGeneratorToken.have_value = false;
                      }
                    else if ((!(result.hasToken())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Token\" field was missing.");
                      }
                    if (fieldGeneratorScore.have_value)
                      {
                        result.setScoreText(fieldGeneratorScore.value);
                        fieldGeneratorScore.have_value = false;
                      }
                    else if ((!(result.hasScore())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Score\" field was missing.");
                      }
                    if (fieldGeneratorStartMillisecond.have_value)
                      {
                        result.setStartMillisecond(fieldGeneratorStartMillisecond.value);
                        fieldGeneratorStartMillisecond.have_value = false;
                      }
                    if (fieldGeneratorEndMillisecond.have_value)
                      {
                        result.setEndMillisecond(fieldGeneratorEndMillisecond.value);
                        fieldGeneratorEndMillisecond.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeOutgoingTransitionsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 1, "estinationID", 0, 12, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorDestinationID;
                            break;
                        case 'E':
                            if ((String.Compare(field_name, 1, "ndMillisecond", 0, 13, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorEndMillisecond;
                            break;
                        case 'S':
                            switch (field_name[1])
                              {
                                case 'c':
                                    if ((String.Compare(field_name, 2, "ore", 0, 3, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorScore;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 2, "artMillisecond", 0, 14, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorStartMillisecond;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "oken", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorToken;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorDestinationID = new FieldHoldingGeneratorDestinationID("field \"DestinationID\" of the TypeOutgoingTransitions class");
                    fieldGeneratorToken = new JSONHoldingStringGenerator("field \"Token\" of the TypeOutgoingTransitions class");
                    fieldGeneratorScore = new JSONHoldingNumberTextGenerator("field \"Score\" of the TypeOutgoingTransitions class");
                    fieldGeneratorStartMillisecond = new FieldHoldingGeneratorStartMillisecond("field \"StartMillisecond\" of the TypeOutgoingTransitions class");
                    fieldGeneratorEndMillisecond = new FieldHoldingGeneratorEndMillisecond("field \"EndMillisecond\" of the TypeOutgoingTransitions class");
                    set_what("the TypeOutgoingTransitions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorDestinationID = new FieldHoldingGeneratorDestinationID("field \"DestinationID\" of the TypeOutgoingTransitions class");
                    fieldGeneratorToken = new JSONHoldingStringGenerator("field \"Token\" of the TypeOutgoingTransitions class");
                    fieldGeneratorScore = new JSONHoldingNumberTextGenerator("field \"Score\" of the TypeOutgoingTransitions class");
                    fieldGeneratorStartMillisecond = new FieldHoldingGeneratorStartMillisecond("field \"StartMillisecond\" of the TypeOutgoingTransitions class");
                    fieldGeneratorEndMillisecond = new FieldHoldingGeneratorEndMillisecond("field \"EndMillisecond\" of the TypeOutgoingTransitions class");
                    set_what("the TypeOutgoingTransitions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorDestinationID.reset();
                    fieldGeneratorToken.reset();
                    fieldGeneratorScore.reset();
                    fieldGeneratorStartMillisecond.reset();
                    fieldGeneratorEndMillisecond.reset();
                    base.reset();
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
                protected override void handle_result(TypeOutgoingTransitionsJSON  result)
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
                public TypeOutgoingTransitionsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeOutgoingTransitionsJSON  result)
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
            protected virtual void handle_result(List<TypeOutgoingTransitionsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeOutgoingTransitionsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeOutgoingTransitionsJSON>();
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
            public List<TypeOutgoingTransitionsJSON> value;
          };
          };
        private bool flagHasNodeID;
        private BigInteger storeNodeID;
        private bool flagHasOutgoingTransitions;
        private List< TypeOutgoingTransitionsJSON  > storeOutgoingTransitions;


        private void  fromJSONNodeID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NodeID of TypeTranscriptionLatticeJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NodeID of TypeTranscriptionLatticeJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNodeID(extracted_integer);
          }


        private void  fromJSONOutgoingTransitions(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field OutgoingTransitions of TypeTranscriptionLatticeJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeOutgoingTransitionsJSON  > vector_OutgoingTransitions1 = new List< TypeOutgoingTransitionsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeOutgoingTransitionsJSON convert_classy = TypeOutgoingTransitionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_OutgoingTransitions1.Add(convert_classy);
              }
            initOutgoingTransitions();
            for (int num2 = 0; num2 < vector_OutgoingTransitions1.Count; ++num2)
                appendOutgoingTransitions(vector_OutgoingTransitions1[num2]);
            for (int num1 = 0; num1 < vector_OutgoingTransitions1.Count; ++num1)
              {
              }
          }


        public TypeTranscriptionLatticeJSON()
          {
            flagHasNodeID = false;
            flagHasOutgoingTransitions = false;
            storeOutgoingTransitions = new List< TypeOutgoingTransitionsJSON  >();
          }

        public bool  hasNodeID()
          {
            return flagHasNodeID;
          }

        public BigInteger  getNodeID()
          {
            Debug.Assert(flagHasNodeID);
            return storeNodeID;
          }

        public bool  hasOutgoingTransitions()
          {
            return flagHasOutgoingTransitions;
          }

        public int  countOfOutgoingTransitions()
          {
            Debug.Assert(flagHasOutgoingTransitions);
            return storeOutgoingTransitions.Count;
          }

        public TypeOutgoingTransitionsJSON   elementOfOutgoingTransitions(int element_num)
          {
            Debug.Assert(flagHasOutgoingTransitions);
            return storeOutgoingTransitions[element_num];
          }

        public List< TypeOutgoingTransitionsJSON  >  getOutgoingTransitions()
          {
            Debug.Assert(flagHasOutgoingTransitions);
            return storeOutgoingTransitions;
          }



        public void setNodeID(BigInteger new_value)
          {
            flagHasNodeID = true;
            if (new_value < 0)
                throw new Exception("The value for field NodeID of TypeTranscriptionLatticeJSON is less than the lower bound (0) for that field.");
            storeNodeID = new_value;
          }
        public void unsetNodeID()
          {
            flagHasNodeID = false;
          }
        public void initOutgoingTransitions()
          {
            if (flagHasOutgoingTransitions)
              {
                for (int num3 = 0; num3 < storeOutgoingTransitions.Count; ++num3)
                  {
                  }
              }
            flagHasOutgoingTransitions = true;
            storeOutgoingTransitions.Clear();
          }
        public void appendOutgoingTransitions(TypeOutgoingTransitionsJSON  to_append)
          {
            if (!flagHasOutgoingTransitions)
              {
                flagHasOutgoingTransitions = true;
                storeOutgoingTransitions.Clear();
              }
            Debug.Assert(flagHasOutgoingTransitions);
            storeOutgoingTransitions.Add(to_append);
          }
        public void unsetOutgoingTransitions()
          {
            if (flagHasOutgoingTransitions)
              {
                for (int num4 = 0; num4 < storeOutgoingTransitions.Count; ++num4)
                  {
                  }
              }
            flagHasOutgoingTransitions = false;
            storeOutgoingTransitions.Clear();
          }


        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasNodeID);
            if (flagHasNodeID)
              {
                handler.start_pair("NodeID");
                handler.number_value(storeNodeID);
              }
            if (flagHasOutgoingTransitions)
              {
                handler.start_pair("OutgoingTransitions");
                handler.start_array();
                for (int num1 = 0; num1 < storeOutgoingTransitions.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeOutgoingTransitions[num1].write_partial_as_json(handler);
                    else
                        storeOutgoingTransitions[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasNodeID()))
              {
                return "When parsing the object for %what%, the \"NodeID\" field was missing.";
              }
            return null;
          }

        public static TypeTranscriptionLatticeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTranscriptionLatticeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTranscriptionLattice", ignore_extras);
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
        public static TypeTranscriptionLatticeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTranscriptionLatticeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTranscriptionLatticeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTranscriptionLattice", ignore_extras);
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
        public static TypeTranscriptionLatticeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTranscriptionLatticeJSON from_text(string text, bool ignore_extras)
          {
            TypeTranscriptionLatticeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTranscriptionLattice", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTranscriptionLatticeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTranscriptionLatticeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTranscriptionLatticeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTranscriptionLattice", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorNodeID : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNodeID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNodeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNodeID(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorNodeID fieldGeneratorNodeID;
            private TypeOutgoingTransitionsJSON.HoldingArrayGenerator fieldGeneratorOutgoingTransitions;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeTranscriptionLatticeJSON result = new TypeTranscriptionLatticeJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeTranscriptionLatticeJSON result)
              {
                if (fieldGeneratorNodeID.have_value)
                  {
                    result.setNodeID(fieldGeneratorNodeID.value);
                    fieldGeneratorNodeID.have_value = false;
                  }
                else if ((!(result.hasNodeID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NodeID\" field was missing.");
                  }
                if (fieldGeneratorOutgoingTransitions.have_value)
                  {
                    result.initOutgoingTransitions();
                    int count = fieldGeneratorOutgoingTransitions.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendOutgoingTransitions(fieldGeneratorOutgoingTransitions.value[num]);
                      }
                    fieldGeneratorOutgoingTransitions.value.Clear();
                    fieldGeneratorOutgoingTransitions.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeTranscriptionLatticeJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'N':
                        if ((String.Compare(field_name, 1, "odeID", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorNodeID;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "utgoingTransitions", 0, 18, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorOutgoingTransitions;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorNodeID = new FieldHoldingGeneratorNodeID("field \"NodeID\" of the TypeTranscriptionLattice class");
                fieldGeneratorOutgoingTransitions = new TypeOutgoingTransitionsJSON.HoldingArrayGenerator("field \"OutgoingTransitions\" of the TypeTranscriptionLattice class", ignore_extras);
                set_what("the TypeTranscriptionLattice class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorNodeID = new FieldHoldingGeneratorNodeID("field \"NodeID\" of the TypeTranscriptionLattice class");
                fieldGeneratorOutgoingTransitions = new TypeOutgoingTransitionsJSON.HoldingArrayGenerator("field \"OutgoingTransitions\" of the TypeTranscriptionLattice class", false);
                set_what("the TypeTranscriptionLattice class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorNodeID.reset();
                fieldGeneratorOutgoingTransitions.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorOutgoingTransitions.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorOutgoingTransitions.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeTranscriptionLatticeJSON  result)
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
            public TypeTranscriptionLatticeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTranscriptionLatticeJSON  result)
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
        protected virtual void handle_result(List<TypeTranscriptionLatticeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTranscriptionLatticeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTranscriptionLatticeJSON>();
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
        public List<TypeTranscriptionLatticeJSON> value;
      };
      };
    public enum TypeLocalOrRemote
      {
        LocalOrRemote_Local,
        LocalOrRemote_Remote
      };

    public static TypeLocalOrRemote  stringToLocalOrRemote(string chars)
      {
        switch (chars[0])
          {
            case 'L':
                if ((String.Compare(chars, 1, "ocal", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeLocalOrRemote.LocalOrRemote_Local;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "emote", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeLocalOrRemote.LocalOrRemote_Remote;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `LocalOrRemote' is not one of the legal values.");
      }

    public static string  stringFromLocalOrRemote(TypeLocalOrRemote the_enum)
      {
        switch (the_enum)
          {
            case TypeLocalOrRemote.LocalOrRemote_Local:
                return "Local";
            case TypeLocalOrRemote.LocalOrRemote_Remote:
                return "Remote";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFormat;
    private TypeFormat storeFormat;
    private bool flagHasFormatVersion;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private bool flagHasNumToReturn;
    private BigInteger storeNumToReturn;
    private bool flagHasAllResults;
    private List< CommandResultJSON  > storeAllResults;
    private bool flagHasDisambiguation;
    private TypeDisambiguationJSON  storeDisambiguation;
    private bool flagHasResultsAreFinal;
    private List< bool > storeResultsAreFinal;
    private bool flagHasASRUsage;
    private List< TypeASRUsageJSON  > storeASRUsage;
    private bool flagHasDomainUsage;
    private List< TypeDomainUsageJSON  > storeDomainUsage;
    private bool flagHasTranscriptionLattice;
    private List< TypeTranscriptionLatticeJSON  > storeTranscriptionLattice;
    private bool flagHasBuildInfo;
    private BuildInfoJSON  storeBuildInfo;
    private bool flagHasQueryID;
    private string storeQueryID;
    private bool flagHasServerGeneratedId;
    private string storeServerGeneratedId;
    private bool flagHasAudioLength;
    private double storeAudioLength;
    private string textStoreAudioLength;
    private bool flagHasRealSpeechTime;
    private double storeRealSpeechTime;
    private string textStoreRealSpeechTime;
    private bool flagHasCpuSpeechTime;
    private double storeCpuSpeechTime;
    private string textStoreCpuSpeechTime;
    private bool flagHasRealTime;
    private double storeRealTime;
    private string textStoreRealTime;
    private bool flagHasCpuTime;
    private double storeCpuTime;
    private string textStoreCpuTime;
    private bool flagHasLocalOrRemote;
    private TypeLocalOrRemote storeLocalOrRemote;
    private bool flagHasLocalOrRemoteReason;
    private string storeLocalOrRemoteReason;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Format of HoundServerJSON is not a string.");
        TypeFormat the_enum;
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "oundQueryResult", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_enum = TypeFormat.Format_HoundQueryResult;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "oundHoundVoiceSearchResult", 0, 26, false) == 0) && (json_string.getData().Length == 27))
                      {
                        the_enum = TypeFormat.Format_SoundHoundVoiceSearchResult;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Format of HoundServerJSON is not one of the legal strings.");
      enum_is_done:;
        setFormat(the_enum);
      }


    private void  fromJSONFormatVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FormatVersion of HoundServerJSON is not a string.");
        if (!(json_string.getData().Equals("1.0")))
            throw new Exception("The value for field FormatVersion of HoundServerJSON is not `1.0'.");
        setFormatVersion();
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of HoundServerJSON is not a string.");
        TypeStatus the_enum;
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeStatus.Status_Error;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "K", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeStatus.Status_OK;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Status of HoundServerJSON is not one of the legal strings.");
      enum_is_done:;
        setStatus(the_enum);
      }


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of HoundServerJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    private void  fromJSONNumToReturn(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumToReturn of HoundServerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumToReturn of HoundServerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumToReturn(extracted_integer);
      }


    private void  fromJSONAllResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AllResults of HoundServerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< CommandResultJSON  > vector_AllResults1 = new List< CommandResultJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            CommandResultJSON convert_classy = CommandResultJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AllResults1.Add(convert_classy);
          }
        initAllResults();
        for (int num3 = 0; num3 < vector_AllResults1.Count; ++num3)
            appendAllResults(vector_AllResults1[num3]);
        for (int num1 = 0; num1 < vector_AllResults1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDisambiguation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDisambiguationJSON convert_classy = TypeDisambiguationJSON.from_json(json_value, ignore_extras, true);
        setDisambiguation(convert_classy);
      }


    private void  fromJSONResultsAreFinal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ResultsAreFinal of HoundServerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_ResultsAreFinal1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field ResultsAreFinal of HoundServerJSON is not true for false.");
                  }
              }
            vector_ResultsAreFinal1.Add(the_bool);
          }
        initResultsAreFinal();
        for (int num4 = 0; num4 < vector_ResultsAreFinal1.Count; ++num4)
            appendResultsAreFinal(vector_ResultsAreFinal1[num4]);
        for (int num1 = 0; num1 < vector_ResultsAreFinal1.Count; ++num1)
          {
          }
      }


    private void  fromJSONASRUsage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ASRUsage of HoundServerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeASRUsageJSON  > vector_ASRUsage1 = new List< TypeASRUsageJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeASRUsageJSON convert_classy = TypeASRUsageJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ASRUsage1.Add(convert_classy);
          }
        initASRUsage();
        for (int num5 = 0; num5 < vector_ASRUsage1.Count; ++num5)
            appendASRUsage(vector_ASRUsage1[num5]);
        for (int num1 = 0; num1 < vector_ASRUsage1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDomainUsage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DomainUsage of HoundServerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeDomainUsageJSON  > vector_DomainUsage1 = new List< TypeDomainUsageJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeDomainUsageJSON convert_classy = TypeDomainUsageJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DomainUsage1.Add(convert_classy);
          }
        initDomainUsage();
        for (int num6 = 0; num6 < vector_DomainUsage1.Count; ++num6)
            appendDomainUsage(vector_DomainUsage1[num6]);
        for (int num1 = 0; num1 < vector_DomainUsage1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTranscriptionLattice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TranscriptionLattice of HoundServerJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeTranscriptionLatticeJSON  > vector_TranscriptionLattice1 = new List< TypeTranscriptionLatticeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeTranscriptionLatticeJSON convert_classy = TypeTranscriptionLatticeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TranscriptionLattice1.Add(convert_classy);
          }
        initTranscriptionLattice();
        for (int num7 = 0; num7 < vector_TranscriptionLattice1.Count; ++num7)
            appendTranscriptionLattice(vector_TranscriptionLattice1[num7]);
        for (int num1 = 0; num1 < vector_TranscriptionLattice1.Count; ++num1)
          {
          }
      }


    private void  fromJSONBuildInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BuildInfoJSON convert_classy = BuildInfoJSON.from_json(json_value, ignore_extras, true);
        setBuildInfo(convert_classy);
      }


    private void  fromJSONQueryID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryID of HoundServerJSON is not a string.");
        setQueryID(json_string.getData());
      }


    private void  fromJSONServerGeneratedId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ServerGeneratedId of HoundServerJSON is not a string.");
        setServerGeneratedId(json_string.getData());
      }


    private void  fromJSONAudioLength(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field AudioLength of HoundServerJSON is not a number.");
              }
          }
        setAudioLengthText(the_rational_text);
      }


    private void  fromJSONRealSpeechTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field RealSpeechTime of HoundServerJSON is not a number.");
              }
          }
        setRealSpeechTimeText(the_rational_text);
      }


    private void  fromJSONCpuSpeechTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field CpuSpeechTime of HoundServerJSON is not a number.");
              }
          }
        setCpuSpeechTimeText(the_rational_text);
      }


    private void  fromJSONRealTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field RealTime of HoundServerJSON is not a number.");
              }
          }
        setRealTimeText(the_rational_text);
      }


    private void  fromJSONCpuTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field CpuTime of HoundServerJSON is not a number.");
              }
          }
        setCpuTimeText(the_rational_text);
      }


    private void  fromJSONLocalOrRemote(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalOrRemote of HoundServerJSON is not a string.");
        TypeLocalOrRemote the_enum;
        switch (json_string.getData()[0])
          {
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "ocal", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeLocalOrRemote.LocalOrRemote_Local;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "emote", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeLocalOrRemote.LocalOrRemote_Remote;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field LocalOrRemote of HoundServerJSON is not one of the legal strings.");
      enum_is_done:;
        setLocalOrRemote(the_enum);
      }


    private void  fromJSONLocalOrRemoteReason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LocalOrRemoteReason of HoundServerJSON is not a string.");
        setLocalOrRemoteReason(json_string.getData());
      }


    public HoundServerJSON()
      {
        flagHasFormat = false;
        flagHasFormatVersion = false;
        flagHasStatus = false;
        flagHasErrorMessage = false;
        flagHasNumToReturn = false;
        flagHasAllResults = false;
        flagHasDisambiguation = false;
        flagHasResultsAreFinal = false;
        flagHasASRUsage = false;
        flagHasDomainUsage = false;
        flagHasTranscriptionLattice = false;
        flagHasBuildInfo = false;
        flagHasQueryID = false;
        flagHasServerGeneratedId = false;
        flagHasAudioLength = false;
        flagHasRealSpeechTime = false;
        flagHasCpuSpeechTime = false;
        flagHasRealTime = false;
        flagHasCpuTime = false;
        flagHasLocalOrRemote = false;
        flagHasLocalOrRemoteReason = false;
        storeAllResults = new List< CommandResultJSON  >();
        storeResultsAreFinal = new List< bool >();
        storeASRUsage = new List< TypeASRUsageJSON  >();
        storeDomainUsage = new List< TypeDomainUsageJSON  >();
        storeTranscriptionLattice = new List< TypeTranscriptionLatticeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFormat()
      {
        return flagHasFormat;
      }

    public TypeFormat  getFormat()
      {
        Debug.Assert(flagHasFormat);
        return storeFormat;
      }

    public string  getFormatAsString()
      {
        return stringFromFormat(getFormat());
      }

    public bool  hasFormatVersion()
      {
        return flagHasFormatVersion;
      }

    public TypeFormatVersion  getFormatVersion()
      {
        Debug.Assert(flagHasFormatVersion);
        return TypeFormatVersion.FormatVersion_1_x2e_0;
      }

    public string  getFormatVersionAsString()
      {
        return stringFromFormatVersion(getFormatVersion());
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        return stringFromStatus(getStatus());
      }

    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }

    public bool  hasNumToReturn()
      {
        return flagHasNumToReturn;
      }

    public BigInteger  getNumToReturn()
      {
        Debug.Assert(flagHasNumToReturn);
        return storeNumToReturn;
      }

    public bool  hasAllResults()
      {
        return flagHasAllResults;
      }

    public int  countOfAllResults()
      {
        Debug.Assert(flagHasAllResults);
        return storeAllResults.Count;
      }

    public CommandResultJSON   elementOfAllResults(int element_num)
      {
        Debug.Assert(flagHasAllResults);
        return storeAllResults[element_num];
      }

    public List< CommandResultJSON  >  getAllResults()
      {
        Debug.Assert(flagHasAllResults);
        return storeAllResults;
      }

    public bool  hasDisambiguation()
      {
        return flagHasDisambiguation;
      }

    public TypeDisambiguationJSON   getDisambiguation()
      {
        Debug.Assert(flagHasDisambiguation);
        return storeDisambiguation;
      }

    public bool  hasResultsAreFinal()
      {
        return flagHasResultsAreFinal;
      }

    public int  countOfResultsAreFinal()
      {
        Debug.Assert(flagHasResultsAreFinal);
        return storeResultsAreFinal.Count;
      }

    public bool  elementOfResultsAreFinal(int element_num)
      {
        Debug.Assert(flagHasResultsAreFinal);
        return storeResultsAreFinal[element_num];
      }

    public List< bool >  getResultsAreFinal()
      {
        Debug.Assert(flagHasResultsAreFinal);
        return storeResultsAreFinal;
      }

    public bool  hasASRUsage()
      {
        return flagHasASRUsage;
      }

    public int  countOfASRUsage()
      {
        Debug.Assert(flagHasASRUsage);
        return storeASRUsage.Count;
      }

    public TypeASRUsageJSON   elementOfASRUsage(int element_num)
      {
        Debug.Assert(flagHasASRUsage);
        return storeASRUsage[element_num];
      }

    public List< TypeASRUsageJSON  >  getASRUsage()
      {
        Debug.Assert(flagHasASRUsage);
        return storeASRUsage;
      }

    public bool  hasDomainUsage()
      {
        return flagHasDomainUsage;
      }

    public int  countOfDomainUsage()
      {
        Debug.Assert(flagHasDomainUsage);
        return storeDomainUsage.Count;
      }

    public TypeDomainUsageJSON   elementOfDomainUsage(int element_num)
      {
        Debug.Assert(flagHasDomainUsage);
        return storeDomainUsage[element_num];
      }

    public List< TypeDomainUsageJSON  >  getDomainUsage()
      {
        Debug.Assert(flagHasDomainUsage);
        return storeDomainUsage;
      }

    public bool  hasTranscriptionLattice()
      {
        return flagHasTranscriptionLattice;
      }

    public int  countOfTranscriptionLattice()
      {
        Debug.Assert(flagHasTranscriptionLattice);
        return storeTranscriptionLattice.Count;
      }

    public TypeTranscriptionLatticeJSON   elementOfTranscriptionLattice(int element_num)
      {
        Debug.Assert(flagHasTranscriptionLattice);
        return storeTranscriptionLattice[element_num];
      }

    public List< TypeTranscriptionLatticeJSON  >  getTranscriptionLattice()
      {
        Debug.Assert(flagHasTranscriptionLattice);
        return storeTranscriptionLattice;
      }

    public bool  hasBuildInfo()
      {
        return flagHasBuildInfo;
      }

    public BuildInfoJSON   getBuildInfo()
      {
        Debug.Assert(flagHasBuildInfo);
        return storeBuildInfo;
      }

    public bool  hasQueryID()
      {
        return flagHasQueryID;
      }

    public string  getQueryID()
      {
        Debug.Assert(flagHasQueryID);
        return storeQueryID;
      }

    public bool  hasServerGeneratedId()
      {
        return flagHasServerGeneratedId;
      }

    public string  getServerGeneratedId()
      {
        Debug.Assert(flagHasServerGeneratedId);
        return storeServerGeneratedId;
      }

    public bool  hasAudioLength()
      {
        return flagHasAudioLength;
      }

    public double  getAudioLength()
      {
        Debug.Assert(flagHasAudioLength);
        if (textStoreAudioLength != "")
          {
            return Double.Parse(textStoreAudioLength);
          }
        return storeAudioLength;
      }

    public string  getAudioLengthAsText()
      {
        Debug.Assert(flagHasAudioLength);
        if (textStoreAudioLength == "")
          {
            return Convert.ToString(storeAudioLength);
          }
        else
          {
            return (textStoreAudioLength);
          }
      }

    public bool  hasRealSpeechTime()
      {
        return flagHasRealSpeechTime;
      }

    public double  getRealSpeechTime()
      {
        Debug.Assert(flagHasRealSpeechTime);
        if (textStoreRealSpeechTime != "")
          {
            return Double.Parse(textStoreRealSpeechTime);
          }
        return storeRealSpeechTime;
      }

    public string  getRealSpeechTimeAsText()
      {
        Debug.Assert(flagHasRealSpeechTime);
        if (textStoreRealSpeechTime == "")
          {
            return Convert.ToString(storeRealSpeechTime);
          }
        else
          {
            return (textStoreRealSpeechTime);
          }
      }

    public bool  hasCpuSpeechTime()
      {
        return flagHasCpuSpeechTime;
      }

    public double  getCpuSpeechTime()
      {
        Debug.Assert(flagHasCpuSpeechTime);
        if (textStoreCpuSpeechTime != "")
          {
            return Double.Parse(textStoreCpuSpeechTime);
          }
        return storeCpuSpeechTime;
      }

    public string  getCpuSpeechTimeAsText()
      {
        Debug.Assert(flagHasCpuSpeechTime);
        if (textStoreCpuSpeechTime == "")
          {
            return Convert.ToString(storeCpuSpeechTime);
          }
        else
          {
            return (textStoreCpuSpeechTime);
          }
      }

    public bool  hasRealTime()
      {
        return flagHasRealTime;
      }

    public double  getRealTime()
      {
        Debug.Assert(flagHasRealTime);
        if (textStoreRealTime != "")
          {
            return Double.Parse(textStoreRealTime);
          }
        return storeRealTime;
      }

    public string  getRealTimeAsText()
      {
        Debug.Assert(flagHasRealTime);
        if (textStoreRealTime == "")
          {
            return Convert.ToString(storeRealTime);
          }
        else
          {
            return (textStoreRealTime);
          }
      }

    public bool  hasCpuTime()
      {
        return flagHasCpuTime;
      }

    public double  getCpuTime()
      {
        Debug.Assert(flagHasCpuTime);
        if (textStoreCpuTime != "")
          {
            return Double.Parse(textStoreCpuTime);
          }
        return storeCpuTime;
      }

    public string  getCpuTimeAsText()
      {
        Debug.Assert(flagHasCpuTime);
        if (textStoreCpuTime == "")
          {
            return Convert.ToString(storeCpuTime);
          }
        else
          {
            return (textStoreCpuTime);
          }
      }

    public bool  hasLocalOrRemote()
      {
        return flagHasLocalOrRemote;
      }

    public TypeLocalOrRemote  getLocalOrRemote()
      {
        Debug.Assert(flagHasLocalOrRemote);
        return storeLocalOrRemote;
      }

    public string  getLocalOrRemoteAsString()
      {
        return stringFromLocalOrRemote(getLocalOrRemote());
      }

    public bool  hasLocalOrRemoteReason()
      {
        return flagHasLocalOrRemoteReason;
      }

    public string  getLocalOrRemoteReason()
      {
        Debug.Assert(flagHasLocalOrRemoteReason);
        return storeLocalOrRemoteReason;
      }


    public virtual int extraHoundServerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundServerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundServerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundServerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFormat(TypeFormat new_value)
      {
        flagHasFormat = true;
        storeFormat = new_value;
      }
    public void setFormat(string chars)
      {
        setFormat(stringToFormat(chars));
      }
    public void unsetFormat()
      {
        flagHasFormat = false;
      }
    public void setFormatVersion()
      {
        flagHasFormatVersion = true;
      }
    public void setFormatVersion(TypeFormatVersion new_value)
      {
        setFormatVersion();
      }
    public void setFormatVersion(string chars)
      {
        setFormatVersion(stringToFormatVersion(chars));
      }
    public void unsetFormatVersion()
      {
        flagHasFormatVersion = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        setStatus(stringToStatus(chars));
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }
    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }
    public void setNumToReturn(BigInteger new_value)
      {
        flagHasNumToReturn = true;
        if (new_value < 0)
            throw new Exception("The value for field NumToReturn of HoundServerJSON is less than the lower bound (0) for that field.");
        storeNumToReturn = new_value;
      }
    public void unsetNumToReturn()
      {
        flagHasNumToReturn = false;
      }
    public void initAllResults()
      {
        if (flagHasAllResults)
          {
            for (int num5 = 0; num5 < storeAllResults.Count; ++num5)
              {
              }
          }
        flagHasAllResults = true;
        storeAllResults.Clear();
      }
    public void appendAllResults(CommandResultJSON  to_append)
      {
        if (!flagHasAllResults)
          {
            flagHasAllResults = true;
            storeAllResults.Clear();
          }
        Debug.Assert(flagHasAllResults);
        storeAllResults.Add(to_append);
      }
    public void unsetAllResults()
      {
        if (flagHasAllResults)
          {
            for (int num6 = 0; num6 < storeAllResults.Count; ++num6)
              {
              }
          }
        flagHasAllResults = false;
        storeAllResults.Clear();
      }
    public void setDisambiguation(TypeDisambiguationJSON  new_value)
      {
        if (flagHasDisambiguation)
          {
          }
        flagHasDisambiguation = true;
        storeDisambiguation = new_value;
      }
    public void unsetDisambiguation()
      {
        if (flagHasDisambiguation)
          {
          }
        flagHasDisambiguation = false;
      }
    public void initResultsAreFinal()
      {
        flagHasResultsAreFinal = true;
        storeResultsAreFinal.Clear();
      }
    public void appendResultsAreFinal(bool to_append)
      {
        if (!flagHasResultsAreFinal)
          {
            flagHasResultsAreFinal = true;
            storeResultsAreFinal.Clear();
          }
        Debug.Assert(flagHasResultsAreFinal);
        storeResultsAreFinal.Add(to_append);
      }
    public void unsetResultsAreFinal()
      {
        flagHasResultsAreFinal = false;
        storeResultsAreFinal.Clear();
      }
    public void initASRUsage()
      {
        if (flagHasASRUsage)
          {
            for (int num7 = 0; num7 < storeASRUsage.Count; ++num7)
              {
              }
          }
        flagHasASRUsage = true;
        storeASRUsage.Clear();
      }
    public void appendASRUsage(TypeASRUsageJSON  to_append)
      {
        if (!flagHasASRUsage)
          {
            flagHasASRUsage = true;
            storeASRUsage.Clear();
          }
        Debug.Assert(flagHasASRUsage);
        storeASRUsage.Add(to_append);
      }
    public void unsetASRUsage()
      {
        if (flagHasASRUsage)
          {
            for (int num8 = 0; num8 < storeASRUsage.Count; ++num8)
              {
              }
          }
        flagHasASRUsage = false;
        storeASRUsage.Clear();
      }
    public void initDomainUsage()
      {
        if (flagHasDomainUsage)
          {
            for (int num9 = 0; num9 < storeDomainUsage.Count; ++num9)
              {
              }
          }
        flagHasDomainUsage = true;
        storeDomainUsage.Clear();
      }
    public void appendDomainUsage(TypeDomainUsageJSON  to_append)
      {
        if (!flagHasDomainUsage)
          {
            flagHasDomainUsage = true;
            storeDomainUsage.Clear();
          }
        Debug.Assert(flagHasDomainUsage);
        storeDomainUsage.Add(to_append);
      }
    public void unsetDomainUsage()
      {
        if (flagHasDomainUsage)
          {
            for (int num10 = 0; num10 < storeDomainUsage.Count; ++num10)
              {
              }
          }
        flagHasDomainUsage = false;
        storeDomainUsage.Clear();
      }
    public void initTranscriptionLattice()
      {
        if (flagHasTranscriptionLattice)
          {
            for (int num11 = 0; num11 < storeTranscriptionLattice.Count; ++num11)
              {
              }
          }
        flagHasTranscriptionLattice = true;
        storeTranscriptionLattice.Clear();
      }
    public void appendTranscriptionLattice(TypeTranscriptionLatticeJSON  to_append)
      {
        if (!flagHasTranscriptionLattice)
          {
            flagHasTranscriptionLattice = true;
            storeTranscriptionLattice.Clear();
          }
        Debug.Assert(flagHasTranscriptionLattice);
        storeTranscriptionLattice.Add(to_append);
      }
    public void unsetTranscriptionLattice()
      {
        if (flagHasTranscriptionLattice)
          {
            for (int num12 = 0; num12 < storeTranscriptionLattice.Count; ++num12)
              {
              }
          }
        flagHasTranscriptionLattice = false;
        storeTranscriptionLattice.Clear();
      }
    public void setBuildInfo(BuildInfoJSON  new_value)
      {
        if (flagHasBuildInfo)
          {
          }
        flagHasBuildInfo = true;
        storeBuildInfo = new_value;
      }
    public void unsetBuildInfo()
      {
        if (flagHasBuildInfo)
          {
          }
        flagHasBuildInfo = false;
      }
    public void setQueryID(string new_value)
      {
        flagHasQueryID = true;
        storeQueryID = new_value;
      }
    public void unsetQueryID()
      {
        flagHasQueryID = false;
      }
    public void setServerGeneratedId(string new_value)
      {
        flagHasServerGeneratedId = true;
        storeServerGeneratedId = new_value;
      }
    public void unsetServerGeneratedId()
      {
        flagHasServerGeneratedId = false;
      }
    public void setAudioLength(double new_value)
      {
        flagHasAudioLength = true;
        if (new_value < 0)
            throw new Exception("The value for field AudioLength of HoundServerJSON is less than the lower bound (0) for that field.");
        storeAudioLength = new_value;
        textStoreAudioLength = "";
      }
    public void setAudioLengthText(string new_value)
      {
        flagHasAudioLength = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field AudioLength of HoundServerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field AudioLength of HoundServerJSON is less than the lower bound (0) for that field.");
        textStoreAudioLength = new_value;
      }
    public void unsetAudioLength()
      {
        flagHasAudioLength = false;
      }
    public void setRealSpeechTime(double new_value)
      {
        flagHasRealSpeechTime = true;
        if (new_value < 0)
            throw new Exception("The value for field RealSpeechTime of HoundServerJSON is less than the lower bound (0) for that field.");
        storeRealSpeechTime = new_value;
        textStoreRealSpeechTime = "";
      }
    public void setRealSpeechTimeText(string new_value)
      {
        flagHasRealSpeechTime = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RealSpeechTime of HoundServerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field RealSpeechTime of HoundServerJSON is less than the lower bound (0) for that field.");
        textStoreRealSpeechTime = new_value;
      }
    public void unsetRealSpeechTime()
      {
        flagHasRealSpeechTime = false;
      }
    public void setCpuSpeechTime(double new_value)
      {
        flagHasCpuSpeechTime = true;
        if (new_value < 0)
            throw new Exception("The value for field CpuSpeechTime of HoundServerJSON is less than the lower bound (0) for that field.");
        storeCpuSpeechTime = new_value;
        textStoreCpuSpeechTime = "";
      }
    public void setCpuSpeechTimeText(string new_value)
      {
        flagHasCpuSpeechTime = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CpuSpeechTime of HoundServerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field CpuSpeechTime of HoundServerJSON is less than the lower bound (0) for that field.");
        textStoreCpuSpeechTime = new_value;
      }
    public void unsetCpuSpeechTime()
      {
        flagHasCpuSpeechTime = false;
      }
    public void setRealTime(double new_value)
      {
        flagHasRealTime = true;
        if (new_value < 0)
            throw new Exception("The value for field RealTime of HoundServerJSON is less than the lower bound (0) for that field.");
        storeRealTime = new_value;
        textStoreRealTime = "";
      }
    public void setRealTimeText(string new_value)
      {
        flagHasRealTime = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field RealTime of HoundServerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field RealTime of HoundServerJSON is less than the lower bound (0) for that field.");
        textStoreRealTime = new_value;
      }
    public void unsetRealTime()
      {
        flagHasRealTime = false;
      }
    public void setCpuTime(double new_value)
      {
        flagHasCpuTime = true;
        if (new_value < 0)
            throw new Exception("The value for field CpuTime of HoundServerJSON is less than the lower bound (0) for that field.");
        storeCpuTime = new_value;
        textStoreCpuTime = "";
      }
    public void setCpuTimeText(string new_value)
      {
        flagHasCpuTime = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CpuTime of HoundServerJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field CpuTime of HoundServerJSON is less than the lower bound (0) for that field.");
        textStoreCpuTime = new_value;
      }
    public void unsetCpuTime()
      {
        flagHasCpuTime = false;
      }
    public void setLocalOrRemote(TypeLocalOrRemote new_value)
      {
        flagHasLocalOrRemote = true;
        storeLocalOrRemote = new_value;
      }
    public void setLocalOrRemote(string chars)
      {
        setLocalOrRemote(stringToLocalOrRemote(chars));
      }
    public void unsetLocalOrRemote()
      {
        flagHasLocalOrRemote = false;
      }
    public void setLocalOrRemoteReason(string new_value)
      {
        flagHasLocalOrRemoteReason = true;
        storeLocalOrRemoteReason = new_value;
      }
    public void unsetLocalOrRemoteReason()
      {
        flagHasLocalOrRemoteReason = false;
      }

    public virtual void extraHoundServerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundServerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundServerLookup(key);
        if (old_field == null)
          {
            extraHoundServerAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFormat);
        if (flagHasFormat)
          {
            handler.start_pair("Format");
            switch (storeFormat)
              {
                case TypeFormat.Format_SoundHoundVoiceSearchResult:
                    handler.string_value("SoundHoundVoiceSearchResult");
                    break;
                case TypeFormat.Format_HoundQueryResult:
                    handler.string_value("HoundQueryResult");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasFormatVersion);
        if (flagHasFormatVersion)
          {
            handler.start_pair("FormatVersion");
            handler.string_value("1.0");
          }
        Debug.Assert(partial_allowed || flagHasStatus);
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            switch (storeStatus)
              {
                case TypeStatus.Status_OK:
                    handler.string_value("OK");
                    break;
                case TypeStatus.Status_Error:
                    handler.string_value("Error");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
          }
        if (flagHasNumToReturn)
          {
            handler.start_pair("NumToReturn");
            handler.number_value(storeNumToReturn);
          }
        if (flagHasAllResults)
          {
            handler.start_pair("AllResults");
            handler.start_array();
            for (int num1 = 0; num1 < storeAllResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeAllResults[num1].write_partial_as_json(handler);
                else
                    storeAllResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDisambiguation)
          {
            handler.start_pair("Disambiguation");
            if (partial_allowed)
                storeDisambiguation.write_partial_as_json(handler);
            else
                storeDisambiguation.write_as_json(handler);
          }
        if (flagHasResultsAreFinal)
          {
            handler.start_pair("ResultsAreFinal");
            handler.start_array();
            for (int num2 = 0; num2 < storeResultsAreFinal.Count; ++num2)
              {
                handler.boolean_value(storeResultsAreFinal[num2]);
              }
            handler.finish_array();
          }
        if (flagHasASRUsage)
          {
            handler.start_pair("ASRUsage");
            handler.start_array();
            for (int num3 = 0; num3 < storeASRUsage.Count; ++num3)
              {
                if (partial_allowed)
                    storeASRUsage[num3].write_partial_as_json(handler);
                else
                    storeASRUsage[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasDomainUsage);
        if (flagHasDomainUsage)
          {
            handler.start_pair("DomainUsage");
            handler.start_array();
            for (int num4 = 0; num4 < storeDomainUsage.Count; ++num4)
              {
                if (partial_allowed)
                    storeDomainUsage[num4].write_partial_as_json(handler);
                else
                    storeDomainUsage[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTranscriptionLattice)
          {
            handler.start_pair("TranscriptionLattice");
            handler.start_array();
            for (int num5 = 0; num5 < storeTranscriptionLattice.Count; ++num5)
              {
                if (partial_allowed)
                    storeTranscriptionLattice[num5].write_partial_as_json(handler);
                else
                    storeTranscriptionLattice[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasBuildInfo)
          {
            handler.start_pair("BuildInfo");
            if (partial_allowed)
                storeBuildInfo.write_partial_as_json(handler);
            else
                storeBuildInfo.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasQueryID);
        if (flagHasQueryID)
          {
            handler.start_pair("QueryID");
            handler.string_value(storeQueryID);
          }
        if (flagHasServerGeneratedId)
          {
            handler.start_pair("ServerGeneratedId");
            handler.string_value(storeServerGeneratedId);
          }
        if (flagHasAudioLength)
          {
            handler.start_pair("AudioLength");
            if (textStoreAudioLength != "")
                handler.number_value(textStoreAudioLength);
            else if (((double)(long)storeAudioLength) == storeAudioLength)
                handler.number_value((long)storeAudioLength);
            else
                handler.number_value(storeAudioLength);
          }
        if (flagHasRealSpeechTime)
          {
            handler.start_pair("RealSpeechTime");
            if (textStoreRealSpeechTime != "")
                handler.number_value(textStoreRealSpeechTime);
            else if (((double)(long)storeRealSpeechTime) == storeRealSpeechTime)
                handler.number_value((long)storeRealSpeechTime);
            else
                handler.number_value(storeRealSpeechTime);
          }
        if (flagHasCpuSpeechTime)
          {
            handler.start_pair("CpuSpeechTime");
            if (textStoreCpuSpeechTime != "")
                handler.number_value(textStoreCpuSpeechTime);
            else if (((double)(long)storeCpuSpeechTime) == storeCpuSpeechTime)
                handler.number_value((long)storeCpuSpeechTime);
            else
                handler.number_value(storeCpuSpeechTime);
          }
        if (flagHasRealTime)
          {
            handler.start_pair("RealTime");
            if (textStoreRealTime != "")
                handler.number_value(textStoreRealTime);
            else if (((double)(long)storeRealTime) == storeRealTime)
                handler.number_value((long)storeRealTime);
            else
                handler.number_value(storeRealTime);
          }
        if (flagHasCpuTime)
          {
            handler.start_pair("CpuTime");
            if (textStoreCpuTime != "")
                handler.number_value(textStoreCpuTime);
            else if (((double)(long)storeCpuTime) == storeCpuTime)
                handler.number_value((long)storeCpuTime);
            else
                handler.number_value(storeCpuTime);
          }
        if (flagHasLocalOrRemote)
          {
            handler.start_pair("LocalOrRemote");
            switch (storeLocalOrRemote)
              {
                case TypeLocalOrRemote.LocalOrRemote_Local:
                    handler.string_value("Local");
                    break;
                case TypeLocalOrRemote.LocalOrRemote_Remote:
                    handler.string_value("Remote");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasLocalOrRemoteReason)
          {
            handler.start_pair("LocalOrRemoteReason");
            handler.string_value(storeLocalOrRemoteReason);
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
        if (!(hasFormat()))
          {
            return "When parsing the object for %what%, the \"Format\" field was missing.";
          }
        if (!(hasFormatVersion()))
          {
            return "When parsing the object for %what%, the \"FormatVersion\" field was missing.";
          }
        if (!(hasStatus()))
          {
            return "When parsing the object for %what%, the \"Status\" field was missing.";
          }
        if (!(hasDomainUsage()))
          {
            return "When parsing the object for %what%, the \"DomainUsage\" field was missing.";
          }
        if (!(hasQueryID()))
          {
            return "When parsing the object for %what%, the \"QueryID\" field was missing.";
          }
        return null;
      }

    public static HoundServerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundServerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundServer", ignore_extras);
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
    public static HoundServerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundServerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundServerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundServer", ignore_extras);
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
    public static HoundServerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundServerJSON from_text(string text, bool ignore_extras)
      {
        HoundServerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundServer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundServerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundServerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundServerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundServer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFormat : JSONStringGenerator
          {
            protected FieldGeneratorFormat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormat()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormat(result));
              }
            protected abstract void handle_result(TypeFormat result);
          };
    private class FieldHoldingGeneratorFormat : FieldGeneratorFormat
  {
    protected override void handle_result(TypeFormat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormat(String what)
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
    public TypeFormat value;
  };
    private class FieldHoldingArrayGeneratorFormat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormat
      {
        private FieldHoldingArrayGeneratorFormat top;

        protected override void handle_result(TypeFormat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormat init_top)
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
    protected virtual void handle_result(List<TypeFormat> result)
      {
      }

    public FieldHoldingArrayGeneratorFormat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormat> value;
  };
        private FieldHoldingGeneratorFormat fieldGeneratorFormat;
    private abstract class FieldGeneratorFormatVersion : JSONStringGenerator
          {
            protected FieldGeneratorFormatVersion(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFormatVersion()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFormatVersion(result));
              }
            protected abstract void handle_result(TypeFormatVersion result);
          };
    private class FieldHoldingGeneratorFormatVersion : FieldGeneratorFormatVersion
  {
    protected override void handle_result(TypeFormatVersion result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFormatVersion(String what)
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
    public TypeFormatVersion value;
  };
    private class FieldHoldingArrayGeneratorFormatVersion : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFormatVersion
      {
        private FieldHoldingArrayGeneratorFormatVersion top;

        protected override void handle_result(TypeFormatVersion result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFormatVersion init_top)
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
    protected virtual void handle_result(List<TypeFormatVersion> result)
      {
      }

    public FieldHoldingArrayGeneratorFormatVersion(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFormatVersion()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFormatVersion>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFormatVersion> value;
  };
        private FieldHoldingGeneratorFormatVersion fieldGeneratorFormatVersion;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToStatus(result));
              }
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
    private class FieldHoldingGeneratorNumToReturn : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumToReturn(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumToReturn : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumToReturn(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumToReturn fieldGeneratorNumToReturn;
        private CommandResultJSON.HoldingArrayGenerator fieldGeneratorAllResults;
        private TypeDisambiguationJSON.HoldingGenerator fieldGeneratorDisambiguation;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorResultsAreFinal;
        private TypeASRUsageJSON.HoldingArrayGenerator fieldGeneratorASRUsage;
        private TypeDomainUsageJSON.HoldingArrayGenerator fieldGeneratorDomainUsage;
        private TypeTranscriptionLatticeJSON.HoldingArrayGenerator fieldGeneratorTranscriptionLattice;
        private BuildInfoJSON.HoldingGenerator fieldGeneratorBuildInfo;
        private JSONHoldingStringGenerator fieldGeneratorQueryID;
        private JSONHoldingStringGenerator fieldGeneratorServerGeneratedId;
        private JSONHoldingNumberTextGenerator fieldGeneratorAudioLength;
        private JSONHoldingNumberTextGenerator fieldGeneratorRealSpeechTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorCpuSpeechTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorRealTime;
        private JSONHoldingNumberTextGenerator fieldGeneratorCpuTime;
    private abstract class FieldGeneratorLocalOrRemote : JSONStringGenerator
          {
            protected FieldGeneratorLocalOrRemote(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLocalOrRemote()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLocalOrRemote(result));
              }
            protected abstract void handle_result(TypeLocalOrRemote result);
          };
    private class FieldHoldingGeneratorLocalOrRemote : FieldGeneratorLocalOrRemote
  {
    protected override void handle_result(TypeLocalOrRemote result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLocalOrRemote(String what)
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
    public TypeLocalOrRemote value;
  };
    private class FieldHoldingArrayGeneratorLocalOrRemote : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLocalOrRemote
      {
        private FieldHoldingArrayGeneratorLocalOrRemote top;

        protected override void handle_result(TypeLocalOrRemote result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLocalOrRemote init_top)
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
    protected virtual void handle_result(List<TypeLocalOrRemote> result)
      {
      }

    public FieldHoldingArrayGeneratorLocalOrRemote(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalOrRemote>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLocalOrRemote()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLocalOrRemote>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLocalOrRemote> value;
  };
        private FieldHoldingGeneratorLocalOrRemote fieldGeneratorLocalOrRemote;
        private JSONHoldingStringGenerator fieldGeneratorLocalOrRemoteReason;
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
            HoundServerJSON result = new HoundServerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundServerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HoundServerJSON result)
          {
            if (fieldGeneratorFormat.have_value)
              {
                result.setFormat(fieldGeneratorFormat.value);
                fieldGeneratorFormat.have_value = false;
              }
            else if ((!(result.hasFormat())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Format\" field was missing.");
              }
            if (fieldGeneratorFormatVersion.have_value)
              {
                result.setFormatVersion();
                fieldGeneratorFormatVersion.have_value = false;
              }
            else if ((!(result.hasFormatVersion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FormatVersion\" field was missing.");
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            else if ((!(result.hasStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Status\" field was missing.");
              }
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            if (fieldGeneratorNumToReturn.have_value)
              {
                result.setNumToReturn(fieldGeneratorNumToReturn.value);
                fieldGeneratorNumToReturn.have_value = false;
              }
            if (fieldGeneratorAllResults.have_value)
              {
                result.initAllResults();
                int count = fieldGeneratorAllResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAllResults(fieldGeneratorAllResults.value[num]);
                  }
                fieldGeneratorAllResults.value.Clear();
                fieldGeneratorAllResults.have_value = false;
              }
            if (fieldGeneratorDisambiguation.have_value)
              {
                result.setDisambiguation(fieldGeneratorDisambiguation.value);
                fieldGeneratorDisambiguation.have_value = false;
              }
            if (fieldGeneratorResultsAreFinal.have_value)
              {
                result.initResultsAreFinal();
                int count = fieldGeneratorResultsAreFinal.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResultsAreFinal(fieldGeneratorResultsAreFinal.value[num]);
                  }
                fieldGeneratorResultsAreFinal.value.Clear();
                fieldGeneratorResultsAreFinal.have_value = false;
              }
            if (fieldGeneratorASRUsage.have_value)
              {
                result.initASRUsage();
                int count = fieldGeneratorASRUsage.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendASRUsage(fieldGeneratorASRUsage.value[num]);
                  }
                fieldGeneratorASRUsage.value.Clear();
                fieldGeneratorASRUsage.have_value = false;
              }
            if (fieldGeneratorDomainUsage.have_value)
              {
                result.initDomainUsage();
                int count = fieldGeneratorDomainUsage.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDomainUsage(fieldGeneratorDomainUsage.value[num]);
                  }
                fieldGeneratorDomainUsage.value.Clear();
                fieldGeneratorDomainUsage.have_value = false;
              }
            else if ((!(result.hasDomainUsage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DomainUsage\" field was missing.");
              }
            if (fieldGeneratorTranscriptionLattice.have_value)
              {
                result.initTranscriptionLattice();
                int count = fieldGeneratorTranscriptionLattice.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTranscriptionLattice(fieldGeneratorTranscriptionLattice.value[num]);
                  }
                fieldGeneratorTranscriptionLattice.value.Clear();
                fieldGeneratorTranscriptionLattice.have_value = false;
              }
            if (fieldGeneratorBuildInfo.have_value)
              {
                result.setBuildInfo(fieldGeneratorBuildInfo.value);
                fieldGeneratorBuildInfo.have_value = false;
              }
            if (fieldGeneratorQueryID.have_value)
              {
                result.setQueryID(fieldGeneratorQueryID.value);
                fieldGeneratorQueryID.have_value = false;
              }
            else if ((!(result.hasQueryID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryID\" field was missing.");
              }
            if (fieldGeneratorServerGeneratedId.have_value)
              {
                result.setServerGeneratedId(fieldGeneratorServerGeneratedId.value);
                fieldGeneratorServerGeneratedId.have_value = false;
              }
            if (fieldGeneratorAudioLength.have_value)
              {
                result.setAudioLengthText(fieldGeneratorAudioLength.value);
                fieldGeneratorAudioLength.have_value = false;
              }
            if (fieldGeneratorRealSpeechTime.have_value)
              {
                result.setRealSpeechTimeText(fieldGeneratorRealSpeechTime.value);
                fieldGeneratorRealSpeechTime.have_value = false;
              }
            if (fieldGeneratorCpuSpeechTime.have_value)
              {
                result.setCpuSpeechTimeText(fieldGeneratorCpuSpeechTime.value);
                fieldGeneratorCpuSpeechTime.have_value = false;
              }
            if (fieldGeneratorRealTime.have_value)
              {
                result.setRealTimeText(fieldGeneratorRealTime.value);
                fieldGeneratorRealTime.have_value = false;
              }
            if (fieldGeneratorCpuTime.have_value)
              {
                result.setCpuTimeText(fieldGeneratorCpuTime.value);
                fieldGeneratorCpuTime.have_value = false;
              }
            if (fieldGeneratorLocalOrRemote.have_value)
              {
                result.setLocalOrRemote(fieldGeneratorLocalOrRemote.value);
                fieldGeneratorLocalOrRemote.have_value = false;
              }
            if (fieldGeneratorLocalOrRemoteReason.have_value)
              {
                result.setLocalOrRemoteReason(fieldGeneratorLocalOrRemoteReason.value);
                fieldGeneratorLocalOrRemoteReason.have_value = false;
              }
          }
        protected abstract void handle_result(HoundServerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 2, "RUsage", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorASRUsage;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "lResults", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorAllResults;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "dioLength", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAudioLength;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "uildInfo", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorBuildInfo;
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "pu", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 4, "peechTime", 0, 9, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorCpuSpeechTime;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 4, "ime", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorCpuTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "sambiguation", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorDisambiguation;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "mainUsage", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDomainUsage;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorErrorMessage;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "ormat", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorFormat;
                          }
                        switch (field_name[6])
                          {
                            case 'V':
                                if ((String.Compare(field_name, 7, "ersion", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorFormatVersion;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ocalOrRemote", 0, 12, false) == 0)
                      {
                        if (field_name.Length == 13)
                          {
                            return fieldGeneratorLocalOrRemote;
                          }
                        switch (field_name[13])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 14, "eason", 0, 5, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorLocalOrRemoteReason;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umToReturn", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorNumToReturn;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryID", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorQueryID;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if (String.Compare(field_name, 3, "l", 0, 1, false) == 0)
                                  {
                                    switch (field_name[4])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 5, "peechTime", 0, 9, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorRealSpeechTime;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 5, "ime", 0, 3, false) == 0) && (field_name.Length == 8))
                                                return fieldGeneratorRealTime;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "ultsAreFinal", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorResultsAreFinal;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "rverGeneratedId", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorServerGeneratedId;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorStatus;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ranscriptionLattice", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorTranscriptionLattice;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundServer class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundServer class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the HoundServer class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the HoundServer class");
            fieldGeneratorNumToReturn = new FieldHoldingGeneratorNumToReturn("field \"NumToReturn\" of the HoundServer class");
            fieldGeneratorAllResults = new CommandResultJSON.HoldingArrayGenerator("field \"AllResults\" of the HoundServer class", ignore_extras);
            fieldGeneratorDisambiguation = new TypeDisambiguationJSON.HoldingGenerator("field \"Disambiguation\" of the HoundServer class", ignore_extras);
            fieldGeneratorResultsAreFinal = new JSONHoldingBooleanArrayGenerator("field \"ResultsAreFinal\" of the HoundServer class");
            fieldGeneratorASRUsage = new TypeASRUsageJSON.HoldingArrayGenerator("field \"ASRUsage\" of the HoundServer class", ignore_extras);
            fieldGeneratorDomainUsage = new TypeDomainUsageJSON.HoldingArrayGenerator("field \"DomainUsage\" of the HoundServer class", ignore_extras);
            fieldGeneratorTranscriptionLattice = new TypeTranscriptionLatticeJSON.HoldingArrayGenerator("field \"TranscriptionLattice\" of the HoundServer class", ignore_extras);
            fieldGeneratorBuildInfo = new BuildInfoJSON.HoldingGenerator("field \"BuildInfo\" of the HoundServer class", ignore_extras);
            fieldGeneratorQueryID = new JSONHoldingStringGenerator("field \"QueryID\" of the HoundServer class");
            fieldGeneratorServerGeneratedId = new JSONHoldingStringGenerator("field \"ServerGeneratedId\" of the HoundServer class");
            fieldGeneratorAudioLength = new JSONHoldingNumberTextGenerator("field \"AudioLength\" of the HoundServer class");
            fieldGeneratorRealSpeechTime = new JSONHoldingNumberTextGenerator("field \"RealSpeechTime\" of the HoundServer class");
            fieldGeneratorCpuSpeechTime = new JSONHoldingNumberTextGenerator("field \"CpuSpeechTime\" of the HoundServer class");
            fieldGeneratorRealTime = new JSONHoldingNumberTextGenerator("field \"RealTime\" of the HoundServer class");
            fieldGeneratorCpuTime = new JSONHoldingNumberTextGenerator("field \"CpuTime\" of the HoundServer class");
            fieldGeneratorLocalOrRemote = new FieldHoldingGeneratorLocalOrRemote("field \"LocalOrRemote\" of the HoundServer class");
            fieldGeneratorLocalOrRemoteReason = new JSONHoldingStringGenerator("field \"LocalOrRemoteReason\" of the HoundServer class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundServer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFormat = new FieldHoldingGeneratorFormat("field \"Format\" of the HoundServer class");
            fieldGeneratorFormatVersion = new FieldHoldingGeneratorFormatVersion("field \"FormatVersion\" of the HoundServer class");
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the HoundServer class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the HoundServer class");
            fieldGeneratorNumToReturn = new FieldHoldingGeneratorNumToReturn("field \"NumToReturn\" of the HoundServer class");
            fieldGeneratorAllResults = new CommandResultJSON.HoldingArrayGenerator("field \"AllResults\" of the HoundServer class", false);
            fieldGeneratorDisambiguation = new TypeDisambiguationJSON.HoldingGenerator("field \"Disambiguation\" of the HoundServer class", false);
            fieldGeneratorResultsAreFinal = new JSONHoldingBooleanArrayGenerator("field \"ResultsAreFinal\" of the HoundServer class");
            fieldGeneratorASRUsage = new TypeASRUsageJSON.HoldingArrayGenerator("field \"ASRUsage\" of the HoundServer class", false);
            fieldGeneratorDomainUsage = new TypeDomainUsageJSON.HoldingArrayGenerator("field \"DomainUsage\" of the HoundServer class", false);
            fieldGeneratorTranscriptionLattice = new TypeTranscriptionLatticeJSON.HoldingArrayGenerator("field \"TranscriptionLattice\" of the HoundServer class", false);
            fieldGeneratorBuildInfo = new BuildInfoJSON.HoldingGenerator("field \"BuildInfo\" of the HoundServer class", false);
            fieldGeneratorQueryID = new JSONHoldingStringGenerator("field \"QueryID\" of the HoundServer class");
            fieldGeneratorServerGeneratedId = new JSONHoldingStringGenerator("field \"ServerGeneratedId\" of the HoundServer class");
            fieldGeneratorAudioLength = new JSONHoldingNumberTextGenerator("field \"AudioLength\" of the HoundServer class");
            fieldGeneratorRealSpeechTime = new JSONHoldingNumberTextGenerator("field \"RealSpeechTime\" of the HoundServer class");
            fieldGeneratorCpuSpeechTime = new JSONHoldingNumberTextGenerator("field \"CpuSpeechTime\" of the HoundServer class");
            fieldGeneratorRealTime = new JSONHoldingNumberTextGenerator("field \"RealTime\" of the HoundServer class");
            fieldGeneratorCpuTime = new JSONHoldingNumberTextGenerator("field \"CpuTime\" of the HoundServer class");
            fieldGeneratorLocalOrRemote = new FieldHoldingGeneratorLocalOrRemote("field \"LocalOrRemote\" of the HoundServer class");
            fieldGeneratorLocalOrRemoteReason = new JSONHoldingStringGenerator("field \"LocalOrRemoteReason\" of the HoundServer class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundServer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFormat.reset();
            fieldGeneratorFormatVersion.reset();
            fieldGeneratorStatus.reset();
            fieldGeneratorErrorMessage.reset();
            fieldGeneratorNumToReturn.reset();
            fieldGeneratorAllResults.reset();
            fieldGeneratorDisambiguation.reset();
            fieldGeneratorResultsAreFinal.reset();
            fieldGeneratorASRUsage.reset();
            fieldGeneratorDomainUsage.reset();
            fieldGeneratorTranscriptionLattice.reset();
            fieldGeneratorBuildInfo.reset();
            fieldGeneratorQueryID.reset();
            fieldGeneratorServerGeneratedId.reset();
            fieldGeneratorAudioLength.reset();
            fieldGeneratorRealSpeechTime.reset();
            fieldGeneratorCpuSpeechTime.reset();
            fieldGeneratorRealTime.reset();
            fieldGeneratorCpuTime.reset();
            fieldGeneratorLocalOrRemote.reset();
            fieldGeneratorLocalOrRemoteReason.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAllResults.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDisambiguation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorASRUsage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDomainUsage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTranscriptionLattice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBuildInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAllResults.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDisambiguation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorASRUsage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDomainUsage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTranscriptionLattice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBuildInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundServerJSON  result)
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
        public HoundServerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundServerJSON  result)
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
    protected virtual void handle_result(List<HoundServerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundServerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundServerJSON>();
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
    public List<HoundServerJSON> value;
  };
  };
