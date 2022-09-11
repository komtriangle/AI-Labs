/* file "FetchEnable.cs" */

/* Copyright 2012-2016 SoundHound, Incorporated.  All rights reserved. */


public class FetchEnable
  {
    private static bool disabled = false;
    private static string disable_reason = null;

    public static void disable_fetches(string reason)
      {
        disable_reason = reason;
        disabled = true;
      }

    public static void enable_fetches()
      {
        disabled = false;
      }

    public static bool fetches_are_enabled()
      {
        return !disabled;
      }

    public static string fetch_disable_reason()
      {
        return disable_reason;
      }
  };
