namespace System.Runtime.Serialization;

[ComVisible(True)]
public class ObjectManager
{
	private DeserializationEventHandler m_onDeserializationHandler; //Field offset: 0x10
	private SerializationEventHandler m_onDeserializedHandler; //Field offset: 0x18
	internal ObjectHolder[] m_objects; //Field offset: 0x20
	internal object m_topObject; //Field offset: 0x28
	internal ObjectHolderList m_specialFixupObjects; //Field offset: 0x30
	internal long m_fixupCount; //Field offset: 0x38
	internal ISurrogateSelector m_selector; //Field offset: 0x40
	internal StreamingContext m_context; //Field offset: 0x48

	internal ObjectHolderList SpecialFixupObjects
	{
		[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 173
	}

	internal object TopObject
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HeaderHandler), typeof(__BinaryParser), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private void AddObjectHolder(ObjectHolder holder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 3)]
	internal override void AddOnDeserialization(DeserializationEventHandler handler) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsUnknownMethods(Count = 2)]
	internal override void AddOnDeserialized(object obj) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	private bool CanCallGetType(object obj) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(RuntimeConstructorInfo))]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "SerializationInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 31)]
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "UpdateValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectHolder), Member = "RemoveDependency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
	[Calls(Type = typeof(ObjectManager), Member = "FindObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 110)]
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
	[Calls(Type = typeof(ObjectHolderListEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 29)]
	public override void DoFixups() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "FindObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[Calls(Type = typeof(TypedReference), Member = "SetTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedReference), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectHolder FindObjectHolder(long objectID) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	private void FixupSpecialObject(ObjectHolder holder) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal ObjectHolderList get_SpecialFixupObjects() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal object get_TopObject() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
	[Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 31)]
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(RuntimeConstructorInfo))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override object GetObject(long objectID) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override void RaiseDeserializationEvent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal override void RaiseOnDeserializedEvent(object obj) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(SerializationEvents))]
	[Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationEventHandler), typeof(System.Collections.Generic.List`1<System.Reflection.MethodInfo>)}, ReturnType = typeof(SerializationEventHandler))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RaiseOnDeserializingEvent(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override void RecordArrayElementFixup(long arrayToBeFixed, Int32[] indices, long objectRequired) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public override void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsInvalidInstructions]
	public override void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "RecordDelayedFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(string), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RecordArrayElementFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Int32[]), typeof(long)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(ObjectHolder))]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ParseRecord), typeof(ParseRecord), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 41)]
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Int32[] arrayIndex) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "ParseString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseRecord), typeof(ParseRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ParseRecord), typeof(ParseRecord), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private bool ResolveObjectReference(ObjectHolder holder) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_TopObject(object value) { }

}

