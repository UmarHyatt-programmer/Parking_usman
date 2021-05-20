using System;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace Yodo1.MAS
{
    public class Yodo1AdWindows : EditorWindow
    {
        Yodo1AdSettings adSettings;

        public enum PlatfromTab
        {
            Android,
            iOS
        }

        static PlatfromTab selectPlarformTab;
        Vector2 scrollPosition;

        static EditorWindow window;

        public Yodo1AdWindows()
        {
            selectPlarformTab = PlatfromTab.iOS;
        }

        public static void Initialize(PlatfromTab platfromTab)
        {
            if (window != null)
            {
                window.Close();
                window = null;
            }

            window = EditorWindow.GetWindow(typeof(Yodo1AdWindows), false, platfromTab.ToString() + " Setting", true);
            window.Show();
            selectPlarformTab = platfromTab;
        }

        #region cycle

        private void GUIEnable()
        {
            GUI.enabled = true;
        }

        private void GUIEnable(bool condition)
        {
            GUI.enabled = condition;
        }

        private void OnDisable()
        {
            this.SaveConfig();
            this.adSettings = null;
        }

        private void OnEnable()
        {
            this.adSettings = Yodo1AdSettingsSave.Load();
        }

        private void OnGUI()
        {
            this.scrollPosition = GUILayout.BeginScrollView(this.scrollPosition, new GUILayoutOption[0]);

            if (selectPlarformTab == PlatfromTab.iOS)
            {
                DrawIOSContent();
            }
            else
            {
                DrawAndroidContent();
            }

            GUIStyle gUIStyle = new GUIStyle();
            gUIStyle.padding = new RectOffset(10, 10, 10, 0);
            GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);
            if (GUILayout.Button("Save Configuration"))
            {
                this.SaveConfig();
            }
            GUILayout.EndVertical();

            GUILayout.EndScrollView();
        }

        #endregion

        private void DrawAndroidContent()
        {
            GUIStyle gUIStyle = new GUIStyle();
            gUIStyle.padding = new RectOffset(10, 10, 10, 0);

            GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);
            //Set AppKey
            this.adSettings.androidSettings.AppKey = EditorGUILayout.TextField("MAS App Key", this.adSettings.androidSettings.AppKey.Trim(), new GUILayoutOption[0]);
            if (string.IsNullOrEmpty(this.adSettings.androidSettings.AppKey.Trim()))
            {
                EditorGUILayout.HelpBox("Please fill in the MAS app key correctly, you can find your app key on the MAS dashboard.", MessageType.Error);
            }
            GUILayout.EndVertical();

            //GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);
            //EditorGUILayout.LabelField("Select the MAS SDK to be integrated:", new GUILayoutOption[0]);
            //GUILayout.EndVertical();

            GUIStyle storeStyle = EditorStyles.helpBox;
            storeStyle.padding = new RectOffset(5, 5, 5, 5);

            GUILayout.BeginVertical(storeStyle, new GUILayoutOption[0]);

            //Google Play Store
            //this.adSettings.androidSettings.GooglePlayStore = EditorGUILayout.BeginToggleGroup("Google Play-Global", this.adSettings.androidSettings.GooglePlayStore);
            //Set AdMob App ID
            this.adSettings.androidSettings.AdmobAppID = EditorGUILayout.TextField("AdMob App ID", this.adSettings.androidSettings.AdmobAppID.Trim(), new GUILayoutOption[0]);
            if (string.IsNullOrEmpty(this.adSettings.androidSettings.AdmobAppID.Trim()))
            {
                EditorGUILayout.HelpBox("A null or incorrect value will cause a crash when it builds. Please make sure to copy Admob App ID from MAS dashboard.", MessageType.Info);
            }

            //this.adSettings.androidSettings.ChineseAndroidStores = !this.adSettings.androidSettings.GooglePlayStore;
            //EditorGUILayout.EndToggleGroup();

            //Chinese Android Stores
            //this.adSettings.androidSettings.ChineseAndroidStores = EditorGUILayout.BeginToggleGroup("Chinese Android Stores", this.adSettings.androidSettings.ChineseAndroidStores);

            //Set Channel
            //this.adSettings.androidSettings.Channel = EditorGUILayout.TextField("Channel", this.adSettings.androidSettings.Channel, new GUILayoutOption[0]);
            //if (string.IsNullOrEmpty(this.adSettings.androidSettings.Channel))
            //{
            //    EditorGUILayout.HelpBox("Please enter the name of the app store.\nFor example: GooglePlay.", MessageType.Info);
            //}

            //EditorGUILayout.EndToggleGroup();
            //this.adSettings.androidSettings.GooglePlayStore = !this.adSettings.androidSettings.ChineseAndroidStores;

            GUILayout.EndVertical();

            //GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);

            ////Androd P Adaption(Network Security Configuration)
            //this.adSettings.androidSettings.networkSecurityConfiguration = EditorGUILayout.BeginToggleGroup("Network Security Configuration", this.adSettings.androidSettings.networkSecurityConfiguration);
            //EditorGUILayout.HelpBox("For some ad network to function correctly, you must whitelist clear text traffic using Android's Network Security Configuration feature.", MessageType.Info);
            //EditorGUILayout.EndToggleGroup();

            //GUILayout.EndVertical();
        }

        private void DrawIOSContent()
        {
            GUIStyle gUIStyle = new GUIStyle();
            gUIStyle.padding = new RectOffset(10, 10, 10, 0);

            GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);

            //Set AppKey
            this.adSettings.iOSSettings.AppKey = EditorGUILayout.TextField("MAS App Key", this.adSettings.iOSSettings.AppKey.Trim(), new GUILayoutOption[0]);
            if (string.IsNullOrEmpty(this.adSettings.iOSSettings.AppKey.Trim()))
            {
                EditorGUILayout.HelpBox("Please fill in the MAS app key correctly, you can find your app key on the MAS dashboard.", MessageType.Error);
            }

            GUILayout.EndVertical();

            //GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);
            //EditorGUILayout.LabelField("Select the MAS SDK to be integrated:", new GUILayoutOption[0]);
            //GUILayout.EndVertical();

            //GUIStyle storeStyle = EditorStyles.helpBox;
            //storeStyle.padding = new RectOffset(5, 5, 5, 5);

            GUILayout.BeginVertical(gUIStyle, new GUILayoutOption[0]);

            //Global Regbion
            //this.adSettings.iOSSettings.GlobalRegion = EditorGUILayout.BeginToggleGroup("Global", this.adSettings.iOSSettings.GlobalRegion);

            //Set AdMob App ID
            this.adSettings.iOSSettings.AdmobAppID = EditorGUILayout.TextField("AdMob App ID", this.adSettings.iOSSettings.AdmobAppID.Trim(), new GUILayoutOption[0]);
            if (string.IsNullOrEmpty(this.adSettings.iOSSettings.AdmobAppID.Trim()))
            {
                EditorGUILayout.HelpBox("A null or incorrect value will cause a crash when it builds. Please make sure to copy Admob App ID from MAS dashboard.", MessageType.Info);
            }

            //this.adSettings.iOSSettings.AppLovinSdkKey = EditorGUILayout.TextField("AppLovin Sdk Key", this.adSettings.iOSSettings.AppLovinSdkKey, new GUILayoutOption[0]);
            //if (string.IsNullOrEmpty(this.adSettings.iOSSettings.AppLovinSdkKey))
            //{
            //    EditorGUILayout.HelpBox("AppLovin Sdk Key Missing for this platform", MessageType.Info);
            //}
            //Debug.Log("[Yodo1 Mas] applovinSdkKey:" + this.adSettings.iOSSettings.AppLovinSdkKey);

            //EditorGUILayout.EndToggleGroup();

            // this.adSettings.iOSSettings.ChinaRegion = !this.adSettings.iOSSettings.GlobalRegion;

            //China Region
            //this.adSettings.iOSSettings.ChinaRegion = EditorGUILayout.BeginToggleGroup("Mainland China Only", this.adSettings.iOSSettings.ChinaRegion);
            //EditorGUILayout.EndToggleGroup();
            //this.adSettings.iOSSettings.GlobalRegion = !this.adSettings.iOSSettings.ChinaRegion;

            GUILayout.EndVertical();
        }

        private void SaveConfig()
        {
            if (selectPlarformTab == PlatfromTab.Android)
            {

                if (Yodo1PostProcess.CheckConfiguration_Android(this.adSettings))
                {
#if UNITY_2019_1_OR_NEWER
#else
                    Yodo1PostProcess.ValidateManifest(this.adSettings);
                    Yodo1PostProcess.GenerateGradle();
#endif
                }
                else
                {
                    return;
                }
            }
            if (selectPlarformTab == PlatfromTab.iOS)
            {
                if (!Yodo1PostProcess.CheckConfiguration_iOS(this.adSettings))
                {
                    return;
                }
            }

            Yodo1AdSettingsSave.Save(this.adSettings);
            Yodo1AdSettingsSave.UpdateDependencies(this.adSettings);
        }
    }
}
