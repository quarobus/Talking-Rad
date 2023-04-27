using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Windows.Speech;

public class VoiceMovement : MonoBehaviour
{
    private Animator anim;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, System.Action> actions = new Dictionary<string, System.Action>();

    void Start()
    {
        anim = GetComponent<Animator>();
        actions.Add("forward", Forward);
        actions.Add("left", Left);
        actions.Add("right", Right);
        actions.Add("back", Back);
        actions.Add("Backflip", BackFlip);
        actions.Add("Play the guitar", PlayTheGuitar);
        actions.Add("Thank you", ThankYouBow);
        actions.Add("Zombie Dance", ZombieDance);
        actions.Add("dance", Dance);
        actions.Add("fight", Fight);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();  
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Forward()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Forward", 0, 0.1f);
        }
    }
    private void Back()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Back", 0, 0.1f);
        }
    }
    private void Left()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Left", 0, 0.1f);
        }
    }
    private void Right()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Right", 0, 0.1f);
        }
    }
    private void BackFlip()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.BackFlip", 0, 0.1f);
        }
    }
    private void PlayTheGuitar()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.PlayTheGuitar", 0, 0.1f);
        }
    }
    private void ThankYouBow()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.ThankYouBow", 0, 0.1f);
        }
    }
    private void ZombieDance()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.ZombieDance", 0, 0.1f);
        }
    }
    private void Dance()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Dance", 0, 0.1f);
        }
    }
    private void Fight()
    {
        if (anim != null)
        {
            anim.Play("Base Layer.Fight", 0, 0.1f);
        }
    }
}
