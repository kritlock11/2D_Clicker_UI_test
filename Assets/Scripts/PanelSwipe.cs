using UnityEngine;

public class PanelSwipe : MonoBehaviour
{
    private Vector2 startTouchPos, endTouchPos;
    public Vector2 startPanelPos, endPanelPos, currPanelPos;
    private float touchSwipeRange = 50;
    private float mouseSwipeRange = 1.7f;
    private bool swipedleft;
    private void Start()
    {
        startPanelPos = transform.position;
        endPanelPos = new Vector2(0, transform.position.y);
    }
    private void TouchSwipeTalents()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPos = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPos = Input.GetTouch(0).position;

            var v = (endTouchPos.x - startTouchPos.x);

            if ((endTouchPos.x < startTouchPos.x) && v < -touchSwipeRange)
            {
                swipedleft = true;
                transform.position = endPanelPos;
            }
            else if ((endTouchPos.x > startTouchPos.x) && v > touchSwipeRange && swipedleft)
            {
                swipedleft = false;
                transform.position = startPanelPos;
            }
        }
    }

    private void MouseSwipeTalents()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            endTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            var v = (endTouchPos.x - startTouchPos.x);
            Debug.Log($"{v}");

            if ((endTouchPos.x < startTouchPos.x) && v < -mouseSwipeRange)
            {
                swipedleft = true;
                transform.position = endPanelPos;
            }
            else if ((endTouchPos.x > startTouchPos.x) && v > mouseSwipeRange && swipedleft)
            {
                swipedleft = false;
                transform.position = startPanelPos;
            }
        }
    }
    void Update()
    {
        //TouchSwipeTalents();
        MouseSwipeTalents();
    }
}
