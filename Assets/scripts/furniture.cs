using UnityEngine;

public class furniture : MonoBehaviour
{
    private Camera _cam;

    private Mode _mode = Mode.Move;
    private bool _selected = false;
    private bool _showMenu = false;


    private float _sensitivityRotate;

    private float lastClick = 0;

    private Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;

    private Vector3 _oldScale;
    private Vector3 _offsetPosition;


    enum Mode
    {
        Move,
        Rotate,
        Scale
    };


    void Start()
    {
        _sensitivityRotate = 0.4f;

        _rotation = Vector3.zero;

        _cam = Camera.main; 
    }

    void OnMouseUp()
    {
        _selected = false;
    }

    void OnMouseDown() {

        if (_showMenu)
            _showMenu = false;

        _selected = true;
        _mouseReference = Input.mousePosition;

        _oldScale = this.transform.localScale;
   
        _offsetPosition = _mouseReference;
        _offsetPosition.z = Camera.main.WorldToScreenPoint(this.transform.position).z;
        _offsetPosition = this.transform.position - _cam.ScreenToWorldPoint(_offsetPosition);


        if (Time.time - lastClick < 0.3)
            _showMenu = true;

        lastClick = Time.time;
    }
    

    void Update()
    {

        if (_selected)
        {
            _mouseOffset = (Input.mousePosition - _mouseReference);

            if (_mode == Mode.Rotate)
            {
                _mouseReference = Input.mousePosition;
                _rotation.y = -(_mouseOffset.x + _mouseOffset.y) * _sensitivityRotate;
                this.transform.Rotate(_rotation,Space.World);
            }

            else if (_mode == Mode.Move)
            {
                _mouseReference = Input.mousePosition;
                _mouseReference.z = _cam.WorldToScreenPoint(this.transform.position).z;
                _offsetPosition.y = -1f * _cam.ScreenToWorldPoint(_mouseReference).y - 40;
                this.transform.position = _cam.ScreenToWorldPoint(_mouseReference) + _offsetPosition;
            }

            else if (_mode == Mode.Scale)
            {
                float avg = (_mouseOffset.x + _mouseOffset.y + _mouseOffset.z)/ 3;
                this.transform.localScale = _oldScale +  new Vector3(avg,avg,avg) * 0.1f;
            }

        }
        
    }

    void OnGUI()
    {
        if (_showMenu == true)
        {
            if (GUI.Button(new Rect(_mouseReference.x+5, Screen.height-_mouseReference.y+5, 100,30), "Rotate"))
            {
                _mode = Mode.Rotate;
                _showMenu = false;
            }

            if (GUI.Button(new Rect(_mouseReference.x + 5, Screen.height - _mouseReference.y + 37, 100, 30), "Move"))
            {
                _mode = Mode.Move;
                _showMenu = false;
            }

            if (GUI.Button(new Rect(_mouseReference.x + 5, Screen.height - _mouseReference.y + 69, 100, 30), "Scale"))
            {
                _mode = Mode.Scale;
                _showMenu = false;
            }

            if (GUI.Button(new Rect(_mouseReference.x + 5, Screen.height - _mouseReference.y + 101, 100, 30), "Remove"))
            {
                Destroy(gameObject);
            }
        }
    }


}