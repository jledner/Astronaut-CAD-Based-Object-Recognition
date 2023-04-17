using UnityEngine;
using Vuforia;

public class RotateObject : MonoBehaviour
{
    //public float torqueAmount = 100f; // the amount of torque to apply
    //public TrackableBehaviour trackable; // the image target to track

    //private bool isTracking = false;
    //private Quaternion initialRotation;

    //void Start()
    //{
    //    if (trackable != null)
    //    {
    //        trackable.RegisterTrackableEventHandler(this);
    //    }
    //    initialRotation = transform.rotation;
    //}

    //void Update()
    //{
    //    if (isTracking)
    //    {
    //        // calculate the angle between the initial and current rotations
    //        Quaternion targetRotation = trackable.transform.rotation * initialRotation;
    //        Quaternion deltaRotation = targetRotation * Quaternion.Inverse(transform.rotation);
    //        float angle = Quaternion.Angle(transform.rotation, targetRotation);

    //        // apply a torque to the GameObject based on the angle
    //        if (angle > 0.01f)
    //        {
    //            Vector3 axis = new Vector3(deltaRotation.x, deltaRotation.y, deltaRotation.z);
    //            float torque = torqueAmount * angle;
    //            transform.Rotate(axis, torque, Space.World);
    //        }
    //    }
    //}

    //public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    //{
    //    if (newStatus == TrackableBehaviour.Status.DETECTED ||
    //        newStatus == TrackableBehaviour.Status.TRACKED ||
    //        newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
    //    {
    //        isTracking = true;
    //    }
    //    else
    //    {
    //        isTracking = false;
    //    }
    //}
}
