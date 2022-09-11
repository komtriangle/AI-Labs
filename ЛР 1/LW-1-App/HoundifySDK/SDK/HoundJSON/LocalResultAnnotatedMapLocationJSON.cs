/* file "LocalResultAnnotatedMapLocationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class LocalResultAnnotatedMapLocationJSON : AnnotatedMapLocationJSON
  {
    public class TypePhoneJSON : JSONBase
      {
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasNumber;
        private string storeNumber;


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypePhoneJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Number of TypePhoneJSON is not a string.");
            setNumber(json_string.getData());
          }


        public TypePhoneJSON()
          {
            flagHasLabel = false;
            flagHasNumber = false;
          }

        public bool  hasLabel()
          {
            return flagHasLabel;
          }

        public string  getLabel()
          {
            Debug.Assert(flagHasLabel);
            return storeLabel;
          }

        public bool  hasNumber()
          {
            return flagHasNumber;
          }

        public string  getNumber()
          {
            Debug.Assert(flagHasNumber);
            return storeNumber;
          }



        public void setLabel(string new_value)
          {
            flagHasLabel = true;
            storeLabel = new_value;
          }
        public void unsetLabel()
          {
            flagHasLabel = false;
          }
        public void setNumber(string new_value)
          {
            flagHasNumber = true;
            storeNumber = new_value;
          }
        public void unsetNumber()
          {
            flagHasNumber = false;
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
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
              }
            Debug.Assert(partial_allowed || flagHasNumber);
            if (flagHasNumber)
              {
                handler.start_pair("Number");
                handler.string_value(storeNumber);
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
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasNumber()))
              {
                return "When parsing the object for %what%, the \"Number\" field was missing.";
              }
            return null;
          }

        public static TypePhoneJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhone", ignore_extras);
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
        public static TypePhoneJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhoneJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhone", ignore_extras);
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
        public static TypePhoneJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhoneJSON from_text(string text, bool ignore_extras)
          {
            TypePhoneJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhone", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePhoneJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePhoneJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePhoneJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhone", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLabel;
            private JSONHoldingStringGenerator fieldGeneratorNumber;

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
                TypePhoneJSON result = new TypePhoneJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypePhoneJSON result)
              {
                if (fieldGeneratorLabel.have_value)
                  {
                    result.setLabel(fieldGeneratorLabel.value);
                    fieldGeneratorLabel.have_value = false;
                  }
                else if ((!(result.hasLabel())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Label\" field was missing.");
                  }
                if (fieldGeneratorNumber.have_value)
                  {
                    result.setNumber(fieldGeneratorNumber.value);
                    fieldGeneratorNumber.have_value = false;
                  }
                else if ((!(result.hasNumber())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Number\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePhoneJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorNumber;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypePhone class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhone class");
                set_what("the TypePhone class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypePhone class");
                fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the TypePhone class");
                set_what("the TypePhone class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLabel.reset();
                fieldGeneratorNumber.reset();
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
            protected override void handle_result(TypePhoneJSON  result)
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
            public TypePhoneJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePhoneJSON  result)
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
        protected virtual void handle_result(List<TypePhoneJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePhoneJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePhoneJSON>();
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
        public List<TypePhoneJSON> value;
      };
      };
    public class TypeLinksJSON : JSONBase
      {
        public enum TypeType
          {
            Type_Web
          };

        public static TypeType  stringToType(string chars)
          {
            if ((String.Compare(chars, 0, "Web", 0, 3, false) == 0) && (chars.Length == 3))
                return TypeType.Type_Web;
            throw new Exception("The value for field `Type' is not one of the legal values.");
          }

        public static string  stringFromType(TypeType the_enum)
          {
            switch (the_enum)
              {
                case TypeType.Type_Web:
                    return "Web";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasType;
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasURL;
        private string storeURL;


        private void  fromJSONType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Type of TypeLinksJSON is not a string.");
            if (!(json_string.getData().Equals("Web")))
                throw new Exception("The value for field Type of TypeLinksJSON is not `Web'.");
            setType();
          }


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypeLinksJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URL of TypeLinksJSON is not a string.");
            setURL(json_string.getData());
          }


        public TypeLinksJSON()
          {
            flagHasType = false;
            flagHasLabel = false;
            flagHasURL = false;
          }

        public bool  hasType()
          {
            return flagHasType;
          }

        public TypeType  getType()
          {
            Debug.Assert(flagHasType);
            return TypeType.Type_Web;
          }

        public string  getTypeAsString()
          {
            return stringFromType(getType());
          }

        public bool  hasLabel()
          {
            return flagHasLabel;
          }

        public string  getLabel()
          {
            Debug.Assert(flagHasLabel);
            return storeLabel;
          }

        public bool  hasURL()
          {
            return flagHasURL;
          }

        public string  getURL()
          {
            Debug.Assert(flagHasURL);
            return storeURL;
          }



        public void setType()
          {
            flagHasType = true;
          }
        public void setType(TypeType new_value)
          {
            setType();
          }
        public void setType(string chars)
          {
            setType(stringToType(chars));
          }
        public void unsetType()
          {
            flagHasType = false;
          }
        public void setLabel(string new_value)
          {
            flagHasLabel = true;
            storeLabel = new_value;
          }
        public void unsetLabel()
          {
            flagHasLabel = false;
          }
        public void setURL(string new_value)
          {
            flagHasURL = true;
            storeURL = new_value;
          }
        public void unsetURL()
          {
            flagHasURL = false;
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
            Debug.Assert(partial_allowed || flagHasType);
            if (flagHasType)
              {
                handler.start_pair("Type");
                handler.string_value("Web");
              }
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
              }
            Debug.Assert(partial_allowed || flagHasURL);
            if (flagHasURL)
              {
                handler.start_pair("URL");
                handler.string_value(storeURL);
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
            if (!(hasType()))
              {
                return "When parsing the object for %what%, the \"Type\" field was missing.";
              }
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasURL()))
              {
                return "When parsing the object for %what%, the \"URL\" field was missing.";
              }
            return null;
          }

        public static TypeLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
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
        public static TypeLinksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
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
        public static TypeLinksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLinksJSON from_text(string text, bool ignore_extras)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLinksJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLinksJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLinksJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLinks", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorType : JSONStringGenerator
              {
                protected FieldGeneratorType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToType(result));
                  }
                protected abstract void handle_result(TypeType result);
              };
        private class FieldHoldingGeneratorType : FieldGeneratorType
      {
        protected override void handle_result(TypeType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorType(String what)
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
        public TypeType value;
      };
        private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorType
          {
            private FieldHoldingArrayGeneratorType top;

            protected override void handle_result(TypeType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
        protected virtual void handle_result(List<TypeType> result)
          {
          }

        public FieldHoldingArrayGeneratorType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeType> value;
      };
            private FieldHoldingGeneratorType fieldGeneratorType;
            private JSONHoldingStringGenerator fieldGeneratorLabel;
            private JSONHoldingStringGenerator fieldGeneratorURL;

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
                TypeLinksJSON result = new TypeLinksJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeLinksJSON result)
              {
                if (fieldGeneratorType.have_value)
                  {
                    result.setType();
                    fieldGeneratorType.have_value = false;
                  }
                else if ((!(result.hasType())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Type\" field was missing.");
                  }
                if (fieldGeneratorLabel.have_value)
                  {
                    result.setLabel(fieldGeneratorLabel.value);
                    fieldGeneratorLabel.have_value = false;
                  }
                else if ((!(result.hasLabel())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Label\" field was missing.");
                  }
                if (fieldGeneratorURL.have_value)
                  {
                    result.setURL(fieldGeneratorURL.value);
                    fieldGeneratorURL.have_value = false;
                  }
                else if ((!(result.hasURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URL\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeLinksJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorType;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURL;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the TypeLinks class");
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeLinks class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeLinks class");
                set_what("the TypeLinks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the TypeLinks class");
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeLinks class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeLinks class");
                set_what("the TypeLinks class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorType.reset();
                fieldGeneratorLabel.reset();
                fieldGeneratorURL.reset();
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
            protected override void handle_result(TypeLinksJSON  result)
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
            public TypeLinksJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLinksJSON  result)
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
        protected virtual void handle_result(List<TypeLinksJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLinksJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLinksJSON>();
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
        public List<TypeLinksJSON> value;
      };
      };
    public class TypePhotosJSON : JSONBase
      {
        private bool flagHasURL;
        private string storeURL;
        private bool flagHasThumbURL;
        private string storeThumbURL;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URL of TypePhotosJSON is not a string.");
            setURL(json_string.getData());
          }


        private void  fromJSONThumbURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ThumbURL of TypePhotosJSON is not a string.");
            setThumbURL(json_string.getData());
          }


        public TypePhotosJSON()
          {
            flagHasURL = false;
            flagHasThumbURL = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasURL()
          {
            return flagHasURL;
          }

        public string  getURL()
          {
            Debug.Assert(flagHasURL);
            return storeURL;
          }

        public bool  hasThumbURL()
          {
            return flagHasThumbURL;
          }

        public string  getThumbURL()
          {
            Debug.Assert(flagHasThumbURL);
            return storeThumbURL;
          }


        public virtual int extraTypePhotosComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePhotosComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePhotosComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePhotosLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setURL(string new_value)
          {
            flagHasURL = true;
            storeURL = new_value;
          }
        public void unsetURL()
          {
            flagHasURL = false;
          }
        public void setThumbURL(string new_value)
          {
            flagHasThumbURL = true;
            storeThumbURL = new_value;
          }
        public void unsetThumbURL()
          {
            flagHasThumbURL = false;
          }

        public virtual void extraTypePhotosAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePhotosSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePhotosLookup(key);
            if (old_field == null)
              {
                extraTypePhotosAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasURL);
            if (flagHasURL)
              {
                handler.start_pair("URL");
                handler.string_value(storeURL);
              }
            if (flagHasThumbURL)
              {
                handler.start_pair("ThumbURL");
                handler.string_value(storeThumbURL);
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
            if (!(hasURL()))
              {
                return "When parsing the object for %what%, the \"URL\" field was missing.";
              }
            return null;
          }

        public static TypePhotosJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhotosJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhotos", ignore_extras);
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
        public static TypePhotosJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhotosJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePhotosJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhotos", ignore_extras);
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
        public static TypePhotosJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePhotosJSON from_text(string text, bool ignore_extras)
          {
            TypePhotosJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhotos", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePhotosJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePhotosJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePhotosJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePhotos", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorURL;
            private JSONHoldingStringGenerator fieldGeneratorThumbURL;
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
                TypePhotosJSON result = new TypePhotosJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePhotosAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePhotosJSON result)
              {
                if (fieldGeneratorURL.have_value)
                  {
                    result.setURL(fieldGeneratorURL.value);
                    fieldGeneratorURL.have_value = false;
                  }
                else if ((!(result.hasURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"URL\" field was missing.");
                  }
                if (fieldGeneratorThumbURL.have_value)
                  {
                    result.setThumbURL(fieldGeneratorThumbURL.value);
                    fieldGeneratorThumbURL.have_value = false;
                  }
              }
            protected abstract void handle_result(TypePhotosJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'T':
                        if ((String.Compare(field_name, 1, "humbURL", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorThumbURL;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RL", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURL;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypePhotos class");
                fieldGeneratorThumbURL = new JSONHoldingStringGenerator("field \"ThumbURL\" of the TypePhotos class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePhotos class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypePhotos class");
                fieldGeneratorThumbURL = new JSONHoldingStringGenerator("field \"ThumbURL\" of the TypePhotos class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePhotos class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorURL.reset();
                fieldGeneratorThumbURL.reset();
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
            protected override void handle_result(TypePhotosJSON  result)
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
            public TypePhotosJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePhotosJSON  result)
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
        protected virtual void handle_result(List<TypePhotosJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePhotosJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePhotosJSON>();
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
        public List<TypePhotosJSON> value;
      };
      };
    public class TypeCategoriesJSON : JSONBase
      {
        private bool flagHasAlias;
        private YelpCategoryAliasJSON  storeAlias;
        private bool flagHasTitle;
        private YelpCategoryTitleJSON  storeTitle;


        private void  fromJSONAlias(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            YelpCategoryAliasJSON convert_classy = YelpCategoryAliasJSON.from_json(json_value, ignore_extras, true);
            setAlias(convert_classy);
          }


        private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            YelpCategoryTitleJSON convert_classy = YelpCategoryTitleJSON.from_json(json_value, ignore_extras, true);
            setTitle(convert_classy);
          }


        public TypeCategoriesJSON()
          {
            flagHasAlias = false;
            flagHasTitle = false;
          }

        public bool  hasAlias()
          {
            return flagHasAlias;
          }

        public YelpCategoryAliasJSON   getAlias()
          {
            Debug.Assert(flagHasAlias);
            return storeAlias;
          }

        public YelpCategoryAliasJSON.TypeValue  getAliasValue()
          {
            return getAlias().getValue();
          }

        public string  getAliasAsString()
          {
            return getAlias().getValueAsString();
          }

        public bool  hasTitle()
          {
            return flagHasTitle;
          }

        public YelpCategoryTitleJSON   getTitle()
          {
            Debug.Assert(flagHasTitle);
            return storeTitle;
          }

        public string  getTitleValue()
          {
            return getTitle().getValue();
          }



        public void setAlias(YelpCategoryAliasJSON  new_value)
          {
            if (flagHasAlias)
              {
              }
            flagHasAlias = true;
            storeAlias = new_value;
          }
        public void setAlias(YelpCategoryAliasJSON.TypeValue new_value)
          {
            setAlias(new YelpCategoryAliasJSON(new_value));
          }
        public void setAlias(string chars)
          {
            YelpCategoryAliasJSON.TypeValueKnownValues known = YelpCategoryAliasJSON.stringToValue(chars);
            YelpCategoryAliasJSON.TypeValue new_value = new YelpCategoryAliasJSON.TypeValue();
            if (known == YelpCategoryAliasJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setAlias(new_value);
          }
        public void unsetAlias()
          {
            if (flagHasAlias)
              {
              }
            flagHasAlias = false;
          }
        public void setTitle(YelpCategoryTitleJSON  new_value)
          {
            if (flagHasTitle)
              {
              }
            flagHasTitle = true;
            storeTitle = new_value;
          }
        public void setTitle(string new_value)
          {
            setTitle(new YelpCategoryTitleJSON(new_value));
          }
        public void unsetTitle()
          {
            if (flagHasTitle)
              {
              }
            flagHasTitle = false;
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
            Debug.Assert(partial_allowed || flagHasAlias);
            if (flagHasAlias)
              {
                handler.start_pair("Alias");
                if (partial_allowed)
                    storeAlias.write_partial_as_json(handler);
                else
                    storeAlias.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasTitle);
            if (flagHasTitle)
              {
                handler.start_pair("Title");
                if (partial_allowed)
                    storeTitle.write_partial_as_json(handler);
                else
                    storeTitle.write_as_json(handler);
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
            if (!(hasAlias()))
              {
                return "When parsing the object for %what%, the \"Alias\" field was missing.";
              }
            if (!(hasTitle()))
              {
                return "When parsing the object for %what%, the \"Title\" field was missing.";
              }
            return null;
          }

        public static TypeCategoriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCategoriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCategories", ignore_extras);
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
        public static TypeCategoriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCategoriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeCategoriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCategories", ignore_extras);
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
        public static TypeCategoriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeCategoriesJSON from_text(string text, bool ignore_extras)
          {
            TypeCategoriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCategories", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeCategoriesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeCategoriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeCategoriesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeCategories", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private YelpCategoryAliasJSON.HoldingGenerator fieldGeneratorAlias;
            private YelpCategoryTitleJSON.HoldingGenerator fieldGeneratorTitle;

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
                TypeCategoriesJSON result = new TypeCategoriesJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeCategoriesJSON result)
              {
                if (fieldGeneratorAlias.have_value)
                  {
                    result.setAlias(fieldGeneratorAlias.value);
                    fieldGeneratorAlias.have_value = false;
                  }
                else if ((!(result.hasAlias())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Alias\" field was missing.");
                  }
                if (fieldGeneratorTitle.have_value)
                  {
                    result.setTitle(fieldGeneratorTitle.value);
                    fieldGeneratorTitle.have_value = false;
                  }
                else if ((!(result.hasTitle())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Title\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeCategoriesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "lias", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorAlias;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTitle;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorAlias = new YelpCategoryAliasJSON.HoldingGenerator("field \"Alias\" of the TypeCategories class", ignore_extras);
                fieldGeneratorTitle = new YelpCategoryTitleJSON.HoldingGenerator("field \"Title\" of the TypeCategories class", ignore_extras);
                set_what("the TypeCategories class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorAlias = new YelpCategoryAliasJSON.HoldingGenerator("field \"Alias\" of the TypeCategories class", false);
                fieldGeneratorTitle = new YelpCategoryTitleJSON.HoldingGenerator("field \"Title\" of the TypeCategories class", false);
                set_what("the TypeCategories class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorAlias.reset();
                fieldGeneratorTitle.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorAlias.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTitle.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorAlias.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTitle.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeCategoriesJSON  result)
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
            public TypeCategoriesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeCategoriesJSON  result)
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
        protected virtual void handle_result(List<TypeCategoriesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeCategoriesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeCategoriesJSON>();
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
        public List<TypeCategoriesJSON> value;
      };
      };
    public class TypeDistanceFromReferenceJSON : JSONBase
      {
        public enum TypeUnit
          {
            Unit_km,
            Unit_mi
          };

        public static TypeUnit  stringToUnit(string chars)
          {
            switch (chars[0])
              {
                case 'k':
                    if ((String.Compare(chars, 1, "m", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeUnit.Unit_km;
                    break;
                case 'm':
                    if ((String.Compare(chars, 1, "i", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeUnit.Unit_mi;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Unit' is not one of the legal values.");
          }

        public static string  stringFromUnit(TypeUnit the_enum)
          {
            switch (the_enum)
              {
                case TypeUnit.Unit_km:
                    return "km";
                case TypeUnit.Unit_mi:
                    return "mi";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasValue;
        private double storeValue;
        private string textStoreValue;
        private bool flagHasUnit;
        private TypeUnit storeUnit;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Value of TypeDistanceFromReferenceJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeDistanceFromReferenceJSON is not a string.");
            TypeUnit the_enum;
            switch (json_string.getData()[0])
              {
                case 'k':
                    if ((String.Compare(json_string.getData(), 1, "m", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_enum = TypeUnit.Unit_km;
                            goto enum_is_done;
                          }
                    break;
                case 'm':
                    if ((String.Compare(json_string.getData(), 1, "i", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_enum = TypeUnit.Unit_mi;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Unit of TypeDistanceFromReferenceJSON is not one of the legal strings.");
          enum_is_done:;
            setUnit(the_enum);
          }


        public TypeDistanceFromReferenceJSON()
          {
            flagHasValue = false;
            flagHasUnit = false;
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public double  getValue()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue != "")
              {
                return Double.Parse(textStoreValue);
              }
            return storeValue;
          }

        public string  getValueAsText()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue == "")
              {
                return Convert.ToString(storeValue);
              }
            else
              {
                return (textStoreValue);
              }
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public TypeUnit  getUnit()
          {
            Debug.Assert(flagHasUnit);
            return storeUnit;
          }

        public string  getUnitAsString()
          {
            return stringFromUnit(getUnit());
          }



        public void setValue(double new_value)
          {
            flagHasValue = true;
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeDistanceFromReferenceJSON is not a valid number.");
            textStoreValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setUnit(TypeUnit new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void setUnit(string chars)
          {
            setUnit(stringToUnit(chars));
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (textStoreValue != "")
                    handler.number_value(textStoreValue);
                else if (((double)(long)storeValue) == storeValue)
                    handler.number_value((long)storeValue);
                else
                    handler.number_value(storeValue);
              }
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                switch (storeUnit)
                  {
                    case TypeUnit.Unit_km:
                        handler.string_value("km");
                        break;
                    case TypeUnit.Unit_mi:
                        handler.string_value("mi");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            return null;
          }

        public static TypeDistanceFromReferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDistanceFromReferenceJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromReference", ignore_extras);
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
        public static TypeDistanceFromReferenceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDistanceFromReferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDistanceFromReferenceJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromReference", ignore_extras);
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
        public static TypeDistanceFromReferenceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDistanceFromReferenceJSON from_text(string text, bool ignore_extras)
          {
            TypeDistanceFromReferenceJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromReference", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDistanceFromReferenceJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDistanceFromReferenceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDistanceFromReferenceJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromReference", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorValue;
        private abstract class FieldGeneratorUnit : JSONStringGenerator
              {
                protected FieldGeneratorUnit(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnit()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToUnit(result));
                  }
                protected abstract void handle_result(TypeUnit result);
              };
        private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
      {
        protected override void handle_result(TypeUnit result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnit(String what)
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
        public TypeUnit value;
      };
        private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnit
          {
            private FieldHoldingArrayGeneratorUnit top;

            protected override void handle_result(TypeUnit result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
        protected virtual void handle_result(List<TypeUnit> result)
          {
          }

        public FieldHoldingArrayGeneratorUnit(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnit()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnit> value;
      };
            private FieldHoldingGeneratorUnit fieldGeneratorUnit;

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
                TypeDistanceFromReferenceJSON result = new TypeDistanceFromReferenceJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeDistanceFromReferenceJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDistanceFromReferenceJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'U':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorUnit;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeDistanceFromReference class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeDistanceFromReference class");
                set_what("the TypeDistanceFromReference class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeDistanceFromReference class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeDistanceFromReference class");
                set_what("the TypeDistanceFromReference class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorUnit.reset();
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
            protected override void handle_result(TypeDistanceFromReferenceJSON  result)
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
            public TypeDistanceFromReferenceJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDistanceFromReferenceJSON  result)
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
        protected virtual void handle_result(List<TypeDistanceFromReferenceJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDistanceFromReferenceJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDistanceFromReferenceJSON>();
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
        public List<TypeDistanceFromReferenceJSON> value;
      };
      };
    public class TypeDistanceFromUserJSON : JSONBase
      {
        public enum TypeUnit
          {
            Unit_km,
            Unit_mi
          };

        public static TypeUnit  stringToUnit(string chars)
          {
            switch (chars[0])
              {
                case 'k':
                    if ((String.Compare(chars, 1, "m", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeUnit.Unit_km;
                    break;
                case 'm':
                    if ((String.Compare(chars, 1, "i", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeUnit.Unit_mi;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Unit' is not one of the legal values.");
          }

        public static string  stringFromUnit(TypeUnit the_enum)
          {
            switch (the_enum)
              {
                case TypeUnit.Unit_km:
                    return "km";
                case TypeUnit.Unit_mi:
                    return "mi";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasValue;
        private double storeValue;
        private string textStoreValue;
        private bool flagHasUnit;
        private TypeUnit storeUnit;


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Value of TypeDistanceFromUserJSON is not a number.");
                  }
              }
            setValueText(the_rational_text);
          }


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeDistanceFromUserJSON is not a string.");
            TypeUnit the_enum;
            switch (json_string.getData()[0])
              {
                case 'k':
                    if ((String.Compare(json_string.getData(), 1, "m", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_enum = TypeUnit.Unit_km;
                            goto enum_is_done;
                          }
                    break;
                case 'm':
                    if ((String.Compare(json_string.getData(), 1, "i", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_enum = TypeUnit.Unit_mi;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Unit of TypeDistanceFromUserJSON is not one of the legal strings.");
          enum_is_done:;
            setUnit(the_enum);
          }


        public TypeDistanceFromUserJSON()
          {
            flagHasValue = false;
            flagHasUnit = false;
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public double  getValue()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue != "")
              {
                return Double.Parse(textStoreValue);
              }
            return storeValue;
          }

        public string  getValueAsText()
          {
            Debug.Assert(flagHasValue);
            if (textStoreValue == "")
              {
                return Convert.ToString(storeValue);
              }
            else
              {
                return (textStoreValue);
              }
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public TypeUnit  getUnit()
          {
            Debug.Assert(flagHasUnit);
            return storeUnit;
          }

        public string  getUnitAsString()
          {
            return stringFromUnit(getUnit());
          }



        public void setValue(double new_value)
          {
            flagHasValue = true;
            storeValue = new_value;
            textStoreValue = "";
          }
        public void setValueText(string new_value)
          {
            flagHasValue = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Value of TypeDistanceFromUserJSON is not a valid number.");
            textStoreValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setUnit(TypeUnit new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void setUnit(string chars)
          {
            setUnit(stringToUnit(chars));
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
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
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                if (textStoreValue != "")
                    handler.number_value(textStoreValue);
                else if (((double)(long)storeValue) == storeValue)
                    handler.number_value((long)storeValue);
                else
                    handler.number_value(storeValue);
              }
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                switch (storeUnit)
                  {
                    case TypeUnit.Unit_km:
                        handler.string_value("km");
                        break;
                    case TypeUnit.Unit_mi:
                        handler.string_value("mi");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            return null;
          }

        public static TypeDistanceFromUserJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDistanceFromUserJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromUser", ignore_extras);
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
        public static TypeDistanceFromUserJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDistanceFromUserJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDistanceFromUserJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromUser", ignore_extras);
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
        public static TypeDistanceFromUserJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDistanceFromUserJSON from_text(string text, bool ignore_extras)
          {
            TypeDistanceFromUserJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromUser", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDistanceFromUserJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDistanceFromUserJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDistanceFromUserJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDistanceFromUser", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingNumberTextGenerator fieldGeneratorValue;
        private abstract class FieldGeneratorUnit : JSONStringGenerator
              {
                protected FieldGeneratorUnit(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnit()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToUnit(result));
                  }
                protected abstract void handle_result(TypeUnit result);
              };
        private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
      {
        protected override void handle_result(TypeUnit result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnit(String what)
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
        public TypeUnit value;
      };
        private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnit
          {
            private FieldHoldingArrayGeneratorUnit top;

            protected override void handle_result(TypeUnit result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
        protected virtual void handle_result(List<TypeUnit> result)
          {
          }

        public FieldHoldingArrayGeneratorUnit(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnit()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnit> value;
      };
            private FieldHoldingGeneratorUnit fieldGeneratorUnit;

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
                TypeDistanceFromUserJSON result = new TypeDistanceFromUserJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeDistanceFromUserJSON result)
              {
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValueText(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDistanceFromUserJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'U':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorUnit;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeDistanceFromUser class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeDistanceFromUser class");
                set_what("the TypeDistanceFromUser class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorValue = new JSONHoldingNumberTextGenerator("field \"Value\" of the TypeDistanceFromUser class");
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeDistanceFromUser class");
                set_what("the TypeDistanceFromUser class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorValue.reset();
                fieldGeneratorUnit.reset();
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
            protected override void handle_result(TypeDistanceFromUserJSON  result)
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
            public TypeDistanceFromUserJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDistanceFromUserJSON  result)
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
        protected virtual void handle_result(List<TypeDistanceFromUserJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDistanceFromUserJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDistanceFromUserJSON>();
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
        public List<TypeDistanceFromUserJSON> value;
      };
      };
    public class TypeReviewsJSON : JSONBase
      {
        public class TypeUserJSON : JSONBase
          {
            private bool flagHasName;
            private string storeName;
            private bool flagHasID;
            private string storeID;
            private bool flagHasPhotoURL;
            private string storePhotoURL;


            private void  fromJSONName(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Name of TypeUserJSON is not a string.");
                setName(json_string.getData());
              }


            private void  fromJSONID(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field ID of TypeUserJSON is not a string.");
                setID(json_string.getData());
              }


            private void  fromJSONPhotoURL(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field PhotoURL of TypeUserJSON is not a string.");
                setPhotoURL(json_string.getData());
              }


            public TypeUserJSON()
              {
                flagHasName = false;
                flagHasID = false;
                flagHasPhotoURL = false;
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

            public bool  hasID()
              {
                return flagHasID;
              }

            public string  getID()
              {
                Debug.Assert(flagHasID);
                return storeID;
              }

            public bool  hasPhotoURL()
              {
                return flagHasPhotoURL;
              }

            public string  getPhotoURL()
              {
                Debug.Assert(flagHasPhotoURL);
                return storePhotoURL;
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
            public void setID(string new_value)
              {
                flagHasID = true;
                storeID = new_value;
              }
            public void unsetID()
              {
                flagHasID = false;
              }
            public void setPhotoURL(string new_value)
              {
                flagHasPhotoURL = true;
                storePhotoURL = new_value;
              }
            public void unsetPhotoURL()
              {
                flagHasPhotoURL = false;
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
                Debug.Assert(partial_allowed || flagHasName);
                if (flagHasName)
                  {
                    handler.start_pair("Name");
                    handler.string_value(storeName);
                  }
                if (flagHasID)
                  {
                    handler.start_pair("ID");
                    handler.string_value(storeID);
                  }
                if (flagHasPhotoURL)
                  {
                    handler.start_pair("PhotoURL");
                    handler.string_value(storePhotoURL);
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
                if (!(hasName()))
                  {
                    return "When parsing the object for %what%, the \"Name\" field was missing.";
                  }
                return null;
              }

            public static TypeUserJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeUserJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeUser", ignore_extras);
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
            public static TypeUserJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeUserJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeUserJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeUser", ignore_extras);
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
            public static TypeUserJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeUserJSON from_text(string text, bool ignore_extras)
              {
                TypeUserJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeUser", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeUserJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeUserJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeUserJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeUser", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorName;
                private JSONHoldingStringGenerator fieldGeneratorID;
                private JSONHoldingStringGenerator fieldGeneratorPhotoURL;

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
                    TypeUserJSON result = new TypeUserJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    handle_result(result);
                  }
                protected void finish(TypeUserJSON result)
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
                    if (fieldGeneratorID.have_value)
                      {
                        result.setID(fieldGeneratorID.value);
                        fieldGeneratorID.have_value = false;
                      }
                    if (fieldGeneratorPhotoURL.have_value)
                      {
                        result.setPhotoURL(fieldGeneratorPhotoURL.value);
                        fieldGeneratorPhotoURL.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeUserJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                                return fieldGeneratorID;
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorName;
                            break;
                        case 'P':
                            if ((String.Compare(field_name, 1, "hotoURL", 0, 7, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhotoURL;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeUser class");
                    fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeUser class");
                    fieldGeneratorPhotoURL = new JSONHoldingStringGenerator("field \"PhotoURL\" of the TypeUser class");
                    set_what("the TypeUser class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TypeUser class");
                    fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the TypeUser class");
                    fieldGeneratorPhotoURL = new JSONHoldingStringGenerator("field \"PhotoURL\" of the TypeUser class");
                    set_what("the TypeUser class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorName.reset();
                    fieldGeneratorID.reset();
                    fieldGeneratorPhotoURL.reset();
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
                protected override void handle_result(TypeUserJSON  result)
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
                public TypeUserJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeUserJSON  result)
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
            protected virtual void handle_result(List<TypeUserJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeUserJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeUserJSON>();
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
            public List<TypeUserJSON> value;
          };
          };
        private bool flagHasRating;
        private sbyte storeRating;
        private bool flagHasLanguage;
        private string storeLanguage;
        private bool flagHasCreated;
        private string storeCreated;
        private bool flagHasURL;
        private string storeURL;
        private bool flagHasText;
        private string storeText;
        private bool flagHasUser;
        private TypeUserJSON  storeUser;


        private void  fromJSONRating(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Rating of TypeReviewsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Rating of TypeReviewsJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setRating(extracted_integer);
          }


        private void  fromJSONLanguage(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Language of TypeReviewsJSON is not a string.");
            setLanguage(json_string.getData());
          }


        private void  fromJSONCreated(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Created of TypeReviewsJSON is not a string.");
            setCreated(json_string.getData());
          }


        private void  fromJSONURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URL of TypeReviewsJSON is not a string.");
            setURL(json_string.getData());
          }


        private void  fromJSONText(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Text of TypeReviewsJSON is not a string.");
            setText(json_string.getData());
          }


        private void  fromJSONUser(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            TypeUserJSON convert_classy = TypeUserJSON.from_json(json_value, ignore_extras, true);
            setUser(convert_classy);
          }


        public TypeReviewsJSON()
          {
            flagHasRating = false;
            flagHasLanguage = false;
            flagHasCreated = false;
            flagHasURL = false;
            flagHasText = false;
            flagHasUser = false;
          }

        public bool  hasRating()
          {
            return flagHasRating;
          }

        public sbyte  getRating()
          {
            Debug.Assert(flagHasRating);
            return storeRating;
          }

        public bool  hasLanguage()
          {
            return flagHasLanguage;
          }

        public string  getLanguage()
          {
            Debug.Assert(flagHasLanguage);
            return storeLanguage;
          }

        public bool  hasCreated()
          {
            return flagHasCreated;
          }

        public string  getCreated()
          {
            Debug.Assert(flagHasCreated);
            return storeCreated;
          }

        public bool  hasURL()
          {
            return flagHasURL;
          }

        public string  getURL()
          {
            Debug.Assert(flagHasURL);
            return storeURL;
          }

        public bool  hasText()
          {
            return flagHasText;
          }

        public string  getText()
          {
            Debug.Assert(flagHasText);
            return storeText;
          }

        public bool  hasUser()
          {
            return flagHasUser;
          }

        public TypeUserJSON   getUser()
          {
            Debug.Assert(flagHasUser);
            return storeUser;
          }



        public void setRating(sbyte new_value)
          {
            flagHasRating = true;
            if (new_value < 0)
                throw new Exception("The value for field Rating of TypeReviewsJSON is less than the lower bound (0) for that field.");
            if (new_value > 5)
                throw new Exception("The value for field Rating of TypeReviewsJSON is greater than the upper bound (5) for that field.");
            storeRating = new_value;
          }
        public void unsetRating()
          {
            flagHasRating = false;
          }
        public void setLanguage(string new_value)
          {
            flagHasLanguage = true;
            storeLanguage = new_value;
          }
        public void unsetLanguage()
          {
            flagHasLanguage = false;
          }
        public void setCreated(string new_value)
          {
            flagHasCreated = true;
            storeCreated = new_value;
          }
        public void unsetCreated()
          {
            flagHasCreated = false;
          }
        public void setURL(string new_value)
          {
            flagHasURL = true;
            storeURL = new_value;
          }
        public void unsetURL()
          {
            flagHasURL = false;
          }
        public void setText(string new_value)
          {
            flagHasText = true;
            storeText = new_value;
          }
        public void unsetText()
          {
            flagHasText = false;
          }
        public void setUser(TypeUserJSON  new_value)
          {
            if (flagHasUser)
              {
              }
            flagHasUser = true;
            storeUser = new_value;
          }
        public void unsetUser()
          {
            if (flagHasUser)
              {
              }
            flagHasUser = false;
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
            Debug.Assert(partial_allowed || flagHasRating);
            if (flagHasRating)
              {
                handler.start_pair("Rating");
                handler.number_value(storeRating);
              }
            Debug.Assert(partial_allowed || flagHasLanguage);
            if (flagHasLanguage)
              {
                handler.start_pair("Language");
                handler.string_value(storeLanguage);
              }
            Debug.Assert(partial_allowed || flagHasCreated);
            if (flagHasCreated)
              {
                handler.start_pair("Created");
                handler.string_value(storeCreated);
              }
            if (flagHasURL)
              {
                handler.start_pair("URL");
                handler.string_value(storeURL);
              }
            if (flagHasText)
              {
                handler.start_pair("Text");
                handler.string_value(storeText);
              }
            Debug.Assert(partial_allowed || flagHasUser);
            if (flagHasUser)
              {
                handler.start_pair("User");
                if (partial_allowed)
                    storeUser.write_partial_as_json(handler);
                else
                    storeUser.write_as_json(handler);
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
            if (!(hasRating()))
              {
                return "When parsing the object for %what%, the \"Rating\" field was missing.";
              }
            if (!(hasLanguage()))
              {
                return "When parsing the object for %what%, the \"Language\" field was missing.";
              }
            if (!(hasCreated()))
              {
                return "When parsing the object for %what%, the \"Created\" field was missing.";
              }
            if (!(hasUser()))
              {
                return "When parsing the object for %what%, the \"User\" field was missing.";
              }
            return null;
          }

        public static TypeReviewsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeReviewsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReviews", ignore_extras);
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
        public static TypeReviewsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeReviewsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeReviewsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReviews", ignore_extras);
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
        public static TypeReviewsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeReviewsJSON from_text(string text, bool ignore_extras)
          {
            TypeReviewsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReviews", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeReviewsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeReviewsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeReviewsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeReviews", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorRating : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorRating(String what) : base(what, 0, 5)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorRating : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorRating(String what) : base(what, 0, 5)
                  {
                  }
              };
            private FieldHoldingGeneratorRating fieldGeneratorRating;
            private JSONHoldingStringGenerator fieldGeneratorLanguage;
            private JSONHoldingStringGenerator fieldGeneratorCreated;
            private JSONHoldingStringGenerator fieldGeneratorURL;
            private JSONHoldingStringGenerator fieldGeneratorText;
            private TypeUserJSON.HoldingGenerator fieldGeneratorUser;

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
                TypeReviewsJSON result = new TypeReviewsJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeReviewsJSON result)
              {
                if (fieldGeneratorRating.have_value)
                  {
                    result.setRating((sbyte)(fieldGeneratorRating.value));
                    fieldGeneratorRating.have_value = false;
                  }
                else if ((!(result.hasRating())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Rating\" field was missing.");
                  }
                if (fieldGeneratorLanguage.have_value)
                  {
                    result.setLanguage(fieldGeneratorLanguage.value);
                    fieldGeneratorLanguage.have_value = false;
                  }
                else if ((!(result.hasLanguage())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Language\" field was missing.");
                  }
                if (fieldGeneratorCreated.have_value)
                  {
                    result.setCreated(fieldGeneratorCreated.value);
                    fieldGeneratorCreated.have_value = false;
                  }
                else if ((!(result.hasCreated())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Created\" field was missing.");
                  }
                if (fieldGeneratorURL.have_value)
                  {
                    result.setURL(fieldGeneratorURL.value);
                    fieldGeneratorURL.have_value = false;
                  }
                if (fieldGeneratorText.have_value)
                  {
                    result.setText(fieldGeneratorText.value);
                    fieldGeneratorText.have_value = false;
                  }
                if (fieldGeneratorUser.have_value)
                  {
                    result.setUser(fieldGeneratorUser.value);
                    fieldGeneratorUser.have_value = false;
                  }
                else if ((!(result.hasUser())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"User\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeReviewsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "reated", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorCreated;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "anguage", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorLanguage;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "ating", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorRating;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ext", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorText;
                        break;
                    case 'U':
                        switch (field_name[1])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 2, "L", 0, 1, false) == 0) && (field_name.Length == 3))
                                    return fieldGeneratorURL;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 2, "er", 0, 2, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorUser;
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
                fieldGeneratorRating = new FieldHoldingGeneratorRating("field \"Rating\" of the TypeReviews class");
                fieldGeneratorLanguage = new JSONHoldingStringGenerator("field \"Language\" of the TypeReviews class");
                fieldGeneratorCreated = new JSONHoldingStringGenerator("field \"Created\" of the TypeReviews class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeReviews class");
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeReviews class");
                fieldGeneratorUser = new TypeUserJSON.HoldingGenerator("field \"User\" of the TypeReviews class", ignore_extras);
                set_what("the TypeReviews class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorRating = new FieldHoldingGeneratorRating("field \"Rating\" of the TypeReviews class");
                fieldGeneratorLanguage = new JSONHoldingStringGenerator("field \"Language\" of the TypeReviews class");
                fieldGeneratorCreated = new JSONHoldingStringGenerator("field \"Created\" of the TypeReviews class");
                fieldGeneratorURL = new JSONHoldingStringGenerator("field \"URL\" of the TypeReviews class");
                fieldGeneratorText = new JSONHoldingStringGenerator("field \"Text\" of the TypeReviews class");
                fieldGeneratorUser = new TypeUserJSON.HoldingGenerator("field \"User\" of the TypeReviews class", false);
                set_what("the TypeReviews class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorRating.reset();
                fieldGeneratorLanguage.reset();
                fieldGeneratorCreated.reset();
                fieldGeneratorURL.reset();
                fieldGeneratorText.reset();
                fieldGeneratorUser.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorUser.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorUser.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeReviewsJSON  result)
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
            public TypeReviewsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeReviewsJSON  result)
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
        protected virtual void handle_result(List<TypeReviewsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeReviewsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeReviewsJSON>();
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
        public List<TypeReviewsJSON> value;
      };
      };
    public class TypeHoursJSON : JSONBase
      {
        private bool flagHasMonday;
        private List< LocalResultBusinessHoursJSON  > storeMonday;
        private bool flagHasTuesday;
        private List< LocalResultBusinessHoursJSON  > storeTuesday;
        private bool flagHasWednesday;
        private List< LocalResultBusinessHoursJSON  > storeWednesday;
        private bool flagHasThursday;
        private List< LocalResultBusinessHoursJSON  > storeThursday;
        private bool flagHasFriday;
        private List< LocalResultBusinessHoursJSON  > storeFriday;
        private bool flagHasSaturday;
        private List< LocalResultBusinessHoursJSON  > storeSaturday;
        private bool flagHasSunday;
        private List< LocalResultBusinessHoursJSON  > storeSunday;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMonday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Monday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Monday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Monday1.Add(convert_classy);
              }
            initMonday();
            for (int num1 = 0; num1 < vector_Monday1.Count; ++num1)
                appendMonday(vector_Monday1[num1]);
            for (int num1 = 0; num1 < vector_Monday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONTuesday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Tuesday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Tuesday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Tuesday1.Add(convert_classy);
              }
            initTuesday();
            for (int num2 = 0; num2 < vector_Tuesday1.Count; ++num2)
                appendTuesday(vector_Tuesday1[num2]);
            for (int num1 = 0; num1 < vector_Tuesday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONWednesday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Wednesday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Wednesday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Wednesday1.Add(convert_classy);
              }
            initWednesday();
            for (int num3 = 0; num3 < vector_Wednesday1.Count; ++num3)
                appendWednesday(vector_Wednesday1[num3]);
            for (int num1 = 0; num1 < vector_Wednesday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONThursday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Thursday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Thursday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Thursday1.Add(convert_classy);
              }
            initThursday();
            for (int num4 = 0; num4 < vector_Thursday1.Count; ++num4)
                appendThursday(vector_Thursday1[num4]);
            for (int num1 = 0; num1 < vector_Thursday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONFriday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Friday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Friday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Friday1.Add(convert_classy);
              }
            initFriday();
            for (int num5 = 0; num5 < vector_Friday1.Count; ++num5)
                appendFriday(vector_Friday1[num5]);
            for (int num1 = 0; num1 < vector_Friday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONSaturday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Saturday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Saturday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Saturday1.Add(convert_classy);
              }
            initSaturday();
            for (int num6 = 0; num6 < vector_Saturday1.Count; ++num6)
                appendSaturday(vector_Saturday1[num6]);
            for (int num1 = 0; num1 < vector_Saturday1.Count; ++num1)
              {
              }
          }


        private void  fromJSONSunday(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Sunday of TypeHoursJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< LocalResultBusinessHoursJSON  > vector_Sunday1 = new List< LocalResultBusinessHoursJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Sunday1.Add(convert_classy);
              }
            initSunday();
            for (int num7 = 0; num7 < vector_Sunday1.Count; ++num7)
                appendSunday(vector_Sunday1[num7]);
            for (int num1 = 0; num1 < vector_Sunday1.Count; ++num1)
              {
              }
          }


        public TypeHoursJSON()
          {
            flagHasMonday = false;
            flagHasTuesday = false;
            flagHasWednesday = false;
            flagHasThursday = false;
            flagHasFriday = false;
            flagHasSaturday = false;
            flagHasSunday = false;
            storeMonday = new List< LocalResultBusinessHoursJSON  >();
            storeTuesday = new List< LocalResultBusinessHoursJSON  >();
            storeWednesday = new List< LocalResultBusinessHoursJSON  >();
            storeThursday = new List< LocalResultBusinessHoursJSON  >();
            storeFriday = new List< LocalResultBusinessHoursJSON  >();
            storeSaturday = new List< LocalResultBusinessHoursJSON  >();
            storeSunday = new List< LocalResultBusinessHoursJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMonday()
          {
            return flagHasMonday;
          }

        public int  countOfMonday()
          {
            Debug.Assert(flagHasMonday);
            return storeMonday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfMonday(int element_num)
          {
            Debug.Assert(flagHasMonday);
            return storeMonday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getMonday()
          {
            Debug.Assert(flagHasMonday);
            return storeMonday;
          }

        public bool  hasTuesday()
          {
            return flagHasTuesday;
          }

        public int  countOfTuesday()
          {
            Debug.Assert(flagHasTuesday);
            return storeTuesday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfTuesday(int element_num)
          {
            Debug.Assert(flagHasTuesday);
            return storeTuesday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getTuesday()
          {
            Debug.Assert(flagHasTuesday);
            return storeTuesday;
          }

        public bool  hasWednesday()
          {
            return flagHasWednesday;
          }

        public int  countOfWednesday()
          {
            Debug.Assert(flagHasWednesday);
            return storeWednesday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfWednesday(int element_num)
          {
            Debug.Assert(flagHasWednesday);
            return storeWednesday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getWednesday()
          {
            Debug.Assert(flagHasWednesday);
            return storeWednesday;
          }

        public bool  hasThursday()
          {
            return flagHasThursday;
          }

        public int  countOfThursday()
          {
            Debug.Assert(flagHasThursday);
            return storeThursday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfThursday(int element_num)
          {
            Debug.Assert(flagHasThursday);
            return storeThursday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getThursday()
          {
            Debug.Assert(flagHasThursday);
            return storeThursday;
          }

        public bool  hasFriday()
          {
            return flagHasFriday;
          }

        public int  countOfFriday()
          {
            Debug.Assert(flagHasFriday);
            return storeFriday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfFriday(int element_num)
          {
            Debug.Assert(flagHasFriday);
            return storeFriday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getFriday()
          {
            Debug.Assert(flagHasFriday);
            return storeFriday;
          }

        public bool  hasSaturday()
          {
            return flagHasSaturday;
          }

        public int  countOfSaturday()
          {
            Debug.Assert(flagHasSaturday);
            return storeSaturday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfSaturday(int element_num)
          {
            Debug.Assert(flagHasSaturday);
            return storeSaturday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getSaturday()
          {
            Debug.Assert(flagHasSaturday);
            return storeSaturday;
          }

        public bool  hasSunday()
          {
            return flagHasSunday;
          }

        public int  countOfSunday()
          {
            Debug.Assert(flagHasSunday);
            return storeSunday.Count;
          }

        public LocalResultBusinessHoursJSON   elementOfSunday(int element_num)
          {
            Debug.Assert(flagHasSunday);
            return storeSunday[element_num];
          }

        public List< LocalResultBusinessHoursJSON  >  getSunday()
          {
            Debug.Assert(flagHasSunday);
            return storeSunday;
          }


        public virtual int extraTypeHoursComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeHoursComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeHoursComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeHoursLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initMonday()
          {
            if (flagHasMonday)
              {
                for (int num1 = 0; num1 < storeMonday.Count; ++num1)
                  {
                  }
              }
            flagHasMonday = true;
            storeMonday.Clear();
          }
        public void appendMonday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasMonday)
              {
                flagHasMonday = true;
                storeMonday.Clear();
              }
            Debug.Assert(flagHasMonday);
            storeMonday.Add(to_append);
          }
        public void unsetMonday()
          {
            if (flagHasMonday)
              {
                for (int num2 = 0; num2 < storeMonday.Count; ++num2)
                  {
                  }
              }
            flagHasMonday = false;
            storeMonday.Clear();
          }
        public void initTuesday()
          {
            if (flagHasTuesday)
              {
                for (int num3 = 0; num3 < storeTuesday.Count; ++num3)
                  {
                  }
              }
            flagHasTuesday = true;
            storeTuesday.Clear();
          }
        public void appendTuesday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasTuesday)
              {
                flagHasTuesday = true;
                storeTuesday.Clear();
              }
            Debug.Assert(flagHasTuesday);
            storeTuesday.Add(to_append);
          }
        public void unsetTuesday()
          {
            if (flagHasTuesday)
              {
                for (int num4 = 0; num4 < storeTuesday.Count; ++num4)
                  {
                  }
              }
            flagHasTuesday = false;
            storeTuesday.Clear();
          }
        public void initWednesday()
          {
            if (flagHasWednesday)
              {
                for (int num5 = 0; num5 < storeWednesday.Count; ++num5)
                  {
                  }
              }
            flagHasWednesday = true;
            storeWednesday.Clear();
          }
        public void appendWednesday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasWednesday)
              {
                flagHasWednesday = true;
                storeWednesday.Clear();
              }
            Debug.Assert(flagHasWednesday);
            storeWednesday.Add(to_append);
          }
        public void unsetWednesday()
          {
            if (flagHasWednesday)
              {
                for (int num6 = 0; num6 < storeWednesday.Count; ++num6)
                  {
                  }
              }
            flagHasWednesday = false;
            storeWednesday.Clear();
          }
        public void initThursday()
          {
            if (flagHasThursday)
              {
                for (int num7 = 0; num7 < storeThursday.Count; ++num7)
                  {
                  }
              }
            flagHasThursday = true;
            storeThursday.Clear();
          }
        public void appendThursday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasThursday)
              {
                flagHasThursday = true;
                storeThursday.Clear();
              }
            Debug.Assert(flagHasThursday);
            storeThursday.Add(to_append);
          }
        public void unsetThursday()
          {
            if (flagHasThursday)
              {
                for (int num8 = 0; num8 < storeThursday.Count; ++num8)
                  {
                  }
              }
            flagHasThursday = false;
            storeThursday.Clear();
          }
        public void initFriday()
          {
            if (flagHasFriday)
              {
                for (int num9 = 0; num9 < storeFriday.Count; ++num9)
                  {
                  }
              }
            flagHasFriday = true;
            storeFriday.Clear();
          }
        public void appendFriday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasFriday)
              {
                flagHasFriday = true;
                storeFriday.Clear();
              }
            Debug.Assert(flagHasFriday);
            storeFriday.Add(to_append);
          }
        public void unsetFriday()
          {
            if (flagHasFriday)
              {
                for (int num10 = 0; num10 < storeFriday.Count; ++num10)
                  {
                  }
              }
            flagHasFriday = false;
            storeFriday.Clear();
          }
        public void initSaturday()
          {
            if (flagHasSaturday)
              {
                for (int num11 = 0; num11 < storeSaturday.Count; ++num11)
                  {
                  }
              }
            flagHasSaturday = true;
            storeSaturday.Clear();
          }
        public void appendSaturday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasSaturday)
              {
                flagHasSaturday = true;
                storeSaturday.Clear();
              }
            Debug.Assert(flagHasSaturday);
            storeSaturday.Add(to_append);
          }
        public void unsetSaturday()
          {
            if (flagHasSaturday)
              {
                for (int num12 = 0; num12 < storeSaturday.Count; ++num12)
                  {
                  }
              }
            flagHasSaturday = false;
            storeSaturday.Clear();
          }
        public void initSunday()
          {
            if (flagHasSunday)
              {
                for (int num13 = 0; num13 < storeSunday.Count; ++num13)
                  {
                  }
              }
            flagHasSunday = true;
            storeSunday.Clear();
          }
        public void appendSunday(LocalResultBusinessHoursJSON  to_append)
          {
            if (!flagHasSunday)
              {
                flagHasSunday = true;
                storeSunday.Clear();
              }
            Debug.Assert(flagHasSunday);
            storeSunday.Add(to_append);
          }
        public void unsetSunday()
          {
            if (flagHasSunday)
              {
                for (int num14 = 0; num14 < storeSunday.Count; ++num14)
                  {
                  }
              }
            flagHasSunday = false;
            storeSunday.Clear();
          }

        public virtual void extraTypeHoursAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeHoursSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeHoursLookup(key);
            if (old_field == null)
              {
                extraTypeHoursAppendPair(key, new_component);
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
            if (flagHasMonday)
              {
                handler.start_pair("Monday");
                handler.start_array();
                for (int num1 = 0; num1 < storeMonday.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeMonday[num1].write_partial_as_json(handler);
                    else
                        storeMonday[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasTuesday)
              {
                handler.start_pair("Tuesday");
                handler.start_array();
                for (int num2 = 0; num2 < storeTuesday.Count; ++num2)
                  {
                    if (partial_allowed)
                        storeTuesday[num2].write_partial_as_json(handler);
                    else
                        storeTuesday[num2].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasWednesday)
              {
                handler.start_pair("Wednesday");
                handler.start_array();
                for (int num3 = 0; num3 < storeWednesday.Count; ++num3)
                  {
                    if (partial_allowed)
                        storeWednesday[num3].write_partial_as_json(handler);
                    else
                        storeWednesday[num3].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasThursday)
              {
                handler.start_pair("Thursday");
                handler.start_array();
                for (int num4 = 0; num4 < storeThursday.Count; ++num4)
                  {
                    if (partial_allowed)
                        storeThursday[num4].write_partial_as_json(handler);
                    else
                        storeThursday[num4].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasFriday)
              {
                handler.start_pair("Friday");
                handler.start_array();
                for (int num5 = 0; num5 < storeFriday.Count; ++num5)
                  {
                    if (partial_allowed)
                        storeFriday[num5].write_partial_as_json(handler);
                    else
                        storeFriday[num5].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasSaturday)
              {
                handler.start_pair("Saturday");
                handler.start_array();
                for (int num6 = 0; num6 < storeSaturday.Count; ++num6)
                  {
                    if (partial_allowed)
                        storeSaturday[num6].write_partial_as_json(handler);
                    else
                        storeSaturday[num6].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasSunday)
              {
                handler.start_pair("Sunday");
                handler.start_array();
                for (int num7 = 0; num7 < storeSunday.Count; ++num7)
                  {
                    if (partial_allowed)
                        storeSunday[num7].write_partial_as_json(handler);
                    else
                        storeSunday[num7].write_as_json(handler);
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

        public static TypeHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHoursJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHours", ignore_extras);
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
        public static TypeHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeHoursJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHours", ignore_extras);
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
        public static TypeHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeHoursJSON from_text(string text, bool ignore_extras)
          {
            TypeHoursJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHours", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeHoursJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeHoursJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeHoursJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeHours", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorMonday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorTuesday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorWednesday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorThursday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorFriday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorSaturday;
            private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorSunday;
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
                TypeHoursJSON result = new TypeHoursJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeHoursAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeHoursJSON result)
              {
                if (fieldGeneratorMonday.have_value)
                  {
                    result.initMonday();
                    int count = fieldGeneratorMonday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendMonday(fieldGeneratorMonday.value[num]);
                      }
                    fieldGeneratorMonday.value.Clear();
                    fieldGeneratorMonday.have_value = false;
                  }
                if (fieldGeneratorTuesday.have_value)
                  {
                    result.initTuesday();
                    int count = fieldGeneratorTuesday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTuesday(fieldGeneratorTuesday.value[num]);
                      }
                    fieldGeneratorTuesday.value.Clear();
                    fieldGeneratorTuesday.have_value = false;
                  }
                if (fieldGeneratorWednesday.have_value)
                  {
                    result.initWednesday();
                    int count = fieldGeneratorWednesday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendWednesday(fieldGeneratorWednesday.value[num]);
                      }
                    fieldGeneratorWednesday.value.Clear();
                    fieldGeneratorWednesday.have_value = false;
                  }
                if (fieldGeneratorThursday.have_value)
                  {
                    result.initThursday();
                    int count = fieldGeneratorThursday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendThursday(fieldGeneratorThursday.value[num]);
                      }
                    fieldGeneratorThursday.value.Clear();
                    fieldGeneratorThursday.have_value = false;
                  }
                if (fieldGeneratorFriday.have_value)
                  {
                    result.initFriday();
                    int count = fieldGeneratorFriday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendFriday(fieldGeneratorFriday.value[num]);
                      }
                    fieldGeneratorFriday.value.Clear();
                    fieldGeneratorFriday.have_value = false;
                  }
                if (fieldGeneratorSaturday.have_value)
                  {
                    result.initSaturday();
                    int count = fieldGeneratorSaturday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendSaturday(fieldGeneratorSaturday.value[num]);
                      }
                    fieldGeneratorSaturday.value.Clear();
                    fieldGeneratorSaturday.have_value = false;
                  }
                if (fieldGeneratorSunday.have_value)
                  {
                    result.initSunday();
                    int count = fieldGeneratorSunday.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendSunday(fieldGeneratorSunday.value[num]);
                      }
                    fieldGeneratorSunday.value.Clear();
                    fieldGeneratorSunday.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeHoursJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'F':
                        if ((String.Compare(field_name, 1, "riday", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorFriday;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "onday", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorMonday;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "turday", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorSaturday;
                                break;
                            case 'u':
                                if ((String.Compare(field_name, 2, "nday", 0, 4, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorSunday;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        switch (field_name[1])
                          {
                            case 'h':
                                if ((String.Compare(field_name, 2, "ursday", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorThursday;
                                break;
                            case 'u':
                                if ((String.Compare(field_name, 2, "esday", 0, 5, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorTuesday;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "ednesday", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorWednesday;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMonday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Monday\" of the TypeHours class", ignore_extras);
                fieldGeneratorTuesday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Tuesday\" of the TypeHours class", ignore_extras);
                fieldGeneratorWednesday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Wednesday\" of the TypeHours class", ignore_extras);
                fieldGeneratorThursday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Thursday\" of the TypeHours class", ignore_extras);
                fieldGeneratorFriday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Friday\" of the TypeHours class", ignore_extras);
                fieldGeneratorSaturday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Saturday\" of the TypeHours class", ignore_extras);
                fieldGeneratorSunday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Sunday\" of the TypeHours class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeHours class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMonday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Monday\" of the TypeHours class", false);
                fieldGeneratorTuesday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Tuesday\" of the TypeHours class", false);
                fieldGeneratorWednesday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Wednesday\" of the TypeHours class", false);
                fieldGeneratorThursday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Thursday\" of the TypeHours class", false);
                fieldGeneratorFriday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Friday\" of the TypeHours class", false);
                fieldGeneratorSaturday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Saturday\" of the TypeHours class", false);
                fieldGeneratorSunday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"Sunday\" of the TypeHours class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeHours class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMonday.reset();
                fieldGeneratorTuesday.reset();
                fieldGeneratorWednesday.reset();
                fieldGeneratorThursday.reset();
                fieldGeneratorFriday.reset();
                fieldGeneratorSaturday.reset();
                fieldGeneratorSunday.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorMonday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTuesday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorWednesday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorThursday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorFriday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSaturday.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSunday.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorMonday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTuesday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorWednesday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorThursday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorFriday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSaturday.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSunday.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeHoursJSON  result)
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
            public TypeHoursJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeHoursJSON  result)
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
        protected virtual void handle_result(List<TypeHoursJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeHoursJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeHoursJSON>();
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
        public List<TypeHoursJSON> value;
      };
      };
    public class TypeAttributesJSON : JSONBase
      {
        public enum TypeWifi
          {
            Wifi_no,
            Wifi_free,
            Wifi_paid
          };

        public static TypeWifi  stringToWifi(string chars)
          {
            switch (chars[0])
              {
                case 'f':
                    if ((String.Compare(chars, 1, "ree", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeWifi.Wifi_free;
                    break;
                case 'n':
                    if ((String.Compare(chars, 1, "o", 0, 1, false) == 0) && (chars.Length == 2))
                        return TypeWifi.Wifi_no;
                    break;
                case 'p':
                    if ((String.Compare(chars, 1, "aid", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeWifi.Wifi_paid;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Wifi' is not one of the legal values.");
          }

        public static string  stringFromWifi(TypeWifi the_enum)
          {
            switch (the_enum)
              {
                case TypeWifi.Wifi_no:
                    return "no";
                case TypeWifi.Wifi_free:
                    return "free";
                case TypeWifi.Wifi_paid:
                    return "paid";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeParking
          {
            Parking_lot,
            Parking_street,
            Parking_garage,
            Parking_valet,
            Parking_validated
          };

        public static TypeParking  stringToParking(string chars)
          {
            switch (chars[0])
              {
                case 'g':
                    if ((String.Compare(chars, 1, "arage", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeParking.Parking_garage;
                    break;
                case 'l':
                    if ((String.Compare(chars, 1, "ot", 0, 2, false) == 0) && (chars.Length == 3))
                        return TypeParking.Parking_lot;
                    break;
                case 's':
                    if ((String.Compare(chars, 1, "treet", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeParking.Parking_street;
                    break;
                case 'v':
                    if (String.Compare(chars, 1, "al", 0, 2, false) == 0)
                      {
                        switch (chars[3])
                          {
                            case 'e':
                                if ((String.Compare(chars, 4, "t", 0, 1, false) == 0) && (chars.Length == 5))
                                    return TypeParking.Parking_valet;
                                break;
                            case 'i':
                                if ((String.Compare(chars, 4, "dated", 0, 5, false) == 0) && (chars.Length == 9))
                                    return TypeParking.Parking_validated;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Parking' is not one of the legal values.");
          }

        public static string  stringFromParking(TypeParking the_enum)
          {
            switch (the_enum)
              {
                case TypeParking.Parking_lot:
                    return "lot";
                case TypeParking.Parking_street:
                    return "street";
                case TypeParking.Parking_garage:
                    return "garage";
                case TypeParking.Parking_valet:
                    return "valet";
                case TypeParking.Parking_validated:
                    return "validated";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasDelivers;
        private bool storeDelivers;
        private bool flagHasTakesReservations;
        private bool storeTakesReservations;
        private bool flagHasGoodForKids;
        private bool storeGoodForKids;
        private bool flagHasOutdoorSeating;
        private bool storeOutdoorSeating;
        private bool flagHasWifi;
        private TypeWifi storeWifi;
        private bool flagHasParking;
        private List< TypeParking > storeParking;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDelivers(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Delivers of TypeAttributesJSON is not true for false.");
                  }
              }
            setDelivers(the_bool);
          }


        private void  fromJSONTakesReservations(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field TakesReservations of TypeAttributesJSON is not true for false.");
                  }
              }
            setTakesReservations(the_bool);
          }


        private void  fromJSONGoodForKids(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field GoodForKids of TypeAttributesJSON is not true for false.");
                  }
              }
            setGoodForKids(the_bool);
          }


        private void  fromJSONOutdoorSeating(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field OutdoorSeating of TypeAttributesJSON is not true for false.");
                  }
              }
            setOutdoorSeating(the_bool);
          }


        private void  fromJSONWifi(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Wifi of TypeAttributesJSON is not a string.");
            TypeWifi the_enum;
            switch (json_string.getData()[0])
              {
                case 'f':
                    if ((String.Compare(json_string.getData(), 1, "ree", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeWifi.Wifi_free;
                            goto enum_is_done;
                          }
                    break;
                case 'n':
                    if ((String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                          {
                            the_enum = TypeWifi.Wifi_no;
                            goto enum_is_done;
                          }
                    break;
                case 'p':
                    if ((String.Compare(json_string.getData(), 1, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeWifi.Wifi_paid;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Wifi of TypeAttributesJSON is not one of the legal strings.");
          enum_is_done:;
            setWifi(the_enum);
          }


        private void  fromJSONParking(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Parking of TypeAttributesJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeParking > vector_Parking1 = new List< TypeParking >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field Parking of TypeAttributesJSON is not a string.");
                TypeParking the_enum;
                switch (json_string.getData()[0])
                  {
                    case 'g':
                        if ((String.Compare(json_string.getData(), 1, "arage", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypeParking.Parking_garage;
                                goto enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 1, "ot", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_enum = TypeParking.Parking_lot;
                                goto enum_is_done;
                              }
                        break;
                    case 's':
                        if ((String.Compare(json_string.getData(), 1, "treet", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_enum = TypeParking.Parking_street;
                                goto enum_is_done;
                              }
                        break;
                    case 'v':
                        if (String.Compare(json_string.getData(), 1, "al", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 4, "t", 0, 1, false) == 0) && (json_string.getData().Length == 5))
                                          {
                                            the_enum = TypeParking.Parking_valet;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 4, "dated", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_enum = TypeParking.Parking_validated;
                                            goto enum_is_done;
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
                throw new Exception("The value for an element of field Parking of TypeAttributesJSON is not one of the legal strings.");
              enum_is_done:;
                vector_Parking1.Add(the_enum);
              }
            initParking();
            for (int num8 = 0; num8 < vector_Parking1.Count; ++num8)
                appendParking(vector_Parking1[num8]);
            for (int num1 = 0; num1 < vector_Parking1.Count; ++num1)
              {
              }
          }


        public TypeAttributesJSON()
          {
            flagHasDelivers = false;
            flagHasTakesReservations = false;
            flagHasGoodForKids = false;
            flagHasOutdoorSeating = false;
            flagHasWifi = false;
            flagHasParking = false;
            storeParking = new List< TypeParking >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDelivers()
          {
            return flagHasDelivers;
          }

        public bool  getDelivers()
          {
            Debug.Assert(flagHasDelivers);
            return storeDelivers;
          }

        public bool  hasTakesReservations()
          {
            return flagHasTakesReservations;
          }

        public bool  getTakesReservations()
          {
            Debug.Assert(flagHasTakesReservations);
            return storeTakesReservations;
          }

        public bool  hasGoodForKids()
          {
            return flagHasGoodForKids;
          }

        public bool  getGoodForKids()
          {
            Debug.Assert(flagHasGoodForKids);
            return storeGoodForKids;
          }

        public bool  hasOutdoorSeating()
          {
            return flagHasOutdoorSeating;
          }

        public bool  getOutdoorSeating()
          {
            Debug.Assert(flagHasOutdoorSeating);
            return storeOutdoorSeating;
          }

        public bool  hasWifi()
          {
            return flagHasWifi;
          }

        public TypeWifi  getWifi()
          {
            Debug.Assert(flagHasWifi);
            return storeWifi;
          }

        public string  getWifiAsString()
          {
            return stringFromWifi(getWifi());
          }

        public bool  hasParking()
          {
            return flagHasParking;
          }

        public int  countOfParking()
          {
            Debug.Assert(flagHasParking);
            return storeParking.Count;
          }

        public TypeParking  elementOfParking(int element_num)
          {
            Debug.Assert(flagHasParking);
            return storeParking[element_num];
          }

        public List< TypeParking >  getParking()
          {
            Debug.Assert(flagHasParking);
            return storeParking;
          }


        public virtual int extraTypeAttributesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeAttributesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeAttributesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeAttributesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDelivers(bool new_value)
          {
            flagHasDelivers = true;
            storeDelivers = new_value;
          }
        public void unsetDelivers()
          {
            flagHasDelivers = false;
          }
        public void setTakesReservations(bool new_value)
          {
            flagHasTakesReservations = true;
            storeTakesReservations = new_value;
          }
        public void unsetTakesReservations()
          {
            flagHasTakesReservations = false;
          }
        public void setGoodForKids(bool new_value)
          {
            flagHasGoodForKids = true;
            storeGoodForKids = new_value;
          }
        public void unsetGoodForKids()
          {
            flagHasGoodForKids = false;
          }
        public void setOutdoorSeating(bool new_value)
          {
            flagHasOutdoorSeating = true;
            storeOutdoorSeating = new_value;
          }
        public void unsetOutdoorSeating()
          {
            flagHasOutdoorSeating = false;
          }
        public void setWifi(TypeWifi new_value)
          {
            flagHasWifi = true;
            storeWifi = new_value;
          }
        public void setWifi(string chars)
          {
            setWifi(stringToWifi(chars));
          }
        public void unsetWifi()
          {
            flagHasWifi = false;
          }
        public void initParking()
          {
            flagHasParking = true;
            storeParking.Clear();
          }
        public void appendParking(TypeParking to_append)
          {
            if (!flagHasParking)
              {
                flagHasParking = true;
                storeParking.Clear();
              }
            Debug.Assert(flagHasParking);
            storeParking.Add(to_append);
          }
        public void appendParking(string chars)
          {
            appendParking(stringToParking(chars));
          }
        public void unsetParking()
          {
            flagHasParking = false;
            storeParking.Clear();
          }

        public virtual void extraTypeAttributesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeAttributesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeAttributesLookup(key);
            if (old_field == null)
              {
                extraTypeAttributesAppendPair(key, new_component);
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
            if (flagHasDelivers)
              {
                handler.start_pair("Delivers");
                handler.boolean_value(storeDelivers);
              }
            if (flagHasTakesReservations)
              {
                handler.start_pair("TakesReservations");
                handler.boolean_value(storeTakesReservations);
              }
            if (flagHasGoodForKids)
              {
                handler.start_pair("GoodForKids");
                handler.boolean_value(storeGoodForKids);
              }
            if (flagHasOutdoorSeating)
              {
                handler.start_pair("OutdoorSeating");
                handler.boolean_value(storeOutdoorSeating);
              }
            if (flagHasWifi)
              {
                handler.start_pair("Wifi");
                switch (storeWifi)
                  {
                    case TypeWifi.Wifi_no:
                        handler.string_value("no");
                        break;
                    case TypeWifi.Wifi_free:
                        handler.string_value("free");
                        break;
                    case TypeWifi.Wifi_paid:
                        handler.string_value("paid");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasParking)
              {
                handler.start_pair("Parking");
                handler.start_array();
                for (int num1 = 0; num1 < storeParking.Count; ++num1)
                  {
                    switch (storeParking[num1])
                      {
                        case TypeParking.Parking_lot:
                            handler.string_value("lot");
                            break;
                        case TypeParking.Parking_street:
                            handler.string_value("street");
                            break;
                        case TypeParking.Parking_garage:
                            handler.string_value("garage");
                            break;
                        case TypeParking.Parking_valet:
                            handler.string_value("valet");
                            break;
                        case TypeParking.Parking_validated:
                            handler.string_value("validated");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
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

        public static TypeAttributesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
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
        public static TypeAttributesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
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
        public static TypeAttributesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesJSON from_text(string text, bool ignore_extras)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAttributesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAttributesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAttributesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributes", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingBooleanGenerator fieldGeneratorDelivers;
            private JSONHoldingBooleanGenerator fieldGeneratorTakesReservations;
            private JSONHoldingBooleanGenerator fieldGeneratorGoodForKids;
            private JSONHoldingBooleanGenerator fieldGeneratorOutdoorSeating;
        private abstract class FieldGeneratorWifi : JSONStringGenerator
              {
                protected FieldGeneratorWifi(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorWifi()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToWifi(result));
                  }
                protected abstract void handle_result(TypeWifi result);
              };
        private class FieldHoldingGeneratorWifi : FieldGeneratorWifi
      {
        protected override void handle_result(TypeWifi result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorWifi(String what)
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
        public TypeWifi value;
      };
        private class FieldHoldingArrayGeneratorWifi : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorWifi
          {
            private FieldHoldingArrayGeneratorWifi top;

            protected override void handle_result(TypeWifi result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorWifi init_top)
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
        protected virtual void handle_result(List<TypeWifi> result)
          {
          }

        public FieldHoldingArrayGeneratorWifi(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeWifi>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorWifi()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeWifi>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeWifi> value;
      };
            private FieldHoldingGeneratorWifi fieldGeneratorWifi;
        private abstract class FieldGeneratorParking : JSONStringGenerator
              {
                protected FieldGeneratorParking(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorParking()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToParking(result));
                  }
                protected abstract void handle_result(TypeParking result);
              };
        private class FieldHoldingGeneratorParking : FieldGeneratorParking
      {
        protected override void handle_result(TypeParking result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorParking(String what)
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
        public TypeParking value;
      };
        private class FieldHoldingArrayGeneratorParking : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorParking
          {
            private FieldHoldingArrayGeneratorParking top;

            protected override void handle_result(TypeParking result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorParking init_top)
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
        protected virtual void handle_result(List<TypeParking> result)
          {
          }

        public FieldHoldingArrayGeneratorParking(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeParking>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorParking()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeParking>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeParking> value;
      };
            private FieldHoldingArrayGeneratorParking fieldGeneratorParking;
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
                TypeAttributesJSON result = new TypeAttributesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeAttributesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeAttributesJSON result)
              {
                if (fieldGeneratorDelivers.have_value)
                  {
                    result.setDelivers(fieldGeneratorDelivers.value);
                    fieldGeneratorDelivers.have_value = false;
                  }
                if (fieldGeneratorTakesReservations.have_value)
                  {
                    result.setTakesReservations(fieldGeneratorTakesReservations.value);
                    fieldGeneratorTakesReservations.have_value = false;
                  }
                if (fieldGeneratorGoodForKids.have_value)
                  {
                    result.setGoodForKids(fieldGeneratorGoodForKids.value);
                    fieldGeneratorGoodForKids.have_value = false;
                  }
                if (fieldGeneratorOutdoorSeating.have_value)
                  {
                    result.setOutdoorSeating(fieldGeneratorOutdoorSeating.value);
                    fieldGeneratorOutdoorSeating.have_value = false;
                  }
                if (fieldGeneratorWifi.have_value)
                  {
                    result.setWifi(fieldGeneratorWifi.value);
                    fieldGeneratorWifi.have_value = false;
                  }
                if (fieldGeneratorParking.have_value)
                  {
                    result.initParking();
                    int count = fieldGeneratorParking.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendParking(fieldGeneratorParking.value[num]);
                      }
                    fieldGeneratorParking.value.Clear();
                    fieldGeneratorParking.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeAttributesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "elivers", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDelivers;
                        break;
                    case 'G':
                        if ((String.Compare(field_name, 1, "oodForKids", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorGoodForKids;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "utdoorSeating", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorOutdoorSeating;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "arking", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorParking;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "akesReservations", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorTakesReservations;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "ifi", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorWifi;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDelivers = new JSONHoldingBooleanGenerator("field \"Delivers\" of the TypeAttributes class");
                fieldGeneratorTakesReservations = new JSONHoldingBooleanGenerator("field \"TakesReservations\" of the TypeAttributes class");
                fieldGeneratorGoodForKids = new JSONHoldingBooleanGenerator("field \"GoodForKids\" of the TypeAttributes class");
                fieldGeneratorOutdoorSeating = new JSONHoldingBooleanGenerator("field \"OutdoorSeating\" of the TypeAttributes class");
                fieldGeneratorWifi = new FieldHoldingGeneratorWifi("field \"Wifi\" of the TypeAttributes class");
                fieldGeneratorParking = new FieldHoldingArrayGeneratorParking("field \"Parking\" of the TypeAttributes class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeAttributes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDelivers = new JSONHoldingBooleanGenerator("field \"Delivers\" of the TypeAttributes class");
                fieldGeneratorTakesReservations = new JSONHoldingBooleanGenerator("field \"TakesReservations\" of the TypeAttributes class");
                fieldGeneratorGoodForKids = new JSONHoldingBooleanGenerator("field \"GoodForKids\" of the TypeAttributes class");
                fieldGeneratorOutdoorSeating = new JSONHoldingBooleanGenerator("field \"OutdoorSeating\" of the TypeAttributes class");
                fieldGeneratorWifi = new FieldHoldingGeneratorWifi("field \"Wifi\" of the TypeAttributes class");
                fieldGeneratorParking = new FieldHoldingArrayGeneratorParking("field \"Parking\" of the TypeAttributes class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeAttributes class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDelivers.reset();
                fieldGeneratorTakesReservations.reset();
                fieldGeneratorGoodForKids.reset();
                fieldGeneratorOutdoorSeating.reset();
                fieldGeneratorWifi.reset();
                fieldGeneratorParking.reset();
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
            protected override void handle_result(TypeAttributesJSON  result)
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
            public TypeAttributesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAttributesJSON  result)
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
        protected virtual void handle_result(List<TypeAttributesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAttributesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAttributesJSON>();
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
        public List<TypeAttributesJSON> value;
      };
      };
    public class TypeAttributesForDisplayJSON : JSONBase
      {
        private bool flagHasLabel;
        private string storeLabel;
        private bool flagHasValue;
        private string storeValue;


        private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Label of TypeAttributesForDisplayJSON is not a string.");
            setLabel(json_string.getData());
          }


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Value of TypeAttributesForDisplayJSON is not a string.");
            setValue(json_string.getData());
          }


        public TypeAttributesForDisplayJSON()
          {
            flagHasLabel = false;
            flagHasValue = false;
          }

        public bool  hasLabel()
          {
            return flagHasLabel;
          }

        public string  getLabel()
          {
            Debug.Assert(flagHasLabel);
            return storeLabel;
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public string  getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }



        public void setLabel(string new_value)
          {
            flagHasLabel = true;
            storeLabel = new_value;
          }
        public void unsetLabel()
          {
            flagHasLabel = false;
          }
        public void setValue(string new_value)
          {
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
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
            Debug.Assert(partial_allowed || flagHasLabel);
            if (flagHasLabel)
              {
                handler.start_pair("Label");
                handler.string_value(storeLabel);
              }
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                handler.string_value(storeValue);
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
            if (!(hasLabel()))
              {
                return "When parsing the object for %what%, the \"Label\" field was missing.";
              }
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeAttributesForDisplayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesForDisplayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributesForDisplay", ignore_extras);
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
        public static TypeAttributesForDisplayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesForDisplayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAttributesForDisplayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributesForDisplay", ignore_extras);
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
        public static TypeAttributesForDisplayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAttributesForDisplayJSON from_text(string text, bool ignore_extras)
          {
            TypeAttributesForDisplayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributesForDisplay", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAttributesForDisplayJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAttributesForDisplayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAttributesForDisplayJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAttributesForDisplay", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLabel;
            private JSONHoldingStringGenerator fieldGeneratorValue;

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
                TypeAttributesForDisplayJSON result = new TypeAttributesForDisplayJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeAttributesForDisplayJSON result)
              {
                if (fieldGeneratorLabel.have_value)
                  {
                    result.setLabel(fieldGeneratorLabel.value);
                    fieldGeneratorLabel.have_value = false;
                  }
                else if ((!(result.hasLabel())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Label\" field was missing.");
                  }
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeAttributesForDisplayJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorLabel;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorValue;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeAttributesForDisplay class");
                fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeAttributesForDisplay class");
                set_what("the TypeAttributesForDisplay class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the TypeAttributesForDisplay class");
                fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeAttributesForDisplay class");
                set_what("the TypeAttributesForDisplay class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLabel.reset();
                fieldGeneratorValue.reset();
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
            protected override void handle_result(TypeAttributesForDisplayJSON  result)
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
            public TypeAttributesForDisplayJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAttributesForDisplayJSON  result)
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
        protected virtual void handle_result(List<TypeAttributesForDisplayJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAttributesForDisplayJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAttributesForDisplayJSON>();
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
        public List<TypeAttributesForDisplayJSON> value;
      };
      };
    private bool flagHasName;
    private string storeName;
    private bool flagHasAlias;
    private string storeAlias;
    private bool flagHasID;
    private string storeID;
    private bool flagHasRating;
    private double storeRating;
    private string textStoreRating;
    private bool flagHasReviewCount;
    private BigInteger storeReviewCount;
    private bool flagHasPrice;
    private sbyte storePrice;
    private bool flagHasPhone;
    private List< TypePhoneJSON  > storePhone;
    private bool flagHasLinks;
    private List< TypeLinksJSON  > storeLinks;
    private bool flagHasYelpURL;
    private string storeYelpURL;
    private bool flagHasEmail;
    private string storeEmail;
    private bool flagHasPhotos;
    private List< TypePhotosJSON  > storePhotos;
    private bool flagHasIsRestaurant;
    private bool storeIsRestaurant;
    private bool flagHasPermanentlyClosed;
    private bool storePermanentlyClosed;
    private bool flagHasIsClaimed;
    private bool storeIsClaimed;
    private bool flagHasCategories;
    private List< TypeCategoriesJSON  > storeCategories;
    private bool flagHasDistanceFromReference;
    private TypeDistanceFromReferenceJSON  storeDistanceFromReference;
    private bool flagHasDistanceFromUser;
    private TypeDistanceFromUserJSON  storeDistanceFromUser;
    private bool flagHasBearingFromUser;
    private double storeBearingFromUser;
    private string textStoreBearingFromUser;
    private bool flagHasReviews;
    private List< TypeReviewsJSON  > storeReviews;
    private bool flagHasHours;
    private TypeHoursJSON  storeHours;
    private bool flagHasHoursToday;
    private List< LocalResultBusinessHoursJSON  > storeHoursToday;
    private bool flagHasOpenNow;
    private bool storeOpenNow;
    private bool flagHasMinutesToOpen;
    private BigInteger storeMinutesToOpen;
    private bool flagHasMinutesToClose;
    private BigInteger storeMinutesToClose;
    private bool flagHasOpen24Hours;
    private bool storeOpen24Hours;
    private bool flagHasAttributes;
    private TypeAttributesJSON  storeAttributes;
    private bool flagHasAttributesForDisplay;
    private List< TypeAttributesForDisplayJSON  > storeAttributesForDisplay;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNameToJSON()
      {
        JSONStringValue generated_string_Name = new JSONStringValue(storeName);
        return generated_string_Name;
      }

    private JSONValue  extraAliasToJSON()
      {
        JSONStringValue generated_string_Alias = new JSONStringValue(storeAlias);
        return generated_string_Alias;
      }

    private JSONValue  extraIDToJSON()
      {
        JSONStringValue generated_string_ID = new JSONStringValue(storeID);
        return generated_string_ID;
      }

    private JSONValue  extraRatingToJSON()
      {
        JSONValue generated_rational_Rating;
        if (textStoreRating != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreRating);
            generated_rational_Rating = handler.result;
          }
        else if (((double)(long)storeRating) == storeRating)
            generated_rational_Rating = new JSONIntegerValue((long)(storeRating));
        else
            generated_rational_Rating = new JSONRationalValue(storeRating, 15);
        return generated_rational_Rating;
      }

    private JSONValue  extraReviewCountToJSON()
      {
        JSONIntegerValue generated_integer_ReviewCount = new JSONIntegerValue(storeReviewCount);
        return generated_integer_ReviewCount;
      }

    private JSONValue  extraPriceToJSON()
      {
        JSONIntegerValue generated_integer_Price = new JSONIntegerValue(storePrice);
        return generated_integer_Price;
      }

    private JSONValue  extraPhoneToJSON()
      {
        JSONArrayValue generated_array_1_Phone = new JSONArrayValue();
        for (int num1 = 0; num1 < storePhone.Count; ++num1)
          {
            JSONValueHandler handler_Phone = new JSONValueHandler();
            storePhone[num1].write_as_json(handler_Phone);
            generated_array_1_Phone.appendComponent(handler_Phone.result);
          }
        return generated_array_1_Phone;
      }

    private JSONValue  extraLinksToJSON()
      {
        JSONArrayValue generated_array_2_Links = new JSONArrayValue();
        for (int num2 = 0; num2 < storeLinks.Count; ++num2)
          {
            JSONValueHandler handler_Links = new JSONValueHandler();
            storeLinks[num2].write_as_json(handler_Links);
            generated_array_2_Links.appendComponent(handler_Links.result);
          }
        return generated_array_2_Links;
      }

    private JSONValue  extraYelpURLToJSON()
      {
        JSONStringValue generated_string_YelpURL = new JSONStringValue(storeYelpURL);
        return generated_string_YelpURL;
      }

    private JSONValue  extraEmailToJSON()
      {
        JSONStringValue generated_string_Email = new JSONStringValue(storeEmail);
        return generated_string_Email;
      }

    private JSONValue  extraPhotosToJSON()
      {
        JSONArrayValue generated_array_3_Photos = new JSONArrayValue();
        for (int num3 = 0; num3 < storePhotos.Count; ++num3)
          {
            JSONValueHandler handler_Photos = new JSONValueHandler();
            storePhotos[num3].write_as_json(handler_Photos);
            generated_array_3_Photos.appendComponent(handler_Photos.result);
          }
        return generated_array_3_Photos;
      }

    private JSONValue  extraIsRestaurantToJSON()
      {
        JSONValue generated_boolean_IsRestaurant = (storeIsRestaurant ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsRestaurant;
      }

    private JSONValue  extraPermanentlyClosedToJSON()
      {
        JSONValue generated_boolean_PermanentlyClosed = (storePermanentlyClosed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_PermanentlyClosed;
      }

    private JSONValue  extraIsClaimedToJSON()
      {
        JSONValue generated_boolean_IsClaimed = (storeIsClaimed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsClaimed;
      }

    private JSONValue  extraCategoriesToJSON()
      {
        JSONArrayValue generated_array_4_Categories = new JSONArrayValue();
        for (int num4 = 0; num4 < storeCategories.Count; ++num4)
          {
            JSONValueHandler handler_Categories = new JSONValueHandler();
            storeCategories[num4].write_as_json(handler_Categories);
            generated_array_4_Categories.appendComponent(handler_Categories.result);
          }
        return generated_array_4_Categories;
      }

    private JSONValue  extraDistanceFromReferenceToJSON()
      {
        JSONValueHandler handler_DistanceFromReference = new JSONValueHandler();
        storeDistanceFromReference.write_as_json(handler_DistanceFromReference);
        return handler_DistanceFromReference.result;
      }

    private JSONValue  extraDistanceFromUserToJSON()
      {
        JSONValueHandler handler_DistanceFromUser = new JSONValueHandler();
        storeDistanceFromUser.write_as_json(handler_DistanceFromUser);
        return handler_DistanceFromUser.result;
      }

    private JSONValue  extraBearingFromUserToJSON()
      {
        JSONValue generated_rational_BearingFromUser;
        if (textStoreBearingFromUser != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreBearingFromUser);
            generated_rational_BearingFromUser = handler.result;
          }
        else if (((double)(long)storeBearingFromUser) == storeBearingFromUser)
            generated_rational_BearingFromUser = new JSONIntegerValue((long)(storeBearingFromUser));
        else
            generated_rational_BearingFromUser = new JSONRationalValue(storeBearingFromUser, 15);
        return generated_rational_BearingFromUser;
      }

    private JSONValue  extraReviewsToJSON()
      {
        JSONArrayValue generated_array_5_Reviews = new JSONArrayValue();
        for (int num5 = 0; num5 < storeReviews.Count; ++num5)
          {
            JSONValueHandler handler_Reviews = new JSONValueHandler();
            storeReviews[num5].write_as_json(handler_Reviews);
            generated_array_5_Reviews.appendComponent(handler_Reviews.result);
          }
        return generated_array_5_Reviews;
      }

    private JSONValue  extraHoursToJSON()
      {
        JSONValueHandler handler_Hours = new JSONValueHandler();
        storeHours.write_as_json(handler_Hours);
        return handler_Hours.result;
      }

    private JSONValue  extraHoursTodayToJSON()
      {
        JSONArrayValue generated_array_6_HoursToday = new JSONArrayValue();
        for (int num6 = 0; num6 < storeHoursToday.Count; ++num6)
          {
            JSONValueHandler handler_HoursToday = new JSONValueHandler();
            storeHoursToday[num6].write_as_json(handler_HoursToday);
            generated_array_6_HoursToday.appendComponent(handler_HoursToday.result);
          }
        return generated_array_6_HoursToday;
      }

    private JSONValue  extraOpenNowToJSON()
      {
        JSONValue generated_boolean_OpenNow = (storeOpenNow ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_OpenNow;
      }

    private JSONValue  extraMinutesToOpenToJSON()
      {
        JSONIntegerValue generated_integer_MinutesToOpen = new JSONIntegerValue(storeMinutesToOpen);
        return generated_integer_MinutesToOpen;
      }

    private JSONValue  extraMinutesToCloseToJSON()
      {
        JSONIntegerValue generated_integer_MinutesToClose = new JSONIntegerValue(storeMinutesToClose);
        return generated_integer_MinutesToClose;
      }

    private JSONValue  extraOpen24HoursToJSON()
      {
        JSONValue generated_boolean_Open24Hours = (storeOpen24Hours ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Open24Hours;
      }

    private JSONValue  extraAttributesToJSON()
      {
        JSONValueHandler handler_Attributes = new JSONValueHandler();
        storeAttributes.write_as_json(handler_Attributes);
        return handler_Attributes.result;
      }

    private JSONValue  extraAttributesForDisplayToJSON()
      {
        JSONArrayValue generated_array_7_AttributesForDisplay = new JSONArrayValue();
        for (int num7 = 0; num7 < storeAttributesForDisplay.Count; ++num7)
          {
            JSONValueHandler handler_AttributesForDisplay = new JSONValueHandler();
            storeAttributesForDisplay[num7].write_as_json(handler_AttributesForDisplay);
            generated_array_7_AttributesForDisplay.appendComponent(handler_AttributesForDisplay.result);
          }
        return generated_array_7_AttributesForDisplay;
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of LocalResultAnnotatedMapLocationJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONAlias(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Alias of LocalResultAnnotatedMapLocationJSON is not a string.");
        setAlias(json_string.getData());
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of LocalResultAnnotatedMapLocationJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Rating of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
          }
        setRatingText(the_rational_text);
      }


    private void  fromJSONReviewCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReviewCount of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCount of LocalResultAnnotatedMapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCount(extracted_integer);
      }


    private void  fromJSONPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Price of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Price of LocalResultAnnotatedMapLocationJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setPrice(extracted_integer);
      }


    private void  fromJSONPhone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Phone of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePhoneJSON  > vector_Phone1 = new List< TypePhoneJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePhoneJSON convert_classy = TypePhoneJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Phone1.Add(convert_classy);
          }
        initPhone();
        for (int num9 = 0; num9 < vector_Phone1.Count; ++num9)
            appendPhone(vector_Phone1[num9]);
        for (int num1 = 0; num1 < vector_Phone1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Links of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeLinksJSON  > vector_Links1 = new List< TypeLinksJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeLinksJSON convert_classy = TypeLinksJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Links1.Add(convert_classy);
          }
        initLinks();
        for (int num10 = 0; num10 < vector_Links1.Count; ++num10)
            appendLinks(vector_Links1[num10]);
        for (int num1 = 0; num1 < vector_Links1.Count; ++num1)
          {
          }
      }


    private void  fromJSONYelpURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YelpURL of LocalResultAnnotatedMapLocationJSON is not a string.");
        setYelpURL(json_string.getData());
      }


    private void  fromJSONEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Email of LocalResultAnnotatedMapLocationJSON is not a string.");
        setEmail(json_string.getData());
      }


    private void  fromJSONPhotos(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Photos of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePhotosJSON  > vector_Photos1 = new List< TypePhotosJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePhotosJSON convert_classy = TypePhotosJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Photos1.Add(convert_classy);
          }
        initPhotos();
        for (int num11 = 0; num11 < vector_Photos1.Count; ++num11)
            appendPhotos(vector_Photos1[num11]);
        for (int num1 = 0; num1 < vector_Photos1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIsRestaurant(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRestaurant of LocalResultAnnotatedMapLocationJSON is not true for false.");
              }
          }
        setIsRestaurant(the_bool);
      }


    private void  fromJSONPermanentlyClosed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PermanentlyClosed of LocalResultAnnotatedMapLocationJSON is not true for false.");
              }
          }
        setPermanentlyClosed(the_bool);
      }


    private void  fromJSONIsClaimed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsClaimed of LocalResultAnnotatedMapLocationJSON is not true for false.");
              }
          }
        setIsClaimed(the_bool);
      }


    private void  fromJSONCategories(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Categories of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeCategoriesJSON  > vector_Categories1 = new List< TypeCategoriesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeCategoriesJSON convert_classy = TypeCategoriesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Categories1.Add(convert_classy);
          }
        initCategories();
        for (int num12 = 0; num12 < vector_Categories1.Count; ++num12)
            appendCategories(vector_Categories1[num12]);
        for (int num1 = 0; num1 < vector_Categories1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDistanceFromReference(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDistanceFromReferenceJSON convert_classy = TypeDistanceFromReferenceJSON.from_json(json_value, ignore_extras, true);
        setDistanceFromReference(convert_classy);
      }


    private void  fromJSONDistanceFromUser(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDistanceFromUserJSON convert_classy = TypeDistanceFromUserJSON.from_json(json_value, ignore_extras, true);
        setDistanceFromUser(convert_classy);
      }


    private void  fromJSONBearingFromUser(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
          }
        setBearingFromUserText(the_rational_text);
      }


    private void  fromJSONReviews(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Reviews of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeReviewsJSON  > vector_Reviews1 = new List< TypeReviewsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeReviewsJSON convert_classy = TypeReviewsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Reviews1.Add(convert_classy);
          }
        initReviews();
        for (int num13 = 0; num13 < vector_Reviews1.Count; ++num13)
            appendReviews(vector_Reviews1[num13]);
        for (int num1 = 0; num1 < vector_Reviews1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeHoursJSON convert_classy = TypeHoursJSON.from_json(json_value, ignore_extras, true);
        setHours(convert_classy);
      }


    private void  fromJSONHoursToday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HoursToday of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< LocalResultBusinessHoursJSON  > vector_HoursToday1 = new List< LocalResultBusinessHoursJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LocalResultBusinessHoursJSON convert_classy = LocalResultBusinessHoursJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HoursToday1.Add(convert_classy);
          }
        initHoursToday();
        for (int num14 = 0; num14 < vector_HoursToday1.Count; ++num14)
            appendHoursToday(vector_HoursToday1[num14]);
        for (int num1 = 0; num1 < vector_HoursToday1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOpenNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenNow of LocalResultAnnotatedMapLocationJSON is not true for false.");
              }
          }
        setOpenNow(the_bool);
      }


    private void  fromJSONMinutesToOpen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MinutesToOpen of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MinutesToOpen of LocalResultAnnotatedMapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMinutesToOpen(extracted_integer);
      }


    private void  fromJSONMinutesToClose(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MinutesToClose of LocalResultAnnotatedMapLocationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MinutesToClose of LocalResultAnnotatedMapLocationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMinutesToClose(extracted_integer);
      }


    private void  fromJSONOpen24Hours(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Open24Hours of LocalResultAnnotatedMapLocationJSON is not true for false.");
              }
          }
        setOpen24Hours(the_bool);
      }


    private void  fromJSONAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeAttributesJSON convert_classy = TypeAttributesJSON.from_json(json_value, ignore_extras, true);
        setAttributes(convert_classy);
      }


    private void  fromJSONAttributesForDisplay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AttributesForDisplay of LocalResultAnnotatedMapLocationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAttributesForDisplayJSON  > vector_AttributesForDisplay1 = new List< TypeAttributesForDisplayJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAttributesForDisplayJSON convert_classy = TypeAttributesForDisplayJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AttributesForDisplay1.Add(convert_classy);
          }
        initAttributesForDisplay();
        for (int num15 = 0; num15 < vector_AttributesForDisplay1.Count; ++num15)
            appendAttributesForDisplay(vector_AttributesForDisplay1[num15]);
        for (int num1 = 0; num1 < vector_AttributesForDisplay1.Count; ++num1)
          {
          }
      }


    public LocalResultAnnotatedMapLocationJSON()
      {
        flagHasName = false;
        flagHasAlias = false;
        flagHasID = false;
        flagHasRating = false;
        flagHasReviewCount = false;
        flagHasPrice = false;
        flagHasPhone = false;
        flagHasLinks = false;
        flagHasYelpURL = false;
        flagHasEmail = false;
        flagHasPhotos = false;
        flagHasIsRestaurant = false;
        flagHasPermanentlyClosed = false;
        flagHasIsClaimed = false;
        flagHasCategories = false;
        flagHasDistanceFromReference = false;
        flagHasDistanceFromUser = false;
        flagHasBearingFromUser = false;
        flagHasReviews = false;
        flagHasHours = false;
        flagHasHoursToday = false;
        flagHasOpenNow = false;
        flagHasMinutesToOpen = false;
        flagHasMinutesToClose = false;
        flagHasOpen24Hours = false;
        flagHasAttributes = false;
        flagHasAttributesForDisplay = false;
        storePhone = new List< TypePhoneJSON  >();
        storeLinks = new List< TypeLinksJSON  >();
        storePhotos = new List< TypePhotosJSON  >();
        storeCategories = new List< TypeCategoriesJSON  >();
        storeReviews = new List< TypeReviewsJSON  >();
        storeHoursToday = new List< LocalResultBusinessHoursJSON  >();
        storeAttributesForDisplay = new List< TypeAttributesForDisplayJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getLocationType()
      {
        return "YelpLocation";
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

    public bool  hasAlias()
      {
        return flagHasAlias;
      }

    public string  getAlias()
      {
        Debug.Assert(flagHasAlias);
        return storeAlias;
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

    public bool  hasRating()
      {
        return flagHasRating;
      }

    public double  getRating()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating != "")
          {
            return Double.Parse(textStoreRating);
          }
        return storeRating;
      }

    public string  getRatingAsText()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating == "")
          {
            return Convert.ToString(storeRating);
          }
        else
          {
            return (textStoreRating);
          }
      }

    public bool  hasReviewCount()
      {
        return flagHasReviewCount;
      }

    public BigInteger  getReviewCount()
      {
        Debug.Assert(flagHasReviewCount);
        return storeReviewCount;
      }

    public bool  hasPrice()
      {
        return flagHasPrice;
      }

    public sbyte  getPrice()
      {
        Debug.Assert(flagHasPrice);
        return storePrice;
      }

    public bool  hasPhone()
      {
        return flagHasPhone;
      }

    public int  countOfPhone()
      {
        Debug.Assert(flagHasPhone);
        return storePhone.Count;
      }

    public TypePhoneJSON   elementOfPhone(int element_num)
      {
        Debug.Assert(flagHasPhone);
        return storePhone[element_num];
      }

    public List< TypePhoneJSON  >  getPhone()
      {
        Debug.Assert(flagHasPhone);
        return storePhone;
      }

    public bool  hasLinks()
      {
        return flagHasLinks;
      }

    public int  countOfLinks()
      {
        Debug.Assert(flagHasLinks);
        return storeLinks.Count;
      }

    public TypeLinksJSON   elementOfLinks(int element_num)
      {
        Debug.Assert(flagHasLinks);
        return storeLinks[element_num];
      }

    public List< TypeLinksJSON  >  getLinks()
      {
        Debug.Assert(flagHasLinks);
        return storeLinks;
      }

    public bool  hasYelpURL()
      {
        return flagHasYelpURL;
      }

    public string  getYelpURL()
      {
        Debug.Assert(flagHasYelpURL);
        return storeYelpURL;
      }

    public bool  hasEmail()
      {
        return flagHasEmail;
      }

    public string  getEmail()
      {
        Debug.Assert(flagHasEmail);
        return storeEmail;
      }

    public bool  hasPhotos()
      {
        return flagHasPhotos;
      }

    public int  countOfPhotos()
      {
        Debug.Assert(flagHasPhotos);
        return storePhotos.Count;
      }

    public TypePhotosJSON   elementOfPhotos(int element_num)
      {
        Debug.Assert(flagHasPhotos);
        return storePhotos[element_num];
      }

    public List< TypePhotosJSON  >  getPhotos()
      {
        Debug.Assert(flagHasPhotos);
        return storePhotos;
      }

    public bool  hasIsRestaurant()
      {
        return flagHasIsRestaurant;
      }

    public bool  getIsRestaurant()
      {
        Debug.Assert(flagHasIsRestaurant);
        return storeIsRestaurant;
      }

    public bool  hasPermanentlyClosed()
      {
        return flagHasPermanentlyClosed;
      }

    public bool  getPermanentlyClosed()
      {
        Debug.Assert(flagHasPermanentlyClosed);
        return storePermanentlyClosed;
      }

    public bool  hasIsClaimed()
      {
        return flagHasIsClaimed;
      }

    public bool  getIsClaimed()
      {
        Debug.Assert(flagHasIsClaimed);
        return storeIsClaimed;
      }

    public bool  hasCategories()
      {
        return flagHasCategories;
      }

    public int  countOfCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories.Count;
      }

    public TypeCategoriesJSON   elementOfCategories(int element_num)
      {
        Debug.Assert(flagHasCategories);
        return storeCategories[element_num];
      }

    public List< TypeCategoriesJSON  >  getCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories;
      }

    public bool  hasDistanceFromReference()
      {
        return flagHasDistanceFromReference;
      }

    public TypeDistanceFromReferenceJSON   getDistanceFromReference()
      {
        Debug.Assert(flagHasDistanceFromReference);
        return storeDistanceFromReference;
      }

    public bool  hasDistanceFromUser()
      {
        return flagHasDistanceFromUser;
      }

    public TypeDistanceFromUserJSON   getDistanceFromUser()
      {
        Debug.Assert(flagHasDistanceFromUser);
        return storeDistanceFromUser;
      }

    public bool  hasBearingFromUser()
      {
        return flagHasBearingFromUser;
      }

    public double  getBearingFromUser()
      {
        Debug.Assert(flagHasBearingFromUser);
        if (textStoreBearingFromUser != "")
          {
            return Double.Parse(textStoreBearingFromUser);
          }
        return storeBearingFromUser;
      }

    public string  getBearingFromUserAsText()
      {
        Debug.Assert(flagHasBearingFromUser);
        if (textStoreBearingFromUser == "")
          {
            return Convert.ToString(storeBearingFromUser);
          }
        else
          {
            return (textStoreBearingFromUser);
          }
      }

    public bool  hasReviews()
      {
        return flagHasReviews;
      }

    public int  countOfReviews()
      {
        Debug.Assert(flagHasReviews);
        return storeReviews.Count;
      }

    public TypeReviewsJSON   elementOfReviews(int element_num)
      {
        Debug.Assert(flagHasReviews);
        return storeReviews[element_num];
      }

    public List< TypeReviewsJSON  >  getReviews()
      {
        Debug.Assert(flagHasReviews);
        return storeReviews;
      }

    public bool  hasHours()
      {
        return flagHasHours;
      }

    public TypeHoursJSON   getHours()
      {
        Debug.Assert(flagHasHours);
        return storeHours;
      }

    public bool  hasHoursToday()
      {
        return flagHasHoursToday;
      }

    public int  countOfHoursToday()
      {
        Debug.Assert(flagHasHoursToday);
        return storeHoursToday.Count;
      }

    public LocalResultBusinessHoursJSON   elementOfHoursToday(int element_num)
      {
        Debug.Assert(flagHasHoursToday);
        return storeHoursToday[element_num];
      }

    public List< LocalResultBusinessHoursJSON  >  getHoursToday()
      {
        Debug.Assert(flagHasHoursToday);
        return storeHoursToday;
      }

    public bool  hasOpenNow()
      {
        return flagHasOpenNow;
      }

    public bool  getOpenNow()
      {
        Debug.Assert(flagHasOpenNow);
        return storeOpenNow;
      }

    public bool  hasMinutesToOpen()
      {
        return flagHasMinutesToOpen;
      }

    public BigInteger  getMinutesToOpen()
      {
        Debug.Assert(flagHasMinutesToOpen);
        return storeMinutesToOpen;
      }

    public bool  hasMinutesToClose()
      {
        return flagHasMinutesToClose;
      }

    public BigInteger  getMinutesToClose()
      {
        Debug.Assert(flagHasMinutesToClose);
        return storeMinutesToClose;
      }

    public bool  hasOpen24Hours()
      {
        return flagHasOpen24Hours;
      }

    public bool  getOpen24Hours()
      {
        Debug.Assert(flagHasOpen24Hours);
        return storeOpen24Hours;
      }

    public bool  hasAttributes()
      {
        return flagHasAttributes;
      }

    public TypeAttributesJSON   getAttributes()
      {
        Debug.Assert(flagHasAttributes);
        return storeAttributes;
      }

    public bool  hasAttributesForDisplay()
      {
        return flagHasAttributesForDisplay;
      }

    public int  countOfAttributesForDisplay()
      {
        Debug.Assert(flagHasAttributesForDisplay);
        return storeAttributesForDisplay.Count;
      }

    public TypeAttributesForDisplayJSON   elementOfAttributesForDisplay(int element_num)
      {
        Debug.Assert(flagHasAttributesForDisplay);
        return storeAttributesForDisplay[element_num];
      }

    public List< TypeAttributesForDisplayJSON  >  getAttributesForDisplay()
      {
        Debug.Assert(flagHasAttributesForDisplay);
        return storeAttributesForDisplay;
      }


    public virtual int extraLocalResultAnnotatedMapLocationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalResultAnnotatedMapLocationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalResultAnnotatedMapLocationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalResultAnnotatedMapLocationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraAnnotatedMapLocationComponentCount()
      {
        int result = 0;
        if (flagHasName)
            ++result;
        if (flagHasAlias)
            ++result;
        if (flagHasID)
            ++result;
        if (flagHasRating)
            ++result;
        if (flagHasReviewCount)
            ++result;
        if (flagHasPrice)
            ++result;
        if (flagHasPhone)
            ++result;
        if (flagHasLinks)
            ++result;
        if (flagHasYelpURL)
            ++result;
        if (flagHasEmail)
            ++result;
        if (flagHasPhotos)
            ++result;
        if (flagHasIsRestaurant)
            ++result;
        if (flagHasPermanentlyClosed)
            ++result;
        if (flagHasIsClaimed)
            ++result;
        if (flagHasCategories)
            ++result;
        if (flagHasDistanceFromReference)
            ++result;
        if (flagHasDistanceFromUser)
            ++result;
        if (flagHasBearingFromUser)
            ++result;
        if (flagHasReviews)
            ++result;
        if (flagHasHours)
            ++result;
        if (flagHasHoursToday)
            ++result;
        if (flagHasOpenNow)
            ++result;
        if (flagHasMinutesToOpen)
            ++result;
        if (flagHasMinutesToClose)
            ++result;
        if (flagHasOpen24Hours)
            ++result;
        if (flagHasAttributes)
            ++result;
        if (flagHasAttributesForDisplay)
            ++result;
        result += extraLocalResultAnnotatedMapLocationComponentCount();
        return result;
      }
    public override string extraAnnotatedMapLocationComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasName)
          {
            if (remainder == 0)
                return "Name";
            --remainder;
          }
        if (flagHasAlias)
          {
            if (remainder == 0)
                return "Alias";
            --remainder;
          }
        if (flagHasID)
          {
            if (remainder == 0)
                return "ID";
            --remainder;
          }
        if (flagHasRating)
          {
            if (remainder == 0)
                return "Rating";
            --remainder;
          }
        if (flagHasReviewCount)
          {
            if (remainder == 0)
                return "ReviewCount";
            --remainder;
          }
        if (flagHasPrice)
          {
            if (remainder == 0)
                return "Price";
            --remainder;
          }
        if (flagHasPhone)
          {
            if (remainder == 0)
                return "Phone";
            --remainder;
          }
        if (flagHasLinks)
          {
            if (remainder == 0)
                return "Links";
            --remainder;
          }
        if (flagHasYelpURL)
          {
            if (remainder == 0)
                return "YelpURL";
            --remainder;
          }
        if (flagHasEmail)
          {
            if (remainder == 0)
                return "Email";
            --remainder;
          }
        if (flagHasPhotos)
          {
            if (remainder == 0)
                return "Photos";
            --remainder;
          }
        if (flagHasIsRestaurant)
          {
            if (remainder == 0)
                return "IsRestaurant";
            --remainder;
          }
        if (flagHasPermanentlyClosed)
          {
            if (remainder == 0)
                return "PermanentlyClosed";
            --remainder;
          }
        if (flagHasIsClaimed)
          {
            if (remainder == 0)
                return "IsClaimed";
            --remainder;
          }
        if (flagHasCategories)
          {
            if (remainder == 0)
                return "Categories";
            --remainder;
          }
        if (flagHasDistanceFromReference)
          {
            if (remainder == 0)
                return "DistanceFromReference";
            --remainder;
          }
        if (flagHasDistanceFromUser)
          {
            if (remainder == 0)
                return "DistanceFromUser";
            --remainder;
          }
        if (flagHasBearingFromUser)
          {
            if (remainder == 0)
                return "BearingFromUser";
            --remainder;
          }
        if (flagHasReviews)
          {
            if (remainder == 0)
                return "Reviews";
            --remainder;
          }
        if (flagHasHours)
          {
            if (remainder == 0)
                return "Hours";
            --remainder;
          }
        if (flagHasHoursToday)
          {
            if (remainder == 0)
                return "HoursToday";
            --remainder;
          }
        if (flagHasOpenNow)
          {
            if (remainder == 0)
                return "OpenNow";
            --remainder;
          }
        if (flagHasMinutesToOpen)
          {
            if (remainder == 0)
                return "MinutesToOpen";
            --remainder;
          }
        if (flagHasMinutesToClose)
          {
            if (remainder == 0)
                return "MinutesToClose";
            --remainder;
          }
        if (flagHasOpen24Hours)
          {
            if (remainder == 0)
                return "Open24Hours";
            --remainder;
          }
        if (flagHasAttributes)
          {
            if (remainder == 0)
                return "Attributes";
            --remainder;
          }
        if (flagHasAttributesForDisplay)
          {
            if (remainder == 0)
                return "AttributesForDisplay";
            --remainder;
          }
        return extraLocalResultAnnotatedMapLocationComponentKey(remainder);
      }
    public override JSONValue extraAnnotatedMapLocationComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasName)
          {
            if (remainder == 0)
                return extraNameToJSON();
            --remainder;
          }
        if (flagHasAlias)
          {
            if (remainder == 0)
                return extraAliasToJSON();
            --remainder;
          }
        if (flagHasID)
          {
            if (remainder == 0)
                return extraIDToJSON();
            --remainder;
          }
        if (flagHasRating)
          {
            if (remainder == 0)
                return extraRatingToJSON();
            --remainder;
          }
        if (flagHasReviewCount)
          {
            if (remainder == 0)
                return extraReviewCountToJSON();
            --remainder;
          }
        if (flagHasPrice)
          {
            if (remainder == 0)
                return extraPriceToJSON();
            --remainder;
          }
        if (flagHasPhone)
          {
            if (remainder == 0)
                return extraPhoneToJSON();
            --remainder;
          }
        if (flagHasLinks)
          {
            if (remainder == 0)
                return extraLinksToJSON();
            --remainder;
          }
        if (flagHasYelpURL)
          {
            if (remainder == 0)
                return extraYelpURLToJSON();
            --remainder;
          }
        if (flagHasEmail)
          {
            if (remainder == 0)
                return extraEmailToJSON();
            --remainder;
          }
        if (flagHasPhotos)
          {
            if (remainder == 0)
                return extraPhotosToJSON();
            --remainder;
          }
        if (flagHasIsRestaurant)
          {
            if (remainder == 0)
                return extraIsRestaurantToJSON();
            --remainder;
          }
        if (flagHasPermanentlyClosed)
          {
            if (remainder == 0)
                return extraPermanentlyClosedToJSON();
            --remainder;
          }
        if (flagHasIsClaimed)
          {
            if (remainder == 0)
                return extraIsClaimedToJSON();
            --remainder;
          }
        if (flagHasCategories)
          {
            if (remainder == 0)
                return extraCategoriesToJSON();
            --remainder;
          }
        if (flagHasDistanceFromReference)
          {
            if (remainder == 0)
                return extraDistanceFromReferenceToJSON();
            --remainder;
          }
        if (flagHasDistanceFromUser)
          {
            if (remainder == 0)
                return extraDistanceFromUserToJSON();
            --remainder;
          }
        if (flagHasBearingFromUser)
          {
            if (remainder == 0)
                return extraBearingFromUserToJSON();
            --remainder;
          }
        if (flagHasReviews)
          {
            if (remainder == 0)
                return extraReviewsToJSON();
            --remainder;
          }
        if (flagHasHours)
          {
            if (remainder == 0)
                return extraHoursToJSON();
            --remainder;
          }
        if (flagHasHoursToday)
          {
            if (remainder == 0)
                return extraHoursTodayToJSON();
            --remainder;
          }
        if (flagHasOpenNow)
          {
            if (remainder == 0)
                return extraOpenNowToJSON();
            --remainder;
          }
        if (flagHasMinutesToOpen)
          {
            if (remainder == 0)
                return extraMinutesToOpenToJSON();
            --remainder;
          }
        if (flagHasMinutesToClose)
          {
            if (remainder == 0)
                return extraMinutesToCloseToJSON();
            --remainder;
          }
        if (flagHasOpen24Hours)
          {
            if (remainder == 0)
                return extraOpen24HoursToJSON();
            --remainder;
          }
        if (flagHasAttributes)
          {
            if (remainder == 0)
                return extraAttributesToJSON();
            --remainder;
          }
        if (flagHasAttributesForDisplay)
          {
            if (remainder == 0)
                return extraAttributesForDisplayToJSON();
            --remainder;
          }
        return extraLocalResultAnnotatedMapLocationComponentValue(remainder);
      }
    public override JSONValue extraAnnotatedMapLocationLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "ias", 0, 3, false) == 0) && (field_name.Length == 5))
                            return (flagHasAlias ? extraAliasToJSON() : null);
                        break;
                    case 't':
                        if (String.Compare(field_name, 2, "tributes", 0, 8, false) == 0)
                          {
                            if (field_name.Length == 10)
                              {
                                return (flagHasAttributes ? extraAttributesToJSON() : null);
                              }
                            switch (field_name[10])
                              {
                                case 'F':
                                    if ((String.Compare(field_name, 11, "orDisplay", 0, 9, false) == 0) && (field_name.Length == 20))
                                        return (flagHasAttributesForDisplay ? extraAttributesForDisplayToJSON() : null);
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
            case 'B':
                if ((String.Compare(field_name, 1, "earingFromUser", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasBearingFromUser ? extraBearingFromUserToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "ategories", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasCategories ? extraCategoriesToJSON() : null);
                break;
            case 'D':
                if (String.Compare(field_name, 1, "istanceFrom", 0, 11, false) == 0)
                  {
                    switch (field_name[12])
                      {
                        case 'R':
                            if ((String.Compare(field_name, 13, "eference", 0, 8, false) == 0) && (field_name.Length == 21))
                                return (flagHasDistanceFromReference ? extraDistanceFromReferenceToJSON() : null);
                            break;
                        case 'U':
                            if ((String.Compare(field_name, 13, "ser", 0, 3, false) == 0) && (field_name.Length == 16))
                                return (flagHasDistanceFromUser ? extraDistanceFromUserToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEmail ? extraEmailToJSON() : null);
                break;
            case 'H':
                if (String.Compare(field_name, 1, "ours", 0, 4, false) == 0)
                  {
                    if (field_name.Length == 5)
                      {
                        return (flagHasHours ? extraHoursToJSON() : null);
                      }
                    switch (field_name[5])
                      {
                        case 'T':
                            if ((String.Compare(field_name, 6, "oday", 0, 4, false) == 0) && (field_name.Length == 10))
                                return (flagHasHoursToday ? extraHoursTodayToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                switch (field_name[1])
                  {
                    case 'D':
                        if (field_name.Length == 2)
                            return (flagHasID ? extraIDToJSON() : null);
                        break;
                    case 's':
                        switch (field_name[2])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 3, "laimed", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return (flagHasIsClaimed ? extraIsClaimedToJSON() : null);
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 3, "estaurant", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return (flagHasIsRestaurant ? extraIsRestaurantToJSON() : null);
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "inks", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasLinks ? extraLinksToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "inutesTo", 0, 8, false) == 0)
                  {
                    switch (field_name[9])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 10, "lose", 0, 4, false) == 0) && (field_name.Length == 14))
                                return (flagHasMinutesToClose ? extraMinutesToCloseToJSON() : null);
                            break;
                        case 'O':
                            if ((String.Compare(field_name, 10, "pen", 0, 3, false) == 0) && (field_name.Length == 13))
                                return (flagHasMinutesToOpen ? extraMinutesToOpenToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasName ? extraNameToJSON() : null);
                break;
            case 'O':
                if (String.Compare(field_name, 1, "pen", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case '2':
                            if ((String.Compare(field_name, 5, "4Hours", 0, 6, false) == 0) && (field_name.Length == 11))
                                return (flagHasOpen24Hours ? extraOpen24HoursToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 5, "ow", 0, 2, false) == 0) && (field_name.Length == 7))
                                return (flagHasOpenNow ? extraOpenNowToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "rmanentlyClosed", 0, 15, false) == 0) && (field_name.Length == 17))
                            return (flagHasPermanentlyClosed ? extraPermanentlyClosedToJSON() : null);
                        break;
                    case 'h':
                        if (String.Compare(field_name, 2, "o", 0, 1, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 4, "e", 0, 1, false) == 0) && (field_name.Length == 5))
                                        return (flagHasPhone ? extraPhoneToJSON() : null);
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 4, "os", 0, 2, false) == 0) && (field_name.Length == 6))
                                        return (flagHasPhotos ? extraPhotosToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "ice", 0, 3, false) == 0) && (field_name.Length == 5))
                            return (flagHasPrice ? extraPriceToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ting", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasRating ? extraRatingToJSON() : null);
                        break;
                    case 'e':
                        if (String.Compare(field_name, 2, "view", 0, 4, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return (flagHasReviewCount ? extraReviewCountToJSON() : null);
                                    break;
                                case 's':
                                    if (field_name.Length == 7)
                                        return (flagHasReviews ? extraReviewsToJSON() : null);
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
            case 'Y':
                if ((String.Compare(field_name, 1, "elpURL", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasYelpURL ? extraYelpURLToJSON() : null);
                break;
            default:
                break;
          }
        return extraLocalResultAnnotatedMapLocationLookup(field_name);
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
    public void setAlias(string new_value)
      {
        flagHasAlias = true;
        storeAlias = new_value;
      }
    public void unsetAlias()
      {
        flagHasAlias = false;
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
    public void setRating(double new_value)
      {
        flagHasRating = true;
        if (new_value < 0)
            throw new Exception("The value for field Rating of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field Rating of LocalResultAnnotatedMapLocationJSON is greater than the upper bound (5) for that field.");
        storeRating = new_value;
        textStoreRating = "";
      }
    public void setRatingText(string new_value)
      {
        flagHasRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Rating of LocalResultAnnotatedMapLocationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Rating of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "5", "", false, "1") > 0)
            throw new Exception("The value for field Rating of LocalResultAnnotatedMapLocationJSON is greater than the upper bound (5) for that field.");
        textStoreRating = new_value;
      }
    public void unsetRating()
      {
        flagHasRating = false;
      }
    public void setReviewCount(BigInteger new_value)
      {
        flagHasReviewCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCount of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        storeReviewCount = new_value;
      }
    public void unsetReviewCount()
      {
        flagHasReviewCount = false;
      }
    public void setPrice(sbyte new_value)
      {
        flagHasPrice = true;
        if (new_value < 0)
            throw new Exception("The value for field Price of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field Price of LocalResultAnnotatedMapLocationJSON is greater than the upper bound (5) for that field.");
        storePrice = new_value;
      }
    public void unsetPrice()
      {
        flagHasPrice = false;
      }
    public void initPhone()
      {
        if (flagHasPhone)
          {
            for (int num15 = 0; num15 < storePhone.Count; ++num15)
              {
              }
          }
        flagHasPhone = true;
        storePhone.Clear();
      }
    public void appendPhone(TypePhoneJSON  to_append)
      {
        if (!flagHasPhone)
          {
            flagHasPhone = true;
            storePhone.Clear();
          }
        Debug.Assert(flagHasPhone);
        storePhone.Add(to_append);
      }
    public void unsetPhone()
      {
        if (flagHasPhone)
          {
            for (int num16 = 0; num16 < storePhone.Count; ++num16)
              {
              }
          }
        flagHasPhone = false;
        storePhone.Clear();
      }
    public void initLinks()
      {
        if (flagHasLinks)
          {
            for (int num17 = 0; num17 < storeLinks.Count; ++num17)
              {
              }
          }
        flagHasLinks = true;
        storeLinks.Clear();
      }
    public void appendLinks(TypeLinksJSON  to_append)
      {
        if (!flagHasLinks)
          {
            flagHasLinks = true;
            storeLinks.Clear();
          }
        Debug.Assert(flagHasLinks);
        storeLinks.Add(to_append);
      }
    public void unsetLinks()
      {
        if (flagHasLinks)
          {
            for (int num18 = 0; num18 < storeLinks.Count; ++num18)
              {
              }
          }
        flagHasLinks = false;
        storeLinks.Clear();
      }
    public void setYelpURL(string new_value)
      {
        flagHasYelpURL = true;
        storeYelpURL = new_value;
      }
    public void unsetYelpURL()
      {
        flagHasYelpURL = false;
      }
    public void setEmail(string new_value)
      {
        flagHasEmail = true;
        storeEmail = new_value;
      }
    public void unsetEmail()
      {
        flagHasEmail = false;
      }
    public void initPhotos()
      {
        if (flagHasPhotos)
          {
            for (int num19 = 0; num19 < storePhotos.Count; ++num19)
              {
              }
          }
        flagHasPhotos = true;
        storePhotos.Clear();
      }
    public void appendPhotos(TypePhotosJSON  to_append)
      {
        if (!flagHasPhotos)
          {
            flagHasPhotos = true;
            storePhotos.Clear();
          }
        Debug.Assert(flagHasPhotos);
        storePhotos.Add(to_append);
      }
    public void unsetPhotos()
      {
        if (flagHasPhotos)
          {
            for (int num20 = 0; num20 < storePhotos.Count; ++num20)
              {
              }
          }
        flagHasPhotos = false;
        storePhotos.Clear();
      }
    public void setIsRestaurant(bool new_value)
      {
        flagHasIsRestaurant = true;
        storeIsRestaurant = new_value;
      }
    public void unsetIsRestaurant()
      {
        flagHasIsRestaurant = false;
      }
    public void setPermanentlyClosed(bool new_value)
      {
        flagHasPermanentlyClosed = true;
        storePermanentlyClosed = new_value;
      }
    public void unsetPermanentlyClosed()
      {
        flagHasPermanentlyClosed = false;
      }
    public void setIsClaimed(bool new_value)
      {
        flagHasIsClaimed = true;
        storeIsClaimed = new_value;
      }
    public void unsetIsClaimed()
      {
        flagHasIsClaimed = false;
      }
    public void initCategories()
      {
        if (flagHasCategories)
          {
            for (int num21 = 0; num21 < storeCategories.Count; ++num21)
              {
              }
          }
        flagHasCategories = true;
        storeCategories.Clear();
      }
    public void appendCategories(TypeCategoriesJSON  to_append)
      {
        if (!flagHasCategories)
          {
            flagHasCategories = true;
            storeCategories.Clear();
          }
        Debug.Assert(flagHasCategories);
        storeCategories.Add(to_append);
      }
    public void unsetCategories()
      {
        if (flagHasCategories)
          {
            for (int num22 = 0; num22 < storeCategories.Count; ++num22)
              {
              }
          }
        flagHasCategories = false;
        storeCategories.Clear();
      }
    public void setDistanceFromReference(TypeDistanceFromReferenceJSON  new_value)
      {
        if (flagHasDistanceFromReference)
          {
          }
        flagHasDistanceFromReference = true;
        storeDistanceFromReference = new_value;
      }
    public void unsetDistanceFromReference()
      {
        if (flagHasDistanceFromReference)
          {
          }
        flagHasDistanceFromReference = false;
      }
    public void setDistanceFromUser(TypeDistanceFromUserJSON  new_value)
      {
        if (flagHasDistanceFromUser)
          {
          }
        flagHasDistanceFromUser = true;
        storeDistanceFromUser = new_value;
      }
    public void unsetDistanceFromUser()
      {
        if (flagHasDistanceFromUser)
          {
          }
        flagHasDistanceFromUser = false;
      }
    public void setBearingFromUser(double new_value)
      {
        flagHasBearingFromUser = true;
        if (new_value < 0)
            throw new Exception("The value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        if (new_value > 360)
            throw new Exception("The value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is greater than the upper bound (360) for that field.");
        storeBearingFromUser = new_value;
        textStoreBearingFromUser = "";
      }
    public void setBearingFromUserText(string new_value)
      {
        flagHasBearingFromUser = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "360", "", false, "3") > 0)
            throw new Exception("The value for field BearingFromUser of LocalResultAnnotatedMapLocationJSON is greater than the upper bound (360) for that field.");
        textStoreBearingFromUser = new_value;
      }
    public void unsetBearingFromUser()
      {
        flagHasBearingFromUser = false;
      }
    public void initReviews()
      {
        if (flagHasReviews)
          {
            for (int num23 = 0; num23 < storeReviews.Count; ++num23)
              {
              }
          }
        flagHasReviews = true;
        storeReviews.Clear();
      }
    public void appendReviews(TypeReviewsJSON  to_append)
      {
        if (!flagHasReviews)
          {
            flagHasReviews = true;
            storeReviews.Clear();
          }
        Debug.Assert(flagHasReviews);
        storeReviews.Add(to_append);
      }
    public void unsetReviews()
      {
        if (flagHasReviews)
          {
            for (int num24 = 0; num24 < storeReviews.Count; ++num24)
              {
              }
          }
        flagHasReviews = false;
        storeReviews.Clear();
      }
    public void setHours(TypeHoursJSON  new_value)
      {
        if (flagHasHours)
          {
          }
        flagHasHours = true;
        storeHours = new_value;
      }
    public void unsetHours()
      {
        if (flagHasHours)
          {
          }
        flagHasHours = false;
      }
    public void initHoursToday()
      {
        if (flagHasHoursToday)
          {
            for (int num25 = 0; num25 < storeHoursToday.Count; ++num25)
              {
              }
          }
        flagHasHoursToday = true;
        storeHoursToday.Clear();
      }
    public void appendHoursToday(LocalResultBusinessHoursJSON  to_append)
      {
        if (!flagHasHoursToday)
          {
            flagHasHoursToday = true;
            storeHoursToday.Clear();
          }
        Debug.Assert(flagHasHoursToday);
        storeHoursToday.Add(to_append);
      }
    public void unsetHoursToday()
      {
        if (flagHasHoursToday)
          {
            for (int num26 = 0; num26 < storeHoursToday.Count; ++num26)
              {
              }
          }
        flagHasHoursToday = false;
        storeHoursToday.Clear();
      }
    public void setOpenNow(bool new_value)
      {
        flagHasOpenNow = true;
        storeOpenNow = new_value;
      }
    public void unsetOpenNow()
      {
        flagHasOpenNow = false;
      }
    public void setMinutesToOpen(BigInteger new_value)
      {
        flagHasMinutesToOpen = true;
        if (new_value < 0)
            throw new Exception("The value for field MinutesToOpen of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        storeMinutesToOpen = new_value;
      }
    public void unsetMinutesToOpen()
      {
        flagHasMinutesToOpen = false;
      }
    public void setMinutesToClose(BigInteger new_value)
      {
        flagHasMinutesToClose = true;
        if (new_value < 0)
            throw new Exception("The value for field MinutesToClose of LocalResultAnnotatedMapLocationJSON is less than the lower bound (0) for that field.");
        storeMinutesToClose = new_value;
      }
    public void unsetMinutesToClose()
      {
        flagHasMinutesToClose = false;
      }
    public void setOpen24Hours(bool new_value)
      {
        flagHasOpen24Hours = true;
        storeOpen24Hours = new_value;
      }
    public void unsetOpen24Hours()
      {
        flagHasOpen24Hours = false;
      }
    public void setAttributes(TypeAttributesJSON  new_value)
      {
        if (flagHasAttributes)
          {
          }
        flagHasAttributes = true;
        storeAttributes = new_value;
      }
    public void unsetAttributes()
      {
        if (flagHasAttributes)
          {
          }
        flagHasAttributes = false;
      }
    public void initAttributesForDisplay()
      {
        if (flagHasAttributesForDisplay)
          {
            for (int num27 = 0; num27 < storeAttributesForDisplay.Count; ++num27)
              {
              }
          }
        flagHasAttributesForDisplay = true;
        storeAttributesForDisplay.Clear();
      }
    public void appendAttributesForDisplay(TypeAttributesForDisplayJSON  to_append)
      {
        if (!flagHasAttributesForDisplay)
          {
            flagHasAttributesForDisplay = true;
            storeAttributesForDisplay.Clear();
          }
        Debug.Assert(flagHasAttributesForDisplay);
        storeAttributesForDisplay.Add(to_append);
      }
    public void unsetAttributesForDisplay()
      {
        if (flagHasAttributesForDisplay)
          {
            for (int num28 = 0; num28 < storeAttributesForDisplay.Count; ++num28)
              {
              }
          }
        flagHasAttributesForDisplay = false;
        storeAttributesForDisplay.Clear();
      }

    public virtual void extraLocalResultAnnotatedMapLocationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalResultAnnotatedMapLocationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalResultAnnotatedMapLocationLookup(key);
        if (old_field == null)
          {
            extraLocalResultAnnotatedMapLocationAppendPair(key, new_component);
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
    public override void extraAnnotatedMapLocationAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "ias", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONAlias(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "tributes", 0, 8, false) == 0)
                          {
                            if (key.Length == 10)
                              {
                                {
                                fromJSONAttributes(new_component, false);
                                return;
                                }
                              }
                            switch (key[10])
                              {
                                case 'F':
                                    if ((String.Compare(key, 11, "orDisplay", 0, 9, false) == 0) && (key.Length == 20))
                                        {
                                        fromJSONAttributesForDisplay(new_component, false);
                                        return;
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
                break;
            case 'B':
                if ((String.Compare(key, 1, "earingFromUser", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONBearingFromUser(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ategories", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONCategories(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "istanceFrom", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'R':
                            if ((String.Compare(key, 13, "eference", 0, 8, false) == 0) && (key.Length == 21))
                                {
                                fromJSONDistanceFromReference(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 13, "ser", 0, 3, false) == 0) && (key.Length == 16))
                                {
                                fromJSONDistanceFromUser(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "mail", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEmail(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if (String.Compare(key, 1, "ours", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONHours(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'T':
                            if ((String.Compare(key, 6, "oday", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONHoursToday(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                switch (key[1])
                  {
                    case 'D':
                        if (key.Length == 2)
                            {
                            fromJSONID(new_component, false);
                            return;
                            }
                        break;
                    case 's':
                        switch (key[2])
                          {
                            case 'C':
                                if ((String.Compare(key, 3, "laimed", 0, 6, false) == 0) && (key.Length == 9))
                                    {
                                    fromJSONIsClaimed(new_component, false);
                                    return;
                                    }
                                break;
                            case 'R':
                                if ((String.Compare(key, 3, "estaurant", 0, 9, false) == 0) && (key.Length == 12))
                                    {
                                    fromJSONIsRestaurant(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "inks", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONLinks(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "inutesTo", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'C':
                            if ((String.Compare(key, 10, "lose", 0, 4, false) == 0) && (key.Length == 14))
                                {
                                fromJSONMinutesToClose(new_component, false);
                                return;
                                }
                            break;
                        case 'O':
                            if ((String.Compare(key, 10, "pen", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONMinutesToOpen(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ame", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONName(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if (String.Compare(key, 1, "pen", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case '2':
                            if ((String.Compare(key, 5, "4Hours", 0, 6, false) == 0) && (key.Length == 11))
                                {
                                fromJSONOpen24Hours(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 5, "ow", 0, 2, false) == 0) && (key.Length == 7))
                                {
                                fromJSONOpenNow(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "rmanentlyClosed", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONPermanentlyClosed(new_component, false);
                            return;
                            }
                        break;
                    case 'h':
                        if (String.Compare(key, 2, "o", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'n':
                                    if ((String.Compare(key, 4, "e", 0, 1, false) == 0) && (key.Length == 5))
                                        {
                                        fromJSONPhone(new_component, false);
                                        return;
                                        }
                                    break;
                                case 't':
                                    if ((String.Compare(key, 4, "os", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONPhotos(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "ice", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONPrice(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ting", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONRating(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "view", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'C':
                                    if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONReviewCount(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if (key.Length == 7)
                                        {
                                        fromJSONReviews(new_component, false);
                                        return;
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
                break;
            case 'Y':
                if ((String.Compare(key, 1, "elpURL", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONYelpURL(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLocalResultAnnotatedMapLocationAppendPair(key, new_component);
      }
    public override void extraAnnotatedMapLocationSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "ias", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONAlias(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if (String.Compare(key, 2, "tributes", 0, 8, false) == 0)
                          {
                            if (key.Length == 10)
                              {
                                {
                                fromJSONAttributes(new_component, false);
                                return;
                                }
                              }
                            switch (key[10])
                              {
                                case 'F':
                                    if ((String.Compare(key, 11, "orDisplay", 0, 9, false) == 0) && (key.Length == 20))
                                        {
                                        fromJSONAttributesForDisplay(new_component, false);
                                        return;
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
                break;
            case 'B':
                if ((String.Compare(key, 1, "earingFromUser", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONBearingFromUser(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "ategories", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONCategories(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "istanceFrom", 0, 11, false) == 0)
                  {
                    switch (key[12])
                      {
                        case 'R':
                            if ((String.Compare(key, 13, "eference", 0, 8, false) == 0) && (key.Length == 21))
                                {
                                fromJSONDistanceFromReference(new_component, false);
                                return;
                                }
                            break;
                        case 'U':
                            if ((String.Compare(key, 13, "ser", 0, 3, false) == 0) && (key.Length == 16))
                                {
                                fromJSONDistanceFromUser(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "mail", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEmail(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if (String.Compare(key, 1, "ours", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONHours(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'T':
                            if ((String.Compare(key, 6, "oday", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONHoursToday(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                switch (key[1])
                  {
                    case 'D':
                        if (key.Length == 2)
                            {
                            fromJSONID(new_component, false);
                            return;
                            }
                        break;
                    case 's':
                        switch (key[2])
                          {
                            case 'C':
                                if ((String.Compare(key, 3, "laimed", 0, 6, false) == 0) && (key.Length == 9))
                                    {
                                    fromJSONIsClaimed(new_component, false);
                                    return;
                                    }
                                break;
                            case 'R':
                                if ((String.Compare(key, 3, "estaurant", 0, 9, false) == 0) && (key.Length == 12))
                                    {
                                    fromJSONIsRestaurant(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "inks", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONLinks(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "inutesTo", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'C':
                            if ((String.Compare(key, 10, "lose", 0, 4, false) == 0) && (key.Length == 14))
                                {
                                fromJSONMinutesToClose(new_component, false);
                                return;
                                }
                            break;
                        case 'O':
                            if ((String.Compare(key, 10, "pen", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONMinutesToOpen(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ame", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONName(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if (String.Compare(key, 1, "pen", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case '2':
                            if ((String.Compare(key, 5, "4Hours", 0, 6, false) == 0) && (key.Length == 11))
                                {
                                fromJSONOpen24Hours(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 5, "ow", 0, 2, false) == 0) && (key.Length == 7))
                                {
                                fromJSONOpenNow(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "rmanentlyClosed", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONPermanentlyClosed(new_component, false);
                            return;
                            }
                        break;
                    case 'h':
                        if (String.Compare(key, 2, "o", 0, 1, false) == 0)
                          {
                            switch (key[3])
                              {
                                case 'n':
                                    if ((String.Compare(key, 4, "e", 0, 1, false) == 0) && (key.Length == 5))
                                        {
                                        fromJSONPhone(new_component, false);
                                        return;
                                        }
                                    break;
                                case 't':
                                    if ((String.Compare(key, 4, "os", 0, 2, false) == 0) && (key.Length == 6))
                                        {
                                        fromJSONPhotos(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "ice", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONPrice(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ting", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONRating(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "view", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'C':
                                    if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONReviewCount(new_component, false);
                                        return;
                                        }
                                    break;
                                case 's':
                                    if (key.Length == 7)
                                        {
                                        fromJSONReviews(new_component, false);
                                        return;
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
                break;
            case 'Y':
                if ((String.Compare(key, 1, "elpURL", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONYelpURL(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraLocalResultAnnotatedMapLocationSetField(key, new_component);
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
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasAlias)
          {
            handler.start_pair("Alias");
            handler.string_value(storeAlias);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasRating)
          {
            handler.start_pair("Rating");
            if (textStoreRating != "")
                handler.number_value(textStoreRating);
            else if (((double)(long)storeRating) == storeRating)
                handler.number_value((long)storeRating);
            else
                handler.number_value(storeRating);
          }
        if (flagHasReviewCount)
          {
            handler.start_pair("ReviewCount");
            handler.number_value(storeReviewCount);
          }
        if (flagHasPrice)
          {
            handler.start_pair("Price");
            handler.number_value(storePrice);
          }
        if (flagHasPhone)
          {
            handler.start_pair("Phone");
            handler.start_array();
            for (int num1 = 0; num1 < storePhone.Count; ++num1)
              {
                if (partial_allowed)
                    storePhone[num1].write_partial_as_json(handler);
                else
                    storePhone[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasLinks)
          {
            handler.start_pair("Links");
            handler.start_array();
            for (int num2 = 0; num2 < storeLinks.Count; ++num2)
              {
                if (partial_allowed)
                    storeLinks[num2].write_partial_as_json(handler);
                else
                    storeLinks[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasYelpURL)
          {
            handler.start_pair("YelpURL");
            handler.string_value(storeYelpURL);
          }
        if (flagHasEmail)
          {
            handler.start_pair("Email");
            handler.string_value(storeEmail);
          }
        if (flagHasPhotos)
          {
            handler.start_pair("Photos");
            handler.start_array();
            for (int num3 = 0; num3 < storePhotos.Count; ++num3)
              {
                if (partial_allowed)
                    storePhotos[num3].write_partial_as_json(handler);
                else
                    storePhotos[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasIsRestaurant)
          {
            handler.start_pair("IsRestaurant");
            handler.boolean_value(storeIsRestaurant);
          }
        if (flagHasPermanentlyClosed)
          {
            handler.start_pair("PermanentlyClosed");
            handler.boolean_value(storePermanentlyClosed);
          }
        if (flagHasIsClaimed)
          {
            handler.start_pair("IsClaimed");
            handler.boolean_value(storeIsClaimed);
          }
        if (flagHasCategories)
          {
            handler.start_pair("Categories");
            handler.start_array();
            for (int num4 = 0; num4 < storeCategories.Count; ++num4)
              {
                if (partial_allowed)
                    storeCategories[num4].write_partial_as_json(handler);
                else
                    storeCategories[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDistanceFromReference)
          {
            handler.start_pair("DistanceFromReference");
            if (partial_allowed)
                storeDistanceFromReference.write_partial_as_json(handler);
            else
                storeDistanceFromReference.write_as_json(handler);
          }
        if (flagHasDistanceFromUser)
          {
            handler.start_pair("DistanceFromUser");
            if (partial_allowed)
                storeDistanceFromUser.write_partial_as_json(handler);
            else
                storeDistanceFromUser.write_as_json(handler);
          }
        if (flagHasBearingFromUser)
          {
            handler.start_pair("BearingFromUser");
            if (textStoreBearingFromUser != "")
                handler.number_value(textStoreBearingFromUser);
            else if (((double)(long)storeBearingFromUser) == storeBearingFromUser)
                handler.number_value((long)storeBearingFromUser);
            else
                handler.number_value(storeBearingFromUser);
          }
        if (flagHasReviews)
          {
            handler.start_pair("Reviews");
            handler.start_array();
            for (int num5 = 0; num5 < storeReviews.Count; ++num5)
              {
                if (partial_allowed)
                    storeReviews[num5].write_partial_as_json(handler);
                else
                    storeReviews[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasHours)
          {
            handler.start_pair("Hours");
            if (partial_allowed)
                storeHours.write_partial_as_json(handler);
            else
                storeHours.write_as_json(handler);
          }
        if (flagHasHoursToday)
          {
            handler.start_pair("HoursToday");
            handler.start_array();
            for (int num6 = 0; num6 < storeHoursToday.Count; ++num6)
              {
                if (partial_allowed)
                    storeHoursToday[num6].write_partial_as_json(handler);
                else
                    storeHoursToday[num6].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOpenNow)
          {
            handler.start_pair("OpenNow");
            handler.boolean_value(storeOpenNow);
          }
        if (flagHasMinutesToOpen)
          {
            handler.start_pair("MinutesToOpen");
            handler.number_value(storeMinutesToOpen);
          }
        if (flagHasMinutesToClose)
          {
            handler.start_pair("MinutesToClose");
            handler.number_value(storeMinutesToClose);
          }
        if (flagHasOpen24Hours)
          {
            handler.start_pair("Open24Hours");
            handler.boolean_value(storeOpen24Hours);
          }
        if (flagHasAttributes)
          {
            handler.start_pair("Attributes");
            if (partial_allowed)
                storeAttributes.write_partial_as_json(handler);
            else
                storeAttributes.write_as_json(handler);
          }
        if (flagHasAttributesForDisplay)
          {
            handler.start_pair("AttributesForDisplay");
            handler.start_array();
            for (int num7 = 0; num7 < storeAttributesForDisplay.Count; ++num7)
              {
                if (partial_allowed)
                    storeAttributesForDisplay[num7].write_partial_as_json(handler);
                else
                    storeAttributesForDisplay[num7].write_as_json(handler);
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
        return null;
      }

    public static new LocalResultAnnotatedMapLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalResultAnnotatedMapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultAnnotatedMapLocation", ignore_extras);
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
    public static new LocalResultAnnotatedMapLocationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalResultAnnotatedMapLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalResultAnnotatedMapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultAnnotatedMapLocation", ignore_extras);
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
    public static new LocalResultAnnotatedMapLocationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new LocalResultAnnotatedMapLocationJSON from_text(string text, bool ignore_extras)
      {
        LocalResultAnnotatedMapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultAnnotatedMapLocation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalResultAnnotatedMapLocationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new LocalResultAnnotatedMapLocationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalResultAnnotatedMapLocationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultAnnotatedMapLocation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : AnnotatedMapLocationJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorAlias;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private JSONHoldingNumberTextGenerator fieldGeneratorRating;
    private class FieldHoldingGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorReviewCount fieldGeneratorReviewCount;
    private class FieldHoldingGeneratorPrice : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorPrice(String what) : base(what, 0, 5)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPrice : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPrice(String what) : base(what, 0, 5)
              {
              }
          };
        private FieldHoldingGeneratorPrice fieldGeneratorPrice;
        private TypePhoneJSON.HoldingArrayGenerator fieldGeneratorPhone;
        private TypeLinksJSON.HoldingArrayGenerator fieldGeneratorLinks;
        private JSONHoldingStringGenerator fieldGeneratorYelpURL;
        private JSONHoldingStringGenerator fieldGeneratorEmail;
        private TypePhotosJSON.HoldingArrayGenerator fieldGeneratorPhotos;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRestaurant;
        private JSONHoldingBooleanGenerator fieldGeneratorPermanentlyClosed;
        private JSONHoldingBooleanGenerator fieldGeneratorIsClaimed;
        private TypeCategoriesJSON.HoldingArrayGenerator fieldGeneratorCategories;
        private TypeDistanceFromReferenceJSON.HoldingGenerator fieldGeneratorDistanceFromReference;
        private TypeDistanceFromUserJSON.HoldingGenerator fieldGeneratorDistanceFromUser;
        private JSONHoldingNumberTextGenerator fieldGeneratorBearingFromUser;
        private TypeReviewsJSON.HoldingArrayGenerator fieldGeneratorReviews;
        private TypeHoursJSON.HoldingGenerator fieldGeneratorHours;
        private LocalResultBusinessHoursJSON.HoldingArrayGenerator fieldGeneratorHoursToday;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenNow;
    private class FieldHoldingGeneratorMinutesToOpen : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMinutesToOpen(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinutesToOpen : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinutesToOpen(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMinutesToOpen fieldGeneratorMinutesToOpen;
    private class FieldHoldingGeneratorMinutesToClose : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMinutesToClose(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinutesToClose : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinutesToClose(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMinutesToClose fieldGeneratorMinutesToClose;
        private JSONHoldingBooleanGenerator fieldGeneratorOpen24Hours;
        private TypeAttributesJSON.HoldingGenerator fieldGeneratorAttributes;
        private TypeAttributesForDisplayJSON.HoldingArrayGenerator fieldGeneratorAttributesForDisplay;
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
            if (!(getAnnotatedMapLocationJSONKey().Equals("YelpLocation")))
                throw new Exception("The key field has a value other than `YelpLocation'.");
            LocalResultAnnotatedMapLocationJSON result = new LocalResultAnnotatedMapLocationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalResultAnnotatedMapLocationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(AnnotatedMapLocationJSON new_result)
          {
            handle_result((LocalResultAnnotatedMapLocationJSON )new_result);
          }
        protected void finish(LocalResultAnnotatedMapLocationJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            if (fieldGeneratorAlias.have_value)
              {
                result.setAlias(fieldGeneratorAlias.value);
                fieldGeneratorAlias.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorRating.have_value)
              {
                result.setRatingText(fieldGeneratorRating.value);
                fieldGeneratorRating.have_value = false;
              }
            if (fieldGeneratorReviewCount.have_value)
              {
                result.setReviewCount(fieldGeneratorReviewCount.value);
                fieldGeneratorReviewCount.have_value = false;
              }
            if (fieldGeneratorPrice.have_value)
              {
                result.setPrice((sbyte)(fieldGeneratorPrice.value));
                fieldGeneratorPrice.have_value = false;
              }
            if (fieldGeneratorPhone.have_value)
              {
                result.initPhone();
                int count = fieldGeneratorPhone.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPhone(fieldGeneratorPhone.value[num]);
                  }
                fieldGeneratorPhone.value.Clear();
                fieldGeneratorPhone.have_value = false;
              }
            if (fieldGeneratorLinks.have_value)
              {
                result.initLinks();
                int count = fieldGeneratorLinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLinks(fieldGeneratorLinks.value[num]);
                  }
                fieldGeneratorLinks.value.Clear();
                fieldGeneratorLinks.have_value = false;
              }
            if (fieldGeneratorYelpURL.have_value)
              {
                result.setYelpURL(fieldGeneratorYelpURL.value);
                fieldGeneratorYelpURL.have_value = false;
              }
            if (fieldGeneratorEmail.have_value)
              {
                result.setEmail(fieldGeneratorEmail.value);
                fieldGeneratorEmail.have_value = false;
              }
            if (fieldGeneratorPhotos.have_value)
              {
                result.initPhotos();
                int count = fieldGeneratorPhotos.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPhotos(fieldGeneratorPhotos.value[num]);
                  }
                fieldGeneratorPhotos.value.Clear();
                fieldGeneratorPhotos.have_value = false;
              }
            if (fieldGeneratorIsRestaurant.have_value)
              {
                result.setIsRestaurant(fieldGeneratorIsRestaurant.value);
                fieldGeneratorIsRestaurant.have_value = false;
              }
            if (fieldGeneratorPermanentlyClosed.have_value)
              {
                result.setPermanentlyClosed(fieldGeneratorPermanentlyClosed.value);
                fieldGeneratorPermanentlyClosed.have_value = false;
              }
            if (fieldGeneratorIsClaimed.have_value)
              {
                result.setIsClaimed(fieldGeneratorIsClaimed.value);
                fieldGeneratorIsClaimed.have_value = false;
              }
            if (fieldGeneratorCategories.have_value)
              {
                result.initCategories();
                int count = fieldGeneratorCategories.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategories(fieldGeneratorCategories.value[num]);
                  }
                fieldGeneratorCategories.value.Clear();
                fieldGeneratorCategories.have_value = false;
              }
            if (fieldGeneratorDistanceFromReference.have_value)
              {
                result.setDistanceFromReference(fieldGeneratorDistanceFromReference.value);
                fieldGeneratorDistanceFromReference.have_value = false;
              }
            if (fieldGeneratorDistanceFromUser.have_value)
              {
                result.setDistanceFromUser(fieldGeneratorDistanceFromUser.value);
                fieldGeneratorDistanceFromUser.have_value = false;
              }
            if (fieldGeneratorBearingFromUser.have_value)
              {
                result.setBearingFromUserText(fieldGeneratorBearingFromUser.value);
                fieldGeneratorBearingFromUser.have_value = false;
              }
            if (fieldGeneratorReviews.have_value)
              {
                result.initReviews();
                int count = fieldGeneratorReviews.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendReviews(fieldGeneratorReviews.value[num]);
                  }
                fieldGeneratorReviews.value.Clear();
                fieldGeneratorReviews.have_value = false;
              }
            if (fieldGeneratorHours.have_value)
              {
                result.setHours(fieldGeneratorHours.value);
                fieldGeneratorHours.have_value = false;
              }
            if (fieldGeneratorHoursToday.have_value)
              {
                result.initHoursToday();
                int count = fieldGeneratorHoursToday.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHoursToday(fieldGeneratorHoursToday.value[num]);
                  }
                fieldGeneratorHoursToday.value.Clear();
                fieldGeneratorHoursToday.have_value = false;
              }
            if (fieldGeneratorOpenNow.have_value)
              {
                result.setOpenNow(fieldGeneratorOpenNow.value);
                fieldGeneratorOpenNow.have_value = false;
              }
            if (fieldGeneratorMinutesToOpen.have_value)
              {
                result.setMinutesToOpen(fieldGeneratorMinutesToOpen.value);
                fieldGeneratorMinutesToOpen.have_value = false;
              }
            if (fieldGeneratorMinutesToClose.have_value)
              {
                result.setMinutesToClose(fieldGeneratorMinutesToClose.value);
                fieldGeneratorMinutesToClose.have_value = false;
              }
            if (fieldGeneratorOpen24Hours.have_value)
              {
                result.setOpen24Hours(fieldGeneratorOpen24Hours.value);
                fieldGeneratorOpen24Hours.have_value = false;
              }
            if (fieldGeneratorAttributes.have_value)
              {
                result.setAttributes(fieldGeneratorAttributes.value);
                fieldGeneratorAttributes.have_value = false;
              }
            if (fieldGeneratorAttributesForDisplay.have_value)
              {
                result.initAttributesForDisplay();
                int count = fieldGeneratorAttributesForDisplay.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttributesForDisplay(fieldGeneratorAttributesForDisplay.value[num]);
                  }
                fieldGeneratorAttributesForDisplay.value.Clear();
                fieldGeneratorAttributesForDisplay.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(LocalResultAnnotatedMapLocationJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "ias", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorAlias;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "tributes", 0, 8, false) == 0)
                              {
                                if (field_name.Length == 10)
                                  {
                                    return fieldGeneratorAttributes;
                                  }
                                switch (field_name[10])
                                  {
                                    case 'F':
                                        if ((String.Compare(field_name, 11, "orDisplay", 0, 9, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorAttributesForDisplay;
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
                case 'B':
                    if ((String.Compare(field_name, 1, "earingFromUser", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorBearingFromUser;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ategories", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCategories;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "istanceFrom", 0, 11, false) == 0)
                      {
                        switch (field_name[12])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 13, "eference", 0, 8, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorDistanceFromReference;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 13, "ser", 0, 3, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorDistanceFromUser;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEmail;
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "ours", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorHours;
                          }
                        switch (field_name[5])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 6, "oday", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorHoursToday;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'D':
                            if (field_name.Length == 2)
                                return fieldGeneratorID;
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 3, "laimed", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorIsClaimed;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 3, "estaurant", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorIsRestaurant;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "inks", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLinks;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "inutesTo", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 10, "lose", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorMinutesToClose;
                                break;
                            case 'O':
                                if ((String.Compare(field_name, 10, "pen", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorMinutesToOpen;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "pen", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case '2':
                                if ((String.Compare(field_name, 5, "4Hours", 0, 6, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorOpen24Hours;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 5, "ow", 0, 2, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorOpenNow;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "rmanentlyClosed", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPermanentlyClosed;
                            break;
                        case 'h':
                            if (String.Compare(field_name, 2, "o", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'n':
                                        if ((String.Compare(field_name, 4, "e", 0, 1, false) == 0) && (field_name.Length == 5))
                                            return fieldGeneratorPhone;
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 4, "os", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorPhotos;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ice", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorPrice;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ting", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorRating;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "view", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorReviewCount;
                                        break;
                                    case 's':
                                        if (field_name.Length == 7)
                                            return fieldGeneratorReviews;
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
                case 'Y':
                    if ((String.Compare(field_name, 1, "elpURL", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorYelpURL;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPrice = new FieldHoldingGeneratorPrice("field \"Price\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPhone = new TypePhoneJSON.HoldingArrayGenerator("field \"Phone\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorLinks = new TypeLinksJSON.HoldingArrayGenerator("field \"Links\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorYelpURL = new JSONHoldingStringGenerator("field \"YelpURL\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPhotos = new TypePhotosJSON.HoldingArrayGenerator("field \"Photos\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorIsRestaurant = new JSONHoldingBooleanGenerator("field \"IsRestaurant\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPermanentlyClosed = new JSONHoldingBooleanGenerator("field \"PermanentlyClosed\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorIsClaimed = new JSONHoldingBooleanGenerator("field \"IsClaimed\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorCategories = new TypeCategoriesJSON.HoldingArrayGenerator("field \"Categories\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorDistanceFromReference = new TypeDistanceFromReferenceJSON.HoldingGenerator("field \"DistanceFromReference\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorDistanceFromUser = new TypeDistanceFromUserJSON.HoldingGenerator("field \"DistanceFromUser\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorBearingFromUser = new JSONHoldingNumberTextGenerator("field \"BearingFromUser\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorReviews = new TypeReviewsJSON.HoldingArrayGenerator("field \"Reviews\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorHours = new TypeHoursJSON.HoldingGenerator("field \"Hours\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorHoursToday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"HoursToday\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorOpenNow = new JSONHoldingBooleanGenerator("field \"OpenNow\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorMinutesToOpen = new FieldHoldingGeneratorMinutesToOpen("field \"MinutesToOpen\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorMinutesToClose = new FieldHoldingGeneratorMinutesToClose("field \"MinutesToClose\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorOpen24Hours = new JSONHoldingBooleanGenerator("field \"Open24Hours\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorAttributes = new TypeAttributesJSON.HoldingGenerator("field \"Attributes\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            fieldGeneratorAttributesForDisplay = new TypeAttributesForDisplayJSON.HoldingArrayGenerator("field \"AttributesForDisplay\" of the LocalResultAnnotatedMapLocation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalResultAnnotatedMapLocation class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorAlias = new JSONHoldingStringGenerator("field \"Alias\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPrice = new FieldHoldingGeneratorPrice("field \"Price\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPhone = new TypePhoneJSON.HoldingArrayGenerator("field \"Phone\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorLinks = new TypeLinksJSON.HoldingArrayGenerator("field \"Links\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorYelpURL = new JSONHoldingStringGenerator("field \"YelpURL\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorEmail = new JSONHoldingStringGenerator("field \"Email\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPhotos = new TypePhotosJSON.HoldingArrayGenerator("field \"Photos\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorIsRestaurant = new JSONHoldingBooleanGenerator("field \"IsRestaurant\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorPermanentlyClosed = new JSONHoldingBooleanGenerator("field \"PermanentlyClosed\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorIsClaimed = new JSONHoldingBooleanGenerator("field \"IsClaimed\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorCategories = new TypeCategoriesJSON.HoldingArrayGenerator("field \"Categories\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorDistanceFromReference = new TypeDistanceFromReferenceJSON.HoldingGenerator("field \"DistanceFromReference\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorDistanceFromUser = new TypeDistanceFromUserJSON.HoldingGenerator("field \"DistanceFromUser\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorBearingFromUser = new JSONHoldingNumberTextGenerator("field \"BearingFromUser\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorReviews = new TypeReviewsJSON.HoldingArrayGenerator("field \"Reviews\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorHours = new TypeHoursJSON.HoldingGenerator("field \"Hours\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorHoursToday = new LocalResultBusinessHoursJSON.HoldingArrayGenerator("field \"HoursToday\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorOpenNow = new JSONHoldingBooleanGenerator("field \"OpenNow\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorMinutesToOpen = new FieldHoldingGeneratorMinutesToOpen("field \"MinutesToOpen\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorMinutesToClose = new FieldHoldingGeneratorMinutesToClose("field \"MinutesToClose\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorOpen24Hours = new JSONHoldingBooleanGenerator("field \"Open24Hours\" of the LocalResultAnnotatedMapLocation class");
            fieldGeneratorAttributes = new TypeAttributesJSON.HoldingGenerator("field \"Attributes\" of the LocalResultAnnotatedMapLocation class", false);
            fieldGeneratorAttributesForDisplay = new TypeAttributesForDisplayJSON.HoldingArrayGenerator("field \"AttributesForDisplay\" of the LocalResultAnnotatedMapLocation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalResultAnnotatedMapLocation class");
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorAlias.reset();
            fieldGeneratorID.reset();
            fieldGeneratorRating.reset();
            fieldGeneratorReviewCount.reset();
            fieldGeneratorPrice.reset();
            fieldGeneratorPhone.reset();
            fieldGeneratorLinks.reset();
            fieldGeneratorYelpURL.reset();
            fieldGeneratorEmail.reset();
            fieldGeneratorPhotos.reset();
            fieldGeneratorIsRestaurant.reset();
            fieldGeneratorPermanentlyClosed.reset();
            fieldGeneratorIsClaimed.reset();
            fieldGeneratorCategories.reset();
            fieldGeneratorDistanceFromReference.reset();
            fieldGeneratorDistanceFromUser.reset();
            fieldGeneratorBearingFromUser.reset();
            fieldGeneratorReviews.reset();
            fieldGeneratorHours.reset();
            fieldGeneratorHoursToday.reset();
            fieldGeneratorOpenNow.reset();
            fieldGeneratorMinutesToOpen.reset();
            fieldGeneratorMinutesToClose.reset();
            fieldGeneratorOpen24Hours.reset();
            fieldGeneratorAttributes.reset();
            fieldGeneratorAttributesForDisplay.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalResultAnnotatedMapLocationJSON  result)
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
        public LocalResultAnnotatedMapLocationJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalResultAnnotatedMapLocationJSON  result)
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
    protected virtual void handle_result(List<LocalResultAnnotatedMapLocationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalResultAnnotatedMapLocationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalResultAnnotatedMapLocationJSON>();
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
    public List<LocalResultAnnotatedMapLocationJSON> value;
  };
  };
