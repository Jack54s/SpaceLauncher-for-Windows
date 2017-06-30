# SpaceLauncher for Windows

**Space + Keys(A-Z,0-9,,./;'[]]\\-=)打开程序**

程序下载地址：[SpaceLauncher](https://github.com/Jack54s/SpaceLauncher-for-Windows/blob/master/SpaceLauncher/bin/Release/app.publish/SpaceLauncher.exe)

## 使用

程序为绿色版，免安装，第一次运行会在程序所在目录下建立一个ini文件，之后如果ini文件无法被找  

到会重新创建一个新的ini文件。**使用开机启动功能时会要求修改注册表，不要担心，修改的注册表项**

**在HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run里。**

## 功能列表

* Space + Keys打开文件
* 添加命令
* 浏览命令
* 开机启动
* 禁用程序
* 当有全屏程序时，SpaceLauncher自动失效

*打字时会有0.6s的延迟识别，这是为了防止误操作，空格按下，0.2s之后才会进行识别，这也是为了*  
*防止打字时的误操作*

## 主要界面截图及说明

### 查看快捷键

![查看快捷键](https://github.com/Jack54s/SpaceLauncher-for-Windows/blob/master/Snap/CommandView.png)

在这个界面你可以查看你添加了哪些快捷键，你可以勾选删除它们，或者Ctrl或Shift选中右键删除。

### 添加快捷键

![添加快捷键](https://github.com/Jack54s/SpaceLauncher-for-Windows/blob/master/Snap/addCommand.png)

你可以为一个文件（文件打开的方式和你电脑的默认方式相同，如果你的电脑不能识别文件，则会让  

你手动选择），文件夹或者URL（网页的浏览器为你的默认浏览器），设置一个快捷键，快捷键必须  

以空格开始<del>（废话啊，我们的程序就叫SpaceLauncher嘛）</del>，另外一个键必须是A-Z,0-9,或者  

, . / ; ' [ ] \\ - =中的一个。

> **目前无法选择Internet快键方式(.url文件)，但是你可以直接查看它的`属性->Web文档`中的URL，将**  

> **它直接复制到URL选项下的文本框中。**  

> *关于URL选项，它有点类似于URL Schemes，比如你可以在URL选项下输入`steam://`，它会打*

> *开steam这个软件，如果你的电脑上没有装steam，那么它会提醒你访问商店以下载*

## 鸣谢

* 程序的icon和窗体标题部分来自于Dota2 卡尔
* 程序的灵感来自于[SpaceLauncher for Mac](https://sspai.com/post/39597)