If not "%Jobpath%"=="%Jobpath:resume=%" (
    @REM cd %jobpath% 
    @REM pushd resume_generator
    @REM git add . && git tag "Build #%resume_build%" && git commit -m "%Build commit for #%resume_build%"
    @REM wsl make
    @REM popd
    @REM cd output
    @REM start.
) else (
    echo Please Run this script from Project root direcory.
)