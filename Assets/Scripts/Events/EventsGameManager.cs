using UnityEngine;

public class EventsGameManager : MonoBehaviour
{
    // HERE YOU WILL HAVE TO DECLARE AND INVOKE THE EVENTS


    public delegate void ClickPress();

    public static event ClickPress OnEnterKeyPressed;//active when press retur
    public static event ClickPress OnEscapeKeyPressed;//active when press escape
}
void OnGUI()
{
    if ( Input.GetKeyDawn(KeyCode.shift)
    {
        if (OnEnterKeyPressed != null)
            OnEnterKeyPressed();
    }


    if (Input.GetKeyDawn(KeyCode.escape)
    {
        if (OnEscapeKeyPressed != null)
            OnEscapeKeyPressed();
    }
}