using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LiftOption : MonoBehaviour
{
    void Start()
    {
        SquatCam.gameObject.SetActive(false);
        DeadCam.gameObject.SetActive(false);
        BenchCam.gameObject.SetActive(false);
        MainCam.gameObject.SetActive(true);
        LiftLbl.gameObject.SetActive(false);
        DeadLiftForm.gameObject.SetActive(false);
        BenchLiftForm.gameObject.SetActive(false);
        SquatLiftForm.gameObject.SetActive(false);
        BackBttn.gameObject.SetActive(false);
        ExerciseLbl.color = Color.white;
        DeadInfo.gameObject.SetActive(false);
        SquatInfo.gameObject.SetActive(false);
        BenchInfo.gameObject.SetActive(false);

    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public Dropdown Exercise;
    public Dropdown DeadLiftForm;
    public Dropdown BenchLiftForm;
    public Dropdown SquatLiftForm;


    public Button BackBttn;
    public Camera DeadCam;
    public Camera SquatCam;
    public Camera BenchCam;
    public Camera MainCam;
    public Text ExerciseLbl;
    public Text LiftLbl;

    public Text DeadInfo;
    public Text BenchInfo;
    public Text SquatInfo;


    //public Animator deadLift;
    public static string value;

    public void MainMenu()
    {
        SquatCam.gameObject.SetActive(false);
        DeadCam.gameObject.SetActive(false);
        BenchCam.gameObject.SetActive(false);
        MainCam.gameObject.SetActive(true);
        LiftLbl.gameObject.SetActive(false);
        DeadLiftForm.gameObject.SetActive(false);
        BenchLiftForm.gameObject.SetActive(false);
        SquatLiftForm.gameObject.SetActive(false);
        ExerciseLbl.gameObject.SetActive(true);
        ExerciseLbl.color = Color.black;
        Exercise.gameObject.SetActive(true);
        BackBttn.gameObject.SetActive(false);
        DeadInfo.gameObject.SetActive(false);
        SquatInfo.gameObject.SetActive(false);
        BenchInfo.gameObject.SetActive(false);

    }
    public void liftOption()
    {
        switch (Exercise.value)
        {
            case 1:
                //deadlift;
                DeadLift Dead = new DeadLift();
                Dead.DeadLiftChange( Exercise, DeadLiftForm, BenchLiftForm, SquatLiftForm, BackBttn, 
                    DeadCam, SquatCam, BenchCam, MainCam, ExerciseLbl, LiftLbl, DeadInfo, BenchInfo, SquatInfo);
                //set active camera to dead lift;

                //drop down value for lift form
                break;

            case 2:
                //Bench
                BenchLift Bench = new BenchLift();
                Bench.BenchPress(Exercise, DeadLiftForm, BenchLiftForm, SquatLiftForm, BackBttn, 
                DeadCam, SquatCam, BenchCam, MainCam, ExerciseLbl, LiftLbl, DeadInfo, BenchInfo, SquatInfo);
                //set active camera to Bench press

                //drop down value for lift form
                break;

            case 3:
                //squat;

                SquatLift Squat = new SquatLift();
                Squat.SquatLiftChange(Exercise, DeadLiftForm, BenchLiftForm, SquatLiftForm, BackBttn,
                DeadCam, SquatCam, BenchCam, MainCam, ExerciseLbl, LiftLbl, DeadInfo, BenchInfo, SquatInfo);

                //set active camera to squat;
                
                //formType();

                break;

            default :

                MainMenu();
               
                break;

        }
    }
    /*
    public static int numValue;
 
    public void formType()
    {
        
        switch (LiftForm.value)
        {
            case 1:
                numValue = 1;
                //deadLift.SetTrigger("Idle");
                //GetComponent<Animator>().SetBool("Idle", true);
                //GetComponent<Animator>().SetBool("Bad", false);
                //GetComponent<Animator>().SetBool("Good", false);
                break;

            case 2:
                numValue = 2;
                //animation for correct form
                //GetComponent<Animator>().SetBool("Idle", false);
                //GetComponent<Animator>().SetBool("Bad", false);
                //deadLift.SetTrigger("Good");
                //GetComponent<Animator>().SetBool("Good", true);
                break;
            case 3:
                numValue = 3;
                //deadLift.SetTrigger("Bad");
                // GetComponent<Animator>().SetBool("Idle", false);
                // GetComponent<Animator>().SetBool("Bad", true);
                //GetComponent<Animator>().SetBool("Good", false);
                break;


            default:
                numValue = 1;
                //deadLift.SetTrigger("Idle");
                //GetComponent<Animator>().SetBool("Idle", true);
                //GetComponent<Animator>().SetBool("Bad", false);
                //GetComponent<Animator>().SetBool("Good", false);
                //animation for incorrect form

                break;
        }
    }*/
}
