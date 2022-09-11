/* file "HolidayJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HolidayJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_unknown,
        Value_new_years_day,
        Value_new_years_eve,
        Value_valentines_day,
        Value_martin_luther_king_day,
        Value_easter,
        Value_easter_monday,
        Value_mothers_day,
        Value_memorial_day,
        Value_fathers_day,
        Value_us_independence_day,
        Value_us_labor_day,
        Value_columbus_day,
        Value_halloween,
        Value_us_thanksgiving_day,
        Value_us_thanksgiving_eve,
        Value_christmas_day,
        Value_christmas_eve,
        Value_rosh_hashanah,
        Value_yom_kippur,
        Value_sukkot,
        Value_hoshana_rabbah,
        Value_shemini_atzeret,
        Value_simchat_torah,
        Value_hanukkah,
        Value_tu_bishvat,
        Value_purim,
        Value_passover,
        Value_lag_baomer,
        Value_shavuot,
        Value_tisha_bav,
        Value_good_friday,
        Value_canada_day,
        Value_us_flag_day,
        Value_veterans_day,
        Value_april_fools_day,
        Value_boxing_day,
        Value_black_friday,
        Value_lent,
        Value_shrove_tuesday,
        Value_mardi_gras,
        Value_ash_wednesday,
        Value_palm_sunday,
        Value_holy_thursday,
        Value_all_saints_day,
        Value_all_souls_day,
        Value_festivus,
        Value_washingtons_birthday,
        Value_saint_patricks_day,
        Value_cesar_chavez_day,
        Value_earth_day,
        Value_cinco_de_mayo,
        Value_spring_equinox,
        Value_summer_solstice,
        Value_fall_equinox,
        Value_winter_solstice,
        Value_remembrance_day,
        Value_kwanzaa,
        Value_groundhog_day,
        Value_jp_coming_of_age_day,
        Value_jp_national_foundation_day,
        Value_jp_vernal_equinox_day,
        Value_jp_showa_day,
        Value_jp_constitution_memorial_day,
        Value_jp_greenery_day,
        Value_jp_childrens_day,
        Value_jp_golden_week,
        Value_jp_marine_day,
        Value_jp_mountain_day,
        Value_jp_respect_for_the_aged_day,
        Value_jp_autumnal_equinox_day,
        Value_jp_health_and_sports_day,
        Value_jp_culture_day,
        Value_jp_labour_thanksgiving_day,
        Value_jp_the_emperors_birthday,
        Value_jp_transfer_holiday,
        Value_jp_citizens_holiday,
        Value_gandhi_jayanti,
        Value_republic_day_of_india,
        Value_indian_independence_day,
        Value_ambedkar_jayanti,
        Value_rabindra_jayanti,
        Value_cheti_chand,
        Value_onam,
        Value_thiruvonam,
        Value_magh_bihu,
        Value_lohri_maghi_or_bhogi,
        Value_labor_day_in_india,
        Value_flag_day_of_india,
        Value_mesadi,
        Value_vaisakhadi,
        Value_vishu,
        Value_bohag_bihu,
        Value_ugadi,
        Value_puthandu,
        Value_pohela_boishakh,
        Value_muharram,
        Value_day_of_ashura,
        Value_milad_un_nabi,
        Value_ramadan,
        Value_eid_al_adha,
        Value_eid_al_fitr,
        Value_eid,
        Value_jumuatul_wida,
        Value_day_of_arafah,
        Value_birthday_of_ali_ibn_abi_talib,
        Value_pentecost,
        Value_pentecost_monday,
        Value_may_day,
        Value_international_womens_day,
        Value_cn_spring_festival_eve,
        Value_cn_spring_festival,
        Value_cn_lantern_festival,
        Value_cn_qingming_festival,
        Value_cn_youth_day,
        Value_cn_dragon_boat_festival,
        Value_cn_childrens_day,
        Value_cn_cpc_founding_day,
        Value_cn_pla_founding_day,
        Value_cn_qixi_festival,
        Value_cn_mid_autumn_festival,
        Value_cn_national_day,
        Value_cn_chong_yang_festival,
        Value_holika_dahan,
        Value_dol_yatra,
        Value_holi,
        Value_dussehra,
        Value_bijoy_doshomi,
        Value_durga_puja,
        Value_diwali,
        Value_kali_puja,
        Value_dhanteras,
        Value_kali_chaudas,
        Value_naraka_chaturdashi,
        Value_lakshmi_puja,
        Value_bali_pratipada,
        Value_goverdhan_puja,
        Value_bhai_dooj,
        Value_ram_navami,
        Value_ganesh_chaturthi,
        Value_janmashtami,
        Value_nag_panchami,
        Value_makar_sankranti,
        Value_pongal,
        Value_raksha_bandhan,
        Value_basant_panchami,
        Value_saraswati_puja,
        Value_rath_yatra,
        Value_navaratri,
        Value_maha_saptami,
        Value_maha_ashtami,
        Value_maha_navami,
        Value_maha_shivaratri,
        Value_anant_chaturdashi,
        Value_shivaji_jayanti,
        Value_valmiki_jayanti,
        Value_chhat_puja,
        Value_dayanand_saraswati_jayanti,
        Value_karwa_chauth,
        Value_vaisakhi,
        Value_guru_nanak_gurpurab,
        Value_guru_gobind_singh_gurpurab,
        Value_guru_teg_bahadur_shahid_diwas,
        Value_mahavir_jayanti,
        Value_paryushan,
        Value_vesak_or_buddha_purnima,
        Value_hanamatsuri,
        Value_sa_ga_dawa,
        Value_ravidass_jayanti,
        Value_bodhi_day,
        Value_rohatsu,
        Value_asalha_puja,
        Value_loy_krathong,
        Value_nowruz,
        Value_nowruz_in_india,
        Value_ca_family_day,
        Value_ca_thanksgiving_day,
        Value_ca_thanksgiving_eve,
        Value_united_nations_day,
        Value_epiphany,
        Value_ascension_day,
        Value_advent_1st,
        Value_advent_2nd,
        Value_advent_3rd,
        Value_advent_4th,
        Value_saint_knuts_day,
        Value_saint_lucys_day,
        Value_midsummer_eve,
        Value_waffle_day,
        Value_walpurgis_night,
        Value_se_national_day,
        Value_se_fathers_day,
        Value_se_mothers_day,
        Value_nobels_day,
        Value_juneteenth,
        Value_fat_thursday,
        Value_shrove_monday,
        Value_de_fathers_day,
        Value_feast_of_corpus_christi,
        Value_assumption_of_mary,
        Value_reformation_day,
        Value_augsburg_peace_festival,
        Value_de_childrens_day,
        Value_de_unity_day,
        Value_de_harvest_festival,
        Value_saint_martins_day,
        Value_de_peoples_day_of_mourning,
        Value_day_of_repentance_and_prayer,
        Value_sunday_of_the_dead,
        Value_saint_nicholas_day,
        Value_immaculate_conception,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'a':
                switch (chars[1])
                  {
                    case 'd':
                        if (String.Compare(chars, 2, "vent_", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case '1':
                                    if ((String.Compare(chars, 8, "st", 0, 2, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_advent_1st;
                                    break;
                                case '2':
                                    if ((String.Compare(chars, 8, "nd", 0, 2, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_advent_2nd;
                                    break;
                                case '3':
                                    if ((String.Compare(chars, 8, "rd", 0, 2, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_advent_3rd;
                                    break;
                                case '4':
                                    if ((String.Compare(chars, 8, "th", 0, 2, false) == 0) && (chars.Length == 10))
                                        return TypeValueKnownValues.Value_advent_4th;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if (String.Compare(chars, 2, "l_s", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 6, "ints_day", 0, 8, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_all_saints_day;
                                    break;
                                case 'o':
                                    if ((String.Compare(chars, 6, "uls_day", 0, 7, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_all_souls_day;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'm':
                        if ((String.Compare(chars, 2, "bedkar_jayanti", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_ambedkar_jayanti;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ant_chaturdashi", 0, 15, false) == 0) && (chars.Length == 17))
                            return TypeValueKnownValues.Value_anant_chaturdashi;
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "ril_fools_day", 0, 13, false) == 0) && (chars.Length == 15))
                            return TypeValueKnownValues.Value_april_fools_day;
                        break;
                    case 's':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "lha_puja", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_asalha_puja;
                                break;
                            case 'c':
                                if ((String.Compare(chars, 3, "ension_day", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_ascension_day;
                                break;
                            case 'h':
                                if ((String.Compare(chars, 3, "_wednesday", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_ash_wednesday;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "umption_of_mary", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeValueKnownValues.Value_assumption_of_mary;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "gsburg_peace_festival", 0, 21, false) == 0) && (chars.Length == 23))
                            return TypeValueKnownValues.Value_augsburg_peace_festival;
                        break;
                    default:
                        break;
                  }
                break;
            case 'b':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "i_pratipada", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeValueKnownValues.Value_bali_pratipada;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "ant_panchami", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_basant_panchami;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "ai_dooj", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_bhai_dooj;
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'j':
                                if ((String.Compare(chars, 3, "oy_doshomi", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_bijoy_doshomi;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "thday_of_ali_ibn_abi_talib", 0, 26, false) == 0) && (chars.Length == 29))
                                    return TypeValueKnownValues.Value_birthday_of_ali_ibn_abi_talib;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ack_friday", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_black_friday;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "hi_day", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_bodhi_day;
                                break;
                            case 'h':
                                if ((String.Compare(chars, 3, "ag_bihu", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_bohag_bihu;
                                break;
                            case 'x':
                                if ((String.Compare(chars, 3, "ing_day", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_boxing_day;
                                break;
                            default:
                                break;
                          }
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
                            case '_':
                                switch (chars[3])
                                  {
                                    case 'f':
                                        if ((String.Compare(chars, 4, "amily_day", 0, 9, false) == 0) && (chars.Length == 13))
                                            return TypeValueKnownValues.Value_ca_family_day;
                                        break;
                                    case 't':
                                        if (String.Compare(chars, 4, "hanksgiving_", 0, 12, false) == 0)
                                          {
                                            switch (chars[16])
                                              {
                                                case 'd':
                                                    if ((String.Compare(chars, 17, "ay", 0, 2, false) == 0) && (chars.Length == 19))
                                                        return TypeValueKnownValues.Value_ca_thanksgiving_day;
                                                    break;
                                                case 'e':
                                                    if ((String.Compare(chars, 17, "ve", 0, 2, false) == 0) && (chars.Length == 19))
                                                        return TypeValueKnownValues.Value_ca_thanksgiving_eve;
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
                            case 'n':
                                if ((String.Compare(chars, 3, "ada_day", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_canada_day;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "sar_chavez_day", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_cesar_chavez_day;
                        break;
                    case 'h':
                        switch (chars[2])
                          {
                            case 'e':
                                if ((String.Compare(chars, 3, "ti_chand", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_cheti_chand;
                                break;
                            case 'h':
                                if ((String.Compare(chars, 3, "at_puja", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_chhat_puja;
                                break;
                            case 'r':
                                if (String.Compare(chars, 3, "istmas_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'd':
                                            if ((String.Compare(chars, 11, "ay", 0, 2, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_christmas_day;
                                            break;
                                        case 'e':
                                            if ((String.Compare(chars, 11, "ve", 0, 2, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_christmas_eve;
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
                    case 'i':
                        if ((String.Compare(chars, 2, "nco_de_mayo", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_cinco_de_mayo;
                        break;
                    case 'n':
                        if (String.Compare(chars, 2, "_", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'c':
                                    switch (chars[4])
                                      {
                                        case 'h':
                                            switch (chars[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(chars, 6, "ldrens_day", 0, 10, false) == 0) && (chars.Length == 16))
                                                        return TypeValueKnownValues.Value_cn_childrens_day;
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 6, "ng_yang_festival", 0, 16, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_cn_chong_yang_festival;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'p':
                                            if ((String.Compare(chars, 5, "c_founding_day", 0, 14, false) == 0) && (chars.Length == 19))
                                                return TypeValueKnownValues.Value_cn_cpc_founding_day;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'd':
                                    if ((String.Compare(chars, 4, "ragon_boat_festival", 0, 19, false) == 0) && (chars.Length == 23))
                                        return TypeValueKnownValues.Value_cn_dragon_boat_festival;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 4, "antern_festival", 0, 15, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_cn_lantern_festival;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 4, "id_autumn_festival", 0, 18, false) == 0) && (chars.Length == 22))
                                        return TypeValueKnownValues.Value_cn_mid_autumn_festival;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 4, "ational_day", 0, 11, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_cn_national_day;
                                    break;
                                case 'p':
                                    if ((String.Compare(chars, 4, "la_founding_day", 0, 15, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_cn_pla_founding_day;
                                    break;
                                case 'q':
                                    if (String.Compare(chars, 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (chars[5])
                                          {
                                            case 'n':
                                                if ((String.Compare(chars, 6, "gming_festival", 0, 14, false) == 0) && (chars.Length == 20))
                                                    return TypeValueKnownValues.Value_cn_qingming_festival;
                                                break;
                                            case 'x':
                                                if ((String.Compare(chars, 6, "i_festival", 0, 10, false) == 0) && (chars.Length == 16))
                                                    return TypeValueKnownValues.Value_cn_qixi_festival;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 's':
                                    if (String.Compare(chars, 4, "pring_festival", 0, 14, false) == 0)
                                      {
                                        if (chars.Length == 18)
                                          {
                                            return TypeValueKnownValues.Value_cn_spring_festival;
                                          }
                                        switch (chars[18])
                                          {
                                            case '_':
                                                if ((String.Compare(chars, 19, "eve", 0, 3, false) == 0) && (chars.Length == 22))
                                                    return TypeValueKnownValues.Value_cn_spring_festival_eve;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'y':
                                    if ((String.Compare(chars, 4, "outh_day", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_cn_youth_day;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "lumbus_day", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_columbus_day;
                        break;
                    default:
                        break;
                  }
                break;
            case 'd':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "y", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case '_':
                                    if (String.Compare(chars, 4, "of_", 0, 3, false) == 0)
                                      {
                                        switch (chars[7])
                                          {
                                            case 'a':
                                                switch (chars[8])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(chars, 9, "afah", 0, 4, false) == 0) && (chars.Length == 13))
                                                            return TypeValueKnownValues.Value_day_of_arafah;
                                                        break;
                                                    case 's':
                                                        if ((String.Compare(chars, 9, "hura", 0, 4, false) == 0) && (chars.Length == 13))
                                                            return TypeValueKnownValues.Value_day_of_ashura;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'r':
                                                if ((String.Compare(chars, 8, "epentance_and_prayer", 0, 20, false) == 0) && (chars.Length == 28))
                                                    return TypeValueKnownValues.Value_day_of_repentance_and_prayer;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'a':
                                    if ((String.Compare(chars, 4, "nand_saraswati_jayanti", 0, 22, false) == 0) && (chars.Length == 26))
                                        return TypeValueKnownValues.Value_dayanand_saraswati_jayanti;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "_", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'c':
                                    if ((String.Compare(chars, 4, "hildrens_day", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_de_childrens_day;
                                    break;
                                case 'f':
                                    if ((String.Compare(chars, 4, "athers_day", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_de_fathers_day;
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 4, "arvest_festival", 0, 15, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_de_harvest_festival;
                                    break;
                                case 'p':
                                    if ((String.Compare(chars, 4, "eoples_day_of_mourning", 0, 22, false) == 0) && (chars.Length == 26))
                                        return TypeValueKnownValues.Value_de_peoples_day_of_mourning;
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 4, "nity_day", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_de_unity_day;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(chars, 2, "anteras", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_dhanteras;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "wali", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_diwali;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "l_yatra", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_dol_yatra;
                        break;
                    case 'u':
                        switch (chars[2])
                          {
                            case 'r':
                                if ((String.Compare(chars, 3, "ga_puja", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_durga_puja;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "sehra", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_dussehra;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'e':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'r':
                                if ((String.Compare(chars, 3, "th_day", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_earth_day;
                                break;
                            case 's':
                                if (String.Compare(chars, 3, "ter", 0, 3, false) == 0)
                                  {
                                    if (chars.Length == 6)
                                      {
                                        return TypeValueKnownValues.Value_easter;
                                      }
                                    switch (chars[6])
                                      {
                                        case '_':
                                            if ((String.Compare(chars, 7, "monday", 0, 6, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_easter_monday;
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
                    case 'i':
                        if (String.Compare(chars, 2, "d", 0, 1, false) == 0)
                          {
                            if (chars.Length == 3)
                              {
                                return TypeValueKnownValues.Value_eid;
                              }
                            switch (chars[3])
                              {
                                case '_':
                                    if (String.Compare(chars, 4, "al_", 0, 3, false) == 0)
                                      {
                                        switch (chars[7])
                                          {
                                            case 'a':
                                                if ((String.Compare(chars, 8, "dha", 0, 3, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_eid_al_adha;
                                                break;
                                            case 'f':
                                                if ((String.Compare(chars, 8, "itr", 0, 3, false) == 0) && (chars.Length == 11))
                                                    return TypeValueKnownValues.Value_eid_al_fitr;
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
                    case 'p':
                        if ((String.Compare(chars, 2, "iphany", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_epiphany;
                        break;
                    default:
                        break;
                  }
                break;
            case 'f':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "l_equinox", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_fall_equinox;
                                break;
                            case 't':
                                switch (chars[3])
                                  {
                                    case '_':
                                        if ((String.Compare(chars, 4, "thursday", 0, 8, false) == 0) && (chars.Length == 12))
                                            return TypeValueKnownValues.Value_fat_thursday;
                                        break;
                                    case 'h':
                                        if ((String.Compare(chars, 4, "ers_day", 0, 7, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_fathers_day;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "st_of_corpus_christi", 0, 20, false) == 0) && (chars.Length == 23))
                                    return TypeValueKnownValues.Value_feast_of_corpus_christi;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "tivus", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_festivus;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ag_day_of_india", 0, 15, false) == 0) && (chars.Length == 17))
                            return TypeValueKnownValues.Value_flag_day_of_india;
                        break;
                    default:
                        break;
                  }
                break;
            case 'g':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "n", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'd':
                                    if ((String.Compare(chars, 4, "hi_jayanti", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_gandhi_jayanti;
                                    break;
                                case 'e':
                                    if ((String.Compare(chars, 4, "sh_chaturthi", 0, 12, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_ganesh_chaturthi;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'o':
                                if ((String.Compare(chars, 3, "d_friday", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_good_friday;
                                break;
                            case 'v':
                                if ((String.Compare(chars, 3, "erdhan_puja", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeValueKnownValues.Value_goverdhan_puja;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "oundhog_day", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_groundhog_day;
                        break;
                    case 'u':
                        if (String.Compare(chars, 2, "ru_", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'g':
                                    if ((String.Compare(chars, 6, "obind_singh_gurpurab", 0, 20, false) == 0) && (chars.Length == 26))
                                        return TypeValueKnownValues.Value_guru_gobind_singh_gurpurab;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 6, "anak_gurpurab", 0, 13, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_guru_nanak_gurpurab;
                                    break;
                                case 't':
                                    if ((String.Compare(chars, 6, "eg_bahadur_shahid_diwas", 0, 23, false) == 0) && (chars.Length == 29))
                                        return TypeValueKnownValues.Value_guru_teg_bahadur_shahid_diwas;
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
            case 'h':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "loween", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_halloween;
                                break;
                            case 'n':
                                switch (chars[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(chars, 4, "matsuri", 0, 7, false) == 0) && (chars.Length == 11))
                                            return TypeValueKnownValues.Value_hanamatsuri;
                                        break;
                                    case 'u':
                                        if ((String.Compare(chars, 4, "kkah", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeValueKnownValues.Value_hanukkah;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'l':
                                switch (chars[3])
                                  {
                                    case 'i':
                                        if (chars.Length == 4)
                                          {
                                            return TypeValueKnownValues.Value_holi;
                                          }
                                        switch (chars[4])
                                          {
                                            case 'k':
                                                if ((String.Compare(chars, 5, "a_dahan", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeValueKnownValues.Value_holika_dahan;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'y':
                                        if ((String.Compare(chars, 4, "_thursday", 0, 9, false) == 0) && (chars.Length == 13))
                                            return TypeValueKnownValues.Value_holy_thursday;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "hana_rabbah", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeValueKnownValues.Value_hoshana_rabbah;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'i':
                switch (chars[1])
                  {
                    case 'm':
                        if ((String.Compare(chars, 2, "maculate_conception", 0, 19, false) == 0) && (chars.Length == 21))
                            return TypeValueKnownValues.Value_immaculate_conception;
                        break;
                    case 'n':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "ian_independence_day", 0, 20, false) == 0) && (chars.Length == 23))
                                    return TypeValueKnownValues.Value_indian_independence_day;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "ernational_womens_day", 0, 21, false) == 0) && (chars.Length == 24))
                                    return TypeValueKnownValues.Value_international_womens_day;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'j':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "nmashtami", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_janmashtami;
                        break;
                    case 'p':
                        if (String.Compare(chars, 2, "_", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 4, "utumnal_equinox_day", 0, 19, false) == 0) && (chars.Length == 23))
                                        return TypeValueKnownValues.Value_jp_autumnal_equinox_day;
                                    break;
                                case 'c':
                                    switch (chars[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(chars, 5, "ildrens_day", 0, 11, false) == 0) && (chars.Length == 16))
                                                return TypeValueKnownValues.Value_jp_childrens_day;
                                            break;
                                        case 'i':
                                            if ((String.Compare(chars, 5, "tizens_holiday", 0, 14, false) == 0) && (chars.Length == 19))
                                                return TypeValueKnownValues.Value_jp_citizens_holiday;
                                            break;
                                        case 'o':
                                            switch (chars[5])
                                              {
                                                case 'm':
                                                    if ((String.Compare(chars, 6, "ing_of_age_day", 0, 14, false) == 0) && (chars.Length == 20))
                                                        return TypeValueKnownValues.Value_jp_coming_of_age_day;
                                                    break;
                                                case 'n':
                                                    if ((String.Compare(chars, 6, "stitution_memorial_day", 0, 22, false) == 0) && (chars.Length == 28))
                                                        return TypeValueKnownValues.Value_jp_constitution_memorial_day;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'u':
                                            if ((String.Compare(chars, 5, "lture_day", 0, 9, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_jp_culture_day;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'g':
                                    switch (chars[4])
                                      {
                                        case 'o':
                                            if ((String.Compare(chars, 5, "lden_week", 0, 9, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_jp_golden_week;
                                            break;
                                        case 'r':
                                            if ((String.Compare(chars, 5, "eenery_day", 0, 10, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_jp_greenery_day;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'h':
                                    if ((String.Compare(chars, 4, "ealth_and_sports_day", 0, 20, false) == 0) && (chars.Length == 24))
                                        return TypeValueKnownValues.Value_jp_health_and_sports_day;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 4, "abour_thanksgiving_day", 0, 22, false) == 0) && (chars.Length == 26))
                                        return TypeValueKnownValues.Value_jp_labour_thanksgiving_day;
                                    break;
                                case 'm':
                                    switch (chars[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 5, "rine_day", 0, 8, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_jp_marine_day;
                                            break;
                                        case 'o':
                                            if ((String.Compare(chars, 5, "untain_day", 0, 10, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_jp_mountain_day;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 4, "ational_foundation_day", 0, 22, false) == 0) && (chars.Length == 26))
                                        return TypeValueKnownValues.Value_jp_national_foundation_day;
                                    break;
                                case 'r':
                                    if ((String.Compare(chars, 4, "espect_for_the_aged_day", 0, 23, false) == 0) && (chars.Length == 27))
                                        return TypeValueKnownValues.Value_jp_respect_for_the_aged_day;
                                    break;
                                case 's':
                                    if ((String.Compare(chars, 4, "howa_day", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_jp_showa_day;
                                    break;
                                case 't':
                                    switch (chars[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(chars, 5, "e_emperors_birthday", 0, 19, false) == 0) && (chars.Length == 24))
                                                return TypeValueKnownValues.Value_jp_the_emperors_birthday;
                                            break;
                                        case 'r':
                                            if ((String.Compare(chars, 5, "ansfer_holiday", 0, 14, false) == 0) && (chars.Length == 19))
                                                return TypeValueKnownValues.Value_jp_transfer_holiday;
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(chars, 4, "ernal_equinox_day", 0, 17, false) == 0) && (chars.Length == 21))
                                        return TypeValueKnownValues.Value_jp_vernal_equinox_day;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        switch (chars[2])
                          {
                            case 'm':
                                if ((String.Compare(chars, 3, "uatul_wida", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_jumuatul_wida;
                                break;
                            case 'n':
                                if ((String.Compare(chars, 3, "eteenth", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_juneteenth;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'k':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if (String.Compare(chars, 3, "i_", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 'c':
                                            if ((String.Compare(chars, 6, "haudas", 0, 6, false) == 0) && (chars.Length == 12))
                                                return TypeValueKnownValues.Value_kali_chaudas;
                                            break;
                                        case 'p':
                                            if ((String.Compare(chars, 6, "uja", 0, 3, false) == 0) && (chars.Length == 9))
                                                return TypeValueKnownValues.Value_kali_puja;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "wa_chauth", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_karwa_chauth;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'w':
                        if ((String.Compare(chars, 2, "anzaa", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_kwanzaa;
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "or_day_in_india", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeValueKnownValues.Value_labor_day_in_india;
                                break;
                            case 'g':
                                if ((String.Compare(chars, 3, "_baomer", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_lag_baomer;
                                break;
                            case 'k':
                                if ((String.Compare(chars, 3, "shmi_puja", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_lakshmi_puja;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "nt", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_lent;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'h':
                                if ((String.Compare(chars, 3, "ri_maghi_or_bhogi", 0, 17, false) == 0) && (chars.Length == 20))
                                    return TypeValueKnownValues.Value_lohri_maghi_or_bhogi;
                                break;
                            case 'y':
                                if ((String.Compare(chars, 3, "_krathong", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_loy_krathong;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'm':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'g':
                                if ((String.Compare(chars, 3, "h_bihu", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_magh_bihu;
                                break;
                            case 'h':
                                if (String.Compare(chars, 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case '_':
                                            switch (chars[5])
                                              {
                                                case 'a':
                                                    if ((String.Compare(chars, 6, "shtami", 0, 6, false) == 0) && (chars.Length == 12))
                                                        return TypeValueKnownValues.Value_maha_ashtami;
                                                    break;
                                                case 'n':
                                                    if ((String.Compare(chars, 6, "avami", 0, 5, false) == 0) && (chars.Length == 11))
                                                        return TypeValueKnownValues.Value_maha_navami;
                                                    break;
                                                case 's':
                                                    switch (chars[6])
                                                      {
                                                        case 'a':
                                                            if ((String.Compare(chars, 7, "ptami", 0, 5, false) == 0) && (chars.Length == 12))
                                                                return TypeValueKnownValues.Value_maha_saptami;
                                                            break;
                                                        case 'h':
                                                            if ((String.Compare(chars, 7, "ivaratri", 0, 8, false) == 0) && (chars.Length == 15))
                                                                return TypeValueKnownValues.Value_maha_shivaratri;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'v':
                                            if ((String.Compare(chars, 5, "ir_jayanti", 0, 10, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_mahavir_jayanti;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'k':
                                if ((String.Compare(chars, 3, "ar_sankranti", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_makar_sankranti;
                                break;
                            case 'r':
                                switch (chars[3])
                                  {
                                    case 'd':
                                        if ((String.Compare(chars, 4, "i_gras", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_mardi_gras;
                                        break;
                                    case 't':
                                        if ((String.Compare(chars, 4, "in_luther_king_day", 0, 18, false) == 0) && (chars.Length == 22))
                                            return TypeValueKnownValues.Value_martin_luther_king_day;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'y':
                                if ((String.Compare(chars, 3, "_day", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_may_day;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'm':
                                if ((String.Compare(chars, 3, "orial_day", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_memorial_day;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "adi", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_mesadi;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "summer_eve", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_midsummer_eve;
                                break;
                            case 'l':
                                if ((String.Compare(chars, 3, "ad_un_nabi", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_milad_un_nabi;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "thers_day", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_mothers_day;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "harram", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_muharram;
                        break;
                    default:
                        break;
                  }
                break;
            case 'n':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'g':
                                if ((String.Compare(chars, 3, "_panchami", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_nag_panchami;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "aka_chaturdashi", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeValueKnownValues.Value_naraka_chaturdashi;
                                break;
                            case 'v':
                                if ((String.Compare(chars, 3, "aratri", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_navaratri;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "w_years_", 0, 8, false) == 0)
                          {
                            switch (chars[10])
                              {
                                case 'd':
                                    if ((String.Compare(chars, 11, "ay", 0, 2, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_new_years_day;
                                    break;
                                case 'e':
                                    if ((String.Compare(chars, 11, "ve", 0, 2, false) == 0) && (chars.Length == 13))
                                        return TypeValueKnownValues.Value_new_years_eve;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "els_day", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_nobels_day;
                                break;
                            case 'w':
                                if (String.Compare(chars, 3, "ruz", 0, 3, false) == 0)
                                  {
                                    if (chars.Length == 6)
                                      {
                                        return TypeValueKnownValues.Value_nowruz;
                                      }
                                    switch (chars[6])
                                      {
                                        case '_':
                                            if ((String.Compare(chars, 7, "in_india", 0, 8, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_nowruz_in_india;
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
                    default:
                        break;
                  }
                break;
            case 'o':
                if ((String.Compare(chars, 1, "nam", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_onam;
                break;
            case 'p':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'l':
                                if ((String.Compare(chars, 3, "m_sunday", 0, 8, false) == 0) && (chars.Length == 11))
                                    return TypeValueKnownValues.Value_palm_sunday;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "yushan", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeValueKnownValues.Value_paryushan;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "sover", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_passover;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "ntecost", 0, 7, false) == 0)
                          {
                            if (chars.Length == 9)
                              {
                                return TypeValueKnownValues.Value_pentecost;
                              }
                            switch (chars[9])
                              {
                                case '_':
                                    if ((String.Compare(chars, 10, "monday", 0, 6, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_pentecost_monday;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'h':
                                if ((String.Compare(chars, 3, "ela_boishakh", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_pohela_boishakh;
                                break;
                            case 'n':
                                if ((String.Compare(chars, 3, "gal", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_pongal;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        switch (chars[2])
                          {
                            case 'r':
                                if ((String.Compare(chars, 3, "im", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeValueKnownValues.Value_purim;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "handu", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeValueKnownValues.Value_puthandu;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'r':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'b':
                                if ((String.Compare(chars, 3, "indra_jayanti", 0, 13, false) == 0) && (chars.Length == 16))
                                    return TypeValueKnownValues.Value_rabindra_jayanti;
                                break;
                            case 'k':
                                if ((String.Compare(chars, 3, "sha_bandhan", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeValueKnownValues.Value_raksha_bandhan;
                                break;
                            case 'm':
                                switch (chars[3])
                                  {
                                    case '_':
                                        if ((String.Compare(chars, 4, "navami", 0, 6, false) == 0) && (chars.Length == 10))
                                            return TypeValueKnownValues.Value_ram_navami;
                                        break;
                                    case 'a':
                                        if ((String.Compare(chars, 4, "dan", 0, 3, false) == 0) && (chars.Length == 7))
                                            return TypeValueKnownValues.Value_ramadan;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "h_yatra", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_rath_yatra;
                                break;
                            case 'v':
                                if ((String.Compare(chars, 3, "idass_jayanti", 0, 13, false) == 0) && (chars.Length == 16))
                                    return TypeValueKnownValues.Value_ravidass_jayanti;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'f':
                                if ((String.Compare(chars, 3, "ormation_day", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_reformation_day;
                                break;
                            case 'm':
                                if ((String.Compare(chars, 3, "embrance_day", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_remembrance_day;
                                break;
                            case 'p':
                                if ((String.Compare(chars, 3, "ublic_day_of_india", 0, 18, false) == 0) && (chars.Length == 21))
                                    return TypeValueKnownValues.Value_republic_day_of_india;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'h':
                                if ((String.Compare(chars, 3, "atsu", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_rohatsu;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "h_hashanah", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeValueKnownValues.Value_rosh_hashanah;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 's':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case '_':
                                if ((String.Compare(chars, 3, "ga_dawa", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_sa_ga_dawa;
                                break;
                            case 'i':
                                if (String.Compare(chars, 3, "nt_", 0, 3, false) == 0)
                                  {
                                    switch (chars[6])
                                      {
                                        case 'k':
                                            if ((String.Compare(chars, 7, "nuts_day", 0, 8, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_saint_knuts_day;
                                            break;
                                        case 'l':
                                            if ((String.Compare(chars, 7, "ucys_day", 0, 8, false) == 0) && (chars.Length == 15))
                                                return TypeValueKnownValues.Value_saint_lucys_day;
                                            break;
                                        case 'm':
                                            if ((String.Compare(chars, 7, "artins_day", 0, 10, false) == 0) && (chars.Length == 17))
                                                return TypeValueKnownValues.Value_saint_martins_day;
                                            break;
                                        case 'n':
                                            if ((String.Compare(chars, 7, "icholas_day", 0, 11, false) == 0) && (chars.Length == 18))
                                                return TypeValueKnownValues.Value_saint_nicholas_day;
                                            break;
                                        case 'p':
                                            if ((String.Compare(chars, 7, "atricks_day", 0, 11, false) == 0) && (chars.Length == 18))
                                                return TypeValueKnownValues.Value_saint_patricks_day;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "aswati_puja", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeValueKnownValues.Value_saraswati_puja;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "_", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'f':
                                    if ((String.Compare(chars, 4, "athers_day", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_se_fathers_day;
                                    break;
                                case 'm':
                                    if ((String.Compare(chars, 4, "others_day", 0, 10, false) == 0) && (chars.Length == 14))
                                        return TypeValueKnownValues.Value_se_mothers_day;
                                    break;
                                case 'n':
                                    if ((String.Compare(chars, 4, "ational_day", 0, 11, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_se_national_day;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "vuot", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_shavuot;
                                break;
                            case 'e':
                                if ((String.Compare(chars, 3, "mini_atzeret", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_shemini_atzeret;
                                break;
                            case 'i':
                                if ((String.Compare(chars, 3, "vaji_jayanti", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_shivaji_jayanti;
                                break;
                            case 'r':
                                if (String.Compare(chars, 3, "ove_", 0, 4, false) == 0)
                                  {
                                    switch (chars[7])
                                      {
                                        case 'm':
                                            if ((String.Compare(chars, 8, "onday", 0, 5, false) == 0) && (chars.Length == 13))
                                                return TypeValueKnownValues.Value_shrove_monday;
                                            break;
                                        case 't':
                                            if ((String.Compare(chars, 8, "uesday", 0, 6, false) == 0) && (chars.Length == 14))
                                                return TypeValueKnownValues.Value_shrove_tuesday;
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
                    case 'i':
                        if ((String.Compare(chars, 2, "mchat_torah", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_simchat_torah;
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "ring_equinox", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeValueKnownValues.Value_spring_equinox;
                        break;
                    case 'u':
                        switch (chars[2])
                          {
                            case 'k':
                                if ((String.Compare(chars, 3, "kot", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeValueKnownValues.Value_sukkot;
                                break;
                            case 'm':
                                if ((String.Compare(chars, 3, "mer_solstice", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_summer_solstice;
                                break;
                            case 'n':
                                if ((String.Compare(chars, 3, "day_of_the_dead", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeValueKnownValues.Value_sunday_of_the_dead;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "iruvonam", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_thiruvonam;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "sha_bav", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeValueKnownValues.Value_tisha_bav;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "_bishvat", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_tu_bishvat;
                        break;
                    default:
                        break;
                  }
                break;
            case 'u':
                switch (chars[1])
                  {
                    case 'g':
                        if ((String.Compare(chars, 2, "adi", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_ugadi;
                        break;
                    case 'n':
                        switch (chars[2])
                          {
                            case 'i':
                                if ((String.Compare(chars, 3, "ted_nations_day", 0, 15, false) == 0) && (chars.Length == 18))
                                    return TypeValueKnownValues.Value_united_nations_day;
                                break;
                            case 'k':
                                if ((String.Compare(chars, 3, "nown", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeValueKnownValues.Value_unknown;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 's':
                        if (String.Compare(chars, 2, "_", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'f':
                                    if ((String.Compare(chars, 4, "lag_day", 0, 7, false) == 0) && (chars.Length == 11))
                                        return TypeValueKnownValues.Value_us_flag_day;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 4, "ndependence_day", 0, 15, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_us_independence_day;
                                    break;
                                case 'l':
                                    if ((String.Compare(chars, 4, "abor_day", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeValueKnownValues.Value_us_labor_day;
                                    break;
                                case 't':
                                    if (String.Compare(chars, 4, "hanksgiving_", 0, 12, false) == 0)
                                      {
                                        switch (chars[16])
                                          {
                                            case 'd':
                                                if ((String.Compare(chars, 17, "ay", 0, 2, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_us_thanksgiving_day;
                                                break;
                                            case 'e':
                                                if ((String.Compare(chars, 17, "ve", 0, 2, false) == 0) && (chars.Length == 19))
                                                    return TypeValueKnownValues.Value_us_thanksgiving_eve;
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
                break;
            case 'v':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'i':
                                if (String.Compare(chars, 3, "sakh", 0, 4, false) == 0)
                                  {
                                    switch (chars[7])
                                      {
                                        case 'a':
                                            if ((String.Compare(chars, 8, "di", 0, 2, false) == 0) && (chars.Length == 10))
                                                return TypeValueKnownValues.Value_vaisakhadi;
                                            break;
                                        case 'i':
                                            if (chars.Length == 8)
                                                return TypeValueKnownValues.Value_vaisakhi;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'l':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(chars, 4, "ntines_day", 0, 10, false) == 0) && (chars.Length == 14))
                                            return TypeValueKnownValues.Value_valentines_day;
                                        break;
                                    case 'm':
                                        if ((String.Compare(chars, 4, "iki_jayanti", 0, 11, false) == 0) && (chars.Length == 15))
                                            return TypeValueKnownValues.Value_valmiki_jayanti;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 's':
                                if ((String.Compare(chars, 3, "ak_or_buddha_purnima", 0, 20, false) == 0) && (chars.Length == 23))
                                    return TypeValueKnownValues.Value_vesak_or_buddha_purnima;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "erans_day", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeValueKnownValues.Value_veterans_day;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "shu", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_vishu;
                        break;
                    default:
                        break;
                  }
                break;
            case 'w':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'f':
                                if ((String.Compare(chars, 3, "fle_day", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeValueKnownValues.Value_waffle_day;
                                break;
                            case 'l':
                                if ((String.Compare(chars, 3, "purgis_night", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeValueKnownValues.Value_walpurgis_night;
                                break;
                            case 's':
                                if ((String.Compare(chars, 3, "hingtons_birthday", 0, 17, false) == 0) && (chars.Length == 20))
                                    return TypeValueKnownValues.Value_washingtons_birthday;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "nter_solstice", 0, 13, false) == 0) && (chars.Length == 15))
                            return TypeValueKnownValues.Value_winter_solstice;
                        break;
                    default:
                        break;
                  }
                break;
            case 'y':
                if ((String.Compare(chars, 1, "om_kippur", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_yom_kippur;
                break;
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_unknown:
                return "unknown";
            case TypeValueKnownValues.Value_new_years_day:
                return "new_years_day";
            case TypeValueKnownValues.Value_new_years_eve:
                return "new_years_eve";
            case TypeValueKnownValues.Value_valentines_day:
                return "valentines_day";
            case TypeValueKnownValues.Value_martin_luther_king_day:
                return "martin_luther_king_day";
            case TypeValueKnownValues.Value_easter:
                return "easter";
            case TypeValueKnownValues.Value_easter_monday:
                return "easter_monday";
            case TypeValueKnownValues.Value_mothers_day:
                return "mothers_day";
            case TypeValueKnownValues.Value_memorial_day:
                return "memorial_day";
            case TypeValueKnownValues.Value_fathers_day:
                return "fathers_day";
            case TypeValueKnownValues.Value_us_independence_day:
                return "us_independence_day";
            case TypeValueKnownValues.Value_us_labor_day:
                return "us_labor_day";
            case TypeValueKnownValues.Value_columbus_day:
                return "columbus_day";
            case TypeValueKnownValues.Value_halloween:
                return "halloween";
            case TypeValueKnownValues.Value_us_thanksgiving_day:
                return "us_thanksgiving_day";
            case TypeValueKnownValues.Value_us_thanksgiving_eve:
                return "us_thanksgiving_eve";
            case TypeValueKnownValues.Value_christmas_day:
                return "christmas_day";
            case TypeValueKnownValues.Value_christmas_eve:
                return "christmas_eve";
            case TypeValueKnownValues.Value_rosh_hashanah:
                return "rosh_hashanah";
            case TypeValueKnownValues.Value_yom_kippur:
                return "yom_kippur";
            case TypeValueKnownValues.Value_sukkot:
                return "sukkot";
            case TypeValueKnownValues.Value_hoshana_rabbah:
                return "hoshana_rabbah";
            case TypeValueKnownValues.Value_shemini_atzeret:
                return "shemini_atzeret";
            case TypeValueKnownValues.Value_simchat_torah:
                return "simchat_torah";
            case TypeValueKnownValues.Value_hanukkah:
                return "hanukkah";
            case TypeValueKnownValues.Value_tu_bishvat:
                return "tu_bishvat";
            case TypeValueKnownValues.Value_purim:
                return "purim";
            case TypeValueKnownValues.Value_passover:
                return "passover";
            case TypeValueKnownValues.Value_lag_baomer:
                return "lag_baomer";
            case TypeValueKnownValues.Value_shavuot:
                return "shavuot";
            case TypeValueKnownValues.Value_tisha_bav:
                return "tisha_bav";
            case TypeValueKnownValues.Value_good_friday:
                return "good_friday";
            case TypeValueKnownValues.Value_canada_day:
                return "canada_day";
            case TypeValueKnownValues.Value_us_flag_day:
                return "us_flag_day";
            case TypeValueKnownValues.Value_veterans_day:
                return "veterans_day";
            case TypeValueKnownValues.Value_april_fools_day:
                return "april_fools_day";
            case TypeValueKnownValues.Value_boxing_day:
                return "boxing_day";
            case TypeValueKnownValues.Value_black_friday:
                return "black_friday";
            case TypeValueKnownValues.Value_lent:
                return "lent";
            case TypeValueKnownValues.Value_shrove_tuesday:
                return "shrove_tuesday";
            case TypeValueKnownValues.Value_mardi_gras:
                return "mardi_gras";
            case TypeValueKnownValues.Value_ash_wednesday:
                return "ash_wednesday";
            case TypeValueKnownValues.Value_palm_sunday:
                return "palm_sunday";
            case TypeValueKnownValues.Value_holy_thursday:
                return "holy_thursday";
            case TypeValueKnownValues.Value_all_saints_day:
                return "all_saints_day";
            case TypeValueKnownValues.Value_all_souls_day:
                return "all_souls_day";
            case TypeValueKnownValues.Value_festivus:
                return "festivus";
            case TypeValueKnownValues.Value_washingtons_birthday:
                return "washingtons_birthday";
            case TypeValueKnownValues.Value_saint_patricks_day:
                return "saint_patricks_day";
            case TypeValueKnownValues.Value_cesar_chavez_day:
                return "cesar_chavez_day";
            case TypeValueKnownValues.Value_earth_day:
                return "earth_day";
            case TypeValueKnownValues.Value_cinco_de_mayo:
                return "cinco_de_mayo";
            case TypeValueKnownValues.Value_spring_equinox:
                return "spring_equinox";
            case TypeValueKnownValues.Value_summer_solstice:
                return "summer_solstice";
            case TypeValueKnownValues.Value_fall_equinox:
                return "fall_equinox";
            case TypeValueKnownValues.Value_winter_solstice:
                return "winter_solstice";
            case TypeValueKnownValues.Value_remembrance_day:
                return "remembrance_day";
            case TypeValueKnownValues.Value_kwanzaa:
                return "kwanzaa";
            case TypeValueKnownValues.Value_groundhog_day:
                return "groundhog_day";
            case TypeValueKnownValues.Value_jp_coming_of_age_day:
                return "jp_coming_of_age_day";
            case TypeValueKnownValues.Value_jp_national_foundation_day:
                return "jp_national_foundation_day";
            case TypeValueKnownValues.Value_jp_vernal_equinox_day:
                return "jp_vernal_equinox_day";
            case TypeValueKnownValues.Value_jp_showa_day:
                return "jp_showa_day";
            case TypeValueKnownValues.Value_jp_constitution_memorial_day:
                return "jp_constitution_memorial_day";
            case TypeValueKnownValues.Value_jp_greenery_day:
                return "jp_greenery_day";
            case TypeValueKnownValues.Value_jp_childrens_day:
                return "jp_childrens_day";
            case TypeValueKnownValues.Value_jp_golden_week:
                return "jp_golden_week";
            case TypeValueKnownValues.Value_jp_marine_day:
                return "jp_marine_day";
            case TypeValueKnownValues.Value_jp_mountain_day:
                return "jp_mountain_day";
            case TypeValueKnownValues.Value_jp_respect_for_the_aged_day:
                return "jp_respect_for_the_aged_day";
            case TypeValueKnownValues.Value_jp_autumnal_equinox_day:
                return "jp_autumnal_equinox_day";
            case TypeValueKnownValues.Value_jp_health_and_sports_day:
                return "jp_health_and_sports_day";
            case TypeValueKnownValues.Value_jp_culture_day:
                return "jp_culture_day";
            case TypeValueKnownValues.Value_jp_labour_thanksgiving_day:
                return "jp_labour_thanksgiving_day";
            case TypeValueKnownValues.Value_jp_the_emperors_birthday:
                return "jp_the_emperors_birthday";
            case TypeValueKnownValues.Value_jp_transfer_holiday:
                return "jp_transfer_holiday";
            case TypeValueKnownValues.Value_jp_citizens_holiday:
                return "jp_citizens_holiday";
            case TypeValueKnownValues.Value_gandhi_jayanti:
                return "gandhi_jayanti";
            case TypeValueKnownValues.Value_republic_day_of_india:
                return "republic_day_of_india";
            case TypeValueKnownValues.Value_indian_independence_day:
                return "indian_independence_day";
            case TypeValueKnownValues.Value_ambedkar_jayanti:
                return "ambedkar_jayanti";
            case TypeValueKnownValues.Value_rabindra_jayanti:
                return "rabindra_jayanti";
            case TypeValueKnownValues.Value_cheti_chand:
                return "cheti_chand";
            case TypeValueKnownValues.Value_onam:
                return "onam";
            case TypeValueKnownValues.Value_thiruvonam:
                return "thiruvonam";
            case TypeValueKnownValues.Value_magh_bihu:
                return "magh_bihu";
            case TypeValueKnownValues.Value_lohri_maghi_or_bhogi:
                return "lohri_maghi_or_bhogi";
            case TypeValueKnownValues.Value_labor_day_in_india:
                return "labor_day_in_india";
            case TypeValueKnownValues.Value_flag_day_of_india:
                return "flag_day_of_india";
            case TypeValueKnownValues.Value_mesadi:
                return "mesadi";
            case TypeValueKnownValues.Value_vaisakhadi:
                return "vaisakhadi";
            case TypeValueKnownValues.Value_vishu:
                return "vishu";
            case TypeValueKnownValues.Value_bohag_bihu:
                return "bohag_bihu";
            case TypeValueKnownValues.Value_ugadi:
                return "ugadi";
            case TypeValueKnownValues.Value_puthandu:
                return "puthandu";
            case TypeValueKnownValues.Value_pohela_boishakh:
                return "pohela_boishakh";
            case TypeValueKnownValues.Value_muharram:
                return "muharram";
            case TypeValueKnownValues.Value_day_of_ashura:
                return "day_of_ashura";
            case TypeValueKnownValues.Value_milad_un_nabi:
                return "milad_un_nabi";
            case TypeValueKnownValues.Value_ramadan:
                return "ramadan";
            case TypeValueKnownValues.Value_eid_al_adha:
                return "eid_al_adha";
            case TypeValueKnownValues.Value_eid_al_fitr:
                return "eid_al_fitr";
            case TypeValueKnownValues.Value_eid:
                return "eid";
            case TypeValueKnownValues.Value_jumuatul_wida:
                return "jumuatul_wida";
            case TypeValueKnownValues.Value_day_of_arafah:
                return "day_of_arafah";
            case TypeValueKnownValues.Value_birthday_of_ali_ibn_abi_talib:
                return "birthday_of_ali_ibn_abi_talib";
            case TypeValueKnownValues.Value_pentecost:
                return "pentecost";
            case TypeValueKnownValues.Value_pentecost_monday:
                return "pentecost_monday";
            case TypeValueKnownValues.Value_may_day:
                return "may_day";
            case TypeValueKnownValues.Value_international_womens_day:
                return "international_womens_day";
            case TypeValueKnownValues.Value_cn_spring_festival_eve:
                return "cn_spring_festival_eve";
            case TypeValueKnownValues.Value_cn_spring_festival:
                return "cn_spring_festival";
            case TypeValueKnownValues.Value_cn_lantern_festival:
                return "cn_lantern_festival";
            case TypeValueKnownValues.Value_cn_qingming_festival:
                return "cn_qingming_festival";
            case TypeValueKnownValues.Value_cn_youth_day:
                return "cn_youth_day";
            case TypeValueKnownValues.Value_cn_dragon_boat_festival:
                return "cn_dragon_boat_festival";
            case TypeValueKnownValues.Value_cn_childrens_day:
                return "cn_childrens_day";
            case TypeValueKnownValues.Value_cn_cpc_founding_day:
                return "cn_cpc_founding_day";
            case TypeValueKnownValues.Value_cn_pla_founding_day:
                return "cn_pla_founding_day";
            case TypeValueKnownValues.Value_cn_qixi_festival:
                return "cn_qixi_festival";
            case TypeValueKnownValues.Value_cn_mid_autumn_festival:
                return "cn_mid_autumn_festival";
            case TypeValueKnownValues.Value_cn_national_day:
                return "cn_national_day";
            case TypeValueKnownValues.Value_cn_chong_yang_festival:
                return "cn_chong_yang_festival";
            case TypeValueKnownValues.Value_holika_dahan:
                return "holika_dahan";
            case TypeValueKnownValues.Value_dol_yatra:
                return "dol_yatra";
            case TypeValueKnownValues.Value_holi:
                return "holi";
            case TypeValueKnownValues.Value_dussehra:
                return "dussehra";
            case TypeValueKnownValues.Value_bijoy_doshomi:
                return "bijoy_doshomi";
            case TypeValueKnownValues.Value_durga_puja:
                return "durga_puja";
            case TypeValueKnownValues.Value_diwali:
                return "diwali";
            case TypeValueKnownValues.Value_kali_puja:
                return "kali_puja";
            case TypeValueKnownValues.Value_dhanteras:
                return "dhanteras";
            case TypeValueKnownValues.Value_kali_chaudas:
                return "kali_chaudas";
            case TypeValueKnownValues.Value_naraka_chaturdashi:
                return "naraka_chaturdashi";
            case TypeValueKnownValues.Value_lakshmi_puja:
                return "lakshmi_puja";
            case TypeValueKnownValues.Value_bali_pratipada:
                return "bali_pratipada";
            case TypeValueKnownValues.Value_goverdhan_puja:
                return "goverdhan_puja";
            case TypeValueKnownValues.Value_bhai_dooj:
                return "bhai_dooj";
            case TypeValueKnownValues.Value_ram_navami:
                return "ram_navami";
            case TypeValueKnownValues.Value_ganesh_chaturthi:
                return "ganesh_chaturthi";
            case TypeValueKnownValues.Value_janmashtami:
                return "janmashtami";
            case TypeValueKnownValues.Value_nag_panchami:
                return "nag_panchami";
            case TypeValueKnownValues.Value_makar_sankranti:
                return "makar_sankranti";
            case TypeValueKnownValues.Value_pongal:
                return "pongal";
            case TypeValueKnownValues.Value_raksha_bandhan:
                return "raksha_bandhan";
            case TypeValueKnownValues.Value_basant_panchami:
                return "basant_panchami";
            case TypeValueKnownValues.Value_saraswati_puja:
                return "saraswati_puja";
            case TypeValueKnownValues.Value_rath_yatra:
                return "rath_yatra";
            case TypeValueKnownValues.Value_navaratri:
                return "navaratri";
            case TypeValueKnownValues.Value_maha_saptami:
                return "maha_saptami";
            case TypeValueKnownValues.Value_maha_ashtami:
                return "maha_ashtami";
            case TypeValueKnownValues.Value_maha_navami:
                return "maha_navami";
            case TypeValueKnownValues.Value_maha_shivaratri:
                return "maha_shivaratri";
            case TypeValueKnownValues.Value_anant_chaturdashi:
                return "anant_chaturdashi";
            case TypeValueKnownValues.Value_shivaji_jayanti:
                return "shivaji_jayanti";
            case TypeValueKnownValues.Value_valmiki_jayanti:
                return "valmiki_jayanti";
            case TypeValueKnownValues.Value_chhat_puja:
                return "chhat_puja";
            case TypeValueKnownValues.Value_dayanand_saraswati_jayanti:
                return "dayanand_saraswati_jayanti";
            case TypeValueKnownValues.Value_karwa_chauth:
                return "karwa_chauth";
            case TypeValueKnownValues.Value_vaisakhi:
                return "vaisakhi";
            case TypeValueKnownValues.Value_guru_nanak_gurpurab:
                return "guru_nanak_gurpurab";
            case TypeValueKnownValues.Value_guru_gobind_singh_gurpurab:
                return "guru_gobind_singh_gurpurab";
            case TypeValueKnownValues.Value_guru_teg_bahadur_shahid_diwas:
                return "guru_teg_bahadur_shahid_diwas";
            case TypeValueKnownValues.Value_mahavir_jayanti:
                return "mahavir_jayanti";
            case TypeValueKnownValues.Value_paryushan:
                return "paryushan";
            case TypeValueKnownValues.Value_vesak_or_buddha_purnima:
                return "vesak_or_buddha_purnima";
            case TypeValueKnownValues.Value_hanamatsuri:
                return "hanamatsuri";
            case TypeValueKnownValues.Value_sa_ga_dawa:
                return "sa_ga_dawa";
            case TypeValueKnownValues.Value_ravidass_jayanti:
                return "ravidass_jayanti";
            case TypeValueKnownValues.Value_bodhi_day:
                return "bodhi_day";
            case TypeValueKnownValues.Value_rohatsu:
                return "rohatsu";
            case TypeValueKnownValues.Value_asalha_puja:
                return "asalha_puja";
            case TypeValueKnownValues.Value_loy_krathong:
                return "loy_krathong";
            case TypeValueKnownValues.Value_nowruz:
                return "nowruz";
            case TypeValueKnownValues.Value_nowruz_in_india:
                return "nowruz_in_india";
            case TypeValueKnownValues.Value_ca_family_day:
                return "ca_family_day";
            case TypeValueKnownValues.Value_ca_thanksgiving_day:
                return "ca_thanksgiving_day";
            case TypeValueKnownValues.Value_ca_thanksgiving_eve:
                return "ca_thanksgiving_eve";
            case TypeValueKnownValues.Value_united_nations_day:
                return "united_nations_day";
            case TypeValueKnownValues.Value_epiphany:
                return "epiphany";
            case TypeValueKnownValues.Value_ascension_day:
                return "ascension_day";
            case TypeValueKnownValues.Value_advent_1st:
                return "advent_1st";
            case TypeValueKnownValues.Value_advent_2nd:
                return "advent_2nd";
            case TypeValueKnownValues.Value_advent_3rd:
                return "advent_3rd";
            case TypeValueKnownValues.Value_advent_4th:
                return "advent_4th";
            case TypeValueKnownValues.Value_saint_knuts_day:
                return "saint_knuts_day";
            case TypeValueKnownValues.Value_saint_lucys_day:
                return "saint_lucys_day";
            case TypeValueKnownValues.Value_midsummer_eve:
                return "midsummer_eve";
            case TypeValueKnownValues.Value_waffle_day:
                return "waffle_day";
            case TypeValueKnownValues.Value_walpurgis_night:
                return "walpurgis_night";
            case TypeValueKnownValues.Value_se_national_day:
                return "se_national_day";
            case TypeValueKnownValues.Value_se_fathers_day:
                return "se_fathers_day";
            case TypeValueKnownValues.Value_se_mothers_day:
                return "se_mothers_day";
            case TypeValueKnownValues.Value_nobels_day:
                return "nobels_day";
            case TypeValueKnownValues.Value_juneteenth:
                return "juneteenth";
            case TypeValueKnownValues.Value_fat_thursday:
                return "fat_thursday";
            case TypeValueKnownValues.Value_shrove_monday:
                return "shrove_monday";
            case TypeValueKnownValues.Value_de_fathers_day:
                return "de_fathers_day";
            case TypeValueKnownValues.Value_feast_of_corpus_christi:
                return "feast_of_corpus_christi";
            case TypeValueKnownValues.Value_assumption_of_mary:
                return "assumption_of_mary";
            case TypeValueKnownValues.Value_reformation_day:
                return "reformation_day";
            case TypeValueKnownValues.Value_augsburg_peace_festival:
                return "augsburg_peace_festival";
            case TypeValueKnownValues.Value_de_childrens_day:
                return "de_childrens_day";
            case TypeValueKnownValues.Value_de_unity_day:
                return "de_unity_day";
            case TypeValueKnownValues.Value_de_harvest_festival:
                return "de_harvest_festival";
            case TypeValueKnownValues.Value_saint_martins_day:
                return "saint_martins_day";
            case TypeValueKnownValues.Value_de_peoples_day_of_mourning:
                return "de_peoples_day_of_mourning";
            case TypeValueKnownValues.Value_day_of_repentance_and_prayer:
                return "day_of_repentance_and_prayer";
            case TypeValueKnownValues.Value_sunday_of_the_dead:
                return "sunday_of_the_dead";
            case TypeValueKnownValues.Value_saint_nicholas_day:
                return "saint_nicholas_day";
            case TypeValueKnownValues.Value_immaculate_conception:
                return "immaculate_conception";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of HolidayJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'a':
                switch (json_string.getData()[1])
                  {
                    case 'd':
                        if (String.Compare(json_string.getData(), 2, "vent_", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case '1':
                                    if ((String.Compare(json_string.getData(), 8, "st", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_advent_1st;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '2':
                                    if ((String.Compare(json_string.getData(), 8, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_advent_2nd;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '3':
                                    if ((String.Compare(json_string.getData(), 8, "rd", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_advent_3rd;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case '4':
                                    if ((String.Compare(json_string.getData(), 8, "th", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_advent_4th;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if (String.Compare(json_string.getData(), 2, "l_s", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 6, "ints_day", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_all_saints_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 6, "uls_day", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_all_souls_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "bedkar_jayanti", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ambedkar_jayanti;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ant_chaturdashi", 0, 15, false) == 0) && (json_string.getData().Length == 17))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_anant_chaturdashi;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "ril_fools_day", 0, 13, false) == 0) && (json_string.getData().Length == 15))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_april_fools_day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 's':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "lha_puja", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_asalha_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'c':
                                if ((String.Compare(json_string.getData(), 3, "ension_day", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_ascension_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "_wednesday", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_ash_wednesday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "umption_of_mary", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_assumption_of_mary;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "gsburg_peace_festival", 0, 21, false) == 0) && (json_string.getData().Length == 23))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_augsburg_peace_festival;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'b':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "i_pratipada", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_bali_pratipada;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "ant_panchami", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_basant_panchami;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "ai_dooj", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_bhai_dooj;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'j':
                                if ((String.Compare(json_string.getData(), 3, "oy_doshomi", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_bijoy_doshomi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "thday_of_ali_ibn_abi_talib", 0, 26, false) == 0) && (json_string.getData().Length == 29))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_birthday_of_ali_ibn_abi_talib;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ack_friday", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_black_friday;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "hi_day", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_bodhi_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "ag_bihu", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_bohag_bihu;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'x':
                                if ((String.Compare(json_string.getData(), 3, "ing_day", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_boxing_day;
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
                break;
            case 'c':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case '_':
                                switch (json_string.getData()[3])
                                  {
                                    case 'f':
                                        if ((String.Compare(json_string.getData(), 4, "amily_day", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ca_family_day;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 't':
                                        if (String.Compare(json_string.getData(), 4, "hanksgiving_", 0, 12, false) == 0)
                                          {
                                            switch (json_string.getData()[16])
                                              {
                                                case 'd':
                                                    if ((String.Compare(json_string.getData(), 17, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 19))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ca_thanksgiving_day;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'e':
                                                    if ((String.Compare(json_string.getData(), 17, "ve", 0, 2, false) == 0) && (json_string.getData().Length == 19))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ca_thanksgiving_eve;
                                                            goto open_enum_is_done;
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
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "ada_day", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_canada_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "sar_chavez_day", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_cesar_chavez_day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        switch (json_string.getData()[2])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "ti_chand", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_cheti_chand;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "at_puja", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_chhat_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if (String.Compare(json_string.getData(), 3, "istmas_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'd':
                                            if ((String.Compare(json_string.getData(), 11, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_christmas_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'e':
                                            if ((String.Compare(json_string.getData(), 11, "ve", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_christmas_eve;
                                                    goto open_enum_is_done;
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
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nco_de_mayo", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_cinco_de_mayo;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if (String.Compare(json_string.getData(), 2, "_", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'c':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'h':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'i':
                                                    if ((String.Compare(json_string.getData(), 6, "ldrens_day", 0, 10, false) == 0) && (json_string.getData().Length == 16))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_childrens_day;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 6, "ng_yang_festival", 0, 16, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_chong_yang_festival;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'p':
                                            if ((String.Compare(json_string.getData(), 5, "c_founding_day", 0, 14, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_cn_cpc_founding_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 4, "ragon_boat_festival", 0, 19, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_dragon_boat_festival;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 4, "antern_festival", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_lantern_festival;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 4, "id_autumn_festival", 0, 18, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_mid_autumn_festival;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 4, "ational_day", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_national_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if ((String.Compare(json_string.getData(), 4, "la_founding_day", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_pla_founding_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'q':
                                    if (String.Compare(json_string.getData(), 4, "i", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[5])
                                          {
                                            case 'n':
                                                if ((String.Compare(json_string.getData(), 6, "gming_festival", 0, 14, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_cn_qingming_festival;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'x':
                                                if ((String.Compare(json_string.getData(), 6, "i_festival", 0, 10, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_cn_qixi_festival;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 's':
                                    if (String.Compare(json_string.getData(), 4, "pring_festival", 0, 14, false) == 0)
                                      {
                                        if (json_string.getData().Length == 18)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_cn_spring_festival;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[18])
                                          {
                                            case '_':
                                                if ((String.Compare(json_string.getData(), 19, "eve", 0, 3, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_cn_spring_festival_eve;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'y':
                                    if ((String.Compare(json_string.getData(), 4, "outh_day", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_cn_youth_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "lumbus_day", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_columbus_day;
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
                    case 'a':
                        if (String.Compare(json_string.getData(), 2, "y", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case '_':
                                    if (String.Compare(json_string.getData(), 4, "of_", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[7])
                                          {
                                            case 'a':
                                                switch (json_string.getData()[8])
                                                  {
                                                    case 'r':
                                                        if ((String.Compare(json_string.getData(), 9, "afah", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_day_of_arafah;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 's':
                                                        if ((String.Compare(json_string.getData(), 9, "hura", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_day_of_ashura;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'r':
                                                if ((String.Compare(json_string.getData(), 8, "epentance_and_prayer", 0, 20, false) == 0) && (json_string.getData().Length == 28))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_day_of_repentance_and_prayer;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 4, "nand_saraswati_jayanti", 0, 22, false) == 0) && (json_string.getData().Length == 26))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_dayanand_saraswati_jayanti;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "_", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'c':
                                    if ((String.Compare(json_string.getData(), 4, "hildrens_day", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_de_childrens_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 4, "athers_day", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_de_fathers_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 4, "arvest_festival", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_de_harvest_festival;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'p':
                                    if ((String.Compare(json_string.getData(), 4, "eoples_day_of_mourning", 0, 22, false) == 0) && (json_string.getData().Length == 26))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_de_peoples_day_of_mourning;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 4, "nity_day", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_de_unity_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "anteras", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_dhanteras;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "wali", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_diwali;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "l_yatra", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_dol_yatra;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "ga_puja", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_durga_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "sehra", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_dussehra;
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
                break;
            case 'e':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "th_day", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_earth_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if (String.Compare(json_string.getData(), 3, "ter", 0, 3, false) == 0)
                                  {
                                    if (json_string.getData().Length == 6)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_easter;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[6])
                                      {
                                        case '_':
                                            if ((String.Compare(json_string.getData(), 7, "monday", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_easter_monday;
                                                    goto open_enum_is_done;
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
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "d", 0, 1, false) == 0)
                          {
                            if (json_string.getData().Length == 3)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_eid;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[3])
                              {
                                case '_':
                                    if (String.Compare(json_string.getData(), 4, "al_", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[7])
                                          {
                                            case 'a':
                                                if ((String.Compare(json_string.getData(), 8, "dha", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_eid_al_adha;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'f':
                                                if ((String.Compare(json_string.getData(), 8, "itr", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_eid_al_fitr;
                                                        goto open_enum_is_done;
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
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "iphany", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_epiphany;
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
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "l_equinox", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_fall_equinox;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                switch (json_string.getData()[3])
                                  {
                                    case '_':
                                        if ((String.Compare(json_string.getData(), 4, "thursday", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_fat_thursday;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'h':
                                        if ((String.Compare(json_string.getData(), 4, "ers_day", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_fathers_day;
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
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "st_of_corpus_christi", 0, 20, false) == 0) && (json_string.getData().Length == 23))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_feast_of_corpus_christi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "tivus", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_festivus;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ag_day_of_india", 0, 15, false) == 0) && (json_string.getData().Length == 17))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_flag_day_of_india;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'g':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if (String.Compare(json_string.getData(), 2, "n", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 4, "hi_jayanti", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_gandhi_jayanti;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 4, "sh_chaturthi", 0, 12, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_ganesh_chaturthi;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'o':
                                if ((String.Compare(json_string.getData(), 3, "d_friday", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_good_friday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'v':
                                if ((String.Compare(json_string.getData(), 3, "erdhan_puja", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_goverdhan_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "oundhog_day", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_groundhog_day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 2, "ru_", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'g':
                                    if ((String.Compare(json_string.getData(), 6, "obind_singh_gurpurab", 0, 20, false) == 0) && (json_string.getData().Length == 26))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_guru_gobind_singh_gurpurab;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 6, "anak_gurpurab", 0, 13, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_guru_nanak_gurpurab;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 't':
                                    if ((String.Compare(json_string.getData(), 6, "eg_bahadur_shahid_diwas", 0, 23, false) == 0) && (json_string.getData().Length == 29))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_guru_teg_bahadur_shahid_diwas;
                                            goto open_enum_is_done;
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
            case 'h':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "loween", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_halloween;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                switch (json_string.getData()[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 4, "matsuri", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_hanamatsuri;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'u':
                                        if ((String.Compare(json_string.getData(), 4, "kkah", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_hanukkah;
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
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                switch (json_string.getData()[3])
                                  {
                                    case 'i':
                                        if (json_string.getData().Length == 4)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_holi;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[4])
                                          {
                                            case 'k':
                                                if ((String.Compare(json_string.getData(), 5, "a_dahan", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_holika_dahan;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'y':
                                        if ((String.Compare(json_string.getData(), 4, "_thursday", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_holy_thursday;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "hana_rabbah", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_hoshana_rabbah;
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
                break;
            case 'i':
                switch (json_string.getData()[1])
                  {
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "maculate_conception", 0, 19, false) == 0) && (json_string.getData().Length == 21))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_immaculate_conception;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "ian_independence_day", 0, 20, false) == 0) && (json_string.getData().Length == 23))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_indian_independence_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "ernational_womens_day", 0, 21, false) == 0) && (json_string.getData().Length == 24))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_international_womens_day;
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
                break;
            case 'j':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "nmashtami", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_janmashtami;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if (String.Compare(json_string.getData(), 2, "_", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 4, "utumnal_equinox_day", 0, 19, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_autumnal_equinox_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'c':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "ildrens_day", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_childrens_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'i':
                                            if ((String.Compare(json_string.getData(), 5, "tizens_holiday", 0, 14, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_citizens_holiday;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'm':
                                                    if ((String.Compare(json_string.getData(), 6, "ing_of_age_day", 0, 14, false) == 0) && (json_string.getData().Length == 20))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_coming_of_age_day;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'n':
                                                    if ((String.Compare(json_string.getData(), 6, "stitution_memorial_day", 0, 22, false) == 0) && (json_string.getData().Length == 28))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_constitution_memorial_day;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'u':
                                            if ((String.Compare(json_string.getData(), 5, "lture_day", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_culture_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'g':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 5, "lden_week", 0, 9, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_golden_week;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 5, "eenery_day", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_greenery_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'h':
                                    if ((String.Compare(json_string.getData(), 4, "ealth_and_sports_day", 0, 20, false) == 0) && (json_string.getData().Length == 24))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_health_and_sports_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 4, "abour_thanksgiving_day", 0, 22, false) == 0) && (json_string.getData().Length == 26))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_labour_thanksgiving_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 5, "rine_day", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_marine_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'o':
                                            if ((String.Compare(json_string.getData(), 5, "untain_day", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_mountain_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 4, "ational_foundation_day", 0, 22, false) == 0) && (json_string.getData().Length == 26))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_national_foundation_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'r':
                                    if ((String.Compare(json_string.getData(), 4, "espect_for_the_aged_day", 0, 23, false) == 0) && (json_string.getData().Length == 27))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_respect_for_the_aged_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if ((String.Compare(json_string.getData(), 4, "howa_day", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_showa_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 't':
                                    switch (json_string.getData()[4])
                                      {
                                        case 'h':
                                            if ((String.Compare(json_string.getData(), 5, "e_emperors_birthday", 0, 19, false) == 0) && (json_string.getData().Length == 24))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_the_emperors_birthday;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 5, "ansfer_holiday", 0, 14, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_jp_transfer_holiday;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'v':
                                    if ((String.Compare(json_string.getData(), 4, "ernal_equinox_day", 0, 17, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_jp_vernal_equinox_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        switch (json_string.getData()[2])
                          {
                            case 'm':
                                if ((String.Compare(json_string.getData(), 3, "uatul_wida", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_jumuatul_wida;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "eteenth", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_juneteenth;
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
                break;
            case 'k':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if (String.Compare(json_string.getData(), 3, "i_", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 'c':
                                            if ((String.Compare(json_string.getData(), 6, "haudas", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_kali_chaudas;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'p':
                                            if ((String.Compare(json_string.getData(), 6, "uja", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_kali_puja;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "wa_chauth", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_karwa_chauth;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'w':
                        if ((String.Compare(json_string.getData(), 2, "anzaa", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_kwanzaa;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "or_day_in_india", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_labor_day_in_india;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'g':
                                if ((String.Compare(json_string.getData(), 3, "_baomer", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_lag_baomer;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "shmi_puja", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_lakshmi_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nt", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_lent;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "ri_maghi_or_bhogi", 0, 17, false) == 0) && (json_string.getData().Length == 20))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_lohri_maghi_or_bhogi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'y':
                                if ((String.Compare(json_string.getData(), 3, "_krathong", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_loy_krathong;
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
                break;
            case 'm':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'g':
                                if ((String.Compare(json_string.getData(), 3, "h_bihu", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_magh_bihu;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'h':
                                if (String.Compare(json_string.getData(), 3, "a", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case '_':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'a':
                                                    if ((String.Compare(json_string.getData(), 6, "shtami", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_maha_ashtami;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'n':
                                                    if ((String.Compare(json_string.getData(), 6, "avami", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_maha_navami;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 's':
                                                    switch (json_string.getData()[6])
                                                      {
                                                        case 'a':
                                                            if ((String.Compare(json_string.getData(), 7, "ptami", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_maha_saptami;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'h':
                                                            if ((String.Compare(json_string.getData(), 7, "ivaratri", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeValueKnownValues.Value_maha_shivaratri;
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
                                            break;
                                        case 'v':
                                            if ((String.Compare(json_string.getData(), 5, "ir_jayanti", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_mahavir_jayanti;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "ar_sankranti", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_makar_sankranti;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                switch (json_string.getData()[3])
                                  {
                                    case 'd':
                                        if ((String.Compare(json_string.getData(), 4, "i_gras", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_mardi_gras;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 't':
                                        if ((String.Compare(json_string.getData(), 4, "in_luther_king_day", 0, 18, false) == 0) && (json_string.getData().Length == 22))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_martin_luther_king_day;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'y':
                                if ((String.Compare(json_string.getData(), 3, "_day", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_may_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'm':
                                if ((String.Compare(json_string.getData(), 3, "orial_day", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_memorial_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "adi", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_mesadi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "summer_eve", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_midsummer_eve;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "ad_un_nabi", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_milad_un_nabi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "thers_day", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_mothers_day;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "harram", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_muharram;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'n':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'g':
                                if ((String.Compare(json_string.getData(), 3, "_panchami", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_nag_panchami;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "aka_chaturdashi", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_naraka_chaturdashi;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'v':
                                if ((String.Compare(json_string.getData(), 3, "aratri", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_navaratri;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "w_years_", 0, 8, false) == 0)
                          {
                            switch (json_string.getData()[10])
                              {
                                case 'd':
                                    if ((String.Compare(json_string.getData(), 11, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_new_years_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 11, "ve", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_new_years_eve;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "els_day", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_nobels_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'w':
                                if (String.Compare(json_string.getData(), 3, "ruz", 0, 3, false) == 0)
                                  {
                                    if (json_string.getData().Length == 6)
                                      {
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_nowruz;
                                            goto open_enum_is_done;
                                          }
                                      }
                                    switch (json_string.getData()[6])
                                      {
                                        case '_':
                                            if ((String.Compare(json_string.getData(), 7, "in_india", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_nowruz_in_india;
                                                    goto open_enum_is_done;
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
                    default:
                        break;
                  }
                break;
            case 'o':
                if ((String.Compare(json_string.getData(), 1, "nam", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_onam;
                        goto open_enum_is_done;
                      }
                break;
            case 'p':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "m_sunday", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_palm_sunday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "yushan", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_paryushan;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "sover", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_passover;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "ntecost", 0, 7, false) == 0)
                          {
                            if (json_string.getData().Length == 9)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_pentecost;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[9])
                              {
                                case '_':
                                    if ((String.Compare(json_string.getData(), 10, "monday", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_pentecost_monday;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "ela_boishakh", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_pohela_boishakh;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "gal", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_pongal;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "im", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_purim;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "handu", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_puthandu;
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
                break;
            case 'r':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'b':
                                if ((String.Compare(json_string.getData(), 3, "indra_jayanti", 0, 13, false) == 0) && (json_string.getData().Length == 16))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_rabindra_jayanti;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "sha_bandhan", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_raksha_bandhan;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'm':
                                switch (json_string.getData()[3])
                                  {
                                    case '_':
                                        if ((String.Compare(json_string.getData(), 4, "navami", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ram_navami;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'a':
                                        if ((String.Compare(json_string.getData(), 4, "dan", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ramadan;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "h_yatra", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_rath_yatra;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'v':
                                if ((String.Compare(json_string.getData(), 3, "idass_jayanti", 0, 13, false) == 0) && (json_string.getData().Length == 16))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_ravidass_jayanti;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'f':
                                if ((String.Compare(json_string.getData(), 3, "ormation_day", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_reformation_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'm':
                                if ((String.Compare(json_string.getData(), 3, "embrance_day", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_remembrance_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'p':
                                if ((String.Compare(json_string.getData(), 3, "ublic_day_of_india", 0, 18, false) == 0) && (json_string.getData().Length == 21))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_republic_day_of_india;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'h':
                                if ((String.Compare(json_string.getData(), 3, "atsu", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_rohatsu;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "h_hashanah", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_rosh_hashanah;
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
                break;
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case '_':
                                if ((String.Compare(json_string.getData(), 3, "ga_dawa", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_sa_ga_dawa;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'i':
                                if (String.Compare(json_string.getData(), 3, "nt_", 0, 3, false) == 0)
                                  {
                                    switch (json_string.getData()[6])
                                      {
                                        case 'k':
                                            if ((String.Compare(json_string.getData(), 7, "nuts_day", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_saint_knuts_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'l':
                                            if ((String.Compare(json_string.getData(), 7, "ucys_day", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_saint_lucys_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 7, "artins_day", 0, 10, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_saint_martins_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'n':
                                            if ((String.Compare(json_string.getData(), 7, "icholas_day", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_saint_nicholas_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'p':
                                            if ((String.Compare(json_string.getData(), 7, "atricks_day", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_saint_patricks_day;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "aswati_puja", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_saraswati_puja;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "_", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 4, "athers_day", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_se_fathers_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'm':
                                    if ((String.Compare(json_string.getData(), 4, "others_day", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_se_mothers_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'n':
                                    if ((String.Compare(json_string.getData(), 4, "ational_day", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_se_national_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'h':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "vuot", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_shavuot;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "mini_atzeret", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_shemini_atzeret;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'i':
                                if ((String.Compare(json_string.getData(), 3, "vaji_jayanti", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_shivaji_jayanti;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if (String.Compare(json_string.getData(), 3, "ove_", 0, 4, false) == 0)
                                  {
                                    switch (json_string.getData()[7])
                                      {
                                        case 'm':
                                            if ((String.Compare(json_string.getData(), 8, "onday", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_shrove_monday;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 't':
                                            if ((String.Compare(json_string.getData(), 8, "uesday", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_shrove_tuesday;
                                                    goto open_enum_is_done;
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
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "mchat_torah", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_simchat_torah;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "ring_equinox", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_spring_equinox;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        switch (json_string.getData()[2])
                          {
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "kot", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_sukkot;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'm':
                                if ((String.Compare(json_string.getData(), 3, "mer_solstice", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_summer_solstice;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "day_of_the_dead", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_sunday_of_the_dead;
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
                break;
            case 't':
                switch (json_string.getData()[1])
                  {
                    case 'h':
                        if ((String.Compare(json_string.getData(), 2, "iruvonam", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_thiruvonam;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "sha_bav", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_tisha_bav;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "_bishvat", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_tu_bishvat;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'u':
                switch (json_string.getData()[1])
                  {
                    case 'g':
                        if ((String.Compare(json_string.getData(), 2, "adi", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ugadi;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        switch (json_string.getData()[2])
                          {
                            case 'i':
                                if ((String.Compare(json_string.getData(), 3, "ted_nations_day", 0, 15, false) == 0) && (json_string.getData().Length == 18))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_united_nations_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "nown", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_unknown;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 's':
                        if (String.Compare(json_string.getData(), 2, "_", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'f':
                                    if ((String.Compare(json_string.getData(), 4, "lag_day", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_us_flag_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 4, "ndependence_day", 0, 15, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_us_independence_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 4, "abor_day", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_us_labor_day;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 't':
                                    if (String.Compare(json_string.getData(), 4, "hanksgiving_", 0, 12, false) == 0)
                                      {
                                        switch (json_string.getData()[16])
                                          {
                                            case 'd':
                                                if ((String.Compare(json_string.getData(), 17, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_us_thanksgiving_day;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'e':
                                                if ((String.Compare(json_string.getData(), 17, "ve", 0, 2, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_us_thanksgiving_eve;
                                                        goto open_enum_is_done;
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
                        break;
                    default:
                        break;
                  }
                break;
            case 'v':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'i':
                                if (String.Compare(json_string.getData(), 3, "sakh", 0, 4, false) == 0)
                                  {
                                    switch (json_string.getData()[7])
                                      {
                                        case 'a':
                                            if ((String.Compare(json_string.getData(), 8, "di", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_vaisakhadi;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'i':
                                            if (json_string.getData().Length == 8)
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_vaisakhi;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'l':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(json_string.getData(), 4, "ntines_day", 0, 10, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_valentines_day;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 4, "iki_jayanti", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_valmiki_jayanti;
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
                        break;
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "ak_or_buddha_purnima", 0, 20, false) == 0) && (json_string.getData().Length == 23))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_vesak_or_buddha_purnima;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "erans_day", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_veterans_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "shu", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_vishu;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'w':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'f':
                                if ((String.Compare(json_string.getData(), 3, "fle_day", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_waffle_day;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'l':
                                if ((String.Compare(json_string.getData(), 3, "purgis_night", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_walpurgis_night;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if ((String.Compare(json_string.getData(), 3, "hingtons_birthday", 0, 17, false) == 0) && (json_string.getData().Length == 20))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_washingtons_birthday;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nter_solstice", 0, 13, false) == 0) && (json_string.getData().Length == 15))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_winter_solstice;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "om_kippur", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_yom_kippur;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public HolidayJSON()
      {
        flagHasValue = false;
      }

    public HolidayJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public HolidayJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public HolidayJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
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

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeValueKnownValues.Value_new_years_day:
                    handler.string_value("new_years_day");
                    break;
                case TypeValueKnownValues.Value_new_years_eve:
                    handler.string_value("new_years_eve");
                    break;
                case TypeValueKnownValues.Value_valentines_day:
                    handler.string_value("valentines_day");
                    break;
                case TypeValueKnownValues.Value_martin_luther_king_day:
                    handler.string_value("martin_luther_king_day");
                    break;
                case TypeValueKnownValues.Value_easter:
                    handler.string_value("easter");
                    break;
                case TypeValueKnownValues.Value_easter_monday:
                    handler.string_value("easter_monday");
                    break;
                case TypeValueKnownValues.Value_mothers_day:
                    handler.string_value("mothers_day");
                    break;
                case TypeValueKnownValues.Value_memorial_day:
                    handler.string_value("memorial_day");
                    break;
                case TypeValueKnownValues.Value_fathers_day:
                    handler.string_value("fathers_day");
                    break;
                case TypeValueKnownValues.Value_us_independence_day:
                    handler.string_value("us_independence_day");
                    break;
                case TypeValueKnownValues.Value_us_labor_day:
                    handler.string_value("us_labor_day");
                    break;
                case TypeValueKnownValues.Value_columbus_day:
                    handler.string_value("columbus_day");
                    break;
                case TypeValueKnownValues.Value_halloween:
                    handler.string_value("halloween");
                    break;
                case TypeValueKnownValues.Value_us_thanksgiving_day:
                    handler.string_value("us_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_us_thanksgiving_eve:
                    handler.string_value("us_thanksgiving_eve");
                    break;
                case TypeValueKnownValues.Value_christmas_day:
                    handler.string_value("christmas_day");
                    break;
                case TypeValueKnownValues.Value_christmas_eve:
                    handler.string_value("christmas_eve");
                    break;
                case TypeValueKnownValues.Value_rosh_hashanah:
                    handler.string_value("rosh_hashanah");
                    break;
                case TypeValueKnownValues.Value_yom_kippur:
                    handler.string_value("yom_kippur");
                    break;
                case TypeValueKnownValues.Value_sukkot:
                    handler.string_value("sukkot");
                    break;
                case TypeValueKnownValues.Value_hoshana_rabbah:
                    handler.string_value("hoshana_rabbah");
                    break;
                case TypeValueKnownValues.Value_shemini_atzeret:
                    handler.string_value("shemini_atzeret");
                    break;
                case TypeValueKnownValues.Value_simchat_torah:
                    handler.string_value("simchat_torah");
                    break;
                case TypeValueKnownValues.Value_hanukkah:
                    handler.string_value("hanukkah");
                    break;
                case TypeValueKnownValues.Value_tu_bishvat:
                    handler.string_value("tu_bishvat");
                    break;
                case TypeValueKnownValues.Value_purim:
                    handler.string_value("purim");
                    break;
                case TypeValueKnownValues.Value_passover:
                    handler.string_value("passover");
                    break;
                case TypeValueKnownValues.Value_lag_baomer:
                    handler.string_value("lag_baomer");
                    break;
                case TypeValueKnownValues.Value_shavuot:
                    handler.string_value("shavuot");
                    break;
                case TypeValueKnownValues.Value_tisha_bav:
                    handler.string_value("tisha_bav");
                    break;
                case TypeValueKnownValues.Value_good_friday:
                    handler.string_value("good_friday");
                    break;
                case TypeValueKnownValues.Value_canada_day:
                    handler.string_value("canada_day");
                    break;
                case TypeValueKnownValues.Value_us_flag_day:
                    handler.string_value("us_flag_day");
                    break;
                case TypeValueKnownValues.Value_veterans_day:
                    handler.string_value("veterans_day");
                    break;
                case TypeValueKnownValues.Value_april_fools_day:
                    handler.string_value("april_fools_day");
                    break;
                case TypeValueKnownValues.Value_boxing_day:
                    handler.string_value("boxing_day");
                    break;
                case TypeValueKnownValues.Value_black_friday:
                    handler.string_value("black_friday");
                    break;
                case TypeValueKnownValues.Value_lent:
                    handler.string_value("lent");
                    break;
                case TypeValueKnownValues.Value_shrove_tuesday:
                    handler.string_value("shrove_tuesday");
                    break;
                case TypeValueKnownValues.Value_mardi_gras:
                    handler.string_value("mardi_gras");
                    break;
                case TypeValueKnownValues.Value_ash_wednesday:
                    handler.string_value("ash_wednesday");
                    break;
                case TypeValueKnownValues.Value_palm_sunday:
                    handler.string_value("palm_sunday");
                    break;
                case TypeValueKnownValues.Value_holy_thursday:
                    handler.string_value("holy_thursday");
                    break;
                case TypeValueKnownValues.Value_all_saints_day:
                    handler.string_value("all_saints_day");
                    break;
                case TypeValueKnownValues.Value_all_souls_day:
                    handler.string_value("all_souls_day");
                    break;
                case TypeValueKnownValues.Value_festivus:
                    handler.string_value("festivus");
                    break;
                case TypeValueKnownValues.Value_washingtons_birthday:
                    handler.string_value("washingtons_birthday");
                    break;
                case TypeValueKnownValues.Value_saint_patricks_day:
                    handler.string_value("saint_patricks_day");
                    break;
                case TypeValueKnownValues.Value_cesar_chavez_day:
                    handler.string_value("cesar_chavez_day");
                    break;
                case TypeValueKnownValues.Value_earth_day:
                    handler.string_value("earth_day");
                    break;
                case TypeValueKnownValues.Value_cinco_de_mayo:
                    handler.string_value("cinco_de_mayo");
                    break;
                case TypeValueKnownValues.Value_spring_equinox:
                    handler.string_value("spring_equinox");
                    break;
                case TypeValueKnownValues.Value_summer_solstice:
                    handler.string_value("summer_solstice");
                    break;
                case TypeValueKnownValues.Value_fall_equinox:
                    handler.string_value("fall_equinox");
                    break;
                case TypeValueKnownValues.Value_winter_solstice:
                    handler.string_value("winter_solstice");
                    break;
                case TypeValueKnownValues.Value_remembrance_day:
                    handler.string_value("remembrance_day");
                    break;
                case TypeValueKnownValues.Value_kwanzaa:
                    handler.string_value("kwanzaa");
                    break;
                case TypeValueKnownValues.Value_groundhog_day:
                    handler.string_value("groundhog_day");
                    break;
                case TypeValueKnownValues.Value_jp_coming_of_age_day:
                    handler.string_value("jp_coming_of_age_day");
                    break;
                case TypeValueKnownValues.Value_jp_national_foundation_day:
                    handler.string_value("jp_national_foundation_day");
                    break;
                case TypeValueKnownValues.Value_jp_vernal_equinox_day:
                    handler.string_value("jp_vernal_equinox_day");
                    break;
                case TypeValueKnownValues.Value_jp_showa_day:
                    handler.string_value("jp_showa_day");
                    break;
                case TypeValueKnownValues.Value_jp_constitution_memorial_day:
                    handler.string_value("jp_constitution_memorial_day");
                    break;
                case TypeValueKnownValues.Value_jp_greenery_day:
                    handler.string_value("jp_greenery_day");
                    break;
                case TypeValueKnownValues.Value_jp_childrens_day:
                    handler.string_value("jp_childrens_day");
                    break;
                case TypeValueKnownValues.Value_jp_golden_week:
                    handler.string_value("jp_golden_week");
                    break;
                case TypeValueKnownValues.Value_jp_marine_day:
                    handler.string_value("jp_marine_day");
                    break;
                case TypeValueKnownValues.Value_jp_mountain_day:
                    handler.string_value("jp_mountain_day");
                    break;
                case TypeValueKnownValues.Value_jp_respect_for_the_aged_day:
                    handler.string_value("jp_respect_for_the_aged_day");
                    break;
                case TypeValueKnownValues.Value_jp_autumnal_equinox_day:
                    handler.string_value("jp_autumnal_equinox_day");
                    break;
                case TypeValueKnownValues.Value_jp_health_and_sports_day:
                    handler.string_value("jp_health_and_sports_day");
                    break;
                case TypeValueKnownValues.Value_jp_culture_day:
                    handler.string_value("jp_culture_day");
                    break;
                case TypeValueKnownValues.Value_jp_labour_thanksgiving_day:
                    handler.string_value("jp_labour_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_jp_the_emperors_birthday:
                    handler.string_value("jp_the_emperors_birthday");
                    break;
                case TypeValueKnownValues.Value_jp_transfer_holiday:
                    handler.string_value("jp_transfer_holiday");
                    break;
                case TypeValueKnownValues.Value_jp_citizens_holiday:
                    handler.string_value("jp_citizens_holiday");
                    break;
                case TypeValueKnownValues.Value_gandhi_jayanti:
                    handler.string_value("gandhi_jayanti");
                    break;
                case TypeValueKnownValues.Value_republic_day_of_india:
                    handler.string_value("republic_day_of_india");
                    break;
                case TypeValueKnownValues.Value_indian_independence_day:
                    handler.string_value("indian_independence_day");
                    break;
                case TypeValueKnownValues.Value_ambedkar_jayanti:
                    handler.string_value("ambedkar_jayanti");
                    break;
                case TypeValueKnownValues.Value_rabindra_jayanti:
                    handler.string_value("rabindra_jayanti");
                    break;
                case TypeValueKnownValues.Value_cheti_chand:
                    handler.string_value("cheti_chand");
                    break;
                case TypeValueKnownValues.Value_onam:
                    handler.string_value("onam");
                    break;
                case TypeValueKnownValues.Value_thiruvonam:
                    handler.string_value("thiruvonam");
                    break;
                case TypeValueKnownValues.Value_magh_bihu:
                    handler.string_value("magh_bihu");
                    break;
                case TypeValueKnownValues.Value_lohri_maghi_or_bhogi:
                    handler.string_value("lohri_maghi_or_bhogi");
                    break;
                case TypeValueKnownValues.Value_labor_day_in_india:
                    handler.string_value("labor_day_in_india");
                    break;
                case TypeValueKnownValues.Value_flag_day_of_india:
                    handler.string_value("flag_day_of_india");
                    break;
                case TypeValueKnownValues.Value_mesadi:
                    handler.string_value("mesadi");
                    break;
                case TypeValueKnownValues.Value_vaisakhadi:
                    handler.string_value("vaisakhadi");
                    break;
                case TypeValueKnownValues.Value_vishu:
                    handler.string_value("vishu");
                    break;
                case TypeValueKnownValues.Value_bohag_bihu:
                    handler.string_value("bohag_bihu");
                    break;
                case TypeValueKnownValues.Value_ugadi:
                    handler.string_value("ugadi");
                    break;
                case TypeValueKnownValues.Value_puthandu:
                    handler.string_value("puthandu");
                    break;
                case TypeValueKnownValues.Value_pohela_boishakh:
                    handler.string_value("pohela_boishakh");
                    break;
                case TypeValueKnownValues.Value_muharram:
                    handler.string_value("muharram");
                    break;
                case TypeValueKnownValues.Value_day_of_ashura:
                    handler.string_value("day_of_ashura");
                    break;
                case TypeValueKnownValues.Value_milad_un_nabi:
                    handler.string_value("milad_un_nabi");
                    break;
                case TypeValueKnownValues.Value_ramadan:
                    handler.string_value("ramadan");
                    break;
                case TypeValueKnownValues.Value_eid_al_adha:
                    handler.string_value("eid_al_adha");
                    break;
                case TypeValueKnownValues.Value_eid_al_fitr:
                    handler.string_value("eid_al_fitr");
                    break;
                case TypeValueKnownValues.Value_eid:
                    handler.string_value("eid");
                    break;
                case TypeValueKnownValues.Value_jumuatul_wida:
                    handler.string_value("jumuatul_wida");
                    break;
                case TypeValueKnownValues.Value_day_of_arafah:
                    handler.string_value("day_of_arafah");
                    break;
                case TypeValueKnownValues.Value_birthday_of_ali_ibn_abi_talib:
                    handler.string_value("birthday_of_ali_ibn_abi_talib");
                    break;
                case TypeValueKnownValues.Value_pentecost:
                    handler.string_value("pentecost");
                    break;
                case TypeValueKnownValues.Value_pentecost_monday:
                    handler.string_value("pentecost_monday");
                    break;
                case TypeValueKnownValues.Value_may_day:
                    handler.string_value("may_day");
                    break;
                case TypeValueKnownValues.Value_international_womens_day:
                    handler.string_value("international_womens_day");
                    break;
                case TypeValueKnownValues.Value_cn_spring_festival_eve:
                    handler.string_value("cn_spring_festival_eve");
                    break;
                case TypeValueKnownValues.Value_cn_spring_festival:
                    handler.string_value("cn_spring_festival");
                    break;
                case TypeValueKnownValues.Value_cn_lantern_festival:
                    handler.string_value("cn_lantern_festival");
                    break;
                case TypeValueKnownValues.Value_cn_qingming_festival:
                    handler.string_value("cn_qingming_festival");
                    break;
                case TypeValueKnownValues.Value_cn_youth_day:
                    handler.string_value("cn_youth_day");
                    break;
                case TypeValueKnownValues.Value_cn_dragon_boat_festival:
                    handler.string_value("cn_dragon_boat_festival");
                    break;
                case TypeValueKnownValues.Value_cn_childrens_day:
                    handler.string_value("cn_childrens_day");
                    break;
                case TypeValueKnownValues.Value_cn_cpc_founding_day:
                    handler.string_value("cn_cpc_founding_day");
                    break;
                case TypeValueKnownValues.Value_cn_pla_founding_day:
                    handler.string_value("cn_pla_founding_day");
                    break;
                case TypeValueKnownValues.Value_cn_qixi_festival:
                    handler.string_value("cn_qixi_festival");
                    break;
                case TypeValueKnownValues.Value_cn_mid_autumn_festival:
                    handler.string_value("cn_mid_autumn_festival");
                    break;
                case TypeValueKnownValues.Value_cn_national_day:
                    handler.string_value("cn_national_day");
                    break;
                case TypeValueKnownValues.Value_cn_chong_yang_festival:
                    handler.string_value("cn_chong_yang_festival");
                    break;
                case TypeValueKnownValues.Value_holika_dahan:
                    handler.string_value("holika_dahan");
                    break;
                case TypeValueKnownValues.Value_dol_yatra:
                    handler.string_value("dol_yatra");
                    break;
                case TypeValueKnownValues.Value_holi:
                    handler.string_value("holi");
                    break;
                case TypeValueKnownValues.Value_dussehra:
                    handler.string_value("dussehra");
                    break;
                case TypeValueKnownValues.Value_bijoy_doshomi:
                    handler.string_value("bijoy_doshomi");
                    break;
                case TypeValueKnownValues.Value_durga_puja:
                    handler.string_value("durga_puja");
                    break;
                case TypeValueKnownValues.Value_diwali:
                    handler.string_value("diwali");
                    break;
                case TypeValueKnownValues.Value_kali_puja:
                    handler.string_value("kali_puja");
                    break;
                case TypeValueKnownValues.Value_dhanteras:
                    handler.string_value("dhanteras");
                    break;
                case TypeValueKnownValues.Value_kali_chaudas:
                    handler.string_value("kali_chaudas");
                    break;
                case TypeValueKnownValues.Value_naraka_chaturdashi:
                    handler.string_value("naraka_chaturdashi");
                    break;
                case TypeValueKnownValues.Value_lakshmi_puja:
                    handler.string_value("lakshmi_puja");
                    break;
                case TypeValueKnownValues.Value_bali_pratipada:
                    handler.string_value("bali_pratipada");
                    break;
                case TypeValueKnownValues.Value_goverdhan_puja:
                    handler.string_value("goverdhan_puja");
                    break;
                case TypeValueKnownValues.Value_bhai_dooj:
                    handler.string_value("bhai_dooj");
                    break;
                case TypeValueKnownValues.Value_ram_navami:
                    handler.string_value("ram_navami");
                    break;
                case TypeValueKnownValues.Value_ganesh_chaturthi:
                    handler.string_value("ganesh_chaturthi");
                    break;
                case TypeValueKnownValues.Value_janmashtami:
                    handler.string_value("janmashtami");
                    break;
                case TypeValueKnownValues.Value_nag_panchami:
                    handler.string_value("nag_panchami");
                    break;
                case TypeValueKnownValues.Value_makar_sankranti:
                    handler.string_value("makar_sankranti");
                    break;
                case TypeValueKnownValues.Value_pongal:
                    handler.string_value("pongal");
                    break;
                case TypeValueKnownValues.Value_raksha_bandhan:
                    handler.string_value("raksha_bandhan");
                    break;
                case TypeValueKnownValues.Value_basant_panchami:
                    handler.string_value("basant_panchami");
                    break;
                case TypeValueKnownValues.Value_saraswati_puja:
                    handler.string_value("saraswati_puja");
                    break;
                case TypeValueKnownValues.Value_rath_yatra:
                    handler.string_value("rath_yatra");
                    break;
                case TypeValueKnownValues.Value_navaratri:
                    handler.string_value("navaratri");
                    break;
                case TypeValueKnownValues.Value_maha_saptami:
                    handler.string_value("maha_saptami");
                    break;
                case TypeValueKnownValues.Value_maha_ashtami:
                    handler.string_value("maha_ashtami");
                    break;
                case TypeValueKnownValues.Value_maha_navami:
                    handler.string_value("maha_navami");
                    break;
                case TypeValueKnownValues.Value_maha_shivaratri:
                    handler.string_value("maha_shivaratri");
                    break;
                case TypeValueKnownValues.Value_anant_chaturdashi:
                    handler.string_value("anant_chaturdashi");
                    break;
                case TypeValueKnownValues.Value_shivaji_jayanti:
                    handler.string_value("shivaji_jayanti");
                    break;
                case TypeValueKnownValues.Value_valmiki_jayanti:
                    handler.string_value("valmiki_jayanti");
                    break;
                case TypeValueKnownValues.Value_chhat_puja:
                    handler.string_value("chhat_puja");
                    break;
                case TypeValueKnownValues.Value_dayanand_saraswati_jayanti:
                    handler.string_value("dayanand_saraswati_jayanti");
                    break;
                case TypeValueKnownValues.Value_karwa_chauth:
                    handler.string_value("karwa_chauth");
                    break;
                case TypeValueKnownValues.Value_vaisakhi:
                    handler.string_value("vaisakhi");
                    break;
                case TypeValueKnownValues.Value_guru_nanak_gurpurab:
                    handler.string_value("guru_nanak_gurpurab");
                    break;
                case TypeValueKnownValues.Value_guru_gobind_singh_gurpurab:
                    handler.string_value("guru_gobind_singh_gurpurab");
                    break;
                case TypeValueKnownValues.Value_guru_teg_bahadur_shahid_diwas:
                    handler.string_value("guru_teg_bahadur_shahid_diwas");
                    break;
                case TypeValueKnownValues.Value_mahavir_jayanti:
                    handler.string_value("mahavir_jayanti");
                    break;
                case TypeValueKnownValues.Value_paryushan:
                    handler.string_value("paryushan");
                    break;
                case TypeValueKnownValues.Value_vesak_or_buddha_purnima:
                    handler.string_value("vesak_or_buddha_purnima");
                    break;
                case TypeValueKnownValues.Value_hanamatsuri:
                    handler.string_value("hanamatsuri");
                    break;
                case TypeValueKnownValues.Value_sa_ga_dawa:
                    handler.string_value("sa_ga_dawa");
                    break;
                case TypeValueKnownValues.Value_ravidass_jayanti:
                    handler.string_value("ravidass_jayanti");
                    break;
                case TypeValueKnownValues.Value_bodhi_day:
                    handler.string_value("bodhi_day");
                    break;
                case TypeValueKnownValues.Value_rohatsu:
                    handler.string_value("rohatsu");
                    break;
                case TypeValueKnownValues.Value_asalha_puja:
                    handler.string_value("asalha_puja");
                    break;
                case TypeValueKnownValues.Value_loy_krathong:
                    handler.string_value("loy_krathong");
                    break;
                case TypeValueKnownValues.Value_nowruz:
                    handler.string_value("nowruz");
                    break;
                case TypeValueKnownValues.Value_nowruz_in_india:
                    handler.string_value("nowruz_in_india");
                    break;
                case TypeValueKnownValues.Value_ca_family_day:
                    handler.string_value("ca_family_day");
                    break;
                case TypeValueKnownValues.Value_ca_thanksgiving_day:
                    handler.string_value("ca_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_ca_thanksgiving_eve:
                    handler.string_value("ca_thanksgiving_eve");
                    break;
                case TypeValueKnownValues.Value_united_nations_day:
                    handler.string_value("united_nations_day");
                    break;
                case TypeValueKnownValues.Value_epiphany:
                    handler.string_value("epiphany");
                    break;
                case TypeValueKnownValues.Value_ascension_day:
                    handler.string_value("ascension_day");
                    break;
                case TypeValueKnownValues.Value_advent_1st:
                    handler.string_value("advent_1st");
                    break;
                case TypeValueKnownValues.Value_advent_2nd:
                    handler.string_value("advent_2nd");
                    break;
                case TypeValueKnownValues.Value_advent_3rd:
                    handler.string_value("advent_3rd");
                    break;
                case TypeValueKnownValues.Value_advent_4th:
                    handler.string_value("advent_4th");
                    break;
                case TypeValueKnownValues.Value_saint_knuts_day:
                    handler.string_value("saint_knuts_day");
                    break;
                case TypeValueKnownValues.Value_saint_lucys_day:
                    handler.string_value("saint_lucys_day");
                    break;
                case TypeValueKnownValues.Value_midsummer_eve:
                    handler.string_value("midsummer_eve");
                    break;
                case TypeValueKnownValues.Value_waffle_day:
                    handler.string_value("waffle_day");
                    break;
                case TypeValueKnownValues.Value_walpurgis_night:
                    handler.string_value("walpurgis_night");
                    break;
                case TypeValueKnownValues.Value_se_national_day:
                    handler.string_value("se_national_day");
                    break;
                case TypeValueKnownValues.Value_se_fathers_day:
                    handler.string_value("se_fathers_day");
                    break;
                case TypeValueKnownValues.Value_se_mothers_day:
                    handler.string_value("se_mothers_day");
                    break;
                case TypeValueKnownValues.Value_nobels_day:
                    handler.string_value("nobels_day");
                    break;
                case TypeValueKnownValues.Value_juneteenth:
                    handler.string_value("juneteenth");
                    break;
                case TypeValueKnownValues.Value_fat_thursday:
                    handler.string_value("fat_thursday");
                    break;
                case TypeValueKnownValues.Value_shrove_monday:
                    handler.string_value("shrove_monday");
                    break;
                case TypeValueKnownValues.Value_de_fathers_day:
                    handler.string_value("de_fathers_day");
                    break;
                case TypeValueKnownValues.Value_feast_of_corpus_christi:
                    handler.string_value("feast_of_corpus_christi");
                    break;
                case TypeValueKnownValues.Value_assumption_of_mary:
                    handler.string_value("assumption_of_mary");
                    break;
                case TypeValueKnownValues.Value_reformation_day:
                    handler.string_value("reformation_day");
                    break;
                case TypeValueKnownValues.Value_augsburg_peace_festival:
                    handler.string_value("augsburg_peace_festival");
                    break;
                case TypeValueKnownValues.Value_de_childrens_day:
                    handler.string_value("de_childrens_day");
                    break;
                case TypeValueKnownValues.Value_de_unity_day:
                    handler.string_value("de_unity_day");
                    break;
                case TypeValueKnownValues.Value_de_harvest_festival:
                    handler.string_value("de_harvest_festival");
                    break;
                case TypeValueKnownValues.Value_saint_martins_day:
                    handler.string_value("saint_martins_day");
                    break;
                case TypeValueKnownValues.Value_de_peoples_day_of_mourning:
                    handler.string_value("de_peoples_day_of_mourning");
                    break;
                case TypeValueKnownValues.Value_day_of_repentance_and_prayer:
                    handler.string_value("day_of_repentance_and_prayer");
                    break;
                case TypeValueKnownValues.Value_sunday_of_the_dead:
                    handler.string_value("sunday_of_the_dead");
                    break;
                case TypeValueKnownValues.Value_saint_nicholas_day:
                    handler.string_value("saint_nicholas_day");
                    break;
                case TypeValueKnownValues.Value_immaculate_conception:
                    handler.string_value("immaculate_conception");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeValueKnownValues.Value_new_years_day:
                    handler.string_value("new_years_day");
                    break;
                case TypeValueKnownValues.Value_new_years_eve:
                    handler.string_value("new_years_eve");
                    break;
                case TypeValueKnownValues.Value_valentines_day:
                    handler.string_value("valentines_day");
                    break;
                case TypeValueKnownValues.Value_martin_luther_king_day:
                    handler.string_value("martin_luther_king_day");
                    break;
                case TypeValueKnownValues.Value_easter:
                    handler.string_value("easter");
                    break;
                case TypeValueKnownValues.Value_easter_monday:
                    handler.string_value("easter_monday");
                    break;
                case TypeValueKnownValues.Value_mothers_day:
                    handler.string_value("mothers_day");
                    break;
                case TypeValueKnownValues.Value_memorial_day:
                    handler.string_value("memorial_day");
                    break;
                case TypeValueKnownValues.Value_fathers_day:
                    handler.string_value("fathers_day");
                    break;
                case TypeValueKnownValues.Value_us_independence_day:
                    handler.string_value("us_independence_day");
                    break;
                case TypeValueKnownValues.Value_us_labor_day:
                    handler.string_value("us_labor_day");
                    break;
                case TypeValueKnownValues.Value_columbus_day:
                    handler.string_value("columbus_day");
                    break;
                case TypeValueKnownValues.Value_halloween:
                    handler.string_value("halloween");
                    break;
                case TypeValueKnownValues.Value_us_thanksgiving_day:
                    handler.string_value("us_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_us_thanksgiving_eve:
                    handler.string_value("us_thanksgiving_eve");
                    break;
                case TypeValueKnownValues.Value_christmas_day:
                    handler.string_value("christmas_day");
                    break;
                case TypeValueKnownValues.Value_christmas_eve:
                    handler.string_value("christmas_eve");
                    break;
                case TypeValueKnownValues.Value_rosh_hashanah:
                    handler.string_value("rosh_hashanah");
                    break;
                case TypeValueKnownValues.Value_yom_kippur:
                    handler.string_value("yom_kippur");
                    break;
                case TypeValueKnownValues.Value_sukkot:
                    handler.string_value("sukkot");
                    break;
                case TypeValueKnownValues.Value_hoshana_rabbah:
                    handler.string_value("hoshana_rabbah");
                    break;
                case TypeValueKnownValues.Value_shemini_atzeret:
                    handler.string_value("shemini_atzeret");
                    break;
                case TypeValueKnownValues.Value_simchat_torah:
                    handler.string_value("simchat_torah");
                    break;
                case TypeValueKnownValues.Value_hanukkah:
                    handler.string_value("hanukkah");
                    break;
                case TypeValueKnownValues.Value_tu_bishvat:
                    handler.string_value("tu_bishvat");
                    break;
                case TypeValueKnownValues.Value_purim:
                    handler.string_value("purim");
                    break;
                case TypeValueKnownValues.Value_passover:
                    handler.string_value("passover");
                    break;
                case TypeValueKnownValues.Value_lag_baomer:
                    handler.string_value("lag_baomer");
                    break;
                case TypeValueKnownValues.Value_shavuot:
                    handler.string_value("shavuot");
                    break;
                case TypeValueKnownValues.Value_tisha_bav:
                    handler.string_value("tisha_bav");
                    break;
                case TypeValueKnownValues.Value_good_friday:
                    handler.string_value("good_friday");
                    break;
                case TypeValueKnownValues.Value_canada_day:
                    handler.string_value("canada_day");
                    break;
                case TypeValueKnownValues.Value_us_flag_day:
                    handler.string_value("us_flag_day");
                    break;
                case TypeValueKnownValues.Value_veterans_day:
                    handler.string_value("veterans_day");
                    break;
                case TypeValueKnownValues.Value_april_fools_day:
                    handler.string_value("april_fools_day");
                    break;
                case TypeValueKnownValues.Value_boxing_day:
                    handler.string_value("boxing_day");
                    break;
                case TypeValueKnownValues.Value_black_friday:
                    handler.string_value("black_friday");
                    break;
                case TypeValueKnownValues.Value_lent:
                    handler.string_value("lent");
                    break;
                case TypeValueKnownValues.Value_shrove_tuesday:
                    handler.string_value("shrove_tuesday");
                    break;
                case TypeValueKnownValues.Value_mardi_gras:
                    handler.string_value("mardi_gras");
                    break;
                case TypeValueKnownValues.Value_ash_wednesday:
                    handler.string_value("ash_wednesday");
                    break;
                case TypeValueKnownValues.Value_palm_sunday:
                    handler.string_value("palm_sunday");
                    break;
                case TypeValueKnownValues.Value_holy_thursday:
                    handler.string_value("holy_thursday");
                    break;
                case TypeValueKnownValues.Value_all_saints_day:
                    handler.string_value("all_saints_day");
                    break;
                case TypeValueKnownValues.Value_all_souls_day:
                    handler.string_value("all_souls_day");
                    break;
                case TypeValueKnownValues.Value_festivus:
                    handler.string_value("festivus");
                    break;
                case TypeValueKnownValues.Value_washingtons_birthday:
                    handler.string_value("washingtons_birthday");
                    break;
                case TypeValueKnownValues.Value_saint_patricks_day:
                    handler.string_value("saint_patricks_day");
                    break;
                case TypeValueKnownValues.Value_cesar_chavez_day:
                    handler.string_value("cesar_chavez_day");
                    break;
                case TypeValueKnownValues.Value_earth_day:
                    handler.string_value("earth_day");
                    break;
                case TypeValueKnownValues.Value_cinco_de_mayo:
                    handler.string_value("cinco_de_mayo");
                    break;
                case TypeValueKnownValues.Value_spring_equinox:
                    handler.string_value("spring_equinox");
                    break;
                case TypeValueKnownValues.Value_summer_solstice:
                    handler.string_value("summer_solstice");
                    break;
                case TypeValueKnownValues.Value_fall_equinox:
                    handler.string_value("fall_equinox");
                    break;
                case TypeValueKnownValues.Value_winter_solstice:
                    handler.string_value("winter_solstice");
                    break;
                case TypeValueKnownValues.Value_remembrance_day:
                    handler.string_value("remembrance_day");
                    break;
                case TypeValueKnownValues.Value_kwanzaa:
                    handler.string_value("kwanzaa");
                    break;
                case TypeValueKnownValues.Value_groundhog_day:
                    handler.string_value("groundhog_day");
                    break;
                case TypeValueKnownValues.Value_jp_coming_of_age_day:
                    handler.string_value("jp_coming_of_age_day");
                    break;
                case TypeValueKnownValues.Value_jp_national_foundation_day:
                    handler.string_value("jp_national_foundation_day");
                    break;
                case TypeValueKnownValues.Value_jp_vernal_equinox_day:
                    handler.string_value("jp_vernal_equinox_day");
                    break;
                case TypeValueKnownValues.Value_jp_showa_day:
                    handler.string_value("jp_showa_day");
                    break;
                case TypeValueKnownValues.Value_jp_constitution_memorial_day:
                    handler.string_value("jp_constitution_memorial_day");
                    break;
                case TypeValueKnownValues.Value_jp_greenery_day:
                    handler.string_value("jp_greenery_day");
                    break;
                case TypeValueKnownValues.Value_jp_childrens_day:
                    handler.string_value("jp_childrens_day");
                    break;
                case TypeValueKnownValues.Value_jp_golden_week:
                    handler.string_value("jp_golden_week");
                    break;
                case TypeValueKnownValues.Value_jp_marine_day:
                    handler.string_value("jp_marine_day");
                    break;
                case TypeValueKnownValues.Value_jp_mountain_day:
                    handler.string_value("jp_mountain_day");
                    break;
                case TypeValueKnownValues.Value_jp_respect_for_the_aged_day:
                    handler.string_value("jp_respect_for_the_aged_day");
                    break;
                case TypeValueKnownValues.Value_jp_autumnal_equinox_day:
                    handler.string_value("jp_autumnal_equinox_day");
                    break;
                case TypeValueKnownValues.Value_jp_health_and_sports_day:
                    handler.string_value("jp_health_and_sports_day");
                    break;
                case TypeValueKnownValues.Value_jp_culture_day:
                    handler.string_value("jp_culture_day");
                    break;
                case TypeValueKnownValues.Value_jp_labour_thanksgiving_day:
                    handler.string_value("jp_labour_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_jp_the_emperors_birthday:
                    handler.string_value("jp_the_emperors_birthday");
                    break;
                case TypeValueKnownValues.Value_jp_transfer_holiday:
                    handler.string_value("jp_transfer_holiday");
                    break;
                case TypeValueKnownValues.Value_jp_citizens_holiday:
                    handler.string_value("jp_citizens_holiday");
                    break;
                case TypeValueKnownValues.Value_gandhi_jayanti:
                    handler.string_value("gandhi_jayanti");
                    break;
                case TypeValueKnownValues.Value_republic_day_of_india:
                    handler.string_value("republic_day_of_india");
                    break;
                case TypeValueKnownValues.Value_indian_independence_day:
                    handler.string_value("indian_independence_day");
                    break;
                case TypeValueKnownValues.Value_ambedkar_jayanti:
                    handler.string_value("ambedkar_jayanti");
                    break;
                case TypeValueKnownValues.Value_rabindra_jayanti:
                    handler.string_value("rabindra_jayanti");
                    break;
                case TypeValueKnownValues.Value_cheti_chand:
                    handler.string_value("cheti_chand");
                    break;
                case TypeValueKnownValues.Value_onam:
                    handler.string_value("onam");
                    break;
                case TypeValueKnownValues.Value_thiruvonam:
                    handler.string_value("thiruvonam");
                    break;
                case TypeValueKnownValues.Value_magh_bihu:
                    handler.string_value("magh_bihu");
                    break;
                case TypeValueKnownValues.Value_lohri_maghi_or_bhogi:
                    handler.string_value("lohri_maghi_or_bhogi");
                    break;
                case TypeValueKnownValues.Value_labor_day_in_india:
                    handler.string_value("labor_day_in_india");
                    break;
                case TypeValueKnownValues.Value_flag_day_of_india:
                    handler.string_value("flag_day_of_india");
                    break;
                case TypeValueKnownValues.Value_mesadi:
                    handler.string_value("mesadi");
                    break;
                case TypeValueKnownValues.Value_vaisakhadi:
                    handler.string_value("vaisakhadi");
                    break;
                case TypeValueKnownValues.Value_vishu:
                    handler.string_value("vishu");
                    break;
                case TypeValueKnownValues.Value_bohag_bihu:
                    handler.string_value("bohag_bihu");
                    break;
                case TypeValueKnownValues.Value_ugadi:
                    handler.string_value("ugadi");
                    break;
                case TypeValueKnownValues.Value_puthandu:
                    handler.string_value("puthandu");
                    break;
                case TypeValueKnownValues.Value_pohela_boishakh:
                    handler.string_value("pohela_boishakh");
                    break;
                case TypeValueKnownValues.Value_muharram:
                    handler.string_value("muharram");
                    break;
                case TypeValueKnownValues.Value_day_of_ashura:
                    handler.string_value("day_of_ashura");
                    break;
                case TypeValueKnownValues.Value_milad_un_nabi:
                    handler.string_value("milad_un_nabi");
                    break;
                case TypeValueKnownValues.Value_ramadan:
                    handler.string_value("ramadan");
                    break;
                case TypeValueKnownValues.Value_eid_al_adha:
                    handler.string_value("eid_al_adha");
                    break;
                case TypeValueKnownValues.Value_eid_al_fitr:
                    handler.string_value("eid_al_fitr");
                    break;
                case TypeValueKnownValues.Value_eid:
                    handler.string_value("eid");
                    break;
                case TypeValueKnownValues.Value_jumuatul_wida:
                    handler.string_value("jumuatul_wida");
                    break;
                case TypeValueKnownValues.Value_day_of_arafah:
                    handler.string_value("day_of_arafah");
                    break;
                case TypeValueKnownValues.Value_birthday_of_ali_ibn_abi_talib:
                    handler.string_value("birthday_of_ali_ibn_abi_talib");
                    break;
                case TypeValueKnownValues.Value_pentecost:
                    handler.string_value("pentecost");
                    break;
                case TypeValueKnownValues.Value_pentecost_monday:
                    handler.string_value("pentecost_monday");
                    break;
                case TypeValueKnownValues.Value_may_day:
                    handler.string_value("may_day");
                    break;
                case TypeValueKnownValues.Value_international_womens_day:
                    handler.string_value("international_womens_day");
                    break;
                case TypeValueKnownValues.Value_cn_spring_festival_eve:
                    handler.string_value("cn_spring_festival_eve");
                    break;
                case TypeValueKnownValues.Value_cn_spring_festival:
                    handler.string_value("cn_spring_festival");
                    break;
                case TypeValueKnownValues.Value_cn_lantern_festival:
                    handler.string_value("cn_lantern_festival");
                    break;
                case TypeValueKnownValues.Value_cn_qingming_festival:
                    handler.string_value("cn_qingming_festival");
                    break;
                case TypeValueKnownValues.Value_cn_youth_day:
                    handler.string_value("cn_youth_day");
                    break;
                case TypeValueKnownValues.Value_cn_dragon_boat_festival:
                    handler.string_value("cn_dragon_boat_festival");
                    break;
                case TypeValueKnownValues.Value_cn_childrens_day:
                    handler.string_value("cn_childrens_day");
                    break;
                case TypeValueKnownValues.Value_cn_cpc_founding_day:
                    handler.string_value("cn_cpc_founding_day");
                    break;
                case TypeValueKnownValues.Value_cn_pla_founding_day:
                    handler.string_value("cn_pla_founding_day");
                    break;
                case TypeValueKnownValues.Value_cn_qixi_festival:
                    handler.string_value("cn_qixi_festival");
                    break;
                case TypeValueKnownValues.Value_cn_mid_autumn_festival:
                    handler.string_value("cn_mid_autumn_festival");
                    break;
                case TypeValueKnownValues.Value_cn_national_day:
                    handler.string_value("cn_national_day");
                    break;
                case TypeValueKnownValues.Value_cn_chong_yang_festival:
                    handler.string_value("cn_chong_yang_festival");
                    break;
                case TypeValueKnownValues.Value_holika_dahan:
                    handler.string_value("holika_dahan");
                    break;
                case TypeValueKnownValues.Value_dol_yatra:
                    handler.string_value("dol_yatra");
                    break;
                case TypeValueKnownValues.Value_holi:
                    handler.string_value("holi");
                    break;
                case TypeValueKnownValues.Value_dussehra:
                    handler.string_value("dussehra");
                    break;
                case TypeValueKnownValues.Value_bijoy_doshomi:
                    handler.string_value("bijoy_doshomi");
                    break;
                case TypeValueKnownValues.Value_durga_puja:
                    handler.string_value("durga_puja");
                    break;
                case TypeValueKnownValues.Value_diwali:
                    handler.string_value("diwali");
                    break;
                case TypeValueKnownValues.Value_kali_puja:
                    handler.string_value("kali_puja");
                    break;
                case TypeValueKnownValues.Value_dhanteras:
                    handler.string_value("dhanteras");
                    break;
                case TypeValueKnownValues.Value_kali_chaudas:
                    handler.string_value("kali_chaudas");
                    break;
                case TypeValueKnownValues.Value_naraka_chaturdashi:
                    handler.string_value("naraka_chaturdashi");
                    break;
                case TypeValueKnownValues.Value_lakshmi_puja:
                    handler.string_value("lakshmi_puja");
                    break;
                case TypeValueKnownValues.Value_bali_pratipada:
                    handler.string_value("bali_pratipada");
                    break;
                case TypeValueKnownValues.Value_goverdhan_puja:
                    handler.string_value("goverdhan_puja");
                    break;
                case TypeValueKnownValues.Value_bhai_dooj:
                    handler.string_value("bhai_dooj");
                    break;
                case TypeValueKnownValues.Value_ram_navami:
                    handler.string_value("ram_navami");
                    break;
                case TypeValueKnownValues.Value_ganesh_chaturthi:
                    handler.string_value("ganesh_chaturthi");
                    break;
                case TypeValueKnownValues.Value_janmashtami:
                    handler.string_value("janmashtami");
                    break;
                case TypeValueKnownValues.Value_nag_panchami:
                    handler.string_value("nag_panchami");
                    break;
                case TypeValueKnownValues.Value_makar_sankranti:
                    handler.string_value("makar_sankranti");
                    break;
                case TypeValueKnownValues.Value_pongal:
                    handler.string_value("pongal");
                    break;
                case TypeValueKnownValues.Value_raksha_bandhan:
                    handler.string_value("raksha_bandhan");
                    break;
                case TypeValueKnownValues.Value_basant_panchami:
                    handler.string_value("basant_panchami");
                    break;
                case TypeValueKnownValues.Value_saraswati_puja:
                    handler.string_value("saraswati_puja");
                    break;
                case TypeValueKnownValues.Value_rath_yatra:
                    handler.string_value("rath_yatra");
                    break;
                case TypeValueKnownValues.Value_navaratri:
                    handler.string_value("navaratri");
                    break;
                case TypeValueKnownValues.Value_maha_saptami:
                    handler.string_value("maha_saptami");
                    break;
                case TypeValueKnownValues.Value_maha_ashtami:
                    handler.string_value("maha_ashtami");
                    break;
                case TypeValueKnownValues.Value_maha_navami:
                    handler.string_value("maha_navami");
                    break;
                case TypeValueKnownValues.Value_maha_shivaratri:
                    handler.string_value("maha_shivaratri");
                    break;
                case TypeValueKnownValues.Value_anant_chaturdashi:
                    handler.string_value("anant_chaturdashi");
                    break;
                case TypeValueKnownValues.Value_shivaji_jayanti:
                    handler.string_value("shivaji_jayanti");
                    break;
                case TypeValueKnownValues.Value_valmiki_jayanti:
                    handler.string_value("valmiki_jayanti");
                    break;
                case TypeValueKnownValues.Value_chhat_puja:
                    handler.string_value("chhat_puja");
                    break;
                case TypeValueKnownValues.Value_dayanand_saraswati_jayanti:
                    handler.string_value("dayanand_saraswati_jayanti");
                    break;
                case TypeValueKnownValues.Value_karwa_chauth:
                    handler.string_value("karwa_chauth");
                    break;
                case TypeValueKnownValues.Value_vaisakhi:
                    handler.string_value("vaisakhi");
                    break;
                case TypeValueKnownValues.Value_guru_nanak_gurpurab:
                    handler.string_value("guru_nanak_gurpurab");
                    break;
                case TypeValueKnownValues.Value_guru_gobind_singh_gurpurab:
                    handler.string_value("guru_gobind_singh_gurpurab");
                    break;
                case TypeValueKnownValues.Value_guru_teg_bahadur_shahid_diwas:
                    handler.string_value("guru_teg_bahadur_shahid_diwas");
                    break;
                case TypeValueKnownValues.Value_mahavir_jayanti:
                    handler.string_value("mahavir_jayanti");
                    break;
                case TypeValueKnownValues.Value_paryushan:
                    handler.string_value("paryushan");
                    break;
                case TypeValueKnownValues.Value_vesak_or_buddha_purnima:
                    handler.string_value("vesak_or_buddha_purnima");
                    break;
                case TypeValueKnownValues.Value_hanamatsuri:
                    handler.string_value("hanamatsuri");
                    break;
                case TypeValueKnownValues.Value_sa_ga_dawa:
                    handler.string_value("sa_ga_dawa");
                    break;
                case TypeValueKnownValues.Value_ravidass_jayanti:
                    handler.string_value("ravidass_jayanti");
                    break;
                case TypeValueKnownValues.Value_bodhi_day:
                    handler.string_value("bodhi_day");
                    break;
                case TypeValueKnownValues.Value_rohatsu:
                    handler.string_value("rohatsu");
                    break;
                case TypeValueKnownValues.Value_asalha_puja:
                    handler.string_value("asalha_puja");
                    break;
                case TypeValueKnownValues.Value_loy_krathong:
                    handler.string_value("loy_krathong");
                    break;
                case TypeValueKnownValues.Value_nowruz:
                    handler.string_value("nowruz");
                    break;
                case TypeValueKnownValues.Value_nowruz_in_india:
                    handler.string_value("nowruz_in_india");
                    break;
                case TypeValueKnownValues.Value_ca_family_day:
                    handler.string_value("ca_family_day");
                    break;
                case TypeValueKnownValues.Value_ca_thanksgiving_day:
                    handler.string_value("ca_thanksgiving_day");
                    break;
                case TypeValueKnownValues.Value_ca_thanksgiving_eve:
                    handler.string_value("ca_thanksgiving_eve");
                    break;
                case TypeValueKnownValues.Value_united_nations_day:
                    handler.string_value("united_nations_day");
                    break;
                case TypeValueKnownValues.Value_epiphany:
                    handler.string_value("epiphany");
                    break;
                case TypeValueKnownValues.Value_ascension_day:
                    handler.string_value("ascension_day");
                    break;
                case TypeValueKnownValues.Value_advent_1st:
                    handler.string_value("advent_1st");
                    break;
                case TypeValueKnownValues.Value_advent_2nd:
                    handler.string_value("advent_2nd");
                    break;
                case TypeValueKnownValues.Value_advent_3rd:
                    handler.string_value("advent_3rd");
                    break;
                case TypeValueKnownValues.Value_advent_4th:
                    handler.string_value("advent_4th");
                    break;
                case TypeValueKnownValues.Value_saint_knuts_day:
                    handler.string_value("saint_knuts_day");
                    break;
                case TypeValueKnownValues.Value_saint_lucys_day:
                    handler.string_value("saint_lucys_day");
                    break;
                case TypeValueKnownValues.Value_midsummer_eve:
                    handler.string_value("midsummer_eve");
                    break;
                case TypeValueKnownValues.Value_waffle_day:
                    handler.string_value("waffle_day");
                    break;
                case TypeValueKnownValues.Value_walpurgis_night:
                    handler.string_value("walpurgis_night");
                    break;
                case TypeValueKnownValues.Value_se_national_day:
                    handler.string_value("se_national_day");
                    break;
                case TypeValueKnownValues.Value_se_fathers_day:
                    handler.string_value("se_fathers_day");
                    break;
                case TypeValueKnownValues.Value_se_mothers_day:
                    handler.string_value("se_mothers_day");
                    break;
                case TypeValueKnownValues.Value_nobels_day:
                    handler.string_value("nobels_day");
                    break;
                case TypeValueKnownValues.Value_juneteenth:
                    handler.string_value("juneteenth");
                    break;
                case TypeValueKnownValues.Value_fat_thursday:
                    handler.string_value("fat_thursday");
                    break;
                case TypeValueKnownValues.Value_shrove_monday:
                    handler.string_value("shrove_monday");
                    break;
                case TypeValueKnownValues.Value_de_fathers_day:
                    handler.string_value("de_fathers_day");
                    break;
                case TypeValueKnownValues.Value_feast_of_corpus_christi:
                    handler.string_value("feast_of_corpus_christi");
                    break;
                case TypeValueKnownValues.Value_assumption_of_mary:
                    handler.string_value("assumption_of_mary");
                    break;
                case TypeValueKnownValues.Value_reformation_day:
                    handler.string_value("reformation_day");
                    break;
                case TypeValueKnownValues.Value_augsburg_peace_festival:
                    handler.string_value("augsburg_peace_festival");
                    break;
                case TypeValueKnownValues.Value_de_childrens_day:
                    handler.string_value("de_childrens_day");
                    break;
                case TypeValueKnownValues.Value_de_unity_day:
                    handler.string_value("de_unity_day");
                    break;
                case TypeValueKnownValues.Value_de_harvest_festival:
                    handler.string_value("de_harvest_festival");
                    break;
                case TypeValueKnownValues.Value_saint_martins_day:
                    handler.string_value("saint_martins_day");
                    break;
                case TypeValueKnownValues.Value_de_peoples_day_of_mourning:
                    handler.string_value("de_peoples_day_of_mourning");
                    break;
                case TypeValueKnownValues.Value_day_of_repentance_and_prayer:
                    handler.string_value("day_of_repentance_and_prayer");
                    break;
                case TypeValueKnownValues.Value_sunday_of_the_dead:
                    handler.string_value("sunday_of_the_dead");
                    break;
                case TypeValueKnownValues.Value_saint_nicholas_day:
                    handler.string_value("saint_nicholas_day");
                    break;
                case TypeValueKnownValues.Value_immaculate_conception:
                    handler.string_value("immaculate_conception");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static HolidayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HolidayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Holiday", ignore_extras);
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
    public static HolidayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HolidayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HolidayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Holiday", ignore_extras);
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
    public static HolidayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HolidayJSON from_text(string text, bool ignore_extras)
      {
        HolidayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Holiday", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HolidayJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HolidayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HolidayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Holiday", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
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

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
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
            HolidayJSON result = new HolidayJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(HolidayJSON new_result);
        public Generator(bool ignore_extras) : base("Type Holiday")
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
        protected override void handle_result(HolidayJSON  result)
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
        public HolidayJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HolidayJSON  result)
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
    protected virtual void handle_result(List<HolidayJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HolidayJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HolidayJSON>();
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
    public List<HolidayJSON> value;
  };
  };
