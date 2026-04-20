#!/bin/bash
rm -rf ./SupesScrapbook.Contracts/Responses/*
rm -rf ./SupesScrapbook.Contracts/Requests/*
find ./src/src/Org.OpenAPITools/Models -name "*Response*.cs" -type f -exec mv {} ./SupesScrapbook.Contracts/Responses/ \;
find ./src/src/Org.OpenAPITools/Models -name "Error*.cs" -type f -exec mv {} ./SupesScrapbook.Contracts/Responses/ \;

rm -rf ./SupesScrapbook.Contracts/Models
mv ./src/src/Org.OpenAPITools/Models ./SupesScrapbook.Contracts/

rm -rf src
rm -rf .openapi-generator
rm .openapi-generator-ignore
rm openapitools.json
