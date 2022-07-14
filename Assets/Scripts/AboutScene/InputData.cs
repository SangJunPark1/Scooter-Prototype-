using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class InputData : MonoBehaviour
{
    string filename = "";

    public InputField InputText_Name;
    public InputField InputText_Age;
    public InputField InputText_Height;
    public InputField InputText_Weight;


    void Start()
    {
        filename = Application.dataPath + "/Subject_Information.csv";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WriteCSV()
    {
       
        TextWriter tw = new StreamWriter(filename, false);

        tw.WriteLine("Name, Age, Height, Weight");
        tw.Close();

        tw = new StreamWriter(filename, true);
        tw.WriteLine(InputText_Name.text + "," + InputText_Age.text + "," + InputText_Height.text + "," + InputText_Weight.text);
        tw.Close();

        Debug.Log("asdfsadfsdaf");
    }

}
