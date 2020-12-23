using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YuguLibrary.Enumerations;
using YuguLibrary.Models;

public class SkillHub : Skill
{
    public SkillHub(string skillJSONFileName, int levelObtained, int progressionPointObtained) : base(skillJSONFileName, levelObtained, progressionPointObtained)
    {

    }

    #region Functions
    #region Test Skill
    private void TestSkill()
    {
        Debug.Log("SkillHub:TestSkill");
    }

    private void TestSkillLogic()
    {
        Debug.Log("SkillHub:TestSkillLogic");
    }
    #endregion

    private void AirBall()
    {
        Debug.Log("SkillHub:AirBall");
        LaunchProjectile(skillChoreographies[0], skillChoreographies[1], 5, 4);
    }

    #endregion
}
