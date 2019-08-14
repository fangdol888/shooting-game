@echo off
:re
set /p name=출력파일 이름:
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc -define:DEBUG -optimize -out:%name%.exe *.cs
pause
%name%
pause

goto re