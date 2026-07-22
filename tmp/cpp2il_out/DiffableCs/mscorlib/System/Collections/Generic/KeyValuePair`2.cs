namespace System.Collections.Generic;

[IsReadOnly]
public struct KeyValuePair
{
	private readonly TKey key; //Field offset: 0x0
	private readonly TValue value; //Field offset: 0x0

	public TKey Key
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public TValue Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CalledBy(Type = typeof(Dictionary`2), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2+Enumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2+Enumerator", Member = "get_Current", ReturnType = "System.Collections.Generic.KeyValuePair`2<TKey, TValue>")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "FromDeviceDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Layouts.InputDeviceDescription"}, ReturnType = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "With", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InternedString", typeof(object), typeof(bool)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher", Member = "WithManufacturerContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputDeviceMatcher")]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dictionary`2), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "CopyToObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "CopyToPairs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.KeyValuePair`2<TKey, TValue>[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentDictionary`2+<GetEnumerator>d__35", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "RegisterTapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.Hotkeys", typeof(int), "Enumerator.HotkeyType", "System.Func`2<Boolean, Boolean>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public KeyValuePair`2(TKey key, TValue value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ReflectionProbeManager", Member = "UpdateGpuData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.CommandBuffer", "UnityEngine.Rendering.CullingResults&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Deconstruct(out TKey key, out TValue value) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public TKey get_Key() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TValue get_Value() { }

	[CalledBy(Type = "UnityEngine.EventSystems.TouchInputModule", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KeyValuePair), Member = "PairToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

