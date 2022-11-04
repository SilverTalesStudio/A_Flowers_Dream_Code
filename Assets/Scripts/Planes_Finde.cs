using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class Planes_Finde
{
    
    public bool Plan_Ethan_isTherePlan;
    public bool Plan_Ethan_isLocked;
    public bool Plan_Sophie_isTherePlan;
    public bool Plan_Sophie_isLocked;
    public bool Plan_Allan_isTherePlan;
    public bool Plan_Allan_isLocked;



    public Planes_Finde(bool isP_E, bool isP_E_Locked, bool isP_S, bool isP_S_Locked, bool isP_A, bool isP_A_Locked)
    {
        this.Plan_Ethan_isTherePlan=isP_E;
        this.Plan_Ethan_isLocked=isP_E_Locked;
        this.Plan_Sophie_isTherePlan = isP_S;
        this.Plan_Sophie_isLocked = isP_S_Locked;
        this.Plan_Allan_isTherePlan = isP_A;
        this.Plan_Allan_isLocked = isP_A_Locked;


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
        return planes.Plan_Sophie_isTherePlan;
    }
    [YarnFunction("is_Sophie_Plan_Locked")]
    public static bool isSophiePlanLocked()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        return planes.Plan_Sophie_isLocked;
    }

    //Allan
    [YarnFunction("has_Allan_Plan")]
    public static bool hasAllanPlan()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        Debug.Log(planes.Plan_Allan_isTherePlan);
        return planes.Plan_Allan_isTherePlan;
    }
    [YarnFunction("is_Allan_Plan_Locked")]
    public static bool isAllanPlanLocked()
    {

        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        Debug.Log(planes.Plan_Allan_isLocked);
        return planes.Plan_Allan_isLocked;
    }

    //Ethan
    [YarnFunction("has_Ethan_Plan")]
    public static bool hasEthanPlan()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        Debug.Log(planes.Plan_Allan_isTherePlan);
        return planes.Plan_Ethan_isTherePlan;
    }
    [YarnFunction("is_Ethan_Plan_Locked")]
    public static bool isEthanPlanLocked()
    {
        string json = PlayerPrefs.GetString("Planes");
        Planes_Finde planes = JsonUtility.FromJson<Planes_Finde>(json);
        Debug.Log(planes.Plan_Allan_isLocked);
        return planes.Plan_Ethan_isLocked;
    }

}
