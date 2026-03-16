using System;
using BepInEx;
using UnityEngine.SceneManagement;

namespace MyMod {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.my.mod";
			public const string NAME = "My Mod";
			public const string VERSION = "1.0.0";
		}

		private void Start() {
			string layerName = "TEST /// FIRST";
			string levelName = "ME";
			SceneManager.sceneLoaded += (scene, mode) => {
				LevelNamePopup activator = FindObjectOfType<LevelNamePopup>();
				if (!activator) {
					return;
				}
				
				// somehow change levelString and nameString, even though they're private properties...
			};
		}
	}
}