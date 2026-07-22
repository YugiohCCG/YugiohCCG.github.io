namespace UnityEngine.InputSystem.XR;

public class XRDeviceDescriptor
{
	public string deviceName; //Field offset: 0x10
	public string manufacturer; //Field offset: 0x18
	public string serialNumber; //Field offset: 0x20
	public InputDeviceCharacteristics characteristics; //Field offset: 0x28
	public int deviceId; //Field offset: 0x2C
	public List<XRFeatureDescriptor> inputFeatures; //Field offset: 0x30

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XRDeviceDescriptor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	public static XRDeviceDescriptor FromJson(string json) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	public string ToJson() { }

}

