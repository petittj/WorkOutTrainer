using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenchLift : MonoBehaviour
{
    public void BenchPress(Dropdown Exercise, Dropdown DeadLiftForm, Dropdown BenchLiftForm, Dropdown SquatLiftForm, Button BackBttn,
                    Camera DeadCam, Camera SquatCam, Camera BenchCam, Camera MainCam, Text ExerciseLbl, Text LiftLbl, Text DeadInfo, Text BenchInfo, Text SquatInfo)
    {

        SquatCam.gameObject.SetActive(false);
        DeadCam.gameObject.SetActive(false);
        BenchCam.gameObject.SetActive(true);
        MainCam.gameObject.SetActive(false);
        ExerciseLbl.gameObject.SetActive(false);
        Exercise.gameObject.SetActive(false);
        LiftLbl.gameObject.SetActive(true);
        DeadLiftForm.gameObject.SetActive(false);
        BenchLiftForm.gameObject.SetActive(true);
        SquatLiftForm.gameObject.SetActive(false);
        BackBttn.gameObject.SetActive(true);
        DeadInfo.gameObject.SetActive(false);
        SquatInfo.gameObject.SetActive(false);
        BenchInfo.gameObject.SetActive(true);
        BenchInfo.color = Color.white;
        LiftLbl.color = Color.white;
    }
}
