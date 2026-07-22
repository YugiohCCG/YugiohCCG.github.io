namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextLib.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextLib
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(TextLib textLib) { }

	}

	public static Func<TextAsset> GetICUAssetEditorDelegate; //Field offset: 0x0
	private readonly IntPtr m_Ptr; //Field offset: 0x10

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public TextLib(Byte[] icuData) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ATGFindIntersectingLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = "System.ValueTuple`2<TagType, String>")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextLib::FindIntersectingLink")]
	public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int FindIntersectingLink_Injected(in Vector2 point, IntPtr textGenerationInfo) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextLib::GenerateTextMesh", IsThreadSafe = True)]
	private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GenerateTextInternal_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out NativeTextInfo ret) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetInstance(Byte[] icuData) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextLib::MeasureText")]
	public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void MeasureText_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out Vector2 ret) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontAsset), Member = "GetFontAssetByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "get_atlasHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "get_atlasIndex", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings) { }

}

