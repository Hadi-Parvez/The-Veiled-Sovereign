using UnityEngine;
using TMPro;

public class PointsManager : MonoBehaviour
{
    public TMP_Text points;
    int point = 0;

    void Start()
    {
        UpdatePoints();
    }

    public void AddPoints(int value)
    {
        point += value;
        UpdatePoints();
    }

    void UpdatePoints()
    {
        points.text = point.ToString();
    }
}