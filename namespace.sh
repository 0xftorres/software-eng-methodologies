#!/bin/bash

OLD_NAMESPACE="$1"
NEW_NAMESPACE="$2"
DIRECTORY="$3"

if [ -z "$OLD_NAMESPACE" ] || [ -z "$NEW_NAMESPACE" ] || [ -z "$DIRECTORY" ]; then
  echo "Uso: $0 <namespace_viejo> <namespace_nuevo> <directorio_nuevo>"
  exit 1
fi

# Escapar puntos para sed
OLD_ESCAPED=$(printf '%s\n' "$OLD_NAMESPACE" | sed 's/\./\\./g')
NEW_ESCAPED=$(printf '%s\n' "$NEW_NAMESPACE" | sed 's/\./\\./g')

cd "$DIRECTORY"
find . -type f -name "*.cs" -exec sed -i "s/namespace $OLD_ESCAPED/namespace $NEW_ESCAPED/g" {} +

echo "Reemplazo completo: $OLD_NAMESPACE -> $NEW_NAMESPACE"