namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleManifest.h")]
public class AssetBundleManifest : object
{

	[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("GetAllAssetBundles")]
	public String[] GetAllAssetBundles() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static String[] GetAllAssetBundles_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "Manager.Updater+<LoadManifest>d__34", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[NativeMethod("GetAssetBundleHash")]
	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetAssetBundleHash_Injected(IntPtr _unity_self, ref ManagedSpanWrapper assetBundleName, out Hash128 ret) { }

}

