using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerprintScanner : MonoBehaviour
{
    public Door door; // link to door
    
    private bool scanChanged; // is fingerprint changed in PC

    // Start is called before the first frame update
    void Start()
    {
        scanChanged = false;
    }

    public void ChangeScanStatus() { scanChanged = true; }

    private void OnMouseDown()
    {
        if (scanChanged) door.ChangeProgressStatus(2);
    }
}
