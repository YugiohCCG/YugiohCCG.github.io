namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextSelectionService.h")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextSelectionService
{

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetCharacterHeightFromIndex")]
	internal static float GetCharacterHeightFromIndex(IntPtr textGenerationInfo, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetCursorLogicalIndexFromPosition")]
	internal static int GetCursorLogicalIndexFromPosition(IntPtr textGenerationInfo, Vector2 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetCursorLogicalIndexFromPosition_Injected(IntPtr textGenerationInfo, in Vector2 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetCursorPositionFromLogicalIndex")]
	internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetEndOfPreviousWord")]
	internal static int GetEndOfPreviousWord(IntPtr textGenerationInfo, int currentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetFirstCharacterIndexOnLine")]
	internal static int GetFirstCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[CalledBy(Type = typeof(TextHandle), Member = "GetHighlightRectangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Rect[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[NativeMethod(Name = "TextSelectionService::GetHighlightRectangles")]
	internal static Rect[] GetHighlightRectangles(IntPtr textGenerationInfo, int cursorIndex, int selectIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetHighlightRectangles_Injected(IntPtr textGenerationInfo, int cursorIndex, int selectIndex, out BlittableArrayWrapper ret) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetLastCharacterIndexOnLine")]
	internal static int GetLastCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetLineHeight")]
	internal static float GetLineHeight(IntPtr textGenerationInfo, int lineIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetLineNumberFromLogicalIndex")]
	internal static int GetLineNumber(IntPtr textGenerationInfo, int logicalIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::GetStartOfNextWord")]
	internal static int GetStartOfNextWord(IntPtr textGenerationInfo, int currentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::LineDownCharacterPosition")]
	internal static int LineDownCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::LineUpCharacterPosition")]
	internal static int LineUpCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::NextCodePointIndex")]
	internal static int NextCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::PreviousCodePointIndex")]
	internal static int PreviousCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentParagraph")]
	internal static void SelectCurrentParagraph(IntPtr textGenerationInfo, ref int cursorIndex, ref int selectIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectCurrentWord")]
	internal static void SelectCurrentWord(IntPtr textGenerationInfo, int currentIndex, ref int startIndex, ref int endIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectToEndOfParagraph")]
	internal static void SelectToEndOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectToNextParagraph")]
	internal static void SelectToNextParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectToPreviousParagraph")]
	internal static void SelectToPreviousParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextSelectionService::SelectToStartOfParagraph")]
	internal static void SelectToStartOfParagraph(IntPtr textGenerationInfo, ref int cursorIndex) { }

	[CalledBy(Type = typeof(TextHandle), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextSelectionService::Substring")]
	internal static string Substring(IntPtr textGenerationInfo, int startIndex, int endIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Substring_Injected(IntPtr textGenerationInfo, int startIndex, int endIndex, out ManagedSpanWrapper ret) { }

}

