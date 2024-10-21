using UnityEngine;

public class DraggableProperty : MonoBehaviour
{
    //=================
    //===Vars
    //=================

    [SerializeField] private Rigidbody dragRigidbody;

    private Vector3 dragScreenPoint;
    private Vector3 dragScreenOffset;

    public void OnMouseDown()
    {
        //Freeze
        dragRigidbody.constraints = RigidbodyConstraints.FreezeAll;

        //Movement
        dragScreenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        dragScreenOffset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragScreenPoint.z));
    }

    public void OnMouseUp()
    {
        //Freeze
        dragRigidbody.constraints = RigidbodyConstraints.None;        
    }

    public void OnMouseDrag()
    {
        //Movement
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragScreenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + dragScreenOffset;
        transform.position = curPosition;
    }
}
