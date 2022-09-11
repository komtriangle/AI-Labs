/* file "CoreUnitsPropertyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CoreUnitsPropertyJSON : PropertyJSON
  {
    public enum TypeTagKnownValues
      {
        Tag_distance,
        Tag_position,
        Tag_area,
        Tag_volume,
        Tag_duration,
        Tag_time,
        Tag_angle,
        Tag_solid_angle,
        Tag_orientation,
        Tag_mass,
        Tag_weight,
        Tag_energy,
        Tag_power,
        Tag_electric_charge,
        Tag_electric_potential_difference,
        Tag_capacitance,
        Tag_electric_resistance,
        Tag_electric_conductance,
        Tag_inductance,
        Tag_magnetic_flux,
        Tag_magnetic_flux_density,
        Tag_current,
        Tag_temperature,
        Tag_count,
        Tag_luminosity,
        Tag_luminous_flux,
        Tag_illuminance,
        Tag_frequency,
        Tag_force,
        Tag_pressure,
        Tag_absorbed_dose,
        Tag_catalytic_activity,
        Tag_width,
        Tag_height,
        Tag_depth,
        Tag__none
      };
    public struct TypeTag
      {
        public bool in_known_list;
        public string string_value;
        public TypeTagKnownValues list_value;
      };

    public static TypeTagKnownValues  stringToTag(string chars)
      {
        switch (chars[0])
          {
            case 'a':
                switch (chars[1])
                  {
                    case 'b':
                        if ((String.Compare(chars, 2, "sorbed_dose", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeTagKnownValues.Tag_absorbed_dose;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "gle", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagKnownValues.Tag_angle;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ea", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeTagKnownValues.Tag_area;
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'p':
                                if ((String.Compare(chars, 3, "acitance", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeTagKnownValues.Tag_capacitance;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "alytic_activity", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeTagKnownValues.Tag_catalytic_activity;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "unt", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagKnownValues.Tag_count;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rrent", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeTagKnownValues.Tag_current;
                        break;
                    default:
                        break;
                  }
                break;
            case 'd':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "pth", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagKnownValues.Tag_depth;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "stance", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeTagKnownValues.Tag_distance;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "ration", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeTagKnownValues.Tag_duration;
                        break;
                    default:
                        break;
                  }
                break;
            case 'e':
                switch (chars[1])
                  {
                    case 'l':
                        if (String.Compare(chars, 2, "ectric_", 0, 7, false) == 0)
                          {
                            switch (chars[9])
                              {
                                case 'c':
                                    switch (chars[10])
                                      {
                                        case 'h':
                                            if ((String.Compare(chars, 11, "arge", 0, 4, false) == 0) && (chars.Length == 15))
                                                return TypeTagKnownValues.Tag_electric_charge;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 11, "nductance", 0, 9, false) == 0) && (chars.Length == 20))
                                                return TypeTagKnownValues.Tag_electric_conductance;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'p':
                                    if ((String.Compare(chars, 10, "otential_difference", 0, 19, false) == 0) && (chars.Length == 29))
                                        return TypeTagKnownValues.Tag_electric_potential_difference;
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 10, "esistance", 0, 9, false) == 0) && (chars.Length == 19))
                                        return TypeTagKnownValues.Tag_electric_resistance;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ergy", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTagKnownValues.Tag_energy;
                        break;
                    default:
                        break;
                  }
                break;
            case 'f':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "rce", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagKnownValues.Tag_force;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "equency", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeTagKnownValues.Tag_frequency;
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(chars, 1, "eight", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeTagKnownValues.Tag_height;
                break;
            case 'i':
                switch (chars[1])
                  {
                    case 'l':
                        if ((String.Compare(chars, 2, "luminance", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeTagKnownValues.Tag_illuminance;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ductance", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeTagKnownValues.Tag_inductance;
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                if (String.Compare(chars, 1, "umino", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 's':
                            if ((String.Compare(chars, 7, "ity", 0, 3, false) == 0) && (chars.Length == 10))
                                return TypeTagKnownValues.Tag_luminosity;
                            break;
                        case 'u':
                            if ((String.Compare(chars, 7, "s_flux", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeTagKnownValues.Tag_luminous_flux;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'm':
                if (String.Compare(chars, 1, "a", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'g':
                            if (String.Compare(chars, 3, "netic_flux", 0, 10, false) == 0)
                              {
                                if (chars.Length == 13)
                                  {
                                    return TypeTagKnownValues.Tag_magnetic_flux;
                                  }
                                switch (chars[13])
                                  {
                                    case '_':
                                        if ((String.Compare(chars, 14, "density", 0, 7, false) == 0) && (chars.Length == 21))
                                            return TypeTagKnownValues.Tag_magnetic_flux_density;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(chars, 3, "s", 0, 1, false) == 0) && (chars.Length == 4))
                                return TypeTagKnownValues.Tag_mass;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if ((String.Compare(chars, 1, "rientation", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeTagKnownValues.Tag_orientation;
                break;
            case 'p':
                switch (chars[1])
                  {
                    case 'o':
                        switch (chars[2])
                          {
                            case 's':
                                if ((String.Compare(chars, 3, "ition", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeTagKnownValues.Tag_position;
                                break;
                            case 'w':
                                if ((String.Compare(chars, 3, "er", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeTagKnownValues.Tag_power;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "essure", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeTagKnownValues.Tag_pressure;
                        break;
                    default:
                        break;
                  }
                break;
            case 's':
                if ((String.Compare(chars, 1, "olid_angle", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeTagKnownValues.Tag_solid_angle;
                break;
            case 't':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "mperature", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeTagKnownValues.Tag_temperature;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "me", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeTagKnownValues.Tag_time;
                        break;
                    default:
                        break;
                  }
                break;
            case 'v':
                if ((String.Compare(chars, 1, "olume", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeTagKnownValues.Tag_volume;
                break;
            case 'w':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "ight", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeTagKnownValues.Tag_weight;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "dth", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeTagKnownValues.Tag_width;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeTagKnownValues.Tag__none;
      }

    public static string  stringFromTag(TypeTagKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTagKnownValues.Tag_distance:
                return "distance";
            case TypeTagKnownValues.Tag_position:
                return "position";
            case TypeTagKnownValues.Tag_area:
                return "area";
            case TypeTagKnownValues.Tag_volume:
                return "volume";
            case TypeTagKnownValues.Tag_duration:
                return "duration";
            case TypeTagKnownValues.Tag_time:
                return "time";
            case TypeTagKnownValues.Tag_angle:
                return "angle";
            case TypeTagKnownValues.Tag_solid_angle:
                return "solid_angle";
            case TypeTagKnownValues.Tag_orientation:
                return "orientation";
            case TypeTagKnownValues.Tag_mass:
                return "mass";
            case TypeTagKnownValues.Tag_weight:
                return "weight";
            case TypeTagKnownValues.Tag_energy:
                return "energy";
            case TypeTagKnownValues.Tag_power:
                return "power";
            case TypeTagKnownValues.Tag_electric_charge:
                return "electric_charge";
            case TypeTagKnownValues.Tag_electric_potential_difference:
                return "electric_potential_difference";
            case TypeTagKnownValues.Tag_capacitance:
                return "capacitance";
            case TypeTagKnownValues.Tag_electric_resistance:
                return "electric_resistance";
            case TypeTagKnownValues.Tag_electric_conductance:
                return "electric_conductance";
            case TypeTagKnownValues.Tag_inductance:
                return "inductance";
            case TypeTagKnownValues.Tag_magnetic_flux:
                return "magnetic_flux";
            case TypeTagKnownValues.Tag_magnetic_flux_density:
                return "magnetic_flux_density";
            case TypeTagKnownValues.Tag_current:
                return "current";
            case TypeTagKnownValues.Tag_temperature:
                return "temperature";
            case TypeTagKnownValues.Tag_count:
                return "count";
            case TypeTagKnownValues.Tag_luminosity:
                return "luminosity";
            case TypeTagKnownValues.Tag_luminous_flux:
                return "luminous_flux";
            case TypeTagKnownValues.Tag_illuminance:
                return "illuminance";
            case TypeTagKnownValues.Tag_frequency:
                return "frequency";
            case TypeTagKnownValues.Tag_force:
                return "force";
            case TypeTagKnownValues.Tag_pressure:
                return "pressure";
            case TypeTagKnownValues.Tag_absorbed_dose:
                return "absorbed_dose";
            case TypeTagKnownValues.Tag_catalytic_activity:
                return "catalytic_activity";
            case TypeTagKnownValues.Tag_width:
                return "width";
            case TypeTagKnownValues.Tag_height:
                return "height";
            case TypeTagKnownValues.Tag_depth:
                return "depth";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTag;
    private TypeTag storeTag;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTagToJSON()
      {
        JSONStringValue generated_string_Tag;
        if (!(storeTag.in_known_list))
          {
        generated_string_Tag = new JSONStringValue(storeTag.string_value);
          }
        else
          {
        switch (storeTag.list_value)
          {
            case TypeTagKnownValues.Tag_distance:
                generated_string_Tag = new JSONStringValue("distance");
                break;
            case TypeTagKnownValues.Tag_position:
                generated_string_Tag = new JSONStringValue("position");
                break;
            case TypeTagKnownValues.Tag_area:
                generated_string_Tag = new JSONStringValue("area");
                break;
            case TypeTagKnownValues.Tag_volume:
                generated_string_Tag = new JSONStringValue("volume");
                break;
            case TypeTagKnownValues.Tag_duration:
                generated_string_Tag = new JSONStringValue("duration");
                break;
            case TypeTagKnownValues.Tag_time:
                generated_string_Tag = new JSONStringValue("time");
                break;
            case TypeTagKnownValues.Tag_angle:
                generated_string_Tag = new JSONStringValue("angle");
                break;
            case TypeTagKnownValues.Tag_solid_angle:
                generated_string_Tag = new JSONStringValue("solid_angle");
                break;
            case TypeTagKnownValues.Tag_orientation:
                generated_string_Tag = new JSONStringValue("orientation");
                break;
            case TypeTagKnownValues.Tag_mass:
                generated_string_Tag = new JSONStringValue("mass");
                break;
            case TypeTagKnownValues.Tag_weight:
                generated_string_Tag = new JSONStringValue("weight");
                break;
            case TypeTagKnownValues.Tag_energy:
                generated_string_Tag = new JSONStringValue("energy");
                break;
            case TypeTagKnownValues.Tag_power:
                generated_string_Tag = new JSONStringValue("power");
                break;
            case TypeTagKnownValues.Tag_electric_charge:
                generated_string_Tag = new JSONStringValue("electric_charge");
                break;
            case TypeTagKnownValues.Tag_electric_potential_difference:
                generated_string_Tag = new JSONStringValue("electric_potential_difference");
                break;
            case TypeTagKnownValues.Tag_capacitance:
                generated_string_Tag = new JSONStringValue("capacitance");
                break;
            case TypeTagKnownValues.Tag_electric_resistance:
                generated_string_Tag = new JSONStringValue("electric_resistance");
                break;
            case TypeTagKnownValues.Tag_electric_conductance:
                generated_string_Tag = new JSONStringValue("electric_conductance");
                break;
            case TypeTagKnownValues.Tag_inductance:
                generated_string_Tag = new JSONStringValue("inductance");
                break;
            case TypeTagKnownValues.Tag_magnetic_flux:
                generated_string_Tag = new JSONStringValue("magnetic_flux");
                break;
            case TypeTagKnownValues.Tag_magnetic_flux_density:
                generated_string_Tag = new JSONStringValue("magnetic_flux_density");
                break;
            case TypeTagKnownValues.Tag_current:
                generated_string_Tag = new JSONStringValue("current");
                break;
            case TypeTagKnownValues.Tag_temperature:
                generated_string_Tag = new JSONStringValue("temperature");
                break;
            case TypeTagKnownValues.Tag_count:
                generated_string_Tag = new JSONStringValue("count");
                break;
            case TypeTagKnownValues.Tag_luminosity:
                generated_string_Tag = new JSONStringValue("luminosity");
                break;
            case TypeTagKnownValues.Tag_luminous_flux:
                generated_string_Tag = new JSONStringValue("luminous_flux");
                break;
            case TypeTagKnownValues.Tag_illuminance:
                generated_string_Tag = new JSONStringValue("illuminance");
                break;
            case TypeTagKnownValues.Tag_frequency:
                generated_string_Tag = new JSONStringValue("frequency");
                break;
            case TypeTagKnownValues.Tag_force:
                generated_string_Tag = new JSONStringValue("force");
                break;
            case TypeTagKnownValues.Tag_pressure:
                generated_string_Tag = new JSONStringValue("pressure");
                break;
            case TypeTagKnownValues.Tag_absorbed_dose:
                generated_string_Tag = new JSONStringValue("absorbed_dose");
                break;
            case TypeTagKnownValues.Tag_catalytic_activity:
                generated_string_Tag = new JSONStringValue("catalytic_activity");
                break;
            case TypeTagKnownValues.Tag_width:
                generated_string_Tag = new JSONStringValue("width");
                break;
            case TypeTagKnownValues.Tag_height:
                generated_string_Tag = new JSONStringValue("height");
                break;
            case TypeTagKnownValues.Tag_depth:
                generated_string_Tag = new JSONStringValue("depth");
                break;
            default:
                Debug.Assert(false);
                generated_string_Tag = null;
                break;
          }
          }
        return generated_string_Tag;
      }


    private void  fromJSONTag(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Tag of CoreUnitsPropertyJSON is not a string.");
        TypeTag the_open_enum = new TypeTag();
        switch (json_string.getData()[0])
          {
            case 'a':
                switch (json_string.getData()[1])
                  {
                    case 'b':
                        if ((String.Compare(json_string.getData(), 2, "sorbed_dose", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_absorbed_dose;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "gle", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_angle;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ea", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_area;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'c':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'p':
                                if ((String.Compare(json_string.getData(), 3, "acitance", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTagKnownValues.Tag_capacitance;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "alytic_activity", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTagKnownValues.Tag_catalytic_activity;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "unt", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_count;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rrent", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_current;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'd':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "pth", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_depth;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "stance", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_distance;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "ration", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_duration;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'e':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "ectric_", 0, 7, false) == 0)
                          {
                            switch (json_string.getData()[9])
                              {
                                case 'c':
                                    switch (json_string.getData()[10])
                                      {
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 11, "arge", 0, 4, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeTagKnownValues.Tag_electric_charge;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 11, "nductance", 0, 9, false) == 0) && (json_string.getData().Length == 20))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeTagKnownValues.Tag_electric_conductance;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'p':
                                    if ((String.Compare(json_string.getData(), 10, "otential_difference", 0, 19, false) == 0) && (json_string.getData().Length == 29))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTagKnownValues.Tag_electric_potential_difference;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 10, "esistance", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeTagKnownValues.Tag_electric_resistance;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ergy", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_energy;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'f':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "rce", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_force;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "equency", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_frequency;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(json_string.getData(), 1, "eight", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTagKnownValues.Tag_height;
                        goto open_enum_is_done;
                      }
                break;
            case 'i':
                switch (json_string.getData()[1])
                  {
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "luminance", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_illuminance;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ductance", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_inductance;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                if (String.Compare(json_string.getData(), 1, "umino", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 's':
                            if ((String.Compare(json_string.getData(), 7, "ity", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagKnownValues.Tag_luminosity;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 7, "s_flux", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagKnownValues.Tag_luminous_flux;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'm':
                if (String.Compare(json_string.getData(), 1, "a", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'g':
                            if (String.Compare(json_string.getData(), 3, "netic_flux", 0, 10, false) == 0)
                              {
                                if (json_string.getData().Length == 13)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTagKnownValues.Tag_magnetic_flux;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[13])
                                  {
                                    case '_':
                                        if ((String.Compare(json_string.getData(), 14, "density", 0, 7, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeTagKnownValues.Tag_magnetic_flux_density;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 3, "s", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeTagKnownValues.Tag_mass;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "rientation", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTagKnownValues.Tag_orientation;
                        goto open_enum_is_done;
                      }
                break;
            case 'p':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "ition", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTagKnownValues.Tag_position;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'w':
                                if ((String.Compare(json_string.getData(), 3, "er", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeTagKnownValues.Tag_power;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "essure", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_pressure;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 's':
                if ((String.Compare(json_string.getData(), 1, "olid_angle", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTagKnownValues.Tag_solid_angle;
                        goto open_enum_is_done;
                      }
                break;
            case 't':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "mperature", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_temperature;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "me", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_time;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'v':
                if ((String.Compare(json_string.getData(), 1, "olume", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTagKnownValues.Tag_volume;
                        goto open_enum_is_done;
                      }
                break;
            case 'w':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_weight;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "dth", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeTagKnownValues.Tag_width;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTag(the_open_enum);
      }


    public CoreUnitsPropertyJSON()
      {
        flagHasTag = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPropertyKind()
      {
        return "Core";
      }

    public bool  hasTag()
      {
        return flagHasTag;
      }

    public TypeTag  getTag()
      {
        Debug.Assert(flagHasTag);
        return storeTag;
      }

    public string  getTagAsString()
      {
        TypeTag result = getTag();
        if (result.in_known_list)
            return stringFromTag(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraCoreUnitsPropertyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCoreUnitsPropertyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCoreUnitsPropertyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCoreUnitsPropertyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPropertyComponentCount()
      {
        int result = 0;
        if (flagHasTag)
            ++result;
        result += extraCoreUnitsPropertyComponentCount();
        return result;
      }
    public override string extraPropertyComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTag)
          {
            if (remainder == 0)
                return "Tag";
            --remainder;
          }
        return extraCoreUnitsPropertyComponentKey(remainder);
      }
    public override JSONValue extraPropertyComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTag)
          {
            if (remainder == 0)
                return extraTagToJSON();
            --remainder;
          }
        return extraCoreUnitsPropertyComponentValue(remainder);
      }
    public override JSONValue extraPropertyLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Tag", 0, 3, false) == 0) && (field_name.Length == 3))
            return (flagHasTag ? extraTagToJSON() : null);
        return extraCoreUnitsPropertyLookup(field_name);
      }

    public void setTag(TypeTag new_value)
      {
        flagHasTag = true;
        storeTag = new_value;
      }
    public void setTag(string chars)
      {
        TypeTagKnownValues known = stringToTag(chars);
        TypeTag new_value = new TypeTag();
        if (known == TypeTagKnownValues.Tag__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTag(new_value);
      }
    public void setTag(TypeTagKnownValues new_value)
      {
        TypeTag new_full_value = new TypeTag();
        Debug.Assert(new_value != TypeTagKnownValues.Tag__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTag(new_full_value);
      }
    public void unsetTag()
      {
        flagHasTag = false;
      }

    public virtual void extraCoreUnitsPropertyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCoreUnitsPropertySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCoreUnitsPropertyLookup(key);
        if (old_field == null)
          {
            extraCoreUnitsPropertyAppendPair(key, new_component);
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
    public override void extraPropertyAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tag", 0, 3, false) == 0) && (key.Length == 3))
            {
            fromJSONTag(new_component, false);
            return;
            }
        extraCoreUnitsPropertyAppendPair(key, new_component);
      }
    public override void extraPropertySetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tag", 0, 3, false) == 0) && (key.Length == 3))
            {
            fromJSONTag(new_component, false);
            return;
            }
        extraCoreUnitsPropertySetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTag);
        if (flagHasTag)
          {
            handler.start_pair("Tag");
            if (storeTag.in_known_list)
              {
                switch (storeTag.list_value)
                  {
                    case TypeTagKnownValues.Tag_distance:
                        handler.string_value("distance");
                        break;
                    case TypeTagKnownValues.Tag_position:
                        handler.string_value("position");
                        break;
                    case TypeTagKnownValues.Tag_area:
                        handler.string_value("area");
                        break;
                    case TypeTagKnownValues.Tag_volume:
                        handler.string_value("volume");
                        break;
                    case TypeTagKnownValues.Tag_duration:
                        handler.string_value("duration");
                        break;
                    case TypeTagKnownValues.Tag_time:
                        handler.string_value("time");
                        break;
                    case TypeTagKnownValues.Tag_angle:
                        handler.string_value("angle");
                        break;
                    case TypeTagKnownValues.Tag_solid_angle:
                        handler.string_value("solid_angle");
                        break;
                    case TypeTagKnownValues.Tag_orientation:
                        handler.string_value("orientation");
                        break;
                    case TypeTagKnownValues.Tag_mass:
                        handler.string_value("mass");
                        break;
                    case TypeTagKnownValues.Tag_weight:
                        handler.string_value("weight");
                        break;
                    case TypeTagKnownValues.Tag_energy:
                        handler.string_value("energy");
                        break;
                    case TypeTagKnownValues.Tag_power:
                        handler.string_value("power");
                        break;
                    case TypeTagKnownValues.Tag_electric_charge:
                        handler.string_value("electric_charge");
                        break;
                    case TypeTagKnownValues.Tag_electric_potential_difference:
                        handler.string_value("electric_potential_difference");
                        break;
                    case TypeTagKnownValues.Tag_capacitance:
                        handler.string_value("capacitance");
                        break;
                    case TypeTagKnownValues.Tag_electric_resistance:
                        handler.string_value("electric_resistance");
                        break;
                    case TypeTagKnownValues.Tag_electric_conductance:
                        handler.string_value("electric_conductance");
                        break;
                    case TypeTagKnownValues.Tag_inductance:
                        handler.string_value("inductance");
                        break;
                    case TypeTagKnownValues.Tag_magnetic_flux:
                        handler.string_value("magnetic_flux");
                        break;
                    case TypeTagKnownValues.Tag_magnetic_flux_density:
                        handler.string_value("magnetic_flux_density");
                        break;
                    case TypeTagKnownValues.Tag_current:
                        handler.string_value("current");
                        break;
                    case TypeTagKnownValues.Tag_temperature:
                        handler.string_value("temperature");
                        break;
                    case TypeTagKnownValues.Tag_count:
                        handler.string_value("count");
                        break;
                    case TypeTagKnownValues.Tag_luminosity:
                        handler.string_value("luminosity");
                        break;
                    case TypeTagKnownValues.Tag_luminous_flux:
                        handler.string_value("luminous_flux");
                        break;
                    case TypeTagKnownValues.Tag_illuminance:
                        handler.string_value("illuminance");
                        break;
                    case TypeTagKnownValues.Tag_frequency:
                        handler.string_value("frequency");
                        break;
                    case TypeTagKnownValues.Tag_force:
                        handler.string_value("force");
                        break;
                    case TypeTagKnownValues.Tag_pressure:
                        handler.string_value("pressure");
                        break;
                    case TypeTagKnownValues.Tag_absorbed_dose:
                        handler.string_value("absorbed_dose");
                        break;
                    case TypeTagKnownValues.Tag_catalytic_activity:
                        handler.string_value("catalytic_activity");
                        break;
                    case TypeTagKnownValues.Tag_width:
                        handler.string_value("width");
                        break;
                    case TypeTagKnownValues.Tag_height:
                        handler.string_value("height");
                        break;
                    case TypeTagKnownValues.Tag_depth:
                        handler.string_value("depth");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTag.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasTag()))
          {
            return "When parsing the object for %what%, the \"Tag\" field was missing.";
          }
        return null;
      }

    public static new CoreUnitsPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CoreUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CoreUnitsProperty", ignore_extras);
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
    public static new CoreUnitsPropertyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CoreUnitsPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CoreUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CoreUnitsProperty", ignore_extras);
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
    public static new CoreUnitsPropertyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CoreUnitsPropertyJSON from_text(string text, bool ignore_extras)
      {
        CoreUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CoreUnitsProperty", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CoreUnitsPropertyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CoreUnitsPropertyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CoreUnitsPropertyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CoreUnitsProperty", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PropertyJSON.Generator
      {
    private abstract class FieldGeneratorTag : JSONStringGenerator
          {
            protected FieldGeneratorTag(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTag()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTagKnownValues known = stringToTag(result);
                TypeTag new_value = new TypeTag();
                if (known == TypeTagKnownValues.Tag__none)
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
            protected abstract void handle_result(TypeTag result);
          };
    private class FieldHoldingGeneratorTag : FieldGeneratorTag
  {
    protected override void handle_result(TypeTag result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTag(String what)
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
    public TypeTag value;
  };
    private class FieldHoldingArrayGeneratorTag : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTag
      {
        private FieldHoldingArrayGeneratorTag top;

        protected override void handle_result(TypeTag result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTag init_top)
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
    protected virtual void handle_result(List<TypeTag> result)
      {
      }

    public FieldHoldingArrayGeneratorTag(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTag>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTag()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTag>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTag> value;
  };
        private FieldHoldingGeneratorTag fieldGeneratorTag;
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
            if (!(getPropertyJSONKey().Equals("Core")))
                throw new Exception("The key field has a value other than `Core'.");
            CoreUnitsPropertyJSON result = new CoreUnitsPropertyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCoreUnitsPropertyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PropertyJSON new_result)
          {
            handle_result((CoreUnitsPropertyJSON )new_result);
          }
        protected void finish(CoreUnitsPropertyJSON result)
          {
            if (fieldGeneratorTag.have_value)
              {
                result.setTag(fieldGeneratorTag.value);
                fieldGeneratorTag.have_value = false;
              }
            else if ((!(result.hasTag())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Tag\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CoreUnitsPropertyJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Tag", 0, 3, false) == 0) && (field_name.Length == 3))
                return fieldGeneratorTag;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTag = new FieldHoldingGeneratorTag("field \"Tag\" of the CoreUnitsProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CoreUnitsProperty class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTag = new FieldHoldingGeneratorTag("field \"Tag\" of the CoreUnitsProperty class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CoreUnitsProperty class");
          }

        public override void reset()
          {
            fieldGeneratorTag.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CoreUnitsPropertyJSON  result)
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
        public CoreUnitsPropertyJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CoreUnitsPropertyJSON  result)
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
    protected virtual void handle_result(List<CoreUnitsPropertyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CoreUnitsPropertyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CoreUnitsPropertyJSON>();
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
    public List<CoreUnitsPropertyJSON> value;
  };
  };
