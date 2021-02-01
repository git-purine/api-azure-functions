#!/bin/bash

# waiting mount
sleep 15s

for filepath in `ls /docker-entrypoint-initdb.d/*.sql`
do
  echo "import: $filepath"
  /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "$SA_PASSWORD" -i $filepath
done
