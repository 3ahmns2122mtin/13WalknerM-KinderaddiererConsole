using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;

    private int termA, termB;
    public bool testing;
    
    

     // Start is called before the first frame update
    public int CheckAddition(int summandA,int summandB)
    {
        int result = 0;     //Wert wirt zugewiesen und deklariert
        testing = false;


        result = summandA + summandB;
        Debug.Log(result);
        return result;
    }

    void Start()
    {
        
        inputFieldTermA.text = "Geben sie eine Zahl ein";
    }

    void GetValues()
    {
        //string termA, termB;
        //termA = inputFieldTermA.text;
        //termB = inputFieldTermB.text;



        //Debug.Log("Methode GetValues wird ausgeführt" +  CheckAddition (int.Parse(termA), int.Parse(termB)));
        try
        {

            termA = int.Parse(inputFieldTermA.text);
        }
        catch (System.Exception)
        {
            inputFieldTermA.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "hallo";
            inputFieldTermA.text = "";
        }

        termB = int.Parse(inputFieldTermB.text);

        txtResult.text = CheckAddition(termA, termB).ToString();
 
    }


    public void ResetAll ()
    {
        txtResult.text = "";
        inputFieldTermA.text = "";
        inputFieldTermB.text = "";
    }
   

    
    void Update()
    {
       
    }

    
}
