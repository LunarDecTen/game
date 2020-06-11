using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tomap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene("MapScene");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
