using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo sali� mal");
        Debug.Log("Hola Mundo");
        Debug.LogError("Algo sali� muy mal");
        Debug.LogWarning("Algo sali� medianamente mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    