﻿namespace murrty.controls;

using System.Runtime.InteropServices;

internal static class Shared {

    /// <summary>
    /// The WndProc message for setting the systems' cursor.
    /// </summary>
    internal const int WM_SETCURSOR = 0x0020;
    /// <summary>
    /// The user32.h resource identifier for the systems' hand cursor.
    /// </summary>
    internal const int IDC_HAND = 32649;
    /// <summary>
    /// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window.
    /// The message is sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application obtains a WM_PAINT message by using the GetMessage or PeekMessage function.
    /// </summary>
    internal const int WM_PAINT = 0xF;

    /// <summary>
    /// Sends the specified message to a window or windows. The SendMessage function calls the window procedure for the specified window and does not return until the window procedure has processed the message.
    /// <para>To send a message and return immediately, use the SendMessageCallback or SendNotifyMessage function.To post a message to a thread's message queue and return immediately, use the PostMessage or PostThreadMessage function.</para>
    /// </summary>
    /// <param name="hWnd">A handle to the window whose window procedure will receive the message. If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.</param>
    /// <param name="wMsg">The message to be sent.</param>
    /// <param name="wParam">Additional message-specific information.</param>
    /// <param name="lParam">Additional message-specific information.</param>
    /// <returns>The return value specifies the result of the message processing; it depends on the message sent.</returns>
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern int SendMessage(
        [In] IntPtr hWnd,
        [In] uint wMsg,
        [In] IntPtr wParam,
        [In] IntPtr lParam);

    /// <summary>
    /// The IntPtr value of IDC_HAND.
    /// </summary>
    internal static readonly IntPtr SystemHand =
        LoadCursor(IntPtr.Zero, (IntPtr)IDC_HAND);

    /// <summary>
    /// Loads the specified cursor resource from the executable (.EXE) file associated with an application instance.
    /// This function has been superseded by the LoadImage function.
    /// </summary>
    /// <param name="hInstance">A handle to an instance of the module whose executable file contains the cursor to be loaded.</param>
    /// <param name="lpCursorName">The name of the cursor resource to be loaded. Alternatively, this parameter can consist of the resource identifier in the low-order word and zero in the high-order word. The MAKEINTRESOURCE macro can also be used to create this value. To use one of the predefined cursors, the application must set the hInstance parameter to NULL and the lpCursorName parameter to a valid value.</param>
    /// <returns>If the function succeeds, the return value is the handle to the newly loaded cursor. If the function fails, the return value is NULL.</returns>
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern IntPtr LoadCursor(
        [In, Optional] IntPtr hInstance,
        [In] IntPtr lpCursorName);

    /// <summary>
    /// Sets the cursor shape.
    /// </summary>
    /// <param name="hCursor">A handle to the cursor. The cursor must have been created by the CreateCursor function or loaded by the LoadCursor or LoadImage function. If this parameter is NULL, the cursor is removed from the screen.</param>
    /// <returns>The return value is the handle to the previous cursor, if there was one. If there was no previous cursor, the return value is NULL.</returns>
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    internal static extern IntPtr SetCursor(
       [In, Optional] IntPtr hCursor);

}