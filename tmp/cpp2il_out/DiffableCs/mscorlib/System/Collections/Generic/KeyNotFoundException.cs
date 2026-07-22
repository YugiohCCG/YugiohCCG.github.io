namespace System.Collections.Generic;

public class KeyNotFoundException : SystemException
{

	[CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "Newtonsoft.Json.Linq.JToken")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public KeyNotFoundException() { }

	[CalledBy(Type = typeof(ThrowHelper), Member = "GetKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(KeyNotFoundException))]
	[CalledBy(Type = typeof(ConcurrentDictionary`2), Member = "ThrowKeyNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyedCollection`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TItem")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionAsset", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputAction")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputActionMap", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputAction")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputControl", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.InputControl")]
	[CalledBy(Type = "UnityEngine.InputSystem.Layouts.InputControlLayout", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.InputSystem.Layouts.InputControlLayout+ControlItem")]
	[CalledBy(Type = "System.Collections.Generic.SortedDictionary`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "System.Linq.Expressions.Error", Member = "KeyDoesNotExistInExpando", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.HybridReferenceDictionary`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public KeyNotFoundException(string message) { }

	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected KeyNotFoundException(SerializationInfo info, StreamingContext context) { }

}

