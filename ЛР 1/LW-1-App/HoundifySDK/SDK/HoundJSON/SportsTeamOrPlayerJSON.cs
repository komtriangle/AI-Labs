/* file "SportsTeamOrPlayerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsTeamOrPlayerJSON : JSONBase
  {
    public struct TypeValue
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public SportsTeamNewJSON  choice0;
            [FieldOffset(0)]
            public SportsPlayerJSON  choice1;
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
                SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
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
                SportsPlayerJSON convert_classy = SportsPlayerJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Value of SportsTeamOrPlayerJSON is not one of the allowed values.");
        setValue(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public SportsTeamOrPlayerJSON()
      {
        flagHasValue = false;
      }

    public SportsTeamOrPlayerJSON(TypeValue init_value)
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
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static SportsTeamOrPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamOrPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamOrPlayer", ignore_extras);
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
    public static SportsTeamOrPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamOrPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsTeamOrPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamOrPlayer", ignore_extras);
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
    public static SportsTeamOrPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsTeamOrPlayerJSON from_text(string text, bool ignore_extras)
      {
        SportsTeamOrPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamOrPlayer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsTeamOrPlayerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsTeamOrPlayerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsTeamOrPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsTeamOrPlayer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONParallelGenerator
      {
        private SportsTeamNewJSON.HoldingGenerator field0;
        private SportsPlayerJSON.HoldingGenerator field1;
        private JSONHandler [] all_handlers = new JSONHandler [2];
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
                field0 = new SportsTeamNewJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new SportsPlayerJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
          }
        public FieldGeneratorValue(string what, bool ignore_extras)
          {
                field0 = new SportsTeamNewJSON.HoldingGenerator("option 0 of field \"Value\"", ignore_extras);
                field1 = new SportsPlayerJSON.HoldingGenerator("option 1 of field \"Value\"", ignore_extras);
            all_handlers[0] = field0;
            all_handlers[1] = field1;
          }

        public override void reset()
          {
            field0.reset();
            field1.reset();
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
            SportsTeamOrPlayerJSON result = new SportsTeamOrPlayerJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsTeamOrPlayerJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsTeamOrPlayer", ignore_extras)
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
        protected override void handle_result(SportsTeamOrPlayerJSON  result)
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
        public SportsTeamOrPlayerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsTeamOrPlayerJSON  result)
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
    protected virtual void handle_result(List<SportsTeamOrPlayerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsTeamOrPlayerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsTeamOrPlayerJSON>();
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
    public List<SportsTeamOrPlayerJSON> value;
  };
  };
