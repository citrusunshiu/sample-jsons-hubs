using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Models;

namespace UnitAIs
{
    public class TestAI : UnitAI
    {
        Unit unit;

        public TestAI(Unit unit)
        {
            this.unit = unit;
        }

        public override UnitAIAction GetUnitAIAction()
        {
            UnitAIAction unitAIAction;
            unitAIAction = UnitAILogic.RandomMove(unit);
            return unitAIAction;
        }
    }

    public class BabyReidentAI : UnitAI
    {
        public override UnitAIAction GetUnitAIAction()
        {
            throw new System.NotImplementedException();
        }
    }

}
public static class UnitAIHub
{
    public static UnitAIAction TestUnitAIHub(Unit unit)
    {
        UnitAIAction unitAIAction;
        unitAIAction = UnitAILogic.RandomMove(unit);
        return null;
    }
}
