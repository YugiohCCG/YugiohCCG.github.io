namespace System.Runtime.Serialization;

internal sealed class ObjectHolder
{
	private object m_object; //Field offset: 0x10
	internal long m_id; //Field offset: 0x18
	private int m_missingElementsRemaining; //Field offset: 0x20
	private int m_missingDecendents; //Field offset: 0x24
	internal SerializationInfo m_serInfo; //Field offset: 0x28
	internal ISerializationSurrogate m_surrogate; //Field offset: 0x30
	internal FixupHolderList m_missingElements; //Field offset: 0x38
	internal LongList m_dependentObjects; //Field offset: 0x40
	internal ObjectHolder m_next; //Field offset: 0x48
	internal int m_flags; //Field offset: 0x50
	private bool m_markForFixupWhenAvailable; //Field offset: 0x54
	private ValueTypeFixupInfo m_valueFixup; //Field offset: 0x58
	private TypeLoadExceptionHolder m_typeLoad; //Field offset: 0x60
	private bool m_reachable; //Field offset: 0x68

	internal bool CanObjectValueChange
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		internal get { } //Length: 25
	}

	internal bool CanSurrogatedObjectValueChange
	{
		[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectManager), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 133
	}

	internal bool CompletelyFixed
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 30
	}

	internal long ContainerID
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 19
	}

	internal LongList DependentObjects
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal int DirectlyDependentObjects
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool HasISerializable
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool HasSurrogate
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool IsIncompleteObjectReference
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
		[CallerCount(Count = 0)]
		internal set { } //Length: 25
	}

	internal object ObjectValue
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool Reachable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool RequiresDelayedFixup
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal bool RequiresSerInfoFixup
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 20
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal set { } //Length: 27
	}

	internal bool RequiresValueTypeFixup
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 8
	}

	internal SerializationInfo SerializationInfo
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal ISerializationSurrogate Surrogate
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int TotalDependentObjects
	{
		[CallerCount(Count = 283)]
		[DeduplicatedMethod]
		internal get { } //Length: 7
	}

	internal TypeLoadExceptionHolder TypeLoadException
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool TypeLoadExceptionReachable
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 9
	}

	internal ValueTypeFixupInfo ValueFixup
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal bool ValueTypeFixupPerformed
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 41
		[CallerCount(Count = 0)]
		internal set { } //Length: 12
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal ObjectHolder(long objID) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, Int32[] arrayIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void AddDependency(long dependentObject) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	internal bool get_CanObjectValueChange() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectHolder&), typeof(Object&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal bool get_CanSurrogatedObjectValueChange() { }

	[CallerCount(Count = 0)]
	internal bool get_CompletelyFixed() { }

	[CallerCount(Count = 0)]
	internal long get_ContainerID() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal LongList get_DependentObjects() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal int get_DirectlyDependentObjects() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_HasISerializable() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_HasSurrogate() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_IsIncompleteObjectReference() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal object get_ObjectValue() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_Reachable() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_RequiresDelayedFixup() { }

	[CallerCount(Count = 0)]
	internal bool get_RequiresSerInfoFixup() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_RequiresValueTypeFixup() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal SerializationInfo get_SerializationInfo() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal ISerializationSurrogate get_Surrogate() { }

	[CallerCount(Count = 283)]
	[DeduplicatedMethod]
	internal int get_TotalDependentObjects() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_TypeLoadExceptionReachable() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	internal ValueTypeFixupInfo get_ValueFixup() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal bool get_ValueTypeFixupPerformed() { }

	[CallerCount(Count = 0)]
	private void IncrementDescendentFixups(int amount) { }

	[CallerCount(Count = 0)]
	internal void MarkForCompletionWhenAvailable() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void RemoveDependency(long id) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DependentObjects(LongList value) { }

	[CallerCount(Count = 0)]
	internal void set_IsIncompleteObjectReference(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Reachable(bool value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal void set_RequiresSerInfoFixup(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_SerializationInfo(SerializationInfo value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	[CallerCount(Count = 0)]
	internal void set_ValueTypeFixupPerformed(bool value) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetFlags() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(FieldInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, Int32[] arrayIndex, ObjectManager manager) { }

	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(long), typeof(SerializationInfo), typeof(long), typeof(MemberInfo), typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "DecrementFixupsRemaining", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "AddFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FixupHolder), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(ISerializationSurrogate), typeof(long), typeof(FieldInfo), typeof(Int32[]), typeof(ObjectManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHolder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

}

