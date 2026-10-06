using System.Collections;
using RoR2;
using UnityEngine;

public class MenuSoundComponent : MonoBehaviour
{
    private uint playID1 = 0u;

    private uint playID2 = 0u;

    private void OnEnable()
    {
        base.StartCoroutine(this.delayedGunSound(5f / 24f, "ConscriptDisplayThrow"));
        base.StartCoroutine(this.delayedGunSound(23f / 24f, "ConscriptDisplayCatch"));
    }

    private IEnumerator delayedGunSound(float delay, string playedSound)
    {
        yield return new WaitForSeconds(delay);
        if (playedSound == "ConscriptDisplayThrow")
        {
            this.playID1 = Util.PlaySound(playedSound, base.gameObject);
        }
        else
        {
            this.playID2 = Util.PlaySound(playedSound, base.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (this.playID1 != 0)
        {
            AkSoundEngine.StopPlayingID(this.playID1);
        }
        if (this.playID2 != 0)
        {
            AkSoundEngine.StopPlayingID(this.playID2);
        }
    }
}
