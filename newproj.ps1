if ($args[0] -eq $null -or $args[0] -eq "" ) {
    echo "prject name is required";
    exit;
}
$name=$args[0]
dotnet new console -f netcoreapp2.1 -n $name
cd ./$name
touch "$name.cs"