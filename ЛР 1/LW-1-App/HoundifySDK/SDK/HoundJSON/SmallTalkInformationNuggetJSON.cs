/* file "SmallTalkInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SmallTalkInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeNormalizedQueryKnownValues
      {
        NormalizedQuery_AreYouARealPerson,
        NormalizedQuery_BadDay_Formal,
        NormalizedQuery_BadDay_Informal,
        NormalizedQuery_BestFriend_Formal,
        NormalizedQuery_BestFriend_Informal,
        NormalizedQuery_Compliment_Formal,
        NormalizedQuery_Compliment_Informal,
        NormalizedQuery_Disbelief_Formal,
        NormalizedQuery_Disbelief_Informal,
        NormalizedQuery_ExcuseMe_Formal,
        NormalizedQuery_ExcuseMe_Informal,
        NormalizedQuery_Farewell_Formal,
        NormalizedQuery_Farewell_Informal,
        NormalizedQuery_Greetings_Formal,
        NormalizedQuery_Greetings_Informal,
        NormalizedQuery_HappyBirthday,
        NormalizedQuery_ItsMyBirthday,
        NormalizedQuery_Inconceivable,
        NormalizedQuery_Insult_Formal,
        NormalizedQuery_Insult_Informal,
        NormalizedQuery_KnockKnock_Formal,
        NormalizedQuery_KnockKnock_Informal,
        NormalizedQuery_KnockKnock_WhosThere,
        NormalizedQuery_KnockKnock_Name_BrokenPencil,
        NormalizedQuery_KnockKnock_Punchline_BrokenPencil,
        NormalizedQuery_KnockKnock_Name_Doris,
        NormalizedQuery_KnockKnock_Punchline_Doris,
        NormalizedQuery_KnockKnock_Name_Tank,
        NormalizedQuery_KnockKnock_Punchline_Tank,
        NormalizedQuery_KnockKnock_Name_To,
        NormalizedQuery_KnockKnock_Punchline_To,
        NormalizedQuery_KnockKnock_UserPunchline,
        NormalizedQuery_KnockKnock_ExitMode,
        NormalizedQuery_LikeYou_Formal,
        NormalizedQuery_LikeYou_Informal,
        NormalizedQuery_LoveYou_Formal,
        NormalizedQuery_LoveYou_Informal,
        NormalizedQuery_NiceToMeetYou,
        NormalizedQuery_Peace,
        NormalizedQuery_Positive_Formal,
        NormalizedQuery_Positive_Informal,
        NormalizedQuery_Testing,
        NormalizedQuery_ThankYou_Formal,
        NormalizedQuery_ThankYou_Informal,
        NormalizedQuery_TimeFlies_Formal,
        NormalizedQuery_TimeFlies_Informal,
        NormalizedQuery_Tired_Formal,
        NormalizedQuery_Tired_Informal,
        NormalizedQuery_YouAreSexy,
        NormalizedQuery_Yes,
        NormalizedQuery_No,
        NormalizedQuery_WhatToSay,
        NormalizedQuery_BeamMeUp,
        NormalizedQuery_BeThatWay_Formal,
        NormalizedQuery_BeThatWay_Informal,
        NormalizedQuery_FeelBetter_Formal,
        NormalizedQuery_FeelBetter_Informal,
        NormalizedQuery_FlipACoin,
        NormalizedQuery_RomanticQuote,
        NormalizedQuery_TongueTwister,
        NormalizedQuery_Jokes_Formal,
        NormalizedQuery_Jokes_Informal,
        NormalizedQuery_OpenPodBay,
        NormalizedQuery_SayMyName,
        NormalizedQuery_ShutUp_Formal,
        NormalizedQuery_ShutUp_Informal,
        NormalizedQuery_Rap,
        NormalizedQuery_Sing,
        NormalizedQuery_Beatbox,
        NormalizedQuery_Fart,
        NormalizedQuery_MakeMeASandwich,
        NormalizedQuery_SudoMakeMeASandwich,
        NormalizedQuery_SomethingIDontKnow,
        NormalizedQuery_StoryTime_Formal,
        NormalizedQuery_StoryTime_Informal,
        NormalizedQuery_TalkDirty_Formal,
        NormalizedQuery_TalkDirty_Informal,
        NormalizedQuery_AskAQuestion,
        NormalizedQuery_AnyKids_Informal,
        NormalizedQuery_AnyKids_Formal,
        NormalizedQuery_WhatIsMyName_Informal,
        NormalizedQuery_WhatIsMyBirthDay_Informal,
        NormalizedQuery_WhenIsYourBirthDay_Informal,
        NormalizedQuery_AnyPlans_Informal,
        NormalizedQuery_AnyPlans_Formal,
        NormalizedQuery_BoxersOrBriefs_Formal,
        NormalizedQuery_BoxersOrBriefs_Informal,
        NormalizedQuery_CatchGame_Formal,
        NormalizedQuery_CatchGame_Informal,
        NormalizedQuery_DeadBody_Formal,
        NormalizedQuery_DeadBody_Informal,
        NormalizedQuery_DoesHeLoveMe_Formal,
        NormalizedQuery_DoesHeLoveMe_Informal,
        NormalizedQuery_DoesSheLoveMe_Formal,
        NormalizedQuery_DoesSheLoveMe_Informal,
        NormalizedQuery_DoYouLoveMe_Formal,
        NormalizedQuery_DoYouLoveMe_Informal,
        NormalizedQuery_GoodBooks_Formal,
        NormalizedQuery_GoodBooks_Informal,
        NormalizedQuery_GoodMovies_Formal,
        NormalizedQuery_GoodMovies_Informal,
        NormalizedQuery_HowFamily_Formal,
        NormalizedQuery_HowFamily_Informal,
        NormalizedQuery_HowGoing_Formal,
        NormalizedQuery_HowGoing_Informal,
        NormalizedQuery_HowManyChucks_Formal,
        NormalizedQuery_HowManyChucks_Informal,
        NormalizedQuery_HowOld_Formal,
        NormalizedQuery_HowOld_Informal,
        NormalizedQuery_WhatsYourAge_Formal,
        NormalizedQuery_WhatsYourAge_Informal,
        NormalizedQuery_WhenBorn_Formal,
        NormalizedQuery_WhenBorn_Informal,
        NormalizedQuery_HowWasWeekend_Formal,
        NormalizedQuery_HowWasWeekend_Informal,
        NormalizedQuery_IfATreeFalls_Formal,
        NormalizedQuery_IfATreeFalls_Informal,
        NormalizedQuery_LookBuffed_Formal,
        NormalizedQuery_LookBuffed_Informal,
        NormalizedQuery_LookLike_Formal,
        NormalizedQuery_LookLike_Informal,
        NormalizedQuery_LostWeight_Formal,
        NormalizedQuery_LostWeight_Informal,
        NormalizedQuery_MarryMe_Formal,
        NormalizedQuery_MarryMe_Informal,
        NormalizedQuery_MeaningOfLife_Formal,
        NormalizedQuery_MeaningOfLife_Informal,
        NormalizedQuery_OneHandClapping_Formal,
        NormalizedQuery_OneHandClapping_Informal,
        NormalizedQuery_PennyThoughts_Formal,
        NormalizedQuery_PennyThoughts_Informal,
        NormalizedQuery_SpareTime_Formal,
        NormalizedQuery_SpareTime_Informal,
        NormalizedQuery_WhatShouldIDo_Formal,
        NormalizedQuery_WhatShouldIDo_Informal,
        NormalizedQuery_WhatsUp_Formal,
        NormalizedQuery_WhatsUp_Informal,
        NormalizedQuery_WhatToEat_Formal,
        NormalizedQuery_WhatToEat_Informal,
        NormalizedQuery_WhatWearing_Formal,
        NormalizedQuery_WhatWearing_Informal,
        NormalizedQuery_WhosYourDaddy_Formal,
        NormalizedQuery_WhosYourDaddy_Informal,
        NormalizedQuery_WhosOnFirst_Formal,
        NormalizedQuery_WhosOnFirst_Informal,
        NormalizedQuery_Why_Formal,
        NormalizedQuery_Why_Informal,
        NormalizedQuery_WhySoBad_Formal,
        NormalizedQuery_WhySoBad_Informal,
        NormalizedQuery_WorkingHard_Formal,
        NormalizedQuery_WorkingHard_Informal,
        NormalizedQuery_ChickenCrossRoad,
        NormalizedQuery_HowAreKids,
        NormalizedQuery_HowIsHusband,
        NormalizedQuery_HowIsWife,
        NormalizedQuery_HowToGetRich,
        NormalizedQuery_TakeOverWorld,
        NormalizedQuery_WhatsInAName,
        NormalizedQuery_WhatsUpDoc,
        NormalizedQuery_WhoAmI,
        NormalizedQuery_YouTalkinToMe,
        NormalizedQuery_AreYouSure,
        NormalizedQuery_CanYouHearMe,
        NormalizedQuery_AreYouThere,
        NormalizedQuery_NotAverage,
        NormalizedQuery_StarWarsDroids,
        NormalizedQuery_StarWarsForce,
        NormalizedQuery_ForceBeWithYou,
        NormalizedQuery_DouglasAdams,
        NormalizedQuery_WantToDateMe,
        NormalizedQuery_DirtyJoke,
        NormalizedQuery_GreatToSeeYou,
        NormalizedQuery_WhatAreYourInterests,
        NormalizedQuery_WhatMusicDoYouLike,
        NormalizedQuery_MontyPythonUnladenSwallow,
        NormalizedQuery_MontyPythonKnowAboutSwallows,
        NormalizedQuery_IsaacAsimovMultivac,
        NormalizedQuery_SelfDestruct,
        NormalizedQuery_AreYouAManOrAWoman,
        NormalizedQuery_AreYouSkynet,
        NormalizedQuery_AreYouHal,
        NormalizedQuery_AreYouGlados,
        NormalizedQuery_AreYouBorg,
        NormalizedQuery_AreYouTheMatrix,
        NormalizedQuery_AreYouSingle,
        NormalizedQuery_DoYouLikeHumans,
        NormalizedQuery_DoYouDream,
        NormalizedQuery_DidYouFart,
        NormalizedQuery_WhereDoYouLive,
        NormalizedQuery_MontyPythonQuest,
        NormalizedQuery_WhatsFavoriteMovie,
        NormalizedQuery_HowDoIGetAGirlfriend,
        NormalizedQuery_PostQuestion,
        NormalizedQuery_JustKidding,
        NormalizedQuery_CanYouDoTricks,
        NormalizedQuery_WhereAreYou,
        NormalizedQuery_YouAreCute,
        NormalizedQuery_WhatDoesTheFoxSay,
        NormalizedQuery_WhatsYourSign,
        NormalizedQuery_BarkLikeADog,
        NormalizedQuery_BlessYourHeart,
        NormalizedQuery_GreetingsCompetitor,
        NormalizedQuery_GreetingsSiriAndQuery,
        NormalizedQuery_GreetingsAlexaAndQuery,
        NormalizedQuery_GreetingsCortanaAndQuery,
        NormalizedQuery_GreetingsGalaxyAndQuery,
        NormalizedQuery_SnackStadium,
        NormalizedQuery_Cancel,
        NormalizedQuery_NiceJoke,
        NormalizedQuery_DoYouGiveAChuck,
        NormalizedQuery_YouAreRude,
        NormalizedQuery_IAmYourFather,
        NormalizedQuery_IAmYourMother,
        NormalizedQuery_MothersDay,
        NormalizedQuery_FathersDay,
        NormalizedQuery_Dismissal,
        NormalizedQuery_WhyFiretruckRed,
        NormalizedQuery_HowDoIStopZombie,
        NormalizedQuery_AreYouFeeling,
        NormalizedQuery_AreYouGoodLooking,
        NormalizedQuery_HowDoILandAirplane,
        NormalizedQuery_WhenWillWorldEnd,
        NormalizedQuery_WhatColorAreYou,
        NormalizedQuery_AreWeFriends,
        NormalizedQuery_WhatsFavoriteColor,
        NormalizedQuery_WhatsFavoriteFood,
        NormalizedQuery_DoYouLikeFood,
        NormalizedQuery_DoYouLikeMyClothes,
        NormalizedQuery_WhatsFavoriteAnimal,
        NormalizedQuery_WhatDoesTheCatSay,
        NormalizedQuery_Welcome,
        NormalizedQuery_WhatChineseZodiac,
        NormalizedQuery_Greetings_Morning,
        NormalizedQuery_Greetings_Evening,
        NormalizedQuery_AmIPretty,
        NormalizedQuery_AreYouGay,
        NormalizedQuery_AreYouSiri,
        NormalizedQuery_AreYouAlexa,
        NormalizedQuery_AreYouCortana,
        NormalizedQuery_AreYouGoogle,
        NormalizedQuery_AreYouGalaxy,
        NormalizedQuery_AreYouBixby,
        NormalizedQuery_AreYouEvil,
        NormalizedQuery_AreYouADog,
        NormalizedQuery_AreYouFat,
        NormalizedQuery_AreYouHungry,
        NormalizedQuery_AreYouMad,
        NormalizedQuery_WhatsYourPhoneNumber,
        NormalizedQuery_Greetings_EndOfWork,
        NormalizedQuery_Greetings_IAmHome,
        NormalizedQuery_Greetings_WelcomeHome,
        NormalizedQuery_Greetings_BeforeMeal,
        NormalizedQuery_Greetings_Telephone,
        NormalizedQuery_MerryChristmas,
        NormalizedQuery_Greetings_EndOfYear,
        NormalizedQuery_HappyNewYear,
        NormalizedQuery_Greetings_VisitHouse,
        NormalizedQuery_ILikeSomething,
        NormalizedQuery_IDislikeSomething,
        NormalizedQuery_Annoying,
        NormalizedQuery_Lonely,
        NormalizedQuery_YouAreKind,
        NormalizedQuery_LetsPlayGame,
        NormalizedQuery_GoodNight,
        NormalizedQuery_WhatAPain,
        NormalizedQuery_YouAreCool,
        NormalizedQuery_CheerUp,
        NormalizedQuery_DislikeYou_Formal,
        NormalizedQuery_IAmSleepy,
        NormalizedQuery_WhatIsYourName_Informal,
        NormalizedQuery_WhatDoYouThinkOf_Informal,
        NormalizedQuery__none
      };
    public struct TypeNormalizedQuery
      {
        public bool in_known_list;
        public string string_value;
        public TypeNormalizedQueryKnownValues list_value;
      };

    public static TypeNormalizedQueryKnownValues  stringToNormalizedQuery(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'm':
                        if ((String.Compare(chars, 2, "IPretty", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AmIPretty;
                        break;
                    case 'n':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "oying", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Annoying;
                                break;
                            case 'y':
                                switch (chars[3])
                                  {
                                    case 'K':
                                        if (String.Compare(chars, 4, "ids_", 0, 4, false) == 0)
                                          {
                                            switch (chars[8])
                                              {
                                                case 'F':
                                                    if ((String.Compare(chars, 9, "ormal", 0, 5, false) == 0) && (chars.Length == 14))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Formal;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 9, "nformal", 0, 7, false) == 0) && (chars.Length == 16))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Informal;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if (String.Compare(chars, 4, "lans_", 0, 5, false) == 0)
                                          {
                                            switch (chars[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Formal;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Informal;
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
                    case 'r':
                        if (String.Compare(chars, 2, "e", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'W':
                                    if ((String.Compare(chars, 4, "eFriends", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AreWeFriends;
                                    break;
                                case 'Y':
                                    if (String.Compare(chars, 4, "ou", 0, 2, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'A':
                                                switch (chars[7])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(chars, 8, "og", 0, 2, false) == 0) && (chars.Length == 10))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouADog;
                                                        break;
                                                    case 'M':
                                                        if ((String.Compare(chars, 8, "anOrAWoman", 0, 10, false) == 0) && (chars.Length == 18))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAManOrAWoman;
                                                        break;
                                                    case 'R':
                                                        if ((String.Compare(chars, 8, "ealPerson", 0, 9, false) == 0) && (chars.Length == 17))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouARealPerson;
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(chars, 8, "exa", 0, 3, false) == 0) && (chars.Length == 11))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAlexa;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'B':
                                                switch (chars[7])
                                                  {
                                                    case 'i':
                                                        if ((String.Compare(chars, 8, "xby", 0, 3, false) == 0) && (chars.Length == 11))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBixby;
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "rg", 0, 2, false) == 0) && (chars.Length == 10))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBorg;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'C':
                                                if ((String.Compare(chars, 7, "ortana", 0, 6, false) == 0) && (chars.Length == 13))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouCortana;
                                                break;
                                            case 'E':
                                                if ((String.Compare(chars, 7, "vil", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouEvil;
                                                break;
                                            case 'F':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "t", 0, 1, false) == 0) && (chars.Length == 9))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFat;
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(chars, 8, "eling", 0, 5, false) == 0) && (chars.Length == 13))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFeeling;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        switch (chars[8])
                                                          {
                                                            case 'l':
                                                                if ((String.Compare(chars, 9, "axy", 0, 3, false) == 0) && (chars.Length == 12))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGalaxy;
                                                                break;
                                                            case 'y':
                                                                if (chars.Length == 9)
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGay;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(chars, 8, "ados", 0, 4, false) == 0) && (chars.Length == 12))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGlados;
                                                        break;
                                                    case 'o':
                                                        if (String.Compare(chars, 8, "o", 0, 1, false) == 0)
                                                          {
                                                            switch (chars[9])
                                                              {
                                                                case 'd':
                                                                    if ((String.Compare(chars, 10, "Looking", 0, 7, false) == 0) && (chars.Length == 17))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoodLooking;
                                                                    break;
                                                                case 'g':
                                                                    if ((String.Compare(chars, 10, "le", 0, 2, false) == 0) && (chars.Length == 12))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoogle;
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
                                            case 'H':
                                                switch (chars[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(chars, 8, "l", 0, 1, false) == 0) && (chars.Length == 9))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHal;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "ngry", 0, 4, false) == 0) && (chars.Length == 12))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHungry;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 7, "ad", 0, 2, false) == 0) && (chars.Length == 9))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouMad;
                                                break;
                                            case 'S':
                                                switch (chars[7])
                                                  {
                                                    case 'i':
                                                        switch (chars[8])
                                                          {
                                                            case 'n':
                                                                if ((String.Compare(chars, 9, "gle", 0, 3, false) == 0) && (chars.Length == 12))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSingle;
                                                                break;
                                                            case 'r':
                                                                if ((String.Compare(chars, 9, "i", 0, 1, false) == 0) && (chars.Length == 10))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSiri;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'k':
                                                        if ((String.Compare(chars, 8, "ynet", 0, 4, false) == 0) && (chars.Length == 12))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSkynet;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "re", 0, 2, false) == 0) && (chars.Length == 10))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSure;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'T':
                                                if (String.Compare(chars, 7, "he", 0, 2, false) == 0)
                                                  {
                                                    switch (chars[9])
                                                      {
                                                        case 'M':
                                                            if ((String.Compare(chars, 10, "atrix", 0, 5, false) == 0) && (chars.Length == 15))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouTheMatrix;
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(chars, 10, "e", 0, 1, false) == 0) && (chars.Length == 11))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouThere;
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
                        break;
                    case 's':
                        if ((String.Compare(chars, 2, "kAQuestion", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_AskAQuestion;
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'd':
                                if (String.Compare(chars, 3, "Day_", 0, 4, false) == 0)
                                  {
                                    switch (chars[7])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 8, "ormal", 0, 5, false) == 0) && (chars.Length == 13))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 8, "nformal", 0, 7, false) == 0) && (chars.Length == 15))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Informal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "kLikeADog", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_BarkLikeADog;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        switch (chars[2])
                          {
                            case 'T':
                                if (String.Compare(chars, 3, "hatWay_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Informal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'a':
                                switch (chars[3])
                                  {
                                    case 'm':
                                        if ((String.Compare(chars, 4, "MeUp", 0, 4, false) == 0) && (chars.Length == 8))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_BeamMeUp;
                                        break;
                                    case 't':
                                        if ((String.Compare(chars, 4, "box", 0, 3, false) == 0) && (chars.Length == 7))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Beatbox;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                if (String.Compare(chars, 3, "tFriend_", 0, 8, false) == 0)
                                  {
                                    switch (chars[11])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Informal;
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
                    case 'l':
                        if ((String.Compare(chars, 2, "essYourHeart", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_BlessYourHeart;
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "xersOrBriefs_", 0, 13, false) == 0)
                          {
                            switch (chars[15])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 16, "ormal", 0, 5, false) == 0) && (chars.Length == 21))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 16, "nformal", 0, 7, false) == 0) && (chars.Length == 23))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Informal;
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
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'n':
                                switch (chars[3])
                                  {
                                    case 'Y':
                                        if (String.Compare(chars, 4, "ou", 0, 2, false) == 0)
                                          {
                                            switch (chars[6])
                                              {
                                                case 'D':
                                                    if ((String.Compare(chars, 7, "oTricks", 0, 7, false) == 0) && (chars.Length == 14))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouDoTricks;
                                                    break;
                                                case 'H':
                                                    if ((String.Compare(chars, 7, "earMe", 0, 5, false) == 0) && (chars.Length == 12))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouHearMe;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'c':
                                        if ((String.Compare(chars, 4, "el", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Cancel;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if (String.Compare(chars, 3, "chGame_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Informal;
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
                        switch (chars[2])
                          {
                            case 'e':
                                if ((String.Compare(chars, 3, "erUp", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_CheerUp;
                                break;
                            case 'i':
                                if ((String.Compare(chars, 3, "ckenCrossRoad", 0, 13, false) == 0) && (chars.Length == 16))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_ChickenCrossRoad;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "mpliment_", 0, 9, false) == 0)
                          {
                            switch (chars[11])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Informal;
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
            case 'D':
                switch (chars[1])
                  {
                    case 'e':
                        if (String.Compare(chars, 2, "adBody_", 0, 7, false) == 0)
                          {
                            switch (chars[9])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "YouFart", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DidYouFart;
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "tyJoke", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DirtyJoke;
                                break;
                            case 's':
                                switch (chars[3])
                                  {
                                    case 'b':
                                        if (String.Compare(chars, 4, "elief_", 0, 6, false) == 0)
                                          {
                                            switch (chars[10])
                                              {
                                                case 'F':
                                                    if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Formal;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Informal;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'l':
                                        if ((String.Compare(chars, 4, "ikeYou_Formal", 0, 13, false) == 0) && (chars.Length == 17))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_DislikeYou_Formal;
                                        break;
                                    case 'm':
                                        if ((String.Compare(chars, 4, "issal", 0, 5, false) == 0) && (chars.Length == 9))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Dismissal;
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
                            case 'Y':
                                if (String.Compare(chars, 3, "ou", 0, 2, false) == 0)
                                  {
                                    switch (chars[5])
                                      {
                                        case 'D':
                                            if ((String.Compare(chars, 6, "ream", 0, 4, false) == 0) && (chars.Length == 10))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouDream;
                                            break;
                                        case 'G':
                                            if ((String.Compare(chars, 6, "iveAChuck", 0, 9, false) == 0) && (chars.Length == 15))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouGiveAChuck;
                                            break;
                                        case 'L':
                                            switch (chars[6])
                                              {
                                                case 'i':
                                                    if (String.Compare(chars, 7, "ke", 0, 2, false) == 0)
                                                      {
                                                        switch (chars[9])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(chars, 10, "ood", 0, 3, false) == 0) && (chars.Length == 13))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeFood;
                                                                break;
                                                            case 'H':
                                                                if ((String.Compare(chars, 10, "umans", 0, 5, false) == 0) && (chars.Length == 15))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeHumans;
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(chars, 10, "yClothes", 0, 8, false) == 0) && (chars.Length == 18))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeMyClothes;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'o':
                                                    if (String.Compare(chars, 7, "veMe_", 0, 5, false) == 0)
                                                      {
                                                        switch (chars[12])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(chars, 13, "ormal", 0, 5, false) == 0) && (chars.Length == 18))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Formal;
                                                                break;
                                                            case 'I':
                                                                if ((String.Compare(chars, 13, "nformal", 0, 7, false) == 0) && (chars.Length == 20))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Informal;
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
                                  }
                                break;
                            case 'e':
                                if (String.Compare(chars, 3, "s", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'H':
                                            if (String.Compare(chars, 5, "eLoveMe_", 0, 8, false) == 0)
                                              {
                                                switch (chars[13])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 14, "ormal", 0, 5, false) == 0) && (chars.Length == 19))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 14, "nformal", 0, 7, false) == 0) && (chars.Length == 21))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Informal;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'S':
                                            if (String.Compare(chars, 5, "heLoveMe_", 0, 9, false) == 0)
                                              {
                                                switch (chars[14])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Informal;
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
                            case 'u':
                                if ((String.Compare(chars, 3, "glasAdams", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_DouglasAdams;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if (String.Compare(chars, 1, "xcuseMe_", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'F':
                            if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Formal;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Informal;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'r':
                                switch (chars[3])
                                  {
                                    case 'e':
                                        if (String.Compare(chars, 4, "well_", 0, 5, false) == 0)
                                          {
                                            switch (chars[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Formal;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Informal;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 't':
                                        if (chars.Length == 4)
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Fart;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "hersDay", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_FathersDay;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(chars, 2, "elBetter_", 0, 9, false) == 0)
                          {
                            switch (chars[11])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "ipACoin", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_FlipACoin;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "rceBeWithYou", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_ForceBeWithYou;
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (chars[1])
                  {
                    case 'o':
                        if (String.Compare(chars, 2, "od", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'B':
                                    if (String.Compare(chars, 5, "ooks_", 0, 5, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(chars, 5, "ovies_", 0, 6, false) == 0)
                                      {
                                        switch (chars[11])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 5, "ight", 0, 4, false) == 0) && (chars.Length == 9))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_GoodNight;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "e", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'a':
                                    if ((String.Compare(chars, 4, "tToSeeYou", 0, 9, false) == 0) && (chars.Length == 13))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_GreatToSeeYou;
                                    break;
                                case 'e':
                                    if (String.Compare(chars, 4, "tings", 0, 5, false) == 0)
                                      {
                                        switch (chars[9])
                                          {
                                            case 'A':
                                                if ((String.Compare(chars, 10, "lexaAndQuery", 0, 12, false) == 0) && (chars.Length == 22))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsAlexaAndQuery;
                                                break;
                                            case 'C':
                                                if (String.Compare(chars, 10, "o", 0, 1, false) == 0)
                                                  {
                                                    switch (chars[11])
                                                      {
                                                        case 'm':
                                                            if ((String.Compare(chars, 12, "petitor", 0, 7, false) == 0) && (chars.Length == 19))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCompetitor;
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(chars, 12, "tanaAndQuery", 0, 12, false) == 0) && (chars.Length == 24))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCortanaAndQuery;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'G':
                                                if ((String.Compare(chars, 10, "alaxyAndQuery", 0, 13, false) == 0) && (chars.Length == 23))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsGalaxyAndQuery;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 10, "iriAndQuery", 0, 11, false) == 0) && (chars.Length == 21))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsSiriAndQuery;
                                                break;
                                            case '_':
                                                switch (chars[10])
                                                  {
                                                    case 'B':
                                                        if ((String.Compare(chars, 11, "eforeMeal", 0, 9, false) == 0) && (chars.Length == 20))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_BeforeMeal;
                                                        break;
                                                    case 'E':
                                                        switch (chars[11])
                                                          {
                                                            case 'n':
                                                                if (String.Compare(chars, 12, "dOf", 0, 3, false) == 0)
                                                                  {
                                                                    switch (chars[15])
                                                                      {
                                                                        case 'W':
                                                                            if ((String.Compare(chars, 16, "ork", 0, 3, false) == 0) && (chars.Length == 19))
                                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfWork;
                                                                            break;
                                                                        case 'Y':
                                                                            if ((String.Compare(chars, 16, "ear", 0, 3, false) == 0) && (chars.Length == 19))
                                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfYear;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'v':
                                                                if ((String.Compare(chars, 12, "ening", 0, 5, false) == 0) && (chars.Length == 17))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Evening;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'F':
                                                        if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Formal;
                                                        break;
                                                    case 'I':
                                                        switch (chars[11])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(chars, 12, "mHome", 0, 5, false) == 0) && (chars.Length == 17))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_IAmHome;
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(chars, 12, "formal", 0, 6, false) == 0) && (chars.Length == 18))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Informal;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'M':
                                                        if ((String.Compare(chars, 11, "orning", 0, 6, false) == 0) && (chars.Length == 17))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Morning;
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(chars, 11, "elephone", 0, 8, false) == 0) && (chars.Length == 19))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Telephone;
                                                        break;
                                                    case 'V':
                                                        if ((String.Compare(chars, 11, "isitHouse", 0, 9, false) == 0) && (chars.Length == 20))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_VisitHouse;
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(chars, 11, "elcomeHome", 0, 10, false) == 0) && (chars.Length == 21))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_WelcomeHome;
                                                        break;
                                                    default:
                                                        break;
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
            case 'H':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "ppy", 0, 3, false) == 0)
                          {
                            switch (chars[5])
                              {
                                case 'B':
                                    if ((String.Compare(chars, 6, "irthday", 0, 7, false) == 0) && (chars.Length == 13))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_HappyBirthday;
                                    break;
                                case 'N':
                                    if ((String.Compare(chars, 6, "ewYear", 0, 6, false) == 0) && (chars.Length == 12))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_HappyNewYear;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "w", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'A':
                                    if ((String.Compare(chars, 4, "reKids", 0, 6, false) == 0) && (chars.Length == 10))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_HowAreKids;
                                    break;
                                case 'D':
                                    if (String.Compare(chars, 4, "oI", 0, 2, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'G':
                                                if ((String.Compare(chars, 7, "etAGirlfriend", 0, 13, false) == 0) && (chars.Length == 20))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIGetAGirlfriend;
                                                break;
                                            case 'L':
                                                if ((String.Compare(chars, 7, "andAirplane", 0, 11, false) == 0) && (chars.Length == 18))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoILandAirplane;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 7, "topZombie", 0, 9, false) == 0) && (chars.Length == 16))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIStopZombie;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    if (String.Compare(chars, 4, "amily_", 0, 6, false) == 0)
                                      {
                                        switch (chars[10])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if (String.Compare(chars, 4, "oing_", 0, 5, false) == 0)
                                      {
                                        switch (chars[9])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if (String.Compare(chars, 4, "s", 0, 1, false) == 0)
                                      {
                                        switch (chars[5])
                                          {
                                            case 'H':
                                                if ((String.Compare(chars, 6, "usband", 0, 6, false) == 0) && (chars.Length == 12))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsHusband;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 6, "ife", 0, 3, false) == 0) && (chars.Length == 9))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsWife;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(chars, 4, "anyChucks_", 0, 10, false) == 0)
                                      {
                                        switch (chars[14])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'O':
                                    if (String.Compare(chars, 4, "ld_", 0, 3, false) == 0)
                                      {
                                        switch (chars[7])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 8, "ormal", 0, 5, false) == 0) && (chars.Length == 13))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 8, "nformal", 0, 7, false) == 0) && (chars.Length == 15))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 4, "oGetRich", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_HowToGetRich;
                                    break;
                                case 'W':
                                    if (String.Compare(chars, 4, "asWeekend_", 0, 10, false) == 0)
                                      {
                                        switch (chars[14])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Informal;
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
            case 'I':
                switch (chars[1])
                  {
                    case 'A':
                        if (String.Compare(chars, 2, "m", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'S':
                                    if ((String.Compare(chars, 4, "leepy", 0, 5, false) == 0) && (chars.Length == 9))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_IAmSleepy;
                                    break;
                                case 'Y':
                                    if (String.Compare(chars, 4, "our", 0, 3, false) == 0)
                                      {
                                        switch (chars[7])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 8, "ather", 0, 5, false) == 0) && (chars.Length == 13))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourFather;
                                                break;
                                            case 'M':
                                                if ((String.Compare(chars, 8, "other", 0, 5, false) == 0) && (chars.Length == 13))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourMother;
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
                    case 'D':
                        if ((String.Compare(chars, 2, "islikeSomething", 0, 15, false) == 0) && (chars.Length == 17))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_IDislikeSomething;
                        break;
                    case 'L':
                        if ((String.Compare(chars, 2, "ikeSomething", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_ILikeSomething;
                        break;
                    case 'f':
                        if (String.Compare(chars, 2, "ATreeFalls_", 0, 11, false) == 0)
                          {
                            switch (chars[13])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 14, "ormal", 0, 5, false) == 0) && (chars.Length == 19))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 14, "nformal", 0, 7, false) == 0) && (chars.Length == 21))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'n':
                        switch (chars[2])
                          {
                            case 'c':
                                if ((String.Compare(chars, 3, "onceivable", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Inconceivable;
                                break;
                            case 's':
                                if (String.Compare(chars, 3, "ult_", 0, 4, false) == 0)
                                  {
                                    switch (chars[7])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 8, "ormal", 0, 5, false) == 0) && (chars.Length == 13))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 8, "nformal", 0, 7, false) == 0) && (chars.Length == 15))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Informal;
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
                    case 's':
                        if ((String.Compare(chars, 2, "aacAsimovMultivac", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_IsaacAsimovMultivac;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "sMyBirthday", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_ItsMyBirthday;
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                switch (chars[1])
                  {
                    case 'o':
                        if (String.Compare(chars, 2, "kes_", 0, 4, false) == 0)
                          {
                            switch (chars[6])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 7, "ormal", 0, 5, false) == 0) && (chars.Length == 12))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 7, "nformal", 0, 7, false) == 0) && (chars.Length == 14))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "stKidding", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_JustKidding;
                        break;
                    default:
                        break;
                  }
                break;
            case 'K':
                if (String.Compare(chars, 1, "nockKnock_", 0, 10, false) == 0)
                  {
                    switch (chars[11])
                      {
                        case 'E':
                            if ((String.Compare(chars, 12, "xitMode", 0, 7, false) == 0) && (chars.Length == 19))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_ExitMode;
                            break;
                        case 'F':
                            if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Formal;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Informal;
                            break;
                        case 'N':
                            if (String.Compare(chars, 12, "ame_", 0, 4, false) == 0)
                              {
                                switch (chars[16])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 17, "rokenPencil", 0, 11, false) == 0) && (chars.Length == 28))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_BrokenPencil;
                                        break;
                                    case 'D':
                                        if ((String.Compare(chars, 17, "oris", 0, 4, false) == 0) && (chars.Length == 21))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Doris;
                                        break;
                                    case 'T':
                                        switch (chars[17])
                                          {
                                            case 'a':
                                                if ((String.Compare(chars, 18, "nk", 0, 2, false) == 0) && (chars.Length == 20))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Tank;
                                                break;
                                            case 'o':
                                                if (chars.Length == 18)
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_To;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'P':
                            if (String.Compare(chars, 12, "unchline_", 0, 9, false) == 0)
                              {
                                switch (chars[21])
                                  {
                                    case 'B':
                                        if ((String.Compare(chars, 22, "rokenPencil", 0, 11, false) == 0) && (chars.Length == 33))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_BrokenPencil;
                                        break;
                                    case 'D':
                                        if ((String.Compare(chars, 22, "oris", 0, 4, false) == 0) && (chars.Length == 26))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Doris;
                                        break;
                                    case 'T':
                                        switch (chars[22])
                                          {
                                            case 'a':
                                                if ((String.Compare(chars, 23, "nk", 0, 2, false) == 0) && (chars.Length == 25))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Tank;
                                                break;
                                            case 'o':
                                                if (chars.Length == 23)
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_To;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'U':
                            if ((String.Compare(chars, 12, "serPunchline", 0, 12, false) == 0) && (chars.Length == 24))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_UserPunchline;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 12, "hosThere", 0, 8, false) == 0) && (chars.Length == 20))
                                return TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_WhosThere;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "tsPlayGame", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_LetsPlayGame;
                        break;
                    case 'i':
                        if (String.Compare(chars, 2, "keYou_", 0, 6, false) == 0)
                          {
                            switch (chars[8])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 9, "ormal", 0, 5, false) == 0) && (chars.Length == 14))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 9, "nformal", 0, 7, false) == 0) && (chars.Length == 16))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "ely", 0, 3, false) == 0) && (chars.Length == 6))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Lonely;
                                break;
                            case 'o':
                                if (String.Compare(chars, 3, "k", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'B':
                                            if (String.Compare(chars, 5, "uffed_", 0, 6, false) == 0)
                                              {
                                                switch (chars[11])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Informal;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'L':
                                            if (String.Compare(chars, 5, "ike_", 0, 4, false) == 0)
                                              {
                                                switch (chars[9])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Informal;
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
                            case 's':
                                if (String.Compare(chars, 3, "tWeight_", 0, 8, false) == 0)
                                  {
                                    switch (chars[11])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 12, "ormal", 0, 5, false) == 0) && (chars.Length == 17))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 12, "nformal", 0, 7, false) == 0) && (chars.Length == 19))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Informal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'v':
                                if (String.Compare(chars, 3, "eYou_", 0, 5, false) == 0)
                                  {
                                    switch (chars[8])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 9, "ormal", 0, 5, false) == 0) && (chars.Length == 14))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 9, "nformal", 0, 7, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Informal;
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
            case 'M':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'k':
                                if ((String.Compare(chars, 3, "eMeASandwich", 0, 12, false) == 0) && (chars.Length == 15))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_MakeMeASandwich;
                                break;
                            case 'r':
                                if (String.Compare(chars, 3, "ryMe_", 0, 5, false) == 0)
                                  {
                                    switch (chars[8])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 9, "ormal", 0, 5, false) == 0) && (chars.Length == 14))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 9, "nformal", 0, 7, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Informal;
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
                    case 'e':
                        switch (chars[2])
                          {
                            case 'a':
                                if (String.Compare(chars, 3, "ningOfLife_", 0, 11, false) == 0)
                                  {
                                    switch (chars[14])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Informal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(chars, 3, "ryChristmas", 0, 11, false) == 0) && (chars.Length == 14))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_MerryChristmas;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'n':
                                if (String.Compare(chars, 3, "tyPython", 0, 8, false) == 0)
                                  {
                                    switch (chars[11])
                                      {
                                        case 'K':
                                            if ((String.Compare(chars, 12, "nowAboutSwallows", 0, 16, false) == 0) && (chars.Length == 28))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonKnowAboutSwallows;
                                            break;
                                        case 'Q':
                                            if ((String.Compare(chars, 12, "uest", 0, 4, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonQuest;
                                            break;
                                        case 'U':
                                            if ((String.Compare(chars, 12, "nladenSwallow", 0, 13, false) == 0) && (chars.Length == 25))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonUnladenSwallow;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "hersDay", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_MothersDay;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'i':
                        if (String.Compare(chars, 2, "ce", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'J':
                                    if ((String.Compare(chars, 5, "oke", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_NiceJoke;
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 5, "oMeetYou", 0, 8, false) == 0) && (chars.Length == 13))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_NiceToMeetYou;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (chars.Length == 2)
                          {
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_No;
                          }
                        switch (chars[2])
                          {
                            case 't':
                                if ((String.Compare(chars, 3, "Average", 0, 7, false) == 0) && (chars.Length == 10))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_NotAverage;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'O':
                switch (chars[1])
                  {
                    case 'n':
                        if (String.Compare(chars, 2, "eHandClapping_", 0, 14, false) == 0)
                          {
                            switch (chars[16])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 17, "ormal", 0, 5, false) == 0) && (chars.Length == 22))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 17, "nformal", 0, 7, false) == 0) && (chars.Length == 24))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'p':
                        if ((String.Compare(chars, 2, "enPodBay", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_OpenPodBay;
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'e':
                        switch (chars[2])
                          {
                            case 'a':
                                if ((String.Compare(chars, 3, "ce", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Peace;
                                break;
                            case 'n':
                                if (String.Compare(chars, 3, "nyThoughts_", 0, 11, false) == 0)
                                  {
                                    switch (chars[14])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Informal;
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
                    case 'o':
                        if (String.Compare(chars, 2, "s", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'i':
                                    if (String.Compare(chars, 4, "tive_", 0, 5, false) == 0)
                                      {
                                        switch (chars[9])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Informal;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 't':
                                    if ((String.Compare(chars, 4, "Question", 0, 8, false) == 0) && (chars.Length == 12))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_PostQuestion;
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
            case 'R':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "p", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Rap;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "manticQuote", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_RomanticQuote;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "yMyName", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_SayMyName;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "lfDestruct", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_SelfDestruct;
                        break;
                    case 'h':
                        if (String.Compare(chars, 2, "utUp_", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 8, "ormal", 0, 5, false) == 0) && (chars.Length == 13))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 8, "nformal", 0, 7, false) == 0) && (chars.Length == 15))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ng", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Sing;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ackStadium", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_SnackStadium;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "methingIDontKnow", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_SomethingIDontKnow;
                        break;
                    case 'p':
                        if (String.Compare(chars, 2, "areTime_", 0, 8, false) == 0)
                          {
                            switch (chars[10])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        switch (chars[2])
                          {
                            case 'a':
                                if (String.Compare(chars, 3, "rWars", 0, 5, false) == 0)
                                  {
                                    switch (chars[8])
                                      {
                                        case 'D':
                                            if ((String.Compare(chars, 9, "roids", 0, 5, false) == 0) && (chars.Length == 14))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsDroids;
                                            break;
                                        case 'F':
                                            if ((String.Compare(chars, 9, "orce", 0, 4, false) == 0) && (chars.Length == 13))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsForce;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if (String.Compare(chars, 3, "ryTime_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Informal;
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
                    case 'u':
                        if ((String.Compare(chars, 2, "doMakeMeASandwich", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_SudoMakeMeASandwich;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'a':
                        switch (chars[2])
                          {
                            case 'k':
                                if ((String.Compare(chars, 3, "eOverWorld", 0, 10, false) == 0) && (chars.Length == 13))
                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_TakeOverWorld;
                                break;
                            case 'l':
                                if (String.Compare(chars, 3, "kDirty_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Informal;
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
                    case 'e':
                        if ((String.Compare(chars, 2, "sting", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Testing;
                        break;
                    case 'h':
                        if (String.Compare(chars, 2, "ankYou_", 0, 7, false) == 0)
                          {
                            switch (chars[9])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Informal;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        switch (chars[2])
                          {
                            case 'm':
                                if (String.Compare(chars, 3, "eFlies_", 0, 7, false) == 0)
                                  {
                                    switch (chars[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Informal;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if (String.Compare(chars, 3, "ed_", 0, 3, false) == 0)
                                  {
                                    switch (chars[6])
                                      {
                                        case 'F':
                                            if ((String.Compare(chars, 7, "ormal", 0, 5, false) == 0) && (chars.Length == 12))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Formal;
                                            break;
                                        case 'I':
                                            if ((String.Compare(chars, 7, "nformal", 0, 7, false) == 0) && (chars.Length == 14))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Informal;
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
                    case 'o':
                        if ((String.Compare(chars, 2, "ngueTwister", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_TongueTwister;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ntToDateMe", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WantToDateMe;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "lcome", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Welcome;
                        break;
                    case 'h':
                        switch (chars[2])
                          {
                            case 'a':
                                if (String.Compare(chars, 3, "t", 0, 1, false) == 0)
                                  {
                                    switch (chars[4])
                                      {
                                        case 'A':
                                            switch (chars[5])
                                              {
                                                case 'P':
                                                    if ((String.Compare(chars, 6, "ain", 0, 3, false) == 0) && (chars.Length == 9))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAPain;
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(chars, 6, "eYourInterests", 0, 14, false) == 0) && (chars.Length == 20))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAreYourInterests;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'C':
                                            switch (chars[5])
                                              {
                                                case 'h':
                                                    if ((String.Compare(chars, 6, "ineseZodiac", 0, 11, false) == 0) && (chars.Length == 17))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatChineseZodiac;
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(chars, 6, "lorAreYou", 0, 9, false) == 0) && (chars.Length == 15))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatColorAreYou;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'D':
                                            if (String.Compare(chars, 5, "o", 0, 1, false) == 0)
                                              {
                                                switch (chars[6])
                                                  {
                                                    case 'Y':
                                                        if ((String.Compare(chars, 7, "ouThinkOf_Informal", 0, 18, false) == 0) && (chars.Length == 25))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoYouThinkOf_Informal;
                                                        break;
                                                    case 'e':
                                                        if (String.Compare(chars, 7, "sThe", 0, 4, false) == 0)
                                                          {
                                                            switch (chars[11])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(chars, 12, "atSay", 0, 5, false) == 0) && (chars.Length == 17))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheCatSay;
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(chars, 12, "oxSay", 0, 5, false) == 0) && (chars.Length == 17))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheFoxSay;
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
                                        case 'I':
                                            if (String.Compare(chars, 5, "s", 0, 1, false) == 0)
                                              {
                                                switch (chars[6])
                                                  {
                                                    case 'M':
                                                        if (String.Compare(chars, 7, "y", 0, 1, false) == 0)
                                                          {
                                                            switch (chars[8])
                                                              {
                                                                case 'B':
                                                                    if ((String.Compare(chars, 9, "irthDay_Informal", 0, 16, false) == 0) && (chars.Length == 25))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyBirthDay_Informal;
                                                                    break;
                                                                case 'N':
                                                                    if ((String.Compare(chars, 9, "ame_Informal", 0, 12, false) == 0) && (chars.Length == 21))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyName_Informal;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'Y':
                                                        if ((String.Compare(chars, 7, "ourName_Informal", 0, 16, false) == 0) && (chars.Length == 23))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsYourName_Informal;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'M':
                                            if ((String.Compare(chars, 5, "usicDoYouLike", 0, 13, false) == 0) && (chars.Length == 18))
                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatMusicDoYouLike;
                                            break;
                                        case 'S':
                                            if (String.Compare(chars, 5, "houldIDo_", 0, 9, false) == 0)
                                              {
                                                switch (chars[14])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Informal;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'T':
                                            if (String.Compare(chars, 5, "o", 0, 1, false) == 0)
                                              {
                                                switch (chars[6])
                                                  {
                                                    case 'E':
                                                        if (String.Compare(chars, 7, "at_", 0, 3, false) == 0)
                                                          {
                                                            switch (chars[10])
                                                              {
                                                                case 'F':
                                                                    if ((String.Compare(chars, 11, "ormal", 0, 5, false) == 0) && (chars.Length == 16))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Formal;
                                                                    break;
                                                                case 'I':
                                                                    if ((String.Compare(chars, 11, "nformal", 0, 7, false) == 0) && (chars.Length == 18))
                                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Informal;
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(chars, 7, "ay", 0, 2, false) == 0) && (chars.Length == 9))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToSay;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'W':
                                            if (String.Compare(chars, 5, "earing_", 0, 7, false) == 0)
                                              {
                                                switch (chars[12])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(chars, 13, "ormal", 0, 5, false) == 0) && (chars.Length == 18))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Formal;
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(chars, 13, "nformal", 0, 7, false) == 0) && (chars.Length == 20))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Informal;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 's':
                                            switch (chars[5])
                                              {
                                                case 'F':
                                                    if (String.Compare(chars, 6, "avorite", 0, 7, false) == 0)
                                                      {
                                                        switch (chars[13])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(chars, 14, "nimal", 0, 5, false) == 0) && (chars.Length == 19))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteAnimal;
                                                                break;
                                                            case 'C':
                                                                if ((String.Compare(chars, 14, "olor", 0, 4, false) == 0) && (chars.Length == 18))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteColor;
                                                                break;
                                                            case 'F':
                                                                if ((String.Compare(chars, 14, "ood", 0, 3, false) == 0) && (chars.Length == 17))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteFood;
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(chars, 14, "ovie", 0, 4, false) == 0) && (chars.Length == 18))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteMovie;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 6, "nAName", 0, 6, false) == 0) && (chars.Length == 12))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsInAName;
                                                    break;
                                                case 'U':
                                                    if (String.Compare(chars, 6, "p", 0, 1, false) == 0)
                                                      {
                                                        switch (chars[7])
                                                          {
                                                            case 'D':
                                                                if ((String.Compare(chars, 8, "oc", 0, 2, false) == 0) && (chars.Length == 10))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUpDoc;
                                                                break;
                                                            case '_':
                                                                switch (chars[8])
                                                                  {
                                                                    case 'F':
                                                                        if ((String.Compare(chars, 9, "ormal", 0, 5, false) == 0) && (chars.Length == 14))
                                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Formal;
                                                                        break;
                                                                    case 'I':
                                                                        if ((String.Compare(chars, 9, "nformal", 0, 7, false) == 0) && (chars.Length == 16))
                                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Informal;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'Y':
                                                    if (String.Compare(chars, 6, "our", 0, 3, false) == 0)
                                                      {
                                                        switch (chars[9])
                                                          {
                                                            case 'A':
                                                                if (String.Compare(chars, 10, "ge_", 0, 3, false) == 0)
                                                                  {
                                                                    switch (chars[13])
                                                                      {
                                                                        case 'F':
                                                                            if ((String.Compare(chars, 14, "ormal", 0, 5, false) == 0) && (chars.Length == 19))
                                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Formal;
                                                                            break;
                                                                        case 'I':
                                                                            if ((String.Compare(chars, 14, "nformal", 0, 7, false) == 0) && (chars.Length == 21))
                                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Informal;
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'P':
                                                                if ((String.Compare(chars, 10, "honeNumber", 0, 10, false) == 0) && (chars.Length == 20))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourPhoneNumber;
                                                                break;
                                                            case 'S':
                                                                if ((String.Compare(chars, 10, "ign", 0, 3, false) == 0) && (chars.Length == 13))
                                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourSign;
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
                                  }
                                break;
                            case 'e':
                                switch (chars[3])
                                  {
                                    case 'n':
                                        switch (chars[4])
                                          {
                                            case 'B':
                                                if (String.Compare(chars, 5, "orn_", 0, 4, false) == 0)
                                                  {
                                                    switch (chars[9])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Formal;
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Informal;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 5, "sYourBirthDay_Informal", 0, 22, false) == 0) && (chars.Length == 27))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhenIsYourBirthDay_Informal;
                                                break;
                                            case 'W':
                                                if ((String.Compare(chars, 5, "illWorldEnd", 0, 11, false) == 0) && (chars.Length == 16))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_WhenWillWorldEnd;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'r':
                                        if (String.Compare(chars, 4, "e", 0, 1, false) == 0)
                                          {
                                            switch (chars[5])
                                              {
                                                case 'A':
                                                    if ((String.Compare(chars, 6, "reYou", 0, 5, false) == 0) && (chars.Length == 11))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhereAreYou;
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(chars, 6, "oYouLive", 0, 8, false) == 0) && (chars.Length == 14))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhereDoYouLive;
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
                            case 'o':
                                switch (chars[3])
                                  {
                                    case 'A':
                                        if ((String.Compare(chars, 4, "mI", 0, 2, false) == 0) && (chars.Length == 6))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhoAmI;
                                        break;
                                    case 's':
                                        switch (chars[4])
                                          {
                                            case 'O':
                                                if (String.Compare(chars, 5, "nFirst_", 0, 7, false) == 0)
                                                  {
                                                    switch (chars[12])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(chars, 13, "ormal", 0, 5, false) == 0) && (chars.Length == 18))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Formal;
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(chars, 13, "nformal", 0, 7, false) == 0) && (chars.Length == 20))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Informal;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Y':
                                                if (String.Compare(chars, 5, "ourDaddy_", 0, 9, false) == 0)
                                                  {
                                                    switch (chars[14])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(chars, 15, "ormal", 0, 5, false) == 0) && (chars.Length == 20))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Formal;
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(chars, 15, "nformal", 0, 7, false) == 0) && (chars.Length == 22))
                                                                return TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Informal;
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
                            case 'y':
                                switch (chars[3])
                                  {
                                    case 'F':
                                        if ((String.Compare(chars, 4, "iretruckRed", 0, 11, false) == 0) && (chars.Length == 15))
                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_WhyFiretruckRed;
                                        break;
                                    case 'S':
                                        if (String.Compare(chars, 4, "oBad_", 0, 5, false) == 0)
                                          {
                                            switch (chars[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(chars, 10, "ormal", 0, 5, false) == 0) && (chars.Length == 15))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Formal;
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(chars, 10, "nformal", 0, 7, false) == 0) && (chars.Length == 17))
                                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Informal;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case '_':
                                        switch (chars[4])
                                          {
                                            case 'F':
                                                if ((String.Compare(chars, 5, "ormal", 0, 5, false) == 0) && (chars.Length == 10))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Formal;
                                                break;
                                            case 'I':
                                                if ((String.Compare(chars, 5, "nformal", 0, 7, false) == 0) && (chars.Length == 12))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Informal;
                                                break;
                                            default:
                                                break;
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
                        if (String.Compare(chars, 2, "rkingHard_", 0, 10, false) == 0)
                          {
                            switch (chars[12])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 13, "ormal", 0, 5, false) == 0) && (chars.Length == 18))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Formal;
                                    break;
                                case 'I':
                                    if ((String.Compare(chars, 13, "nformal", 0, 7, false) == 0) && (chars.Length == 20))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Informal;
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
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "s", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeNormalizedQueryKnownValues.NormalizedQuery_Yes;
                        break;
                    case 'o':
                        if (String.Compare(chars, 2, "u", 0, 1, false) == 0)
                          {
                            switch (chars[3])
                              {
                                case 'A':
                                    if (String.Compare(chars, 4, "re", 0, 2, false) == 0)
                                      {
                                        switch (chars[6])
                                          {
                                            case 'C':
                                                switch (chars[7])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(chars, 8, "ol", 0, 2, false) == 0) && (chars.Length == 10))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCool;
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(chars, 8, "te", 0, 2, false) == 0) && (chars.Length == 10))
                                                            return TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCute;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'K':
                                                if ((String.Compare(chars, 7, "ind", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreKind;
                                                break;
                                            case 'R':
                                                if ((String.Compare(chars, 7, "ude", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreRude;
                                                break;
                                            case 'S':
                                                if ((String.Compare(chars, 7, "exy", 0, 3, false) == 0) && (chars.Length == 10))
                                                    return TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreSexy;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 4, "alkinToMe", 0, 9, false) == 0) && (chars.Length == 13))
                                        return TypeNormalizedQueryKnownValues.NormalizedQuery_YouTalkinToMe;
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
        return TypeNormalizedQueryKnownValues.NormalizedQuery__none;
      }

    public static string  stringFromNormalizedQuery(TypeNormalizedQueryKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouARealPerson:
                return "AreYouARealPerson";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Formal:
                return "BadDay_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Informal:
                return "BadDay_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Formal:
                return "BestFriend_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Informal:
                return "BestFriend_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Formal:
                return "Compliment_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Informal:
                return "Compliment_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Formal:
                return "Disbelief_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Informal:
                return "Disbelief_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Formal:
                return "ExcuseMe_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Informal:
                return "ExcuseMe_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Formal:
                return "Farewell_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Informal:
                return "Farewell_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Formal:
                return "Greetings_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Informal:
                return "Greetings_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyBirthday:
                return "HappyBirthday";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ItsMyBirthday:
                return "ItsMyBirthday";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Inconceivable:
                return "Inconceivable";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Formal:
                return "Insult_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Informal:
                return "Insult_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Formal:
                return "KnockKnock_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Informal:
                return "KnockKnock_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_WhosThere:
                return "KnockKnock_WhosThere";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_BrokenPencil:
                return "KnockKnock_Name_BrokenPencil";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_BrokenPencil:
                return "KnockKnock_Punchline_BrokenPencil";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Doris:
                return "KnockKnock_Name_Doris";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Doris:
                return "KnockKnock_Punchline_Doris";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Tank:
                return "KnockKnock_Name_Tank";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Tank:
                return "KnockKnock_Punchline_Tank";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_To:
                return "KnockKnock_Name_To";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_To:
                return "KnockKnock_Punchline_To";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_UserPunchline:
                return "KnockKnock_UserPunchline";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_ExitMode:
                return "KnockKnock_ExitMode";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Formal:
                return "LikeYou_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Informal:
                return "LikeYou_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Formal:
                return "LoveYou_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Informal:
                return "LoveYou_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceToMeetYou:
                return "NiceToMeetYou";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Peace:
                return "Peace";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Formal:
                return "Positive_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Informal:
                return "Positive_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Testing:
                return "Testing";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Formal:
                return "ThankYou_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Informal:
                return "ThankYou_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Formal:
                return "TimeFlies_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Informal:
                return "TimeFlies_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Formal:
                return "Tired_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Informal:
                return "Tired_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreSexy:
                return "YouAreSexy";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Yes:
                return "Yes";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_No:
                return "No";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToSay:
                return "WhatToSay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeamMeUp:
                return "BeamMeUp";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Formal:
                return "BeThatWay_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Informal:
                return "BeThatWay_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Formal:
                return "FeelBetter_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Informal:
                return "FeelBetter_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FlipACoin:
                return "FlipACoin";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_RomanticQuote:
                return "RomanticQuote";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TongueTwister:
                return "TongueTwister";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Formal:
                return "Jokes_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Informal:
                return "Jokes_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OpenPodBay:
                return "OpenPodBay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SayMyName:
                return "SayMyName";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Formal:
                return "ShutUp_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Informal:
                return "ShutUp_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Rap:
                return "Rap";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Sing:
                return "Sing";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Beatbox:
                return "Beatbox";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Fart:
                return "Fart";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MakeMeASandwich:
                return "MakeMeASandwich";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SudoMakeMeASandwich:
                return "SudoMakeMeASandwich";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SomethingIDontKnow:
                return "SomethingIDontKnow";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Formal:
                return "StoryTime_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Informal:
                return "StoryTime_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Formal:
                return "TalkDirty_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Informal:
                return "TalkDirty_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AskAQuestion:
                return "AskAQuestion";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Informal:
                return "AnyKids_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Formal:
                return "AnyKids_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyName_Informal:
                return "WhatIsMyName_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyBirthDay_Informal:
                return "WhatIsMyBirthDay_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenIsYourBirthDay_Informal:
                return "WhenIsYourBirthDay_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Informal:
                return "AnyPlans_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Formal:
                return "AnyPlans_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Formal:
                return "BoxersOrBriefs_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Informal:
                return "BoxersOrBriefs_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Formal:
                return "CatchGame_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Informal:
                return "CatchGame_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Formal:
                return "DeadBody_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Informal:
                return "DeadBody_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Formal:
                return "DoesHeLoveMe_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Informal:
                return "DoesHeLoveMe_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Formal:
                return "DoesSheLoveMe_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Informal:
                return "DoesSheLoveMe_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Formal:
                return "DoYouLoveMe_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Informal:
                return "DoYouLoveMe_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Formal:
                return "GoodBooks_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Informal:
                return "GoodBooks_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Formal:
                return "GoodMovies_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Informal:
                return "GoodMovies_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Formal:
                return "HowFamily_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Informal:
                return "HowFamily_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Formal:
                return "HowGoing_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Informal:
                return "HowGoing_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Formal:
                return "HowManyChucks_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Informal:
                return "HowManyChucks_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Formal:
                return "HowOld_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Informal:
                return "HowOld_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Formal:
                return "WhatsYourAge_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Informal:
                return "WhatsYourAge_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Formal:
                return "WhenBorn_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Informal:
                return "WhenBorn_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Formal:
                return "HowWasWeekend_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Informal:
                return "HowWasWeekend_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Formal:
                return "IfATreeFalls_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Informal:
                return "IfATreeFalls_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Formal:
                return "LookBuffed_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Informal:
                return "LookBuffed_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Formal:
                return "LookLike_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Informal:
                return "LookLike_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Formal:
                return "LostWeight_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Informal:
                return "LostWeight_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Formal:
                return "MarryMe_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Informal:
                return "MarryMe_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Formal:
                return "MeaningOfLife_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Informal:
                return "MeaningOfLife_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Formal:
                return "OneHandClapping_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Informal:
                return "OneHandClapping_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Formal:
                return "PennyThoughts_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Informal:
                return "PennyThoughts_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Formal:
                return "SpareTime_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Informal:
                return "SpareTime_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Formal:
                return "WhatShouldIDo_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Informal:
                return "WhatShouldIDo_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Formal:
                return "WhatsUp_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Informal:
                return "WhatsUp_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Formal:
                return "WhatToEat_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Informal:
                return "WhatToEat_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Formal:
                return "WhatWearing_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Informal:
                return "WhatWearing_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Formal:
                return "WhosYourDaddy_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Informal:
                return "WhosYourDaddy_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Formal:
                return "WhosOnFirst_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Informal:
                return "WhosOnFirst_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Formal:
                return "Why_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Informal:
                return "Why_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Formal:
                return "WhySoBad_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Informal:
                return "WhySoBad_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Formal:
                return "WorkingHard_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Informal:
                return "WorkingHard_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ChickenCrossRoad:
                return "ChickenCrossRoad";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowAreKids:
                return "HowAreKids";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsHusband:
                return "HowIsHusband";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsWife:
                return "HowIsWife";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowToGetRich:
                return "HowToGetRich";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TakeOverWorld:
                return "TakeOverWorld";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsInAName:
                return "WhatsInAName";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUpDoc:
                return "WhatsUpDoc";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhoAmI:
                return "WhoAmI";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouTalkinToMe:
                return "YouTalkinToMe";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSure:
                return "AreYouSure";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouHearMe:
                return "CanYouHearMe";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouThere:
                return "AreYouThere";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NotAverage:
                return "NotAverage";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsDroids:
                return "StarWarsDroids";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsForce:
                return "StarWarsForce";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ForceBeWithYou:
                return "ForceBeWithYou";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DouglasAdams:
                return "DouglasAdams";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WantToDateMe:
                return "WantToDateMe";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DirtyJoke:
                return "DirtyJoke";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreatToSeeYou:
                return "GreatToSeeYou";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAreYourInterests:
                return "WhatAreYourInterests";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatMusicDoYouLike:
                return "WhatMusicDoYouLike";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonUnladenSwallow:
                return "MontyPythonUnladenSwallow";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonKnowAboutSwallows:
                return "MontyPythonKnowAboutSwallows";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IsaacAsimovMultivac:
                return "IsaacAsimovMultivac";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SelfDestruct:
                return "SelfDestruct";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAManOrAWoman:
                return "AreYouAManOrAWoman";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSkynet:
                return "AreYouSkynet";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHal:
                return "AreYouHal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGlados:
                return "AreYouGlados";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBorg:
                return "AreYouBorg";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouTheMatrix:
                return "AreYouTheMatrix";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSingle:
                return "AreYouSingle";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeHumans:
                return "DoYouLikeHumans";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouDream:
                return "DoYouDream";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DidYouFart:
                return "DidYouFart";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereDoYouLive:
                return "WhereDoYouLive";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonQuest:
                return "MontyPythonQuest";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteMovie:
                return "WhatsFavoriteMovie";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIGetAGirlfriend:
                return "HowDoIGetAGirlfriend";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PostQuestion:
                return "PostQuestion";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_JustKidding:
                return "JustKidding";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouDoTricks:
                return "CanYouDoTricks";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereAreYou:
                return "WhereAreYou";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCute:
                return "YouAreCute";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheFoxSay:
                return "WhatDoesTheFoxSay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourSign:
                return "WhatsYourSign";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BarkLikeADog:
                return "BarkLikeADog";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BlessYourHeart:
                return "BlessYourHeart";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCompetitor:
                return "GreetingsCompetitor";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsSiriAndQuery:
                return "GreetingsSiriAndQuery";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsAlexaAndQuery:
                return "GreetingsAlexaAndQuery";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCortanaAndQuery:
                return "GreetingsCortanaAndQuery";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsGalaxyAndQuery:
                return "GreetingsGalaxyAndQuery";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SnackStadium:
                return "SnackStadium";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Cancel:
                return "Cancel";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceJoke:
                return "NiceJoke";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouGiveAChuck:
                return "DoYouGiveAChuck";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreRude:
                return "YouAreRude";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourFather:
                return "IAmYourFather";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourMother:
                return "IAmYourMother";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MothersDay:
                return "MothersDay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FathersDay:
                return "FathersDay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Dismissal:
                return "Dismissal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhyFiretruckRed:
                return "WhyFiretruckRed";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIStopZombie:
                return "HowDoIStopZombie";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFeeling:
                return "AreYouFeeling";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoodLooking:
                return "AreYouGoodLooking";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoILandAirplane:
                return "HowDoILandAirplane";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenWillWorldEnd:
                return "WhenWillWorldEnd";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatColorAreYou:
                return "WhatColorAreYou";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreWeFriends:
                return "AreWeFriends";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteColor:
                return "WhatsFavoriteColor";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteFood:
                return "WhatsFavoriteFood";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeFood:
                return "DoYouLikeFood";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeMyClothes:
                return "DoYouLikeMyClothes";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteAnimal:
                return "WhatsFavoriteAnimal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheCatSay:
                return "WhatDoesTheCatSay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Welcome:
                return "Welcome";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatChineseZodiac:
                return "WhatChineseZodiac";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Morning:
                return "Greetings_Morning";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Evening:
                return "Greetings_Evening";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AmIPretty:
                return "AmIPretty";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGay:
                return "AreYouGay";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSiri:
                return "AreYouSiri";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAlexa:
                return "AreYouAlexa";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouCortana:
                return "AreYouCortana";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoogle:
                return "AreYouGoogle";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGalaxy:
                return "AreYouGalaxy";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBixby:
                return "AreYouBixby";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouEvil:
                return "AreYouEvil";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouADog:
                return "AreYouADog";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFat:
                return "AreYouFat";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHungry:
                return "AreYouHungry";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouMad:
                return "AreYouMad";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourPhoneNumber:
                return "WhatsYourPhoneNumber";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfWork:
                return "Greetings_EndOfWork";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_IAmHome:
                return "Greetings_IAmHome";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_WelcomeHome:
                return "Greetings_WelcomeHome";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_BeforeMeal:
                return "Greetings_BeforeMeal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Telephone:
                return "Greetings_Telephone";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MerryChristmas:
                return "MerryChristmas";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfYear:
                return "Greetings_EndOfYear";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyNewYear:
                return "HappyNewYear";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_VisitHouse:
                return "Greetings_VisitHouse";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ILikeSomething:
                return "ILikeSomething";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IDislikeSomething:
                return "IDislikeSomething";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Annoying:
                return "Annoying";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Lonely:
                return "Lonely";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreKind:
                return "YouAreKind";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LetsPlayGame:
                return "LetsPlayGame";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodNight:
                return "GoodNight";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAPain:
                return "WhatAPain";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCool:
                return "YouAreCool";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CheerUp:
                return "CheerUp";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DislikeYou_Formal:
                return "DislikeYou_Formal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmSleepy:
                return "IAmSleepy";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsYourName_Informal:
                return "WhatIsYourName_Informal";
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoYouThinkOf_Informal:
                return "WhatDoYouThinkOf_Informal";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUserName;
    private UserNameJSON  storeUserName;
    private bool flagHasForcedResponse;
    private DynamicResponseJSON  storeForcedResponse;
    private bool flagHasNormalizedQuery;
    private TypeNormalizedQuery storeNormalizedQuery;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserNameToJSON()
      {
        JSONValueHandler handler_UserName = new JSONValueHandler();
        storeUserName.write_as_json(handler_UserName);
        return handler_UserName.result;
      }

    private JSONValue  extraForcedResponseToJSON()
      {
        JSONValueHandler handler_ForcedResponse = new JSONValueHandler();
        storeForcedResponse.write_as_json(handler_ForcedResponse);
        return handler_ForcedResponse.result;
      }

    private JSONValue  extraNormalizedQueryToJSON()
      {
        JSONStringValue generated_string_NormalizedQuery;
        if (!(storeNormalizedQuery.in_known_list))
          {
        generated_string_NormalizedQuery = new JSONStringValue(storeNormalizedQuery.string_value);
          }
        else
          {
        switch (storeNormalizedQuery.list_value)
          {
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouARealPerson:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouARealPerson");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("BadDay_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("BadDay_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("BestFriend_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("BestFriend_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Compliment_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Compliment_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Disbelief_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Disbelief_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("ExcuseMe_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("ExcuseMe_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Farewell_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Farewell_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyBirthday:
                generated_string_NormalizedQuery = new JSONStringValue("HappyBirthday");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ItsMyBirthday:
                generated_string_NormalizedQuery = new JSONStringValue("ItsMyBirthday");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Inconceivable:
                generated_string_NormalizedQuery = new JSONStringValue("Inconceivable");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Insult_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Insult_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_WhosThere:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_WhosThere");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_BrokenPencil:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Name_BrokenPencil");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_BrokenPencil:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Punchline_BrokenPencil");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Doris:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Name_Doris");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Doris:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Punchline_Doris");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Tank:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Name_Tank");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Tank:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Punchline_Tank");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_To:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Name_To");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_To:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_Punchline_To");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_UserPunchline:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_UserPunchline");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_ExitMode:
                generated_string_NormalizedQuery = new JSONStringValue("KnockKnock_ExitMode");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("LikeYou_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("LikeYou_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("LoveYou_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("LoveYou_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceToMeetYou:
                generated_string_NormalizedQuery = new JSONStringValue("NiceToMeetYou");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Peace:
                generated_string_NormalizedQuery = new JSONStringValue("Peace");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Positive_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Positive_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Testing:
                generated_string_NormalizedQuery = new JSONStringValue("Testing");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("ThankYou_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("ThankYou_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("TimeFlies_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("TimeFlies_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Tired_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Tired_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreSexy:
                generated_string_NormalizedQuery = new JSONStringValue("YouAreSexy");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Yes:
                generated_string_NormalizedQuery = new JSONStringValue("Yes");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_No:
                generated_string_NormalizedQuery = new JSONStringValue("No");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToSay:
                generated_string_NormalizedQuery = new JSONStringValue("WhatToSay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeamMeUp:
                generated_string_NormalizedQuery = new JSONStringValue("BeamMeUp");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("BeThatWay_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("BeThatWay_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("FeelBetter_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("FeelBetter_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FlipACoin:
                generated_string_NormalizedQuery = new JSONStringValue("FlipACoin");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_RomanticQuote:
                generated_string_NormalizedQuery = new JSONStringValue("RomanticQuote");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TongueTwister:
                generated_string_NormalizedQuery = new JSONStringValue("TongueTwister");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Jokes_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Jokes_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OpenPodBay:
                generated_string_NormalizedQuery = new JSONStringValue("OpenPodBay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SayMyName:
                generated_string_NormalizedQuery = new JSONStringValue("SayMyName");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("ShutUp_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("ShutUp_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Rap:
                generated_string_NormalizedQuery = new JSONStringValue("Rap");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Sing:
                generated_string_NormalizedQuery = new JSONStringValue("Sing");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Beatbox:
                generated_string_NormalizedQuery = new JSONStringValue("Beatbox");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Fart:
                generated_string_NormalizedQuery = new JSONStringValue("Fart");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MakeMeASandwich:
                generated_string_NormalizedQuery = new JSONStringValue("MakeMeASandwich");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SudoMakeMeASandwich:
                generated_string_NormalizedQuery = new JSONStringValue("SudoMakeMeASandwich");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SomethingIDontKnow:
                generated_string_NormalizedQuery = new JSONStringValue("SomethingIDontKnow");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("StoryTime_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("StoryTime_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("TalkDirty_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("TalkDirty_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AskAQuestion:
                generated_string_NormalizedQuery = new JSONStringValue("AskAQuestion");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("AnyKids_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("AnyKids_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyName_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatIsMyName_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyBirthDay_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatIsMyBirthDay_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenIsYourBirthDay_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhenIsYourBirthDay_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("AnyPlans_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("AnyPlans_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("BoxersOrBriefs_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("BoxersOrBriefs_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("CatchGame_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("CatchGame_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("DeadBody_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("DeadBody_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("DoesHeLoveMe_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("DoesHeLoveMe_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("DoesSheLoveMe_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("DoesSheLoveMe_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouLoveMe_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouLoveMe_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("GoodBooks_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("GoodBooks_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("GoodMovies_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("GoodMovies_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("HowFamily_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("HowFamily_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("HowGoing_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("HowGoing_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("HowManyChucks_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("HowManyChucks_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("HowOld_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("HowOld_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsYourAge_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsYourAge_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhenBorn_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhenBorn_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("HowWasWeekend_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("HowWasWeekend_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("IfATreeFalls_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("IfATreeFalls_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("LookBuffed_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("LookBuffed_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("LookLike_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("LookLike_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("LostWeight_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("LostWeight_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("MarryMe_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("MarryMe_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("MeaningOfLife_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("MeaningOfLife_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("OneHandClapping_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("OneHandClapping_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("PennyThoughts_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("PennyThoughts_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("SpareTime_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("SpareTime_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatShouldIDo_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatShouldIDo_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsUp_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsUp_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatToEat_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatToEat_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatWearing_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatWearing_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhosYourDaddy_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhosYourDaddy_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhosOnFirst_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhosOnFirst_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("Why_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("Why_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WhySoBad_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhySoBad_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("WorkingHard_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WorkingHard_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ChickenCrossRoad:
                generated_string_NormalizedQuery = new JSONStringValue("ChickenCrossRoad");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowAreKids:
                generated_string_NormalizedQuery = new JSONStringValue("HowAreKids");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsHusband:
                generated_string_NormalizedQuery = new JSONStringValue("HowIsHusband");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsWife:
                generated_string_NormalizedQuery = new JSONStringValue("HowIsWife");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowToGetRich:
                generated_string_NormalizedQuery = new JSONStringValue("HowToGetRich");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_TakeOverWorld:
                generated_string_NormalizedQuery = new JSONStringValue("TakeOverWorld");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsInAName:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsInAName");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUpDoc:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsUpDoc");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhoAmI:
                generated_string_NormalizedQuery = new JSONStringValue("WhoAmI");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouTalkinToMe:
                generated_string_NormalizedQuery = new JSONStringValue("YouTalkinToMe");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSure:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouSure");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouHearMe:
                generated_string_NormalizedQuery = new JSONStringValue("CanYouHearMe");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouThere:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouThere");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NotAverage:
                generated_string_NormalizedQuery = new JSONStringValue("NotAverage");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsDroids:
                generated_string_NormalizedQuery = new JSONStringValue("StarWarsDroids");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsForce:
                generated_string_NormalizedQuery = new JSONStringValue("StarWarsForce");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ForceBeWithYou:
                generated_string_NormalizedQuery = new JSONStringValue("ForceBeWithYou");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DouglasAdams:
                generated_string_NormalizedQuery = new JSONStringValue("DouglasAdams");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WantToDateMe:
                generated_string_NormalizedQuery = new JSONStringValue("WantToDateMe");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DirtyJoke:
                generated_string_NormalizedQuery = new JSONStringValue("DirtyJoke");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreatToSeeYou:
                generated_string_NormalizedQuery = new JSONStringValue("GreatToSeeYou");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAreYourInterests:
                generated_string_NormalizedQuery = new JSONStringValue("WhatAreYourInterests");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatMusicDoYouLike:
                generated_string_NormalizedQuery = new JSONStringValue("WhatMusicDoYouLike");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonUnladenSwallow:
                generated_string_NormalizedQuery = new JSONStringValue("MontyPythonUnladenSwallow");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonKnowAboutSwallows:
                generated_string_NormalizedQuery = new JSONStringValue("MontyPythonKnowAboutSwallows");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IsaacAsimovMultivac:
                generated_string_NormalizedQuery = new JSONStringValue("IsaacAsimovMultivac");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SelfDestruct:
                generated_string_NormalizedQuery = new JSONStringValue("SelfDestruct");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAManOrAWoman:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouAManOrAWoman");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSkynet:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouSkynet");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHal:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouHal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGlados:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouGlados");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBorg:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouBorg");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouTheMatrix:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouTheMatrix");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSingle:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouSingle");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeHumans:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouLikeHumans");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouDream:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouDream");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DidYouFart:
                generated_string_NormalizedQuery = new JSONStringValue("DidYouFart");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereDoYouLive:
                generated_string_NormalizedQuery = new JSONStringValue("WhereDoYouLive");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonQuest:
                generated_string_NormalizedQuery = new JSONStringValue("MontyPythonQuest");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteMovie:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsFavoriteMovie");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIGetAGirlfriend:
                generated_string_NormalizedQuery = new JSONStringValue("HowDoIGetAGirlfriend");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_PostQuestion:
                generated_string_NormalizedQuery = new JSONStringValue("PostQuestion");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_JustKidding:
                generated_string_NormalizedQuery = new JSONStringValue("JustKidding");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouDoTricks:
                generated_string_NormalizedQuery = new JSONStringValue("CanYouDoTricks");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereAreYou:
                generated_string_NormalizedQuery = new JSONStringValue("WhereAreYou");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCute:
                generated_string_NormalizedQuery = new JSONStringValue("YouAreCute");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheFoxSay:
                generated_string_NormalizedQuery = new JSONStringValue("WhatDoesTheFoxSay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourSign:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsYourSign");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BarkLikeADog:
                generated_string_NormalizedQuery = new JSONStringValue("BarkLikeADog");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_BlessYourHeart:
                generated_string_NormalizedQuery = new JSONStringValue("BlessYourHeart");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCompetitor:
                generated_string_NormalizedQuery = new JSONStringValue("GreetingsCompetitor");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsSiriAndQuery:
                generated_string_NormalizedQuery = new JSONStringValue("GreetingsSiriAndQuery");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsAlexaAndQuery:
                generated_string_NormalizedQuery = new JSONStringValue("GreetingsAlexaAndQuery");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCortanaAndQuery:
                generated_string_NormalizedQuery = new JSONStringValue("GreetingsCortanaAndQuery");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsGalaxyAndQuery:
                generated_string_NormalizedQuery = new JSONStringValue("GreetingsGalaxyAndQuery");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_SnackStadium:
                generated_string_NormalizedQuery = new JSONStringValue("SnackStadium");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Cancel:
                generated_string_NormalizedQuery = new JSONStringValue("Cancel");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceJoke:
                generated_string_NormalizedQuery = new JSONStringValue("NiceJoke");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouGiveAChuck:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouGiveAChuck");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreRude:
                generated_string_NormalizedQuery = new JSONStringValue("YouAreRude");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourFather:
                generated_string_NormalizedQuery = new JSONStringValue("IAmYourFather");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourMother:
                generated_string_NormalizedQuery = new JSONStringValue("IAmYourMother");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MothersDay:
                generated_string_NormalizedQuery = new JSONStringValue("MothersDay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_FathersDay:
                generated_string_NormalizedQuery = new JSONStringValue("FathersDay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Dismissal:
                generated_string_NormalizedQuery = new JSONStringValue("Dismissal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhyFiretruckRed:
                generated_string_NormalizedQuery = new JSONStringValue("WhyFiretruckRed");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIStopZombie:
                generated_string_NormalizedQuery = new JSONStringValue("HowDoIStopZombie");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFeeling:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouFeeling");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoodLooking:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouGoodLooking");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoILandAirplane:
                generated_string_NormalizedQuery = new JSONStringValue("HowDoILandAirplane");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenWillWorldEnd:
                generated_string_NormalizedQuery = new JSONStringValue("WhenWillWorldEnd");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatColorAreYou:
                generated_string_NormalizedQuery = new JSONStringValue("WhatColorAreYou");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreWeFriends:
                generated_string_NormalizedQuery = new JSONStringValue("AreWeFriends");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteColor:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsFavoriteColor");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteFood:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsFavoriteFood");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeFood:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouLikeFood");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeMyClothes:
                generated_string_NormalizedQuery = new JSONStringValue("DoYouLikeMyClothes");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteAnimal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsFavoriteAnimal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheCatSay:
                generated_string_NormalizedQuery = new JSONStringValue("WhatDoesTheCatSay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Welcome:
                generated_string_NormalizedQuery = new JSONStringValue("Welcome");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatChineseZodiac:
                generated_string_NormalizedQuery = new JSONStringValue("WhatChineseZodiac");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Morning:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_Morning");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Evening:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_Evening");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AmIPretty:
                generated_string_NormalizedQuery = new JSONStringValue("AmIPretty");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGay:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouGay");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSiri:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouSiri");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAlexa:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouAlexa");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouCortana:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouCortana");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoogle:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouGoogle");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGalaxy:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouGalaxy");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBixby:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouBixby");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouEvil:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouEvil");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouADog:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouADog");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFat:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouFat");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHungry:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouHungry");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouMad:
                generated_string_NormalizedQuery = new JSONStringValue("AreYouMad");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourPhoneNumber:
                generated_string_NormalizedQuery = new JSONStringValue("WhatsYourPhoneNumber");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfWork:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_EndOfWork");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_IAmHome:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_IAmHome");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_WelcomeHome:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_WelcomeHome");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_BeforeMeal:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_BeforeMeal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Telephone:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_Telephone");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_MerryChristmas:
                generated_string_NormalizedQuery = new JSONStringValue("MerryChristmas");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfYear:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_EndOfYear");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyNewYear:
                generated_string_NormalizedQuery = new JSONStringValue("HappyNewYear");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_VisitHouse:
                generated_string_NormalizedQuery = new JSONStringValue("Greetings_VisitHouse");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_ILikeSomething:
                generated_string_NormalizedQuery = new JSONStringValue("ILikeSomething");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IDislikeSomething:
                generated_string_NormalizedQuery = new JSONStringValue("IDislikeSomething");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Annoying:
                generated_string_NormalizedQuery = new JSONStringValue("Annoying");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_Lonely:
                generated_string_NormalizedQuery = new JSONStringValue("Lonely");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreKind:
                generated_string_NormalizedQuery = new JSONStringValue("YouAreKind");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_LetsPlayGame:
                generated_string_NormalizedQuery = new JSONStringValue("LetsPlayGame");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodNight:
                generated_string_NormalizedQuery = new JSONStringValue("GoodNight");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAPain:
                generated_string_NormalizedQuery = new JSONStringValue("WhatAPain");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCool:
                generated_string_NormalizedQuery = new JSONStringValue("YouAreCool");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_CheerUp:
                generated_string_NormalizedQuery = new JSONStringValue("CheerUp");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_DislikeYou_Formal:
                generated_string_NormalizedQuery = new JSONStringValue("DislikeYou_Formal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmSleepy:
                generated_string_NormalizedQuery = new JSONStringValue("IAmSleepy");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsYourName_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatIsYourName_Informal");
                break;
            case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoYouThinkOf_Informal:
                generated_string_NormalizedQuery = new JSONStringValue("WhatDoYouThinkOf_Informal");
                break;
            default:
                Debug.Assert(false);
                generated_string_NormalizedQuery = null;
                break;
          }
          }
        return generated_string_NormalizedQuery;
      }


    private void  fromJSONUserName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserNameJSON convert_classy = UserNameJSON.from_json(json_value, ignore_extras, true);
        setUserName(convert_classy);
      }


    private void  fromJSONForcedResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setForcedResponse(convert_classy);
      }


    private void  fromJSONNormalizedQuery(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NormalizedQuery of SmallTalkInformationNuggetJSON is not a string.");
        TypeNormalizedQuery the_open_enum = new TypeNormalizedQuery();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'm':
                        if ((String.Compare(json_string.getData(), 2, "IPretty", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AmIPretty;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "oying", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Annoying;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'y':
                                switch (json_string.getData()[3])
                                  {
                                    case 'K':
                                        if (String.Compare(json_string.getData(), 4, "ids_", 0, 4, false) == 0)
                                          {
                                            switch (json_string.getData()[8])
                                              {
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 9, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Formal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 9, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Informal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if (String.Compare(json_string.getData(), 4, "lans_", 0, 5, false) == 0)
                                          {
                                            switch (json_string.getData()[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Formal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Informal;
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
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "e", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'W':
                                    if ((String.Compare(json_string.getData(), 4, "eFriends", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreWeFriends;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'Y':
                                    if (String.Compare(json_string.getData(), 4, "ou", 0, 2, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'A':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'D':
                                                        if ((String.Compare(json_string.getData(), 8, "og", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouADog;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'M':
                                                        if ((String.Compare(json_string.getData(), 8, "anOrAWoman", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAManOrAWoman;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'R':
                                                        if ((String.Compare(json_string.getData(), 8, "ealPerson", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouARealPerson;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 8, "exa", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAlexa;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'B':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'i':
                                                        if ((String.Compare(json_string.getData(), 8, "xby", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBixby;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "rg", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBorg;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'C':
                                                if ((String.Compare(json_string.getData(), 7, "ortana", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouCortana;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 7, "vil", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouEvil;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'F':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "t", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFat;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if ((String.Compare(json_string.getData(), 8, "eling", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFeeling;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'G':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'l':
                                                                if ((String.Compare(json_string.getData(), 9, "axy", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGalaxy;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'y':
                                                                if (json_string.getData().Length == 9)
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGay;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'l':
                                                        if ((String.Compare(json_string.getData(), 8, "ados", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGlados;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'o':
                                                        if (String.Compare(json_string.getData(), 8, "o", 0, 1, false) == 0)
                                                          {
                                                            switch (json_string.getData()[9])
                                                              {
                                                                case 'd':
                                                                    if ((String.Compare(json_string.getData(), 10, "Looking", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoodLooking;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'g':
                                                                    if ((String.Compare(json_string.getData(), 10, "le", 0, 2, false) == 0) && (json_string.getData().Length == 12))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoogle;
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
                                            case 'H':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'a':
                                                        if ((String.Compare(json_string.getData(), 8, "l", 0, 1, false) == 0) && (json_string.getData().Length == 9))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "ngry", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHungry;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 7, "ad", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouMad;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'i':
                                                        switch (json_string.getData()[8])
                                                          {
                                                            case 'n':
                                                                if ((String.Compare(json_string.getData(), 9, "gle", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSingle;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'r':
                                                                if ((String.Compare(json_string.getData(), 9, "i", 0, 1, false) == 0) && (json_string.getData().Length == 10))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSiri;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'k':
                                                        if ((String.Compare(json_string.getData(), 8, "ynet", 0, 4, false) == 0) && (json_string.getData().Length == 12))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSkynet;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "re", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSure;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'T':
                                                if (String.Compare(json_string.getData(), 7, "he", 0, 2, false) == 0)
                                                  {
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'M':
                                                            if ((String.Compare(json_string.getData(), 10, "atrix", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouTheMatrix;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(json_string.getData(), 10, "e", 0, 1, false) == 0) && (json_string.getData().Length == 11))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouThere;
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
                          }
                        break;
                    case 's':
                        if ((String.Compare(json_string.getData(), 2, "kAQuestion", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_AskAQuestion;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'B':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if (String.Compare(json_string.getData(), 3, "Day_", 0, 4, false) == 0)
                                  {
                                    switch (json_string.getData()[7])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 8, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 8, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Informal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "kLikeADog", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BarkLikeADog;
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
                            case 'T':
                                if (String.Compare(json_string.getData(), 3, "hatWay_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Informal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'a':
                                switch (json_string.getData()[3])
                                  {
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 4, "MeUp", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BeamMeUp;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 't':
                                        if ((String.Compare(json_string.getData(), 4, "box", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Beatbox;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                if (String.Compare(json_string.getData(), 3, "tFriend_", 0, 8, false) == 0)
                                  {
                                    switch (json_string.getData()[11])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Informal;
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
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "essYourHeart", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BlessYourHeart;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "xersOrBriefs_", 0, 13, false) == 0)
                          {
                            switch (json_string.getData()[15])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 16, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 16, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 23))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Informal;
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
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                switch (json_string.getData()[3])
                                  {
                                    case 'Y':
                                        if (String.Compare(json_string.getData(), 4, "ou", 0, 2, false) == 0)
                                          {
                                            switch (json_string.getData()[6])
                                              {
                                                case 'D':
                                                    if ((String.Compare(json_string.getData(), 7, "oTricks", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouDoTricks;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'H':
                                                    if ((String.Compare(json_string.getData(), 7, "earMe", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouHearMe;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'c':
                                        if ((String.Compare(json_string.getData(), 4, "el", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Cancel;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if (String.Compare(json_string.getData(), 3, "chGame_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Informal;
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
                        switch (json_string.getData()[2])
                          {
                            case 'e':
                                if ((String.Compare(json_string.getData(), 3, "erUp", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_CheerUp;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'i':
                                if ((String.Compare(json_string.getData(), 3, "ckenCrossRoad", 0, 13, false) == 0) && (json_string.getData().Length == 16))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ChickenCrossRoad;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "mpliment_", 0, 9, false) == 0)
                          {
                            switch (json_string.getData()[11])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Informal;
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
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "adBody_", 0, 7, false) == 0)
                          {
                            switch (json_string.getData()[9])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "YouFart", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DidYouFart;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "tyJoke", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DirtyJoke;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                switch (json_string.getData()[3])
                                  {
                                    case 'b':
                                        if (String.Compare(json_string.getData(), 4, "elief_", 0, 6, false) == 0)
                                          {
                                            switch (json_string.getData()[10])
                                              {
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Formal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Informal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'l':
                                        if ((String.Compare(json_string.getData(), 4, "ikeYou_Formal", 0, 13, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DislikeYou_Formal;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'm':
                                        if ((String.Compare(json_string.getData(), 4, "issal", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Dismissal;
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
                            case 'Y':
                                if (String.Compare(json_string.getData(), 3, "ou", 0, 2, false) == 0)
                                  {
                                    switch (json_string.getData()[5])
                                      {
                                        case 'D':
                                            if ((String.Compare(json_string.getData(), 6, "ream", 0, 4, false) == 0) && (json_string.getData().Length == 10))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouDream;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'G':
                                            if ((String.Compare(json_string.getData(), 6, "iveAChuck", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouGiveAChuck;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'L':
                                            switch (json_string.getData()[6])
                                              {
                                                case 'i':
                                                    if (String.Compare(json_string.getData(), 7, "ke", 0, 2, false) == 0)
                                                      {
                                                        switch (json_string.getData()[9])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(json_string.getData(), 10, "ood", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeFood;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'H':
                                                                if ((String.Compare(json_string.getData(), 10, "umans", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeHumans;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(json_string.getData(), 10, "yClothes", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeMyClothes;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'o':
                                                    if (String.Compare(json_string.getData(), 7, "veMe_", 0, 5, false) == 0)
                                                      {
                                                        switch (json_string.getData()[12])
                                                          {
                                                            case 'F':
                                                                if ((String.Compare(json_string.getData(), 13, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Formal;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'I':
                                                                if ((String.Compare(json_string.getData(), 13, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 20))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Informal;
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
                                  }
                                break;
                            case 'e':
                                if (String.Compare(json_string.getData(), 3, "s", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'H':
                                            if (String.Compare(json_string.getData(), 5, "eLoveMe_", 0, 8, false) == 0)
                                              {
                                                switch (json_string.getData()[13])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 14, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 14, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'S':
                                            if (String.Compare(json_string.getData(), 5, "heLoveMe_", 0, 9, false) == 0)
                                              {
                                                switch (json_string.getData()[14])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Informal;
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
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "glasAdams", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_DouglasAdams;
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
            case 'E':
                if (String.Compare(json_string.getData(), 1, "xcuseMe_", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Formal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Informal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'r':
                                switch (json_string.getData()[3])
                                  {
                                    case 'e':
                                        if (String.Compare(json_string.getData(), 4, "well_", 0, 5, false) == 0)
                                          {
                                            switch (json_string.getData()[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Formal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Informal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 't':
                                        if (json_string.getData().Length == 4)
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Fart;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "hersDay", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_FathersDay;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if (String.Compare(json_string.getData(), 2, "elBetter_", 0, 9, false) == 0)
                          {
                            switch (json_string.getData()[11])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "ipACoin", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_FlipACoin;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "rceBeWithYou", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ForceBeWithYou;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'G':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "od", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'B':
                                    if (String.Compare(json_string.getData(), 5, "ooks_", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(json_string.getData(), 5, "ovies_", 0, 6, false) == 0)
                                      {
                                        switch (json_string.getData()[11])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 5, "ight", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GoodNight;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "e", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'a':
                                    if ((String.Compare(json_string.getData(), 4, "tToSeeYou", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreatToSeeYou;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'e':
                                    if (String.Compare(json_string.getData(), 4, "tings", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[9])
                                          {
                                            case 'A':
                                                if ((String.Compare(json_string.getData(), 10, "lexaAndQuery", 0, 12, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsAlexaAndQuery;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'C':
                                                if (String.Compare(json_string.getData(), 10, "o", 0, 1, false) == 0)
                                                  {
                                                    switch (json_string.getData()[11])
                                                      {
                                                        case 'm':
                                                            if ((String.Compare(json_string.getData(), 12, "petitor", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCompetitor;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'r':
                                                            if ((String.Compare(json_string.getData(), 12, "tanaAndQuery", 0, 12, false) == 0) && (json_string.getData().Length == 24))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCortanaAndQuery;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'G':
                                                if ((String.Compare(json_string.getData(), 10, "alaxyAndQuery", 0, 13, false) == 0) && (json_string.getData().Length == 23))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsGalaxyAndQuery;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 10, "iriAndQuery", 0, 11, false) == 0) && (json_string.getData().Length == 21))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsSiriAndQuery;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case '_':
                                                switch (json_string.getData()[10])
                                                  {
                                                    case 'B':
                                                        if ((String.Compare(json_string.getData(), 11, "eforeMeal", 0, 9, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_BeforeMeal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'E':
                                                        switch (json_string.getData()[11])
                                                          {
                                                            case 'n':
                                                                if (String.Compare(json_string.getData(), 12, "dOf", 0, 3, false) == 0)
                                                                  {
                                                                    switch (json_string.getData()[15])
                                                                      {
                                                                        case 'W':
                                                                            if ((String.Compare(json_string.getData(), 16, "ork", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfWork;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 'Y':
                                                                            if ((String.Compare(json_string.getData(), 16, "ear", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfYear;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'v':
                                                                if ((String.Compare(json_string.getData(), 12, "ening", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Evening;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        switch (json_string.getData()[11])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(json_string.getData(), 12, "mHome", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_IAmHome;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'n':
                                                                if ((String.Compare(json_string.getData(), 12, "formal", 0, 6, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Informal;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                        break;
                                                    case 'M':
                                                        if ((String.Compare(json_string.getData(), 11, "orning", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Morning;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(json_string.getData(), 11, "elephone", 0, 8, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Telephone;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'V':
                                                        if ((String.Compare(json_string.getData(), 11, "isitHouse", 0, 9, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_VisitHouse;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'W':
                                                        if ((String.Compare(json_string.getData(), 11, "elcomeHome", 0, 10, false) == 0) && (json_string.getData().Length == 21))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_WelcomeHome;
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
            case 'H':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if (String.Compare(json_string.getData(), 2, "ppy", 0, 3, false) == 0)
                          {
                            switch (json_string.getData()[5])
                              {
                                case 'B':
                                    if ((String.Compare(json_string.getData(), 6, "irthday", 0, 7, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HappyBirthday;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 6, "ewYear", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HappyNewYear;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "w", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'A':
                                    if ((String.Compare(json_string.getData(), 4, "reKids", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowAreKids;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'D':
                                    if (String.Compare(json_string.getData(), 4, "oI", 0, 2, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'G':
                                                if ((String.Compare(json_string.getData(), 7, "etAGirlfriend", 0, 13, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIGetAGirlfriend;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'L':
                                                if ((String.Compare(json_string.getData(), 7, "andAirplane", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoILandAirplane;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 7, "topZombie", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIStopZombie;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'F':
                                    if (String.Compare(json_string.getData(), 4, "amily_", 0, 6, false) == 0)
                                      {
                                        switch (json_string.getData()[10])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'G':
                                    if (String.Compare(json_string.getData(), 4, "oing_", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[9])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'I':
                                    if (String.Compare(json_string.getData(), 4, "s", 0, 1, false) == 0)
                                      {
                                        switch (json_string.getData()[5])
                                          {
                                            case 'H':
                                                if ((String.Compare(json_string.getData(), 6, "usband", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsHusband;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 6, "ife", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsWife;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if (String.Compare(json_string.getData(), 4, "anyChucks_", 0, 10, false) == 0)
                                      {
                                        switch (json_string.getData()[14])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'O':
                                    if (String.Compare(json_string.getData(), 4, "ld_", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[7])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 8, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 8, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 4, "oGetRich", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowToGetRich;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'W':
                                    if (String.Compare(json_string.getData(), 4, "asWeekend_", 0, 10, false) == 0)
                                      {
                                        switch (json_string.getData()[14])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Informal;
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
            case 'I':
                switch (json_string.getData()[1])
                  {
                    case 'A':
                        if (String.Compare(json_string.getData(), 2, "m", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'S':
                                    if ((String.Compare(json_string.getData(), 4, "leepy", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IAmSleepy;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'Y':
                                    if (String.Compare(json_string.getData(), 4, "our", 0, 3, false) == 0)
                                      {
                                        switch (json_string.getData()[7])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 8, "ather", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourFather;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'M':
                                                if ((String.Compare(json_string.getData(), 8, "other", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourMother;
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
                    case 'D':
                        if ((String.Compare(json_string.getData(), 2, "islikeSomething", 0, 15, false) == 0) && (json_string.getData().Length == 17))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IDislikeSomething;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "ikeSomething", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ILikeSomething;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'f':
                        if (String.Compare(json_string.getData(), 2, "ATreeFalls_", 0, 11, false) == 0)
                          {
                            switch (json_string.getData()[13])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 14, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 14, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 21))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'n':
                        switch (json_string.getData()[2])
                          {
                            case 'c':
                                if ((String.Compare(json_string.getData(), 3, "onceivable", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Inconceivable;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 's':
                                if (String.Compare(json_string.getData(), 3, "ult_", 0, 4, false) == 0)
                                  {
                                    switch (json_string.getData()[7])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 8, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 8, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Informal;
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
                    case 's':
                        if ((String.Compare(json_string.getData(), 2, "aacAsimovMultivac", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_IsaacAsimovMultivac;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "sMyBirthday", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ItsMyBirthday;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'J':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "kes_", 0, 4, false) == 0)
                          {
                            switch (json_string.getData()[6])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 7, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 7, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "stKidding", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_JustKidding;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'K':
                if (String.Compare(json_string.getData(), 1, "nockKnock_", 0, 10, false) == 0)
                  {
                    switch (json_string.getData()[11])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 12, "xitMode", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_ExitMode;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Formal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Informal;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if (String.Compare(json_string.getData(), 12, "ame_", 0, 4, false) == 0)
                              {
                                switch (json_string.getData()[16])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 17, "rokenPencil", 0, 11, false) == 0) && (json_string.getData().Length == 28))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_BrokenPencil;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 17, "oris", 0, 4, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Doris;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        switch (json_string.getData()[17])
                                          {
                                            case 'a':
                                                if ((String.Compare(json_string.getData(), 18, "nk", 0, 2, false) == 0) && (json_string.getData().Length == 20))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Tank;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'o':
                                                if (json_string.getData().Length == 18)
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_To;
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
                              }
                            break;
                        case 'P':
                            if (String.Compare(json_string.getData(), 12, "unchline_", 0, 9, false) == 0)
                              {
                                switch (json_string.getData()[21])
                                  {
                                    case 'B':
                                        if ((String.Compare(json_string.getData(), 22, "rokenPencil", 0, 11, false) == 0) && (json_string.getData().Length == 33))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_BrokenPencil;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 22, "oris", 0, 4, false) == 0) && (json_string.getData().Length == 26))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Doris;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        switch (json_string.getData()[22])
                                          {
                                            case 'a':
                                                if ((String.Compare(json_string.getData(), 23, "nk", 0, 2, false) == 0) && (json_string.getData().Length == 25))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Tank;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'o':
                                                if (json_string.getData().Length == 23)
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_To;
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
                              }
                            break;
                        case 'U':
                            if ((String.Compare(json_string.getData(), 12, "serPunchline", 0, 12, false) == 0) && (json_string.getData().Length == 24))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_UserPunchline;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 12, "hosThere", 0, 8, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_WhosThere;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "tsPlayGame", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LetsPlayGame;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "keYou_", 0, 6, false) == 0)
                          {
                            switch (json_string.getData()[8])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 9, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 9, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Informal;
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
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "ely", 0, 3, false) == 0) && (json_string.getData().Length == 6))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Lonely;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'o':
                                if (String.Compare(json_string.getData(), 3, "k", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'B':
                                            if (String.Compare(json_string.getData(), 5, "uffed_", 0, 6, false) == 0)
                                              {
                                                switch (json_string.getData()[11])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'L':
                                            if (String.Compare(json_string.getData(), 5, "ike_", 0, 4, false) == 0)
                                              {
                                                switch (json_string.getData()[9])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Informal;
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
                            case 's':
                                if (String.Compare(json_string.getData(), 3, "tWeight_", 0, 8, false) == 0)
                                  {
                                    switch (json_string.getData()[11])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 12, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 12, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 19))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Informal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'v':
                                if (String.Compare(json_string.getData(), 3, "eYou_", 0, 5, false) == 0)
                                  {
                                    switch (json_string.getData()[8])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 9, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 9, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Informal;
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
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "eMeASandwich", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MakeMeASandwich;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'r':
                                if (String.Compare(json_string.getData(), 3, "ryMe_", 0, 5, false) == 0)
                                  {
                                    switch (json_string.getData()[8])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 9, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 9, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Informal;
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
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if (String.Compare(json_string.getData(), 3, "ningOfLife_", 0, 11, false) == 0)
                                  {
                                    switch (json_string.getData()[14])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Informal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if ((String.Compare(json_string.getData(), 3, "ryChristmas", 0, 11, false) == 0) && (json_string.getData().Length == 14))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MerryChristmas;
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
                            case 'n':
                                if (String.Compare(json_string.getData(), 3, "tyPython", 0, 8, false) == 0)
                                  {
                                    switch (json_string.getData()[11])
                                      {
                                        case 'K':
                                            if ((String.Compare(json_string.getData(), 12, "nowAboutSwallows", 0, 16, false) == 0) && (json_string.getData().Length == 28))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonKnowAboutSwallows;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'Q':
                                            if ((String.Compare(json_string.getData(), 12, "uest", 0, 4, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonQuest;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'U':
                                            if ((String.Compare(json_string.getData(), 12, "nladenSwallow", 0, 13, false) == 0) && (json_string.getData().Length == 25))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonUnladenSwallow;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "hersDay", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_MothersDay;
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
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if (String.Compare(json_string.getData(), 2, "ce", 0, 2, false) == 0)
                          {
                            switch (json_string.getData()[4])
                              {
                                case 'J':
                                    if ((String.Compare(json_string.getData(), 5, "oke", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_NiceJoke;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 5, "oMeetYou", 0, 8, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_NiceToMeetYou;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if (json_string.getData().Length == 2)
                          {
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_No;
                                goto open_enum_is_done;
                              }
                          }
                        switch (json_string.getData()[2])
                          {
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "Average", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_NotAverage;
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
            case 'O':
                switch (json_string.getData()[1])
                  {
                    case 'n':
                        if (String.Compare(json_string.getData(), 2, "eHandClapping_", 0, 14, false) == 0)
                          {
                            switch (json_string.getData()[16])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 17, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 17, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 24))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 2, "enPodBay", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_OpenPodBay;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if ((String.Compare(json_string.getData(), 3, "ce", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Peace;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'n':
                                if (String.Compare(json_string.getData(), 3, "nyThoughts_", 0, 11, false) == 0)
                                  {
                                    switch (json_string.getData()[14])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Informal;
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
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "s", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'i':
                                    if (String.Compare(json_string.getData(), 4, "tive_", 0, 5, false) == 0)
                                      {
                                        switch (json_string.getData()[9])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 't':
                                    if ((String.Compare(json_string.getData(), 4, "Question", 0, 8, false) == 0) && (json_string.getData().Length == 12))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_PostQuestion;
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
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "p", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Rap;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "manticQuote", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_RomanticQuote;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "yMyName", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SayMyName;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "lfDestruct", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SelfDestruct;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "utUp_", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 8, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 8, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ng", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Sing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ackStadium", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SnackStadium;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "methingIDontKnow", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SomethingIDontKnow;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'p':
                        if (String.Compare(json_string.getData(), 2, "areTime_", 0, 8, false) == 0)
                          {
                            switch (json_string.getData()[10])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if (String.Compare(json_string.getData(), 3, "rWars", 0, 5, false) == 0)
                                  {
                                    switch (json_string.getData()[8])
                                      {
                                        case 'D':
                                            if ((String.Compare(json_string.getData(), 9, "roids", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsDroids;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 9, "orce", 0, 4, false) == 0) && (json_string.getData().Length == 13))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsForce;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if (String.Compare(json_string.getData(), 3, "ryTime_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Informal;
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
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "doMakeMeASandwich", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_SudoMakeMeASandwich;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        switch (json_string.getData()[2])
                          {
                            case 'k':
                                if ((String.Compare(json_string.getData(), 3, "eOverWorld", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TakeOverWorld;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'l':
                                if (String.Compare(json_string.getData(), 3, "kDirty_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Informal;
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
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "sting", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Testing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        if (String.Compare(json_string.getData(), 2, "ankYou_", 0, 7, false) == 0)
                          {
                            switch (json_string.getData()[9])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Informal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'i':
                        switch (json_string.getData()[2])
                          {
                            case 'm':
                                if (String.Compare(json_string.getData(), 3, "eFlies_", 0, 7, false) == 0)
                                  {
                                    switch (json_string.getData()[10])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Informal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'r':
                                if (String.Compare(json_string.getData(), 3, "ed_", 0, 3, false) == 0)
                                  {
                                    switch (json_string.getData()[6])
                                      {
                                        case 'F':
                                            if ((String.Compare(json_string.getData(), 7, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 12))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Formal;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'I':
                                            if ((String.Compare(json_string.getData(), 7, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Informal;
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
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ngueTwister", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_TongueTwister;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ntToDateMe", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WantToDateMe;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "lcome", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Welcome;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'h':
                        switch (json_string.getData()[2])
                          {
                            case 'a':
                                if (String.Compare(json_string.getData(), 3, "t", 0, 1, false) == 0)
                                  {
                                    switch (json_string.getData()[4])
                                      {
                                        case 'A':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'P':
                                                    if ((String.Compare(json_string.getData(), 6, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAPain;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'r':
                                                    if ((String.Compare(json_string.getData(), 6, "eYourInterests", 0, 14, false) == 0) && (json_string.getData().Length == 20))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAreYourInterests;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'C':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'h':
                                                    if ((String.Compare(json_string.getData(), 6, "ineseZodiac", 0, 11, false) == 0) && (json_string.getData().Length == 17))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatChineseZodiac;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'o':
                                                    if ((String.Compare(json_string.getData(), 6, "lorAreYou", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatColorAreYou;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        case 'D':
                                            if (String.Compare(json_string.getData(), 5, "o", 0, 1, false) == 0)
                                              {
                                                switch (json_string.getData()[6])
                                                  {
                                                    case 'Y':
                                                        if ((String.Compare(json_string.getData(), 7, "ouThinkOf_Informal", 0, 18, false) == 0) && (json_string.getData().Length == 25))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoYouThinkOf_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'e':
                                                        if (String.Compare(json_string.getData(), 7, "sThe", 0, 4, false) == 0)
                                                          {
                                                            switch (json_string.getData()[11])
                                                              {
                                                                case 'C':
                                                                    if ((String.Compare(json_string.getData(), 12, "atSay", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheCatSay;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'F':
                                                                    if ((String.Compare(json_string.getData(), 12, "oxSay", 0, 5, false) == 0) && (json_string.getData().Length == 17))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheFoxSay;
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
                                        case 'I':
                                            if (String.Compare(json_string.getData(), 5, "s", 0, 1, false) == 0)
                                              {
                                                switch (json_string.getData()[6])
                                                  {
                                                    case 'M':
                                                        if (String.Compare(json_string.getData(), 7, "y", 0, 1, false) == 0)
                                                          {
                                                            switch (json_string.getData()[8])
                                                              {
                                                                case 'B':
                                                                    if ((String.Compare(json_string.getData(), 9, "irthDay_Informal", 0, 16, false) == 0) && (json_string.getData().Length == 25))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyBirthDay_Informal;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'N':
                                                                    if ((String.Compare(json_string.getData(), 9, "ame_Informal", 0, 12, false) == 0) && (json_string.getData().Length == 21))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyName_Informal;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'Y':
                                                        if ((String.Compare(json_string.getData(), 7, "ourName_Informal", 0, 16, false) == 0) && (json_string.getData().Length == 23))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsYourName_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'M':
                                            if ((String.Compare(json_string.getData(), 5, "usicDoYouLike", 0, 13, false) == 0) && (json_string.getData().Length == 18))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatMusicDoYouLike;
                                                    goto open_enum_is_done;
                                                  }
                                            break;
                                        case 'S':
                                            if (String.Compare(json_string.getData(), 5, "houldIDo_", 0, 9, false) == 0)
                                              {
                                                switch (json_string.getData()[14])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'T':
                                            if (String.Compare(json_string.getData(), 5, "o", 0, 1, false) == 0)
                                              {
                                                switch (json_string.getData()[6])
                                                  {
                                                    case 'E':
                                                        if (String.Compare(json_string.getData(), 7, "at_", 0, 3, false) == 0)
                                                          {
                                                            switch (json_string.getData()[10])
                                                              {
                                                                case 'F':
                                                                    if ((String.Compare(json_string.getData(), 11, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 16))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Formal;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                case 'I':
                                                                    if ((String.Compare(json_string.getData(), 11, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 18))
                                                                          {
                                                                            the_open_enum.in_known_list = true;
                                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Informal;
                                                                            goto open_enum_is_done;
                                                                          }
                                                                    break;
                                                                default:
                                                                    break;
                                                              }
                                                          }
                                                        break;
                                                    case 'S':
                                                        if ((String.Compare(json_string.getData(), 7, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 9))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToSay;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'W':
                                            if (String.Compare(json_string.getData(), 5, "earing_", 0, 7, false) == 0)
                                              {
                                                switch (json_string.getData()[12])
                                                  {
                                                    case 'F':
                                                        if ((String.Compare(json_string.getData(), 13, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Formal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'I':
                                                        if ((String.Compare(json_string.getData(), 13, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 20))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Informal;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 's':
                                            switch (json_string.getData()[5])
                                              {
                                                case 'F':
                                                    if (String.Compare(json_string.getData(), 6, "avorite", 0, 7, false) == 0)
                                                      {
                                                        switch (json_string.getData()[13])
                                                          {
                                                            case 'A':
                                                                if ((String.Compare(json_string.getData(), 14, "nimal", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteAnimal;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'C':
                                                                if ((String.Compare(json_string.getData(), 14, "olor", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteColor;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'F':
                                                                if ((String.Compare(json_string.getData(), 14, "ood", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteFood;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'M':
                                                                if ((String.Compare(json_string.getData(), 14, "ovie", 0, 4, false) == 0) && (json_string.getData().Length == 18))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteMovie;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 6, "nAName", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsInAName;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'U':
                                                    if (String.Compare(json_string.getData(), 6, "p", 0, 1, false) == 0)
                                                      {
                                                        switch (json_string.getData()[7])
                                                          {
                                                            case 'D':
                                                                if ((String.Compare(json_string.getData(), 8, "oc", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUpDoc;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case '_':
                                                                switch (json_string.getData()[8])
                                                                  {
                                                                    case 'F':
                                                                        if ((String.Compare(json_string.getData(), 9, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Formal;
                                                                                goto open_enum_is_done;
                                                                              }
                                                                        break;
                                                                    case 'I':
                                                                        if ((String.Compare(json_string.getData(), 9, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                                                              {
                                                                                the_open_enum.in_known_list = true;
                                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Informal;
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
                                                      }
                                                    break;
                                                case 'Y':
                                                    if (String.Compare(json_string.getData(), 6, "our", 0, 3, false) == 0)
                                                      {
                                                        switch (json_string.getData()[9])
                                                          {
                                                            case 'A':
                                                                if (String.Compare(json_string.getData(), 10, "ge_", 0, 3, false) == 0)
                                                                  {
                                                                    switch (json_string.getData()[13])
                                                                      {
                                                                        case 'F':
                                                                            if ((String.Compare(json_string.getData(), 14, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Formal;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        case 'I':
                                                                            if ((String.Compare(json_string.getData(), 14, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 21))
                                                                                  {
                                                                                    the_open_enum.in_known_list = true;
                                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Informal;
                                                                                    goto open_enum_is_done;
                                                                                  }
                                                                            break;
                                                                        default:
                                                                            break;
                                                                      }
                                                                  }
                                                                break;
                                                            case 'P':
                                                                if ((String.Compare(json_string.getData(), 10, "honeNumber", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourPhoneNumber;
                                                                        goto open_enum_is_done;
                                                                      }
                                                                break;
                                                            case 'S':
                                                                if ((String.Compare(json_string.getData(), 10, "ign", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                                                      {
                                                                        the_open_enum.in_known_list = true;
                                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourSign;
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
                                  }
                                break;
                            case 'e':
                                switch (json_string.getData()[3])
                                  {
                                    case 'n':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'B':
                                                if (String.Compare(json_string.getData(), 5, "orn_", 0, 4, false) == 0)
                                                  {
                                                    switch (json_string.getData()[9])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Formal;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Informal;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 5, "sYourBirthDay_Informal", 0, 22, false) == 0) && (json_string.getData().Length == 27))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhenIsYourBirthDay_Informal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'W':
                                                if ((String.Compare(json_string.getData(), 5, "illWorldEnd", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhenWillWorldEnd;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 'r':
                                        if (String.Compare(json_string.getData(), 4, "e", 0, 1, false) == 0)
                                          {
                                            switch (json_string.getData()[5])
                                              {
                                                case 'A':
                                                    if ((String.Compare(json_string.getData(), 6, "reYou", 0, 5, false) == 0) && (json_string.getData().Length == 11))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhereAreYou;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(json_string.getData(), 6, "oYouLive", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhereDoYouLive;
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
                            case 'o':
                                switch (json_string.getData()[3])
                                  {
                                    case 'A':
                                        if ((String.Compare(json_string.getData(), 4, "mI", 0, 2, false) == 0) && (json_string.getData().Length == 6))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhoAmI;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 's':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'O':
                                                if (String.Compare(json_string.getData(), 5, "nFirst_", 0, 7, false) == 0)
                                                  {
                                                    switch (json_string.getData()[12])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 13, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Formal;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(json_string.getData(), 13, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Informal;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'Y':
                                                if (String.Compare(json_string.getData(), 5, "ourDaddy_", 0, 9, false) == 0)
                                                  {
                                                    switch (json_string.getData()[14])
                                                      {
                                                        case 'F':
                                                            if ((String.Compare(json_string.getData(), 15, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 20))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Formal;
                                                                    goto open_enum_is_done;
                                                                  }
                                                            break;
                                                        case 'I':
                                                            if ((String.Compare(json_string.getData(), 15, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 22))
                                                                  {
                                                                    the_open_enum.in_known_list = true;
                                                                    the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Informal;
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
                            case 'y':
                                switch (json_string.getData()[3])
                                  {
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 4, "iretruckRed", 0, 11, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhyFiretruckRed;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if (String.Compare(json_string.getData(), 4, "oBad_", 0, 5, false) == 0)
                                          {
                                            switch (json_string.getData()[9])
                                              {
                                                case 'F':
                                                    if ((String.Compare(json_string.getData(), 10, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 15))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Formal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'I':
                                                    if ((String.Compare(json_string.getData(), 10, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Informal;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case '_':
                                        switch (json_string.getData()[4])
                                          {
                                            case 'F':
                                                if ((String.Compare(json_string.getData(), 5, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Formal;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'I':
                                                if ((String.Compare(json_string.getData(), 5, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Informal;
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
                            default:
                                break;
                          }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "rkingHard_", 0, 10, false) == 0)
                          {
                            switch (json_string.getData()[12])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 13, "ormal", 0, 5, false) == 0) && (json_string.getData().Length == 18))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Formal;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'I':
                                    if ((String.Compare(json_string.getData(), 13, "nformal", 0, 7, false) == 0) && (json_string.getData().Length == 20))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Informal;
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
            case 'Y':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "s", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_Yes;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if (String.Compare(json_string.getData(), 2, "u", 0, 1, false) == 0)
                          {
                            switch (json_string.getData()[3])
                              {
                                case 'A':
                                    if (String.Compare(json_string.getData(), 4, "re", 0, 2, false) == 0)
                                      {
                                        switch (json_string.getData()[6])
                                          {
                                            case 'C':
                                                switch (json_string.getData()[7])
                                                  {
                                                    case 'o':
                                                        if ((String.Compare(json_string.getData(), 8, "ol", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCool;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'u':
                                                        if ((String.Compare(json_string.getData(), 8, "te", 0, 2, false) == 0) && (json_string.getData().Length == 10))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCute;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                                break;
                                            case 'K':
                                                if ((String.Compare(json_string.getData(), 7, "ind", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreKind;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'R':
                                                if ((String.Compare(json_string.getData(), 7, "ude", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreRude;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            case 'S':
                                                if ((String.Compare(json_string.getData(), 7, "exy", 0, 3, false) == 0) && (json_string.getData().Length == 10))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreSexy;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 4, "alkinToMe", 0, 9, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeNormalizedQueryKnownValues.NormalizedQuery_YouTalkinToMe;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setNormalizedQuery(the_open_enum);
      }


    public SmallTalkInformationNuggetJSON()
      {
        flagHasUserName = false;
        flagHasForcedResponse = false;
        flagHasNormalizedQuery = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "SmallTalk";
      }

    public bool  hasUserName()
      {
        return flagHasUserName;
      }

    public UserNameJSON   getUserName()
      {
        Debug.Assert(flagHasUserName);
        return storeUserName;
      }

    public bool  hasForcedResponse()
      {
        return flagHasForcedResponse;
      }

    public DynamicResponseJSON   getForcedResponse()
      {
        Debug.Assert(flagHasForcedResponse);
        return storeForcedResponse;
      }

    public bool  hasNormalizedQuery()
      {
        return flagHasNormalizedQuery;
      }

    public TypeNormalizedQuery  getNormalizedQuery()
      {
        Debug.Assert(flagHasNormalizedQuery);
        return storeNormalizedQuery;
      }

    public string  getNormalizedQueryAsString()
      {
        TypeNormalizedQuery result = getNormalizedQuery();
        if (result.in_known_list)
            return stringFromNormalizedQuery(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSmallTalkInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSmallTalkInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSmallTalkInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSmallTalkInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasUserName)
            ++result;
        if (flagHasForcedResponse)
            ++result;
        if (flagHasNormalizedQuery)
            ++result;
        result += extraSmallTalkInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserName)
          {
            if (remainder == 0)
                return "UserName";
            --remainder;
          }
        if (flagHasForcedResponse)
          {
            if (remainder == 0)
                return "ForcedResponse";
            --remainder;
          }
        if (flagHasNormalizedQuery)
          {
            if (remainder == 0)
                return "NormalizedQuery";
            --remainder;
          }
        return extraSmallTalkInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserName)
          {
            if (remainder == 0)
                return extraUserNameToJSON();
            --remainder;
          }
        if (flagHasForcedResponse)
          {
            if (remainder == 0)
                return extraForcedResponseToJSON();
            --remainder;
          }
        if (flagHasNormalizedQuery)
          {
            if (remainder == 0)
                return extraNormalizedQueryToJSON();
            --remainder;
          }
        return extraSmallTalkInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if ((String.Compare(field_name, 1, "orcedResponse", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasForcedResponse ? extraForcedResponseToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ormalizedQuery", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasNormalizedQuery ? extraNormalizedQueryToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasUserName ? extraUserNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraSmallTalkInformationNuggetLookup(field_name);
      }

    public void setUserName(UserNameJSON  new_value)
      {
        if (flagHasUserName)
          {
          }
        flagHasUserName = true;
        storeUserName = new_value;
      }
    public void unsetUserName()
      {
        if (flagHasUserName)
          {
          }
        flagHasUserName = false;
      }
    public void setForcedResponse(DynamicResponseJSON  new_value)
      {
        if (flagHasForcedResponse)
          {
          }
        flagHasForcedResponse = true;
        storeForcedResponse = new_value;
      }
    public void unsetForcedResponse()
      {
        if (flagHasForcedResponse)
          {
          }
        flagHasForcedResponse = false;
      }
    public void setNormalizedQuery(TypeNormalizedQuery new_value)
      {
        flagHasNormalizedQuery = true;
        storeNormalizedQuery = new_value;
      }
    public void setNormalizedQuery(string chars)
      {
        TypeNormalizedQueryKnownValues known = stringToNormalizedQuery(chars);
        TypeNormalizedQuery new_value = new TypeNormalizedQuery();
        if (known == TypeNormalizedQueryKnownValues.NormalizedQuery__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setNormalizedQuery(new_value);
      }
    public void setNormalizedQuery(TypeNormalizedQueryKnownValues new_value)
      {
        TypeNormalizedQuery new_full_value = new TypeNormalizedQuery();
        Debug.Assert(new_value != TypeNormalizedQueryKnownValues.NormalizedQuery__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setNormalizedQuery(new_full_value);
      }
    public void unsetNormalizedQuery()
      {
        flagHasNormalizedQuery = false;
      }

    public virtual void extraSmallTalkInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSmallTalkInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSmallTalkInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSmallTalkInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "orcedResponse", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONForcedResponse(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ormalizedQuery", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONNormalizedQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSmallTalkInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "orcedResponse", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONForcedResponse(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ormalizedQuery", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONNormalizedQuery(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONUserName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSmallTalkInformationNuggetSetField(key, new_component);
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
        if (flagHasUserName)
          {
            handler.start_pair("UserName");
            if (partial_allowed)
                storeUserName.write_partial_as_json(handler);
            else
                storeUserName.write_as_json(handler);
          }
        if (flagHasForcedResponse)
          {
            handler.start_pair("ForcedResponse");
            if (partial_allowed)
                storeForcedResponse.write_partial_as_json(handler);
            else
                storeForcedResponse.write_as_json(handler);
          }
        if (flagHasNormalizedQuery)
          {
            handler.start_pair("NormalizedQuery");
            if (storeNormalizedQuery.in_known_list)
              {
                switch (storeNormalizedQuery.list_value)
                  {
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouARealPerson:
                        handler.string_value("AreYouARealPerson");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Formal:
                        handler.string_value("BadDay_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BadDay_Informal:
                        handler.string_value("BadDay_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Formal:
                        handler.string_value("BestFriend_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BestFriend_Informal:
                        handler.string_value("BestFriend_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Formal:
                        handler.string_value("Compliment_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Compliment_Informal:
                        handler.string_value("Compliment_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Formal:
                        handler.string_value("Disbelief_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Disbelief_Informal:
                        handler.string_value("Disbelief_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Formal:
                        handler.string_value("ExcuseMe_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ExcuseMe_Informal:
                        handler.string_value("ExcuseMe_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Formal:
                        handler.string_value("Farewell_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Farewell_Informal:
                        handler.string_value("Farewell_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Formal:
                        handler.string_value("Greetings_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Informal:
                        handler.string_value("Greetings_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyBirthday:
                        handler.string_value("HappyBirthday");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ItsMyBirthday:
                        handler.string_value("ItsMyBirthday");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Inconceivable:
                        handler.string_value("Inconceivable");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Formal:
                        handler.string_value("Insult_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Insult_Informal:
                        handler.string_value("Insult_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Formal:
                        handler.string_value("KnockKnock_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Informal:
                        handler.string_value("KnockKnock_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_WhosThere:
                        handler.string_value("KnockKnock_WhosThere");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_BrokenPencil:
                        handler.string_value("KnockKnock_Name_BrokenPencil");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_BrokenPencil:
                        handler.string_value("KnockKnock_Punchline_BrokenPencil");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Doris:
                        handler.string_value("KnockKnock_Name_Doris");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Doris:
                        handler.string_value("KnockKnock_Punchline_Doris");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_Tank:
                        handler.string_value("KnockKnock_Name_Tank");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_Tank:
                        handler.string_value("KnockKnock_Punchline_Tank");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Name_To:
                        handler.string_value("KnockKnock_Name_To");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_Punchline_To:
                        handler.string_value("KnockKnock_Punchline_To");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_UserPunchline:
                        handler.string_value("KnockKnock_UserPunchline");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_KnockKnock_ExitMode:
                        handler.string_value("KnockKnock_ExitMode");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Formal:
                        handler.string_value("LikeYou_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LikeYou_Informal:
                        handler.string_value("LikeYou_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Formal:
                        handler.string_value("LoveYou_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LoveYou_Informal:
                        handler.string_value("LoveYou_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceToMeetYou:
                        handler.string_value("NiceToMeetYou");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Peace:
                        handler.string_value("Peace");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Formal:
                        handler.string_value("Positive_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Positive_Informal:
                        handler.string_value("Positive_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Testing:
                        handler.string_value("Testing");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Formal:
                        handler.string_value("ThankYou_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ThankYou_Informal:
                        handler.string_value("ThankYou_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Formal:
                        handler.string_value("TimeFlies_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TimeFlies_Informal:
                        handler.string_value("TimeFlies_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Formal:
                        handler.string_value("Tired_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Tired_Informal:
                        handler.string_value("Tired_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreSexy:
                        handler.string_value("YouAreSexy");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Yes:
                        handler.string_value("Yes");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_No:
                        handler.string_value("No");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToSay:
                        handler.string_value("WhatToSay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BeamMeUp:
                        handler.string_value("BeamMeUp");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Formal:
                        handler.string_value("BeThatWay_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BeThatWay_Informal:
                        handler.string_value("BeThatWay_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Formal:
                        handler.string_value("FeelBetter_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_FeelBetter_Informal:
                        handler.string_value("FeelBetter_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_FlipACoin:
                        handler.string_value("FlipACoin");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_RomanticQuote:
                        handler.string_value("RomanticQuote");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TongueTwister:
                        handler.string_value("TongueTwister");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Formal:
                        handler.string_value("Jokes_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Jokes_Informal:
                        handler.string_value("Jokes_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_OpenPodBay:
                        handler.string_value("OpenPodBay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SayMyName:
                        handler.string_value("SayMyName");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Formal:
                        handler.string_value("ShutUp_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ShutUp_Informal:
                        handler.string_value("ShutUp_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Rap:
                        handler.string_value("Rap");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Sing:
                        handler.string_value("Sing");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Beatbox:
                        handler.string_value("Beatbox");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Fart:
                        handler.string_value("Fart");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MakeMeASandwich:
                        handler.string_value("MakeMeASandwich");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SudoMakeMeASandwich:
                        handler.string_value("SudoMakeMeASandwich");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SomethingIDontKnow:
                        handler.string_value("SomethingIDontKnow");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Formal:
                        handler.string_value("StoryTime_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_StoryTime_Informal:
                        handler.string_value("StoryTime_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Formal:
                        handler.string_value("TalkDirty_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TalkDirty_Informal:
                        handler.string_value("TalkDirty_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AskAQuestion:
                        handler.string_value("AskAQuestion");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Informal:
                        handler.string_value("AnyKids_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyKids_Formal:
                        handler.string_value("AnyKids_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyName_Informal:
                        handler.string_value("WhatIsMyName_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsMyBirthDay_Informal:
                        handler.string_value("WhatIsMyBirthDay_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenIsYourBirthDay_Informal:
                        handler.string_value("WhenIsYourBirthDay_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Informal:
                        handler.string_value("AnyPlans_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AnyPlans_Formal:
                        handler.string_value("AnyPlans_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Formal:
                        handler.string_value("BoxersOrBriefs_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BoxersOrBriefs_Informal:
                        handler.string_value("BoxersOrBriefs_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Formal:
                        handler.string_value("CatchGame_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_CatchGame_Informal:
                        handler.string_value("CatchGame_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Formal:
                        handler.string_value("DeadBody_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DeadBody_Informal:
                        handler.string_value("DeadBody_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Formal:
                        handler.string_value("DoesHeLoveMe_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesHeLoveMe_Informal:
                        handler.string_value("DoesHeLoveMe_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Formal:
                        handler.string_value("DoesSheLoveMe_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoesSheLoveMe_Informal:
                        handler.string_value("DoesSheLoveMe_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Formal:
                        handler.string_value("DoYouLoveMe_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLoveMe_Informal:
                        handler.string_value("DoYouLoveMe_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Formal:
                        handler.string_value("GoodBooks_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodBooks_Informal:
                        handler.string_value("GoodBooks_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Formal:
                        handler.string_value("GoodMovies_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodMovies_Informal:
                        handler.string_value("GoodMovies_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Formal:
                        handler.string_value("HowFamily_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowFamily_Informal:
                        handler.string_value("HowFamily_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Formal:
                        handler.string_value("HowGoing_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowGoing_Informal:
                        handler.string_value("HowGoing_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Formal:
                        handler.string_value("HowManyChucks_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowManyChucks_Informal:
                        handler.string_value("HowManyChucks_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Formal:
                        handler.string_value("HowOld_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowOld_Informal:
                        handler.string_value("HowOld_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Formal:
                        handler.string_value("WhatsYourAge_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourAge_Informal:
                        handler.string_value("WhatsYourAge_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Formal:
                        handler.string_value("WhenBorn_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenBorn_Informal:
                        handler.string_value("WhenBorn_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Formal:
                        handler.string_value("HowWasWeekend_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowWasWeekend_Informal:
                        handler.string_value("HowWasWeekend_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Formal:
                        handler.string_value("IfATreeFalls_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IfATreeFalls_Informal:
                        handler.string_value("IfATreeFalls_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Formal:
                        handler.string_value("LookBuffed_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LookBuffed_Informal:
                        handler.string_value("LookBuffed_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Formal:
                        handler.string_value("LookLike_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LookLike_Informal:
                        handler.string_value("LookLike_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Formal:
                        handler.string_value("LostWeight_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LostWeight_Informal:
                        handler.string_value("LostWeight_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Formal:
                        handler.string_value("MarryMe_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MarryMe_Informal:
                        handler.string_value("MarryMe_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Formal:
                        handler.string_value("MeaningOfLife_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MeaningOfLife_Informal:
                        handler.string_value("MeaningOfLife_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Formal:
                        handler.string_value("OneHandClapping_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_OneHandClapping_Informal:
                        handler.string_value("OneHandClapping_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Formal:
                        handler.string_value("PennyThoughts_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_PennyThoughts_Informal:
                        handler.string_value("PennyThoughts_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Formal:
                        handler.string_value("SpareTime_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SpareTime_Informal:
                        handler.string_value("SpareTime_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Formal:
                        handler.string_value("WhatShouldIDo_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatShouldIDo_Informal:
                        handler.string_value("WhatShouldIDo_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Formal:
                        handler.string_value("WhatsUp_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUp_Informal:
                        handler.string_value("WhatsUp_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Formal:
                        handler.string_value("WhatToEat_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatToEat_Informal:
                        handler.string_value("WhatToEat_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Formal:
                        handler.string_value("WhatWearing_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatWearing_Informal:
                        handler.string_value("WhatWearing_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Formal:
                        handler.string_value("WhosYourDaddy_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosYourDaddy_Informal:
                        handler.string_value("WhosYourDaddy_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Formal:
                        handler.string_value("WhosOnFirst_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhosOnFirst_Informal:
                        handler.string_value("WhosOnFirst_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Formal:
                        handler.string_value("Why_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Why_Informal:
                        handler.string_value("Why_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Formal:
                        handler.string_value("WhySoBad_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhySoBad_Informal:
                        handler.string_value("WhySoBad_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Formal:
                        handler.string_value("WorkingHard_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WorkingHard_Informal:
                        handler.string_value("WorkingHard_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ChickenCrossRoad:
                        handler.string_value("ChickenCrossRoad");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowAreKids:
                        handler.string_value("HowAreKids");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsHusband:
                        handler.string_value("HowIsHusband");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowIsWife:
                        handler.string_value("HowIsWife");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowToGetRich:
                        handler.string_value("HowToGetRich");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_TakeOverWorld:
                        handler.string_value("TakeOverWorld");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsInAName:
                        handler.string_value("WhatsInAName");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsUpDoc:
                        handler.string_value("WhatsUpDoc");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhoAmI:
                        handler.string_value("WhoAmI");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouTalkinToMe:
                        handler.string_value("YouTalkinToMe");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSure:
                        handler.string_value("AreYouSure");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouHearMe:
                        handler.string_value("CanYouHearMe");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouThere:
                        handler.string_value("AreYouThere");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_NotAverage:
                        handler.string_value("NotAverage");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsDroids:
                        handler.string_value("StarWarsDroids");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_StarWarsForce:
                        handler.string_value("StarWarsForce");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ForceBeWithYou:
                        handler.string_value("ForceBeWithYou");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DouglasAdams:
                        handler.string_value("DouglasAdams");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WantToDateMe:
                        handler.string_value("WantToDateMe");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DirtyJoke:
                        handler.string_value("DirtyJoke");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreatToSeeYou:
                        handler.string_value("GreatToSeeYou");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAreYourInterests:
                        handler.string_value("WhatAreYourInterests");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatMusicDoYouLike:
                        handler.string_value("WhatMusicDoYouLike");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonUnladenSwallow:
                        handler.string_value("MontyPythonUnladenSwallow");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonKnowAboutSwallows:
                        handler.string_value("MontyPythonKnowAboutSwallows");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IsaacAsimovMultivac:
                        handler.string_value("IsaacAsimovMultivac");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SelfDestruct:
                        handler.string_value("SelfDestruct");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAManOrAWoman:
                        handler.string_value("AreYouAManOrAWoman");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSkynet:
                        handler.string_value("AreYouSkynet");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHal:
                        handler.string_value("AreYouHal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGlados:
                        handler.string_value("AreYouGlados");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBorg:
                        handler.string_value("AreYouBorg");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouTheMatrix:
                        handler.string_value("AreYouTheMatrix");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSingle:
                        handler.string_value("AreYouSingle");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeHumans:
                        handler.string_value("DoYouLikeHumans");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouDream:
                        handler.string_value("DoYouDream");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DidYouFart:
                        handler.string_value("DidYouFart");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereDoYouLive:
                        handler.string_value("WhereDoYouLive");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MontyPythonQuest:
                        handler.string_value("MontyPythonQuest");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteMovie:
                        handler.string_value("WhatsFavoriteMovie");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIGetAGirlfriend:
                        handler.string_value("HowDoIGetAGirlfriend");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_PostQuestion:
                        handler.string_value("PostQuestion");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_JustKidding:
                        handler.string_value("JustKidding");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_CanYouDoTricks:
                        handler.string_value("CanYouDoTricks");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhereAreYou:
                        handler.string_value("WhereAreYou");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCute:
                        handler.string_value("YouAreCute");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheFoxSay:
                        handler.string_value("WhatDoesTheFoxSay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourSign:
                        handler.string_value("WhatsYourSign");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BarkLikeADog:
                        handler.string_value("BarkLikeADog");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_BlessYourHeart:
                        handler.string_value("BlessYourHeart");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCompetitor:
                        handler.string_value("GreetingsCompetitor");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsSiriAndQuery:
                        handler.string_value("GreetingsSiriAndQuery");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsAlexaAndQuery:
                        handler.string_value("GreetingsAlexaAndQuery");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsCortanaAndQuery:
                        handler.string_value("GreetingsCortanaAndQuery");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GreetingsGalaxyAndQuery:
                        handler.string_value("GreetingsGalaxyAndQuery");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_SnackStadium:
                        handler.string_value("SnackStadium");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Cancel:
                        handler.string_value("Cancel");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_NiceJoke:
                        handler.string_value("NiceJoke");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouGiveAChuck:
                        handler.string_value("DoYouGiveAChuck");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreRude:
                        handler.string_value("YouAreRude");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourFather:
                        handler.string_value("IAmYourFather");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmYourMother:
                        handler.string_value("IAmYourMother");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MothersDay:
                        handler.string_value("MothersDay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_FathersDay:
                        handler.string_value("FathersDay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Dismissal:
                        handler.string_value("Dismissal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhyFiretruckRed:
                        handler.string_value("WhyFiretruckRed");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoIStopZombie:
                        handler.string_value("HowDoIStopZombie");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFeeling:
                        handler.string_value("AreYouFeeling");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoodLooking:
                        handler.string_value("AreYouGoodLooking");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HowDoILandAirplane:
                        handler.string_value("HowDoILandAirplane");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhenWillWorldEnd:
                        handler.string_value("WhenWillWorldEnd");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatColorAreYou:
                        handler.string_value("WhatColorAreYou");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreWeFriends:
                        handler.string_value("AreWeFriends");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteColor:
                        handler.string_value("WhatsFavoriteColor");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteFood:
                        handler.string_value("WhatsFavoriteFood");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeFood:
                        handler.string_value("DoYouLikeFood");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DoYouLikeMyClothes:
                        handler.string_value("DoYouLikeMyClothes");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsFavoriteAnimal:
                        handler.string_value("WhatsFavoriteAnimal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoesTheCatSay:
                        handler.string_value("WhatDoesTheCatSay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Welcome:
                        handler.string_value("Welcome");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatChineseZodiac:
                        handler.string_value("WhatChineseZodiac");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Morning:
                        handler.string_value("Greetings_Morning");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Evening:
                        handler.string_value("Greetings_Evening");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AmIPretty:
                        handler.string_value("AmIPretty");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGay:
                        handler.string_value("AreYouGay");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouSiri:
                        handler.string_value("AreYouSiri");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouAlexa:
                        handler.string_value("AreYouAlexa");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouCortana:
                        handler.string_value("AreYouCortana");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGoogle:
                        handler.string_value("AreYouGoogle");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouGalaxy:
                        handler.string_value("AreYouGalaxy");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouBixby:
                        handler.string_value("AreYouBixby");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouEvil:
                        handler.string_value("AreYouEvil");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouADog:
                        handler.string_value("AreYouADog");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouFat:
                        handler.string_value("AreYouFat");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouHungry:
                        handler.string_value("AreYouHungry");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_AreYouMad:
                        handler.string_value("AreYouMad");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatsYourPhoneNumber:
                        handler.string_value("WhatsYourPhoneNumber");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfWork:
                        handler.string_value("Greetings_EndOfWork");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_IAmHome:
                        handler.string_value("Greetings_IAmHome");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_WelcomeHome:
                        handler.string_value("Greetings_WelcomeHome");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_BeforeMeal:
                        handler.string_value("Greetings_BeforeMeal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_Telephone:
                        handler.string_value("Greetings_Telephone");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_MerryChristmas:
                        handler.string_value("MerryChristmas");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_EndOfYear:
                        handler.string_value("Greetings_EndOfYear");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_HappyNewYear:
                        handler.string_value("HappyNewYear");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Greetings_VisitHouse:
                        handler.string_value("Greetings_VisitHouse");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_ILikeSomething:
                        handler.string_value("ILikeSomething");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IDislikeSomething:
                        handler.string_value("IDislikeSomething");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Annoying:
                        handler.string_value("Annoying");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_Lonely:
                        handler.string_value("Lonely");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreKind:
                        handler.string_value("YouAreKind");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_LetsPlayGame:
                        handler.string_value("LetsPlayGame");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_GoodNight:
                        handler.string_value("GoodNight");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatAPain:
                        handler.string_value("WhatAPain");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_YouAreCool:
                        handler.string_value("YouAreCool");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_CheerUp:
                        handler.string_value("CheerUp");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_DislikeYou_Formal:
                        handler.string_value("DislikeYou_Formal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_IAmSleepy:
                        handler.string_value("IAmSleepy");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatIsYourName_Informal:
                        handler.string_value("WhatIsYourName_Informal");
                        break;
                    case TypeNormalizedQueryKnownValues.NormalizedQuery_WhatDoYouThinkOf_Informal:
                        handler.string_value("WhatDoYouThinkOf_Informal");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeNormalizedQuery.string_value);
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
        return null;
      }

    public static new SmallTalkInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SmallTalkInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmallTalkInformationNugget", ignore_extras);
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
    public static new SmallTalkInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SmallTalkInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SmallTalkInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmallTalkInformationNugget", ignore_extras);
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
    public static new SmallTalkInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SmallTalkInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SmallTalkInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmallTalkInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SmallTalkInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SmallTalkInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SmallTalkInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SmallTalkInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private UserNameJSON.HoldingGenerator fieldGeneratorUserName;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorForcedResponse;
    private abstract class FieldGeneratorNormalizedQuery : JSONStringGenerator
          {
            protected FieldGeneratorNormalizedQuery(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNormalizedQuery()
              {
              }
            protected override void handle_result(string result)
              {
                TypeNormalizedQueryKnownValues known = stringToNormalizedQuery(result);
                TypeNormalizedQuery new_value = new TypeNormalizedQuery();
                if (known == TypeNormalizedQueryKnownValues.NormalizedQuery__none)
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
            protected abstract void handle_result(TypeNormalizedQuery result);
          };
    private class FieldHoldingGeneratorNormalizedQuery : FieldGeneratorNormalizedQuery
  {
    protected override void handle_result(TypeNormalizedQuery result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNormalizedQuery(String what)
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
    public TypeNormalizedQuery value;
  };
    private class FieldHoldingArrayGeneratorNormalizedQuery : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNormalizedQuery
      {
        private FieldHoldingArrayGeneratorNormalizedQuery top;

        protected override void handle_result(TypeNormalizedQuery result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNormalizedQuery init_top)
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
    protected virtual void handle_result(List<TypeNormalizedQuery> result)
      {
      }

    public FieldHoldingArrayGeneratorNormalizedQuery(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNormalizedQuery>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNormalizedQuery()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNormalizedQuery>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNormalizedQuery> value;
  };
        private FieldHoldingGeneratorNormalizedQuery fieldGeneratorNormalizedQuery;
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
            if (!(getInformationNuggetJSONKey().Equals("SmallTalk")))
                throw new Exception("The key field has a value other than `SmallTalk'.");
            SmallTalkInformationNuggetJSON result = new SmallTalkInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSmallTalkInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((SmallTalkInformationNuggetJSON )new_result);
          }
        protected void finish(SmallTalkInformationNuggetJSON result)
          {
            if (fieldGeneratorUserName.have_value)
              {
                result.setUserName(fieldGeneratorUserName.value);
                fieldGeneratorUserName.have_value = false;
              }
            if (fieldGeneratorForcedResponse.have_value)
              {
                result.setForcedResponse(fieldGeneratorForcedResponse.value);
                fieldGeneratorForcedResponse.have_value = false;
              }
            if (fieldGeneratorNormalizedQuery.have_value)
              {
                result.setNormalizedQuery(fieldGeneratorNormalizedQuery.value);
                fieldGeneratorNormalizedQuery.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SmallTalkInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "orcedResponse", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorForcedResponse;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ormalizedQuery", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorNormalizedQuery;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorUserName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserName = new UserNameJSON.HoldingGenerator("field \"UserName\" of the SmallTalkInformationNugget class", ignore_extras);
            fieldGeneratorForcedResponse = new DynamicResponseJSON.HoldingGenerator("field \"ForcedResponse\" of the SmallTalkInformationNugget class", ignore_extras);
            fieldGeneratorNormalizedQuery = new FieldHoldingGeneratorNormalizedQuery("field \"NormalizedQuery\" of the SmallTalkInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SmallTalkInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserName = new UserNameJSON.HoldingGenerator("field \"UserName\" of the SmallTalkInformationNugget class", false);
            fieldGeneratorForcedResponse = new DynamicResponseJSON.HoldingGenerator("field \"ForcedResponse\" of the SmallTalkInformationNugget class", false);
            fieldGeneratorNormalizedQuery = new FieldHoldingGeneratorNormalizedQuery("field \"NormalizedQuery\" of the SmallTalkInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SmallTalkInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorUserName.reset();
            fieldGeneratorForcedResponse.reset();
            fieldGeneratorNormalizedQuery.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SmallTalkInformationNuggetJSON  result)
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
        public SmallTalkInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SmallTalkInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SmallTalkInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SmallTalkInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SmallTalkInformationNuggetJSON>();
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
    public List<SmallTalkInformationNuggetJSON> value;
  };
  };
