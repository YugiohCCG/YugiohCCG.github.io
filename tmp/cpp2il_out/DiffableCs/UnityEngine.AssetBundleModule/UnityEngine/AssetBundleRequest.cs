namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRequest : ResourceRequest
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static AssetBundleRequest ConvertToManaged(IntPtr ptr) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(AssetBundleRequest request) { }

	}


	public Object[] allAssets
	{
		[CalledBy(Type = "Manager.Helper+<GetAsset>d__76`1", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Game.CardAnimationPlayer+<LoadSkeleton>d__38", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetAllLoadedAssets")]
		 get { } //Length: 81
	}

	public object asset
	{
		[CallerCount(Count = 51)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private AssetBundleRequest(IntPtr ptr) { }

	[CalledBy(Type = "Manager.Helper+<GetAsset>d__76`1", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Game.CardAnimationPlayer+<LoadSkeleton>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetAllLoadedAssets")]
	public Object[] get_allAssets() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static Object[] get_allAssets_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public object get_asset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetLoadedAsset")]
	protected virtual object GetResult() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr GetResult_Injected(IntPtr _unity_self) { }

}

