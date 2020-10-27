using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipSprite : MonoBehaviour
{
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject glowEffect;
    [SerializeField] GameObject fader;
    [SerializeField] AudioClip[] audioClips;
    const float delay = 0.05f;
    bool spriteSwitched;

    void Start()
    {
        spriteSwitched = false;
    }

    void Update()
    {
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime<=1)
        {
            if(!spriteSwitched)
            {
                SwitchAllSprites(1, true);
            }
            else
            {
                SwitchAllSprites(0, false);
            }
        }
    }

    void SwitchAllSprites(int index, bool triggerSet)
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            gameObject.transform.GetChild(i).GetComponent<Image>().sprite = sprites[index];
        }
        StartCoroutine(WaitBeforeSetting(triggerSet));
        
    }

    IEnumerator WaitBeforeSetting(bool triggerSet)
    {
        yield return new WaitForSeconds(delay);
        spriteSwitched = triggerSet;
    }

    public void StartGlow()
    {
        glowEffect.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(audioClips[0]);
        StartCoroutine(WaitAndDisplay());
    }

    IEnumerator WaitAndDisplay()
    {
        yield return new WaitForSecondsRealtime(glowEffect.GetComponent<ParticleSystem>().main.duration);
        fader.GetComponent<Animator>().SetTrigger("FaderOpen");
        GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
        StartCoroutine(WaitAndLoadToMainMenu());
    }

    IEnumerator WaitAndLoadToMainMenu()
    {
        yield return new WaitForSeconds(4f);
        LevelManager.LoadNextLevel();
    }
}
