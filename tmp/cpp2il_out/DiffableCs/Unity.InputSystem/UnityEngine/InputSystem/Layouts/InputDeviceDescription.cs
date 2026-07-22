namespace UnityEngine.InputSystem.Layouts;

public struct InputDeviceDescription : IEquatable<InputDeviceDescription>
{
	private struct DeviceDescriptionJson
	{
		public string interface; //Field offset: 0x0
		public string type; //Field offset: 0x8
		public string product; //Field offset: 0x10
		public string serial; //Field offset: 0x18
		public string version; //Field offset: 0x20
		public string manufacturer; //Field offset: 0x28
		public string capabilities; //Field offset: 0x30

	}

	[SerializeField]
	private string m_InterfaceName; //Field offset: 0x0
	[SerializeField]
	private string m_DeviceClass; //Field offset: 0x8
	[SerializeField]
	private string m_Manufacturer; //Field offset: 0x10
	[SerializeField]
	private string m_Product; //Field offset: 0x18
	[SerializeField]
	private string m_Serial; //Field offset: 0x20
	[SerializeField]
	private string m_Version; //Field offset: 0x28
	[SerializeField]
	private string m_Capabilities; //Field offset: 0x30

	public string capabilities
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string deviceClass
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public bool empty
	{
		[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDevice))]
		[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		 get { } //Length: 122
	}

	public string interfaceName
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public string manufacturer
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string product
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string serial
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string version
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(InputManager), Member = "TryMatchDisconnectedDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDevice))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(JsonParser), Member = "NavigateToProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JsonParser), Member = "CurrentPropertyHasValueEqualTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JsonValue)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Substring), Member = "get_isEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonString propertyValue, string deviceDescriptor) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "InvariantEqualsIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public override bool Equals(InputDeviceDescription other) { }

	[CalledBy(Type = typeof(InputManager), Member = "OnNativeDeviceDiscovered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(JsonUtility), Member = "FromJson", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DeviceDescriptionJson)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DeviceDescriptionJson))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static InputDeviceDescription FromJson(string json) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_capabilities() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_deviceClass() { }

	[CalledBy(Type = typeof(InputSystem), Member = "AddDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription)}, ReturnType = typeof(InputDevice))]
	[CalledBy(Type = typeof(InputManager), Member = "RecreateDevicesUsingLayoutWithInferiorMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "OnUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputUpdateType), typeof(InputEventBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	public bool get_empty() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public string get_interfaceName() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_manufacturer() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_product() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_serial() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_version() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringHelpers), Member = "InvariantEqualsIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringHelpers), Member = "InvariantEqualsIgnoreCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_capabilities(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_deviceClass(string value) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_interfaceName(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_manufacturer(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_product(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_serial(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_version(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JsonUtility), Member = "ToJson", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 7)]
	public string ToJson() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

}

