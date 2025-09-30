using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    // Variable
    public TextMeshProUGUI text;
    public InputActionReference e;

    private int score;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        text.text = "gameStart";


    }

    // Update is called once per frame
    void Update()
    {

        text.text = "Score " + score;

        if (e.action.WasPressedThisFrame())
        {

            score++;


        }

        
    }
}
