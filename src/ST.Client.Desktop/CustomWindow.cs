namespace System.Application
{
    /// <summary>
    /// 业务自定义窗口
    /// </summary>
    public enum CustomWindow
    {
#if !__MOBILE__
        LoginOrRegister,
#endif
        MessageBox,
        AddAuth,
        ShowAuth,
        AuthTrade,
        EncryptionAuth,
        TextBox,
#if !__MOBILE__
        TaskBar,
#endif
        ExportAuth,
#if !__MOBILE__
        ScriptStore,
        HideApp,
        EditAppInfo,
        IdleApp,
        ShareManage,
        ChangeBindPhoneNumber,
        UserProfile,
        NewVersion,
        [Obsolete("disabled", true)]
        WebView3,
        BindPhoneNumber,
        ASF_AddBot,
        SteamShutdown,
        ProxySettings,
#endif
    }
}