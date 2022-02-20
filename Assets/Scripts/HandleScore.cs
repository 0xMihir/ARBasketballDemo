using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class HandleScore : MonoBehaviour
{
    [SerializeField]
    ScoreManager m_scoreManager;

    public ScoreManager scoreManager {
        get => m_scoreManager;
        set => m_scoreManager = value;
    }

    ParticleSystem confetti;

    void Start() {
        confetti = GetComponentInChildren<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("OnTriggerEnter");
            Destroy(other.gameObject);
            // m_scoreManager.score++;
            confetti.Play();
        }
    }
    
}
