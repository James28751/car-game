using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
     GameObject flag;
     GameObject car;
     GameObject UItext;
    GameObject over;
    GameObject MDF;



    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
       UItext = GameObject.Find("UItext");
        over = GameObject.Find("overtext");
        MDF= GameObject.Find("MDF");
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        float er = flag.transform.position.x -
            car.transform.position.x;
        UItext.GetComponent<Text>().text = "�Z���ؼ��٦� " + er.ToString("F2") + "m";
        if (Input.GetMouseButtonUp(0))
        {
           
            if (er > 0)
            {
                float eq = (car.transform.position.x - MDF.transform.position.x) / (flag.transform.position.x-MDF.transform.position.x);
                //������m-�X�o�I(-1)/�X�m��m-�X�o�I(25-(-1)) 11/26 %��
                float en = eq * 100;
                over.GetComponent<Text>().text = "����: " + en.ToString("F2") + "��";
            }
            else if (er < 0)
            {
                over.GetComponent<Text>().text = "����:0��";
            }

        }

    }
}
