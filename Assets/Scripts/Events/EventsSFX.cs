using UnityEngine;

public class EventsSFX : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private ParticleSystem particleSystem;

    #endregion

    private void Awake()
    {
        StopParticleSystem();
    }

    private void StartParticleSystem()
    {
        EventsGameManager.OnEnterKeyPressed += (particleSystem.Play());
    }
    
    private void StopParticleSystem()
    {
        EventsGameManager.OnEscapeKeyPressed += (particleSystem.Stop());
    }
}
