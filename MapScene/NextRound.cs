using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRound : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        Global.month++;
        if (Global.month > 12)
        {
            Global.month = Global.month % 12;
            Global.year++;
        }
        SceneManager.LoadScene("RoomScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
