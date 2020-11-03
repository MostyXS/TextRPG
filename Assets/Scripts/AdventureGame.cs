using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    // Start is called before the first frame update
    

    State state;
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();

    }

    private void ManageState()
    {
        State[] nextStates = state.GetNextStates();

        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+index))
            { 
                state = nextStates[index];
            }


        }
        
        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
            textComponent.text = state.GetStateStory();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
            textComponent.text = state.GetStateStory();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Error, you push the wrong button");
        }*/
        

        
    }
}
