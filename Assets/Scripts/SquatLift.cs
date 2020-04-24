using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SquatLift : MonoBehaviour
{
    public void SquatLiftChange(Dropdown Exercise, Dropdown DeadLiftForm, Dropdown BenchLiftForm, Dropdown SquatLiftForm, Button BackBttn,
                    Camera DeadCam, Camera SquatCam, Camera BenchCam, Camera MainCam, Text ExerciseLbl, Text LiftLbl, Text DeadInfo, Text BenchInfo, Text SquatInfo)
    {
        SquatCam.gameObject.SetActive(true);
        DeadCam.gameObject.SetActive(false);
        BenchCam.gameObject.SetActive(false);
        MainCam.gameObject.SetActive(false);
        ExerciseLbl.gameObject.SetActive(false);
        Exercise.gameObject.SetActive(false);
        LiftLbl.gameObject.SetActive(true);
        DeadLiftForm.gameObject.SetActive(false);
        BenchLiftForm.gameObject.SetActive(false);
        SquatLiftForm.gameObject.SetActive(true);
        BackBttn.gameObject.SetActive(true);
        DeadInfo.gameObject.SetActive(false);
        SquatInfo.gameObject.SetActive(true);
        BenchInfo.gameObject.SetActive(false);
        SquatInfo.color = Color.black;
    }
}
