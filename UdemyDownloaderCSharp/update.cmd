@echo off
title Udemy-dl Windows Updater

echo Updating udemy-dl.exe
echo.
IF EXIST udemy-dl.exe.new (
del udemy-dl.exe.new
)
curl --fail https://raw.githubusercontent.com/nishad/udemy-dl-windows/master/dist/udemy-dl.exe -o udemy-dl.exe.new
IF EXIST udemy-dl.exe.new (
del udemy-dl.exe
ren udemy-dl.exe.new udemy-dl.exe
) ELSE (
echo ERROR : Failed to download latest udemy-dl.exe
)

echo Updating aria2c.exe
echo.
IF EXIST aria2c.exe.new (
del aria2c.exe.new
)
curl --fail https://raw.githubusercontent.com/nishad/udemy-dl-windows/master/dist/aria2c.exe -o aria2c.exe.new
IF EXIST aria2c.exe.new (
del aria2c.exe
ren aria2c.exe.new aria2c.exe
) ELSE (
echo ERROR : Failed to download latest aria2c.exe
)

echo.
echo Updating youtube-dl.exe
IF EXIST youtube-dl.exe.new (
del youtube-dl.exe.new
)
curl --fail https://yt-dl.org/latest/youtube-dl.exe -o youtube-dl.exe.new
IF EXIST youtube-dl.exe.new (
del youtube-dl.exe
ren youtube-dl.exe.new youtube-dl.exe
) ELSE (
echo ERROR : Failed to download latest youtube-dl.exe
)

echo.
echo Updating curl.exe
IF EXIST curl.exe.new (
del curl.exe.new
)
curl --fail https://raw.githubusercontent.com/nishad/udemy-dl-windows/master/dist/curl.exe -o curl.exe.new
IF EXIST curl.exe.new (
del curl.exe
ren curl.exe.new curl.exe
) ELSE (
echo ERROR : Failed to download latest curl.exe
)

echo.
echo Updating ffmpeg.exe
IF EXIST ffmpeg.exe.new (
del ffmpeg.exe.new
)
curl --fail https://raw.githubusercontent.com/nishad/udemy-dl-windows/master/dist/ffmpeg.exe -o ffmpeg.exe.new
IF EXIST ffmpeg.exe.new (
del ffmpeg.exe
ren ffmpeg.exe.new ffmpeg.exe
) ELSE (
echo ERROR : Failed to download latest ffmpeg.exe
)

echo.
echo Updating curl-ca-bundle.crt
IF EXIST curl-ca-bundle.crt.new (
del curl-ca-bundle.crt.new
)
curl --fail https://curl.haxx.se/ca/cacert.pem -o curl-ca-bundle.crt.new
IF EXIST curl-ca-bundle.crt.new (
del curl-ca-bundle.crt
ren curl-ca-bundle.crt.new curl-ca-bundle.crt
) ELSE (
echo ERROR : Failed to download latest curl-ca-bundle.crt
)

echo.
echo Updating cacert.pem
curl --fail https://mkcert.org/generate/ -o cacert.pem.new
IF EXIST cacert.pem.new (
del cacert.pem
ren cacert.pem.new cacert.pem
) ELSE (
echo ERROR : Failed to download latest cacert.pem
)

echo.
echo Updating update.cmd
IF EXIST update.cmd.new (
del update.cmd.new
)
curl --fail https://raw.githubusercontent.com/nishad/udemy-dl-windows/master/dist/update.cmd -o update.cmd.new
IF EXIST update.cmd.new (
del update.cmd
ren update.cmd.new update.cmd
) ELSE (
echo ERROR : Failed to download latest update.cmd
)

echo Update completed
pause
