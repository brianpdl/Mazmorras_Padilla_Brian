using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    // Start is called before the first frame update
    private Outline outline;

    [SerializeField] private Texture2D cursorInteraccion;
    [SerializeField] private Texture2D cursorPorDefecto;
    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnMouseEnter()// cunado pasamos x encima 
    {
        Cursor.SetCursor(cursorInteraccion, Vector2.zero, CursorMode.Auto);
        outline.enabled = true;
            

    }

    private void OnMouseExit()//se quita el raton
    {
        Cursor.SetCursor(cursorPorDefecto, Vector2.zero, CursorMode.Auto);

        outline.enabled = false;
    }
}
