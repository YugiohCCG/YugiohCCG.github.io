namespace System;

public class NullReferenceException : SystemException
{

	[CalledBy(Type = typeof(Enum), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(Assembly), Member = "LoadWithPartialName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeAssembly))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName), typeof(Evidence), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeAssembly))]
	[CalledBy(Type = "UnityEngine.Camera", Member = "GetAllCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NullCheckInstruction", Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionNoT+Value", Member = "ConvertNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Interpreter.InterpretedFrame"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NullReferenceException() { }

	[CalledBy(Type = "UnityEngine.UIElements.TabView", Member = "set_activeTab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Tab"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.AssetBundle", Member = "LoadAssetWithSubAssetsAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = "UnityEngine.AssetBundleRequest")]
	[CalledBy(Type = "UnityEngine.AssetBundle", Member = "LoadAssetAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = "UnityEngine.AssetBundleRequest")]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetCheckedDownloader", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Networking.UnityWebRequest"}, ReturnType = "T")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1", Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Hierarchy.HierarchyNode&"}, ReturnType = "T")]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyPropertyUnmanaged`1", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Hierarchy.HierarchyNode&", "T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Spine.Unity.AttachmentTools.AtlasUtilities", Member = "GetRepackedSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Spine.Skin", typeof(string), "UnityEngine.Shader", "UnityEngine.Material&", "UnityEngine.Texture2D&", typeof(int), typeof(int), "UnityEngine.TextureFormat", typeof(bool), "UnityEngine.Material", typeof(bool), typeof(bool), "System.Int32[]", "UnityEngine.Texture2D[]", "UnityEngine.TextureFormat[]", "System.Boolean[]"}, ReturnType = "Spine.Skin")]
	[CalledBy(Type = "Unity.Burst.FunctionPointer`1", Member = "CheckIsCreated", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.GraphicsFence", Member = "InitPostAllocation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Coroutine"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine_Auto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StartCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.Coroutine")]
	[CalledBy(Type = "Unity.IO.LowLevel.Unsafe.AsyncReadManager", Member = "GetFileInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "Unity.IO.LowLevel.Unsafe.FileInfoResult*"}, ReturnType = "Unity.IO.LowLevel.Unsafe.ReadHandle")]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRSystem", Member = "CreateDefaultLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera", "UnityEngine.Experimental.Rendering.XRLayout"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.SocketAsyncEventArgs"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.MonoBehaviour", Member = "StopCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerator)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public NullReferenceException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected NullReferenceException(SerializationInfo info, StreamingContext context) { }

}

