using UnityEngine;
using Wikitude;

public class TrackerToggle : SampleController
{
    public ObjectTracker OTracker;
    public ImageTracker ITracker;

    private bool _waitingForTrackerToLoad = false;

    public void OnOTracker() {
        if (!OTracker.enabled && !_waitingForTrackerToLoad) {
            _waitingForTrackerToLoad = true;

            OTracker.enabled = true;
        }
    }

    public void OnITracker() {
        if (!ITracker.enabled && !_waitingForTrackerToLoad) {
            _waitingForTrackerToLoad = true;

            ITracker.enabled = true;
        }
    }

    public override void OnTargetsLoaded() {
        _waitingForTrackerToLoad = false;
    }
}
