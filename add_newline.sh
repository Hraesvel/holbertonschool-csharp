#!/bin/bash
if [ -z "$(tail -c 1 "$1")" ]
then
    echo "Newline at end of file!"
    exit 1
else
    echo "No newline at end of file!"
    sed -i -e '$a\' $1
    exit 0
fi
