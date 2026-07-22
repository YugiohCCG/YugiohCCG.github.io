namespace System;

public sealed class Comparison : MulticastDelegate
{

	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnController", Member = "SortIfNeeded", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseReorderableDragAndDropController", Member = "SetupDragAndDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<Int32>", typeof(bool)}, ReturnType = "UnityEngine.UIElements.StartDragArgs")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleComplexSelector", Member = "CalculateHashes", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal", Member = "ProcessMatchedRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "System.Collections.Generic.List`1<SelectorMatchRecord>"}, ReturnType = "UnityEngine.UIElements.ComputedStyle")]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "SortedRaycastGraphics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", "UnityEngine.Ray", "System.Collections.Generic.List`1<RaycastHitData>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventTrace+ReplayController", Member = "PlayAllEventsAccordingToTimestamps", ReturnType = "UnityEngine.InputSystem.LowLevel.InputEventTrace+ReplayController")]
	[CalledBy(Type = "UnityEngine.Rendering.PowerOfTwoTextureAtlas", Member = "RelayoutEntries", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalEntityManager", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshFiles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider", Member = "Subscribe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventConsumer", typeof(int), "System.Nullable`1<Int32>", "Type[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public Comparison`1(object object, IntPtr method) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override int Invoke(T x, T y) { }

}

