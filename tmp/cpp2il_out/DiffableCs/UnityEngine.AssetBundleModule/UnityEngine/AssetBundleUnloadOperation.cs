namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public static AssetBundleUnloadOperation ConvertToManaged(IntPtr ptr) { }

	}


	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private AssetBundleUnloadOperation(IntPtr ptr) { }

}

