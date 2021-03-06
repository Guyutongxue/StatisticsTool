# StatisticsTool 统计工具

## 简介

本工具用于快速进行单项列表的标记统计。在处理作业、回执等名单时及其有效，相比传统纸笔记录方式效率提高至少3倍以上。

## 使用方法

在Visual Studio中打开项目，然后生成运行。文件在 `bin\Debug` 下。

### 数据读取

本工具需要两个文本文件： `list.txt` 和 `index.txt` 。

`list.txt` 需要记录元素名称列表；在实际应用中记录人名。每一行一个元素，结尾没有多余的空行或空格。

`index.txt` 需要记录元素的别称或简写；在实际应用中记录人名简写。每一行一个元素别称，与 `list.txt` 每一项一一对应。结尾同样没有多余的空行或空格。

本工具会自动读取当前目录下的 `list.txt` 和 `index.txt` 。当然也可以通过点击Read按钮读取其它位置的文件。

### 开始统计

载入列表后，直接在 Input 文本框输入**元素别称**即可实现该项的标记。项目列表和标记将会同步在左侧的列表框中。

同样可以在列表框中选择对应的元素，并点击 Select 或 Unselect 按钮实现标记或取消标记。

### 查看结果

点击 Show Selected 按钮查看已经标记的元素。点击 Show Unselected 按钮查看未被标记的元素。

同时结果会在模拟命令行中输出，可以复制。

### 模拟命令行

工具中有一个愚蠢的模拟命令行，可以实现大部分图形界面的功能。

用法: command [options]

Command:

- `add [name1] [name2] ... `
	- 输入**别称**来标记
- `del [name1] [name2] ... `
	- 输入**别称**来取消标记
- `show [-u] `
	- 查看已标记的结果。 `-u` 选项表示查看未标记的结果。
- `help `
	- 显示帮助

