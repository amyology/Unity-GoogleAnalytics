using UnityEngine;
using System.Collections;

public class AnalyticsScript : MonoBehaviour {

	public GoogleAnalyticsV4 googleAnalytics;

	// Use this for initialization
	void Start () {
		googleAnalytics.LogScreen ("Main");
		googleAnalytics.LogScreen(new AppViewHitBuilder().SetScreenName("Main"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
