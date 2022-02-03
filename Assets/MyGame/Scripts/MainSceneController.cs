
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldTermA, inputFieldTermB;
    [SerializeField] private Text txtResult;
    private int termA, termB;

    public int CheckAddition(int summandA, int summandB)
    {
        int result = 0;

        result = summandA + summandB;

        Debug.Log(result);
        txtResult.text = string.Format("{0}", result);
        return result;
    }
    void Start()
    {
        Debug.Log("Frohe Weihnachten");
    }

    public void GetValues()
    {
        /*f(Regex.IsMatch(inputFieldTermA.text, @"^\d+$") && Regex.IsMatch(inputFieldTermB.text, @"^\d+$")) 
        //überprüft ob in den Inputboxxen ein Zahlenwert steht
        {
            termA = int.Parse(inputFieldTermA.text);
            termB = int.Parse(inputFieldTermB.text);
        }
        else
        {
            termA = 0;
            termB = 0;
        }*/

        try
        {
            termA = int.Parse(inputFieldTermA.text);
        }
        catch (System.Exception)
        {

            inputFieldTermA.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "falsch";
            inputFieldTermA.text = "";
        }

        try
        {
            termB = int.Parse(inputFieldTermB.text);
        }
        catch (System.Exception)
        {

            inputFieldTermB.GetComponent<InputField>().image.color = Color.red;
            inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "falsch";
            inputFieldTermB.text = "";
        }

        txtResult.text = CheckAddition(termA, termB).ToString(); //ruft die Additionsfunktion auf
    }
        

    public void ResetAll()
    {
        txtResult.text = "";
        inputFieldTermA.text = "";
        inputFieldTermB.text = "";
        termA = 0;
        termB = 0;
        Color newColor = new Color(288, 167, 162, 255);
        inputFieldTermA.GetComponent<InputField>().image.color = newColor;
        inputFieldTermB.GetComponent<InputField>().image.color = newColor;
        inputFieldTermA.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben";
        inputFieldTermB.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "Ganze Zahl eingeben";
    }
    void Update()
    {
        
    }
}

