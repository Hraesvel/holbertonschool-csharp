#!/usr/bin/python3

from lxml import etree
from sys import argv

def insertDoc():
    if len(argv) <= 1:
        return


    root = None
    doc = None

    line = argv[1]

    if argv[1][-1] == '/':
        line = argv[1][0:-1]
        print(line)

    path = "./{0}/{0}.csproj".format(line)
    try:
        with open(path, "r") as f:
            parser = etree.XMLParser(remove_blank_text=True)
            t = etree.fromstring(f.read(), parser)
            root = t.find("PropertyGroup").find("RootNamespace")
            doc = t.find("PropertyGroup").find("DocumentationFile")
            if doc is not None:
                print("{} as DocumentationFile tag already".format(argv[1]))
                return
    except FileNotFoundError as e:
        print(e)
        return

    
    with open(path, "w") as f:
        doctag = etree.Element("DocumentationFile")
        doctag.text = 'bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml'
        root.addnext(doctag)
        f.write(etree.tostring(t, pretty_print = True))

if __name__ == "__main__":
    insertDoc()