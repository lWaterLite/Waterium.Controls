# 确保 7-Zip 已安装，并且 7z.exe 的路径已添加到系统的 PATH 环境变量中

# 设置压缩文件名和目标路径
$archiveName1 = "Waterium.Controls.Window.dll.7z"
$sourcePath1 = "bin/Release/net8.0-windows"
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Definition

# 第一个压缩操作：压缩 bin/Release/net8.0-windows 下的所有文件
Set-Location "$scriptPath\$sourcePath1"
& "7z.exe" a "$archiveName1" *

# 切换回脚本所在目录
Set-Location $scriptPath

# 脚本完成
Write-Host "Compression complete."
