using UnityEngine;

public class InputMouse : MonoBehaviour
{
    public SpriteRenderer triangulo;
    public Color cor1;
    public Color cor2;
    public Color cor3;

    // Roda ao Detectar mouse entrando no colisor do objeto
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
        triangulo.color = cor1; 
    }
    // Roda ao Detectar mouse saindo do colisor do objeto
    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
        triangulo.color = cor2;
    }

    // Roda ao Detectar clique do mouse sobre colisor do objeto
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
        triangulo.color = cor3;
    }
}
