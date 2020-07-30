#!/usr/bin/python3

from lxml import etree
from sys import argv
from os import path

def insertDoc():
    if len(argv) <= 1:
        return


    root = None
    doc = None
    tag = None
    line = argv[1]

    if argv[1][-1] == '/':
        line = argv[1][0:-1]
        print(line)

    # print(path.basename(line))
    p = path.abspath("./{0}/{0}.csproj".format(line))
    try:
        with open(p, "r") as f:
            parser = etree.XMLParser(remove_blank_text=True)
            try:
                tag = etree.fromstring(f.read(), parser)
            except etree.XMLSyntaxError as e:
                print(e)
                return


            root = tag.find("PropertyGroup").find("TargetFramework")
            print(etree.tostring(root))

            doc = tag.find("PropertyGroup").find("DocumentationFile")
            if doc is not None:
                print("{} as DocumentationFile tag already".format(argv[1]))
                return
    except FileNotFoundError as e:
        print(e)
        return

    
    with open(p, "w") as f:
        doctag = etree.Element("DocumentationFile")
        doctag.text = 'bin\\$(Configuration)\\$(TargetFramework)\\$(AssemblyName).xml'
        root.addnext(doctag)
        try:
            s = etree.tostring(tag, pretty_print = True)
            
            f.write(s.decode('utf-8'))
        except TypeError as e:
            print(etree.tostring(tag, pretty_print = True))
            print(e)
            

if __name__ == "__main__":
    insertDoc()