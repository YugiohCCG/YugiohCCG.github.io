namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : object
{
	public enum CreateOptions
	{
		None = 0,
		CreateNativeObject = 1,
	}

	private static class EncodingUtility
	{
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 11)]
		[CallsUnknownMethods(Count = 9)]
		private static EncodingUtility() { }

	}


	public Byte[] bytes
	{
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "HasValidAssetReference", ReturnType = typeof(bool))]
		[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "Spine.SkeletonData")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public string text
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 163
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextAsset), Member = "Internal_CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextAsset() { }

	[CalledBy(Type = "Game.CardAnimationPlayer+<GetTextAsset>d__27", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextAsset), Member = "Internal_CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public TextAsset(string text) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextAsset), Member = "Internal_CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal TextAsset(CreateOptions options, string text) { }

	[CalledBy(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextAsset), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static string DecodeString(Byte[] bytes) { }

	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeStreamableAsset", Member = "HasValidAssetReference", ReturnType = typeof(bool))]
	[CalledBy(Type = "Spine.Unity.SkeletonDataAsset", Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "Spine.SkeletonData")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Byte[] get_bytes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Byte[] get_bytes_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public string get_text() { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeVolumeBakingSet", Member = "LoadStreambleAssetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ProbeVolumeStreamableAsset", "System.Collections.Generic.List`1<Int32>"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextAsset), Member = "GetDataSize", ReturnType = typeof(long))]
	[Calls(Type = typeof(TextAsset), Member = "GetDataPtr", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "ConvertExistingDataToNativeArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int), typeof(Allocator)}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public NativeArray<T> GetData() { }

	[CalledBy(Type = typeof(TextAsset), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private IntPtr GetDataPtr() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetDataPtr_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(TextAsset), Member = "GetData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private long GetDataSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long GetDataSize_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = typeof(TextAsset), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextAsset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextAsset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateOptions), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Internal_CreateInstance_Injected(TextAsset self, ref ManagedSpanWrapper text) { }

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

