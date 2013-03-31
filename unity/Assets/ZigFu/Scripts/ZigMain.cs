using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Project_gbl.Functions;

public class ZigMain : MonoBehaviour {
    public ZigInputType inputType = ZigInputType.Auto;
    //public bool UpdateDepthmap = true;
    //public bool UpdateImagemap = false;
    //public bool UpdateLabelmap = false;
    //public bool AlignDepthToRGB = false;
    public ZigInputSettings settings = new ZigInputSettings();
    public bool Verbose = true;
	public GameObject zigFuGameObject;
	public GameObject playerObject;
    
    
	void Awake () {
        #if UNITY_WEBPLAYER
        #if UNITY_EDITOR
        Debug.LogError("Depth camera input will not work in editor when target platform is Webplayer. Please change target platform to PC/Mac standalone.");
        return;
        #endif
        #endif

        ZigInput.InputType = inputType;
        ZigInput.Settings = settings;
        //ZigInput.UpdateDepth = UpdateDepthmap;
        //ZigInput.UpdateImage = UpdateImagemap;
        //ZigInput.UpdateLabelMap = UpdateLabelmap;
        //ZigInput.AlignDepthToRGB = AlignDepthToRGB;
		ZigInput.Instance.AddListener(gameObject);
		FunctionsController.Instance.UpdateObjectOnScreen(playerObject);
		Debug.Log ("Yo all");
	}
	

    void Zig_UserFound(ZigTrackedUser user) {
	     Debug.Log ("User Found");

    }

    void Zig_UserLost(ZigTrackedUser user) {
		Debug.Log ("Yo all Lost");

    }

    void Zig_Update(ZigInput zig) {
		FunctionsController.Instance.UpdateZigInformation(zig);
    }
  
}
