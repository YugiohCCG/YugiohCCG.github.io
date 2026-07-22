namespace System;

[NonVersionable]
public struct Nullable
{
	private readonly bool hasValue; //Field offset: 0x0
	internal T value; //Field offset: 0x0

	public bool HasValue
	{
		[CallerCount(Count = 89)]
		[DeduplicatedMethod]
		[NonVersionable]
		 get { } //Length: 4
	}

	public T Value
	{
		[CallerCount(Count = 39)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		 get { } //Length: 49
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[NonVersionable]
	public Nullable`1(T value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static object Box(Nullable<T> o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Collections.NativeArray`1", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 89)]
	[DeduplicatedMethod]
	[NonVersionable]
	public bool get_HasValue() { }

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public T get_Value() { }

	[CalledBy(Type = "UnityEngine.Rendering.RendererListParams", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = "Unity.Collections.NativeArray`1", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public T GetValueOrDefault() { }

	[CalledBy(Type = "UnityEngine.InputSystem.HID.HIDParser+HIDItemStateGlobal", Member = "GetPhysicalMin", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.HID.HIDParser+HIDItemStateGlobal", Member = "GetPhysicalMax", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputSystem.HID.HIDParser", Member = "ParseReportDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte*", typeof(int), "HIDDeviceDescriptor&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonObjectContract", Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "SetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.JsonConverter", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.JsonReader", typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CalculatePropertyDetails", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.JsonConverter&", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.JsonReader", typeof(object), typeof(Boolean&), typeof(Object&), "Newtonsoft.Json.Serialization.JsonContract&", typeof(Boolean&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "ShouldSetPropertyValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonObjectContract", typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Serialization.JsonObjectContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>", typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EndProcessProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "Newtonsoft.Json.JsonReader", "Newtonsoft.Json.Serialization.JsonObjectContract", typeof(int), "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonSerializerInternalReader+PropertyPresence", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "ShouldWriteProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), "Newtonsoft.Json.Serialization.JsonObjectContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "CheckForCircularReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContract", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "CalculatePropertyValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", typeof(object), "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContract&", typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.JsonWriter", "System.Dynamic.IDynamicMetaObjectProvider", "Newtonsoft.Json.Serialization.JsonDynamicContract", "Newtonsoft.Json.Serialization.JsonProperty", "Newtonsoft.Json.Serialization.JsonContainerContract", "Newtonsoft.Json.Serialization.JsonProperty"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	public T GetValueOrDefault(T defaultValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static Nullable<T> Unbox(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private static Nullable<T> UnboxExact(object o) { }

}

