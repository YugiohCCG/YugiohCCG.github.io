namespace UnityEngine;

internal class IMGUITextHandle : TextHandle
{
	public class TextHandleTuple
	{
		public float lastTimeUsed; //Field offset: 0x10
		public int hashCode; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public TextHandleTuple(float lastTimeUsed, int hashCode) { }

	}

	private static Dictionary<Int32, IMGUITextHandle> textHandles; //Field offset: 0x0
	private static LinkedList<TextHandleTuple> textHandlesTuple; //Field offset: 0x8
	private static float lastCleanupTime; //Field offset: 0x10
	private static int newHandlesSinceCleanup; //Field offset: 0x14
	internal LinkedListNode<TextHandleTuple> tuple; //Field offset: 0xB0
	internal bool isCachedOnNative; //Field offset: 0xB8

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static IMGUITextHandle() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	public IMGUITextHandle() { }

	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "RemoveTextInfoFromPermanentCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LinkedList`1), Member = "RemoveFirst", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static void ClearUnusedTextHandles() { }

	[CalledBy(Type = typeof(GUIStyle), Member = "get_lineHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(MeshInfoBindings[]&), typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetLineHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextSettings), Member = "GetCachedFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyStyleToNewStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontStyle)}, ReturnType = typeof(FontStyles))]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(GUIStyle), Member = "get_alignment", ReturnType = typeof(TextAnchor))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "LegacyAlignmentToNewAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAnchor)}, ReturnType = "UnityEngine.TextCore.Text.TextAlignment")]
	[CallsUnknownMethods(Count = 27)]
	[ContainsUnimplementedInstructions]
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void EmptyManagedCache() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings"}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static float GetLineHeight(GUIStyle style) { }

	[CallerCount(Count = 0)]
	internal Vector2 GetPreferredSize() { }

	[CalledBy(Type = typeof(GUIStyle), Member = "GetCursorPixelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetPreferredSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(Vector2&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "UpdateTextHandle", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "get_settings", ReturnType = "UnityEngine.TextCore.Text.TextGenerationSettings")]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", typeof(bool), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	[CalledBy(Type = typeof(GUIStyle), Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(MeshInfoBindings[]&), typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32)}, ReturnType = typeof(IMGUITextHandle))]
	[CalledBy(Type = typeof(IMGUITextHandle), Member = "GetTextHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Rect), typeof(string), typeof(Color32), typeof(Boolean&)}, ReturnType = typeof(IMGUITextHandle))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
	[Calls(Type = typeof(IMGUITextHandle), Member = "ClearUnusedTextHandles", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.TextInfo")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdatePreferredSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "AddLast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedList`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.LinkedListNode`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	[CallerCount(Count = 0)]
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

}

