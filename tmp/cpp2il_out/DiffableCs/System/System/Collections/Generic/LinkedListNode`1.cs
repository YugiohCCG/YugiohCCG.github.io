namespace System.Collections.Generic;

public sealed class LinkedListNode
{
	internal LinkedList<T> list; //Field offset: 0x0
	internal LinkedListNode<T> next; //Field offset: 0x0
	internal LinkedListNode<T> prev; //Field offset: 0x0
	internal T item; //Field offset: 0x0

	public LinkedListNode<T> Next
	{
		[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction", Member = "Call", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`1", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.FastAction`3", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 51
	}

	public T Value
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public LinkedListNode`1(T value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal LinkedListNode`1(LinkedList<T> list, T value) { }

	[CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "GetNextOperation", ReturnType = typeof(WebOperation))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "SchedulerIteration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebOperation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServicePointScheduler), Member = "RemoveIdleConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebConnection)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction", Member = "Call", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`1", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.FastAction`3", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B", "C"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FastAction`2", Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public LinkedListNode<T> get_Next() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal void Invalidate() { }

}

