using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeadLift : MonoBehaviour
{
    public void DeadLiftChange(Dropdown Exercise, Dropdown DeadLiftForm, Dropdown BenchLiftForm, Dropdown SquatLiftForm, Button BackBttn,
                    Camera DeadCam, Camera SquatCam, Camera BenchCam, Camera MainCam, Text ExerciseLbl, Text LiftLbl, Text DeadInfo, Text BenchInfo, Text SquatInfo)

    {

        SquatCam.gameObject.SetActive(false);
        DeadCam.gameObject.SetActive(true);
        BenchCam.gameObject.SetActive(false);
        MainCam.gameObject.SetActive(false);
        ExerciseLbl.gameObject.SetActive(false);
        Exercise.gameObject.SetActive(false);
        LiftLbl.gameObject.SetActive(true);
        DeadLiftForm.gameObject.SetActive(true);
        BenchLiftForm.gameObject.SetActive(false);
        SquatLiftForm.gameObject.SetActive(false);
        BackBttn.gameObject.SetActive(true);
        DeadInfo.gameObject.SetActive(true);
        SquatInfo.gameObject.SetActive(false);
        BenchInfo.gameObject.SetActive(false);
    }

}
