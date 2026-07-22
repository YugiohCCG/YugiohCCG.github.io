namespace UnityEngine;

[NativeClass("TextRendering::Font")]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[StaticAccessor("TextRenderingPrivate", StaticAccessorType::DoubleColon (2))]
public sealed class Font : object
{
	internal sealed class FontTextureRebuildCallback : MulticastDelegate
	{

		[CallerCount(Count = 536)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public FontTextureRebuildCallback(object object, IntPtr method) { }

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Font> textureRebuilt; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; //Field offset: 0x18

	public static event Action<Font> textureRebuilt
	{
		[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 add { } //Length: 193
		[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		 remove { } //Length: 193
	}

	public bool dynamic
	{
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public int fontSize
	{
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public Material material
	{
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 get { } //Length: 294
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Font), Member = "Internal_CreateFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Font() { }

	[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void add_textureRebuilt(Action<Font> value) { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_dynamic() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_fontSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Material get_material() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ExcludeFromDocs]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = True)]
	public bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetCharacterInfo_Injected(IntPtr _unity_self, char ch, out CharacterInfo info, int size, FontStyle style) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), "UnityEngine.TextCore.LowLevel.GlyphRenderMode", typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "get_fallbackOSFontAssets", ReturnType = "System.Collections.Generic.List`1<FontAsset>")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "GetOSFontAssetList", ReturnType = "System.Collections.Generic.List`1<FontAsset>")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings", Member = "GetGlobalFallbacks", ReturnType = "System.IntPtr[]")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static String[] GetOSFallbacks() { }

	[CalledBy(Type = "TMPro.TMP_DynamicFontAssetUtilities", Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static String[] GetPathsToOSFonts() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool HasCharacter(int c) { }

	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool HasCharacter(char c) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	[CalledBy(Type = typeof(Font), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void Internal_CreateFont(Font self, string name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	[CalledBy(Type = "UnityEngine.UI.FontUpdateTracker", Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Text"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	public static void remove_textureRebuilt(Action<Font> value) { }

	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void RequestCharactersInTexture_Injected(IntPtr _unity_self, ref ManagedSpanWrapper characters, int size, FontStyle style) { }

}

