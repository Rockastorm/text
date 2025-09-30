using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    // Variable
    public TextMeshProUGUI text;
    public InputActionReference e;
    public InputActionReference b;

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

        if (b.action.WasPressedThisFrame())
        {

            score--;


        }


        if (score >= 100)
        {

            text.color = Color.green;


        }

        else if (score < 0)
        {

            text.color = Color.red;


        }

        else
        {

            text.color = Color.yellow;

        
        }


    }
}
