using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Planes_Finde
{
    
    public (bool isTherePlan, bool isLocked) Plan_Ethan;
    public (bool isTherePlan, bool isLocked) Plan_Sophie;
    public (bool isTherePlan, bool isLocked) Plan_Allan;

    public Planes_Finde(bool isP_E, bool isP_E_Locked, bool isP_S, bool isP_S_Locked, bool isA_E, bool isA_E_Locked)
    {

        this.Plan_Ethan = (isP_E , isP_E_Locked);
        this.Plan_Sophie = (isP_S, isP_S_Locked);
        this.Plan_Allan = (isA_E, isA_E_Locked);
        createJSONPlanes();
    }

    public void createJSONPlanes()
    {
        string json = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("Planes", json);
    }

    //Sophie
    [YarnFunction("has_Sophie_Plan")]
    public static bool hasSophiePlan()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Sophie.isTherePlan;
    }
    [YarnFunction("is_Sophie_Plan_Locked")]
    public static bool isSophiePlanLocked()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Sophie.isLocked;
    }

    //Allan
    [YarnFunction("has_Allan_Plan")]
    public static bool hasAllanPlan()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Allan.isTherePlan;
    }
    [YarnFunction("is_Allan_Plan_Locked")]
    public static bool isAllanPlanLocked()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Allan.isLocked;
    }

    //Ethan
    [YarnFunction("has_Ethan_Plan")]
    public static bool hasEthanPlan()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Ethan.isTherePlan;
    }
    [YarnFunction("is_Ethan_Plan_Locked")]
    public static bool isEthanPlanLocked()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Ethan.isLocked;
    }
}
