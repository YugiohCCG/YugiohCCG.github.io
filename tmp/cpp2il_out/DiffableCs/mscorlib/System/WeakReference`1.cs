namespace System;

public sealed class WeakReference : ISerializable
{
	private GCHandle handle; //Field offset: 0x0
	private bool trackResurrection; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.LayoutHandle", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Security.SslStream", "Mono.Net.Security.MobileTlsProvider", "Mono.Security.Interface.MonoTlsSettings", typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Text.RegularExpressions.RegexOptions", typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Text.RegularExpressions.Regex", Member = "InitializeReferences", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Pool.PoolManager", Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Pool.IPool"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public WeakReference`1(T target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public WeakReference`1(T target, bool trackResurrection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private WeakReference`1(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.WeakReference`1<RegexReplacement>", typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), "System.Text.RegularExpressions.RegexOptions"}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetTarget(T target) { }

	[CalledBy(Type = "UnityEngine.UIElements.Layout.LayoutManager", Member = "GetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Layout.LayoutHandle"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), "System.Security.Cryptography.X509Certificates.X509Chain", "System.Net.Security.SslPolicyErrors"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexReplacement", Member = "GetOrCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.WeakReference`1<RegexReplacement>", typeof(string), typeof(Hashtable), typeof(int), typeof(Hashtable), "System.Text.RegularExpressions.RegexOptions"}, ReturnType = "System.Text.RegularExpressions.RegexReplacement")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.FontAsset"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool TryGetTarget(out T target) { }

}

