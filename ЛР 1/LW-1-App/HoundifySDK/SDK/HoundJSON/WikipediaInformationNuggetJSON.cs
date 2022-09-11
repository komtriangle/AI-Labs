/* file "WikipediaInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class WikipediaInformationNuggetJSON : InformationNuggetJSON
  {
    public class TypeWikipediaEntriesJSON : JSONBase
      {
        private bool flagHasTitle;
        private string storeTitle;
        private bool flagHasRequestedTitle;
        private string storeRequestedTitle;
        private bool flagHasShouldIndicateRedirect;
        private bool storeShouldIndicateRedirect;
        private bool flagHasWrittenSummaryShort;
        private string storeWrittenSummaryShort;
        private bool flagHasWrittenSummaryLong;
        private string storeWrittenSummaryLong;
        private bool flagHasImage;
        private string storeImage;
        private bool flagHasURI;
        private string storeURI;
        private bool flagHasSpokenSummaryShort;
        private string storeSpokenSummaryShort;
        private bool flagHasSpokenSummaryLong;
        private string storeSpokenSummaryLong;
        private bool flagHasSpokenSummaryLongIsShort;
        private bool storeSpokenSummaryLongIsShort;
        private bool flagHasOriginalID;
        private BigInteger storeOriginalID;
        private bool flagHasResolvedID;
        private BigInteger storeResolvedID;
        private bool flagHasWebCommandEnabled;
        private bool storeWebCommandEnabled;
        private bool flagHasWikipediaAttribution;
        private string storeWikipediaAttribution;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Title of TypeWikipediaEntriesJSON is not a string.");
            setTitle(json_string.getData());
          }


        private void  fromJSONRequestedTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field RequestedTitle of TypeWikipediaEntriesJSON is not a string.");
            setRequestedTitle(json_string.getData());
          }


        private void  fromJSONShouldIndicateRedirect(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field ShouldIndicateRedirect of TypeWikipediaEntriesJSON is not true for false.");
                  }
              }
            setShouldIndicateRedirect(the_bool);
          }


        private void  fromJSONWrittenSummaryShort(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenSummaryShort of TypeWikipediaEntriesJSON is not a string.");
            setWrittenSummaryShort(json_string.getData());
          }


        private void  fromJSONWrittenSummaryLong(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WrittenSummaryLong of TypeWikipediaEntriesJSON is not a string.");
            setWrittenSummaryLong(json_string.getData());
          }


        private void  fromJSONImage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Image of TypeWikipediaEntriesJSON is not a string.");
            setImage(json_string.getData());
          }


        private void  fromJSONURI(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URI of TypeWikipediaEntriesJSON is not a string.");
            setURI(json_string.getData());
          }


        private void  fromJSONSpokenSummaryShort(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenSummaryShort of TypeWikipediaEntriesJSON is not a string.");
            setSpokenSummaryShort(json_string.getData());
          }


        private void  fromJSONSpokenSummaryLong(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SpokenSummaryLong of TypeWikipediaEntriesJSON is not a string.");
            setSpokenSummaryLong(json_string.getData());
          }


        private void  fromJSONSpokenSummaryLongIsShort(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field SpokenSummaryLongIsShort of TypeWikipediaEntriesJSON is not true for false.");
                  }
              }
            setSpokenSummaryLongIsShort(the_bool);
          }


        private void  fromJSONOriginalID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OriginalID of TypeWikipediaEntriesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OriginalID of TypeWikipediaEntriesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOriginalID(extracted_integer);
          }


        private void  fromJSONResolvedID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ResolvedID of TypeWikipediaEntriesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ResolvedID of TypeWikipediaEntriesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setResolvedID(extracted_integer);
          }


        private void  fromJSONWebCommandEnabled(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WebCommandEnabled of TypeWikipediaEntriesJSON is not true for false.");
                  }
              }
            setWebCommandEnabled(the_bool);
          }


        private void  fromJSONWikipediaAttribution(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field WikipediaAttribution of TypeWikipediaEntriesJSON is not a string.");
            setWikipediaAttribution(json_string.getData());
          }


        public TypeWikipediaEntriesJSON()
          {
            flagHasTitle = false;
            flagHasRequestedTitle = false;
            flagHasShouldIndicateRedirect = false;
            flagHasWrittenSummaryShort = false;
            flagHasWrittenSummaryLong = false;
            flagHasImage = false;
            flagHasURI = false;
            flagHasSpokenSummaryShort = false;
            flagHasSpokenSummaryLong = false;
            flagHasSpokenSummaryLongIsShort = false;
            flagHasOriginalID = false;
            flagHasResolvedID = false;
            flagHasWebCommandEnabled = false;
            flagHasWikipediaAttribution = false;
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

        public bool  hasRequestedTitle()
          {
            return flagHasRequestedTitle;
          }

        public string  getRequestedTitle()
          {
            Debug.Assert(flagHasRequestedTitle);
            return storeRequestedTitle;
          }

        public bool  hasShouldIndicateRedirect()
          {
            return flagHasShouldIndicateRedirect;
          }

        public bool  getShouldIndicateRedirect()
          {
            Debug.Assert(flagHasShouldIndicateRedirect);
            return storeShouldIndicateRedirect;
          }

        public bool  hasWrittenSummaryShort()
          {
            return flagHasWrittenSummaryShort;
          }

        public string  getWrittenSummaryShort()
          {
            Debug.Assert(flagHasWrittenSummaryShort);
            return storeWrittenSummaryShort;
          }

        public bool  hasWrittenSummaryLong()
          {
            return flagHasWrittenSummaryLong;
          }

        public string  getWrittenSummaryLong()
          {
            Debug.Assert(flagHasWrittenSummaryLong);
            return storeWrittenSummaryLong;
          }

        public bool  hasImage()
          {
            return flagHasImage;
          }

        public string  getImage()
          {
            Debug.Assert(flagHasImage);
            return storeImage;
          }

        public bool  hasURI()
          {
            return flagHasURI;
          }

        public string  getURI()
          {
            Debug.Assert(flagHasURI);
            return storeURI;
          }

        public bool  hasSpokenSummaryShort()
          {
            return flagHasSpokenSummaryShort;
          }

        public string  getSpokenSummaryShort()
          {
            Debug.Assert(flagHasSpokenSummaryShort);
            return storeSpokenSummaryShort;
          }

        public bool  hasSpokenSummaryLong()
          {
            return flagHasSpokenSummaryLong;
          }

        public string  getSpokenSummaryLong()
          {
            Debug.Assert(flagHasSpokenSummaryLong);
            return storeSpokenSummaryLong;
          }

        public bool  hasSpokenSummaryLongIsShort()
          {
            return flagHasSpokenSummaryLongIsShort;
          }

        public bool  getSpokenSummaryLongIsShort()
          {
            Debug.Assert(flagHasSpokenSummaryLongIsShort);
            return storeSpokenSummaryLongIsShort;
          }

        public bool  hasOriginalID()
          {
            return flagHasOriginalID;
          }

        public BigInteger  getOriginalID()
          {
            Debug.Assert(flagHasOriginalID);
            return storeOriginalID;
          }

        public bool  hasResolvedID()
          {
            return flagHasResolvedID;
          }

        public BigInteger  getResolvedID()
          {
            Debug.Assert(flagHasResolvedID);
            return storeResolvedID;
          }

        public bool  hasWebCommandEnabled()
          {
            return flagHasWebCommandEnabled;
          }

        public bool  getWebCommandEnabled()
          {
            Debug.Assert(flagHasWebCommandEnabled);
            return storeWebCommandEnabled;
          }

        public bool  hasWikipediaAttribution()
          {
            return flagHasWikipediaAttribution;
          }

        public string  getWikipediaAttribution()
          {
            Debug.Assert(flagHasWikipediaAttribution);
            return storeWikipediaAttribution;
          }


        public virtual int extraTypeWikipediaEntriesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeWikipediaEntriesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeWikipediaEntriesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeWikipediaEntriesLookup(string field_name)
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
        public void setRequestedTitle(string new_value)
          {
            flagHasRequestedTitle = true;
            storeRequestedTitle = new_value;
          }
        public void unsetRequestedTitle()
          {
            flagHasRequestedTitle = false;
          }
        public void setShouldIndicateRedirect(bool new_value)
          {
            flagHasShouldIndicateRedirect = true;
            storeShouldIndicateRedirect = new_value;
          }
        public void unsetShouldIndicateRedirect()
          {
            flagHasShouldIndicateRedirect = false;
          }
        public void setWrittenSummaryShort(string new_value)
          {
            flagHasWrittenSummaryShort = true;
            storeWrittenSummaryShort = new_value;
          }
        public void unsetWrittenSummaryShort()
          {
            flagHasWrittenSummaryShort = false;
          }
        public void setWrittenSummaryLong(string new_value)
          {
            flagHasWrittenSummaryLong = true;
            storeWrittenSummaryLong = new_value;
          }
        public void unsetWrittenSummaryLong()
          {
            flagHasWrittenSummaryLong = false;
          }
        public void setImage(string new_value)
          {
            flagHasImage = true;
            storeImage = new_value;
          }
        public void unsetImage()
          {
            flagHasImage = false;
          }
        public void setURI(string new_value)
          {
            flagHasURI = true;
            storeURI = new_value;
          }
        public void unsetURI()
          {
            flagHasURI = false;
          }
        public void setSpokenSummaryShort(string new_value)
          {
            flagHasSpokenSummaryShort = true;
            storeSpokenSummaryShort = new_value;
          }
        public void unsetSpokenSummaryShort()
          {
            flagHasSpokenSummaryShort = false;
          }
        public void setSpokenSummaryLong(string new_value)
          {
            flagHasSpokenSummaryLong = true;
            storeSpokenSummaryLong = new_value;
          }
        public void unsetSpokenSummaryLong()
          {
            flagHasSpokenSummaryLong = false;
          }
        public void setSpokenSummaryLongIsShort(bool new_value)
          {
            flagHasSpokenSummaryLongIsShort = true;
            storeSpokenSummaryLongIsShort = new_value;
          }
        public void unsetSpokenSummaryLongIsShort()
          {
            flagHasSpokenSummaryLongIsShort = false;
          }
        public void setOriginalID(BigInteger new_value)
          {
            flagHasOriginalID = true;
            storeOriginalID = new_value;
          }
        public void unsetOriginalID()
          {
            flagHasOriginalID = false;
          }
        public void setResolvedID(BigInteger new_value)
          {
            flagHasResolvedID = true;
            storeResolvedID = new_value;
          }
        public void unsetResolvedID()
          {
            flagHasResolvedID = false;
          }
        public void setWebCommandEnabled(bool new_value)
          {
            flagHasWebCommandEnabled = true;
            storeWebCommandEnabled = new_value;
          }
        public void unsetWebCommandEnabled()
          {
            flagHasWebCommandEnabled = false;
          }
        public void setWikipediaAttribution(string new_value)
          {
            flagHasWikipediaAttribution = true;
            storeWikipediaAttribution = new_value;
          }
        public void unsetWikipediaAttribution()
          {
            flagHasWikipediaAttribution = false;
          }

        public virtual void extraTypeWikipediaEntriesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeWikipediaEntriesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeWikipediaEntriesLookup(key);
            if (old_field == null)
              {
                extraTypeWikipediaEntriesAppendPair(key, new_component);
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
            if (flagHasRequestedTitle)
              {
                handler.start_pair("RequestedTitle");
                handler.string_value(storeRequestedTitle);
              }
            if (flagHasShouldIndicateRedirect)
              {
                handler.start_pair("ShouldIndicateRedirect");
                handler.boolean_value(storeShouldIndicateRedirect);
              }
            Debug.Assert(partial_allowed || flagHasWrittenSummaryShort);
            if (flagHasWrittenSummaryShort)
              {
                handler.start_pair("WrittenSummaryShort");
                handler.string_value(storeWrittenSummaryShort);
              }
            Debug.Assert(partial_allowed || flagHasWrittenSummaryLong);
            if (flagHasWrittenSummaryLong)
              {
                handler.start_pair("WrittenSummaryLong");
                handler.string_value(storeWrittenSummaryLong);
              }
            Debug.Assert(partial_allowed || flagHasImage);
            if (flagHasImage)
              {
                handler.start_pair("Image");
                handler.string_value(storeImage);
              }
            Debug.Assert(partial_allowed || flagHasURI);
            if (flagHasURI)
              {
                handler.start_pair("URI");
                handler.string_value(storeURI);
              }
            Debug.Assert(partial_allowed || flagHasSpokenSummaryShort);
            if (flagHasSpokenSummaryShort)
              {
                handler.start_pair("SpokenSummaryShort");
                handler.string_value(storeSpokenSummaryShort);
              }
            Debug.Assert(partial_allowed || flagHasSpokenSummaryLong);
            if (flagHasSpokenSummaryLong)
              {
                handler.start_pair("SpokenSummaryLong");
                handler.string_value(storeSpokenSummaryLong);
              }
            if (flagHasSpokenSummaryLongIsShort)
              {
                handler.start_pair("SpokenSummaryLongIsShort");
                handler.boolean_value(storeSpokenSummaryLongIsShort);
              }
            Debug.Assert(partial_allowed || flagHasOriginalID);
            if (flagHasOriginalID)
              {
                handler.start_pair("OriginalID");
                handler.number_value(storeOriginalID);
              }
            Debug.Assert(partial_allowed || flagHasResolvedID);
            if (flagHasResolvedID)
              {
                handler.start_pair("ResolvedID");
                handler.number_value(storeResolvedID);
              }
            if (flagHasWebCommandEnabled)
              {
                handler.start_pair("WebCommandEnabled");
                handler.boolean_value(storeWebCommandEnabled);
              }
            if (flagHasWikipediaAttribution)
              {
                handler.start_pair("WikipediaAttribution");
                handler.string_value(storeWikipediaAttribution);
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
            if ((!allow_unpolished) && !(hasWrittenSummaryShort()))
              {
                return "When parsing the object for %what%, the \"WrittenSummaryShort\" field was missing.";
              }
            if ((!allow_unpolished) && !(hasWrittenSummaryLong()))
              {
                return "When parsing the object for %what%, the \"WrittenSummaryLong\" field was missing.";
              }
            if (!(hasImage()))
              {
                return "When parsing the object for %what%, the \"Image\" field was missing.";
              }
            if (!(hasURI()))
              {
                return "When parsing the object for %what%, the \"URI\" field was missing.";
              }
            if ((!allow_unpolished) && !(hasSpokenSummaryShort()))
              {
                return "When parsing the object for %what%, the \"SpokenSummaryShort\" field was missing.";
              }
            if ((!allow_unpolished) && !(hasSpokenSummaryLong()))
              {
                return "When parsing the object for %what%, the \"SpokenSummaryLong\" field was missing.";
              }
            if (!(hasOriginalID()))
              {
                return "When parsing the object for %what%, the \"OriginalID\" field was missing.";
              }
            if (!(hasResolvedID()))
              {
                return "When parsing the object for %what%, the \"ResolvedID\" field was missing.";
              }
            return null;
          }

        public static TypeWikipediaEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWikipediaEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWikipediaEntries", ignore_extras);
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
        public static TypeWikipediaEntriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWikipediaEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeWikipediaEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWikipediaEntries", ignore_extras);
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
        public static TypeWikipediaEntriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeWikipediaEntriesJSON from_text(string text, bool ignore_extras)
          {
            TypeWikipediaEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWikipediaEntries", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeWikipediaEntriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeWikipediaEntriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeWikipediaEntriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeWikipediaEntries", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorTitle;
            private JSONHoldingStringGenerator fieldGeneratorRequestedTitle;
            private JSONHoldingBooleanGenerator fieldGeneratorShouldIndicateRedirect;
            private JSONHoldingStringGenerator fieldGeneratorWrittenSummaryShort;
            private JSONHoldingStringGenerator fieldGeneratorWrittenSummaryLong;
            private JSONHoldingStringGenerator fieldGeneratorImage;
            private JSONHoldingStringGenerator fieldGeneratorURI;
            private JSONHoldingStringGenerator fieldGeneratorSpokenSummaryShort;
            private JSONHoldingStringGenerator fieldGeneratorSpokenSummaryLong;
            private JSONHoldingBooleanGenerator fieldGeneratorSpokenSummaryLongIsShort;
        private class FieldHoldingGeneratorOriginalID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOriginalID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorOriginalID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorOriginalID fieldGeneratorOriginalID;
        private class FieldHoldingGeneratorResolvedID : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorResolvedID : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorResolvedID(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorResolvedID fieldGeneratorResolvedID;
            private JSONHoldingBooleanGenerator fieldGeneratorWebCommandEnabled;
            private JSONHoldingStringGenerator fieldGeneratorWikipediaAttribution;
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
                TypeWikipediaEntriesJSON result = new TypeWikipediaEntriesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeWikipediaEntriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeWikipediaEntriesJSON result)
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
                if (fieldGeneratorRequestedTitle.have_value)
                  {
                    result.setRequestedTitle(fieldGeneratorRequestedTitle.value);
                    fieldGeneratorRequestedTitle.have_value = false;
                  }
                if (fieldGeneratorShouldIndicateRedirect.have_value)
                  {
                    result.setShouldIndicateRedirect(fieldGeneratorShouldIndicateRedirect.value);
                    fieldGeneratorShouldIndicateRedirect.have_value = false;
                  }
                if (fieldGeneratorWrittenSummaryShort.have_value)
                  {
                    result.setWrittenSummaryShort(fieldGeneratorWrittenSummaryShort.value);
                    fieldGeneratorWrittenSummaryShort.have_value = false;
                  }
                else if ((!(result.hasWrittenSummaryShort())) && (!allow_unpolished) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenSummaryShort\" field was missing.");
                  }
                if (fieldGeneratorWrittenSummaryLong.have_value)
                  {
                    result.setWrittenSummaryLong(fieldGeneratorWrittenSummaryLong.value);
                    fieldGeneratorWrittenSummaryLong.have_value = false;
                  }
                else if ((!(result.hasWrittenSummaryLong())) && (!allow_unpolished) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"WrittenSummaryLong\" field was missing.");
                  }
                if (fieldGeneratorImage.have_value)
                  {
                    result.setImage(fieldGeneratorImage.value);
                    fieldGeneratorImage.have_value = false;
                  }
                else if ((!(result.hasImage())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Image\" field was missing.");
                  }
                if (fieldGeneratorURI.have_value)
                  {
                    result.setURI(fieldGeneratorURI.value);
                    fieldGeneratorURI.have_value = false;
                  }
                else if ((!(result.hasURI())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URI\" field was missing.");
                  }
                if (fieldGeneratorSpokenSummaryShort.have_value)
                  {
                    result.setSpokenSummaryShort(fieldGeneratorSpokenSummaryShort.value);
                    fieldGeneratorSpokenSummaryShort.have_value = false;
                  }
                else if ((!(result.hasSpokenSummaryShort())) && (!allow_unpolished) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenSummaryShort\" field was missing.");
                  }
                if (fieldGeneratorSpokenSummaryLong.have_value)
                  {
                    result.setSpokenSummaryLong(fieldGeneratorSpokenSummaryLong.value);
                    fieldGeneratorSpokenSummaryLong.have_value = false;
                  }
                else if ((!(result.hasSpokenSummaryLong())) && (!allow_unpolished) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SpokenSummaryLong\" field was missing.");
                  }
                if (fieldGeneratorSpokenSummaryLongIsShort.have_value)
                  {
                    result.setSpokenSummaryLongIsShort(fieldGeneratorSpokenSummaryLongIsShort.value);
                    fieldGeneratorSpokenSummaryLongIsShort.have_value = false;
                  }
                if (fieldGeneratorOriginalID.have_value)
                  {
                    result.setOriginalID(fieldGeneratorOriginalID.value);
                    fieldGeneratorOriginalID.have_value = false;
                  }
                else if ((!(result.hasOriginalID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"OriginalID\" field was missing.");
                  }
                if (fieldGeneratorResolvedID.have_value)
                  {
                    result.setResolvedID(fieldGeneratorResolvedID.value);
                    fieldGeneratorResolvedID.have_value = false;
                  }
                else if ((!(result.hasResolvedID())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ResolvedID\" field was missing.");
                  }
                if (fieldGeneratorWebCommandEnabled.have_value)
                  {
                    result.setWebCommandEnabled(fieldGeneratorWebCommandEnabled.value);
                    fieldGeneratorWebCommandEnabled.have_value = false;
                  }
                if (fieldGeneratorWikipediaAttribution.have_value)
                  {
                    result.setWikipediaAttribution(fieldGeneratorWikipediaAttribution.value);
                    fieldGeneratorWikipediaAttribution.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeWikipediaEntriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'I':
                        if ((String.Compare(field_name, 1, "mage", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorImage;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "riginalID", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorOriginalID;
                        break;
                    case 'R':
                        if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                          {
                            switch (field_name[2])
                              {
                                case 'q':
                                    if ((String.Compare(field_name, 3, "uestedTitle", 0, 11, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorRequestedTitle;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "olvedID", 0, 7, false) == 0) && (field_name.Length == 10))
                                        return fieldGeneratorResolvedID;
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
                                if ((String.Compare(field_name, 2, "ouldIndicateRedirect", 0, 20, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorShouldIndicateRedirect;
                                break;
                            case 'p':
                                if (String.Compare(field_name, 2, "okenSummary", 0, 11, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'L':
                                            if (String.Compare(field_name, 14, "ong", 0, 3, false) == 0)
                                              {
                                                if (field_name.Length == 17)
                                                  {
                                                    return fieldGeneratorSpokenSummaryLong;
                                                  }
                                                switch (field_name[17])
                                                  {
                                                    case 'I':
                                                        if ((String.Compare(field_name, 18, "sShort", 0, 6, false) == 0) && (field_name.Length == 24))
                                                            return fieldGeneratorSpokenSummaryLongIsShort;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 14, "hort", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorSpokenSummaryShort;
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
                    case 'T':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTitle;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RI", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURI;
                        break;
                    case 'W':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "bCommandEnabled", 0, 15, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorWebCommandEnabled;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 2, "kipediaAttribution", 0, 18, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorWikipediaAttribution;
                                break;
                            case 'r':
                                if (String.Compare(field_name, 2, "ittenSummary", 0, 12, false) == 0)
                                  {
                                    switch (field_name[14])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 15, "ong", 0, 3, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorWrittenSummaryLong;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 15, "hort", 0, 4, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorWrittenSummaryShort;
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
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeWikipediaEntries class");
                fieldGeneratorRequestedTitle = new JSONHoldingStringGenerator("field \"RequestedTitle\" of the TypeWikipediaEntries class");
                fieldGeneratorShouldIndicateRedirect = new JSONHoldingBooleanGenerator("field \"ShouldIndicateRedirect\" of the TypeWikipediaEntries class");
                fieldGeneratorWrittenSummaryShort = new JSONHoldingStringGenerator("field \"WrittenSummaryShort\" of the TypeWikipediaEntries class");
                fieldGeneratorWrittenSummaryLong = new JSONHoldingStringGenerator("field \"WrittenSummaryLong\" of the TypeWikipediaEntries class");
                fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the TypeWikipediaEntries class");
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryShort = new JSONHoldingStringGenerator("field \"SpokenSummaryShort\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryLong = new JSONHoldingStringGenerator("field \"SpokenSummaryLong\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryLongIsShort = new JSONHoldingBooleanGenerator("field \"SpokenSummaryLongIsShort\" of the TypeWikipediaEntries class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeWikipediaEntries class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeWikipediaEntries class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeWikipediaEntries class");
                fieldGeneratorWikipediaAttribution = new JSONHoldingStringGenerator("field \"WikipediaAttribution\" of the TypeWikipediaEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeWikipediaEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TypeWikipediaEntries class");
                fieldGeneratorRequestedTitle = new JSONHoldingStringGenerator("field \"RequestedTitle\" of the TypeWikipediaEntries class");
                fieldGeneratorShouldIndicateRedirect = new JSONHoldingBooleanGenerator("field \"ShouldIndicateRedirect\" of the TypeWikipediaEntries class");
                fieldGeneratorWrittenSummaryShort = new JSONHoldingStringGenerator("field \"WrittenSummaryShort\" of the TypeWikipediaEntries class");
                fieldGeneratorWrittenSummaryLong = new JSONHoldingStringGenerator("field \"WrittenSummaryLong\" of the TypeWikipediaEntries class");
                fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the TypeWikipediaEntries class");
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryShort = new JSONHoldingStringGenerator("field \"SpokenSummaryShort\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryLong = new JSONHoldingStringGenerator("field \"SpokenSummaryLong\" of the TypeWikipediaEntries class");
                fieldGeneratorSpokenSummaryLongIsShort = new JSONHoldingBooleanGenerator("field \"SpokenSummaryLongIsShort\" of the TypeWikipediaEntries class");
                fieldGeneratorOriginalID = new FieldHoldingGeneratorOriginalID("field \"OriginalID\" of the TypeWikipediaEntries class");
                fieldGeneratorResolvedID = new FieldHoldingGeneratorResolvedID("field \"ResolvedID\" of the TypeWikipediaEntries class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeWikipediaEntries class");
                fieldGeneratorWikipediaAttribution = new JSONHoldingStringGenerator("field \"WikipediaAttribution\" of the TypeWikipediaEntries class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeWikipediaEntries class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTitle.reset();
                fieldGeneratorRequestedTitle.reset();
                fieldGeneratorShouldIndicateRedirect.reset();
                fieldGeneratorWrittenSummaryShort.reset();
                fieldGeneratorWrittenSummaryLong.reset();
                fieldGeneratorImage.reset();
                fieldGeneratorURI.reset();
                fieldGeneratorSpokenSummaryShort.reset();
                fieldGeneratorSpokenSummaryLong.reset();
                fieldGeneratorSpokenSummaryLongIsShort.reset();
                fieldGeneratorOriginalID.reset();
                fieldGeneratorResolvedID.reset();
                fieldGeneratorWebCommandEnabled.reset();
                fieldGeneratorWikipediaAttribution.reset();
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
            protected override void handle_result(TypeWikipediaEntriesJSON  result)
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
            public TypeWikipediaEntriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeWikipediaEntriesJSON  result)
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
        protected virtual void handle_result(List<TypeWikipediaEntriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeWikipediaEntriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeWikipediaEntriesJSON>();
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
        public List<TypeWikipediaEntriesJSON> value;
      };
      };
    private bool flagHasWikipediaEntries;
    private List< TypeWikipediaEntriesJSON  > storeWikipediaEntries;
    private bool flagHasExplicitKnowledgeSource;
    private bool storeExplicitKnowledgeSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWikipediaEntriesToJSON()
      {
        JSONArrayValue generated_array_1_WikipediaEntries = new JSONArrayValue();
        for (int num1 = 0; num1 < storeWikipediaEntries.Count; ++num1)
          {
            JSONValueHandler handler_WikipediaEntries = new JSONValueHandler();
            storeWikipediaEntries[num1].write_as_json(handler_WikipediaEntries);
            generated_array_1_WikipediaEntries.appendComponent(handler_WikipediaEntries.result);
          }
        return generated_array_1_WikipediaEntries;
      }

    private JSONValue  extraExplicitKnowledgeSourceToJSON()
      {
        JSONValue generated_boolean_ExplicitKnowledgeSource = (storeExplicitKnowledgeSource ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ExplicitKnowledgeSource;
      }


    private void  fromJSONWikipediaEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WikipediaEntries of WikipediaInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field WikipediaEntries of WikipediaInformationNuggetJSON has too few elements.");
        List< TypeWikipediaEntriesJSON  > vector_WikipediaEntries1 = new List< TypeWikipediaEntriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeWikipediaEntriesJSON convert_classy = TypeWikipediaEntriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_WikipediaEntries1.Add(convert_classy);
          }
        Debug.Assert(vector_WikipediaEntries1.Count >= 1);
        initWikipediaEntries();
        for (int num1 = 0; num1 < vector_WikipediaEntries1.Count; ++num1)
            appendWikipediaEntries(vector_WikipediaEntries1[num1]);
        for (int num1 = 0; num1 < vector_WikipediaEntries1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExplicitKnowledgeSource(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExplicitKnowledgeSource of WikipediaInformationNuggetJSON is not true for false.");
              }
          }
        setExplicitKnowledgeSource(the_bool);
      }


    public WikipediaInformationNuggetJSON()
      {
        flagHasWikipediaEntries = false;
        flagHasExplicitKnowledgeSource = false;
        storeWikipediaEntries = new List< TypeWikipediaEntriesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "Wikipedia";
      }

    public bool  hasWikipediaEntries()
      {
        return flagHasWikipediaEntries;
      }

    public int  countOfWikipediaEntries()
      {
        Debug.Assert(flagHasWikipediaEntries);
        return storeWikipediaEntries.Count;
      }

    public TypeWikipediaEntriesJSON   elementOfWikipediaEntries(int element_num)
      {
        Debug.Assert(flagHasWikipediaEntries);
        return storeWikipediaEntries[element_num];
      }

    public List< TypeWikipediaEntriesJSON  >  getWikipediaEntries()
      {
        Debug.Assert(flagHasWikipediaEntries);
        return storeWikipediaEntries;
      }

    public bool  hasExplicitKnowledgeSource()
      {
        return flagHasExplicitKnowledgeSource;
      }

    public bool  getExplicitKnowledgeSource()
      {
        Debug.Assert(flagHasExplicitKnowledgeSource);
        return storeExplicitKnowledgeSource;
      }


    public virtual int extraWikipediaInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWikipediaInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWikipediaInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWikipediaInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasWikipediaEntries)
            ++result;
        if (flagHasExplicitKnowledgeSource)
            ++result;
        result += extraWikipediaInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWikipediaEntries)
          {
            if (remainder == 0)
                return "WikipediaEntries";
            --remainder;
          }
        if (flagHasExplicitKnowledgeSource)
          {
            if (remainder == 0)
                return "ExplicitKnowledgeSource";
            --remainder;
          }
        return extraWikipediaInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWikipediaEntries)
          {
            if (remainder == 0)
                return extraWikipediaEntriesToJSON();
            --remainder;
          }
        if (flagHasExplicitKnowledgeSource)
          {
            if (remainder == 0)
                return extraExplicitKnowledgeSourceToJSON();
            --remainder;
          }
        return extraWikipediaInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "xplicitKnowledgeSource", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasExplicitKnowledgeSource ? extraExplicitKnowledgeSourceToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "ikipediaEntries", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasWikipediaEntries ? extraWikipediaEntriesToJSON() : null);
                break;
            default:
                break;
          }
        return extraWikipediaInformationNuggetLookup(field_name);
      }

    public void initWikipediaEntries()
      {
        if (flagHasWikipediaEntries)
          {
            for (int num1 = 0; num1 < storeWikipediaEntries.Count; ++num1)
              {
              }
          }
        flagHasWikipediaEntries = true;
        storeWikipediaEntries.Clear();
      }
    public void appendWikipediaEntries(TypeWikipediaEntriesJSON  to_append)
      {
        if (!flagHasWikipediaEntries)
          {
            flagHasWikipediaEntries = true;
            storeWikipediaEntries.Clear();
          }
        Debug.Assert(flagHasWikipediaEntries);
        storeWikipediaEntries.Add(to_append);
      }
    public void unsetWikipediaEntries()
      {
        if (flagHasWikipediaEntries)
          {
            for (int num2 = 0; num2 < storeWikipediaEntries.Count; ++num2)
              {
              }
          }
        flagHasWikipediaEntries = false;
        storeWikipediaEntries.Clear();
      }
    public void setExplicitKnowledgeSource(bool new_value)
      {
        flagHasExplicitKnowledgeSource = true;
        storeExplicitKnowledgeSource = new_value;
      }
    public void unsetExplicitKnowledgeSource()
      {
        flagHasExplicitKnowledgeSource = false;
      }

    public virtual void extraWikipediaInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWikipediaInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWikipediaInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraWikipediaInformationNuggetAppendPair(key, new_component);
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
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "xplicitKnowledgeSource", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONExplicitKnowledgeSource(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "ikipediaEntries", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONWikipediaEntries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraWikipediaInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "xplicitKnowledgeSource", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONExplicitKnowledgeSource(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "ikipediaEntries", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONWikipediaEntries(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraWikipediaInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWikipediaEntries);
        if (flagHasWikipediaEntries)
          {
            handler.start_pair("WikipediaEntries");
            Debug.Assert(storeWikipediaEntries.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeWikipediaEntries.Count; ++num1)
              {
                if (partial_allowed)
                    storeWikipediaEntries[num1].write_partial_as_json(handler);
                else
                    storeWikipediaEntries[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasExplicitKnowledgeSource)
          {
            handler.start_pair("ExplicitKnowledgeSource");
            handler.boolean_value(storeExplicitKnowledgeSource);
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
        if (!(hasWikipediaEntries()))
          {
            return "When parsing the object for %what%, the \"WikipediaEntries\" field was missing.";
          }
        return null;
      }

    public static new WikipediaInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaInformationNugget", ignore_extras);
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
    public static new WikipediaInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikipediaInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WikipediaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaInformationNugget", ignore_extras);
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
    public static new WikipediaInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new WikipediaInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        WikipediaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WikipediaInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new WikipediaInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WikipediaInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WikipediaInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private TypeWikipediaEntriesJSON.HoldingArrayGenerator fieldGeneratorWikipediaEntries;
        private JSONHoldingBooleanGenerator fieldGeneratorExplicitKnowledgeSource;
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
            if (!(getInformationNuggetJSONKey().Equals("Wikipedia")))
                throw new Exception("The key field has a value other than `Wikipedia'.");
            WikipediaInformationNuggetJSON result = new WikipediaInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWikipediaInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((WikipediaInformationNuggetJSON )new_result);
          }
        protected void finish(WikipediaInformationNuggetJSON result)
          {
            if (fieldGeneratorWikipediaEntries.have_value)
              {
                result.initWikipediaEntries();
                int count = fieldGeneratorWikipediaEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWikipediaEntries(fieldGeneratorWikipediaEntries.value[num]);
                  }
                fieldGeneratorWikipediaEntries.value.Clear();
                fieldGeneratorWikipediaEntries.have_value = false;
              }
            else if ((!(result.hasWikipediaEntries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WikipediaEntries\" field was missing.");
              }
            if (fieldGeneratorExplicitKnowledgeSource.have_value)
              {
                result.setExplicitKnowledgeSource(fieldGeneratorExplicitKnowledgeSource.value);
                fieldGeneratorExplicitKnowledgeSource.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(WikipediaInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "xplicitKnowledgeSource", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorExplicitKnowledgeSource;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ikipediaEntries", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorWikipediaEntries;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorWikipediaEntries = new TypeWikipediaEntriesJSON.HoldingArrayGenerator("field \"WikipediaEntries\" of the WikipediaInformationNugget class", ignore_extras);
            fieldGeneratorExplicitKnowledgeSource = new JSONHoldingBooleanGenerator("field \"ExplicitKnowledgeSource\" of the WikipediaInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WikipediaInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWikipediaEntries = new TypeWikipediaEntriesJSON.HoldingArrayGenerator("field \"WikipediaEntries\" of the WikipediaInformationNugget class", false);
            fieldGeneratorExplicitKnowledgeSource = new JSONHoldingBooleanGenerator("field \"ExplicitKnowledgeSource\" of the WikipediaInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WikipediaInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorWikipediaEntries.reset();
            fieldGeneratorExplicitKnowledgeSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(WikipediaInformationNuggetJSON  result)
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
        public WikipediaInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WikipediaInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<WikipediaInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WikipediaInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WikipediaInformationNuggetJSON>();
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
    public List<WikipediaInformationNuggetJSON> value;
  };
  };
