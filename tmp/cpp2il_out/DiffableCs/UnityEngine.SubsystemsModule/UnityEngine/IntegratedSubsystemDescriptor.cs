namespace UnityEngine;

[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10

	public override string id
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubsystemDescriptorBindings), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
		 get { } //Length: 11
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IntegratedSubsystemDescriptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubsystemDescriptorBindings), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	public override string get_id() { }

}

