using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class date : MonoBehaviour
{
    private Text m_Text;
    // Start is called before the first frame update
    void Start()
    {
        m_Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //DateTime dateTime = DateTime.Now;
        m_Text.text = "时间为"+Global.year+"年"+Global.month+"月";
    }
}
