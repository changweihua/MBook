%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\installutil.exe MBookService.exe
Net Start MBookService
sc config MBookService start= auto
pause