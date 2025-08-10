namespace ExplorerTabUtility.Helpers;

internal static class Constants
{
    internal const string AppName = "ExplorerTabUtility";
    internal const string MutexId = $"__{AppName}Hook__Mutex";
    internal const string NotifyIconText = "资源管理器标签页工具：强制将新窗口转为标签页。";
    internal const string SettingsFileName = "settings.json";
    internal const string HotKeyProfilesFileName = "HotKeyProfiles.json";
    internal const string JsonFileFilter = "JSON 文件 (*.json)|*.json|所有文件|*.*";
    internal const string UpdateUrl = "https://api.github.com/repos/w4po/ExplorerTabUtility/releases/latest";
    internal const string DefaultHotKeyProfiles = "[{\"Name\":\"主页\",\"HotKeys\":[91,69],\"Scope\":0,\"Action\":0,\"Path\":\"\",\"IsHandled\":true,\"IsEnabled\":true,\"Delay\":0},{\"Name\":\"复制标签页\",\"HotKeys\":[17,68],\"Scope\":1,\"Action\":1,\"Path\":null,\"IsHandled\":true,\"IsEnabled\":true,\"Delay\":0},{\"Name\":\"重新打开关闭的标签页\",\"HotKeys\":[16,17,84],\"Scope\":1,\"Action\":2,\"Path\":null,\"IsHandled\":true,\"IsEnabled\":true,\"Delay\":0}]";
}