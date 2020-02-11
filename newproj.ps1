if ($args[0] -eq $null -or $args[0] -eq "" ) {
    echo "prject name is required";
    exit;
}
$name=$args[0]
dotnet new console -f netcoreapp2.1 -n $name
cd ./$name
mv "Program.cs" "main.cs"
powershell -c "[io.file]::WriteAllText('$name.cs','',[System.Text.Encoding]::UTF8)"
cd ..