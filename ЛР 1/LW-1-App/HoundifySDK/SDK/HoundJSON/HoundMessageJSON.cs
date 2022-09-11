/* file "HoundMessageJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HoundMessageJSON : JSONBase
  {
    public struct TypeValue
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public HoundServerJSON  choice0;
            [FieldOffset(0)]
            public HoundPartialTranscriptJSON  choice1;
            [FieldOffset(0)]
            public HoundUpdateJSON  choice2;
          };
        public Utype u;
      };
    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeValue or_result = new TypeValue();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                HoundServerJSON convert_classy = HoundServerJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                HoundPartialTranscriptJSON convert_classy = HoundPartialTranscriptJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                HoundUpdateJSON convert_classy = HoundUpdateJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice2 = convert_classy;
                or_result.key = 2;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Value of HoundMessageJSON is not one of the allowed values.");
        setValue(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public HoundMessageJSON()
      {
        flagHasValue = false;
      }

    public HoundMessageJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void setValue(TypeValue new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasValue)
          {
            switch (storeValue.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasValue = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeValue = new_value;
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            switch (storeValue.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue.key)
          {
            case 0:
                storeValue.u.choice0.write_as_json(handler);
                break;
            case 1:
                storeValue.u.choice1.write_as_json(handler);
                break;
            case 2:
                storeValue.u.choice2.write_as_json(handler);
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue.key)
          {
            case 0:
                storeValue.u.choice0.write_partial_as_json(handler);
                break;
            case 1:
                storeValue.u.choice1.write_partial_as_json(handler);
                break;
            case 2:
                storeValue.u.choice2.write_partial_as_json(handler);
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static HoundMessageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundMessageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundMessage", ignore_extras);
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
    public static HoundMessageJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundMessageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundMessageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundMessage", ignore_extras);
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
    public static HoundMessageJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundMessageJSON from_text(string text, bool ignore_extras)
      {
        HoundMessageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundMessage", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundMessageJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundMessageJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundMessageJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundMessage", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONParallelGenerator
      {
        private HoundServerJSON.HoldingGenerator field0;
        private HoundPartialTranscriptJSON.HoldingGenerator field1;
        private HoundUpdateJSON.HoldingGenerator field2;
        private JSONHandler [] all_handlers = new JSONHandler [3];
        protected override JSONHandler[] start()
          {
            return all_handlers;
          }
        protected override void finish(int winning_index)
          {
            TypeValue result = new TypeValue();
            result.key = winning_index;
            switch (winning_index)
              {
                case 0:
                  {
                    Debug.Assert(field0.have_value);
                    result.u.choice0 = field0.value;
                    break;
                  }
                case 1:
                  {
                    Debug.Assert(field1.have_value);
                    result.u.choice1 = field1.value;
                    break;
                  }
                case 2:
                  {
                    Debug.Assert(field2.have_value);
                    result.u.choice2 = field2.value;
                    break;
                  }
                default:
                  {
                    Debug.Assert(false);
                    break;
                  }
              }
            handle_result(result);
          }
        protected abstract void handle_result(TypeValue result);
        public FieldGeneratorValue(bool ignore_extras)
          {
                field0 = new HoundServerJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new HoundPartialTranscriptJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
                field2 = new HoundUpdateJSON.HoldingGenerator("option 2 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
            all_handlers[2] = field2;
          }
        public FieldGeneratorValue(string what, bool ignore_extras)
          {
                field0 = new HoundServerJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new HoundPartialTranscriptJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
                field2 = new HoundUpdateJSON.HoldingGenerator("option 2 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
            all_handlers[2] = field2;
          }

        public override void reset()
          {
            field0.reset();
            field1.reset();
            field2.reset();
            base.reset();
          }
      };
    public class HolderValue
      {
        private bool have_data;
        private TypeValue data;
        public HolderValue()  { have_data = false; }
        public HolderValue(TypeValue init_data)
          {
            have_data = true;
            data = init_data;
            if (have_data)
              {
              }
          }
        public HolderValue(HolderValue other)
          {
            have_data = other.haveData();
            data = other.referenced();
            if (have_data)
              {
              }
          }

        public bool haveData()
          {
            return have_data;
          }
        public TypeValue referenced()
          {
            return data;
          }
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = new HolderValue(result);
          }

        public FieldHoldingGeneratorValue(String what, bool ignore_extras) : base(ignore_extras)
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
        public HolderValue value;
      };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            HoundMessageJSON result = new HoundMessageJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(HoundMessageJSON new_result);
        public Generator(bool ignore_extras) : base("Type HoundMessage", ignore_extras)
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundMessageJSON  result)
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
        public HoundMessageJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundMessageJSON  result)
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
    protected virtual void handle_result(List<HoundMessageJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundMessageJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundMessageJSON>();
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
    public List<HoundMessageJSON> value;
  };
  };
