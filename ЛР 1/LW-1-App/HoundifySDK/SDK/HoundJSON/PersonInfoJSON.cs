/* file "PersonInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonInfoJSON : PersonProfileJSON
  {
    private bool flagHasDescription;
    private WrittenSpokenStringJSON  storeDescription;
    private bool flagHasBirthplace;
    private MapLocationJSON  storeBirthplace;
    private bool flagHasDateOfDeath;
    private DateAndOrTimeJSON  storeDateOfDeath;
    private bool flagHasLocationOfDeath;
    private MapLocationJSON  storeLocationOfDeath;
    private bool flagHasCauseOfDeath;
    private WrittenSpokenStringJSON  storeCauseOfDeath;
    private bool flagHasPower;
    private WrittenSpokenStringJSON  storePower;
    private bool flagHasAge;
    private AmountJSON  storeAge;
    private bool flagHasAgeAtDeath;
    private AmountJSON  storeAgeAtDeath;
    private bool flagHasMother;
    private WhoJSON  storeMother;
    private bool flagHasFather;
    private WhoJSON  storeFather;
    private bool flagHasSpouse;
    private WhoJSON  storeSpouse;
    private bool flagHasSiblings;
    private List< WhoJSON  > storeSiblings;
    private bool flagHasChildren;
    private List< WhoJSON  > storeChildren;
    private bool flagHasHeight;
    private AmountJSON  storeHeight;
    private bool flagHasWeight;
    private AmountJSON  storeWeight;
    private bool flagHasNetWorth;
    private AmountJSON  storeNetWorth;
    private bool flagHasTraits;
    private List< PersonTraitJSON  > storeTraits;
    private bool flagHasEnemy;
    private WhoJSON  storeEnemy;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDescriptionToJSON()
      {
        JSONValueHandler handler_Description = new JSONValueHandler();
        storeDescription.write_as_json(handler_Description);
        return handler_Description.result;
      }

    private JSONValue  extraBirthplaceToJSON()
      {
        JSONValueHandler handler_Birthplace = new JSONValueHandler();
        storeBirthplace.write_as_json(handler_Birthplace);
        return handler_Birthplace.result;
      }

    private JSONValue  extraDateOfDeathToJSON()
      {
        JSONValueHandler handler_DateOfDeath = new JSONValueHandler();
        storeDateOfDeath.write_as_json(handler_DateOfDeath);
        return handler_DateOfDeath.result;
      }

    private JSONValue  extraLocationOfDeathToJSON()
      {
        JSONValueHandler handler_LocationOfDeath = new JSONValueHandler();
        storeLocationOfDeath.write_as_json(handler_LocationOfDeath);
        return handler_LocationOfDeath.result;
      }

    private JSONValue  extraCauseOfDeathToJSON()
      {
        JSONValueHandler handler_CauseOfDeath = new JSONValueHandler();
        storeCauseOfDeath.write_as_json(handler_CauseOfDeath);
        return handler_CauseOfDeath.result;
      }

    private JSONValue  extraPowerToJSON()
      {
        JSONValueHandler handler_Power = new JSONValueHandler();
        storePower.write_as_json(handler_Power);
        return handler_Power.result;
      }

    private JSONValue  extraAgeToJSON()
      {
        JSONValueHandler handler_Age = new JSONValueHandler();
        storeAge.write_as_json(handler_Age);
        return handler_Age.result;
      }

    private JSONValue  extraAgeAtDeathToJSON()
      {
        JSONValueHandler handler_AgeAtDeath = new JSONValueHandler();
        storeAgeAtDeath.write_as_json(handler_AgeAtDeath);
        return handler_AgeAtDeath.result;
      }

    private JSONValue  extraMotherToJSON()
      {
        JSONValueHandler handler_Mother = new JSONValueHandler();
        storeMother.write_as_json(handler_Mother);
        return handler_Mother.result;
      }

    private JSONValue  extraFatherToJSON()
      {
        JSONValueHandler handler_Father = new JSONValueHandler();
        storeFather.write_as_json(handler_Father);
        return handler_Father.result;
      }

    private JSONValue  extraSpouseToJSON()
      {
        JSONValueHandler handler_Spouse = new JSONValueHandler();
        storeSpouse.write_as_json(handler_Spouse);
        return handler_Spouse.result;
      }

    private JSONValue  extraSiblingsToJSON()
      {
        JSONArrayValue generated_array_1_Siblings = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSiblings.Count; ++num1)
          {
            JSONValueHandler handler_Siblings = new JSONValueHandler();
            storeSiblings[num1].write_as_json(handler_Siblings);
            generated_array_1_Siblings.appendComponent(handler_Siblings.result);
          }
        return generated_array_1_Siblings;
      }

    private JSONValue  extraChildrenToJSON()
      {
        JSONArrayValue generated_array_2_Children = new JSONArrayValue();
        for (int num2 = 0; num2 < storeChildren.Count; ++num2)
          {
            JSONValueHandler handler_Children = new JSONValueHandler();
            storeChildren[num2].write_as_json(handler_Children);
            generated_array_2_Children.appendComponent(handler_Children.result);
          }
        return generated_array_2_Children;
      }

    private JSONValue  extraHeightToJSON()
      {
        JSONValueHandler handler_Height = new JSONValueHandler();
        storeHeight.write_as_json(handler_Height);
        return handler_Height.result;
      }

    private JSONValue  extraWeightToJSON()
      {
        JSONValueHandler handler_Weight = new JSONValueHandler();
        storeWeight.write_as_json(handler_Weight);
        return handler_Weight.result;
      }

    private JSONValue  extraNetWorthToJSON()
      {
        JSONValueHandler handler_NetWorth = new JSONValueHandler();
        storeNetWorth.write_as_json(handler_NetWorth);
        return handler_NetWorth.result;
      }

    private JSONValue  extraTraitsToJSON()
      {
        JSONArrayValue generated_array_3_Traits = new JSONArrayValue();
        for (int num3 = 0; num3 < storeTraits.Count; ++num3)
          {
            JSONValueHandler handler_Traits = new JSONValueHandler();
            storeTraits[num3].write_as_json(handler_Traits);
            generated_array_3_Traits.appendComponent(handler_Traits.result);
          }
        return generated_array_3_Traits;
      }

    private JSONValue  extraEnemyToJSON()
      {
        JSONValueHandler handler_Enemy = new JSONValueHandler();
        storeEnemy.write_as_json(handler_Enemy);
        return handler_Enemy.result;
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_value, ignore_extras, true);
        setDescription(convert_classy);
      }


    private void  fromJSONBirthplace(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setBirthplace(convert_classy);
      }


    private void  fromJSONDateOfDeath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateOfDeath(convert_classy);
      }


    private void  fromJSONLocationOfDeath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocationOfDeath(convert_classy);
      }


    private void  fromJSONCauseOfDeath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_value, ignore_extras, true);
        setCauseOfDeath(convert_classy);
      }


    private void  fromJSONPower(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WrittenSpokenStringJSON convert_classy = WrittenSpokenStringJSON.from_json(json_value, ignore_extras, true);
        setPower(convert_classy);
      }


    private void  fromJSONAge(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setAge(convert_classy);
      }


    private void  fromJSONAgeAtDeath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setAgeAtDeath(convert_classy);
      }


    private void  fromJSONMother(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhoJSON convert_classy = WhoJSON.from_json(json_value, ignore_extras, true);
        setMother(convert_classy);
      }


    private void  fromJSONFather(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhoJSON convert_classy = WhoJSON.from_json(json_value, ignore_extras, true);
        setFather(convert_classy);
      }


    private void  fromJSONSpouse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhoJSON convert_classy = WhoJSON.from_json(json_value, ignore_extras, true);
        setSpouse(convert_classy);
      }


    private void  fromJSONSiblings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Siblings of PersonInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WhoJSON  > vector_Siblings1 = new List< WhoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhoJSON convert_classy = WhoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Siblings1.Add(convert_classy);
          }
        initSiblings();
        for (int num1 = 0; num1 < vector_Siblings1.Count; ++num1)
            appendSiblings(vector_Siblings1[num1]);
        for (int num1 = 0; num1 < vector_Siblings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChildren(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Children of PersonInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< WhoJSON  > vector_Children1 = new List< WhoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            WhoJSON convert_classy = WhoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Children1.Add(convert_classy);
          }
        initChildren();
        for (int num2 = 0; num2 < vector_Children1.Count; ++num2)
            appendChildren(vector_Children1[num2]);
        for (int num1 = 0; num1 < vector_Children1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHeight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setHeight(convert_classy);
      }


    private void  fromJSONWeight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setWeight(convert_classy);
      }


    private void  fromJSONNetWorth(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setNetWorth(convert_classy);
      }


    private void  fromJSONTraits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Traits of PersonInfoJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PersonTraitJSON  > vector_Traits1 = new List< PersonTraitJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PersonTraitJSON convert_classy = PersonTraitJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Traits1.Add(convert_classy);
          }
        initTraits();
        for (int num3 = 0; num3 < vector_Traits1.Count; ++num3)
            appendTraits(vector_Traits1[num3]);
        for (int num1 = 0; num1 < vector_Traits1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEnemy(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhoJSON convert_classy = WhoJSON.from_json(json_value, ignore_extras, true);
        setEnemy(convert_classy);
      }


    public PersonInfoJSON()
      {
        flagHasDescription = false;
        flagHasBirthplace = false;
        flagHasDateOfDeath = false;
        flagHasLocationOfDeath = false;
        flagHasCauseOfDeath = false;
        flagHasPower = false;
        flagHasAge = false;
        flagHasAgeAtDeath = false;
        flagHasMother = false;
        flagHasFather = false;
        flagHasSpouse = false;
        flagHasSiblings = false;
        flagHasChildren = false;
        flagHasHeight = false;
        flagHasWeight = false;
        flagHasNetWorth = false;
        flagHasTraits = false;
        flagHasEnemy = false;
        storeSiblings = new List< WhoJSON  >();
        storeChildren = new List< WhoJSON  >();
        storeTraits = new List< PersonTraitJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public WrittenSpokenStringJSON   getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasBirthplace()
      {
        return flagHasBirthplace;
      }

    public MapLocationJSON   getBirthplace()
      {
        Debug.Assert(flagHasBirthplace);
        return storeBirthplace;
      }

    public bool  hasDateOfDeath()
      {
        return flagHasDateOfDeath;
      }

    public DateAndOrTimeJSON   getDateOfDeath()
      {
        Debug.Assert(flagHasDateOfDeath);
        return storeDateOfDeath;
      }

    public bool  hasLocationOfDeath()
      {
        return flagHasLocationOfDeath;
      }

    public MapLocationJSON   getLocationOfDeath()
      {
        Debug.Assert(flagHasLocationOfDeath);
        return storeLocationOfDeath;
      }

    public bool  hasCauseOfDeath()
      {
        return flagHasCauseOfDeath;
      }

    public WrittenSpokenStringJSON   getCauseOfDeath()
      {
        Debug.Assert(flagHasCauseOfDeath);
        return storeCauseOfDeath;
      }

    public bool  hasPower()
      {
        return flagHasPower;
      }

    public WrittenSpokenStringJSON   getPower()
      {
        Debug.Assert(flagHasPower);
        return storePower;
      }

    public bool  hasAge()
      {
        return flagHasAge;
      }

    public AmountJSON   getAge()
      {
        Debug.Assert(flagHasAge);
        return storeAge;
      }

    public bool  hasAgeAtDeath()
      {
        return flagHasAgeAtDeath;
      }

    public AmountJSON   getAgeAtDeath()
      {
        Debug.Assert(flagHasAgeAtDeath);
        return storeAgeAtDeath;
      }

    public bool  hasMother()
      {
        return flagHasMother;
      }

    public WhoJSON   getMother()
      {
        Debug.Assert(flagHasMother);
        return storeMother;
      }

    public bool  hasFather()
      {
        return flagHasFather;
      }

    public WhoJSON   getFather()
      {
        Debug.Assert(flagHasFather);
        return storeFather;
      }

    public bool  hasSpouse()
      {
        return flagHasSpouse;
      }

    public WhoJSON   getSpouse()
      {
        Debug.Assert(flagHasSpouse);
        return storeSpouse;
      }

    public bool  hasSiblings()
      {
        return flagHasSiblings;
      }

    public int  countOfSiblings()
      {
        Debug.Assert(flagHasSiblings);
        return storeSiblings.Count;
      }

    public WhoJSON   elementOfSiblings(int element_num)
      {
        Debug.Assert(flagHasSiblings);
        return storeSiblings[element_num];
      }

    public List< WhoJSON  >  getSiblings()
      {
        Debug.Assert(flagHasSiblings);
        return storeSiblings;
      }

    public bool  hasChildren()
      {
        return flagHasChildren;
      }

    public int  countOfChildren()
      {
        Debug.Assert(flagHasChildren);
        return storeChildren.Count;
      }

    public WhoJSON   elementOfChildren(int element_num)
      {
        Debug.Assert(flagHasChildren);
        return storeChildren[element_num];
      }

    public List< WhoJSON  >  getChildren()
      {
        Debug.Assert(flagHasChildren);
        return storeChildren;
      }

    public bool  hasHeight()
      {
        return flagHasHeight;
      }

    public AmountJSON   getHeight()
      {
        Debug.Assert(flagHasHeight);
        return storeHeight;
      }

    public bool  hasWeight()
      {
        return flagHasWeight;
      }

    public AmountJSON   getWeight()
      {
        Debug.Assert(flagHasWeight);
        return storeWeight;
      }

    public bool  hasNetWorth()
      {
        return flagHasNetWorth;
      }

    public AmountJSON   getNetWorth()
      {
        Debug.Assert(flagHasNetWorth);
        return storeNetWorth;
      }

    public bool  hasTraits()
      {
        return flagHasTraits;
      }

    public int  countOfTraits()
      {
        Debug.Assert(flagHasTraits);
        return storeTraits.Count;
      }

    public PersonTraitJSON   elementOfTraits(int element_num)
      {
        Debug.Assert(flagHasTraits);
        return storeTraits[element_num];
      }

    public List< PersonTraitJSON  >  getTraits()
      {
        Debug.Assert(flagHasTraits);
        return storeTraits;
      }

    public bool  hasEnemy()
      {
        return flagHasEnemy;
      }

    public WhoJSON   getEnemy()
      {
        Debug.Assert(flagHasEnemy);
        return storeEnemy;
      }


    public virtual int extraPersonInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPersonProfileComponentCount()
      {
        int result = 0;
        if (flagHasDescription)
            ++result;
        if (flagHasBirthplace)
            ++result;
        if (flagHasDateOfDeath)
            ++result;
        if (flagHasLocationOfDeath)
            ++result;
        if (flagHasCauseOfDeath)
            ++result;
        if (flagHasPower)
            ++result;
        if (flagHasAge)
            ++result;
        if (flagHasAgeAtDeath)
            ++result;
        if (flagHasMother)
            ++result;
        if (flagHasFather)
            ++result;
        if (flagHasSpouse)
            ++result;
        if (flagHasSiblings)
            ++result;
        if (flagHasChildren)
            ++result;
        if (flagHasHeight)
            ++result;
        if (flagHasWeight)
            ++result;
        if (flagHasNetWorth)
            ++result;
        if (flagHasTraits)
            ++result;
        if (flagHasEnemy)
            ++result;
        result += extraPersonInfoComponentCount();
        return result;
      }
    public override string extraPersonProfileComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDescription)
          {
            if (remainder == 0)
                return "Description";
            --remainder;
          }
        if (flagHasBirthplace)
          {
            if (remainder == 0)
                return "Birthplace";
            --remainder;
          }
        if (flagHasDateOfDeath)
          {
            if (remainder == 0)
                return "DateOfDeath";
            --remainder;
          }
        if (flagHasLocationOfDeath)
          {
            if (remainder == 0)
                return "LocationOfDeath";
            --remainder;
          }
        if (flagHasCauseOfDeath)
          {
            if (remainder == 0)
                return "CauseOfDeath";
            --remainder;
          }
        if (flagHasPower)
          {
            if (remainder == 0)
                return "Power";
            --remainder;
          }
        if (flagHasAge)
          {
            if (remainder == 0)
                return "Age";
            --remainder;
          }
        if (flagHasAgeAtDeath)
          {
            if (remainder == 0)
                return "AgeAtDeath";
            --remainder;
          }
        if (flagHasMother)
          {
            if (remainder == 0)
                return "Mother";
            --remainder;
          }
        if (flagHasFather)
          {
            if (remainder == 0)
                return "Father";
            --remainder;
          }
        if (flagHasSpouse)
          {
            if (remainder == 0)
                return "Spouse";
            --remainder;
          }
        if (flagHasSiblings)
          {
            if (remainder == 0)
                return "Siblings";
            --remainder;
          }
        if (flagHasChildren)
          {
            if (remainder == 0)
                return "Children";
            --remainder;
          }
        if (flagHasHeight)
          {
            if (remainder == 0)
                return "Height";
            --remainder;
          }
        if (flagHasWeight)
          {
            if (remainder == 0)
                return "Weight";
            --remainder;
          }
        if (flagHasNetWorth)
          {
            if (remainder == 0)
                return "NetWorth";
            --remainder;
          }
        if (flagHasTraits)
          {
            if (remainder == 0)
                return "Traits";
            --remainder;
          }
        if (flagHasEnemy)
          {
            if (remainder == 0)
                return "Enemy";
            --remainder;
          }
        return extraPersonInfoComponentKey(remainder);
      }
    public override JSONValue extraPersonProfileComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDescription)
          {
            if (remainder == 0)
                return extraDescriptionToJSON();
            --remainder;
          }
        if (flagHasBirthplace)
          {
            if (remainder == 0)
                return extraBirthplaceToJSON();
            --remainder;
          }
        if (flagHasDateOfDeath)
          {
            if (remainder == 0)
                return extraDateOfDeathToJSON();
            --remainder;
          }
        if (flagHasLocationOfDeath)
          {
            if (remainder == 0)
                return extraLocationOfDeathToJSON();
            --remainder;
          }
        if (flagHasCauseOfDeath)
          {
            if (remainder == 0)
                return extraCauseOfDeathToJSON();
            --remainder;
          }
        if (flagHasPower)
          {
            if (remainder == 0)
                return extraPowerToJSON();
            --remainder;
          }
        if (flagHasAge)
          {
            if (remainder == 0)
                return extraAgeToJSON();
            --remainder;
          }
        if (flagHasAgeAtDeath)
          {
            if (remainder == 0)
                return extraAgeAtDeathToJSON();
            --remainder;
          }
        if (flagHasMother)
          {
            if (remainder == 0)
                return extraMotherToJSON();
            --remainder;
          }
        if (flagHasFather)
          {
            if (remainder == 0)
                return extraFatherToJSON();
            --remainder;
          }
        if (flagHasSpouse)
          {
            if (remainder == 0)
                return extraSpouseToJSON();
            --remainder;
          }
        if (flagHasSiblings)
          {
            if (remainder == 0)
                return extraSiblingsToJSON();
            --remainder;
          }
        if (flagHasChildren)
          {
            if (remainder == 0)
                return extraChildrenToJSON();
            --remainder;
          }
        if (flagHasHeight)
          {
            if (remainder == 0)
                return extraHeightToJSON();
            --remainder;
          }
        if (flagHasWeight)
          {
            if (remainder == 0)
                return extraWeightToJSON();
            --remainder;
          }
        if (flagHasNetWorth)
          {
            if (remainder == 0)
                return extraNetWorthToJSON();
            --remainder;
          }
        if (flagHasTraits)
          {
            if (remainder == 0)
                return extraTraitsToJSON();
            --remainder;
          }
        if (flagHasEnemy)
          {
            if (remainder == 0)
                return extraEnemyToJSON();
            --remainder;
          }
        return extraPersonInfoComponentValue(remainder);
      }
    public override JSONValue extraPersonProfileLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if (String.Compare(field_name, 1, "ge", 0, 2, false) == 0)
                  {
                    if (field_name.Length == 3)
                      {
                        return (flagHasAge ? extraAgeToJSON() : null);
                      }
                    switch (field_name[3])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 4, "tDeath", 0, 6, false) == 0) && (field_name.Length == 10))
                                return (flagHasAgeAtDeath ? extraAgeAtDeathToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'B':
                if ((String.Compare(field_name, 1, "irthplace", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasBirthplace ? extraBirthplaceToJSON() : null);
                break;
            case 'C':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "useOfDeath", 0, 10, false) == 0) && (field_name.Length == 12))
                            return (flagHasCauseOfDeath ? extraCauseOfDeathToJSON() : null);
                        break;
                    case 'h':
                        if ((String.Compare(field_name, 2, "ildren", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasChildren ? extraChildrenToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "teOfDeath", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasDateOfDeath ? extraDateOfDeathToJSON() : null);
                        break;
                    case 'e':
                        if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasDescription ? extraDescriptionToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "nemy", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEnemy ? extraEnemyToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ather", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasFather ? extraFatherToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasHeight ? extraHeightToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocationOfDeath", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasLocationOfDeath ? extraLocationOfDeathToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "other", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasMother ? extraMotherToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "etWorth", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasNetWorth ? extraNetWorthToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "ower", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasPower ? extraPowerToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "blings", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasSiblings ? extraSiblingsToJSON() : null);
                        break;
                    case 'p':
                        if ((String.Compare(field_name, 2, "ouse", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasSpouse ? extraSpouseToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "raits", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasTraits ? extraTraitsToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasWeight ? extraWeightToJSON() : null);
                break;
            default:
                break;
          }
        return extraPersonInfoLookup(field_name);
      }

    public void setDescription(WrittenSpokenStringJSON  new_value)
      {
        if (flagHasDescription)
          {
          }
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        if (flagHasDescription)
          {
          }
        flagHasDescription = false;
      }
    public void setBirthplace(MapLocationJSON  new_value)
      {
        if (flagHasBirthplace)
          {
          }
        flagHasBirthplace = true;
        storeBirthplace = new_value;
      }
    public void unsetBirthplace()
      {
        if (flagHasBirthplace)
          {
          }
        flagHasBirthplace = false;
      }
    public void setDateOfDeath(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDateOfDeath)
          {
          }
        flagHasDateOfDeath = true;
        storeDateOfDeath = new_value;
      }
    public void unsetDateOfDeath()
      {
        if (flagHasDateOfDeath)
          {
          }
        flagHasDateOfDeath = false;
      }
    public void setLocationOfDeath(MapLocationJSON  new_value)
      {
        if (flagHasLocationOfDeath)
          {
          }
        flagHasLocationOfDeath = true;
        storeLocationOfDeath = new_value;
      }
    public void unsetLocationOfDeath()
      {
        if (flagHasLocationOfDeath)
          {
          }
        flagHasLocationOfDeath = false;
      }
    public void setCauseOfDeath(WrittenSpokenStringJSON  new_value)
      {
        if (flagHasCauseOfDeath)
          {
          }
        flagHasCauseOfDeath = true;
        storeCauseOfDeath = new_value;
      }
    public void unsetCauseOfDeath()
      {
        if (flagHasCauseOfDeath)
          {
          }
        flagHasCauseOfDeath = false;
      }
    public void setPower(WrittenSpokenStringJSON  new_value)
      {
        if (flagHasPower)
          {
          }
        flagHasPower = true;
        storePower = new_value;
      }
    public void unsetPower()
      {
        if (flagHasPower)
          {
          }
        flagHasPower = false;
      }
    public void setAge(AmountJSON  new_value)
      {
        if (flagHasAge)
          {
          }
        flagHasAge = true;
        storeAge = new_value;
      }
    public void unsetAge()
      {
        if (flagHasAge)
          {
          }
        flagHasAge = false;
      }
    public void setAgeAtDeath(AmountJSON  new_value)
      {
        if (flagHasAgeAtDeath)
          {
          }
        flagHasAgeAtDeath = true;
        storeAgeAtDeath = new_value;
      }
    public void unsetAgeAtDeath()
      {
        if (flagHasAgeAtDeath)
          {
          }
        flagHasAgeAtDeath = false;
      }
    public void setMother(WhoJSON  new_value)
      {
        if (flagHasMother)
          {
          }
        flagHasMother = true;
        storeMother = new_value;
      }
    public void unsetMother()
      {
        if (flagHasMother)
          {
          }
        flagHasMother = false;
      }
    public void setFather(WhoJSON  new_value)
      {
        if (flagHasFather)
          {
          }
        flagHasFather = true;
        storeFather = new_value;
      }
    public void unsetFather()
      {
        if (flagHasFather)
          {
          }
        flagHasFather = false;
      }
    public void setSpouse(WhoJSON  new_value)
      {
        if (flagHasSpouse)
          {
          }
        flagHasSpouse = true;
        storeSpouse = new_value;
      }
    public void unsetSpouse()
      {
        if (flagHasSpouse)
          {
          }
        flagHasSpouse = false;
      }
    public void initSiblings()
      {
        if (flagHasSiblings)
          {
            for (int num1 = 0; num1 < storeSiblings.Count; ++num1)
              {
              }
          }
        flagHasSiblings = true;
        storeSiblings.Clear();
      }
    public void appendSiblings(WhoJSON  to_append)
      {
        if (!flagHasSiblings)
          {
            flagHasSiblings = true;
            storeSiblings.Clear();
          }
        Debug.Assert(flagHasSiblings);
        storeSiblings.Add(to_append);
      }
    public void unsetSiblings()
      {
        if (flagHasSiblings)
          {
            for (int num2 = 0; num2 < storeSiblings.Count; ++num2)
              {
              }
          }
        flagHasSiblings = false;
        storeSiblings.Clear();
      }
    public void initChildren()
      {
        if (flagHasChildren)
          {
            for (int num3 = 0; num3 < storeChildren.Count; ++num3)
              {
              }
          }
        flagHasChildren = true;
        storeChildren.Clear();
      }
    public void appendChildren(WhoJSON  to_append)
      {
        if (!flagHasChildren)
          {
            flagHasChildren = true;
            storeChildren.Clear();
          }
        Debug.Assert(flagHasChildren);
        storeChildren.Add(to_append);
      }
    public void unsetChildren()
      {
        if (flagHasChildren)
          {
            for (int num4 = 0; num4 < storeChildren.Count; ++num4)
              {
              }
          }
        flagHasChildren = false;
        storeChildren.Clear();
      }
    public void setHeight(AmountJSON  new_value)
      {
        if (flagHasHeight)
          {
          }
        flagHasHeight = true;
        storeHeight = new_value;
      }
    public void unsetHeight()
      {
        if (flagHasHeight)
          {
          }
        flagHasHeight = false;
      }
    public void setWeight(AmountJSON  new_value)
      {
        if (flagHasWeight)
          {
          }
        flagHasWeight = true;
        storeWeight = new_value;
      }
    public void unsetWeight()
      {
        if (flagHasWeight)
          {
          }
        flagHasWeight = false;
      }
    public void setNetWorth(AmountJSON  new_value)
      {
        if (flagHasNetWorth)
          {
          }
        flagHasNetWorth = true;
        storeNetWorth = new_value;
      }
    public void unsetNetWorth()
      {
        if (flagHasNetWorth)
          {
          }
        flagHasNetWorth = false;
      }
    public void initTraits()
      {
        if (flagHasTraits)
          {
            for (int num5 = 0; num5 < storeTraits.Count; ++num5)
              {
              }
          }
        flagHasTraits = true;
        storeTraits.Clear();
      }
    public void appendTraits(PersonTraitJSON  to_append)
      {
        if (!flagHasTraits)
          {
            flagHasTraits = true;
            storeTraits.Clear();
          }
        Debug.Assert(flagHasTraits);
        storeTraits.Add(to_append);
      }
    public void unsetTraits()
      {
        if (flagHasTraits)
          {
            for (int num6 = 0; num6 < storeTraits.Count; ++num6)
              {
              }
          }
        flagHasTraits = false;
        storeTraits.Clear();
      }
    public void setEnemy(WhoJSON  new_value)
      {
        if (flagHasEnemy)
          {
          }
        flagHasEnemy = true;
        storeEnemy = new_value;
      }
    public void unsetEnemy()
      {
        if (flagHasEnemy)
          {
          }
        flagHasEnemy = false;
      }

    public virtual void extraPersonInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonInfoLookup(key);
        if (old_field == null)
          {
            extraPersonInfoAppendPair(key, new_component);
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
    public override void extraPersonProfileAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ge", 0, 2, false) == 0)
                  {
                    if (key.Length == 3)
                      {
                        {
                        fromJSONAge(new_component, false);
                        return;
                        }
                      }
                    switch (key[3])
                      {
                        case 'A':
                            if ((String.Compare(key, 4, "tDeath", 0, 6, false) == 0) && (key.Length == 10))
                                {
                                fromJSONAgeAtDeath(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "irthplace", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONBirthplace(new_component, false);
                    return;
                    }
                break;
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "useOfDeath", 0, 10, false) == 0) && (key.Length == 12))
                            {
                            fromJSONCauseOfDeath(new_component, false);
                            return;
                            }
                        break;
                    case 'h':
                        if ((String.Compare(key, 2, "ildren", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONChildren(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "teOfDeath", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONDateOfDeath(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "scription", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONDescription(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "nemy", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEnemy(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ather", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFather(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "eight", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONHeight(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationOfDeath", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONLocationOfDeath(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "other", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONMother(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "etWorth", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONNetWorth(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ower", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONPower(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "blings", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONSiblings(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "ouse", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSpouse(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "raits", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONTraits(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "eight", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONWeight(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonInfoAppendPair(key, new_component);
      }
    public override void extraPersonProfileSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if (String.Compare(key, 1, "ge", 0, 2, false) == 0)
                  {
                    if (key.Length == 3)
                      {
                        {
                        fromJSONAge(new_component, false);
                        return;
                        }
                      }
                    switch (key[3])
                      {
                        case 'A':
                            if ((String.Compare(key, 4, "tDeath", 0, 6, false) == 0) && (key.Length == 10))
                                {
                                fromJSONAgeAtDeath(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'B':
                if ((String.Compare(key, 1, "irthplace", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONBirthplace(new_component, false);
                    return;
                    }
                break;
            case 'C':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "useOfDeath", 0, 10, false) == 0) && (key.Length == 12))
                            {
                            fromJSONCauseOfDeath(new_component, false);
                            return;
                            }
                        break;
                    case 'h':
                        if ((String.Compare(key, 2, "ildren", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONChildren(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "teOfDeath", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONDateOfDeath(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "scription", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONDescription(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "nemy", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEnemy(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ather", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONFather(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "eight", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONHeight(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocationOfDeath", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONLocationOfDeath(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "other", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONMother(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "etWorth", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONNetWorth(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ower", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONPower(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "blings", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONSiblings(new_component, false);
                            return;
                            }
                        break;
                    case 'p':
                        if ((String.Compare(key, 2, "ouse", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONSpouse(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(key, 1, "raits", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONTraits(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "eight", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONWeight(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraPersonInfoSetField(key, new_component);
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
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            if (partial_allowed)
                storeDescription.write_partial_as_json(handler);
            else
                storeDescription.write_as_json(handler);
          }
        if (flagHasBirthplace)
          {
            handler.start_pair("Birthplace");
            if (partial_allowed)
                storeBirthplace.write_partial_as_json(handler);
            else
                storeBirthplace.write_as_json(handler);
          }
        if (flagHasDateOfDeath)
          {
            handler.start_pair("DateOfDeath");
            if (partial_allowed)
                storeDateOfDeath.write_partial_as_json(handler);
            else
                storeDateOfDeath.write_as_json(handler);
          }
        if (flagHasLocationOfDeath)
          {
            handler.start_pair("LocationOfDeath");
            if (partial_allowed)
                storeLocationOfDeath.write_partial_as_json(handler);
            else
                storeLocationOfDeath.write_as_json(handler);
          }
        if (flagHasCauseOfDeath)
          {
            handler.start_pair("CauseOfDeath");
            if (partial_allowed)
                storeCauseOfDeath.write_partial_as_json(handler);
            else
                storeCauseOfDeath.write_as_json(handler);
          }
        if (flagHasPower)
          {
            handler.start_pair("Power");
            if (partial_allowed)
                storePower.write_partial_as_json(handler);
            else
                storePower.write_as_json(handler);
          }
        if (flagHasAge)
          {
            handler.start_pair("Age");
            if (partial_allowed)
                storeAge.write_partial_as_json(handler);
            else
                storeAge.write_as_json(handler);
          }
        if (flagHasAgeAtDeath)
          {
            handler.start_pair("AgeAtDeath");
            if (partial_allowed)
                storeAgeAtDeath.write_partial_as_json(handler);
            else
                storeAgeAtDeath.write_as_json(handler);
          }
        if (flagHasMother)
          {
            handler.start_pair("Mother");
            if (partial_allowed)
                storeMother.write_partial_as_json(handler);
            else
                storeMother.write_as_json(handler);
          }
        if (flagHasFather)
          {
            handler.start_pair("Father");
            if (partial_allowed)
                storeFather.write_partial_as_json(handler);
            else
                storeFather.write_as_json(handler);
          }
        if (flagHasSpouse)
          {
            handler.start_pair("Spouse");
            if (partial_allowed)
                storeSpouse.write_partial_as_json(handler);
            else
                storeSpouse.write_as_json(handler);
          }
        if (flagHasSiblings)
          {
            handler.start_pair("Siblings");
            handler.start_array();
            for (int num1 = 0; num1 < storeSiblings.Count; ++num1)
              {
                if (partial_allowed)
                    storeSiblings[num1].write_partial_as_json(handler);
                else
                    storeSiblings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasChildren)
          {
            handler.start_pair("Children");
            handler.start_array();
            for (int num2 = 0; num2 < storeChildren.Count; ++num2)
              {
                if (partial_allowed)
                    storeChildren[num2].write_partial_as_json(handler);
                else
                    storeChildren[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasHeight)
          {
            handler.start_pair("Height");
            if (partial_allowed)
                storeHeight.write_partial_as_json(handler);
            else
                storeHeight.write_as_json(handler);
          }
        if (flagHasWeight)
          {
            handler.start_pair("Weight");
            if (partial_allowed)
                storeWeight.write_partial_as_json(handler);
            else
                storeWeight.write_as_json(handler);
          }
        if (flagHasNetWorth)
          {
            handler.start_pair("NetWorth");
            if (partial_allowed)
                storeNetWorth.write_partial_as_json(handler);
            else
                storeNetWorth.write_as_json(handler);
          }
        if (flagHasTraits)
          {
            handler.start_pair("Traits");
            handler.start_array();
            for (int num3 = 0; num3 < storeTraits.Count; ++num3)
              {
                if (partial_allowed)
                    storeTraits[num3].write_partial_as_json(handler);
                else
                    storeTraits[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasEnemy)
          {
            handler.start_pair("Enemy");
            if (partial_allowed)
                storeEnemy.write_partial_as_json(handler);
            else
                storeEnemy.write_as_json(handler);
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

    public static new PersonInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonInfo", ignore_extras);
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
    public static new PersonInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonInfo", ignore_extras);
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
    public static new PersonInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new PersonInfoJSON from_text(string text, bool ignore_extras)
      {
        PersonInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new PersonInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PersonProfileJSON.Generator
      {
        private WrittenSpokenStringJSON.HoldingGenerator fieldGeneratorDescription;
        private MapLocationJSON.HoldingGenerator fieldGeneratorBirthplace;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateOfDeath;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocationOfDeath;
        private WrittenSpokenStringJSON.HoldingGenerator fieldGeneratorCauseOfDeath;
        private WrittenSpokenStringJSON.HoldingGenerator fieldGeneratorPower;
        private AmountJSON.HoldingGenerator fieldGeneratorAge;
        private AmountJSON.HoldingGenerator fieldGeneratorAgeAtDeath;
        private WhoJSON.HoldingGenerator fieldGeneratorMother;
        private WhoJSON.HoldingGenerator fieldGeneratorFather;
        private WhoJSON.HoldingGenerator fieldGeneratorSpouse;
        private WhoJSON.HoldingArrayGenerator fieldGeneratorSiblings;
        private WhoJSON.HoldingArrayGenerator fieldGeneratorChildren;
        private AmountJSON.HoldingGenerator fieldGeneratorHeight;
        private AmountJSON.HoldingGenerator fieldGeneratorWeight;
        private AmountJSON.HoldingGenerator fieldGeneratorNetWorth;
        private PersonTraitJSON.HoldingArrayGenerator fieldGeneratorTraits;
        private WhoJSON.HoldingGenerator fieldGeneratorEnemy;
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
            PersonInfoJSON result = new PersonInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PersonProfileJSON new_result)
          {
            handle_result((PersonInfoJSON )new_result);
          }
        protected void finish(PersonInfoJSON result)
          {
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorBirthplace.have_value)
              {
                result.setBirthplace(fieldGeneratorBirthplace.value);
                fieldGeneratorBirthplace.have_value = false;
              }
            if (fieldGeneratorDateOfDeath.have_value)
              {
                result.setDateOfDeath(fieldGeneratorDateOfDeath.value);
                fieldGeneratorDateOfDeath.have_value = false;
              }
            if (fieldGeneratorLocationOfDeath.have_value)
              {
                result.setLocationOfDeath(fieldGeneratorLocationOfDeath.value);
                fieldGeneratorLocationOfDeath.have_value = false;
              }
            if (fieldGeneratorCauseOfDeath.have_value)
              {
                result.setCauseOfDeath(fieldGeneratorCauseOfDeath.value);
                fieldGeneratorCauseOfDeath.have_value = false;
              }
            if (fieldGeneratorPower.have_value)
              {
                result.setPower(fieldGeneratorPower.value);
                fieldGeneratorPower.have_value = false;
              }
            if (fieldGeneratorAge.have_value)
              {
                result.setAge(fieldGeneratorAge.value);
                fieldGeneratorAge.have_value = false;
              }
            if (fieldGeneratorAgeAtDeath.have_value)
              {
                result.setAgeAtDeath(fieldGeneratorAgeAtDeath.value);
                fieldGeneratorAgeAtDeath.have_value = false;
              }
            if (fieldGeneratorMother.have_value)
              {
                result.setMother(fieldGeneratorMother.value);
                fieldGeneratorMother.have_value = false;
              }
            if (fieldGeneratorFather.have_value)
              {
                result.setFather(fieldGeneratorFather.value);
                fieldGeneratorFather.have_value = false;
              }
            if (fieldGeneratorSpouse.have_value)
              {
                result.setSpouse(fieldGeneratorSpouse.value);
                fieldGeneratorSpouse.have_value = false;
              }
            if (fieldGeneratorSiblings.have_value)
              {
                result.initSiblings();
                int count = fieldGeneratorSiblings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSiblings(fieldGeneratorSiblings.value[num]);
                  }
                fieldGeneratorSiblings.value.Clear();
                fieldGeneratorSiblings.have_value = false;
              }
            if (fieldGeneratorChildren.have_value)
              {
                result.initChildren();
                int count = fieldGeneratorChildren.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChildren(fieldGeneratorChildren.value[num]);
                  }
                fieldGeneratorChildren.value.Clear();
                fieldGeneratorChildren.have_value = false;
              }
            if (fieldGeneratorHeight.have_value)
              {
                result.setHeight(fieldGeneratorHeight.value);
                fieldGeneratorHeight.have_value = false;
              }
            if (fieldGeneratorWeight.have_value)
              {
                result.setWeight(fieldGeneratorWeight.value);
                fieldGeneratorWeight.have_value = false;
              }
            if (fieldGeneratorNetWorth.have_value)
              {
                result.setNetWorth(fieldGeneratorNetWorth.value);
                fieldGeneratorNetWorth.have_value = false;
              }
            if (fieldGeneratorTraits.have_value)
              {
                result.initTraits();
                int count = fieldGeneratorTraits.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTraits(fieldGeneratorTraits.value[num]);
                  }
                fieldGeneratorTraits.value.Clear();
                fieldGeneratorTraits.have_value = false;
              }
            if (fieldGeneratorEnemy.have_value)
              {
                result.setEnemy(fieldGeneratorEnemy.value);
                fieldGeneratorEnemy.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(PersonInfoJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ge", 0, 2, false) == 0)
                      {
                        if (field_name.Length == 3)
                          {
                            return fieldGeneratorAge;
                          }
                        switch (field_name[3])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 4, "tDeath", 0, 6, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorAgeAtDeath;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "irthplace", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorBirthplace;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "useOfDeath", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCauseOfDeath;
                            break;
                        case 'h':
                            if ((String.Compare(field_name, 2, "ildren", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorChildren;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "teOfDeath", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDateOfDeath;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDescription;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "nemy", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEnemy;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ather", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFather;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorHeight;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocationOfDeath", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorLocationOfDeath;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "other", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMother;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "etWorth", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorNetWorth;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ower", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorPower;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "blings", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSiblings;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ouse", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSpouse;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "raits", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorTraits;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorWeight;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDescription = new WrittenSpokenStringJSON.HoldingGenerator("field \"Description\" of the PersonInfo class", ignore_extras);
            fieldGeneratorBirthplace = new MapLocationJSON.HoldingGenerator("field \"Birthplace\" of the PersonInfo class", ignore_extras);
            fieldGeneratorDateOfDeath = new DateAndOrTimeJSON.HoldingGenerator("field \"DateOfDeath\" of the PersonInfo class", ignore_extras);
            fieldGeneratorLocationOfDeath = new MapLocationJSON.HoldingGenerator("field \"LocationOfDeath\" of the PersonInfo class", ignore_extras);
            fieldGeneratorCauseOfDeath = new WrittenSpokenStringJSON.HoldingGenerator("field \"CauseOfDeath\" of the PersonInfo class", ignore_extras);
            fieldGeneratorPower = new WrittenSpokenStringJSON.HoldingGenerator("field \"Power\" of the PersonInfo class", ignore_extras);
            fieldGeneratorAge = new AmountJSON.HoldingGenerator("field \"Age\" of the PersonInfo class", ignore_extras);
            fieldGeneratorAgeAtDeath = new AmountJSON.HoldingGenerator("field \"AgeAtDeath\" of the PersonInfo class", ignore_extras);
            fieldGeneratorMother = new WhoJSON.HoldingGenerator("field \"Mother\" of the PersonInfo class", ignore_extras);
            fieldGeneratorFather = new WhoJSON.HoldingGenerator("field \"Father\" of the PersonInfo class", ignore_extras);
            fieldGeneratorSpouse = new WhoJSON.HoldingGenerator("field \"Spouse\" of the PersonInfo class", ignore_extras);
            fieldGeneratorSiblings = new WhoJSON.HoldingArrayGenerator("field \"Siblings\" of the PersonInfo class", ignore_extras);
            fieldGeneratorChildren = new WhoJSON.HoldingArrayGenerator("field \"Children\" of the PersonInfo class", ignore_extras);
            fieldGeneratorHeight = new AmountJSON.HoldingGenerator("field \"Height\" of the PersonInfo class", ignore_extras);
            fieldGeneratorWeight = new AmountJSON.HoldingGenerator("field \"Weight\" of the PersonInfo class", ignore_extras);
            fieldGeneratorNetWorth = new AmountJSON.HoldingGenerator("field \"NetWorth\" of the PersonInfo class", ignore_extras);
            fieldGeneratorTraits = new PersonTraitJSON.HoldingArrayGenerator("field \"Traits\" of the PersonInfo class", ignore_extras);
            fieldGeneratorEnemy = new WhoJSON.HoldingGenerator("field \"Enemy\" of the PersonInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonInfo class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDescription = new WrittenSpokenStringJSON.HoldingGenerator("field \"Description\" of the PersonInfo class", false);
            fieldGeneratorBirthplace = new MapLocationJSON.HoldingGenerator("field \"Birthplace\" of the PersonInfo class", false);
            fieldGeneratorDateOfDeath = new DateAndOrTimeJSON.HoldingGenerator("field \"DateOfDeath\" of the PersonInfo class", false);
            fieldGeneratorLocationOfDeath = new MapLocationJSON.HoldingGenerator("field \"LocationOfDeath\" of the PersonInfo class", false);
            fieldGeneratorCauseOfDeath = new WrittenSpokenStringJSON.HoldingGenerator("field \"CauseOfDeath\" of the PersonInfo class", false);
            fieldGeneratorPower = new WrittenSpokenStringJSON.HoldingGenerator("field \"Power\" of the PersonInfo class", false);
            fieldGeneratorAge = new AmountJSON.HoldingGenerator("field \"Age\" of the PersonInfo class", false);
            fieldGeneratorAgeAtDeath = new AmountJSON.HoldingGenerator("field \"AgeAtDeath\" of the PersonInfo class", false);
            fieldGeneratorMother = new WhoJSON.HoldingGenerator("field \"Mother\" of the PersonInfo class", false);
            fieldGeneratorFather = new WhoJSON.HoldingGenerator("field \"Father\" of the PersonInfo class", false);
            fieldGeneratorSpouse = new WhoJSON.HoldingGenerator("field \"Spouse\" of the PersonInfo class", false);
            fieldGeneratorSiblings = new WhoJSON.HoldingArrayGenerator("field \"Siblings\" of the PersonInfo class", false);
            fieldGeneratorChildren = new WhoJSON.HoldingArrayGenerator("field \"Children\" of the PersonInfo class", false);
            fieldGeneratorHeight = new AmountJSON.HoldingGenerator("field \"Height\" of the PersonInfo class", false);
            fieldGeneratorWeight = new AmountJSON.HoldingGenerator("field \"Weight\" of the PersonInfo class", false);
            fieldGeneratorNetWorth = new AmountJSON.HoldingGenerator("field \"NetWorth\" of the PersonInfo class", false);
            fieldGeneratorTraits = new PersonTraitJSON.HoldingArrayGenerator("field \"Traits\" of the PersonInfo class", false);
            fieldGeneratorEnemy = new WhoJSON.HoldingGenerator("field \"Enemy\" of the PersonInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonInfo class");
          }

        public override void reset()
          {
            fieldGeneratorDescription.reset();
            fieldGeneratorBirthplace.reset();
            fieldGeneratorDateOfDeath.reset();
            fieldGeneratorLocationOfDeath.reset();
            fieldGeneratorCauseOfDeath.reset();
            fieldGeneratorPower.reset();
            fieldGeneratorAge.reset();
            fieldGeneratorAgeAtDeath.reset();
            fieldGeneratorMother.reset();
            fieldGeneratorFather.reset();
            fieldGeneratorSpouse.reset();
            fieldGeneratorSiblings.reset();
            fieldGeneratorChildren.reset();
            fieldGeneratorHeight.reset();
            fieldGeneratorWeight.reset();
            fieldGeneratorNetWorth.reset();
            fieldGeneratorTraits.reset();
            fieldGeneratorEnemy.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonInfoJSON  result)
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
        public PersonInfoJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonInfoJSON  result)
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
    protected virtual void handle_result(List<PersonInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonInfoJSON>();
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
    public List<PersonInfoJSON> value;
  };
    public static new PersonInfoJSON from_WhoJSON_json(WhoJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        PersonInfoJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type PersonInfo", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
    public static PersonInfoJSON from_PersonProfileJSON_json(PersonProfileJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        PersonInfoJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type PersonInfo", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
