using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ClimbInteractable : XRBaseInteractable
{
    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        if (interactor is XRDirectInteractor)
        {
            Climber.climbinghand = interactor.GetComponent<XRController>();
        }
        
    }
    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        if (interactor is XRDirectInteractor)
        {
            if (Climber.climbinghand && Climber.climbinghand.name == interactor.name)
            {
                Climber.climbinghand = null;
            }
        }
    }
}
