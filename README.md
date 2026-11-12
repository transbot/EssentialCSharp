# EssentialCSharp — C# 本质论

[![构建与测试](https://github.com/transbot/EssentialCSharp/actions/workflows/build-and-test.yml/badge.svg?branch=v12.0Chinese&event=push)](https://github.com/transbot/EssentialCSharp/actions/workflows/build-and-test.yml?query=branch%3Av12.0Chinese)

本仓库提供《C# 12.0 本质论》（第 8 版，清华大学出版社，2024 年）中文版的配套源代码。

代码及测试以中文版译稿和本仓库已修正的示例为准。中文版翻译过程中核对并修订了英文纸质版的部分疏漏，相关勘误和配套资源见[中文版主页](https://bookzhou.com)。

[EssentialCSharp.com](https://essentialcsharp.com) 提供英文在线资料，参阅时请留意版次和代码清单编号的差异。

![《C# 12.0 本质论》第 8 版封面](https://github.com/user-attachments/assets/bb84e67a-e659-4ab3-ba76-438ca110458a)

## 中文版购买链接

- [京东](https://item.jd.com/14279697.html)
- [当当](https://product.dangdang.com/29781408.html)

## 配套资源与试读

中英文版配套资源和试读 PDF 可从[中文版主页](https://bookzhou.com)获取，也可使用[百度网盘备用地址](https://pan.baidu.com/s/1yd43W)。

## 开发环境

- [.NET SDK](https://dotnet.microsoft.com/zh-cn/download)：使用 .NET 8 SDK 构建项目，SDK 选择规则见 `global.json`。项目保留 `net8.0`、`net7.0` 和 `net6.0` 三个目标框架；运行或测试某个目标框架时，需要安装对应的运行时。
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)：可使用支持 .NET 8 的 Visual Studio 2022；Visual Studio 2026 的本机构建与测试验证结果见下文。也可使用 .NET CLI 命令。
- [Git](https://git-scm.com/book/zh/v2)：可用于克隆仓库和获取更新；也可使用 Visual Studio 的 Git 功能。

### Visual Studio 2026 验证记录

2026 年 11 月 11 日，基于提交 [`49ff1c93`](https://github.com/transbot/EssentialCSharp/commit/49ff1c93eacc8982247af59619f61debea150740)，在 Windows x64、Debug、简体中文（zh-CN）环境中，使用 Visual Studio Professional 2026 18.12.0 自带的 MSBuild 18.12.2 和 VSTest 18.12.0 完成了完整重新构建与测试。SDK 按 `global.json` 实际选择为 .NET SDK 8.0.319。

46 个项目的三个目标框架全部构建成功，0 个错误。全部 69 个测试程序集共执行 1,936 次测试，全部通过，无失败或跳过，未缩减测试范围。

| 目标框架 | 测试程序集 | 通过测试次数 | 运行时探针结果 |
| --- | ---: | ---: | --- |
| `net8.0` | 23 | 650 | .NET 8.0.34 |
| `net7.0` | 23 | 646 | .NET 7.0.20 |
| `net6.0` | 23 | 640 | .NET 6.0.36 |

此次验证未发现构建或测试兼容性问题，结论限于上述环境和提交。构建仍有 139 条警告，涉及 .NET 6/7 生命周期、旧 API 及教材演示代码；未通过更改目标框架、跳过测试或隐藏警告来取得通过结果。

### 打开解决方案时项目显示“已卸载”

先右键单击一个项目，选择“重新加载项目”。若出现错误，请根据完整错误信息检查 SDK、运行时或工作负载。若项目可以正常加载，但重新打开解决方案后又恢复为卸载状态，可尝试重建本地解决方案状态：

1. 保存工作，并在所有 Visual Studio 实例中关闭该解决方案。
2. 备份并重命名对应的 `.suo` 文件：VS2022 为 `.vs/EssentialCSharp/v17/.suo`，VS2026 为 `.vs/EssentialCSharp/v18/.suo`。
3. 重新打开 `EssentialCSharp.sln`，检查项目加载状态。

`.suo` 保存个人解决方案设置，重建后可能需要重新选择启动项目等设置；保留备份以便恢复。本机已通过此方式恢复全部 46 个项目，并验证重新打开后仍保持加载。这类本地状态文件无需提交到 GitHub。

## 运行代码

### Visual Studio

1. 打开主解决方案 `EssentialCSharp.sln`。
2. 选择“生成 → 生成解决方案”。
3. 将要阅读的章节设为启动项目。例如，运行第 1 章时，右键单击 `Chapter01`，选择“设为启动项目”。
4. 选择 .NET 8 目标框架，按 F5 或选择“调试 → 开始调试”。
5. 按程序提示输入当前章节的代码清单编号，例如 `1.1`。运行其他章节时，请切换到对应的启动项目。

![运行代码清单示例](https://github.com/transbot/EssentialCSharp/assets/12107254/9b8891de-3df3-48d9-838e-1a36750e7102)

### .NET CLI

在仓库根目录（包含 `EssentialCSharp.sln` 的目录）还原并构建项目：

```bash
dotnet restore
dotnet build --no-restore
```

例如，从仓库根目录运行第 1 章：

```bash
dotnet run --project src/Chapter01/Chapter01.csproj --framework net8.0
```

项目包含多个目标框架，运行时需使用 `--framework` 指定其中一个。程序启动后，按提示输入当前章节的代码清单编号。也可以先进入章节目录，再执行 `dotnet run --framework net8.0`。

更多命令说明见 [.NET CLI 文档](https://learn.microsoft.com/zh-cn/dotnet/core/tools/)。

## 测试

测试断言按中文版译稿及本仓库的配套示例维护，覆盖 `net6.0`、`net7.0` 和 `net8.0` 三个目标框架。

CI 在 Windows、Linux 和 macOS 上执行构建与测试，并在 Linux 上分别执行“简体中文主验证”（zh-CN）和“法语跨区域检查”（fr-FR）。两组区域测试均运行全部现有测试及三个目标框架：简体中文组覆盖中文读者的典型环境，法语组验证数字、日期等区域格式差异。CI 会核对实际区域设置和目标运行时。

部分清单刻意演示编译错误或运行时异常；对应测试会核对编译诊断或预期异常。请保留这些教学示例的设计意图。

在 Visual Studio 中，可以通过“测试资源管理器”运行全部测试，也可以右键单击具体测试方法，选择“运行测试”或“调试测试”。详见 [Visual Studio 测试文档](https://learn.microsoft.com/visualstudio/test/run-unit-tests-with-test-explorer)。

从仓库根目录运行全部测试：

```bash
dotnet test
```

运行单章测试时，可指定测试项目，例如：

```bash
dotnet test src/Chapter01.Tests/Chapter01.Tests.csproj
```

## 阅读源代码

配套工程包含运行入口、测试和辅助代码，因此部分文件与书中的展示形式有所不同。阅读代码时，可通过以下标记识别书中展示的部分：

- `#region INCLUDE` 与 `#endregion INCLUDE` 之间是书中展示的代码。
- `#region EXCLUDE` 与 `#endregion EXCLUDE` 之间的内容在书中省略，通常以 `// ...` 表示。
- 行尾带有 `// EXCLUDE` 的代码在书中省略。

## 仓库维护

配套代码保持与已出版中文版一致。仓库整理和 CI 维护不改动教材代码、测试、依赖版本或目标框架；刻意演示错误的示例及对应测试继续保留。

依赖更新采用人工审查和合并策略，不自动合并。检查通过仅作为审查依据；涉及教材配套代码或行为的变更，需要另行确认。本仓库不启用英文版版本分支之间的自动同步。

## 问题反馈与修正

使用 [Issues](https://github.com/transbot/EssentialCSharp/issues) 报告问题或错误，通过 [Discussions](https://github.com/transbot/EssentialCSharp/discussions) 讨论用法，通过 [Pull requests](https://github.com/transbot/EssentialCSharp/pulls) 提交修正。反馈时请注明中文版版次、章节或代码清单编号，以及复现步骤。

资讯、下载与勘误请访问[中文版主页](https://bookzhou.com)。

祝编程愉快！
