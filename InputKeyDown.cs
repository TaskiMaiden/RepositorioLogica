using UnityEngine;

public class InputKeyDown : MonoBehaviour
{
    public KeyCode teclaDesejada;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(teclaDesejada))
        {
            Debug.Log("Tecla Apertada");
        }
        if (Input.GetKeyUp(teclaDesejada))
        {
            Debug.Log("Tecla Solta");
        }
    }
}
