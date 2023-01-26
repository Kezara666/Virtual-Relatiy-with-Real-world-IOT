using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_off : MonoBehaviour
{
    
    public Light light_op;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        

        if (Input.GetKeyDown("f"))
        {
            
            string strCmdText;
            strCmdText= "/C a.bat";   //This command to open a new notepad
            System.Diagnostics.Process.Start("CMD.exe",strCmdText); //Start cmd process
            light_op.color=Color.black;    

        }
        if (Input.GetKeyDown("z"))
        {

            string strCmdText= "/C b.bat";   //This command to open a new notepad
            System.Diagnostics.Process.Start("CMD.exe",strCmdText); //Start cmd process
            light_op.color=Color.black;     
            light_op.color=Color.white;

        }
        

        
        
    }
}
