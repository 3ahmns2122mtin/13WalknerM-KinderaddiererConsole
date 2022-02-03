using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
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
        int val1 = CheckAddition(1,2);
        int val2 = CheckAddition(10, 20);
        int val3 = CheckAddition(100, 200);

        Debug.Log("val1 : " + val1 + "val2 + val3: " + (val1 + val2));
        Debug.Log("Nach Methodenaufruf sg. Call");
        Debug.Log("Frohe Weihnachten");

        inputFieldTermA.text = "HALLO";
    }

    public void GetValues()
    {
        string termA, termB;
        termA = inputFieldTermA.text;
        termB = inputFieldTermB.text;

        Debug.Log("Methode GetValues wird ausgeführt" +  CheckAddition (int.Parse(termA), int.Parse(termB)));
    }

   

    //Reset auf 0 von TermA & TermB

    // Update is called once per frame
    void Update()
    {
       
    }

    
}
