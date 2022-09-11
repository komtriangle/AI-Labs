/* file "JSONValue.cs" */

/* Copyright 2012-2018 SoundHound, Incorporated.  All rights reserved. */

using System.IO;


public abstract class JSONValue
  {
    public enum Kind
      {
        JVK_STRING,
        JVK_INTEGER,
        JVK_RATIONAL,
        JVK_TRUE,
        JVK_FALSE,
        JVK_NULL,
        JVK_OBJECT,
        JVK_ARRAY
      };

    protected JSONValue()  { }

    public abstract Kind kind();
    public abstract void write(JSONHandler handler);
    public virtual JSONStringValue string_value()  { return null; }
    public virtual JSONIntegerValue integer_value()  { return null; }
    public virtual JSONRationalValue rational_value()  { return null; }
    public virtual JSONTrueValue true_value()  { return null; }
    public virtual JSONFalseValue false_value()  { return null; }
    public virtual JSONNullValue null_value()  { return null; }
    public virtual JSONObjectValue object_value()  { return null; }
    public virtual JSONArrayValue array_value()  { return null; }

    public static JSONValue parse_json_value(JSONTextSource source)
      {
        JSONValueHandler my_handler = new JSONValueHandler();
        JSONParse.parse_json_value(source, my_handler);
        return my_handler.getResult();
      }

    public static JSONValue parse_json_value(TextReader input, string file_name)
      {
        JSONValueHandler my_handler = new JSONValueHandler();
        JSONParse.parse_json_value(input, file_name, my_handler);
        return my_handler.getResult();
      }

    public static JSONValue parse_json_value(string text, string file_name)
      {
        JSONValueHandler my_handler = new JSONValueHandler();
        JSONParse.parse_json_value(text, file_name, my_handler);
        return my_handler.getResult();
      }
  }
