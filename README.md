# SZS-Tool
Compress and decompress SZS files with the Yaz0 compression

## Compatibility
**FOR USE WITH NINTENDO 3DS GAMES ONLY**. The `.szs` files from a Wii game **will not work**.

## Future plans
- Add support for the following compressions (and an example of a game that uses that compression):
  - NARC (3DS)
    - Super Mario 3D Land
  - RARC (GameCube, Wii)
    - Super Mario Galaxy
  - SARC (Wii)
    - New Super Mario Bros. Wii
  - U8 (Wii U)
    - Mario Kart 8
- Detect what compression a file uses and if it's valid
- Add support for `.arc`, `.carc`, `.narc` and `.sarc`
- Rename the project to "Nintendo Archive Tool"
- Clean up UI & code

## Compressing
- To compress, put all the files you wish to compress into a `.zip` file. This makes SZS Tool's job easier.
- Select the `.zip` file

## Decompressing
- To decompress, select a supported file
- Next, choose a folder to export to

## Downloads
Go to the [Release pages](https://github.com/theawesomecoder61/SZS-Tool/releases).

## Building
1. Ensure you have .NET Framework 4.5
2. Open the `.sln` in Visual Studio 2010 or later (I use Visual Studio 2012)
3. Go to `Build > Build Solution`

## FAQ
### What about Wiimms SZS Tool?
The problem is that [Wiimms SZS Tool](https://szs.wiimm.de/wszst/) (of which I did not make nor is it mine) is for Linux and Mac. It supports Windows, only with Cygwin. SZS Tool (this one) doesn't need Cygwin. Plus, Wiimms SZS Tool only works with `.szs` from Wii games, not GameCube, 3DS and Wii U games as this SZS Tool supports.
