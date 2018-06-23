call :"%1"
exit /b

:""
    "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.com" GENESTUB.sln /build Release
    exit /b

:"package"
    zip -j GENESTUB.zip readme.md bin\Release\GENESTUB.exe
    exit /b
