# SZS-Tool
Compress and decompress SZS files with the Yaz0 compression

## Compatibility
**FOR USE WITH NINTENDO 3DS GAMES ONLY**. The `.szs` files from a Wii game **will not work**.

## Future plans
- Add support for the following compressions:
  - SARC (Wii)
  - U8 (Wii U)
- Detect what compression a file uses and if it's valid

## Compressing
- To compress, put all the files you wish to compress into a `.zip` file. This makes SZS Tool's job easier.
- Select the `.zip` file

## Decompressing
- To decompress, select a `.szs` file

## Downloads
Go to the [Release pages](https://github.com/theawesomecoder61/SZS-Tool/releases).

## Building
1. Ensure you have .NET Framework 4.5
2. Open the `.sln` in Visual Studio 2010 or later (I use Visual Studio 2012)
3. Go to `Build > Build Solution`

## FAQ
### What about Wiimms SZS Tool?
The problem is that [Wiimms SZS Tool](https://szs.wiimm.de/wszst/) (of which I did not make nor is it mine) is for Linux and Mac. It supports Windows, only with Cygwin. SZS Tool (this one) doesn't need Cygwin. Plus, Wiimms SZS Tool only works with `.szs` from Wii games, not 3DS games.

## Yaz0?
Yaz0 is a compression used by Nintendo in their games from the GameCube to the 3DS. You can read more about the Yaz0 compression on the [Custom Mario Kart Wiki](http://wiki.tockdom.com/wiki/Yaz0).

To see if a `.szs` file is compatible with SZS Tool, make sure the first 4 bytes in the file match `59 61 7A 30` or in ASCII `Yaz0`.
