namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class UIEventRegistration
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "TakeCapture", ReturnType = typeof(void))]
		internal void <.cctor>b__1_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "ReleaseCapture", ReturnType = typeof(void))]
		internal void <.cctor>b__1_1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(bool))]
		internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "CleanupRoots", ReturnType = typeof(void))]
		internal void <.cctor>b__1_3() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "EndContainerGUIFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
		internal bool <.cctor>b__1_4(Exception exception) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIEventRegistration), Member = "MakeCurrentIMGUIContainerDirty", ReturnType = typeof(void))]
		internal void <.cctor>b__1_5() { }

	}

	private static List<IUIElementsUtility> s_Utilities; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 23)]
	private static UIEventRegistration() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_3", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void CleanupRoots() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GUIUtility), Member = "ShouldRethrowException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static bool EndContainerGUIFromException(Exception exception) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_5", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal static void MakeCurrentIMGUIContainerDirty() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_1", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void ReleaseCapture() { }

	[CalledBy(Type = typeof(<>c), Member = "<.cctor>b__1_0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void TakeCapture() { }

}

