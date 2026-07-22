namespace UnityEngine.InputSystem.XR;

[InputControlLayout(commonUsages = new IL2CPP_TYPE_STRING[] {"LeftHand", "RightHand"}, isGenericTypeOfDevice = True, displayName = "XR Controller")]
public class XRController : TrackedDevice
{

	public static XRController leftHand
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
		 get { } //Length: 160
	}

	public static XRController rightHand
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
		 get { } //Length: 160
	}

	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XRController() { }

	[CalledBy(Type = typeof(OpenVRControllerWMR), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ViveWand), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OpenVROculusTouchController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OculusTouchController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GearVRTrackedController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DaydreamController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HololensHand), Member = "FinishSetup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WMRSpatialController), Member = "FinishSetup", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TrackedDevice), Member = "FinishSetup", ReturnType = typeof(void))]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InputSystem), Member = "SetDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	protected virtual void FinishSetup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	public static XRController get_leftHand() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	public static XRController get_rightHand() { }

}

