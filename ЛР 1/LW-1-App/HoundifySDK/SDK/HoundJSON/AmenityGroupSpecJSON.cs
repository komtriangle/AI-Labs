/* file "AmenityGroupSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AmenityGroupSpecJSON : JSONBase
  {
    public class TypeAmenityGroupJSON : JSONBase
      {
        private bool flagHasAmenityAlias;
        private string storeAmenityAlias;
        private bool flagHasAmenityName;
        private string storeAmenityName;
        private bool flagHasAmenitySpokenNameSingular;
        private string storeAmenitySpokenNameSingular;
        private bool flagHasAmenitySpokenNamePlural;
        private string storeAmenitySpokenNamePlural;
        private bool flagHasAmenityTopLevelName;
        private string storeAmenityTopLevelName;
        private bool flagHasAmenityTopLevelSpokenNameSingular;
        private string storeAmenityTopLevelSpokenNameSingular;
        private bool flagHasAmenityTopLevelSpokenNamePlural;
        private string storeAmenityTopLevelSpokenNamePlural;


        private void  fromJSONAmenityAlias(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityAlias of TypeAmenityGroupJSON is not a string.");
            setAmenityAlias(json_string.getData());
          }


        private void  fromJSONAmenityName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityName of TypeAmenityGroupJSON is not a string.");
            setAmenityName(json_string.getData());
          }


        private void  fromJSONAmenitySpokenNameSingular(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenitySpokenNameSingular of TypeAmenityGroupJSON is not a string.");
            setAmenitySpokenNameSingular(json_string.getData());
          }


        private void  fromJSONAmenitySpokenNamePlural(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenitySpokenNamePlural of TypeAmenityGroupJSON is not a string.");
            setAmenitySpokenNamePlural(json_string.getData());
          }


        private void  fromJSONAmenityTopLevelName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityTopLevelName of TypeAmenityGroupJSON is not a string.");
            setAmenityTopLevelName(json_string.getData());
          }


        private void  fromJSONAmenityTopLevelSpokenNameSingular(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityTopLevelSpokenNameSingular of TypeAmenityGroupJSON is not a string.");
            setAmenityTopLevelSpokenNameSingular(json_string.getData());
          }


        private void  fromJSONAmenityTopLevelSpokenNamePlural(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field AmenityTopLevelSpokenNamePlural of TypeAmenityGroupJSON is not a string.");
            setAmenityTopLevelSpokenNamePlural(json_string.getData());
          }


        public TypeAmenityGroupJSON()
          {
            flagHasAmenityAlias = false;
            flagHasAmenityName = false;
            flagHasAmenitySpokenNameSingular = false;
            flagHasAmenitySpokenNamePlural = false;
            flagHasAmenityTopLevelName = false;
            flagHasAmenityTopLevelSpokenNameSingular = false;
            flagHasAmenityTopLevelSpokenNamePlural = false;
          }

        public bool  hasAmenityAlias()
          {
            return flagHasAmenityAlias;
          }

        public string  getAmenityAlias()
          {
            Debug.Assert(flagHasAmenityAlias);
            return storeAmenityAlias;
          }

        public bool  hasAmenityName()
          {
            return flagHasAmenityName;
          }

        public string  getAmenityName()
          {
            Debug.Assert(flagHasAmenityName);
            return storeAmenityName;
          }

        public bool  hasAmenitySpokenNameSingular()
          {
            return flagHasAmenitySpokenNameSingular;
          }

        public string  getAmenitySpokenNameSingular()
          {
            Debug.Assert(flagHasAmenitySpokenNameSingular);
            return storeAmenitySpokenNameSingular;
          }

        public bool  hasAmenitySpokenNamePlural()
          {
            return flagHasAmenitySpokenNamePlural;
          }

        public string  getAmenitySpokenNamePlural()
          {
            Debug.Assert(flagHasAmenitySpokenNamePlural);
            return storeAmenitySpokenNamePlural;
          }

        public bool  hasAmenityTopLevelName()
          {
            return flagHasAmenityTopLevelName;
          }

        public string  getAmenityTopLevelName()
          {
            Debug.Assert(flagHasAmenityTopLevelName);
            return storeAmenityTopLevelName;
          }

        public bool  hasAmenityTopLevelSpokenNameSingular()
          {
            return flagHasAmenityTopLevelSpokenNameSingular;
          }

        public string  getAmenityTopLevelSpokenNameSingular()
          {
            Debug.Assert(flagHasAmenityTopLevelSpokenNameSingular);
            return storeAmenityTopLevelSpokenNameSingular;
          }

        public bool  hasAmenityTopLevelSpokenNamePlural()
          {
            return flagHasAmenityTopLevelSpokenNamePlural;
          }

        public string  getAmenityTopLevelSpokenNamePlural()
          {
            Debug.Assert(flagHasAmenityTopLevelSpokenNamePlural);
            return storeAmenityTopLevelSpokenNamePlural;
          }



        public void setAmenityAlias(string new_value)
          {
            flagHasAmenityAlias = true;
            storeAmenityAlias = new_value;
          }
        public void unsetAmenityAlias()
          {
            flagHasAmenityAlias = false;
          }
        public void setAmenityName(string new_value)
          {
            flagHasAmenityName = true;
            storeAmenityName = new_value;
          }
        public void unsetAmenityName()
          {
            flagHasAmenityName = false;
          }
        public void setAmenitySpokenNameSingular(string new_value)
          {
            flagHasAmenitySpokenNameSingular = true;
            storeAmenitySpokenNameSingular = new_value;
          }
        public void unsetAmenitySpokenNameSingular()
          {
            flagHasAmenitySpokenNameSingular = false;
          }
        public void setAmenitySpokenNamePlural(string new_value)
          {
            flagHasAmenitySpokenNamePlural = true;
            storeAmenitySpokenNamePlural = new_value;
          }
        public void unsetAmenitySpokenNamePlural()
          {
            flagHasAmenitySpokenNamePlural = false;
          }
        public void setAmenityTopLevelName(string new_value)
          {
            flagHasAmenityTopLevelName = true;
            storeAmenityTopLevelName = new_value;
          }
        public void unsetAmenityTopLevelName()
          {
            flagHasAmenityTopLevelName = false;
          }
        public void setAmenityTopLevelSpokenNameSingular(string new_value)
          {
            flagHasAmenityTopLevelSpokenNameSingular = true;
            storeAmenityTopLevelSpokenNameSingular = new_value;
          }
        public void unsetAmenityTopLevelSpokenNameSingular()
          {
            flagHasAmenityTopLevelSpokenNameSingular = false;
          }
        public void setAmenityTopLevelSpokenNamePlural(string new_value)
          {
            flagHasAmenityTopLevelSpokenNamePlural = true;
            storeAmenityTopLevelSpokenNamePlural = new_value;
          }
        public void unsetAmenityTopLevelSpokenNamePlural()
          {
            flagHasAmenityTopLevelSpokenNamePlural = false;
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
            Debug.Assert(partial_allowed || flagHasAmenityAlias);
            if (flagHasAmenityAlias)
              {
                handler.start_pair("AmenityAlias");
                handler.string_value(storeAmenityAlias);
              }
            Debug.Assert(partial_allowed || flagHasAmenityName);
            if (flagHasAmenityName)
              {
                handler.start_pair("AmenityName");
                handler.string_value(storeAmenityName);
              }
            if (flagHasAmenitySpokenNameSingular)
              {
                handler.start_pair("AmenitySpokenNameSingular");
                handler.string_value(storeAmenitySpokenNameSingular);
              }
            if (flagHasAmenitySpokenNamePlural)
              {
                handler.start_pair("AmenitySpokenNamePlural");
                handler.string_value(storeAmenitySpokenNamePlural);
              }
            if (flagHasAmenityTopLevelName)
              {
                handler.start_pair("AmenityTopLevelName");
                handler.string_value(storeAmenityTopLevelName);
              }
            if (flagHasAmenityTopLevelSpokenNameSingular)
              {
                handler.start_pair("AmenityTopLevelSpokenNameSingular");
                handler.string_value(storeAmenityTopLevelSpokenNameSingular);
              }
            if (flagHasAmenityTopLevelSpokenNamePlural)
              {
                handler.start_pair("AmenityTopLevelSpokenNamePlural");
                handler.string_value(storeAmenityTopLevelSpokenNamePlural);
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
            if (!(hasAmenityAlias()))
              {
                return "When parsing the object for %what%, the \"AmenityAlias\" field was missing.";
              }
            if (!(hasAmenityName()))
              {
                return "When parsing the object for %what%, the \"AmenityName\" field was missing.";
              }
            return null;
          }

        public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenityGroupJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
        public static TypeAmenityGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAmenityGroupJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
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
        public static TypeAmenityGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAmenityGroupJSON from_text(string text, bool ignore_extras)
          {
            TypeAmenityGroupJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAmenityGroupJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAmenityGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAmenityGroupJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAmenityGroup", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorAmenityAlias;
            private JSONHoldingStringGenerator fieldGeneratorAmenityName;
            private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNameSingular;
            private JSONHoldingStringGenerator fieldGeneratorAmenitySpokenNamePlural;
            private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelName;
            private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNameSingular;
            private JSONHoldingStringGenerator fieldGeneratorAmenityTopLevelSpokenNamePlural;

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
                TypeAmenityGroupJSON result = new TypeAmenityGroupJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeAmenityGroupJSON result)
              {
                if (fieldGeneratorAmenityAlias.have_value)
                  {
                    result.setAmenityAlias(fieldGeneratorAmenityAlias.value);
                    fieldGeneratorAmenityAlias.have_value = false;
                  }
                else if ((!(result.hasAmenityAlias())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AmenityAlias\" field was missing.");
                  }
                if (fieldGeneratorAmenityName.have_value)
                  {
                    result.setAmenityName(fieldGeneratorAmenityName.value);
                    fieldGeneratorAmenityName.have_value = false;
                  }
                else if ((!(result.hasAmenityName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AmenityName\" field was missing.");
                  }
                if (fieldGeneratorAmenitySpokenNameSingular.have_value)
                  {
                    result.setAmenitySpokenNameSingular(fieldGeneratorAmenitySpokenNameSingular.value);
                    fieldGeneratorAmenitySpokenNameSingular.have_value = false;
                  }
                if (fieldGeneratorAmenitySpokenNamePlural.have_value)
                  {
                    result.setAmenitySpokenNamePlural(fieldGeneratorAmenitySpokenNamePlural.value);
                    fieldGeneratorAmenitySpokenNamePlural.have_value = false;
                  }
                if (fieldGeneratorAmenityTopLevelName.have_value)
                  {
                    result.setAmenityTopLevelName(fieldGeneratorAmenityTopLevelName.value);
                    fieldGeneratorAmenityTopLevelName.have_value = false;
                  }
                if (fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value)
                  {
                    result.setAmenityTopLevelSpokenNameSingular(fieldGeneratorAmenityTopLevelSpokenNameSingular.value);
                    fieldGeneratorAmenityTopLevelSpokenNameSingular.have_value = false;
                  }
                if (fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value)
                  {
                    result.setAmenityTopLevelSpokenNamePlural(fieldGeneratorAmenityTopLevelSpokenNamePlural.value);
                    fieldGeneratorAmenityTopLevelSpokenNamePlural.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeAmenityGroupJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Amenity", 0, 7, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 8, "lias", 0, 4, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorAmenityAlias;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAmenityName;
                            break;
                        case 'S':
                            if (String.Compare(field_name, 8, "pokenName", 0, 9, false) == 0)
                              {
                                switch (field_name[17])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 18, "lural", 0, 5, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorAmenitySpokenNamePlural;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 18, "ingular", 0, 7, false) == 0) && (field_name.Length == 25))
                                            return fieldGeneratorAmenitySpokenNameSingular;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'T':
                            if (String.Compare(field_name, 8, "opLevel", 0, 7, false) == 0)
                              {
                                switch (field_name[15])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 16, "ame", 0, 3, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorAmenityTopLevelName;
                                        break;
                                    case 'S':
                                        if (String.Compare(field_name, 16, "pokenName", 0, 9, false) == 0)
                                          {
                                            switch (field_name[25])
                                              {
                                                case 'P':
                                                    if ((String.Compare(field_name, 26, "lural", 0, 5, false) == 0) && (field_name.Length == 31))
                                                        return fieldGeneratorAmenityTopLevelSpokenNamePlural;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 26, "ingular", 0, 7, false) == 0) && (field_name.Length == 33))
                                                        return fieldGeneratorAmenityTopLevelSpokenNameSingular;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAmenityAlias = new JSONHoldingStringGenerator("field \"AmenityAlias\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                set_what("the TypeAmenityGroup class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAmenityAlias = new JSONHoldingStringGenerator("field \"AmenityAlias\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityName = new JSONHoldingStringGenerator("field \"AmenityName\" of the TypeAmenityGroup class");
                fieldGeneratorAmenitySpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenitySpokenNameSingular\" of the TypeAmenityGroup class");
                fieldGeneratorAmenitySpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenitySpokenNamePlural\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelName = new JSONHoldingStringGenerator("field \"AmenityTopLevelName\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNameSingular\" of the TypeAmenityGroup class");
                fieldGeneratorAmenityTopLevelSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityTopLevelSpokenNamePlural\" of the TypeAmenityGroup class");
                set_what("the TypeAmenityGroup class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAmenityAlias.reset();
                fieldGeneratorAmenityName.reset();
                fieldGeneratorAmenitySpokenNameSingular.reset();
                fieldGeneratorAmenitySpokenNamePlural.reset();
                fieldGeneratorAmenityTopLevelName.reset();
                fieldGeneratorAmenityTopLevelSpokenNameSingular.reset();
                fieldGeneratorAmenityTopLevelSpokenNamePlural.reset();
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
            protected override void handle_result(TypeAmenityGroupJSON  result)
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
            public TypeAmenityGroupJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAmenityGroupJSON  result)
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
        protected virtual void handle_result(List<TypeAmenityGroupJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAmenityGroupJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAmenityGroupJSON>();
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
        public List<TypeAmenityGroupJSON> value;
      };
      };
    private bool flagHasAmenityGroupName;
    private string storeAmenityGroupName;
    private bool flagHasAmenityGroupSpokenNameSingular;
    private string storeAmenityGroupSpokenNameSingular;
    private bool flagHasAmenityGroupSpokenNamePlural;
    private string storeAmenityGroupSpokenNamePlural;
    private bool flagHasAmenityGroup;
    private List< TypeAmenityGroupJSON  > storeAmenityGroup;


    private void  fromJSONAmenityGroupName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AmenityGroupName of AmenityGroupSpecJSON is not a string.");
        setAmenityGroupName(json_string.getData());
      }


    private void  fromJSONAmenityGroupSpokenNameSingular(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AmenityGroupSpokenNameSingular of AmenityGroupSpecJSON is not a string.");
        setAmenityGroupSpokenNameSingular(json_string.getData());
      }


    private void  fromJSONAmenityGroupSpokenNamePlural(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AmenityGroupSpokenNamePlural of AmenityGroupSpecJSON is not a string.");
        setAmenityGroupSpokenNamePlural(json_string.getData());
      }


    private void  fromJSONAmenityGroup(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenityGroup of AmenityGroupSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAmenityGroupJSON  > vector_AmenityGroup1 = new List< TypeAmenityGroupJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAmenityGroupJSON convert_classy = TypeAmenityGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenityGroup1.Add(convert_classy);
          }
        initAmenityGroup();
        for (int num1 = 0; num1 < vector_AmenityGroup1.Count; ++num1)
            appendAmenityGroup(vector_AmenityGroup1[num1]);
        for (int num1 = 0; num1 < vector_AmenityGroup1.Count; ++num1)
          {
          }
      }


    public AmenityGroupSpecJSON()
      {
        flagHasAmenityGroupName = false;
        flagHasAmenityGroupSpokenNameSingular = false;
        flagHasAmenityGroupSpokenNamePlural = false;
        flagHasAmenityGroup = false;
        storeAmenityGroup = new List< TypeAmenityGroupJSON  >();
      }

    public bool  hasAmenityGroupName()
      {
        return flagHasAmenityGroupName;
      }

    public string  getAmenityGroupName()
      {
        Debug.Assert(flagHasAmenityGroupName);
        return storeAmenityGroupName;
      }

    public bool  hasAmenityGroupSpokenNameSingular()
      {
        return flagHasAmenityGroupSpokenNameSingular;
      }

    public string  getAmenityGroupSpokenNameSingular()
      {
        Debug.Assert(flagHasAmenityGroupSpokenNameSingular);
        return storeAmenityGroupSpokenNameSingular;
      }

    public bool  hasAmenityGroupSpokenNamePlural()
      {
        return flagHasAmenityGroupSpokenNamePlural;
      }

    public string  getAmenityGroupSpokenNamePlural()
      {
        Debug.Assert(flagHasAmenityGroupSpokenNamePlural);
        return storeAmenityGroupSpokenNamePlural;
      }

    public bool  hasAmenityGroup()
      {
        return flagHasAmenityGroup;
      }

    public int  countOfAmenityGroup()
      {
        Debug.Assert(flagHasAmenityGroup);
        return storeAmenityGroup.Count;
      }

    public TypeAmenityGroupJSON   elementOfAmenityGroup(int element_num)
      {
        Debug.Assert(flagHasAmenityGroup);
        return storeAmenityGroup[element_num];
      }

    public List< TypeAmenityGroupJSON  >  getAmenityGroup()
      {
        Debug.Assert(flagHasAmenityGroup);
        return storeAmenityGroup;
      }



    public void setAmenityGroupName(string new_value)
      {
        flagHasAmenityGroupName = true;
        storeAmenityGroupName = new_value;
      }
    public void unsetAmenityGroupName()
      {
        flagHasAmenityGroupName = false;
      }
    public void setAmenityGroupSpokenNameSingular(string new_value)
      {
        flagHasAmenityGroupSpokenNameSingular = true;
        storeAmenityGroupSpokenNameSingular = new_value;
      }
    public void unsetAmenityGroupSpokenNameSingular()
      {
        flagHasAmenityGroupSpokenNameSingular = false;
      }
    public void setAmenityGroupSpokenNamePlural(string new_value)
      {
        flagHasAmenityGroupSpokenNamePlural = true;
        storeAmenityGroupSpokenNamePlural = new_value;
      }
    public void unsetAmenityGroupSpokenNamePlural()
      {
        flagHasAmenityGroupSpokenNamePlural = false;
      }
    public void initAmenityGroup()
      {
        if (flagHasAmenityGroup)
          {
            for (int num1 = 0; num1 < storeAmenityGroup.Count; ++num1)
              {
              }
          }
        flagHasAmenityGroup = true;
        storeAmenityGroup.Clear();
      }
    public void appendAmenityGroup(TypeAmenityGroupJSON  to_append)
      {
        if (!flagHasAmenityGroup)
          {
            flagHasAmenityGroup = true;
            storeAmenityGroup.Clear();
          }
        Debug.Assert(flagHasAmenityGroup);
        storeAmenityGroup.Add(to_append);
      }
    public void unsetAmenityGroup()
      {
        if (flagHasAmenityGroup)
          {
            for (int num2 = 0; num2 < storeAmenityGroup.Count; ++num2)
              {
              }
          }
        flagHasAmenityGroup = false;
        storeAmenityGroup.Clear();
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
        if (flagHasAmenityGroupName)
          {
            handler.start_pair("AmenityGroupName");
            handler.string_value(storeAmenityGroupName);
          }
        if (flagHasAmenityGroupSpokenNameSingular)
          {
            handler.start_pair("AmenityGroupSpokenNameSingular");
            handler.string_value(storeAmenityGroupSpokenNameSingular);
          }
        if (flagHasAmenityGroupSpokenNamePlural)
          {
            handler.start_pair("AmenityGroupSpokenNamePlural");
            handler.string_value(storeAmenityGroupSpokenNamePlural);
          }
        Debug.Assert(partial_allowed || flagHasAmenityGroup);
        if (flagHasAmenityGroup)
          {
            handler.start_pair("AmenityGroup");
            handler.start_array();
            for (int num1 = 0; num1 < storeAmenityGroup.Count; ++num1)
              {
                if (partial_allowed)
                    storeAmenityGroup[num1].write_partial_as_json(handler);
                else
                    storeAmenityGroup[num1].write_as_json(handler);
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
        if (!(hasAmenityGroup()))
          {
            return "When parsing the object for %what%, the \"AmenityGroup\" field was missing.";
          }
        return null;
      }

    public static AmenityGroupSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AmenityGroupSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AmenityGroupSpec", ignore_extras);
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
    public static AmenityGroupSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AmenityGroupSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AmenityGroupSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AmenityGroupSpec", ignore_extras);
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
    public static AmenityGroupSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AmenityGroupSpecJSON from_text(string text, bool ignore_extras)
      {
        AmenityGroupSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AmenityGroupSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AmenityGroupSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AmenityGroupSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AmenityGroupSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AmenityGroupSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorAmenityGroupName;
        private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNameSingular;
        private JSONHoldingStringGenerator fieldGeneratorAmenityGroupSpokenNamePlural;
        private TypeAmenityGroupJSON.HoldingArrayGenerator fieldGeneratorAmenityGroup;

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
            AmenityGroupSpecJSON result = new AmenityGroupSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(AmenityGroupSpecJSON result)
          {
            if (fieldGeneratorAmenityGroupName.have_value)
              {
                result.setAmenityGroupName(fieldGeneratorAmenityGroupName.value);
                fieldGeneratorAmenityGroupName.have_value = false;
              }
            if (fieldGeneratorAmenityGroupSpokenNameSingular.have_value)
              {
                result.setAmenityGroupSpokenNameSingular(fieldGeneratorAmenityGroupSpokenNameSingular.value);
                fieldGeneratorAmenityGroupSpokenNameSingular.have_value = false;
              }
            if (fieldGeneratorAmenityGroupSpokenNamePlural.have_value)
              {
                result.setAmenityGroupSpokenNamePlural(fieldGeneratorAmenityGroupSpokenNamePlural.value);
                fieldGeneratorAmenityGroupSpokenNamePlural.have_value = false;
              }
            if (fieldGeneratorAmenityGroup.have_value)
              {
                result.initAmenityGroup();
                int count = fieldGeneratorAmenityGroup.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenityGroup(fieldGeneratorAmenityGroup.value[num]);
                  }
                fieldGeneratorAmenityGroup.value.Clear();
                fieldGeneratorAmenityGroup.have_value = false;
              }
            else if ((!(result.hasAmenityGroup())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AmenityGroup\" field was missing.");
              }
          }
        protected abstract void handle_result(AmenityGroupSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "AmenityGroup", 0, 12, false) == 0)
              {
                if (field_name.Length == 12)
                  {
                    return fieldGeneratorAmenityGroup;
                  }
                switch (field_name[12])
                  {
                    case 'N':
                        if ((String.Compare(field_name, 13, "ame", 0, 3, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorAmenityGroupName;
                        break;
                    case 'S':
                        if (String.Compare(field_name, 13, "pokenName", 0, 9, false) == 0)
                          {
                            switch (field_name[22])
                              {
                                case 'P':
                                    if ((String.Compare(field_name, 23, "lural", 0, 5, false) == 0) && (field_name.Length == 28))
                                        return fieldGeneratorAmenityGroupSpokenNamePlural;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 23, "ingular", 0, 7, false) == 0) && (field_name.Length == 30))
                                        return fieldGeneratorAmenityGroupSpokenNameSingular;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the AmenityGroupSpec class", ignore_extras);
            set_what("the AmenityGroupSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorAmenityGroupName = new JSONHoldingStringGenerator("field \"AmenityGroupName\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroupSpokenNameSingular = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNameSingular\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroupSpokenNamePlural = new JSONHoldingStringGenerator("field \"AmenityGroupSpokenNamePlural\" of the AmenityGroupSpec class");
            fieldGeneratorAmenityGroup = new TypeAmenityGroupJSON.HoldingArrayGenerator("field \"AmenityGroup\" of the AmenityGroupSpec class", false);
            set_what("the AmenityGroupSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorAmenityGroupName.reset();
            fieldGeneratorAmenityGroupSpokenNameSingular.reset();
            fieldGeneratorAmenityGroupSpokenNamePlural.reset();
            fieldGeneratorAmenityGroup.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAmenityGroup.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAmenityGroup.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AmenityGroupSpecJSON  result)
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
        public AmenityGroupSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AmenityGroupSpecJSON  result)
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
    protected virtual void handle_result(List<AmenityGroupSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AmenityGroupSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AmenityGroupSpecJSON>();
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
    public List<AmenityGroupSpecJSON> value;
  };
  };
