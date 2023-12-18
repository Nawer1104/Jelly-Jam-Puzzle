using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Enum type;

    Jelly jelly;

    public void SetJelly(Jelly jelly)
    {
        this.jelly = jelly;
        jelly.transform.position = transform.position;
        jelly.gameObject.GetComponent<DragAndDrop>()._dragging = false;
    }

    public void RemoveJelly()
    {
        this.jelly = null;
    }

    public Jelly GetJelly()
    {
        if (jelly != null)
        {
            return jelly;
        }
        else
        {
            return null;
        }
    }
}
