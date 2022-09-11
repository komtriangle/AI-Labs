/* file "HomeAutomationActionResponseListJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationActionResponseListJSON : JSONBase
  {
    public class TypeDevicesJSON : JSONBase
      {
        private bool flagHasDevice;
        private HomeAutomationDeviceJSON  storeDevice;
        private bool flagHasResponse;
        private HomeAutomationActionResponseJSON  storeResponse;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDevice(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HomeAutomationDeviceJSON convert_classy = HomeAutomationDeviceJSON.from_json(json_value, ignore_extras, true);
            setDevice(convert_classy);
          }


        private void  fromJSONResponse(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HomeAutomationActionResponseJSON convert_classy = HomeAutomationActionResponseJSON.from_json(json_value, ignore_extras, true);
            setResponse(convert_classy);
          }


        public TypeDevicesJSON()
          {
            flagHasDevice = false;
            flagHasResponse = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDevice()
          {
            return flagHasDevice;
          }

        public HomeAutomationDeviceJSON   getDevice()
          {
            Debug.Assert(flagHasDevice);
            return storeDevice;
          }

        public bool  hasResponse()
          {
            return flagHasResponse;
          }

        public HomeAutomationActionResponseJSON   getResponse()
          {
            Debug.Assert(flagHasResponse);
            return storeResponse;
          }


        public virtual int extraTypeDevicesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDevicesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDevicesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDevicesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDevice(HomeAutomationDeviceJSON  new_value)
          {
            if (flagHasDevice)
              {
              }
            flagHasDevice = true;
            storeDevice = new_value;
          }
        public void unsetDevice()
          {
            if (flagHasDevice)
              {
              }
            flagHasDevice = false;
          }
        public void setResponse(HomeAutomationActionResponseJSON  new_value)
          {
            if (flagHasResponse)
              {
              }
            flagHasResponse = true;
            storeResponse = new_value;
          }
        public void unsetResponse()
          {
            if (flagHasResponse)
              {
              }
            flagHasResponse = false;
          }

        public virtual void extraTypeDevicesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDevicesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDevicesLookup(key);
            if (old_field == null)
              {
                extraTypeDevicesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasDevice);
            if (flagHasDevice)
              {
                handler.start_pair("Device");
                if (partial_allowed)
                    storeDevice.write_partial_as_json(handler);
                else
                    storeDevice.write_as_json(handler);
              }
            if (flagHasResponse)
              {
                handler.start_pair("Response");
                if (partial_allowed)
                    storeResponse.write_partial_as_json(handler);
                else
                    storeResponse.write_as_json(handler);
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
            if (!(hasDevice()))
              {
                return "When parsing the object for %what%, the \"Device\" field was missing.";
              }
            return null;
          }

        public static TypeDevicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDevicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDevices", ignore_extras);
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
        public static TypeDevicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDevicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDevicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDevices", ignore_extras);
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
        public static TypeDevicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDevicesJSON from_text(string text, bool ignore_extras)
          {
            TypeDevicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDevices", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDevicesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDevicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDevicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDevices", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private HomeAutomationDeviceJSON.HoldingGenerator fieldGeneratorDevice;
            private HomeAutomationActionResponseJSON.HoldingGenerator fieldGeneratorResponse;
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
                TypeDevicesJSON result = new TypeDevicesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDevicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDevicesJSON result)
              {
                if (fieldGeneratorDevice.have_value)
                  {
                    result.setDevice(fieldGeneratorDevice.value);
                    fieldGeneratorDevice.have_value = false;
                  }
                else if ((!(result.hasDevice())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Device\" field was missing.");
                  }
                if (fieldGeneratorResponse.have_value)
                  {
                    result.setResponse(fieldGeneratorResponse.value);
                    fieldGeneratorResponse.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDevicesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "evice", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorDevice;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "esponse", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorResponse;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDevice = new HomeAutomationDeviceJSON.HoldingGenerator("field \"Device\" of the TypeDevices class", ignore_extras);
                fieldGeneratorResponse = new HomeAutomationActionResponseJSON.HoldingGenerator("field \"Response\" of the TypeDevices class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDevices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDevice = new HomeAutomationDeviceJSON.HoldingGenerator("field \"Device\" of the TypeDevices class", false);
                fieldGeneratorResponse = new HomeAutomationActionResponseJSON.HoldingGenerator("field \"Response\" of the TypeDevices class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDevices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDevice.reset();
                fieldGeneratorResponse.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorDevice.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorResponse.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorDevice.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorResponse.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDevicesJSON  result)
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
            public TypeDevicesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDevicesJSON  result)
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
        protected virtual void handle_result(List<TypeDevicesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDevicesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDevicesJSON>();
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
        public List<TypeDevicesJSON> value;
      };
      };
    public class TypeGroupsJSON : JSONBase
      {
        private bool flagHasGroup;
        private HomeAutomationGroupJSON  storeGroup;
        private bool flagHasResponse;
        private HomeAutomationActionResponseJSON  storeResponse;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONGroup(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HomeAutomationGroupJSON convert_classy = HomeAutomationGroupJSON.from_json(json_value, ignore_extras, true);
            setGroup(convert_classy);
          }


        private void  fromJSONResponse(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            HomeAutomationActionResponseJSON convert_classy = HomeAutomationActionResponseJSON.from_json(json_value, ignore_extras, true);
            setResponse(convert_classy);
          }


        public TypeGroupsJSON()
          {
            flagHasGroup = false;
            flagHasResponse = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasGroup()
          {
            return flagHasGroup;
          }

        public HomeAutomationGroupJSON   getGroup()
          {
            Debug.Assert(flagHasGroup);
            return storeGroup;
          }

        public bool  hasResponse()
          {
            return flagHasResponse;
          }

        public HomeAutomationActionResponseJSON   getResponse()
          {
            Debug.Assert(flagHasResponse);
            return storeResponse;
          }


        public virtual int extraTypeGroupsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeGroupsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeGroupsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeGroupsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setGroup(HomeAutomationGroupJSON  new_value)
          {
            if (flagHasGroup)
              {
              }
            flagHasGroup = true;
            storeGroup = new_value;
          }
        public void unsetGroup()
          {
            if (flagHasGroup)
              {
              }
            flagHasGroup = false;
          }
        public void setResponse(HomeAutomationActionResponseJSON  new_value)
          {
            if (flagHasResponse)
              {
              }
            flagHasResponse = true;
            storeResponse = new_value;
          }
        public void unsetResponse()
          {
            if (flagHasResponse)
              {
              }
            flagHasResponse = false;
          }

        public virtual void extraTypeGroupsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeGroupsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeGroupsLookup(key);
            if (old_field == null)
              {
                extraTypeGroupsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasGroup);
            if (flagHasGroup)
              {
                handler.start_pair("Group");
                if (partial_allowed)
                    storeGroup.write_partial_as_json(handler);
                else
                    storeGroup.write_as_json(handler);
              }
            if (flagHasResponse)
              {
                handler.start_pair("Response");
                if (partial_allowed)
                    storeResponse.write_partial_as_json(handler);
                else
                    storeResponse.write_as_json(handler);
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
            if (!(hasGroup()))
              {
                return "When parsing the object for %what%, the \"Group\" field was missing.";
              }
            return null;
          }

        public static TypeGroupsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeGroupsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeGroups", ignore_extras);
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
        public static TypeGroupsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeGroupsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeGroupsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeGroups", ignore_extras);
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
        public static TypeGroupsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeGroupsJSON from_text(string text, bool ignore_extras)
          {
            TypeGroupsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeGroups", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeGroupsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeGroupsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeGroupsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeGroups", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private HomeAutomationGroupJSON.HoldingGenerator fieldGeneratorGroup;
            private HomeAutomationActionResponseJSON.HoldingGenerator fieldGeneratorResponse;
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
                TypeGroupsJSON result = new TypeGroupsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeGroupsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeGroupsJSON result)
              {
                if (fieldGeneratorGroup.have_value)
                  {
                    result.setGroup(fieldGeneratorGroup.value);
                    fieldGeneratorGroup.have_value = false;
                  }
                else if ((!(result.hasGroup())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Group\" field was missing.");
                  }
                if (fieldGeneratorResponse.have_value)
                  {
                    result.setResponse(fieldGeneratorResponse.value);
                    fieldGeneratorResponse.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeGroupsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'G':
                        if ((String.Compare(field_name, 1, "roup", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorGroup;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "esponse", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorResponse;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorGroup = new HomeAutomationGroupJSON.HoldingGenerator("field \"Group\" of the TypeGroups class", ignore_extras);
                fieldGeneratorResponse = new HomeAutomationActionResponseJSON.HoldingGenerator("field \"Response\" of the TypeGroups class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeGroups class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorGroup = new HomeAutomationGroupJSON.HoldingGenerator("field \"Group\" of the TypeGroups class", false);
                fieldGeneratorResponse = new HomeAutomationActionResponseJSON.HoldingGenerator("field \"Response\" of the TypeGroups class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeGroups class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorGroup.reset();
                fieldGeneratorResponse.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorGroup.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorResponse.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorGroup.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorResponse.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeGroupsJSON  result)
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
            public TypeGroupsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeGroupsJSON  result)
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
        protected virtual void handle_result(List<TypeGroupsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeGroupsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeGroupsJSON>();
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
        public List<TypeGroupsJSON> value;
      };
      };
    private bool flagHasDevices;
    private List< TypeDevicesJSON  > storeDevices;
    private bool flagHasGroups;
    private List< TypeGroupsJSON  > storeGroups;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDevices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Devices of HomeAutomationActionResponseListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeDevicesJSON  > vector_Devices1 = new List< TypeDevicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeDevicesJSON convert_classy = TypeDevicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Devices1.Add(convert_classy);
          }
        initDevices();
        for (int num1 = 0; num1 < vector_Devices1.Count; ++num1)
            appendDevices(vector_Devices1[num1]);
        for (int num1 = 0; num1 < vector_Devices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Groups of HomeAutomationActionResponseListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeGroupsJSON  > vector_Groups1 = new List< TypeGroupsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeGroupsJSON convert_classy = TypeGroupsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Groups1.Add(convert_classy);
          }
        initGroups();
        for (int num2 = 0; num2 < vector_Groups1.Count; ++num2)
            appendGroups(vector_Groups1[num2]);
        for (int num1 = 0; num1 < vector_Groups1.Count; ++num1)
          {
          }
      }


    public HomeAutomationActionResponseListJSON()
      {
        flagHasDevices = false;
        flagHasGroups = false;
        storeDevices = new List< TypeDevicesJSON  >();
        storeGroups = new List< TypeGroupsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDevices()
      {
        return flagHasDevices;
      }

    public int  countOfDevices()
      {
        Debug.Assert(flagHasDevices);
        return storeDevices.Count;
      }

    public TypeDevicesJSON   elementOfDevices(int element_num)
      {
        Debug.Assert(flagHasDevices);
        return storeDevices[element_num];
      }

    public List< TypeDevicesJSON  >  getDevices()
      {
        Debug.Assert(flagHasDevices);
        return storeDevices;
      }

    public bool  hasGroups()
      {
        return flagHasGroups;
      }

    public int  countOfGroups()
      {
        Debug.Assert(flagHasGroups);
        return storeGroups.Count;
      }

    public TypeGroupsJSON   elementOfGroups(int element_num)
      {
        Debug.Assert(flagHasGroups);
        return storeGroups[element_num];
      }

    public List< TypeGroupsJSON  >  getGroups()
      {
        Debug.Assert(flagHasGroups);
        return storeGroups;
      }


    public virtual int extraHomeAutomationActionResponseListComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationActionResponseListComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResponseListComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationActionResponseListLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initDevices()
      {
        if (flagHasDevices)
          {
            for (int num1 = 0; num1 < storeDevices.Count; ++num1)
              {
              }
          }
        flagHasDevices = true;
        storeDevices.Clear();
      }
    public void appendDevices(TypeDevicesJSON  to_append)
      {
        if (!flagHasDevices)
          {
            flagHasDevices = true;
            storeDevices.Clear();
          }
        Debug.Assert(flagHasDevices);
        storeDevices.Add(to_append);
      }
    public void unsetDevices()
      {
        if (flagHasDevices)
          {
            for (int num2 = 0; num2 < storeDevices.Count; ++num2)
              {
              }
          }
        flagHasDevices = false;
        storeDevices.Clear();
      }
    public void initGroups()
      {
        if (flagHasGroups)
          {
            for (int num3 = 0; num3 < storeGroups.Count; ++num3)
              {
              }
          }
        flagHasGroups = true;
        storeGroups.Clear();
      }
    public void appendGroups(TypeGroupsJSON  to_append)
      {
        if (!flagHasGroups)
          {
            flagHasGroups = true;
            storeGroups.Clear();
          }
        Debug.Assert(flagHasGroups);
        storeGroups.Add(to_append);
      }
    public void unsetGroups()
      {
        if (flagHasGroups)
          {
            for (int num4 = 0; num4 < storeGroups.Count; ++num4)
              {
              }
          }
        flagHasGroups = false;
        storeGroups.Clear();
      }

    public virtual void extraHomeAutomationActionResponseListAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationActionResponseListSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationActionResponseListLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationActionResponseListAppendPair(key, new_component);
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
        if (flagHasDevices)
          {
            handler.start_pair("Devices");
            handler.start_array();
            for (int num1 = 0; num1 < storeDevices.Count; ++num1)
              {
                if (partial_allowed)
                    storeDevices[num1].write_partial_as_json(handler);
                else
                    storeDevices[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGroups)
          {
            handler.start_pair("Groups");
            handler.start_array();
            for (int num2 = 0; num2 < storeGroups.Count; ++num2)
              {
                if (partial_allowed)
                    storeGroups[num2].write_partial_as_json(handler);
                else
                    storeGroups[num2].write_as_json(handler);
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

    public static HomeAutomationActionResponseListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResponseListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponseList", ignore_extras);
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
    public static HomeAutomationActionResponseListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResponseListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationActionResponseListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponseList", ignore_extras);
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
    public static HomeAutomationActionResponseListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationActionResponseListJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationActionResponseListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponseList", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationActionResponseListJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationActionResponseListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationActionResponseListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationActionResponseList", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeDevicesJSON.HoldingArrayGenerator fieldGeneratorDevices;
        private TypeGroupsJSON.HoldingArrayGenerator fieldGeneratorGroups;
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
            HomeAutomationActionResponseListJSON result = new HomeAutomationActionResponseListJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationActionResponseListAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationActionResponseListJSON result)
          {
            if (fieldGeneratorDevices.have_value)
              {
                result.initDevices();
                int count = fieldGeneratorDevices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDevices(fieldGeneratorDevices.value[num]);
                  }
                fieldGeneratorDevices.value.Clear();
                fieldGeneratorDevices.have_value = false;
              }
            if (fieldGeneratorGroups.have_value)
              {
                result.initGroups();
                int count = fieldGeneratorGroups.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGroups(fieldGeneratorGroups.value[num]);
                  }
                fieldGeneratorGroups.value.Clear();
                fieldGeneratorGroups.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationActionResponseListJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "evices", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorDevices;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "roups", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorGroups;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDevices = new TypeDevicesJSON.HoldingArrayGenerator("field \"Devices\" of the HomeAutomationActionResponseList class", ignore_extras);
            fieldGeneratorGroups = new TypeGroupsJSON.HoldingArrayGenerator("field \"Groups\" of the HomeAutomationActionResponseList class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationActionResponseList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDevices = new TypeDevicesJSON.HoldingArrayGenerator("field \"Devices\" of the HomeAutomationActionResponseList class", false);
            fieldGeneratorGroups = new TypeGroupsJSON.HoldingArrayGenerator("field \"Groups\" of the HomeAutomationActionResponseList class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationActionResponseList class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDevices.reset();
            fieldGeneratorGroups.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDevices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGroups.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDevices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGroups.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationActionResponseListJSON  result)
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
        public HomeAutomationActionResponseListJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationActionResponseListJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationActionResponseListJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationActionResponseListJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationActionResponseListJSON>();
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
    public List<HomeAutomationActionResponseListJSON> value;
  };
  };
