using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ShootBall : MonoBehaviour
{
    [SerializeField]
    GameObject m_ballPrefab;
    public GameObject BallPrefab {
        get => m_ballPrefab;
        set => m_ballPrefab = value;
    }
    

    [SerializeField]
    ARCameraManager m_camera;
    public ARCameraManager ARCamera {
        get => m_camera;
        set => m_camera = value;
    }
    
    [SerializeField]
    AnchorCreator m_anchorCreator;
    public AnchorCreator Creator {
        get => m_anchorCreator;
        set => m_anchorCreator = value;
    }

    

   

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (!m_anchorCreator.g_anchorPlaced && Input.touchCount == 0)
            return;

        var touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began)
            return;
        Debug.Log("ShootBall Touch");

        var ball = Instantiate(m_ballPrefab, m_camera.transform.position, m_camera.transform.rotation);
        var rigidBody = ball.GetComponent<Rigidbody>();
        rigidBody.AddForce(m_camera.transform.forward * 5, ForceMode.Impulse);
        Debug.Log("ShootBall Spawned");
    }
}
