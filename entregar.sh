#!/bin/bash

read -p "Enter zip name: " name

if [ -d "$name" ]; then
  echo "$name exists"
else
  echo "$name does not exist"
  exit 1
fi

cd "$name"
zip -r "$name.zip" . -x "bin/*" "obj/*"
mv "$name.zip" ..