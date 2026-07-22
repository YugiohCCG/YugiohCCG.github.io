namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static AssetBundleCreateRequest ConvertToManaged(IntPtr ptr) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(AssetBundleCreateRequest assetBundleCreateRequest) { }

	}


	public AssetBundle assetBundle
	{
		[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Utilities.Async.AwaiterExtensions+<AssetBundleCreateRequest>d__28", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("GetAssetBundleBlocking")]
		 get { } //Length: 132
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private AssetBundleCreateRequest(IntPtr ptr) { }

	[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Utilities.Async.AwaiterExtensions+<AssetBundleCreateRequest>d__28", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetAssetBundleBlocking")]
	public AssetBundle get_assetBundle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

}

