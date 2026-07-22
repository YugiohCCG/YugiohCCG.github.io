namespace System.Runtime.Serialization;

internal sealed class SerializationEvents
{
	private readonly List<MethodInfo> _onSerializingMethods; //Field offset: 0x10
	private readonly List<MethodInfo> _onSerializedMethods; //Field offset: 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; //Field offset: 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; //Field offset: 0x28

	internal bool HasOnSerializingEvents
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 19
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationEvents), Member = "GetMethodsWithAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal SerializationEvents(Type t) { }

	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RaiseOnDeserializedEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "AddOnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "AddOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "AddOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler)}, ReturnType = typeof(SerializationEventHandler))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "AddOnSerialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler)}, ReturnType = typeof(SerializationEventHandler))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDeserializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SerializationEvents), Member = "InvokeOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(StreamingContext), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasOnSerializingEvents() { }

	[CalledBy(Type = typeof(SerializationEvents), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.Serialization.SerializationEventsCache+<>c", Member = "<GetSerializationEventsForType>b__1_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	[CalledBy(Type = typeof(SafeSerializationManager), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

}

