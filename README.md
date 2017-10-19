# SZS-Tool
Compress and decompress SZS files with the Yaz0 compression

## Purpose
Say you want to do some modifications to the ROM of a 3DS game. You have the `.szs` files and you want to extract its contents to modify them. You would use SZS Tool.

### What about Wiimms SZS Tool?
The problem is that [Wiimms SZS Tool](https://szs.wiimm.de/wszst/) (of which I did not make nor is it mine) is for Linux and Mac. It supports Windows, only with Cygwin. SZS Tool (this one) doesn't need Cygwin.

## Compressing
- To compress, put all the files you wish to compress into a `.zip` file. This makes SZS Tool's job easier.
- Select the `.zip`

## Decompressing
- To decompress, select a `.szs` file

## Building
1. Ensure you have .NET Framework 4.5
2. Open the `.sln` in Visual Studio 2010 or later (I use Visual Studio 2012)
3. Go to `Build > Build Solution`
