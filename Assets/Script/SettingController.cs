using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SettingController : MonoBehaviour
{
    public GameObject Main_setting;
    Vector3 MainPos;
    private int SettingFlag = 0;
    

    public GameObject ManuController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Main_setting.transform.position.y <= 2686f && SettingFlag == 1)
        {
            Main_setting.transform.Translate(0f, (2686f - Main_setting.transform.position.y) / 15f, 0f);
            //Main_setting.transform.Translate(0f, 10f, 0f);

        }else if (SettingFlag != 2)
        {
            SettingFlag = 0;
            
        }

        if (Main_setting.transform.position.y >= 896f && SettingFlag == 2)
        {
            Main_setting.transform.Translate(0f, (896f - Main_setting.transform.position.y) / 14f, 0f);
        }
        else if(SettingFlag != 1)
        {
            SettingFlag = 0;
        }
    }


    public void ButtonClick(string ButtonName)
    {
        
        if (ButtonName == "Setting")
        {

            SettingFlag = 1;
            //èâä˙èÛë‘ÇÃM_SÇÃyç¿ïW:896
            //ê›íËèÛë‘ÇÃM_SÇÃyç¿ïW:2686
            //Debug.Log(Main_setting.transform.position.y);


        //    while (Main_setting.transform.position.y < 2686f)
        //    {
        //        Main_setting.transform.Translate(0f, 1f, 0f);
        //    }
        }

        if (ButtonName == "Initialize")
        {
            ManuController.gameObject.GetComponent<MainController>().Init();
            //Debug.Log("Initialized!");
        }

        if (ButtonName == "SettingClose") 
        {
            SettingFlag = 2;
            //while (Main_setting.transform.position.y > 896f)
            //{  
            //    Main_setting.transform.Translate(0f, -1f, 0f);
            //}
        }
        
    }   
}