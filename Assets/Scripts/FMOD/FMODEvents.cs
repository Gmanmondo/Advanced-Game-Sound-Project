using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FMODEvents : MonoBehaviour
{
    [field: Header("Music")]
    [field: SerializeField] public EventReference music {get; private set;}
    
    
    [field: Header("SFX")]
    [field: SerializeField] public EventReference bones {get; private set;}
    [field: SerializeField] public EventReference gameOver {get; private set;}
    [field: SerializeField] public EventReference strafe {get; private set;}
    [field: SerializeField] public EventReference jump {get; private set;}
    [field: SerializeField] public EventReference slide {get; private set;}

    public static FMODEvents instance {get; private set;}

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
}
