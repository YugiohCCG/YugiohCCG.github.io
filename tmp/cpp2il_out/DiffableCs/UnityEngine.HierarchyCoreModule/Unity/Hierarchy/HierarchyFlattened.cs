namespace Unity.Hierarchy;

[DefaultMember("Item")]
[NativeHeader("Modules/HierarchyCore/HierarchyFlattenedBindings.h")]
[NativeHeader("Modules/HierarchyCore/Public/HierarchyFlattened.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public sealed class HierarchyFlattened : IDisposable
{
	public static class BindingsMarshaller
	{

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public static IntPtr ConvertToNative(HierarchyFlattened hierarchyFlattened) { }

	}

	internal struct Enumerator
	{
		private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
		private readonly HierarchyFlattenedNode* m_NodesPtr; //Field offset: 0x8
		private readonly int m_NodesCount; //Field offset: 0x10
		private readonly int m_Version; //Field offset: 0x14
		private int m_Index; //Field offset: 0x18

		[IsReadOnly]
		public HierarchyFlattenedNode Current
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 5)]
			 get { } //Length: 125
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal Enumerator(HierarchyFlattened hierarchyFlattened) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		public HierarchyFlattenedNode get_Current() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		public bool MoveNext() { }

	}

	private IntPtr m_Ptr; //Field offset: 0x10
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	private IntPtr m_NodesPtr; //Field offset: 0x20
	private int m_NodesCount; //Field offset: 0x28
	private int m_Version; //Field offset: 0x2C
	private readonly bool m_IsOwner; //Field offset: 0x30

	public int Count
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Hierarchy Hierarchy
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool IsCreated
	{
		[CallerCount(Count = 7)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 9
	}

	[IsReadOnly]
	public HierarchyFlattenedNode Item
	{
		[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = "get_Current", ReturnType = typeof(object))]
		[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
		[CalledBy(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 114
	}

	internal HierarchyFlattenedNode* NodesPtr
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal get { } //Length: 11
	}

	public bool UpdateNeeded
	{
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
		 get { } //Length: 81
	}

	internal int Version
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "set_hierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hierarchy)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public HierarchyFlattened(Hierarchy hierarchy) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private HierarchyFlattened(IntPtr nativePtr, Hierarchy hierarchy, IntPtr nodesPtr, int nodesCount, int version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	public bool Contains(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool Contains_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HierarchyFlattenedBindings::Create", IsThreadSafe = True)]
	private static IntPtr Create(IntPtr handlePtr, Hierarchy hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr Create_Injected(IntPtr handlePtr, IntPtr hierarchy, out IntPtr nodesPtr, out int nodesCount, out int version) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static IntPtr CreateHierarchyFlattened(IntPtr nativePtr, IntPtr hierarchyPtr, IntPtr nodesPtr, int nodesCount, int version) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("HierarchyFlattenedBindings::Destroy", IsThreadSafe = True)]
	private static void Destroy(IntPtr nativePtr) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Dispose(bool disposing) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "DisposeHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(HierarchyFlattenedNodeChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyFlattened), typeof(HierarchyNode&)}, ReturnType = typeof(void))]
	public HierarchyFlattenedNodeChildren EnumerateChildren(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected virtual void Finalize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	internal static HierarchyFlattened FromIntPtr(IntPtr handlePtr) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_Count() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Hierarchy get_Hierarchy() { }

	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsCreated() { }

	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList+Enumerator", Member = "get_Current", ReturnType = typeof(object))]
	[CalledBy(Type = "UnityEngine.UIElements.ReadOnlyHierarchyViewModelList", Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(HierarchyNode&))]
	[CalledBy(Type = typeof(HierarchyViewModel), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(HierarchyNode&))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public HierarchyFlattenedNode get_Item(int index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal HierarchyFlattenedNode* get_NodesPtr() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod("UpdateNeeded", IsThreadSafe = True)]
	public bool get_UpdateNeeded() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_UpdateNeeded_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_Version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	public int GetChildrenCount(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController+<GetAllItemIds>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Enumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	public int IndexOf(in HierarchyNode node) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int IndexOf_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateSortOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HierarchyNode&), typeof(HierarchyNode&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "OnViewDataReadyUpdateNodes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = "UpdateHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(IsThreadSafe = True)]
	public void Update() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Update_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[RequiredByNativeCode]
	private static void UpdateHierarchyFlattened(IntPtr handlePtr, IntPtr nodesPtr, int nodesCount, int version) { }

}

