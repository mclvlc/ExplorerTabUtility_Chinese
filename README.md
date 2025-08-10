# 个人AI汉化版 | Explorer Tab Utility 文件资源管理器标签工具

> [!TIP]
> 强制让Windows 11的新文件资源管理器窗口以标签页形式打开，让您的工作流程更清爽有序！

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ExplorerTabUtilityLogo.gif" alt="Explorer Tab Utility Logo">
  
  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
  [![Windows 11](https://img.shields.io/badge/Windows%2011-22H2+-blue.svg)](https://www.microsoft.com/windows/windows-11)
  [![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download)
  [![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-purple.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
</div>

> [!IMPORTANT]
> 本应用需要Windows 11 (22H2版本22621或更高) 并启用文件资源管理器标签页功能

## 🤔 为什么选择Explorer Tab Utility?

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TheWhy.png" alt="Why use Explorer Tab Utility">
</div>

告别杂乱无章的多个资源管理器窗口！本工具自动将新窗口转为标签页，提供更清爽高效的文件管理体验

## ✨ 功能亮点

<details>
<summary>🔄 自动窗口转标签页</summary>

- 无缝转换新窗口为标签页
- 路径已打开时自动切换到现有标签
- 支持虚拟桌面切换快捷键
- 支持标签页的附着/分离
- 优雅处理"在文件夹中显示"文件选择
- 支持批量打开多个标签页

**效果演示:**
![窗口转标签页](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/WindowToTab.gif)
</details>

<details>
<summary>🖨️ 复制当前标签页</summary>

- 快速复制当前标签/窗口
- 可选择复制为标签页或新窗口(切换`标签`选项)
- 保留当前位置和选中项

**效果演示:**
![复制标签页](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DuplicateTab.gif)
</details>

<details>
<summary>♻️ 重新打开关闭的标签</summary>

- 恢复最近关闭的标签/窗口
- 可选择恢复为标签页或新窗口(切换`标签`选项)
- 精确还原位置和选中项
- 历史记录跨应用重启保存(需在设置启用"保存关闭历史")

**效果演示:**
![重新打开标签](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ReopenClosedTab.gif)
</details>

<details>
<summary>🔄 恢复先前窗口</summary>

- 文件资源管理器重启/崩溃或系统重启后自动恢复窗口
- 通过"恢复先前窗口"设置配置
- 首次启动时显示确认对话框

![恢复窗口](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/RestorePrevious.png)
</details>

<details>
<summary>📋 分离与贴靠窗口</summary>

- 将当前标签分离为新窗口
- 将窗口贴靠屏幕边缘(左/右/上/下)
- 单快捷键串联多个操作
- 示例设置(CTRL + Q):
  1. 第一步：分离当前标签
  2. 第二步：原窗口贴靠左侧
  3. 第三步：新窗口贴靠右侧(可调延迟)
- 自定义延迟匹配系统性能

**效果演示:**
![分离贴靠](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DetachSnap.gif)
</details>

<details>
<summary>⬅️ 前进后退导航</summary>

- 通过以下方式在文件资源管理器导航：
  - 自定义快捷键
  - 点击文件夹空白处
- 快速切换目录的理想选择

**效果演示:**
![导航演示](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/NavigateBack.gif)
</details>

<details>
<summary>📁 自定义路径导航</summary>

- 为常用位置设置快捷键
- 可选择打开为标签页或新窗口(切换`标签`选项)
- 支持多种格式：
  - 标准路径：`C:\Users\Documents`
  - 环境变量：`%USERPROFILE%\Downloads`
  - Windows CLSID路径：`{A8CDFF1C-4878-43be-B5FD-F8091C1C60D0}`(特殊文件夹)
  - 程序和文件：`C:\file.txt`
  - 网址：`https://github.com/w4po/ExplorerTabUtility`(默认浏览器打开)
- 快速访问系统文件夹

**效果演示:**
![自定义路径](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/CustomLocation.gif)
</details>

<details>
<summary>🔍 标签搜索/切换器</summary>

- 快速查找切换已打开标签
- 输入部分文件夹名或路径搜索
- 方向键导航，Enter选择
- 特殊操作修饰键：
  - 默认：切换到现有标签或新标签打开
  - SHIFT键：在新窗口打开
  - CTRL键：强制复制标签
- 一键清除关闭历史

![标签搜索](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TabSearch.gif)
</details>

<details>
<summary>🪟 Ctrl+Shift强制新窗口</summary>

- 按住Ctrl+Shift打开位置时强制新窗口
- 临时覆盖窗口钩子和标签重用设置
- 需要独立窗口时的完美解决方案
</details>

<details>
<summary>⚡ 性能与可靠性</summary>

- 轻量级资源占用
- 快速响应的标签创建
- 基于COM的稳定实现
- 可靠的窗口状态管理
</details>

## 🚀 快速开始

1. 从[发布页](https://github.com/w4po/ExplorerTabUtility/releases)下载最新版，或通过包管理器安装：
    ```powershell
    winget install w4po.ExplorerTabUtility --interactive
    ```
    ```powershell
    choco install explorertabutility --version 2.5.0 --params "/interactive"
    ```
2. 运行应用程序
3. 查看系统托盘图标即可使用

    ![菜单](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Menu.png)

## ⚙️ 配置说明

> [!NOTE]
> 应用默认最小化到系统托盘
> 双击或右键点击托盘图标进行配置

<details>
<summary>🔧 常规设置</summary>

- **窗口钩子**：启用/禁用自动窗口转标签页
- **重用标签**：切换到现有标签而非重复打开
- **键盘钩子**：启用/禁用快捷键
- **鼠标钩子**：启用/禁用鼠标导航
- **开机启动**：配置随Windows启动
- **设置持久化**：
  * 设置存储在AppData目录的JSON文件中：
  * %APPDATA%\ExplorerTabUtility\settings.json
  * 如需重置，直接删除此文件即可
</details>

<details>
<summary>⚙️ 偏好设置</summary>

- **自动更新**：启动时检查更新
- **主题问题**：使用替代窗口隐藏方法(解决主题兼容问题)
- **保存关闭历史**：保存最近关闭窗口记录
- **恢复先前窗口**：重启后恢复之前窗口
- **隐藏托盘图标**：隐藏系统托盘图标
* 需先配置`ToggleVisibility`快捷键

![偏好设置](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Preferences.png)
</details>

<details>
<summary>⌨️ 快捷键配置管理</summary>

### 配置选项
- 新建配置
- 从文件导入
- 导出到文件
- 启用/禁用单个配置

### 配置设置
每个配置包含以下设置：

1. **基本配置**
 - 快捷键：设置组合键(支持修饰键)
 - 作用域：全局或仅文件资源管理器
 - 操作类型：
   - `打开`：打开指定位置
   - `复制`：复制当前标签
   - `重新打开`：恢复最后关闭的位置
   - `标签搜索`：打开搜索弹出框
   - `后退`：在当前标签后退
   - `前进`：在当前标签前进
   - `向上`：向上一级目录
   - `设为目标窗口`：标记当前窗口为新建标签目标
   - `切换窗口钩子`：启用/禁用窗口钩子
   - `切换标签重用`：启用/禁用标签重用
   - `切换可见性`：显示/隐藏主窗口
   - `分离标签`：将当前标签分离为新窗口
   - `贴靠`：将窗口贴靠屏幕边缘
 - 路径字段(用于`打开`操作)
   - 留空则打开新标签
   - 支持多种路径格式(见自定义路径导航)

2. **高级设置**
 - 执行延迟：设置延迟滑块
 - 按键处理：控制是否传递快捷键
 - 配置删除：移除不需要的配置

![表单](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Form.png)

> [!TIP]
> 使用"已处理"开关控制是否将快捷键传递给其他应用

> [!NOTE]
> `设为目标窗口`操作可指定新建标签的目标窗口，适用于多窗口或虚拟桌面场景
</details>

## 🔧 技术细节

<details>
<summary>实现概述</summary>

### 核心组件

#### 1. 🔌 COM集成
- 通过原生COM接口与Windows Shell交互：
- `Shell32`：核心Shell功能
- `SHDocVw`：资源管理器窗口管理
- 自定义COM接口实现
- 高效的PIDL处理
- 线程安全的COM对象管理

#### 2. 🪟 窗口管理
- 高级窗口跟踪：
- 线程安全的窗口追踪
- 智能标签页转换逻辑
- 特殊文件夹导航支持

#### 3. ⚡ 进程与事件系统
- 健壮的进程监控：
- 崩溃自动恢复
- 事件驱动架构
- 异步操作处理

#### 4. 🚀 性能优化
- 智能缓存机制：
- 窗口句柄缓存
- 路径比较优化
- 高效资源管理

#### 5. 🎨 现代UI
- WPF现代化界面：
- XAML组件
- Windows 11设计语言
- 增强的系统托盘集成

### 关键技术
- .NET 9和.NET Framework 4.8.1
- Windows COM API
- WPF界面框架
</details>

## 🗑️ 卸载指南

根据安装方式选择卸载方法：

- **安装程序版**：使用Windows标准卸载
- "设置 > 应用 > 已安装应用"
- 或控制面板卸载
- 或运行安装目录的卸载程序

- **winget安装**：
```powershell
winget uninstall w4po.ExplorerTabUtility
