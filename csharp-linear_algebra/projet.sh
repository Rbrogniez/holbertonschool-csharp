#!/usr/bin/env bash
project_name="$1"
dotnet new console -n "$project_name"
mv "$project_name/Program.cs" "$project_name/$project_name.cs"
cd "$project_name"
dotnet build
