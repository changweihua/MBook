cd %SystemRoot%\Microsoft.NET\Framework\v4.0.30319\
installutil.exe MonoBookService.exe
Net Start MBookScheduler
sc config MBookScheduler start= auto
pause