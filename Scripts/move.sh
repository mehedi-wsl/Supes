#!/bin/bash
echo "Runnnign";
find ./src/src/SupesScrapbook.Contracts/Models -type f -exec sed -i 's|using Newtonsoft.Json;||' {} +;
find ./src/src/SupesScrapbook.Contracts/Models -type f -exec sed -i 's|using SupesScrapbook.Contracts.Converters;||' {} +;
rm -rf ./SupesScrapbook.Contracts/Responses/*
rm -rf ./SupesScrapbook.Contracts/Requests/*
find ./src/src/SupesScrapbook.Contracts/Models -name "*Response*.cs" -type f -exec mv {} ./SupesScrapbook.Contracts/Responses/ \;
find ./src/src/SupesScrapbook.Contracts/Models -name "Error*.cs" -type f -exec mv {} ./SupesScrapbook.Contracts/Responses/ \;

rm -rf ./SupesScrapbook.Contracts/Models
mv ./src/src/SupesScrapbook.Contracts/Models ./SupesScrapbook.Contracts/

rm -rf src
rm -rf .openapi-generator
rm .editorconfig
