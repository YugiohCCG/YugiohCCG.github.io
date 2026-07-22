namespace Spine.Unity;

public class SpineAttachment : SpineAttributeBase
{
	internal struct Hierarchy
	{
		public string skin; //Field offset: 0x0
		public string slot; //Field offset: 0x8
		public string name; //Field offset: 0x10

		[CalledBy(Type = typeof(SpineAttachment), Member = "GetHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hierarchy))]
		[CalledBy(Type = typeof(SpineAttachment), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonData)}, ReturnType = typeof(Attachment))]
		[CalledBy(Type = typeof(SpineAttachment), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(SkeletonDataAsset)}, ReturnType = typeof(Attachment))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		public Hierarchy(string fullPath) { }

	}

	public bool returnAttachmentPath; //Field offset: 0x30
	public bool currentSkinOnly; //Field offset: 0x31
	public bool placeholdersOnly; //Field offset: 0x32
	public string skinField; //Field offset: 0x38
	public string slotField; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "", string skinField = "", bool includeNone = true, bool fallbackToTextField = false) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SlotData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[CallsUnknownMethods(Count = 1)]
	public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SkeletonDataAsset), Member = "GetSkeletonData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(SkeletonData))]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SlotData))]
	[Calls(Type = typeof(SkeletonData), Member = "FindSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Skin))]
	[Calls(Type = typeof(Skin), Member = "GetAttachment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(Attachment))]
	[CallsUnknownMethods(Count = 1)]
	public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hierarchy), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	public static Hierarchy GetHierarchy(string fullPath) { }

}

