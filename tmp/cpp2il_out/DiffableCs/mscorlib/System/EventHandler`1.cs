namespace System;

public sealed class EventHandler : MulticastDelegate
{

	[CalledBy(Type = "UnityEngine.UIElements.DataBindingManager+HierarchyDataSourceTracker", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DataBindingManager"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Columns", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Column"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.Columns", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.Column"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnListView", Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Columns"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnTreeView", Member = "set_columns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Columns"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public EventHandler`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void Invoke(object sender, TEventArgs e) { }

}

