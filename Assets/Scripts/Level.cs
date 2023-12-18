using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Point> points;

    public void CheckJelly()
    {
        foreach(Point point in points)
        {
            if (point.GetJelly() == null) return;

            if (point.type != point.GetJelly().type) return;
        }

        GameManager.Instance.CheckLevelUp();
    }

    public static List<GameObject> GetAllChilds(GameObject Go)
    {
        List<GameObject> list = new List<GameObject>();
        for (int i = 0; i < Go.transform.childCount; i++)
        {
            list.Add(Go.transform.GetChild(i).gameObject);
        }
        return list;
    }
}
