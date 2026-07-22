namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs
{

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("DeleteAllWithCallback")]
	public static void DeleteAll() { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnDeauth>b__125_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static void DeleteKey(string key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void DeleteKey_Injected(ref ManagedSpanWrapper key) { }

	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CameraController", Member = "InitCameraDefaults", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound", Member = "PlayBGM", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound", Member = "GetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.SoundTypes"}, ReturnType = typeof(float))]
	[CalledBy(Type = "Manager.Sound", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "LoadPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "LoadPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static float GetFloat(string key, float defaultValue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue) { }

	[CallerCount(Count = 89)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public static int GetInt(string key, int defaultValue) { }

	[CalledBy(Type = "Manager.Hotkey", Member = "SaveCustomHKSet", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsInvalidInstructions]
	public static int GetInt(string key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "LoadFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "GetInitialPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "Show", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "get_LastBrowsedFolder", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager+<RenameDeck>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<DeleteDeck>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck", Member = "get_LastUsedDeckName", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Deck", Member = "get_CurrentDeck", ReturnType = "Card.Deck")]
	[CalledBy(Type = "ClientAPI.WebServer+UserData", Member = "GetDLT", ReturnType = typeof(string))]
	[CalledBy(Type = "Data.BinaryExtensions", Member = "GetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings&", typeof(String&), typeof(String&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Data.CustomTheme+<InitTheme>d__8", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater", Member = "get_RequiresUpdaterUpdate", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Updater+<HandleLauncherUpdate>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<TrySeamlessAuth>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "LoadPrefs", ReturnType = typeof(void))]
	[CalledBy(Type = "ClientAPI.WebServer+UserData", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.Player"}, ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 4)]
	public static string GetString(string key, string defaultValue) { }

	[CalledBy(Type = "Game.DuelManager+<OnReloadField>d__76", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static string GetString(string key) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<>c", Member = "<OnDeauth>b__125_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<OnClickConfirm>d__147", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "<OnResetButton>b__148_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Plugins.WindowsPermissionSetup", Member = "get_UpdaterTempFile", ReturnType = typeof(FileInfo))]
	[CalledBy(Type = "Manager.Helper+<Init>d__98", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper+<Start>d__108", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Helper", Member = "QuitGame", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod("Sync")]
	public static void Save() { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyGameplay", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplyCard", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Menu.SettingsMenu", Member = "ApplySocial", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.ChatWindow", Member = "StoreSize", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.General.Hologram", Member = "DefineScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.CameraController", Member = "SetCameraToSliders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "SetUpOptimizedView", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Battle.DuelZone", Member = "DragDisplayCardBorderEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Sound", Member = "SetVolume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.SoundTypes", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "StorePosition", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void SetFloat(string key, float value) { }

	[CallerCount(Count = 82)]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static void SetInt(string key, int value) { }

	[CalledBy(Type = "Scenes.Menu.SettingsMenu+<ApplyOthers>d__139", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnOperationCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnOperationSuccessful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "set_LastBrowsedFolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager", Member = "GetCurrentDefaultDeckName", ReturnType = typeof(string))]
	[CalledBy(Type = "Card.Manager", Member = "SetDefaultDeck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<DeleteAllDecks>d__68", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Manager+<RenameDeck>d__72", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Data.BinaryExtensions", Member = "SetSettingsPref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(string), typeof(string), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Data.CustomTheme+<DefineTheme>d__9", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Updater+<HandleLauncherUpdate>d__92", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Network+<>c", Member = "<StartAuth>b__33_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "SaveFilters", ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Deck", Member = "set_LastUsedDeckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(PlayerPrefsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlayerPrefs), Member = "TrySetSetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	public static void SetString(string key, string value) { }

	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("SetFloat")]
	private static bool TrySetFloat(string key, float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TrySetFloat_Injected(ref ManagedSpanWrapper key, float value) { }

	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("SetInt")]
	private static bool TrySetInt(string key, int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TrySetInt_Injected(ref ManagedSpanWrapper key, int value) { }

	[CalledBy(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("SetString")]
	private static bool TrySetSetString(string key, string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TrySetSetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper value) { }

}

