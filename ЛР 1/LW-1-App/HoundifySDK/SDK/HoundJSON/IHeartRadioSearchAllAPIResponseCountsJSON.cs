/* file "IHeartRadioSearchAllAPIResponseCountsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioSearchAllAPIResponseCountsJSON : JSONBase
  {
    private bool flagHastracks;
    private BigInteger storetracks;
    private bool flagHaskeywords;
    private BigInteger storekeywords;
    private bool flagHasartists;
    private BigInteger storeartists;
    private bool flagHasalbums;
    private BigInteger storealbums;
    private bool flagHasstations;
    private BigInteger storestations;
    private bool flagHasplaylists;
    private BigInteger storeplaylists;
    private bool flagHaspodcasts;
    private BigInteger storepodcasts;
    private bool flagHasfeaturedStations;
    private BigInteger storefeaturedStations;
    private bool flagHastalkShows;
    private BigInteger storetalkShows;
    private bool flagHastalkThemes;
    private BigInteger storetalkThemes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONtracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field tracks of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field tracks of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        settracks(extracted_integer);
      }


    private void  fromJSONkeywords(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field keywords of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field keywords of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setkeywords(extracted_integer);
      }


    private void  fromJSONartists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field artists of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field artists of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setartists(extracted_integer);
      }


    private void  fromJSONalbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field albums of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field albums of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setalbums(extracted_integer);
      }


    private void  fromJSONstations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field stations of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field stations of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setstations(extracted_integer);
      }


    private void  fromJSONplaylists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field playlists of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field playlists of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setplaylists(extracted_integer);
      }


    private void  fromJSONpodcasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field podcasts of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field podcasts of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setpodcasts(extracted_integer);
      }


    private void  fromJSONfeaturedStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field featuredStations of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field featuredStations of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setfeaturedStations(extracted_integer);
      }


    private void  fromJSONtalkShows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field talkShows of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field talkShows of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        settalkShows(extracted_integer);
      }


    private void  fromJSONtalkThemes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field talkThemes of IHeartRadioSearchAllAPIResponseCountsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field talkThemes of IHeartRadioSearchAllAPIResponseCountsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        settalkThemes(extracted_integer);
      }


    public IHeartRadioSearchAllAPIResponseCountsJSON()
      {
        flagHastracks = false;
        flagHaskeywords = false;
        flagHasartists = false;
        flagHasalbums = false;
        flagHasstations = false;
        flagHasplaylists = false;
        flagHaspodcasts = false;
        flagHasfeaturedStations = false;
        flagHastalkShows = false;
        flagHastalkThemes = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hastracks()
      {
        return flagHastracks;
      }

    public BigInteger  gettracks()
      {
        Debug.Assert(flagHastracks);
        return storetracks;
      }

    public bool  haskeywords()
      {
        return flagHaskeywords;
      }

    public BigInteger  getkeywords()
      {
        Debug.Assert(flagHaskeywords);
        return storekeywords;
      }

    public bool  hasartists()
      {
        return flagHasartists;
      }

    public BigInteger  getartists()
      {
        Debug.Assert(flagHasartists);
        return storeartists;
      }

    public bool  hasalbums()
      {
        return flagHasalbums;
      }

    public BigInteger  getalbums()
      {
        Debug.Assert(flagHasalbums);
        return storealbums;
      }

    public bool  hasstations()
      {
        return flagHasstations;
      }

    public BigInteger  getstations()
      {
        Debug.Assert(flagHasstations);
        return storestations;
      }

    public bool  hasplaylists()
      {
        return flagHasplaylists;
      }

    public BigInteger  getplaylists()
      {
        Debug.Assert(flagHasplaylists);
        return storeplaylists;
      }

    public bool  haspodcasts()
      {
        return flagHaspodcasts;
      }

    public BigInteger  getpodcasts()
      {
        Debug.Assert(flagHaspodcasts);
        return storepodcasts;
      }

    public bool  hasfeaturedStations()
      {
        return flagHasfeaturedStations;
      }

    public BigInteger  getfeaturedStations()
      {
        Debug.Assert(flagHasfeaturedStations);
        return storefeaturedStations;
      }

    public bool  hastalkShows()
      {
        return flagHastalkShows;
      }

    public BigInteger  gettalkShows()
      {
        Debug.Assert(flagHastalkShows);
        return storetalkShows;
      }

    public bool  hastalkThemes()
      {
        return flagHastalkThemes;
      }

    public BigInteger  gettalkThemes()
      {
        Debug.Assert(flagHastalkThemes);
        return storetalkThemes;
      }


    public virtual int extraIHeartRadioSearchAllAPIResponseCountsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponseCountsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseCountsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseCountsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void settracks(BigInteger new_value)
      {
        flagHastracks = true;
        storetracks = new_value;
      }
    public void unsettracks()
      {
        flagHastracks = false;
      }
    public void setkeywords(BigInteger new_value)
      {
        flagHaskeywords = true;
        storekeywords = new_value;
      }
    public void unsetkeywords()
      {
        flagHaskeywords = false;
      }
    public void setartists(BigInteger new_value)
      {
        flagHasartists = true;
        storeartists = new_value;
      }
    public void unsetartists()
      {
        flagHasartists = false;
      }
    public void setalbums(BigInteger new_value)
      {
        flagHasalbums = true;
        storealbums = new_value;
      }
    public void unsetalbums()
      {
        flagHasalbums = false;
      }
    public void setstations(BigInteger new_value)
      {
        flagHasstations = true;
        storestations = new_value;
      }
    public void unsetstations()
      {
        flagHasstations = false;
      }
    public void setplaylists(BigInteger new_value)
      {
        flagHasplaylists = true;
        storeplaylists = new_value;
      }
    public void unsetplaylists()
      {
        flagHasplaylists = false;
      }
    public void setpodcasts(BigInteger new_value)
      {
        flagHaspodcasts = true;
        storepodcasts = new_value;
      }
    public void unsetpodcasts()
      {
        flagHaspodcasts = false;
      }
    public void setfeaturedStations(BigInteger new_value)
      {
        flagHasfeaturedStations = true;
        storefeaturedStations = new_value;
      }
    public void unsetfeaturedStations()
      {
        flagHasfeaturedStations = false;
      }
    public void settalkShows(BigInteger new_value)
      {
        flagHastalkShows = true;
        storetalkShows = new_value;
      }
    public void unsettalkShows()
      {
        flagHastalkShows = false;
      }
    public void settalkThemes(BigInteger new_value)
      {
        flagHastalkThemes = true;
        storetalkThemes = new_value;
      }
    public void unsettalkThemes()
      {
        flagHastalkThemes = false;
      }

    public virtual void extraIHeartRadioSearchAllAPIResponseCountsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponseCountsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponseCountsLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponseCountsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHastracks);
        if (flagHastracks)
          {
            handler.start_pair("tracks");
            handler.number_value(storetracks);
          }
        Debug.Assert(partial_allowed || flagHaskeywords);
        if (flagHaskeywords)
          {
            handler.start_pair("keywords");
            handler.number_value(storekeywords);
          }
        Debug.Assert(partial_allowed || flagHasartists);
        if (flagHasartists)
          {
            handler.start_pair("artists");
            handler.number_value(storeartists);
          }
        Debug.Assert(partial_allowed || flagHasalbums);
        if (flagHasalbums)
          {
            handler.start_pair("albums");
            handler.number_value(storealbums);
          }
        Debug.Assert(partial_allowed || flagHasstations);
        if (flagHasstations)
          {
            handler.start_pair("stations");
            handler.number_value(storestations);
          }
        Debug.Assert(partial_allowed || flagHasplaylists);
        if (flagHasplaylists)
          {
            handler.start_pair("playlists");
            handler.number_value(storeplaylists);
          }
        Debug.Assert(partial_allowed || flagHaspodcasts);
        if (flagHaspodcasts)
          {
            handler.start_pair("podcasts");
            handler.number_value(storepodcasts);
          }
        Debug.Assert(partial_allowed || flagHasfeaturedStations);
        if (flagHasfeaturedStations)
          {
            handler.start_pair("featuredStations");
            handler.number_value(storefeaturedStations);
          }
        Debug.Assert(partial_allowed || flagHastalkShows);
        if (flagHastalkShows)
          {
            handler.start_pair("talkShows");
            handler.number_value(storetalkShows);
          }
        Debug.Assert(partial_allowed || flagHastalkThemes);
        if (flagHastalkThemes)
          {
            handler.start_pair("talkThemes");
            handler.number_value(storetalkThemes);
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
        if (!(hastracks()))
          {
            return "When parsing the object for %what%, the \"tracks\" field was missing.";
          }
        if (!(haskeywords()))
          {
            return "When parsing the object for %what%, the \"keywords\" field was missing.";
          }
        if (!(hasartists()))
          {
            return "When parsing the object for %what%, the \"artists\" field was missing.";
          }
        if (!(hasalbums()))
          {
            return "When parsing the object for %what%, the \"albums\" field was missing.";
          }
        if (!(hasstations()))
          {
            return "When parsing the object for %what%, the \"stations\" field was missing.";
          }
        if (!(hasplaylists()))
          {
            return "When parsing the object for %what%, the \"playlists\" field was missing.";
          }
        if (!(haspodcasts()))
          {
            return "When parsing the object for %what%, the \"podcasts\" field was missing.";
          }
        if (!(hasfeaturedStations()))
          {
            return "When parsing the object for %what%, the \"featuredStations\" field was missing.";
          }
        if (!(hastalkShows()))
          {
            return "When parsing the object for %what%, the \"talkShows\" field was missing.";
          }
        if (!(hastalkThemes()))
          {
            return "When parsing the object for %what%, the \"talkThemes\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponseCountsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseCountsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseCounts", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseCountsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseCountsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseCountsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseCounts", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseCountsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseCountsJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseCountsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseCounts", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponseCountsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponseCountsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseCountsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseCounts", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratortracks : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratortracks(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratortracks : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratortracks(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratortracks fieldGeneratortracks;
    private class FieldHoldingGeneratorkeywords : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorkeywords(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorkeywords : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorkeywords(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorkeywords fieldGeneratorkeywords;
    private class FieldHoldingGeneratorartists : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorartists(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorartists : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorartists(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorartists fieldGeneratorartists;
    private class FieldHoldingGeneratoralbums : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratoralbums(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratoralbums : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratoralbums(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratoralbums fieldGeneratoralbums;
    private class FieldHoldingGeneratorstations : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorstations(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorstations : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorstations(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorstations fieldGeneratorstations;
    private class FieldHoldingGeneratorplaylists : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorplaylists(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorplaylists : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorplaylists(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorplaylists fieldGeneratorplaylists;
    private class FieldHoldingGeneratorpodcasts : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorpodcasts(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorpodcasts : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorpodcasts(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorpodcasts fieldGeneratorpodcasts;
    private class FieldHoldingGeneratorfeaturedStations : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorfeaturedStations(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorfeaturedStations : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorfeaturedStations(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorfeaturedStations fieldGeneratorfeaturedStations;
    private class FieldHoldingGeneratortalkShows : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratortalkShows(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratortalkShows : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratortalkShows(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratortalkShows fieldGeneratortalkShows;
    private class FieldHoldingGeneratortalkThemes : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratortalkThemes(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratortalkThemes : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratortalkThemes(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratortalkThemes fieldGeneratortalkThemes;
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
            IHeartRadioSearchAllAPIResponseCountsJSON result = new IHeartRadioSearchAllAPIResponseCountsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponseCountsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponseCountsJSON result)
          {
            if (fieldGeneratortracks.have_value)
              {
                result.settracks(fieldGeneratortracks.value);
                fieldGeneratortracks.have_value = false;
              }
            else if ((!(result.hastracks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"tracks\" field was missing.");
              }
            if (fieldGeneratorkeywords.have_value)
              {
                result.setkeywords(fieldGeneratorkeywords.value);
                fieldGeneratorkeywords.have_value = false;
              }
            else if ((!(result.haskeywords())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"keywords\" field was missing.");
              }
            if (fieldGeneratorartists.have_value)
              {
                result.setartists(fieldGeneratorartists.value);
                fieldGeneratorartists.have_value = false;
              }
            else if ((!(result.hasartists())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"artists\" field was missing.");
              }
            if (fieldGeneratoralbums.have_value)
              {
                result.setalbums(fieldGeneratoralbums.value);
                fieldGeneratoralbums.have_value = false;
              }
            else if ((!(result.hasalbums())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"albums\" field was missing.");
              }
            if (fieldGeneratorstations.have_value)
              {
                result.setstations(fieldGeneratorstations.value);
                fieldGeneratorstations.have_value = false;
              }
            else if ((!(result.hasstations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stations\" field was missing.");
              }
            if (fieldGeneratorplaylists.have_value)
              {
                result.setplaylists(fieldGeneratorplaylists.value);
                fieldGeneratorplaylists.have_value = false;
              }
            else if ((!(result.hasplaylists())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"playlists\" field was missing.");
              }
            if (fieldGeneratorpodcasts.have_value)
              {
                result.setpodcasts(fieldGeneratorpodcasts.value);
                fieldGeneratorpodcasts.have_value = false;
              }
            else if ((!(result.haspodcasts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"podcasts\" field was missing.");
              }
            if (fieldGeneratorfeaturedStations.have_value)
              {
                result.setfeaturedStations(fieldGeneratorfeaturedStations.value);
                fieldGeneratorfeaturedStations.have_value = false;
              }
            else if ((!(result.hasfeaturedStations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"featuredStations\" field was missing.");
              }
            if (fieldGeneratortalkShows.have_value)
              {
                result.settalkShows(fieldGeneratortalkShows.value);
                fieldGeneratortalkShows.have_value = false;
              }
            else if ((!(result.hastalkShows())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"talkShows\" field was missing.");
              }
            if (fieldGeneratortalkThemes.have_value)
              {
                result.settalkThemes(fieldGeneratortalkThemes.value);
                fieldGeneratortalkThemes.have_value = false;
              }
            else if ((!(result.hastalkThemes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"talkThemes\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponseCountsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bums", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratoralbums;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tists", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorartists;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'f':
                    if ((String.Compare(field_name, 1, "eaturedStations", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorfeaturedStations;
                    break;
                case 'k':
                    if ((String.Compare(field_name, 1, "eywords", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorkeywords;
                    break;
                case 'p':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "aylists", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorplaylists;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "dcasts", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorpodcasts;
                            break;
                        default:
                            break;
                      }
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "tations", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorstations;
                    break;
                case 't':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "lk", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 5, "hows", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratortalkShows;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 5, "hemes", 0, 5, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratortalkThemes;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "acks", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratortracks;
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
            fieldGeneratortracks = new FieldHoldingGeneratortracks("field \"tracks\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorkeywords = new FieldHoldingGeneratorkeywords("field \"keywords\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorartists = new FieldHoldingGeneratorartists("field \"artists\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratoralbums = new FieldHoldingGeneratoralbums("field \"albums\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorstations = new FieldHoldingGeneratorstations("field \"stations\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorplaylists = new FieldHoldingGeneratorplaylists("field \"playlists\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorpodcasts = new FieldHoldingGeneratorpodcasts("field \"podcasts\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorfeaturedStations = new FieldHoldingGeneratorfeaturedStations("field \"featuredStations\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratortalkShows = new FieldHoldingGeneratortalkShows("field \"talkShows\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratortalkThemes = new FieldHoldingGeneratortalkThemes("field \"talkThemes\" of the IHeartRadioSearchAllAPIResponseCounts class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponseCounts class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratortracks = new FieldHoldingGeneratortracks("field \"tracks\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorkeywords = new FieldHoldingGeneratorkeywords("field \"keywords\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorartists = new FieldHoldingGeneratorartists("field \"artists\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratoralbums = new FieldHoldingGeneratoralbums("field \"albums\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorstations = new FieldHoldingGeneratorstations("field \"stations\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorplaylists = new FieldHoldingGeneratorplaylists("field \"playlists\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorpodcasts = new FieldHoldingGeneratorpodcasts("field \"podcasts\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratorfeaturedStations = new FieldHoldingGeneratorfeaturedStations("field \"featuredStations\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratortalkShows = new FieldHoldingGeneratortalkShows("field \"talkShows\" of the IHeartRadioSearchAllAPIResponseCounts class");
            fieldGeneratortalkThemes = new FieldHoldingGeneratortalkThemes("field \"talkThemes\" of the IHeartRadioSearchAllAPIResponseCounts class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponseCounts class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratortracks.reset();
            fieldGeneratorkeywords.reset();
            fieldGeneratorartists.reset();
            fieldGeneratoralbums.reset();
            fieldGeneratorstations.reset();
            fieldGeneratorplaylists.reset();
            fieldGeneratorpodcasts.reset();
            fieldGeneratorfeaturedStations.reset();
            fieldGeneratortalkShows.reset();
            fieldGeneratortalkThemes.reset();
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
        protected override void handle_result(IHeartRadioSearchAllAPIResponseCountsJSON  result)
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
        public IHeartRadioSearchAllAPIResponseCountsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponseCountsJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponseCountsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponseCountsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponseCountsJSON>();
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
    public List<IHeartRadioSearchAllAPIResponseCountsJSON> value;
  };
  };
