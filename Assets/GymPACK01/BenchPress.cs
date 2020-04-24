using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchPress : MonoBehaviour
{

    public static Camera deadCam;
    public static Camera SquatCam;
    public static Camera BenchCam;
    public void setCamera()
    {
        SquatCam.gameObject.SetActive(false);
        deadCam.gameObject.SetActive(false);
        BenchCam.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
