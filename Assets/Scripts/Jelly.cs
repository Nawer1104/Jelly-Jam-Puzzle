using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public GameObject vfxAttach;

    public Enum type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Point"))
        {
            if (collision.GetComponent<Point>().GetJelly() != null) return;
            PlayVfx();
            collision.GetComponent<Point>().SetJelly(this);
            GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].CheckJelly();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Point"))
        {
            if (collision.GetComponent<Point>().GetJelly() != null)
            {
                collision.GetComponent<Point>().RemoveJelly();
            }
            
        }
    }

    public void PlayVfx()
    {
        GameObject vfx = Instantiate(vfxAttach, transform.position, Quaternion.identity) as GameObject;
        Destroy(vfx, 1f);
    }
}
