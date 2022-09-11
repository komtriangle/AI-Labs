/* file "SuggestedStationsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SuggestedStationsJSON : JSONBase
  {
    public class TypeStationsJSON : JSONBase
      {
        public enum TypeAttributionKnownValues
          {
            Attribution_IHeartRadio,
            Attribution_Audacy,
            Attribution__none
          };
        public struct TypeAttribution
          {
            public bool in_known_list;
            public string string_value;
            public TypeAttributionKnownValues list_value;
          };

        public static TypeAttributionKnownValues  stringToAttribution(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "udacy", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeAttributionKnownValues.Attribution_Audacy;
                    break;
                case 'I':
                    if ((String.Compare(chars, 1, "HeartRadio", 0, 10, false) == 0) && (chars.Length == 11))
                        return TypeAttributionKnownValues.Attribution_IHeartRadio;
                    break;
                default:
                    break;
              }
            return TypeAttributionKnownValues.Attribution__none;
          }

        public static string  stringFromAttribution(TypeAttributionKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeAttributionKnownValues.Attribution_IHeartRadio:
                    return "IHeartRadio";
                case TypeAttributionKnownValues.Attribution_Audacy:
                    return "Audacy";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeDeliveryKnownValues
          {
            Delivery_DAB,
            Delivery_FM,
            Delivery_AM,
            Delivery_TerrestrialRF,
            Delivery_Satellite,
            Delivery_IP,
            Delivery__none
          };
        public struct TypeDelivery
          {
            public bool in_known_list;
            public string string_value;
            public TypeDeliveryKnownValues list_value;
          };

        public static TypeDeliveryKnownValues  stringToDelivery(string chars)
          {
            switch (chars[0])
              {
                case 'A':
                    if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeDeliveryKnownValues.Delivery_AM;
                    break;
                case 'D':
                    if ((String.Compare(chars, 1, "AB", 0, 2, false) == 0) && (chars.Length == 3))
                        return TypeDeliveryKnownValues.Delivery_DAB;
                    break;
                case 'F':
                    if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeDeliveryKnownValues.Delivery_FM;
                    break;
                case 'I':
                    if ((String.Compare(chars, 1, "P", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeDeliveryKnownValues.Delivery_IP;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "atellite", 0, 8, false) == 0) && (chars.Length == 9))
                        return TypeDeliveryKnownValues.Delivery_Satellite;
                    break;
                case 'T':
                    if ((String.Compare(chars, 1, "errestrialRF", 0, 12, false) == 0) && (chars.Length == 13))
                        return TypeDeliveryKnownValues.Delivery_TerrestrialRF;
                    break;
                default:
                    break;
              }
            return TypeDeliveryKnownValues.Delivery__none;
          }

        public static string  stringFromDelivery(TypeDeliveryKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeDeliveryKnownValues.Delivery_DAB:
                    return "DAB";
                case TypeDeliveryKnownValues.Delivery_FM:
                    return "FM";
                case TypeDeliveryKnownValues.Delivery_AM:
                    return "AM";
                case TypeDeliveryKnownValues.Delivery_TerrestrialRF:
                    return "TerrestrialRF";
                case TypeDeliveryKnownValues.Delivery_Satellite:
                    return "Satellite";
                case TypeDeliveryKnownValues.Delivery_IP:
                    return "IP";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasName;
        private string storeName;
        private bool flagHasLogoURL;
        private string storeLogoURL;
        private bool flagHasAttribution;
        private TypeAttribution storeAttribution;
        private bool flagHasDelivery;
        private TypeDelivery storeDelivery;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Name of TypeStationsJSON is not a string.");
            setName(json_string.getData());
          }


        private void  fromJSONLogoURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LogoURL of TypeStationsJSON is not a string.");
            setLogoURL(json_string.getData());
          }


        private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Attribution of TypeStationsJSON is not a string.");
            TypeAttribution the_open_enum = new TypeAttribution();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "udacy", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeAttributionKnownValues.Attribution_Audacy;
                            goto open_enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 1, "HeartRadio", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeAttributionKnownValues.Attribution_IHeartRadio;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setAttribution(the_open_enum);
          }


        private void  fromJSONDelivery(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Delivery of TypeStationsJSON is not a string.");
            TypeDelivery the_open_enum = new TypeDelivery();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_AM;
                            goto open_enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "AB", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_DAB;
                            goto open_enum_is_done;
                          }
                    break;
                case 'F':
                    if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_FM;
                            goto open_enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 1, "P", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_IP;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "atellite", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_Satellite;
                            goto open_enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "errestrialRF", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDeliveryKnownValues.Delivery_TerrestrialRF;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setDelivery(the_open_enum);
          }


        public TypeStationsJSON()
          {
            flagHasName = false;
            flagHasLogoURL = false;
            flagHasAttribution = false;
            flagHasDelivery = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasName()
          {
            return flagHasName;
          }

        public string  getName()
          {
            Debug.Assert(flagHasName);
            return storeName;
          }

        public bool  hasLogoURL()
          {
            return flagHasLogoURL;
          }

        public string  getLogoURL()
          {
            Debug.Assert(flagHasLogoURL);
            return storeLogoURL;
          }

        public bool  hasAttribution()
          {
            return flagHasAttribution;
          }

        public TypeAttribution  getAttribution()
          {
            Debug.Assert(flagHasAttribution);
            return storeAttribution;
          }

        public string  getAttributionAsString()
          {
            TypeAttribution result = getAttribution();
            if (result.in_known_list)
                return stringFromAttribution(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasDelivery()
          {
            return flagHasDelivery;
          }

        public TypeDelivery  getDelivery()
          {
            Debug.Assert(flagHasDelivery);
            return storeDelivery;
          }

        public string  getDeliveryAsString()
          {
            TypeDelivery result = getDelivery();
            if (result.in_known_list)
                return stringFromDelivery(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeStationsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStationsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStationsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStationsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setName(string new_value)
          {
            flagHasName = true;
            storeName = new_value;
          }
        public void unsetName()
          {
            flagHasName = false;
          }
        public void setLogoURL(string new_value)
          {
            flagHasLogoURL = true;
            storeLogoURL = new_value;
          }
        public void unsetLogoURL()
          {
            flagHasLogoURL = false;
          }
        public void setAttribution(TypeAttribution new_value)
          {
            flagHasAttribution = true;
            storeAttribution = new_value;
          }
        public void setAttribution(string chars)
          {
            TypeAttributionKnownValues known = stringToAttribution(chars);
            TypeAttribution new_value = new TypeAttribution();
            if (known == TypeAttributionKnownValues.Attribution__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setAttribution(new_value);
          }
        public void setAttribution(TypeAttributionKnownValues new_value)
          {
            TypeAttribution new_full_value = new TypeAttribution();
            Debug.Assert(new_value != TypeAttributionKnownValues.Attribution__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setAttribution(new_full_value);
          }
        public void unsetAttribution()
          {
            flagHasAttribution = false;
          }
        public void setDelivery(TypeDelivery new_value)
          {
            flagHasDelivery = true;
            storeDelivery = new_value;
          }
        public void setDelivery(string chars)
          {
            TypeDeliveryKnownValues known = stringToDelivery(chars);
            TypeDelivery new_value = new TypeDelivery();
            if (known == TypeDeliveryKnownValues.Delivery__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setDelivery(new_value);
          }
        public void setDelivery(TypeDeliveryKnownValues new_value)
          {
            TypeDelivery new_full_value = new TypeDelivery();
            Debug.Assert(new_value != TypeDeliveryKnownValues.Delivery__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setDelivery(new_full_value);
          }
        public void unsetDelivery()
          {
            flagHasDelivery = false;
          }

        public virtual void extraTypeStationsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStationsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStationsLookup(key);
            if (old_field == null)
              {
                extraTypeStationsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasName);
            if (flagHasName)
              {
                handler.start_pair("Name");
                handler.string_value(storeName);
              }
            if (flagHasLogoURL)
              {
                handler.start_pair("LogoURL");
                handler.string_value(storeLogoURL);
              }
            if (flagHasAttribution)
              {
                handler.start_pair("Attribution");
                if (storeAttribution.in_known_list)
                  {
                    switch (storeAttribution.list_value)
                      {
                        case TypeAttributionKnownValues.Attribution_IHeartRadio:
                            handler.string_value("IHeartRadio");
                            break;
                        case TypeAttributionKnownValues.Attribution_Audacy:
                            handler.string_value("Audacy");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeAttribution.string_value);
                  }
              }
            if (flagHasDelivery)
              {
                handler.start_pair("Delivery");
                if (storeDelivery.in_known_list)
                  {
                    switch (storeDelivery.list_value)
                      {
                        case TypeDeliveryKnownValues.Delivery_DAB:
                            handler.string_value("DAB");
                            break;
                        case TypeDeliveryKnownValues.Delivery_FM:
                            handler.string_value("FM");
                            break;
                        case TypeDeliveryKnownValues.Delivery_AM:
                            handler.string_value("AM");
                            break;
                        case TypeDeliveryKnownValues.Delivery_TerrestrialRF:
                            handler.string_value("TerrestrialRF");
                            break;
                        case TypeDeliveryKnownValues.Delivery_Satellite:
                            handler.string_value("Satellite");
                            break;
                        case TypeDeliveryKnownValues.Delivery_IP:
                            handler.string_value("IP");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeDelivery.string_value);
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
            if (!(hasName()))
              {
                return "When parsing the object for %what%, the \"Name\" field was missing.";
              }
            return null;
          }

        public static TypeStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
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
        public static TypeStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
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
        public static TypeStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStationsJSON from_text(string text, bool ignore_extras)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStationsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStations", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorName;
            private JSONHoldingStringGenerator fieldGeneratorLogoURL;
        private abstract class FieldGeneratorAttribution : JSONStringGenerator
              {
                protected FieldGeneratorAttribution(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorAttribution()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeAttributionKnownValues known = stringToAttribution(result);
                    TypeAttribution new_value = new TypeAttribution();
                    if (known == TypeAttributionKnownValues.Attribution__none)
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
                protected abstract void handle_result(TypeAttribution result);
              };
        private class FieldHoldingGeneratorAttribution : FieldGeneratorAttribution
      {
        protected override void handle_result(TypeAttribution result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorAttribution(String what)
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
        public TypeAttribution value;
      };
        private class FieldHoldingArrayGeneratorAttribution : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorAttribution
          {
            private FieldHoldingArrayGeneratorAttribution top;

            protected override void handle_result(TypeAttribution result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorAttribution init_top)
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
        protected virtual void handle_result(List<TypeAttribution> result)
          {
          }

        public FieldHoldingArrayGeneratorAttribution(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeAttribution>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorAttribution()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeAttribution>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeAttribution> value;
      };
            private FieldHoldingGeneratorAttribution fieldGeneratorAttribution;
        private abstract class FieldGeneratorDelivery : JSONStringGenerator
              {
                protected FieldGeneratorDelivery(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorDelivery()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeDeliveryKnownValues known = stringToDelivery(result);
                    TypeDelivery new_value = new TypeDelivery();
                    if (known == TypeDeliveryKnownValues.Delivery__none)
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
                protected abstract void handle_result(TypeDelivery result);
              };
        private class FieldHoldingGeneratorDelivery : FieldGeneratorDelivery
      {
        protected override void handle_result(TypeDelivery result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorDelivery(String what)
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
        public TypeDelivery value;
      };
        private class FieldHoldingArrayGeneratorDelivery : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorDelivery
          {
            private FieldHoldingArrayGeneratorDelivery top;

            protected override void handle_result(TypeDelivery result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorDelivery init_top)
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
        protected virtual void handle_result(List<TypeDelivery> result)
          {
          }

        public FieldHoldingArrayGeneratorDelivery(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDelivery>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorDelivery()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDelivery>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeDelivery> value;
      };
            private FieldHoldingGeneratorDelivery fieldGeneratorDelivery;
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
                TypeStationsJSON result = new TypeStationsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStationsJSON result)
              {
                if (fieldGeneratorName.have_value)
                  {
                    result.setName(fieldGeneratorName.value);
                    fieldGeneratorName.have_value = false;
                  }
                else if ((!(result.hasName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Name\" field was missing.");
                  }
                if (fieldGeneratorLogoURL.have_value)
                  {
                    result.setLogoURL(fieldGeneratorLogoURL.value);
                    fieldGeneratorLogoURL.have_value = false;
                  }
                if (fieldGeneratorAttribution.have_value)
                  {
                    result.setAttribution(fieldGeneratorAttribution.value);
                    fieldGeneratorAttribution.have_value = false;
                  }
                if (fieldGeneratorDelivery.have_value)
                  {
                    result.setDelivery(fieldGeneratorDelivery.value);
                    fieldGeneratorDelivery.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeStationsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorAttribution;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "elivery", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDelivery;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "ogoURL", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorLogoURL;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorName;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeStations class");
                fieldGeneratorLogoURL = new JSONHoldingStringGenerator("field \"LogoURL\" of the TypeStations class");
                fieldGeneratorAttribution = new FieldHoldingGeneratorAttribution("field \"Attribution\" of the TypeStations class");
                fieldGeneratorDelivery = new FieldHoldingGeneratorDelivery("field \"Delivery\" of the TypeStations class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeStations class");
                fieldGeneratorLogoURL = new JSONHoldingStringGenerator("field \"LogoURL\" of the TypeStations class");
                fieldGeneratorAttribution = new FieldHoldingGeneratorAttribution("field \"Attribution\" of the TypeStations class");
                fieldGeneratorDelivery = new FieldHoldingGeneratorDelivery("field \"Delivery\" of the TypeStations class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorName.reset();
                fieldGeneratorLogoURL.reset();
                fieldGeneratorAttribution.reset();
                fieldGeneratorDelivery.reset();
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
            protected override void handle_result(TypeStationsJSON  result)
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
            public TypeStationsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStationsJSON  result)
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
        protected virtual void handle_result(List<TypeStationsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStationsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStationsJSON>();
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
        public List<TypeStationsJSON> value;
      };
      };
    private bool flagHasStations;
    private List< TypeStationsJSON  > storeStations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of SuggestedStationsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Stations of SuggestedStationsJSON has too few elements.");
        List< TypeStationsJSON  > vector_Stations1 = new List< TypeStationsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeStationsJSON convert_classy = TypeStationsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        Debug.Assert(vector_Stations1.Count >= 1);
        initStations();
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
            appendStations(vector_Stations1[num1]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    public SuggestedStationsJSON()
      {
        flagHasStations = false;
        storeStations = new List< TypeStationsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public TypeStationsJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< TypeStationsJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }


    public virtual int extraSuggestedStationsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSuggestedStationsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSuggestedStationsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSuggestedStationsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(TypeStationsJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }

    public virtual void extraSuggestedStationsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSuggestedStationsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSuggestedStationsLookup(key);
        if (old_field == null)
          {
            extraSuggestedStationsAppendPair(key, new_component);
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
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            Debug.Assert(storeStations.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
                if (partial_allowed)
                    storeStations[num1].write_partial_as_json(handler);
                else
                    storeStations[num1].write_as_json(handler);
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
        return null;
      }

    public static SuggestedStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SuggestedStationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SuggestedStations", ignore_extras);
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
    public static SuggestedStationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SuggestedStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SuggestedStationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SuggestedStations", ignore_extras);
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
    public static SuggestedStationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SuggestedStationsJSON from_text(string text, bool ignore_extras)
      {
        SuggestedStationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SuggestedStations", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SuggestedStationsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SuggestedStationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SuggestedStationsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SuggestedStations", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeStationsJSON.HoldingArrayGenerator fieldGeneratorStations;
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
            SuggestedStationsJSON result = new SuggestedStationsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSuggestedStationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SuggestedStationsJSON result)
          {
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
          }
        protected abstract void handle_result(SuggestedStationsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Stations", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorStations;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStations = new TypeStationsJSON.HoldingArrayGenerator("field \"Stations\" of the SuggestedStations class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SuggestedStations class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStations = new TypeStationsJSON.HoldingArrayGenerator("field \"Stations\" of the SuggestedStations class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SuggestedStations class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SuggestedStationsJSON  result)
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
        public SuggestedStationsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SuggestedStationsJSON  result)
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
    protected virtual void handle_result(List<SuggestedStationsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SuggestedStationsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SuggestedStationsJSON>();
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
    public List<SuggestedStationsJSON> value;
  };
  };
