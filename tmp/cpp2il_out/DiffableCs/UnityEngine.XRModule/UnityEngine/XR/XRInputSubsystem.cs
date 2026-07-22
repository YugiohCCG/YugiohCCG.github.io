namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeType(Header = "Modules/XR/Subsystems/Input/XRInputSubsystem.h")]
[UsedByNativeCode]
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> trackingOriginUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<XRInputSubsystem> boundaryChanged; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XRInputSubsystem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubsystemManager), Member = "GetIntegratedSubsystemByPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntegratedSubsystem))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubsystemManager), Member = "GetIntegratedSubsystemByPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(IntegratedSubsystem))]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode(GenerateProxy = True)]
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

}

