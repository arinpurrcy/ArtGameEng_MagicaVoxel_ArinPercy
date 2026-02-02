using UnityEngine;
using UnityEngine.Playables;

public class carcrashtrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }

}
