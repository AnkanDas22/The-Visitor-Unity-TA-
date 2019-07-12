using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] State initialState;
    [SerializeField] TextMeshProUGUI storytext;
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = initialState;
        storytext.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    void ManageStates()
    {
        State[] nextstates = state.GetNextStates();
        for (int i = 0; i < nextstates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextstates[i];
            }
        }
        storytext.text = state.GetStateStory();
    }
}
