using System;
using UnityEngine;

public class AnimationScrubber : MonoBehaviour
{
    // to access the Animator object
    public Animator controller;
    public String animationName;
    public float timelineSpeed;

    private void OnEnable(){
        // when our component is enabled stop the animation 
        controller.speed = 0;

    } 

    public void Scrub(float value){
        // play the animation upto time = value
        controller.Play(animationName,-1,value);
    }


}
