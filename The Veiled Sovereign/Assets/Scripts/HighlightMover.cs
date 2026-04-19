using UnityEngine;

public class HighlightMover : MonoBehaviour
{
    public RectTransform highlight;
    public RectTransform defaultTarget; // Play button

    private Vector3 targetPos;

    void Start()
    {
        MoveTo(defaultTarget); // set initial position
    }

    void Update()
    {
        highlight.position = Vector3.Lerp(
            highlight.position,
            targetPos,
            Time.deltaTime * 10f
        );
    }

    public void MoveTo(RectTransform target)
    {
        targetPos = target.position;
    }
}