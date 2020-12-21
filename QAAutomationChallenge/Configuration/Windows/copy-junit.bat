@echo off
set jhome=%~1
set jobname=%~2
set buildnr=%~3
echo "%jhome%\jobs\%jobname%\builds\%buildnr%\junitResult.xml"
xcopy "%jhome%\jobs\%jobname%\builds\%buildnr%\junitResult.xml" "Test Results\junit\*" /Y
@echo Done Processing!