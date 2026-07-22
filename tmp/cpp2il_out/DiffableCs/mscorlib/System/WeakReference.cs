namespace System;

[ComVisible(True)]
public class WeakReference : ISerializable
{
	private bool isLongReference; //Field offset: 0x10
	private GCHandle gcHandle; //Field offset: 0x18

	public override bool IsAlive
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 31
	}

	public override object Target
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 53
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 92
	}

	public override bool TrackResurrection
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected WeakReference() { }

	[CalledBy(Type = typeof(ClientIdentity), Member = "set_ClientProxy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "EnsureNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WeakReference&), typeof(string)}, ReturnType = "System.Xml.Linq.XNamespace")]
	[CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = "System.Xml.Linq.XNamespace")]
	[CalledBy(Type = "System.Dynamic.ExpandoClass", Member = "FindNewClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Dynamic.ExpandoClass")]
	[CalledBy(Type = "System.Data.Index", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", "System.Data.IndexField[]", "System.Comparison`1<DataRow>", "System.Data.DataViewRowState", "System.Data.IFilter"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataViewListener", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataView"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.DataView", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.DynamicResolutionHandler", Member = "GetOrCreateDrsInstanceHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Camera"}, ReturnType = "UnityEngine.Rendering.DynamicResolutionHandler")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "CreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Net.TimerThread+Queue")]
	[CalledBy(Type = "System.Net.TimerThread", Member = "GetOrCreateQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Net.TimerThread+Queue")]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "set_Credentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.NetworkCredential"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.Process"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = "System.Diagnostics.Process")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "Start", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "get_StartInfo", ReturnType = "System.Diagnostics.ProcessStartInfo")]
	[CalledBy(Type = "System.Diagnostics.Switch", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlDocument", Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "BuildCommandsList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebRequest"}, ReturnType = "PipelineEntry[]")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WeakReference(object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	public WeakReference(object target, bool trackResurrection) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	protected WeakReference(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(GCHandleType)}, ReturnType = typeof(GCHandle))]
	[ContainsUnimplementedInstructions]
	private void AllocateHandle(object target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool get_IsAlive() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object get_Target() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_TrackResurrection() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTargetHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr), typeof(GCHandleType)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override void set_Target(object value) { }

}

